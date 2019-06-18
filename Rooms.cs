using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace hotelReservation {
    public class Rooms {
        private string roomType;
        private int roomNo;
        private bool isBooked;
        private int price;

        public Rooms(string roomType, int roomNo, bool isBooked, int price){
            this.roomType = roomType;
            this.roomNo = roomNo;
            this.isBooked = isBooked;
            this.price = price;
        }

        public void setBooked(bool reserved){
            isBooked = reserved;
        }

        public bool getBooked(){
            return isBooked;
        }

        public int getPrice(){
            return price;
        }
    }
}