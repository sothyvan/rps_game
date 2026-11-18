using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Basic button example (slides 24-31).
// How a UI Button calls a script:
//   1. Put this script on a GameObject in the scene (for example "GameManager").
//   2. Select a Button. In "On Click ()", click "+".
//   3. Drag the GameObject with this script into "None (Object)".
//   4. Choose "ButtonController > OnButtonClick (GameObject)".
//   5. Drag the Button itself into "None (Game Object)".
// Press Play and click the button: the Console prints "<button name> clicked".
public class ButtonController : MonoBehaviour
{
    public void OnButtonClick(GameObject gameObject)
    {
        Debug.Log(gameObject.name + " clicked " );
    }
    public void OnMouseExit(GameObject gameObject)
    {
        Debug.Log(gameObject.name + " mouse exit");
    }
}
