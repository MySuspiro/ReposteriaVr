using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//agregar paso 1 importar el XR
using UnityEngine.XR;
using UnityEngine.UI;
using TMPro;



public class ConstelacionesCodigo : MonoBehaviour
{
    
	
    
	
	bool triggerValue;
	
	
	public GameObject Base_InfoConstelacion;
	public Image FotoConstelacion;
	public Sprite [] imagenConstelacion;
	public TMP_Text Titulo,MiniTitulo,Info;
	public Button cerrar;
	public Animator Animacion;
	
    
    
    void Start()
    {
	    //  control=GameObject.FindGameObjectWithTag("Control").GetComponent<Elcontrol>();
	    cerrar.onClick.AddListener(()=>cerrarVentana());
	    Animacion.SetBool("Cerrar",true);
	    
    }


	void cerrarVentana()
	{
		Animacion.SetBool("Cerrar",true);
	}

	public void  ActivaConstelacion(string Constelacion)
	{
		//Base_InfoConstelacion.SetActive(true);
		Animacion.SetBool("Cerrar",false);
		Infoconstelacion(Constelacion);
		
	}
	
	
	
	void Infoconstelacion(string Constelacion)
	{
		
		
		switch (Constelacion)
		{
			
			
		case "Osa Mayor":
			FotoConstelacion.sprite= imagenConstelacion[0];
			Titulo.text="Constelacion Osa Mayor";
			MiniTitulo.text="La Osa Mayor";
			Info.text="La Osa Mayor, también conocida como el Carro Mayor, es una constelación visible durante todo el año en el hemisferio norte. Entre los aficionados se le conoce con el "+
				"nombre de «el carro» o «el cazo», por la forma que dibujan sus siete estrellas principales, aunque ha recibido otros nombres.";	
			break;
			
		case "Osa Menor":
			FotoConstelacion.sprite= imagenConstelacion[1];
			Titulo.text="Constelacion Osa Menor";
			MiniTitulo.text="La Osa Menor";
			Info.text="La Osa Menor es una constelación del hemisferio norte. Comparte el mismo nombre que la Osa Mayor, debido a que su cola se asemeja al mango de una cuchara: consta de siete"+
				" estrellas con la forma de carro. El elemento más conocido de la Osa Menor es la estrella polar, llamada Polaris,1​ la cual se encuentra situada aproximadamente en la prolongación"+
				" del eje de la Tierra, de modo que permanece casi fija en el cielo y señala el polo norte geográfico";	
			break;
			
			
		case "Casiopea":
			FotoConstelacion.sprite= imagenConstelacion[2];
			Titulo.text="Constelacion Casiopea";
			MiniTitulo.text="Casiopea";
			Info.text="Casiopea es una de las constelaciones compiladas en el catálogo estelar de Ptolomeo, el Almagesto, del siglo II. Fácilmente reconocible por sus cinco estrellas brillantes"+
				" que forman un conocido asterismo del cielo circumpolar boreal. Casiopea señala al norte (y a la estrella polar) apuntando desde sus extremos de la «M» o «W». Tiene al otro lado"+
				" al Gran Carro de la Osa Mayor.";	
			break;
		
		
		case "Cefeo":
			FotoConstelacion.sprite= imagenConstelacion[3];
			Titulo.text="Constelacion Cefeo";
			MiniTitulo.text="Cefeo";
			Info.text="Cefeo es una constelación del norte que representa al legendario rey de Etiopía Cefeo, esposo de Casiopea y padre de Andrómeda. Es una de las 88 constelaciones modernas y una"+
				" de las 48 constelaciones nombradas por Ptolomeo. La estrella más brillante en la constelación es Alderamin (α Cephei),​ una subgigante blanca cuya luminosidad es veinte veces mayor"+
				" que la del Sol y que se encuentra a 48,8 años luz de distancia. ";	
			break;
		
		
		
		case "Dragon":
			FotoConstelacion.sprite= imagenConstelacion[4];
			Titulo.text="Constelacion Dragon";
			MiniTitulo.text="Dragon";
			Info.text="Draco (el dragón) es una constelación del norte lejano, que es circumpolar para muchos observadores del hemisferio norte. Es una de las 88 constelaciones modernas, y una de las"+
				" 48 constelaciones listadas por Ptolomeo. El polo norte de la eclíptica está en Draco. Aunque muy grande, Draco no tiene estrellas especialmente brillantes. La cabeza del dragón está"+
				" representada por un cuadrilátero de estrellas";	
			break;
			
			
		case "Andromeda":
			FotoConstelacion.sprite= imagenConstelacion[5];
			Titulo.text="Constelacion Andrómeda";
			MiniTitulo.text="Andrómeda";
			Info.text="Es una de las cuarenta y ocho constelaciones enumeradas por el astrónomo grecorromano del siglo II Claudio Ptolomeo, siendo en la actualidad una de las ochenta y ocho constelaciones"+
				" modernas. Situada al norte del ecuador celeste, lleva el nombre de Andrómeda, la hija de Cefeo y Casiopea, que fue encadenada a una roca para ser devorada por el monstruo marino Ceto. Es"+
				" más visible en las noches de otoño del hemisferio norte";	
			break;
			
			
		case "Acuario":
			FotoConstelacion.sprite= imagenConstelacion[6];
			Titulo.text="Constelacion Acuario";
			MiniTitulo.text="Acuario";
			Info.text="Acuario (el portador del agua o ánfora), es una de las 88 constelaciones reconocidas por la astronomía moderna, descrita por Claudio Ptolomeo. Su símbolo representa el flujo del "+
				"agua. De todo el zodiaco, Acuario es una de las constelaciones reconocida con mayor antigüedad. Los sumerios le dieron este nombre a la constelación, en honor a su dios An, que derrama el agua de la inmortalidad sobre la Tierra.";	
			break;
			
			
		case "Capricornio":
			FotoConstelacion.sprite= imagenConstelacion[7];
			Titulo.text="Constelacion Capricornio";
			MiniTitulo.text="Capricornio";
			Info.text="Capricornus (la cabra mitad pez) es una de las constelaciones del Zodíaco, llamada comúnmente Capricornio, sobre todo en lo referente a la astrología. Aunque a veces se representa"+
				" como una cabra, generalmente se le añade una cola de pez. El astro más brillante de la constelación es δ Capricorni, llamado Deneb Algedi, una estrella blanca distante 38,6 años luz. Es"+
				" una binaria espectroscópica y una variable eclipsante con un período orbital de sólo 24 horas y media.  ";	
			break;
			
			
		case "Pegaso":
			FotoConstelacion.sprite= imagenConstelacion[8];
			Titulo.text="Constelacion Pegaso";
			MiniTitulo.text="Pegaso";
			Info.text="Pegaso (el caballo alado) es una constelación del norte, que recibe su nombre del Pegaso mítico. Es una de las 88 constelaciones modernas y una de las 48 inicialmente descritas por"+
				" Ptolomeo. Johann Bayer catalogó 23 estrellas en la constelación, dándoles las denominaciones de Bayer desde alfa a psi. El astro más brillante de Pegaso es Enif (ε Pegasi),​ supergigante "+
				"anaranjada de tipo espectral K2Ib-II con una luminosidad 6700 veces mayor que la del Sol";	
			break;
			
			
		case "Piscis":
			FotoConstelacion.sprite= imagenConstelacion[9];
			Titulo.text="Constelacion Piscis";
			MiniTitulo.text="Piscis";
			Info.text="Los peces es una constelación del zodiaco ubicada entre Aquarius al oeste y Aries hacia el este. Con magnitud 3,62, su estrella más brillante es η Piscium, denominada oficialmente Alpherg."+
				" Es una gigante luminosa amarilla de tipo espectral G7IIa con una temperatura superficial de 4930 K.";	
			break;
			
			
		case "Orion":
			FotoConstelacion.sprite= imagenConstelacion[10];
			Titulo.text="Constelacion Orión ";
			MiniTitulo.text="Orión";
			Info.text="el Cazador, es una constelación prominente, quizás la más conocida del cielo. Sus estrellas brillantes y visibles desde ambos hemisferios hacen que esta constelación sea reconocida"+
				" mundialmente. La constelación es visible a lo largo de toda la noche durante el invierno en el hemisferio norte. Rigel (β Orionis), la estrella más brillante de la constelación, es en"+
				" realidad un sistema estelar cuádruple cuya componente principal es una supergigante blanco-azulada de tipo espectral B8Iae​ con una masa de 21 masas solares y una luminosidad bolométrica"+
				" 120 000 veces superior a la del Sol.";	
			break;
		
		
		case "Canis Mayor":
			FotoConstelacion.sprite= imagenConstelacion[11];
			Titulo.text="Constelacion Canis Mayor ";
			MiniTitulo.text="Canis Mayor";
			Info.text="El Can Mayor (Canis Maior) es una constelación que parece seguir, en su recorrido en el cielo debido al movimiento diurno, al «Gran Cazador», Orión. Sirio (α Canis Majoris) es la"+
				" estrella más brillante en el cielo nocturno y también una de las más próximas, ya que se encuentra 8,7 años luz; es una estrella binaria compuesta por Sirio A, la estrella visible a"+
				" simple vista, y Sirio B, una enana blanca.";	
			break;
		
		case "Geminis":
			FotoConstelacion.sprite= imagenConstelacion[12];
			Titulo.text="Constelacion Gemini  ";
			MiniTitulo.text="Gemini";
			Info.text="(los mellizos) es la tercera constelación del zodíaco, y se encuentra a unos treinta grados al noreste de Orión. William Herschel descubrió Urano cerca de η"+
				" Geminorum en 1781, y Clyde Tombaugh hizo lo propio con Plutón cerca de δ Geminorum. Pólux (β Geminorum) es la estrella más brillante de Gemini. Es una gigante naranja"+
				" —de tipo espectral K0IIIb—​ y es la estrella de estas características más próxima al sistema solar, pues está a una distancia de 33,7 años luz.";	
			break;
		
		case "Perseo":
			FotoConstelacion.sprite= imagenConstelacion[13];
			Titulo.text="Constelacion Perseo  ";
			MiniTitulo.text="Perseo";
			Info.text="Perseo es una constelación del norte y representa a Perseo, héroe mitológico que decapitó a Medusa. Es una de las 48 constelaciones de Ptolomeo así"+
				" como una de las 88 constelaciones modernas. En ella está la famosa variable Algol (β Persei), y en ella se localiza la lluvia de meteoros de las perseidas."+
				"Mirfak (α Persei),​ la estrella más brillante de Perseo, es una supergigante blanco-amarilla de tipo espectral F5Ib con una temperatura superficial de 6180 K; "+
				"brilla con una luminosidad equivalente a 5000 soles y tiene un masa entre 7 y 8 masas solares.";	
			break;
		
		
		case "Tauro":
			FotoConstelacion.sprite= imagenConstelacion[14];
			Titulo.text="Constelacion Tauro";
			MiniTitulo.text="Tauro";
			Info.text="Tauro o Taurus es una constelación zodiacal; su nombre en latín es Taurus y en español toro. Destaca en el cielo invernal, entre Aries al oeste y Géminis al este."+
				" Al norte se encuentran Perseo y Auriga; al sureste Orión, y al suroeste Eridanus y Cetus.Aldebarán (α Tauri), la estrella más brillante de la constelación, es una gigante"+
				" naranja —catalogada como K5+III—​ de primera magnitud. El nombre Aldebarán proviene del árabe الدبران, cuyo significado es «la que sigue», en referencia a que esta estrella "+
				"sigue al cúmulo de las Pléyades en su recorrido nocturno a través del cielo.";	
			break;
			
			
		case "Boyero":
			FotoConstelacion.sprite= imagenConstelacion[15];
			Titulo.text="Constelacion Bootes";
			MiniTitulo.text="Bootes";
			Info.text="Bootes o el Boyero es una de las 88 constelaciones modernas y era una de las 48 constelaciones listadas por Ptolomeo. Bootes parece ser una figura humana grande,"+
				" mirando hacia la Osa Mayor.Arturo (α Bootis) es la estrella más brillante de la constelación y la tercera más brillante del cielo nocturno. Es una gigante naranja de "+
				"tipo espectral K1.5III​ cuyo radio es 26 veces más grande que el radio solar.";	
			break;
		
		
		case "Cancer":
			FotoConstelacion.sprite= imagenConstelacion[16];
			Titulo.text="Constelacion Cáncer";
			MiniTitulo.text="Cáncer";
			Info.text="Cáncer (el cangrejo), en astronomía, es una de las doce constelaciones del zodíaco. En astrología, Cáncer constituye uno de los doce signos zodiacales."
				+"La constelación de Cáncer es pequeña y débil.Cáncer no tiene estrellas brillantes, si bien en una noche clara la constelación contiene cerca de 50 estrellas "+
				"visibles a simple vista. β Cancri, que recibe el nombre de Tarf,1 es su estrella más brillante, una gigante naranja de tipo K4III​ con un radio unas 50 veces más grande que el del Sol.";	
			break;
			
		
		case "Leo":
			FotoConstelacion.sprite= imagenConstelacion[17];
			Titulo.text="Constelacion Leo";
			MiniTitulo.text="Leo";
			Info.text="Leo (el león) es una de las constelaciones del zodíaco. Se encuentra entre Cáncer y Virgo.Quizá una de las constelaciones más conocidas, Leo contiene muchas "+
				"estrellas brillantes, destacando entre ellas α Leonis, llamada Régulo («pequeño rey» en latín); en la antigüedad recibió el título de «corazón del león», siendo conocida"+
				" en la antigua Grecia como Cor Leonis y en la astronomía árabe como Al Kalb al Asad.";	
			break;
			
			
		case "Virgo":
			FotoConstelacion.sprite= imagenConstelacion[18];
			Titulo.text="Constelacion Virgo";
			MiniTitulo.text="Virgo";
			Info.text="Virgo (la virgen) es una constelación del zodíaco. Se encuentra entre Leo al oeste y Libra al este y es una de las constelaciones más grandes visibles en el cielo.Espiga "+
				"(α Virginis), la estrella más brillante de Virgo, es un sistema binario cuyas componentes están separadas entre sí apenas 0,12 ua con un período orbital de 4,0145 días. La estrella"+
				" principal tiene tipo espectral B1 —clasificada como gigante o subgigante— y una masa 11 veces mayor que la masa solar, siendo una de las estrellas más cercanas a nosotros";	
			break;
			
		
		case "Hydra":
			FotoConstelacion.sprite= imagenConstelacion[19];
			Titulo.text="Constelacion Hidra ";
			MiniTitulo.text="Hidra ";
			Info.text="Hidra es la más extensa de las 88 constelaciones modernas, y fue una de las 48 constelaciones registradas en el siglo II por el astrónomo Ptolomeo. Comúnmente representada"+
				" como una serpiente acuática, la constelación se extiende a ambos lados del ecuador celeste. No debe ser confundida con Hydrus, constelación austral de menor tamaño. α Hydrae esta"+
				" es una gigante luminosa naranja de tipo espectral K3II-III con una luminosidad bolométrica 946 veces mayor que la del Sol y un radio 56 veces más grande que el radio solar.";	
			break;
		
		
		case "Aguila":
			FotoConstelacion.sprite= imagenConstelacion[20];
			Titulo.text="Constelacion Aguila ";
			MiniTitulo.text="Aguila ";
			Info.text="Aquila (el Águila) es una de las 48 constelaciones listadas por Ptolomeo, mencionada también por Eudoxo de Cnidos (siglo iv a. C.) y Arato (siglo iii a. C.), y"+
				" actualmente una de las 88 constelaciones reconocidas por la IAU. Altair (α Aquilae), el astro más brillante de la constelación, es una estrella blanca de tipo espectral"+
				" A7Vn​ situada a 16,8 años luz, cuya velocidad de rotación en el ecuador —aproximadamente 286 km/s—​ es 140 veces más alta que la del Sol.";	
			break;
		
			
		case "Lira":
			FotoConstelacion.sprite= imagenConstelacion[21];
			Titulo.text="Constelacion Lyra ";
			MiniTitulo.text="Lyra ";
			Info.text="La constelación de Lyra (la lira, en griego: Λύρα) no es grande pero es fácilmente identificable por su estrella Vega, que es uno de los vértices del denominado"+
				" ''Triángulo de verano''.Su estrella más importante es Vega, una brillante estrella azulada situada a unos 25 años luz de la Tierra de magnitud 0,03 que puede verse en"+
				" el cénit durante las noches de verano.";	
			break;
			
		case "Ofiuco":
			FotoConstelacion.sprite= imagenConstelacion[22];
			Titulo.text="Constelacion Ofiuco ";
			MiniTitulo.text="Ofiuco ";
			Info.text="Ofiuco u Ophiuchus (el portador de la serpiente o Serpentario), también conocido como ''El cazador de serpientes'', es una de las 88 constelaciones modernas y una de"+
				" las 48 listadas por Ptolomeo. Puede verse en ambos hemisferios entre los meses de abril a octubre por estar situada sobre el ecuador celeste.La estrella más brillante de la"+
				" constelación es α Ophiuchi, que recibe el nombre de Rasalhague o Ras Alhague, una subgigante blanca de tipo espectral A5IVnn,​ 25 veces más luminosa que el Sol";	
			break;	
			
			
		case "Scorpio":
			FotoConstelacion.sprite= imagenConstelacion[23];
			Titulo.text="Constelacion Escorpio  ";
			MiniTitulo.text="Escorpio  ";
			Info.text="Escorpio (el escorpión) es una de las 88 constelaciones modernas. Antiguamente esta constelación se representaba unida a la que hoy se conoce como Libra.La estrella principal"+
				" de la constelación es α Scorpii, conocida como Antares. Es una fría supergigante roja de tipo espectral M0.5Iab​ cuyo diámetro, medido por interferometría, es de 3,4 ua; si estuviese"+
				" en el centro del sistema solar, su superficie se extendería más allá de la órbita de Ceres.";	
			break;	
			
			
		case "Saguitario":
			FotoConstelacion.sprite= imagenConstelacion[24];
			Titulo.text="Constelacion Sagitario";
			MiniTitulo.text="Sagitario";
			Info.text="Sagittarius (el arquero) es una constelación del zodíaco, generalmente representada como un centauro sosteniendo un arco. Sagittarius se encuentra entre Scorpius al oeste y"+
				" Capricornus al este.El astro más brillante de Sagitario es Kaus Australis (ε Sagittarii), una gigante blanco-azulada de tipo espectral B9.5III​ y 9200 K de temperatura situada a "+
				"145 años luz en dirección al centro de la Vía Láctea.​ Forma un sistema binario con una estrella de la secuencia principal ligeramente menos masiva que el Sol.";	
			break;
			
	
		case "Hercules":
			FotoConstelacion.sprite= imagenConstelacion[25];
			Titulo.text="Constelacion Hercules";
			MiniTitulo.text="Hercules";
			Info.text="Recibe su nombre del héroe mitológico, Hércules, y es la quinta en tamaño de las 88 constelaciones modernas. También era una de las 48 constelaciones de Ptolomeo.Hércules"+
				" no tiene estrellas de primera magnitud, siendo la más brillante β Herculis (Kornephoros),​ una gigante amarilla de tipo espectral G7IIIa​ y magnitud 2,78, 175 veces más luminosa que el Sol.";	
			break;
		
		case "Cisne":
			FotoConstelacion.sprite= imagenConstelacion[26];
			Titulo.text="Constelacion Cisne";
			MiniTitulo.text="Cisne";
			Info.text="Cygnus (el cisne) es una constelación del hemisferio norte que atraviesa la Vía Láctea. La disposición de sus principales estrellas hace que a veces sea conocida como la Cruz"+
				" del Norte, en contraste con la constelación austral de la Cruz del Sur.Deneb (α Cygni), la estrella más brillante de la constelación, ocupa uno de los vértices del llamado Triángulo"+
				" de verano. Es una supergigante blanca de clase espectral A2Iae y una de las estrellas más luminosas de la Vía Láctea,";	
			break;	
			
		}// fin switch infoconstelacion
		
		
		
		
		
	}// fin Infoconstelacion
	
	
	
	
	
	
	
	
	
	
	
	

    // Update is called once per frame
    void Update()
	{
   
        
    }// fin update
}
