using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
    private TankController tankController;

    // Start is called before the first frame update

    public TankModel()
    {

    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

}
