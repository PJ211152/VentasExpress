namespace VentasExpress
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.txb_Contraseña = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Ingresar = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.Location = new System.Drawing.Point(93, 120);
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.Size = new System.Drawing.Size(177, 20);
            this.txb_Usuario.TabIndex = 0;
            // 
            // txb_Contraseña
            // 
            this.txb_Contraseña.Location = new System.Drawing.Point(93, 177);
            this.txb_Contraseña.Name = "txb_Contraseña";
            this.txb_Contraseña.Size = new System.Drawing.Size(177, 20);
            this.txb_Contraseña.TabIndex = 1;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Usuario.Location = new System.Drawing.Point(158, 104);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 2;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Contraseña.Location = new System.Drawing.Point(152, 161);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_Contraseña.TabIndex = 3;
            this.lbl_Contraseña.Text = "Contraseña";
            this.lbl_Contraseña.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.White;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Location = new System.Drawing.Point(79, 220);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(200, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Ingresar";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Ingresar
            // 
            this.lbl_Ingresar.AutoSize = true;
            this.lbl_Ingresar.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ingresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Ingresar.Location = new System.Drawing.Point(98, 42);
            this.lbl_Ingresar.Name = "lbl_Ingresar";
            this.lbl_Ingresar.Size = new System.Drawing.Size(172, 38);
            this.lbl_Ingresar.TabIndex = 5;
            this.lbl_Ingresar.Text = "Ingresar";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(143, 249);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Salir";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(354, 318);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_Ingresar);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.txb_Contraseña);
            this.Controls.Add(this.txb_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Usuario;
        private System.Windows.Forms.TextBox txb_Contraseña;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Ingresar;
        private System.Windows.Forms.Button btn_Exit;
    }
}

