using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lvl1_Task2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtSize;
        private Button btnCreate;
        private Button btnNewArray;
        private ListBox listBoxArray;
        private Label lblMin;
        private Label lblMax;
        private Label label1;
        private Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtSize = new TextBox();
            this.btnCreate = new Button();
            this.btnNewArray = new Button();
            this.listBoxArray = new ListBox();
            this.lblMin = new Label();
            this.lblMax = new Label();
            this.label1 = new Label();
            this.label2 = new Label();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            this.label1.Location = new Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(326, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задача 2: Поиск максимума и минимума";

            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new Size(149, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите размер массива N:";

            this.txtSize.Location = new Point(15, 60);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new Size(100, 20);
            this.txtSize.TabIndex = 2;

            this.btnCreate.Location = new Point(130, 58);
            this.btnCreate.Name = "btnGenerate";
            this.btnCreate.Size = new Size(100, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new EventHandler(this.btnCreate_Click);

            this.listBoxArray.FormattingEnabled = true;
            this.listBoxArray.Location = new Point(15, 90);
            this.listBoxArray.Name = "listBoxArray";
            this.listBoxArray.Size = new Size(300, 160);
            this.listBoxArray.TabIndex = 4;

            this.lblMin.AutoSize = true;
            this.lblMin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            this.lblMin.ForeColor = Color.Blue;
            this.lblMin.Location = new Point(15, 260);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new Size(64, 15);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "Минимум:";

            this.lblMax.AutoSize = true;
            this.lblMax.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            this.lblMax.ForeColor = Color.Red;
            this.lblMax.Location = new Point(15, 285);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new Size(73, 15);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "Максимум:";

            this.btnNewArray.Enabled = false;
            this.btnNewArray.Location = new Point(15, 310);
            this.btnNewArray.Name = "btnNewArray";
            this.btnNewArray.Size = new Size(100, 30);
            this.btnNewArray.TabIndex = 7;
            this.btnNewArray.Text = "Новый массив";
            this.btnNewArray.UseVisualStyleBackColor = true;
            this.btnNewArray.Click += new EventHandler(this.btnNewArray_Click);

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(334, 361);
            this.Controls.Add(this.btnNewArray);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.listBoxArray);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Поиск максимума и минимума";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
