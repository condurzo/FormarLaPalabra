using UnityEngine;
using System.Collections;

public class Modo3Ayuda : MonoBehaviour {
	public int Metodo;
	public int Level;
	public int tempMonedas;
	public int Monedas;
	public string AyudaL1;
	public string AyudaL2;
	public string AyudaL3;
	public string AyudaL4;
	public string AyudaL5;
	public string AyudaL6;
	public string AyudaL7;
	public string AyudaL8;
	public string AyudaL9;

	public int RandomTemp1;
	public int RandomTemp2;
	public int RandomTemp3;
	public int RandomTemp4;
	public int RandomTemp5;

	public bool AyudaBool1;
	public bool AyudaBool2;
	public bool AyudaBool3;
	public bool AyudaBool4;
	public bool AyudaBool5;

	public bool Guardar;

	public TextMesh Letra1;
	public TextMesh Letra2;
	public TextMesh Letra3;
	public TextMesh Letra4;
	public TextMesh Letra5;
	public TextMesh Letra6;
	public TextMesh Letra7;
	public TextMesh Letra8;
	public TextMesh Letra9;

	public GameObject Detec1;
	public GameObject Detec2;
	public GameObject Detec3;
	public GameObject Detec4;
	public GameObject Detec5;
	public GameObject Detec6;

	public GameObject TextoAyuda1;
	public GameObject TextoAyuda2;
	public GameObject TextoAyuda3;
	public GameObject TextoAyuda4;
	public GameObject TextoAyuda5;
	public GameObject TextoAyuda6;


	void ActivarAyuda1(){
		TextoAyuda1.SetActive (true);
	}
	void ActivarAyuda2(){
		TextoAyuda2.SetActive (true);
	}
	void ActivarAyuda3(){
		TextoAyuda3.SetActive (true);
	}
	void ActivarAyuda4(){
		TextoAyuda4.SetActive (true);
	}
	void ActivarAyuda5(){
		TextoAyuda5.SetActive (true);
	}
	void ActivarAyuda6(){
		TextoAyuda6.SetActive (true);
	}

	void CancelarTexto(){
		TextoAyuda1.SetActive (false);
		TextoAyuda2.SetActive (false);
		TextoAyuda3.SetActive (false);
		TextoAyuda4.SetActive (false);
		TextoAyuda5.SetActive (false);
		TextoAyuda6.SetActive (false);
	}

	void Start(){
		


		#region GuardarLetras
		Level = PlayerPrefs.GetInt("level3"); 
		switch (Level){
		#region Nivel1
		case 1 :
			if(PlayerPrefs.GetInt("M3-1-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-1-1");
				switch(RandomTemp1){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "B";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "E";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-1-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-1-2");
				switch(RandomTemp2){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "B";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "E";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-1-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-1-3");
				switch(RandomTemp3){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "B";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "E";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-1-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-1-4");
				switch(RandomTemp4){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "B";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "E";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-1-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-1-5");
				switch(RandomTemp5){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "B";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "E";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			break;
			#endregion Nivel1

			#region Nivel2
		case 2 :
			if(PlayerPrefs.GetInt("M3-2-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-2-1");
				switch(RandomTemp1){
				case 1:
					Letra1.text = "D";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "F";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "U";
					break;
				case 7:
					Letra7.text = "L";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-2-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-2-2");
				switch(RandomTemp2){
				case 1:
					Letra1.text = "D";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "F";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "U";
					break;
				case 7:
					Letra7.text = "L";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-2-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-2-3");
				switch(RandomTemp3){
				case 1:
					Letra1.text = "D";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "F";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "U";
					break;
				case 7:
					Letra7.text = "L";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-2-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-2-4");
				switch(RandomTemp4){
				case 1:
					Letra1.text = "D";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "F";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "U";
					break;
				case 7:
					Letra7.text = "L";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-2-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-2-5");
				switch(RandomTemp5){
				case 1:
					Letra1.text = "D";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "F";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "U";
					break;
				case 7:
					Letra7.text = "L";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			break;
			#endregion Nivel2

			#region Nivel3
		case 3:
			if(PlayerPrefs.GetInt("M3-3-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-3-1");
				switch(RandomTemp1){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "C";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "N";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-3-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-3-2");
				switch(RandomTemp2){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "C";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "N";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-3-G3")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-3-3");
				switch(RandomTemp3){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "C";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "N";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-3-G4")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-3-4");
				switch(RandomTemp4){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "C";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "N";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-3-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);;
				RandomTemp5 = PlayerPrefs.GetInt("M3-3-5");
				switch(RandomTemp5){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "C";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "N";
					break;
				}
			}
			break;
			#endregion Nivel3

			#region Nivel4
		case 4:
			if(PlayerPrefs.GetInt("M3-4-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-4-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "P";
					break;
				case 6:
					Letra6.text = "O";
					break;
				case 7:
					Letra7.text = "S";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}

			if(PlayerPrefs.GetInt("M3-4-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-4-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "P";
					break;
				case 6:
					Letra6.text = "O";
					break;
				case 7:
					Letra7.text = "S";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}

			if(PlayerPrefs.GetInt("M3-4-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-4-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "P";
					break;
				case 6:
					Letra6.text = "O";
					break;
				case 7:
					Letra7.text = "S";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-4-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-4-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "P";
					break;
				case 6:
					Letra6.text = "O";
					break;
				case 7:
					Letra7.text = "S";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}

			if(PlayerPrefs.GetInt("M3-4-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-4-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "P";
					break;
				case 6:
					Letra6.text = "O";
					break;
				case 7:
					Letra7.text = "S";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			break;
			#endregion Nivel4

			#region Nivel5
		case 5:
			if(PlayerPrefs.GetInt("M3-5-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-5-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "T";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-5-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-5-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "T";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-5-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-5-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "T";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-5-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-5-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "T";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-5-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-5-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "T";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			break;
			#endregion Nivel5

			#region Nivel6
		case 6:
			if(PlayerPrefs.GetInt("M3-6-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-6-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "E";
					break;
				case 2:
					Letra2.text = "M";
					break;
				case 3:
					Letra3.text = "B";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "J";
					break;
				case 8:
					Letra8.text = "E";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-6-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-6-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "E";
					break;
				case 2:
					Letra2.text = "M";
					break;
				case 3:
					Letra3.text = "B";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "J";
					break;
				case 8:
					Letra8.text = "E";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-6-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3= PlayerPrefs.GetInt("M3-6-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "E";
					break;
				case 2:
					Letra2.text = "M";
					break;
				case 3:
					Letra3.text = "B";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "J";
					break;
				case 8:
					Letra8.text = "E";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-6-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4= PlayerPrefs.GetInt("M3-6-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "E";
					break;
				case 2:
					Letra2.text = "M";
					break;
				case 3:
					Letra3.text = "B";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "J";
					break;
				case 8:
					Letra8.text = "E";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-6-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5= PlayerPrefs.GetInt("M3-6-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "E";
					break;
				case 2:
					Letra2.text = "M";
					break;
				case 3:
					Letra3.text = "B";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "J";
					break;
				case 8:
					Letra8.text = "E";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			break;
			#endregion Nivel6

			#region Nivel7
		case 7:
			if(PlayerPrefs.GetInt("M3-7-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-7-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "T";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-7-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-7-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "T";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-7-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-7-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "T";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-7-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-7-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "T";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-7-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-7-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "T";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			break;
			#endregion Nivel7

			#region Nivel8
		case 8:
			if(PlayerPrefs.GetInt("M3-8-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-8-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "R";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "G";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "O";
					break;
				case 8:
					Letra8.text = "S";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-8-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-8-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "R";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "G";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "O";
					break;
				case 8:
					Letra8.text = "S";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-8-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-8-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "R";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "G";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "O";
					break;
				case 8:
					Letra8.text = "S";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-8-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-8-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "R";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "G";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "O";
					break;
				case 8:
					Letra8.text = "S";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-8-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-8-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "R";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "G";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "O";
					break;
				case 8:
					Letra8.text = "S";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			break;
			#endregion Nivel8

			#region Nivel9
		case 9:
			if(PlayerPrefs.GetInt("M3-9-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-9-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "L";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "U";
					break;
				case 5:
					Letra5.text = "A";
					break;
				case 6:
					Letra6.text = "D";	
					break;
				case 7:
					Letra7.text = "O";
					break;
				case 8:
					Letra8.text = "R";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-9-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-9-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "L";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "U";
					break;
				case 5:
					Letra5.text = "A";
					break;
				case 6:
					Letra6.text = "D";	
					break;
				case 7:
					Letra7.text = "O";
					break;
				case 8:
					Letra8.text = "R";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-9-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-9-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "L";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "U";
					break;
				case 5:
					Letra5.text = "A";
					break;
				case 6:
					Letra6.text = "D";	
					break;
				case 7:
					Letra7.text = "O";
					break;
				case 8:
					Letra8.text = "R";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-9-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-9-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "L";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "U";
					break;
				case 5:
					Letra5.text = "A";
					break;
				case 6:
					Letra6.text = "D";	
					break;
				case 7:
					Letra7.text = "O";
					break;
				case 8:
					Letra8.text = "R";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-9-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-9-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "L";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "U";
					break;
				case 5:
					Letra5.text = "A";
					break;
				case 6:
					Letra6.text = "D";	
					break;
				case 7:
					Letra7.text = "O";
					break;
				case 8:
					Letra8.text = "R";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			break;
			#endregion Nivel9

			#region Nivel10
		case 10:
			if(PlayerPrefs.GetInt("M3-10-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-10-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "T";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "V";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "S";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "R";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-10-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-10-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "T";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "V";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "S";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "R";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-10-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-10-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "T";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "V";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "S";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "R";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-10-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-10-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "T";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "V";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "S";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "R";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-10-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-10-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "T";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "V";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "S";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "R";
					break;
				}
			}
			break;
			#endregion Nivel10

			#region Nivel11
		case 11:
			if(PlayerPrefs.GetInt("M3-11-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-11-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "R";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "T";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "J";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-11-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-11-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "R";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "T";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "J";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-11-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-11-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "R";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "T";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "J";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-11-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-11-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "R";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "T";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "J";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-11-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-11-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "R";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "T";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "J";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			break;

			#endregion Nivel11

			#region Nivel12
		case 12:
			if(PlayerPrefs.GetInt("M3-12-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-12-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "V";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "S";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "T";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-12-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-12-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "V";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "S";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "T";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-12-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-12-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "V";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "S";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "T";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-12-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-12-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "V";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "S";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "T";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-12-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-12-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "V";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "S";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "T";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			break;
			#endregion Nivel12

			#region Nivel13
		case 13:
			if(PlayerPrefs.GetInt("M3-13-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-13-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "G";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-13-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-13-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "G";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-13-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-13-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "G";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-13-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-13-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "G";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-13-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-13-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "G";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			break;
			#endregion Nivel13

			#region Nivel14
		case 14:
			if(PlayerPrefs.GetInt("M3-14-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-14-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "V";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "T";
					break;
				case 5:
					Letra5.text = "E";
					break;
				case 6:
					Letra6.text = "B";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-14-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-14-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "V";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "T";
					break;
				case 5:
					Letra5.text = "E";
					break;
				case 6:
					Letra6.text = "B";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-14-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-14-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "V";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "T";
					break;
				case 5:
					Letra5.text = "E";
					break;
				case 6:
					Letra6.text = "B";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-14-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-14-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "V";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "T";
					break;
				case 5:
					Letra5.text = "E";
					break;
				case 6:
					Letra6.text = "B";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-14-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-14-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "V";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "T";
					break;
				case 5:
					Letra5.text = "E";
					break;
				case 6:
					Letra6.text = "B";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			break;
			#endregion Nivel14

			#region Nivel15
		case 15:
			if(PlayerPrefs.GetInt("M3-15-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-15-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "R";
					break;
				case 5:
					Letra5.text = "O";
					break;
				case 6:
					Letra6.text = "B";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-15-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-15-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "R";
					break;
				case 5:
					Letra5.text = "O";
					break;
				case 6:
					Letra6.text = "B";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-15-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-15-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "R";
					break;
				case 5:
					Letra5.text = "O";
					break;
				case 6:
					Letra6.text = "B";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-15-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-15-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "R";
					break;
				case 5:
					Letra5.text = "O";
					break;
				case 6:
					Letra6.text = "B";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-15-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-15-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "R";
					break;
				case 5:
					Letra5.text = "O";
					break;
				case 6:
					Letra6.text = "B";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			break;
			#endregion Nivel15

			#region Nivel16
		case 16:
			if(PlayerPrefs.GetInt("M3-16-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-16-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "A";
					break;
				case 2:
					Letra2.text = "S";
					break;
				case 3:
					Letra3.text = "E";
					break;
				case 4:
					Letra4.text = "S";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "N";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-16-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-16-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "A";
					break;
				case 2:
					Letra2.text = "S";
					break;
				case 3:
					Letra3.text = "E";
					break;
				case 4:
					Letra4.text = "S";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "N";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-16-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-16-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "A";
					break;
				case 2:
					Letra2.text = "S";
					break;
				case 3:
					Letra3.text = "E";
					break;
				case 4:
					Letra4.text = "S";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "N";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-16-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-16-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "A";
					break;
				case 2:
					Letra2.text = "S";
					break;
				case 3:
					Letra3.text = "E";
					break;
				case 4:
					Letra4.text = "S";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "N";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-16-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-16-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "A";
					break;
				case 2:
					Letra2.text = "S";
					break;
				case 3:
					Letra3.text = "E";
					break;
				case 4:
					Letra4.text = "S";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "N";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			break;
			#endregion Nivel16

			#region Nivel17
		case 17:
			if(PlayerPrefs.GetInt("M3-17-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-17-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "M";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "B";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-17-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-17-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "M";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "B";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-17-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-17-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "M";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "B";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-17-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-17-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "M";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "B";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-17-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-17-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "M";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "B";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			break;
			#endregion Nivel17

			#region Nivel18
		case 18:
			if(PlayerPrefs.GetInt("M3-18-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-18-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "V";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "T";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "G";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-18-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-18-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "V";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "T";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "G";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-18-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-18-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "V";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "T";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "G";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-18-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-18-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "V";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "T";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "G";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-18-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-18-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "V";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "T";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "G";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			break;
			#endregion Nivel18

			#region Nivel19
		case 19:
			if(PlayerPrefs.GetInt("M3-19-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-19-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "J";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "D";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "N";
					break;
				case 7:
					Letra7.text = "E";
					break;
				case 8:
					Letra8.text = "R";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-19-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-19-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "J";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "D";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "N";
					break;
				case 7:
					Letra7.text = "E";
					break;
				case 8:
					Letra8.text = "R";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-19-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-19-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "J";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "D";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "N";
					break;
				case 7:
					Letra7.text = "E";
					break;
				case 8:
					Letra8.text = "R";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-19-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-19-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "J";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "D";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "N";
					break;
				case 7:
					Letra7.text = "E";
					break;
				case 8:
					Letra8.text = "R";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-19-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-19-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "J";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "D";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "N";
					break;
				case 7:
					Letra7.text = "E";
					break;
				case 8:
					Letra8.text = "R";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			break;
			#endregion Nivel19

			#region Nivel20
		case 20:
			if(PlayerPrefs.GetInt("M3-20-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-20-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "S";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "P";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-20-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-20-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "S";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "P";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-20-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-20-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "S";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "P";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-20-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-20-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "S";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "P";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-20-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-20-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "S";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "P";
					break;
				case 5:
					Letra5.text = "I";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "T";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			break;
			#endregion Nivel20

			#region Nivel21
		case 21:
			if(PlayerPrefs.GetInt("M3-21-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-21-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "U";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "H";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-21-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-21-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "U";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "H";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-21-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-21-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "U";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "H";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-21-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-21-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "U";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "H";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-21-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-21-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "U";
					break;
				case 3:
					Letra3.text = "C";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "C";
					break;
				case 8:
					Letra8.text = "H";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			break;
			#endregion Nivel21

			#region Nivel22
		case 22:
			if(PlayerPrefs.GetInt("M3-22-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-22-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "Q";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "I";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-22-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-22-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "Q";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "I";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-22-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-22-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "Q";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "I";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-22-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-22-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "Q";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "I";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-22-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-22-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "O";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "Q";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "R";
					break;
				case 8:
					Letra8.text = "I";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			break;
			#endregion Nivel22

			#region Nivel23
		case 23:
			if(PlayerPrefs.GetInt("M3-23-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-23-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "C";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-23-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-23-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "C";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-23-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-23-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "C";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-23-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-23-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "C";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-23-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-23-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "I";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "C";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			break;
			#endregion Nivel23

			#region Nivel24
		case 24:
			if(PlayerPrefs.GetInt("M3-24-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-24-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "D";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "L";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-24-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-24-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "D";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "L";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-24-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-24-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "D";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "L";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-24-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-24-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "D";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "L";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-24-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-24-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "D";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "N";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "L";
					break;
				}
			}
			break;
			#endregion Nivel24

			#region Nivel25
		case 25:
			if(PlayerPrefs.GetInt("M3-25-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-25-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "J";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "D";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "C";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-25-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-25-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "J";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "D";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "C";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-25-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-25-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "J";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "D";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "C";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-25-G1")==4){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-25-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "J";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "D";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "C";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-25-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-25-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "P";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "R";
					break;
				case 4:
					Letra4.text = "J";
					break;
				case 5:
					Letra5.text = "U";
					break;
				case 6:
					Letra6.text = "D";
					break;
				case 7:
					Letra7.text = "I";
					break;
				case 8:
					Letra8.text = "C";
					break;
				case 9:
					Letra9.text = "A";
					break;
				}
			}
			break;
			#endregion Nivel25

			#region Nivel26
		case 26:
			if(PlayerPrefs.GetInt("M3-26-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-26-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "O";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "N";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-26-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-26-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "O";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "N";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-26-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-26-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "O";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "N";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-26-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-26-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "O";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "N";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-26-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-26-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "M";
					break;
				case 2:
					Letra2.text = "E";
					break;
				case 3:
					Letra3.text = "L";
					break;
				case 4:
					Letra4.text = "O";
					break;
				case 5:
					Letra5.text = "C";
					break;
				case 6:
					Letra6.text = "O";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "N";
					break;
				}
			}
			break;
			#endregion Nivel26

			#region Nivel27
		case 27:
			if(PlayerPrefs.GetInt("M3-27-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-27-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "E";
					break;
				case 2:
					Letra2.text = "S";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "R";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "G";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-27-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-27-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "E";
					break;
				case 2:
					Letra2.text = "S";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "R";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "G";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-27-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-27-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "E";
					break;
				case 2:
					Letra2.text = "S";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "R";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "G";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-27-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-27-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "E";
					break;
				case 2:
					Letra2.text = "S";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "R";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "G";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-27-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-27-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "E";
					break;
				case 2:
					Letra2.text = "S";
					break;
				case 3:
					Letra3.text = "P";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "R";
					break;
				case 6:
					Letra6.text = "R";
					break;
				case 7:
					Letra7.text = "A";
					break;
				case 8:
					Letra8.text = "G";
					break;
				case 9:
					Letra9.text = "O";
					break;
				}
			}
			break;
			#endregion Nivel27

			#region Nivel28
		case 28:
			if(PlayerPrefs.GetInt("M3-28-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-28-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "F";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "B";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-28-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-28-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "F";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "B";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-28-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-28-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "F";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "B";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-28-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-28-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "F";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "B";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-28-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-28-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "I";
					break;
				case 2:
					Letra2.text = "N";
					break;
				case 3:
					Letra3.text = "F";
					break;
				case 4:
					Letra4.text = "A";
					break;
				case 5:
					Letra5.text = "L";
					break;
				case 6:
					Letra6.text = "I";
					break;
				case 7:
					Letra7.text = "B";
					break;
				case 8:
					Letra8.text = "L";
					break;
				case 9:
					Letra9.text = "E";
					break;
				}
			}
			break;
			#endregion Nivel28

			#region Nivel29
		case 29:
			if(PlayerPrefs.GetInt("M3-29-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-29-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "O";
					break;
				case 2:
					Letra2.text = "R";
					break;
				case 3:
					Letra3.text = "D";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "N";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "D";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "R";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-29-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-29-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "O";
					break;
				case 2:
					Letra2.text = "R";
					break;
				case 3:
					Letra3.text = "D";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "N";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "D";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "R";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-29-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-29-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "O";
					break;
				case 2:
					Letra2.text = "R";
					break;
				case 3:
					Letra3.text = "D";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "N";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "D";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "R";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-29-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-29-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "O";
					break;
				case 2:
					Letra2.text = "R";
					break;
				case 3:
					Letra3.text = "D";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "N";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "D";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "R";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-29-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-29-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "O";
					break;
				case 2:
					Letra2.text = "R";
					break;
				case 3:
					Letra3.text = "D";
					break;
				case 4:
					Letra4.text = "E";
					break;
				case 5:
					Letra5.text = "N";
					break;
				case 6:
					Letra6.text = "A";
					break;
				case 7:
					Letra7.text = "D";
					break;
				case 8:
					Letra8.text = "O";
					break;
				case 9:
					Letra9.text = "R";
					break;
				}
			}
			break;
			#endregion Nivel29

			#region Nivel30
		case 30:
			if(PlayerPrefs.GetInt("M3-30-G1")==1){
				Detec1.SetActive(false);
				Detec2.SetActive(true);
				RandomTemp1 = PlayerPrefs.GetInt("M3-30-1");

				switch(RandomTemp1){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "M";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-30-G2")==1){
				Detec2.SetActive(false);
				Detec3.SetActive(true);
				RandomTemp2 = PlayerPrefs.GetInt("M3-30-2");

				switch(RandomTemp2){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "M";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-30-G3")==1){
				Detec3.SetActive(false);
				Detec4.SetActive(true);
				RandomTemp3 = PlayerPrefs.GetInt("M3-30-3");

				switch(RandomTemp3){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "M";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-30-G4")==1){
				Detec4.SetActive(false);
				Detec5.SetActive(true);
				RandomTemp4 = PlayerPrefs.GetInt("M3-30-4");

				switch(RandomTemp4){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "M";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}
			if(PlayerPrefs.GetInt("M3-30-G5")==1){
				Detec5.SetActive(false);
				Detec6.SetActive(true);
				RandomTemp5 = PlayerPrefs.GetInt("M3-30-5");

				switch(RandomTemp5){
				case 1:
					Letra1.text = "C";
					break;
				case 2:
					Letra2.text = "A";
					break;
				case 3:
					Letra3.text = "M";
					break;
				case 4:
					Letra4.text = "I";
					break;
				case 5:
					Letra5.text = "S";
					break;
				case 6:
					Letra6.text = "E";
					break;
				case 7:
					Letra7.text = "T";
					break;
				case 8:
					Letra8.text = "A";
					break;
				case 9:
					Letra9.text = "S";
					break;
				}
			}

			break;
			#endregion Nivel30
		}

		#endregion GuardarLetras
	}

	void Update(){
		AyudaBool1 = true;

		#region RandomNumber

		if(AyudaBool1){
			RandomTemp1 = Random.Range(1,10);
			AyudaBool1 = false;
			AyudaBool2= true;
		}
		if(AyudaBool2){
			RandomTemp2 = Random.Range(1,10);
			if(RandomTemp1 == RandomTemp2){
				RandomTemp2 = Random.Range(1,10);
			}else{
				AyudaBool2= false;
				AyudaBool3 = true;
			}
		}
		if(AyudaBool3){
			RandomTemp3 = Random.Range(1,10);
			if(RandomTemp1 == RandomTemp3){
				RandomTemp3 = Random.Range(1,10);
			}else if(RandomTemp2 == RandomTemp3){
				RandomTemp3 = Random.Range(1,10);
			}else{
				AyudaBool3=false;
				AyudaBool4=true;
			}
		}
		if(AyudaBool4){
			RandomTemp4 = Random.Range(1,10);
			if(RandomTemp1 == RandomTemp4){
				RandomTemp4 = Random.Range(1,10);
			}else if(RandomTemp2 == RandomTemp4){
				RandomTemp4 = Random.Range(1,10);
			}else if(RandomTemp3 == RandomTemp4){
				RandomTemp4 = Random.Range(1,10);
			}else{
				AyudaBool4=false;
				AyudaBool5=true;
			}
		}
		if(AyudaBool5){
			RandomTemp5 = Random.Range(1,10);
			if(RandomTemp1 == RandomTemp5){
				RandomTemp5 = Random.Range(1,10);
			}else if(RandomTemp2 == RandomTemp5){
				RandomTemp5 = Random.Range(1,10);
			}else if(RandomTemp3 == RandomTemp5){
				RandomTemp5 = Random.Range(1,10);
			}else if(RandomTemp4 == RandomTemp5){
				RandomTemp5 = Random.Range(1,10);
			}else{
				AyudaBool5=false;
				Guardar = true;
			}
		}
		#endregion RandomNumber

		#region SetRandomNumber

		Level = PlayerPrefs.GetInt("level3");
		switch (Level){
		case 1 :
			Metodo = 1;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-1-0")==0){
					PlayerPrefs.SetInt("M3-1-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-1-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-1-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-1-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-1-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-1-0",1);
				}
			}
			break;
		case 2 :
			Metodo = 2;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-2-0")==0){
					PlayerPrefs.SetInt("M3-2-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-2-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-2-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-2-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-2-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-2-0",1);
				}
			}
			break;
		case 3 :
			Metodo = 3;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-3-0")==0){
					PlayerPrefs.SetInt("M3-3-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-3-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-3-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-3-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-3-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-3-0",1);
				}
			}
			break;
		case 4 :
			Metodo = 4;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-4-0")==0){
					PlayerPrefs.SetInt("M3-4-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-4-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-4-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-4-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-4-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-4-0",1);
				}
			}
			break;
		case 5 :
			Metodo = 5;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-5-0")==0){
					PlayerPrefs.SetInt("M3-5-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-5-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-5-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-5-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-5-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-5-0",1);
				}
			}
			break;
		case 6 :
			Metodo = 6;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-6-0")==0){
					PlayerPrefs.SetInt("M3-6-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-6-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-6-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-6-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-6-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-6-0",1);
				}
			}
			break;
		case 7 :
			Metodo = 7;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-7-0")==0){
					PlayerPrefs.SetInt("M3-7-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-7-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-7-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-7-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-7-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-7-0",1);
				}
			}
			break;
		case 8 :
			Metodo = 8;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-8-0")==0){
					PlayerPrefs.SetInt("M3-8-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-8-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-8-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-8-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-8-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-8-0",1);
				}
			}
			break;
		case 9 :
			Metodo = 9;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-9-0")==0){
					PlayerPrefs.SetInt("M3-9-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-9-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-9-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-9-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-9-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-9-0",1);
				}
			}
			break;
		case 10 :
			Metodo = 10;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-10-0")==0){
					PlayerPrefs.SetInt("M3-10-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-10-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-10-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-10-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-10-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-10-0",1);
				}
			}
			break;
		case 11 :
			Metodo = 11;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-11-0")==0){
					PlayerPrefs.SetInt("M3-11-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-11-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-11-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-11-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-11-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-11-0",1);
				}
			}
			break;
		case 12 :
			Metodo = 12;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-12-0")==0){
					PlayerPrefs.SetInt("M3-12-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-12-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-12-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-12-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-12-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-12-0",1);
				}
			}
			break;
		case 13 :
			Metodo = 13;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-13-0")==0){
					PlayerPrefs.SetInt("M3-13-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-13-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-13-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-13-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-13-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-13-0",1);
				}
			}
			break;
		case 14 :
			Metodo = 14;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-14-0")==0){
					PlayerPrefs.SetInt("M3-14-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-14-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-14-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-14-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-14-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-14-0",1);
				}
			}
			break;
		case 15 :
			Metodo = 15;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-15-0")==0){
					PlayerPrefs.SetInt("M3-15-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-15-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-15-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-15-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-15-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-15-0",1);
				}
			}
			break;
		case 16 :
			Metodo = 16;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-16-0")==0){
					PlayerPrefs.SetInt("M3-16-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-16-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-16-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-16-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-16-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-16-0",1);
				}
			}
			break;
		case 17 :
			Metodo = 17;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-17-0")==0){
					PlayerPrefs.SetInt("M3-17-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-17-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-17-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-17-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-17-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-17-0",1);
				}
			}
			break;
		case 18:
			Metodo = 18;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-18-0")==0){
					PlayerPrefs.SetInt("M3-18-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-18-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-18-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-18-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-18-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-18-0",1);
				}
			}
			break;
		case 19 :
			Metodo = 19;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-19-0")==0){
					PlayerPrefs.SetInt("M3-19-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-19-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-19-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-19-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-19-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-19-0",1);
				}
			}
			break;
		case 20 :
			Metodo = 20;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-20-0")==0){
					PlayerPrefs.SetInt("M3-20-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-20-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-20-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-20-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-20-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-20-0",1);
				}
			}
			break;
		case 21 :
			Metodo = 21;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-21-0")==0){
					PlayerPrefs.SetInt("M3-21-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-21-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-21-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-21-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-21-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-21-0",1);
				}
			}
			break;
		case 22 :
			Metodo = 22;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-22-0")==0){
					PlayerPrefs.SetInt("M3-22-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-22-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-22-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-22-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-22-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-22-0",1);
				}
			}
			break;
		case 23 :
			Metodo = 23;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-23-0")==0){
					PlayerPrefs.SetInt("M3-23-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-23-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-23-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-23-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-23-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-23-0",1);
				}
			}
			break;
		case 24 :
			Metodo = 24;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-24-0")==0){
					PlayerPrefs.SetInt("M3-24-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-24-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-24-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-24-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-24-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-24-0",1);
				}
			}
			break;
		case 25 :
			Metodo = 25;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-25-0")==0){
					PlayerPrefs.SetInt("M3-25-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-25-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-25-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-25-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-25-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-25-0",1);
				}
			}
			break;
		case 26 :
			Metodo = 26;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-26-0")==0){
					PlayerPrefs.SetInt("M3-26-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-26-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-26-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-26-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-26-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-26-0",1);
				}
			}
			break;
		case 27 :
			Metodo = 27;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-27-0")==0){
					PlayerPrefs.SetInt("M3-27-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-27-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-27-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-27-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-27-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-27-0",1);
				}
			}
			break;
		case 28 :
			Metodo = 28;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-28-0")==0){
					PlayerPrefs.SetInt("M3-28-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-28-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-28-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-28-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-28-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-28-0",1);
				}
			}
			break;
		case 29 :
			Metodo = 29;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-29-0")==0){
					PlayerPrefs.SetInt("M3-29-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-29-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-29-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-29-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-29-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-29-0",1);
				}
			}
			break;
		case 30 :
			Metodo = 30;
			if(Guardar){
				if(PlayerPrefs.GetInt("M3-30-0")==0){
					PlayerPrefs.SetInt("M3-30-1",RandomTemp1);
					PlayerPrefs.SetInt("M3-30-2",RandomTemp2);
					PlayerPrefs.SetInt("M3-30-3",RandomTemp3);
					PlayerPrefs.SetInt("M3-30-4",RandomTemp4);
					PlayerPrefs.SetInt("M3-30-5",RandomTemp5);
					PlayerPrefs.SetInt("M3-30-0",1);
				}
			}
			break;
		}
		#endregion SetRandomNumber
	}

	#region Metodo1
	/////////// METODO 1
	void Ayuda () {
		Monedas = PlayerPrefs.GetInt ("Monedas");
		if (Monedas >= 3) {
		if(Metodo==1){
			//Abogado
			RandomTemp1 = PlayerPrefs.GetInt("M3-1-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-1-G1",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-1-G1",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-1-G1",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-1-G1",1);
				break;
			case 5:
				Letra5.text = "B";
				PlayerPrefs.SetInt("M3-1-G1",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-1-G1",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-1-G1",1);
				break;
			case 8:
				Letra8.text = "E";
				PlayerPrefs.SetInt("M3-1-G1",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-1-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}
		if(Metodo==2){
			//Acarreo
			RandomTemp1 = PlayerPrefs.GetInt("M3-2-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "D";
				PlayerPrefs.SetInt("M3-2-G1",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-2-G1",1);
				break;
			case 3:
				Letra3.text = "F";
				PlayerPrefs.SetInt("M3-2-G1",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-2-G1",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-2-G1",1);
				break;
			case 6:
				Letra6.text = "U";
				PlayerPrefs.SetInt("M3-2-G1",1);
				break;
			case 7:
				Letra7.text = "L";
				PlayerPrefs.SetInt("M3-2-G1",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-2-G1",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-2-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}
		if(Metodo==3){
			//Billete
			RandomTemp1 = PlayerPrefs.GetInt("M3-3-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-3-G1",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-3-G1",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-3-G1",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-3-G1",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-3-G1",1);
				break;
			case 6:
				Letra6.text = "C";
				PlayerPrefs.SetInt("M3-3-G1",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-3-G1",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-3-G1",1);
				break;
			case 9:
				Letra9.text = "N";
				PlayerPrefs.SetInt("M3-3-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}
		if(Metodo==4){
			//Sensual
			RandomTemp1 = PlayerPrefs.GetInt("M3-4-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-4-G1",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-4-G1",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-4-G1",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-4-G1",1);
				break;
			case 5:
				Letra5.text = "P";
				PlayerPrefs.SetInt("M3-4-G1",1);
				break;
			case 6:
				Letra6.text = "O";
				PlayerPrefs.SetInt("M3-4-G1",1);
				break;
			case 7:
				Letra7.text = "S";
				PlayerPrefs.SetInt("M3-4-G1",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-4-G1",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-4-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==5){
			//Botella
			RandomTemp1 = PlayerPrefs.GetInt("M3-5-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-5-G1",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-5-G1",1);
				break;
			case 3:
				Letra3.text = "T";
				PlayerPrefs.SetInt("M3-5-G1",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-5-G1",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-5-G1",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-5-G1",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-5-G1",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-5-G1",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-5-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==6){
			//Cocinar
			RandomTemp1 = PlayerPrefs.GetInt("M3-6-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "E";
				PlayerPrefs.SetInt("M3-6-G1",1);
				break;
			case 2:
				Letra2.text = "M";
				PlayerPrefs.SetInt("M3-6-G1",1);
				break;
			case 3:
				Letra3.text = "B";
				PlayerPrefs.SetInt("M3-6-G1",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-6-G1",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-6-G1",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-6-G1",1);
				break;
			case 7:
				Letra7.text = "J";
				PlayerPrefs.SetInt("M3-6-G1",1);
				break;
			case 8:
				Letra8.text = "E";
				PlayerPrefs.SetInt("M3-6-G1",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-6-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==7){
			//Galopar
			RandomTemp1 = PlayerPrefs.GetInt("M3-7-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-7-G1",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-7-G1",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-7-G1",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-7-G1",1);
				break;
			case 5:
				Letra5.text = "T";
				PlayerPrefs.SetInt("M3-7-G1",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-7-G1",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-7-G1",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-7-G1",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-7-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}



		if(Metodo==8){
			//Llavero
			RandomTemp1 = PlayerPrefs.GetInt("M3-8-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "R";
				PlayerPrefs.SetInt("M3-8-G1",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-8-G1",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-8-G1",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-8-G1",1);
				break;
			case 5:
				Letra5.text = "G";
				PlayerPrefs.SetInt("M3-8-G1",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-8-G1",1);
				break;
			case 7:
				Letra7.text = "O";
				PlayerPrefs.SetInt("M3-8-G1",1);
				break;
			case 8:
				Letra8.text = "S";
				PlayerPrefs.SetInt("M3-8-G1",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-8-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==9){
			//Mensaje
			RandomTemp1 = PlayerPrefs.GetInt("M3-9-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "L";
				PlayerPrefs.SetInt("M3-9-G1",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-9-G1",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-9-G1",1);
				break;
			case 4:
				Letra4.text = "U";
				PlayerPrefs.SetInt("M3-9-G1",1);
				break;
			case 5:
				Letra5.text = "A";
				PlayerPrefs.SetInt("M3-9-G1",1);
				break;
			case 6:
				Letra6.text = "D";	
				PlayerPrefs.SetInt("M3-9-G1",1);
				break;
			case 7:
				Letra7.text = "O";
				PlayerPrefs.SetInt("M3-9-G1",1);
				break;
			case 8:
				Letra8.text = "R";
				PlayerPrefs.SetInt("M3-9-G1",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-9-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==10){
			//Premiar
			RandomTemp1 = PlayerPrefs.GetInt("M3-10-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "T";
				PlayerPrefs.SetInt("M3-10-G1",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-10-G1",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-10-G1",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-10-G1",1);
				break;
			case 5:
				Letra5.text = "V";
				PlayerPrefs.SetInt("M3-10-G1",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-10-G1",1);
				break;
			case 7:
				Letra7.text = "S";
				PlayerPrefs.SetInt("M3-10-G1",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-10-G1",1);
				break;
			case 9:
				Letra9.text = "R";
				PlayerPrefs.SetInt("M3-10-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==11){
			//Cristal
			RandomTemp1 = PlayerPrefs.GetInt("M3-11-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "R";
				PlayerPrefs.SetInt("M3-11-G1",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-11-G1",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-11-G1",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-11-G1",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-11-G1",1);
				break;
			case 6:
				Letra6.text = "T";
				PlayerPrefs.SetInt("M3-11-G1",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-11-G1",1);
				break;
			case 8:
				Letra8.text = "J";
				PlayerPrefs.SetInt("M3-11-G1",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-11-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==12){
			//Iguales
			RandomTemp1 = PlayerPrefs.GetInt("M3-12-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "V";
				PlayerPrefs.SetInt("M3-12-G1",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-12-G1",1);
				break;
			case 3:
				Letra3.text = "S";
				PlayerPrefs.SetInt("M3-12-G1",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-12-G1",1);
				break;
			case 5:
				Letra5.text = "T";
				PlayerPrefs.SetInt("M3-12-G1",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-12-G1",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-12-G1",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-12-G1",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-12-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==13){
			//Cuentos
			RandomTemp1 = PlayerPrefs.GetInt("M3-13-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-13-G1",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-13-G1",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-13-G1",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-13-G1",1);
				break;
			case 5:
				Letra5.text = "G";
				PlayerPrefs.SetInt("M3-13-G1",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-13-G1",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-13-G1",1);
				break;
			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-13-G1",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-13-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==14){
			//Galeria
			RandomTemp1 = PlayerPrefs.GetInt("M3-14-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "V";
				PlayerPrefs.SetInt("M3-14-G1",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-14-G1",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-14-G1",1);
				break;
			case 4:
				Letra4.text = "T";
				PlayerPrefs.SetInt("M3-14-G1",1);
				break;
			case 5:
				Letra5.text = "E";
				PlayerPrefs.SetInt("M3-14-G1",1);
				break;
			case 6:
				Letra6.text = "B";
				PlayerPrefs.SetInt("M3-14-G1",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-14-G1",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-14-G1",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-14-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==15){
			//Pelotas
			RandomTemp1 = PlayerPrefs.GetInt("M3-15-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-15-G1",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-15-G1",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-15-G1",1);
				break;
			case 4:
				Letra4.text = "R";
				PlayerPrefs.SetInt("M3-15-G1",1);
				break;
			case 5:
				Letra5.text = "O";
				PlayerPrefs.SetInt("M3-15-G1",1);
				break;
			case 6:
				Letra6.text = "B";
				PlayerPrefs.SetInt("M3-15-G1",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-15-G1",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-15-G1",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-15-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==16){
			//Batata
			RandomTemp1 = PlayerPrefs.GetInt("M3-16-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "A";
				PlayerPrefs.SetInt("M3-16-G1",1);
				break;
			case 2:
				Letra2.text = "S";
				PlayerPrefs.SetInt("M3-16-G1",1);
				break;
			case 3:
				Letra3.text = "E";
				PlayerPrefs.SetInt("M3-16-G1",1);
				break;
			case 4:
				Letra4.text = "S";
				PlayerPrefs.SetInt("M3-16-G1",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-16-G1",1);
				break;
			case 6:
				Letra6.text = "N";
				PlayerPrefs.SetInt("M3-16-G1",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-16-G1",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-16-G1",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-16-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==17){
			//Offside
			RandomTemp1 = PlayerPrefs.GetInt("M3-17-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-17-G1",1);
				break;
			case 2:
				Letra2.text = "M";
				PlayerPrefs.SetInt("M3-17-G1",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-17-G1",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-17-G1",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-17-G1",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-17-G1",1);
				break;
			case 7:
				Letra7.text = "B";
				PlayerPrefs.SetInt("M3-17-G1",1);
				break;

			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-17-G1",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-17-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==18){
			//Hornerar
			RandomTemp1 = PlayerPrefs.GetInt("M3-18-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-18-G1",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-18-G1",1);
				break;
			case 3:
				Letra3.text = "V";
				PlayerPrefs.SetInt("M3-18-G1",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-18-G1",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-18-G1",1);
				break;
			case 6:
				Letra6.text = "T";
				PlayerPrefs.SetInt("M3-18-G1",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-18-G1",1);
				break;
			case 8:
				Letra8.text = "G";
				PlayerPrefs.SetInt("M3-18-G1",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-18-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==19){
			//Ajustar
			RandomTemp1 = PlayerPrefs.GetInt("M3-19-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "J";
				PlayerPrefs.SetInt("M3-19-G1",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-19-G1",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-19-G1",1);
				break;
			case 4:
				Letra4.text = "D";
				PlayerPrefs.SetInt("M3-19-G1",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-19-G1",1);
				break;
			case 6:
				Letra6.text = "N";
				PlayerPrefs.SetInt("M3-19-G1",1);
				break;
			case 7:
				Letra7.text = "E";
				PlayerPrefs.SetInt("M3-19-G1",1);
				break;
			case 8:
				Letra8.text = "R";
				PlayerPrefs.SetInt("M3-19-G1",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-19-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==20){
			//Ganador
			RandomTemp1 = PlayerPrefs.GetInt("M3-20-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "S";
				PlayerPrefs.SetInt("M3-20-G1",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-20-G1",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-20-G1",1);
				break;
			case 4:
				Letra4.text = "P";
				PlayerPrefs.SetInt("M3-20-G1",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-20-G1",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-20-G1",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-20-G1",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-20-G1",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-20-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==21){
			//Esperar
			RandomTemp1 = PlayerPrefs.GetInt("M3-21-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-21-G1",1);
				break;
			case 2:
				Letra2.text = "U";
				PlayerPrefs.SetInt("M3-21-G1",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-21-G1",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-21-G1",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-21-G1",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-21-G1",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-21-G1",1);
				break;
			case 8:
				Letra8.text = "H";
				PlayerPrefs.SetInt("M3-21-G1",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-21-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==22){
			//Archivo
			RandomTemp1 = PlayerPrefs.GetInt("M3-22-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-22-G1",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-22-G1",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-22-G1",1);
				break;
			case 4:
				Letra4.text = "Q";
				PlayerPrefs.SetInt("M3-22-G1",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-22-G1",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-22-G1",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-22-G1",1);
				break;
			case 8:
				Letra8.text = "I";
				PlayerPrefs.SetInt("M3-22-G1",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-22-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==23){
			//Padrino
			RandomTemp1 = PlayerPrefs.GetInt("M3-23-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-23-G1",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-23-G1",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-23-G1",1);
				break;
			case 4:
				Letra4.text = "C";
				PlayerPrefs.SetInt("M3-23-G1",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-23-G1",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-23-G1",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-23-G1",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-23-G1",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-23-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==24){
			//Gaseosa
			RandomTemp1 = PlayerPrefs.GetInt("M3-24-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-24-G1",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-24-G1",1);
				break;
			case 3:
				Letra3.text = "D";
				PlayerPrefs.SetInt("M3-24-G1",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-24-G1",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-24-G1",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-24-G1",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-24-G1",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-24-G1",1);
				break;
			case 9:
				Letra9.text = "L";
				PlayerPrefs.SetInt("M3-24-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==25){
			//Mascara
			RandomTemp1 = PlayerPrefs.GetInt("M3-25-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-25-G1",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-25-G1",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-25-G1",1);
				break;
			case 4:
				Letra4.text = "J";
				PlayerPrefs.SetInt("M3-25-G1",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-25-G1",1);
				break;
			case 6:
				Letra6.text = "D";
				PlayerPrefs.SetInt("M3-25-G1",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-25-G1",1);
				break;
			case 8:
				Letra8.text = "C";
				PlayerPrefs.SetInt("M3-25-G1",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-25-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==26){
			//Catorce
			RandomTemp1 = PlayerPrefs.GetInt("M3-26-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-26-G1",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-26-G1",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-26-G1",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-26-G1",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-26-G1",1);
				break;
			case 6:
				Letra6.text = "O";
				PlayerPrefs.SetInt("M3-26-G1",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-26-G1",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-26-G1",1);
				break;
			case 9:
				Letra9.text = "N";
				PlayerPrefs.SetInt("M3-26-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==27){
			//Corazon
			RandomTemp1 = PlayerPrefs.GetInt("M3-27-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "E";
				PlayerPrefs.SetInt("M3-27-G1",1);
				break;
			case 2:
				Letra2.text = "S";
				PlayerPrefs.SetInt("M3-27-G1",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-27-G1",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-27-G1",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-27-G1",1);
				break;
			case 6:
				Letra6.text = "R";
				PlayerPrefs.SetInt("M3-27-G1",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-27-G1",1);
				break;
			case 8:
				Letra8.text = "G";
				PlayerPrefs.SetInt("M3-27-G1",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-27-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==28){
			//Pulgada
			RandomTemp1 = PlayerPrefs.GetInt("M3-28-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-28-G1",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-28-G1",1);
				break;
			case 3:
				Letra3.text = "F";
				PlayerPrefs.SetInt("M3-28-G1",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-28-G1",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-28-G1",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-28-G1",1);
				break;
			case 7:
				Letra7.text = "B";
				PlayerPrefs.SetInt("M3-28-G1",1);
				break;
			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-28-G1",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-28-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==29){
			//Ventana
			RandomTemp1 = PlayerPrefs.GetInt("M3-29-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "O";
				PlayerPrefs.SetInt("M3-29-G1",1);
				break;
			case 2:
				Letra2.text = "R";
				PlayerPrefs.SetInt("M3-29-G1",1);
				break;
			case 3:
				Letra3.text = "D";
				PlayerPrefs.SetInt("M3-29-G1",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-29-G1",1);
				break;
			case 5:
				Letra5.text = "N";
				PlayerPrefs.SetInt("M3-29-G1",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-29-G1",1);
				break;
			case 7:
				Letra7.text = "D";
				PlayerPrefs.SetInt("M3-29-G1",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-29-G1",1);
				break;
			case 9:
				Letra9.text = "R";
				PlayerPrefs.SetInt("M3-29-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}

		if(Metodo==30){
			//Asustar
			RandomTemp1 = PlayerPrefs.GetInt("M3-30-1");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-30-G1",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-30-G1",1);
				break;
			case 3:
				Letra3.text = "M";
				PlayerPrefs.SetInt("M3-30-G1",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-30-G1",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-30-G1",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-30-G1",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-30-G1",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-30-G1",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-30-G1",1);
				break;
			}
			Detec1.SetActive(false);
			Detec2.SetActive(true);
		}
			tempMonedas = Monedas - 3;
			PlayerPrefs.SetInt ("Monedas", tempMonedas);
			TextoAyuda1.SetActive (false);
		}


	}
	#endregion

	#region Metodo2
	/////////// METODO 2
	void Ayuda2 () {
			Monedas = PlayerPrefs.GetInt ("Monedas");
			if (Monedas >= 5) {
		if(Metodo==1){
			//Abogado
			RandomTemp1 = PlayerPrefs.GetInt("M3-1-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-1-G2",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-1-G2",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-1-G2",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-1-G2",1);
				break;
			case 5:
				Letra5.text = "B";
				PlayerPrefs.SetInt("M3-1-G2",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-1-G2",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-1-G2",1);
				break;
			case 8:
				Letra8.text = "E";
				PlayerPrefs.SetInt("M3-1-G2",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-1-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}
		if(Metodo==2){
			//Acarreo
			RandomTemp1 = PlayerPrefs.GetInt("M3-2-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "D";
				PlayerPrefs.SetInt("M3-2-G2",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-2-G2",1);
				break;
			case 3:
				Letra3.text = "F";
				PlayerPrefs.SetInt("M3-2-G2",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-2-G2",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-2-G2",1);
				break;
			case 6:
				Letra6.text = "U";
				PlayerPrefs.SetInt("M3-2-G2",1);
				break;
			case 7:
				Letra7.text = "L";
				PlayerPrefs.SetInt("M3-2-G2",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-2-G2",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-2-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}
		if(Metodo==3){
			//Billete
			RandomTemp1 = PlayerPrefs.GetInt("M3-3-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-3-G2",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-3-G2",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-3-G2",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-3-G2",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-3-G2",1);
				break;
			case 6:
				Letra6.text = "C";
				PlayerPrefs.SetInt("M3-3-G2",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-3-G2",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-3-G2",1);
				break;
			case 9:
				Letra9.text = "N";
				PlayerPrefs.SetInt("M3-3-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}
		if(Metodo==4){
			//Sensual
			RandomTemp1 = PlayerPrefs.GetInt("M3-4-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-4-G2",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-4-G2",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-4-G2",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-4-G2",1);
				break;
			case 5:
				Letra5.text = "P";
				PlayerPrefs.SetInt("M3-4-G2",1);
				break;
			case 6:
				Letra6.text = "O";
				PlayerPrefs.SetInt("M3-4-G2",1);
				break;
			case 7:
				Letra7.text = "S";
				PlayerPrefs.SetInt("M3-4-G2",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-4-G2",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-4-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==5){
			//Botella
			RandomTemp1 = PlayerPrefs.GetInt("M3-5-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-5-G2",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-5-G2",1);
				break;
			case 3:
				Letra3.text = "T";
				PlayerPrefs.SetInt("M3-5-G2",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-5-G2",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-5-G2",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-5-G2",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-5-G2",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-5-G2",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-5-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==6){
			//Cocinar
			RandomTemp1 = PlayerPrefs.GetInt("M3-6-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "E";
				PlayerPrefs.SetInt("M3-6-G2",1);
				break;
			case 2:
				Letra2.text = "M";
				PlayerPrefs.SetInt("M3-6-G2",1);
				break;
			case 3:
				Letra3.text = "B";
				PlayerPrefs.SetInt("M3-6-G2",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-6-G2",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-6-G2",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-6-G2",1);
				break;
			case 7:
				Letra7.text = "J";
				PlayerPrefs.SetInt("M3-6-G2",1);
				break;
			case 8:
				Letra8.text = "E";
				PlayerPrefs.SetInt("M3-6-G2",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-6-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==7){
			//Galopar
			RandomTemp1 = PlayerPrefs.GetInt("M3-7-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-7-G2",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-7-G2",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-7-G2",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-7-G2",1);
				break;
			case 5:
				Letra5.text = "T";
				PlayerPrefs.SetInt("M3-7-G2",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-7-G2",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-7-G2",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-7-G2",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-7-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}



		if(Metodo==8){
			//Llavero
			RandomTemp1 = PlayerPrefs.GetInt("M3-8-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "R";
				PlayerPrefs.SetInt("M3-8-G2",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-8-G2",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-8-G2",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-8-G2",1);
				break;
			case 5:
				Letra5.text = "G";
				PlayerPrefs.SetInt("M3-8-G2",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-8-G2",1);
				break;
			case 7:
				Letra7.text = "O";
				PlayerPrefs.SetInt("M3-8-G2",1);
				break;
			case 8:
				Letra8.text = "S";
				PlayerPrefs.SetInt("M3-8-G2",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-8-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==9){
			//Mensaje
			RandomTemp1 = PlayerPrefs.GetInt("M3-9-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "L";
				PlayerPrefs.SetInt("M3-9-G2",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-9-G2",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-9-G2",1);
				break;
			case 4:
				Letra4.text = "U";
				PlayerPrefs.SetInt("M3-9-G2",1);
				break;
			case 5:
				Letra5.text = "A";
				PlayerPrefs.SetInt("M3-9-G2",1);
				break;
			case 6:
				Letra6.text = "D";	
				PlayerPrefs.SetInt("M3-9-G2",1);
				break;
			case 7:
				Letra7.text = "O";
				PlayerPrefs.SetInt("M3-9-G2",1);
				break;
			case 8:
				Letra8.text = "R";
				PlayerPrefs.SetInt("M3-9-G2",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-9-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==10){
			//Premiar
			RandomTemp1 = PlayerPrefs.GetInt("M3-10-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "T";
				PlayerPrefs.SetInt("M3-10-G2",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-10-G2",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-10-G2",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-10-G2",1);
				break;
			case 5:
				Letra5.text = "V";
				PlayerPrefs.SetInt("M3-10-G2",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-10-G2",1);
				break;
			case 7:
				Letra7.text = "S";
				PlayerPrefs.SetInt("M3-10-G2",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-10-G2",1);
				break;
			case 9:
				Letra9.text = "R";
				PlayerPrefs.SetInt("M3-10-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==11){
			//Cristal
			RandomTemp1 = PlayerPrefs.GetInt("M3-11-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "R";
				PlayerPrefs.SetInt("M3-11-G2",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-11-G2",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-11-G2",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-11-G2",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-11-G2",1);
				break;
			case 6:
				Letra6.text = "T";
				PlayerPrefs.SetInt("M3-11-G2",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-11-G2",1);
				break;
			case 8:
				Letra8.text = "J";
				PlayerPrefs.SetInt("M3-11-G2",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-11-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==12){
			//Iguales
			RandomTemp1 = PlayerPrefs.GetInt("M3-12-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "V";
				PlayerPrefs.SetInt("M3-12-G2",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-12-G2",1);
				break;
			case 3:
				Letra3.text = "S";
				PlayerPrefs.SetInt("M3-12-G2",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-12-G2",1);
				break;
			case 5:
				Letra5.text = "T";
				PlayerPrefs.SetInt("M3-12-G2",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-12-G2",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-12-G2",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-12-G2",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-12-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==13){
			//Cuentos
			RandomTemp1 = PlayerPrefs.GetInt("M3-13-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-13-G2",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-13-G2",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-13-G2",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-13-G2",1);
				break;
			case 5:
				Letra5.text = "G";
				PlayerPrefs.SetInt("M3-13-G2",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-13-G2",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-13-G2",1);
				break;
			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-13-G2",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-13-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==14){
			//Galeria
			RandomTemp1 = PlayerPrefs.GetInt("M3-14-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "V";
				PlayerPrefs.SetInt("M3-14-G2",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-14-G2",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-14-G2",1);
				break;
			case 4:
				Letra4.text = "T";
				PlayerPrefs.SetInt("M3-14-G2",1);
				break;
			case 5:
				Letra5.text = "E";
				PlayerPrefs.SetInt("M3-14-G2",1);
				break;
			case 6:
				Letra6.text = "B";
				PlayerPrefs.SetInt("M3-14-G2",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-14-G2",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-14-G2",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-14-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==15){
			//Pelotas
			RandomTemp1 = PlayerPrefs.GetInt("M3-15-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-15-G2",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-15-G2",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-15-G2",1);
				break;
			case 4:
				Letra4.text = "R";
				PlayerPrefs.SetInt("M3-15-G2",1);
				break;
			case 5:
				Letra5.text = "O";
				PlayerPrefs.SetInt("M3-15-G2",1);
				break;
			case 6:
				Letra6.text = "B";
				PlayerPrefs.SetInt("M3-15-G2",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-15-G2",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-15-G2",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-15-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==16){
			//Batata
			RandomTemp1 = PlayerPrefs.GetInt("M3-16-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "A";
				PlayerPrefs.SetInt("M3-16-G2",1);
				break;
			case 2:
				Letra2.text = "S";
				PlayerPrefs.SetInt("M3-16-G2",1);
				break;
			case 3:
				Letra3.text = "E";
				PlayerPrefs.SetInt("M3-16-G2",1);
				break;
			case 4:
				Letra4.text = "S";
				PlayerPrefs.SetInt("M3-16-G2",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-16-G2",1);
				break;
			case 6:
				Letra6.text = "N";
				PlayerPrefs.SetInt("M3-16-G2",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-16-G2",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-16-G2",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-16-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==17){
			//Offside
			RandomTemp1 = PlayerPrefs.GetInt("M3-17-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-17-G2",1);
				break;
			case 2:
				Letra2.text = "M";
				PlayerPrefs.SetInt("M3-17-G2",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-17-G2",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-17-G2",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-17-G2",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-17-G2",1);
				break;
			case 7:
				Letra7.text = "B";
				PlayerPrefs.SetInt("M3-17-G2",1);
				break;

			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-17-G2",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-17-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==18){
			//Hornerar
			RandomTemp1 = PlayerPrefs.GetInt("M3-18-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-18-G2",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-18-G2",1);
				break;
			case 3:
				Letra3.text = "V";
				PlayerPrefs.SetInt("M3-18-G2",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-18-G2",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-18-G2",1);
				break;
			case 6:
				Letra6.text = "T";
				PlayerPrefs.SetInt("M3-18-G2",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-18-G2",1);
				break;
			case 8:
				Letra8.text = "G";
				PlayerPrefs.SetInt("M3-18-G2",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-18-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==19){
			//Ajustar
			RandomTemp1 = PlayerPrefs.GetInt("M3-19-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "J";
				PlayerPrefs.SetInt("M3-19-G2",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-19-G2",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-19-G2",1);
				break;
			case 4:
				Letra4.text = "D";
				PlayerPrefs.SetInt("M3-19-G2",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-19-G2",1);
				break;
			case 6:
				Letra6.text = "N";
				PlayerPrefs.SetInt("M3-19-G2",1);
				break;
			case 7:
				Letra7.text = "E";
				PlayerPrefs.SetInt("M3-19-G2",1);
				break;
			case 8:
				Letra8.text = "R";
				PlayerPrefs.SetInt("M3-19-G2",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-19-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==20){
			//Ganador
			RandomTemp1 = PlayerPrefs.GetInt("M3-20-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "S";
				PlayerPrefs.SetInt("M3-20-G2",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-20-G2",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-20-G2",1);
				break;
			case 4:
				Letra4.text = "P";
				PlayerPrefs.SetInt("M3-20-G2",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-20-G2",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-20-G2",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-20-G2",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-20-G2",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-20-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==21){
			//Esperar
			RandomTemp1 = PlayerPrefs.GetInt("M3-21-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-21-G2",1);
				break;
			case 2:
				Letra2.text = "U";
				PlayerPrefs.SetInt("M3-21-G2",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-21-G2",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-21-G2",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-21-G2",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-21-G2",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-21-G2",1);
				break;
			case 8:
				Letra8.text = "H";
				PlayerPrefs.SetInt("M3-21-G2",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-21-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==22){
			//Archivo
			RandomTemp1 = PlayerPrefs.GetInt("M3-22-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-22-G2",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-22-G2",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-22-G2",1);
				break;
			case 4:
				Letra4.text = "Q";
				PlayerPrefs.SetInt("M3-22-G2",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-22-G2",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-22-G2",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-22-G2",1);
				break;
			case 8:
				Letra8.text = "I";
				PlayerPrefs.SetInt("M3-22-G2",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-22-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==23){
			//Padrino
			RandomTemp1 = PlayerPrefs.GetInt("M3-23-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-23-G2",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-23-G2",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-23-G2",1);
				break;
			case 4:
				Letra4.text = "C";
				PlayerPrefs.SetInt("M3-23-G2",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-23-G2",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-23-G2",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-23-G2",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-23-G2",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-23-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==24){
			//Gaseosa
			RandomTemp1 = PlayerPrefs.GetInt("M3-24-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-24-G2",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-24-G2",1);
				break;
			case 3:
				Letra3.text = "D";
				PlayerPrefs.SetInt("M3-24-G2",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-24-G2",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-24-G2",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-24-G2",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-24-G2",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-24-G2",1);
				break;
			case 9:
				Letra9.text = "L";
				PlayerPrefs.SetInt("M3-24-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==25){
			//Mascara
			RandomTemp1 = PlayerPrefs.GetInt("M3-25-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-25-G2",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-25-G2",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-25-G2",1);
				break;
			case 4:
				Letra4.text = "J";
				PlayerPrefs.SetInt("M3-25-G2",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-25-G2",1);
				break;
			case 6:
				Letra6.text = "D";
				PlayerPrefs.SetInt("M3-25-G2",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-25-G2",1);
				break;
			case 8:
				Letra8.text = "C";
				PlayerPrefs.SetInt("M3-25-G2",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-25-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==26){
			//Catorce
			RandomTemp1 = PlayerPrefs.GetInt("M3-26-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-26-G2",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-26-G2",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-26-G2",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-26-G2",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-26-G2",1);
				break;
			case 6:
				Letra6.text = "O";
				PlayerPrefs.SetInt("M3-26-G2",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-26-G2",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-26-G2",1);
				break;
			case 9:
				Letra9.text = "N";
				PlayerPrefs.SetInt("M3-26-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==27){
			//Corazon
			RandomTemp1 = PlayerPrefs.GetInt("M3-27-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "E";
				PlayerPrefs.SetInt("M3-27-G2",1);
				break;
			case 2:
				Letra2.text = "S";
				PlayerPrefs.SetInt("M3-27-G2",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-27-G2",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-27-G2",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-27-G2",1);
				break;
			case 6:
				Letra6.text = "R";
				PlayerPrefs.SetInt("M3-27-G2",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-27-G2",1);
				break;
			case 8:
				Letra8.text = "G";
				PlayerPrefs.SetInt("M3-27-G2",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-27-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==28){
			//Pulgada
			RandomTemp1 = PlayerPrefs.GetInt("M3-28-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-28-G2",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-28-G2",1);
				break;
			case 3:
				Letra3.text = "F";
				PlayerPrefs.SetInt("M3-28-G2",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-28-G2",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-28-G2",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-28-G2",1);
				break;
			case 7:
				Letra7.text = "B";
				PlayerPrefs.SetInt("M3-28-G2",1);
				break;
			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-28-G2",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-28-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==29){
			//Ventana
			RandomTemp1 = PlayerPrefs.GetInt("M3-29-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "O";
				PlayerPrefs.SetInt("M3-29-G2",1);
				break;
			case 2:
				Letra2.text = "R";
				PlayerPrefs.SetInt("M3-29-G2",1);
				break;
			case 3:
				Letra3.text = "D";
				PlayerPrefs.SetInt("M3-29-G2",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-29-G2",1);
				break;
			case 5:
				Letra5.text = "N";
				PlayerPrefs.SetInt("M3-29-G2",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-29-G2",1);
				break;
			case 7:
				Letra7.text = "D";
				PlayerPrefs.SetInt("M3-29-G2",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-29-G2",1);
				break;
			case 9:
				Letra9.text = "R";
				PlayerPrefs.SetInt("M3-29-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}

		if(Metodo==30){
			//Asustar
			RandomTemp1 = PlayerPrefs.GetInt("M3-30-2");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-30-G2",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-30-G2",1);
				break;
			case 3:
				Letra3.text = "M";
				PlayerPrefs.SetInt("M3-30-G2",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-30-G2",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-30-G2",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-30-G2",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-30-G2",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-30-G2",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-30-G2",1);
				break;
			}
			Detec2.SetActive(false);
			Detec3.SetActive(true);
		}
			tempMonedas = Monedas - 5;
			PlayerPrefs.SetInt ("Monedas", tempMonedas);
			TextoAyuda2.SetActive (false);
		}
	}



	#endregion Metodo2

	#region Metodo3
	/////////// METODO 3
	void Ayuda3 () {
				Monedas = PlayerPrefs.GetInt ("Monedas");
				if (Monedas >= 8) {
		if(Metodo==1){
			//Abogado
			RandomTemp1 = PlayerPrefs.GetInt("M3-1-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-1-G3",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-1-G3",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-1-G3",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-1-G3",1);
				break;
			case 5:
				Letra5.text = "B";
				PlayerPrefs.SetInt("M3-1-G3",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-1-G3",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-1-G3",1);
				break;
			case 8:
				Letra8.text = "E";
				PlayerPrefs.SetInt("M3-1-G3",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-1-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}
		if(Metodo==2){
			//Acarreo
			RandomTemp1 = PlayerPrefs.GetInt("M3-2-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "D";
				PlayerPrefs.SetInt("M3-2-G3",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-2-G3",1);
				break;
			case 3:
				Letra3.text = "F";
				PlayerPrefs.SetInt("M3-2-G3",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-2-G3",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-2-G3",1);
				break;
			case 6:
				Letra6.text = "U";
				PlayerPrefs.SetInt("M3-2-G3",1);
				break;
			case 7:
				Letra7.text = "L";
				PlayerPrefs.SetInt("M3-2-G3",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-2-G3",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-2-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}
		if(Metodo==3){
			//Billete
			RandomTemp1 = PlayerPrefs.GetInt("M3-3-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-3-G3",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-3-G3",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-3-G3",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-3-G3",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-3-G3",1);
				break;
			case 6:
				Letra6.text = "C";
				PlayerPrefs.SetInt("M3-3-G3",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-3-G3",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-3-G3",1);
				break;
			case 9:
				Letra9.text = "N";
				PlayerPrefs.SetInt("M3-3-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}
		if(Metodo==4){
			//Sensual
			RandomTemp1 = PlayerPrefs.GetInt("M3-4-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-4-G3",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-4-G3",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-4-G3",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-4-G3",1);
				break;
			case 5:
				Letra5.text = "P";
				PlayerPrefs.SetInt("M3-4-G3",1);
				break;
			case 6:
				Letra6.text = "O";
				PlayerPrefs.SetInt("M3-4-G3",1);
				break;
			case 7:
				Letra7.text = "S";
				PlayerPrefs.SetInt("M3-4-G3",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-4-G3",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-4-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==5){
			//Botella
			RandomTemp1 = PlayerPrefs.GetInt("M3-5-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-5-G3",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-5-G3",1);
				break;
			case 3:
				Letra3.text = "T";
				PlayerPrefs.SetInt("M3-5-G3",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-5-G3",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-5-G3",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-5-G3",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-5-G3",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-5-G3",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-5-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==6){
			//Cocinar
			RandomTemp1 = PlayerPrefs.GetInt("M3-6-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "E";
				PlayerPrefs.SetInt("M3-6-G3",1);
				break;
			case 2:
				Letra2.text = "M";
				PlayerPrefs.SetInt("M3-6-G3",1);
				break;
			case 3:
				Letra3.text = "B";
				PlayerPrefs.SetInt("M3-6-G3",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-6-G3",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-6-G3",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-6-G3",1);
				break;
			case 7:
				Letra7.text = "J";
				PlayerPrefs.SetInt("M3-6-G3",1);
				break;
			case 8:
				Letra8.text = "E";
				PlayerPrefs.SetInt("M3-6-G3",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-6-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==7){
			//Galopar
			RandomTemp1 = PlayerPrefs.GetInt("M3-7-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-7-G3",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-7-G3",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-7-G3",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-7-G3",1);
				break;
			case 5:
				Letra5.text = "T";
				PlayerPrefs.SetInt("M3-7-G3",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-7-G3",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-7-G3",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-7-G3",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-7-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}



		if(Metodo==8){
			//Llavero
			RandomTemp1 = PlayerPrefs.GetInt("M3-8-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "R";
				PlayerPrefs.SetInt("M3-8-G3",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-8-G3",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-8-G3",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-8-G3",1);
				break;
			case 5:
				Letra5.text = "G";
				PlayerPrefs.SetInt("M3-8-G3",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-8-G3",1);
				break;
			case 7:
				Letra7.text = "O";
				PlayerPrefs.SetInt("M3-8-G3",1);
				break;
			case 8:
				Letra8.text = "S";
				PlayerPrefs.SetInt("M3-8-G3",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-8-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==9){
			//Mensaje
			RandomTemp1 = PlayerPrefs.GetInt("M3-9-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "L";
				PlayerPrefs.SetInt("M3-9-G3",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-9-G3",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-9-G3",1);
				break;
			case 4:
				Letra4.text = "U";
				PlayerPrefs.SetInt("M3-9-G3",1);
				break;
			case 5:
				Letra5.text = "A";
				PlayerPrefs.SetInt("M3-9-G3",1);
				break;
			case 6:
				Letra6.text = "D";	
				PlayerPrefs.SetInt("M3-9-G3",1);
				break;
			case 7:
				Letra7.text = "O";
				PlayerPrefs.SetInt("M3-9-G3",1);
				break;
			case 8:
				Letra8.text = "R";
				PlayerPrefs.SetInt("M3-9-G3",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-9-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==10){
			//Premiar
			RandomTemp1 = PlayerPrefs.GetInt("M3-10-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "T";
				PlayerPrefs.SetInt("M3-10-G3",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-10-G3",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-10-G3",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-10-G3",1);
				break;
			case 5:
				Letra5.text = "V";
				PlayerPrefs.SetInt("M3-10-G3",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-10-G3",1);
				break;
			case 7:
				Letra7.text = "S";
				PlayerPrefs.SetInt("M3-10-G3",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-10-G3",1);
				break;
			case 9:
				Letra9.text = "R";
				PlayerPrefs.SetInt("M3-10-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==11){
			//Cristal
			RandomTemp1 = PlayerPrefs.GetInt("M3-11-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "R";
				PlayerPrefs.SetInt("M3-11-G3",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-11-G3",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-11-G3",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-11-G3",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-11-G3",1);
				break;
			case 6:
				Letra6.text = "T";
				PlayerPrefs.SetInt("M3-11-G3",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-11-G3",1);
				break;
			case 8:
				Letra8.text = "J";
				PlayerPrefs.SetInt("M3-11-G3",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-11-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==12){
			//Iguales
			RandomTemp1 = PlayerPrefs.GetInt("M3-12-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "V";
				PlayerPrefs.SetInt("M3-12-G3",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-12-G3",1);
				break;
			case 3:
				Letra3.text = "S";
				PlayerPrefs.SetInt("M3-12-G3",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-12-G3",1);
				break;
			case 5:
				Letra5.text = "T";
				PlayerPrefs.SetInt("M3-12-G3",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-12-G3",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-12-G3",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-12-G3",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-12-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==13){
			//Cuentos
			RandomTemp1 = PlayerPrefs.GetInt("M3-13-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-13-G3",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-13-G3",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-13-G3",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-13-G3",1);
				break;
			case 5:
				Letra5.text = "G";
				PlayerPrefs.SetInt("M3-13-G3",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-13-G3",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-13-G3",1);
				break;
			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-13-G3",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-13-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==14){
			//Galeria
			RandomTemp1 = PlayerPrefs.GetInt("M3-14-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "V";
				PlayerPrefs.SetInt("M3-14-G3",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-14-G3",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-14-G3",1);
				break;
			case 4:
				Letra4.text = "T";
				PlayerPrefs.SetInt("M3-14-G3",1);
				break;
			case 5:
				Letra5.text = "E";
				PlayerPrefs.SetInt("M3-14-G3",1);
				break;
			case 6:
				Letra6.text = "B";
				PlayerPrefs.SetInt("M3-14-G3",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-14-G3",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-14-G3",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-14-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==15){
			//Pelotas
			RandomTemp1 = PlayerPrefs.GetInt("M3-15-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-15-G3",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-15-G3",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-15-G3",1);
				break;
			case 4:
				Letra4.text = "R";
				PlayerPrefs.SetInt("M3-15-G3",1);
				break;
			case 5:
				Letra5.text = "O";
				PlayerPrefs.SetInt("M3-15-G3",1);
				break;
			case 6:
				Letra6.text = "B";
				PlayerPrefs.SetInt("M3-15-G3",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-15-G3",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-15-G3",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-15-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==16){
			//Batata
			RandomTemp1 = PlayerPrefs.GetInt("M3-16-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "A";
				PlayerPrefs.SetInt("M3-16-G3",1);
				break;
			case 2:
				Letra2.text = "S";
				PlayerPrefs.SetInt("M3-16-G3",1);
				break;
			case 3:
				Letra3.text = "E";
				PlayerPrefs.SetInt("M3-16-G3",1);
				break;
			case 4:
				Letra4.text = "S";
				PlayerPrefs.SetInt("M3-16-G3",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-16-G3",1);
				break;
			case 6:
				Letra6.text = "N";
				PlayerPrefs.SetInt("M3-16-G3",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-16-G3",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-16-G3",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-16-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==17){
			//Offside
			RandomTemp1 = PlayerPrefs.GetInt("M3-17-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-17-G3",1);
				break;
			case 2:
				Letra2.text = "M";
				PlayerPrefs.SetInt("M3-17-G3",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-17-G3",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-17-G3",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-17-G3",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-17-G3",1);
				break;
			case 7:
				Letra7.text = "B";
				PlayerPrefs.SetInt("M3-17-G3",1);
				break;

			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-17-G3",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-17-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==18){
			//Hornerar
			RandomTemp1 = PlayerPrefs.GetInt("M3-18-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-18-G3",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-18-G3",1);
				break;
			case 3:
				Letra3.text = "V";
				PlayerPrefs.SetInt("M3-18-G3",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-18-G3",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-18-G3",1);
				break;
			case 6:
				Letra6.text = "T";
				PlayerPrefs.SetInt("M3-18-G3",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-18-G3",1);
				break;
			case 8:
				Letra8.text = "G";
				PlayerPrefs.SetInt("M3-18-G3",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-18-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==19){
			//Ajustar
			RandomTemp1 = PlayerPrefs.GetInt("M3-19-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "J";
				PlayerPrefs.SetInt("M3-19-G3",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-19-G3",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-19-G3",1);
				break;
			case 4:
				Letra4.text = "D";
				PlayerPrefs.SetInt("M3-19-G3",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-19-G3",1);
				break;
			case 6:
				Letra6.text = "N";
				PlayerPrefs.SetInt("M3-19-G3",1);
				break;
			case 7:
				Letra7.text = "E";
				PlayerPrefs.SetInt("M3-19-G3",1);
				break;
			case 8:
				Letra8.text = "R";
				PlayerPrefs.SetInt("M3-19-G3",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-19-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==20){
			//Ganador
			RandomTemp1 = PlayerPrefs.GetInt("M3-20-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "S";
				PlayerPrefs.SetInt("M3-20-G3",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-20-G3",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-20-G3",1);
				break;
			case 4:
				Letra4.text = "P";
				PlayerPrefs.SetInt("M3-20-G3",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-20-G3",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-20-G3",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-20-G3",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-20-G3",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-20-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==21){
			//Esperar
			RandomTemp1 = PlayerPrefs.GetInt("M3-21-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-21-G3",1);
				break;
			case 2:
				Letra2.text = "U";
				PlayerPrefs.SetInt("M3-21-G3",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-21-G3",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-21-G3",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-21-G3",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-21-G3",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-21-G3",1);
				break;
			case 8:
				Letra8.text = "H";
				PlayerPrefs.SetInt("M3-21-G3",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-21-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==22){
			//Archivo
			RandomTemp1 = PlayerPrefs.GetInt("M3-22-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-22-G3",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-22-G3",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-22-G3",1);
				break;
			case 4:
				Letra4.text = "Q";
				PlayerPrefs.SetInt("M3-22-G3",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-22-G3",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-22-G3",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-22-G3",1);
				break;
			case 8:
				Letra8.text = "I";
				PlayerPrefs.SetInt("M3-22-G3",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-22-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==23){
			//Padrino
			RandomTemp1 = PlayerPrefs.GetInt("M3-23-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-23-G3",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-23-G3",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-23-G3",1);
				break;
			case 4:
				Letra4.text = "C";
				PlayerPrefs.SetInt("M3-23-G3",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-23-G3",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-23-G3",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-23-G3",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-23-G3",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-23-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==24){
			//Gaseosa
			RandomTemp1 = PlayerPrefs.GetInt("M3-24-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-24-G3",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-24-G3",1);
				break;
			case 3:
				Letra3.text = "D";
				PlayerPrefs.SetInt("M3-24-G3",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-24-G3",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-24-G3",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-24-G3",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-24-G3",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-24-G3",1);
				break;
			case 9:
				Letra9.text = "L";
				PlayerPrefs.SetInt("M3-24-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==25){
			//Mascara
			RandomTemp1 = PlayerPrefs.GetInt("M3-25-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-25-G3",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-25-G3",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-25-G3",1);
				break;
			case 4:
				Letra4.text = "J";
				PlayerPrefs.SetInt("M3-25-G3",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-25-G3",1);
				break;
			case 6:
				Letra6.text = "D";
				PlayerPrefs.SetInt("M3-25-G3",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-25-G3",1);
				break;
			case 8:
				Letra8.text = "C";
				PlayerPrefs.SetInt("M3-25-G3",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-25-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==26){
			//Catorce
			RandomTemp1 = PlayerPrefs.GetInt("M3-26-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-26-G3",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-26-G3",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-26-G3",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-26-G3",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-26-G3",1);
				break;
			case 6:
				Letra6.text = "O";
				PlayerPrefs.SetInt("M3-26-G3",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-26-G3",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-26-G3",1);
				break;
			case 9:
				Letra9.text = "N";
				PlayerPrefs.SetInt("M3-26-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==27){
			//Corazon
			RandomTemp1 = PlayerPrefs.GetInt("M3-27-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "E";
				PlayerPrefs.SetInt("M3-27-G3",1);
				break;
			case 2:
				Letra2.text = "S";
				PlayerPrefs.SetInt("M3-27-G3",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-27-G3",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-27-G3",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-27-G3",1);
				break;
			case 6:
				Letra6.text = "R";
				PlayerPrefs.SetInt("M3-27-G3",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-27-G3",1);
				break;
			case 8:
				Letra8.text = "G";
				PlayerPrefs.SetInt("M3-27-G3",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-27-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==28){
			//Pulgada
			RandomTemp1 = PlayerPrefs.GetInt("M3-28-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-28-G3",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-28-G3",1);
				break;
			case 3:
				Letra3.text = "F";
				PlayerPrefs.SetInt("M3-28-G3",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-28-G3",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-28-G3",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-28-G3",1);
				break;
			case 7:
				Letra7.text = "B";
				PlayerPrefs.SetInt("M3-28-G3",1);
				break;
			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-28-G3",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-28-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==29){
			//Ventana
			RandomTemp1 = PlayerPrefs.GetInt("M3-29-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "O";
				PlayerPrefs.SetInt("M3-29-G3",1);
				break;
			case 2:
				Letra2.text = "R";
				PlayerPrefs.SetInt("M3-29-G3",1);
				break;
			case 3:
				Letra3.text = "D";
				PlayerPrefs.SetInt("M3-29-G3",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-29-G3",1);
				break;
			case 5:
				Letra5.text = "N";
				PlayerPrefs.SetInt("M3-29-G3",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-29-G3",1);
				break;
			case 7:
				Letra7.text = "D";
				PlayerPrefs.SetInt("M3-29-G3",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-29-G3",1);
				break;
			case 9:
				Letra9.text = "R";
				PlayerPrefs.SetInt("M3-29-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}

		if(Metodo==30){
			//Asustar
			RandomTemp1 = PlayerPrefs.GetInt("M3-30-3");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-30-G3",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-30-G3",1);
				break;
			case 3:
				Letra3.text = "M";
				PlayerPrefs.SetInt("M3-30-G3",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-30-G3",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-30-G3",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-30-G3",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-30-G3",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-30-G3",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-30-G3",1);
				break;
			}
			Detec3.SetActive(false);
			Detec4.SetActive(true);
		}
			tempMonedas = Monedas - 8;
			PlayerPrefs.SetInt ("Monedas", tempMonedas);
			TextoAyuda3.SetActive (false);
		}
	}

	#endregion

	#region Metodo4
	/////////// METODO 4
	void Ayuda4 () {
					Monedas = PlayerPrefs.GetInt ("Monedas");
					if (Monedas >= 12) {
		if(Metodo==1){
			//Abogado
			RandomTemp1 = PlayerPrefs.GetInt("M3-1-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-1-G4",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-1-G4",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-1-G4",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-1-G4",1);
				break;
			case 5:
				Letra5.text = "B";
				PlayerPrefs.SetInt("M3-1-G4",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-1-G4",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-1-G4",1);
				break;
			case 8:
				Letra8.text = "E";
				PlayerPrefs.SetInt("M3-1-G4",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-1-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}
		if(Metodo==2){
			//Acarreo
			RandomTemp1 = PlayerPrefs.GetInt("M3-2-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "D";
				PlayerPrefs.SetInt("M3-2-G4",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-2-G4",1);
				break;
			case 3:
				Letra3.text = "F";
				PlayerPrefs.SetInt("M3-2-G4",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-2-G4",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-2-G4",1);
				break;
			case 6:
				Letra6.text = "U";
				PlayerPrefs.SetInt("M3-2-G4",1);
				break;
			case 7:
				Letra7.text = "L";
				PlayerPrefs.SetInt("M3-2-G4",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-2-G4",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-2-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}
		if(Metodo==3){
			//Billete
			RandomTemp1 = PlayerPrefs.GetInt("M3-3-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-3-G4",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-3-G4",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-3-G4",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-3-G4",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-3-G4",1);
				break;
			case 6:
				Letra6.text = "C";
				PlayerPrefs.SetInt("M3-3-G4",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-3-G4",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-3-G4",1);
				break;
			case 9:
				Letra9.text = "N";
				PlayerPrefs.SetInt("M3-3-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}
		if(Metodo==4){
			//Sensual
			RandomTemp1 = PlayerPrefs.GetInt("M3-4-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-4-G4",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-4-G4",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-4-G4",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-4-G4",1);
				break;
			case 5:
				Letra5.text = "P";
				PlayerPrefs.SetInt("M3-4-G4",1);
				break;
			case 6:
				Letra6.text = "O";
				PlayerPrefs.SetInt("M3-4-G4",1);
				break;
			case 7:
				Letra7.text = "S";
				PlayerPrefs.SetInt("M3-4-G4",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-4-G4",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-4-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==5){
			//Botella
			RandomTemp1 = PlayerPrefs.GetInt("M3-5-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-5-G4",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-5-G4",1);
				break;
			case 3:
				Letra3.text = "T";
				PlayerPrefs.SetInt("M3-5-G4",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-5-G4",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-5-G4",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-5-G4",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-5-G4",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-5-G4",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-5-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==6){
			//Cocinar
			RandomTemp1 = PlayerPrefs.GetInt("M3-6-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "E";
				PlayerPrefs.SetInt("M3-6-G4",1);
				break;
			case 2:
				Letra2.text = "M";
				PlayerPrefs.SetInt("M3-6-G4",1);
				break;
			case 3:
				Letra3.text = "B";
				PlayerPrefs.SetInt("M3-6-G4",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-6-G4",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-6-G4",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-6-G4",1);
				break;
			case 7:
				Letra7.text = "J";
				PlayerPrefs.SetInt("M3-6-G4",1);
				break;
			case 8:
				Letra8.text = "E";
				PlayerPrefs.SetInt("M3-6-G4",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-6-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==7){
			//Galopar
			RandomTemp1 = PlayerPrefs.GetInt("M3-7-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-7-G4",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-7-G4",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-7-G4",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-7-G4",1);
				break;
			case 5:
				Letra5.text = "T";
				PlayerPrefs.SetInt("M3-7-G4",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-7-G4",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-7-G4",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-7-G4",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-7-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}



		if(Metodo==8){
			//Llavero
			RandomTemp1 = PlayerPrefs.GetInt("M3-8-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "R";
				PlayerPrefs.SetInt("M3-8-G4",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-8-G4",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-8-G4",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-8-G4",1);
				break;
			case 5:
				Letra5.text = "G";
				PlayerPrefs.SetInt("M3-8-G4",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-8-G4",1);
				break;
			case 7:
				Letra7.text = "O";
				PlayerPrefs.SetInt("M3-8-G4",1);
				break;
			case 8:
				Letra8.text = "S";
				PlayerPrefs.SetInt("M3-8-G4",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-8-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==9){
			//Mensaje
			RandomTemp1 = PlayerPrefs.GetInt("M3-9-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "L";
				PlayerPrefs.SetInt("M3-9-G4",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-9-G4",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-9-G4",1);
				break;
			case 4:
				Letra4.text = "U";
				PlayerPrefs.SetInt("M3-9-G4",1);
				break;
			case 5:
				Letra5.text = "A";
				PlayerPrefs.SetInt("M3-9-G4",1);
				break;
			case 6:
				Letra6.text = "D";	
				PlayerPrefs.SetInt("M3-9-G4",1);
				break;
			case 7:
				Letra7.text = "O";
				PlayerPrefs.SetInt("M3-9-G4",1);
				break;
			case 8:
				Letra8.text = "R";
				PlayerPrefs.SetInt("M3-9-G4",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-9-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==10){
			//Premiar
			RandomTemp1 = PlayerPrefs.GetInt("M3-10-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "T";
				PlayerPrefs.SetInt("M3-10-G4",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-10-G4",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-10-G4",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-10-G4",1);
				break;
			case 5:
				Letra5.text = "V";
				PlayerPrefs.SetInt("M3-10-G4",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-10-G4",1);
				break;
			case 7:
				Letra7.text = "S";
				PlayerPrefs.SetInt("M3-10-G4",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-10-G4",1);
				break;
			case 9:
				Letra9.text = "R";
				PlayerPrefs.SetInt("M3-10-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==11){
			//Cristal
			RandomTemp1 = PlayerPrefs.GetInt("M3-11-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "R";
				PlayerPrefs.SetInt("M3-11-G4",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-11-G4",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-11-G4",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-11-G4",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-11-G4",1);
				break;
			case 6:
				Letra6.text = "T";
				PlayerPrefs.SetInt("M3-11-G4",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-11-G4",1);
				break;
			case 8:
				Letra8.text = "J";
				PlayerPrefs.SetInt("M3-11-G4",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-11-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==12){
			//Iguales
			RandomTemp1 = PlayerPrefs.GetInt("M3-12-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "V";
				PlayerPrefs.SetInt("M3-12-G4",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-12-G4",1);
				break;
			case 3:
				Letra3.text = "S";
				PlayerPrefs.SetInt("M3-12-G4",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-12-G4",1);
				break;
			case 5:
				Letra5.text = "T";
				PlayerPrefs.SetInt("M3-12-G4",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-12-G4",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-12-G4",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-12-G4",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-12-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==13){
			//Cuentos
			RandomTemp1 = PlayerPrefs.GetInt("M3-13-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-13-G4",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-13-G4",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-13-G4",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-13-G4",1);
				break;
			case 5:
				Letra5.text = "G";
				PlayerPrefs.SetInt("M3-13-G4",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-13-G4",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-13-G4",1);
				break;
			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-13-G4",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-13-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==14){
			//Galeria
			RandomTemp1 = PlayerPrefs.GetInt("M3-14-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "V";
				PlayerPrefs.SetInt("M3-14-G4",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-14-G4",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-14-G4",1);
				break;
			case 4:
				Letra4.text = "T";
				PlayerPrefs.SetInt("M3-14-G4",1);
				break;
			case 5:
				Letra5.text = "E";
				PlayerPrefs.SetInt("M3-14-G4",1);
				break;
			case 6:
				Letra6.text = "B";
				PlayerPrefs.SetInt("M3-14-G4",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-14-G4",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-14-G4",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-14-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==15){
			//Pelotas
			RandomTemp1 = PlayerPrefs.GetInt("M3-15-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-15-G4",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-15-G4",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-15-G4",1);
				break;
			case 4:
				Letra4.text = "R";
				PlayerPrefs.SetInt("M3-15-G4",1);
				break;
			case 5:
				Letra5.text = "O";
				PlayerPrefs.SetInt("M3-15-G4",1);
				break;
			case 6:
				Letra6.text = "B";
				PlayerPrefs.SetInt("M3-15-G4",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-15-G4",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-15-G4",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-15-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==16){
			//Batata
			RandomTemp1 = PlayerPrefs.GetInt("M3-16-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "A";
				PlayerPrefs.SetInt("M3-16-G4",1);
				break;
			case 2:
				Letra2.text = "S";
				PlayerPrefs.SetInt("M3-16-G4",1);
				break;
			case 3:
				Letra3.text = "E";
				PlayerPrefs.SetInt("M3-16-G4",1);
				break;
			case 4:
				Letra4.text = "S";
				PlayerPrefs.SetInt("M3-16-G4",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-16-G4",1);
				break;
			case 6:
				Letra6.text = "N";
				PlayerPrefs.SetInt("M3-16-G4",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-16-G4",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-16-G4",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-16-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==17){
			//Offside
			RandomTemp1 = PlayerPrefs.GetInt("M3-17-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-17-G4",1);
				break;
			case 2:
				Letra2.text = "M";
				PlayerPrefs.SetInt("M3-17-G4",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-17-G4",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-17-G4",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-17-G4",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-17-G4",1);
				break;
			case 7:
				Letra7.text = "B";
				PlayerPrefs.SetInt("M3-17-G4",1);
				break;

			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-17-G4",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-17-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==18){
			//Hornerar
			RandomTemp1 = PlayerPrefs.GetInt("M3-18-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-18-G4",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-18-G4",1);
				break;
			case 3:
				Letra3.text = "V";
				PlayerPrefs.SetInt("M3-18-G4",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-18-G4",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-18-G4",1);
				break;
			case 6:
				Letra6.text = "T";
				PlayerPrefs.SetInt("M3-18-G4",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-18-G4",1);
				break;
			case 8:
				Letra8.text = "G";
				PlayerPrefs.SetInt("M3-18-G4",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-18-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==19){
			//Ajustar
			RandomTemp1 = PlayerPrefs.GetInt("M3-19-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "J";
				PlayerPrefs.SetInt("M3-19-G4",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-19-G4",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-19-G4",1);
				break;
			case 4:
				Letra4.text = "D";
				PlayerPrefs.SetInt("M3-19-G4",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-19-G4",1);
				break;
			case 6:
				Letra6.text = "N";
				PlayerPrefs.SetInt("M3-19-G4",1);
				break;
			case 7:
				Letra7.text = "E";
				PlayerPrefs.SetInt("M3-19-G4",1);
				break;
			case 8:
				Letra8.text = "R";
				PlayerPrefs.SetInt("M3-19-G4",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-19-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==20){
			//Ganador
			RandomTemp1 = PlayerPrefs.GetInt("M3-20-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "S";
				PlayerPrefs.SetInt("M3-20-G4",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-20-G4",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-20-G4",1);
				break;
			case 4:
				Letra4.text = "P";
				PlayerPrefs.SetInt("M3-20-G4",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-20-G4",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-20-G4",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-20-G4",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-20-G4",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-20-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==21){
			//Esperar
			RandomTemp1 = PlayerPrefs.GetInt("M3-21-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-21-G4",1);
				break;
			case 2:
				Letra2.text = "U";
				PlayerPrefs.SetInt("M3-21-G4",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-21-G4",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-21-G4",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-21-G4",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-21-G4",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-21-G4",1);
				break;
			case 8:
				Letra8.text = "H";
				PlayerPrefs.SetInt("M3-21-G4",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-21-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==22){
			//Archivo
			RandomTemp1 = PlayerPrefs.GetInt("M3-22-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-22-G4",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-22-G4",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-22-G4",1);
				break;
			case 4:
				Letra4.text = "Q";
				PlayerPrefs.SetInt("M3-22-G4",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-22-G4",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-22-G4",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-22-G4",1);
				break;
			case 8:
				Letra8.text = "I";
				PlayerPrefs.SetInt("M3-22-G4",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-22-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==23){
			//Padrino
			RandomTemp1 = PlayerPrefs.GetInt("M3-23-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-23-G4",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-23-G4",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-23-G4",1);
				break;
			case 4:
				Letra4.text = "C";
				PlayerPrefs.SetInt("M3-23-G4",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-23-G4",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-23-G4",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-23-G4",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-23-G4",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-23-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==24){
			//Gaseosa
			RandomTemp1 = PlayerPrefs.GetInt("M3-24-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-24-G4",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-24-G4",1);
				break;
			case 3:
				Letra3.text = "D";
				PlayerPrefs.SetInt("M3-24-G4",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-24-G4",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-24-G4",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-24-G4",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-24-G4",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-24-G4",1);
				break;
			case 9:
				Letra9.text = "L";
				PlayerPrefs.SetInt("M3-24-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==25){
			//Mascara
			RandomTemp1 = PlayerPrefs.GetInt("M3-25-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-25-G4",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-25-G4",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-25-G4",1);
				break;
			case 4:
				Letra4.text = "J";
				PlayerPrefs.SetInt("M3-25-G4",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-25-G4",1);
				break;
			case 6:
				Letra6.text = "D";
				PlayerPrefs.SetInt("M3-25-G4",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-25-G4",1);
				break;
			case 8:
				Letra8.text = "C";
				PlayerPrefs.SetInt("M3-25-G4",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-25-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==26){
			//Catorce
			RandomTemp1 = PlayerPrefs.GetInt("M3-26-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-26-G4",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-26-G4",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-26-G4",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-26-G4",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-26-G4",1);
				break;
			case 6:
				Letra6.text = "O";
				PlayerPrefs.SetInt("M3-26-G4",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-26-G4",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-26-G4",1);
				break;
			case 9:
				Letra9.text = "N";
				PlayerPrefs.SetInt("M3-26-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==27){
			//Corazon
			RandomTemp1 = PlayerPrefs.GetInt("M3-27-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "E";
				PlayerPrefs.SetInt("M3-27-G4",1);
				break;
			case 2:
				Letra2.text = "S";
				PlayerPrefs.SetInt("M3-27-G4",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-27-G4",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-27-G4",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-27-G4",1);
				break;
			case 6:
				Letra6.text = "R";
				PlayerPrefs.SetInt("M3-27-G4",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-27-G4",1);
				break;
			case 8:
				Letra8.text = "G";
				PlayerPrefs.SetInt("M3-27-G4",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-27-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==28){
			//Pulgada
			RandomTemp1 = PlayerPrefs.GetInt("M3-28-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-28-G4",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-28-G4",1);
				break;
			case 3:
				Letra3.text = "F";
				PlayerPrefs.SetInt("M3-28-G4",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-28-G4",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-28-G4",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-28-G4",1);
				break;
			case 7:
				Letra7.text = "B";
				PlayerPrefs.SetInt("M3-28-G4",1);
				break;
			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-28-G4",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-28-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==29){
			//Ventana
			RandomTemp1 = PlayerPrefs.GetInt("M3-29-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "O";
				PlayerPrefs.SetInt("M3-29-G4",1);
				break;
			case 2:
				Letra2.text = "R";
				PlayerPrefs.SetInt("M3-29-G4",1);
				break;
			case 3:
				Letra3.text = "D";
				PlayerPrefs.SetInt("M3-29-G4",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-29-G4",1);
				break;
			case 5:
				Letra5.text = "N";
				PlayerPrefs.SetInt("M3-29-G4",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-29-G4",1);
				break;
			case 7:
				Letra7.text = "D";
				PlayerPrefs.SetInt("M3-29-G4",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-29-G4",1);
				break;
			case 9:
				Letra9.text = "R";
				PlayerPrefs.SetInt("M3-29-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}

		if(Metodo==30){
			//Asustar
			RandomTemp1 = PlayerPrefs.GetInt("M3-30-4");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-30-G4",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-30-G4",1);
				break;
			case 3:
				Letra3.text = "M";
				PlayerPrefs.SetInt("M3-30-G4",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-30-G4",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-30-G4",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-30-G4",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-30-G4",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-30-G4",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-30-G4",1);
				break;
			}
			Detec4.SetActive(false);
			Detec5.SetActive(true);
		}
			tempMonedas = Monedas - 12;
			PlayerPrefs.SetInt ("Monedas", tempMonedas);
			TextoAyuda4.SetActive (false);
		}
	}
	#endregion

	#region Metodo5
	/////////// METODO 5
	void Ayuda5 () {
						Monedas = PlayerPrefs.GetInt ("Monedas");
						if (Monedas >= 15) {
		if(Metodo==1){
			//Abogado
			RandomTemp1 = PlayerPrefs.GetInt("M3-1-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-1-G5",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-1-G5",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-1-G5",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-1-G5",1);
				break;
			case 5:
				Letra5.text = "B";
				PlayerPrefs.SetInt("M3-1-G5",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-1-G5",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-1-G5",1);
				break;
			case 8:
				Letra8.text = "E";
				PlayerPrefs.SetInt("M3-1-G5",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-1-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}
		if(Metodo==2){
			//Acarreo
			RandomTemp1 = PlayerPrefs.GetInt("M3-2-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "D";
				PlayerPrefs.SetInt("M3-2-G5",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-2-G5",1);
				break;
			case 3:
				Letra3.text = "F";
				PlayerPrefs.SetInt("M3-2-G5",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-2-G5",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-2-G5",1);
				break;
			case 6:
				Letra6.text = "U";
				PlayerPrefs.SetInt("M3-2-G5",1);
				break;
			case 7:
				Letra7.text = "L";
				PlayerPrefs.SetInt("M3-2-G5",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-2-G5",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-2-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}
		if(Metodo==3){
			//Billete
			RandomTemp1 = PlayerPrefs.GetInt("M3-3-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-3-G5",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-3-G5",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-3-G5",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-3-G5",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-3-G5",1);
				break;
			case 6:
				Letra6.text = "C";
				PlayerPrefs.SetInt("M3-3-G5",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-3-G5",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-3-G5",1);
				break;
			case 9:
				Letra9.text = "N";
				PlayerPrefs.SetInt("M3-3-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}
		if(Metodo==4){
			//Sensual
			RandomTemp1 = PlayerPrefs.GetInt("M3-4-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-4-G5",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-4-G5",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-4-G5",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-4-G5",1);
				break;
			case 5:
				Letra5.text = "P";
				PlayerPrefs.SetInt("M3-4-G5",1);
				break;
			case 6:
				Letra6.text = "O";
				PlayerPrefs.SetInt("M3-4-G5",1);
				break;
			case 7:
				Letra7.text = "S";
				PlayerPrefs.SetInt("M3-4-G5",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-4-G5",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-4-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==5){
			//Botella
			RandomTemp1 = PlayerPrefs.GetInt("M3-5-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-5-G5",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-5-G5",1);
				break;
			case 3:
				Letra3.text = "T";
				PlayerPrefs.SetInt("M3-5-G5",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-5-G5",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-5-G5",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-5-G5",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-5-G5",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-5-G5",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-5-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==6){
			//Cocinar
			RandomTemp1 = PlayerPrefs.GetInt("M3-6-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "E";
				PlayerPrefs.SetInt("M3-6-G5",1);
				break;
			case 2:
				Letra2.text = "M";
				PlayerPrefs.SetInt("M3-6-G5",1);
				break;
			case 3:
				Letra3.text = "B";
				PlayerPrefs.SetInt("M3-6-G5",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-6-G5",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-6-G5",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-6-G5",1);
				break;
			case 7:
				Letra7.text = "J";
				PlayerPrefs.SetInt("M3-6-G5",1);
				break;
			case 8:
				Letra8.text = "E";
				PlayerPrefs.SetInt("M3-6-G5",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-6-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==7){
			//Galopar
			RandomTemp1 = PlayerPrefs.GetInt("M3-7-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-7-G5",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-7-G5",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-7-G5",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-7-G5",1);
				break;
			case 5:
				Letra5.text = "T";
				PlayerPrefs.SetInt("M3-7-G5",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-7-G5",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-7-G5",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-7-G5",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-7-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}



		if(Metodo==8){
			//Llavero
			RandomTemp1 = PlayerPrefs.GetInt("M3-8-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "R";
				PlayerPrefs.SetInt("M3-8-G5",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-8-G5",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-8-G5",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-8-G5",1);
				break;
			case 5:
				Letra5.text = "G";
				PlayerPrefs.SetInt("M3-8-G5",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-8-G5",1);
				break;
			case 7:
				Letra7.text = "O";
				PlayerPrefs.SetInt("M3-8-G5",1);
				break;
			case 8:
				Letra8.text = "S";
				PlayerPrefs.SetInt("M3-8-G5",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-8-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==9){
			//Mensaje
			RandomTemp1 = PlayerPrefs.GetInt("M3-9-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "L";
				PlayerPrefs.SetInt("M3-9-G5",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-9-G5",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-9-G5",1);
				break;
			case 4:
				Letra4.text = "U";
				PlayerPrefs.SetInt("M3-9-G5",1);
				break;
			case 5:
				Letra5.text = "A";
				PlayerPrefs.SetInt("M3-9-G5",1);
				break;
			case 6:
				Letra6.text = "D";	
				PlayerPrefs.SetInt("M3-9-G5",1);
				break;
			case 7:
				Letra7.text = "O";
				PlayerPrefs.SetInt("M3-9-G5",1);
				break;
			case 8:
				Letra8.text = "R";
				PlayerPrefs.SetInt("M3-9-G5",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-9-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==10){
			//Premiar
			RandomTemp1 = PlayerPrefs.GetInt("M3-10-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "T";
				PlayerPrefs.SetInt("M3-10-G5",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-10-G5",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-10-G5",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-10-G5",1);
				break;
			case 5:
				Letra5.text = "V";
				PlayerPrefs.SetInt("M3-10-G5",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-10-G5",1);
				break;
			case 7:
				Letra7.text = "S";
				PlayerPrefs.SetInt("M3-10-G5",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-10-G5",1);
				break;
			case 9:
				Letra9.text = "R";
				PlayerPrefs.SetInt("M3-10-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==11){
			//Cristal
			RandomTemp1 = PlayerPrefs.GetInt("M3-11-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "R";
				PlayerPrefs.SetInt("M3-11-G5",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-11-G5",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-11-G5",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-11-G5",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-11-G5",1);
				break;
			case 6:
				Letra6.text = "T";
				PlayerPrefs.SetInt("M3-11-G5",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-11-G5",1);
				break;
			case 8:
				Letra8.text = "J";
				PlayerPrefs.SetInt("M3-11-G5",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-11-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==12){
			//Iguales
			RandomTemp1 = PlayerPrefs.GetInt("M3-12-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "V";
				PlayerPrefs.SetInt("M3-12-G5",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-12-G5",1);
				break;
			case 3:
				Letra3.text = "S";
				PlayerPrefs.SetInt("M3-12-G5",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-12-G5",1);
				break;
			case 5:
				Letra5.text = "T";
				PlayerPrefs.SetInt("M3-12-G5",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-12-G5",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-12-G5",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-12-G5",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-12-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==13){
			//Cuentos
			RandomTemp1 = PlayerPrefs.GetInt("M3-13-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-13-G5",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-13-G5",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-13-G5",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-13-G5",1);
				break;
			case 5:
				Letra5.text = "G";
				PlayerPrefs.SetInt("M3-13-G5",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-13-G5",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-13-G5",1);
				break;
			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-13-G5",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-13-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==14){
			//Galeria
			RandomTemp1 = PlayerPrefs.GetInt("M3-14-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "V";
				PlayerPrefs.SetInt("M3-14-G5",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-14-G5",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-14-G5",1);
				break;
			case 4:
				Letra4.text = "T";
				PlayerPrefs.SetInt("M3-14-G5",1);
				break;
			case 5:
				Letra5.text = "E";
				PlayerPrefs.SetInt("M3-14-G5",1);
				break;
			case 6:
				Letra6.text = "B";
				PlayerPrefs.SetInt("M3-14-G5",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-14-G5",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-14-G5",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-14-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==15){
			//Pelotas
			RandomTemp1 = PlayerPrefs.GetInt("M3-15-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-15-G5",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-15-G5",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-15-G5",1);
				break;
			case 4:
				Letra4.text = "R";
				PlayerPrefs.SetInt("M3-15-G5",1);
				break;
			case 5:
				Letra5.text = "O";
				PlayerPrefs.SetInt("M3-15-G5",1);
				break;
			case 6:
				Letra6.text = "B";
				PlayerPrefs.SetInt("M3-15-G5",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-15-G5",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-15-G5",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-15-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==16){
			//Batata
			RandomTemp1 = PlayerPrefs.GetInt("M3-16-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "A";
				PlayerPrefs.SetInt("M3-16-G5",1);
				break;
			case 2:
				Letra2.text = "S";
				PlayerPrefs.SetInt("M3-16-G5",1);
				break;
			case 3:
				Letra3.text = "E";
				PlayerPrefs.SetInt("M3-16-G5",1);
				break;
			case 4:
				Letra4.text = "S";
				PlayerPrefs.SetInt("M3-16-G5",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-16-G5",1);
				break;
			case 6:
				Letra6.text = "N";
				PlayerPrefs.SetInt("M3-16-G5",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-16-G5",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-16-G5",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-16-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==17){
			//Offside
			RandomTemp1 = PlayerPrefs.GetInt("M3-17-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-17-G5",1);
				break;
			case 2:
				Letra2.text = "M";
				PlayerPrefs.SetInt("M3-17-G5",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-17-G5",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-17-G5",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-17-G5",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-17-G5",1);
				break;
			case 7:
				Letra7.text = "B";
				PlayerPrefs.SetInt("M3-17-G5",1);
				break;

			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-17-G5",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-17-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==18){
			//Hornerar
			RandomTemp1 = PlayerPrefs.GetInt("M3-18-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-18-G5",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-18-G5",1);
				break;
			case 3:
				Letra3.text = "V";
				PlayerPrefs.SetInt("M3-18-G5",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-18-G5",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-18-G5",1);
				break;
			case 6:
				Letra6.text = "T";
				PlayerPrefs.SetInt("M3-18-G5",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-18-G5",1);
				break;
			case 8:
				Letra8.text = "G";
				PlayerPrefs.SetInt("M3-18-G5",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-18-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==19){
			//Ajustar
			RandomTemp1 = PlayerPrefs.GetInt("M3-19-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "J";
				PlayerPrefs.SetInt("M3-19-G5",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-19-G5",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-19-G5",1);
				break;
			case 4:
				Letra4.text = "D";
				PlayerPrefs.SetInt("M3-19-G5",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-19-G5",1);
				break;
			case 6:
				Letra6.text = "N";
				PlayerPrefs.SetInt("M3-19-G5",1);
				break;
			case 7:
				Letra7.text = "E";
				PlayerPrefs.SetInt("M3-19-G5",1);
				break;
			case 8:
				Letra8.text = "R";
				PlayerPrefs.SetInt("M3-19-G5",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-19-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==20){
			//Ganador
			RandomTemp1 = PlayerPrefs.GetInt("M3-20-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "S";
				PlayerPrefs.SetInt("M3-20-G5",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-20-G5",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-20-G5",1);
				break;
			case 4:
				Letra4.text = "P";
				PlayerPrefs.SetInt("M3-20-G5",1);
				break;
			case 5:
				Letra5.text = "I";
				PlayerPrefs.SetInt("M3-20-G5",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-20-G5",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-20-G5",1);
				break;
			case 8:
				Letra8.text = "T";
				PlayerPrefs.SetInt("M3-20-G5",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-20-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==21){
			//Esperar
			RandomTemp1 = PlayerPrefs.GetInt("M3-21-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-21-G5",1);
				break;
			case 2:
				Letra2.text = "U";
				PlayerPrefs.SetInt("M3-21-G5",1);
				break;
			case 3:
				Letra3.text = "C";
				PlayerPrefs.SetInt("M3-21-G5",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-21-G5",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-21-G5",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-21-G5",1);
				break;
			case 7:
				Letra7.text = "C";
				PlayerPrefs.SetInt("M3-21-G5",1);
				break;
			case 8:
				Letra8.text = "H";
				PlayerPrefs.SetInt("M3-21-G5",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-21-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==22){
			//Archivo
			RandomTemp1 = PlayerPrefs.GetInt("M3-22-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-22-G5",1);
				break;
			case 2:
				Letra2.text = "O";
				PlayerPrefs.SetInt("M3-22-G5",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-22-G5",1);
				break;
			case 4:
				Letra4.text = "Q";
				PlayerPrefs.SetInt("M3-22-G5",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-22-G5",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-22-G5",1);
				break;
			case 7:
				Letra7.text = "R";
				PlayerPrefs.SetInt("M3-22-G5",1);
				break;
			case 8:
				Letra8.text = "I";
				PlayerPrefs.SetInt("M3-22-G5",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-22-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==23){
			//Padrino
			RandomTemp1 = PlayerPrefs.GetInt("M3-23-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-23-G5",1);
				break;
			case 2:
				Letra2.text = "I";
				PlayerPrefs.SetInt("M3-23-G5",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-23-G5",1);
				break;
			case 4:
				Letra4.text = "C";
				PlayerPrefs.SetInt("M3-23-G5",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-23-G5",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-23-G5",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-23-G5",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-23-G5",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-23-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==24){
			//Gaseosa
			RandomTemp1 = PlayerPrefs.GetInt("M3-24-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-24-G5",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-24-G5",1);
				break;
			case 3:
				Letra3.text = "D";
				PlayerPrefs.SetInt("M3-24-G5",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-24-G5",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-24-G5",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-24-G5",1);
				break;
			case 7:
				Letra7.text = "N";
				PlayerPrefs.SetInt("M3-24-G5",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-24-G5",1);
				break;
			case 9:
				Letra9.text = "L";
				PlayerPrefs.SetInt("M3-24-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==25){
			//Mascara
			RandomTemp1 = PlayerPrefs.GetInt("M3-25-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "P";
				PlayerPrefs.SetInt("M3-25-G5",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-25-G5",1);
				break;
			case 3:
				Letra3.text = "R";
				PlayerPrefs.SetInt("M3-25-G5",1);
				break;
			case 4:
				Letra4.text = "J";
				PlayerPrefs.SetInt("M3-25-G5",1);
				break;
			case 5:
				Letra5.text = "U";
				PlayerPrefs.SetInt("M3-25-G5",1);
				break;
			case 6:
				Letra6.text = "D";
				PlayerPrefs.SetInt("M3-25-G5",1);
				break;
			case 7:
				Letra7.text = "I";
				PlayerPrefs.SetInt("M3-25-G5",1);
				break;
			case 8:
				Letra8.text = "C";
				PlayerPrefs.SetInt("M3-25-G5",1);
				break;
			case 9:
				Letra9.text = "A";
				PlayerPrefs.SetInt("M3-25-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==26){
			//Catorce
			RandomTemp1 = PlayerPrefs.GetInt("M3-26-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "M";
				PlayerPrefs.SetInt("M3-26-G5",1);
				break;
			case 2:
				Letra2.text = "E";
				PlayerPrefs.SetInt("M3-26-G5",1);
				break;
			case 3:
				Letra3.text = "L";
				PlayerPrefs.SetInt("M3-26-G5",1);
				break;
			case 4:
				Letra4.text = "O";
				PlayerPrefs.SetInt("M3-26-G5",1);
				break;
			case 5:
				Letra5.text = "C";
				PlayerPrefs.SetInt("M3-26-G5",1);
				break;
			case 6:
				Letra6.text = "O";
				PlayerPrefs.SetInt("M3-26-G5",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-26-G5",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-26-G5",1);
				break;
			case 9:
				Letra9.text = "N";
				PlayerPrefs.SetInt("M3-26-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==27){
			//Corazon
			RandomTemp1 = PlayerPrefs.GetInt("M3-27-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "E";
				PlayerPrefs.SetInt("M3-27-G5",1);
				break;
			case 2:
				Letra2.text = "S";
				PlayerPrefs.SetInt("M3-27-G5",1);
				break;
			case 3:
				Letra3.text = "P";
				PlayerPrefs.SetInt("M3-27-G5",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-27-G5",1);
				break;
			case 5:
				Letra5.text = "R";
				PlayerPrefs.SetInt("M3-27-G5",1);
				break;
			case 6:
				Letra6.text = "R";
				PlayerPrefs.SetInt("M3-27-G5",1);
				break;
			case 7:
				Letra7.text = "A";
				PlayerPrefs.SetInt("M3-27-G5",1);
				break;
			case 8:
				Letra8.text = "G";
				PlayerPrefs.SetInt("M3-27-G5",1);
				break;
			case 9:
				Letra9.text = "O";
				PlayerPrefs.SetInt("M3-27-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==28){
			//Pulgada
			RandomTemp1 = PlayerPrefs.GetInt("M3-28-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "I";
				PlayerPrefs.SetInt("M3-28-G5",1);
				break;
			case 2:
				Letra2.text = "N";
				PlayerPrefs.SetInt("M3-28-G5",1);
				break;
			case 3:
				Letra3.text = "F";
				PlayerPrefs.SetInt("M3-28-G5",1);
				break;
			case 4:
				Letra4.text = "A";
				PlayerPrefs.SetInt("M3-28-G5",1);
				break;
			case 5:
				Letra5.text = "L";
				PlayerPrefs.SetInt("M3-28-G5",1);
				break;
			case 6:
				Letra6.text = "I";
				PlayerPrefs.SetInt("M3-28-G5",1);
				break;
			case 7:
				Letra7.text = "B";
				PlayerPrefs.SetInt("M3-28-G5",1);
				break;
			case 8:
				Letra8.text = "L";
				PlayerPrefs.SetInt("M3-28-G5",1);
				break;
			case 9:
				Letra9.text = "E";
				PlayerPrefs.SetInt("M3-28-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==29){
			//Ventana
			RandomTemp1 = PlayerPrefs.GetInt("M3-29-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "O";
				PlayerPrefs.SetInt("M3-29-G5",1);
				break;
			case 2:
				Letra2.text = "R";
				PlayerPrefs.SetInt("M3-29-G5",1);
				break;
			case 3:
				Letra3.text = "D";
				PlayerPrefs.SetInt("M3-29-G5",1);
				break;
			case 4:
				Letra4.text = "E";
				PlayerPrefs.SetInt("M3-29-G5",1);
				break;
			case 5:
				Letra5.text = "N";
				PlayerPrefs.SetInt("M3-29-G5",1);
				break;
			case 6:
				Letra6.text = "A";
				PlayerPrefs.SetInt("M3-29-G5",1);
				break;
			case 7:
				Letra7.text = "D";
				PlayerPrefs.SetInt("M3-29-G5",1);
				break;
			case 8:
				Letra8.text = "O";
				PlayerPrefs.SetInt("M3-29-G5",1);
				break;
			case 9:
				Letra9.text = "R";
				PlayerPrefs.SetInt("M3-29-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}

		if(Metodo==30){
			//Asustar
			RandomTemp1 = PlayerPrefs.GetInt("M3-30-5");

			switch(RandomTemp1){
			case 1:
				Letra1.text = "C";
				PlayerPrefs.SetInt("M3-30-G5",1);
				break;
			case 2:
				Letra2.text = "A";
				PlayerPrefs.SetInt("M3-30-G5",1);
				break;
			case 3:
				Letra3.text = "M";
				PlayerPrefs.SetInt("M3-30-G5",1);
				break;
			case 4:
				Letra4.text = "I";
				PlayerPrefs.SetInt("M3-30-G5",1);
				break;
			case 5:
				Letra5.text = "S";
				PlayerPrefs.SetInt("M3-30-G5",1);
				break;
			case 6:
				Letra6.text = "E";
				PlayerPrefs.SetInt("M3-30-G5",1);
				break;
			case 7:
				Letra7.text = "T";
				PlayerPrefs.SetInt("M3-30-G5",1);
				break;
			case 8:
				Letra8.text = "A";
				PlayerPrefs.SetInt("M3-30-G5",1);
				break;
			case 9:
				Letra9.text = "S";
				PlayerPrefs.SetInt("M3-30-G5",1);
				break;
			}
			Detec5.SetActive(false);
			Detec6.SetActive(true);
		}
			tempMonedas = Monedas - 15;
			PlayerPrefs.SetInt ("Monedas", tempMonedas);
			TextoAyuda5.SetActive (false);
		}
	}
	#endregion


}
