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
	public partial class F_Adm_Modify : Form
	{
		public F_Adm_Modify()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			F_Adm_Modify_Dishes f1 = new F_Adm_Modify_Dishes();
			f1.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			F_Adm_Modify_Ingredients f1 = new F_Adm_Modify_Ingredients();
			f1.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Adm_Modify_Products f1 = new Adm_Modify_Products();
			f1.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
