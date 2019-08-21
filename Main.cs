using System;

class MainClass {// spawner 
  public static Queen[] queensArray; 
  public static int[] board; 

  public static void Main (string[] args) {
    queensArray = new Queen[8]; 
    board = new int[64]; 
    int min = 0; 
    int max = 7; 
    
    for(int i = 0 ; i < 8 ; i++){
      Queen queen = new Queen(i,min, max); 
      queensArray[i] = queen; 
      min += 8; 
      max += 8; 
    }

    printBoard();
  }


  public static void printBoard(){
      for(int i = 0 ; i < board.Length; i++){
          Console.Write( 0 + " "); 
          if(i % 8 == 7){
            Console.WriteLine(); 
          }
          
      }
  }
}