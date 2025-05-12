/*
Create a drawing application where users can create different types of Brushes
(PencilBrush, InkBrush, PaintBrush) based on the selected tool.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob10FactoryMethod
{
    public interface IBrush
    {
        void Draw();
    }

    public class PencilBrush : IBrush
    {
        public void Draw()
        {
            Console.WriteLine("write with pencil");
        }
    }

    public class InkBrush : IBrush
    {
        public void Draw()
        {
            Console.WriteLine("write eith ink");
        }
    }

    public class PaintBrush : IBrush
    {
        public void Draw()
        {
            Console.WriteLine("write with paint");
        }
    }

    public interface IBrushFactory
    {
        IBrush CreateBrush();
    }

    public class PencilBrushFactory : IBrushFactory
    {
        public IBrush CreateBrush()
        {
            return new PencilBrush();
        }
    }

    public class InkBrushFactory : IBrushFactory
    {
        public IBrush CreateBrush()
        {
            return new InkBrush();
        }
    }

    public class PaintBrushFactory : IBrushFactory
    {
        public IBrush CreateBrush()
        {
            return new PaintBrush();
        }
    }

    public class Drawing
    {
        private IBrushFactory _factory;

        public Drawing(IBrushFactory factory)
        {
            _factory = factory;
        }

        public void Draw()
        {
            IBrush brush = _factory.CreateBrush();
            brush.Draw();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var dr = new Drawing(new PencilBrushFactory());
            dr.Draw();
        }
    }
}
