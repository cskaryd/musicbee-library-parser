using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace MusicBeeReader
{
  public partial class Form1 : Form
  {
    private System.IO.FileStream MusicBeeLibrary;

    protected class MBLibrary
    {
      public Int32 LibraryFileCount { get; set; } // 8 bytes
      public List<LibraryEntry> Files { get; set; }
    }

    protected class LibraryEntry
    {
      public byte FileDesignation { get; set; }  // 1 byte  / byte
      public byte Status { get; set; }           // 1 byte  / byte
      public byte Unknown { get; set; }          // 1 byte  / byte
      public UInt16 PlayCount { get; set; }      // 2 bytes / uint16
      public Int64 DateLastPlayed { get; set; }  // 8 bytes / int64

      public DateTime? dlp
      {
        get
        {
          try { return new DateTime(DateLastPlayed); }
          catch { return null; }
        }
      }

      public UInt16 SkipCount { get; set; }      // 2 bytes / uint16
      public string FilePath { get; set; }       // n bytes / string
      public Int32 FileSize { get; set; }        // 4 bytes / int32
      public Int32 SampleRate { get; set; }      // 4 bytes / int32
      public byte ChannelIndicator { get; set; } // 1 byte  / byte
      public byte BitrateType { get; set; }      // 1 byte  / byte
      public Int16 Bitrate { get; set; }         // 2 bytes / int16
      public Int32 TrackLengthMS { get; set; }   // 4 bytes / int32

      public double TrackLength
      {
        get
        {
          return (double)TrackLengthMS / 1000;
        }
      }

      public Int64 DateAdded { get; set; }       // 8 bytes / int64

      public DateTime? da
      {
        get
        {
          try { return new DateTime(DateAdded); }
          catch { return null; }
        }
      }

      public Int64 DateModified { get; set; }    // 8 bytes / int64

      public DateTime? dm
      {
        get
        {
          try { return new DateTime(DateModified); }
          catch { return null; }
        }
      }

      public byte TagType { get; set; }          // 1 byte  / byte
      public List<Tuple<byte, string>> Tags { get; set; }
      public List<LibraryCueSheetTag> CueData { get; set; }
      public List<LibraryArtwork> Artwork { get; set; }
    }

    protected class LibraryArtwork
    {
      public byte ArtType { get; set; }       // 1 byte  / byte
      public string ArtData { get; set; }     // n bytes / string
      public byte StorageMode { get; set; }   // 1 byte  / byte
      public string StorageData { get; set; } // n bytes / string
    }

    protected class LibraryCueSheetTag
    {
      public byte SheetId { get; set; } // 1 byte  / byte
      public UInt16 Part1 { get; set; } // 2 bytes / string
      public Int64 Part2 { get; set; }  // 8 byte  / byte
      public UInt16 Part3 { get; set; } // 2 bytes / string
    }

    public Form1()
    {
      InitializeComponent();
    }

    private byte[] ReadBytesToArray(int Length)
    {
      var data = new Span<byte>(new byte[Length]);

      MusicBeeLibrary.Read(data);

      return data.ToArray();
    }

    private string ReadStringFromBytes()
    {
      var len = MusicBeeLibrary.ReadByte();
      var strBytes = ReadBytesToArray(len);

      return Encoding.Default.GetString(strBytes);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MusicBeeLibrary = System.IO.File.Open(".\\MusicBeeLibrary.mbl", System.IO.FileMode.Open);

      var mbl = new MBLibrary();

      mbl.LibraryFileCount = BitConverter.ToInt32(ReadBytesToArray(4)) >> 8;
      mbl.Files = new List<LibraryEntry>();

      while (true)
      {
        var le = new LibraryEntry();

        le.FileDesignation = ReadBytesToArray(1)[0];

        if (le.FileDesignation == 1)
          break;

        if (10 > le.FileDesignation && le.FileDesignation > 1)
        {
          le.Status = ReadBytesToArray(1)[0];

          if (le.Status > 6)
            throw new Exception("Bad status");

          le.Artwork = new List<LibraryArtwork>();
          le.CueData = new List<LibraryCueSheetTag>();

          le.Unknown = ReadBytesToArray(1)[0];
          le.PlayCount = BitConverter.ToUInt16(ReadBytesToArray(2));

          var dateBytes = ReadBytesToArray(8);

          dateBytes[7] = 8;
          le.DateLastPlayed = BitConverter.ToInt64(dateBytes);

          le.SkipCount = BitConverter.ToUInt16(ReadBytesToArray(2));
          le.FilePath = ReadStringFromBytes();
          le.FileSize = BitConverter.ToInt32(ReadBytesToArray(4));
          le.SampleRate = BitConverter.ToInt32(ReadBytesToArray(4));
          le.ChannelIndicator = ReadBytesToArray(1)[0];
          le.BitrateType = ReadBytesToArray(1)[0];
          le.Bitrate = BitConverter.ToInt16(ReadBytesToArray(2));
          le.TrackLengthMS = BitConverter.ToInt32(ReadBytesToArray(4));

          dateBytes = ReadBytesToArray(8);

          dateBytes[7] = 8;
          le.DateAdded = BitConverter.ToInt64(dateBytes);

          dateBytes = ReadBytesToArray(8);

          dateBytes[7] = 8;
          le.DateModified = BitConverter.ToInt64(dateBytes);

          Debug.WriteLine(le.FilePath);

          while (true)
          {
            var artType = ReadBytesToArray(1)[0];

            if (artType > 253)
              break;

            var art = new LibraryArtwork();

            art.ArtType = artType;
            art.ArtData = ReadStringFromBytes();
            art.StorageMode = ReadBytesToArray(1)[0];
            art.StorageData = ReadStringFromBytes();

            le.Artwork.Add(art);
          }

          le.TagType = ReadBytesToArray(1)[0];
          le.Tags = new List<Tuple<byte, string>>();

          while (true)
          {
            var tagCode = ReadBytesToArray(1)[0];

            if (tagCode == 0)
              break;

            if (tagCode == 255)
            {
              var c = BitConverter.ToInt16(ReadBytesToArray(2));
              var i = 0;

              while (i < c)
              {
                var cst = new LibraryCueSheetTag();

                cst.SheetId = ReadBytesToArray(1)[0];
                cst.Part1 = BitConverter.ToUInt16(ReadBytesToArray(2));
                cst.Part2 = BitConverter.ToInt64(ReadBytesToArray(8));
                cst.Part3 = BitConverter.ToUInt16(ReadBytesToArray(2));

                le.CueData.Add(cst);
                i += 1;
              }

              break;
            }

            le.Tags.Add(new Tuple<byte, string>(tagCode, ReadStringFromBytes()));
          }

          mbl.Files.Add(le);
        }
      }

      MusicBeeLibrary.Close();
      MusicBeeLibrary.Dispose();
      MusicBeeLibrary = null;

      using (var mblJson = System.IO.File.CreateText(".\\MusicBeeLibrary_test.json"))
      {
        mblJson.Write(mblJson);
        mblJson.Close();
      }
    }
  }
}