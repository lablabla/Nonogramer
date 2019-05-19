using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogramer
{
    public class PuzzleModel
    {
        /// <summary>
        /// Rows of the hint.
        /// Each element in the outer list is a row 
        /// containing 1 or more numbers of consequent colored squares
        /// </summary>
        public List<List<int>> Rows { get; set; }

        /// <summary>
        /// Columns of the hint.
        /// Each element in the outer list is a column 
        /// containing 1 or more numbers of consequent colored squares
        /// </summary>
        public List<List<int>> Columns { get; set; }

        /// <summary>
        /// Number of rows
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Number of columns
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// List of size Height*Width in row major ordering
        /// each element is true if colored or false if blank
        /// </summary>
        public List<bool> Goal { get; set; }
    }
}
