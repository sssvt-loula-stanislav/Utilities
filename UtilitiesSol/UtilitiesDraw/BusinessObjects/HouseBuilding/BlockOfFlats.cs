using System;
using System.Collections.Generic;
using System.Drawing;
using UtilitiesDraw.PaintersObjects;

namespace UtilitiesDraw.BusinessObjects.HouseBuilding
{



    public class BlockOfFlats : BuildingElement
    {



        private Address address;
        private List<Floor> floors;



        public BlockOfFlats(Address address)
        {
            this.address = address;
            this.floors = new List<Floor>();
        }



        public Address Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public List<Floor> Floors
        {
            get
            {
                return floors;
            }

            set
            {
                floors = value;
            }
        }



        public override void DrawSelf(Graphics g, CanvasContext context)
        {
            int roofHeight = 150;
            int livingPartHeight = context.Height - roofHeight;

            Rectangle roofRectangle = new Rectangle(context.Left + 2, context.Top + 2, context.Width - 4, roofHeight);
            Rectangle livingRectangle = new Rectangle(context.Left + 2, context.Top + 2 + roofHeight, context.Width - 4, livingPartHeight - 4);
            using (Pen pen = new Pen(Color.Black, 3.0f))
            //using (Pen pen = new Pen(Color.Black, 2.0f))
            {
                //Point roofTip = new Point(roofRectangle.X + roofRectangle.Width / 2);
                //Point roofLeft = new Point(roofRectangle.X, roofRectangle.Y);
                //Point roofRight = new Point(roofRectangle.X + roofRectangle.Width, roofRectangle.Y + roofRectangle.Height, roofRectangle.Bottom);
                Point roofTip = new Point(roofRectangle.Left + roofRectangle.Width / 2);
                Point roofLeft = new Point(roofRectangle.Left, roofRectangle.Bottom);
                Point roofRight = new Point(roofRectangle.Right, roofRectangle.Bottom);
                g.DrawPolygon(pen, new Point[] { roofTip, roofLeft, roofRight});
                g.DrawRectangle(pen, livingRectangle);
            }
        }



        /*
        • Adresa: K Ládví 344, Praha 8, 181 00
        • Patra:
        • 0. patro (přízemí)
        • Byt: 10,2 m x 3,2 m, dvoukřídlé dveře, dvě okna "Standard"
        • Byt: 5,5 m x 3,2 m, jednokřídlé dveře, jedno okno "Standard"
        • 1. patro (byt s francouzskými okny má balkon)
        • Byt: 8,2 m x 3,2 m, jednokřídlé dveře, dvě okna "Francouz"
        • Byt: 8,5 m x 3,2 m, jednokřídlé dveře, dvě okna "Standard"
        • 2. patro (s luxusním bytem a verandou)
        • Byt: 12,1 m x 4,5 m, dvoukřídlé dveře, jedno okno "Standard", jedno okno "Francouz"
        */
        public static BlockOfFlats GetKLadviBlockOfFlats()
        {
            BlockOfFlats block = new BlockOfFlats(Address.GetKLadviAddress());
            block.Floors.Add(Floor.GetGroundFloor());
            block.Floors.Add(Floor.GetFirstFloor());
            block.Floors.Add(Floor.GetSecondFloor());
            return block;
        }



    }



}
