
namespace StayAwakeApp
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.label2 = new System.Windows.Forms.Label();
            this.labelbylsv = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.radioButtonMinutos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEmpezar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.radioButtonHoras = new System.Windows.Forms.RadioButton();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.labelTiempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "v1.4";
            // 
            // labelbylsv
            // 
            this.labelbylsv.AutoSize = true;
            this.labelbylsv.Location = new System.Drawing.Point(118, 12);
            this.labelbylsv.Name = "labelbylsv";
            this.labelbylsv.Size = new System.Drawing.Size(41, 13);
            this.labelbylsv.TabIndex = 18;
            this.labelbylsv.Text = "by LSV";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(5, 6);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(35, 24);
            this.buttonInfo.TabIndex = 14;
            this.buttonInfo.Text = "info.";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // radioButtonMinutos
            // 
            this.radioButtonMinutos.AutoSize = true;
            this.radioButtonMinutos.Location = new System.Drawing.Point(86, 72);
            this.radioButtonMinutos.Name = "radioButtonMinutos";
            this.radioButtonMinutos.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMinutos.TabIndex = 17;
            this.radioButtonMinutos.TabStop = true;
            this.radioButtonMinutos.Text = "Minutos";
            this.radioButtonMinutos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cantidad de Tiempo:";
            // 
            // buttonEmpezar
            // 
            this.buttonEmpezar.Location = new System.Drawing.Point(40, 142);
            this.buttonEmpezar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEmpezar.Name = "buttonEmpezar";
            this.buttonEmpezar.Size = new System.Drawing.Size(90, 42);
            this.buttonEmpezar.TabIndex = 11;
            this.buttonEmpezar.Text = "Empezar";
            this.buttonEmpezar.UseVisualStyleBackColor = true;
            this.buttonEmpezar.Click += new System.EventHandler(this.buttonEmpezar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(40, 189);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(89, 23);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // radioButtonHoras
            // 
            this.radioButtonHoras.AutoSize = true;
            this.radioButtonHoras.Location = new System.Drawing.Point(27, 72);
            this.radioButtonHoras.Name = "radioButtonHoras";
            this.radioButtonHoras.Size = new System.Drawing.Size(53, 17);
            this.radioButtonHoras.TabIndex = 16;
            this.radioButtonHoras.TabStop = true;
            this.radioButtonHoras.Text = "Horas";
            this.radioButtonHoras.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(40, 94);
            this.numericUpDownCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCantidad.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownCantidad.TabIndex = 12;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelTiempo
            // 
            this.labelTiempo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTiempo.Location = new System.Drawing.Point(41, 116);
            this.labelTiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(89, 24);
            this.labelTiempo.TabIndex = 21;
            this.labelTiempo.Text = "00:00:00";
            this.labelTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 228);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelbylsv);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.radioButtonMinutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEmpezar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.radioButtonHoras);
            this.Controls.Add(this.numericUpDownCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UI";
            this.Text = "Stay Awake App";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelbylsv;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.RadioButton radioButtonMinutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEmpezar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.RadioButton radioButtonHoras;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label labelTiempo;
    }
}

