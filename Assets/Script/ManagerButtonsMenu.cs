using UnityEngine;
using System.Collections;

public class ManagerButtonsMenu : MonoBehaviour {
	
        //Lorsque le bouton Host est appuyé. La fonction permet de loader la scène de HUD de connection avec tous les paramètres nécessaires au joueur qui host.
	public void HostPressed() {
	
    //Zone réservée au code nécessaire au joueur qui host


	}

        //Lorsque le bouton Join est appuyé. La fonction permet de loader la scène de HUD de connection avec tous les paramètres nécessaires au joueur qui join.
    public void JoinPressed()
    {

        //Zone réservée au code nécessaire au joueur qui join
        Application.LoadLevel(1);
    
    }

        //Lorsque le bouton Controls est appuyé. Affiche un schéma des commandes.
    public void ControlsPressed()
    {

    }
}
