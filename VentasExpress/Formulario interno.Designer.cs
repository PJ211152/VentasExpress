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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Ordenar = new System.Windows.Forms.TextBox();
            this.btn_Ordenar = new System.Windows.Forms.Button();
            this.dgw_Productos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Consulta = new System.Windows.Forms.TabPage();
            this.txb_Consultar = new System.Windows.Forms.TextBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.dgw_Consulta = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_salir = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_ExitConfirmation = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_ventas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_Venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Productos)).BeginInit();
            this.tab_Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Consulta)).BeginInit();
            this.tab_salir.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Venta);
            this.tabControl1.Controls.Add(this.tab_Consulta);
            this.tabControl1.Controls.Add(this.tab_salir);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
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
            this.tab_Venta.Controls.Add(this.label2);
            this.tab_Venta.Controls.Add(this.label1);
            this.tab_Venta.Controls.Add(this.txb_Ordenar);
            this.tab_Venta.Controls.Add(this.btn_Ordenar);
            this.tab_Venta.Controls.Add(this.dgw_Productos);
            this.tab_Venta.Location = new System.Drawing.Point(4, 22);
            this.tab_Venta.Name = "tab_Venta";
            this.tab_Venta.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Venta.Size = new System.Drawing.Size(720, 311);
            this.tab_Venta.TabIndex = 0;
            this.tab_Venta.Text = "Venta Nueva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Para realizar su pedido, ingrese el codigo y la cantidad separados por una coma";
            // 
            // txb_Ordenar
            // 
            this.txb_Ordenar.Location = new System.Drawing.Point(105, 56);
            this.txb_Ordenar.Name = "txb_Ordenar";
            this.txb_Ordenar.Size = new System.Drawing.Size(134, 20);
            this.txb_Ordenar.TabIndex = 2;
            // 
            // btn_Ordenar
            // 
            this.btn_Ordenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Ordenar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Ordenar.FlatAppearance.BorderSize = 0;
            this.btn_Ordenar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Ordenar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Ordenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ordenar.Location = new System.Drawing.Point(136, 82);
            this.btn_Ordenar.Name = "btn_Ordenar";
            this.btn_Ordenar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ordenar.TabIndex = 1;
            this.btn_Ordenar.Text = "Ordenar";
            this.btn_Ordenar.UseVisualStyleBackColor = false;
            this.btn_Ordenar.Click += new System.EventHandler(this.btn_Ordenar_Click);
            // 
            // dgw_Productos
            // 
            this.dgw_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Productos.ColumnHeadersVisible = false;
            this.dgw_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Precio});
            this.dgw_Productos.Location = new System.Drawing.Point(364, 56);
            this.dgw_Productos.Name = "dgw_Productos";
            this.dgw_Productos.Size = new System.Drawing.Size(353, 232);
            this.dgw_Productos.TabIndex = 0;
            this.dgw_Productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // tab_Consulta
            // 
            this.tab_Consulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tab_Consulta.Controls.Add(this.txb_Consultar);
            this.tab_Consulta.Controls.Add(this.btn_Consultar);
            this.tab_Consulta.Controls.Add(this.dgw_Consulta);
            this.tab_Consulta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab_Consulta.Location = new System.Drawing.Point(4, 22);
            this.tab_Consulta.Name = "tab_Consulta";
            this.tab_Consulta.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Consulta.Size = new System.Drawing.Size(720, 311);
            this.tab_Consulta.TabIndex = 1;
            this.tab_Consulta.Text = "Consultar Inventarios";
            // 
            // txb_Consultar
            // 
            this.txb_Consultar.Location = new System.Drawing.Point(75, 60);
            this.txb_Consultar.Name = "txb_Consultar";
            this.txb_Consultar.Size = new System.Drawing.Size(134, 20);
            this.txb_Consultar.TabIndex = 4;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Consultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Consultar.FlatAppearance.BorderSize = 0;
            this.btn_Consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consultar.Location = new System.Drawing.Point(106, 86);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_Consultar.TabIndex = 3;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = false;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // dgw_Consulta
            // 
            this.dgw_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Consulta.ColumnHeadersVisible = false;
            this.dgw_Consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgw_Consulta.Location = new System.Drawing.Point(329, 32);
            this.dgw_Consulta.Name = "dgw_Consulta";
            this.dgw_Consulta.Size = new System.Drawing.Size(353, 232);
            this.dgw_Consulta.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tab_salir
            // 
            this.tab_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tab_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tab_salir.Controls.Add(this.button1);
            this.tab_salir.Controls.Add(this.lbl_ExitConfirmation);
            this.tab_salir.Location = new System.Drawing.Point(4, 22);
            this.tab_salir.Margin = new System.Windows.Forms.Padding(0);
            this.tab_salir.Name = "tab_salir";
            this.tab_salir.Size = new System.Drawing.Size(720, 311);
            this.tab_salir.TabIndex = 2;
            this.tab_salir.Text = "Salir";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(260, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 100);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_ExitConfirmation
            // 
            this.lbl_ExitConfirmation.AutoSize = true;
            this.lbl_ExitConfirmation.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExitConfirmation.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ExitConfirmation.Location = new System.Drawing.Point(255, 39);
            this.lbl_ExitConfirmation.Name = "lbl_ExitConfirmation";
            this.lbl_ExitConfirmation.Size = new System.Drawing.Size(230, 25);
            this.lbl_ExitConfirmation.TabIndex = 0;
            this.lbl_ExitConfirmation.Text = "¿Seguro que desea salir?";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Maroon;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.lbl_ventas.Cursor = System.Windows.Forms.Cursors.Arrow;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(479, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
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
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario_interno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario interno";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formulario_interno_FormClosed);
            this.Load += new System.EventHandler(this.Formulario_interno_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Venta.ResumeLayout(false);
            this.tab_Venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Productos)).EndInit();
            this.tab_Consulta.ResumeLayout(false);
            this.tab_Consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Consulta)).EndInit();
            this.tab_salir.ResumeLayout(false);
            this.tab_salir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Venta;
        private System.Windows.Forms.TabPage tab_Consulta;
        private System.Windows.Forms.TabPage tab_salir;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_ventas;
        private System.Windows.Forms.DataGridView dgw_Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.TextBox txb_Ordenar;
        private System.Windows.Forms.Button btn_Ordenar;
        private System.Windows.Forms.DataGridView dgw_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_ExitConfirmation;
        private System.Windows.Forms.TextBox txb_Consultar;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Label label2;
    }
}