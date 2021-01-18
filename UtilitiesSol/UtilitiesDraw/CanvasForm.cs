using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UtilitiesDraw.BusinessObjects.HouseBuilding;
using UtilitiesDraw.PaintersObjects;


namespace UtilitiesDraw
{
    public partial class CanvasForm : Form
    {

        private bool isDrawingVisible = false;

        public CanvasForm()
        {
            InitializeComponent();
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawingVisible)
            {  
                DrawAll(e.Graphics);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            this.isDrawingVisible = true;
            this.panelCanvas.Refresh();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.isDrawingVisible = false;
            this.panelCanvas.Refresh();
        }

        private void CanvasForm_Resize(object sender, EventArgs e)
        {
            if (this.isDrawingVisible)
            {
                this.panelCanvas.Refresh();
            }
        }



        private void DrawAll(Graphics g)
        {
            BlockOfFlats block = BlockOfFlats.GetKLadviBlockOfFlats();
            CanvasContext context = new CanvasContext(0, 0, panelCanvas.Width -5, panelCanvas.Height -5);
            block.DrawSelf(g, context);

            Door door = new Door(100, 50, false);
            door.DrawSelfDoor(g, context);

            Window okno = new Window("Standard", 100, 50);
            okno.DrawSelfOkno(g, context);
        }


    }

}
