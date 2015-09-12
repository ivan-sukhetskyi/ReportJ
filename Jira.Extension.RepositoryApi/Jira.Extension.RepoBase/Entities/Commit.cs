﻿using System;

namespace Jira.Extension.RepoBase.Entities
{
    public class Commit
    {
        public string Author { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
