using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Start2Menu(){ SceneManager.LoadScene("MenuScene");}
    public void Menu2Beginner() { SceneManager.LoadScene("BeginnerScene"); }
    public void Menu2Apprentice() { SceneManager.LoadScene("Apprentice Scene"); }
    public void Menu2Master() { SceneManager.LoadScene("Master Scene"); }
    public void Menu2Rule() { SceneManager.LoadScene("GameRule"); }
    public void Beginner2stage1() { SceneManager.LoadScene("Beginner_stage1"); }
    public void Apprentice2stage1() { SceneManager.LoadScene("Apprentice_stage1"); }
    public void Master2stage1() { SceneManager.LoadScene("Master_stage1"); }
   
}
