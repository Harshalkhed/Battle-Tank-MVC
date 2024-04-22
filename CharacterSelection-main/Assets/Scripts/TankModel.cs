using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
    private TankController tankController;

    public float movementSpeed;
    public float rotateSpeed;
    public TankType tankType;
    public Material color;
    // Start is called before the first frame update

    public TankModel(float _movementSpeed,float _rotateSpeed,TankType tank,Material _color)
    {
        movementSpeed = _movementSpeed;
        rotateSpeed = _rotateSpeed;
        tankType = tank;
        color = _color;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

}
