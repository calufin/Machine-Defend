using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Transform target;
    private Rigidbody rb;
    public float speed = 5f;
    public float rotateSpeed = 200f;
    
    public void seek(Transform Target)
    {
        target = Target;
    }


    private void Update()
    {
        if(target == null)
        {
            Destroy(this.gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime; 

        if(dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }

    void HitTarget()
    {
        Destroy(gameObject);
    }
}
