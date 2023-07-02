namespace Registro_Videojuegos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cmbox_resultado = new System.Windows.Forms.ComboBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_puntos = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.rtxtbox_datos = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_registrar);
            this.groupBox1.Controls.Add(this.cmbox_resultado);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Videojuego";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(93, 60);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(288, 26);
            this.txt_nombre.TabIndex = 3;
            // 
            // cmbox_resultado
            // 
            this.cmbox_resultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_resultado.FormattingEnabled = true;
            this.cmbox_resultado.Items.AddRange(new object[] {
            "Victoria",
            "Derrota"});
            this.cmbox_resultado.Location = new System.Drawing.Point(107, 100);
            this.cmbox_resultado.Name = "cmbox_resultado";
            this.cmbox_resultado.Size = new System.Drawing.Size(274, 28);
            this.cmbox_resultado.TabIndex = 4;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(21, 149);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(360, 40);
            this.btn_registrar.TabIndex = 5;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(694, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Puntos Acumulados: ";
            // 
            // lbl_puntos
            // 
            this.lbl_puntos.AutoSize = true;
            this.lbl_puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puntos.Location = new System.Drawing.Point(892, 229);
            this.lbl_puntos.Name = "lbl_puntos";
            this.lbl_puntos.Size = new System.Drawing.Size(0, 25);
            this.lbl_puntos.TabIndex = 7;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(425, 227);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(263, 35);
            this.btn_Guardar.TabIndex = 9;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // rtxtbox_datos
            // 
            this.rtxtbox_datos.Location = new System.Drawing.Point(425, 20);
            this.rtxtbox_datos.Name = "rtxtbox_datos";
            this.rtxtbox_datos.ReadOnly = true;
            this.rtxtbox_datos.Size = new System.Drawing.Size(529, 201);
            this.rtxtbox_datos.TabIndex = 10;
            this.rtxtbox_datos.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 274);
            this.Controls.Add(this.rtxtbox_datos);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.lbl_puntos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbox_resultado;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_puntos;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.RichTextBox rtxtbox_datos;
    }
}

