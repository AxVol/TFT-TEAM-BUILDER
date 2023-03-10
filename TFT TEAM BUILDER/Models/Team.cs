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

        public Team()
        {
            teamItems = new ObservableCollection<Items>();

            slot0 = new ObservableCollection<Champions>();
            slot1 = new ObservableCollection<Champions>();
            slot2 = new ObservableCollection<Champions>();
            slot3 = new ObservableCollection<Champions>();
            slot4 = new ObservableCollection<Champions>();
            slot5 = new ObservableCollection<Champions>();
            slot6 = new ObservableCollection<Champions>();
            slot7 = new ObservableCollection<Champions>();
            slot8 = new ObservableCollection<Champions>();
            slot9 = new ObservableCollection<Champions>();
            slot10 = new ObservableCollection<Champions>();
            slot11 = new ObservableCollection<Champions>();
            slot12 = new ObservableCollection<Champions>();
            slot13 = new ObservableCollection<Champions>();
            slot14 = new ObservableCollection<Champions>();
            slot15 = new ObservableCollection<Champions>();
            slot16 = new ObservableCollection<Champions>();
            slot17 = new ObservableCollection<Champions>();
            slot18 = new ObservableCollection<Champions>();
            slot19 = new ObservableCollection<Champions>();
            slot20 = new ObservableCollection<Champions>();
            slot21 = new ObservableCollection<Champions>();
            slot22 = new ObservableCollection<Champions>();
            slot23 = new ObservableCollection<Champions>();
            slot24 = new ObservableCollection<Champions>();
            slot25 = new ObservableCollection<Champions>();
            slot26 = new ObservableCollection<Champions>();
            slot27 = new ObservableCollection<Champions>();
    }

        public void Serealize()
        {
            File.WriteAllText($"Content/myBuilds/{this.name}.json", JsonConvert.SerializeObject(this));   
        }
    }
}
