/* SOLUCAO 2 - RUIM - RETORNANDO UMA STRING INFORMANDO O ERRO 
 
    • A semântica da operação é prejudicada
    • Retornar string não tem nada a ver com atualização de reserva
    • E se a operação tivesse que retornar um string?
    • Ainda não é possível tratar exceções em construtores
    • A lógica fica estruturada em condicionais aninhadas
*/

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using Aula144_ExcecoesPersonalizadasParte2.Entities;

namespace Aula144_ExcecoesPersonalizadasParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Booking error: Check-in date must be earlier than check-out date");
            }
            else
            {
                Booking booking = new Booking(roomNumber, checkIn, checkOut);
                Console.WriteLine("Booking: " + booking);

                Console.WriteLine();
                Console.WriteLine("Enter new dates for rebooking: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = booking.UpdateDates(checkIn, checkOut);

                if (error != null)
                {
                    Console.WriteLine("Booking error: " + error);
                }

                else
                {
                    Console.WriteLine("Booking: " + booking);
                }
            }
        }
    }
}
