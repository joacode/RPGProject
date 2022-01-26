using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject playerObj;

    private Vector3 pos = new Vector3(0.0f, 3.23f, -5.54f);
    private float mouseInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // rotate camera by moving mouse
        mouseInput = Input.GetAxis("Mouse X");

        // el codigo de abajo no funciona, hay una respuesta en https://www.youtube.com/watch?v=qnjKoTmko3Q
        //transform.Rotate(0.0f, mouseInput, 0, 0f);



        // follow the player
        transform.position = playerObj.transform.position + pos;

    }
}
