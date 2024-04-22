using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{

    private TankModel tankModel;
    private TankView tankView;
    public Rigidbody tankRigidbody;
    // Start is called before the first frame update

    public TankController(TankModel _tankModel,TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView); ;
        tankRigidbody= tankView.tankRigidbody;
        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        tankView.ChangeColor(tankModel.color);

        
    }

    public void Move(float movement,float movementSpeed)
    {
        tankRigidbody.velocity = tankView.transform.forward * movement * movementSpeed;
    }
    public void Rotate(float rotate,float rotateSpeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        tankRigidbody.MoveRotation(tankRigidbody.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }

}
