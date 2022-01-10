using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightMov : MonoBehaviour
{
    private Vector3 positionInitial;
    private Vector3 move;
    public float var = 0;

    void Start()
    {
        positionInitial = transform.position;
        move = new Vector3(20f,0f,0f);
    }

    void Update() => transform.position = Vector3.Lerp(positionInitial - move, positionInitial + move, Mathf.Abs(Mathf.Cos((1 + Time.realtimeSinceStartup) / 2)));
    
}
