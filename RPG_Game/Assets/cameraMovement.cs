using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        Vector3 target = new Vector3(player.transform.position.x, player.transform.position.y + 3, player.transform.position.z - 12.5f);
        Vector3 move = target - this.transform.position;

        transform.Translate(move * player.GetComponent<playerMovement>().playerSpeed * Time.deltaTime, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3(player.transform.position.x, player.transform.position.y + 3, player.transform.position.z - 12.5f );
        Vector3 move = target - this.transform.position;

        transform.Translate(move * player.GetComponent<playerMovement>().playerSpeed* Time.deltaTime, Space.World);
    }
}
