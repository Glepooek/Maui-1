﻿using CommunityToolkit.Maui.Sample.Behaviors;
using CommunityToolkit.Maui.Sample.Converters;
using CommunityToolkit.Maui.Sample.Effects;
using CommunityToolkit.Maui.Sample.Extensions;
using CommunityToolkit.Maui.Sample.Models;
using CommunityToolkit.Maui.Sample.ViewModels.Base;
using CommunityToolkit.Maui.Sample.Views;
using Microsoft.Maui.Graphics;
using System.Collections.Generic;

namespace CommunityToolkit.Maui.Sample.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        public IEnumerable<SectionModel> Items { get; } = new List<SectionModel>
        {
            new SectionModel(typeof(BehaviorsGalleryPage), "Behaviors", Color.FromArgb("#8E8CD8"),
                "Behaviors lets you add functionality to user interface controls without having to subclass them. Behaviors are written in code and added to controls in XAML or code"),

            new SectionModel(typeof(ConvertersGalleryPage), "Converters", Color.FromArgb("#EA005E"),
                "Converters let you convert bindings of a certain type to a different value, based on custom logic"),

            new SectionModel(typeof(EffectsGalleryPage), "Effects", Color.FromArgb("#EFB950"),
                "Effects are used to add visual customization on a control by control bases"),

            new SectionModel(typeof(ExtensionsGalleryPage), "Extensions", Color.FromArgb("#00CC6A"),
                "Extensions are used to supplement existing functionalities by making them easier to use"),

            new SectionModel(typeof(ViewsGalleryPage), "Views", Color.FromArgb("#EF6950"),
                "A custom view or control allows for adding custom functionality as if it came out of the Xamarin.Forms box")
        };
    }
}