using System;

namespace Domain
{
    public class Dice
    {
        #region Field
		public Random _randomizer; 
	    #endregion

        #region Property
		public int Dots { get; private set;} 
	    #endregion


        #region Constructor
		public Dice(){
            Dots=6;
            _randomizer=new Random();
        } 
	    #endregion

        #region Methods
		public void Roll(){
            int dice=_randomizer.Next(6)+1;

            
            Dots=dice;
            
        } 
	    #endregion
    }
}
