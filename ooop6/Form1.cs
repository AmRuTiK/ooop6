using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooop6
{
    public partial class Form1 : Form
    {
        private List<CFigure> figures = new List<CFigure>();    //лист для хранения фигур
        public int objectSize = 10;
        public bool Cntrl;

        Color color = Color.Red;
        Color red = Color.Red;
        Color green = Color.Green;
        Color blue = Color.Blue;
        Color purple = Color.Purple;
        Color black = Color.Black;
        int colorindex = 0;

        int selectedFigure = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsizeplus_Click(object sender, EventArgs e)
        {
            GetBigger();
        }


        private void buttoncircle_Click(object sender, EventArgs e)
        {
            selectedFigure = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
            }
        }



        void control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;  //сглаживание
            foreach (CFigure figure in figures)
            {
                figure.SelfDraw(e.Graphics);    //метод круга для отрисовки самого себя

            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Cntrl)
            {
                foreach (CFigure figure in figures)
                {
                    figure.setCondition(false);

                }
                switch (selectedFigure)
                {
                    case 0:
                        CCircle newcircle = new CCircle(e.X, e.Y, objectSize, color);
                        newcircle.setCondition(true);
                        figures.Add(newcircle);
                        break;

                    case 1:
                        CSquare newsquare = new CSquare(e.X, e.Y, objectSize, color);
                        newsquare.setCondition(true);
                        figures.Add((newsquare));
                        break;

                    case 2:
                        CTriangle newtriangle = new CTriangle(e.X, e.Y, objectSize, color);
                        newtriangle.setCondition(true);
                        figures.Add(newtriangle);
                        break;
                    case 3:
                        CSection newsection = new CSection(e.X, e.Y, objectSize, color);
                        newsection.setCondition(true);
                        figures.Add(newsection);
                        break;

                }
                Refresh();
            }
            else if (Cntrl)
            {
                foreach (CFigure figure in figures)

                {
                    if (figure.MouseCheck(e))
                    {
                        figure.setCondition(true);
                        break;
                    }
                }
            }
            Refresh ();
        }

      

        private void Form1_KeyDown(object sender, KeyEventArgs e)   //нажатие кнопок
        {
            if (Control.ModifierKeys == Keys.Control)
                checkBoxctrl.Checked = true;
            else if (Control.ModifierKeys == Keys.Delete)
                DelFigure();
            else if (e.KeyCode == Keys.Up)
            {
                foreach (CFigure figure in figures)
                {
                    if (figure.selected && ((figure.coords.Y - figure.rad) > 0))
                    {
                        figure.coords.Y -= 3;
                    }
                }
                Refresh();
            }

            else if (e.KeyCode==Keys.Down)
            {
                foreach (CFigure figure in figures)
                {
                    if (figure.selected && ((figure.coords.Y+figure.rad) < (int)this.ClientSize.Height))
                        figure.coords.Y += 3;
                }
                Refresh();
            }
            else if (e.KeyCode == Keys.Left)
            {
                foreach (CFigure figure in figures)
                {
                    if (figure.selected && ((figure.coords.X - figure.rad) > 0))
                        figure.coords.X -= 3;
                }
                Refresh();
            }
            else if (e.KeyCode == Keys.Right)
            {
                foreach (CFigure figure in figures)
                {
                    if (figure.selected && ((figure.coords.X + figure.rad) < (int)ClientSize.Width))
                        figure.coords.X += 3;
                }
                Refresh();
            }
            else if (e.KeyCode==Keys.Oemplus)
            {
                GetBigger();
            }
            else if (e.KeyCode==Keys.OemMinus)
            {
                GetSmaller();
            }
            

               
        }

        private void DelFigure()
        {
            for (int i = 0; i < figures.Count; i++)
            {
                if (figures[i].selected==true)
                {
                    figures.Remove(figures[i]);
                    i--;
                }
            }
            Refresh();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)     //отжатие кнопки
        {
            checkBoxctrl.Checked = false;
        }

        private void checkBoxctrl_CheckedChanged(object sender, EventArgs e)
        {
            Cntrl=checkBoxctrl.Checked;
            foreach (CFigure figure in figures) {
                figure.fcntrl = Cntrl;

            }
        }

        private void buttonsizeminus_Click(object sender, EventArgs e)
        {
            GetSmaller();
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            DelFigure();
        }
        private void GetSmaller()   //метод уменьшения фигур
        {
            foreach (CFigure figure in figures) 
            {
                if (figure.selected && figure.rad>10)
                    figure.rad -=5;
            }
            Refresh();
        }
        private void GetBigger()    //метод увеличения фигур
        {
            foreach (CFigure figure in figures)
            {
                if (figure.selected && figure.rad <=95)
                    figure.rad += 5;
            }
            Refresh();
        }

        private void buttonsquare_Click(object sender, EventArgs e)
        {
            selectedFigure = 1;
        }

        private void buttontri_Click(object sender, EventArgs e)
        {
            selectedFigure = 2;
        }

        private void buttonsel_Click(object sender, EventArgs e)
        {
            selectedFigure = 3;
        }

        private void buttoncol_Click(object sender, EventArgs e)
        {
            if (colorindex < 3)
                colorindex++;
            else
                colorindex = 0;
            switch (colorindex)
            {
                case 0:
                    color = red;
                    break;
                case 1:
                    color = green;
                    break;
                case 2:
                    color = blue;
                    break;
                case 3:
                    color = purple;
                    break;
                case 4:
                    color = black;
                    break;
            }
            buttoncol.BackColor = color;
            foreach (CFigure figure in figures)
            {
                if (figure.selected)
                    figure.colorF = color;

            }
        }
        public class CFigure
        {
            public Point coords;
            public int rad;
            public bool selected = false;
            public bool fcntrl = false;

            public Color colorT = Color.CornflowerBlue;
            public Color colorF = Color.Purple;

            public void setCondition(bool cond) // метод переключения выделения
            {
                selected = cond;
            }
            public virtual void SelfDraw(Graphics g) // Метод для отрисовки самого себя
            {
            
            }
            public virtual bool MouseCheck(MouseEventArgs e) // Проверка объекта на попадание в него курсора
            {
                return false;
            }
            
        }
        public class CCircle : CFigure// класс круга
        {
            public CCircle(int x, int y, int radius, Color color) // конструктор по умолчанию
            {
                coords.X = x;
                coords.Y = y;
                rad = radius;
                colorF = color;
            }
            public override void SelfDraw(Graphics g) // Метод для отрисовки самого себя
            {
                if (!(selected != true))
                {
                    g.DrawEllipse(new Pen(colorT, 3), coords.X - rad, coords.Y - rad, rad * 2, rad * 2);
                }
                else
                    g.DrawEllipse(new Pen(colorF, 3), coords.X - rad, coords.Y - rad, rad * 2, rad * 2);
            }
            public override bool MouseCheck(MouseEventArgs e) // Проверка объекта на попадание в него курсора
            {
                if (fcntrl)
                {
                    if (Math.Pow(e.X - coords.X, 2) + Math.Pow(e.Y - coords.Y, 2) <= Math.Pow(rad, 2) && !selected)
                    {
                        selected = true;
                        return true;
                    }
                }
                return false;
            }

        }

        public class CSquare : CFigure // класс квадрата
        {
            public CSquare(int x, int y, int radius, Color color) // конструктор по умолчанию
            {
                coords.X = x;
                coords.Y = y;
                rad = radius;
                colorF = color;
            }
            public override void SelfDraw(Graphics g) // Метод для отрисовки самого себя
            {
                if (selected == true)
                    g.DrawRectangle(new Pen(colorT, 3), coords.X - rad, coords.Y - rad, rad * 2, rad * 2);
                else
                    g.DrawRectangle(new Pen(colorF, 3), coords.X - rad, coords.Y - rad, rad * 2, rad * 2);

            }
            public override bool MouseCheck(MouseEventArgs e) // Проверка объекта на попадание в него курсора
            {
                if (fcntrl)
                {
                    if (Math.Pow(e.X - coords.X, 2) + Math.Pow(e.Y - coords.Y, 2) <= Math.Pow(rad, 2) && !selected)
                    {
                        selected = true;
                        return true;
                    }
                }
                return false;
            }
        }

        public class CTriangle : CFigure // класс треугольника
        {
            public CTriangle(int x, int y, int radius, Color color) // конструктор по умолчанию
            {
                coords.X = x;
                coords.Y = y;
                rad = radius;
                colorF = color;
            }
            public override void SelfDraw(Graphics g) // Метод для отрисовки самого себя
            {
                Point point1 = new Point(coords.X, coords.Y - rad);
                Point point2 = new Point(coords.X + rad, coords.Y + rad);
                Point point3 = new Point(coords.X - rad, coords.Y + rad);
                Point[] curvePoints = { point1, point2, point3 };

                if (selected == true)
                    g.DrawPolygon(new Pen(colorT, 3), curvePoints);
                else
                    g.DrawPolygon(new Pen(colorF, 3), curvePoints);
            }
            public override bool MouseCheck(MouseEventArgs e) // Проверка объекта на попадание в него курсора
            {
                if (fcntrl)
                {
                    if (Math.Pow(e.X - coords.X, 2) + Math.Pow(e.Y - coords.Y, 2) <= Math.Pow(rad, 2) && !selected)
                    {
                        selected = true;
                        return true;
                    }
                }
                return false;
            }
        }

        public class CSection : CFigure // класс отрезка
        {
            public CSection(int x, int y, int radius, Color color) // конструктор по умолчанию
            {
                coords.X = x;
                coords.Y = y;
                rad = radius;
                colorF = color;
            }
            public override void SelfDraw(Graphics g) // Метод для отрисовки самого себя
            {
                Point point1 = new Point(coords.X - rad, coords.Y);
                Point point2 = new Point(coords.X + rad, coords.Y);
                Point[] curvePoints = { point1, point2 };

                if (selected == true)
                    g.DrawPolygon(new Pen(colorT, 3), curvePoints);
                else
                    g.DrawPolygon(new Pen(colorF, 3), curvePoints);
            }
            public override bool MouseCheck(MouseEventArgs e) // Проверка объекта на попадание в него курсора
            {
                if (fcntrl)
                {
                    if (Math.Pow(e.X - coords.X, 2) + Math.Pow(e.Y - coords.Y, 2) <= Math.Pow(rad, 2) && !selected)
                    {
                        selected = true;
                        return true;
                    }
                }
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (CFigure figure in figures)
            {
                figure.setCondition(false);
            }
            Refresh(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(CFigure figure in figures)  //выделение всех объектов
            {
                figure.setCondition(true);

            } 
            Refresh();
                
        }
    }
}


