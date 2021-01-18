using System;
using System.Collections.Generic;
using System.Drawing;
using UtilitiesDraw.PaintersObjects;


namespace UtilitiesDraw.BusinessObjects.HouseBuilding
{



    public class Window : BuildingElement
    {



        private string modelName;
        private double width;
        private double height;



        public Window(string modelName, double width, double height)
        {
            this.modelName = modelName;
            this.width = width;
            this.height = height;
        }



        public string ModelName
        {
            get
            {
                return modelName;
            }

            set
            {
                modelName = value;
            }
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



        // Model "Standard", 0,8 metru x 1,5 metru
        public static Window GetStandardWindow()
        {
            Window window = new Window("Standard", 0.8, 1.5);
            return window;
        }



        // Model "Francouz", 1,0 metru x 2,2 metru
        public static Window GetFrenchWindow()
        {
            Window window = new Window("Francouz", 1.0, 2.2);
            return window;
        }

        public override void DrawSelfOkno(Graphics g, CanvasContext context)
        {
            int OknoHeight = 150;
            Rectangle DoorRectangle = new Rectangle(context.Left + 400, context.Top + 225, context.Width - 550, OknoHeight);
            Pen pen = new Pen(Color.Black, 3.0f);
            g.DrawRectangle(pen, DoorRectangle);
            g.DrawLine(pen, context.Left + 620, context.Top + 300, context.Width - 370, OknoHeight + 150);
            g.DrawLine(pen, context.Left + 510, context.Top + 375, context.Width - 261, OknoHeight + 75);
        }

    }



}
