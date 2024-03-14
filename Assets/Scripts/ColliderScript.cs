using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public Animator animator;
    public AudioSource AudioSource;
    public AudioClip danceclip;
    public AudioClip idleclip;

    private Vector3 animObject;

    private void Start()
    {
        animObject = animator.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Table")
        {
            animator.Play("Dance1");
            AudioSource.clip = danceclip;
            AudioSource.Play();
        }


    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.name == "Table")
        {
            animator.Play("Empty");
            AudioSource.clip = idleclip;
            AudioSource.Play();
            animator.transform.position = animObject;
        }
    }
}