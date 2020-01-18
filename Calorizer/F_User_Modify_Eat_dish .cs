using System;
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
	public partial class F_User_Modify_Eat_dish : Form
	{
	

		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sasha\source\repos\Курсач_попытка1\Курсач_попытка1\Database1.mdf;Integrated Security=True");
		SqlCommand cmd;
		public F_User_Modify_Eat_dish()
		{
			InitializeComponent();
			DisplayData();
		}
		private void F_Adm_Modify_Dishes_Load(object sender, EventArgs e)
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

				cmd.CommandText = "select * from Eat_dish";
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
		private void ClearData()
		{
			dtp1.Text = "";
			dtp2.Text = "";
			
			txt3.Text = "";
		}




		//private void btn_INSERT_Click(object sender, EventArgs e)
		//{
		
			
		//		cmd = new SqlCommand("insert into Eat_dish (Date_,Time_,ID_dish,ID_user,Volume_eat_dish) values(@Date_,@Time_,@ID_dish,@ID_user,@Volume_eat_dish)", con);
		//		con.Open();
		//		cmd.Parameters.AddWithValue("@Date_", dtp1.Text);
		//		cmd.Parameters.AddWithValue("@Time_", dtp2.Text);
		//		cmd.Parameters.AddWithValue("@ID_dish", comboBox1.Text);
		//		cmd.Parameters.AddWithValue("@ID_user", comboBox2.Text);
		//		cmd.Parameters.AddWithValue("@Volume_eat_dish", txt3.Text);
		//		//Convert.ToDateTime(dateTimePicker1.Value.ToString())
		//		cmd.ExecuteNonQuery();
		//		con.Close();
		//		MessageBox.Show("Record Inserted Successfully");
		//		DisplayData();
		//		ClearData();
		//}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dtp1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			dtp2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txt3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dtp2_ValueChanged(object sender, EventArgs e)
		{

		}
		//INSERT
		private void button1_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = con.CreateCommand();
		    cmd.CommandType = CommandType.Text;
			//con.Open();
			//cmd = new SqlCommand( "insert into Eat_dish (Date_,Time_,ID_dish,ID_user,Volume_eat_dish)"+
			//				  "values(( '" + dtp1.Value.ToShortDateString() + "'), " +
			//				  "('" + dtp2.Value.ToShortTimeString() + "')," +
			//				  //"values(( '" + Convert.ToDateTime(dtp1.Value.ToString()) +"'),"+
			//				  // "('" + Convert.ToDateTime(dtp2.Value.ToString()) + "')," +
			//				  //"('" + dtp2.Value.ToShortTimeString()+"'),"+
			//				  "(select ID_dish From Dish where Name_dish = '" + comboBox1.Text +"'),"+
			//				  "(select ID_user From [dbo].[User] where Name_user = '"+comboBox2.Text+"'),"+
			//				  "( '" + Convert.ToInt32(txt3.Text) + "'))", con);
			////'" + Convert.ToDateTime(dateTimePicker2.Value.ToString()) + "'
			//	cmd.ExecuteNonQuery();

			//con.Close();
			//MessageBox.Show("OK");
			cmd = new SqlCommand("insert into Eat_dish (Date_,Time_,ID_dish,ID_user,Volume_eat_dish) values(@Date_,@Time_,@ID_dish,@ID_user,@Volume_eat_dish)", con);
			con.Open();
			cmd.Parameters.AddWithValue("@Date_", dtp1.Value.ToShortDateString());
			cmd.Parameters.AddWithValue("@Time_", dtp2.Value.ToShortTimeString());
			cmd.Parameters.AddWithValue("@ID_dish", comboBox1.Text);
			cmd.Parameters.AddWithValue("@ID_user", comboBox2.Text);
			cmd.Parameters.AddWithValue("@Volume_eat_dish", txt3.Text);
			//Convert.ToDateTime(dateTimePicker1.Value.ToString())
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Record Inserted Successfully");
			DisplayData();
			ClearData();
			// = new SqlCommand("insert into Eat_dish (Date_,Time_,ID_dish,ID_user,Volume_eat_dish) " +
			// "values(@txt_ID_dish,@txt_weight_,@txt_Name_product)", con);


			//con.Open();
			//cmd.Parameters.AddWithValue("@txt_ID_dish", txt_ID_dish.Text);
			//cmd.Parameters.AddWithValue("@txt_weight_", txt_weight_.Text);
			//cmd.Parameters.AddWithValue("@txt_Name_product", txt_Name_product.Text);
			//Convert.ToDateTime(dateTimePicker1.Value.ToString())
			//cmd.ExecuteNonQuery();
			//con.Close();
			//MessageBox.Show("Record Inserted Successfully");
			//DisplayData();
			//ClearData();
		}

		private void F_User_Modify_Eat_dish_Load(object sender, EventArgs e)
		{
			fill_Dishes();
			fill_Users();
		}

		public void fill_Dishes()
		{
			comboBox1.Items.Clear();

			con.Open();

			SqlCommand cmd = con.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select Name_dish From Dish";
			cmd.ExecuteNonQuery();

			DataTable adt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(adt);
			foreach (DataRow dr in adt.Rows)
			{
				comboBox1.Items.Add(dr["Name_dish"].ToString());
			}
			con.Close();

		}

		public void fill_Users()
		{
			comboBox2.Items.Clear();

			con.Open();

			SqlCommand cmd = con.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select Name_user from [dbo].[User]";
			cmd.ExecuteNonQuery();

			DataTable adt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(adt);
			foreach (DataRow dr in adt.Rows)
			{
				comboBox2.Items.Add(dr["Name_user"].ToString());
			}
			
			con.Close();

		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
