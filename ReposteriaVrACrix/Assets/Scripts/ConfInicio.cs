using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConfInicio : MonoBehaviour
{
	
	public Button BienvenidoBtn,AstroturismoBtn,BtnDominicus,BtnSamana,BtnValleNuevo,BtnDunas,TurismoEspacialBtn
		,BtnAtrasAstoT,BtnAtrasTurismoE;
	
	
	public Animator Animaciones;
	
	
    // Start is called before the first frame update
    void Start()
	{
    	
    	
		BienvenidoBtn.onClick.AddListener(()=>Transicion());
		AstroturismoBtn.onClick.AddListener(()=>Decidir(1));
		TurismoEspacialBtn.onClick.AddListener(()=>Decidir(2));
		BtnAtrasAstoT.onClick.AddListener(()=>Volver(1));
		BtnAtrasTurismoE.onClick.AddListener(()=>Volver(2));
		BtnDominicus.onClick.AddListener(()=>Lugares(4));
		BtnSamana.onClick.AddListener(()=>Lugares(3));
		BtnValleNuevo.onClick.AddListener(()=>Lugares(2));
		BtnDunas.onClick.AddListener(()=>Lugares(1));
	}
    
	void Decidir(int num)
	{
		Animaciones.SetInteger("Decidir",num);
		Animaciones.SetInteger("Volver",0);
		
	}

	void Volver (int num)
	{
		Animaciones.SetInteger("Decidir",0);
		Animaciones.SetInteger("Volver",num);
		
	}

	void Transicion()
	{
		Animaciones.SetBool("Ir",true);
		//SceneManager.LoadScene("Invierno");
	}


	void Lugares(int lugar)
	{
		
		switch (lugar)
		{
		
		case 1:
			SceneManager.LoadScene("Dunas de Bani");
			break;
			
		case 2:
			SceneManager.LoadScene("Valle nuevo");
			break;
			
		case 3:
			SceneManager.LoadScene("Samana");
			break;
			
		case 4:
			SceneManager.LoadScene("Bayahibe");
			break;	
		}
		
	}// fin lugares

    // Update is called once per frame
    void Update()
    {
        
    }
}
