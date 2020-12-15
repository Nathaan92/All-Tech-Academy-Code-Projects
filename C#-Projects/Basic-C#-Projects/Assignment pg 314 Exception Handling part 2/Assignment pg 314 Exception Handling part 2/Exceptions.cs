using System;


namespace Assignment_pg_314_Exception_Handling_part_2
{
    class Exceptions
    {
        public class negative:Exception
        {
            public negative()
                : base() { }
            public negative(string message)
                : base(message) { }
        }
        public class tooYoung:Exception
        {
            public tooYoung()
                : base() { }
            public tooYoung(string message)
                : base(message) { }
        }
    }
}
