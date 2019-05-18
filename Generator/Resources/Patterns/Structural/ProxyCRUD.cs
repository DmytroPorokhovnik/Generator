using System;

//Proxy - 0
//Subject - 1
//RealSubject - 2
//Create - 3
//Read - 4
//Update - 5
//Delete - 6
namespace {0}
{
    abstract class {1}
    {
        public abstract void {3}(string key, string value);
        public abstract string {4}(string key);
        public abstract bool {5}(string key, string value);
        public abstract bool {6}(string key);
    }

    class {0} : {1}
    {
        {1} subject;
        string role;

        public {0}({1} subject, string role)
        {
            this.subject = subject;
            this.role = role;
        }

        public override void {3}(string key, string value)
        {
            if (role == "Owner")
                this.subject.{3}(key, value);
            else
                throw new UnauthorizedAccessException("{3}: Access denied.");
        }

        public override string {4}(string key)
        {
            return this.subject.{4}(key);
        }

        public override bool {5}(string key, string value)
        {
            if (role != "User")
               return this.subject.{5}(key, value);
            else
                throw new UnauthorizedAccessException("{5}: Access denied.");
        }

        public override bool {6}(string key)
        {
            if (role == "Administrator" || role == "Owner")
                return this.subject.{6}(key);
            else
                throw new UnauthorizedAccessException("{6}: Access denied.");
        }
    }

    class {2} : {1}
    {
        Dictionary<string, string> dictionary;
        public {2}()
        {
            dictionary = new Dictionary<string, string>();
            dictionary.Add("TestKey", "TestValue");
        }

        public override void {3}(string key, string value)
        {
            this.dictionary.Add(key, value);
        }

        public override string {4}(string key)
        {
            return this.dictionary[key];
        }

        public override bool {5}(string key, string value)
        {
            if (this.dictionary.ContainsKey(key) && this.dictionary.ContainsValue(value))
            {
                this.dictionary[key] = value;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool {6}(string key)
        {
            return this.dictionary.Remove(key);
        }
    }
}
