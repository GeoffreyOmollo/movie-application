﻿using FC.Codeflix.Catalog.Domain.Enum;
using FC.Codeflix.Catalog.Domain.SeedWork;
using FC.Codeflix.Catalog.Domain.Validation;
using FC.Codeflix.Catalog.Domain.Validator;

namespace FC.Codeflix.Catalog.Domain.Entity;
public class Video : AggregateRoot
{

    public string Title { get; private set; }
    public string Description { get; private set; }
    public int YearLaunched { get; private set; }
    public bool Opened { get; private set; }
    public bool Published { get; private set; }
    public int Duration { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public Rating Rating { get; private set; }

    public Video(
        string title, 
        string description, 
        int yearLaunched, 
        bool opened, 
        bool published, 
        int duration,
        Rating rating
    )
    {
        Title = title;
        Description = description;
        YearLaunched = yearLaunched;
        Opened = opened;
        Published = published;
        Duration = duration;
        Rating = rating;
        CreatedAt = DateTime.Now;
    }

    public void Validate(ValidationHandler handler) 
        => new VideoValidator(this, handler).Validate();

    public void Update(
        string title,
        string description,
        int yearLaunched,
        bool opened,
        bool published,
        int duration
    )
    {
        Title = title;
        Description = description;
        YearLaunched = yearLaunched;
        Opened = opened;
        Published = published;
        Duration = duration;
    }
}
