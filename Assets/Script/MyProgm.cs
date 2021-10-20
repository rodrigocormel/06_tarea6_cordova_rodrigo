using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyProgm : MonoBehaviour
{
    public Rectangulo rectangulo;
    public Circulares circulares;
    
    void Start()
    {
       
        Debug.Log("Lista de Electrodomesticos presione el nuemero de su elección");

        int[] Orden = new int[8];
        string[] Electrodomesticos = new string[8];

        int[] OrdenIn = { 1, 2, 3, 4, 5, 6, 7, 8 ,9};
        string[] ElectrodomesticosIn = { "Microondas", "Refrigeradora", "Batidora", "Exprimidor", "Extractor", "Horno Electrico", "Cocina Electrica", "Olla Arrocera", "Licuadora" };

        Debug.Log(OrdenIn[0] + "-" + ElectrodomesticosIn[0]);
        Debug.Log(OrdenIn[1] + "-" + ElectrodomesticosIn[1]);
        Debug.Log(OrdenIn[2] + "-" + ElectrodomesticosIn[2]);
        Debug.Log(OrdenIn[3] + "-" + ElectrodomesticosIn[3]);
        Debug.Log(OrdenIn[4] + "-" + ElectrodomesticosIn[4]);
        Debug.Log(OrdenIn[5] + "-" + ElectrodomesticosIn[5]);
        Debug.Log(OrdenIn[6] + "-" + ElectrodomesticosIn[6]);
        Debug.Log(OrdenIn[7] + "-" + ElectrodomesticosIn[7]);
        Debug.Log(OrdenIn[8] + "-" + ElectrodomesticosIn[8]);

    }
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            rectangulo.Micro();
        }
        if (Input.GetKeyDown ("2"))
        {
            rectangulo.Refri();
        }               
        if (Input.GetKeyDown("3"))
        {
            circulares.Batidor();
        }
        if (Input.GetKeyDown("4"))
        {
            circulares.Exprimir();
        }
        if (Input.GetKeyDown("5"))
        {
            circulares.Extraer();
        }
        if (Input.GetKeyDown("6"))
        {
            rectangulo.Horno();
        }
        if (Input.GetKeyDown("7"))
        {
            rectangulo.Cocina();
        }
        if (Input.GetKeyDown("8"))
        {
            circulares.Arrocera();
        }
        if (Input.GetKeyDown("9"))
        {
            circulares.Licuar();
        }
       

    }
}
