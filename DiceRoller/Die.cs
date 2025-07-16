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

    /// <summary>
    /// Ceates a new instance of the Die class with the specified number of sides.
    /// </summary>
    /// <param name="numSides">
    /// The sides must be more than 0
    /// </param>
    public Die(byte numSides)
    {
        if (numSides == 0 || numSides > 20)
        {
            throw new ArgumentOutOfRangeException(nameof(numSides)
                ,$"{nameof(numSides)} must be greater than 0 and less than 21");
        }
        NumberOfSides = numSides;
    }

    /// <summary>
    /// Gets or sets the number of sides of the die.
    /// </summary>
    public byte NumberOfSides { get; set; }
}
