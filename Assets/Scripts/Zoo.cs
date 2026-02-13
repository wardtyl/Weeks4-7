using UnityEngine;
using System.Collections.Generic;

public class Zoo : MonoBehaviour
{
    public List<Animal> animals = new List<Animal>();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //    animals.Add("Snake");
        //    animals.Remove("Gorilla");

        //    string selectedAnimal = animals[3];
        //    Debug.Log(selectedAnimal);

        //    for(int i = 0; i < animals.Count; i++)
        //    {
        //        string currentAnimal = animals[i];
        //        Debug.Log(currentAnimal);
        //}

        //    //clears list
        //    animals.Clear();

        Animal newCat = new Animal("cat", "tiger", 5);
        animals.Add(newCat);

        for (int i = 0; i < animals.Count; i++)
        {
            Debug.Log(animals[i].name);
        }

        //simple variables
        int x = 0;
        float f = 0f;
        string s = "";

        //Constructor: Method that establsihes the initial values of 
        //more complicated data types (structs, classes, collections (lists)) 
        Vector3 v = new Vector3(0, 0, 0);



        // Update is called once per frame
        void Update()
        {

        }


    }

    public class Animal
    {
        public string type;
        public string name;
        public int age;
        public Color colour;
        public float size;
        public string sex;

        public Animal(string inType, string inName, int inAge)
        {
            type = inType;
            name = inName;
            age = inAge;
        }
    }
}