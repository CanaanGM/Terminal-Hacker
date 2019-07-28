using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;
    string input;
    enum Screen {MainMenu, Password, Win }
    Screen currentScreen;
    // Start is called before the first frame update
    void Start()
    {
            ShowGameMenu();
    }
    void ShowGameMenu ()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome Mr Wayne ~!");
        Terminal.WriteLine("Who would you like to mess with?");
        Terminal.WriteLine("1. Aza Al-Ghoul ~!");
        Terminal.WriteLine("2. The Joker ~!");
        Terminal.WriteLine("3. The Justice League ~!");
        Terminal.WriteLine("Please Choose: ");
    }

     void OnUserInput(string input)
        {
            if( input.ToLower() == "menu")
            {
                ShowGameMenu();
            }
            else if( currentScreen == Screen.MainMenu)
            {
                MenuController(input);
            }
            else if( currentScreen == Screen.Password)
            {
                MenuController(input);
            }
        }
    void MenuController (string input)
    {
        if ( input == "1")
        {
            level = 1;
            GameStart(level);
        }
        else if( input == "2")
        {
            level = 2;
            GameStart(level);
        }
        else if( input == "3")
        {
            level = 3;
            GameStart(level);
        }
    }

    private void GameStart(int level)
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You've chosen " + level + " Good Luck ~!");
        Terminal.WriteLine("Please enter your password: ");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
