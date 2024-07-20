using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Ball;
    Vector3 offset;
    //float smoothSpeed = 0.01f;

    Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Ball.transform.position;
        lastPosition = Ball.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        /*transform.position = new Vector3(
            transform.position.x,
            Ball.transform.position.y + offset.y,
            transform.position.z
            );*/

        /*Vector3 ballPosition = Ball.transform.position;

        Vector3 CurrentPosition = new Vector3(transform.position.x, ballPosition.y + offset.y, transform.position.z);

        if (CurrentPosition.y < transform.position.y)
        {
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, CurrentPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }*/

        var pos = transform.position;
        pos.y = Ball.transform.position.y + offset.y;
        pos.y = Mathf.Min(pos.y, lastPosition.y);
        lastPosition = pos;
        transform.position = pos;

    }
}
