namespace WindowsFormsApp1
{
    partial class FormUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.panelVerh = new System.Windows.Forms.Panel();
            this.labelAvtor = new System.Windows.Forms.Label();
            this.pictureBoxLog = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPas = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.buttonVoiti = new System.Windows.Forms.Button();
            this.buttonGost = new System.Windows.Forms.Button();
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.buttonCaptchaRefref = new System.Windows.Forms.Button();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            this.timerCaptcha = new System.Windows.Forms.Timer(this.components);
            this.panelVerh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVerh
            // 
            this.panelVerh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panelVerh.Controls.Add(this.labelAvtor);
            this.panelVerh.Controls.Add(this.pictureBoxLog);
            this.panelVerh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVerh.Location = new System.Drawing.Point(0, 0);
            this.panelVerh.Name = "panelVerh";
            this.panelVerh.Size = new System.Drawing.Size(429, 90);
            this.panelVerh.TabIndex = 0;
            // 
            // labelAvtor
            // 
            this.labelAvtor.AutoSize = true;
            this.labelAvtor.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvtor.Location = new System.Drawing.Point(182, 31);
            this.labelAvtor.Name = "labelAvtor";
            this.labelAvtor.Size = new System.Drawing.Size(157, 27);
            this.labelAvtor.TabIndex = 1;
            this.labelAvtor.Text = "ООО \"Ювелир\"";
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
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(72, 139);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(48, 19);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин";
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPas.Location = new System.Drawing.Point(63, 188);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(57, 19);
            this.labelPas.TabIndex = 2;
            this.labelPas.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(143, 137);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(216, 26);
            this.textBoxLogin.TabIndex = 3;
            // 
            // textBoxPas
            // 
            this.textBoxPas.Location = new System.Drawing.Point(143, 186);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.PasswordChar = '*';
            this.textBoxPas.Size = new System.Drawing.Size(216, 26);
            this.textBoxPas.TabIndex = 4;
            // 
            // buttonVoiti
            // 
            this.buttonVoiti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonVoiti.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVoiti.Location = new System.Drawing.Point(155, 243);
            this.buttonVoiti.Name = "buttonVoiti";
            this.buttonVoiti.Size = new System.Drawing.Size(126, 32);
            this.buttonVoiti.TabIndex = 5;
            this.buttonVoiti.Text = "Войти";
            this.buttonVoiti.UseVisualStyleBackColor = false;
            this.buttonVoiti.Click += new System.EventHandler(this.buttonVoiti_Click);
            // 
            // buttonGost
            // 
            this.buttonGost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonGost.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGost.Location = new System.Drawing.Point(155, 290);
            this.buttonGost.Name = "buttonGost";
            this.buttonGost.Size = new System.Drawing.Size(126, 32);
            this.buttonGost.TabIndex = 6;
            this.buttonGost.Text = "Войти как гость";
            this.buttonGost.UseVisualStyleBackColor = false;
            this.buttonGost.Click += new System.EventHandler(this.buttonGost_Click);
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(104, 341);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(235, 75);
            this.pictureBoxCaptcha.TabIndex = 7;
            this.pictureBoxCaptcha.TabStop = false;
            // 
            // buttonCaptchaRefref
            // 
            this.buttonCaptchaRefref.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonCaptchaRefref.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCaptchaRefref.Location = new System.Drawing.Point(155, 458);
            this.buttonCaptchaRefref.Name = "buttonCaptchaRefref";
            this.buttonCaptchaRefref.Size = new System.Drawing.Size(126, 32);
            this.buttonCaptchaRefref.TabIndex = 8;
            this.buttonCaptchaRefref.Text = "Обновить";
            this.buttonCaptchaRefref.UseVisualStyleBackColor = false;
            this.buttonCaptchaRefref.Click += new System.EventHandler(this.buttonCaptchaRefref_Click);
            // 
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.Location = new System.Drawing.Point(155, 422);
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(126, 26);
            this.textBoxCaptcha.TabIndex = 9;
            // 
            // timerCaptcha
            // 
            this.timerCaptcha.Interval = 10000;
            this.timerCaptcha.Tick += new System.EventHandler(this.timerCaptcha_Tick);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 331);
            this.Controls.Add(this.textBoxCaptcha);
            this.Controls.Add(this.buttonCaptchaRefref);
            this.Controls.Add(this.pictureBoxCaptcha);
            this.Controls.Add(this.buttonGost);
            this.Controls.Add(this.buttonVoiti);
            this.Controls.Add(this.textBoxPas);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPas);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.panelVerh);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(445, 560);
            this.MinimumSize = new System.Drawing.Size(445, 370);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.panelVerh.ResumeLayout(false);
            this.panelVerh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVerh;
        private System.Windows.Forms.PictureBox pictureBoxLog;
        private System.Windows.Forms.Label labelAvtor;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.Button buttonVoiti;
        private System.Windows.Forms.Button buttonGost;
        private System.Windows.Forms.PictureBox pictureBoxCaptcha;
        private System.Windows.Forms.Button buttonCaptchaRefref;
        private System.Windows.Forms.TextBox textBoxCaptcha;
        private System.Windows.Forms.Timer timerCaptcha;
    }
}

