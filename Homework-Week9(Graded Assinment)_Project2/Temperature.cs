using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Week9_Graded_Assinment__Project2
{
    class Temperature
    {
        private float degrees;
        private char scale;                                        // <------------------------ clean up your program format PLEASE it's AWFUL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        public Temperature() 
        {             
            SetTemperatureAndScale(0, 'C');
        }

        public Temperature( float deg, char c) //constructor 2
        {
            SetTemperatureAndScale(deg, 'C');
            //degrees = deg; THE UNPROFESSIONAL WAY!!!!!!DONT DO THIS!!!
            //SetScale(c);           
        }

        public Temperature(float deg)           //constructor 3
        {
            SetTemperatureAndScale(deg, 'C');
        }

        public Temperature(char c)              //constructor 4
        {
            SetTemperatureAndScale(0, c);
        }
                                            

        public float GetCelsius()
        {
            return degrees;
        }

        public float GetFarenheit()
        {
            // F = 9((C/5) + 32
            return 9*(degrees / 5) + 32;
        }

        public void SetTemperature(float deg )
        {
            degrees = deg;
        }

        public void SetScale(char c)
        {
            scale = c.ToString().ToUpper()[0];   // make sure  celsius  is only set in only uppercase Or,,,,to lowercase if so desired!!!

            if (scale == 'C')   
            {

            }
        }

        public void SetTemperatureAndScale(float deg , char c)
        {
            SetTemperature(deg);
            SetScale(c);
        }
        
        public override string ToString()
        {
            return degrees + " " + scale;
        }

        public override bool Equals(object that)
        {
            Temperature thatTemp = (Temperature)that;// have to type cast to temperature type to uset getcelcius method
            return this.GetCelsius() == thatTemp.GetCelsius();
        }    
    }
}
