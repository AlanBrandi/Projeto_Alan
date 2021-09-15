using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptB : MonoBehaviour
{
    public ScriptA A;
  public void Removervida(int dano)
  {
        A.life = A.life - A.VDano;
  }
}
