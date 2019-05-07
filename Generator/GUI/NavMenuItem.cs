using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Windows;
using System.Collections.ObjectModel;
using System.Collections;
using System;
namespace Generator.GUI
{
    public class NavMenuItem : DependencyObject, INotifyPropertyChanged, ISmartNavItemContext, ICloneable
    {
        private bool __IsSelected;
        private bool __IsExpanded;
        private ObservableCollection<NavMenuItem> __Submenus;

        private string __SynonymSource;

        /// <summary>
        /// С помощью этого поля делается фильтрация Submenus в дереве на главной форме.
        /// </summary>
        private IEnumerable __FilteredItemSource;

        public event PropertyChangedEventHandler PropertyChanged;

        public NavMenuItem()
        {
            __Submenus = new ObservableCollection<NavMenuItem>();
            __FilteredItemSource = __Submenus.ToArray();
        }


        #region Public Properties

        public List<string> Synonyms { get; private set; }

        public string SynonymSource
        {
            get => __SynonymSource;
            set
            {
                __SynonymSource = value;
                Synonyms = __SynonymSource
                    .Replace(" ", "")
                    .ToLower()
                    .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
        }

        public string Level
        {
            get;
            set;
        }

        public bool IsRoot => Level == "Top";

        public FeatureGroup FeatureGroup { get; set; }

        public bool IsExpanded
        {
            get => __IsExpanded;
            set
            {
                __IsExpanded = value;
                OnPropertyChanged();
            }
        }


        public bool IsSelected
        {
            get => __IsSelected;

            set
            {
                __IsSelected = value;
                OnPropertyChanged();
            }
        }

        public bool IsForInactiveGroup { get; set; }

        public bool IsItemActive =>
            !IsRoot ||
            (FeatureGroup.IsGroupActive() && !IsForInactiveGroup
             || !FeatureGroup.IsGroupActive() && (IsForInactiveGroup || !IsForInactiveGroup && Submenus.Count == 0));

        public string Tag { get; set; }

        public string Header { get; set; }

        public bool UnavailableForFile { get; set; }

        public ObservableCollection<NavMenuItem> Submenus
        {
            get => __Submenus;
            set
            {
                __Submenus = value;
                __FilteredItemSource = value.ToArray();
            }
        }

        public IEnumerable FilteredItemSource
        {
            get => __FilteredItemSource;
            set => __FilteredItemSource = value;
        }

        public int SubmenuCount => __Submenus.Count;

        #region ISmartNavItemContext Members

        public bool HandleSelectionChanged
        {
            get;
            set;
        }

        #endregion

        #endregion

        #region Private Methods

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Public Methods

        public object Clone()
        {
            var childs = new ObservableCollection<NavMenuItem>();

            foreach (var item in Submenus)
                childs.Add((NavMenuItem)item.Clone());

            var clone = (NavMenuItem)MemberwiseClone();
            clone.Submenus = childs;

            return clone;
        }       

        #endregion
    }
}
