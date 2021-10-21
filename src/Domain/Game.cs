using System;

namespace Domain
{
    public class Game
    {
        #region Fields
		private readonly List<int> _highscores=new(); 
        private Dice _dice1, _dice2;
	    #endregion
        #region Properties
		public int Eye1 => _dice1.Dots;
        public int Eye2 => _dice2.Dots;
        public bool HasSnakeEyes => Eye1==1&&Eye2==1;
        public IReadOnlyList<int> HighScores {get;}
        public int Total {get; private set;} 
	    #endregion

        #region Constructor
		public Game()
        {
            <Initialize();
            
        } 
	    #endregion

        #region Methods
		private void Initialize(){
            _dice1=new Dice();
            _dice2=new Dice();
        }

        public void Play(){
            _dice1.Roll();
            _dice2.Roll();
            if(HasSnakeEyes)
            {
                _highscores.Add(Total);
                Total = 0;
            }
            else
            {
                Total+=Eye1+Eye2;
     
            }
        }

        public void Restart(){
            Initialize();
        } 
	#endregion
    }

