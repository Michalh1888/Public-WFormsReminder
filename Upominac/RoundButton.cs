using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRoundButton
{
    //** Vytvoření svého vlastního ovládacího prvku "Button" **
    //Vytvoření a přepsání klasického prvku "Button"
    //Vytvoření nových vlastních vlastností BorderSize,BorderRadius,BorderColor,BackgroundColor a TextColor
    //(zobrazí se v Properties design tlačítka),dále vytv. nové kategorie v Properties okně("RoundButton")
    //Po vytvoření této třídy => Build


    public class RoundButton : Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;

        //Properties
        [Category("RoundButton")]//vytvoření kategorie "RoundButton" v okně Properties prvku(button)
        public int BorderSize   //nová vlastnost
        {
            get { return borderSize; }
            set { borderSize = value; Invalidate(); }
        }

        [Category("RoundButton")]
        public int BorderRadius //nová vlastnost
        {
            get { return borderRadius; }
            set
            {
                if (value <= Height) borderRadius = value;
                else borderRadius = Height;
                Invalidate();
            }
        }

        [Category("RoundButton")]
        public Color BorderColor    //nová vlastnost
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        [Category("RoundButton")]
        public Color BackgroundColor    //nová vlastnost
        {
            get { return BackColor; }
            set { BackColor = value; }
        }

        [Category("RoundButton")]
        public Color TextColor  //nová vlastnost
        {
            get { return ForeColor; }
            set { ForeColor = value; }
        }

        [Category("RoundButton")]
        public bool Border3D { get; set; }
        

        //Constructor
        public RoundButton()
        {   
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
            Resize += new EventHandler(Button_Resize);
        }
        //nová událost změny velikosti
        private void Button_Resize(object? sender, EventArgs e)
        {
            if (borderRadius > Height) borderRadius = Height;
        }

        //Methods
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }
        //metoda "OnPaint()" se spustí při překreslení(vytvoření) prvku
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurface = new RectangleF(0, 0, Width, Height);
            RectangleF rectBorder = new RectangleF(1, 1, Width - 0.8F, Height - 1);

            if (borderRadius > 2) //Round Button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //Button surface
                    Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    
                    //Button border
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                //Button surface
                Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }


            //3D borders of button
            if (Border3D)
            {
                Rectangle rect = Rectangle.Round(rectBorder);
                ControlPaint.DrawBorder(pevent.Graphics, rect,
                       BorderColor, BorderSize, ButtonBorderStyle.Outset,
                        BorderColor, BorderSize, ButtonBorderStyle.Outset,
                        BorderColor, BorderSize, ButtonBorderStyle.Outset,
                        BorderColor, BorderSize, ButtonBorderStyle.Outset) ;
            }
            

        }
        //metoda "OnHandleCreated()" se spustí při vytvoření/načtení prvku(spuš.aplikace)
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object? sender, EventArgs e)
        {
            Invalidate();
        }

        



    }
}
