using System;



namespace UtilitiesDraw.PaintersObjects
{



    /// <summary>
    /// Describes the part of the drawing canvas that can be used by a particular object owning this instance.
    /// </summary>
    public class CanvasContext
    {



        /// <summary>X coordinate of the top-left corner of the drawing area.</summary>
        private int left;

        /// <summary>Y coordinate of the top-left corner of the drawing area.</summary>
        private int top;

        /// <summary>Width of the drawing area.</summary>
        private int width;

        /// <summary>Height of the drawing area.</summary>
        private int height;



        /// <summary>
        /// Constructor.
        /// </summary>
        public CanvasContext()
        {
        }



        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="left">X coordinate of the top-left corner of the drawing area.</param>
        /// <param name="top">Y coordinate of the top-left corner of the drawing area.</param>
        /// <param name="width">Width of of the drawing area.</param>
        /// <param name="height">Height of the drawing area.</param>
        public CanvasContext(int left, int top, int width, int height)
        {
            this.left = left;
            this.top = top;
            this.width = width;
            this.height = height;
        }



        /// <summary>X coordinate of the top-left corner of the drawing area.</summary>
        public int Left
        {
            get { return this.left; }
            set { this.left = value; }
        }

        /// <summary>Y coordinate of the top-left corner of the drawing area.</summary>
        public int Top
        {
            get { return this.top; }
            set { this.top = value; }
        }

        /// <summary>Width of the drawing area.</summary>
        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        /// <summary>Height of the drawing area.</summary>
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }



    }



}
