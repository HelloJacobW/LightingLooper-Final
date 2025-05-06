using UnityEngine.UI;
using UnityEngine;

public class DialogueScript : MonoBehaviour
{
    public int wave = 0;
    public Text dialogue;
    void Start()
    {
        if (dialogue)
            Invoke("Dialogue", 2f);
    }
    
    private void Dialogue()
    {
        wave++;
        switch (wave)
        {
            case 1:
                dialogue.text = "I am Fiz and I'm here to explain to a player the controls";
                Invoke("Dialogue", 3f);
                break;
            case 2:
                dialogue.text = "The basics, A is a puny jump, and X is attack. You can't jump that bump yet, but you will";
                Invoke("Dialogue", 3f);
                break;
            case 3:
                dialogue.text = "Alright, the main point of the game. B is the portal button";
                Invoke("Dialogue", 2f);
                break;
            case 4:
                dialogue.text = "It does different portals depending on where the joystic is and direction you are headed";
                Invoke("Dialogue", 3f);
                break;
            default:
                break;
        }
    }
}
