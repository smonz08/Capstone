using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Animator animator;
    public float speed = 1;
    public AudioSource PlayerAudioSource;

    // Update is called once per frame

    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * speed * Time.deltaTime; 
        
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        Vector3 vertical = new Vector3(0.0f, Input.GetAxis("Vertical"), 0.0f);
        transform.position = transform.position + vertical * speed * Time.deltaTime;
    
        if (vertical.y !=0 || horizontal.x !=0)
        {
            if (!PlayerAudioSource.isPlaying)
            {
                PlayerAudioSource.Play();
            }
            else
            {
                // Always stop the audio if the player is not inputting movement.
                PlayerAudioSource.Stop();
            }
        }
    
    }

}
