using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2009M.Entity
{
   public class Student
    {
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Gender { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime updateAt { get; set; }
        public int Status { get; set; }

        public override string ToString()
        {
            return $"RoollNumber{ RollNumber} ,FullName{ FullName},Email{Email},Dob{Dob},Phone{Phone},Address{Address},Gender{Gender},CreateAt{CreateAt},UpdateAt{updateAt},Status{Status}";
        }
    }
}
