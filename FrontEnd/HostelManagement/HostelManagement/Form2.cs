﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            passTB.PasswordChar = '*';
            retypepassTB.PasswordChar = '*';
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        public bool Validate(string yourString)
        {
            return yourString.All(ch => char.IsLetterOrDigit(ch)) || (yourString.Any(ch => char.IsWhiteSpace(ch)));
        }

        public bool HaveNumeric(string value)
        {
            return value.Any(char.IsNumber);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (regTB.Text == string.Empty)
            {
                reqreg.Visible = true;
            }
            else
            {
                reqreg.Visible = false;
            }
            if(userTB.Text == string.Empty)
            {
                requser.Visible = true;
            }
            else
            {
                requser.Visible= false;
            }
            if(contactTB.Text == string.Empty)
            {
                reqcontact.Visible = true;
            }
            else
            {
                reqcontact.Visible= false;
            }
            if(mailTB.Text == string.Empty)
            {
                reqmail.Visible = true;
            }
            else
            {
                reqmail.Visible= false;
            }
            if(passTB.Text == string.Empty)
            {
                reqpass.Visible = true;
            }
            else
            {
                reqpass.Visible = false;
            }
            if(retypepassTB.Text == string.Empty)
            {
                reqretype.Visible = true;
            }
            else
            {
                reqretype.Visible = false;
            }
            if(captcha.Checked == false)
            {
                reqcaptcha.Visible = true;
            }
            else
            {
                reqcaptcha.Visible= false;
            }
            // Ensures registration number to have digits starting from the digit 0,1,2
            if (!reqreg.Visible && (!IsNumeric(regTB.Text) || (regTB.Text[0]!='2' && regTB.Text[0]!='1' && regTB.Text[0]!='0')))
            {
                invalidreg.Visible = true;
            }
            else
            {
                invalidreg.Visible = false;
            }
            if (!reqmail.Visible && (!mailTB.Text.Contains("@") || !mailTB.Text.Contains(".com")))
            {
                invalidmail.Visible = true;
            }
            else
            {
                invalidmail.Visible = false;
            }
            if (HaveNumeric(userTB.Text) || !Validate(userTB.Text))
            {
                invalidname.Visible = true;
            }
            else
            {
                invalidname.Visible = false;
            }
            if (passTB.Text != retypepassTB.Text && !reqpass.Visible && !reqretype.Visible)
            {
                invalidretype.Visible = true;
            }
            else
            {
                invalidretype.Visible = false;
            }
            if(!reqcaptcha.Visible && !reqcontact.Visible && !reqmail.Visible && !reqpass.Visible && !reqreg.Visible && !reqretype.Visible && !requser.Visible && !invalidreg.Visible && !invalidmail.Visible && !invalidname.Visible && !invalidretype.Visible)
            {
                DialogResult dr = MessageBox.Show("Registered Successfully!","Success",MessageBoxButtons.OK);
                if(dr == DialogResult.OK)
                {
                    LOGIN frm = new LOGIN();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LOGIN frm = new LOGIN();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
