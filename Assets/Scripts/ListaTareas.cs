using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ListaTareas : MonoBehaviour
{
    [SerializeField] private List<string> listaDeTareas = new List<string>();
    [SerializeField] private TextMeshProUGUI listText;
    private ReadInput readInput;

    private void Start()
    {
        readInput = GetComponent<ReadInput>();
    }

    public void ActualizarLista()
    {
        listText.text = "Tareas:";

        foreach (string tarea in listaDeTareas)
        {
            listText.text += $"\n- {tarea}";
        }        
    }

    public void BotonAgregar()
    {
        if (readInput.input != null && readInput.input != "")
        {
            listaDeTareas.Add(readInput.input); 
            ActualizarLista();
        }
    }

    public void BotonEliminar()
    {
        if (readInput.input != null && readInput.input != "")
        {
            listaDeTareas.Remove(readInput.input);
            ActualizarLista();
        }
    }

    public void VaciarLista()
    {
        listaDeTareas.Clear();
        ActualizarLista();
    }
}
