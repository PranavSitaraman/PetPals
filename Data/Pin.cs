using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace PetPals.Data
{
    public record Pin
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Time { get; set; }
        public PinKind Kind { get; set; }

    }
    public enum PinKind
    {
        [Display(Name = "Car")] Car
    }
}