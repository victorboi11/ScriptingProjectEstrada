using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;

        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }

        //Constuctor
        public Stuff ()
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }
    }

    // Created an Instance (an Object) ofthe Stuff class
    public Stuff myStuff;

    public Stuff myOtherStuff = new Stuff(50, 1.5f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
