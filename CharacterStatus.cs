using System;

namespace ConsoleGame
{
  public struct StatusData {
      int id;
      string name;
      int hp;
      int mp;
      int str;
      int ac;
      int ev;
      int agi;
      int intl;
      int defaultskill;
      bool isPlayer;
  };

  StatusData[] statusdatabase = new StatusData[16];


  static const StatusData statusdatabase[] = {
      {0,"noname", 0, 0, 0, 0, 0, 0, 0, 0, 0},
      {1,"warrior", 40, 3, 30, 10, 15, 15, 5, 1, 0},
      {2,"hunter", 30, 10, 20, 5, 18, 20, 10, 3, 0},
      {3,"priest", 10, 50, 5, 3, 10, 15, 20, 1,  0},
      {4,"sorcerer", 15, 50, 5, 3, 10, 15, 20, 7, 0},
      {5,"monk", 50, 10, 20, 8, 20, 25, 5, 1, 0},
      {6,"oak",26,0,10,3,0,0,0,0, 1},
      {7,"goblin",20,0,10,3,0,0,0,0, 1},
      {8,"green-slime",18,0,10,3,0,0,0,0, 1},
      {9,"kobold",20,0,10,3,0,0,0,0, 1},
      {10,"wild-dog",11,0,10,3,0,0,0,0, 1},
      {11,"pixie",5,0,10,3,0,0,0,0, 1},
      {12,"big-spider",33,0,10,3,0,0,0,0, 1},
      {13,"big-cockroach",30,0,10,3,0,0,0,0, 1},
      {14,"dragon",50,0,10,3,0,0,0,0, 1},
      {15,"snake",10,0,20,20,0,0,0,0, 1}
  };
}

