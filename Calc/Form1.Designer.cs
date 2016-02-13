namespace Calc
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
            this.pad7 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.pad9 = new System.Windows.Forms.Button();
            this.pad8 = new System.Windows.Forms.Button();
            this.pad5 = new System.Windows.Forms.Button();
            this.pad6 = new System.Windows.Forms.Button();
            this.pad4 = new System.Windows.Forms.Button();
            this.pad2 = new System.Windows.Forms.Button();
            this.pad3 = new System.Windows.Forms.Button();
            this.pad1 = new System.Windows.Forms.Button();
            this.pad0 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.operationPlus = new System.Windows.Forms.Button();
            this.operationMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pad7
            // 
            this.pad7.Location = new System.Drawing.Point(157, 163);
            this.pad7.Name = "pad7";
            this.pad7.Size = new System.Drawing.Size(124, 126);
            this.pad7.TabIndex = 7;
            this.pad7.Text = "7";
            this.pad7.UseVisualStyleBackColor = true;
            this.pad7.Click += new System.EventHandler(this.pad_Click);
            // 
            // display
            // 
            this.display.Enabled = false;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(156, 48);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(613, 56);
            this.display.TabIndex = 116;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pad9
            // 
            this.pad9.Location = new System.Drawing.Point(460, 163);
            this.pad9.Name = "pad9";
            this.pad9.Size = new System.Drawing.Size(124, 126);
            this.pad9.TabIndex = 9;
            this.pad9.Text = "9";
            this.pad9.UseVisualStyleBackColor = true;
            this.pad9.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad8
            // 
            this.pad8.Location = new System.Drawing.Point(309, 163);
            this.pad8.Name = "pad8";
            this.pad8.Size = new System.Drawing.Size(124, 126);
            this.pad8.TabIndex = 8;
            this.pad8.Text = "8";
            this.pad8.UseVisualStyleBackColor = true;
            this.pad8.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad5
            // 
            this.pad5.Location = new System.Drawing.Point(309, 319);
            this.pad5.Name = "pad5";
            this.pad5.Size = new System.Drawing.Size(124, 126);
            this.pad5.TabIndex = 5;
            this.pad5.Text = "5";
            this.pad5.UseVisualStyleBackColor = true;
            this.pad5.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad6
            // 
            this.pad6.Location = new System.Drawing.Point(460, 319);
            this.pad6.Name = "pad6";
            this.pad6.Size = new System.Drawing.Size(124, 126);
            this.pad6.TabIndex = 6;
            this.pad6.Text = "6";
            this.pad6.UseVisualStyleBackColor = true;
            this.pad6.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad4
            // 
            this.pad4.Location = new System.Drawing.Point(157, 319);
            this.pad4.Name = "pad4";
            this.pad4.Size = new System.Drawing.Size(124, 126);
            this.pad4.TabIndex = 4;
            this.pad4.Text = "4";
            this.pad4.UseVisualStyleBackColor = true;
            this.pad4.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad2
            // 
            this.pad2.Location = new System.Drawing.Point(309, 476);
            this.pad2.Name = "pad2";
            this.pad2.Size = new System.Drawing.Size(124, 126);
            this.pad2.TabIndex = 2;
            this.pad2.Text = "2";
            this.pad2.UseVisualStyleBackColor = true;
            this.pad2.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad3
            // 
            this.pad3.Location = new System.Drawing.Point(460, 476);
            this.pad3.Name = "pad3";
            this.pad3.Size = new System.Drawing.Size(124, 126);
            this.pad3.TabIndex = 3;
            this.pad3.Text = "3";
            this.pad3.UseVisualStyleBackColor = true;
            this.pad3.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad1
            // 
            this.pad1.Location = new System.Drawing.Point(157, 476);
            this.pad1.Name = "pad1";
            this.pad1.Size = new System.Drawing.Size(124, 126);
            this.pad1.TabIndex = 1;
            this.pad1.Text = "1";
            this.pad1.UseVisualStyleBackColor = true;
            this.pad1.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad0
            // 
            this.pad0.Location = new System.Drawing.Point(309, 620);
            this.pad0.Name = "pad0";
            this.pad0.Size = new System.Drawing.Size(124, 126);
            this.pad0.TabIndex = 0;
            this.pad0.Text = "0";
            this.pad0.UseVisualStyleBackColor = true;
            this.pad0.Click += new System.EventHandler(this.pad_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(637, 163);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(124, 126);
            this.result.TabIndex = 12;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // operationPlus
            // 
            this.operationPlus.Location = new System.Drawing.Point(637, 319);
            this.operationPlus.Name = "operationPlus";
            this.operationPlus.Size = new System.Drawing.Size(124, 126);
            this.operationPlus.TabIndex = 13;
            this.operationPlus.Text = "+";
            this.operationPlus.UseVisualStyleBackColor = true;
            this.operationPlus.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationMinus
            // 
            this.operationMinus.Location = new System.Drawing.Point(637, 476);
            this.operationMinus.Name = "operationMinus";
            this.operationMinus.Size = new System.Drawing.Size(124, 126);
            this.operationMinus.TabIndex = 117;
            this.operationMinus.Text = "-";
            this.operationMinus.UseVisualStyleBackColor = true;
            this.operationMinus.Click += new System.EventHandler(this.operation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 802);
            this.Controls.Add(this.operationMinus);
            this.Controls.Add(this.operationPlus);
            this.Controls.Add(this.result);
            this.Controls.Add(this.pad0);
            this.Controls.Add(this.pad2);
            this.Controls.Add(this.pad3);
            this.Controls.Add(this.pad1);
            this.Controls.Add(this.pad5);
            this.Controls.Add(this.pad6);
            this.Controls.Add(this.pad4);
            this.Controls.Add(this.pad8);
            this.Controls.Add(this.pad9);
            this.Controls.Add(this.display);
            this.Controls.Add(this.pad7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pad7;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button pad9;
        private System.Windows.Forms.Button pad8;
        private System.Windows.Forms.Button pad5;
        private System.Windows.Forms.Button pad6;
        private System.Windows.Forms.Button pad4;
        private System.Windows.Forms.Button pad2;
        private System.Windows.Forms.Button pad3;
        private System.Windows.Forms.Button pad1;
        private System.Windows.Forms.Button pad0;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button operationPlus;
        private System.Windows.Forms.Button operationMinus;
    }
}

