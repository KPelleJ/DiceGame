namespace DiceGame
{
    /// <summary>
    /// This class represents a dice cup containing two dice.
    /// </summary>
    public class DiceCup
    {
        #region Instance fields
        private Die _die1;
        private Die _die2;
        private Die _die3;
        private int _diceSides;
        #endregion

        #region Constructor
        public DiceCup(int diceSides)
        {
            _die1 = new Die(diceSides);
            _die2 = new Die(diceSides);
            _die3 = new Die(diceSides);
            _diceSides = diceSides;
        }
        #endregion

        // Implement a property TotalValue: the sum of 
        // the face values of the dice in the cup
        public int TotalValue 
        {
            get { return _die1.FaceValue + _die2.FaceValue + _die3.FaceValue; }
        }

        public int Facevalue1 
        { 
            get { return _die1.FaceValue; }
        }

        public int Facevalue2 
        {
            get { return _die2.FaceValue; }
        }

        public int Facevalue3
        {
            get { return _die3.FaceValue; }
        }

        public int DiceSides
        { 
            get { return _diceSides; }
        }

        // Implement a method Shake: all the dice in the cup should be rolled
        //
        public void Shake()
        {
            _die1.Roll(_diceSides);
            _die2.Roll(_diceSides);
            _die3.Roll(_diceSides);
        }

        public override string ToString() 
        {
            return $"You rolled a {_die1.FaceValue}, a {_die2.FaceValue} and a {_die3.FaceValue} for a total of {TotalValue}";
        }

        public string DiceHas()
        {
            return $"Your dice has {_diceSides} sides";
        }
    }
}