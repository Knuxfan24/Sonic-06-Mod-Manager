﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Sonic_06_Mod_Manager
{
    public partial class ModCreate : Form
    {
        string modName = "";
        string modVersion = "";
        string modDate = "";
        string modAuthor = "";
        string modCopy = "";
        bool modMerge = false;
        string modPathTrue;

        public ModCreate(string modPath)
        {
            Console.WriteLine(modPath);
            InitializeComponent();
            modPathTrue = modPath;
        }

        private void ModTitleBox_TextChanged(object sender, EventArgs e)
        {
            if (modTitleBox.Text != "")
            {
                createButton.Enabled = true;
            }
            else
            {
                createButton.Enabled = false;
            }
            modName = modTitleBox.Text;
        }

        private void ModVersionBox_TextChanged(object sender, EventArgs e)
        {
            modVersion = modVersionBox.Text;
        }

        private void ModDateBox_TextChanged(object sender, EventArgs e)
        {
            modDate = modDateBox.Text;
        }

        private void ModAuthorBox_TextChanged(object sender, EventArgs e)
        {
            modAuthor = modAuthorBox.Text;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(modPathTrue + "\\" + modName);
            if (Directory.Exists(modPathTrue + "\\" + modName))
            {
                MessageBox.Show("A mod called '" + modName + "' already exists.", "Stupid Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(modPathTrue + "\\" + modName);
                    using (Stream modINILocation = File.Open(modPathTrue + "\\" + modName + "\\mod.ini", FileMode.Create))
                    using (StreamWriter modINI = new StreamWriter(modINILocation))
                    {
                        modINI.WriteLine("Title=\"" + modName + "\"");
                        if (modVersion != "") { modINI.WriteLine("Version=\"" + modVersion + "\""); }
                        if (modDate != "") { modINI.WriteLine("Date=\"" + modDate + "\""); }
                        if (modAuthor != "") { modINI.WriteLine("Author=\"" + modAuthor + "\""); }
                        modINI.WriteLine("Platform=\"" + combo_System.Text + "\"");
                        modINI.WriteLine("Merge=\"" + modMerge.ToString() + "\"");
                        if (modCopy != "") { modINI.WriteLine("Copy=\"" + modCopy + "\""); }
                        modINI.Close();
                    }
                }
                catch { MessageBox.Show("An error occurred when creating the directory. Please check for invalid characters in your mod name.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }
            ModManager.isCreatorDisposed = true;
            Close();
        }

        private void Check_Merge_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Merge.Checked == true)
            {
                modMerge = true;
                lbl_Copy.Enabled = true;
                modCopyBox.Enabled = true;
                readonlyButtonHelp.Enabled = true;
            }
            else
            {
                modMerge = false;
                lbl_Copy.Enabled = false;
                modCopyBox.Enabled = false;
                readonlyButtonHelp.Enabled = true;
            }
        }

        private void ModCreate_Load(object sender, EventArgs e)
        {
            combo_System.SelectedIndex = 0;
            this.MaximumSize = new System.Drawing.Size(int.MaxValue, 239);
        }

        private void ModCopy_TextChanged(object sender, EventArgs e)
        {
            modCopy = modCopyBox.Text;
        }

        private void ReadonlyButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This parameter tells the Mod Manager not to merge files marked as 'read-only.' Files must be listed as comma separated values (e.g. 'cache.arc,player.arc,object.arc').", "Read-only", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
