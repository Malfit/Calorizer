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
	public partial class F_Adm_Modify_Ingredients :Form
	{
		int selectedRow;
		int Record_ID;
		string Record_weight;

		public F_Adm_Modify_Ingredients()
		{
			InitializeComponent();
			DisplayData();
		}
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sasha\source\repos\Курсач_попытка1\Курсач_попытка1\Database1.mdf;Integrated Security=True");
		SqlCommand cmd;
		SqlCommand cmd1;
		//SqlDataAdapter adapt;
		//ID variable used in Updating and Deleting Record  
		int ID_dish = 0;

		private void F_Adm_Modify_Igredients_Load(object sender, EventArgs e)
		{
			DisplayData();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//ID_dish = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			//txt_weight_.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			//txt_Name_product.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

			
		}

		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			//txt_ID_dish.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			//txt_weight_.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			//txt_Name_product.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

			selectedRow = e.RowIndex;
			Record_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
			Record_weight = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			//MessageBox.Show(Record_weight);
			txt_ID_dish.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txt_weight_.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			txt_Name_product.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
		}

		//INSERT
		private void btn_INSERT_Click(object sender, EventArgs e)
		{
			if ( txt_weight_.Text != "" && txt_Name_product.Text != "" && txt_ID_dish.Text != "" )
			{
				// con.Open();
				//SqlCommand cmd = con.CreateCommand();
				//cmd.CommandType = CommandType.Text;
				//cmd.CommandText = "insert into Use_food_for_the_dish(Id_dish, weight_, Name_product)" +
				//				 "values('"+txt_ID_dish.Text+"','"+txt_weight_.Text+"','"+txt_Name_product.Text+"')";
				//cmd.ExecuteNonQuery();
				//con.Close();
				//MessageBox.Show("Record Inserted Successfully");

				cmd = new SqlCommand("insert into Use_food_for_the_dish(Id_dish,weight_,Name_product) " +
									 "values(@txt_ID_dish,@txt_weight_,@txt_Name_product)", con);
				//Id_dish '@txt_ID_dish'
				con.Open();
				cmd.Parameters.AddWithValue("@txt_ID_dish", txt_ID_dish.Text);
				cmd.Parameters.AddWithValue("@txt_weight_", txt_weight_.Text);
				cmd.Parameters.AddWithValue("@txt_Name_product", txt_Name_product.Text);
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

		//UPDATE
		private void btn_UPDATE_Click(object sender, EventArgs e)
		{
			try
			{

				//con.Open();

				//cmd = con.CreateCommand();
				//cmd.CommandType = CommandType.Text;
				//cmd.CommandText = ("update Use_food_for_the_dish set weight_ = 150 where id_dish = 10 and Name_product = 'cherry'");
				//cmd.EndExecuteNonQuery();

				////if (txt_weight_.Text != "" && txt_Name_product.Text != "")
				//{
				con.Open();
				//cmd = new SqlCommand("update Use_food_for_the_dish set weight_ = @txt_weight_ where Name_product =@txt_Name_product && ID_dish = @ID_dish", con);
				//cmd = new SqlCommand("update Use_food_for_the_dish set weight_ ='" + Convert.ToInt32(txt_weight_.ToString()) + "' where id_dish = '" + Record_ID + "' and Name_product = '" + Record_weight + "'");


				cmd = new SqlCommand("update Use_food_for_the_dish set weight_ = '" + Convert.ToInt32(txt_weight_.Text) + "' where id_dish = '" + Record_ID+"' and Name_product = '"+Record_weight+"'", con);


				//cmd.Parameters.AddWithValue("@id", ID_dish);
				//cmd.Parameters.AddWithValue("@weight_", Convert.ToInt32( txt_weight_.Text));
				//cmd.Parameters.AddWithValue("@Name_product", txt_Name_product.Text);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Record Updated Successfully");
				con.Close();
				DisplayData();
				ClearData();
			
				
		}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		//DELETE
		private void btn_DELETE_Click(object sender, EventArgs e)
		{

			if ((int.Parse(txt_ID_dish.Text)) != 0 )
				{
				con.Open();
				cmd = new SqlCommand("delete Use_food_for_the_dish where ID_dish=@id AND Name_product = @Name_product", con);
				cmd.Parameters.AddWithValue("@id", int.Parse(txt_ID_dish.Text));
				cmd.Parameters.AddWithValue("@Name_product", txt_Name_product.Text);
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

		private void DisplayData()
		{
			try
			{
				con.Open();

				SqlCommand cmd = con.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select * from Use_food_for_the_dish";
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
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			con.Open();
			SqlCommand cmd = con.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from Use_food_for_the_dish";
			cmd.ExecuteNonQuery();

			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			con.Close();
		}
	

		private void ClearData()
		{
			txt_ID_dish.Text = "";
			txt_weight_.Text = "";
			txt_Name_product.Text="";
		}

		private void txt_ID_dish_TextChanged     (object sender, EventArgs e) { }
		private void txt_Name_product_TextChanged(object sender, EventArgs e) { }
		private void txt_weight__TextChanged     (object sender, EventArgs e) { }

		private void F_Adm_Modify_Ingredients_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		
	}
}
