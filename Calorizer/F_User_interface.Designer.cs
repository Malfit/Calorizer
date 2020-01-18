namespace Курсач_попытка1
{
	partial class F_User_Interface
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_User_Interface));
			this.button1 = new System.Windows.Forms.Button();
			this.btn_ = new System.Windows.Forms.Button();
			this.tableAdapterManager1 = new Курсач_попытка1.Database1DataSetTableAdapters.TableAdapterManager();
			this.button2 = new System.Windows.Forms.Button();
			this.btn_View_product_list = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.OldLace;
			this.button1.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(222, 186);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(178, 62);
			this.button1.TabIndex = 0;
			this.button1.Text = "Exit";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_
			// 
			this.btn_.BackColor = System.Drawing.Color.OldLace;
			this.btn_.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_.Location = new System.Drawing.Point(222, 13);
			this.btn_.Name = "btn_";
			this.btn_.Size = new System.Drawing.Size(178, 62);
			this.btn_.TabIndex = 2;
			this.btn_.Text = "Bring a new meal";
			this.btn_.UseVisualStyleBackColor = false;
			this.btn_.Click += new System.EventHandler(this.btn__Click);
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
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.OldLace;
			this.button2.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(12, 104);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(181, 62);
			this.button2.TabIndex = 5;
			this.button2.Text = "View list of dishes";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btn_View_product_list
			// 
			this.btn_View_product_list.BackColor = System.Drawing.Color.OldLace;
			this.btn_View_product_list.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_View_product_list.Location = new System.Drawing.Point(12, 12);
			this.btn_View_product_list.Name = "btn_View_product_list";
			this.btn_View_product_list.Size = new System.Drawing.Size(181, 65);
			this.btn_View_product_list.TabIndex = 6;
			this.btn_View_product_list.Text = "View product list";
			this.btn_View_product_list.UseVisualStyleBackColor = false;
			this.btn_View_product_list.Click += new System.EventHandler(this.btn_View_product_list_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.OldLace;
			this.button4.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(12, 185);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(181, 65);
			this.button4.TabIndex = 7;
			this.button4.Text = "View list of ingredients in the dish";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.OldLace;
			this.button3.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(219, 104);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(181, 62);
			this.button3.TabIndex = 8;
			this.button3.Text = "Calculate consumed calories";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// F_User_Interface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(414, 260);
			this.ControlBox = false;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.btn_View_product_list);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btn_);
			this.Controls.Add(this.button1);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "F_User_Interface";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User interface";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_;
		private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btn_View_product_list;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
	}
}