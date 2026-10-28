
using UnityEngine;

public class MusicPauseTrigger : MonoBehaviour
{
    public AudioSource musicSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            musicSource.Pause();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            musicSource.UnPause();
        }
    }
}
