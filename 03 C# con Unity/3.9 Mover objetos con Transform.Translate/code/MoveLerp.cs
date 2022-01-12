using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLerp : MonoBehaviour
{
    public Transform vectorPlayer;
    public GameObject positionA;
    public GameObject positionB;
    public Vector3 posA;
    public Vector3 posB;
    void Start()
    {
        vectorPlayer = gameObject.GetComponent<Transform>();
        positionA = GameObject.Find("PositionA");
        positionB = GameObject.Find("PositionB");
        posA = positionA.transform.position;
        posB = positionB.transform.position;

    }

    void Update()
    {
        vectorPlayer.transform.position = posA;
        vectorPlayer.transform.position = Vector3.Lerp(posA, posB, Time.time * 0.5f);
    }
}
