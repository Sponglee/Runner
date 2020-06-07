using PathCreation.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{

    public Transform playerHolder;

    public PathFollower playerFollower;
    public PathFollower cameraFollower;

    [SerializeField] private InputController _inputController;
    [SerializeField] private float playerSpeed = 5f;



    public float PlayerSpeed
    {
        get
        {
            return playerSpeed;
        }

        set
        {
            if(playerSpeed != value)
            {
            }
          
                playerSpeed = value;
                InitializePathFollower();
        }
    }


    private void Start()
    {
        InitializePathFollower();

    }


    public void InitializePathFollower()
    {
        playerFollower.speed = playerSpeed;
 
        cameraFollower.distanceTravelled = playerFollower.distanceTravelled + 5f;
        cameraFollower.speed = playerSpeed;
    }


    // Update is called once per frame
    void Update()
    {
        playerHolder.localPosition += Vector3.up* _inputController.playerInput;
    }
}
