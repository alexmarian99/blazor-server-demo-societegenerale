namespace BlazorDemo
{
    public delegate void NotifyUpdateUi();
    public class ChatSystem
    {
        public List<ChatMessage> Messages { get; set; } = new List<ChatMessage>();
        public event NotifyUpdateUi UpdateUiEvent;

        public void AddMessage(string Author, string Content)
        {
            Messages.Add(new ChatMessage()
            {
                Name = Author,
                Message = Content
            });
            try
            {
                UpdateUiEvent.Invoke();
            }
            catch (Exception)
            {

            }
        }
    }

    public class ChatMessage
    {
        public string Name { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
    }
}
