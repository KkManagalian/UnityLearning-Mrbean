using UnityEngine;

public class OmegaSounds : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioClip[] audioClips;
    public void PlaySFX(int ix)
    {
        sfxSource.PlayOneShot(audioClips[ix]);
    }
}
