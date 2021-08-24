using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Score : MonoBehaviour

{
  //  public Flowchart flowchart;    
     public Text ScoreDisplay;
    //public int points;
    //public int totalScore;
     public int currentScore;
     public Text GradeText;
     public Text Performance;

    // Start is called before the first frame update
    void Start()
    {
       currentScore = 0;
       Grade(currentScore);
       //DontDestroyOnLoad(ScoreDisplay);

    }

    // Update is called once per frame
    void Update()
    {
        Grade(currentScore);
    }

    public void AddScore5()
    {
        currentScore = currentScore + 5;
        ScoreDisplay.text = currentScore.ToString(); 
        
    }

    public void AddScore10()
    {
        currentScore = currentScore + 10;
        ScoreDisplay.text = currentScore.ToString(); 
        
    }

     public void AddScore15()
    {
        currentScore = currentScore + 15;
        ScoreDisplay.text = currentScore.ToString(); 
        
    }

    public void MinusScore5()
    {
        currentScore = currentScore - 5;
        ScoreDisplay.text = currentScore.ToString(); 
    }

        public void MinusScore10()
    {
        currentScore = currentScore - 10;
        ScoreDisplay.text = currentScore.ToString(); 
    }
        public void MinusScore15()
    {
        currentScore = currentScore - 15;
        ScoreDisplay.text = currentScore.ToString(); 
    }
        
      
      
    public void Grade(int currentScore)
        {
        if(currentScore >= -99 && currentScore <= 39)
        {
            GradeText.text = "GRADE: F";
            Performance.text =" Decision Making in Paramedic Practice - Book by Andy Collen" + "\r\n" + "ASSESSMENT SKILLS FOR PARAMEDICS - by  Amanda Blaber & Graham Harris"  + "\r\n" + "Paramedics: From Street to Emergency Department Case - Book by Bob Fellows and Sarah Fellows";
        }

        else if(currentScore >= 40 && currentScore <= 50)
        {
            GradeText.text = "GRADE: E";
            Performance.text ="Decision Making in Paramedic Practice - Book by Andy Collen" + "\r\n" + "ASSESSMENT SKILLS FOR PARAMEDICS - by  Amanda Blaber & Graham Harris";
        }

         else if(currentScore >= 51 && currentScore <= 60)
        {
            GradeText.text = "GRADE: D";
            Performance.text =" Decision Making in Paramedic Practice - Book by Andy Collen"  + "\r\n" + "Paramedics: From Street to Emergency Department Case - Book by Bob Fellows and Sarah Fellows";;
        }

         else if(currentScore >= 60 && currentScore <= 69)
        {
            GradeText.text = "GRADE: C";
            Performance.text =" Decision Making in Paramedic Practice - Book by Andy Collen ";
        }

         else if(currentScore >= 70 && currentScore <= 79)
        {
            GradeText.text = "GRADE: B";
            Performance.text =" Decision Making in Paramedic Practice - Book by Andy Collen ";
        }

         else if(currentScore >= 80 && currentScore <= 89)
        {
            GradeText.text = "GRADE: A";
            Performance.text =" Decision Making in Paramedic Practice - Book by Andy Collen ";
        }

         else if(currentScore >= 90 && currentScore <= 999)
        {
            GradeText.text = "GRADE: A+";
            Performance.text =" Decision Making in Paramedic Practice - Book by Andy Collen ";
        }

        Debug.Log(currentScore);
        Debug.Log(GradeText.text);
    }
}
