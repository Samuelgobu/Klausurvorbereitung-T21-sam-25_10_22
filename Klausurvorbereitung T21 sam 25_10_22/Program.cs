using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausurvorbereitung_T21_sam_25_10_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------------- Auto ----------------------------------------
            Console.WriteLine("Höchstgeschwindigkeit = ");
            Auto auto1 = new Auto(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Wollen Sie das Auto an machen? j/n");
            string antwort = Console.ReadLine(); ;

            if (antwort == "j")
            {
                auto1.SchlüsselDrehen();
            }
            
            
            Console.WriteLine("Gewählt Geschwindigkeit(km/h) und Zeit(h) (mit Enter key getrennt)");
            auto1.Fahren(Convert.ToDouble(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));
            auto1.Kilometerstand();
            // --------------- Auto ----------------------------------------
            //---------------- Physik --------------------------------------





            /* Aufgabe zur Klausurvorbereitung:
            * ---Aufgabe 1 ---
            * Erstellen Sie die Klasse Auto. Objekte in dieser Klasse
            * haben die Eigenschaften Höchstgeschwindigkeit,
            * Kilometerzähler und MotorAn (bool).
            *
            * Erstellen Sie einen Konstruktor, in dem der Nutzer die Höchstge-
            * schwindigkeit eingibt. MotorAn wird im Konstruktor auf false,
            * der Kilometerzähler wird auf 0 gesetzt.
            *
            * Erstellen Sie die Methode SchlüsselDrehen(). Wenn der Motor aus ist,
            * wird er eingeschaltet, wenn er an ist, wird er ausgeschaltet.
            *
            * Erstellen Sie die Methode Fahren(geschwindigkeit, zeit).
            * Die Methode prüft, ob der Motor eingeschaltet ist und ob die
            * Geschwindigkeit erreicht werden kann. Danach wird die Strecke
            * vom Kilometerzähler gezählt.
            *
            * Erstellen Sie die Methode Kilometerstand(). Sie schreibt den Wert
            * des Kilometerzählers in einem Satz in die Konsole.
            *
            * --- Aufgabe 2 ---
            * Erstellen Sie die statische Klasse Physik. Diese Klasse hat keine
            * Objekte.
            * Erstellen Sie in der Klasse die Konstante G mit dem Wert 9.81.
            *
            * Die Methoden sollen Methoden mit Rückgabewert sein!
            *
            * Erstellen Sie die Methode Wurfweite(v0, winkel). Die Methode
            * berechnet die Wurfweite eines schiefen Wurfs mit Abwurfwinkel
            * und Anfangsgeschwindigkeit v0. v0 in m/s; winkel in °.
            *
            * Erstellen Sie die Methode Wurfhöhe(v0, winkel).
            */
        }

    }
    
    class Auto
    {
        public double Höchstgeschwindigkeit;
        public double Kilometerzähler;
        public bool MotorAN;

        public Auto (double höchstgeschwindigkeit)
        {
            Höchstgeschwindigkeit = höchstgeschwindigkeit;
            Kilometerzähler = 0;
            MotorAN = false;
        }

        public void SchlüsselDrehen()
        {
            if (MotorAN == true)
            {
                MotorAN = false;
                Console.WriteLine("Das Auto wurde ausgeschaltet");
            }
            else if (MotorAN == false)
            {
                MotorAN = true;
                Console.WriteLine("Das Auto wurde angeschaltet");
            }
        }
        public void Fahren(double geschwindigkeit, int zeit)
        {
            if (MotorAN == true)
            {
                if (geschwindigkeit <= Höchstgeschwindigkeit)
                {
                    double strecke = geschwindigkeit * zeit;
                    Kilometerzähler += strecke;
                    
                }
                else
                {
                    Console.WriteLine("Diese Geschwindigkeit kann nicht erreicht werden");
                }
            }
            else
            {
                Console.WriteLine("Der Motor ist nicht an");

            }
        }
        public void Kilometerstand()
        {
            Console.WriteLine("Anzahl der zuruckgelegte Kilometer = " + Kilometerzähler + "km");
        }
    }
    static class Physik
    {
        public readonly static double G = 9.81;

        public static double Wurfhöhe(double v0, double winkel)
        {
            double maxhöhe = Math.Sin(winkel)*v0;
            
            return maxhöhe;
        }
        public static double Wurfweite(double v0, double winkel)
        {
            double weite = 0;

            return weite;
        }

    }
}
