using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BienvenidoEmpezar : MonoBehaviour
{
	
	public GameObject XROrigen,CanvaInicio,CanvaInicio1,AstroturismoVentana,TurismoEspacialVentana;
	public Animator animaciones;
    // Start is called before the first frame update
    void Start()
    {
	    XROrigen.transform.position=new Vector3(9.357f,1.294f,-408.53f);
	    CanvaInicio.SetActive(true);
	    CanvaInicio1.SetActive(false);
	    AstroturismoVentana.SetActive(false);
	    TurismoEspacialVentana.SetActive(false);
	    animaciones.SetBool("Ir",true);
	    animaciones.SetInteger("Decidir",0);
	    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
