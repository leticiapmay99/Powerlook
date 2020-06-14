namespace PowerLook_Aluguel
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label login1Label;
            System.Windows.Forms.Label senhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login1TextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            login1Label = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login1Label
            // 
            login1Label.AutoSize = true;
            login1Label.Location = new System.Drawing.Point(378, 137);
            login1Label.Name = "login1Label";
            login1Label.Size = new System.Drawing.Size(36, 13);
            login1Label.TabIndex = 1;
            login1Label.Text = "Login:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(377, 173);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 3;
            senhaLabel.Text = "Senha:";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataSource = typeof(DBPowerLook.DAL.Login);
            // 
            // login1TextBox
            // 
            this.login1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "login1", true));
            this.login1TextBox.Location = new System.Drawing.Point(422, 134);
            this.login1TextBox.Name = "login1TextBox";
            this.login1TextBox.Size = new System.Drawing.Size(100, 20);
            this.login1TextBox.TabIndex = 2;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(422, 170);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.senhaTextBox.TabIndex = 4;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(372, 214);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 33);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(478, 214);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 33);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(603, 347);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(login1Label);
            this.Controls.Add(this.login1TextBox);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource loginBindingSource;
        private System.Windows.Forms.TextBox login1TextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}