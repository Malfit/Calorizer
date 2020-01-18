using System;

namespace Курсач_попытка1
{
	partial class F_Adm_Modify_Ingredients
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Adm_Modify_Ingredients));
			this.btn_DELETE = new System.Windows.Forms.Button();
			this.btn_UPDATE = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_INSERT = new System.Windows.Forms.Button();
			this.txt_weight_ = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Name_product = new System.Windows.Forms.TextBox();
			this.txt_ID_dish = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_DELETE
			// 
			this.btn_DELETE.BackColor = System.Drawing.Color.OldLace;
			this.btn_DELETE.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DELETE.Location = new System.Drawing.Point(17, 321);
			this.btn_DELETE.Name = "btn_DELETE";
			this.btn_DELETE.Size = new System.Drawing.Size(209, 65);
			this.btn_DELETE.TabIndex = 12;
			this.btn_DELETE.Text = "DELETE";
			this.btn_DELETE.UseVisualStyleBackColor = false;
			this.btn_DELETE.Click += new System.EventHandler(this.btn_DELETE_Click);
			// 
			// btn_UPDATE
			// 
			this.btn_UPDATE.BackColor = System.Drawing.Color.OldLace;
			this.btn_UPDATE.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_UPDATE.Location = new System.Drawing.Point(17, 223);
			this.btn_UPDATE.Name = "btn_UPDATE";
			this.btn_UPDATE.Size = new System.Drawing.Size(209, 65);
			this.btn_UPDATE.TabIndex = 11;
			this.btn_UPDATE.Text = "UPDATE";
			this.btn_UPDATE.UseVisualStyleBackColor = false;
			this.btn_UPDATE.Click += new System.EventHandler(this.btn_UPDATE_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(246, 9);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(356, 473);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// btn_INSERT
			// 
			this.btn_INSERT.BackColor = System.Drawing.Color.OldLace;
			this.btn_INSERT.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_INSERT.Location = new System.Drawing.Point(17, 128);
			this.btn_INSERT.Name = "btn_INSERT";
			this.btn_INSERT.Size = new System.Drawing.Size(209, 64);
			this.btn_INSERT.TabIndex = 8;
			this.btn_INSERT.Text = "INSERT";
			this.btn_INSERT.UseVisualStyleBackColor = false;
			this.btn_INSERT.Click += new System.EventHandler(this.btn_INSERT_Click);
			// 
			// txt_weight_
			// 
			this.txt_weight_.Location = new System.Drawing.Point(114, 87);
			this.txt_weight_.Name = "txt_weight_";
			this.txt_weight_.Size = new System.Drawing.Size(112, 20);
			this.txt_weight_.TabIndex = 15;
			this.txt_weight_.TextChanged += new System.EventHandler(this.txt_weight__TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 22);
			this.label1.TabIndex = 16;
			this.label1.Text = "Weight";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 22);
			this.label2.TabIndex = 17;
			this.label2.Text = "Name product";
			// 
			// txt_Name_product
			// 
			this.txt_Name_product.Location = new System.Drawing.Point(114, 46);
			this.txt_Name_product.Name = "txt_Name_product";
			this.txt_Name_product.Size = new System.Drawing.Size(112, 20);
			this.txt_Name_product.TabIndex = 18;
			this.txt_Name_product.TextChanged += new System.EventHandler(this.txt_Name_product_TextChanged);
			// 
			// txt_ID_dish
			// 
			this.txt_ID_dish.Location = new System.Drawing.Point(114, 9);
			this.txt_ID_dish.Name = "txt_ID_dish";
			this.txt_ID_dish.Size = new System.Drawing.Size(112, 20);
			this.txt_ID_dish.TabIndex = 19;
			this.txt_ID_dish.TextChanged += new System.EventHandler(this.txt_ID_dish_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 22);
			this.label3.TabIndex = 20;
			this.label3.Text = "ID_dish";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.OldLace;
			this.button1.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(17, 415);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(209, 65);
			this.button1.TabIndex = 21;
			this.button1.Text = "EXIT";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// F_Adm_Modify_Ingredients
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(610, 492);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_ID_dish);
			this.Controls.Add(this.txt_Name_product);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_weight_);
			this.Controls.Add(this.btn_DELETE);
			this.Controls.Add(this.btn_UPDATE);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_INSERT);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "F_Adm_Modify_Ingredients";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adm_Modify_Ingredients";
			this.Load += new System.EventHandler(this.F_Adm_Modify_Ingredients_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_DELETE;
		private System.Windows.Forms.Button btn_UPDATE;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_INSERT;
		private System.Windows.Forms.TextBox txt_weight_;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_Name_product;
		private System.Windows.Forms.TextBox txt_ID_dish;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
	}
}