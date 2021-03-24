using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float angle;
    public Vector3 dir;
    private Vector3 A;
    private Vector3 B;
    private Vector3 E;
private Vector3 R;


    // Start is called before the first frame update
    void Start()
    {
        A = transform.forward;
        
        
        var roa = transform.rotation;
        Debug.Log(transform.forward);
        //transform.Rotate(dir * angle, Space.World);
        transform.Rotate(Vector3.forward * angle + Vector3.up * angle);
        Debug.Log(transform.rotation);
        transform.rotation = roa;
        transform.Rotate(Vector3.forward * angle + Vector3.up * angle, Space.World);
        Debug.Log(transform.rotation);


        //B = transform.forward;
        //Debug.Log(A + "  " + B);
        //Quaternion ret1 = Quaternion.FromToRotation(A, B);
        //Debug.Log(ret1);
        //Debug.Log(transform.rotation.eulerAngles);
        //Debug.Log(transform.localEulerAngles);
        //Quaternion ret = Quaternion.RotateTowards(Quaternion.Euler(A), Quaternion.Euler(B), angle);
        //Debug.Log(ret);
        //GameObject gameObject = GameObject.Instantiate(new GameObject());
        //Debug.Log(gameObject.transform.forward);
        //gameObject.transform.rotation = ret1;
        //Debug.Log(gameObject.transform.forward);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
