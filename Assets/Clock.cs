using System.Security.Cryptography;
using UnityEngine;

public class Clock : MonoBehaviour

{
    // Variável para armazenar a rotação atual do ponteiro
    private float _rotacaoAtual;

    // Variável para armazenar a hora atual
    private int _horaAtual;

    // Variável para armazenar o tempo em segundos
    private float _tempoEmSegundos;

    // Variável para armazenar a velocidade de rotação do ponteiro
    private float _velocidadeRotacao = 360f / 12f; // 360 graus dividido por 12 horas

    public Transform horas;

    void Update()
    {
        // Obter a hora atual
        _horaAtual = System.DateTime.Now.Hour;

        // Calcular a rotação desejada
        _rotacaoAtual = _horaAtual * _velocidadeRotacao;

        // Ajustar a rotação para que o ponteiro comece na posição 12h
        _rotacaoAtual -= 90f;

        // Aplicar a rotação ao objeto
        transform.rotation = Quaternion.Euler(0f, 0f, _rotacaoAtual);
    }
}
