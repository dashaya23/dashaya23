namespace WindowsFormsApp1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelVerh = new System.Windows.Forms.Panel();
            this.labelMenu = new System.Windows.Forms.Label();
            this.pictureBoxLog = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNaz = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelFIO = new System.Windows.Forms.Label();
            this.panelVerh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLog)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVerh
            // 
            this.panelVerh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panelVerh.Controls.Add(this.labelMenu);
            this.panelVerh.Controls.Add(this.pictureBoxLog);
            this.panelVerh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVerh.Location = new System.Drawing.Point(0, 0);
            this.panelVerh.Name = "panelVerh";
            this.panelVerh.Size = new System.Drawing.Size(1067, 90);
            this.panelVerh.TabIndex = 1;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenu.Location = new System.Drawing.Point(509, 30);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(149, 27);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "Главное меню";
            // 
            // pictureBoxLog
            // 
            this.pictureBoxLog.Image = global::WindowsFormsApp1.Properties.Resources.logo;
            this.pictureBoxLog.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLog.Name = "pictureBoxLog";
            this.pictureBoxLog.Size = new System.Drawing.Size(93, 90);
            this.pictureBoxLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLog.TabIndex = 0;
            this.pictureBoxLog.TabStop = false;
            // 
            // flowLayoutPanelProduct
            // 
            this.flowLayoutPanelProduct.AutoScroll = true;
            this.flowLayoutPanelProduct.Location = new System.Drawing.Point(12, 199);
            this.flowLayoutPanelProduct.Name = "flowLayoutPanelProduct";
            this.flowLayoutPanelProduct.Size = new System.Drawing.Size(1023, 355);
            this.flowLayoutPanelProduct.TabIndex = 2;
            // 
            // buttonNaz
            // 
            this.buttonNaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonNaz.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNaz.Location = new System.Drawing.Point(23, 576);
            this.buttonNaz.Name = "buttonNaz";
            this.buttonNaz.Size = new System.Drawing.Size(123, 30);
            this.buttonNaz.TabIndex = 3;
            this.buttonNaz.Text = "Назад";
            this.buttonNaz.UseVisualStyleBackColor = false;
            this.buttonNaz.Click += new System.EventHandler(this.buttonNaz_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonAdd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(481, 576);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(177, 30);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить товары";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(812, 103);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(0, 18);
            this.labelFIO.TabIndex = 10;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonNaz);
            this.Controls.Add(this.flowLayoutPanelProduct);
            this.Controls.Add(this.panelVerh);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelVerh.ResumeLayout(false);
            this.panelVerh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVerh;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.PictureBox pictureBoxLog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProduct;
        private System.Windows.Forms.Button buttonNaz;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelFIO;
    }
}