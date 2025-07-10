using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// when something is gray it mines its imported and not yet used

// this class inherits from MonoBehaviour class
// inheritance = extension vs. imports = Libraries
// libraries/imports allow for things like inputs, physics, and sprite renderers
public class GeoController : MonoBehaviour
{
    //=============================================
    //Variables
    //============================================

    // global
    int variableOne;
    int variableTwo = 5;
    string str1 = "Hello ";
    public int varOne = 9; // public means it can be acessed and modified by other scripts

    int challenge = 3;
    void Start()// Start is called before the first frame update
    {
        int variableThree = 3; // local
        string str2 = "World";
        // used for initalization
        Debug.Log("Hello World");
        // Debug is a class from unity, use for debugging and displaying
        // . is an access operater, allowing us to use functions or varibles from the debug class
        // Log() is a method from the Debug class, sends message inside the Console

        /*
         * int Integer - 1;
         * float Float = 3.14;
         * bool Boolean = true;
         * char Character = 'a';
         * string String = "hello World";
         */

        variableOne = 5;
        print(variableTwo +  variableTwo);
        Debug.Log(str1 + str2);

    }

    // Update is called once per frame
    void Update()
    {
        // runs every frame, like a function, this is where the logic goes
       // Debug.Log(challenge);
      //  challenge += 1;
    }
}
