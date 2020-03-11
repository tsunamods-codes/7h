﻿using SeventhHeavenUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhHeaven.Classes
{
    public enum StringKey
    {
        Play,
        PlayWithMods,
        StartedClickHereToViewAppLog,
        HintLabel,
        CheckingForUpdates,
        ModRequiresModsIsMissingWarning,
        UnsupportedModVersionsWarning,
        ThisModRequiresYouActivateFollowingMods,
        ModRequiresYouDeactivateTheFollowingMods,
        CannotActivateModBecauseItIsIncompatibleWithOtherMod,
        CannotActivateModBecauseDependentIsIncompatible,
        SelectAll,
        Unknown,
        UpdateAvailable,
        UpdateDownloading,
        NoUpdates,
        UpdatesIgnored,
        AutoUpdate,
        FollowingErrorsFoundInConfiguration,
        ErrorsFoundInGeneralSettingsViewAppLog,
        AppUpdateIsAvailableMessage,
        NewVersionAvailable,
        ThisModContainsDataThatCouldHarm,
        CannotOpenHelp,
        SubscriptionIsAlreadyAdded,
        AddedToSubscriptions,
        IrosLinkMayBeFormatedIncorrectly,
        FailedToSetBackgroundImageFromTheme,
        AllowModToRun,
        ThisModAlsoRequiresYouDownloadTheFollowing,
        ThisModRequiresTheFollowingButCouldNotBeFoundInCatalog,
        PauseResumeSelectedDownload,
        PauseSelectedDownload,
        ResumeSelectedDownload,
        NoResultsFound,
        CheckingSubscription,
        CheckingCatalog,
        UpdatedCatalogFrom,
        FailedToLoadSubscription,
        CatalogDownloadFailed,
        Resuming,
        Paused,
        Canceled,
        Warning,
        IsAlreadyDownloading,
        IsAlreadyUpdating,
        IsAlreadyDownloadedAndInstalled,
        Requirements,
        Failed,
        NoLinksFor,
        FailedToParseLinkFor,
        ExternalDownload,
        OpeningExternalUrlInBrowserFor,
        ErrorDownloading,
        WasCanceled,
        Error,
        ExternalUrlDownloadMessage1,
        ExternalUrlDownloadMessage2,
        Starting,
        Pending,
        SwitchingToBackupUrl,
        Downloading,
        Installing,
        PathToFlevelRequired,
        MissingPath,
        PathToOutputFolderRequired,
        SelectTheSectionsToExtract,
        FlevelFileDoesNotExistAtGivenPath,
        OutputFolderDoesNotExist,
        Complete,
        FailedToExtractTheErrorHasBeenLogged,
        ExtractComplete,
        ConfigureMod,
        ThisOptionCannotBeChangedDueToCompatibility,
        TheFollowingValuesHaveBeenRemovedDueToCompatibility,
        FailedToPlayPreviewAudio,
        DownloadingPreviewImage,
        InsertAndClickImport,
        GameLauncherSettingsUpdated,
        FailedToSaveLaunchSettings,
        ErrorCopyingFf7InputCfg,
        NoFf7InputCfgFoundAt,
        AlreadyExistsAt,
        ChoosingAnyOtherOptionBesidesCustom7HGameDriver,
        ReunionWarningMessage,
        YouShouldLeaveThisSettingOn,
        ProgramToRunNotFound,
        ImportMissingMoviesWarningMessage,
        LookingFor,
        InsertToContinue,
        PleaseInsertToContinueCopying,
        InsertDisc,
        FoundDiscAt,
        Overwriting,
        Copying,
        FailedToFindAt,
        AnErrorOccurredCopyingMovies,
        SuccessfullyCopiedMovies,
        FinishedCopyingMoviesSomeFailed,
        SaveControlConfiguration,
        ImportCurrentControlsFromGameAndSaveAs,
        SaveError,
        ControlNameIsEmpty,
        ControlNameContainsInvalidChars,
        ControlsWithThatNameAlreadyExist,
        SuccessfullyCreatedCustomControls,
        FailedToCreateCustomControls,
        SuccessfullyDeletedCustomControls,
        FailedToDeleteCustomControls,
        EnterNameForCatalog,
        GeneralSettingsHaveBeenUpdated,
        SettingsNotValid,
        MissingFf7ExePath,
        MissingLibraryPath,
        MissingTexturesPath,
        MissingMoviePath,
        FailedToRegisterIroModFilesWith7thHeaven,
        FailedToUnregisterIroModFilesWith7thHeaven,
        FailedToUnregisterIrosLinksWith7thHeaven,
        FailedToRegisterIrosLinksWith7thHeaven,
        FailedToCreate7thHeavenContextMenuEntries,
        FailedToRemove7thHeavenContextMenuEntries,
        CatalogNameWillAutoResolveOnSave,
        ResolvingCatalogName,
        UrlMustBeInIrosFormat,
        ResolvingCatalogNameFor,
        SelectAnIroFileToImport,
        SelectAFolderThatContainsModFiles,
        SelectAFolderThatContainsIroModFilesAndFolders,
        ImportingModsPleaseWait,
        ValidationError,
        ImportError,
        EnterPathToAnIroFile,
        IroFileDoesNotExist,
        SuccessfullyImported,
        CanNotImportMod,
        FailedToImportModTheErrorHasBeenLogged,
        EnterPathToFolderContainingModFiles,
        DirectoryDoesNotExist,
        EnterPathToFolderContainingIroFilesOrModFolders,
        GeneratingLinks,
        FailedToGenerateLinks,
        EnterMegaFolderIdToGenerateLinks,
        NoLinksFoundInFolder,
        MissingRequirements,
        UnsupportedVersion,
        MissingRequiredActiveMods,
        DeactivateModsWarning,
        Uninstalled,
        CanNotReOrderModItHasBeenRemoved,
        CanNotConfigureModItHasBeenRemoved,
        CanNotConfigureModFailedToReadModXml,
        ThereAreNoOptionsToConfigureForThisMod,
        NoOptions,
        NewVersionOfModAvailable,

    }

    public static class ResourceHelper
    {
        public static string GetString(StringKey key)
        {
            try
            {
                return App.Current.Resources[key.ToString()].ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}