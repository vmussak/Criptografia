namespace CriptografiaGPI
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
            this.txtNormal = new System.Windows.Forms.TextBox();
            this.txtCriptografia = new System.Windows.Forms.TextBox();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.btnDescriptografar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNormal
            // 
            this.txtNormal.Location = new System.Drawing.Point(34, 63);
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.Size = new System.Drawing.Size(574, 20);
            this.txtNormal.TabIndex = 0;
            // 
            // txtCriptografia
            // 
            this.txtCriptografia.Location = new System.Drawing.Point(34, 154);
            this.txtCriptografia.Name = "txtCriptografia";
            this.txtCriptografia.Size = new System.Drawing.Size(574, 20);
            this.txtCriptografia.TabIndex = 1;
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Location = new System.Drawing.Point(642, 63);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(124, 23);
            this.btnCriptografar.TabIndex = 2;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // btnDescriptografar
            // 
            this.btnDescriptografar.Location = new System.Drawing.Point(642, 154);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(124, 23);
            this.btnDescriptografar.TabIndex = 3;
            this.btnDescriptografar.Text = "Descriptografar";
            this.btnDescriptografar.UseVisualStyleBackColor = true;
            this.btnDescriptografar.Click += new System.EventHandler(this.btnDescriptografar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 251);
            this.Controls.Add(this.btnDescriptografar);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.txtCriptografia);
            this.Controls.Add(this.txtNormal);
            this.Name = "Form1";
            this.Text = "Criptografia GPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNormal;
        private System.Windows.Forms.TextBox txtCriptografia;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Button btnDescriptografar;
    }
}

