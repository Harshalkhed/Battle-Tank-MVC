using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
    private TankController tankController;

    public float movementSpeed;
    public float rotateSpeed;
    // Start is called before the first frame update

    public TankModel(float _movementSpeed,float _rotateSpeed)
    {
        movementSpeed = _movementSpeed;
        rotateSpeed = _rotateSpeed;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

}
