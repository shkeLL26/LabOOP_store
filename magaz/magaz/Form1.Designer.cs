namespace magaz
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pageAllProducts = new System.Windows.Forms.TabPage();
            this.listView4 = new System.Windows.Forms.ListView();
            this.pageOther = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.pageTools = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.pageMicroelectronics = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.buttonCart = new System.Windows.Forms.Button();
            this.pageAllProducts.SuspendLayout();
            this.pageOther.SuspendLayout();
            this.pageTools.SuspendLayout();
            this.pageMicroelectronics.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(744, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(168, 28);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Вход";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pageAllProducts
            // 
            this.pageAllProducts.Controls.Add(this.listView4);
            this.pageAllProducts.Location = new System.Drawing.Point(4, 24);
            this.pageAllProducts.Name = "pageAllProducts";
            this.pageAllProducts.Padding = new System.Windows.Forms.Padding(3);
            this.pageAllProducts.Size = new System.Drawing.Size(912, 400);
            this.pageAllProducts.TabIndex = 3;
            this.pageAllProducts.Text = "Все товары";
            this.pageAllProducts.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            this.listView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(3, 3);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(906, 394);
            this.listView4.TabIndex = 1;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // pageOther
            // 
            this.pageOther.Controls.Add(this.listView3);
            this.pageOther.Location = new System.Drawing.Point(4, 24);
            this.pageOther.Name = "pageOther";
            this.pageOther.Padding = new System.Windows.Forms.Padding(3);
            this.pageOther.Size = new System.Drawing.Size(912, 400);
            this.pageOther.TabIndex = 2;
            this.pageOther.Text = "Другое";
            this.pageOther.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(3, 3);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(906, 394);
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // pageTools
            // 
            this.pageTools.Controls.Add(this.listView2);
            this.pageTools.Location = new System.Drawing.Point(4, 24);
            this.pageTools.Name = "pageTools";
            this.pageTools.Padding = new System.Windows.Forms.Padding(3);
            this.pageTools.Size = new System.Drawing.Size(912, 400);
            this.pageTools.TabIndex = 1;
            this.pageTools.Text = "Инструменты";
            this.pageTools.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(906, 394);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // pageMicroelectronics
            // 
            this.pageMicroelectronics.Controls.Add(this.listView1);
            this.pageMicroelectronics.Location = new System.Drawing.Point(4, 24);
            this.pageMicroelectronics.Name = "pageMicroelectronics";
            this.pageMicroelectronics.Padding = new System.Windows.Forms.Padding(3);
            this.pageMicroelectronics.Size = new System.Drawing.Size(912, 400);
            this.pageMicroelectronics.TabIndex = 0;
            this.pageMicroelectronics.Text = "Микроэлектроника";
            this.pageMicroelectronics.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(906, 394);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageMicroelectronics);
            this.tabControl1.Controls.Add(this.pageTools);
            this.tabControl1.Controls.Add(this.pageOther);
            this.tabControl1.Controls.Add(this.pageAllProducts);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 428);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // buttonCart
            // 
            this.buttonCart.BackgroundImage = global::magaz.Properties.Resources.shoppingCart;
            this.buttonCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCart.Location = new System.Drawing.Point(700, 12);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Size = new System.Drawing.Size(39, 28);
            this.buttonCart.TabIndex = 1;
            this.buttonCart.UseVisualStyleBackColor = true;
            this.buttonCart.Click += new System.EventHandler(this.buttonCart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 474);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCart);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form1";
            this.Text = "MyChipDip";
            this.pageAllProducts.ResumeLayout(false);
            this.pageOther.ResumeLayout(false);
            this.pageTools.ResumeLayout(false);
            this.pageMicroelectronics.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCart;
        private System.Windows.Forms.TabPage pageAllProducts;
        private System.Windows.Forms.TabPage pageOther;
        private System.Windows.Forms.TabPage pageTools;
        private System.Windows.Forms.TabPage pageMicroelectronics;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
    }
}

