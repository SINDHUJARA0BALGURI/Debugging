using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTextGenerator : MonoBehaviour
{
    private const string chars = "ASDFGHJKLQWERTYUUIO";
    public string Genrator(int length)
    {
        string result = string.Empty;
        for(int i = 0; i < length; i++)
        {
            int maxroll = chars.Length;
            char randomCharacter = chars[Random.Range(0, maxroll)];
            result = randomCharacter.ToString();
        }
        return result;
    }
}
