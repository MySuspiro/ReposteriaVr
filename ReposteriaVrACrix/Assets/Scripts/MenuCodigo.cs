using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuCodigo : MonoBehaviour
{
	//InputActionAsset playerControls;
	//InputAction Menu;
	
	
	public Button IraInicio;
	
    // Start is called before the first frame update
    void Start()
	{
		
		IraInicio.onClick.AddListener(()=>Comenzar());
        
    }


	public void Comenzar()
	{
		SceneManager.LoadScene("Bienvenido");
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
