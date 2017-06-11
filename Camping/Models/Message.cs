using System;

namespace Camping
{
	public class Message
	{
		public User From {
			get;
			set;
		}

        public int Id_description {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public string Title {
			get;
			set;
		}

		public string Body {
			get;
			set;
		}

		public bool HasAttachment {
			get;
			set;
		}

		public uint ThreadCount {
			get;
			set;
		}

		public string When {
			get;
			set;
		}

		public Boolean IsStared {
			get;
			set;
		}

		public Boolean IsRead {
			get;
			set;
		}

		public Message (
			User from, 
            int id_description,
            int id,
			uint threadCount, 
			bool hasAttachment,
			string when,
			string title, 
			string body, 
			Boolean isStared,
			Boolean isRead)
		{
			From 			= from;
            Id_description  = id_description;
            Id = id;
            ThreadCount 	= threadCount;
			HasAttachment 	= hasAttachment;
			When 			= when;
			Title			= title;
			Body 			= body;
			IsStared	 	= isStared;
			IsRead	 		= isRead;
		}
	}
}