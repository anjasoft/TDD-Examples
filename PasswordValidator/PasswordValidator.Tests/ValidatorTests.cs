using System;
using NUnit.Framework;

namespace PasswordValidator.Tests
{
    [TestFixture]
    public class ValidatorTests
    {
        //-----------------------------------------------------------------------------------------------------Iteration 1: first failing test
        //We're writing a test with a password that conforms to the validation rules, so after implementation this should always be valid.

        //[Test]
        //public void TestMethod1()
        //{
        //    var pw = "helloTDD1234";
        //    bool valid = Validator.Validate(pw);
        //    Assert.IsTrue(valid);
        //}



        //---------------------------------------------------------------------------------------------------------Iteration 2: Asserting password has correct length
        //Next step is to add a test case for password length. After refactoring the tests looks like this.

        //[Test]
        //public void CanValidatePassword()
        //{
        //    var pw = "helloTDD1234";
        //    bool valid = Validator.Validate(pw);
        //    Assert.IsTrue(valid);
        //}


        //[Test]
        //public void CanVerifyPasswordLength()
        //{
        //    var pw = "Sh0rt";
        //    bool valid = Validator.Validate(pw);
        //    Assert.IsFalse(valid);
        //}



        //---------------------------------------------------------------------------------------------------------Iteration 3: Asserting password contains capital characters
        //We add another test case, this time to check that the password contains capital characters. 

        //string goodPassword = "helloTDD1234";
        //string shortPassword = "Sh0rt";
        //string noCapitalLetter = "hellotdd1234";

        //[Test]
        //public void CanValidatePassword()
        //{
        //    bool valid = Validator.Validate(goodPassword);
        //    Assert.IsTrue(valid);
        //}

        //[Test]
        //public void CanVerifyPasswordLength()
        //{
        //    bool valid = Validator.Validate(shortPassword);
        //    Assert.IsFalse(valid);
        //}

        //[Test]
        //public void CanVerifyCapitalLetters()
        //{
        //    bool valid = Validator.Validate(noCapitalLetter);
        //    Assert.IsFalse(valid);
        //}


        //---------------------------------------------------------------------------------------------------------Iteration 4: Asserting password contains numbers
        //We add another test case, this time to check that the password contains capital characters. We also realize that all the tests look very similar so we refactor them to avoid the duplicated code.

        string goodPassword = "helloTDD1234";
        string shortPassword = "Sh0rt";
        string noCapitalLetter = "hellotdd1234";
        string noNumbers = "helloTDD";

        [Test]
        public void CanValidatePassword()
        {
            TestPasswordValidation(goodPassword, true);
        }

        [Test]
        public void CanVerifyPasswordLength()
        {
            TestPasswordValidation(shortPassword, false);
        }

        [Test]
        public void CanVerifyCapitalLetters()
        {
            TestPasswordValidation(noCapitalLetter, false);
        }

        [Test]
        public void CanVerifyContainsNumbers()
        {
            TestPasswordValidation(noNumbers, false);
        }

        private void TestPasswordValidation(string pw, bool expextedOutcome)
        {
            var isValid = Validator.Validate(pw);
            Assert.AreEqual(expextedOutcome, isValid);
        }


        //---------------------------------------------------------------------------------------------------------Iteration 5: Refactoring of Validator.cs
        //Now we dont need any more tests, but the if-statement in the Validator class is kind of ugly. So we refactor it into a regex instead. 
        //This shows that when we have a good test suite for our class we can safely change the implementation of it, 
        /and if the tests still passes we can be confident that is still works
    }
}
