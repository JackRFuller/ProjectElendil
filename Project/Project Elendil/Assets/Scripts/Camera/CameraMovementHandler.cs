using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementHandler : BaseMonoBehaviour
{
    //Components
    private CharacterController cameraController;

    [Header("Movement Attributes")]
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float rotationSpeed;
    [SerializeField]
    private float zoomSpeed;

    private void Start()
    {
        cameraController = this.GetComponent<CharacterController>();
    }

    public override void UpdateNormal()
    {
        MoveCamera();

        RotateCamera();

        ZoomCamera();
    }

    private void MoveCamera()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, y, 0) * movementSpeed;
        dir = transform.TransformDirection(dir);

        cameraController.Move(dir * Time.deltaTime);
    }

    private void RotateCamera()
    {
        
        if (Input.GetKey(KeyCode.Q))
            transform.RotateAround(this.transform.position, -Vector3.up, rotationSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.E))
            transform.RotateAround(this.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }

    private void ZoomCamera()
    {

    }
}
