namespace Bliblioteca
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.BoaVindas = new System.Windows.Forms.Label();
            this.BTN_Cadastrar = new System.Windows.Forms.Button();
            this.BTN_Consultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "\'";
            // 
            // BoaVindas
            // 
            this.BoaVindas.AutoSize = true;
            this.BoaVindas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BoaVindas.Font = new System.Drawing.Font("Myanmar Text", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoaVindas.ForeColor = System.Drawing.Color.Black;
            this.BoaVindas.Location = new System.Drawing.Point(99, 33);
            this.BoaVindas.Margin = new System.Windows.Forms.Padding(10);
            this.BoaVindas.Name = "BoaVindas";
            this.BoaVindas.Size = new System.Drawing.Size(198, 60);
            this.BoaVindas.TabIndex = 1;
            this.BoaVindas.Text = "Bem Vindo!";
            this.BoaVindas.Click += new System.EventHandler(this.label2_Click);
            // 
            // BTN_Cadastrar
            // 
            this.BTN_Cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_Cadastrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cadastrar.Location = new System.Drawing.Point(99, 119);
            this.BTN_Cadastrar.Name = "BTN_Cadastrar";
            this.BTN_Cadastrar.Size = new System.Drawing.Size(198, 44);
            this.BTN_Cadastrar.TabIndex = 2;
            this.BTN_Cadastrar.Text = "Cadastrar";
            this.BTN_Cadastrar.UseVisualStyleBackColor = false;
            this.BTN_Cadastrar.Click += new System.EventHandler(this.BTN_Cadastrar_Click);
            // 
            // BTN_Consultar
            // 
            this.BTN_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_Consultar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Consultar.Location = new System.Drawing.Point(99, 185);
            this.BTN_Consultar.Name = "BTN_Consultar";
            this.BTN_Consultar.Size = new System.Drawing.Size(198, 44);
            this.BTN_Consultar.TabIndex = 3;
            this.BTN_Consultar.Text = "Consultar";
            this.BTN_Consultar.UseVisualStyleBackColor = false;
            this.BTN_Consultar.Click += new System.EventHandler(this.BTN_Consultar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 332);
            this.Controls.Add(this.BTN_Consultar);
            this.Controls.Add(this.BTN_Cadastrar);
            this.Controls.Add(this.BoaVindas);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Location = new System.Drawing.Point(10, 20);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(424, 371);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(424, 371);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BoaVindas;
        private System.Windows.Forms.Button BTN_Cadastrar;
        private System.Windows.Forms.Button BTN_Consultar;
    }
}