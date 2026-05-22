using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float speed = 2f;
    void Update()
    {
        transform.position += new Vector3(Mathf.Sin(Time.time) * speed * Time.deltaTime, 0, 0);
    }
}
