namespace AareonTechnicalTest.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public Ticket Ticket { get; set; }

        public int TicketId { get; set; }
    }
}
