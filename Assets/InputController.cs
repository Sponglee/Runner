using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    public float inputRate = 0.5f;
    public float playerInput;
    public bool CorrectInput = false;

    [Tooltip("Percentage of the screen from bottom")]
    public float startPosTreshold = 1f;
    void Update()
    {
        if (true)
        {
            

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 startPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
                //Debug.Log(startPos);
                if (Mathf.Abs(startPos.x) <= startPosTreshold)
                {
                    CorrectInput = true;
                }
                else
                {
                    CorrectInput = false;
                }
            }
            else if (Input.GetMouseButton(0) && CorrectInput)
            {
                    playerInput = Mathf.Clamp(Input.GetAxis("Mouse X"), -10f, 10f)*inputRate;
            }
            else if (Input.GetMouseButtonUp(0))
            {
                playerInput = 0f;
            }
        }

    }
}
