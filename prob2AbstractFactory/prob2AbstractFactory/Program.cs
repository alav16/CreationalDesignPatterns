/*
You are building a GUI library that supports two styles: LightTheme and DarkTheme.
Each theme must provide its own version of Button, TextBox, and CheckBox.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob2AbstractFactory
{

    public interface IButton
    {
        void Render();
    }

    public interface ITextBox
        {
        void Render();
    }

    public interface ICheckBox
    {
        void Render();
    }

    public interface IThemeFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
        ICheckBox CreateCheckBox();
    }

    public class LightButton : IButton
    {
        public void Render() => Console.WriteLine("Light Button");
    }

    public class LightTextBox : ITextBox
    {
        public void Render() => Console.WriteLine("Light TextBox");
    }

    public class LightCheckBox : ICheckBox
    {
        public void Render() => Console.WriteLine("Light Check Box");
    }

    public class DarkButton : IButton
    {
        public void Render() => Console.WriteLine("Dark Button");
    }

    public class DarkTextBox : ITextBox
    {
        public void Render() => Console.WriteLine("Dark TextBox");
    }

    public class DarkCheckBox : ICheckBox
    {
        public void Render() => Console.WriteLine("Dark CheckBox");
    }
    public class LightThemeFactory : IThemeFactory
    {
        public IButton CreateButton() => new LightButton();
        public ITextBox CreateTextBox() => new LightTextBox();
        public ICheckBox CreateCheckBox() => new LightCheckBox();
    }

    public class DarkThemeFactory : IThemeFactory
    {
        public IButton CreateButton() => new DarkButton();
        public ITextBox CreateTextBox() => new DarkTextBox();
        public ICheckBox CreateCheckBox() => new DarkCheckBox();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IThemeFactory factory = new LightThemeFactory();
            var factorBut = factory.CreateButton();
            var factoryText = factory.CreateTextBox();
            var factoryCheck = factory.CreateCheckBox();

            factorBut.Render();
            factoryText.Render();
            factoryCheck.Render();

            IThemeFactory factory1 = new DarkThemeFactory();
            var factorBut1 = factory1.CreateButton();
            var factorText1 = factory1.CreateTextBox();
            var factoryCheck1 = factory1.CreateCheckBox();

            factorBut1.Render();
            factorText1.Render();
            factoryCheck1.Render();
        }
    }
}
