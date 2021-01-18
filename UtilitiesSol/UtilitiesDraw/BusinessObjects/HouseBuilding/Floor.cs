using System;
using System.Collections.Generic;



namespace UtilitiesDraw.BusinessObjects.HouseBuilding
{



    public class Floor
    {



        private int floorNumber;
        private string description;
        private List<Flat> flats;



        public Floor(int floorNumber, string description)
        {
            this.floorNumber = floorNumber;
            this.description = description;
            this.flats = new List<Flat>();
        }



        public int FloorNumber
        {
            get
            {
                return floorNumber;
            }

            set
            {
                floorNumber = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public List<Flat> Flats
        {
            get
            {
                return flats;
            }

            set
            {
                flats = value;
            }
        }



        // 0. patro (přízemí)
        // Byt: 10,2 m x 3,2 m, dvoukřídlé dveře, dvě okna "Standard"
        // Byt: 5,5 m x 3,2 m, jednokřídlé dveře, jedno okno "Standard"
        public static Floor GetGroundFloor()
        {
            Floor floor = new Floor(0, "přízemí");
            floor.Flats.Add(Flat.GetDoubleDoorTwoStandardWindowFlat());
            floor.Flats.Add(Flat.GetSingleDoorOneStandardWindowFlat());
            return floor;
        }



        // 1. patro (byt s francouzskými okny má balkon)
        // Byt: 8,2 m x 3,2 m, jednokřídlé dveře, dvě okna "Francouz"
        // Byt: 8,5 m x 3,2 m, jednokřídlé dveře, dvě okna "Standard"
        public static Floor GetFirstFloor()
        {
            Floor floor = new Floor(1, "byt s francouzskými okny má balkon");
            floor.Flats.Add(Flat.GetSingleDoorTwoFrenchWindowFlat());
            floor.Flats.Add(Flat.GetSingleDoorTwoStandardWindowFlat());
            return floor;
        }



        // 2. patro (s luxusním bytem a verandou)
        // Byt: 12,1 m x 4,5 m, dvoukřídlé dveře, jedno okno "Standard", jedno okno "Francouz"
        public static Floor GetSecondFloor()
        {
            Floor floor = new Floor(2, "s luxusním bytem a verandou");
            floor.Flats.Add(Flat.GetDoubleDoorOneStandardOneFrenchWindowFlat());
            return floor;
        }



    }



}
