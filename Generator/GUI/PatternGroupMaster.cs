using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;

namespace Generator.GUI
{
    internal static class FeatureMaster
    {
        #region Fields

        private static readonly ReadOnlyCollection<EditionFeature> __AllEditionFeatures;
        private static readonly Dictionary<FeatureGroup, IList<EditionFeature>> __MappedFeatures = new Dictionary<FeatureGroup, IList<EditionFeature>>();

        #endregion

        static FeatureMaster()
        {
            Array featureValues = Enum.GetValues(typeof(EditionFeature));
            var featureList = new List<EditionFeature>(featureValues.Length);
            featureList.AddRange(featureValues.Cast<EditionFeature>());

            __AllEditionFeatures = new ReadOnlyCollection<EditionFeature>(featureList);

            Array groupValues = Enum.GetValues(typeof(FeatureGroup));
            var groupList = new List<FeatureGroup>(groupValues.Length);
            groupList.AddRange(groupValues.Cast<FeatureGroup>());

            foreach (var featureGroup in groupList)
                __MappedFeatures[featureGroup] = GetGroupFeaturesList(featureGroup);

        }

        #region Properties

        internal static EditionFeature[] ActiveFeatures
        {
            get
            {
                var res = from m in __AllEditionFeatures
                          where Check(m) &&
                                m != EditionFeature.Base &&
                                m != EditionFeature.RomNVRam &&
                                m != EditionFeature.Scripting &&
                                m != EditionFeature.ReservedAdvancedFeature1 &&
                                m != EditionFeature.ReservedAdvancedFeature2 &&
                                m != EditionFeature.ReservedAdvancedFeature3
                          select m;

                var list = res.ToList();
                list.Sort(new FeatureSorter());

                return list.ToArray();
            }
        }

        internal static EditionFeature[] InactiveFeatures
        {
            get
            {
                var res = from m in __AllEditionFeatures
                          where !Check(m) &&
                                m != EditionFeature.Base &&
                                m != EditionFeature.RomNVRam &&
                                m != EditionFeature.Scripting &&
                                m != EditionFeature.ReservedAdvancedFeature1 &&
                                m != EditionFeature.ReservedAdvancedFeature2 &&
                                m != EditionFeature.ReservedAdvancedFeature3
                          select m;

                var list = res.ToList();
                list.Sort(new FeatureSorter());

                return list.ToArray();
            }
        }

        #endregion

        private static IList<EditionFeature> GetGroupFeaturesList(FeatureGroup featureGroup)
        {
            var featureList = new List<EditionFeature>();

            switch (featureGroup)
            {
                case FeatureGroup.Base:
                    featureList.Add(EditionFeature.Base);
                    break;

                case FeatureGroup.DeviceRecovery:
                    featureList.Add(EditionFeature.FirmwareAccess);
                    featureList.Add(EditionFeature.RomNVRam);
                    featureList.Add(EditionFeature.PasswordRecovery);
                    break;

                case FeatureGroup.DeviceUtilities:
                    featureList.Add(EditionFeature.Compare);
                    featureList.Add(EditionFeature.CompareMultiTargets);
                    featureList.Add(EditionFeature.DCO);
                    featureList.Add(EditionFeature.DiskEditor);
                    featureList.Add(EditionFeature.FillOrErase);
                    featureList.Add(EditionFeature.GenerateBadSectors);
                    featureList.Add(EditionFeature.HPA);
                    featureList.Add(EditionFeature.MediaRecovery);
                    featureList.Add(EditionFeature.SecurityFeatures);
                    featureList.Add(EditionFeature.Trim);
                    featureList.Add(EditionFeature.UnclipHpaDco);
                    featureList.Add(EditionFeature.WriteFromFile);
                    break;

                case FeatureGroup.Diagnostics:
                    featureList.Add(EditionFeature.AutomaticCheckup);
                    featureList.Add(EditionFeature.MediaScan);
                    featureList.Add(EditionFeature.Smart);
                    break;

                case FeatureGroup.FileRecovery:
                    featureList.Add(EditionFeature.FileRecoveryAll);
                    featureList.Add(EditionFeature.FileRecoveryNTFS);
                    break;

                case FeatureGroup.Imaging:
                    featureList.Add(EditionFeature.Imaging);
                    featureList.Add(EditionFeature.ImagingByHead);
                    featureList.Add(EditionFeature.ImagingCalculateHash);
                    featureList.Add(EditionFeature.ImagingFileSignatures);
                    featureList.Add(EditionFeature.ImagingHexViewer);
                    featureList.Add(EditionFeature.ImagingMultiTargets);
                    break;

                case FeatureGroup.Other:
                    featureList.Add(EditionFeature.CaseManagement);
                    featureList.Add(EditionFeature.CaseMagagementImportExport);
                    featureList.Add(EditionFeature.Oscilloscope);
                    featureList.Add(EditionFeature.Terminal);
                    featureList.Add(EditionFeature.RemoteDB);
                    featureList.Add(EditionFeature.USBSupport);

                    break;

                case FeatureGroup.Hashes:
                    featureList.Add(EditionFeature.CalculateHash);
                    featureList.Add(EditionFeature.VerifyHashes);
                    break;

                default:
                    throw new NotImplementedException(String.Format("Not mapped feature group: {0}", featureGroup));
            }

            return featureList;
        }

        #region Internal Methods       

        internal static ICollectionView GetRecentlyActivatedFeatures(IList<EditionFeature> inactiveFeatures)
        {
            var activatedFeatures = (from feature in inactiveFeatures
                                     where Check(feature)
                                     select new FeatureUIModel(feature)).ToList();

            if (activatedFeatures.Any(f => f.Feature == EditionFeature.FileRecoveryNTFS) &&
                activatedFeatures.Any(f => f.Feature == EditionFeature.FileRecoveryAll))
                activatedFeatures.Remove(activatedFeatures.First(f => f.Feature == EditionFeature.FileRecoveryNTFS));

            return GetFeaturesCollectionView(activatedFeatures);
        }

        internal static ICollectionView GetInactiveFeaturesCollectionView()
        {
            var features = (from feature in InactiveFeatures select new FeatureUIModel(feature)).ToList();

            if (features.Any(f => f.Feature == EditionFeature.FileRecoveryNTFS) && features.Any(f => f.Feature == EditionFeature.FileRecoveryAll))
                features.Remove(features.First(f => f.Feature == EditionFeature.FileRecoveryNTFS));

            return GetFeaturesCollectionView(features);
        }

        private static ICollectionView GetFeaturesCollectionView(List<FeatureUIModel> features)
        {
            var collectionView = (CollectionView)CollectionViewSource.GetDefaultView(features);

            if (collectionView != null && collectionView.CanGroup && collectionView.GroupDescriptions != null)
                collectionView.GroupDescriptions.Add(new PropertyGroupDescription("Group"));

            return collectionView;
        }

        internal static ICollectionView GetActiveFeaturesList()
        {
            return GetFeaturesCollectionView((from feature in ActiveFeatures select new FeatureUIModel(feature)).ToList());
        }

        internal static bool IsWindowsMenuActive()
        {
            return Check(EditionFeature.Terminal) || Check(EditionFeature.Oscilloscope);
        }

        internal static bool IsGroupActive(this FeatureGroup featureGroup)
        {
            if (!__MappedFeatures.ContainsKey(featureGroup))
                throw new NotImplementedException(String.Format("Not mapped feature group: {0}", featureGroup));

            return __MappedFeatures[featureGroup].Count(f => ActiveFeatures.Contains(f)) > 1;
        }


        internal static ICollectionView GetInactiveGroupFeatures(this FeatureGroup featureGroup)
        {
            if (!__MappedFeatures.ContainsKey(featureGroup))
                throw new NotImplementedException(String.Format("Not mapped feature group: {0}", featureGroup));

            var features = __MappedFeatures[featureGroup].Where(f => InactiveFeatures.Contains(f))
                                                         .Select(f => new FeatureUIModel(f))
                                                         .ToList();
            return GetFeaturesCollectionView(features);
        }

        internal static bool CheckIfMultiTargetsAvaliable()
        {
            if (Check(EditionFeature.ImagingMultiTargets))
                return true;

            AtolaBox.ShowError("Imaging_Error_MultipleTargetsUnavailable");
            return false;
        }

        #endregion
    }
}
