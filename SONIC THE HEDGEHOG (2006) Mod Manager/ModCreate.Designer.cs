﻿namespace SONIC_THE_HEDGEHOG__2006__Mod_Manager
{
    partial class ModCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.modTitleBox = new System.Windows.Forms.TextBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.modVersionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modDateBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modAuthorBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mod Title:";
            // 
            // modTitleBox
            // 
            this.modTitleBox.Location = new System.Drawing.Point(72, 12);
            this.modTitleBox.Name = "modTitleBox";
            this.modTitleBox.Size = new System.Drawing.Size(284, 20);
            this.modTitleBox.TabIndex = 4;
            this.modTitleBox.TextChanged += new System.EventHandler(this.ModTitleBox_TextChanged);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(12, 41);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(109, 13);
            this.versionLabel.TabIndex = 7;
            this.versionLabel.Text = "Mod Version Number:";
            // 
            // modVersionBox
            // 
            this.modVersionBox.Location = new System.Drawing.Point(127, 38);
            this.modVersionBox.Name = "modVersionBox";
            this.modVersionBox.Size = new System.Drawing.Size(229, 20);
            this.modVersionBox.TabIndex = 6;
            this.modVersionBox.TextChanged += new System.EventHandler(this.ModVersionBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mod Date:";
            // 
            // modDateBox
            // 
            this.modDateBox.Location = new System.Drawing.Point(75, 64);
            this.modDateBox.Name = "modDateBox";
            this.modDateBox.Size = new System.Drawing.Size(281, 20);
            this.modDateBox.TabIndex = 8;
            this.modDateBox.TextChanged += new System.EventHandler(this.ModDateBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mod Author:";
            // 
            // modAuthorBox
            // 
            this.modAuthorBox.Location = new System.Drawing.Point(83, 90);
            this.modAuthorBox.Name = "modAuthorBox";
            this.modAuthorBox.Size = new System.Drawing.Size(273, 20);
            this.modAuthorBox.TabIndex = 10;
            this.modAuthorBox.TextChanged += new System.EventHandler(this.ModAuthorBox_TextChanged);
            // 
            // createButton
            // 
            this.createButton.Enabled = false;
            this.createButton.Location = new System.Drawing.Point(281, 116);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 12;
            this.createButton.Text = "Create Mod";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ModCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 148);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modAuthorBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modDateBox);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.modVersionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modTitleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModCreate";
            this.Text = "Mod Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modTitleBox;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.TextBox modVersionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modDateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modAuthorBox;
        private System.Windows.Forms.Button createButton;
    }
}