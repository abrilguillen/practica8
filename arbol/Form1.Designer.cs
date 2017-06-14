namespace arbol
{
    partial class frmArbolBinario
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
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdPRE = new System.Windows.Forms.Button();
            this.cmdIN = new System.Windows.Forms.Button();
            this.cmdPOST = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(12, 38);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 0;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(110, 35);
            this.txtAgregar.Multiline = true;
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(100, 26);
            this.txtAgregar.TabIndex = 1;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(12, 80);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 2;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdPRE
            // 
            this.cmdPRE.Location = new System.Drawing.Point(12, 128);
            this.cmdPRE.Name = "cmdPRE";
            this.cmdPRE.Size = new System.Drawing.Size(75, 23);
            this.cmdPRE.TabIndex = 3;
            this.cmdPRE.Text = "Pre";
            this.cmdPRE.UseVisualStyleBackColor = true;
            this.cmdPRE.Click += new System.EventHandler(this.cmdPRE_Click);
            // 
            // cmdIN
            // 
            this.cmdIN.Location = new System.Drawing.Point(12, 157);
            this.cmdIN.Name = "cmdIN";
            this.cmdIN.Size = new System.Drawing.Size(75, 23);
            this.cmdIN.TabIndex = 4;
            this.cmdIN.Text = "In";
            this.cmdIN.UseVisualStyleBackColor = true;
            this.cmdIN.Click += new System.EventHandler(this.cmdIN_Click);
            // 
            // cmdPOST
            // 
            this.cmdPOST.Location = new System.Drawing.Point(12, 186);
            this.cmdPOST.Name = "cmdPOST";
            this.cmdPOST.Size = new System.Drawing.Size(75, 23);
            this.cmdPOST.TabIndex = 5;
            this.cmdPOST.Text = "Post";
            this.cmdPOST.UseVisualStyleBackColor = true;
            this.cmdPOST.Click += new System.EventHandler(this.cmdPOST_Click);
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(110, 80);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(152, 35);
            this.txtMostrar.TabIndex = 6;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.cmdPOST);
            this.Controls.Add(this.cmdIN);
            this.Controls.Add(this.cmdPRE);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.cmdAgregar);
            this.Name = "frmArbolBinario";
            this.Text = "Arbol binario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtAgregar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdPRE;
        private System.Windows.Forms.Button cmdIN;
        private System.Windows.Forms.Button cmdPOST;
        private System.Windows.Forms.TextBox txtMostrar;
    }
}

