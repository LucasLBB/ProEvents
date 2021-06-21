using System;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.API.Models
{
    public class Events
    {
        [Key]
        public int EventId { get; set; }
        public string Local { get; set; }
        public DateTime DateEvent { get; set;}
        public string Theme { get; set; }
        public int QtdPeople { get; set; }
        public string Batch { get; set; }
        public string Image { get; set; }
    }
}