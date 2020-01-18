namespace Курсач_попытка1
{
	partial class F_User_Calculate_calories
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_User_Calculate_calories));
			this.tableAdapterManager1 = new Курсач_попытка1.Database1DataSetTableAdapters.TableAdapterManager();
			this.button1 = new System.Windows.Forms.Button();
			this.txt_1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tableAdapterManager1
			// 
			this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager1.Connection = null;
			this.tableAdapterManager1.DishTableAdapter = null;
			this.tableAdapterManager1.Eat_dishTableAdapter = null;
			this.tableAdapterManager1.ProductsTableAdapter = null;
			this.tableAdapterManager1.UpdateOrder = Курсач_попытка1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager1.Use_food_for_the_dishTableAdapter = null;
			this.tableAdapterManager1.UserTableAdapter = null;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(33, 262);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(193, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Count calories";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txt_1
			// 
			this.txt_1.Location = new System.Drawing.Point(31, 310);
			this.txt_1.Multiline = true;
			this.txt_1.Name = "txt_1";
			this.txt_1.Size = new System.Drawing.Size(195, 91);
			this.txt_1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 31);
			this.label1.TabIndex = 3;
			this.label1.Text = "Enter data";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(29, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Month";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(29, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "Year";
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(32, 98);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(194, 20);
			this.txt2.TabIndex = 6;
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(31, 159);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(195, 20);
			this.txt3.TabIndex = 7;
			// 
			// txt4
			// 
			this.txt4.Location = new System.Drawing.Point(31, 220);
			this.txt4.Name = "txt4";
			this.txt4.Size = new System.Drawing.Size(195, 20);
			this.txt4.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(29, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 22);
			this.label4.TabIndex = 9;
			this.label4.Text = "Day";
			// 
			// F_User_Calculate_calories
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(258, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt4);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_1);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "F_User_Calculate_calories";
			this.Text = "F_User_Calculate_calories";
			this.Load += new System.EventHandler(this.F_User_Calculate_calories_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txt_1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.Label label4;
	}
}