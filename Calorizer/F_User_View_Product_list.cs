﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Курсач_попытка1
{
	public partial class F_User_View_Product_list : Form
	{
		public F_User_View_Product_list()
		{
			InitializeComponent();
			DisplayData();
		}


		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sasha\source\repos\Курсач_попытка1\Курсач_попытка1\Database1.mdf;Integrated Security=True");
		//SqlCommand cmd;
		//SqlDataAdapter adapt;
		//ID variable used in Updating and Deleting Record  
		//int ID_dish = 0;
	
		private void F_User_View_Product_list_Load(object sender, EventArgs e)
		{
			DisplayData();
		}


		private void DisplayData()
		{
			try
			{
				con.Open();

				SqlCommand cmd = con.CreateCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "select * from Products";
				cmd.ExecuteNonQuery();

				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;

				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}