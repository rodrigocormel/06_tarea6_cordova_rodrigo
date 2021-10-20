using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo : MonoBehaviour
{
    public int Dimension;
    public int Volumen; 
    
    public MyProgm myProgm;
    
    public Microondas microondas;
    public Refigerador refigerador;
    public HornoElectrico hornoElectrico;
    public CocinaElectrica cocinaElectrica;
    
    public void Micro()
    {
        microondas.Llama();
    }
    public void Refri()
    {
        refigerador.Llama();
    }
    public void Horno()
    {
        hornoElectrico.Llama();
    }
    public void Cocina()
    {
        cocinaElectrica.Llama();
    }
}
