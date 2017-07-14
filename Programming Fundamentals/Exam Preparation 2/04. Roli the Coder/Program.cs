using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var eventsRegex =
new Regex(@"(?<id>\d+)\s+#(?<eventName>\w+)\s*(?<participants>(?:@[a-zA-Z0-9'-]+\s*)*)");

        var events = new Dictionary<int, Event>();
        while (true)
        {
            var line = Console.ReadLine();

            if (line == "Time for Code"){break;}

            var evnt = eventsRegex.Match(line);

            if (!evnt.Success)
            {
                continue;
            }

            var id = int.Parse(evnt.Groups["id"].Value);
            var eventName = evnt.Groups["eventName"].Value;
            var participantsStr = evnt.Groups["participants"].Value;

            var participants = new List<string>();

            if (participantsStr.Length>0)
            {
                participants.AddRange(participantsStr
                    .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries));

            }

            if (!events.ContainsKey(id))
            {
                var @event = new Event
                {
                    Name = eventName,
                    Participants = participants,
                };
                events[id] = @event;
            }
            if (events[id].Name == eventName)
            {
                events[id].Participants.AddRange(participants);
            }
           
        }
        foreach (var @event in events)
        {
            @event.Value.Participants = @event.Value.Participants
                .Distinct().OrderBy(a => a).ToList();
        }
        var sortedEvents = events
            .OrderByDescending(a => a.Value.Participants.Count)
            .ThenBy(a => a.Value.Name)
            .Select(a => a.Value)
            .ToArray();

        foreach (var sortedEvent in sortedEvents)
        {
            Console.WriteLine($"{sortedEvent.Name} - {sortedEvent.Participants.Count}");
            foreach (var participant in sortedEvent.Participants)
            {
                Console.WriteLine(participant);
            }
        }
    }
}
class Event
{
    public string Name { get; set; }
    public List<string> Participants { get; set; }
}
