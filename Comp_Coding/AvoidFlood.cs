using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    /* author : Abhigyan Sinha
     * Description : This is the solution to the problem given in Groove Coding Challenge.
     * Method : groove_problem takes in an integer type array as an arguement and return an integer type array as the answer.
     * To execute this file in the editor - You need to create an instance of the class Groove_CodingChallenge and make a call to the function groove_problem
     * using that instance. 
     */
    class AvoidFlood
    {
        public int[] groove_problem(int[] input_array)
        {
            int[] result_array = new int[input_array.Length]; // Array For storing the result

            List<int> index_of_dry_days = new List<int>();

            Dictionary<int, int> map_rainy_days = new Dictionary<int, int>(); // Dictionary to store the lake values as Key and the indices as values

            for (int i = 0; i < input_array.Length; i++)
            {
                int current_lake_value = input_array[i]; //Get the current lake value in the input array ( will be either 0 or any integer > 0)

                if (current_lake_value != 0)  // This means a lake is going to be filled and tha value of the lake is input_array[i]
                {
                    if (map_rainy_days.ContainsKey(current_lake_value)) // If we have already seen that lake before it means it has been filled before and might cause flood.
                    {
                        int index = map_rainy_days[current_lake_value];  // Get the index of the filled lake as previously seen in input_array.
                        int change_index = int.MinValue; // Setting a flag.
                        foreach (int j in index_of_dry_days) // Checking if there exists a dry day after the lake got filled and before it rains again to lead to flood.
                        {
                            if (j > index)  //Checking for the index
                            {
                                change_index = j;  //Set the value of that flag to the index which we found. It's the very next greater index which we are looking for.
                                break;
                            }
                        }

                        if (change_index >= 0) // This means a valid index has been found and we have a dry day present in between
                        {
                            result_array[change_index] = current_lake_value;  // Set the value of the lake to be dried on the dry day index found earlier.
                            index_of_dry_days.Remove(change_index); // Remove the dry day index from the Linked List as it has been utilized.
                        }
                        else
                        {
                            return new int[0];  // This means there doesn't exist a dry day in between and therefore flood is inevitable.
                        }
                    }
                    map_rainy_days[current_lake_value] = i;  // Will add the current_lake_value if not seen before and will change its value to index i if already seen before.
                    result_array[i] = -1; // Set the result_Array to -1 as it's a rainy day.
                    
                }
                else
                {
                    index_of_dry_days.Add(i); // Add the index of dry day to the Linked List.
                    result_array[i] = 1; // Set a temporary value.
                }
            }
            return result_array; // return the answer.
        }
    }
}
