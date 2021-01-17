using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dxSample {
    public class CustomFormatFunction : ICustomFunctionOperatorBrowsable {
        public FunctionCategory Category {
            get {
                return FunctionCategory.Text;
            }
        }
        public string Description {
            get {
                return "CustomFormatFunction(string format, object arg0)\r\nConverts an arg0 value to a string based on a specified format";
            }
        }
        public bool IsValidOperandCount(int count) {
            return count == 2;
        }
        public bool IsValidOperandType(int operandIndex, int operandCount, Type type) {
            return true;
        }
        public int MaxOperandCount {
            get {
                return 2;
            }
        }
        public int MinOperandCount {
            get {
                return 2;
            }
        }
        public object Evaluate(params object[] operands) {
            string res = String.Format(operands[0].ToString(), operands[1]);
            return res;
        }
        public string Name {
            get {
                return "CustomFormatFunction";
            }
        }
        public Type ResultType(params Type[] operands) {
            return typeof(string);
        }
    }
}
