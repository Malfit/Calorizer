namespace Курсач_попытка1
{
	partial class Adm_Modify_Products
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adm_Modify_Products));
			this.txt_Name_product = new System.Windows.Forms.Label();
			this.txt_health_benefits = new System.Windows.Forms.Label();
			this.txt_Liquid = new System.Windows.Forms.Label();
			this.btn_DELETE = new System.Windows.Forms.Button();
			this.btn_UPDATE = new System.Windows.Forms.Button();
			this.btn_INSERT = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txt_1 = new System.Windows.Forms.TextBox();
			this.txt_2 = new System.Windows.Forms.TextBox();
			this.txt_3 = new System.Windows.Forms.TextBox();
			this.txt_4 = new System.Windows.Forms.TextBox();
			this.calories_per_100g = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_Name_product
			// 
			this.txt_Name_product.AutoSize = true;
			this.txt_Name_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.txt_Name_product.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Name_product.Location = new System.Drawing.Point(12, 19);
			this.txt_Name_product.Name = "txt_Name_product";
			this.txt_Name_product.Size = new System.Drawing.Size(98, 22);
			this.txt_Name_product.TabIndex = 13;
			this.txt_Name_product.Text = "Name_product";
			this.txt_Name_product.Click += new System.EventHandler(this.txt_Name_product_Click);
			// 
			// txt_health_benefits
			// 
			this.txt_health_benefits.AutoSize = true;
			this.txt_health_benefits.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_health_benefits.Location = new System.Drawing.Point(12, 54);
			this.txt_health_benefits.Name = "txt_health_benefits";
			this.txt_health_benefits.Size = new System.Drawing.Size(105, 22);
			this.txt_health_benefits.TabIndex = 17;
			this.txt_health_benefits.Text = "health_benefits";
			this.txt_health_benefits.Click += new System.EventHandler(this.txt_health_benefits_Click);
			// 
			// txt_Liquid
			// 
			this.txt_Liquid.AutoSize = true;
			this.txt_Liquid.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Liquid.Location = new System.Drawing.Point(13, 122);
			this.txt_Liquid.Name = "txt_Liquid";
			this.txt_Liquid.Size = new System.Drawing.Size(46, 22);
			this.txt_Liquid.TabIndex = 19;
			this.txt_Liquid.Text = "Liquid";
			this.txt_Liquid.Click += new System.EventHandler(this.txt_Liquid_Click);
			// 
			// btn_DELETE
			// 
			this.btn_DELETE.BackColor = System.Drawing.Color.OldLace;
			this.btn_DELETE.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DELETE.Location = new System.Drawing.Point(15, 315);
			this.btn_DELETE.Name = "btn_DELETE";
			this.btn_DELETE.Size = new System.Drawing.Size(272, 56);
			this.btn_DELETE.TabIndex = 12;
			this.btn_DELETE.Text = "DELETE";
			this.btn_DELETE.UseVisualStyleBackColor = false;
			this.btn_DELETE.Click += new System.EventHandler(this.btn_DELETE_Click);
			// 
			// btn_UPDATE
			// 
			this.btn_UPDATE.BackColor = System.Drawing.Color.OldLace;
			this.btn_UPDATE.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_UPDATE.Location = new System.Drawing.Point(15, 235);
			this.btn_UPDATE.Name = "btn_UPDATE";
			this.btn_UPDATE.Size = new System.Drawing.Size(272, 56);
			this.btn_UPDATE.TabIndex = 11;
			this.btn_UPDATE.Text = "UPDATE";
			this.btn_UPDATE.UseVisualStyleBackColor = false;
			this.btn_UPDATE.Click += new System.EventHandler(this.btn_UPDATE_Click);
			// 
			// btn_INSERT
			// 
			this.btn_INSERT.BackColor = System.Drawing.Color.OldLace;
			this.btn_INSERT.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_INSERT.Location = new System.Drawing.Point(15, 157);
			this.btn_INSERT.Name = "btn_INSERT";
			this.btn_INSERT.Size = new System.Drawing.Size(272, 56);
			this.btn_INSERT.TabIndex = 8;
			this.btn_INSERT.Text = "INSERT";
			this.btn_INSERT.UseVisualStyleBackColor = false;
			this.btn_INSERT.Click += new System.EventHandler(this.btn_INSERT_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(307, 19);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(456, 428);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// txt_1
			// 
			this.txt_1.Location = new System.Drawing.Point(137, 19);
			this.txt_1.Name = "txt_1";
			this.txt_1.Size = new System.Drawing.Size(150, 20);
			this.txt_1.TabIndex = 14;
			this.txt_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txt_2
			// 
			this.txt_2.Location = new System.Drawing.Point(137, 54);
			this.txt_2.Name = "txt_2";
			this.txt_2.Size = new System.Drawing.Size(150, 20);
			this.txt_2.TabIndex = 15;
			this.txt_2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// txt_3
			// 
			this.txt_3.Location = new System.Drawing.Point(137, 90);
			this.txt_3.Name = "txt_3";
			this.txt_3.Size = new System.Drawing.Size(150, 20);
			this.txt_3.TabIndex = 16;
			this.txt_3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// txt_4
			// 
			this.txt_4.Location = new System.Drawing.Point(137, 122);
			this.txt_4.Name = "txt_4";
			this.txt_4.Size = new System.Drawing.Size(150, 20);
			this.txt_4.TabIndex = 20;
			this.txt_4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// calories_per_100g
			// 
			this.calories_per_100g.AutoSize = true;
			this.calories_per_100g.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calories_per_100g.Location = new System.Drawing.Point(12, 90);
			this.calories_per_100g.Name = "calories_per_100g";
			this.calories_per_100g.Size = new System.Drawing.Size(124, 22);
			this.calories_per_100g.TabIndex = 21;
			this.calories_per_100g.Text = "calories_per_100g";
			this.calories_per_100g.Click += new System.EventHandler(this.calories_per_100g_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.OldLace;
			this.button1.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(15, 391);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(272, 56);
			this.button1.TabIndex = 22;
			this.button1.Text = "EXIT";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Adm_Modify_Products
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(776, 459);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.calories_per_100g);
			this.Controls.Add(this.txt_4);
			this.Controls.Add(this.txt_Liquid);
			this.Controls.Add(this.txt_health_benefits);
			this.Controls.Add(this.txt_3);
			this.Controls.Add(this.txt_2);
			this.Controls.Add(this.txt_1);
			this.Controls.Add(this.txt_Name_product);
			this.Controls.Add(this.btn_DELETE);
			this.Controls.Add(this.btn_UPDATE);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_INSERT);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Adm_Modify_Products";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adm_Modify_Products";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label txt_Name_product;
		private System.Windows.Forms.Button btn_DELETE;
		private System.Windows.Forms.Button btn_UPDATE;
		
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_INSERT;
		private System.Windows.Forms.TextBox txt_1;
		private System.Windows.Forms.TextBox txt_2;
		private System.Windows.Forms.TextBox txt_3;
		private System.Windows.Forms.Label txt_health_benefits;
		private System.Windows.Forms.Label txt_Liquid;
		private System.Windows.Forms.TextBox txt_4;
		private System.Windows.Forms.Label calories_per_100g;
		private System.Windows.Forms.Button button1;
	}
}