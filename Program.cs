using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace hotelReservation {
    class Program {
        int revenue = 0;
        Rooms[] roomsList = { new Rooms("luxury", 1, false, 300), new Rooms("luxury", 2, false, 350), new Rooms("regular", 3, false, 200), new Rooms("regular", 4, false, 180) };
        static void Main(String[] args){
            
            Program hotel = new Program();

            while (true){
                Console.WriteLine("Hi! Welcome to our hotel. What would you like to do today?");
                string action = Console.ReadLine();
                if (action == "Book"){
                    hotel.bookRoom();
                }
                else if (action == "Leave"){
                    hotel.leaveRoom();
                }
                else if (action == "Done"){
                    Console.WriteLine("Thank you for stopping by the hotel!");
                    Console.WriteLine("Revenue earned: ${0}", hotel.revenue);
                    break;
                }
                else{
                    Console.WriteLine("Sorry, that is not an option here.");
                }
            }
        }

        public void bookRoom(){
            Type:
            Console.WriteLine("What type of room would you like?");
            string roomType = Console.ReadLine();
            if (roomType == "luxury"){
                BookRoom:
                Console.WriteLine("Select either rooms 1 or 2.");
                int roomNo = Int32.Parse(Console.ReadLine());
                if (roomNo == 1){
                    if (roomsList[0].getBooked()){
                        Console.WriteLine("This room is already booked.");
                        goto BookRoom;
                    }
                    roomsList[0].setBooked(true);
                    revenue += roomsList[0].getPrice();
                    Console.WriteLine("Thank you for choosing this room!");
                }
                else if (roomNo == 2){
                    if (roomsList[1].getBooked()){
                        Console.WriteLine("This room is already booked.");
                        goto BookRoom;
                    }
                    roomsList[1].setBooked(true);
                    revenue += roomsList[1].getPrice();
                    Console.WriteLine("Thank you for choosing this room!");
                }
                else{
                    Console.WriteLine("No luxury rooms have that number.");
                    goto BookRoom;
                }
            }
            else if (roomType == "regular"){
                BookRoom:
                Console.WriteLine("Select either rooms 3 or 4.");
                int roomNo = Int32.Parse(Console.ReadLine());
                if (roomNo == 3){
                    if (roomsList[2].getBooked()){
                        Console.WriteLine("This room is already booked.");
                        goto BookRoom;
                    }
                    roomsList[2].setBooked(true);
                    revenue += roomsList[2].getPrice();
                    Console.WriteLine("Thank you for choosing this room!");
                }
                else if (roomNo == 4){
                    if (roomsList[3].getBooked()){
                        Console.WriteLine("This room is already booked.");
                        goto BookRoom;
                    }
                    roomsList[3].setBooked(true);
                    revenue += roomsList[3].getPrice();
                    Console.WriteLine("Thank you for choosing this room!");
                }
                else{
                    Console.WriteLine("No regular rooms have that number.");
                    goto BookRoom;
                }
            }
            else{
                Console.WriteLine("Sorry, we don't have that kind of room.");
                goto Type;
            }
        }

        public void leaveRoom(){
            Console.WriteLine("Which room would you like to leave?");
            int roomNo = Int32.Parse(Console.ReadLine());

            if (roomNo > roomsList.Length){
                Console.WriteLine("We don't have that room here.");
            }
            else if (!roomsList[roomNo - 1].getBooked()){
                Console.WriteLine("This room was already vacant.");
            }
            else{
                roomsList[roomNo - 1].setBooked(false);
                Console.WriteLine("We hoped you enjoyed your stay!");
            }
        }
    }
}