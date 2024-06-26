﻿
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Entities;

public class CategoryEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? CategoryName { get; set; }
}
