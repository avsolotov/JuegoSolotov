namespace JuegoSolotov
{
    partial class MenuOne
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
            this.btnjugar = new System.Windows.Forms.Button();
            this.btnadministrador = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnsolotovmedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnjugar
            // 
            this.btnjugar.BackColor = System.Drawing.SystemColors.Control;
            this.btnjugar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnjugar.FlatAppearance.BorderSize = 2;
            this.btnjugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnjugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnjugar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjugar.Location = new System.Drawing.Point(256, 414);
            this.btnjugar.Name = "btnjugar";
            this.btnjugar.Size = new System.Drawing.Size(111, 23);
            this.btnjugar.TabIndex = 0;
            this.btnjugar.Text = "JUGAR";
            this.btnjugar.UseVisualStyleBackColor = false;
            this.btnjugar.Click += new System.EventHandler(this.Btnjugar_Click);
            // 
            // btnadministrador
            // 
            this.btnadministrador.BackColor = System.Drawing.SystemColors.Control;
            this.btnadministrador.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnadministrador.FlatAppearance.BorderSize = 2;
            this.btnadministrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnadministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadministrador.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadministrador.Location = new System.Drawing.Point(256, 443);
            this.btnadministrador.Name = "btnadministrador";
            this.btnadministrador.Size = new System.Drawing.Size(111, 23);
            this.btnadministrador.TabIndex = 1;
            this.btnadministrador.Text = "PROFESOR";
            this.btnadministrador.UseVisualStyleBackColor = false;
            this.btnadministrador.Click += new System.EventHandler(this.Btnadministrador_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnsalir.FlatAppearance.BorderSize = 2;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(477, 12);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(111, 23);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // btnsolotovmedia
            // 
            this.btnsolotovmedia.BackColor = System.Drawing.SystemColors.Control;
            this.btnsolotovmedia.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnsolotovmedia.FlatAppearance.BorderSize = 2;
            this.btnsolotovmedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnsolotovmedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsolotovmedia.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsolotovmedia.Location = new System.Drawing.Point(477, 653);
            this.btnsolotovmedia.Name = "btnsolotovmedia";
            this.btnsolotovmedia.Size = new System.Drawing.Size(111, 23);
            this.btnsolotovmedia.TabIndex = 3;
            this.btnsolotovmedia.Text = "SOLOTOVMEDIA";
            this.btnsolotovmedia.UseVisualStyleBackColor = false;
            this.btnsolotovmedia.Click += new System.EventHandler(this.Btnsolotovmedia_Click);
            // 
            // MenuOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoSolotov.Properties.Resources.MenuOne;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.btnsolotovmedia);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnadministrador);
            this.Controls.Add(this.btnjugar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuOne";
            this.Load += new System.EventHandler(this.MenuOne_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnjugar;
        private System.Windows.Forms.Button btnadministrador;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnsolotovmedia;
    }
}