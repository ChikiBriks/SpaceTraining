using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SpaceTraining.MVVM.View
{
    public partial class TestView : UserControl
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int qNum = 0;
        int i;
        int score;


        public TestView()
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


                    scoreText2.Content = "Астрономия – это наука, которая занимается изучением…?";

                    ans1.Visibility = Visibility.Visible;
                    ans2.Visibility = Visibility.Visible;
                    ans3.Visibility = Visibility.Visible;

                    ans1.Content = "Планет";
                    ans2.Content = "Вселенной";
                    ans3.Content = "Галактики";

                    ans2.Tag = "1";


                    break;

                case 2:

                    txtQuestion.Text = "Второй вопрос";


                    scoreText2.Content = "Из каких двух греческих слов, состоит название Астрономия?";

                    ans1.Content = "Астрон, Номос";
                    ans2.Content = "Светило, закон";
                    ans3.Content = "Звезда, светило";

                    ans1.Tag = "1";


                    break;

                case 3:

                    txtQuestion.Text = "Третий вопрос";


                    scoreText2.Content = "Благодаря каким ученым появился термин «Астрономия»?";

                    ans1.Content = "Пифагор, Менделеев";
                    ans2.Content = "Плутарх, Диофант";
                    ans3.Content = "Пифагор, Гиппарх";

                    ans3.Tag = "1";


                    break;

                case 4:

                    txtQuestion.Text = "Четвертый вопрос";


                    scoreText2.Content = " Для осуществления астрономических исследований,\n расчета координат, траекторий небесных тел, необходимо владеть науками…?";

                    ans1.Content = "Химия, физика";
                    ans2.Content = "Математика, география";
                    ans3.Content = "Механика, биология";

                    ans2.Tag = "1";


                    break;

                case 5:

                    txtQuestion.Text = "Пятый вопрос";


                    scoreText2.Content = "Знания какой науки нужны для определения химического состава небесных светил?";

                    ans1.Content = "Химия";
                    ans2.Content = "Математика";
                    ans3.Content = "Физика";


                    ans1.Tag = "1";


                    break;
                case 6:

                    txtQuestion.Text = "Шестой вопрос";


                    scoreText2.Content = "Для чего нужна биология в астрономии?";

                    ans1.Content = "Влияние планет на солнце";
                    ans2.Content = "Влияние солнца на планеты";
                    ans3.Content = "Влияние солнечного\nсвета на все живое";

                    ans3.Tag = "1";


                    break;
                case 7:

                    txtQuestion.Text = "Седьмой вопрос";


                    scoreText2.Content = "С чем познакомит вас история в астрономии?";

                    ans1.Content = "С Древним Римом";
                    ans2.Content = "Древними астрономами";
                    ans3.Content = "Древними учеными";

                    ans2.Tag = "1";


                    break;
                case 8:

                    txtQuestion.Text = "Восьмой вопрос";


                    scoreText2.Content = " Какая наука поможет исследовать значение\n и происхождение название планет и созвездия?";

                    ans1.Content = "Механика";
                    ans2.Content = "География";
                    ans3.Content = "Лингвистика";

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
