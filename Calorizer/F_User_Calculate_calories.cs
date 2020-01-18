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
	public partial class F_User_Calculate_calories : Form
	{
		public F_User_Calculate_calories()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sasha\source\repos\Курсач_попытка1\Курсач_попытка1\Database1.mdf;Integrated Security=True");
		SqlCommand cmd;

		private void F_User_Calculate_calories_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			con.Open();

			SqlCommand cmd = con.CreateCommand();
			cmd.CommandType = CommandType.Text;
			//string d1 = dtp1.Value.Year.ToString() + "-" + dtp1.Value.Day.ToString() + "-" + dtp1.Value.Month.ToString();
			cmd.CommandText = "SELECT sum(Volume_eat_dish * weight_ * calories_per_100g/100) AS Calories From Eat_dish, Dish, Use_food_for_the_dish, Products Where Eat_dish.ID_dish = Dish.ID_dish AND Dish.ID_dish = Use_food_for_the_dish.ID_dish AND Use_food_for_the_dish.Name_product = Products.Name_product AND Day(Date_) = '"+txt2.Text+"' AND Month(Date_) = '"+txt3.Text+"' AND Year(Date_) = '"+txt4.Text+"' group by ID_user";
			//cmd.CommandText = "SELECT sum(Volume_eat_dish * weight_ * calories_per_100g) AS Calories From Eat_dish, Dish, Use_food_for_the_dish, Products Where Eat_dish.ID_dish = Dish.ID_dish AND Dish.ID_dish = Use_food_for_the_dish.ID_dish AND Use_food_for_the_dish.Name_product = Products.Name_product AND Date_ ='" + d1 + "' group by ID_user";
			//"Select Date_ From Eat_dish Where  Date_ = '" + Convert.ToDateTime(dtp1.Value.ToString());

			cmd.ExecuteNonQuery();

			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			foreach (DataRow dr in dt.Rows)
			{
				txt_1.Text = dr["Calories"].ToString();
			}

			con.Close();
		//	SELECT sum(Volume_eat_dish* weight_ *calories_per_100g)
  //      From Eat_dish, Dish, Use_food_for_the_dish, Products
		//Where
		//Eat_dish.ID_dish = Dish.ID_dish AND
		//Dish.ID_dish = Use_food_for_the_dish.ID_dish AND
		//Use_food_for_the_dish.Name_product = Products.Name_product


		//group by ID_user
		}
		//Select 
	}
}
