namespace WinFormsDelegate
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
            this.components = new System.ComponentModel.Container();
            this.num1TextBox = new System.Windows.Forms.TextBox();
            this.num2TextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.divisionBtn = new System.Windows.Forms.Button();
            this.multBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1TextBox
            // 
            this.num1TextBox.Location = new System.Drawing.Point(197, 70);
            this.num1TextBox.Name = "num1TextBox";
            this.num1TextBox.Size = new System.Drawing.Size(49, 22);
            this.num1TextBox.TabIndex = 0;
            // 
            // num2TextBox
            // 
            this.num2TextBox.Location = new System.Drawing.Point(261, 70);
            this.num2TextBox.Name = "num2TextBox";
            this.num2TextBox.Size = new System.Drawing.Size(49, 22);
            this.num2TextBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.plusBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plusBtn.Location = new System.Drawing.Point(162, 107);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(39, 34);
            this.plusBtn.TabIndex = 3;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.minusBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minusBtn.Location = new System.Drawing.Point(207, 107);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(39, 34);
            this.minusBtn.TabIndex = 4;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = false;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // divisionBtn
            // 
            this.divisionBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.divisionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.divisionBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.divisionBtn.Location = new System.Drawing.Point(252, 107);
            this.divisionBtn.Name = "divisionBtn";
            this.divisionBtn.Size = new System.Drawing.Size(39, 34);
            this.divisionBtn.TabIndex = 5;
            this.divisionBtn.Text = "/";
            this.divisionBtn.UseVisualStyleBackColor = false;
            this.divisionBtn.Click += new System.EventHandler(this.divisionBtn_Click);
            // 
            // multBtn
            // 
            this.multBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.multBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.multBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multBtn.Location = new System.Drawing.Point(297, 107);
            this.multBtn.Name = "multBtn";
            this.multBtn.Size = new System.Drawing.Size(39, 34);
            this.multBtn.TabIndex = 6;
            this.multBtn.Text = "x";
            this.multBtn.UseVisualStyleBackColor = false;
            this.multBtn.Click += new System.EventHandler(this.multBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter 2 numbers and click on one of the buttons";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearBtn.Location = new System.Drawing.Point(216, 162);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 34);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.multBtn);
            this.Controls.Add(this.divisionBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.num2TextBox);
            this.Controls.Add(this.num1TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1TextBox;
        private System.Windows.Forms.TextBox num2TextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button divisionBtn;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearBtn;
    }
}

