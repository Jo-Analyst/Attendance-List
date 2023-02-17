﻿using DataBase;
using System.IO;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmOpenBackupAndRestore : Form
    {
        public FrmOpenBackupAndRestore()
        {
            InitializeComponent();
        }

        string path = "C://Course-Managemenentt-Backup";
        private void CreateDirectory()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private string getDate() 
        {
            DateTime dt = DateTime.Now;
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;

            int hour = dt.Hour;
            int minute = dt.Minute;
            int second = dt.Second;

            return $"{day}-{month}-{year}--{hour}-{minute}-{second}";
        }

        Backup backup = new Backup();

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                CreateDirectory();
                string file = $"{path}\\{getDate()}.bak";
                backup.GenerateBackup(file);
                MessageBox.Show($"Backup realizado com sucesso. O caminho do arquivo é este: {file}.", "Mensage,", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
        }
    }
}
