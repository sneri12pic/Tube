using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tube
{
    class Underground
    {
        private List<Station> stationList = new List<Station>();
        public List<Station> StationList
        {
            get { return stationList; }
            set { stationList = value; }
        }

        public void AddStation(Station newStation)
        {
            stationList.Add(newStation);
        }
        public void AddStation(string ID, string Name, int Zone)
        {
            Station newStation = new Station();
            newStation.ID = ID;
            newStation.Name = Name;
            newStation.Zone = Zone;
            stationList.Add(newStation);
        }
        public Station find(string id_Station)
        {
            foreach (Station station in stationList)
            {
                // Use of StringComparison.OrdinalIgnoreCase ensures that the comparison is not sensitive to the case of the characters
                if (string.Equals(id_Station, station.ID, StringComparison.OrdinalIgnoreCase))
                {
                    return station;
                }
            }
            return null;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Station station in stationList)
            {
                sb.AppendLine("----------------------");
                sb.AppendLine($"ID: {station.ID}");
                sb.AppendLine($"Name: {station.Name}");
                sb.AppendLine($"Zone: {station.Zone}");
                sb.AppendLine("----------------------");
            }
            return sb.ToString();
        }
    }

    public class UndergroundFacade
    {
        private Underground underground = new Underground();

        public void AddStation(Station newStation)
        {
            underground.AddStation(newStation);
        }
        public void AddStation(string ID, string Name, int Zone)
        {
            underground.AddStation(ID, Name, Zone);
        }

        public Station find(string id_Station)
        {
            return underground.find(id_Station);
        }
        public string GetStationList()
        {
            return underground.ToString();
        }
    }
}
