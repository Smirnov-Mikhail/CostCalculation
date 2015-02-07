namespace Cost_calculation
{
    using System;
    using System.Windows.Forms;

    public partial class CostForm : Form
    {
        public CostForm()
        {
            InitializeComponent();
        }

        private void CostForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Действия при нажатии на клавишу "Далее".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next_Click(object sender, EventArgs e)
        {
            if (this.CurrentTaskLabel.Text == "Введите параметры дома.")
            {
                HandlerHouseData();
            }
            else if (this.CurrentTaskLabel.Text == "Введите параметры бруса для основания.")
            {
                HandlerBaseData();
            }
            else if (this.CurrentTaskLabel.Text == "Выберите стену, к которой привяжем лаги.")
            {
                HandlerChoiceWallForLagsData();
            }
            else if (this.CurrentTaskLabel.Text == "Введите параметры досок и бруса для лаг.")
            {
                HandlerLagsData();
            }
            else if (this.CurrentTaskLabel.Text == "Введите параметры бруса для стен.")
            {
                HandlerWallsData();
            }
        }

        /// <summary>
        /// Обрабатываем входные данные дома.
        /// </summary>
        private void HandlerHouseData()
        {
            house.length = Convert.ToDouble(this.lengthtTextBox.Text);
            house.width = Convert.ToDouble(this.widthTextBox.Text);
            house.height = Convert.ToDouble(this.heightTextBox.Text);

            this.NameMaterial.Text = "Брус";
            this.OutputData.Text = "Рассматриваем дом: " + house.length + "х" + house.width + "х" + house.height;
            ClearLabels();
            this.CurrentTaskLabel.Text = "Введите параметры бруса для основания.";
            this.lengthtTextBox.Text = "6";
        }

        /// <summary>
        /// Обрабатываем входные данные бруса для основания.
        /// </summary>
        private void HandlerBaseData()
        {
            double numberTimber = house.Perimeter() / Convert.ToDouble(this.lengthtTextBox.Text);

            this.OutputData.Text = "Нужно бруса для основания: " + numberTimber.ToString();
            ClearLabels();
            this.CurrentTaskLabel.Text = "Выберите стену, к которой привяжем лаги.";
            this.lengthtTextBox.Text = "6";

            this.Controls.Remove(lengthtTextBox);
            this.Controls.Remove(widthTextBox);
            this.Controls.Remove(heightTextBox);
            this.Controls.Remove(NameMaterial);
            this.Controls.Remove(memoLengthLabel);
            this.Controls.Remove(memoWidthLabel);
            this.Controls.Remove(memoHeightLabel);

            LengthWall = new Button();
            LengthWall.AutoSize = true;
            LengthWall.Location = new System.Drawing.Point(12, 40);
            LengthWall.Name = "LengthWallButton";
            LengthWall.Text = "Стена длиной " + house.length.ToString();
            LengthWall.UseVisualStyleBackColor = true;
            LengthWall.Click += new System.EventHandler(this.LengthWall_Click);
            this.Controls.Add(LengthWall);

            WidthWall = new Button();
            WidthWall.AutoSize = true;
            WidthWall.Location = new System.Drawing.Point(180, 40);
            WidthWall.Name = "LengthWallButton";
            WidthWall.Text = "Стена длиной " + house.width.ToString();
            WidthWall.UseVisualStyleBackColor = true;
            WidthWall.Click += new System.EventHandler(this.WidthWall_Click);
            this.Controls.Add(WidthWall);
        }

        private void LengthWall_Click(object sender, EventArgs e)
        {
            house.wallForLags = true;
            this.Controls.Remove(LengthWall);
            this.Controls.Remove(WidthWall);
        }

        private void WidthWall_Click(object sender, EventArgs e)
        {
            house.wallForLags = false;
            this.Controls.Remove(LengthWall);
            this.Controls.Remove(WidthWall);
        }

        /// <summary>
        /// Обрабатываем входные данные бруса для основания и черновые доски.
        /// </summary>
        private void HandlerChoiceWallForLagsData()
        {
            this.Controls.Add(lengthtTextBox);
            this.Controls.Add(widthTextBox);
            this.Controls.Add(heightTextBox);
            this.Controls.Add(NameMaterial);
            this.Controls.Add(memoLengthLabel);
            this.Controls.Add(memoWidthLabel);
            this.Controls.Add(memoHeightLabel);

            if (house.wallForLags)
                this.OutputData.Text = "Привязали лаги к стене с длиной " + house.length.ToString();
            else
                this.OutputData.Text = "Привязали лаги к стене с длиной " + house.width.ToString();
            ClearLabels();
            this.CurrentTaskLabel.Text = "Введите параметры досок и бруса для лаг.";
            this.lengthtTextBox.Text = "6";

            TempLabel = new Label();
            TempLabel.AutoSize = true;
            TempLabel.Location = new System.Drawing.Point(36, 100);
            TempLabel.Name = "TempLabel";
            TempLabel.Text = "Доска";
            this.Controls.Add(TempLabel);

            TempTextBox1 = new TextBox();
            TempTextBox1.Location = new System.Drawing.Point(92, 100);
            TempTextBox1.Name = "TempTextBox1";
            TempTextBox1.Size = new System.Drawing.Size(67, 23);
            TempTextBox1.Text = "6";
            this.Controls.Add(TempTextBox1);

            TempTextBox2 = new TextBox();
            TempTextBox2.Location = new System.Drawing.Point(168, 100);
            TempTextBox2.Name = "TempTextBox1";
            TempTextBox2.Size = new System.Drawing.Size(67, 23);
            this.Controls.Add(TempTextBox2);

            TempTextBox3 = new TextBox();
            TempTextBox3.Location = new System.Drawing.Point(244, 100);
            TempTextBox3.Name = "TempTextBox1";
            TempTextBox3.Size = new System.Drawing.Size(67, 23);
            TempTextBox3.Text = "0,02";
            this.Controls.Add(TempTextBox3);
        }

        /// <summary>
        /// Обрабатываем входные данные бруса для лагов.
        /// </summary>
        private void HandlerLagsData()
        {
            house.distanceBetweenLags = 0.8;

            double numberTimber;
            double numberTimberOther = 1;

            if (house.wallForLags)
            {
                numberTimber = house.length / house.distanceBetweenLags - 2;
                if (house.width > 6)
                    numberTimberOther = 2;
            }
            else
            {
                numberTimber = house.width / house.distanceBetweenLags - 2;
                if (house.length > 6)
                    numberTimberOther = 2;
            }

            this.OutputData.Text = "Нужно бруса для лагов: " + (numberTimber + numberTimberOther).ToString();

            double numberBoard;
            double areaBoard = Convert.ToDouble(this.TempTextBox1.Text) * Convert.ToDouble(this.TempTextBox2.Text);
            if (house.wallForLags)
            {
                numberBoard = ((house.length - numberTimber * Convert.ToDouble(this.widthTextBox.Text)) * house.width) 
                    / areaBoard;
            }
            else
            {
                numberBoard = ((house.width - numberTimber * Convert.ToDouble(this.widthTextBox.Text)) * house.length)
                    / areaBoard;
            }

            this.OutputData.Text += "\nНужно досок:" + numberBoard.ToString();
            ClearLabels();
            this.CurrentTaskLabel.Text = "Введите параметры бруса для стен.";
            this.lengthtTextBox.Text = "6";

            removeTempElements();
        }

        /// <summary>
        /// Обрабатываем входные данные бруса для стен.
        /// </summary>
        private void HandlerWallsData()
        {
            double numberLine = house.height / Convert.ToDouble(this.heightTextBox.Text);
            double numberTimber = house.Perimeter() / Convert.ToDouble(this.lengthtTextBox.Text) * numberLine;

            this.NameMaterial.Text = "";
            this.OutputData.Text = "Нужно бруса: " + numberTimber.ToString();
            ClearLabels();
        }

        /// <summary>
        /// Очищает поля ввода данных.
        /// </summary>
        private void ClearLabels()
        {
            this.lengthtTextBox.Text = "";
            this.widthTextBox.Text = "";
            this.heightTextBox.Text = "";
        }

        /// <summary>
        /// Удаляем с формы временные элементы.
        /// </summary>
        private void removeTempElements()
        {
            this.Controls.Remove(TempLabel);
            this.Controls.Remove(TempTextBox1);
            this.Controls.Remove(TempTextBox2);
            this.Controls.Remove(TempTextBox3);
        }

        /// <summary>
        /// Структура дома.
        /// </summary>
        private struct House
        {
            public double length;
            public double width;
            public double height;

            public bool wallForLags;
            public double distanceBetweenLags;

            public double Perimeter()
            {
                return 2 * (length + width);
            }
        }

        private House house;
        private Button LengthWall;
        private Button WidthWall;
        private Label TempLabel;
        private TextBox TempTextBox1;
        private TextBox TempTextBox2;
        private TextBox TempTextBox3;
    }
}
