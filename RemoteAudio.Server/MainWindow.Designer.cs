﻿namespace RemoteAudio.Server;

partial class MainWindow
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
        {
            components.Dispose();
            Server.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.deviceInfo = new System.Windows.Forms.Label();
            this.deviceDescription = new System.Windows.Forms.TextBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceInfo
            // 
            this.deviceInfo.AutoSize = true;
            this.deviceInfo.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deviceInfo.Location = new System.Drawing.Point(12, 44);
            this.deviceInfo.Name = "deviceInfo";
            this.deviceInfo.Size = new System.Drawing.Size(104, 32);
            this.deviceInfo.TabIndex = 0;
            this.deviceInfo.Text = "PC 정보:";
            this.deviceInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // deviceDescription
            // 
            this.deviceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceDescription.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deviceDescription.Location = new System.Drawing.Point(782, 408);
            this.deviceDescription.Name = "deviceDescription";
            this.deviceDescription.PlaceholderText = "설명";
            this.deviceDescription.Size = new System.Drawing.Size(214, 29);
            this.deviceDescription.TabIndex = 1;
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsButton.Location = new System.Drawing.Point(12, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 29);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "설정";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            this.statusStrip.Location = new System.Drawing.Point(0, 451);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(31, 17);
            this.statusText.Text = "준비";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 408);
            this.progressBar.Maximum = 10000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(760, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 4;
            this.progressBar.Click += new System.EventHandler(this.ProgressBar_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 50;
            this.Timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.deviceDescription);
            this.Controls.Add(this.deviceInfo);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainWindow";
            this.Text = "Remote Audio";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label deviceInfo;
    private TextBox deviceDescription;
    private Button settingsButton;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel statusText;
    private System.Windows.Forms.Timer Timer;
    private ProgressBar progressBar;
}