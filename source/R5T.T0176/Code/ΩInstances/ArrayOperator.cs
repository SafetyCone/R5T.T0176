using System;


namespace R5T.T0176
{
    public class ArrayOperator : IArrayOperator
    {
        #region Infrastructure

        public static IArrayOperator Instance { get; } = new ArrayOperator();


        private ArrayOperator()
        {
        }

        #endregion
    }
}
