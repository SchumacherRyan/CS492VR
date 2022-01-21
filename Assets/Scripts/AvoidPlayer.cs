using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidPlayer : MonoBehaviour
{

    public float speed;
    public GameObject player;


    // Update is called once per frame
    void Update()
    {
        Avoid();
    }

    private void Avoid() {
        if(Vector3.Distance(transform.position, player.transform.position) < 2) 
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, -1 * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Wall"))
        {
            transform.position = new Vector3(0.0f, 0.5f, 0.0f);
        }
    }
}
