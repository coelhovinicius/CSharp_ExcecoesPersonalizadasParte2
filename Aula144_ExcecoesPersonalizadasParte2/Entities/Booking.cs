/* >>> CLASSE BOOKING <<< */
using System;

namespace Aula144_ExcecoesPersonalizadasParte2.Entities
{
    class Booking
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Booking()
        {
        }

        public Booking(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays; // Casting do double TotalDays para inteiro
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Rebooking error: Dates must be later than today";
            }
            if (checkOut <= checkIn)
            {
                return "Booking error: Check-out date must be later than check-in date";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null; // Indica que nao houve nenhum erro
        }

        public override string ToString()
        {
            return "Room " + RoomNumber
                + ", check-in: " + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: " + CheckOut.ToString("dd/MM/yyyy")
                + ", " + Duration() + " nights";
        }
    }
}
