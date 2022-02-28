using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SpaceTraining.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для TestFiveView.xaml
    /// </summary>
    public partial class TestFiveView : UserControl
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int qNum = 0;
        int i;
        int score;


        public TestFiveView()
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


                    scoreText2.Content = "Самая близкая к нам звезда, которая обладает\nсредней величиной и средней температурой – это?";

                    ans1.Visibility = Visibility.Visible;
                    ans2.Visibility = Visibility.Visible;
                    ans3.Visibility = Visibility.Visible;

                    ans1.Content = "Луна";
                    ans2.Content = "Марс";
                    ans3.Content = "Солнце";

                    ans3.Tag = "1";


                    break;

                case 2:

                    txtQuestion.Text = "Второй вопрос";


                    scoreText2.Content = "Какая температура на поверхности солнца?";

                    ans1.Content = "6 000 °С";
                    ans2.Content = "10 000 °С";
                    ans3.Content = "3 000 °С";

                    ans1.Tag = "1";


                    break;

                case 3:

                    txtQuestion.Text = "Третий вопрос";


                    scoreText2.Content = "Планеты какой группы относительно небольшие и плотные?";

                    ans1.Content = "Гиганты";
                    ans2.Content = "Земные";
                    ans3.Content = "Космические";

                    ans2.Tag = "1";


                    break;

                case 4:

                    txtQuestion.Text = "Четвертый вопрос";


                    scoreText2.Content = "Какие планеты во много раз больше других планет?";

                    ans1.Content = "Титаны";
                    ans2.Content = "Гиганты";
                    ans3.Content = "Огромные";

                    ans2.Tag = "1";


                    break;

                case 5:

                    txtQuestion.Text = "Пятый вопрос";


                    scoreText2.Content = "Сколько основных планет входит в солнечную систему?";

                    ans1.Content = "8";
                    ans2.Content = "1";
                    ans3.Content = "10";


                    ans1.Tag = "1";


                    break;
                case 6:

                    txtQuestion.Text = "Шестой вопрос";


                    scoreText2.Content = "Сколько карликовых планет входит в солнечную систему?";

                    ans1.Content = "20";
                    ans2.Content = "8";
                    ans3.Content = "5";

                    ans3.Tag = "1";


                    break;
                case 7:

                    txtQuestion.Text = "Седьмой вопрос";


                    scoreText2.Content = "Почему светит солнце?";

                    ans1.Content = "Просто";
                    ans2.Content = "Атомные реакции";
                    ans3.Content = "Оно горит";

                    ans2.Tag = "1";


                    break;
                case 8:

                    txtQuestion.Text = "Восьмой вопрос";


                    scoreText2.Content = "Сколько примерно могло бы поместиться земных шаров в Солнце?";

                    ans1.Content = "Менее 1 млн";
                    ans2.Content = "Одна";
                    ans3.Content = "Более 1 млн";

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
