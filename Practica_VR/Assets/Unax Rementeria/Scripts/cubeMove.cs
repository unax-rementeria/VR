using System.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class cubeMove : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 direction;

    void Start()
    {
        float direction = Random.Range(-3.0f,3.0f);
        transform.LookAt(Camera.main.transform);
        transform.Rotate(0.0f,direction,0.0f);
        morir();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OllisionEnter(Collision collision)
    {
        Destroy(gameObject);       
    }

    IEnumerator morir()
    {
        yield return new WaitForSeconds(10);
        Debug.Log("destruido");
        Destroy(gameObject);
    }

}
