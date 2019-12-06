using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlaneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public float smooth = 0.3f;
    public float tiltAngle = 5.0F;
    void Update()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);

        if (Input.GetButtonDown("Jump") || Input.GetKeyDown("r"))
        { //If you press R
            SceneManager.LoadScene("SampleScene"); //Load scene called Game
        }
    }
}
