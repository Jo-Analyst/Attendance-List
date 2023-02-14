﻿using DataBase;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmSaveStudent : Form
    {

        public bool studentWasSaved { get; set; }
        int id;
        Student student = new Student();

        public FrmSaveStudent()
        {
            InitializeComponent();
        }

        public FrmSaveStudent(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Preencha o nome da turma", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a turma", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                student._id = id;
                student._name = txtName.Text.Trim();
                student._class = cbClass.Text.Trim();
                student._gender = rbMasculine.Checked ? "M" : "F";
                student.Save();
                studentWasSaved = true;

                if (id == 0)
                {
                    DialogResult dr = MessageBox.Show("Deseja incluir mais um novo aluno?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        txtName.Clear();
                        cbClass.SelectedIndex = -1;
                        rbMasculine.Checked = true;
                        txtName.Focus();
                        return;
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSaveStudent_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                try
                {
                    student._id = id;
                    var dataStudent = student.FindById().Rows[0];
                    txtName.Text = dataStudent["name"].ToString();
                    cbClass.Text = dataStudent["class"].ToString();
                    if (dataStudent["gender"].ToString() == "F")
                        rbFeminine.Checked = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmSaveStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}