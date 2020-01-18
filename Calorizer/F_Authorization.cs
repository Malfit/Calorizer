using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Курсач_попытка1
{
	public partial class F_Authorization : Form
	{
		public F_Authorization()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			if (textBox1.Text == "admin")
			{
				if (textBox2.Text == "admin")
				{
					F_Adm_Modify f1 = new F_Adm_Modify();
					f1.ShowDialog();
				}
			}
			else if (textBox1.Text == "user")
			{
				if (textBox2.Text == "user")
				{
					F_User_Interface f2 = new F_User_Interface();
					f2.ShowDialog();
				}
			}
			else
				MessageBox.Show("Incorrect login or password");
			textBox1.Clear();
			textBox2.Clear();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
	