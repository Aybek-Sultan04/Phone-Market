﻿using Domain.Entity;
using Domain.States;

namespace Domain.Models;

public class Phone
{
    public int Id { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public decimal Price { get; set; }
    public Phone_Color Color { get; set; }
    public Condition Condition { get; set; }
    public byte[]? Image { get; set; }

    public int? PostId { get; set; }
    public Post? Post { get; set; }

    public IEnumerable<Favourite>? Favourites { get; set; }
}
