﻿namespace Unify.Environment3
{
    partial class UnifyEnvironment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnifyEnvironment));
            this.Unify_Rush = new Unify.Environment3.RushInterface();
            this.SuspendLayout();
            // 
            // Unify_Rush
            // 
            this.Unify_Rush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Unify_Rush.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Unify_Rush.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unify_Rush.ForeColor = System.Drawing.SystemColors.Control;
            this.Unify_Rush.Location = new System.Drawing.Point(0, 0);
            this.Unify_Rush.Name = "Unify_Rush";
            this.Unify_Rush.Size = new System.Drawing.Size(849, 589);
            this.Unify_Rush.Status = "Ready.";
            this.Unify_Rush.TabIndex = 0;
            // 
            // UnifyEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(849, 589);
            this.Controls.Add(this.Unify_Rush);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(865, 628);
            this.Name = "UnifyEnvironment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sonic \'06 Mod Manager";
            this.ResumeLayout(false);

        }

        #endregion
        private RushInterface Unify_Rush;
    }
}