using UnityEngine;

public class Hacker2 : MonoBehaviour
{
    // Bug: You have chosen level: 0
    //Game state
    int level;
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen = Screen.MainMenu;
    string Password = "";
    string winningMessage = "";
    string losingMessage = "";
    string loreMessage = "";

    string[] level1Passwords = { "vault", "door", "infiltrate", "access", "security" };
    string[] level2Passwords = { "murder mystery", "final space", "total drama island", "family guy", "rick and morty" };
    string[] level3Passwords = { "nuclear mosquito-filled invasion official test", "pyong mosquito pesticide: not functional", "U.S.Marine Secret Services, only operational at nightime", "the midst of the middle night of my bday month", "worldwide annihilation at it's finest" };

    
    
    // Bank: Vault, Door, Security, Access, Infiltrate
    // Netflix: Vikings, Accessibility, TotalDrama, Daredevil, DragonBall
    // Death itself: nuclearalphamissile, U.S.MarineSecretServices,pyongmosquitoinvasion, perfectlunchtime, worldwideannihilation
    // Start is called before the first frame update
    void Start()
    {
       int randomNumber = Random.Range(0, 5);
        ShowMainMenu("Haidar");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu("Haidar");
        }
        else if (currentScreen == Screen.MainMenu) {
            SelectLevel(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);



        }
        
    }

    private void CheckPassword(string input)
    {
        if (input == Password)
        {
            Terminal.WriteLine(winningMessage);
        } else {
            Terminal.WriteLine(losingMessage);
        }
    }

    void SelectLevel(string inputLevel)
    {
        if (inputLevel == "1")
        {
            // lorMessage: idk where it's meant to be added into the code just yet, I hope I find out soon.
            level = 1;
            loreMessage = "So you're going to be helping some others to break into a bank to secure funds for better technology for each and every one of our felow hackers. If you fail this, our objective will probably be harder to accomplish overall, in terms of the actual lore. Good luck!";
            //winningMessage = "you won level 1";
            winningMessage = "Congrats on not being an absolute noob, let's see how well you do on the next difficulty.";
            // losingMessage = "you are really bad at this game, just saying";
            losingMessage = "You are a disgrace to MLG hackers, and your friends are now gonna get arrested because of you, great job. Better luck next time.";
            StartGame();

        }
        else if (inputLevel == "2")
        {
            level = 2;
            //winningMessage = "you beat level 2";
            winningMessage = "I'm surprised that you could guess a Netflix show name, congrats on knowing your stuff, and being the new Robin Hood. You done good, agent.";
            // losingMessage = "you lost, better luck next time";
            losingMessage = "You lost because you don't know your Netflix shows, and now you won't acheive the title of Robin Hood temporarily, people still have to pay because of you.";
            StartGame();
        }
        else if (inputLevel == "3")
        {
            level = 3;
            winningMessage = "If you won this level, you're cheating, and I know it. You shouldn't have been able to pass this level anyways, so good job cheating on the hardest level.";
            //losingMessage 
            losingMessage = "You lost, obviously as expected, this was meant to be virtually impossible without cheating, so you have my respect for trying to save Japan from even more debt than they already have. Better luck next time.";
            StartGame();
        } else {
            StartGame();
         
        }


    }

    private void StartGame()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(loreMessage);
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level:" + level);


        switch (level)
        {
            case 1:
                Password = level1Passwords[Random.Range(0, level1Passwords.Length - 1)];
                print(Password);
                break; 
            case 2:
                Password = level2Passwords[Random.Range(0, level2Passwords.Length - 1)];
                break;
            case 3:
                Password = level3Passwords[Random.Range(0, level3Passwords.Length - 1)];
                break;


            default:
                Terminal.WriteLine("You must be clueless, this ain't a valid level number!");
                break;


        }
        Terminal.WriteLine("Enter the password to complete your objective:" + Password.Anagram());
    }
    void ShowMainMenu(string name) {
        Terminal.ClearScreen();
        Terminal.WriteLine("You have been summoned by the international organization of hackers, to help out in our quest to acheive eventual world peace. Each level has a different lore, which will be explained once you select them, good luck trying to help us out!");
        Terminal.WriteLine("Press 1 for Bank:");
        Terminal.WriteLine("Press 2 for Netflix:");
        Terminal.WriteLine("Press 3 for Death itself:");
        Terminal.WriteLine("Please select your preferred difficulty level:");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
