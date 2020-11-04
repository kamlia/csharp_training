using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using addressbook_web_tests;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactsRemovalTest : TestBase
    {
        [Test]
       
        public void ContactRemovalTest()
        {
            GoToHomePage();
            Login(new AccountData("admin","secret"));
            GoToContactsPage();
            SelectContacts(1);
            RemoveContact();
        }
    }
}
