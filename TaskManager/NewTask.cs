﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
           try { 

            Process.Start(textBox1.Text);

            }

            catch (  Exception ) 
            {
                MessageBox.Show("Wrong task name or path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
             
        }
    }
}
