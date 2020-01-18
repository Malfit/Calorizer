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
	public partial class F_User_Interface : Form
	{
		public F_User_Interface()
		{
			InitializeComponent();

		}

		//exit
		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//INSERT
		private void btn__Click(object sender, EventArgs e)
		{
			F_User_Modify_Eat_dish  u1 = new F_User_Modify_Eat_dish();
			u1.ShowDialog();
		}

		private void btn_View_product_list_Click(object sender, EventArgs e)
		{
			F_User_View_Product_list u1 = new F_User_View_Product_list();
			u1.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			F_User_View_Ingredients_list u1 = new F_User_View_Ingredients_list();
			u1.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			F_User_View_Dishes_list u1 = new F_User_View_Dishes_list();
			u1.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			F_User_Calculate_calories u1 = new F_User_Calculate_calories();
			u1.ShowDialog();
		}
	}
}
