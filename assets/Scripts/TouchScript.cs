using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI

public class TouchScript : MonoBehaviour
{
    public GUIText touchText;

    void OnTriggerEnter(Collider other)
    {
      if (other.gameObject.tag == "Player")
      {
        Destroy(GetComponent<BoxCollider>());
        gameObject.SetActive (false);
        Destroy(gameObject);
      }

      if(gameObject.tag == "Edible")
      {
        touchText.text = "You ate an edible plant.";
      }

      void OnGUI()
      {
          GUI.Box(new Rect(10,10,100,90), touchText);
      }
    }
}
