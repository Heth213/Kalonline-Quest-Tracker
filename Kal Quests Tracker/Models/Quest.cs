using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Kal_Quests_Tracker.Models
{
    public class Quest
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("QuestId")]
        public object QuestId { get; set; }

        [JsonProperty("Level")]
        public int Level { get; set; }

        [JsonProperty("Steps")]
        public List<string> Steps { get; set; }

        [JsonProperty("Rewards")]
        public List<string> Rewards { get; set; }

        // Additional properties for tracking
        [JsonIgnore]
        public bool IsCompleted { get; set; }

        [JsonIgnore]
        public string DisplayName { get { return Type + " " + QuestId + " (Level " + Level + ")"; } }

        [JsonIgnore]
        public string QuestIdString { get { return QuestId != null ? QuestId.ToString() : ""; } }

        public Quest()
        {
            Steps = new List<string>();
            Rewards = new List<string>();
            IsCompleted = false;
        }
    }

    public class QuestData
    {
        [JsonProperty("Quests")]
        public List<Quest> Quests { get; set; }

        public QuestData()
        {
            Quests = new List<Quest>();
        }
    }
}
