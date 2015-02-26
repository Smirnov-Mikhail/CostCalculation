namespace Cost_calculation
{
    using System;
    using System.Drawing;
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
            else if (this.CurrentTaskLabel.Text == "Введите параметры черновых досок и бруса для лаг.")
            {
                HandlerLagsData();
            }
            else if (this.CurrentTaskLabel.Text == "Введите параметры бруса для стен.")
            {
                HandlerWallsData();
            }
            else if (this.CurrentTaskLabel.Text == "Введите параметры черновой доски и доски для стропил и потолочных балок.")
            {
                HandlerRoofData();
            }
            else if (this.CurrentTaskLabel.Text == "Введите параметры половой доски.")
            {
                HandlerFloorboardsData();
            }
            else if (this.CurrentTaskLabel.Text == "Введите параметры вагонки для потолка.")
            {
                HandlerCeilingData();
            }
            else if (this.CurrentTaskLabel.Text == "Выберите тип мансарды.")
            {
                HandlerChoiceTypeMansardData();
            }
            else if (this.CurrentTaskLabel.Text == "Введите параметры доски для мансарды, половой доски и вагонки.")
            {
                HandlerMansardData();
            }
            else if (this.CurrentTaskLabel.Text == "Введите параметры вагонки для фронтона.")
            {
                HandlerGableData();
            }
        }

        /// <summary>
        /// Создаёт лэйбл и три поля для ввода данных.
        /// </summary>
        private void CreateSecondElements()
        {
            SecondLabel = new Label();
            SecondLabel.AutoSize = true;
            SecondLabel.Location = new System.Drawing.Point(36, 100);
            SecondLabel.Name = "SecondLabel";
            SecondLabel.Text = "Доска";
            this.Controls.Add(SecondLabel);

            SecondTextBox1 = new TextBox();
            SecondTextBox1.Location = new System.Drawing.Point(106, 100);
            SecondTextBox1.Name = "SecondTextBox1";
            SecondTextBox1.Size = new System.Drawing.Size(67, 23);
            SecondTextBox1.Text = "6";
            this.Controls.Add(SecondTextBox1);

            SecondTextBox2 = new TextBox();
            SecondTextBox2.Location = new System.Drawing.Point(182, 100);
            SecondTextBox2.Name = "SecondTextBox2";
            SecondTextBox2.Size = new System.Drawing.Size(67, 23);
            this.Controls.Add(SecondTextBox2);

            SecondTextBox3 = new TextBox();
            SecondTextBox3.Location = new System.Drawing.Point(258, 100);
            SecondTextBox3.Name = "SecondTextBox3";
            SecondTextBox3.Size = new System.Drawing.Size(67, 23);
            SecondTextBox3.Text = "0,02";
            this.Controls.Add(SecondTextBox3);
        }

        /// <summary>
        /// Создаёт лэйбл и три поля для ввода данных.
        /// </summary>
        private void CreateThirdElements()
        {
            ThirdLabel = new Label();
            ThirdLabel.AutoSize = true;
            ThirdLabel.Location = new System.Drawing.Point(36, 134);
            ThirdLabel.Name = "ThirdLabel";
            ThirdLabel.Text = "Вагонка";
            this.Controls.Add(ThirdLabel);

            ThirdTextBox1 = new TextBox();
            ThirdTextBox1.Location = new System.Drawing.Point(106, 134);
            ThirdTextBox1.Name = "ThirdTextBox1";
            ThirdTextBox1.Size = new System.Drawing.Size(67, 23);
            ThirdTextBox1.Text = "6";
            this.Controls.Add(ThirdTextBox1);

            ThirdTextBox2 = new TextBox();
            ThirdTextBox2.Location = new System.Drawing.Point(182, 134);
            ThirdTextBox2.Name = "ThirdTextBox2";
            ThirdTextBox2.Size = new System.Drawing.Size(67, 23);
            this.Controls.Add(ThirdTextBox2);

            ThirdTextBox3 = new TextBox();
            ThirdTextBox3.Location = new System.Drawing.Point(258, 134);
            ThirdTextBox3.Name = "ThirdTextBox3";
            ThirdTextBox3.Size = new System.Drawing.Size(67, 23);
            this.Controls.Add(ThirdTextBox3);
        }

        /// <summary>
        /// Создаём кнопки для выбора варианта.
        /// </summary>
        private void CreateChoiceElements()
        {
            Choice1 = new Button();
            Choice1.Size = new System.Drawing.Size(150, 25);
            Choice1.Location = new System.Drawing.Point(12, 40);
            Choice1.Name = "Choice1";
            Choice1.Text = "Стена длиной " + house.length.ToString();
            Choice1.UseVisualStyleBackColor = true;
            Choice1.Click += new System.EventHandler(this.Choice1_Click);
            this.Controls.Add(Choice1);

            Choice2 = new Button();
            Choice2.Size = new System.Drawing.Size(150, 25);
            Choice2.Location = new System.Drawing.Point(220, 40);
            Choice2.Name = "Choice2";
            Choice2.Text = "Стена длиной " + house.width.ToString();
            Choice2.UseVisualStyleBackColor = true;
            Choice2.Click += new System.EventHandler(this.Choice2_Click);
            this.Controls.Add(Choice2);
        }

        /// <summary>
        /// Создаём дополнительное поле для вводаданных.
        /// </summary>
        private void CreateAlone1Elements()
        {
            Alone1Label = new Label();
            Alone1Label.AutoSize = true;
            Alone1Label.Location = new System.Drawing.Point(36, 134);
            Alone1Label.Name = "Alone1Label";
            Alone1Label.Text = "Высота крыши";
            this.Controls.Add(Alone1Label);

            Alone1TextBox = new TextBox();
            Alone1TextBox.Location = new System.Drawing.Point(182, 134);
            Alone1TextBox.Name = "Alone1TextBox";
            Alone1TextBox.Size = new System.Drawing.Size(67, 23);
            this.Controls.Add(Alone1TextBox);
        }

        /// <summary>
        /// Создаём дополнительное поле для вводаданных.
        /// </summary>
        private void CreateAlone2Elements()
        {
            Alone2Label = new Label();
            Alone2Label.AutoSize = true;
            Alone2Label.Location = new System.Drawing.Point(36, 168);
            Alone2Label.Name = "Alone2Label";
            Alone2Label.Text = "Высота стойки";
            this.Controls.Add(Alone2Label);

            Alone2TextBox = new TextBox();
            Alone2TextBox.Location = new System.Drawing.Point(182, 168);
            Alone2TextBox.Name = "Alone2TextBox";
            Alone2TextBox.Size = new System.Drawing.Size(67, 23);
            this.Controls.Add(Alone2TextBox);
        }

        /// <summary>
        /// Обрабатываем входные данные дома.
        /// </summary>
        private void HandlerHouseData()
        {
            house.length = Convert.ToDouble(this.lengthtTextBox.Text);
            house.width = Convert.ToDouble(this.widthTextBox.Text);
            house.height = Convert.ToDouble(this.heightTextBox.Text);

            house.indent = 0.3;

            this.NameMaterial.Text = "Брус";
            this.OutputData.Text = "Рассматриваем дом: " + house.length + "х" + house.width + "х" + house.height;
            ClearLabels();
            this.CurrentTaskLabel.Text = "Введите параметры бруса для основания.";
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

            RemoveBasicInputField();

            CreateChoiceElements();
        }

        private void Choice1_Click(object sender, EventArgs e)
        {
            this.choice = 1;
            this.Controls.Remove(Choice1);
            this.Controls.Remove(Choice2);
            this.Controls.Remove(Choice3);
        }

        private void Choice2_Click(object sender, EventArgs e)
        {
            this.choice = 2;
            this.Controls.Remove(Choice1);
            this.Controls.Remove(Choice2);
            this.Controls.Remove(Choice3);
        }

        private void Choice3_Click(object sender, EventArgs e)
        {
            this.choice = 3;
            this.Controls.Remove(Choice1);
            this.Controls.Remove(Choice2);
            this.Controls.Remove(Choice3);
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

            if (this.choice == 1)
            {
                this.OutputData.Text = "Привязали лаги к стене с длиной " + house.length.ToString();
                house.wallForLags = true;
            }
            else
            {
                this.OutputData.Text = "Привязали лаги к стене с длиной " + house.width.ToString();
                house.wallForLags = false;
            }
            ClearLabels();
            this.CurrentTaskLabel.Text = "Введите параметры черновых досок и бруса для лаг.";

            CreateSecondElements();
            
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
            double areaBoard = Convert.ToDouble(this.SecondTextBox1.Text) * Convert.ToDouble(this.SecondTextBox2.Text);
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
            this.NameMaterial.Text = "Доска";
            RemoveSecondElements();
        }

        /// <summary>
        /// Обрабатываем входные данные бруса для стен.
        /// </summary>
        private void HandlerWallsData()
        {
            double numberLine = house.height / Convert.ToDouble(this.heightTextBox.Text);
            double numberTimber = house.Perimeter() / Convert.ToDouble(this.lengthtTextBox.Text) * numberLine;


            this.OutputData.Text = "Нужно бруса: " + numberTimber.ToString();
            this.CurrentTaskLabel.Text = "Введите параметры черновой доски и доски для стропил и потолочных балок.";
            ClearLabels();
            CreateSecondElements();
            SecondLabel.Text = "Ч. доска";

            CreateAlone1Elements();

            this.heightTextBox.Text = "0,04";
        }

        /// <summary>
        /// Обрабатываем входные данные бруса для стропил и потолочных балок.
        /// </summary>
        private void HandlerRoofData()
        {
            this.OutputData.Text = "Нужно досок для стропил и потолочных балок: " +  ((house.length + 1) * 3);
            house.heightRoof = Convert.ToDouble(Alone1TextBox.Text);
            double hypotenuse = Math.Sqrt(house.heightRoof * house.heightRoof + (house.width / 2 + house.indent) * (house.width / 2 + house.indent));
            double numberRow = (hypotenuse / (0.4 + Convert.ToDouble(widthTextBox.Text)) + 1) * 2;
            double numberBroad = (house.length * numberRow) / Convert.ToDouble(lengthtTextBox.Text); 

            this.OutputData.Text += "\nНужно Ч. досок: " + numberBroad.ToString();
            this.OutputData.Text += "\nНужно листов андулина: " + (house.length * hypotenuse) / 0.8;
            this.CurrentTaskLabel.Text = ".";
            ClearLabels();
            RemoveSecondElements();
            RemoveAlone1Elements();
            this.CurrentTaskLabel.Text = "Введите параметры половой доски.";
        }

        /// <summary>
        /// Обрабатываем входные данные дляполовых досок.
        /// </summary>
        private void HandlerFloorboardsData()
        {
            double numberBroad = house.Area()
                / (Convert.ToDouble(lengthtTextBox.Text) * Convert.ToDouble(widthTextBox.Text));

            this.OutputData.Text = "Нужно половых досок: " + numberBroad.ToString();
            ClearLabels();
            this.NameMaterial.Text = "Вагонка";
            this.CurrentTaskLabel.Text = "Введите параметры вагонки для потолка.";
        }

        /// <summary>
        /// Обрабатываем входные данные для вагонки для потолка.
        /// </summary>
        private void HandlerCeilingData()
        {
            double numberWallPanelling = house.Area() /
                (Convert.ToDouble(lengthtTextBox.Text) * Convert.ToDouble(widthTextBox.Text));

            this.OutputData.Text = "Нужно вагонки: " + numberWallPanelling.ToString();

            RemoveBasicInputField();
            this.CurrentTaskLabel.Text = "Выберите тип мансарды.";
            CreateChoiceElements();
            Choice1.BackgroundImage = Image.FromFile("1.jpg");
            Choice1.Size = new System.Drawing.Size(190, 100);
            Choice1.Text = "";
            Choice2.BackgroundImage = Image.FromFile("2.jpg");
            Choice2.Size = new System.Drawing.Size(190, 100);
            Choice2.Text = "";

            Choice3 = new Button();
            Choice3.Size = new System.Drawing.Size(190, 100);
            Choice3.Location = new System.Drawing.Point(430, 40);
            Choice3.Name = "Choice3";
            Choice3.Text = "Мансарда отсутствует";
            Choice3.UseVisualStyleBackColor = true;
            Choice3.Click += new System.EventHandler(this.Choice3_Click);
            this.Controls.Add(Choice3);
        }

        /// <summary>
        /// Выбираем тип мансарды или её отсутствие.
        /// </summary>
        private void HandlerChoiceTypeMansardData()
        {
            this.Controls.Add(lengthtTextBox);
            this.Controls.Add(widthTextBox);
            this.Controls.Add(heightTextBox);
            this.Controls.Add(NameMaterial);
            this.Controls.Add(memoLengthLabel);
            this.Controls.Add(memoWidthLabel);
            this.Controls.Add(memoHeightLabel);
            ClearLabels();
            this.NameMaterial.Text = "Доска М.";

            CreateSecondElements();
            SecondLabel.Text = "Доска П.";
            CreateThirdElements();

            CreateAlone1Elements();
            Alone1Label.Text = "Высота мансарды";
            Alone1TextBox.Text = "2,2";
            Alone1Label.Location = new System.Drawing.Point(370, 66);
            Alone1TextBox.Location = new System.Drawing.Point(516, 66);
                        
            if (choice == 2)
            {
                CreateAlone2Elements();
                Alone2TextBox.Text = "1";
                Alone2Label.Location = new System.Drawing.Point(370, 100);
                Alone2TextBox.Location = new System.Drawing.Point(516, 100);
            }

            this.CurrentTaskLabel.Text = "Введите параметры доски для мансарды, половой доски и вагонки.";
        }

        /// <summary>
        /// Обрабатываем входные данные для мансарды.
        /// </summary>
        private void HandlerMansardData()
        {
            if (choice == 1)
            {
                this.OutputData.Text = "Нужно досок для мансарды: " + ((house.length + 1) * 2).ToString();
                double widthMansard = Convert.ToDouble(Alone1TextBox.Text) * (house.width / 2 + house.indent) / house.heightRoof;
                double areaMansard = house.length * widthMansard;

                this.OutputData.Text += "\nНужно половых досок: " + (areaMansard
                    / (Convert.ToDouble(SecondTextBox1.Text) * Convert.ToDouble(SecondTextBox2.Text))).ToString();

                this.OutputData.Text += "\nНужно вагонки: " + ((areaMansard + (Convert.ToDouble(Alone1TextBox.Text) * house.length) * 2)
                    / (Convert.ToDouble(ThirdTextBox1.Text) * Convert.ToDouble(ThirdTextBox2.Text))).ToString();
            }
            else if  (choice == 2)
            {
                this.OutputData.Text = "Нужно досок для мансарды: " + ((house.length + 1) / 2).ToString();

                double rack = Convert.ToDouble(Alone2TextBox.Text);
                // Подобие треугольников.
                double widthMansard = rack * (house.width / 2 + house.indent) / house.heightRoof;
                double areaMansard = house.length * widthMansard;
                double hypotenuse = Math.Sqrt(house.heightRoof * house.heightRoof + (house.width / 2 + house.indent) * (house.width / 2 + house.indent));
                double l = hypotenuse - hypotenuse * rack / house.heightRoof;

                this.OutputData.Text += "\nНужно половых досок: " + (areaMansard
                    / (Convert.ToDouble(SecondTextBox1.Text) * Convert.ToDouble(SecondTextBox2.Text))).ToString();

                this.OutputData.Text += "\nНужно вагонки: " + ((areaMansard + rack * house.length * 2 + l * house.length * 2)
                    / (Convert.ToDouble(ThirdTextBox1.Text) * Convert.ToDouble(ThirdTextBox2.Text))).ToString();

                RemoveAlone2Elements();
            }

            RemoveSecondElements();
            RemoveThirdElements();
            RemoveAlone1Elements();
            this.CurrentTaskLabel.Text = "Введите параметры вагонки для фронтона.";
            this.NameMaterial.Text = "Вагонка";
            ClearLabels();
        }

        private void HandlerGableData()
        {
            this.OutputData.Text = "Нужно вагонки:" + 0.5 * house.heightRoof * (house.width + house.indent) * 0.5
                / (Convert.ToDouble(lengthtTextBox.Text) * Convert.ToDouble(widthTextBox.Text));
        }

        /// <summary>
        /// Очищает поля ввода данных.
        /// </summary>
        private void ClearLabels()
        {
            this.lengthtTextBox.Text = "6";
            this.widthTextBox.Text = "";
            this.heightTextBox.Text = "";
        }

        /// <summary>
        /// Удаляем с формы временные элементы.
        /// </summary>
        private void RemoveSecondElements()
        {
            this.Controls.Remove(SecondLabel);
            this.Controls.Remove(SecondTextBox1);
            this.Controls.Remove(SecondTextBox2);
            this.Controls.Remove(SecondTextBox3);
        }

        /// <summary>
        /// Удаляем с формы временные элементы.
        /// </summary>
        private void RemoveThirdElements()
        {
            this.Controls.Remove(ThirdLabel);
            this.Controls.Remove(ThirdTextBox1);
            this.Controls.Remove(ThirdTextBox2);
            this.Controls.Remove(ThirdTextBox3);
        }

        /// <summary>
        /// Удялаем сформы временное поле ввода.
        /// </summary>
        private void RemoveAlone1Elements()
        {
            this.Controls.Remove(Alone1Label);
            this.Controls.Remove(Alone1TextBox);
        }

        /// <summary>
        /// Удаляем с формы временное поле ввода.
        /// </summary>
        private void RemoveAlone2Elements()
        {
            this.Controls.Remove(Alone2Label);
            this.Controls.Remove(Alone2TextBox);
        }

        /// <summary>
        /// Удаляем с формы элементы для выбора варианта.
        /// </summary>
        private void RemoveChoiceElements()
        {
            this.Controls.Remove(Choice1);
            this.Controls.Remove(Choice2);
            this.Controls.Remove(Choice3);
        }

        /// <summary>
        /// Убирает с формы основное поле для ввода данных.
        /// </summary>
        private void RemoveBasicInputField()
        {
            this.Controls.Remove(lengthtTextBox);
            this.Controls.Remove(widthTextBox);
            this.Controls.Remove(heightTextBox);
            this.Controls.Remove(NameMaterial);
            this.Controls.Remove(memoLengthLabel);
            this.Controls.Remove(memoWidthLabel);
            this.Controls.Remove(memoHeightLabel);
        }

        /// <summary>
        /// Структура дома.
        /// </summary>
        private struct House
        {
            public double length;
            public double width;
            public double height;
            public double heightRoof;
            // поднебесники
            public double indent;

            public bool wallForLags;
            public double distanceBetweenLags;

            public double Perimeter()
            {
                return 2 * (length + width);
            }

            public double Area()
            {
                return length * width;
            }
        }

        private House house;
        // Кнопки для выбора одного варианта.
        private Button Choice1;
        private Button Choice2;
        private Button Choice3;
        private int choice;
        // Второе поле ввода данных.
        private Label SecondLabel;
        private TextBox SecondTextBox1;
        private TextBox SecondTextBox2;
        private TextBox SecondTextBox3;
        // Третье поле ввода данных.
        private Label ThirdLabel;
        private TextBox ThirdTextBox1;
        private TextBox ThirdTextBox2;
        private TextBox ThirdTextBox3;
        // Одиночное поле ввода.
        private Label Alone1Label;
        private TextBox Alone1TextBox;
        // Одиночное поле ввода.
        private Label Alone2Label;
        private TextBox Alone2TextBox;
    }
}
