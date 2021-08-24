using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;
using Fungus;

public class PatientDetails : MonoBehaviour
{
    public Text patientDetails;
    public static string Name;
    public static int age;
    public static List<string> sex = new List<string>();
    public static List<string> randomSex = new List<string>();
    public static List<string> fNames = new List<string>();
    public static List<string> RandomfNames = new List<string>();
    public static List<string> mNames = new List<string>();
    public static List<string> RandomMNames = new List<string>();
    public static string bloodType;
    public static double height;
    public static double weight;
    
    private System.Random randomAge = new System.Random();
    private System.Random randomHeight = new System.Random();
    private System.Random randomWeight = new System.Random();
   // private System.Random Names = new System.Random();
    public static string history;
    Patients patients = new Patients();
    void Start()
    {
        Name = "Bob";
        sex = randomSex;
        age = randomAge.Next(45, 80);
        height = randomHeight.Next(160, 191); 
        weight = randomWeight.Next(80, 130);
        bloodType = "A";
        history = " Stroke,  Diabetes";
        patientDetails.text = "\r\n" + "\r\n" + " Name : " + Name + "\r\n" + "\r\n" + " Age : " + age + "\r\n" + "\r\n" + " Height : " + height + "\r\n" + "\r\n" + " Weight : " + weight + "\r\n" + "\r\n" + " Blood type : " + bloodType + "\r\n" + "\r\n" + " Medical history : " + history;
        PostToDatabase();                   
    }

    void RandomMname()
    {
       // List<string> mNames = new List<string>();
        mNames.Add("Bob");
        mNames.Add("Lucas");
        mNames.Add("Oliver");
        mNames.Add("Abdulrahman");
        mNames.Add("Tyrone");
        string RandomMNames = mNames[UnityEngine.Random.Range(0, mNames.Count)];
        Debug.Log(mNames);
    }

    void RandomFname()
    {
       // List<string> fNames = new List<string>();
        fNames.Add("Katrina");
        fNames.Add("Emily");
        fNames.Add("Rachel");
        fNames.Add("Karen");
        fNames.Add("Sara");
        string RandomfNames = fNames[UnityEngine.Random.Range(0, fNames.Count)];
        Debug.Log(fNames);
    }

    void randomGender()
    {
        //List<string> Sex = new List<string>();
        sex.Add("M");
        sex.Add("F");
        string randomSex = sex[UnityEngine.Random.Range(0, sex.Count)];
    }

    public void OnGetDetails()
    {
        RetrieveFromDatabase(); 
    }
    private void OnActivate()
    {
        patientDetails.text = patients.patientName;
        patientDetails.text = patients.patientAge.ToString();
        patientDetails.text = patients.patientBloodType;
        patientDetails.text = patients.patientHeight.ToString();
        patientDetails.text = patients.patientWeight.ToString();
        patientDetails.text = patients.patientHistory;   
        //patientDetails.text = patients.patientSex.ToString(); 
         
    }
    private void PostToDatabase()
    {
       // Patients patients = new Patients(Name, age, height, weight, history, bloodType);
       Patients patients = new Patients();
       patients.patientName= Name;
       patients.patientAge= age;
       patients.patientHeight= height;
       patients.patientWeight= weight;
       patients.patientHistory= history;
       patients.patientBloodType= bloodType;
       //patients.patientSex = sex;
        //Debug.Log(patients.patientName);
        RestClient.Put("https://fyp-project-b077f-default-rtdb.firebaseio.com/.json", patients);
    }

    private void RetrieveFromDatabase()
    {
        RestClient.Get<Patients>("https://fyp-project-b077f-default-rtdb.firebaseio.com/.json").Then(response =>
        {   
           // Debug.Log(response);
            patients = response;
            OnActivate();
            
        });     
    } 
}
