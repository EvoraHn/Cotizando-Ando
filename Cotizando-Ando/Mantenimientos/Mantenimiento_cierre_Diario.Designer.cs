namespace Punto_de_venta.Mantenimientos
{
    partial class Mantenimiento_cierre_Diario
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ctSemana = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.ctMeses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSoloGuardar1 = new System.Windows.Forms.Button();
            this.BtnNuevaFactura1 = new System.Windows.Forms.Button();
            this.btnCotizacion = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnQuitarTodo = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSobrante = new System.Windows.Forms.TextBox();
            this.txtFaltante = new System.Windows.Forms.TextBox();
            this.txtConteodeCaja = new System.Windows.Forms.TextBox();
            this.txtVentasEnSistema = new System.Windows.Forms.TextBox();
            this.txtMontoInicial = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbNombresUsuarios = new System.Windows.Forms.ComboBox();
            this.lblver = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgDetalle_Transaccion = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctMeses)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle_Transaccion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblFactura);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 48);
            this.panel2.TabIndex = 33;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::Punto_de_venta.Properties.Resources.casa__1_;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(12, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 37);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(86, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "CIERRE DIARIO";
            // 
            // lblFactura
            // 
            this.lblFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.ForeColor = System.Drawing.Color.Black;
            this.lblFactura.Location = new System.Drawing.Point(303, 23);
            this.lblFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(48, 18);
            this.lblFactura.TabIndex = 2;
            this.lblFactura.Text = "00000";
            this.lblFactura.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ctSemana);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ctMeses);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnQuitarTodo);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSobrante);
            this.panel1.Controls.Add(this.txtFaltante);
            this.panel1.Controls.Add(this.txtConteodeCaja);
            this.panel1.Controls.Add(this.txtVentasEnSistema);
            this.panel1.Controls.Add(this.txtMontoInicial);
            this.panel1.Controls.Add(this.btnQuitar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(-4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 845);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(718, 492);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 33);
            this.label3.TabIndex = 46;
            this.label3.Text = "VENTAS EN ESTA SEMANA ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ctSemana
            // 
            this.ctSemana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctSemana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ctSemana.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.ctSemana.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.ctSemana.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.ctSemana.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            this.ctSemana.BorderSkin.BorderColor = System.Drawing.Color.BlanchedAlmond;
            chartArea7.Name = "ChartArea1";
            this.ctSemana.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.ctSemana.Legends.Add(legend7);
            this.ctSemana.Location = new System.Drawing.Point(693, 528);
            this.ctSemana.Name = "ctSemana";
            this.ctSemana.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series7.YValuesPerPoint = 4;
            this.ctSemana.Series.Add(series7);
            this.ctSemana.Size = new System.Drawing.Size(472, 291);
            this.ctSemana.TabIndex = 45;
            this.ctSemana.Text = "chart1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 492);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 33);
            this.label2.TabIndex = 31;
            this.label2.Text = "VENTAS POR MÉS ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ctMeses
            // 
            chartArea8.Name = "ChartArea1";
            this.ctMeses.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.ctMeses.Legends.Add(legend8);
            this.ctMeses.Location = new System.Drawing.Point(16, 528);
            this.ctMeses.Name = "ctMeses";
            this.ctMeses.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            series8.YValuesPerPoint = 6;
            this.ctMeses.Series.Add(series8);
            this.ctMeses.Size = new System.Drawing.Size(534, 291);
            this.ctMeses.TabIndex = 44;
            this.ctMeses.Text = "chart1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(227, 296);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 18);
            this.label8.TabIndex = 36;
            this.label8.Text = "Conteo de Caja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(3, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Monto Inicial";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnSoloGuardar1);
            this.panel4.Controls.Add(this.BtnNuevaFactura1);
            this.panel4.Controls.Add(this.btnCotizacion);
            this.panel4.Controls.Add(this.btnImprimir);
            this.panel4.Location = new System.Drawing.Point(1023, 400);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 57);
            this.panel4.TabIndex = 34;
            // 
            // btnSoloGuardar1
            // 
            this.btnSoloGuardar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSoloGuardar1.BackColor = System.Drawing.Color.White;
            this.btnSoloGuardar1.BackgroundImage = global::Punto_de_venta.Properties.Resources.disco_flexible_1;
            this.btnSoloGuardar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSoloGuardar1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSoloGuardar1.FlatAppearance.BorderSize = 0;
            this.btnSoloGuardar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSoloGuardar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSoloGuardar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoloGuardar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoloGuardar1.ForeColor = System.Drawing.Color.Gray;
            this.btnSoloGuardar1.Location = new System.Drawing.Point(9, 11);
            this.btnSoloGuardar1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSoloGuardar1.Name = "btnSoloGuardar1";
            this.btnSoloGuardar1.Size = new System.Drawing.Size(44, 37);
            this.btnSoloGuardar1.TabIndex = 20;
            this.btnSoloGuardar1.UseVisualStyleBackColor = false;
            this.btnSoloGuardar1.Visible = false;
            this.btnSoloGuardar1.Click += new System.EventHandler(this.btnSoloGuardar_Click);
            // 
            // BtnNuevaFactura1
            // 
            this.BtnNuevaFactura1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevaFactura1.BackColor = System.Drawing.Color.White;
            this.BtnNuevaFactura1.BackgroundImage = global::Punto_de_venta.Properties.Resources.nuevo;
            this.BtnNuevaFactura1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNuevaFactura1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnNuevaFactura1.FlatAppearance.BorderSize = 0;
            this.BtnNuevaFactura1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNuevaFactura1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnNuevaFactura1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevaFactura1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevaFactura1.ForeColor = System.Drawing.Color.Gray;
            this.BtnNuevaFactura1.Location = new System.Drawing.Point(98, 11);
            this.BtnNuevaFactura1.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNuevaFactura1.Name = "BtnNuevaFactura1";
            this.BtnNuevaFactura1.Size = new System.Drawing.Size(44, 37);
            this.BtnNuevaFactura1.TabIndex = 21;
            this.BtnNuevaFactura1.UseVisualStyleBackColor = false;
            this.BtnNuevaFactura1.Click += new System.EventHandler(this.BtnNuevaFactura_Click);
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCotizacion.BackColor = System.Drawing.Color.White;
            this.btnCotizacion.BackgroundImage = global::Punto_de_venta.Properties.Resources.escritura;
            this.btnCotizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCotizacion.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCotizacion.FlatAppearance.BorderSize = 0;
            this.btnCotizacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCotizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizacion.ForeColor = System.Drawing.Color.Gray;
            this.btnCotizacion.Location = new System.Drawing.Point(58, 11);
            this.btnCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Size = new System.Drawing.Size(44, 37);
            this.btnCotizacion.TabIndex = 22;
            this.btnCotizacion.UseVisualStyleBackColor = false;
            this.btnCotizacion.Visible = false;
            this.btnCotizacion.Click += new System.EventHandler(this.btnCotizacion_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.BackgroundImage = global::Punto_de_venta.Properties.Resources._61764;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Gray;
            this.btnImprimir.Location = new System.Drawing.Point(146, 11);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(44, 37);
            this.btnImprimir.TabIndex = 23;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnQuitarTodo
            // 
            this.btnQuitarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarTodo.BackColor = System.Drawing.Color.White;
            this.btnQuitarTodo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnQuitarTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuitarTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuitarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarTodo.ForeColor = System.Drawing.Color.Gray;
            this.btnQuitarTodo.Location = new System.Drawing.Point(1112, 332);
            this.btnQuitarTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarTodo.Name = "btnQuitarTodo";
            this.btnQuitarTodo.Size = new System.Drawing.Size(105, 28);
            this.btnQuitarTodo.TabIndex = 19;
            this.btnQuitarTodo.Text = "Hacer Cierre";
            this.btnQuitarTodo.UseVisualStyleBackColor = false;
            this.btnQuitarTodo.Visible = false;
            this.btnQuitarTodo.Click += new System.EventHandler(this.btnQuitarTodo_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(450, 296);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 18);
            this.label15.TabIndex = 10;
            this.label15.Text = "Sobrante";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gray;
            this.label19.Location = new System.Drawing.Point(554, 297);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 18);
            this.label19.TabIndex = 10;
            this.label19.Text = "Faltante";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(652, 296);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 18);
            this.label13.TabIndex = 10;
            this.label13.Text = "Ventas en sistema";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(-165, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cliente";
            // 
            // txtSobrante
            // 
            this.txtSobrante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSobrante.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrante.ForeColor = System.Drawing.Color.Gray;
            this.txtSobrante.Location = new System.Drawing.Point(453, 317);
            this.txtSobrante.Margin = new System.Windows.Forms.Padding(2);
            this.txtSobrante.Name = "txtSobrante";
            this.txtSobrante.ReadOnly = true;
            this.txtSobrante.Size = new System.Drawing.Size(97, 28);
            this.txtSobrante.TabIndex = 9;
            this.txtSobrante.Text = "0";
            // 
            // txtFaltante
            // 
            this.txtFaltante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFaltante.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaltante.ForeColor = System.Drawing.Color.Gray;
            this.txtFaltante.Location = new System.Drawing.Point(554, 317);
            this.txtFaltante.Margin = new System.Windows.Forms.Padding(2);
            this.txtFaltante.Name = "txtFaltante";
            this.txtFaltante.ReadOnly = true;
            this.txtFaltante.Size = new System.Drawing.Size(97, 28);
            this.txtFaltante.TabIndex = 11;
            this.txtFaltante.Text = "0";
            this.txtFaltante.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // txtConteodeCaja
            // 
            this.txtConteodeCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConteodeCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteodeCaja.ForeColor = System.Drawing.Color.Gray;
            this.txtConteodeCaja.Location = new System.Drawing.Point(229, 317);
            this.txtConteodeCaja.Margin = new System.Windows.Forms.Padding(2);
            this.txtConteodeCaja.Name = "txtConteodeCaja";
            this.txtConteodeCaja.Size = new System.Drawing.Size(220, 28);
            this.txtConteodeCaja.TabIndex = 8;
            this.txtConteodeCaja.Text = "0";
            this.txtConteodeCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConteodeCaja_KeyPress);
            // 
            // txtVentasEnSistema
            // 
            this.txtVentasEnSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVentasEnSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentasEnSistema.ForeColor = System.Drawing.Color.Gray;
            this.txtVentasEnSistema.Location = new System.Drawing.Point(655, 316);
            this.txtVentasEnSistema.Margin = new System.Windows.Forms.Padding(2);
            this.txtVentasEnSistema.Name = "txtVentasEnSistema";
            this.txtVentasEnSistema.ReadOnly = true;
            this.txtVentasEnSistema.Size = new System.Drawing.Size(163, 28);
            this.txtVentasEnSistema.TabIndex = 5;
            this.txtVentasEnSistema.Text = "0";
            this.txtVentasEnSistema.TextChanged += new System.EventHandler(this.txtVentasEnSistema_TextChanged);
            this.txtVentasEnSistema.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteExonerado_KeyPress);
            // 
            // txtMontoInicial
            // 
            this.txtMontoInicial.AutoCompleteCustomSource.AddRange(new string[] {
            "0"});
            this.txtMontoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoInicial.ForeColor = System.Drawing.Color.Gray;
            this.txtMontoInicial.Location = new System.Drawing.Point(6, 317);
            this.txtMontoInicial.Margin = new System.Windows.Forms.Padding(2);
            this.txtMontoInicial.Name = "txtMontoInicial";
            this.txtMontoInicial.Size = new System.Drawing.Size(220, 28);
            this.txtMontoInicial.TabIndex = 2;
            this.txtMontoInicial.Text = "0";
            this.txtMontoInicial.TextChanged += new System.EventHandler(this.txtMontoInicial_TextChanged);
            this.txtMontoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoInicial_KeyPress);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.BackColor = System.Drawing.Color.White;
            this.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.Gray;
            this.btnQuitar.Location = new System.Drawing.Point(1144, 367);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(73, 28);
            this.btnQuitar.TabIndex = 18;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(235)))), ((int)(((byte)(214)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Gray;
            this.btnAgregar.Location = new System.Drawing.Point(1144, 296);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(73, 28);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Calcular";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.cmbNombresUsuarios);
            this.panel3.Controls.Add(this.lblver);
            this.panel3.Controls.Add(this.BtnActualizar);
            this.panel3.Controls.Add(this.lblBuscar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Controls.Add(this.dgDetalle_Transaccion);
            this.panel3.Location = new System.Drawing.Point(4, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1216, 234);
            this.panel3.TabIndex = 33;
            // 
            // cmbNombresUsuarios
            // 
            this.cmbNombresUsuarios.FormattingEnabled = true;
            this.cmbNombresUsuarios.Location = new System.Drawing.Point(260, 6);
            this.cmbNombresUsuarios.Name = "cmbNombresUsuarios";
            this.cmbNombresUsuarios.Size = new System.Drawing.Size(305, 30);
            this.cmbNombresUsuarios.TabIndex = 32;
            this.cmbNombresUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbNombresUsuarios_SelectedIndexChanged);
            // 
            // lblver
            // 
            this.lblver.AutoSize = true;
            this.lblver.BackColor = System.Drawing.Color.Transparent;
            this.lblver.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblver.Location = new System.Drawing.Point(124, 9);
            this.lblver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblver.Name = "lblver";
            this.lblver.Size = new System.Drawing.Size(131, 24);
            this.lblver.TabIndex = 31;
            this.lblver.Text = "Ver ventas de:";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnActualizar.BackgroundImage = global::Punto_de_venta.Properties.Resources.Actualizar;
            this.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.Gray;
            this.BtnActualizar.Location = new System.Drawing.Point(764, 5);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(37, 29);
            this.BtnActualizar.TabIndex = 24;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBuscar.Location = new System.Drawing.Point(808, 7);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(78, 24);
            this.lblBuscar.TabIndex = 30;
            this.lblBuscar.Text = "Buscar :";
            this.lblBuscar.Click += new System.EventHandler(this.lblBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(2, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "DETALLES";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscar.Location = new System.Drawing.Point(886, 6);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(325, 28);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // dgDetalle_Transaccion
            // 
            this.dgDetalle_Transaccion.AllowUserToAddRows = false;
            this.dgDetalle_Transaccion.AllowUserToOrderColumns = true;
            this.dgDetalle_Transaccion.AllowUserToResizeRows = false;
            this.dgDetalle_Transaccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDetalle_Transaccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetalle_Transaccion.BackgroundColor = System.Drawing.Color.White;
            this.dgDetalle_Transaccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalle_Transaccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgDetalle_Transaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetalle_Transaccion.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgDetalle_Transaccion.Location = new System.Drawing.Point(6, 42);
            this.dgDetalle_Transaccion.Margin = new System.Windows.Forms.Padding(2);
            this.dgDetalle_Transaccion.Name = "dgDetalle_Transaccion";
            this.dgDetalle_Transaccion.ReadOnly = true;
            this.dgDetalle_Transaccion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgDetalle_Transaccion.RowHeadersVisible = false;
            this.dgDetalle_Transaccion.RowHeadersWidth = 20;
            this.dgDetalle_Transaccion.RowTemplate.Height = 24;
            this.dgDetalle_Transaccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetalle_Transaccion.Size = new System.Drawing.Size(1205, 184);
            this.dgDetalle_Transaccion.TabIndex = 0;
            this.dgDetalle_Transaccion.SelectionChanged += new System.EventHandler(this.dgProductos_SelectionChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Mantenimiento_cierre_Diario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 847);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mantenimiento_cierre_Diario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "|";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Formulario_Ventas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Formulario_Ventas_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctSemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctMeses)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle_Transaccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSobrante;
        private System.Windows.Forms.TextBox txtFaltante;
        private System.Windows.Forms.TextBox txtConteodeCaja;
        private System.Windows.Forms.TextBox txtVentasEnSistema;
        private System.Windows.Forms.TextBox txtMontoInicial;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgDetalle_Transaccion;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnQuitarTodo;
        private System.Windows.Forms.Button btnSoloGuardar1;
        private System.Windows.Forms.Button BtnNuevaFactura1;
        private System.Windows.Forms.Button btnCotizacion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctMeses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctSemana;
        private System.Windows.Forms.Label lblver;
        private System.Windows.Forms.ComboBox cmbNombresUsuarios;
    }
}