using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq;

public class Elevator : MonoBehaviour
{
    private List<int> Floors = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public bool Shabat;
    public int CurrentFloor;
    public int RequestedFloor;

    public int GoToFloor(int currentFloor, int requestedFloor)
    {
        int goToFloor = requestedFloor - currentFloor;
        
        return goToFloor;
    }

    public void ShabatElevator(List<int> floors, bool shabat)
    {
        
        int currentFloor = 0;
        foreach (int floor in floors)
        {
            currentFloor -= GoToFloor(floor, (floor + 1));
            Debug.Log($"now at floor {currentFloor}");
        }

        floors.Reverse();

        foreach (int floor in floors)
        {
            currentFloor -= GoToFloor(floor, (floor - 1));
            Debug.Log($"now at floor {currentFloor}"); 
        }

        floors.Sort();
       
        
    }

    public void OpenDoor()
    {
        Debug.Log("The doors are open");
    }

    public void CloseDoor()
    {
        Debug.Log("The doors are close");

    }

    public void OperateElevator(int currentFloor, int requestFloor, List<int> floors, bool shabat)
    {
        CloseDoor();
        
        if (shabat)
        {

            ShabatElevator(floors, shabat);

        }

        else if (!(currentFloor == requestFloor))
        {
            currentFloor -= GoToFloor(currentFloor, requestFloor);
            Debug.Log($"now at floor {currentFloor}");
        }

        OpenDoor();
    }
}

