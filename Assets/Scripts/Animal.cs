using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public string Name;
    public abstract void MakeSound();
    public virtual void Move()
    {
        Debug.Log(Name + " hareket ediyor!");
    }
}
