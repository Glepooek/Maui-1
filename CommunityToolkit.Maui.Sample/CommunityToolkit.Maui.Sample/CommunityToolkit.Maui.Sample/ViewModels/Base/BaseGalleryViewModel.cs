﻿using CommunityToolkit.Maui.Sample.Models;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace CommunityToolkit.Maui.Sample.ViewModels.Base
{
    public abstract class BaseGalleryViewModel : BaseViewModel
	{
		ICommand filterCommand;

		public BaseGalleryViewModel() => Filter();

		public abstract IEnumerable<SectionModel> Items { get; }

		public IEnumerable<SectionModel> FilteredItems { get; private set; }

		public ICommand FilterCommand => filterCommand ??= new Command(Filter);

		public string FilterValue { private get; set; }

		void Filter()
		{
			FilterValue ??= string.Empty;
			FilteredItems = Items.Where(item => item.Title.IndexOf(FilterValue, StringComparison.InvariantCultureIgnoreCase) >= 0);
			OnPropertyChanged(nameof(FilteredItems));
		}
	}
}