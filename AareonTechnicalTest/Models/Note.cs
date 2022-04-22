namespace AareonTechnicalTest.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int PersonId { get; set; }

        public int TicketId { get; set; }
    }
}
