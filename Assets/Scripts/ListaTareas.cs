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
            AgregarTarea(readInput.input);
            ActualizarLista();
        }
    }

    public void BotonEliminar()
    {
        if (readInput.input != null && readInput.input != "")
        {
            EliminarTarea(readInput.input);
            ActualizarLista();
        }
    }

    private void AgregarTarea(string tarea)
    {
        listaDeTareas.Add(tarea);
    }

    private void EliminarTarea(string tarea)
    {
        listaDeTareas.Remove(tarea);
    }
}
