using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamReadMoreReadLessButton
{
    public partial class ReadMoreReadLessControl : ContentView
    {        
        private (string ReadLess, string ReadMore) _states = ("ReadLess", "ReadMore");
        private string _currentState;

        public ReadMoreReadLessControl()
        {
            InitializeComponent();

            _currentState = _states.ReadLess;
            ToggleState();
        }

        private void ToggleState()
        {
            VisualStateManager.GoToState(LabelContent, _currentState);
            VisualStateManager.GoToState(ReadMoreReadLessButton, _currentState);
        }

        void ReadMoreReadLessButton_Clicked(object sender, EventArgs e)
        {
            if (LabelContent.Text == string.Empty) return;

            _currentState = _currentState == _states.ReadLess
                ? _states.ReadMore
                : _states.ReadLess;

            ToggleState();
        }

        public string Text
        {
            get { return (string) LabelContent.GetValue(Label.TextProperty); }
            set { LabelContent.SetValue(Label.TextProperty, value); }
        }        
    }
}
