﻿namespace HwN2
{
    partial class FormGuessNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.userNumber = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.Label();
            this.countsText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отгадайте число от 1 до 100";
            // 
            // userNumber
            // 
            this.userNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNumber.Location = new System.Drawing.Point(47, 64);
            this.userNumber.Name = "userNumber";
            this.userNumber.Size = new System.Drawing.Size(305, 30);
            this.userNumber.TabIndex = 2;
            this.userNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userNumber_KeyDown);
            // 
            // textMessage
            // 
            this.textMessage.AutoSize = true;
            this.textMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMessage.Location = new System.Drawing.Point(45, 117);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(19, 25);
            this.textMessage.TabIndex = 3;
            this.textMessage.Text = "-";
            this.textMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countsText
            // 
            this.countsText.AutoSize = true;
            this.countsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countsText.Location = new System.Drawing.Point(47, 167);
            this.countsText.Name = "countsText";
            this.countsText.Size = new System.Drawing.Size(23, 25);
            this.countsText.TabIndex = 4;
            this.countsText.Text = "0";
            // 
            // FormGuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 239);
            this.Controls.Add(this.countsText);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.userNumber);
            this.Controls.Add(this.label1);
            this.Name = "FormGuessNumber";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNumber;
        private System.Windows.Forms.Label textMessage;
        private System.Windows.Forms.Label countsText;
    }
}

