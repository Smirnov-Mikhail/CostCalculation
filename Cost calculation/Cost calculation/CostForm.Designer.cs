namespace Cost_calculation
{
    partial class CostForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lengthtTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.NameMaterial = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.OutputData = new System.Windows.Forms.Label();
            this.memoLengthLabel = new System.Windows.Forms.Label();
            this.memoWidthLabel = new System.Windows.Forms.Label();
            this.memoHeightLabel = new System.Windows.Forms.Label();
            this.CurrentTaskLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lengthtTextBox
            // 
            this.lengthtTextBox.Location = new System.Drawing.Point(92, 66);
            this.lengthtTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lengthtTextBox.Name = "lengthtTextBox";
            this.lengthtTextBox.Size = new System.Drawing.Size(67, 23);
            this.lengthtTextBox.TabIndex = 0;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(168, 66);
            this.widthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(67, 23);
            this.widthTextBox.TabIndex = 1;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(244, 66);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(67, 23);
            this.heightTextBox.TabIndex = 2;
            // 
            // NameMaterial
            // 
            this.NameMaterial.AutoSize = true;
            this.NameMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameMaterial.Location = new System.Drawing.Point(36, 66);
            this.NameMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameMaterial.Name = "NameMaterial";
            this.NameMaterial.Size = new System.Drawing.Size(36, 17);
            this.NameMaterial.TabIndex = 3;
            this.NameMaterial.Text = "Дом";
            // 
            // Next
            // 
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Location = new System.Drawing.Point(369, 129);
            this.Next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(115, 41);
            this.Next.TabIndex = 4;
            this.Next.Text = "Далее";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // OutputData
            // 
            this.OutputData.AutoSize = true;
            this.OutputData.Location = new System.Drawing.Point(35, 169);
            this.OutputData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputData.Name = "OutputData";
            this.OutputData.Size = new System.Drawing.Size(0, 17);
            this.OutputData.TabIndex = 5;
            // 
            // memoLengthLabel
            // 
            this.memoLengthLabel.AutoSize = true;
            this.memoLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoLengthLabel.Location = new System.Drawing.Point(92, 43);
            this.memoLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memoLengthLabel.Name = "memoLengthLabel";
            this.memoLengthLabel.Size = new System.Drawing.Size(48, 17);
            this.memoLengthLabel.TabIndex = 6;
            this.memoLengthLabel.Text = "длина";
            // 
            // memoWidthLabel
            // 
            this.memoWidthLabel.AutoSize = true;
            this.memoWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoWidthLabel.Location = new System.Drawing.Point(164, 43);
            this.memoWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memoWidthLabel.Name = "memoWidthLabel";
            this.memoWidthLabel.Size = new System.Drawing.Size(59, 17);
            this.memoWidthLabel.TabIndex = 7;
            this.memoWidthLabel.Text = "ширина";
            // 
            // memoHeightLabel
            // 
            this.memoHeightLabel.AutoSize = true;
            this.memoHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoHeightLabel.Location = new System.Drawing.Point(240, 43);
            this.memoHeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memoHeightLabel.Name = "memoHeightLabel";
            this.memoHeightLabel.Size = new System.Drawing.Size(55, 17);
            this.memoHeightLabel.TabIndex = 8;
            this.memoHeightLabel.Text = "высота";
            // 
            // CurrentTaskLabel
            // 
            this.CurrentTaskLabel.AutoSize = true;
            this.CurrentTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentTaskLabel.Location = new System.Drawing.Point(16, 11);
            this.CurrentTaskLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentTaskLabel.Name = "CurrentTaskLabel";
            this.CurrentTaskLabel.Size = new System.Drawing.Size(213, 20);
            this.CurrentTaskLabel.TabIndex = 9;
            this.CurrentTaskLabel.Text = "Введите параметры дома.";
            // 
            // CostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 376);
            this.Controls.Add(this.CurrentTaskLabel);
            this.Controls.Add(this.memoHeightLabel);
            this.Controls.Add(this.memoWidthLabel);
            this.Controls.Add(this.memoLengthLabel);
            this.Controls.Add(this.OutputData);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.NameMaterial);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthtTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CostForm";
            this.Text = "Стоимость здания";
            this.Load += new System.EventHandler(this.CostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox lengthtTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label NameMaterial;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label OutputData;
        private System.Windows.Forms.Label memoLengthLabel;
        private System.Windows.Forms.Label memoWidthLabel;
        private System.Windows.Forms.Label memoHeightLabel;
        private System.Windows.Forms.Label CurrentTaskLabel;
    }
}

