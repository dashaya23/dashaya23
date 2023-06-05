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
            this.textBoxPoisk = new System.Windows.Forms.TextBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.radioButtonASC = new System.Windows.Forms.RadioButton();
            this.radioButtonDESC = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.panelVerh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLog)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.flowLayoutPanelProduct.Size = new System.Drawing.Size(1023, 202);
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
            // textBoxPoisk
            // 
            this.textBoxPoisk.Location = new System.Drawing.Point(14, 153);
            this.textBoxPoisk.Name = "textBoxPoisk";
            this.textBoxPoisk.Size = new System.Drawing.Size(132, 26);
            this.textBoxPoisk.TabIndex = 4;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(199, 153);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(177, 26);
            this.comboBoxFilter.TabIndex = 5;
            // 
            // radioButtonASC
            // 
            this.radioButtonASC.AutoSize = true;
            this.radioButtonASC.Checked = true;
            this.radioButtonASC.Location = new System.Drawing.Point(469, 153);
            this.radioButtonASC.Name = "radioButtonASC";
            this.radioButtonASC.Size = new System.Drawing.Size(132, 22);
            this.radioButtonASC.TabIndex = 6;
            this.radioButtonASC.TabStop = true;
            this.radioButtonASC.Text = "По возрастанию";
            this.radioButtonASC.UseVisualStyleBackColor = true;
            // 
            // radioButtonDESC
            // 
            this.radioButtonDESC.AutoSize = true;
            this.radioButtonDESC.Location = new System.Drawing.Point(651, 153);
            this.radioButtonDESC.Name = "radioButtonDESC";
            this.radioButtonDESC.Size = new System.Drawing.Size(115, 22);
            this.radioButtonDESC.TabIndex = 7;
            this.radioButtonDESC.Text = "По убыванию";
            this.radioButtonDESC.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 123);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(834, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "нет на складе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "итолрилоридолитлдирлдвыатмлдтоавломьтлдавотмлдотычвьапжеклвощджорегшортмктрв";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(195, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Подвеска";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.labelFIO.Location = new System.Drawing.Point(877, 104);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(0, 18);
            this.labelFIO.TabIndex = 10;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(992, 140);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 18);
            this.labelCount.TabIndex = 11;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButtonDESC);
            this.Controls.Add(this.radioButtonASC);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.textBoxPoisk);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVerh;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.PictureBox pictureBoxLog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProduct;
        private System.Windows.Forms.Button buttonNaz;
        private System.Windows.Forms.TextBox textBoxPoisk;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.RadioButton radioButtonASC;
        private System.Windows.Forms.RadioButton radioButtonDESC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelCount;
    }
}