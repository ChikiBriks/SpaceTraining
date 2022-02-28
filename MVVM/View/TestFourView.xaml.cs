using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SpaceTraining.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для TestFourView.xaml
    /// </summary>
    public partial class TestFourView : UserControl
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int qNum = 0;
        int i;
        int score;


        public TestFourView()
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


                    scoreText2.Content = "Небольшое планетоподобное тело Солнечной системы,\nдвижущийся по орбите вокруг Солнца – это?";

                    ans1.Visibility = Visibility.Visible;
                    ans2.Visibility = Visibility.Visible;
                    ans3.Visibility = Visibility.Visible;

                    ans1.Content = "Планета";
                    ans2.Content = "Астероид";
                    ans3.Content = "Комета";

                    ans2.Tag = "1";


                    break;

                case 2:

                    txtQuestion.Text = "Второй вопрос";


                    scoreText2.Content = "Кем был открыт первый астероид Церера?";

                    ans1.Content = "Пиацци";
                    ans2.Content = "Галилео";
                    ans3.Content = "Энштейн";

                    ans1.Tag = "1";


                    break;

                case 3:

                    txtQuestion.Text = "Третий вопрос";


                    scoreText2.Content = "Какие космические объекты, которые по своим характеристикам\nне могут быть отнесены к карликовым планетам, планетам или их спутникам?";

                    ans1.Content = "Огромные тела";
                    ans2.Content = "Большие тела";
                    ans3.Content = "Малые тела";

                    ans3.Tag = "1";


                    break;

                case 4:

                    txtQuestion.Text = "Четвертый вопрос";


                    scoreText2.Content = "Какой советский аппарат изучил комету Галлея в 1986 году?";

                    ans1.Content = "НАСА";
                    ans2.Content = "Вега";
                    ans3.Content = "Заря";

                    ans2.Tag = "1";


                    break;

                case 5:

                    txtQuestion.Text = "Пятый вопрос";


                    scoreText2.Content = "Какой пояс превышает массу ближнего пояса астероидов?";

                    ans1.Content = "Койпера";
                    ans2.Content = "Оорта";
                    ans3.Content = "Пиацци";


                    ans1.Tag = "1";


                    break;
                case 6:

                    txtQuestion.Text = "Шестой вопрос";


                    scoreText2.Content = "При приближении кометы к Солнцу замёрзшие газы\nна её поверхности начинают испаряться и образуют…?";

                    ans1.Content = "Взрыв";
                    ans2.Content = "Пыль";
                    ans3.Content = "Хвост";

                    ans3.Tag = "1";


                    break;
                case 7:

                    txtQuestion.Text = "Седьмой вопрос";


                    scoreText2.Content = "Какая общая масса всего ближнего пояса от массы Луны?";

                    ans1.Content = "10%";
                    ans2.Content = "4%";
                    ans3.Content = "2,5%";

                    ans2.Tag = "1";


                    break;
                case 8:

                    txtQuestion.Text = "Восьмой вопрос";


                    scoreText2.Content = "Маленькие космические тела, вращающиеся вокруг Солнца по конической орбите – это?";

                    ans1.Content = "Астероиды";
                    ans2.Content = "Болиды";
                    ans3.Content = "Кометы";

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
