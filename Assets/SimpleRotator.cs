using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotator : MonoBehaviour
{
    [SerializeField] private float speedX = 0f;
    [SerializeField] private float speedY = 0f;
    [SerializeField] private float speedZ = 0f;
    [SerializeField] private bool IsWorldSpace = false;

    void Update()
    {
        transform.Rotate(speedX * Time.deltaTime, speedY * Time.deltaTime, speedZ * Time.deltaTime, IsWorldSpace?Space.World:Space.Self);

    }

}
