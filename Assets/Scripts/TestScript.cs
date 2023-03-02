using System;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private void Start()
    {
        // Variable declaration
        {
            int a = 3;
            int b = 4;

            int sum = a + b; // Calculating

            Debug.Log(sum); // 7
        }

        // Variable assignment
        /*{
            string name = "Hannelore";
            Debug.Log(name); // Hannelore
            name = "Marigold";
            Debug.Log(name); // Marigold
        }*/

        // Scope 1
        /*{
            string name = "Hannelore";
            string name = "Marigold";
        }*/

        // Scope 2
        /*{
            {
                string person = "Hannelore";
                i = 5;
            }

            {
                string person = "Marigold";
            }

            Debug.Log(person);
        }*/

        // Float problems
        // {
        //     // float number1 = 0.5f;
        //     // float number2 = 0.1;
        //
        //     float tenth = 0.1f; // Not quite 0.1
        //     float one = 1f;
        //
        //     float result = one - tenth * 10f; // -1.490116E-08
        //
        //     bool equalZero = result == 0; // false
        //     bool approximatelyZero = Mathf.Abs(result) <= 0.01f; // true
        // }
        /*

        // Zusätzliche Funktion mit Mathf
        {
            float result = Mathf.Pow(2, 8); // 28 = 256
            float sqrt = Mathf.Sqrt(36); // 6
            float max = Mathf.Max(3, 4); // 4
            float min = Mathf.Min(3, 4); // 3
        }

        // Arithmetic Operators Hints
        {
            // Ganzzahliges Teilen
            float a = 3 / 4; // 0

            // Mindestens ein float in Berechnung
            float b = 3 / 4.0f; // 0.75f
        }
        {
            int a = 3;
            int b = 4;

            int sum = a + b++;
        }
        {
            int c = 3;
            int d = 4;

            int sum = c + ++d;
        }*/

        // If Else
        /*{
            if (5 > 3)
            {
                Debug.Log("Greater");

            }
            else
            {
                Debug.Log("Less");

            }
            Debug.Log("Always");
        }*/

        // Switch
        /*{
            int weekdayIndex = 0;
            string weekdayName;

            switch (weekdayIndex)
            {
                case 0:
                    weekdayName = "Monday";
                    break;
                case 1:
                    weekdayName = "Tuesday";
                    break;
                case 2:
                    weekdayName = "Wednesday";
                    break;
                case 3:
                    weekdayName = "Thursday";
                    break;
                case 4:
                    weekdayName = "Friday";
                    break;
                case 5:
                    weekdayName = "Saturday";
                    break;
                case 6:
                    weekdayName = "Sunday";
                    break;
                default:
                    weekdayName = "Unknown";
                    break;
            }
        }*/

        // Loops
        // {
        //     int maxValue = 3;
        //     int currentValue = 1;
        //
        //     while (currentValue <= maxValue)
        //     {
        //         Debug.Log(currentValue);
        //         currentValue++;
        //     }
        // }
        /*{
            for (int i = 1; i <= 3; i++)
            {
                Debug.Log(i);
            }
        }*/
        // show break and continue at 2
    }
}
