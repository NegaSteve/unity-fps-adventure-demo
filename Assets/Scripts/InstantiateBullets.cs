using UnityEngine;
using System.Collections;

public class InstantiateBullets : MonoBehaviour
{

    public GameObject shot;
    
    public Transform shotSpawn;
 
    public int shotCount;
    public float spawnWait;
    public float waveWait;
    public float startWait;

    private AudioSource audioSource;

    void Start()
    {
        StartCoroutine(Fire());
        //InvokeRepeating("Fire", delay, fireRate);
    }

    private void Awake()
    {
        
    }

    IEnumerator Fire()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < shotCount; i++)
            {
                GameObject clone;
                clone = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                yield return new WaitForSeconds(spawnWait);
                Destroy(clone, 1.0f);
            }
           
            yield return new WaitForSeconds(waveWait);
        }
    }
        //audioSource.Play();
    
}