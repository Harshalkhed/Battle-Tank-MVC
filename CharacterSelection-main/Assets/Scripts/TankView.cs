using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    public Rigidbody tankRigidbody;
    private float movement;
    private float rotate;
    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -4f);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (movement != 0)
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        if (rotate != 0)
            tankController.Rotate(rotate, tankController.GetTankModel().rotateSpeed);

    }
    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotate = Input.GetAxis("Horizontal");
    }


    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public Rigidbody GetRigidbody()
    {
        return tankRigidbody;
    }
}
