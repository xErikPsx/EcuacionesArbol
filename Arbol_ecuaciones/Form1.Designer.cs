namespace Arbol_ecuaciones
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
            this.txtEc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.btnEvaluarPost = new System.Windows.Forms.Button();
            this.btnEvaluarPre = new System.Windows.Forms.Button();
            this.txtResPost = new System.Windows.Forms.TextBox();
            this.txtResPre = new System.Windows.Forms.TextBox();
            this.lblPruebas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEc
            // 
            this.txtEc.Location = new System.Drawing.Point(9, 20);
            this.txtEc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEc.Name = "txtEc";
            this.txtEc.Size = new System.Drawing.Size(177, 20);
            this.txtEc.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Evaluar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(9, 89);
            this.txtPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPost.Multiline = true;
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(177, 43);
            this.txtPost.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pre-Orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Post-Orden";
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(9, 202);
            this.txtPre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPre.Multiline = true;
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(177, 43);
            this.txtPre.TabIndex = 5;
            // 
            // btnEvaluarPost
            // 
            this.btnEvaluarPost.Location = new System.Drawing.Point(14, 142);
            this.btnEvaluarPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEvaluarPost.Name = "btnEvaluarPost";
            this.btnEvaluarPost.Size = new System.Drawing.Size(68, 21);
            this.btnEvaluarPost.TabIndex = 6;
            this.btnEvaluarPost.Text = "Evaluar";
            this.btnEvaluarPost.UseVisualStyleBackColor = true;
            this.btnEvaluarPost.Click += new System.EventHandler(this.btnEvaluarPost_Click);
            // 
            // btnEvaluarPre
            // 
            this.btnEvaluarPre.Location = new System.Drawing.Point(9, 249);
            this.btnEvaluarPre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEvaluarPre.Name = "btnEvaluarPre";
            this.btnEvaluarPre.Size = new System.Drawing.Size(68, 22);
            this.btnEvaluarPre.TabIndex = 7;
            this.btnEvaluarPre.Text = "Evaluar";
            this.btnEvaluarPre.UseVisualStyleBackColor = true;
            this.btnEvaluarPre.Click += new System.EventHandler(this.btnEvaluarPre_Click);
            // 
            // txtResPost
            // 
            this.txtResPost.Location = new System.Drawing.Point(86, 142);
            this.txtResPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResPost.Multiline = true;
            this.txtResPost.Name = "txtResPost";
            this.txtResPost.Size = new System.Drawing.Size(100, 21);
            this.txtResPost.TabIndex = 8;
            // 
            // txtResPre
            // 
            this.txtResPre.Location = new System.Drawing.Point(86, 249);
            this.txtResPre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResPre.Multiline = true;
            this.txtResPre.Name = "txtResPre";
            this.txtResPre.Size = new System.Drawing.Size(100, 22);
            this.txtResPre.TabIndex = 9;
            // 
            // lblPruebas
            // 
            this.lblPruebas.AutoSize = true;
            this.lblPruebas.Location = new System.Drawing.Point(9, 295);
            this.lblPruebas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPruebas.Name = "lblPruebas";
            this.lblPruebas.Size = new System.Drawing.Size(0, 13);
            this.lblPruebas.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 296);
            this.Controls.Add(this.lblPruebas);
            this.Controls.Add(this.txtResPre);
            this.Controls.Add(this.txtResPost);
            this.Controls.Add(this.btnEvaluarPre);
            this.Controls.Add(this.btnEvaluarPost);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.Button btnEvaluarPost;
        private System.Windows.Forms.Button btnEvaluarPre;
        private System.Windows.Forms.TextBox txtResPost;
        private System.Windows.Forms.TextBox txtResPre;
        private System.Windows.Forms.Label lblPruebas;
    }
}

