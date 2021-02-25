using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    private bool canSpawn = true;

    public GameObject enemy;
    public Transform pos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Spawn()
    {
        while (canSpawn == true)
        {
            Instantiate(enemy, pos);
            yield return new WaitForSeconds(5);
        }

    }
}
