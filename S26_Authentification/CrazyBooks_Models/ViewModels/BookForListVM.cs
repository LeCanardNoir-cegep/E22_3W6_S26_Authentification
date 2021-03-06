using CrazyBooks_Models.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace CrazyBooks_Models.ViewModels
{
    public class BookForListVM
    {
        public BookForListVM()
        { }
        public BookForListVM(Book b)
        {
            Id = b.Id;
            Title = b.Title;
            ISBN = b.ISBN;
            Price = b.Price;
            Promo = b.Promo;
            Available = b.Available;
            PublishedDate = b.PublishedDate;
            Subject = b.Subject.Name;
            Publisher = b.Publisher.Name;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
        [Display(Name = "Promotion")]
        public bool Promo { get; set; } = false;
        public bool Available { get; set; } = true;
        public DateTime PublishedDate { get; set; }
        public string Subject { get; set; }
        public string Publisher { get; set; }
    }
}
