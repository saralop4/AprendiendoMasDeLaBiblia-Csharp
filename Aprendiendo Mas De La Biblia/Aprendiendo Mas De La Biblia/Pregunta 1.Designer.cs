namespace Aprendiendo_Mas_De_La_Biblia
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Opcion1 = new System.Windows.Forms.RadioButton();
            this.Opcion2 = new System.Windows.Forms.RadioButton();
            this.Opcion3 = new System.Windows.Forms.RadioButton();
            this.Opcion4 = new System.Windows.Forms.RadioButton();
            this.pregunta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.Minimizar = new System.Windows.Forms.Label();
            this.Maximizar = new System.Windows.Forms.Label();
            this.Cerrar = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Opcion1
            // 
            this.Opcion1.AutoSize = true;
            this.Opcion1.BackColor = System.Drawing.Color.Transparent;
            this.Opcion1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcion1.Location = new System.Drawing.Point(124, 548);
            this.Opcion1.Margin = new System.Windows.Forms.Padding(4);
            this.Opcion1.Name = "Opcion1";
            this.Opcion1.Size = new System.Drawing.Size(17, 16);
            this.Opcion1.TabIndex = 0;
            this.Opcion1.UseVisualStyleBackColor = false;
            this.Opcion1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Opcion2
            // 
            this.Opcion2.AutoSize = true;
            this.Opcion2.BackColor = System.Drawing.Color.Transparent;
            this.Opcion2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcion2.Location = new System.Drawing.Point(124, 641);
            this.Opcion2.Margin = new System.Windows.Forms.Padding(4);
            this.Opcion2.Name = "Opcion2";
            this.Opcion2.Size = new System.Drawing.Size(17, 16);
            this.Opcion2.TabIndex = 1;
            this.Opcion2.UseVisualStyleBackColor = false;
            // 
            // Opcion3
            // 
            this.Opcion3.AutoSize = true;
            this.Opcion3.BackColor = System.Drawing.Color.Transparent;
            this.Opcion3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcion3.Location = new System.Drawing.Point(124, 731);
            this.Opcion3.Margin = new System.Windows.Forms.Padding(4);
            this.Opcion3.Name = "Opcion3";
            this.Opcion3.Size = new System.Drawing.Size(17, 16);
            this.Opcion3.TabIndex = 2;
            this.Opcion3.UseVisualStyleBackColor = false;
            this.Opcion3.CheckedChanged += new System.EventHandler(this.Opcion3_CheckedChanged);
            // 
            // Opcion4
            // 
            this.Opcion4.AutoSize = true;
            this.Opcion4.BackColor = System.Drawing.Color.Transparent;
            this.Opcion4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcion4.Location = new System.Drawing.Point(124, 822);
            this.Opcion4.Margin = new System.Windows.Forms.Padding(4);
            this.Opcion4.Name = "Opcion4";
            this.Opcion4.Size = new System.Drawing.Size(17, 16);
            this.Opcion4.TabIndex = 3;
            this.Opcion4.UseVisualStyleBackColor = false;
            // 
            // pregunta
            // 
            this.pregunta.AutoSize = true;
            this.pregunta.BackColor = System.Drawing.Color.Transparent;
            this.pregunta.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregunta.Location = new System.Drawing.Point(4, 0);
            this.pregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(30, 22);
            this.pregunta.TabIndex = 4;
            this.pregunta.Text = "**";
            this.pregunta.Click += new System.EventHandler(this.pregunta_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(388, 426);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 82);
            this.button1.TabIndex = 100;
            this.button1.TabStop = false;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tiempo
            // 
            this.tiempo.Interval = 1000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // Minimizar
            // 
            this.Minimizar.AutoSize = true;
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(409, 11);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(48, 17);
            this.Minimizar.TabIndex = 8;
            this.Minimizar.Text = "          ";
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.AutoSize = true;
            this.Maximizar.BackColor = System.Drawing.Color.Transparent;
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(453, 11);
            this.Maximizar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(44, 17);
            this.Maximizar.TabIndex = 9;
            this.Maximizar.Text = "         ";
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.AutoSize = true;
            this.Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(484, 11);
            this.Cerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(56, 17);
            this.Cerrar.TabIndex = 10;
            this.Cerrar.Text = "            ";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.Color.Transparent;
            this.score1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.Location = new System.Drawing.Point(140, 139);
            this.score1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(39, 44);
            this.score1.TabIndex = 11;
            this.score1.Text = "0";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.BackColor = System.Drawing.Color.Transparent;
            this.score2.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.Location = new System.Drawing.Point(383, 139);
            this.score2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(39, 44);
            this.score2.TabIndex = 12;
            this.score2.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.pregunta);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(93, 265);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(365, 154);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(70, -6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 45);
            this.label2.TabIndex = 14;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(202, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 28);
            this.label3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(257, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 28);
            this.label4.TabIndex = 16;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(313, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 28);
            this.label5.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 918);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Maximizar);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Opcion4);
            this.Controls.Add(this.Opcion3);
            this.Controls.Add(this.Opcion2);
            this.Controls.Add(this.Opcion1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "          ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Minimizar;
        private System.Windows.Forms.Label Maximizar;
        private System.Windows.Forms.Label Cerrar;
        public System.Windows.Forms.RadioButton Opcion1;
        public System.Windows.Forms.RadioButton Opcion2;
        public System.Windows.Forms.RadioButton Opcion3;
        public System.Windows.Forms.RadioButton Opcion4;
        public System.Windows.Forms.Label pregunta;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}