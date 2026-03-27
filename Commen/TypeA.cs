using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    /// What You Can Write Inside The Namesapce?
    /// enum
    /// class
    /// struct
    /// interface
    /// delegate
    /// record

    /// What You Can Write Inside The Enum?
    /// only labels => refer to number

    /// What You Can Write Inside The Class Or Struct?
    /// 1. Fields (Attributres) => variables
    /// 2. Methods => functions 
    /// 3. Constructor => special method
    /// 4. Properties
    /// 5. Events
    /// 6. Indexers => special property

    /// What You Can Write Inside The Interface?
    /// 1. Method Signature
    /// 2. Property Signature
    /// 3. Event Signature
    /// 4. Indexer Signature
    /// 5. Default Implementation (C# 8.0 +)


    /// Allowed Access Modifiers Inside The Namespace 
    /// 1. public
    /// 2. internal [Default Access Modifier] 

    //internal enum You
    //{
    //    first, 
    //    second, 
    //    third, 
    //    fourth,
    //    fifth, 
    //    sixth, 
    //    seventh
    //}

    //public enum publicYou
    //{
    //    first,
    //    second,
    //    third,
    //    fourth,
    //    fifth,
    //    sixth,
    //    seventh
    //}


    public class TypeA
    {
        //You you = You.first; // valid
        //publicYou publicYou = publicYou.first; // valid


        /// Allowed Access Modifiers Inside The class
        /// 1. private [Default]
        /// 2. private protected => inhertance
        /// 3. protected => inhertance
        /// 4. internal
        /// 5. internal protected => inhertance
        /// 6. public

        int x; // private
        internal int y; // same assembly only
        public int z; // allow for all

        void test()
        {
            x = 1;
            y = 2;
            z = 3;
        }
    }
}
