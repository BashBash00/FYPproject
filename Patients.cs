using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Patients
{
public string patientName;
public int patientAge;
public string patientBloodType;
public double patientHeight;
public double patientWeight;
public string patientHistory;
 public static List<string> patientSex = new List<string>();

public Patients(){}
public Patients(string Name, int age, double height, double weight, string history, string bloodType, List<string> sex)
{
    patientName = Name;
    patientAge = age;
    patientHeight = height;
    patientWeight = weight;
    patientHistory = history;
    patientBloodType = bloodType;
    patientSex = sex;
}
}
