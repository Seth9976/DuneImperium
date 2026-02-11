using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000006 RID: 6
public static class DBGGameOptions : Object
{
	// Token: 0x06000014 RID: 20 RVA: 0x0001A118 File Offset: 0x00018318
	// Note: this type is marked as 'beforefieldinit'.
	static DBGGameOptions()
	{
		Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "", "DBGGameOptions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr);
		DBGGameOptions.NativeFieldInfoPtr_Scenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr, "Scenario");
		DBGGameOptions.NativeFieldInfoPtr_ViewingOnlineGameResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr, "ViewingOnlineGameResults");
		DBGGameOptions.NativeFieldInfoPtr_Timers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr, "Timers");
		DBGGameOptions.NativeFieldInfoPtr_MatchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr, "MatchType");
		DBGGameOptions.NativeFieldInfoPtr_AIDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr, "AIDifficulty");
		DBGGameOptions.NativeFieldInfoPtr_AIPlayerMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr, "AIPlayerMetadata");
		DBGGameOptions.NativeFieldInfoPtr_HasMatchInitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr, "HasMatchInitData");
		DBGGameOptions.NativeFieldInfoPtr_Friends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr, "Friends");
		DBGGameOptions.NativeFieldInfoPtr_XboxOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr, "XboxOnly");
		DBGGameOptions.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr, "Color");
		DBGGameOptions.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr, "Avatar");
		DBGGameOptions.NativeFieldInfoPtr_BlockedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr, "BlockedPlayers");
		DBGGameOptions.NativeFieldInfoPtr_ClientVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr, "ClientVersion");
		DBGGameOptions.NativeFieldInfoPtr_ClientPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameOptions>.NativeClassPtr, "ClientPlatform");
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000020E7 File Offset: 0x000002E7
	public DBGGameOptions(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000016 RID: 22 RVA: 0x0001A260 File Offset: 0x00018460
	// (set) Token: 0x06000017 RID: 23 RVA: 0x000020F0 File Offset: 0x000002F0
	public unsafe static string Scenario
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGGameOptions.NativeFieldInfoPtr_Scenario, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGGameOptions.NativeFieldInfoPtr_Scenario, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000018 RID: 24 RVA: 0x0001A280 File Offset: 0x00018480
	// (set) Token: 0x06000019 RID: 25 RVA: 0x00002102 File Offset: 0x00000302
	public unsafe static string ViewingOnlineGameResults
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGGameOptions.NativeFieldInfoPtr_ViewingOnlineGameResults, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGGameOptions.NativeFieldInfoPtr_ViewingOnlineGameResults, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600001A RID: 26 RVA: 0x0001A2A0 File Offset: 0x000184A0
	// (set) Token: 0x0600001B RID: 27 RVA: 0x00002114 File Offset: 0x00000314
	public unsafe static string Timers
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGGameOptions.NativeFieldInfoPtr_Timers, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGGameOptions.NativeFieldInfoPtr_Timers, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600001C RID: 28 RVA: 0x0001A2C0 File Offset: 0x000184C0
	// (set) Token: 0x0600001D RID: 29 RVA: 0x00002126 File Offset: 0x00000326
	public unsafe static string MatchType
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGGameOptions.NativeFieldInfoPtr_MatchType, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGGameOptions.NativeFieldInfoPtr_MatchType, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600001E RID: 30 RVA: 0x0001A2E0 File Offset: 0x000184E0
	// (set) Token: 0x0600001F RID: 31 RVA: 0x00002138 File Offset: 0x00000338
	public unsafe static string AIDifficulty
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGGameOptions.NativeFieldInfoPtr_AIDifficulty, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGGameOptions.NativeFieldInfoPtr_AIDifficulty, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000020 RID: 32 RVA: 0x0001A300 File Offset: 0x00018500
	// (set) Token: 0x06000021 RID: 33 RVA: 0x0000214A File Offset: 0x0000034A
	public unsafe static string AIPlayerMetadata
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGGameOptions.NativeFieldInfoPtr_AIPlayerMetadata, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGGameOptions.NativeFieldInfoPtr_AIPlayerMetadata, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000022 RID: 34 RVA: 0x0001A320 File Offset: 0x00018520
	// (set) Token: 0x06000023 RID: 35 RVA: 0x0000215C File Offset: 0x0000035C
	public unsafe static string HasMatchInitData
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGGameOptions.NativeFieldInfoPtr_HasMatchInitData, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGGameOptions.NativeFieldInfoPtr_HasMatchInitData, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000024 RID: 36 RVA: 0x0001A340 File Offset: 0x00018540
	// (set) Token: 0x06000025 RID: 37 RVA: 0x0000216E File Offset: 0x0000036E
	public unsafe static string Friends
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGGameOptions.NativeFieldInfoPtr_Friends, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGGameOptions.NativeFieldInfoPtr_Friends, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000026 RID: 38 RVA: 0x0001A360 File Offset: 0x00018560
	// (set) Token: 0x06000027 RID: 39 RVA: 0x00002180 File Offset: 0x00000380
	public unsafe static string XboxOnly
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGGameOptions.NativeFieldInfoPtr_XboxOnly, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGGameOptions.NativeFieldInfoPtr_XboxOnly, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000028 RID: 40 RVA: 0x0001A380 File Offset: 0x00018580
	// (set) Token: 0x06000029 RID: 41 RVA: 0x00002192 File Offset: 0x00000392
	public unsafe static string Color
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGGameOptions.NativeFieldInfoPtr_Color, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGGameOptions.NativeFieldInfoPtr_Color, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600002A RID: 42 RVA: 0x0001A3A0 File Offset: 0x000185A0
	// (set) Token: 0x0600002B RID: 43 RVA: 0x000021A4 File Offset: 0x000003A4
	public unsafe static string Avatar
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGGameOptions.NativeFieldInfoPtr_Avatar, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGGameOptions.NativeFieldInfoPtr_Avatar, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600002C RID: 44 RVA: 0x0001A3C0 File Offset: 0x000185C0
	// (set) Token: 0x0600002D RID: 45 RVA: 0x000021B6 File Offset: 0x000003B6
	public unsafe static string BlockedPlayers
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGGameOptions.NativeFieldInfoPtr_BlockedPlayers, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGGameOptions.NativeFieldInfoPtr_BlockedPlayers, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600002E RID: 46 RVA: 0x0001A3E0 File Offset: 0x000185E0
	// (set) Token: 0x0600002F RID: 47 RVA: 0x000021C8 File Offset: 0x000003C8
	public unsafe static string ClientVersion
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGGameOptions.NativeFieldInfoPtr_ClientVersion, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGGameOptions.NativeFieldInfoPtr_ClientVersion, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000030 RID: 48 RVA: 0x0001A400 File Offset: 0x00018600
	// (set) Token: 0x06000031 RID: 49 RVA: 0x000021DA File Offset: 0x000003DA
	public unsafe static string ClientPlatform
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGGameOptions.NativeFieldInfoPtr_ClientPlatform, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGGameOptions.NativeFieldInfoPtr_ClientPlatform, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeFieldInfoPtr_Scenario;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeFieldInfoPtr_ViewingOnlineGameResults;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeFieldInfoPtr_Timers;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeFieldInfoPtr_MatchType;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeFieldInfoPtr_AIDifficulty;

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeFieldInfoPtr_AIPlayerMetadata;

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeFieldInfoPtr_HasMatchInitData;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeFieldInfoPtr_Friends;

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeFieldInfoPtr_XboxOnly;

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeFieldInfoPtr_Color;

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeFieldInfoPtr_Avatar;

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeFieldInfoPtr_BlockedPlayers;

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeFieldInfoPtr_ClientVersion;

	// Token: 0x04000017 RID: 23
	private static readonly IntPtr NativeFieldInfoPtr_ClientPlatform;
}
