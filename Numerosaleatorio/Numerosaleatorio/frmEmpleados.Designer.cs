namespace Numerosaleatorio
{
    partial class frmEmpleados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cbgrupo = new ComboBox();
            tbsueldo = new TextBox();
            tbnombre = new TextBox();
            tbnumero = new TextBox();
            dtnacimiento = new DateTimePicker();
            rbfemenino = new RadioButton();
            rbmasculino = new RadioButton();
            cbseguro = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnaleatorios = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbgrupo);
            groupBox1.Controls.Add(tbsueldo);
            groupBox1.Controls.Add(tbnombre);
            groupBox1.Controls.Add(tbnumero);
            groupBox1.Controls.Add(dtnacimiento);
            groupBox1.Controls.Add(rbfemenino);
            groupBox1.Controls.Add(rbmasculino);
            groupBox1.Controls.Add(cbseguro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 446);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cbgrupo
            // 
            cbgrupo.FormattingEnabled = true;
            cbgrupo.Location = new Point(112, 265);
            cbgrupo.Name = "cbgrupo";
            cbgrupo.Size = new Size(151, 28);
            cbgrupo.TabIndex = 12;
            cbgrupo.SelectedIndexChanged += cbgrupo_SelectedIndexChanged;
            // 
            // tbsueldo
            // 
            tbsueldo.Location = new Point(112, 309);
            tbsueldo.Name = "tbsueldo";
            tbsueldo.Size = new Size(125, 27);
            tbsueldo.TabIndex = 11;
            tbsueldo.TextChanged += tbsueldo_TextChanged;
            // 
            // tbnombre
            // 
            tbnombre.Location = new Point(112, 89);
            tbnombre.Name = "tbnombre";
            tbnombre.Size = new Size(265, 27);
            tbnombre.TabIndex = 10;
            // 
            // tbnumero
            // 
            tbnumero.Location = new Point(114, 45);
            tbnumero.Name = "tbnumero";
            tbnumero.Size = new Size(125, 27);
            tbnumero.TabIndex = 9;
            tbnumero.TextChanged += textBox1_TextChanged;
            // 
            // dtnacimiento
            // 
            dtnacimiento.Location = new Point(170, 127);
            dtnacimiento.Name = "dtnacimiento";
            dtnacimiento.Size = new Size(276, 27);
            dtnacimiento.TabIndex = 8;
            dtnacimiento.ValueChanged += dtnacimiento_ValueChanged;
            // 
            // rbfemenino
            // 
            rbfemenino.AutoSize = true;
            rbfemenino.Location = new Point(68, 217);
            rbfemenino.Name = "rbfemenino";
            rbfemenino.Size = new Size(95, 24);
            rbfemenino.TabIndex = 7;
            rbfemenino.TabStop = true;
            rbfemenino.Text = "Femenino";
            rbfemenino.UseVisualStyleBackColor = true;
            // 
            // rbmasculino
            // 
            rbmasculino.AutoSize = true;
            rbmasculino.Location = new Point(68, 175);
            rbmasculino.Name = "rbmasculino";
            rbmasculino.Size = new Size(97, 24);
            rbmasculino.TabIndex = 6;
            rbmasculino.TabStop = true;
            rbmasculino.Text = "Masculino";
            rbmasculino.UseVisualStyleBackColor = true;
            rbmasculino.CheckedChanged += rbmasculino_CheckedChanged;
            // 
            // cbseguro
            // 
            cbseguro.AutoSize = true;
            cbseguro.Location = new Point(99, 385);
            cbseguro.Name = "cbseguro";
            cbseguro.Size = new Size(132, 24);
            cbseguro.TabIndex = 5;
            cbseguro.Text = "Seguro medico";
            cbseguro.UseVisualStyleBackColor = true;
            cbseguro.CheckedChanged += cbseguro_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 312);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 4;
            label5.Text = "Sueldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 268);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Grupo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 127);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha de naciminto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 89);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 49);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // btnaleatorios
            // 
            btnaleatorios.Location = new Point(96, 482);
            btnaleatorios.Name = "btnaleatorios";
            btnaleatorios.Size = new Size(309, 39);
            btnaleatorios.TabIndex = 1;
            btnaleatorios.Text = "Generar datos aleatorios";
            btnaleatorios.UseVisualStyleBackColor = true;
            btnaleatorios.Click += btnaleatorios_Click;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 573);
            Controls.Add(btnaleatorios);
            Controls.Add(groupBox1);
            Name = "frmEmpleados";
            Text = "Form1";
            Load += frmEmpleados_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbgrupo;
        private TextBox tbsueldo;
        private TextBox tbnombre;
        private TextBox tbnumero;
        private DateTimePicker dtnacimiento;
        private RadioButton rbfemenino;
        private RadioButton rbmasculino;
        private CheckBox cbseguro;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnaleatorios;
    }
}
