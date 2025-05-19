namespace PedidosApp1
{
    partial class Dasboard12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblventas = new System.Windows.Forms.Label();
            this.iconcantventas = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconTrabajador = new FontAwesome.Sharp.IconPictureBox();
            this.lblTrabajador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblCantidadProveedor = new System.Windows.Forms.Label();
            this.Chartdetalle_ingreso = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataArticulo = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcantventas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTrabajador)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chartdetalle_ingreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataArticulo)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblventas);
            this.panel1.Controls.Add(this.iconcantventas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblventas
            // 
            this.lblventas.AutoSize = true;
            this.lblventas.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblventas.Location = new System.Drawing.Point(74, 49);
            this.lblventas.Name = "lblventas";
            this.lblventas.Size = new System.Drawing.Size(62, 23);
            this.lblventas.TabIndex = 2;
            this.lblventas.Text = "Ventas";
            this.lblventas.Click += new System.EventHandler(this.lblventas_Click);
            // 
            // iconcantventas
            // 
            this.iconcantventas.BackColor = System.Drawing.Color.White;
            this.iconcantventas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconcantventas.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconcantventas.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconcantventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconcantventas.IconSize = 60;
            this.iconcantventas.Location = new System.Drawing.Point(187, 22);
            this.iconcantventas.Name = "iconcantventas";
            this.iconcantventas.Size = new System.Drawing.Size(60, 64);
            this.iconcantventas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconcantventas.TabIndex = 1;
            this.iconcantventas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Ventas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconTrabajador);
            this.panel2.Controls.Add(this.lblTrabajador);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(283, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 100);
            this.panel2.TabIndex = 1;
            // 
            // iconTrabajador
            // 
            this.iconTrabajador.BackColor = System.Drawing.Color.White;
            this.iconTrabajador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconTrabajador.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconTrabajador.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconTrabajador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTrabajador.IconSize = 60;
            this.iconTrabajador.Location = new System.Drawing.Point(227, 12);
            this.iconTrabajador.Name = "iconTrabajador";
            this.iconTrabajador.Size = new System.Drawing.Size(60, 64);
            this.iconTrabajador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconTrabajador.TabIndex = 3;
            this.iconTrabajador.TabStop = false;
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.AutoSize = true;
            this.lblTrabajador.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajador.Location = new System.Drawing.Point(85, 49);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(93, 23);
            this.lblTrabajador.TabIndex = 3;
            this.lblTrabajador.Text = "Trabajador";
            this.lblTrabajador.Click += new System.EventHandler(this.lblTrabajador_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Trabajadores";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCantidadProveedor);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(623, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 100);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de Proveedores";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TruckField;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 60;
            this.iconPictureBox1.Location = new System.Drawing.Point(212, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(60, 64);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblCantidadProveedor
            // 
            this.lblCantidadProveedor.AutoSize = true;
            this.lblCantidadProveedor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProveedor.Location = new System.Drawing.Point(73, 49);
            this.lblCantidadProveedor.Name = "lblCantidadProveedor";
            this.lblCantidadProveedor.Size = new System.Drawing.Size(89, 23);
            this.lblCantidadProveedor.TabIndex = 4;
            this.lblCantidadProveedor.Text = "Proveedor";
            this.lblCantidadProveedor.Click += new System.EventHandler(this.lblCantidadProveedor_Click);
            // 
            // Chartdetalle_ingreso
            // 
            chartArea3.Name = "ChartArea1";
            this.Chartdetalle_ingreso.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Chartdetalle_ingreso.Legends.Add(legend3);
            this.Chartdetalle_ingreso.Location = new System.Drawing.Point(90, 149);
            this.Chartdetalle_ingreso.Name = "Chartdetalle_ingreso";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Chartdetalle_ingreso.Series.Add(series3);
            this.Chartdetalle_ingreso.Size = new System.Drawing.Size(776, 223);
            this.Chartdetalle_ingreso.TabIndex = 5;
            this.Chartdetalle_ingreso.Text = "chart1";
            this.Chartdetalle_ingreso.Click += new System.EventHandler(this.Chartdetalle_ingreso_Click);
            // 
            // dataArticulo
            // 
            this.dataArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataArticulo.Location = new System.Drawing.Point(372, 411);
            this.dataArticulo.Name = "dataArticulo";
            this.dataArticulo.Size = new System.Drawing.Size(523, 177);
            this.dataArticulo.TabIndex = 6;
            this.dataArticulo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataArticulo_CellContentClick);
            this.dataArticulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataArticulo_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblCategoria);
            this.panel4.Controls.Add(this.lblPresentacion);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(22, 411);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 177);
            this.panel4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Presentacion";
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.Location = new System.Drawing.Point(63, 139);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(174, 23);
            this.lblPresentacion.TabIndex = 4;
            this.lblPresentacion.Text = "Nombre Presentacion";
            this.lblPresentacion.Click += new System.EventHandler(this.lblPresentacion_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(90, 58);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(147, 23);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Nombre Categoria";
            this.lblCategoria.Click += new System.EventHandler(this.lblCategoria_Click);
            // 
            // Dasboard12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 622);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataArticulo);
            this.Controls.Add(this.Chartdetalle_ingreso);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dasboard12";
            this.Text = "Dasboard12";
            this.Load += new System.EventHandler(this.Dasboard12_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcantventas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTrabajador)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chartdetalle_ingreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataArticulo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblventas;
        private FontAwesome.Sharp.IconPictureBox iconcantventas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTrabajador;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconTrabajador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCantidadProveedor;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chartdetalle_ingreso;
        private System.Windows.Forms.DataGridView dataArticulo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategoria;
    }
}