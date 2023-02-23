namespace Triangulos
{
    partial class CállculodeFiguras
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblVariables = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtVariable1 = new System.Windows.Forms.TextBox();
            this.txtVariable2 = new System.Windows.Forms.TextBox();
            this.lblaAr = new System.Windows.Forms.Label();
            this.lblPer = new System.Windows.Forms.Label();
            this.lblRegresaArea = new System.Windows.Forms.Label();
            this.lblRegresaPerimetro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Triangulos.Properties.Resources.fondo2;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTexto.Location = new System.Drawing.Point(181, 19);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(79, 28);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Figura";
            // 
            // lblVariables
            // 
            this.lblVariables.AutoSize = true;
            this.lblVariables.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblVariables.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariables.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVariables.Location = new System.Drawing.Point(81, 126);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.Size = new System.Drawing.Size(108, 28);
            this.lblVariables.TabIndex = 3;
            this.lblVariables.Text = "Variables";
            // 
            // txtEntrada
            // 
            this.txtEntrada.BackColor = System.Drawing.Color.Black;
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.ForeColor = System.Drawing.Color.White;
            this.txtEntrada.Location = new System.Drawing.Point(136, 50);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(168, 31);
            this.txtEntrada.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl1.Location = new System.Drawing.Point(12, 169);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(25, 28);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl2.Location = new System.Drawing.Point(12, 213);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(25, 28);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "2";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(86, 276);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtVariable1
            // 
            this.txtVariable1.BackColor = System.Drawing.Color.Black;
            this.txtVariable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVariable1.ForeColor = System.Drawing.Color.White;
            this.txtVariable1.Location = new System.Drawing.Point(43, 168);
            this.txtVariable1.Name = "txtVariable1";
            this.txtVariable1.Size = new System.Drawing.Size(168, 31);
            this.txtVariable1.TabIndex = 8;
            // 
            // txtVariable2
            // 
            this.txtVariable2.BackColor = System.Drawing.Color.Black;
            this.txtVariable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVariable2.ForeColor = System.Drawing.Color.White;
            this.txtVariable2.Location = new System.Drawing.Point(43, 210);
            this.txtVariable2.Name = "txtVariable2";
            this.txtVariable2.Size = new System.Drawing.Size(168, 31);
            this.txtVariable2.TabIndex = 9;
            // 
            // lblaAr
            // 
            this.lblaAr.AutoSize = true;
            this.lblaAr.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblaAr.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaAr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblaAr.Location = new System.Drawing.Point(283, 126);
            this.lblaAr.Name = "lblaAr";
            this.lblaAr.Size = new System.Drawing.Size(61, 28);
            this.lblaAr.TabIndex = 10;
            this.lblaAr.Text = "Área";
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPer.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPer.Location = new System.Drawing.Point(283, 231);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(118, 28);
            this.lblPer.TabIndex = 11;
            this.lblPer.Text = "Perimetro";
            this.lblPer.Click += new System.EventHandler(this.lblPer_Click);
            // 
            // lblRegresaArea
            // 
            this.lblRegresaArea.AutoSize = true;
            this.lblRegresaArea.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblRegresaArea.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegresaArea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRegresaArea.Location = new System.Drawing.Point(283, 184);
            this.lblRegresaArea.Name = "lblRegresaArea";
            this.lblRegresaArea.Size = new System.Drawing.Size(25, 28);
            this.lblRegresaArea.TabIndex = 12;
            this.lblRegresaArea.Text = "0";
            // 
            // lblRegresaPerimetro
            // 
            this.lblRegresaPerimetro.AutoSize = true;
            this.lblRegresaPerimetro.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblRegresaPerimetro.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegresaPerimetro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRegresaPerimetro.Location = new System.Drawing.Point(283, 276);
            this.lblRegresaPerimetro.Name = "lblRegresaPerimetro";
            this.lblRegresaPerimetro.Size = new System.Drawing.Size(25, 28);
            this.lblRegresaPerimetro.TabIndex = 13;
            this.lblRegresaPerimetro.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(253, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(136, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(176, 100);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buacar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CállculodeFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 386);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRegresaPerimetro);
            this.Controls.Add(this.lblRegresaArea);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.lblaAr);
            this.Controls.Add(this.txtVariable2);
            this.Controls.Add(this.txtVariable1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.lblVariables);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CállculodeFiguras";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CállculodeFiguras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblVariables;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtVariable1;
        private System.Windows.Forms.TextBox txtVariable2;
        private System.Windows.Forms.Label lblaAr;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label lblRegresaArea;
        private System.Windows.Forms.Label lblRegresaPerimetro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBuscar;
    }
}

