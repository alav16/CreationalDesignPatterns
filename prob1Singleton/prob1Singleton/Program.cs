/*
Create a ConfigurationManager class that stores application settings like theme, language, and version
It should always return the same instance wherever used. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace prob1Singleton
//{

//    public class ConfigurationManager
//{
//    private static ConfigurationManager instance;

//    private ConfigurationManager()
//    {
//        Console.WriteLine("Instance created");
//    }

//    public static ConfigurationManager GetInstance()
//    {
//        if (instance == null)
//        {
//            instance = new ConfigurationManager();
//        }
//        return instance;
//    }

//    public void ShowMessage()
//    {
//        Console.WriteLine("It is instance of Singleton");
//    }
//}
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        ConfigurationManager theme = ConfigurationManager.GetInstance();
//        theme.ShowMessage();

//        ConfigurationManager language = ConfigurationManager.GetInstance();
//        language.ShowMessage();

//        ConfigurationManager version = ConfigurationManager.GetInstance();
//        version.ShowMessage();

//        Console.WriteLine(theme == language);
//        Console.WriteLine(language == version);
//        Console.WriteLine(version == theme);
//    }
//}
//}



public class ConfigurationManager
{
    private static readonly Lazy<ConfigurationManager> _instance =
        new Lazy<ConfigurationManager>(() => new ConfigurationManager());

    private ConfigurationManager()
    {
        Console.WriteLine("Instance created");
    }

    public static ConfigurationManager Instance => _instance.Value;

    public void ShowMessage()
    {
        Console.WriteLine("It is instance from Lazy<T>");
    }
}
internal class Program
{
    static void Main(string[] args)
    {

        var config = ConfigurationManager.Instance;
        config.ShowMessage();
    }
}

