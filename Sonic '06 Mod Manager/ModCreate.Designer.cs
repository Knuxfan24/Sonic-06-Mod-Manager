﻿namespace Sonic_06_Mod_Manager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModCreate));
            this.label1 = new System.Windows.Forms.Label();
            this.modTitleBox = new System.Windows.Forms.TextBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.modVersionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modDateBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modAuthorBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.check_Merge = new System.Windows.Forms.CheckBox();
            this.mergeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title:";
            // 
            // modTitleBox
            // 
            this.modTitleBox.Location = new System.Drawing.Point(62, 12);
            this.modTitleBox.Name = "modTitleBox";
            this.modTitleBox.Size = new System.Drawing.Size(294, 20);
            this.modTitleBox.TabIndex = 4;
            this.modTitleBox.TextChanged += new System.EventHandler(this.ModTitleBox_TextChanged);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(11, 41);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 13);
            this.versionLabel.TabIndex = 7;
            this.versionLabel.Text = "Version:";
            // 
            // modVersionBox
            // 
            this.modVersionBox.Location = new System.Drawing.Point(62, 38);
            this.modVersionBox.Name = "modVersionBox";
            this.modVersionBox.Size = new System.Drawing.Size(294, 20);
            this.modVersionBox.TabIndex = 6;
            this.modVersionBox.TextChanged += new System.EventHandler(this.ModVersionBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date:";
            // 
            // modDateBox
            // 
            this.modDateBox.Location = new System.Drawing.Point(62, 64);
            this.modDateBox.Name = "modDateBox";
            this.modDateBox.Size = new System.Drawing.Size(294, 20);
            this.modDateBox.TabIndex = 8;
            this.modDateBox.TextChanged += new System.EventHandler(this.ModDateBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Author:";
            // 
            // modAuthorBox
            // 
            this.modAuthorBox.Location = new System.Drawing.Point(62, 90);
            this.modAuthorBox.Name = "modAuthorBox";
            this.modAuthorBox.Size = new System.Drawing.Size(294, 20);
            this.modAuthorBox.TabIndex = 10;
            this.modAuthorBox.TextChanged += new System.EventHandler(this.ModAuthorBox_TextChanged);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.LightGreen;
            this.createButton.Enabled = false;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Location = new System.Drawing.Point(281, 116);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 12;
            this.createButton.Text = "Create Mod";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // check_Merge
            // 
            this.check_Merge.AutoSize = true;
            this.check_Merge.Location = new System.Drawing.Point(62, 120);
            this.check_Merge.Name = "check_Merge";
            this.check_Merge.Size = new System.Drawing.Size(62, 17);
            this.check_Merge.TabIndex = 13;
            this.check_Merge.Text = "Merge?";
            this.mergeTooltip.SetToolTip(this.check_Merge, "Does this mod need to merge its arc files with the base game ones rather than ent" +
        "irely replace them?");
            this.check_Merge.UseVisualStyleBackColor = true;
            this.check_Merge.CheckedChanged += new System.EventHandler(this.Check_Merge_CheckedChanged);
            // 
            // ModCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 148);
            this.Controls.Add(this.check_Merge);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.CheckBox check_Merge;
        private System.Windows.Forms.ToolTip mergeTooltip;
    }
}