namespace crud_prac
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>


        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.usuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.contrase = new Guna.UI2.WinForms.Guna2TextBox();
            this.materialRaisedButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(122, 141);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Usuario";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(113, 219);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(86, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Contraseña";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // usuario
            // 
            this.usuario.BorderRadius = 5;
            this.usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usuario.DefaultText = "";
            this.usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usuario.DisabledState.Parent = this.usuario;
            this.usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usuario.FocusedState.Parent = this.usuario;
            this.usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usuario.HoverState.Parent = this.usuario;
            this.usuario.Location = new System.Drawing.Point(64, 180);
            this.usuario.Name = "usuario";
            this.usuario.PasswordChar = '\0';
            this.usuario.PlaceholderText = "";
            this.usuario.SelectedText = "";
            this.usuario.ShadowDecoration.Parent = this.usuario;
            this.usuario.Size = new System.Drawing.Size(200, 36);
            this.usuario.TabIndex = 8;
            // 
            // contrase
            // 
            this.contrase.BorderRadius = 5;
            this.contrase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contrase.DefaultText = "";
            this.contrase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contrase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contrase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contrase.DisabledState.Parent = this.contrase;
            this.contrase.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contrase.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contrase.FocusedState.Parent = this.contrase;
            this.contrase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contrase.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contrase.HoverState.Parent = this.contrase;
            this.contrase.Location = new System.Drawing.Point(64, 250);
            this.contrase.Name = "contrase";
            this.contrase.PasswordChar = '\0';
            this.contrase.PlaceholderText = "";
            this.contrase.SelectedText = "";
            this.contrase.ShadowDecoration.Parent = this.contrase;
            this.contrase.Size = new System.Drawing.Size(200, 36);
            this.contrase.TabIndex = 9;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.materialRaisedButton1.BorderRadius = 5;
            this.materialRaisedButton1.CheckedState.Parent = this.materialRaisedButton1;
            this.materialRaisedButton1.CustomImages.Parent = this.materialRaisedButton1;
            this.materialRaisedButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.materialRaisedButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.materialRaisedButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.materialRaisedButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.materialRaisedButton1.DisabledState.Parent = this.materialRaisedButton1;
            this.materialRaisedButton1.FillColor = System.Drawing.Color.RoyalBlue;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.materialRaisedButton1.ForeColor = System.Drawing.Color.White;
            this.materialRaisedButton1.HoverState.Parent = this.materialRaisedButton1;
            this.materialRaisedButton1.Location = new System.Drawing.Point(73, 320);
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.ShadowDecoration.Parent = this.materialRaisedButton1;
            this.materialRaisedButton1.Size = new System.Drawing.Size(179, 43);
            this.materialRaisedButton1.TabIndex = 10;
            this.materialRaisedButton1.Text = "Entrar";
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(331, 487);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.contrase);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Guna.UI2.WinForms.Guna2TextBox usuario;
        private Guna.UI2.WinForms.Guna2TextBox contrase;
        private Guna.UI2.WinForms.Guna2Button materialRaisedButton1;
    }
}

