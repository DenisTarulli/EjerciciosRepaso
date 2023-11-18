using System;
using TMPro;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI displayText;

    private string currentInput = "";
    private double result = 0.0;

    public void OnButtonClick(string buttonValue)
    {
        if (buttonValue == "=")
        {
            CalculateResult();
        }
        else if (buttonValue == "C")
        {
            ClearInput();
        }
        else
        {
            currentInput += buttonValue;
            UpdateDisplay();
        }
    }

    public void CalculateResult()
    {
        try
        {
            result = Convert.ToDouble(new System.Data.DataTable().Compute(currentInput, ""));
            currentInput = result.ToString();

            UpdateDisplay();
        }
        catch (Exception)
        {
            currentInput = "Error";
        }
    }

    public void ClearInput()
    {
        currentInput = "";
        result = 0.0;
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        displayText.text = currentInput;
    }
}
