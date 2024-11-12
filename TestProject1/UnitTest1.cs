using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void PasswordLessThan8CharachtersLong_ReturnsFalse()
        {
           string password = "aA1_";
           Assert.That(PasswordValidator.ValidatePassword(password), Is.False);
        }

        [Test]
        public void PasswordMoreThan127CharachtersLong_ReturnsFalse()
        {
            string password = string.Concat(Enumerable.Repeat("mn", 127 / 2)) + "1_";
            Assert.That(PasswordValidator.ValidatePassword(password), Is.False);
        }

        [Test]
        public void PasswordWithoutUpperCase_ReturnsFalse()
        {
            string password = "asdfasdf1_";
            Assert.That(PasswordValidator.ValidatePassword(password), Is.False);            
            password = "12345657_";
            Assert.That(PasswordValidator.ValidatePassword(password), Is.False);
        }

        [Test]
        public void PasswordWithoutLowerCase_ReturnsFalse()
        {
            string password = "ASDFASDF1_";
            Assert.That(PasswordValidator.ValidatePassword(password), Is.False);           
            password = "1234567_";
            Assert.That(PasswordValidator.ValidatePassword(password), Is.False);
        }

        [Test]
        public void PasswordWithoutDigit_ReturnsFalse()
        {
            string password = "asdfASDF_";
            Assert.That(PasswordValidator.ValidatePassword(password), Is.False);
        }

        [Test]
        public void PasswordWithoutSpecialCharacter_ReturnsFalse()
        {
            string password = "asdfASDF1";
            Assert.That(PasswordValidator.ValidatePassword(password), Is.False);
        }

        [Test]
        public void PasswordWithRepeatingCharacters_ReturnsFalse()
        {
            string password = "asdfASDF1___";
            Assert.That(PasswordValidator.ValidatePassword(password), Is.False);

        }

        [Test]
        public void ValidPassword_ReturnsTrue()
        {
            string password = "asdfASDF1|";
            Assert.That(PasswordValidator.ValidatePassword(password), Is.True);
        }

    }
}