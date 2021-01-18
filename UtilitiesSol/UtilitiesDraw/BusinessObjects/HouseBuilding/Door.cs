using System;
using System.Collections.Generic;
using System.Drawing;
using UtilitiesDraw.PaintersObjects;


namespace UtilitiesDraw.BusinessObjects.HouseBuilding
{



    public class Door : BuildingElement
    {



        private double width;
        private double height;
        private bool isDoubleWinged;



        public Door(double width, double height, bool isDoubleWinged)
        {
            this.width = width;
            this.height = height;
            this.isDoubleWinged = isDoubleWinged;
        }



        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public bool IsDoubleWinged
        {
            get
            {
                return isDoubleWinged;
            }

            set
            {
                isDoubleWinged = value;
            }
        }



        // Dveře: 0,9 metru x 2,2 metru, jednokřídlé
        public static Door GetSingleDoor()
        {
            Door door = new Door(0.9, 2.2, false);
            return door;
        }



        // Dveře: 1,8 metru x 2,1 metru, dvoukřídlé
        public static Door GetDoubleDoor()
        {
            Door door = new Door(1.8, 2.1, true);
            return door;
        }


        public override void DrawSelfDoor(Graphics g, CanvasContext context)
        {
            int DoorHeight = 275;
            Rectangle DoorRectangle = new Rectangle(context.Left + 70, context.Top + 205, context.Width - 600, DoorHeight);
            Rectangle Klika = new Rectangle(context.Left + 180, context.Top + 350, context.Width - 720, DoorHeight/ 50);
            Pen pen = new Pen(Color.Black, 3.0f);
            g.DrawRectangle(pen, DoorRectangle);
            g.DrawRectangle(pen, Klika);
        }



    }
}
