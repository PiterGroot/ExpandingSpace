using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    int randomNumberItem1;
    int randomNumberItem2;
    int randomNumberItem3;
    // Start is called before the first frame update
    void Start()
    {
        randomNumberItem1 = RandomNum();
        randomNumberItem2 = RandomNum();
        randomNumberItem3 = RandomNum();
    }

    // Update is called once per frame
    void Update()
    {
        switch (randomNumberItem1)
        {
            case 1:
                
                return;
            case 2:
              
                return;
            case 3:
                
                return;
            case 4:
                
                return;
            case 5:
                return;
        }
        switch (randomNumberItem2)
        {
            case 1:

                return;
            case 2:

                return;
            case 3:

                return;
            case 4:

                return;
            case 5:
                return;
        }
        switch (randomNumberItem3)
        {
            case 1:

                return;
            case 2:

                return;
            case 3:

                return;
            case 4:

                return;
            case 5:
                return;
        }


    }

    int RandomNum()
    {
        int Number = Random.Range(1, 6);
        return Number;
    }
}
