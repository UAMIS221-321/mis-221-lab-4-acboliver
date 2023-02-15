//start main
int userChoice = GetUserChoice();

do{
    RouteEm(userChoice);
    userChoice = GetUserChoice();
} while (userChoice !=3);

//end main

static void GetFull(){
    int i,j;
  Random rnd = new Random();
int number = rnd.Next(minValue:3,maxValue:9 );
   
   for(i=1;i<=number;i++)
   {
	for(j=1;j<=i;j++)
	   Console.Write("O");
	Console.Write("\n");
    //OR STATEMENT FOR PARTIAL
}PauseAction();
}


static void GetPartial(){
    int i,j;
  Random rnd = new Random();
int number = rnd.Next(minValue:3,maxValue:9 );
   
   for(i=1;i<=number;i++)
   {
	for(j=1;j<=i;j++){
        Random rnd2 = new Random();
    int gap = rnd2.Next(3);
    if(gap == 0)
	   Console.Write(" ");
       else
       Console.Write("O");
    }
	Console.Write("\n");
    
}PauseAction();
}
static int GetUserChoice(){
    DisplayMenu();
   string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)){
        return int.Parse(userChoice);

    }   
    else return 0;
}
static void DisplayMenu() {
Console.Clear();
System.Console.WriteLine("Enter 1 to display a full triangle\nEnter 2 to display a partial triangle\nEnter 3 to exit");


}

static bool IsValidChoice(string userChoice){
    if(userChoice=="1" || userChoice=="2" || userChoice=="3" ){
        return true;
    
    
    }
    else return false;
}

static void SayInvalid(){
System.Console.WriteLine("Invalid!");
    PauseAction();
}

static void RouteEm(int menuChoice){
    if(menuChoice==1){
 
        GetFull();
    }
    else if(menuChoice==2){
    
        GetPartial();
    }
    
    else if(menuChoice!=3){
        SayInvalid();

    }


}

static void PauseAction() {
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}
