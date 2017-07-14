using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 * Name: Robin singh
 * Date: July 13, 2017
 * Description: This is the SuperVillian class which inherits from the SuperHuman class
 * and implement the IHasMalice Interface 
 * Version: 0.2 - Modified COnstructor to take Malice value
 */
namespace COMP123_S2017_Lesson9A
{
    /// <summary>
    /// this is the SuperVillian class
    /// </summary>
    public class SuperVillian : SuperHuman, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _malice;


        // PUBLIC PROPERTIES
        public int Malice
        {

            get
            {
                return this._malice;

            }
            set
            {
                this._malice = value;
            }
        }


        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the SuperVillian class
        /// I t takes one argument - name (string)
        /// </summary>
        /// <param name="name"></param>
        public SuperVillian(string name,int malice)
            : base(name)
        {
            this.Malice = malice;
        }
        //PRIVATE METHODS 

        // PUBLIC METHODS 
    }
}