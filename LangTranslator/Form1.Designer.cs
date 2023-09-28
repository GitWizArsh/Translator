
namespace LangTranslator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTranslate = new System.Windows.Forms.TextBox();
            this.btnFrench = new System.Windows.Forms.Button();
            this.btnGerman = new System.Windows.Forms.Button();
            this.btnPolish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Good Morning and I will translate it";
            // 
            // txtTranslate
            // 
            this.txtTranslate.Location = new System.Drawing.Point(113, 117);
            this.txtTranslate.Name = "txtTranslate";
            this.txtTranslate.Size = new System.Drawing.Size(226, 23);
            this.txtTranslate.TabIndex = 1;
            // 
            // btnFrench
            // 
            this.btnFrench.Location = new System.Drawing.Point(61, 208);
            this.btnFrench.Name = "btnFrench";
            this.btnFrench.Size = new System.Drawing.Size(75, 23);
            this.btnFrench.TabIndex = 2;
            this.btnFrench.Text = "French";
            this.btnFrench.UseVisualStyleBackColor = true;
            this.btnFrench.Click += new System.EventHandler(this.btnFrench_Click);
            // 
            // btnGerman
            // 
            this.btnGerman.Location = new System.Drawing.Point(178, 208);
            this.btnGerman.Name = "btnGerman";
            this.btnGerman.Size = new System.Drawing.Size(75, 23);
            this.btnGerman.TabIndex = 3;
            this.btnGerman.Text = "German";
            this.btnGerman.UseVisualStyleBackColor = true;
            this.btnGerman.Click += new System.EventHandler(this.btnGerman_Click);
            // 
            // btnPolish
            // 
            this.btnPolish.Location = new System.Drawing.Point(317, 208);
            this.btnPolish.Name = "btnPolish";
            this.btnPolish.Size = new System.Drawing.Size(75, 23);
            this.btnPolish.TabIndex = 4;
            this.btnPolish.Text = "Polish";
            this.btnPolish.UseVisualStyleBackColor = true;
            this.btnPolish.Click += new System.EventHandler(this.btnPolish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 281);
            this.Controls.Add(this.btnPolish);
            this.Controls.Add(this.btnGerman);
            this.Controls.Add(this.btnFrench);
            this.Controls.Add(this.txtTranslate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTranslate;
        private System.Windows.Forms.Button btnFrench;
        private System.Windows.Forms.Button btnGerman;
        private System.Windows.Forms.Button btnPolish;
    }
}

