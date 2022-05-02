namespace WinForms
{
    partial class Form1
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
            this.grupoMedia = new System.Windows.Forms.GroupBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.cmdVerificar = new System.Windows.Forms.Button();
            this.txtNumeroFaltas = new System.Windows.Forms.TextBox();
            this.lblNumeroFaltas = new System.Windows.Forms.Label();
            this.grupoMedia.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoMedia
            // 
            this.grupoMedia.Controls.Add(this.txtNumeroFaltas);
            this.grupoMedia.Controls.Add(this.lblNumeroFaltas);
            this.grupoMedia.Controls.Add(this.cmdVerificar);
            this.grupoMedia.Controls.Add(this.txtNota3);
            this.grupoMedia.Controls.Add(this.lblNota3);
            this.grupoMedia.Controls.Add(this.txtNota2);
            this.grupoMedia.Controls.Add(this.lblNota2);
            this.grupoMedia.Controls.Add(this.txtNota1);
            this.grupoMedia.Controls.Add(this.lblNota1);
            this.grupoMedia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grupoMedia.Location = new System.Drawing.Point(12, 12);
            this.grupoMedia.Name = "grupoMedia";
            this.grupoMedia.Size = new System.Drawing.Size(335, 363);
            this.grupoMedia.TabIndex = 0;
            this.grupoMedia.TabStop = false;
            this.grupoMedia.Text = "Média de Notas";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(6, 43);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(143, 21);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Informe a 1ª nota";
            this.lblNota1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(187, 43);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(63, 29);
            this.txtNota1.TabIndex = 1;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(187, 83);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(63, 29);
            this.txtNota2.TabIndex = 3;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(6, 83);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(143, 21);
            this.lblNota2.TabIndex = 2;
            this.lblNota2.Text = "Informe a 2ª nota";
            this.lblNota2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(187, 123);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(63, 29);
            this.txtNota3.TabIndex = 5;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(6, 123);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(143, 21);
            this.lblNota3.TabIndex = 4;
            this.lblNota3.Text = "Informe a 3ª nota";
            this.lblNota3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmdVerificar
            // 
            this.cmdVerificar.Location = new System.Drawing.Point(34, 225);
            this.cmdVerificar.Name = "cmdVerificar";
            this.cmdVerificar.Size = new System.Drawing.Size(172, 41);
            this.cmdVerificar.TabIndex = 6;
            this.cmdVerificar.Text = "Verificar";
            this.cmdVerificar.UseVisualStyleBackColor = true;
            // 
            // txtNumeroFaltas
            // 
            this.txtNumeroFaltas.Location = new System.Drawing.Point(187, 161);
            this.txtNumeroFaltas.Name = "txtNumeroFaltas";
            this.txtNumeroFaltas.Size = new System.Drawing.Size(63, 29);
            this.txtNumeroFaltas.TabIndex = 3;
            this.txtNumeroFaltas.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblNumeroFaltas
            // 
            this.lblNumeroFaltas.AutoSize = true;
            this.lblNumeroFaltas.Location = new System.Drawing.Point(6, 164);
            this.lblNumeroFaltas.Name = "lblNumeroFaltas";
            this.lblNumeroFaltas.Size = new System.Drawing.Size(175, 21);
            this.lblNumeroFaltas.TabIndex = 2;
            this.lblNumeroFaltas.Text = "Informe o nº de faltas";
            this.lblNumeroFaltas.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 601);
            this.Controls.Add(this.grupoMedia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grupoMedia.ResumeLayout(false);
            this.grupoMedia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grupoMedia;
        private TextBox txtNota1;
        private Label lblNota1;
        private TextBox txtNota3;
        private Label lblNota3;
        private TextBox txtNota2;
        private Label lblNota2;
        private TextBox txtNumeroFaltas;
        private Label lblNumeroFaltas;
        private Button cmdVerificar;
    }
}