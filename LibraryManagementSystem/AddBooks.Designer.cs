namespace LibraryManagementSystem
{
    partial class AddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.txtpub = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquan = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 93);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 46);
            this.label6.TabIndex = 2;
            this.label6.Text = "Add Book";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(406, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 464);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.btncancel);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Controls.Add(this.date);
            this.panel3.Controls.Add(this.txtauthor);
            this.panel3.Controls.Add(this.txtpub);
            this.panel3.Controls.Add(this.txtprice);
            this.panel3.Controls.Add(this.txtquan);
            this.panel3.Controls.Add(this.txtname);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblname);
            this.panel3.Location = new System.Drawing.Point(376, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 484);
            this.panel3.TabIndex = 1;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(320, 404);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(140, 38);
            this.btncancel.TabIndex = 13;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(121, 404);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(140, 38);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(261, 219);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(260, 22);
            this.date.TabIndex = 11;
            // 
            // txtauthor
            // 
            this.txtauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtauthor.Location = new System.Drawing.Point(261, 115);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(260, 30);
            this.txtauthor.TabIndex = 10;
            // 
            // txtpub
            // 
            this.txtpub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpub.Location = new System.Drawing.Point(261, 169);
            this.txtpub.Name = "txtpub";
            this.txtpub.Size = new System.Drawing.Size(260, 30);
            this.txtpub.TabIndex = 9;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(261, 269);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(260, 30);
            this.txtprice.TabIndex = 8;
            // 
            // txtquan
            // 
            this.txtquan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquan.Location = new System.Drawing.Point(261, 316);
            this.txtquan.Name = "txtquan";
            this.txtquan.Size = new System.Drawing.Size(260, 30);
            this.txtquan.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(261, 57);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(260, 30);
            this.txtname.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Book Author:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Book Publication:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book Publication Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Quantity:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(34, 61);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(120, 25);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Book Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AddBooks";
            this.Text = "AddBooks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.TextBox txtpub;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquan;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}