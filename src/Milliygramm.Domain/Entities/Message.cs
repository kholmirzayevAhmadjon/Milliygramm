﻿using Milliygramm.Domain.Commons;

namespace Milliygramm.Domain.Entities;

public sealed class Message : Auditable
{
    public long ChatId { get; set; }
    public Chat Chat { get; set; }
    public string Text { get; set; }
    public long? ContentId { get; set; }
    public Asset Content { get; set; }
    public long SenderId { get; set; }
    public User User { get; set; }
}
