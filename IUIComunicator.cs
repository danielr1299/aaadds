namespace Logic
{
    public interface IUIComunicator
    {
        void OnMessage(string message);
        void OnError(string errorMessage);
        bool OnQuestion(string questionMessage);
    }
}
