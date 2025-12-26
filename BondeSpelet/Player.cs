using System;
using System.Collections.Generic;
using System.Text;

namespace BondeSpelet
{
    public class Player
    {
        public string Name { get; set; }
        public int FarmLevel { get; set; }
        public int Balance { get; set; }
        public int InsuranceLevel { get; set; }
        public int ForestAmmount {  get; set; }
        public int ForestValue { get; set; }
        public int AnimalAmmount { get; set; }
        public int BoardSpot { get; set; }
        public bool IsCPU { get; set; }

        public Player(string name, bool isCpu, int farmLevel = 1, int balance = 200000, int insuranceLevel = 1, int forestAmmount = 0, int forestValue = 0, int animalAmmount = 0, int boardspot = 0)
        {
            this.Name = name;
            this.IsCPU = isCpu;
        } 

        void CreateRealPlayer()
        {

        }

        void CreateCpuPlayer()
        {

        }
    }
}
