namespace BlazorDemo
{
    public class PresentationReview
    {
        public List<int> GradesList { get; set; } = new List<int>();
        public event NotifyUpdateUi UpdateUiEvent;

        public void AddGrade(int value)
        {
            GradesList.Add(value);
            try
            {
                UpdateUiEvent.Invoke();
            }
            catch (Exception)
            {

            }
        }
    }
}
