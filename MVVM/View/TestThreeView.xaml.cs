using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SpaceTraining.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для TestThreeView.xaml
    /// </summary>
    public partial class TestThreeView : UserControl
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int qNum = 0;
        int i;
        int score;


        public TestThreeView()
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


                    scoreText2.Content = "ТУчение о Вселенной в целом, основанное на результатах\nисследований, доступных для астрономических наблюдений – это?";

                    ans1.Visibility = Visibility.Visible;
                    ans2.Visibility = Visibility.Visible;
                    ans3.Visibility = Visibility.Visible;

                    ans1.Content = "Вселенная";
                    ans2.Content = "Космология";
                    ans3.Content = "Галактика";

                    ans2.Tag = "1";


                    break;

                case 2:

                    txtQuestion.Text = "Второй вопрос";


                    scoreText2.Content = "Весь существующий материальный мир, безграничный во времени\nи пространстве и бесконечно разнообразный по формам. О чем это предложение? ";

                    ans1.Content = "Космос";
                    ans2.Content = "Галактика";
                    ans3.Content = "Вселенная";

                    ans3.Tag = "1";


                    break;

                case 3:

                    txtQuestion.Text = "Третий вопрос";


                    scoreText2.Content = "Какая часть Вселенной, доступна для астрономических наблюдений?";

                    ans1.Content = "Галактика";
                    ans2.Content = "Вселенная";
                    ans3.Content = "Метагалактика";

                    ans3.Tag = "1";


                    break;

                case 4:

                    txtQuestion.Text = "Четвертый вопрос";


                    scoreText2.Content = "Сколько существует Вселенная?";

                    ans1.Content = "10 млн лет";
                    ans2.Content = "15 млрд лет";
                    ans3.Content = "13 млрд лет";

                    ans2.Tag = "1";


                    break;

                case 5:

                    txtQuestion.Text = "Пятый вопрос";


                    scoreText2.Content = "С какого года используют методы радиолокации для изучения вселенной?";

                    ans1.Content = "1931 г.";
                    ans2.Content = "1961 г.";
                    ans3.Content = "1885 г.";


                    ans1.Tag = "1";


                    break;
                case 6:

                    txtQuestion.Text = "Шестой вопрос";


                    scoreText2.Content = "Как называются пустотные области, которые\nнаходятся на последнем уровне во Вселенной? ";

                    ans1.Content = "Черная дыра";
                    ans2.Content = "Оазисы";
                    ans3.Content = "Войды";

                    ans3.Tag = "1";


                    break;
                case 7:

                    txtQuestion.Text = "Седьмой вопрос";


                    scoreText2.Content = "В составе какой структуры десятки или даже\nсотни галактических систем или их скоплений? ";

                    ans1.Content = "Спиральная галактика";
                    ans2.Content = "Сверхскопление галактик";
                    ans3.Content = "Галактики";

                    ans2.Tag = "1";


                    break;
                case 8:

                    txtQuestion.Text = "Восьмой вопрос";


                    scoreText2.Content = "Когда произошел колоссальный переворот в науке о космическом пространстве? ";

                    ans1.Content = "30-е годы прошлого века";
                    ans2.Content = "20-е годы этого века";
                    ans3.Content = "20-е годы прошлого века";

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
