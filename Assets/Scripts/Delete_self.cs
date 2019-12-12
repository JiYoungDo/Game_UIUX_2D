using System.Collections;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class Delete_self : MonoBehaviour
{
    public float DestroyTime ;
    AudioSource audioSource;
    
    float timer;
    

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Start()
    {
        timer = 0.0f;
        Destroy(gameObject, DestroyTime);
        
    }
    private void Update()
    {
        timer += Time.deltaTime;

        if(5<=timer&& timer<=5.2)
        {
            audioSource.Play();
        }
        if (5.5<=timer&&timer<=5.7)
        {
            audioSource.Play();
        }
        if (6<=timer&&timer<=6.2)
        {
            audioSource.Play();
        }
        if (6.4 <= timer && timer <= 7.0)
        {
            audioSource.Play();
        }

        
    }
}
