using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class CompareContent : MonoBehaviour
{
    public static CompareContent Instance;
    public InputField input;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void CompareLines()
    {
        try
        {
            List<string> lines = new List<string>();

            // Leer el archivo l�nea por l�nea
            using (StreamReader sr = new StreamReader(input.text))
            {
                string line;
                int lineNumber = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    // Comparar la l�nea actual con las anteriores
                    for (int i = 0; i < lines.Count; i++)
                    {
                        if (line == lines[i])
                        {
                            Debug.Log($"{lineNumber}: {line}");
                            break;
                        }
                    }
                    // Agregar la l�nea a la lista
                    lines.Add(line);
                    lineNumber++;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ocurri� un error: {e.Message}");
        }
    }
}
