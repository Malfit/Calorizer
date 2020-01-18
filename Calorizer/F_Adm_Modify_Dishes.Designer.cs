namespace Курсач_попытка1
{
	partial class F_Adm_Modify_Dishes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Adm_Modify_Dishes));
			this.button1 = new System.Windows.Forms.Button();
			this.btn_INSERT = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txt_Name_dish = new System.Windows.Forms.TextBox();
			this.btn_UPDATE = new System.Windows.Forms.Button();
			this.btn_DELETE = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.OldLace;
			this.button1.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(23, 274);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(198, 57);
			this.button1.TabIndex = 0;
			this.button1.Text = "EXIT";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_INSERT
			// 
			this.btn_INSERT.BackColor = System.Drawing.Color.OldLace;
			this.btn_INSERT.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_INSERT.Location = new System.Drawing.Point(23, 50);
			this.btn_INSERT.Name = "btn_INSERT";
			this.btn_INSERT.Size = new System.Drawing.Size(198, 56);
			this.btn_INSERT.TabIndex = 1;
			this.btn_INSERT.Text = "INSERT";
			this.btn_INSERT.UseVisualStyleBackColor = false;
			this.btn_INSERT.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(238, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(244, 319);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// txt_Name_dish
			// 
			this.txt_Name_dish.Location = new System.Drawing.Point(102, 12);
			this.txt_Name_dish.Multiline = true;
			this.txt_Name_dish.Name = "txt_Name_dish";
			this.txt_Name_dish.Size = new System.Drawing.Size(119, 22);
			this.txt_Name_dish.TabIndex = 3;
			this.txt_Name_dish.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btn_UPDATE
			// 
			this.btn_UPDATE.BackColor = System.Drawing.Color.OldLace;
			this.btn_UPDATE.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_UPDATE.Location = new System.Drawing.Point(23, 123);
			this.btn_UPDATE.Name = "btn_UPDATE";
			this.btn_UPDATE.Size = new System.Drawing.Size(198, 56);
			this.btn_UPDATE.TabIndex = 4;
			this.btn_UPDATE.Text = "UPDATE";
			this.btn_UPDATE.UseVisualStyleBackColor = false;
			this.btn_UPDATE.Click += new System.EventHandler(this.button3_Click);
			// 
			// btn_DELETE
			// 
			this.btn_DELETE.BackColor = System.Drawing.Color.OldLace;
			this.btn_DELETE.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DELETE.Location = new System.Drawing.Point(23, 200);
			this.btn_DELETE.Name = "btn_DELETE";
			this.btn_DELETE.Size = new System.Drawing.Size(198, 57);
			this.btn_DELETE.TabIndex = 5;
			this.btn_DELETE.Text = "DELETE";
			this.btn_DELETE.UseVisualStyleBackColor = false;
			this.btn_DELETE.Click += new System.EventHandler(this.button4_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 22);
			this.label2.TabIndex = 7;
			this.label2.Text = "Name_dish";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// F_Adm_Modify_Dishes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(507, 347);
			this.ControlBox = false;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_DELETE);
			this.Controls.Add(this.btn_UPDATE);
			this.Controls.Add(this.txt_Name_dish);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_INSERT);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "F_Adm_Modify_Dishes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modify dishes";
			this.Load += new System.EventHandler(this.F_Adm_Modify_Dishes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_INSERT;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txt_Name_dish;
		private System.Windows.Forms.Button btn_UPDATE;
		private System.Windows.Forms.Button btn_DELETE;
		private System.Windows.Forms.Label label2;
	}
}