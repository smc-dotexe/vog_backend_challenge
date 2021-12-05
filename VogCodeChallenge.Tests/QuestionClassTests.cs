using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.Step7;
using Xunit;

namespace VogCodeChallenge.Tests
{
    public class QuestionClassTests
    {
        [Fact]
        public void Eight_A_Multiply_Value_by_2_for_Int_1_to_4()
        {
            var result = QuestionClass.TESTModule(1);
            Assert.Equal(2, result);
            result = QuestionClass.TESTModule(2);
            Assert.Equal(4, result);
            result = QuestionClass.TESTModule(3);
            Assert.Equal(6, result);
            result = QuestionClass.TESTModule(4);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Eight_B_Multiply_Value_by_3_for_Int_Greater_than_4()
        {
            var result = QuestionClass.TESTModule(5);
            Assert.Equal(15, result);
        }

        [Fact]
        public void Eight_C_Throw_Proper_Exception_For_Int_Less_Than_1()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => QuestionClass.TESTModule(0));
        }

        [Fact]
        public void Eight_D_Float_Values_of_1f_2f_Return_3f()
        {
            var result = QuestionClass.TESTModule(1.0f);
            Assert.Equal(3f, result);
            result = QuestionClass.TESTModule(2.0f);
            Assert.Equal(3f, result);
        }

        [Fact]
        public void Eight_E_Convert_Any_String_To_UpperCase()
        {
            var result = QuestionClass.TESTModule("return as upper case");
            Assert.Equal("RETURN AS UPPER CASE", result);
        }

        [Fact]
        public void Eight_F_Return_Input_Value_If_None_Match()
        {
            var result = QuestionClass.TESTModule(true);
            Assert.Equal(true, result);
        }
    }
}
