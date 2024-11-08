using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class dialogocambioescena : MonoBehaviour
{
    [SerializeField] private GameObject Exclamacion;   //signo de exclamacion//

    [SerializeField, TextArea(4, 6)] private string[] lineasdialogo;     //variable para guardar los dialogos uwu // //Text area es para agrandar los espacios donde escribir//

    [SerializeField] private GameObject paneldialogo; // la referencia para llamara al panel// 

    [SerializeField] private TMP_Text dialogotext;  //la referencia al texto//



    private float typingTime = 0.05f;   // variable del tiempo de las letritas// el tiempo de desplazamiento del texto, la "f" son segundos jaja

    private bool isPlayerInRange; //si el jugador entra en el area//
    private bool didDialogueStart;  //variable boolianda con un nombre "X"
    private int lineIndex; // variable entera xd  el cual indica que dialogo muestra//


    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange && Input.GetButtonDown("Fire1"))   //fire1 es click izquierdo//


            if (!didDialogueStart) // condicion adicional para que este dialogo aun no haya iniciado//

            {
                StartDialogue();  // es una funcion//
            }

            else if (dialogotext.text == lineasdialogo[lineIndex])
            {
                NextDialogueLine();
            }

    }

    private void StartDialogue()
    {
        didDialogueStart = true; // se inicio la conversacion//
        paneldialogo.SetActive(true); //activamos el panel jeje //
        Exclamacion.SetActive(false);   // desactivar la exclamacion//
        lineIndex = 0;
        StartCoroutine(ShowLine());   //escribelo xD, es para llamar la corrutina del dialogo//
    }


    public void NextDialogueLine()     // variable para cambiar de dialogo//
    {
        lineIndex++;
        if (lineIndex < lineasdialogo.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {
            didDialogueStart = false;
            paneldialogo.SetActive(false);
            Exclamacion.SetActive(true);
            StopAllCoroutines();
            SceneManager.LoadScene(8);
        }

    }
    private IEnumerator ShowLine()
    {
        dialogotext.text = string.Empty;   //todo esto es para que el dialogo tenga una animacion de recorrido como en Among Us//

        foreach (char ch in lineasdialogo[lineIndex])
        {
            dialogotext.text += ch;
            yield return new WaitForSeconds(0.05f); // aqui se acorto la variable y se uso "typingTime" // 
        }
    }






    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == ("Player"))    //soul//

        {
            isPlayerInRange = true;
            Exclamacion.SetActive(true);    //Activar signo de exclamacion//
            Debug.Log("Funciona");           //mensaje para saber si sirve//
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == ("Player"))    //soul//
        {
            isPlayerInRange = false;
            Exclamacion.SetActive(false);  //desactivar signo//
            Debug.Log("Yanogenera");      //mensaje para saber si sirven//
        }
    }

}