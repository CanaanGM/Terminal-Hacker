using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game Config: 
        // do these into a Matrix...   
    string[] levelOnePasswords = {"Ninja", "Shadow", "Money", "Power" };
    string[] levelTwoPasswords = { "Harly", "Ominous", "Laugh", "Evil Genius" };
    string[] levelThreePasswords = { "Hawk", "Green", "Space", "SuperMan" };

    // Game Variables
    int level;
    string input;
    int randomLvl = Random.Range(0, 5); // to randomize the password~!
    
    

    enum Screen {MainMenu, Password, Win }
    Screen currentScreen;
    // Start is called before the first frame update
    void Start()
    {
            ShowGameMenu();
    }
    void ShowGameMenu ()
    {
        currentScreen = Screen.MainMenu;
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

            if (level == 1)
            {
                
                if ( input == levelOnePasswords[randomLvl])
                {
                    WinCondition();
                }
                else
                {
                    Terminal.WriteLine("Wrong code...");
                    // after 6 attempts print a lose message and go to mainMenu..
                }
            }
            else if (level == 2)
            {
                
                if (input == levelTwoPasswords[randomLvl])
                {
                    WinCondition();
                }
                else if( input.ToLower() == "batman")
                {
                    Terminal.WriteLine("I've been expecting ya old freind~!");
                    // need to do something speical here~!

                }
                else
                {
                    Terminal.WriteLine("Wrong code...");
                    // after 4 attempts print a lose message and go to mainMenu..
                }
            }
            else if (level == 3)
            {
                if (input == levelThreePasswords[randomLvl])
                {
                    WinCondition();
                }
                
                else
                {
                    Terminal.WriteLine("Wrong code...");
                    // after 2 attempts print a lose message and go to mainMenu..
                }
            }
        }
        }

    void WinCondition()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();

       
        ShowLvlReward();
    }

    void ShowLvlReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("You thwrated their plans to kill you~!");
                Terminal.WriteLine
                    (@"

                                 
                    
                    ");
                break;

            case 2:

                break;

            case 3:

                break;
        }
        
    }

    void MenuController (string input) // to choose what lvl to play ~!
    {
        if ( input == "1")
        {
            level = 1;
            GameStart();
        }
        else if( input == "2")
        {
            level = 2;
            GameStart();
        }
        else if( input == "3")
        {
            level = 3;
            GameStart();
        }
        else
        {
            Terminal.WriteLine("Please choose a valid input!");
        }
    }

    private void GameStart()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("You've chosen " + level + " Good Luck ~!");
        Terminal.WriteLine("Please enter your password: ");

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
