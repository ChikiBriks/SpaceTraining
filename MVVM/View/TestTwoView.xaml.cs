using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SpaceTraining.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для TestTwoView.xaml
    /// </summary>
    public partial class TestTwoView : UserControl
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int qNum = 0;
        int i;
        int score;


        public TestTwoView()
        {
            InitializeComponent();


            NextQuestion();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {

            Button senderButton = sender as Button;

            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            NextQuestion();

        }

        private void RestartGame()
        {
            score = 0;
            qNum = -1;
            i = 0;
        }

        private void NextQuestion()
        {

            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                RestartGame();
            }

            foreach (var x in Test.Children.OfType<Button>())
            {
                x.Tag = "0";
            }

            foreach (var x in Test2.Children.OfType<Button>())
            {
                x.Tag = "0";
            }


            switch (i)
            {
                case 1:

                    txtQuestion.Text = "Первый вопрос";


                    scoreText2.Content = "Как образно называют галактику, разделяющее пустое космическое пространство?";

                    ans1.Visibility = Visibility.Visible;
                    ans2.Visibility = Visibility.Visible;
                    ans3.Visibility = Visibility.Visible;

                    ans1.Content = "Пустынями";
                    ans2.Content = "Оазисами";
                    ans3.Content = "Темная энергия";

                    ans2.Tag = "1";


                    break;

                case 2:

                    txtQuestion.Text = "Второй вопрос";


                    scoreText2.Content = "Что является центром галактики?";

                    ans1.Content = "Ядро";
                    ans2.Content = "Оно";
                    ans3.Content = "Черная дыра";

                    ans1.Tag = "1";


                    break;

                case 3:

                    txtQuestion.Text = "Третий вопрос";


                    scoreText2.Content = "Тонкий, плоский галактический слой,\nгде находится большинство космических объектов — это?";

                    ans1.Content = "Кружок";
                    ans2.Content = "Овал";
                    ans3.Content = "Диск";

                    ans3.Tag = "1";


                    break;

                case 4:

                    txtQuestion.Text = "Четвертый вопрос";


                    scoreText2.Content = "Как называется внешний сфероидальный компонент?";

                    ans1.Content = "Звезда";
                    ans2.Content = "Гало";
                    ans3.Content = "Оазис";

                    ans2.Tag = "1";


                    break;

                case 5:

                    txtQuestion.Text = "Пятый вопрос";


                    scoreText2.Content = "Объёмная сферическая оболочка галактического ядра называется:";

                    ans1.Content = "Балдж";
                    ans2.Content = "Спиральный рукав";
                    ans3.Content = "Выпуклость";


                    ans1.Tag = "1";


                    break;
                case 6:

                    txtQuestion.Text = "Шестой вопрос";


                    scoreText2.Content = "Как называются неплотные спиральные ответвления\nс большим количеством новообразованных звёзд?";

                    ans1.Content = "Спиральный рукав";
                    ans2.Content = "Перемычка";
                    ans3.Content = "Галактические рукава";

                    ans3.Tag = "1";


                    break;
                case 7:

                    txtQuestion.Text = "Седьмой вопрос";


                    scoreText2.Content = "Что располагается около балджа?";

                    ans1.Content = "Бар";
                    ans2.Content = "Перемычка или бар";
                    ans3.Content = "Старые светилы";

                    ans2.Tag = "1";


                    break;
                case 8:

                    txtQuestion.Text = "Восьмой вопрос";


                    scoreText2.Content = "Что является Ядром Млечного Пути?";

                    ans1.Content = "Группа звезд";
                    ans2.Content = "Ядро";
                    ans3.Content = "Черная дыра";

                    ans3.Tag = "1";


                    break;
                case 9:

                    txtQuestion.Text = "Ты прошёл тест! Молодец!";

                    scoreText2.Visibility = Visibility.Visible;
                    scoreText2.Content = "Всего правильных: " + score + " из " + "8";

                    ans1.Visibility = Visibility.Collapsed;
                    ans3.Visibility = Visibility.Collapsed;

                    ans1.Content = "Answer 1";
                    ans2.Content = "Заново [ЛКМ 2 раза]";
                    ans3.Content = "Answer 3";

                    ans3.Tag = "1";

                    break;
            }
        }
    }
}
