using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using addressbook_web_tests;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactsCreationTests : TestBase
    {
       

        [Test]
        public void ContactsCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToContactsPage();
            ContactsData contacts = new ContactsData("roman", "romashkin");
            FillContactsForm(contacts);
            SubmitContactsCreation();
            ReturnToContactsPage();
        }

       
        }
    }


       

       