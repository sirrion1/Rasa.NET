﻿namespace Rasa.Data
{
    public enum GameOpcode
    {
        AbandonMission = 392,
        Abilities = 10,
        AbilityDrawer = 393,
        AbilityDrawerSlot = 394,
        AbortMission = 11,
        AcceptPartyInvitesChanged = 395,
        AckPing = 12,
        ActionBlockChange = 765,
        ActionFailed = 13,
        ActionInterrupt = 245,
        ActionReuseTimerRestarted = 766,
        ActionReuseTimes = 716,
        ActorControllerInfo = 14,
        ActorGotLoot = 697,
        ActorInfo = 15,
        ActorKilled = 776,
        ActorName = 16,
        AddAuctionItem = 722,
        AddBuybackItem = 396,
        AddCredits = 10000088,
        AddFriend = 6,
        AddFriendAck = 17,
        AddFriendByName = 10000057,
        AddIgnore = 8,
        AddIgnoreAck = 18,
        AddIgnoreByName = 10000056,
        AddInboxItem = 723,
        AddOverflowItem = 246,
        AddPartyMember = 19,
        AddRandomInventoryItemHack = 20,
        AddSquadMember = 21,
        AddTeamMember = 10000117,
        AddToClanWargame = 678,
        AddToLauncher = 22,
        AddToPetition = 397,
        AddToPetitionAck = 398,
        AddWagerItem = 10000096,
        AdminChat = 23,
        AdminMessage = 24,
        AdvancementStats = 25,
        AdventureHistory = 247,
        AdventureStatus = 248,
        AllControlPointStatus = 810,
        AllCredits = 10000090,
        AllocateAttributePoints = 26,
        AnnounceCounterAttack = 576,
        AnnounceDamage = 399,
        AnnounceHealing = 620,
        AnnounceLeech = 400,
        AnnounceMapDamage = 401,
        AnnounceReflect = 621,
        AnnounceVamp = 689,
        AppearanceData = 27,
        AppearanceMeshId = 402,
        ArmAbilityFailed = 403,
        ArmorBroken = 405,
        ArmorInfo = 406,
        ArmWeaponFailed = 404,
        AssignNPCMission = 407,
        AssignRadioMission = 408,
        AssignSharedMission = 409,
        AttachedGameEffects = 28,
        AttachInfo = 655,
        AttributeInfo = 29,
        AuctionBuyoutFailed = 724,
        AuctionBuyoutSuccess = 725,
        AuctionCreationFailed = 726,
        AuctionCreationSuccess = 727,
        AuctionExpired = 728,
        AuctionSold = 729,
        AuctionStatusFailed = 730,
        AuctionStatusSuccess = 731,
        AutoFireKeepAlive = 410,
        AvailableAllocationPoints = 30,
        AvailableCharacterClasses = 31,
        Bark = 411,
        BattlecryNotification = 412,
        BeginCharacterSelection = 413,
        BeginTeleport = 32,
        BeginUserCreation = 33,
        BlockInfo = 624,
        BodyAttributes = 34,
        BotAddAbility = 801,
        BotAddAllLogos = 802,
        BotAssignNPCMission = 586,
        BotClearInventory = 414,
        BotCompleteNPCMission = 587,
        BotCompleteNPCObjective = 588,
        BotFillInventory = 415,
        BotGimmeAmmo = 416,
        BotGimmeMoney = 589,
        BotGimmePower = 590,
        BotGimmeWeapon = 591,
        BotLevelUp = 777,
        BotPrepareForCombat = 417,
        BotRequestCreateMap = 592,
        BotRequestMapInstanceList = 593,
        BotRequestPersistentMapInstanceList = 664,
        BotRequestStartGroupList = 418,
        BotSetClass = 803,
        BotTeleportToLocalStartGroup = 419,
        BotTeleportToLocation = 420,
        BotTeleportToSpawner = 421,
        BuryMe = 35,
        CallActorMethod = 36,
        CallGameEffectMethod = 37,
        CancelAuctionFailed = 732,
        CancelAuctionSuccess = 733,
        CancelCorpseLooting = 647,
        CancelLogoutRequest = 818,
        CancelPetition = 422,
        CancelPetitionAck = 423,
        CancelSquadInviteRequest = 804,
        CancelSquadJoinRequest = 805,
        CanDishonorUser = 249,
        CanDishonorUserAck = 250,
        CanHonorUser = 251,
        CanHonorUserAck = 252,
        CanLootItems = 646,
        CannotInvite = 38,
        CannotJoin = 253,
        ChallengeBoardBidFailed = 780,
        ChallengeBoardBidSuccess = 781,
        ChallengeClanToFeud = 669,
        ChallengeClanToFued = 670,
        ChallengedToWargameDuel = 603,
        ChallengedToWargameSquad = 627,
        ChallengeUserToWargameByName = 626,
        ChallengeUserToWargameDuelByName = 602,
        ChallengingToWargameDuel = 635,
        ChallengingToWargameSquad = 636,
        ChangeClanLeader = 612,
        ChangeClanName = 889,
        ChangeFirstName = 887,
        ChangeGuildMaster = 254,
        ChangeLastName = 888,
        ChangePartyLootMethod = 424,
        ChangePartyLootThreshold = 425,
        ChangeShowHelmet = 757,
        ChangeTitle = 709,
        ChannelChat = 10000034,
        CharacteDeleteSuccess = 10000083,
        CharacterChanged = 39,
        CharacterClass = 40,
        CharacterCreateSuccess = 426,
        CharacterDeleteSuccess = 734,
        CharacterInfo = 41,
        CharacterLogout = 10000040,
        CharacterName = 427,
        CharacterOptions = 692,
        CharacterSelect = 428,
        ChatChannelCreate = 10000035,
        ChatChannelDestroy = 10000037,
        ChatChannelJoin = 10000036,
        ChatChannelJoined = 10000038,
        ChatChannelLeft = 10000039,
        ChooseInstanceList = 685,
        ClanAssociation = 782,
        ClanChangeRankTitle = 847,
        ClanChat = 10000069,
        ClanCreate = 10000001,
        ClanCreated = 10000085,
        ClanCreditTransfer = 10000101,
        ClanDeleted = 784,
        ClanDemotePlayer = 10000026,
        ClanDisbanded = 10000032,
        ClanGetMembers = 10000015,
        ClanId = 735,
        ClanInfo = 785,
        ClanInvitationResponse = 613,
        ClanLeaderChanged = 10000029,
        ClanLeadersChat = 10000070,
        ClanLockbox_DepositItem = 882,
        ClanLockbox_DepositItemInSlot = 885,
        ClanLockbox_DepositItemInTab = 886,
        ClanLockbox_DestroyItem = 806,
        ClanLockbox_MoveItem = 10000105,
        ClanLockbox_WithdrawItem = 883,
        ClanMemberDemoted = 10000028,
        ClanMemberPromoted = 10000027,
        ClanMembersRosterBegin = 786,
        ClanMembersRosterEnd = 787,
        ClanMemberStatusUpdate = 10000020,
        ClanPromotePlayer = 10000025,
        ClanSetPlayerRank = 10000023,
        ClanSetRankTitle = 10000030,
        ClanWarfareSearch = 680,
        ClanWarfareSearchResults = 681,
        ClanWargameInviteReceived = 682,
        ClanWargameTestSuccess = 683,
        ClassTooltipInfo = 429,
        ClearServerFlag = 833,
        ClearShortcut = 42,
        ClearTargetId = 43,
        ClearTrackingTarget = 255,
        CloneCredits = 704,
        CloneCreditsChanged = 705,
        CloseDebrief = 44,
        Coalesce = 642,
        CombatMode = 45,
        CommandFollowAck = 256,
        CommandStopFollowAck = 257,
        CompleteNPCMission = 430,
        CompleteNPCObjective = 431,
        CompleteRadioMission = 432,
        ControlPointBidStatus = 812,
        ControlPointBidStatusFailed = 813,
        ControlPointStatus = 814,
        Converse = 433,
        CraftingCatastrophicFailure = 698,
        CraftingFailure = 699,
        CraftingStatus = 434,
        CraftingSuccess = 700,
        CreateAndGoToMapInstance = 46,
        CreateBugReport = 435,
        CreateCharacter = 436,
        CreateClan = 614,
        CreateHelpRequest = 437,
        CreateNewCharacterFailed = 47,
        CreateNewCharacterOK = 48,
        CreatePetitionAck = 438,
        CreatePhysicalEntity = 49,
        CreateUser = 50,
        CreatureCommandFollow = 258,
        CreatureCommandStopFollow = 259,
        CreatureInfo = 439,
        CreditsUpdate = 778,
        CurrentCharacterId = 51,
        CustomizationChoices = 10000012,
        DamageInfo = 260,
        DeadOnArrival = 261,
        DeclineSharedMission = 440,
        DeleteCharacterFailed = 52,
        DeleteCharacterOK = 53,
        DeleteSavePositionFailed = 54,
        DeleteSavePositionOK = 55,
        DestroyPhysicalEntity = 56,
        DetachGameEffect = 262,
        Detonate = 263,
        DevCommand = 441,
        DevRQSWindow = 831,
        DevStartMapAck = 442,
        Died = 57,
        DisableMovement = 58,
        DisableWaypointList = 59,
        DisbandClan = 615,
        Disbanded = 266,
        DisbandGuild = 264,
        DisbandParty = 443,
        DisbandResponse = 265,
        DishonoredByUser = 270,
        DishonorUser = 267,
        DishonorUserFailed = 268,
        DishonorUserSucceeded = 269,
        DispenseRadioMission = 444,
        DispenseSharedMission = 445,
        DisplayClanLeaderInfo = 10000071,
        DisplayClanMemberInfo = 788,
        DisplayClanMemberInfoHeader = 881,
        DisplayClanMessage = 616,
        DisplayClanRosterInfo = 10000072,
        DisplayClientMessage = 10000058,
        DisplayDemoHackPlayerMessageDemoHack = 60,
        DisplayDestinationContextNotification = 446,
        DisplayGuildMessage = 271,
        DisplayLookingForGroupMessage = 829,
        DisplayMapErrors = 447,
        DisplayPartyMessage = 61,
        DisplayPlayerNotification = 448,
        DisplayPlayerTutorialNotification = 449,
        DisplaySystemMessage = 62,
        DisplayWargameMessage = 604,
        DisplayWargameTimer = 628,
        Dissipate = 617,
        DoExplosion = 625,
        DoSwitch = 63,
        Dying = 272,
        EmitterInfo = 450,
        Emote = 10000081,
        EnableDevCommands = 451,
        EnableFollow = 273,
        EnableMovement = 64,
        EnableWaypointList = 65,
        EnteredWaypoint = 274,
        EquipmentInfo = 66,
        ExamineHack = 67,
        ExamineResults = 68,
        ExitedWaypoint = 275,
        ExperienceChanged = 452,
        ExperienceIncreased = 69,
        FatalError = 70,
        FeudChallengeResponse = 671,
        FinishedCameraScript = 453,
        Fire = 276,
        ForceCompleteObjective = 639,
        ForceConverse = 832,
        ForceState = 454,
        FriendAdded = 10000053,
        FriendList = 71,
        FriendLoggedIn = 10000060,
        FriendLoggedOff = 10000061,
        FriendLoggedOut = 661,
        FriendRemoved = 10000054,
        FriendStatusUpdate = 10000059,
        FuedChallengeResponse = 672,
        Funds = 72,
        FundsUpdate = 277,
        GameEffectApplied = 73,
        GameEffectAttached = 74,
        GameEffectAttachFailed = 774,
        GameEffectDetached = 75,
        GameEffectDurationChange = 76,
        GameEffects = 279,
        GameEffectTick = 278,
        GameEffectUpdateTooltip = 660,
        GeneratedCharacterName = 77,
        GeneratedFamilyName = 456,
        GetClanName = 10000079,
        GetCustomizationChoices = 10000011,
        GetFundsAmount = 779,
        GetPvPClanMembershipStatus = 789,
        GetPvPClanStatus = 790,
        GetServerCollisionData = 280,
        GetServerSkeleton = 281,
        GetSocialContactList = 10000055,
        GlobalChat = 3,
        GmCmd_ForceCompleteObjective = 457,
        GMCommand = 455,
        GmGotoMapAck = 458,
        GmGotoStartGroupAck = 459,
        GmKillMapAck = 460,
        GmShowUserMissionsAck = 461,
        GotLoot = 78,
        GotoMob = 873,
        GraveyardGained = 462,
        GuildAbbreviation = 282,
        GuildAbbreviationAndTitle = 283,
        GuildChat = 5,
        GuildInvitationResponse = 284,
        HackCommand = 463,
        Heal = 711,
        HitPointChange = 285,
        HomeInventory_Close = 79,
        HomeInventory_DestroyItem = 80,
        HomeInventory_MoveItem = 81,
        HomeInventory_Open = 82,
        Honor = 286,
        HonoredByUser = 290,
        HonorUser = 287,
        HonorUserFailed = 288,
        HonorUserSucceeded = 289,
        HoveringChanged = 83,
        IgnoreAdded = 10000051,
        IgnoredPlayerLoggedIn = 10000062,
        IgnoredPlayerLoggedOff = 10000063,
        IgnoreList = 84,
        IgnoreRemoved = 10000052,
        InventoryAddItem = 85,
        InventoryCreate = 86,
        InventoryDestroy = 87,
        InventoryDisabled = 291,
        InventoryMoveFailed = 464,
        InventoryMoveItemFailed = 465,
        InventoryReload = 879,
        InventoryRemoveItem = 88,
        InventoryTransfer = 89,
        Invitation = 292,
        InvitationCancelled = 90,
        InvitationDeclined = 91,
        InvitationResult = 293,
        InviteClan = 618,
        InvitedPlayerToParty = 10000078,
        InvitedToAddAndJoinFriend = 467,
        InvitedToJoinFriend = 95,
        InviteFriendToJoin = 92,
        InviteSquad = 791,
        InviteSquadConfirmationRequest = 792,
        InviteToClan = 623,
        InviteToClanById = 10000033,
        InviteToClanByName = 10000013,
        InviteToParty = 93,
        InviteUserIntoGuild = 294,
        InviteUserToParty = 94,
        InviteUserToPartyByName = 466,
        IsLootable = 468,
        IsRunning = 96,
        IsTargetable = 594,
        IsTrialAccount = 768,
        IsUsable = 599,
        ItemInfo = 469,
        ItemModuleModified = 717,
        ItemStatus = 470,
        ItemTemplateTooltipInfo = 579,
        JoinedTeam = 10000122,
        JoinFriendCancelled = 295,
        JoinFriendDeclined = 296,
        JoinSquadRequestReceived = 793,
        JoinSquadRequestSent = 794,
        JoinTeam = 10000114,
        KickPlayerFromClan = 10000021,
        KickPlayerFromClanByName = 767,
        KickUserFromParty = 97,
        KickUserFromPartyById = 720,
        LauncherEntered = 98,
        LauncherExited = 99,
        LauncherReady = 100,
        LauncherUnready = 101,
        LeaveClan = 619,
        LeaveGuild = 297,
        LeaveParty = 102,
        LeaveTeam = 10000115,
        LeftGuild = 298,
        LeftTeam = 10000123,
        Level = 103,
        LevelChanged = 471,
        LevelIncreased = 104,
        LevelSkills = 472,
        LevelUp = 299,
        LoadClanLockboxInventory = 10000102,
        LoadClanLockboxLogs = 822,
        LockboxFunds = 600,
        LockboxTabPermissions = 854,
        LockInfo = 473,
        LockToActor = 474,
        LoginOk = 105,
        LogosStoneAdded = 475,
        LogosStoneRemoved = 476,
        LogosStoneTabula = 477,
        LogoutTimeRemaining = 819,
        LookingForGroupAdPlaced = 823,
        LookingForGroupAdRemoved = 824,
        LookingForGroupSearchResults = 825,
        LootClassInfo = 478,
        LootCorpse = 648,
        LootInfo = 656,
        LootQuantity = 479,
        LostBattleground = 871,
        MadeDead = 629,
        MakePlayerClanLeader = 10000022,
        MakeUserPartyLeader = 480,
        MakeUserPartyLeaderById = 721,
        MapInstanceList = 106,
        MapLoaded = 107,
        MapMarkerInfo = 665,
        MarketPlaceSearchResults = 300,
        MasterChanged = 302,
        MasterChangeResponse = 301,
        MemberJoined = 303,
        MemberLeft = 304,
        MemberLogin = 305,
        MemberLogout = 306,
        MethodX = 108,
        MinionAdded = 870,
        MinionAssist = 836,
        MinionAssistMe = 852,
        MinionAssistMeAck = 858,
        MinionAssistTarget = 853,
        MinionAssistTargetAck = 859,
        MinionCommand = 857,
        MinionCommandAck = 860,
        MinionFollow = 837,
        MinionFollowMe = 850,
        MinionFollowMeAck = 861,
        MinionFollowTarget = 851,
        MinionFollowTargetAck = 862,
        MinionGo = 838,
        MinionGoAck = 863,
        MinionGuard = 839,
        MinionStay = 840,
        MinionStayAck = 864,
        MinionStopAssist = 841,
        MinionTarget = 842,
        MinionTargetAck = 865,
        MinionTargetMe = 843,
        MinionTargetMeAck = 866,
        MinionTemperamentAck = 867,
        MissionCleared = 821,
        MissionCompleteable = 481,
        MissionCompleted = 482,
        MissionDiscarded = 483,
        MissionFailed = 484,
        MissionGained = 485,
        MissionRewarded = 486,
        MissionStatusInfo = 487,
        Module2Info = 109,
        ModuleCondition = 110,
        ModuleDead = 307,
        ModuleInfo = 111,
        ModuleTooltipInfo = 488,
        MoveAbilityShortcut = 113,
        MoveEntityShortcut = 114,
        MoveGestureShortcut = 115,
        MovementModChange = 580,
        NonFatalError = 116,
        Notification = 117,
        NPCConversationStatus = 489,
        NPCInfo = 490,
        ObjectiveActivated = 491,
        ObjectiveCompleted = 492,
        ObjectiveFailed = 493,
        ObjectiveRevealed = 494,
        OnPaused = 713,
        OnRestart = 714,
        OpenAuctionHouse = 736,
        OpenDebrief = 118,
        OverallQuality = 649,
        OverflowTransfer = 308,
        PartyChat = 4,
        PartyDisbanded = 495,
        PartyInvitationResponse = 119,
        PartyJoinRequestResponse = 795,
        PartyMemberList = 120,
        PartyMemberLogin = 121,
        PartyMemberLogout = 122,
        PartyMemberLoot = 123,
        PartyMemberNameList = 309,
        PartyMemberRoll = 496,
        PartyMemberVoiceId = 310,
        PartyMemberVoiceIds = 581,
        PerformActionRequest = 124,
        PerformNPCChoice = 497,
        PerformObjectAbility = 311,
        PerformRecovery = 125,
        PerformWindup = 126,
        PersonalInventory_DestroyItem = 127,
        PersonalInventory_MoveItem = 498,
        PersonalInventory_MoveItems = 128,
        PersonalInventory_SplitItem = 499,
        Ping = 129,
        PlayerActive = 10000074,
        PlayerAfk = 10000077,
        PlayerCount = 500,
        PlayerCountAck = 501,
        PlayerDead = 595,
        PlayerEnteredCombat = 718,
        PlayerExitedCombat = 719,
        PlayerFlags = 710,
        PlayerInactive = 10000075,
        PlayerInactiveWarning = 830,
        PlayerJoinedClan = 10000017,
        PlayerJoinedTeam = 312,
        PlayerKickedFromClan = 10000019,
        PlayerLeftClan = 10000018,
        PlayerLeftTeam = 313,
        PlayerLogin = 130,
        PlayerLogout = 131,
        PlayerTeamInfo = 314,
        PlayerVendorAddItem = 315,
        PlayerVendorCreate = 316,
        PlayerVendorDestroy = 317,
        PlayerVendorRemoveItem = 318,
        PlayerVendorUpdateSaleInfo = 319,
        PlayTutorialAudio = 707,
        PostTeleport = 132,
        PreloadData = 622,
        PreTeleport = 133,
        PreviewMOTD = 769,
        PreWonkavate = 134,
        PrivilegedCommand = 640,
        PurchaseClanLockboxTab = 868,
        PurchaseLockboxTab = 855,
        PvPEnabled = 783,
        QACommand = 502,
        QAGiveMissionAck = 503,
        QAKnowledgeQuery = 135,
        QueryFailed = 737,
        QuerySuccess = 738,
        RaceId = 760,
        RadialChat = 136,
        ReceivedCreatureKillPrestige = 10000109,
        ReceivedItemLootPrestige = 10000111,
        ReflectDamage = 577,
        RefuseRevive = 762,
        RemoveAuctionItem = 739,
        RemoveBuybackItem = 504,
        Removed = 324,
        RemoveFriend = 7,
        RemoveFriendAck = 137,
        RemoveFriendByName = 657,
        RemoveFromClanWargame = 679,
        RemoveFromLauncher = 138,
        RemoveFromWargame = 715,
        RemoveIgnore = 9,
        RemoveIgnoreAck = 139,
        RemoveIgnoreByName = 658,
        RemoveInboxItem = 740,
        RemoveLookingForGroupAd = 826,
        RemoveMember = 320,
        RemoveOverflowItem = 321,
        RemovePartyMember = 140,
        RemoveSelf = 141,
        RemoveSquadMember = 142,
        RemoveTeam = 10000116,
        RemoveTeamMember = 10000118,
        RemoveUserFromGuild = 322,
        RemoveUserResponse = 323,
        RemoveWageredItem = 10000093,
        RemoveWagerItem = 10000097,
        Reply = 659,
        RequestAcceptTradeRequest = 610,
        RequestActionInterrupt = 759,
        RequestAddItemToPlayerVendor = 325,
        RequestAddItemToTrade = 143,
        RequestAddLogosStoneToTabula = 505,
        RequestAdventureHistory = 326,
        RequestAdventureStatus = 327,
        RequestArmAbility = 506,
        RequestArmWeapon = 507,
        RequestAttachModuleToArmor = 508,
        RequestAttachModuleToWeapon = 144,
        RequestAuctionBuyout = 741,
        RequestAuctionStatus = 742,
        RequestBind = 145,
        RequestCampaignStatus = 328,
        RequestCancelAuction = 743,
        RequestCancelAuctioneer = 744,
        RequestCancelNPCVendor = 329,
        RequestCancelTrade = 146,
        RequestCancelVendor = 509,
        RequestChangeEnergyUnitAmount = 147,
        RequestCharacterInfo = 148,
        RequestCharacterName = 149,
        RequestChargedWeaponAttack = 510,
        RequestChiStrike = 330,
        RequestCloneCharacterToSlot = 511,
        RequestCloseChallengeBoard = 815,
        RequestClosePlayerVendor = 331,
        RequestConfirmTrade = 150,
        RequestControlPointBidStatus = 816,
        RequestControlPointStatus = 817,
        RequestCorpseLooting = 650,
        RequestCraftingStatus = 152,
        RequestCraftItem = 151,
        RequestCraftItemNew = 844,
        RequestCreateAuction = 745,
        RequestCreateCharacterInSlot = 512,
        RequestCreateLookingForGroupAd = 827,
        RequestCreateNewCharacter = 153,
        RequestCreateSingleUseRecipe = 154,
        RequestCritDeathFinish = 662,
        RequestCustomization = 332,
        RequestDeleteCharacter = 155,
        RequestDeleteCharacterInSlot = 513,
        RequestDeleteSavePosition = 156,
        RequestDepositGuildFunds = 333,
        RequestDetach = 334,
        RequestDetachGameEffect = 746,
        RequestDisassembleItem = 676,
        RequestDynamicAdventureUpdates = 335,
        RequestEquip = 1,
        RequestEquipArmor = 514,
        RequestEquipWeapon = 515,
        RequestExtractModule = 845,
        RequestFamilyName = 516,
        RequestGesture = 336,
        RequestGestureWeapon = 747,
        RequestIntegrateItem = 848,
        RequestInvitationToJoin = 337,
        RequestIssueHTMLInteraction = 338,
        RequestJoinVoiceChannel = 339,
        RequestLeaveVoiceChannel = 340,
        RequestLockboxTabPermissions = 856,
        RequestLogout = 820,
        RequestLookingForGroupSearch = 828,
        RequestLootAllFromCorpse = 651,
        RequestLootItemFromCorpse = 652,
        RequestLOSReport = 761,
        RequestMapInstanceList = 157,
        RequestModifyItem = 677,
        RequestModifyPlayerVendorItemInfo = 341,
        RequestMoveItemToClanLockbox = 10000103,
        RequestMoveItemToHomeInventory = 582,
        RequestMovementBlock = 517,
        RequestNPCConverse = 518,
        RequestNPCOpenAuctionHouse = 748,
        RequestNPCVending = 519,
        RequestNPCVendorCreateGuild = 342,
        RequestNPCVendorPurchase = 158,
        RequestNPCVendorSale = 159,
        RequestPerformAbility = 343,
        RequestPerformChargedAbility = 520,
        RequestPlaceObject = 344,
        RequestPlayerVendorItemsByCategory = 345,
        RequestPurchasePlayerVendorItem = 346,
        RequestQueryAuctions = 749,
        RequestRemoveItemFromPlayerVendor = 347,
        RequestRemoveItemFromTrade = 160,
        RequestRepair = 348,
        RequestRetrieveAllFinishedItems = 750,
        RequestRetrieveFinishedCraftItem = 521,
        RequestReturnItemToInventory = 349,
        RequestReverseEngineer = 668,
        RequestRevive = 763,
        RequestSalvageItem = 846,
        RequestSaveCurrentCharacterToPosition = 161,
        RequestSavePositionInfo = 162,
        RequestSetAbilitySlot = 522,
        RequestSwapAbilitySlots = 601,
        RequestSwitchToCharacter = 163,
        RequestSwitchToCharacterInSlot = 523,
        RequestTakeItemFromClanLockbox = 10000104,
        RequestTakeItemFromHomeInventory = 583,
        RequestTakeItemFromInboxInventory = 751,
        RequestToggleRun = 164,
        RequestToJoin = 350,
        RequestToJoinLeaderConfirmationRequest = 796,
        RequestToolAction = 524,
        RequestTooltipForClassId = 525,
        RequestTooltipForItemClassId = 690,
        RequestTooltipForItemTemplateId = 578,
        RequestTooltipForModuleId = 526,
        RequestTrade = 165,
        RequestUnconfirmTrade = 166,
        RequestUnequip = 167,
        RequestUnstick = 351,
        RequestUpgradeItem = 849,
        RequestUseCloneCredit = 706,
        RequestUseObject = 352,
        RequestUseTransferCredit = 752,
        RequestVendorBuyback = 527,
        RequestVendorPurchase = 528,
        RequestVendorRepair = 667,
        RequestVendorSale = 529,
        RequestViewPlayerVendor = 353,
        RequestVisualCombatMode = 753,
        RequestWaypointList = 168,
        RequestWeaponAttack = 354,
        RequestWeaponDraw = 530,
        RequestWeaponReload = 531,
        RequestWeaponStow = 532,
        RequestWithdrawGuildFunds = 355,
        ResetAuctionInventory = 754,
        ResetBuybackInventory = 533,
        ResetInboxInventory = 755,
        ResetOverflowInventory = 356,
        ResetWagerInventory = 10000095,
        ResistanceData = 534,
        RespondToAddAndJoinFriend = 535,
        RespondToJoinFriend = 169,
        RespondToRequestToJoin = 357,
        RetrieveKBArticle = 536,
        RetrieveKBArticleAck = 537,
        RetrievePetition = 538,
        RetrievePetitionAck = 539,
        ReturnToWormhole = 686,
        Revived = 171,
        ReviveMe = 170,
        ReviveRequestInfo = 764,
        RevokeClanFeud = 673,
        RevokeInvitation = 172,
        RevokeWargameChallenge = 630,
        RewardNPCMission = 540,
        RewardRadioMission = 541,
        RunCameraScript = 358,
        SalaryPaid = 359,
        SaveCharacterOptions = 693,
        SaveCharacterSnapshotFailed = 173,
        SaveCharacterSnapshotOK = 174,
        SavePositionInfo = 175,
        SaveUserOptions = 694,
        ScoreBoardActive = 877,
        ScoreBoardFullUpdate = 874,
        ScoreBoardGameScore = 880,
        ScoreBoardIndividualUpdate = 875,
        ScoreBoardTrackerUpdate = 876,
        ScriptableClientEvent = 643,
        SearchKB = 542,
        SearchKBAck = 543,
        SearchPetitions = 544,
        SearchPetitionsAck = 545,
        SelectAbilitiesAndPumps = 176,
        SelectInstance = 687,
        SelectInstanceCancel = 688,
        SelectNewCharacterClass = 177,
        SelectWaypoint = 178,
        SendJoinRequestToPartyByName = 797,
        SendJoinRequestToSquadLeader = 798,
        SendMeToMapHack = 179,
        SendMeToMyApartment = 180,
        SendMOTD = 770,
        SendPlayerToMapInstance = 181,
        ServerCollisionData = 360,
        ServerFlags = 834,
        ServerPerformanceMetrics = 182,
        ServerSkeleton = 361,
        SetAbilityShortcut = 183,
        SetAdventureBrief = 184,
        SetAdventureFailureDebrief = 185,
        SetAdventureSuccessDebrief = 186,
        SetAutoDefend = 187,
        SetAutoLootThreshold = 546,
        SetClanData = 799,
        SetClanMemberData = 800,
        SetClanMemberInfo = 10000031,
        SetClanMembers = 10000016,
        SetClanName = 10000080,
        SetConfig = 188,
        SetConsumable = 189,
        SetControlledActorId = 190,
        SetCurrentClanInfo = 10000014,
        SetCurrentContextId = 362,
        SetCurrentPartyId = 191,
        SetDesiredCrouchState = 811,
        SetDesiredPosture = 641,
        SetEntityShortcut = 192,
        SetGestureShortcut = 193,
        SetGuildTitle = 363,
        SetHoverAltitude = 194,
        SetHue = 878,
        SetInfo = 364,
        SetIsContextOwner = 365,
        SetIsGM = 366,
        SetIsPartyLeader = 10000006,
        SetKillStreak = 367,
        SetMaster = 368,
        SetNumberOfTeams = 890,
        SetObjectiveBrief = 196,
        SetOwnerId = 884,
        SetPartyLeader = 195,
        SetReuseTimeModifier = 369,
        SetServerFlag = 835,
        SetServerLanguages = 370,
        SetShortcuts = 197,
        SetSkyTime = 198,
        SetSocialContactList = 10000050,
        SetStackCount = 199,
        SetTarget = 200,
        SetTargetId = 201,
        SetTrackingTarget = 202,
        SetUsable = 203,
        SetWargameMaxKills = 631,
        ShareMission = 547,
        Shout = 204,
        ShowHelmetChanged = 758,
        Skills = 548,
        SquadMemberList = 205,
        SquadRequestCanceled = 807,
        SquadRequestDeclined = 808,
        SquadRequestSuccess = 809,
        StartActionReuseTimer = 10000086,
        StartAutoFire = 549,
        StartTrackingScriptableClientEvent = 644,
        StateChange = 206,
        StateChangeRequest = 207,
        StateCorrection = 208,
        StaticLootInfo = 653,
        StopAutoFire = 550,
        StopTrackingScriptableClientEvent = 645,
        StoreUserClientInformation = 775,
        SurrenderClanFeud = 675,
        SurrenderWargame = 674,
        Swap = 371,
        SwapMeshDeath = 551,
        SwapMeshRevive = 552,
        SwitchToCharacterFailed = 209,
        SwitchToCharacterOK = 210,
        SystemMessage = 553,
        TakenInfo = 654,
        TargetCategory = 211,
        TargetId = 372,
        TeamDisbanded = 10000121,
        TeamMemberList = 10000119,
        Teleport = 212,
        TeleportAcknowledge = 213,
        TeleportArrival = 373,
        TeleportFailed = 374,
        TierAdvancementInfo = 214,
        TitleAdded = 701,
        TitleChanged = 708,
        TitleChangeResponse = 375,
        TitleRemoved = 702,
        Titles = 703,
        ToBePerceivedModifier = 772,
        ToggleAfk = 10000076,
        ToPerceiveModifier = 773,
        TradeAddItem = 215,
        TradeCompleted = 554,
        TradeConfirmChange = 216,
        TradeCreate = 217,
        TradeDestroy = 218,
        TradeEnergyUnitsChange = 219,
        TradeInvite = 611,
        TradeRemoveItem = 220,
        TradeUpdateItem = 712,
        Train = 555,
        TrainSkill = 556,
        TransferCreditToLockbox = 596,
        TranslateLogos = 557,
        TranslateLogosResult = 558,
        TurnOff = 559,
        TurnOn = 560,
        UnrequestMovementBlock = 561,
        Update = 221,
        UpdateAbilityCostModifiers = 222,
        UpdateAdventureList = 376,
        UpdateArmor = 562,
        UpdateAttribute = 223,
        UpdateAttributeRefresh = 224,
        UpdateAttributes = 563,
        UpdateCampaignStatus = 377,
        UpdateChi = 378,
        UpdateChiAttribute = 225,
        UpdateClanLockbox = 10000098,
        UpdateClanLockboxCredits = 10000099,
        UpdateClanLockboxLogs = 10000113,
        UpdateClanLockboxTabCount = 869,
        UpdateConsumables = 379,
        UpdateCredits = 10000089,
        UpdateEscortStatus = 684,
        UpdateHealth = 380,
        UpdateHitPoints = 564,
        UpdateLauncherState = 226,
        UpdateLevel = 771,
        UpdateMapMarker = 666,
        UpdateMovement = 227,
        UpdateObjectiveCounter = 565,
        UpdateObjectiveItemCounter = 566,
        UpdatePartyMemberClassAndLevel = 584,
        UpdatePartyMemberInfo = 663,
        UpdatePartyMemberState = 228,
        UpdatePhysicalEntity = 381,
        UpdatePower = 567,
        UpdateRegions = 568,
        UpdateTeamMemberInfo = 10000120,
        UsableInfo = 229,
        Use = 230,
        UseInterrupted = 609,
        UseInterruptible = 691,
        UserActionFailed = 756,
        UserClanName = 10000073,
        UserCreationFailed = 231,
        UserJoinedParty = 232,
        UserLeftParty = 233,
        UserOptions = 695,
        UserTitheUpdate = 382,
        UserTitleChanged = 383,
        Vend = 569,
        ViewUserFlags = 10000084,
        VoiceChatAvailable = 384,
        VoiceChatConnectInfo = 385,
        WageredItemLocked = 10000112,
        WageredItemOutLeveled = 10000108,
        WagerItem = 10000091,
        WargameCancelled = 605,
        WargameChallengeRefused = 637,
        WargameChallengeResponse = 606,
        WargameChallengeRevoked = 638,
        WargameData = 696,
        WargameDefeat = 607,
        WargameScoreboard = 632,
        WargameStarted = 633,
        WargameTied = 634,
        WargameVictory = 608,
        WaypointAdded = 235,
        WaypointGained = 570,
        WaypointList = 386,
        WeaponAmmoInfo = 571,
        WeaponBindCount = 236,
        WeaponBroken = 387,
        WeaponDrawerInventory_DestroyItem = 572,
        WeaponDrawerInventory_MoveItem = 573,
        WeaponDrawerSlot = 574,
        WeaponInfo = 237,
        WeaponJammed = 585,
        WeaponReady = 575,
        WeaponState = 238,
        Whisper = 2,
        WhisperAck = 239,
        WhisperFailAck = 240,
        WhisperSelf = 241,
        Who = 388,
        WhoAck = 389,
        WhoFailAck = 390,
        WhoUserCountAck = 391,
        WonBattleground = 872,
        Wonkavate = 242,
        WorldLocationDescriptor = 243,
        WorldPlacementDescriptor = 244,
    }
}
