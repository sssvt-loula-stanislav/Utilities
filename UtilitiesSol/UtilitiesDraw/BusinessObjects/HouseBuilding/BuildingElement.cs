using System;
using System.Drawing;

using UtilitiesDraw.PaintersObjects;



namespace UtilitiesDraw.BusinessObjects.HouseBuilding
{



    public class BuildingElement
    {



        public virtual void DrawSelf(Graphics g, CanvasContext context)
        {
            using (Brush brush = new SolidBrush(Color.Magenta))
            {
                g.FillRectangle(brush, context.Left, context.Top, context.Width, context.Height);
            }
        }

        public virtual void DrawSelfDoor(Graphics g, CanvasContext context)
        {
            using (Brush brush = new SolidBrush(Color.Blue))
            {
                g.FillRectangle(brush, context.Left, context.Top, context.Width, context.Height);
            }
        }
        public virtual void DrawSelfOkno(Graphics g, CanvasContext context)
        {
            using (Brush brush = new SolidBrush(Color.Blue))
            {
                g.FillRectangle(brush, context.Left, context.Top, context.Width, context.Height);
            }
        }


    }



}
