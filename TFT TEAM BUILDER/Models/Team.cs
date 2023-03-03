using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;

namespace TFT_TEAM_BUILDER.Models
{
    class Team
    {
        public string name { get; set; }
        public ObservableCollection<Champions> previewTeam { get; set; }
        public ObservableCollection<Traits> teamTraits { get; set; }
        public ObservableCollection<Items> teamItems { get; set; }
        public ObservableCollection<Champions> slot0 { get; set; }
        public ObservableCollection<Champions> slot1 { get; set; }
        public ObservableCollection<Champions> slot2 { get; set; }
        public ObservableCollection<Champions> slot3 { get; set; }
        public ObservableCollection<Champions> slot4 { get; set; }
        public ObservableCollection<Champions> slot5 { get; set; }
        public ObservableCollection<Champions> slot6 { get; set; }
        public ObservableCollection<Champions> slot7 { get; set; }
        public ObservableCollection<Champions> slot8 { get; set; }
        public ObservableCollection<Champions> slot9 { get; set; }
        public ObservableCollection<Champions> slot10 { get; set; }
        public ObservableCollection<Champions> slot11 { get; set; }
        public ObservableCollection<Champions> slot12 { get; set; }
        public ObservableCollection<Champions> slot13 { get; set; }
        public ObservableCollection<Champions> slot14 { get; set; }
        public ObservableCollection<Champions> slot15 { get; set; }
        public ObservableCollection<Champions> slot16 { get; set; }
        public ObservableCollection<Champions> slot17 { get; set; }
        public ObservableCollection<Champions> slot18 { get; set; }
        public ObservableCollection<Champions> slot19 { get; set; }
        public ObservableCollection<Champions> slot20 { get; set; }
        public ObservableCollection<Champions> slot21 { get; set; }
        public ObservableCollection<Champions> slot22 { get; set; }
        public ObservableCollection<Champions> slot23 { get; set; }
        public ObservableCollection<Champions> slot24 { get; set; }
        public ObservableCollection<Champions> slot25 { get; set; }
        public ObservableCollection<Champions> slot26 { get; set; }
        public ObservableCollection<Champions> slot27 { get; set; }

        public Team(string name, ObservableCollection<Champions> previewTeam, ObservableCollection<Traits> teamTraits, ObservableCollection<Items> teamItems, ObservableCollection<Champions> slot0, ObservableCollection<Champions> slot1, ObservableCollection<Champions> slot2, ObservableCollection<Champions> slot3, ObservableCollection<Champions> slot4, ObservableCollection<Champions> slot5, ObservableCollection<Champions> slot6, ObservableCollection<Champions> slot7, ObservableCollection<Champions> slot8, ObservableCollection<Champions> slot9, ObservableCollection<Champions> slot10, ObservableCollection<Champions> slot11, ObservableCollection<Champions> slot12, ObservableCollection<Champions> slot13, ObservableCollection<Champions> slot14, ObservableCollection<Champions> slot15, ObservableCollection<Champions> slot16, ObservableCollection<Champions> slot17, ObservableCollection<Champions> slot18, ObservableCollection<Champions> slot19, ObservableCollection<Champions> slot20, ObservableCollection<Champions> slot21, ObservableCollection<Champions> slot22, ObservableCollection<Champions> slot23, ObservableCollection<Champions> slot24, ObservableCollection<Champions> slot25, ObservableCollection<Champions> slot26, ObservableCollection<Champions> slot27)
        {
            this.name = name;
            this.previewTeam = previewTeam;
            this.teamTraits = teamTraits;
            this.teamItems = teamItems;
            this.slot0 = slot0;
            this.slot1 = slot1;
            this.slot2 = slot2;
            this.slot3 = slot3;
            this.slot4 = slot4;
            this.slot5 = slot5;
            this.slot6 = slot6;
            this.slot7 = slot7;
            this.slot8 = slot8;
            this.slot9 = slot9;
            this.slot10 = slot10;
            this.slot11 = slot11;
            this.slot12 = slot12;
            this.slot13 = slot13;
            this.slot14 = slot14;
            this.slot15 = slot15;
            this.slot16 = slot16;
            this.slot17 = slot17;
            this.slot18 = slot18;
            this.slot19 = slot19;
            this.slot20 = slot20;
            this.slot21 = slot21;
            this.slot22 = slot22;
            this.slot23 = slot23;
            this.slot24 = slot24;
            this.slot25 = slot25;
            this.slot26 = slot26;
            this.slot27 = slot27;
        }

        public void Serealize()
        {
            File.WriteAllText($"Content/myBuilds/{this.name}.json", JsonConvert.SerializeObject(this));   
        }
    }
}
