namespace MusicBeeReader
{
  partial class frmMBLViewer
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
      this.btnNext = new System.Windows.Forms.Button();
      this.lblNumTracks = new System.Windows.Forms.Label();
      this.txtNumTracks = new System.Windows.Forms.TextBox();
      this.btnOpen = new System.Windows.Forms.Button();
      this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
      this.lblPath = new System.Windows.Forms.Label();
      this.lblLine = new System.Windows.Forms.Label();
      this.txtPath = new System.Windows.Forms.TextBox();
      this.lblDateAdded = new System.Windows.Forms.Label();
      this.txtDateAdded = new System.Windows.Forms.TextBox();
      this.lblDateModified = new System.Windows.Forms.Label();
      this.txtDateModified = new System.Windows.Forms.TextBox();
      this.lblLastPlayed = new System.Windows.Forms.Label();
      this.txtLastPlayed = new System.Windows.Forms.TextBox();
      this.btnPrev = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.lblXofY = new System.Windows.Forms.Label();
      this.lblSample = new System.Windows.Forms.Label();
      this.txtSample = new System.Windows.Forms.TextBox();
      this.lblPlayCount = new System.Windows.Forms.Label();
      this.txtPlayCount = new System.Windows.Forms.TextBox();
      this.lblTrackLength = new System.Windows.Forms.Label();
      this.txtTrackLength = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnNext
      // 
      this.btnNext.Enabled = false;
      this.btnNext.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnNext.Location = new System.Drawing.Point(395, 264);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(75, 23);
      this.btnNext.TabIndex = 0;
      this.btnNext.Text = "Next ►";
      this.btnNext.UseVisualStyleBackColor = true;
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // lblNumTracks
      // 
      this.lblNumTracks.AutoSize = true;
      this.lblNumTracks.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblNumTracks.Location = new System.Drawing.Point(138, 16);
      this.lblNumTracks.Name = "lblNumTracks";
      this.lblNumTracks.Size = new System.Drawing.Size(104, 14);
      this.lblNumTracks.TabIndex = 1;
      this.lblNumTracks.Text = "Number Of Tracks:";
      // 
      // txtNumTracks
      // 
      this.txtNumTracks.Location = new System.Drawing.Point(249, 13);
      this.txtNumTracks.Name = "txtNumTracks";
      this.txtNumTracks.ReadOnly = true;
      this.txtNumTracks.Size = new System.Drawing.Size(100, 23);
      this.txtNumTracks.TabIndex = 2;
      // 
      // btnOpen
      // 
      this.btnOpen.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnOpen.Location = new System.Drawing.Point(12, 12);
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(75, 23);
      this.btnOpen.TabIndex = 3;
      this.btnOpen.Text = "Open MBL";
      this.btnOpen.UseVisualStyleBackColor = true;
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // dlgOpen
      // 
      this.dlgOpen.FileName = "openFileDialog1";
      // 
      // lblPath
      // 
      this.lblPath.AutoSize = true;
      this.lblPath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblPath.Location = new System.Drawing.Point(12, 64);
      this.lblPath.Name = "lblPath";
      this.lblPath.Size = new System.Drawing.Size(55, 14);
      this.lblPath.TabIndex = 4;
      this.lblPath.Text = "File Path";
      // 
      // lblLine
      // 
      this.lblLine.BackColor = System.Drawing.Color.Black;
      this.lblLine.Location = new System.Drawing.Point(15, 49);
      this.lblLine.Name = "lblLine";
      this.lblLine.Size = new System.Drawing.Size(455, 1);
      this.lblLine.TabIndex = 5;
      this.lblLine.Text = "label3";
      // 
      // txtPath
      // 
      this.txtPath.Location = new System.Drawing.Point(111, 61);
      this.txtPath.Name = "txtPath";
      this.txtPath.ReadOnly = true;
      this.txtPath.Size = new System.Drawing.Size(359, 23);
      this.txtPath.TabIndex = 6;
      // 
      // lblDateAdded
      // 
      this.lblDateAdded.AutoSize = true;
      this.lblDateAdded.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblDateAdded.Location = new System.Drawing.Point(13, 180);
      this.lblDateAdded.Name = "lblDateAdded";
      this.lblDateAdded.Size = new System.Drawing.Size(71, 14);
      this.lblDateAdded.TabIndex = 4;
      this.lblDateAdded.Text = "Date Added";
      // 
      // txtDateAdded
      // 
      this.txtDateAdded.Location = new System.Drawing.Point(112, 177);
      this.txtDateAdded.Name = "txtDateAdded";
      this.txtDateAdded.ReadOnly = true;
      this.txtDateAdded.Size = new System.Drawing.Size(358, 23);
      this.txtDateAdded.TabIndex = 6;
      // 
      // lblDateModified
      // 
      this.lblDateModified.AutoSize = true;
      this.lblDateModified.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblDateModified.Location = new System.Drawing.Point(13, 209);
      this.lblDateModified.Name = "lblDateModified";
      this.lblDateModified.Size = new System.Drawing.Size(84, 14);
      this.lblDateModified.TabIndex = 4;
      this.lblDateModified.Text = "Date Modified";
      // 
      // txtDateModified
      // 
      this.txtDateModified.Location = new System.Drawing.Point(112, 206);
      this.txtDateModified.Name = "txtDateModified";
      this.txtDateModified.ReadOnly = true;
      this.txtDateModified.Size = new System.Drawing.Size(358, 23);
      this.txtDateModified.TabIndex = 6;
      // 
      // lblLastPlayed
      // 
      this.lblLastPlayed.AutoSize = true;
      this.lblLastPlayed.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblLastPlayed.Location = new System.Drawing.Point(13, 238);
      this.lblLastPlayed.Name = "lblLastPlayed";
      this.lblLastPlayed.Size = new System.Drawing.Size(68, 14);
      this.lblLastPlayed.TabIndex = 4;
      this.lblLastPlayed.Text = "Last Played";
      // 
      // txtLastPlayed
      // 
      this.txtLastPlayed.Location = new System.Drawing.Point(112, 235);
      this.txtLastPlayed.Name = "txtLastPlayed";
      this.txtLastPlayed.ReadOnly = true;
      this.txtLastPlayed.Size = new System.Drawing.Size(358, 23);
      this.txtLastPlayed.TabIndex = 6;
      // 
      // btnPrev
      // 
      this.btnPrev.Enabled = false;
      this.btnPrev.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnPrev.Location = new System.Drawing.Point(314, 264);
      this.btnPrev.Name = "btnPrev";
      this.btnPrev.Size = new System.Drawing.Size(75, 23);
      this.btnPrev.TabIndex = 8;
      this.btnPrev.Text = "◄ Prev";
      this.btnPrev.UseVisualStyleBackColor = true;
      this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnClose.Location = new System.Drawing.Point(12, 11);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 9;
      this.btnClose.Text = "Close MBL";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // lblXofY
      // 
      this.lblXofY.AutoSize = true;
      this.lblXofY.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblXofY.Location = new System.Drawing.Point(15, 273);
      this.lblXofY.Name = "lblXofY";
      this.lblXofY.Size = new System.Drawing.Size(66, 14);
      this.lblXofY.TabIndex = 1;
      this.lblXofY.Text = "Track Y of Y";
      // 
      // lblSample
      // 
      this.lblSample.AutoSize = true;
      this.lblSample.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblSample.Location = new System.Drawing.Point(13, 93);
      this.lblSample.Name = "lblSample";
      this.lblSample.Size = new System.Drawing.Size(76, 14);
      this.lblSample.TabIndex = 4;
      this.lblSample.Text = "Sample Rate";
      // 
      // txtSample
      // 
      this.txtSample.Location = new System.Drawing.Point(112, 90);
      this.txtSample.Name = "txtSample";
      this.txtSample.ReadOnly = true;
      this.txtSample.Size = new System.Drawing.Size(358, 23);
      this.txtSample.TabIndex = 6;
      // 
      // lblPlayCount
      // 
      this.lblPlayCount.AutoSize = true;
      this.lblPlayCount.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblPlayCount.Location = new System.Drawing.Point(13, 122);
      this.lblPlayCount.Name = "lblPlayCount";
      this.lblPlayCount.Size = new System.Drawing.Size(63, 14);
      this.lblPlayCount.TabIndex = 4;
      this.lblPlayCount.Text = "Play Count";
      // 
      // txtPlayCount
      // 
      this.txtPlayCount.Location = new System.Drawing.Point(112, 119);
      this.txtPlayCount.Name = "txtPlayCount";
      this.txtPlayCount.ReadOnly = true;
      this.txtPlayCount.Size = new System.Drawing.Size(358, 23);
      this.txtPlayCount.TabIndex = 6;
      // 
      // lblTrackLength
      // 
      this.lblTrackLength.AutoSize = true;
      this.lblTrackLength.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblTrackLength.Location = new System.Drawing.Point(13, 151);
      this.lblTrackLength.Name = "lblTrackLength";
      this.lblTrackLength.Size = new System.Drawing.Size(73, 14);
      this.lblTrackLength.TabIndex = 4;
      this.lblTrackLength.Text = "Track Length";
      // 
      // txtTrackLength
      // 
      this.txtTrackLength.Location = new System.Drawing.Point(112, 148);
      this.txtTrackLength.Name = "txtTrackLength";
      this.txtTrackLength.ReadOnly = true;
      this.txtTrackLength.Size = new System.Drawing.Size(358, 23);
      this.txtTrackLength.TabIndex = 6;
      // 
      // frmMBLViewer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(480, 303);
      this.Controls.Add(this.btnPrev);
      this.Controls.Add(this.txtLastPlayed);
      this.Controls.Add(this.txtDateModified);
      this.Controls.Add(this.txtTrackLength);
      this.Controls.Add(this.txtPlayCount);
      this.Controls.Add(this.txtSample);
      this.Controls.Add(this.lblTrackLength);
      this.Controls.Add(this.txtDateAdded);
      this.Controls.Add(this.lblPlayCount);
      this.Controls.Add(this.lblLastPlayed);
      this.Controls.Add(this.lblSample);
      this.Controls.Add(this.lblDateModified);
      this.Controls.Add(this.lblDateAdded);
      this.Controls.Add(this.txtPath);
      this.Controls.Add(this.lblLine);
      this.Controls.Add(this.lblPath);
      this.Controls.Add(this.btnOpen);
      this.Controls.Add(this.txtNumTracks);
      this.Controls.Add(this.lblXofY);
      this.Controls.Add(this.lblNumTracks);
      this.Controls.Add(this.btnNext);
      this.Controls.Add(this.btnClose);
      this.Name = "frmMBLViewer";
      this.Text = "MusicBee Library Parser";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMBLViewer_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.Label lblNumTracks;
    private System.Windows.Forms.TextBox txtNumTracks;
    private System.Windows.Forms.Button btnOpen;
    private System.Windows.Forms.OpenFileDialog dlgOpen;
    private System.Windows.Forms.Label lblPath;
    private System.Windows.Forms.Label lblLine;
    private System.Windows.Forms.TextBox txtPath;
    private System.Windows.Forms.Label lblDateAdded;
    private System.Windows.Forms.TextBox txtDateAdded;
    private System.Windows.Forms.Label lblDateModified;
    private System.Windows.Forms.TextBox txtDateModified;
    private System.Windows.Forms.Label lblLastPlayed;
    private System.Windows.Forms.TextBox txtLastPlayed;
    private System.Windows.Forms.Button btnPrev;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblXofY;
    private System.Windows.Forms.Label lblSample;
    private System.Windows.Forms.TextBox txtSample;
    private System.Windows.Forms.Label lblPlayCount;
    private System.Windows.Forms.TextBox txtPlayCount;
    private System.Windows.Forms.Label lblTrackLength;
    private System.Windows.Forms.TextBox txtTrackLength;
  }
}