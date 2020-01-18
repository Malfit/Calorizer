using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Курсач_попытка1
{
	public partial class F_Adm_Modify_Dishes : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sasha\source\repos\Курсач_попытка1\Курсач_попытка1\Database1.mdf;Integrated Security=True");
		SqlCommand cmd;
		//SqlDataAdapter adapt;
		//ID variable used in Updating and Deleting Record  
		int ID_dish = 0;
		
		

		public F_Adm_Modify_Dishes()
		{
			InitializeComponent();
			DisplayData();
		}

		private void F_Adm_Modify_Dishes_Load(object sender, EventArgs e)
		{
			DisplayData();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (txt_Name_dish.Text != "")
			{
				cmd = new SqlCommand("insert into Dish(Name_dish) values(@Name_dish)", con);
				con.Open();
				cmd.Parameters.AddWithValue("@Name_dish", txt_Name_dish.Text);
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
			//SqlConnection constr = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;
			//Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
			//sda = new SqlDataAdapter(@"SELECT [ID_dish],[Name_dish] FROM Products", constr);
			//dt = new DataTable();
			//sda.Fill(dt);
			//dataGridView1.DataSource = dt;
			//con.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ID_dish = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			txt_Name_dish.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
		}
		private void DisplayData()
		{
			try
			{
				con.Open();

				SqlCommand cmd = con.CreateCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "select * from Dish";
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
			txt_Name_dish.Text = "";
			ID_dish = 0;
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (txt_Name_dish.Text != "" )
			{
				cmd = new SqlCommand("update Dish set Name_dish = @Name_dish where ID_dish=@id", con);
				con.Open();
				cmd.Parameters.AddWithValue("@id", ID_dish);
				cmd.Parameters.AddWithValue("@Name_dish", txt_Name_dish.Text);
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

		private void button4_Click(object sender, EventArgs e)
		{
			if (ID_dish != 0)
			{
				cmd = new SqlCommand("delete Dish where ID_dish=@id", con);
				con.Open();
				cmd.Parameters.AddWithValue("@id", ID_dish);
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

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			con.Open();
			SqlCommand cmd = con.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from Dish";
			cmd.ExecuteNonQuery();

			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			con.Close();
		}
	}
}
