namespace MusicBeeReader
{
  partial class frmMBLViewer
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Button btnExport;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.Button btnOpen;
    private System.Windows.Forms.Button btnPrev;
    private System.Windows.Forms.OpenFileDialog dlgOpen;
    private System.Windows.Forms.Label lblDateAdded;
    private System.Windows.Forms.Label lblDateModified;
    private System.Windows.Forms.Label lblLastPlayed;
    private System.Windows.Forms.Label lblLine;
    private System.Windows.Forms.Label lblNumTracks;
    private System.Windows.Forms.Label lblPath;
    private System.Windows.Forms.Label lblPlayCount;
    private System.Windows.Forms.Label lblSample;
    private System.Windows.Forms.Label lblTrackLength;
    private System.Windows.Forms.Label lblXofY;
    private System.Windows.Forms.TextBox txtDateAdded;
    private System.Windows.Forms.TextBox txtDateModified;
    private System.Windows.Forms.TextBox txtLastPlayed;
    private System.Windows.Forms.TextBox txtNumTracks;
    private System.Windows.Forms.TextBox txtPath;
    private System.Windows.Forms.TextBox txtPlayCount;
    private System.Windows.Forms.TextBox txtSample;
    private System.Windows.Forms.TextBox txtTrackLength;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
        components.Dispose();

      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      btnNext = new System.Windows.Forms.Button();
      lblNumTracks = new System.Windows.Forms.Label();
      txtNumTracks = new System.Windows.Forms.TextBox();
      btnOpen = new System.Windows.Forms.Button();
      dlgOpen = new System.Windows.Forms.OpenFileDialog();
      lblPath = new System.Windows.Forms.Label();
      lblLine = new System.Windows.Forms.Label();
      txtPath = new System.Windows.Forms.TextBox();
      lblDateAdded = new System.Windows.Forms.Label();
      txtDateAdded = new System.Windows.Forms.TextBox();
      lblDateModified = new System.Windows.Forms.Label();
      txtDateModified = new System.Windows.Forms.TextBox();
      lblLastPlayed = new System.Windows.Forms.Label();
      txtLastPlayed = new System.Windows.Forms.TextBox();
      btnPrev = new System.Windows.Forms.Button();
      btnClose = new System.Windows.Forms.Button();
      lblXofY = new System.Windows.Forms.Label();
      lblSample = new System.Windows.Forms.Label();
      txtSample = new System.Windows.Forms.TextBox();
      lblPlayCount = new System.Windows.Forms.Label();
      txtPlayCount = new System.Windows.Forms.TextBox();
      lblTrackLength = new System.Windows.Forms.Label();
      txtTrackLength = new System.Windows.Forms.TextBox();
      btnExport = new System.Windows.Forms.Button();
      SuspendLayout();
      // 
      // btnNext
      // 
      btnNext.Enabled = false;
      btnNext.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      btnNext.Location = new System.Drawing.Point(395, 264);
      btnNext.Name = "btnNext";
      btnNext.Size = new System.Drawing.Size(75, 23);
      btnNext.TabIndex = 21;
      btnNext.Text = "Next ►";
      btnNext.UseVisualStyleBackColor = true;
      btnNext.Click += btnNext_Click;
      // 
      // lblNumTracks
      // 
      lblNumTracks.AutoSize = true;
      lblNumTracks.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      lblNumTracks.Location = new System.Drawing.Point(138, 16);
      lblNumTracks.Name = "lblNumTracks";
      lblNumTracks.Size = new System.Drawing.Size(104, 14);
      lblNumTracks.TabIndex = 2;
      lblNumTracks.Text = "Number Of Tracks:";
      // 
      // txtNumTracks
      // 
      txtNumTracks.Location = new System.Drawing.Point(249, 13);
      txtNumTracks.Name = "txtNumTracks";
      txtNumTracks.ReadOnly = true;
      txtNumTracks.Size = new System.Drawing.Size(100, 23);
      txtNumTracks.TabIndex = 3;
      // 
      // btnOpen
      // 
      btnOpen.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      btnOpen.Location = new System.Drawing.Point(12, 12);
      btnOpen.Name = "btnOpen";
      btnOpen.Size = new System.Drawing.Size(85, 23);
      btnOpen.TabIndex = 0;
      btnOpen.Text = "Open MBL";
      btnOpen.UseVisualStyleBackColor = true;
      btnOpen.Click += btnOpen_Click;
      // 
      // dlgOpen
      // 
      dlgOpen.FileName = "openFileDialog1";
      // 
      // lblPath
      // 
      lblPath.AutoSize = true;
      lblPath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      lblPath.Location = new System.Drawing.Point(12, 64);
      lblPath.Name = "lblPath";
      lblPath.Size = new System.Drawing.Size(55, 14);
      lblPath.TabIndex = 5;
      lblPath.Text = "File Path";
      // 
      // lblLine
      // 
      lblLine.BackColor = System.Drawing.Color.Black;
      lblLine.Location = new System.Drawing.Point(15, 49);
      lblLine.Name = "lblLine";
      lblLine.Size = new System.Drawing.Size(455, 1);
      lblLine.TabIndex = 4;
      lblLine.Text = "label3";
      // 
      // txtPath
      // 
      txtPath.Location = new System.Drawing.Point(111, 61);
      txtPath.Name = "txtPath";
      txtPath.ReadOnly = true;
      txtPath.Size = new System.Drawing.Size(359, 23);
      txtPath.TabIndex = 6;
      // 
      // lblDateAdded
      // 
      lblDateAdded.AutoSize = true;
      lblDateAdded.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      lblDateAdded.Location = new System.Drawing.Point(13, 180);
      lblDateAdded.Name = "lblDateAdded";
      lblDateAdded.Size = new System.Drawing.Size(71, 14);
      lblDateAdded.TabIndex = 13;
      lblDateAdded.Text = "Date Added";
      // 
      // txtDateAdded
      // 
      txtDateAdded.Location = new System.Drawing.Point(112, 177);
      txtDateAdded.Name = "txtDateAdded";
      txtDateAdded.ReadOnly = true;
      txtDateAdded.Size = new System.Drawing.Size(358, 23);
      txtDateAdded.TabIndex = 14;
      // 
      // lblDateModified
      // 
      lblDateModified.AutoSize = true;
      lblDateModified.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      lblDateModified.Location = new System.Drawing.Point(13, 209);
      lblDateModified.Name = "lblDateModified";
      lblDateModified.Size = new System.Drawing.Size(84, 14);
      lblDateModified.TabIndex = 15;
      lblDateModified.Text = "Date Modified";
      // 
      // txtDateModified
      // 
      txtDateModified.Location = new System.Drawing.Point(112, 206);
      txtDateModified.Name = "txtDateModified";
      txtDateModified.ReadOnly = true;
      txtDateModified.Size = new System.Drawing.Size(358, 23);
      txtDateModified.TabIndex = 16;
      // 
      // lblLastPlayed
      // 
      lblLastPlayed.AutoSize = true;
      lblLastPlayed.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      lblLastPlayed.Location = new System.Drawing.Point(13, 238);
      lblLastPlayed.Name = "lblLastPlayed";
      lblLastPlayed.Size = new System.Drawing.Size(68, 14);
      lblLastPlayed.TabIndex = 17;
      lblLastPlayed.Text = "Last Played";
      // 
      // txtLastPlayed
      // 
      txtLastPlayed.Location = new System.Drawing.Point(112, 235);
      txtLastPlayed.Name = "txtLastPlayed";
      txtLastPlayed.ReadOnly = true;
      txtLastPlayed.Size = new System.Drawing.Size(358, 23);
      txtLastPlayed.TabIndex = 18;
      // 
      // btnPrev
      // 
      btnPrev.Enabled = false;
      btnPrev.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      btnPrev.Location = new System.Drawing.Point(314, 264);
      btnPrev.Name = "btnPrev";
      btnPrev.Size = new System.Drawing.Size(75, 23);
      btnPrev.TabIndex = 20;
      btnPrev.Text = "◄ Prev";
      btnPrev.UseVisualStyleBackColor = true;
      btnPrev.Click += btnPrev_Click;
      // 
      // btnClose
      // 
      btnClose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      btnClose.Location = new System.Drawing.Point(12, 11);
      btnClose.Name = "btnClose";
      btnClose.Size = new System.Drawing.Size(75, 23);
      btnClose.TabIndex = 9;
      btnClose.Text = "Close MBL";
      btnClose.UseVisualStyleBackColor = true;
      btnClose.Click += btnClose_Click;
      // 
      // lblXofY
      // 
      lblXofY.AutoSize = true;
      lblXofY.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      lblXofY.Location = new System.Drawing.Point(15, 273);
      lblXofY.Name = "lblXofY";
      lblXofY.Size = new System.Drawing.Size(66, 14);
      lblXofY.TabIndex = 19;
      lblXofY.Text = "Track Y of Y";
      // 
      // lblSample
      // 
      lblSample.AutoSize = true;
      lblSample.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      lblSample.Location = new System.Drawing.Point(13, 93);
      lblSample.Name = "lblSample";
      lblSample.Size = new System.Drawing.Size(76, 14);
      lblSample.TabIndex = 7;
      lblSample.Text = "Sample Rate";
      // 
      // txtSample
      // 
      txtSample.Location = new System.Drawing.Point(112, 90);
      txtSample.Name = "txtSample";
      txtSample.ReadOnly = true;
      txtSample.Size = new System.Drawing.Size(358, 23);
      txtSample.TabIndex = 8;
      // 
      // lblPlayCount
      // 
      lblPlayCount.AutoSize = true;
      lblPlayCount.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      lblPlayCount.Location = new System.Drawing.Point(13, 122);
      lblPlayCount.Name = "lblPlayCount";
      lblPlayCount.Size = new System.Drawing.Size(63, 14);
      lblPlayCount.TabIndex = 9;
      lblPlayCount.Text = "Play Count";
      // 
      // txtPlayCount
      // 
      txtPlayCount.Location = new System.Drawing.Point(112, 119);
      txtPlayCount.Name = "txtPlayCount";
      txtPlayCount.ReadOnly = true;
      txtPlayCount.Size = new System.Drawing.Size(358, 23);
      txtPlayCount.TabIndex = 10;
      // 
      // lblTrackLength
      // 
      lblTrackLength.AutoSize = true;
      lblTrackLength.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      lblTrackLength.Location = new System.Drawing.Point(13, 151);
      lblTrackLength.Name = "lblTrackLength";
      lblTrackLength.Size = new System.Drawing.Size(73, 14);
      lblTrackLength.TabIndex = 11;
      lblTrackLength.Text = "Track Length";
      // 
      // txtTrackLength
      // 
      txtTrackLength.Location = new System.Drawing.Point(112, 148);
      txtTrackLength.Name = "txtTrackLength";
      txtTrackLength.ReadOnly = true;
      txtTrackLength.Size = new System.Drawing.Size(358, 23);
      txtTrackLength.TabIndex = 12;
      // 
      // btnExport
      // 
      btnExport.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      btnExport.Location = new System.Drawing.Point(381, 13);
      btnExport.Name = "btnExport";
      btnExport.Size = new System.Drawing.Size(89, 23);
      btnExport.TabIndex = 1;
      btnExport.Text = "Export M3U";
      btnExport.UseVisualStyleBackColor = true;
      btnExport.Click += btnExport_Click;
      // 
      // frmMBLViewer
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(480, 303);
      Controls.Add(btnPrev);
      Controls.Add(txtLastPlayed);
      Controls.Add(txtDateModified);
      Controls.Add(txtTrackLength);
      Controls.Add(txtPlayCount);
      Controls.Add(txtSample);
      Controls.Add(lblTrackLength);
      Controls.Add(txtDateAdded);
      Controls.Add(lblPlayCount);
      Controls.Add(lblLastPlayed);
      Controls.Add(lblSample);
      Controls.Add(lblDateModified);
      Controls.Add(lblDateAdded);
      Controls.Add(txtPath);
      Controls.Add(lblLine);
      Controls.Add(lblPath);
      Controls.Add(btnExport);
      Controls.Add(btnOpen);
      Controls.Add(txtNumTracks);
      Controls.Add(lblXofY);
      Controls.Add(lblNumTracks);
      Controls.Add(btnNext);
      Controls.Add(btnClose);
      Name = "frmMBLViewer";
      Text = "MusicBee Library Parser";
      FormClosing += frmMBLViewer_FormClosing;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
  }
}