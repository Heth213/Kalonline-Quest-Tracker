using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Kal_Quests_Tracker.Models
{
    public class CharacterProfile
    {
        [JsonProperty("CharacterName")]
        public string CharacterName { get; set; }

        [JsonProperty("CompletedQuests")]
        public HashSet<string> CompletedQuests { get; set; }

        [JsonProperty("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("LastModified")]
        public DateTime LastModified { get; set; }

        public CharacterProfile()
        {
            CompletedQuests = new HashSet<string>();
            CreatedDate = DateTime.Now;
            LastModified = DateTime.Now;
        }

        public CharacterProfile(string characterName) : this()
        {
            CharacterName = characterName;
        }

        public void MarkQuestCompleted(string questKey)
        {
            CompletedQuests.Add(questKey);
            LastModified = DateTime.Now;
        }

        public void MarkQuestIncomplete(string questKey)
        {
            CompletedQuests.Remove(questKey);
            LastModified = DateTime.Now;
        }

        public bool IsQuestCompleted(string questKey)
        {
            return CompletedQuests.Contains(questKey);
        }

        public string GetQuestKey(Quest quest)
        {
            return quest.Type + "_" + quest.QuestIdString + "_" + quest.Level;
        }
    }
}
