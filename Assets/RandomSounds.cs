using System.Collections;
using UnityEngine;

public class RandomSounds : MonoBehaviour
{

    // Array de audios para os sons das aves
    public AudioClip[] soundClips;

    // AudioSource para reproduzir os sons
    private AudioSource audioSource;
// Tempo mínimo e máximo entre sons (em segundos)
    public float minTimeBetweenSounds = 10f;
    public float maxTimeBetweenSounds = 20f;

 
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>(); // Adiciona um AudioSource ao GameObject
        StartCoroutine(PlayRandomSounds()); // Inicia a corrotina para tocar sons aleatórios
    }

    private IEnumerator PlayRandomSounds()
    {
        while (true) // Loop infinito
        {
            // Escolhe um som aleatório da lista
            AudioClip randomClip = soundClips[Random.Range(0, soundClips.Length)];
            audioSource.clip = randomClip; // Define o clipe de áudio
            audioSource.Play(); // Reproduz o som

            // Espera um tempo aleatório entre 5 e 15 segundos
            float waitTime = Random.Range(minTimeBetweenSounds, maxTimeBetweenSounds);
            Debug.Log("waitTime: "+ waitTime);
            yield return new WaitForSeconds(waitTime); // Pausa a corrotina
        }
    }
}
