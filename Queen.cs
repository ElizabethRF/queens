using System;

class Queen {
  int index, min, max, position; 
  int[] restrictedPositions; 
  public Queen(int index, int min, int max){
    this.index = index; 
    this.min = min;
    this.max = max; 
    restrictedPositions = new int[8];
    Console.WriteLine ("Queen "+index);
    spotRestrictedPosition(); 

  }


  public void spotRestrictedPosition(){
    Console.WriteLine("yei");
    for(int i = 0; i < this.index; i++ ){
      
    }

    upperDiagonal(); //TODO 
    lowerDiagonal(); // TODO 
    straightLine(); //TODO 
  }


  public void upperDiagonal(){

  }

  public void lowerDiagonal(){

  }

  public void straightLine(){

  }
}