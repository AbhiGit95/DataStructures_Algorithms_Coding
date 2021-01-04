using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class UndergroundSystem
    {
        Dictionary<string, Dictionary<string,double[]>> stations;
        Dictionary<int, (string, int)> check_in;
        public UndergroundSystem()
        {
            stations = new Dictionary<string, Dictionary<string, double[]>>();
            check_in = new Dictionary<int, (string, int)>(); 
        }

        public void CheckIn(int id, string stationName, int t)
        {
            //Add the id of the person to check_in and corresponding check in station and station time.
            check_in.Add(id, (stationName, t));
        }

        public void CheckOut(int id, string stationName, int t)
        {
            //Check if Person is already checked in
            if(check_in.ContainsKey(id))
            {
                //check if the source station is already registerd once
                if(stations.ContainsKey(check_in[id].Item1))
                {
                    //check if for the corresponding source station we already have an entry for the destination station.
                    if(stations[check_in[id].Item1].ContainsKey(stationName))
                    {
                        double time = (double)t - check_in[id].Item2; // get time difference : check_out - check_in.
                        double count = stations[check_in[id].Item1][stationName][1]; // count of the no. of journey between source - destination till now.
                        double new_avg = ((stations[check_in[id].Item1][stationName][0] * count) + time) / (count + 1); // calculate the average...now count += 1;
                        //set the updated values;
                        stations[check_in[id].Item1][stationName][1] = count + 1; 
                        stations[check_in[id].Item1][stationName][0] = new_avg;
                    }

                    else
                    {
                        //If the corresponding destination station is not present with source station then add it with proper values.
                        double time = (double)t - check_in[id].Item2; // time difference between the journey.
                        stations[check_in[id].Item1].Add(stationName, new double[] { time, 1 }); 
                    }
                }
                else
                {
                    //If source station is not registered then register it along with the destination station with proper values.
                    double[] temp = new double[2]; 
                    temp[1] = 1; //count of number of journeys between source and destination.
                    temp[0] = (double)t - check_in[id].Item2;
                    Dictionary<string, double[]> temp_map = new Dictionary<string, double[]>();
                    temp_map.Add(stationName, temp);
                    stations.Add(check_in[id].Item1, temp_map);
                }
                check_in.Remove(id);
            }
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            return stations[startStation][endStation][0];
        }
    }
}
