
namespace AmIPositive
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.positiveLabel = new System.Windows.Forms.Label();
            this.divisibleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(67, 73);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(281, 36);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input an Integer:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(327, 80);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 26);
            this.inputTextBox.TabIndex = 1;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(327, 151);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(100, 75);
            this.inputButton.TabIndex = 2;
            this.inputButton.Text = "Enter";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // positiveLabel
            // 
            this.positiveLabel.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveLabel.Location = new System.Drawing.Point(73, 266);
            this.positiveLabel.Name = "positiveLabel";
            this.positiveLabel.Size = new System.Drawing.Size(354, 73);
            this.positiveLabel.TabIndex = 3;
            // 
            // divisibleLabel
            // 
            this.divisibleLabel.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisibleLabel.Location = new System.Drawing.Point(77, 362);
            this.divisibleLabel.Name = "divisibleLabel";
            this.divisibleLabel.Size = new System.Drawing.Size(350, 84);
            this.divisibleLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(629, 499);
            this.Controls.Add(this.divisibleLabel);
            this.Controls.Add(this.positiveLabel);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputLabel);
            this.Name = "Form1";
            this.Text = "Am I Positive?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Label positiveLabel;
        private System.Windows.Forms.Label divisibleLabel;
    }
}

