﻿namespace Recognition
{
    partial class Errors
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
            this.listView = new System.Windows.Forms.ListView();
            this.Метод = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FAR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FRR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Точность = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.BorderInPercent = new System.Windows.Forms.TextBox();
            this.SetBorder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Метод,
            this.FAR,
            this.FRR,
            this.Точность});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 83);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(400, 175);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // Метод
            // 
            this.Метод.Text = "Метод";
            this.Метод.Width = 225;
            // 
            // FAR
            // 
            this.FAR.Text = "FAR";
            this.FAR.Width = 35;
            // 
            // FRR
            // 
            this.FRR.Text = "FRR";
            this.FRR.Width = 35;
            // 
            // Точность
            // 
            this.Точность.Text = "Точность";
            this.Точность.Width = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пороговое значение в мс:";
            // 
            // BorderInPercent
            // 
            this.BorderInPercent.Location = new System.Drawing.Point(159, 31);
            this.BorderInPercent.Name = "BorderInPercent";
            this.BorderInPercent.Size = new System.Drawing.Size(96, 20);
            this.BorderInPercent.TabIndex = 3;
            // 
            // SetBorder
            // 
            this.SetBorder.Location = new System.Drawing.Point(270, 29);
            this.SetBorder.Name = "SetBorder";
            this.SetBorder.Size = new System.Drawing.Size(131, 23);
            this.SetBorder.TabIndex = 4;
            this.SetBorder.Text = "Задать";
            this.SetBorder.UseVisualStyleBackColor = true;
            this.SetBorder.Click += new System.EventHandler(this.SetBorder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "*Шаблон среднестатистического пользователя составляет около 3000 мс";
            // 
            // Errors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetBorder);
            this.Controls.Add(this.BorderInPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView);
            this.Name = "Errors";
            this.Text = "Точность методов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Метод;
        private System.Windows.Forms.ColumnHeader FAR;
        private System.Windows.Forms.ColumnHeader FRR;
        private System.Windows.Forms.ColumnHeader Точность;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BorderInPercent;
        private System.Windows.Forms.Button SetBorder;
        private System.Windows.Forms.Label label1;
    }
}