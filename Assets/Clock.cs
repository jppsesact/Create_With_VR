using System.Security.Cryptography;
using UnityEngine;

public class Clock : MonoBehaviour

{
    public Transform ponteiroSegundos; // Referência para o transform do ponteiro dos segundos
    public Transform ponteiroMinutos; // Referência para o transform do ponteiro dos segundos
    public Transform ponteiroHoras; // Referência para o transform do ponteiro dos segundos

    void Update()
    {
        // Obtém o tempo atual do sistema
        System.DateTime agora = System.DateTime.Now;

        // Calcula o ângulo de rotação com base nos segundos atuais
        float segundos = agora.Second;
        float anguloSegundos = segundos * 6f; // 360 graus / 60 segundos = 6 graus por segundo

        float minutos = agora.Minute;
        float anguloMinutos = minutos * 6f; // 360 graus / 60 Minutos = 6 graus por minuto
        
        float horas = agora.Hour;
        float anguloHoras = horas * 30f; // 360 graus / 12 horas = 30 graus por hora

        // Aplica a rotação aos ponteiro 
        ponteiroSegundos.rotation = Quaternion.Euler(anguloSegundos, 0f, 0f);
        ponteiroMinutos.rotation = Quaternion.Euler(anguloMinutos, 0f, 0f);
        ponteiroHoras.rotation = Quaternion.Euler(anguloHoras, 0f, 0f);

    }
}
