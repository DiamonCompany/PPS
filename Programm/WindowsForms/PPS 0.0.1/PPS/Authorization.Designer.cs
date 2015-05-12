namespace PPS
{
    partial class Authorization
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_registry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(10, 20);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(38, 13);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Логин";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(10, 60);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(45, 13);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Пароль";
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(79, 17);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(147, 20);
            this.tb_Login.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(79, 57);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(147, 20);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(32, 94);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(80, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Вход";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_registry
            // 
            this.btn_registry.Location = new System.Drawing.Point(132, 94);
            this.btn_registry.Name = "btn_registry";
            this.btn_registry.Size = new System.Drawing.Size(80, 23);
            this.btn_registry.TabIndex = 5;
            this.btn_registry.Text = "Регистрация";
            this.btn_registry.UseVisualStyleBackColor = true;
            this.btn_registry.Click += new System.EventHandler(this.btn_registry_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 133);
            this.Controls.Add(this.btn_registry);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Login);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void createRegistry()
        {
            if (this.lbl_FirstName == null)
            {
                this.lbl_Password2 = new System.Windows.Forms.Label();
                this.lbl_FirstName = new System.Windows.Forms.Label();
                this.lbl_SurName = new System.Windows.Forms.Label();
                this.tb_Password2 = new System.Windows.Forms.TextBox();
                this.tb_FirstName = new System.Windows.Forms.TextBox();
                this.tb_SurName = new System.Windows.Forms.TextBox();
            }
            else
            {
                this.lbl_Password2.Visible = true;
                this.lbl_FirstName.Visible = true;
                this.lbl_SurName.Visible = true;
                this.tb_Password2.Visible = true;
                this.tb_FirstName.Visible = true;
                this.tb_SurName.Visible = true;
            }
            // 
            // lbl_Password2
            // 
            this.lbl_Password2.AutoSize = true;
            this.lbl_Password2.Location = new System.Drawing.Point(10, 100);
            this.lbl_Password2.Name = "lbl_Password2";
            this.lbl_Password2.Size = new System.Drawing.Size(38, 13);
            this.lbl_Password2.TabIndex = 0;
            this.lbl_Password2.Text = "Подвердите";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(10, 140);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(38, 13);
            this.lbl_FirstName.TabIndex = 0;
            this.lbl_FirstName.Text = "Имя";
            // 
            // lbl_SurName
            // 
            this.lbl_SurName.AutoSize = true;
            this.lbl_SurName.Location = new System.Drawing.Point(10, 180);
            this.lbl_SurName.Name = "lbl_SurName";
            this.lbl_SurName.Size = new System.Drawing.Size(38, 13);
            this.lbl_SurName.TabIndex = 0;
            this.lbl_SurName.Text = "Фамилия";
            // 
            // tb_Password2
            // 
            this.tb_Password2.Location = new System.Drawing.Point(79, 97);
            this.tb_Password2.Name = "tb_Password2";
            this.tb_Password2.Size = new System.Drawing.Size(147, 20);
            this.tb_Password2.TabIndex = 3;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(79, 137);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(147, 20);
            this.tb_FirstName.TabIndex = 3;
            // 
            // tb_SurName
            // 
            this.tb_SurName.Location = new System.Drawing.Point(79, 177);
            this.tb_SurName.Name = "tb_SurName";
            this.tb_SurName.Size = new System.Drawing.Size(147, 20);
            this.tb_SurName.TabIndex = 3;
            // 
            // Authorization
            //
            this.Controls.Add(this.lbl_Password2);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.lbl_SurName);
            this.Controls.Add(this.tb_Password2);
            this.Controls.Add(this.tb_FirstName);
            this.Controls.Add(this.tb_SurName);
        }

        private void deleteRegistry()
        {
            this.lbl_Password2.Visible = false;
            this.lbl_FirstName.Visible = false;
            this.lbl_SurName.Visible = false;
            this.tb_Password2.Visible = false;
            this.tb_FirstName.Visible = false;
            this.tb_SurName.Visible = false;
        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Password2;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_SurName;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Password2;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.TextBox tb_SurName;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_registry;
    }
}

