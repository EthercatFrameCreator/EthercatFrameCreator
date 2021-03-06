﻿namespace EthercatFuzzer
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_send = new System.Windows.Forms.Button();
            this.lbl_DeviceList = new System.Windows.Forms.Label();
            this.cmb_DeviceList = new System.Windows.Forms.ComboBox();
            this.lbl_RepeatCount = new System.Windows.Forms.Label();
            this.txt_RCount = new System.Windows.Forms.TextBox();
            this.lbl_CMD = new System.Windows.Forms.Label();
            this.cmb_cmd = new System.Windows.Forms.ComboBox();
            this.lbl_SlaveAddress = new System.Windows.Forms.Label();
            this.lbl_OffsetAddress = new System.Windows.Forms.Label();
            this.txt_OAddress = new System.Windows.Forms.TextBox();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.txt_SAddress = new System.Windows.Forms.TextBox();
            this.richtxt_data = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SourceAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DestinationAdress = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(410, 268);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(152, 23);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_DeviceList
            // 
            this.lbl_DeviceList.AutoSize = true;
            this.lbl_DeviceList.Location = new System.Drawing.Point(283, 12);
            this.lbl_DeviceList.Name = "lbl_DeviceList";
            this.lbl_DeviceList.Size = new System.Drawing.Size(60, 13);
            this.lbl_DeviceList.TabIndex = 1;
            this.lbl_DeviceList.Text = "Device List";
            // 
            // cmb_DeviceList
            // 
            this.cmb_DeviceList.FormattingEnabled = true;
            this.cmb_DeviceList.Location = new System.Drawing.Point(267, 28);
            this.cmb_DeviceList.Name = "cmb_DeviceList";
            this.cmb_DeviceList.Size = new System.Drawing.Size(295, 21);
            this.cmb_DeviceList.TabIndex = 2;
            this.cmb_DeviceList.SelectedIndexChanged += new System.EventHandler(this.cmb_DeviceList_SelectedIndexChanged);
            // 
            // lbl_RepeatCount
            // 
            this.lbl_RepeatCount.AutoSize = true;
            this.lbl_RepeatCount.Location = new System.Drawing.Point(40, 109);
            this.lbl_RepeatCount.Name = "lbl_RepeatCount";
            this.lbl_RepeatCount.Size = new System.Drawing.Size(73, 13);
            this.lbl_RepeatCount.TabIndex = 3;
            this.lbl_RepeatCount.Text = "Repeat Count";
            // 
            // txt_RCount
            // 
            this.txt_RCount.Location = new System.Drawing.Point(30, 125);
            this.txt_RCount.Name = "txt_RCount";
            this.txt_RCount.Size = new System.Drawing.Size(190, 20);
            this.txt_RCount.TabIndex = 4;
            // 
            // lbl_CMD
            // 
            this.lbl_CMD.AutoSize = true;
            this.lbl_CMD.Location = new System.Drawing.Point(40, 154);
            this.lbl_CMD.Name = "lbl_CMD";
            this.lbl_CMD.Size = new System.Drawing.Size(31, 13);
            this.lbl_CMD.TabIndex = 5;
            this.lbl_CMD.Text = "CMD";
            // 
            // cmb_cmd
            // 
            this.cmb_cmd.FormattingEnabled = true;
            this.cmb_cmd.Location = new System.Drawing.Point(30, 170);
            this.cmb_cmd.Name = "cmb_cmd";
            this.cmb_cmd.Size = new System.Drawing.Size(190, 21);
            this.cmb_cmd.TabIndex = 6;
            // 
            // lbl_SlaveAddress
            // 
            this.lbl_SlaveAddress.AutoSize = true;
            this.lbl_SlaveAddress.Location = new System.Drawing.Point(38, 198);
            this.lbl_SlaveAddress.Name = "lbl_SlaveAddress";
            this.lbl_SlaveAddress.Size = new System.Drawing.Size(75, 13);
            this.lbl_SlaveAddress.TabIndex = 7;
            this.lbl_SlaveAddress.Text = "Slave Address";
            // 
            // lbl_OffsetAddress
            // 
            this.lbl_OffsetAddress.AutoSize = true;
            this.lbl_OffsetAddress.Location = new System.Drawing.Point(37, 241);
            this.lbl_OffsetAddress.Name = "lbl_OffsetAddress";
            this.lbl_OffsetAddress.Size = new System.Drawing.Size(76, 13);
            this.lbl_OffsetAddress.TabIndex = 9;
            this.lbl_OffsetAddress.Text = "Offset Address";
            // 
            // txt_OAddress
            // 
            this.txt_OAddress.Location = new System.Drawing.Point(30, 257);
            this.txt_OAddress.Name = "txt_OAddress";
            this.txt_OAddress.Size = new System.Drawing.Size(190, 20);
            this.txt_OAddress.TabIndex = 10;
            this.txt_OAddress.TextChanged += new System.EventHandler(this.txt_OAddress_TextChanged);
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Location = new System.Drawing.Point(283, 173);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(30, 13);
            this.lbl_Data.TabIndex = 11;
            this.lbl_Data.Text = "Data";
            // 
            // txt_SAddress
            // 
            this.txt_SAddress.Location = new System.Drawing.Point(30, 214);
            this.txt_SAddress.Name = "txt_SAddress";
            this.txt_SAddress.Size = new System.Drawing.Size(190, 20);
            this.txt_SAddress.TabIndex = 13;
            this.txt_SAddress.TextChanged += new System.EventHandler(this.txt_SAddress_TextChanged);
            // 
            // richtxt_data
            // 
            this.richtxt_data.Location = new System.Drawing.Point(267, 195);
            this.richtxt_data.Name = "richtxt_data";
            this.richtxt_data.Size = new System.Drawing.Size(295, 64);
            this.richtxt_data.TabIndex = 14;
            this.richtxt_data.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Source Adress";
            // 
            // txt_SourceAdress
            // 
            this.txt_SourceAdress.Location = new System.Drawing.Point(267, 76);
            this.txt_SourceAdress.Name = "txt_SourceAdress";
            this.txt_SourceAdress.Size = new System.Drawing.Size(295, 20);
            this.txt_SourceAdress.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Destination Adress (Noktalı giriniz)";
            // 
            // txt_DestinationAdress
            // 
            this.txt_DestinationAdress.Location = new System.Drawing.Point(267, 125);
            this.txt_DestinationAdress.Name = "txt_DestinationAdress";
            this.txt_DestinationAdress.Size = new System.Drawing.Size(295, 20);
            this.txt_DestinationAdress.TabIndex = 18;
            this.txt_DestinationAdress.TextChanged += new System.EventHandler(this.txt_DestinationAdress_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EthercatFuzzer.Properties.Resources.SauSiberImage;
            this.pictureBox1.Location = new System.Drawing.Point(73, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 303);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_DestinationAdress);
            this.Controls.Add(this.txt_SourceAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richtxt_data);
            this.Controls.Add(this.txt_SAddress);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.txt_OAddress);
            this.Controls.Add(this.lbl_OffsetAddress);
            this.Controls.Add(this.lbl_SlaveAddress);
            this.Controls.Add(this.cmb_cmd);
            this.Controls.Add(this.lbl_CMD);
            this.Controls.Add(this.txt_RCount);
            this.Controls.Add(this.lbl_RepeatCount);
            this.Controls.Add(this.cmb_DeviceList);
            this.Controls.Add(this.lbl_DeviceList);
            this.Controls.Add(this.btn_send);
            this.Name = "MainScreen";
            this.Text = "EtherCat Fuzzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lbl_DeviceList;
        private System.Windows.Forms.ComboBox cmb_DeviceList;
        private System.Windows.Forms.Label lbl_RepeatCount;
        private System.Windows.Forms.TextBox txt_RCount;
        private System.Windows.Forms.Label lbl_CMD;
        private System.Windows.Forms.ComboBox cmb_cmd;
        private System.Windows.Forms.Label lbl_SlaveAddress;
        private System.Windows.Forms.Label lbl_OffsetAddress;
        private System.Windows.Forms.TextBox txt_OAddress;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.TextBox txt_SAddress;
        private System.Windows.Forms.RichTextBox richtxt_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SourceAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DestinationAdress;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

