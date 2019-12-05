using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform cam;
    public Vector3 distance;
    void Update()
    {
        transform.position = cam.position + distance;
    }
}
