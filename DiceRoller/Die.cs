using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller;

/// <summary>
/// Represents a die with a configurable number of sides.
/// </summary>
public class Die
{
    private const byte MAX_SIDES = 20;
    private static  readonly Random rand = new();

    /// <summary>
    /// Ceates a new instance of the Die class with the specified number of sides.
    /// </summary>
    /// <param name="numSides">
    /// The number of sides on the die. The sides must be more than 0
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"> Thrown when the number of sides provided is invalid. </exception>
    public Die(byte numSides)
    {
        if (numSides == 0 || numSides > MAX_SIDES)
        {
            throw new ArgumentOutOfRangeException(nameof(numSides)
                ,$"{nameof(numSides)} must be greater than 0 and less than 21");
        }
        NumberOfSides = numSides;

        // Forces the die to start with a random value facing up.
        Roll();
    }

    /// <summary>
    /// Gets or sets the number of sides of the die.
    /// </summary>
    public byte NumberOfSides { get; private set; }

    /// <summary>
    /// The current value that is facing up on the die.
    /// </summary>
    public byte FaceUpValue { get; private set; }


    /// <summary>
    /// Simulates rolling the die and returns the value that is facing up.
    /// </summary>
    public void Roll()
    {
        
        FaceUpValue = Convert.ToByte(rand.Next(1, NumberOfSides + 1));
    }
}
