using System;
using System.Collections.Generic;
using Compiler.Tokenization;

namespace Compiler.IO
{
    /// <summary>
    /// An object for reporting errors in the compilation process
    /// </summary>
    public class ErrorReporter
    {
        /// <summary>
        /// Whether or not any errors have been encountered
        /// </summary>
        public bool HasErrors { get; set; }

        /// <Summary>
        /// Empty list to store all the errors
        /// </Summary>
        public List<String> Errors = new List<string>();

        /// <Summary>
        /// Adds errors to the error list
        /// </Summary>
        public void AddError(String newErrorToken)
        {
            Errors.Add(newErrorToken);
            HasErrors = true;
        }

        /// <Summary>
        /// Returns the list of errors
        /// </Summary>
        public List<String> GetErrorList()
        {
            return Errors;
        }
    }
}