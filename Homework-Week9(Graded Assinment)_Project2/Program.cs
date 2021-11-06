using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// Homework 9(Graded Assignment)    
/// File Name: Project2
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola
/// 
/// This a temperature Class that has two instance variables: A temperature value (a floating
/// point number) and a character for the scale, either C for celcius or F for Fahrenheight.
/// The class has 4 constructor methods: one for each instance variable(assuming zero degrees if
/// no value is specified and Celsius if no scale is specified),
/// one with two parameters for the two instance variables, and 
/// no-argument constructor(set to zero degrees Celsius). The following is included:
/// 
///1.) Two getter methods to return the temperature, 1 of them to return the temperature in Celsius, 
/// the other to return the temperature in Fahrenheit. 
/// Return the value rounded to the nearest tenth of a degree.
///
///2.)Three setter methods, one to set the temperature, 
///one to set the scale and one to set both instance variables.
///
///3.)A suitable ToString method.
///
///4.)An Equals method that compares two temperatures. 
///Hint call the same getTemperature method and compare that.
///
///5.)A driver program that tests each of the constructors, each of the getters, each of the setter, 
///the ToString method and the equals method, 
///make sure that the Equals can return both true and false.
///
/// formulas---> C = 5*(F - 32)/9    F = 9*(C/5) + 32

namespace Homework_Week9_Graded_Assinment__Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();  
            temp = new Temperature(25);
            temp = new Temperature('C');
            temp = new Temperature(25,'C');      
            Temperature temp1 = new Temperature(0);

            Console.WriteLine(temp); // Console.WriteLine(temp.ToString()) same!!! .ToString is implied when printing off the object temp//same for ny 
            
            Console.WriteLine(temp1);
            
            Console.WriteLine(temp.Equals(temp1));

            Console.WriteLine("First getter for celsius: "+temp.GetCelsius()); //Getter 1
            Console.WriteLine("Second getter for Fahrenheit: " + temp.GetFarenheit());
            temp.SetTemperatureAndScale(23, 'C');//put of different line!
            Console.WriteLine("Setter for celsius temperature: " + temp.GetCelsius() );  //SetTemperature
            Console.ReadLine();

        }
    }
}
