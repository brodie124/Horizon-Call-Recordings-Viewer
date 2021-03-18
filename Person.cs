namespace Horizon_Call_Recordings_Viewer {
    public class Person {
        public string FirstName;

        public string LastName;

        public string PhoneNo;


        public Person(string firstName, string lastName, string phoneNo) {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNo = phoneNo;
        }


        protected bool Equals(Person other) {
            return FirstName == other.FirstName && LastName == other.LastName && PhoneNo == other.PhoneNo;
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Person) obj);
        }

        public override int GetHashCode() {
            unchecked {
                var hashCode = (FirstName != null ? FirstName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (LastName != null ? LastName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PhoneNo != null ? PhoneNo.GetHashCode() : 0);
                return hashCode;
            }
        }

        public override string ToString() {
            return $"{this.LastName}, {this.FirstName} - {this.PhoneNo}";
        }
    }
}