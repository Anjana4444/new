namespace LibraryManagementSystem
{
    partial class FrmNVMLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNVMLibrary));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonFictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resurveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblBookNameOrAuther = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.resurveToolStripMenuItem,
            this.returnBooksToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(730, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fictionToolStripMenuItem,
            this.nonFictionToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // fictionToolStripMenuItem
            // 
            this.fictionToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.fictionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fictionToolStripMenuItem.Image")));
            this.fictionToolStripMenuItem.Name = "fictionToolStripMenuItem";
            this.fictionToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.fictionToolStripMenuItem.Text = "Add New Book";
            this.fictionToolStripMenuItem.Click += new System.EventHandler(this.fictionToolStripMenuItem_Click);
            // 
            // nonFictionToolStripMenuItem
            // 
            this.nonFictionToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.nonFictionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nonFictionToolStripMenuItem.Image")));
            this.nonFictionToolStripMenuItem.Name = "nonFictionToolStripMenuItem";
            this.nonFictionToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.nonFictionToolStripMenuItem.Text = "View Books";
            this.nonFictionToolStripMenuItem.Click += new System.EventHandler(this.nonFictionToolStripMenuItem_Click);
            // 
            // resurveToolStripMenuItem
            // 
            this.resurveToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resurveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resurveToolStripMenuItem.Image")));
            this.resurveToolStripMenuItem.Name = "resurveToolStripMenuItem";
            this.resurveToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.resurveToolStripMenuItem.Text = "Issue Books";
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnBooksToolStripMenuItem.Image")));
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.returnBooksToolStripMenuItem.Text = "Return Books";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewToolStripMenuItem.Image")));
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.addNewToolStripMenuItem.Text = "Book Details";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // LblBookNameOrAuther
            // 
            this.LblBookNameOrAuther.AutoSize = true;
            this.LblBookNameOrAuther.Location = new System.Drawing.Point(147, 80);
            this.LblBookNameOrAuther.Name = "LblBookNameOrAuther";
            this.LblBookNameOrAuther.Size = new System.Drawing.Size(0, 17);
            this.LblBookNameOrAuther.TabIndex = 3;
            // 
            // FrmNVMLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(730, 498);
            this.Controls.Add(this.LblBookNameOrAuther);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmNVMLibrary";
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resurveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fictionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonFictionToolStripMenuItem;
        private System.Windows.Forms.Label LblBookNameOrAuther;
    }
}

