using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public Vector3 position1 = new Vector3(0,0,0);
    public Vector3 position2 = new Vector3(2,2,2);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, position2, 23 * Time.deltaTime);

        if (transform.position.y == 8){
            transform.position = position1;
            transform.position = Vector3.MoveTowards(transform.position, position2, 23 * Time.deltaTime);
        }
    }
}
