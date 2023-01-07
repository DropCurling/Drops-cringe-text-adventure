// Final release 1.0.
// Text adventure!
using System;


class program 
{
        
        static Player currentPlayer = new Player();
        public static bool mainLoop = true;
        static void Main(string[] args)
        {
            OGbeginnings();
            Start();
            encounters.FirstEncounter();
            while (mainLoop)
            {
                encounters.RandomEncounter();
            }
            

        }
        
    


    static void Start()
    {
        Console.Clear();
        Player p = new Player();
        Console.WriteLine("You wake up in a cold, stone room.");
        Console.WriteLine("There is a hole in the ceiling. It looks like you fell from there.");
        Console.WriteLine("What was your name?");
        currentPlayer.name = Console.ReadLine();
        Console.WriteLine("What was your Class?");
        Console.WriteLine("Mage, Ranger, Merchant, Engineer, or Warrior?");
        bool flag = false;
        while (flag == false)
        {
            flag = true;
            string input = Console.ReadLine().ToLower();
            if (input == "mage" )
                program.currentPlayer.currentClass = Player.PlayerClass.Mage;
            else if (input == "ranger")
                program.currentPlayer.currentClass = Player.PlayerClass.Ranger;
            else if (input == "warrior")
                program.currentPlayer.currentClass = Player.PlayerClass.Warrior;
            else if (input == "merchant")
                program.currentPlayer.currentClass = Player.PlayerClass.Merchant;
            else if (input == "engineer")
                program.currentPlayer.currentClass = Player.PlayerClass.Enginner;
            else 
            {
                Console.WriteLine("No no that cant be right... Its not even a class!");
                flag = false;
            }
        }

        Console.WriteLine("You feel dazed and tired, but you have to escape");
        if (currentPlayer.name == "Drop")
        {
            Console.WriteLine("you can do thi- Wait a minute! You have my name! Amazing!");
        }
        else if (currentPlayer.name == "Vaul")
        {
            Console.WriteLine("You can do thi- Hey wait! You can one shot everything! How?!");
            program.currentPlayer.weaponValue += 70;
        }
        else if (currentPlayer.name == "TechGamer")
        {
            // Techcore mode (Trolled)
            Console.WriteLine("You can do this you annoying child... What do you mean your part of my mind?");
            Console.WriteLine("You seem to be... very weak. Be careful.");
            program.currentPlayer.coins -= 20;
            program.currentPlayer.weaponValue -= 1;
            program.currentPlayer.health -= 5;
            program.currentPlayer.damage -= 1;
            program.currentPlayer.modifier += 5;
        }
        else if (currentPlayer.name == "Ame")
        {
            Console.WriteLine("You can do this " +currentPlayer.name + "! For Ames rica!");
        }
        else if (currentPlayer.name == "Orange")
        {
            Console.WriteLine("You can do this! For the fellow Krisma Lords!");
        }
        else if (currentPlayer.name == "")
        {
            Console.WriteLine("You can do this... Wow too good for a name eh?");
        }
        else
        {
            Console.WriteLine("You can do this " + currentPlayer.name + "!");
        }

        Console.WriteLine("Press [Enter] to continue.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("There is a door. You feel some resistance as you turn the handle");
        Console.WriteLine("But the rusty lock falls off with little effort");
        Console.WriteLine("You see a small goblin. You are surprised. You have never seen one before!");
        Console.WriteLine("It has its back to you.");
    }


    static void OGbeginnings()
    {
        Print("You wake up inside room 23 at the Inn.");
        Print("You have to travel back home after visiting your family.");
        Print("Its a long ways away, so you decide to ask the farmer if you can hitch a ride");
        Print("Once he leaves.");
        Print("Press [Enter]");
        Console.ReadKey();
        Print("Walking along the path, you notice a small pathway. Theres a sign that says 'DO NOT ENTER'");
        Print("How bad can it be?");
        Print("Curiosity gets the better of you, and you decide to take a peek inside");
        Print("You see that there is a set of stairs");
        Print("Press [Enter] to advance.");
        Console.ReadKey();
        Print("as you are walking, you feel the floor beneath you shake.");
        Print("Suddenly The groun-");
        System.Threading.Thread.Sleep(7000);
    }
   
    static void NPCarea()
    {
        bool NPC = false;
        int SomeGuy = 1;
        while (NPC == false)
        {

        Console.Clear();
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("G - talk to the giant goblin.");
        Console.WriteLine("F - talk to the small fairies");
        Console.WriteLine("H - talk to the human");
        Console.WriteLine("E - exit");
        Console.WriteLine("");
        string input = Console.ReadLine().ToLower();
        if (input == "g" || input == "giant")
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Hello little man!");
            Console.WriteLine("How good is your weapon? Let me see!");
            Console.ResetColor();
            Console.WriteLine("Y to show weapon, N to not.");
            string show = Console.ReadLine().ToLower();
            if (show == "y" || show == "yes")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Haha! Puny weapon!");
                if (currentPlayer.weaponValue == 19)
                {
                    Console.WriteLine("I can give you an upgrade for... 3000 gold coins!");
                    Console.WriteLine("What do you say?");
                    Console.ResetColor();
                    Console.WriteLine("Y to buy, N to not.");
                    string gettingtolast = Console.ReadLine().ToLower();
                    if (gettingtolast =="y" || gettingtolast == "yes")
                    {
                        if (currentPlayer.coins >= 15000)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Haha! Say no more little man!");
                            Console.ResetColor();
                            Console.WriteLine("After waiting a while, the giant hands you your newly upgraded weapon");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Expert craftsmanship if i do say so myself. Have fun slaying puny monsters. HA!");
                            currentPlayer.coins -= 15000;
                            currentPlayer.weaponValue += 1;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Ha! You dont have enough gold coins!");
                            Console.WriteLine("Come back when you have enough!");
                            Console.ReadKey();
                        }

                    }
                    else if (currentPlayer.weaponValue == 20)
                    {
                        Console.WriteLine("Your weapon is fine! no need to upgrade!");
                        Console.ReadKey();
                    }
                    else if (gettingtolast == "n" || gettingtolast == "no")
                    {
                        Console.WriteLine("Aw man... Alright little man.");
                        Console.ReadKey();
                    }

                
                }
                else
                Console.WriteLine("Come back when its stronger! HA!");
                Console.ReadKey();

            }
            else if (show == "n" || show == "no")
            {
                Console.WriteLine("Aw man... Alright little man.");
                Console.ReadKey();
            }


        }
        else if (input == "f" || input == "fairies")
        {
            Console.WriteLine("One of the fairies greets you");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            
            Console.WriteLine("Hello there! We have finally finished our rewards program. Just check the board!");
            Console.WriteLine();
            Console.WriteLine("Current available Rewards");
            Console.WriteLine("(L) = Reward for being level 10");
            Console.WriteLine("(W) = Reward for having a level 20 weapon");
            Console.WriteLine("(E) = Reward for defeating 200 enemies");
            Console.WriteLine("(D) = Reward for defeating 500 enemies");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("there is another fairy");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hi. What reward do you want?");
            string rewards = Console.ReadLine().ToLower();

            if (rewards == "l")
            {
                Console.WriteLine("Let me see if you can.");
                Console.ReadKey();

                if (currentPlayer.level == 10)
                {
                    Console.WriteLine("Congrats. you receive 10 magic beef jerky's.");
                    currentPlayer.potions += 5;
                    Console.ReadKey();
                }
                else if (currentPlayer.level > 10)
                {
                    Console.WriteLine("You dont get anything. You are over level 10.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You are not level 10 you do not get any prize.");
                    Console.ReadKey();
                }

                }
            else if (rewards == "w")
            {
                Console.WriteLine("Let me see if you can");
                Console.ReadKey();

                if (currentPlayer.weaponValue == 20)
                {
                    Console.WriteLine("Congrats. you win 10 magic beef jerky's.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You get nothing.");
                    Console.ReadKey();
                }
            }
            else if (rewards == "e")
            {
                Console.WriteLine("Let me see if you can...");
                Console.ReadKey();
                if (currentPlayer.enemyK == 200)
                {
                    Console.WriteLine("Congrats. You win 150 gold coins.");
                    currentPlayer.coins++;
                    Console.ReadKey();
                }
                else if (currentPlayer.enemyK > 200)
                {
                    Console.WriteLine("You have over 200 enemies defeated, so technically I dont have to give you anything.");
                    Console.WriteLine("Thats your prize.");
                    Console.ReadKey();

                }
                
            
            }
            else if (rewards == "d")
            {
                Console.WriteLine("Let me see if you can...");
                Console.ReadKey();
                if (currentPlayer.enemyK == 500 || currentPlayer.enemyK == 520)
                {
                    Console.WriteLine("Congrats. You earn this rare weapon.");
                    Console.ResetColor();
                    Console.WriteLine("It looks very sharp.");
                    currentPlayer.weaponValue++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You do not have 500 enemies defeated.");
                }
            }
            

        }
        else if (input == "h" || input == "human")
        {
            if (SomeGuy == 1)
            {
                Console.WriteLine("You walk up to the human");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Please help me! I need stronger armor but Im 300 gold short!");
                Console.ResetColor();
                Console.WriteLine("Type Y to help and N to not.");
                String help = Console.ReadLine().ToLower();

                if (help == "y")
                {
                    if (currentPlayer.coins >= 300)
                    {
                    Console.WriteLine("you hand the man 300 gold");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("oh thank you! thank you so much!");
                    Console.ResetColor();
                    Console.WriteLine("The man runs off and comes back in with better armor");
                    Console.WriteLine("Thanks again! Here is a magic beef jerky!");
                    currentPlayer.potions += 1;
                    currentPlayer.coins -= 300;
                    SomeGuy += 1;
                    }
                    else
                    {
                        Console.WriteLine("You dont have enough? Looks like your in the same boat as me.");
                        Console.ReadKey();
                    }

                }
                else if (help == "n")
                {
                    Console.WriteLine("Aw.. alright. You have a good day.");
                    Console.ReadKey();
                }

            }
            else if (SomeGuy == 2)
            {
                Console.WriteLine("Hey there! thanks for the money!");
                Console.ReadKey();

            }

        }
        else if (input == "e" || input == "exit")
        {
            Console.WriteLine("you turn around and exit back to the shop.");
            NPC = true;
        }

        }
    }

    
    











public class encounters
{
    static Random rand = new Random();
    // Encounter generic

    // Encounter
    public static void FirstEncounter()
    {
        Console.WriteLine("You grab a rusty dagger and run up to the goblin");
        Console.WriteLine("The goblin turns...");
        Console.WriteLine("Press [Enter]");
        Console.ReadKey();
        combat(false, "goblin", 1, 5);
    }
    public static void BasicEncounter()
    {
        Console.Clear();
        Console.WriteLine("In this room you turn and you see...");
        Console.ReadKey();
        combat (true,"",0,0);

    }

    public static void BlueWizardEncounter()
    {
        if (program.currentPlayer.currentClass == Player.PlayerClass.Mage)
        {
            Console.Clear();
            Console.WriteLine("In this room, you see a strange man praying to a statue of some kind.");
            Console.WriteLine("He gets up and turns to you. Handing you a magic beef jerky.");
            Console.WriteLine("It seems he thinks your an apprentice.");
            currentPlayer.potions++;
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("In this room, you see a strange man praying to a statue of some kind.");
            Console.WriteLine("He gets up and turns to you");
            Console.ReadKey();
            combat (false, "Blue wizard", 4, 8);
        }

    }
    public static void RedWizardEncounter()
    {
        Console.Clear();
        Console.WriteLine("You open the door and peer into the darkness.");
        Console.WriteLine("With a flash of light, You see a strange man holding a flame.");
        Console.ReadKey();
        combat (false, "Red wizard",5, 15);
    }
    public static void EndingEncounter()
    {
        Console.Clear();
        Print("You walk into a room. There is a set of stairs.");
        Print("You can see the sunlight, as you run to the outside!");
        Print("You have won.");
        Print("Congrats, " +currentPlayer.name+ "!");
        Print("Press [Enter] to end the game.");
        Console.ReadKey();
        System.Environment.Exit(0);
    }
    public static void StrangeEncounter()
    {
        Console.Clear();
        Console.WriteLine("You open the door and see an odd man walking");
        Console.WriteLine("Hello, Stranger.");
        Console.WriteLine("Do you know where the shop is? ...Ah nevermind, why would you?");
        Console.WriteLine("Welp... I better (R)un off now.");
        Console.WriteLine("Thanks anyway, Stranger.");
    }

    public static void GiantEncounter()
    {
        Console.Clear();
        Console.WriteLine("As you walk into the next room you see a giant goblin. Its taller than you!");
        Console.WriteLine("It turns to you.");
        Console.ReadKey();
        combat (false, "Giant", 5, 20);
    }
    public static void DarkWizardEncounter()
    {
        Console.Clear();
        Console.WriteLine("Stepping into the room, there is no enemies.");
        Console.WriteLine("Your almost at the door when...");
        Console.WriteLine("You just barely avoid a beam of darkness.");
        Console.WriteLine("You turn around and see...");
        Console.ReadKey();
        combat (false, "Dark wizard", 7, 17);
    }
    public static void NecromancerEncounter()
    {
        Console.Clear();
        Console.WriteLine("You step into a room filled with skeletons.");
        Console.WriteLine("There is a man standing in the center");
        Console.WriteLine("He turns to you...");
        Console.ReadKey();
        combat(false, "The Necromancer", 10, 4);
    }
    public static void FallenHero()
    {
        Console.Clear();
        Console.WriteLine("You step into a room.");
        Console.WriteLine("You can feel the air change as you see a skeleton in full armor.");
        Console.WriteLine("It turns to you");
        if (program.currentPlayer.currentClass == Player.PlayerClass.Warrior)
        {
            Console.WriteLine("It laughs as it tosses you a Magic Beef Jerky");
            program.currentPlayer.potions++;
        }
        
        Console.WriteLine("He raises his sword to you");
        combat(false, "The Fallen Hero", 7, 25);
        
    }
    public static void FinalFightEncounter()
    {
        Console.Clear();
        Console.WriteLine(currentPlayer.name+ ". something feels... off.");
        Console.ReadKey();
        Console.WriteLine("You step into a dark room.");
        Console.WriteLine("Torches suddenly light up as you see something wearing a robe...");
        Console.WriteLine("You dont know if its a man or something else, but you know what you must do.");
        Console.WriteLine("It holds its scythe and points to you");
        Console.ReadKey();
        combat(false, "Death: The dungeons master. ", 15, 35);
        EndingEncounter();
    }
    
     
  


    // Encounter tools
    public static void RandomEncounter()
    {
        switch(rand.Next(0,45)) 
        {
        case 1:
            BasicEncounter();
            break;
        case 2:
        case 3:
            BlueWizardEncounter();
            break;
        case 4:
        case 5:
            if (program.currentPlayer.level >= 3)
            RedWizardEncounter();
            break;
        case 7:
        case 8:
        case 9:
        case 10:
            StrangeEncounter();
            break;
        case 11:
        case 12:
            if (program.currentPlayer.level >= 5)
            {
            GiantEncounter();
            break;
            }
            else
            {
                StrangeEncounter();
                break;
            }
        case 13:
            if  (program.currentPlayer.level >= 8)
            {
                DarkWizardEncounter();
                break;
            }
            else
                BlueWizardEncounter();
                break;
        case 14:
           if (program.currentPlayer.level >= 6)
           {
            NecromancerEncounter();
            break;
           }
           else if (program.currentPlayer.level >= 3)
           {
            RedWizardEncounter();
            break;
           }
           else 
            BlueWizardEncounter();
            break;
        case 6:
           if (program.currentPlayer.level >= 6)
           {
            NecromancerEncounter();
            break;
           }
           else if (program.currentPlayer.level >= 3)
           {
            RedWizardEncounter();
            break;
           }
           else 
            BlueWizardEncounter();
            break;
           
        
        case 15:
        case 16:
        case 17:
           if(program.currentPlayer.level >= 10)
           {
                FallenHero();
                break;
           }
           else
                BasicEncounter();
                break;

        default:
            if (program.currentPlayer.level >= 12)
            {
                FinalFightEncounter();
                break;
            }     
            else
                BasicEncounter();
                break;


        }

    }




    







    public static void combat(bool random, string name, int power, int health)
    {
        string n = "";
        int p = 0;
        int h = 0;
        if (random)
        {
            n = GetName();
            p = program.currentPlayer.GetPower();
            h = program.currentPlayer.GetHealth();

        }
        
        else 
        {
            n = name;
            p = power;
            h = health;
        }
        
        while (h > 0)
        {
           

            Console.Clear();
            Console.WriteLine("      -== FIGHT ==-      ");
            Console.WriteLine(n);
            Console.WriteLine(p + "/" + h);
            Console.WriteLine("");
            Console.WriteLine("-========================-");
            Console.WriteLine("|  (A)ttack    (D)efend  |");
            Console.WriteLine("|  (R)un       (H)eal    |");
            Console.WriteLine("-========================-");
            Console.WriteLine(" Magic beef jerky: " +program.currentPlayer.potions+ "   Health: " +program.currentPlayer.health+ "."); 
            Console.WriteLine("");
            if (program.currentPlayer.currentClass == Player.PlayerClass.Enginner)
            {
                Console.WriteLine("      -= (B)uild =-     ");
                Console.WriteLine("Current amount of scrap: " +program.currentPlayer.scrap);
            }
            Console.WriteLine("Select your choice");
            String input = Console.ReadLine();
            if (input.ToLower() == "a" || input.ToLower() == "attack")
            {
                // Attack
                Console.WriteLine(program.currentPlayer.name+ " attacks the enemy!");
                Console.WriteLine(n+ " attacks you!");
                int damage = p - program.currentPlayer.armorValue;
                if (damage < 0)
                    damage = 0;
                int attack = rand.Next(0, program.currentPlayer.weaponValue) + rand.Next(1, 4) + ((program.currentPlayer.currentClass == Player.PlayerClass.Warrior)?2:0);
                Console.WriteLine("You lose " + damage + " health and deal " +attack+ " damage"); 
                currentPlayer.health -= damage;
                h -= attack;
                Console.WriteLine("Press [Enter]");
                Console.ReadKey();
            }

            else if (input.ToLower() == "d" || input.ToLower() == "defend")
            {
                // Defend
                Console.WriteLine("as " +n+ " goes in to attack you, you defend!");
                int damage = p/4 - program.currentPlayer.armorValue;
                if (damage < 0)
                    damage = 0;
                int attack = rand.Next(0, program.currentPlayer.weaponValue) + rand.Next(1, 4)/2 + ((program.currentPlayer.currentClass == Player.PlayerClass.Ranger)?1:0);
                Console.WriteLine("You lose " + damage + " health and deal " +attack+ " damage.");
                program.currentPlayer.health -= damage;
                h -= attack;
                Console.WriteLine("Press [Enter]");
                Console.ReadKey();
            }
            else if (input.ToLower() == "r" || input.ToLower() == "run")
            {
                // Run
                if(program.currentPlayer.currentClass != Player.PlayerClass.Ranger && rand.Next(0, 2) == 0)
                {
                    Console.WriteLine("You fail to run from " + n + "! " +n+ " attacks!");
                    int damage = p - program.currentPlayer.armorValue;
                if (damage < 0)
                    damage = 0;
                    Console.WriteLine("You lose " + damage + " health and are unable to escape.");
                    program.currentPlayer.health -= damage;
                    Console.WriteLine("Press [Enter]");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You successfully runs from " +n+ "!");
                    Console.WriteLine("As you flee, you see a golden door. You open it and run inside.");
                    Console.WriteLine("Press [Enter]");
                    Console.ReadKey();
                    // go to store
                    Shop.LoadShop(program.currentPlayer);

                }
            }
            else if (input.ToLower() == "h" || input.ToLower() == "heal")
            {
                // Heal
                if (program.currentPlayer.potions == 0)
                {
                    Console.WriteLine(program.currentPlayer.name+ " searches the bag and does not find anything!");
                    int damage = p - program.currentPlayer.armorValue;
                    Console.WriteLine(n+ " strikes " +program.currentPlayer.name+ "! You lose " +damage+ " health!");
                    program.currentPlayer.health -= damage;
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine(program.currentPlayer.name+ " searches the bag and find some magic beef jerky!");
                    int potionV = 5 + ((program.currentPlayer.currentClass==Player.PlayerClass.Mage)?+3:0);
                    Console.WriteLine("You take a bite and gain " +potionV+ " health!");
                    program.currentPlayer.health += potionV;
                    program.currentPlayer.potions--;
                    Console.WriteLine(n + " attacked!");
                    int damage = p - program.currentPlayer.armorValue;
                    if (damage < 0)
                    damage = 0;
                    Console.WriteLine("You take " +damage+ " damage!");
                    program.currentPlayer.health -= damage;
                    Console.WriteLine("Press [Enter]");
                    Console.ReadKey();


                }
                Console.ReadKey();

            }
            else if (input.ToLower() == "b" || input.ToLower() == "build") 
            {
                if (program.currentPlayer.currentClass == Player.PlayerClass.Enginner)
                {
                    Console.WriteLine("you try to build a sentry");
                    if(program.currentPlayer.scrap >= 25)
                    {
                        Console.WriteLine("You successfully build it!");
                        program.currentPlayer.scrap -= 25;

                        Console.WriteLine(n + " attacked!");
                    int damage = p - program.currentPlayer.armorValue;
                    if (damage < 0)
                    damage = 0;
                    Console.WriteLine("You take " +damage+ " damage!");
                    program.currentPlayer.health -= damage;
                    Console.WriteLine("The sentry spurs to life, firing off makeshift bullets towards " +n+ "!");
                    int attack = rand.Next(0, program.currentPlayer.weaponValue) + rand.Next(1, 10);
                    Console.WriteLine("It deals " +attack+ " damage"); 
                    Console.WriteLine("The sentry overheats and explodes. You will have to build another one");
                    h -= attack;
                    Console.ReadKey();

                    }
                    else if (program.currentPlayer.scrap < 25)
                    {
                        Console.WriteLine("You fail to build it, and you lose 5 scrap!");
                        program.currentPlayer.scrap -= 5;
                        Console.WriteLine(n + " attacked!");
                    int damage = p - program.currentPlayer.armorValue;
                    if (damage < 0)
                    damage = 0;
                    Console.WriteLine("You take " +damage+ " damage!");
                    program.currentPlayer.health -= damage;
                    Console.ReadKey();
                    }

                }

            }

            if (program.currentPlayer.health <= 0)
        {
            Console.WriteLine(program.currentPlayer.name +" falls to the floor defeated by " +n+ ". They are dead.");
            Console.WriteLine("Better luck next time.");
            Console.WriteLine("-========== GAME OVER ==========-");
            Console.ReadKey();
            System.Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("");
        }
            

            

        }
        Console.Clear();
        int c = program.currentPlayer.GetCoins();
        int x = program.currentPlayer.GetXp();
        int s = program.currentPlayer.GetScrap();
        Console.WriteLine(program.currentPlayer.name+ " has won against " +n+ "!");
        Console.WriteLine("its body dissolved into " +c+ " coins!");
        program.currentPlayer.coins+=c;
        program.currentPlayer.xp+=x;
        Console.WriteLine("You now have " +program.currentPlayer.coins+ " coins!");
        if(program.currentPlayer.currentClass==Player.PlayerClass.Enginner)
        {
            Console.WriteLine("You find " +s+ " scrap pieces! You can use these for sentries!");
            program.currentPlayer.scrap+=s;
        }
        Console.WriteLine("You have gained " +x+ " xp!");

        if(program.currentPlayer.CanLevelUp())
        {
            program.currentPlayer.LevelUp();
        }
        Console.WriteLine();
        currentPlayer.enemyK ++;
        
        Console.WriteLine("Enemies defeated:  " +currentPlayer.enemyK);
        Console.ReadKey();
    }

    public static string GetName()
    {

        switch (rand.Next(0, 7)) 
        {
        case 0:
            return "Goblin";
        case 1:
            return "Lost warrior";
        case 2:
            return "Risen skeleton";
        case 3:
            return "Moving statue";
        case 4:
            return "Ghost";
        case 5:
            return "Mimic";
        case 6:
            return "Moving suit of armor";

 
        }
        return "Human grave robber";
    }


}










public class Shop
{
    
    public static void LoadShop(Player p)
    {      
        RunShop(p);
    }

    public static void RunShop(Player p)
    {
        int potionP;
        int armorP;
        int weaponP;
        int difP;
        while(true)
        {
            potionP = 20 + 10*program.currentPlayer.modifier + ((program.currentPlayer.currentClass==Player.PlayerClass.Merchant)?-10:0);
            armorP = 100 * (program.currentPlayer.armorValue+1) + ((program.currentPlayer.currentClass==Player.PlayerClass.Merchant)?-25:0);;
            weaponP = 100 * program.currentPlayer.weaponValue + ((program.currentPlayer.currentClass==Player.PlayerClass.Merchant)?-25:0);;
            difP = 200 + 100*program.currentPlayer.modifier + ((program.currentPlayer.currentClass==Player.PlayerClass.Merchant)?-100:0);;
            Console.Clear();
            Console.WriteLine("    -=Mysterious Shop=-    ");
            Console.WriteLine("-===========================-");
            Console.WriteLine("(W)eapon    -    $" +weaponP);
            Console.WriteLine("(M)agic Beef Jerky   -   $" +potionP);
            Console.WriteLine("(A)rmor    -    $" +armorP);
            Console.WriteLine("(D)ifficulty    -    $" +difP);
            Console.WriteLine("-===========================-");
            Console.WriteLine("");
            Console.WriteLine("(E)xit");
            Console.WriteLine("(G)o into the back");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("-=" +p.name+ "s current stats=- ");
            Console.WriteLine("-================================-");
            Console.WriteLine("Current health: " +p.health);
            Console.WriteLine("Coins: " +p.coins);
            Console.WriteLine("Weapon strength: " +p.weaponValue);
            Console.WriteLine("Armor strength: " +p.armorValue);
            Console.WriteLine("Magic beef jerky amount: " +p.potions);
            Console.WriteLine("Dificulty mods: " +p.modifier);
            Console.WriteLine("XP:");
            Console.Write("[");
            program.ProgressBar("+", " ", ((decimal)p.xp / (decimal)p.GetLevelUpValue()), 25);
            Console.WriteLine("]");
            Console.WriteLine("Current Level: " +p.level);
            Console.WriteLine("-================================-");
            Console.WriteLine("Hello there, Stranger. What can I get you?");


            // await input 
            string input = Console.ReadLine().ToLower();
            if (input == "m" || input == "Magic Beef Jerky")
            {
                TryBuy("Magic Beef Jerky", potionP, p);
            }
            else if (input == "w" || input == "Weapon")
            {
                TryBuy("Weapon", weaponP, p);
            }
            else if (input == "a" || input == "Armor")
            {
                TryBuy("Armor", armorP, p);
            }
            else if (input == "d" || input == "Difficulty")
            {
                TryBuy("Difficulty", difP, p);
            }
            else if (input == "e" || input == "Exit")
            {
                Console.WriteLine("Have a day, stranger!");
                break;

            }
            else if (input == "g" || input == "Go")
            {
                Console.WriteLine("You see a wooden door. You open it. ");
                Console.WriteLine("You see a lot of creatures. Big, small, even human.");
                Console.WriteLine("It looks like they arent hostile.");
                Console.ReadKey();
                NPCarea();
            }

        }

    }
    public static void TryBuy(string item, int cost, Player p)
    {
        if(p.coins >= cost)
        {
            if(item == "Magic Beef Jerky")
            {
                p.potions++;
                Console.WriteLine("Thank you for your purchase, Stranger!");
                Console.ReadKey();
            }
            else if (item == "Weapon")
            {
                if (currentPlayer.weaponValue < 18)
                {
                p.weaponValue++;
                Console.WriteLine("Thank you for your purchase, Stranger!");
                Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Unfortunately, I have no more upgrades to give.");
                    Console.WriteLine("Here is your money back stranger.");
                    Console.ReadKey();
                    currentPlayer.coins += 1800 - ((program.currentPlayer.currentClass==Player.PlayerClass.Merchant)?+25:0);
                }
            }
            else if (item == "Armor")
            {
                if (currentPlayer.armorValue >= 15)
                {
                    Console.WriteLine("Unfortunately, I have no more upgrades to give.");
                    Console.WriteLine("Here is your money back stranger.");
                    Console.ReadKey();
                    currentPlayer.coins += 1600 - ((program.currentPlayer.currentClass==Player.PlayerClass.Merchant)?+25:0);
                }
                else
                {
                p.armorValue++;
                Console.WriteLine("Thank you for your purchase, Stranger!");
                Console.ReadKey();
                }

            }
            else if(item == "Difficulty")
            {
                p.modifier++;
                Console.WriteLine("Thank you for your purchase, Stranger!"); 
                Console.WriteLine("I think you'll find future rooms a bit more challenging from now on, Stranger.");
                Console.ReadKey();
            
            }
                

            p.coins -= cost;
        }
        else
        {
            Console.WriteLine("It appears you do not have enough gold stranger.");
            Console.ReadKey();

        }

    }
  
}




public static void Print(string text, int speed = 100)
{
    foreach (char c in text)
    {
        Console.Write(c);
        System.Threading.Thread.Sleep(speed);
        
    }
    Console.WriteLine();

}


public static void ProgressBar(string fillerChar, string backgroundChar, decimal value, int size)
{
    int dif = (int)(value * size);
    for(int i = 0; i < size; i++)
    {
        if(i < dif)
        {
            Console.Write(fillerChar);

        }
        else
        {
            Console.Write(backgroundChar);
        }

    }

}













public class Player
{
    Random rand = new Random();
    public string name;
    public int coins = 20;
    public int scrap = 25;
    public int level = 1;
    public int xp = 0;
    public int health = 25;
    public int damage = 1;
    public int armorValue = 0;
    public int potions = 5;
    public int weaponValue = 1;
    public int enemyK = 0;

    public enum PlayerClass {Mage, Ranger, Warrior, Merchant, Enginner};
    public PlayerClass currentClass = PlayerClass.Warrior;

    public int modifier = 0;

    public int GetHealth()
    {
        int upper = (2 * currentPlayer.level + 4 + modifier);
        int lower = (currentPlayer.level + 2);
        return rand.Next(lower, upper);


    }
    public int GetPower()
    {
        int upper = (2 * currentPlayer.level + 3 + modifier);
        int lower = (currentPlayer.level + 1);
        return rand.Next(lower, upper);
    }
    public int GetCoins()
    {
        int upper = (20 * modifier + 50);
        int lower = (15 * modifier + 10);
        return rand.Next(lower, upper);
    }

    public int GetXp()
    {
        int upper = (20 * modifier + 50);
        int lower = (15 * modifier + 10);
        return rand.Next(lower, upper);
    }
    public int GetScrap()
    {
        int upper = (15 * modifier + 10);
        int lower = (5 * modifier + 10);
        return rand.Next(lower, upper);
    }

    public int GetLevelUpValue()
    {
        return 100 * level +250;
    }
    public bool CanLevelUp()
    {
        if(xp >= GetLevelUpValue())
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public void LevelUp()
    {
        while(CanLevelUp())
        {
            xp -= GetLevelUpValue();
            level++;
        }
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Congrats, you have leveled up! You are now level " +level+ "!"); 
        Console.ResetColor();
        Console.WriteLine("It seems future rooms will be tougher. Be careful.");
    }

    
}

}
