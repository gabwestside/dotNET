using System;
using UsingInterfaces.Entities;

namespace UsingInterfaces.Services
{
    class RentalService
    {
        public double PricePerHours { get; set; }
        public double PricePerDay { get; set; }
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHours, double pricePerDay)
        {
            PricePerHours = pricePerHours;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHours * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
