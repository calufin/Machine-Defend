using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private GameObject enemy;

    public Transform target;
    public Transform part;

    public GameObject pos;
    public GameObject bull;

    private string enemyTag = "Enemy";

    private bool flag = false;

    public float fireRate = 3f;
    public float fireCountdown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        enemy = GameObject.FindGameObjectWithTag(enemyTag);

        target = enemy.transform;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            this.flag = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            this.flag = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true)
        {
            
            Vector3 dir = target.position - transform.position;
            Quaternion lookR = Quaternion.LookRotation(dir);
            Vector3 rotation = lookR.eulerAngles;
            part.rotation = Quaternion.Euler(0f, rotation.y, 0f);

            if (fireCountdown <= 0)
            {
                Shoot();
                fireCountdown = 1f / fireRate;
            }

            fireCountdown -= Time.deltaTime;
        }

    }

    void Shoot()
    {
       GameObject BullGO = (GameObject)Instantiate(bull, pos.transform.position, Quaternion.Euler(0, 0, 180));
        Bullet bullet = BullGO.GetComponent<Bullet>();

        if(bullet != null)
        {
            bullet.seek(target);
        }
    }
}
