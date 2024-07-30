namespace Punto_de_venta.Imprimir
{
    partial class Form1
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
            this.cmbimpresoras = new System.Windows.Forms.ComboBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new Punto_de_venta.Ventas.printDocument();
            this.pbcodigo_de_barras = new System.Windows.Forms.PictureBox();
            this.btngenerar_codigo_de_Barras = new System.Windows.Forms.Button();
            this.txtcodigo_a_generar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbcodigo_de_barras)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbimpresoras
            // 
            this.cmbimpresoras.FormattingEnabled = true;
            this.cmbimpresoras.Location = new System.Drawing.Point(87, 95);
            this.cmbimpresoras.Name = "cmbimpresoras";
            this.cmbimpresoras.Size = new System.Drawing.Size(436, 24);
            this.cmbimpresoras.TabIndex = 0;
            this.cmbimpresoras.SelectedIndexChanged += new System.EventHandler(this.cmbimpresoras_SelectedIndexChanged);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(448, 134);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 30);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbcodigo_de_barras
            // 
            this.pbcodigo_de_barras.Location = new System.Drawing.Point(87, 221);
            this.pbcodigo_de_barras.Name = "pbcodigo_de_barras";
            this.pbcodigo_de_barras.Size = new System.Drawing.Size(436, 166);
            this.pbcodigo_de_barras.TabIndex = 3;
            this.pbcodigo_de_barras.TabStop = false;
            // 
            // btngenerar_codigo_de_Barras
            // 
            this.btngenerar_codigo_de_Barras.Location = new System.Drawing.Point(448, 404);
            this.btngenerar_codigo_de_Barras.Name = "btngenerar_codigo_de_Barras";
            this.btngenerar_codigo_de_Barras.Size = new System.Drawing.Size(75, 29);
            this.btngenerar_codigo_de_Barras.TabIndex = 4;
            this.btngenerar_codigo_de_Barras.Text = "Generar";
            this.btngenerar_codigo_de_Barras.UseVisualStyleBackColor = true;
            this.btngenerar_codigo_de_Barras.Click += new System.EventHandler(this.btngenerar_codigo_de_Barras_Click);
            // 
            // txtcodigo_a_generar
            // 
            this.txtcodigo_a_generar.Location = new System.Drawing.Point(87, 193);
            this.txtcodigo_a_generar.Name = "txtcodigo_a_generar";
            this.txtcodigo_a_generar.Size = new System.Drawing.Size(436, 22);
            this.txtcodigo_a_generar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 493);
            this.Controls.Add(this.txtcodigo_a_generar);
            this.Controls.Add(this.btngenerar_codigo_de_Barras);
            this.Controls.Add(this.pbcodigo_de_barras);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.cmbimpresoras);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbcodigo_de_barras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbimpresoras;
        private System.Windows.Forms.Button btn_imprimir;
        private Ventas.printDocument printDocument1;
        private System.Windows.Forms.PictureBox pbcodigo_de_barras;
        private System.Windows.Forms.Button btngenerar_codigo_de_Barras;
        private System.Windows.Forms.TextBox txtcodigo_a_generar;
    }
}