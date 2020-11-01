using System.Collections.Specialized;
using UnityEngine;

public class FollowBoy : MonoBehaviour
{

    public Transform player;  // gives player's position
    public Vector3 offset;  // Distance of the camera from the player

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;  // Camera follows the player
    }
}
