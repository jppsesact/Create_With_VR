using System.Security.Cryptography;
using UnityEngine;

public class Clock : MonoBehaviour

{
    // Vari�vel para armazenar a rota��o atual do ponteiro
    private float _rotacaoAtual;

    // Vari�vel para armazenar a hora atual
    private int _horaAtual;

    // Vari�vel para armazenar o tempo em segundos
    private float _tempoEmSegundos;

    // Vari�vel para armazenar a velocidade de rota��o do ponteiro
    private float _velocidadeRotacao = 360f / 12f; // 360 graus dividido por 12 horas

    public Transform horas;

    void Update()
    {
        // Obter a hora atual
        _horaAtual = System.DateTime.Now.Hour;

        // Calcular a rota��o desejada
        _rotacaoAtual = _horaAtual * _velocidadeRotacao;

        // Ajustar a rota��o para que o ponteiro comece na posi��o 12h
        _rotacaoAtual -= 90f;

        // Aplicar a rota��o ao objeto
        transform.rotation = Quaternion.Euler(0f, 0f, _rotacaoAtual);
    }
}
