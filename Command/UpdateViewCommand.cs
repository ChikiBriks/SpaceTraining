using SpaceTraining.MVVM.ViewModel;
using System;
using System.Windows.Input;

namespace SpaceTraining.Command
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;
        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Theory")
            {
                viewModel.SelectedViewModel = new TheoryViewModel();
            }
            if (parameter.ToString() == "Start")
            {
                viewModel.SelectedViewModel = new StartViewModel();
            }
            if (parameter.ToString() == "Trainer")
            {
                viewModel.SelectedViewModel = new TrainerViewModel();
            }
            if (parameter.ToString() == "App")
            {
                viewModel.SelectedViewModel = new AppViewModel();
            }
            if (parameter.ToString() == "StartTwo")
            {
                viewModel.SelectedViewModel = new StartTwoViewModel();
            }
            if (parameter.ToString() == "TextOne")
            {
                viewModel.SelectedViewModel = new TextOneViewModel();
            }
            if (parameter.ToString() == "TextTwo")
            {
                viewModel.SelectedViewModel = new TextTwoViewModel();
            }
            if (parameter.ToString() == "TextThree")
            {
                viewModel.SelectedViewModel = new TextThreeViewModel();
            }
            if (parameter.ToString() == "TextFour")
            {
                viewModel.SelectedViewModel = new TextFourViewModel();
            }
            if (parameter.ToString() == "TextFive")
            {
                viewModel.SelectedViewModel = new TextFiveViewModel();
            }
            if (parameter.ToString() == "TextSix")
            {
                viewModel.SelectedViewModel = new TextSixViewModel();
            }
            if (parameter.ToString() == "Test")
            {
                viewModel.SelectedViewModel = new TestViewModel();
            }
            if (parameter.ToString() == "TestTwo")
            {
                viewModel.SelectedViewModel = new TestTwoViewModel();
            }
            if (parameter.ToString() == "TestThree")
            {
                viewModel.SelectedViewModel = new TestThreeViewModel();
            }
            if (parameter.ToString() == "TestFour")
            {
                viewModel.SelectedViewModel = new TestFourViewModel();
            }
            if (parameter.ToString() == "TestFive")
            {
                viewModel.SelectedViewModel = new TestFiveViewModel();
            }
            if (parameter.ToString() == "TestSix")
            {
                viewModel.SelectedViewModel = new TestSixViewModel();
            }
        }
    }
}
