using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//agregar paso 1 importar el XR
using UnityEngine.XR;

public class Elcontrol : MonoBehaviour
{
	
	//variables a crear
	
	
	
	// variables parea selecionar la caracteristicas deseada
	
	
	public InputDeviceCharacteristics CarasteristicasDeseadas;
	// vatiable de control de dispositivo de entrada que tendra las caracteristicas deseada 
	private	InputDevice dispositivoDeEntrada;
	//variblae para el modelo de la mano 
	public GameObject ModeloDeLaMano;
	//variable para controlar la mano
	private GameObject MiMano;
	
	Animator animacion,ConstelacionAnimacion;
	public GameObject constelacionesHeredado;
	
	   
	string ultimaConste;
	bool triggerValue;
	bool inputValue;
	bool isPressed = false;
	
	ConstelacionesCodigo constelacion;
	
	
	// Start is called before the first frame update
	void Start()
	{
		if (SceneManager.GetActiveScene().name !="Bienvenido")
		{
			
		constelacionesHeredado = GameObject.Find("ModelosConstelaciones");
			constelacion=GameObject.FindGameObjectWithTag("Control").GetComponent<ConstelacionesCodigo>();
		
			for(int i = 0; i<constelacionesHeredado.transform.childCount; i++)
			{
				Debug.Log("nombre " + constelacionesHeredado.transform.GetChild(i).GetComponent<Animator>().name);
			}
		
		}
		// crear lista para los dispositivo de entrada
		List<InputDevice> dispositivoConectados = new List<InputDevice>();
		//busco el dispositivo(que esta conectado) que tenga la caracteristica que
		// deso y lo agrego a las lista
		InputDevices.GetDevicesWithCharacteristics(CarasteristicasDeseadas,dispositivoConectados);
		// si la lista tiene algun elemento....
		if (dispositivoConectados.Count>0)
		{
	    	
			dispositivoDeEntrada = dispositivoConectados[0];
			//instancio un modelo de mano en ese dispositivo
			MiMano = Instantiate(ModeloDeLaMano,transform);
	    	
		}
	    
		animacion = MiMano.GetComponent<Animator>();
		
		
	}

	// Update is called once per frame
	void Update()
	{
        
		if (dispositivoDeEntrada.TryGetFeatureValue(CommonUsages.grip, out float valorGrip))
		{
			animacion.SetFloat("posicion",valorGrip);
			
	    	
		}
		
		if (CarasteristicasDeseadas.ToString() =="Left" && SceneManager.GetActiveScene().name !="Bienvenido" )
		{
			
		
        
		////emision de rayo
		RaycastHit ChoqueDeRayos;
	    
		//Debug.DrawRay(MiMano.transform.position, MiMano.transform.TransformDirection(Vector3.forward)*100000,Color.green);
		if (Physics.Raycast(MiMano.transform.position, MiMano.transform.TransformDirection(Vector3.forward)*1000000,out ChoqueDeRayos));
	    
		{
			string Conste = ChoqueDeRayos.transform.name;
			
			
				
   

			if(ChoqueDeRayos.collider.isTrigger && (ChoqueDeRayos.transform.name.Equals("Osa Mayor") || ChoqueDeRayos.transform.name.Equals("Osa Menor") || ChoqueDeRayos.transform.name.Equals("Casiopea")||
				ChoqueDeRayos.transform.name.Equals("Cefeo") || ChoqueDeRayos.transform.name.Equals("Dragon") || ChoqueDeRayos.transform.name.Equals("Andromeda")||
				ChoqueDeRayos.transform.name.Equals("Acuario") || ChoqueDeRayos.transform.name.Equals("Capricornio") || ChoqueDeRayos.transform.name.Equals("Pegaso")||
				ChoqueDeRayos.transform.name.Equals("Piscis") || ChoqueDeRayos.transform.name.Equals("Orion") || ChoqueDeRayos.transform.name.Equals("Canis Mayor")||
				ChoqueDeRayos.transform.name.Equals("Geminis") || ChoqueDeRayos.transform.name.Equals("Perseo") || ChoqueDeRayos.transform.name.Equals("Tauro")||
				ChoqueDeRayos.transform.name.Equals("Boyero") || ChoqueDeRayos.transform.name.Equals("Cancer") || ChoqueDeRayos.transform.name.Equals("Leo")||
				ChoqueDeRayos.transform.name.Equals("Virgo") || ChoqueDeRayos.transform.name.Equals("Hydra") || ChoqueDeRayos.transform.name.Equals("Aguila")||
				ChoqueDeRayos.transform.name.Equals("Lira") || ChoqueDeRayos.transform.name.Equals("Ofiuco") || ChoqueDeRayos.transform.name.Equals("Scorpio")||
				ChoqueDeRayos.transform.name.Equals("Saguitario") || ChoqueDeRayos.transform.name.Equals("Hercules") || ChoqueDeRayos.transform.name.Equals("Cisne")
			
			
			
			))
			{
				
				if (dispositivoDeEntrada.TryGetFeatureValue(CommonUsages.triggerButton,out triggerValue)
				  && triggerValue)
				 {
    	
					constelacion.ActivaConstelacion(Conste);
	    	
    	
    	
				  Conste="";
				 }
				
				
				
				

				for(int i = 0; i<constelacionesHeredado.transform.childCount; i++)
				{
					string name = constelacionesHeredado.transform.GetChild(i).GetComponent<Animator>().name;
					
					if(ChoqueDeRayos.transform.name == name){
						Debug.Log("nombre " + constelacionesHeredado.transform.GetChild(i).GetComponent<Animator>().name);
						ConstelacionAnimacion= ChoqueDeRayos.transform.GetComponent<Animator>();
						ConstelacionAnimacion.SetBool("Encendido",true);
					}
				}
					
			}
			else {
				for(int i = 0; i<constelacionesHeredado.transform.childCount; i++)
				{
					constelacionesHeredado.transform.GetChild(i).GetComponent<Animator>().SetBool("Encendido",false);
					
				}
			}

	
			



	    
		}//fin raycast
	  
		}//Si es izquierda
	    
	    
	}// fin Update
}