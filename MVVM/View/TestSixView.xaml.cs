using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SpaceTraining.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для TestSixView.xaml
    /// </summary>
    public partial class TestSixView : UserControl
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int qNum = 0;
        int i;
        int score;


        public TestSixView()
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


                    scoreText2.Content = "Раздел астрономии, изучающий физическое состояние\nи химический состав небесных тел и их систем? ";

                    ans1.Visibility = Visibility.Visible;
                    ans2.Visibility = Visibility.Visible;
                    ans3.Visibility = Visibility.Visible;

                    ans1.Content = "Физика";
                    ans2.Content = "Астрофизика";
                    ans3.Content = "Химиофизика";

                    ans2.Tag = "1";


                    break;

                case 2:

                    txtQuestion.Text = "Второй вопрос";


                    scoreText2.Content = "Небесное тело, в котором идут, шли или будут идти термоядерные реакции?";

                    ans1.Content = "Звезды";
                    ans2.Content = "Астероиды";
                    ans3.Content = "Кометы";

                    ans1.Tag = "1";


                    break;

                case 3:

                    txtQuestion.Text = "Третий вопрос";


                    scoreText2.Content = "Что представляют собой звезды?";

                    ans1.Content = "Лампу";
                    ans2.Content = "Небесные тела";
                    ans3.Content = "Газовые шары";

                    ans3.Tag = "1";


                    break;

                case 4:

                    txtQuestion.Text = "Четвертый вопрос";


                    scoreText2.Content = "Когда началось современная классификация звёзд?";

                    ans1.Content = "IX века";
                    ans2.Content = "XX века";
                    ans3.Content = "XI века";

                    ans2.Tag = "1";


                    break;

                case 5:

                    txtQuestion.Text = "Пятый вопрос";


                    scoreText2.Content = "Тип звёзд, в которых ядерные реакции никогда не могли\nкомпенсировать потери энергии на излучение?";

                    ans1.Content = "Коричневые карлики";
                    ans2.Content = "Белый карлик";
                    ans3.Content = "Черный карлик";


                    ans1.Tag = "1";


                    break;
                case 6:

                    txtQuestion.Text = "Шестой вопрос";


                    scoreText2.Content = "Системы, состоящие из трёх и более звёзд?";

                    ans1.Content = "Двойные звезды";
                    ans2.Content = "Тесные звезды";
                    ans3.Content = "Кратные звезды";

                    ans3.Tag = "1";


                    break;
                case 7:

                    txtQuestion.Text = "Седьмой вопрос";


                    scoreText2.Content = "Звёзды с довольно низкой эффективной температурой (3000 — 5000 К),\nоднако с огромной светимостью?";

                    ans1.Content = "Гиганты";
                    ans2.Content = "Красные гиганты";
                    ans3.Content = "Карлики";

                    ans2.Tag = "1";


                    break;
                case 8:

                    txtQuestion.Text = "Восьмой вопрос";


                    scoreText2.Content = "В каком году впервые был обнаружен коричневый карлик?";

                    ans1.Content = "2000 г";
                    ans2.Content = "2009 г";
                    ans3.Content = "2004 г";

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
