using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Курсач_попытка1
{
	public partial class Adm_Modify_Products : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sasha\source\repos\Курсач_попытка1\Курсач_попытка1\Database1.mdf;Integrated Security=True");
		SqlCommand cmd;
		//SqlDataAdapter adapt;
		//ID variable used in Updating and Deleting Record  
		//int ID_dish = 0;
		public Adm_Modify_Products()
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
		private void ClearData()
		{
			txt_1.Text = "";
			txt_2.Text = "";
			txt_3.Text = "";
			txt_4.Text = "";
		}
		



		private void btn_INSERT_Click(object sender, EventArgs e)
		{
			if (txt_1.Text != "" && txt_2.Text != "" && txt_3.Text != "" && txt_4.Text != "")
			{
				cmd = new SqlCommand("insert into Products (Name_product,health_benefits,calories_per_100g,Liquid) values(@Name_product,@health_benefits,@calories_per_100g,@Liquid)", con);
				con.Open();
				cmd.Parameters.AddWithValue("@Name_product", txt_1.Text);
				cmd.Parameters.AddWithValue("@health_benefits", txt_2.Text);
				cmd.Parameters.AddWithValue("@calories_per_100g", txt_3.Text);
				cmd.Parameters.AddWithValue("@Liquid", txt_4.Text);
				//Convert.ToDateTime(dateTimePicker1.Value.ToString())
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Record Inserted Successfully");
				DisplayData();
				ClearData();
			}
			else
			{
				MessageBox.Show("Please Provide Details!");
			}
		}
		private void btn_UPDATE_Click(object sender, EventArgs e)
		{
			if (txt_1.Text != "" && txt_1.Text != "" && txt_1.Text != "" && txt_1.Text != "")
			{
				cmd = new SqlCommand("update Products set health_benefits = @health_benefits, calories_per_100g = @calories_per_100g, Liquid = @Liquid where Name_product=@Name_product", con);
				//cmd = new SqlCommand("update Products set health_benefits = @health_benefits where Name_product=@Name_product", con);
				//cmd = new SqlCommand("update Products set calories_per_100g = @calories_per_100g where Name_product=@Name_product", con);
				//cmd = new SqlCommand("update Products set Liquid = @Liquid where Name_product=@Name_product", con);
				con.Open();
				cmd.Parameters.AddWithValue("@health_benefits", txt_2.Text);
				cmd.Parameters.AddWithValue("@calories_per_100g", txt_3.Text);
				cmd.Parameters.AddWithValue("@Liquid", txt_4.Text);
				cmd.Parameters.AddWithValue("@Name_product", txt_Name_product.Text);

				cmd.ExecuteNonQuery();
				MessageBox.Show("Record Updated Successfully");
				con.Close();
				DisplayData();
				ClearData();
			}
			else
			{
				MessageBox.Show("Please Select Record to Update");
			}
		}

		private void btn_DELETE_Click(object sender, EventArgs e)
		{
			if (txt_1.Text != "")
			{
				cmd = new SqlCommand("delete Products where Name_product=@Name_product", con);
				con.Open();
				cmd.Parameters.AddWithValue("@Name_product", txt_1.Text);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Record Deleted Successfully!");
				DisplayData();
				ClearData();
			}
			else
			{
				MessageBox.Show("Please Select Record to Delete");
			}
		}



		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txt_1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			txt_2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txt_3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			txt_4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
		}

		//--------------------------Text_boxes
		//Name_product
		private void textBox1_TextChanged(object sender, EventArgs e) { }		
		//Health_benefits
		private void textBox2_TextChanged(object sender, EventArgs e) { }		
		//Calories_per_100g
		private void textBox3_TextChanged(object sender, EventArgs e) { }
		//Liquid
		private void textBox4_TextChanged(object sender, EventArgs e) { }

		//---------------------------Labels
		private void txt_Liquid_Click(object sender, EventArgs e) { }
		private void txt_health_benefits_Click(object sender, EventArgs e) { }
		private void txt_Name_product_Click(object sender, EventArgs e) { }
		private void calories_per_100g_Click(object sender, EventArgs e) { }

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
