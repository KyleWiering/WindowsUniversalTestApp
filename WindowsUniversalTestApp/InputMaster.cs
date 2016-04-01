using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.UI.Xaml.Controls;

namespace WindowsUniversalTestApp
{
    class InputMaster
    {
        public TextBox SystemTextBox { get;set;}

        private int Timer;

        public void construct()
        {
            
        }



        public void TalkToTheSystem(string input)
        {
            
            string Response = InterpretInput(input);

            SendAMessage(Response);

            
        }

        private void SendAMessage(string Message)
        {
            SystemTextBox.Text += "\nSystem: " + Message;
        }

        private string InterpretInput(string input)
        {
            string Response = "I do not believe that will work.";




            return Response;
        }
    }
}
