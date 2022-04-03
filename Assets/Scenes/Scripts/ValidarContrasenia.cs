using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
	string contraseniaCorrecta;
	public Text ingresoUsuario;
	string contraseniaUsuario;
	public GameObject cartelMsj;
	public Text textoMsj;


    // Start is called before the first frame update
    void Start()
    {
		contraseniaCorrecta = "12345";
		cartelMsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void validarContrasenia()
	{
		contraseniaUsuario = ingresoUsuario.text;
		if (contraseniaUsuario == contraseniaCorrecta)
		{
			Debug.Log("Bienvenido");
			cartelMsj.SetActive(true);
			textoMsj.text = "Bienvenido";
		}
		else
		{
			Debug.Log("Contraseña incorrecta");
			cartelMsj.SetActive(true);
			textoMsj.text = "Contraseña incorrecta";
		}
	}
}
