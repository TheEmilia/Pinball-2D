using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleManager : MonoBehaviour
{
    [SerializeField] bool isRightPaddle;
    [SerializeField] float rotationArc = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // on input, rotate about paddle axis (if right paddle, on right input, else on left input)
    }
}
