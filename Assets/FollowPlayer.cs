using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform playerTransform;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerTransform.position);
        transform.position = playerTransform.position + offset;

    }
}
