using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimationTest : MonoBehaviour
{
    private int m_ClipIdx = 0;

    [System.Serializable]
    public class ClipData
    {
        public AnimationClip Animation;
        public AudioClip Audio;
        public float AudioDelay = 0f;
        public bool AutoGoToNext;
    }

    public ClipData[] Clips;

    void Start()
    {

    }

    void OnMouseDown()
    {
        StartCoroutine(PlayClip());
    }
    
    IEnumerator PlayClip() {
        GetComponent<Collider>().enabled = false;
        ClipData clip;
        do {
            clip = Clips[m_ClipIdx];
            GetComponentInParent<Animation>().Play(clip.Animation.name);
            AudioSource audioSource = GetComponent<AudioSource>();
            if (audioSource != null) {
                audioSource.clip = clip.Audio;
                audioSource.PlayDelayed(clip.AudioDelay);
            }
            m_ClipIdx = (m_ClipIdx + 1 ) % Clips.Length;
            if (clip.AutoGoToNext) {
                yield return new WaitForSeconds(clip.Animation.length);
            }
        } while(clip.AutoGoToNext);
        GetComponent<Collider>().enabled = true;
    }




}