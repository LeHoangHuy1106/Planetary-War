using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{

    protected PointController pointController;

    public void SetPointController(PointController pointController)
    {
        this.pointController = pointController;
    }   
}
