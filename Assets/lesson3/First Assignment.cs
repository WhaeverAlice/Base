using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAssignment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = 7;

        OperateOnInt(number);
        OperateOnIntWithIf(number);
        IntSwitch(number);
    }


    void OperateOnInt(int input)
    {
        int result = (input + 10) * 2;
        Debug.Log(result);
    }

    void OperateOnIntWithIf(int input)
    {
        int result = input + 10;
        if (result >= 15) 
        {
            Debug.Log($"{input} is bigger than 4");
        }
        else
        {
            Debug.Log($"{input} is smaller than 5");
        }

      
    }

    void IntSwitch(int input)
    {
        switch (input)
        {
            case 1:
                Debug.Log($"{input} is the loneliest number");
                break;
            case 3:
                Debug.Log($"{input} is a crowd");
                break;
            case 7:
                Debug.Log($"{input} ate nine");
                break;
        }

    }
}
