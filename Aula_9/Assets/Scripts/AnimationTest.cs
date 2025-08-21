using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    private int m_ClipIdx = 0;

    [System.Serializable]
    public class ClipData {
        public AnimationClip Animation;
        public AudioClip Audio;
        public float AudioDelay = 0f;
    }

    public ClipData[] Clips;

    void Start()
    {

    }
    
    void OnMouseDown () {
        print (name + " selecionado usando " +
        Clips[m_ClipIdx].Animation.name);
        GetComponentInParent<Animation>()
        .Play(Clips[m_ClipIdx].Animation.name);
        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource != null) {
            audioSource.clip = Clips[m_ClipIdx].Audio;
            audioSource.PlayDelayed(Clips[m_ClipIdx].AudioDelay);
        }
        if(++m_ClipIdx >= Clips.Length) m_ClipIdx = 0;
    }



}