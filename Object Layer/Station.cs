using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Tube // coursework2_OOSD
{
    public class Station
    {
        private String _id;

        public string ID   // property
        {
            get
            {
                return _id;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("ID cannot be blank!", "ID");
                }
                _id = value;
            }
        }

        // Name of the Station creation
        private string name;
        public string Name
        {
            // Getter name
            get { return name; }
            // Setter name
            set
            {
                // Checking so the line is not blank
                if (value == "")
                {
                    throw new ArgumentException("Error Name is blank! ", "Name");

                }
                name = value;

            }
        }

        // Station Zone creation
        private int zone;
        public int Zone
        {
            get { return zone; }
            set
            {
                zone = value;
            }
        }

        //Counter started creation
        private int started;
        public int Started
        {
            get { return started; }
            set
            {
                started = value;
            }
        }

        //Counter ended creation
        private int ended;
        public int Ended
        {
            get { return ended; }
            set
            {
                ended = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------");
            sb.AppendLine($"ID: {ID}");
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Zone: {Zone}");
            sb.AppendLine("----------------------");

            return sb.ToString();
        }
    }
}
