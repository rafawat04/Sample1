using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleWall : MonoBehaviour
{

    private float startY;

    public float amplitude;
    public float frequency;

    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position.y;
        StartCoroutine(MoveObject());
    }

    IEnumerator MoveObject()
    {
        while (true)
        {
            // Wait for 3 seconds
            yield return new WaitForSeconds(3f);

            // Move the object up
            float t = 0f;
            Vector3 startPosition = transform.position;
            Vector3 endPosition = new Vector3(startPosition.x, startY + amplitude, startPosition.z);
            while (t < 1f)
            {
                t += Time.deltaTime;
                transform.position = Vector3.Lerp(startPosition, endPosition, t);
                yield return null;
            }

            // Wait for 3 seconds
            yield return new WaitForSeconds(3f);

            // Move the object down
            t = 0f;
            startPosition = transform.position;
            endPosition = new Vector3(startPosition.x, startY, startPosition.z);
            while (t < 1f)
            {
                t += Time.deltaTime;
                transform.position = Vector3.Lerp(startPosition, endPosition, t);
                yield return null;
            }
        }
    }
}
