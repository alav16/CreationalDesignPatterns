/*
Implement a graphic editor where users can duplicate shapes 
(Circle, Square, Rectangle) without manually copying all properties every time.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob7Prototype
{
    public interface IGraphic : ICloneable
    {
        void Draw();
    }

    public class Circle : IGraphic
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Radius: {Radius}");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Square : IGraphic
    {
        public int Side { get; set; }
        public Square(int side)
        {
            Side = side;
        }

        public void Draw()
        {
            Console.WriteLine($"Side: {Side}");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Rectangle : IGraphic
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Width: {Width}, Height: {Height}");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class GraphicEditor
    {
        public IGraphic CreateCopy(IGraphic graphic)
        {
            return (IGraphic)graphic.Clone();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var originCircle = new Circle(10);
            var originSquare = new Square(10);
            var originRect = new Rectangle(5, 10);

            originCircle.Draw();
            originSquare.Draw();
            originRect.Draw();

            var editor = new GraphicEditor();
            var clonedCircle = (Circle)editor.CreateCopy(originCircle);
            var clonedSquare = (Square)editor.CreateCopy(originSquare);
            var clonedRect = (Rectangle)editor.CreateCopy(originRect);

            clonedCircle.Radius = 20;
            clonedSquare.Side = 50;
            clonedRect.Width = 100;

            clonedCircle.Draw();
            clonedSquare.Draw();
            clonedRect.Draw();
            
            originCircle.Draw();
            originSquare.Draw();
            originRect.Draw();
        }
    }
}
