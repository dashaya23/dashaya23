namespace WindowsFormsApp1
{
    partial class Update
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
            this.panelVerh = new System.Windows.Forms.Panel();
            this.labelVerh = new System.Windows.Forms.Label();
            this.pictureBoxLog = new System.Windows.Forms.PictureBox();
            this.buttonNaz = new System.Windows.Forms.Button();
            this.panelVerh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLog)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVerh
            // 
            this.panelVerh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panelVerh.Controls.Add(this.labelVerh);
            this.panelVerh.Controls.Add(this.pictureBoxLog);
            this.panelVerh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVerh.Location = new System.Drawing.Point(0, 0);
            this.panelVerh.Name = "panelVerh";
            this.panelVerh.Size = new System.Drawing.Size(1067, 90);
            this.panelVerh.TabIndex = 2;
            // 
            // labelVerh
            // 
            this.labelVerh.AutoSize = true;
            this.labelVerh.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVerh.Location = new System.Drawing.Point(509, 30);
            this.labelVerh.Name = "labelVerh";
            this.labelVerh.Size = new System.Drawing.Size(185, 27);
            this.labelVerh.TabIndex = 1;
            this.labelVerh.Text = "Изменение товара";
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
            // buttonNaz
            // 
            this.buttonNaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonNaz.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNaz.Location = new System.Drawing.Point(12, 581);
            this.buttonNaz.Name = "buttonNaz";
            this.buttonNaz.Size = new System.Drawing.Size(123, 30);
            this.buttonNaz.TabIndex = 4;
            this.buttonNaz.Text = "Назад";
            this.buttonNaz.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.buttonNaz);
            this.Controls.Add(this.panelVerh);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.panelVerh.ResumeLayout(false);
            this.panelVerh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVerh;
        private System.Windows.Forms.Label labelVerh;
        private System.Windows.Forms.PictureBox pictureBoxLog;
        private System.Windows.Forms.Button buttonNaz;
    }
}