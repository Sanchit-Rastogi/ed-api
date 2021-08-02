using System;
namespace ED_api.ViewModels
{
    public class PraiseDTO
    {
        public int Id { get; set; }

        public string Sender { get; set; }

        public string Receiver { get; set; }

        public string Title { get; set; }

        public string Message { get; set; }
    }
}
