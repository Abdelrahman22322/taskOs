namespace WindowsFormsApp2
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
            this.file_name = new System.Windows.Forms.TextBox();
            this.file_content = new System.Windows.Forms.RichTextBox();
            this.opration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // file_name
            // 
            this.file_name.Location = new System.Drawing.Point(334, 108);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(161, 24);
            this.file_name.TabIndex = 0;
            // 
            // file_content
            // 
            this.file_content.Location = new System.Drawing.Point(260, 208);
            this.file_content.Name = "file_content";
            this.file_content.Size = new System.Drawing.Size(310, 197);
            this.file_content.TabIndex = 1;
            this.file_content.Text = "";
            // 
            // opration
            // 
            this.opration.Location = new System.Drawing.Point(370, 165);
            this.opration.Name = "opration";
            this.opration.Size = new System.Drawing.Size(75, 23);
            this.opration.TabIndex = 2;
            this.opration.Text = "opration";
            this.opration.UseVisualStyleBackColor = true;
            this.opration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.opration_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "file_name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opration);
            this.Controls.Add(this.file_content);
            this.Controls.Add(this.file_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox file_name;
        private System.Windows.Forms.RichTextBox file_content;
        private System.Windows.Forms.Button opration;
        private System.Windows.Forms.Label label1;
    }
}

