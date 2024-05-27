    using System.Collections;
    using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public GameObject[] players;
    private int currentPlayerIndex = 0;
    protected MaquinaDeEstados maquinaDeEstados;
    void Start()
    {
        StartTurn();
    }

    void StartTurn()
    {
        // Activate current player
        maquinaDeEstados = players[currentPlayerIndex].GetComponent<MaquinaDeEstados>();
        maquinaDeEstados.ActivarEstado(maquinaDeEstados.Jugar);

    }

    public void EndTurn()
    {
        // PASA A ESTADO DE ESPERA
        maquinaDeEstados.ActivarEstado(maquinaDeEstados.Esperar);

        // Move to next player
        currentPlayerIndex = (currentPlayerIndex + 1) % players.Length;

        // Start next turn
        StartTurn();
    }

    public void MoveTurn()
    {
        // PASA A ESTADO DE Moverse
        maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoMoverse);
    }
    public void AtackTurn()
    {
        // PASA A ESTADO DE Moverse
        maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoAtacar);
    }
}