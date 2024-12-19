using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_8.@class
{
    internal class Song
    {
        private string Name;
        private string Author;
        public Song? Connect;

        public Song() { }
        public Song(string name, string author)
        {
            this.Name = name;
            this.Author = author;
            this.Connect = null;
        }
        public Song(Song connect, string name, string author)
        {
            this.Name = name;
            this.Author = author;
            this.Connect = connect;
        }
        //чтоб поменять занчение
        public void GiveName(string name)
        {
            this.Name = name;
        }
        //чтоб поменять занчение
        public void GiveAuthor(string author)
        {
            this.Author = author;
        }
        //чтоб поменять занчение
        public void GiveConnect(Song connect)
        {
            this.Connect = connect;
        }
        //    for (int i = 1; i<list.Count; i++)
        //        {
        //            list[i].GiveConnect(list[i - 1]);
        //}
        //print
        public string Title()
        {
            return $"название:{Name} автор:{Author}";
        }
        //сравнение
        public override bool Equals(object d)
        {
            if (d is Song newsong)
            {
                return (this.Title() == newsong.Title());
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Author);
        }
    }
}
