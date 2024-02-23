namespace DiceGame
{
    /// <summary>
    /// This class represents a single 6-sided die
    /// </summary>
    public class Die
    {
        #region Instance fields
        private int _faceValue;
        #endregion

        #region Constructor
        public Die(int nrOfSides)
        {
            Roll(nrOfSides);  // This puts the die in a well-defined state
        }

        #endregion

        #region Properties
        public int FaceValue
        {
            get { return _faceValue; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Roll the die: the value will be set to a random number
        /// between 1 and 6 (both included).
        /// </summary>
        public void Roll(int sides)
        {
            _faceValue = RandomNumberGenerator.Generate(1, sides);
        } 
        #endregion
    }
}