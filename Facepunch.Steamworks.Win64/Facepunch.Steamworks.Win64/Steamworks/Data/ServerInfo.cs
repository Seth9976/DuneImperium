using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Steamworks.Data
{
	// Token: 0x0200020A RID: 522
	public sealed class ServerInfo : ValueType
	{
		// Token: 0x06001A19 RID: 6681 RVA: 0x0007DAC8 File Offset: 0x0007BCC8
		// Note: this type is marked as 'beforefieldinit'.
		static ServerInfo()
		{
			Il2CppClassPointerStore<ServerInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ServerInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr);
			ServerInfo.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<Name>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__Ping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<Ping>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__GameDir_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<GameDir>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__Map_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<Map>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__Description_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<Description>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__AppId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<AppId>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__Players_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<Players>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__MaxPlayers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<MaxPlayers>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__BotPlayers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<BotPlayers>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__Passworded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<Passworded>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__Secure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<Secure>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__LastTimePlayed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<LastTimePlayed>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<Version>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__TagString_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<TagString>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__SteamId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<SteamId>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__AddressRaw_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<AddressRaw>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__Address_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<Address>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__ConnectionPort_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<ConnectionPort>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__QueryPort_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<QueryPort>k__BackingField");
			ServerInfo.NativeFieldInfoPtr__tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "_tags");
			ServerInfo.NativeFieldInfoPtr_k_unFavoriteFlagNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "k_unFavoriteFlagNone");
			ServerInfo.NativeFieldInfoPtr_k_unFavoriteFlagFavorite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "k_unFavoriteFlagFavorite");
			ServerInfo.NativeFieldInfoPtr_k_unFavoriteFlagHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "k_unFavoriteFlagHistory");
			ServerInfo.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668058);
			ServerInfo.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668059);
			ServerInfo.NativeMethodInfoPtr_get_Ping_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668060);
			ServerInfo.NativeMethodInfoPtr_set_Ping_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668061);
			ServerInfo.NativeMethodInfoPtr_get_GameDir_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668062);
			ServerInfo.NativeMethodInfoPtr_set_GameDir_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668063);
			ServerInfo.NativeMethodInfoPtr_get_Map_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668064);
			ServerInfo.NativeMethodInfoPtr_set_Map_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668065);
			ServerInfo.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668066);
			ServerInfo.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668067);
			ServerInfo.NativeMethodInfoPtr_get_AppId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668068);
			ServerInfo.NativeMethodInfoPtr_set_AppId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668069);
			ServerInfo.NativeMethodInfoPtr_get_Players_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668070);
			ServerInfo.NativeMethodInfoPtr_set_Players_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668071);
			ServerInfo.NativeMethodInfoPtr_get_MaxPlayers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668072);
			ServerInfo.NativeMethodInfoPtr_set_MaxPlayers_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668073);
			ServerInfo.NativeMethodInfoPtr_get_BotPlayers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668074);
			ServerInfo.NativeMethodInfoPtr_set_BotPlayers_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668075);
			ServerInfo.NativeMethodInfoPtr_get_Passworded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668076);
			ServerInfo.NativeMethodInfoPtr_set_Passworded_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668077);
			ServerInfo.NativeMethodInfoPtr_get_Secure_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668078);
			ServerInfo.NativeMethodInfoPtr_set_Secure_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668079);
			ServerInfo.NativeMethodInfoPtr_get_LastTimePlayed_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668080);
			ServerInfo.NativeMethodInfoPtr_set_LastTimePlayed_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668081);
			ServerInfo.NativeMethodInfoPtr_get_Version_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668082);
			ServerInfo.NativeMethodInfoPtr_set_Version_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668083);
			ServerInfo.NativeMethodInfoPtr_get_TagString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668084);
			ServerInfo.NativeMethodInfoPtr_set_TagString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668085);
			ServerInfo.NativeMethodInfoPtr_get_SteamId_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668086);
			ServerInfo.NativeMethodInfoPtr_set_SteamId_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668087);
			ServerInfo.NativeMethodInfoPtr_get_AddressRaw_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668088);
			ServerInfo.NativeMethodInfoPtr_set_AddressRaw_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668089);
			ServerInfo.NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668090);
			ServerInfo.NativeMethodInfoPtr_set_Address_Public_set_Void_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668091);
			ServerInfo.NativeMethodInfoPtr_get_ConnectionPort_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668092);
			ServerInfo.NativeMethodInfoPtr_set_ConnectionPort_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668093);
			ServerInfo.NativeMethodInfoPtr_get_QueryPort_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668094);
			ServerInfo.NativeMethodInfoPtr_set_QueryPort_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668095);
			ServerInfo.NativeMethodInfoPtr_get_Tags_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668096);
			ServerInfo.NativeMethodInfoPtr_From_Internal_Static_ServerInfo_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668097);
			ServerInfo.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt16_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668098);
			ServerInfo.NativeMethodInfoPtr_AddToHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668099);
			ServerInfo.NativeMethodInfoPtr_QueryRulesAsync_Public_Task_1_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668100);
			ServerInfo.NativeMethodInfoPtr_RemoveFromHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668101);
			ServerInfo.NativeMethodInfoPtr_AddToFavourites_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668102);
			ServerInfo.NativeMethodInfoPtr_RemoveFromFavourites_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668103);
			ServerInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668104);
			ServerInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100668105);
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x0007E084 File Offset: 0x0007C284
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x0007E0C0 File Offset: 0x0007C2C0
		public unsafe string Name
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x0007E108 File Offset: 0x0007C308
		// (set) Token: 0x06001A1D RID: 6685 RVA: 0x0007E14C File Offset: 0x0007C34C
		public unsafe int Ping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_Ping_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_Ping_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x0007E190 File Offset: 0x0007C390
		// (set) Token: 0x06001A1F RID: 6687 RVA: 0x0007E1CC File Offset: 0x0007C3CC
		public unsafe string GameDir
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_GameDir_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_GameDir_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x0007E214 File Offset: 0x0007C414
		// (set) Token: 0x06001A21 RID: 6689 RVA: 0x0007E250 File Offset: 0x0007C450
		public unsafe string Map
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_Map_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_Map_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x0007E298 File Offset: 0x0007C498
		// (set) Token: 0x06001A23 RID: 6691 RVA: 0x0007E2D4 File Offset: 0x0007C4D4
		public unsafe string Description
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x0007E31C File Offset: 0x0007C51C
		// (set) Token: 0x06001A25 RID: 6693 RVA: 0x0007E360 File Offset: 0x0007C560
		public unsafe uint AppId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_AppId_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_AppId_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x0007E3A4 File Offset: 0x0007C5A4
		// (set) Token: 0x06001A27 RID: 6695 RVA: 0x0007E3E8 File Offset: 0x0007C5E8
		public unsafe int Players
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_Players_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_Players_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x0007E42C File Offset: 0x0007C62C
		// (set) Token: 0x06001A29 RID: 6697 RVA: 0x0007E470 File Offset: 0x0007C670
		public unsafe int MaxPlayers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_MaxPlayers_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_MaxPlayers_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x0007E4B4 File Offset: 0x0007C6B4
		// (set) Token: 0x06001A2B RID: 6699 RVA: 0x0007E4F8 File Offset: 0x0007C6F8
		public unsafe int BotPlayers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_BotPlayers_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_BotPlayers_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x0007E53C File Offset: 0x0007C73C
		// (set) Token: 0x06001A2D RID: 6701 RVA: 0x0007E580 File Offset: 0x0007C780
		public unsafe bool Passworded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_Passworded_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_Passworded_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x0007E5C4 File Offset: 0x0007C7C4
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x0007E608 File Offset: 0x0007C808
		public unsafe bool Secure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_Secure_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_Secure_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x0007E64C File Offset: 0x0007C84C
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x0007E690 File Offset: 0x0007C890
		public unsafe uint LastTimePlayed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_LastTimePlayed_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_LastTimePlayed_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x0007E6D4 File Offset: 0x0007C8D4
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x0007E718 File Offset: 0x0007C918
		public unsafe int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_Version_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_Version_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x0007E75C File Offset: 0x0007C95C
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x0007E798 File Offset: 0x0007C998
		public unsafe string TagString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_TagString_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_TagString_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x0007E7E0 File Offset: 0x0007C9E0
		// (set) Token: 0x06001A37 RID: 6711 RVA: 0x0007E824 File Offset: 0x0007CA24
		public unsafe ulong SteamId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_SteamId_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_SteamId_Public_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x0007E868 File Offset: 0x0007CA68
		// (set) Token: 0x06001A39 RID: 6713 RVA: 0x0007E8AC File Offset: 0x0007CAAC
		public unsafe uint AddressRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_AddressRaw_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 403849, RefRangeEnd = 403852, XrefRangeStart = 403849, XrefRangeEnd = 403852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_AddressRaw_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x0007E8F0 File Offset: 0x0007CAF0
		// (set) Token: 0x06001A3B RID: 6715 RVA: 0x0007E934 File Offset: 0x0007CB34
		public unsafe IPAddress Address
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_Address_Public_set_Void_IPAddress_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x0007E97C File Offset: 0x0007CB7C
		// (set) Token: 0x06001A3D RID: 6717 RVA: 0x0007E9C0 File Offset: 0x0007CBC0
		public unsafe int ConnectionPort
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_ConnectionPort_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 337738, RefRangeEnd = 337747, XrefRangeStart = 337738, XrefRangeEnd = 337747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_ConnectionPort_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001A3E RID: 6718 RVA: 0x0007EA04 File Offset: 0x0007CC04
		// (set) Token: 0x06001A3F RID: 6719 RVA: 0x0007EA48 File Offset: 0x0007CC48
		public unsafe int QueryPort
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_QueryPort_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_set_QueryPort_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001A40 RID: 6720 RVA: 0x0007EA8C File Offset: 0x0007CC8C
		public unsafe Il2CppStringArray Tags
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952809, XrefRangeEnd = 952815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_get_Tags_Public_get_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0007EAD0 File Offset: 0x0007CCD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 952830, RefRangeEnd = 952831, XrefRangeStart = 952815, XrefRangeEnd = 952830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServerInfo From(gameserveritem_t item)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_From_Internal_Static_ServerInfo_gameserveritem_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ServerInfo(intPtr);
			}
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0007EB14 File Offset: 0x0007CD14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 952836, RefRangeEnd = 952838, XrefRangeStart = 952831, XrefRangeEnd = 952836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerInfo(uint ip, ushort cport, ushort qport, uint timeplayed)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ip;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cport;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qport;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeplayed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt16_UInt16_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0007EB8C File Offset: 0x0007CD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952838, XrefRangeEnd = 952851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_AddToHistory_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0007EBC4 File Offset: 0x0007CDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952851, XrefRangeEnd = 952865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Dictionary<string, string>> QueryRulesAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_QueryRulesAsync_Public_Task_1_Dictionary_2_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Dictionary<string, string>>>(intPtr3) : null;
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0007EC08 File Offset: 0x0007CE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952865, XrefRangeEnd = 952874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_RemoveFromHistory_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0007EC40 File Offset: 0x0007CE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952874, XrefRangeEnd = 952887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToFavourites()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_AddToFavourites_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0007EC78 File Offset: 0x0007CE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952887, XrefRangeEnd = 952896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromFavourites()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_RemoveFromFavourites_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0007ECB0 File Offset: 0x0007CEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952896, XrefRangeEnd = 952898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ServerInfo other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ServerInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0007ED08 File Offset: 0x0007CF08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 952901, RefRangeEnd = 952903, XrefRangeStart = 952898, XrefRangeEnd = 952901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00008818 File Offset: 0x00006A18
		public ServerInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00008821 File Offset: 0x00006A21
		public ServerInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr))
		{
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x0007ED4C File Offset: 0x0007CF4C
		// (set) Token: 0x06001A4D RID: 6733 RVA: 0x00008833 File Offset: 0x00006A33
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x0007ED74 File Offset: 0x0007CF74
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x00008852 File Offset: 0x00006A52
		public unsafe int _Ping_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Ping_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Ping_k__BackingField)) = value;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x0007ED9C File Offset: 0x0007CF9C
		// (set) Token: 0x06001A51 RID: 6737 RVA: 0x0000886D File Offset: 0x00006A6D
		public unsafe string _GameDir_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__GameDir_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__GameDir_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x0007EDC4 File Offset: 0x0007CFC4
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x0000888C File Offset: 0x00006A8C
		public unsafe string _Map_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Map_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Map_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x0007EDEC File Offset: 0x0007CFEC
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x000088AB File Offset: 0x00006AAB
		public unsafe string _Description_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Description_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Description_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x0007EE14 File Offset: 0x0007D014
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x000088CA File Offset: 0x00006ACA
		public unsafe uint _AppId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__AppId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__AppId_k__BackingField)) = value;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x0007EE3C File Offset: 0x0007D03C
		// (set) Token: 0x06001A59 RID: 6745 RVA: 0x000088E5 File Offset: 0x00006AE5
		public unsafe int _Players_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Players_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Players_k__BackingField)) = value;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x0007EE64 File Offset: 0x0007D064
		// (set) Token: 0x06001A5B RID: 6747 RVA: 0x00008900 File Offset: 0x00006B00
		public unsafe int _MaxPlayers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__MaxPlayers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__MaxPlayers_k__BackingField)) = value;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0007EE8C File Offset: 0x0007D08C
		// (set) Token: 0x06001A5D RID: 6749 RVA: 0x0000891B File Offset: 0x00006B1B
		public unsafe int _BotPlayers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__BotPlayers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__BotPlayers_k__BackingField)) = value;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x0007EEB4 File Offset: 0x0007D0B4
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x00008936 File Offset: 0x00006B36
		public unsafe bool _Passworded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Passworded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Passworded_k__BackingField)) = value;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x0007EEDC File Offset: 0x0007D0DC
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x00008951 File Offset: 0x00006B51
		public unsafe bool _Secure_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Secure_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Secure_k__BackingField)) = value;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0007EF04 File Offset: 0x0007D104
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0000896C File Offset: 0x00006B6C
		public unsafe uint _LastTimePlayed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__LastTimePlayed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__LastTimePlayed_k__BackingField)) = value;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x0007EF2C File Offset: 0x0007D12C
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x00008987 File Offset: 0x00006B87
		public unsafe int _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x0007EF54 File Offset: 0x0007D154
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x000089A2 File Offset: 0x00006BA2
		public unsafe string _TagString_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__TagString_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__TagString_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0007EF7C File Offset: 0x0007D17C
		// (set) Token: 0x06001A69 RID: 6761 RVA: 0x000089C1 File Offset: 0x00006BC1
		public unsafe ulong _SteamId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__SteamId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__SteamId_k__BackingField)) = value;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x0007EFA4 File Offset: 0x0007D1A4
		// (set) Token: 0x06001A6B RID: 6763 RVA: 0x000089DC File Offset: 0x00006BDC
		public unsafe uint _AddressRaw_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__AddressRaw_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__AddressRaw_k__BackingField)) = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x0007EFCC File Offset: 0x0007D1CC
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x000089F7 File Offset: 0x00006BF7
		public unsafe IPAddress _Address_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Address_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__Address_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x0007EFFC File Offset: 0x0007D1FC
		// (set) Token: 0x06001A6F RID: 6767 RVA: 0x00008A16 File Offset: 0x00006C16
		public unsafe int _ConnectionPort_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__ConnectionPort_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__ConnectionPort_k__BackingField)) = value;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x0007F024 File Offset: 0x0007D224
		// (set) Token: 0x06001A71 RID: 6769 RVA: 0x00008A31 File Offset: 0x00006C31
		public unsafe int _QueryPort_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__QueryPort_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__QueryPort_k__BackingField)) = value;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x0007F04C File Offset: 0x0007D24C
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x00008A4C File Offset: 0x00006C4C
		public unsafe Il2CppStringArray _tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__tags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr__tags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x0007F07C File Offset: 0x0007D27C
		// (set) Token: 0x06001A75 RID: 6773 RVA: 0x00008A6B File Offset: 0x00006C6B
		public unsafe static uint k_unFavoriteFlagNone
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ServerInfo.NativeFieldInfoPtr_k_unFavoriteFlagNone, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServerInfo.NativeFieldInfoPtr_k_unFavoriteFlagNone, (void*)(&value));
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x0007F098 File Offset: 0x0007D298
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x00008A79 File Offset: 0x00006C79
		public unsafe static uint k_unFavoriteFlagFavorite
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ServerInfo.NativeFieldInfoPtr_k_unFavoriteFlagFavorite, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServerInfo.NativeFieldInfoPtr_k_unFavoriteFlagFavorite, (void*)(&value));
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x0007F0B4 File Offset: 0x0007D2B4
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x00008A87 File Offset: 0x00006C87
		public unsafe static uint k_unFavoriteFlagHistory
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ServerInfo.NativeFieldInfoPtr_k_unFavoriteFlagHistory, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServerInfo.NativeFieldInfoPtr_k_unFavoriteFlagHistory, (void*)(&value));
			}
		}

		// Token: 0x04001F37 RID: 7991
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04001F38 RID: 7992
		private static readonly IntPtr NativeFieldInfoPtr__Ping_k__BackingField;

		// Token: 0x04001F39 RID: 7993
		private static readonly IntPtr NativeFieldInfoPtr__GameDir_k__BackingField;

		// Token: 0x04001F3A RID: 7994
		private static readonly IntPtr NativeFieldInfoPtr__Map_k__BackingField;

		// Token: 0x04001F3B RID: 7995
		private static readonly IntPtr NativeFieldInfoPtr__Description_k__BackingField;

		// Token: 0x04001F3C RID: 7996
		private static readonly IntPtr NativeFieldInfoPtr__AppId_k__BackingField;

		// Token: 0x04001F3D RID: 7997
		private static readonly IntPtr NativeFieldInfoPtr__Players_k__BackingField;

		// Token: 0x04001F3E RID: 7998
		private static readonly IntPtr NativeFieldInfoPtr__MaxPlayers_k__BackingField;

		// Token: 0x04001F3F RID: 7999
		private static readonly IntPtr NativeFieldInfoPtr__BotPlayers_k__BackingField;

		// Token: 0x04001F40 RID: 8000
		private static readonly IntPtr NativeFieldInfoPtr__Passworded_k__BackingField;

		// Token: 0x04001F41 RID: 8001
		private static readonly IntPtr NativeFieldInfoPtr__Secure_k__BackingField;

		// Token: 0x04001F42 RID: 8002
		private static readonly IntPtr NativeFieldInfoPtr__LastTimePlayed_k__BackingField;

		// Token: 0x04001F43 RID: 8003
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeFieldInfoPtr__TagString_k__BackingField;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeFieldInfoPtr__SteamId_k__BackingField;

		// Token: 0x04001F46 RID: 8006
		private static readonly IntPtr NativeFieldInfoPtr__AddressRaw_k__BackingField;

		// Token: 0x04001F47 RID: 8007
		private static readonly IntPtr NativeFieldInfoPtr__Address_k__BackingField;

		// Token: 0x04001F48 RID: 8008
		private static readonly IntPtr NativeFieldInfoPtr__ConnectionPort_k__BackingField;

		// Token: 0x04001F49 RID: 8009
		private static readonly IntPtr NativeFieldInfoPtr__QueryPort_k__BackingField;

		// Token: 0x04001F4A RID: 8010
		private static readonly IntPtr NativeFieldInfoPtr__tags;

		// Token: 0x04001F4B RID: 8011
		private static readonly IntPtr NativeFieldInfoPtr_k_unFavoriteFlagNone;

		// Token: 0x04001F4C RID: 8012
		private static readonly IntPtr NativeFieldInfoPtr_k_unFavoriteFlagFavorite;

		// Token: 0x04001F4D RID: 8013
		private static readonly IntPtr NativeFieldInfoPtr_k_unFavoriteFlagHistory;

		// Token: 0x04001F4E RID: 8014
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001F4F RID: 8015
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001F50 RID: 8016
		private static readonly IntPtr NativeMethodInfoPtr_get_Ping_Public_get_Int32_0;

		// Token: 0x04001F51 RID: 8017
		private static readonly IntPtr NativeMethodInfoPtr_set_Ping_Public_set_Void_Int32_0;

		// Token: 0x04001F52 RID: 8018
		private static readonly IntPtr NativeMethodInfoPtr_get_GameDir_Public_get_String_0;

		// Token: 0x04001F53 RID: 8019
		private static readonly IntPtr NativeMethodInfoPtr_set_GameDir_Public_set_Void_String_0;

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeMethodInfoPtr_get_Map_Public_get_String_0;

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeMethodInfoPtr_set_Map_Public_set_Void_String_0;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeMethodInfoPtr_set_Description_Public_set_Void_String_0;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeMethodInfoPtr_get_AppId_Public_get_UInt32_0;

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeMethodInfoPtr_set_AppId_Public_set_Void_UInt32_0;

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeMethodInfoPtr_get_Players_Public_get_Int32_0;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeMethodInfoPtr_set_Players_Public_set_Void_Int32_0;

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxPlayers_Public_get_Int32_0;

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxPlayers_Public_set_Void_Int32_0;

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeMethodInfoPtr_get_BotPlayers_Public_get_Int32_0;

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeMethodInfoPtr_set_BotPlayers_Public_set_Void_Int32_0;

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeMethodInfoPtr_get_Passworded_Public_get_Boolean_0;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeMethodInfoPtr_set_Passworded_Public_set_Void_Boolean_0;

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeMethodInfoPtr_get_Secure_Public_get_Boolean_0;

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeMethodInfoPtr_set_Secure_Public_set_Void_Boolean_0;

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeMethodInfoPtr_get_LastTimePlayed_Public_get_UInt32_0;

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeMethodInfoPtr_set_LastTimePlayed_Public_set_Void_UInt32_0;

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Int32_0;

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Public_set_Void_Int32_0;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeMethodInfoPtr_get_TagString_Public_get_String_0;

		// Token: 0x04001F69 RID: 8041
		private static readonly IntPtr NativeMethodInfoPtr_set_TagString_Public_set_Void_String_0;

		// Token: 0x04001F6A RID: 8042
		private static readonly IntPtr NativeMethodInfoPtr_get_SteamId_Public_get_UInt64_0;

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeMethodInfoPtr_set_SteamId_Public_set_Void_UInt64_0;

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressRaw_Public_get_UInt32_0;

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeMethodInfoPtr_set_AddressRaw_Public_set_Void_UInt32_0;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0;

		// Token: 0x04001F6F RID: 8047
		private static readonly IntPtr NativeMethodInfoPtr_set_Address_Public_set_Void_IPAddress_0;

		// Token: 0x04001F70 RID: 8048
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectionPort_Public_get_Int32_0;

		// Token: 0x04001F71 RID: 8049
		private static readonly IntPtr NativeMethodInfoPtr_set_ConnectionPort_Public_set_Void_Int32_0;

		// Token: 0x04001F72 RID: 8050
		private static readonly IntPtr NativeMethodInfoPtr_get_QueryPort_Public_get_Int32_0;

		// Token: 0x04001F73 RID: 8051
		private static readonly IntPtr NativeMethodInfoPtr_set_QueryPort_Public_set_Void_Int32_0;

		// Token: 0x04001F74 RID: 8052
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Public_get_Il2CppStringArray_0;

		// Token: 0x04001F75 RID: 8053
		private static readonly IntPtr NativeMethodInfoPtr_From_Internal_Static_ServerInfo_gameserveritem_t_0;

		// Token: 0x04001F76 RID: 8054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt16_UInt16_UInt32_0;

		// Token: 0x04001F77 RID: 8055
		private static readonly IntPtr NativeMethodInfoPtr_AddToHistory_Public_Void_0;

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeMethodInfoPtr_QueryRulesAsync_Public_Task_1_Dictionary_2_String_String_0;

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromHistory_Public_Void_0;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeMethodInfoPtr_AddToFavourites_Public_Void_0;

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromFavourites_Public_Void_0;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ServerInfo_0;

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x020002AF RID: 687
		[ObfuscatedName("Steamworks.Data.ServerInfo+<QueryRulesAsync>d__85")]
		public sealed class _QueryRulesAsync_d__85 : ValueType
		{
			// Token: 0x060022F9 RID: 8953 RVA: 0x00094E90 File Offset: 0x00093090
			// Note: this type is marked as 'beforefieldinit'.
			static _QueryRulesAsync_d__85()
			{
				Il2CppClassPointerStore<ServerInfo._QueryRulesAsync_d__85>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, "<QueryRulesAsync>d__85");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerInfo._QueryRulesAsync_d__85>.NativeClassPtr);
				ServerInfo._QueryRulesAsync_d__85.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo._QueryRulesAsync_d__85>.NativeClassPtr, "<>1__state");
				ServerInfo._QueryRulesAsync_d__85.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo._QueryRulesAsync_d__85>.NativeClassPtr, "<>t__builder");
				ServerInfo._QueryRulesAsync_d__85.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo._QueryRulesAsync_d__85>.NativeClassPtr, "<>4__this");
				ServerInfo._QueryRulesAsync_d__85.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo._QueryRulesAsync_d__85>.NativeClassPtr, "<>u__1");
				ServerInfo._QueryRulesAsync_d__85.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo._QueryRulesAsync_d__85>.NativeClassPtr, 100668106);
				ServerInfo._QueryRulesAsync_d__85.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo._QueryRulesAsync_d__85>.NativeClassPtr, 100668107);
			}

			// Token: 0x060022FA RID: 8954 RVA: 0x00094F34 File Offset: 0x00093134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952782, XrefRangeEnd = 952803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo._QueryRulesAsync_d__85.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022FB RID: 8955 RVA: 0x00094F6C File Offset: 0x0009316C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952803, XrefRangeEnd = 952809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerInfo._QueryRulesAsync_d__85.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022FC RID: 8956 RVA: 0x0000E79F File Offset: 0x0000C99F
			public _QueryRulesAsync_d__85(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060022FD RID: 8957 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
			public _QueryRulesAsync_d__85()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerInfo._QueryRulesAsync_d__85>.NativeClassPtr))
			{
			}

			// Token: 0x17000935 RID: 2357
			// (get) Token: 0x060022FE RID: 8958 RVA: 0x00094FB4 File Offset: 0x000931B4
			// (set) Token: 0x060022FF RID: 8959 RVA: 0x0000E7BA File Offset: 0x0000C9BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo._QueryRulesAsync_d__85.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo._QueryRulesAsync_d__85.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000936 RID: 2358
			// (get) Token: 0x06002300 RID: 8960 RVA: 0x00094FDC File Offset: 0x000931DC
			// (set) Token: 0x06002301 RID: 8961 RVA: 0x0000E7D5 File Offset: 0x0000C9D5
			public AsyncTaskMethodBuilder<Dictionary<string, string>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo._QueryRulesAsync_d__85.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Dictionary<string, string>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Dictionary<string, string>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo._QueryRulesAsync_d__85.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Dictionary<string, string>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000937 RID: 2359
			// (get) Token: 0x06002302 RID: 8962 RVA: 0x0009500C File Offset: 0x0009320C
			// (set) Token: 0x06002303 RID: 8963 RVA: 0x0000E803 File Offset: 0x0000CA03
			public ServerInfo __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo._QueryRulesAsync_d__85.NativeFieldInfoPtr___4__this);
					return new ServerInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo._QueryRulesAsync_d__85.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000938 RID: 2360
			// (get) Token: 0x06002304 RID: 8964 RVA: 0x0009503C File Offset: 0x0009323C
			// (set) Token: 0x06002305 RID: 8965 RVA: 0x0000E831 File Offset: 0x0000CA31
			public TaskAwaiter<Dictionary<string, string>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo._QueryRulesAsync_d__85.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Dictionary<string, string>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Dictionary<string, string>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerInfo._QueryRulesAsync_d__85.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Dictionary<string, string>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002426 RID: 9254
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002427 RID: 9255
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002428 RID: 9256
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002429 RID: 9257
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400242A RID: 9258
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400242B RID: 9259
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
