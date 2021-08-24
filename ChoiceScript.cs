using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour
{
 public GameObject TextBox;
 public GameObject ecgChoice;
 public GameObject aspirinChoice;
public GameObject rememberChoice;
public GameObject askChoice;
public GameObject matterChoice;
 public int ChoiceMade;

public void ChoiceOption1(){
 TextBox.GetComponent<Text>().text = "The ECG shows that the type of heart attack is a STEMI";
  ChoiceMade = 1;
}    

public void ChoiceOption1_1(){
 TextBox.GetComponent<Text>().text = "Which procedure should the hospital prepare for?";
  ChoiceMade = 3;
}

public void ChoiceOption1_2(){
 TextBox.GetComponent<Text>().text = "The patient says the symptoms started within the past 12 hours";  
  ChoiceMade = 4;
}

public void ChoiceOption1_3(){
 TextBox.GetComponent<Text>().text = "Which procedure should the hospital prepare for?";
 ChoiceMade = 5; 
}

public void ChoiceOption2(){
TextBox.GetComponent<Text>().text = "The patient doesn't like that he doesn't know what he's given.";
ChoiceMade=2;
}

   void Update()
{
    if(ChoiceMade == 1){
        ecgChoice.SetActive (false);
        aspirinChoice.SetActive (false);
        rememberChoice.SetActive (true);
        askChoice.SetActive (true);
        matterChoice.SetActive (true);
}
     if(ChoiceMade == 3){
        ecgChoice.SetActive (false);
        aspirinChoice.SetActive (false);
        rememberChoice.SetActive (false);
        askChoice.SetActive (false);
        matterChoice.SetActive (false);
}
      if(ChoiceMade == 4){
        rememberChoice.SetActive (true);
        askChoice.SetActive (true);
     }
      if(ChoiceMade == 5){
        rememberChoice.SetActive (true);
        askChoice.SetActive (true);
     }
      if(ChoiceMade == 2){
        ecgChoice.SetActive (false);
        aspirinChoice.SetActive (false);
}

    }
}

