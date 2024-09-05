using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace zerix_trial.Pages
{
    public class InboxModel : PageModel
    {
        private readonly ILogger<InboxModel> _logger;

        public InboxModel(ILogger<InboxModel> logger)
        {
            _logger = logger;
        }

        // Define a message structure
        public class Message
        {
            public string Timestamp { get; set; }
            public string SentMethod { get; set; } // e.g., "Via SMS", "Via Email"
            public string Content { get; set; } // The actual message content
            public bool IsSent { get; set; } // To determine if it's a sent or received message
        }

        // List of messages to display
        public List<Message> Messages { get; set; } = new List<Message>();

        public void OnGet()
        {
            // Sample data for demonstration purposes
            Messages.Add(new Message { Timestamp = "1:41 AM", SentMethod = "Via SMS", Content = "We'll cover project updates, upcoming deadlines, and brainstorming ideas for the new campaign. Hope to see you all there!\n\nCheers,\nAna", IsSent = false });
            Messages.Add(new Message { Timestamp = "1:42 AM", SentMethod = "Via SMS", Content = "This is noted, Miss Ana!", IsSent = true });
            Messages.Add(new Message { Timestamp = "1:41 AM", SentMethod = "Via SMS", Content = "We'll cover project updates, upcoming deadlines, and brainstorming ideas for the new campaign. Hope to see you all there!\n\nCheers,\nAna", IsSent = false });
            Messages.Add(new Message { Timestamp = "1:42 AM", SentMethod = "Via SMS", Content = "This is noted, Miss Ana!", IsSent = true });
            Messages.Add(new Message { Timestamp = "1:41 AM", SentMethod = "Via SMS", Content = "We'll cover project updates, upcoming deadlines, and brainstorming ideas for the new campaign. Hope to see you all there!\n\nCheers,\nAna", IsSent = false });
            Messages.Add(new Message { Timestamp = "1:42 AM", SentMethod = "Via SMS", Content = "This is noted, Miss Ana!", IsSent = true });
            Messages.Add(new Message { Timestamp = "1:41 AM", SentMethod = "Via SMS", Content = "We'll cover project updates, upcoming deadlines, and brainstorming ideas for the new campaign. Hope to see you all there!\n\nCheers,\nAna", IsSent = false });
            Messages.Add(new Message { Timestamp = "1:42 AM", SentMethod = "Via SMS", Content = "This is noted, Miss Ana!", IsSent = true });
            Messages.Add(new Message { Timestamp = "1:41 AM", SentMethod = "Via SMS", Content = "We'll cover project updates, upcoming deadlines, and brainstorming ideas for the new campaign. Hope to see you all there!\n\nCheers,\nAna", IsSent = false });
            Messages.Add(new Message { Timestamp = "1:42 AM", SentMethod = "Via SMS", Content = "This is noted, Miss Ana!", IsSent = true });
            Messages.Add(new Message { Timestamp = "1:41 AM", SentMethod = "Via SMS", Content = "We'll cover project updates, upcoming deadlines, and brainstorming ideas for the new campaign. Hope to see you all there!\n\nCheers,\nAna", IsSent = false });
            Messages.Add(new Message { Timestamp = "1:42 AM", SentMethod = "Via SMS", Content = "This is noted, Miss Ana!", IsSent = true });
            Messages.Add(new Message { Timestamp = "1:41 AM", SentMethod = "Via SMS", Content = "We'll cover project updates, upcoming deadlines, and brainstorming ideas for the new campaign. Hope to see you all there!\n\nCheers,\nAna", IsSent = false });
            Messages.Add(new Message { Timestamp = "1:42 AM", SentMethod = "Via SMS", Content = "This is noted, Miss Ana!", IsSent = true });
            Messages.Add(new Message { Timestamp = "1:41 AM", SentMethod = "Via SMS", Content = "We'll cover project updates, upcoming deadlines, and brainstorming ideas for the new campaign. Hope to see you all there!\n\nCheers,\nAna", IsSent = false });
            Messages.Add(new Message { Timestamp = "1:42 AM", SentMethod = "Via SMS", Content = "This is noted, Miss Ana!", IsSent = true });
            Messages.Add(new Message { Timestamp = "1:41 AM", SentMethod = "Via SMS", Content = "We'll cover project updates, upcoming deadlines, and brainstorming ideas for the new campaign. Hope to see you all there!\n\nCheers,\nAna", IsSent = false });
            Messages.Add(new Message { Timestamp = "1:42 AM", SentMethod = "Via SMS", Content = "This is noted, Miss Ana!", IsSent = true });
            Messages.Add(new Message { Timestamp = "1:41 AM", SentMethod = "Via SMS", Content = "We'll cover project updates, upcoming deadlines, and brainstorming ideas for the new campaign. Hope to see you all there!\n\nCheers,\nAna", IsSent = false });
            Messages.Add(new Message { Timestamp = "1:42 AM", SentMethod = "Via SMS", Content = "This is noted, Miss Ana!", IsSent = true });
            // Add more sample messages as needed
        }
    }
}
