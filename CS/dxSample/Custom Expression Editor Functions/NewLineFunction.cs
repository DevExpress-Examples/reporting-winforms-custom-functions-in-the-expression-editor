using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Data.Filtering;

namespace dxSample {
    public class NewLineConstant : ICustomFunctionOperatorBrowsable {
        public FunctionCategory Category {
            get {
                return FunctionCategory.Text;
            }
        }
        public string Description {
            get {
                return "NewLineConstant()\r\nInserts a new line.";
            }
        }
        public bool IsValidOperandCount(int count) {
            return count == 0;
        }
        public bool IsValidOperandType(int operandIndex, int operandCount, Type type) {
            return true;
        }
        public int MaxOperandCount {
            get {
                return 0;
            }
        }
        public int MinOperandCount {
            get {
                return -1;
            }
        }
        public object Evaluate(params object[] operands) {
            return Environment.NewLine;
        }
        public string Name {
            get {
                return "NewLineConstant";
            }
        }
        public Type ResultType(params Type[] operands) {
            return typeof(string);
        }
    }
   
}
