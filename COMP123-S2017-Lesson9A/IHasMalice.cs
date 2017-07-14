using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Robin singh
 * Date: July 13, 2017
 * Description: This is an interface that defines a Malice property that 
 * must be implement in any class that subscribes to it.
 * Version: 0.1 - Created IHasMalice interface
 */
namespace COMP123_S2017_Lesson9A
{
    /// <summary>
    /// this is the IHasMalice interface 
    /// </summary>
    public interface IHasMalice
    {
        

        // PUBLIC PROPERTIES
        int Malice { get; set; }
    }
}