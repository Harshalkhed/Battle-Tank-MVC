using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{

    public TankSpawner tankSpawner;
    
    public void BlueTankselected()
    {
        //Debug.Log("blue tank button");
        tankSpawner.CreateTank(TankType.Bluetank);
        this.gameObject.SetActive(false);
    }
    public void GreenTankselected()
    {
       tankSpawner.CreateTank(TankType.GreenTank);
        this.gameObject.SetActive(false);
    }
    public void RedTankselected()
    {
        tankSpawner.CreateTank(TankType.RedTank);
        this.gameObject.SetActive(false);
    }
}
