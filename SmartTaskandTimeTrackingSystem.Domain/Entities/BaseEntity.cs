﻿using SmartTaskandTimeTrackingSystem.Domain.Enums;

namespace SmartTaskandTimeTrackingSystem.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
       
    }
}
