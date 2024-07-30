
namespace Punto_de_venta.Ventas
{
    partial class Formulario_Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Ventas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnninguno = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn10 = new System.Windows.Forms.RadioButton();
            this.rbtn5 = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.txtRTN = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnQuitarTodo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtISV18 = new System.Windows.Forms.TextBox();
            this.txtISV15 = new System.Windows.Forms.TextBox();
            this.txtIG18 = new System.Windows.Forms.TextBox();
            this.txtIG15 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtImporteExento = new System.Windows.Forms.TextBox();
            this.txtImporteExonerado = new System.Windows.Forms.TextBox();
            this.txtDescuentos = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgFactura = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnSoloGuardar1 = new System.Windows.Forms.Button();
            this.BtnNuevaFactura1 = new System.Windows.Forms.Button();
            this.btnCotizacion = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblFactura);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 48);
            this.panel2.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(86, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "Cotizar un producto";
            // 
            // lblFactura
            // 
            this.lblFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.ForeColor = System.Drawing.Color.Gray;
            this.lblFactura.Location = new System.Drawing.Point(260, 23);
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
            this.panel1.Controls.Add(this.rbtnninguno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbtn10);
            this.panel1.Controls.Add(this.rbtn5);
            this.panel1.Controls.Add(this.rbtn3);
            this.panel1.Controls.Add(this.txtRTN);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnQuitarTodo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtISV18);
            this.panel1.Controls.Add(this.txtISV15);
            this.panel1.Controls.Add(this.txtIG18);
            this.panel1.Controls.Add(this.txtIG15);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtSubtotal);
            this.panel1.Controls.Add(this.txtImporteExento);
            this.panel1.Controls.Add(this.txtImporteExonerado);
            this.panel1.Controls.Add(this.txtDescuentos);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.dgFactura);
            this.panel1.Controls.Add(this.btnQuitar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(-4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 845);
            this.panel1.TabIndex = 0;
            // 
            // rbtnninguno
            // 
            this.rbtnninguno.AutoSize = true;
            this.rbtnninguno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnninguno.Location = new System.Drawing.Point(10, 431);
            this.rbtnninguno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnninguno.Name = "rbtnninguno";
            this.rbtnninguno.Size = new System.Drawing.Size(79, 21);
            this.rbtnninguno.TabIndex = 42;
            this.rbtnninguno.TabStop = true;
            this.rbtnninguno.Text = "Ninguno";
            this.rbtnninguno.UseVisualStyleBackColor = true;
            this.rbtnninguno.CheckedChanged += new System.EventHandler(this.rbtnninguno_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(90, 400);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Descuento aplicado";
            // 
            // rbtn10
            // 
            this.rbtn10.AutoSize = true;
            this.rbtn10.Location = new System.Drawing.Point(10, 408);
            this.rbtn10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn10.Name = "rbtn10";
            this.rbtn10.Size = new System.Drawing.Size(63, 28);
            this.rbtn10.TabIndex = 40;
            this.rbtn10.TabStop = true;
            this.rbtn10.Text = "10%";
            this.rbtn10.UseVisualStyleBackColor = true;
            this.rbtn10.CheckedChanged += new System.EventHandler(this.rbtn10_CheckedChanged);
            // 
            // rbtn5
            // 
            this.rbtn5.AutoSize = true;
            this.rbtn5.Location = new System.Drawing.Point(10, 385);
            this.rbtn5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn5.Name = "rbtn5";
            this.rbtn5.Size = new System.Drawing.Size(53, 28);
            this.rbtn5.TabIndex = 39;
            this.rbtn5.TabStop = true;
            this.rbtn5.Text = "5%";
            this.rbtn5.UseVisualStyleBackColor = true;
            this.rbtn5.CheckedChanged += new System.EventHandler(this.rbtn5_CheckedChanged);
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Location = new System.Drawing.Point(10, 362);
            this.rbtn3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(53, 28);
            this.rbtn3.TabIndex = 38;
            this.rbtn3.TabStop = true;
            this.rbtn3.Text = "3%";
            this.rbtn3.UseVisualStyleBackColor = true;
            this.rbtn3.CheckedChanged += new System.EventHandler(this.rbtn3_CheckedChanged);
            // 
            // txtRTN
            // 
            this.txtRTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRTN.ForeColor = System.Drawing.Color.Gray;
            this.txtRTN.Location = new System.Drawing.Point(230, 317);
            this.txtRTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRTN.Mask = "0000-0000-000000";
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(220, 28);
            this.txtRTN.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(226, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 18);
            this.label8.TabIndex = 36;
            this.label8.Text = "Importe excento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(3, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cliente";
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
            this.btnQuitarTodo.Location = new System.Drawing.Point(1120, 332);
            this.btnQuitarTodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitarTodo.Name = "btnQuitarTodo";
            this.btnQuitarTodo.Size = new System.Drawing.Size(97, 28);
            this.btnQuitarTodo.TabIndex = 19;
            this.btnQuitarTodo.Text = "Quitar todo";
            this.btnQuitarTodo.UseVisualStyleBackColor = false;
            this.btnQuitarTodo.Click += new System.EventHandler(this.btnQuitarTodo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(226, 296);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "RTN";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(594, 346);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 18);
            this.label16.TabIndex = 10;
            this.label16.Text = "I.S.V. (18%)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(451, 346);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 18);
            this.label17.TabIndex = 10;
            this.label17.Text = "I.S.V. (15%)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(597, 296);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 18);
            this.label15.TabIndex = 10;
            this.label15.Text = "IG (18%)";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(454, 296);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 18);
            this.label18.TabIndex = 10;
            this.label18.Text = "IG (15%)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Gray;
            this.label20.Location = new System.Drawing.Point(740, 346);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 18);
            this.label20.TabIndex = 10;
            this.label20.Text = "Total";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gray;
            this.label19.Location = new System.Drawing.Point(743, 296);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 18);
            this.label19.TabIndex = 10;
            this.label19.Text = "Subtotal";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(90, 346);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 18);
            this.label13.TabIndex = 10;
            this.label13.Text = "Importe exonerado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(3, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descuentos";
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
            // txtISV18
            // 
            this.txtISV18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISV18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISV18.ForeColor = System.Drawing.Color.Gray;
            this.txtISV18.Location = new System.Drawing.Point(597, 367);
            this.txtISV18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtISV18.Name = "txtISV18";
            this.txtISV18.ReadOnly = true;
            this.txtISV18.Size = new System.Drawing.Size(139, 28);
            this.txtISV18.TabIndex = 10;
            this.txtISV18.Text = "0";
            // 
            // txtISV15
            // 
            this.txtISV15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISV15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISV15.ForeColor = System.Drawing.Color.Gray;
            this.txtISV15.Location = new System.Drawing.Point(454, 367);
            this.txtISV15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtISV15.Name = "txtISV15";
            this.txtISV15.ReadOnly = true;
            this.txtISV15.Size = new System.Drawing.Size(139, 28);
            this.txtISV15.TabIndex = 7;
            this.txtISV15.Text = "0";
            // 
            // txtIG18
            // 
            this.txtIG18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIG18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIG18.ForeColor = System.Drawing.Color.Gray;
            this.txtIG18.Location = new System.Drawing.Point(597, 317);
            this.txtIG18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIG18.Name = "txtIG18";
            this.txtIG18.ReadOnly = true;
            this.txtIG18.Size = new System.Drawing.Size(139, 28);
            this.txtIG18.TabIndex = 9;
            this.txtIG18.Text = "0";
            // 
            // txtIG15
            // 
            this.txtIG15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIG15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIG15.ForeColor = System.Drawing.Color.Gray;
            this.txtIG15.Location = new System.Drawing.Point(454, 317);
            this.txtIG15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIG15.Name = "txtIG15";
            this.txtIG15.ReadOnly = true;
            this.txtIG15.Size = new System.Drawing.Size(139, 28);
            this.txtIG15.TabIndex = 6;
            this.txtIG15.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Gray;
            this.txtTotal.Location = new System.Drawing.Point(740, 367);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(162, 28);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.Text = "0";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.ForeColor = System.Drawing.Color.Gray;
            this.txtSubtotal.Location = new System.Drawing.Point(740, 317);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(162, 28);
            this.txtSubtotal.TabIndex = 11;
            this.txtSubtotal.Text = "0";
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // txtImporteExento
            // 
            this.txtImporteExento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImporteExento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteExento.ForeColor = System.Drawing.Color.Gray;
            this.txtImporteExento.Location = new System.Drawing.Point(230, 367);
            this.txtImporteExento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtImporteExento.Name = "txtImporteExento";
            this.txtImporteExento.ReadOnly = true;
            this.txtImporteExento.Size = new System.Drawing.Size(220, 28);
            this.txtImporteExento.TabIndex = 8;
            this.txtImporteExento.Text = "0";
            // 
            // txtImporteExonerado
            // 
            this.txtImporteExonerado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImporteExonerado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteExonerado.ForeColor = System.Drawing.Color.Gray;
            this.txtImporteExonerado.Location = new System.Drawing.Point(93, 367);
            this.txtImporteExonerado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtImporteExonerado.Name = "txtImporteExonerado";
            this.txtImporteExonerado.ReadOnly = true;
            this.txtImporteExonerado.Size = new System.Drawing.Size(132, 28);
            this.txtImporteExonerado.TabIndex = 5;
            this.txtImporteExonerado.Text = "0";
            this.txtImporteExonerado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteExonerado_KeyPress);
            // 
            // txtDescuentos
            // 
            this.txtDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentos.ForeColor = System.Drawing.Color.Gray;
            this.txtDescuentos.Location = new System.Drawing.Point(93, 419);
            this.txtDescuentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescuentos.Name = "txtDescuentos";
            this.txtDescuentos.ReadOnly = true;
            this.txtDescuentos.Size = new System.Drawing.Size(132, 28);
            this.txtDescuentos.TabIndex = 4;
            this.txtDescuentos.Text = "0";
            this.txtDescuentos.TextChanged += new System.EventHandler(this.txtDescuentos_TextChanged);
            this.txtDescuentos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuentos_KeyPress);
            this.txtDescuentos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescuentos_KeyUp);
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.Gray;
            this.txtCliente.Location = new System.Drawing.Point(6, 317);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(220, 28);
            this.txtCliente.TabIndex = 2;
            // 
            // dgFactura
            // 
            this.dgFactura.AllowUserToAddRows = false;
            this.dgFactura.AllowUserToOrderColumns = true;
            this.dgFactura.AllowUserToResizeRows = false;
            this.dgFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFactura.BackgroundColor = System.Drawing.Color.White;
            this.dgFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Producto,
            this.Precio,
            this.Cantidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFactura.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgFactura.Location = new System.Drawing.Point(7, 459);
            this.dgFactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgFactura.Name = "dgFactura";
            this.dgFactura.ReadOnly = true;
            this.dgFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgFactura.RowHeadersVisible = false;
            this.dgFactura.RowHeadersWidth = 20;
            this.dgFactura.RowTemplate.Height = 20;
            this.dgFactura.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFactura.Size = new System.Drawing.Size(1210, 382);
            this.dgFactura.TabIndex = 0;
            this.dgFactura.SelectionChanged += new System.EventHandler(this.dgFactura_SelectionChanged);
            this.dgFactura.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgFactura_KeyUp);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
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
            this.btnQuitar.Location = new System.Drawing.Point(1120, 367);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(97, 28);
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
            this.btnAgregar.Location = new System.Drawing.Point(1120, 296);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 28);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.BtnActualizar);
            this.panel3.Controls.Add(this.lblBuscar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.txtProducto);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.dgProductos);
            this.panel3.Location = new System.Drawing.Point(4, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1216, 234);
            this.panel3.TabIndex = 33;
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
            this.label4.Location = new System.Drawing.Point(2, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Listado de Productos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscar.Location = new System.Drawing.Point(886, 6);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(325, 28);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(1144, 178);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 18);
            this.label12.TabIndex = 10;
            this.label12.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(3, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Código";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(157, 179);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 18);
            this.label21.TabIndex = 10;
            this.label21.Text = "Producto";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Gray;
            this.txtId.Location = new System.Drawing.Point(6, 201);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(150, 26);
            this.txtId.TabIndex = 14;
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.ForeColor = System.Drawing.Color.Gray;
            this.txtProducto.Location = new System.Drawing.Point(160, 201);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(984, 26);
            this.txtProducto.TabIndex = 15;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Gray;
            this.txtCantidad.Location = new System.Drawing.Point(1148, 201);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(64, 26);
            this.txtCantidad.TabIndex = 16;
            this.txtCantidad.Text = "1";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.AllowUserToOrderColumns = true;
            this.dgProductos.AllowUserToResizeRows = false;
            this.dgProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProductos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgProductos.Location = new System.Drawing.Point(6, 39);
            this.dgProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgProductos.RowHeadersVisible = false;
            this.dgProductos.RowHeadersWidth = 20;
            this.dgProductos.RowTemplate.Height = 24;
            this.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductos.Size = new System.Drawing.Size(1205, 137);
            this.dgProductos.TabIndex = 0;
            this.dgProductos.SelectionChanged += new System.EventHandler(this.dgProductos_SelectionChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
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
            // Formulario_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 847);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Formulario_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "|";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Formulario_Ventas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Formulario_Ventas_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtISV18;
        private System.Windows.Forms.TextBox txtISV15;
        private System.Windows.Forms.TextBox txtIG18;
        private System.Windows.Forms.TextBox txtIG15;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtImporteExento;
        private System.Windows.Forms.TextBox txtImporteExonerado;
        private System.Windows.Forms.TextBox txtDescuentos;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgFactura;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button btnQuitarTodo;
        private System.Windows.Forms.Button btnSoloGuardar1;
        private System.Windows.Forms.Button BtnNuevaFactura1;
        private System.Windows.Forms.Button btnCotizacion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.MaskedTextBox txtRTN;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.RadioButton rbtn10;
        private System.Windows.Forms.RadioButton rbtn5;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton rbtnninguno;
        private System.Windows.Forms.Label label2;
    }
}