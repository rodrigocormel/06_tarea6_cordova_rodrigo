using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulares : MonoBehaviour
{
    public int Temperatura;
    public int Volumen;

    public MyProgm myProgm;

    public OllaArrocera ollaArrocera;
    public Batidora batidora;
    public Exprimidor exprimidor;
    public Extractor extractor;
    public Licuadora licuadora;

    public void Arrocera()
    {
        ollaArrocera.Llama();
    }

    public void Batidor()
    {
        batidora.Llama();
    }
    public void Exprimir()
    {
        exprimidor.Llama();
    }
    public void Extraer()
    {
        extractor.Llama();
    }
    public void Licuar()
    {
        licuadora.Llama();
    }
}
