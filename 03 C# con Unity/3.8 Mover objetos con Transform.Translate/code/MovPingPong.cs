using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPingPong : MonoBehaviour
{
    public Transform miPosicion;
    public float velocidad;
    public float rango;
    public float distancia;

    private float posX;
    private float posY;
    private float posZ;

    void Start()
    {
        miPosicion = gameObject.GetComponent<Transform>();
        posX = miPosicion.transform.position.x;
        posY = miPosicion.transform.position.y;
        posZ = miPosicion.transform.position.z;
        velocidad = 2.0f;
        distancia = 4.7f;
        rango = -2.4f;
    }

    // Update is called once per frame
    void Update()
    {
        posX = Mathf.PingPong(Time.time * velocidad, distancia) + rango;
        miPosicion.transform.position = new Vector3(posX, posY, posZ);
    }
}
