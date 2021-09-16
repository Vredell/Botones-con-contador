using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Botones_con_contador
{
    public partial class MainPage : ContentPage
    {
        int _count;
        String _message;
        Button button1;
        public MainPage()
        {
            InitializeComponent();
            _count = 0;
            //_message = "you clicked me [0] times ";

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (button1 == null) 
                button1 = ((Button)sender);

            _count++;
            _message = "you clicked me {0} times";
            button1.Text = String.Format(_message, _count); 
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
           _message = "cliked me";
            if (button1 != null)
            {
                button1.Text = _message;
                _count = 0;
            
            }

        }
    }
}
