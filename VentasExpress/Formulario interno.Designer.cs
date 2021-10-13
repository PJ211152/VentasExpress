namespace VentasExpress
{
    partial class Formulario_interno
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Venta = new System.Windows.Forms.TabPage();
            this.tab_Consulta = new System.Windows.Forms.TabPage();
            this.tab_salir = new System.Windows.Forms.TabPage();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_ventas = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Venta);
            this.tabControl1.Controls.Add(this.tab_Consulta);
            this.tabControl1.Controls.Add(this.tab_salir);
            this.tabControl1.Location = new System.Drawing.Point(9, 45);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 337);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_Venta
            // 
            this.tab_Venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tab_Venta.Location = new System.Drawing.Point(4, 22);
            this.tab_Venta.Name = "tab_Venta";
            this.tab_Venta.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Venta.Size = new System.Drawing.Size(720, 311);
            this.tab_Venta.TabIndex = 0;
            this.tab_Venta.Text = "Venta Nueva";
            // 
            // tab_Consulta
            // 
            this.tab_Consulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tab_Consulta.Location = new System.Drawing.Point(4, 22);
            this.tab_Consulta.Name = "tab_Consulta";
            this.tab_Consulta.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Consulta.Size = new System.Drawing.Size(720, 311);
            this.tab_Consulta.TabIndex = 1;
            this.tab_Consulta.Text = "Consultar Inventarios";
            // 
            // tab_salir
            // 
            this.tab_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tab_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tab_salir.Location = new System.Drawing.Point(4, 22);
            this.tab_salir.Margin = new System.Windows.Forms.Padding(0);
            this.tab_salir.Name = "tab_salir";
            this.tab_salir.Size = new System.Drawing.Size(720, 311);
            this.tab_salir.TabIndex = 2;
            this.tab_salir.Text = "Salir";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Maroon;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_close.Location = new System.Drawing.Point(711, 8);
            this.btn_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_ventas
            // 
            this.lbl_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbl_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ventas.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ventas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ventas.Location = new System.Drawing.Point(0, 0);
            this.lbl_ventas.Name = "lbl_ventas";
            this.lbl_ventas.Size = new System.Drawing.Size(749, 37);
            this.lbl_ventas.TabIndex = 3;
            this.lbl_ventas.Text = "Ventas Express";
            this.lbl_ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Formulario_interno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(748, 391);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_ventas);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario_interno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario interno";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formulario_interno_FormClosed);
            this.Load += new System.EventHandler(this.Formulario_interno_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Venta;
        private System.Windows.Forms.TabPage tab_Consulta;
        private System.Windows.Forms.TabPage tab_salir;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_ventas;
    }
}