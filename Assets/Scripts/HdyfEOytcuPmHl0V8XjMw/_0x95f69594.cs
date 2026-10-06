using System.Collections.Generic;
using UnityEngine;

/// The generated content of one attempt: which basket wants what, in what order the
/// fruit arrives, and where the two decorative props and the butterfly path landed.
public class _0x95f69594
{
    public const int JokerFruit = -1;
    public int Seed;
    public int _0xfd5f453d
    {
        get
        {
            return this.Queue.Count;
        }
    }

    public readonly int[] BasketFruit = new int[BasketCount];
    public readonly int[] BasketArt = new int[BasketCount];
    public float ButterflyPhase;
    public readonly float[] PropTurn = new float[2];
    public float DaySeconds;
    public const int BasketCount = 3;
    public readonly Vector2[] PropPosition = new Vector2[2];
    public float ButterflySpan;
    public readonly int[] BasketTarget = new int[BasketCount];
    public readonly List<int> Queue = new List<int>();
}