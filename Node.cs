﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node  // wasnt working as a seperate script
{
  public bool walkable;
  public int gridX;
  public int gridY;
  public Vector3 worldPosition;
  public int gCost;
  public int hCost;
  public Node parent;
   public Node(bool _walkable,Vector3 _worldPos,int _gridX,int _gridY)
   {
      walkable=_walkable;
      worldPosition=_worldPos;
      gridX=_gridX;
      gridY=_gridY;
   }
   public int fCost{
       get{    // whenever fCost is called it gets the value from the current gCost and hCost values 
             return gCost+hCost;                  
       }
   }
}