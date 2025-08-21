using UnityEngine;

public class FlowerAnimation : MonoBehaviour
{
    void Start()
    {

    }

    void OnMouseDown()
    {
        GetComponent<Animator>().SetTrigger("selectedTrigger");
    }
    
    void PlaySound(UnityEngine.Object clip) {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = (AudioClip)clip;
        audioSource.Play();
    }


}
