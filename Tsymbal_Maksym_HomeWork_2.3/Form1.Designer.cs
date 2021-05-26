
namespace Tsymbal_Maksym_HomeWork_2._3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.send_button = new System.Windows.Forms.Button();
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.message_textBox = new System.Windows.Forms.TextBox();
            this.Nickname_textBox = new System.Windows.Forms.TextBox();
            this.disconnect_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(736, 472);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(133, 54);
            this.send_button.TabIndex = 0;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            // 
            // input_textBox
            // 
            this.input_textBox.Location = new System.Drawing.Point(12, 472);
            this.input_textBox.Multiline = true;
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(718, 54);
            this.input_textBox.TabIndex = 1;
            this.input_textBox.TextChanged += new System.EventHandler(this.input_textBox_TextChanged);
            // 
            // message_textBox
            // 
            this.message_textBox.Location = new System.Drawing.Point(12, 12);
            this.message_textBox.Multiline = true;
            this.message_textBox.Name = "message_textBox";
            this.message_textBox.Size = new System.Drawing.Size(718, 453);
            this.message_textBox.TabIndex = 2;
            // 
            // Nickname_textBox
            // 
            this.Nickname_textBox.Location = new System.Drawing.Point(897, 12);
            this.Nickname_textBox.Multiline = true;
            this.Nickname_textBox.Name = "Nickname_textBox";
            this.Nickname_textBox.Size = new System.Drawing.Size(129, 23);
            this.Nickname_textBox.TabIndex = 3;
            this.Nickname_textBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // disconnect_button
            // 
            this.disconnect_button.Location = new System.Drawing.Point(897, 38);
            this.disconnect_button.Name = "disconnect_button";
            this.disconnect_button.Size = new System.Drawing.Size(129, 44);
            this.disconnect_button.TabIndex = 4;
            this.disconnect_button.Text = "Disconnect";
            this.disconnect_button.UseVisualStyleBackColor = true;
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(736, 38);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(129, 44);
            this.connect_button.TabIndex = 5;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(736, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your Nickname:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.disconnect_button);
            this.Controls.Add(this.Nickname_textBox);
            this.Controls.Add(this.message_textBox);
            this.Controls.Add(this.input_textBox);
            this.Controls.Add(this.send_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.TextBox message_textBox;
        private System.Windows.Forms.TextBox Nickname_textBox;
        private System.Windows.Forms.Button disconnect_button;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Label label1;
    }
}

