

using Business.Concrete;
using Entities.Concrete;



Person person1 = new Person();
person1.FirstName = "Mehmet Kayra";
person1.LastName = "Akın";
person1.DateOfBirthYear = 1999;
person1.NationalIdentity = 123;



PttManager pttManager = new PttManager( new PersonManager());
pttManager.GiveMask(person1);
