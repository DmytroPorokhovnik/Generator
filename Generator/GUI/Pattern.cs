using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.GUI
{
    public enum EditionFeature
    {
        /// <summary>
        /// Base - это любая фича, которая не входит в другие, но является частью базового Инсайта. 
        /// Соответствующий бит в хаспе просто игнорится.
        /// </summary>
        Base,
        AutomaticCheckup,
        CalculateHash,

        /// <summary>
        /// Все CaseManagement фичи кроме Export/Import
        /// </summary>
        CaseManagement,

        /// <summary>
        /// Export/Import кейсов 
        /// </summary>
        CaseMagagementImportExport, // 4
        Compare,
        DiskEditor,
        FillOrErase,

        /// <summary>
        /// Разрешает работать со всеми файловыми системами.
        /// </summary>
        FileRecoveryAll,    //8

        /// <summary>
        /// Разрешает доступиться только к NTFS. Остальные ФС - недоступны.
        /// </summary>
        FileRecoveryNTFS,
        GenerateBadSectors,
        FirmwareAccess,
        DCO,    //12
        HPA,
        Imaging,

        /// <summary>
        /// Копирование по головам
        /// </summary>
        ImagingByHead,
        ImagingCalculateHash, //16
        ImagingFileSignatures,

        /// <summary>
        /// HEX Viewer, который показывается во время копирования
        /// </summary>
        ImagingHexViewer,
        MediaRecovery,
        MediaScan,  // 20

        /// <summary>
        /// Imaging в более, чем один таргет любого типа
        /// </summary>
        ImagingMultiTargets,
        Oscilloscope,
        PasswordRecovery,

        /// <summary>
        /// Возможность работать с SQL Server базой данных, находящейся на другом компьютере
        /// </summary>
        RemoteDB, // 24
        // ReSharper disable once InconsistentNaming
        RomNVRam,
        UnclipHpaDco,

        /// <summary>
        /// Работа с USB-устройствами
        /// </summary>
        USBSupport,

        /// <summary>
        /// Скрипты из Ресайклера
        /// </summary>
        Scripting, // 28
        SecurityFeatures,
        Smart,
        Terminal,
        Trim, // 32
        WriteFromFile,

        /// <summary>
        /// Разрешает сравнение сорса с более, чем одним таргетом любого типа
        /// </summary>
        CompareMultiTargets,

        ReservedAdvancedFeature1,
        ReservedAdvancedFeature2,
        ReservedAdvancedFeature3,
        VerifyHashes
    }
}
