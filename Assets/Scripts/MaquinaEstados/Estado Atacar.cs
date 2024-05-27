using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoAtacar : Estado
{
    private Character character;
    private Tile currentTile;
    private Interact interact;

    protected override void Awake()
    {
        base.Awake();
        //LOGICA AL INICIAR PRIMERA VEZ
        character = GetComponent<Character>();
        interact = Camera.main.GetComponent<Interact>();
    }

    void Update()
    {
        //LOGICA DE ESPERA


    }

    // Método llamado cuando el estado se activa.
    void OnEnable()
    {
        interact.currentTile = character.characterTile;
        character.isMoving = false;
        interact.InspectTile();
        //character.changeMovedata();
        //COSAS QUE HACER CCUANDO SE ACTIVE EL ESTADO
        //maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoAlerta); // Cambia al estado de alerta.
    }


}
