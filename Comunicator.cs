using System;
using Logic;

namespace UI
{
    class Comunicator : IUIComunicator
    {
        public void OnError(string errorMessage)
        {
            Console.WriteLine("Error: " + errorMessage.ToUpper());
        }

        public void OnMessage(string message)
        {
            Console.WriteLine("Info: " + message);
        }

        public bool OnQuestion(string questionMessage)
        {
            throw new NotImplementedException();
        }
    }
}
