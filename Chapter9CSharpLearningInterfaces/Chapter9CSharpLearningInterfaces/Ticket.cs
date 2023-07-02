using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9CSharpLearningInterfaces
{
    class Ticket : IEquatable<Ticket>
    {
    // Property to store the duration of the ticket in hours
    public int DurationInHours { get; set; }

    // Simple constructor
    public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }
    // Write this code to avoid error with IEquatable
    public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours;
        }
    }
}
