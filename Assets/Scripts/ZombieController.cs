using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    private GameObject Player;
    public float Speed = 1;
    // Start is called before the first frame update
    void Start()
    {
       Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = Player.transform.position - transform.position;
        transform.position = transform.position + target.normalized * Time.deltaTime * Speed;
    }
}
