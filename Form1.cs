using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace MusicBeeReader
{
  public partial class frmMBLViewer : Form
  {
    private System.IO.FileStream MusicBeeLibrary;
    private MBLibrary LibraryData;
    private int CurrentTrackNo = 0;
    private Dictionary<int, long> TrackPositions;

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
          try { return DateLastPlayed == 0 ? null : new DateTime(DateLastPlayed); }
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

      public DateTime da
      {
        get
        {
          return new DateTime(DateAdded);
        }
      }

      public Int64 DateModified { get; set; }    // 8 bytes / int64

      public DateTime dm
      {
        get
        {
          return new DateTime(DateModified);
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

    public frmMBLViewer()
    {
      InitializeComponent();
    }

    private int DecodeFrom7Bytes(int[] Values)
    {
      int i = 0;
      int result = 0;

      foreach (int val in Values)
      {
        result |= (val & 0x7f) << (7 * i);
        i++;

        if ((val & 0x80) == 0)
          break;
      }

      return result;
    }

    private byte[] ReadBytesToArray(int Length)
    {
      var data = new Span<byte>(new byte[Length]);

      MusicBeeLibrary.Read(data);

      return data.ToArray();
    }

    private string ReadStringFromBytes()
    {
      int length;
      int len_1 = ReadBytesToArray(1)[0];

      if (len_1 > 0x7F)
      {
        int len_2 = ReadBytesToArray(1)[0];

        if (len_2 > 0x7F)
          length = DecodeFrom7Bytes(new int[] { len_1, len_2, ReadBytesToArray(1)[0] });
        else
          length = DecodeFrom7Bytes(new int[] { len_1, len_2 });
      }
      else
        length = len_1;

      if (length == 0)
        return "";

      var strBytes = ReadBytesToArray(length);

      return Encoding.Default.GetString(strBytes);
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
      CurrentTrackNo++;

      if (!TrackPositions.ContainsKey(CurrentTrackNo))
        TrackPositions.Add(CurrentTrackNo, MusicBeeLibrary.Position);

      GetTrack();
    }

    private void btnPrev_Click(object sender, EventArgs e)
    {
      CurrentTrackNo--;
      MusicBeeLibrary.Position = TrackPositions[CurrentTrackNo];
      GetTrack();
    }

    private void DisplayTrack(LibraryEntry le)
    {
      LibraryData.Files.Add(le);

      txtPath.Text = le.FilePath;

      if (le.dlp.HasValue)
        txtLastPlayed.Text = le.dlp.Value.ToString("yyyy-MM-dd hh:mm:ss");
      else
        txtLastPlayed.Text = "";

      txtDateAdded.Text = le.da.ToString("yyyy-MM-dd hh:mm:ss");
      txtDateModified.Text = le.dm.ToString("yyyy-MM-dd hh:mm:ss");

      txtSample.Text = le.SampleRate.ToString();
      txtTrackLength.Text = le.TrackLength.ToString();
      txtPlayCount.Text = le.PlayCount.ToString();

      lblXofY.Text = string.Format("{0} of {1}", CurrentTrackNo, txtNumTracks.Text);
    }

    private LibraryEntry GetTrack()
    {
      var le = new LibraryEntry();

      le.FileDesignation = ReadBytesToArray(1)[0];

      if (le.FileDesignation == 1)
        return null; // FIXME - Log something here

      if (10 > le.FileDesignation && le.FileDesignation > 1)
      {
        le.Status = ReadBytesToArray(1)[0];

        if (le.Status > 6)
          throw new Exception("Bad status");

        le.Artwork = new List<LibraryArtwork>();
        le.CueData = new List<LibraryCueSheetTag>();

        le.Unknown = ReadBytesToArray(1)[0];
        le.PlayCount = BitConverter.ToUInt16(ReadBytesToArray(2));

        var hasValue = false;
        var dateBytes = ReadBytesToArray(8);

        foreach (var b in dateBytes)
          if (b != 0)
            hasValue = true;

        if (hasValue)
        {
          dateBytes[7] = 8;
          le.DateLastPlayed = BitConverter.ToInt64(dateBytes);
        }
        else
          le.DateLastPlayed = 0;

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

        //Debug.WriteLine(le.FilePath);

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
      }

      return le;
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;

      MusicBeeLibrary = System.IO.File.Open("..\\..\\..\\MusicBeeLibrary.mbl", System.IO.FileMode.Open);

      LibraryData = new MBLibrary();
      LibraryData.Files = new List<LibraryEntry>();
      LibraryData.LibraryFileCount = BitConverter.ToInt32(ReadBytesToArray(4)) >> 8;
      txtNumTracks.Text = LibraryData.LibraryFileCount.ToString("#,###");

      var allTracks = "";

      for (int i = 0; i < LibraryData.LibraryFileCount - 1; i++)
      {
        var le = GetTrack();

        allTracks = string.Format("{0}\r\n{1}", allTracks, le.FilePath);
        lblXofY.Text = string.Format("{0} of {1}", (i + 1).ToString("#,##0"), LibraryData.LibraryFileCount.ToString("#,##0"));
        Application.DoEvents();
      }

      Debug.WriteLine(allTracks);
      this.Cursor = Cursors.Default;
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
      //dlgOpen.Filter = "*.mbl";
      //dlgOpen.ShowDialog();

      MusicBeeLibrary = System.IO.File.Open(".\\MusicBeeLibrary.mbl", System.IO.FileMode.Open);

      LibraryData = new MBLibrary();
      LibraryData.Files = new List<LibraryEntry>();
      LibraryData.LibraryFileCount = BitConverter.ToInt32(ReadBytesToArray(4)) >> 8;
      txtNumTracks.Text = LibraryData.LibraryFileCount.ToString("#,###");

      btnClose.BringToFront();
      btnOpen.SendToBack();

      CurrentTrackNo = 0;
      TrackPositions = new Dictionary<int, long>();

      DisplayTrack(GetTrack());

      btnNext.Enabled = true;
      btnPrev.Enabled = true;
    }

    private void frmMBLViewer_FormClosing(object sender, FormClosingEventArgs e)
    {
      CloseMBL();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      CloseMBL();

      btnClose.SendToBack();
      btnOpen.BringToFront();

      txtPath.Text = "";
      txtLastPlayed.Text = "";
      txtDateAdded.Text = "";
      txtDateModified.Text = "";
      txtSample.Text = "";
      lblXofY.Text = "";
      txtNumTracks.Text = "";
      txtTrackLength.Text = "";
      txtPlayCount.Text = "";

      btnNext.Enabled = false;
      btnPrev.Enabled = false;
    }

    private void CloseMBL()
    {
      TrackPositions = null;
      LibraryData.Files = null;
      LibraryData = null;

      if (MusicBeeLibrary != null)
      {
        MusicBeeLibrary.Close();
        MusicBeeLibrary.Dispose();
        MusicBeeLibrary = null;
      }

      btnClose.SendToBack();
      btnOpen.BringToFront();
    }
  }
}