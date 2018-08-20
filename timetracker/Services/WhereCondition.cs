
namespace timetracker.Services
{
    /// <summary>
    /// Represents a single WHERE SQL condition
    /// </summary>
    class WhereCondition
    {
        public string Left = null;
        public string Operator = "=";
        public string Right = null;

        public WhereCondition() { }

        /// <summary>
        /// creates an equal test 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public WhereCondition(string left, object right)
        {
            Left = left;
            Right = right.ToString();
        }

        /// <summary>
        /// Creates a condition of type @operator between left and right.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="operator"></param>
        /// <param name="right"></param>
        public WhereCondition(string left, string @operator, object right)
        {
            Left = left;
            Operator = @operator;
            Right = right.ToString();
        }

        /// <summary>
        /// Forms a string for inclusion into a query.
        /// </summary>
        /// <returns></returns>
        public string Build()
        {
            if (Left != null && Operator != null && Right != null)
            {
                return "[" + Left + "] " + Operator + (Right.ToUpper() == "NULL" ? Right : "'" + Right + "'");
            }
            return "";
        }
    }
}
