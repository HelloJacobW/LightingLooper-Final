using UnityEngine.UI;
using UnityEngine;

public class DialogueScript : MonoBehaviour
{
    public Text dialogue;
    private int wave = 0;
    private bool dialogueActive = true;
    void Start()
    {
        if (dialogue)
            Invoke("Dialogue", 2f);
    }
    
    private void Dialogue()
    {
        if (!dialogueActive) return;
        wave++;
        switch (wave)
        {
            case 1:
                dialogue.text = "I am Fiz and I'm here to explain to a player the controls";
                Invoke("Dialogue", 4f);
                break;
            case 2:
                dialogue.text = "The basics, A is a puny jump, and X is attack. You can't jump that bump yet, but you will";
                Invoke("Dialogue", 5f);
                break;
            case 3:
                dialogue.text = "Alright, the main point of the game. B is the portal button";
                Invoke("Dialogue", 3f);
                break;
            case 4:
                dialogue.text = "It does different portals depending on where the joystic is and direction you are headed";
                Invoke("Dialogue", 7f);
                break;
            case 5:
                dialogue.text = "Try to go forward then use portal up while grounded before the bump to jump it. Trust me, its way better than a jump.";
                Invoke("Dialogue", 10f);
                break;
            case 6:
                dialogue.text = "YOU GOT THIS!, but if you want to cheese it, joystic up jump when you fall down press the portal button. It will boost you up higher and higher each time. There is a boundarie and you lose life if you go too high.";
                Invoke("Dialogue", 20f);
                break;
            case 7:
                dialogue.text = "I don't beleive you are trying hard enough :(";
                Invoke("Dialogue", 1f);
                break;
            case 8:
                dialogue.text = "JUST GET OVER IT";
                break;
            case 10:
                dialogue.text = "Well Done";
                Invoke("Dialogue", 2f);
                break;
            case 11:
                dialogue.text = "The goal of the game is to destroy the Enemy Orb";
                Invoke("Dialogue", 3f);
                break;
            case 12:
                dialogue.text = "It has a force field, I garentee you will have a hard time with it.";
                Invoke("Dialogue", 6f);
                break;
            case 13:
                dialogue.text = "Alright, the way to weaken the force field is to fight enemies. Every enemy you kill weakens it";
                Invoke("Dialogue", 8f);
                break;
            case 14:
                dialogue.text = "I Spawned a few enemies in the beginning get them!";
                Invoke("Dialogue", 3f);
                break;
            case 15:
                dialogue.text = "There is a ranged enemy and a meelee enemy, melee enemies have shields and ranged shoot you. Your fast enough to win right?";
                Invoke("Dialogue", 5f);
                break;
            case 16:
                dialogue.text = "";
                break;
            default:
                break;
        }
    }
    public void StopDialogue()
    {
        CancelInvoke("Dialogue");
        dialogueActive = false;
        dialogue.text = "";
    }
    public void Part2()
    {
        if(wave < 9)
        {
            StopDialogue();
            wave = 9;
            dialogueActive = true;
            Dialogue();
        }
    }
}
