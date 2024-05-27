using UnityEngine;
using System.Collections;

public class MaquinaDeEstados : MonoBehaviour {

    // Estados disponibles
    public Estado EstadoPatrulla;
    public Estado EstadoAlerta;
    public Estado EstadoPersecucion;
    public Estado EstadoInicial;

    // Renderer para indicar visualmente el estado actual
    public MeshRenderer MeshRendererIndicador;

    private Estado estadoActual; // Estado actual en la máquina de estados

    void Start () {
        ActivarEstado(EstadoInicial); // Al inicio, activa el estado inicial
	}

    // Método para activar un nuevo estado
    public void ActivarEstado(Estado nuevoEstado)
    {
        // Desactiva el estado actual si existe uno
        if(estadoActual != null) 
            estadoActual.enabled = false;

        // Asigna el nuevo estado como estado actual
        estadoActual = nuevoEstado;
        estadoActual.enabled = true; // Activa el nuevo estado

        // Cambia el color del indicador visual al color asociado al estado actual
        MeshRendererIndicador.material.color = estadoActual.ColorEstado;
    }
}
