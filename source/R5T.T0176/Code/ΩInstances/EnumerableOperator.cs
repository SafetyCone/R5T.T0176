using System;


namespace R5T.T0176
{
    public class EnumerableOperator : IEnumerableOperator
    {
        #region Infrastructure

        public static IEnumerableOperator Instance { get; } = new EnumerableOperator();


        private EnumerableOperator()
        {
        }

        #endregion
    }
}
