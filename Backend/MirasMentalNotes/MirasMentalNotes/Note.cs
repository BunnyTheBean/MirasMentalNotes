﻿namespace MirasMentalNotes
{
    public class Note
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Content { get; set; }
        public string? SecretContent { get; set; }
        public List<string> Tags { get; set; } = new();
    }
}
