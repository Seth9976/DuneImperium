using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001B4 RID: 436
	public sealed class gameserveritem_t : ValueType
	{
		// Token: 0x060015FD RID: 5629 RVA: 0x0006D760 File Offset: 0x0006B960
		// Note: this type is marked as 'beforefieldinit'.
		static gameserveritem_t()
		{
			Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "gameserveritem_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr);
			gameserveritem_t.NativeFieldInfoPtr_NetAdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "NetAdr");
			gameserveritem_t.NativeFieldInfoPtr_Ping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "Ping");
			gameserveritem_t.NativeFieldInfoPtr_HadSuccessfulResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "HadSuccessfulResponse");
			gameserveritem_t.NativeFieldInfoPtr_DoNotRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "DoNotRefresh");
			gameserveritem_t.NativeFieldInfoPtr_GameDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "GameDir");
			gameserveritem_t.NativeFieldInfoPtr_Map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "Map");
			gameserveritem_t.NativeFieldInfoPtr_GameDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "GameDescription");
			gameserveritem_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "AppID");
			gameserveritem_t.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "Players");
			gameserveritem_t.NativeFieldInfoPtr_MaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "MaxPlayers");
			gameserveritem_t.NativeFieldInfoPtr_BotPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "BotPlayers");
			gameserveritem_t.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "Password");
			gameserveritem_t.NativeFieldInfoPtr_Secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "Secure");
			gameserveritem_t.NativeFieldInfoPtr_TimeLastPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "TimeLastPlayed");
			gameserveritem_t.NativeFieldInfoPtr_ServerVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "ServerVersion");
			gameserveritem_t.NativeFieldInfoPtr_ServerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "ServerName");
			gameserveritem_t.NativeFieldInfoPtr_GameTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "GameTags");
			gameserveritem_t.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "SteamID");
			gameserveritem_t.NativeMethodInfoPtr_InternalConstruct_Internal_Static_Void_byref_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100667384);
			gameserveritem_t.NativeMethodInfoPtr_InternalGetName_Internal_Static_Utf8StringPointer_byref_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100667385);
			gameserveritem_t.NativeMethodInfoPtr_InternalSetName_Internal_Static_Void_byref_gameserveritem_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100667386);
			gameserveritem_t.NativeMethodInfoPtr_GameDirUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100667387);
			gameserveritem_t.NativeMethodInfoPtr_MapUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100667388);
			gameserveritem_t.NativeMethodInfoPtr_GameDescriptionUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100667389);
			gameserveritem_t.NativeMethodInfoPtr_ServerNameUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100667390);
			gameserveritem_t.NativeMethodInfoPtr_GameTagsUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100667391);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x0006D998 File Offset: 0x0006BB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951064, XrefRangeEnd = 951069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalConstruct(ref gameserveritem_t self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_InternalConstruct_Internal_Static_Void_byref_gameserveritem_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0006D9D0 File Offset: 0x0006BBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951069, XrefRangeEnd = 951074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer InternalGetName(ref gameserveritem_t self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_InternalGetName_Internal_Static_Utf8StringPointer_byref_gameserveritem_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x0006DA14 File Offset: 0x0006BC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951074, XrefRangeEnd = 951081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetName(ref gameserveritem_t self, string pName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_InternalSetName_Internal_Static_Void_byref_gameserveritem_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0006DA60 File Offset: 0x0006BC60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951085, RefRangeEnd = 951086, XrefRangeStart = 951081, XrefRangeEnd = 951085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GameDirUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_GameDirUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0006DA9C File Offset: 0x0006BC9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951090, RefRangeEnd = 951091, XrefRangeStart = 951086, XrefRangeEnd = 951090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string MapUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_MapUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x0006DAD8 File Offset: 0x0006BCD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951095, RefRangeEnd = 951096, XrefRangeStart = 951091, XrefRangeEnd = 951095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GameDescriptionUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_GameDescriptionUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x0006DB14 File Offset: 0x0006BD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951100, RefRangeEnd = 951101, XrefRangeStart = 951096, XrefRangeEnd = 951100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ServerNameUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_ServerNameUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x0006DB50 File Offset: 0x0006BD50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951105, RefRangeEnd = 951106, XrefRangeStart = 951101, XrefRangeEnd = 951105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GameTagsUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_GameTagsUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x0000742B File Offset: 0x0000562B
		public gameserveritem_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00007434 File Offset: 0x00005634
		public gameserveritem_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x0006DB8C File Offset: 0x0006BD8C
		// (set) Token: 0x06001609 RID: 5641 RVA: 0x00007446 File Offset: 0x00005646
		public unsafe servernetadr_t NetAdr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_NetAdr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_NetAdr)) = value;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x0006DBB4 File Offset: 0x0006BDB4
		// (set) Token: 0x0600160B RID: 5643 RVA: 0x00007461 File Offset: 0x00005661
		public unsafe int Ping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_Ping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_Ping)) = value;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x0006DBDC File Offset: 0x0006BDDC
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x0000747C File Offset: 0x0000567C
		public unsafe bool HadSuccessfulResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_HadSuccessfulResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_HadSuccessfulResponse)) = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x0006DC04 File Offset: 0x0006BE04
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x00007497 File Offset: 0x00005697
		public unsafe bool DoNotRefresh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_DoNotRefresh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_DoNotRefresh)) = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x0006DC2C File Offset: 0x0006BE2C
		// (set) Token: 0x06001611 RID: 5649 RVA: 0x000074B2 File Offset: 0x000056B2
		public unsafe Il2CppStructArray<byte> GameDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_GameDir);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_GameDir), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x0006DC5C File Offset: 0x0006BE5C
		// (set) Token: 0x06001613 RID: 5651 RVA: 0x000074D1 File Offset: 0x000056D1
		public unsafe Il2CppStructArray<byte> Map
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_Map);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_Map), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x0006DC8C File Offset: 0x0006BE8C
		// (set) Token: 0x06001615 RID: 5653 RVA: 0x000074F0 File Offset: 0x000056F0
		public unsafe Il2CppStructArray<byte> GameDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_GameDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_GameDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x0006DCBC File Offset: 0x0006BEBC
		// (set) Token: 0x06001617 RID: 5655 RVA: 0x0000750F File Offset: 0x0000570F
		public unsafe uint AppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_AppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_AppID)) = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x0006DCE4 File Offset: 0x0006BEE4
		// (set) Token: 0x06001619 RID: 5657 RVA: 0x0000752A File Offset: 0x0000572A
		public unsafe int Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_Players);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_Players)) = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x0006DD0C File Offset: 0x0006BF0C
		// (set) Token: 0x0600161B RID: 5659 RVA: 0x00007545 File Offset: 0x00005745
		public unsafe int MaxPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_MaxPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_MaxPlayers)) = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x0006DD34 File Offset: 0x0006BF34
		// (set) Token: 0x0600161D RID: 5661 RVA: 0x00007560 File Offset: 0x00005760
		public unsafe int BotPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_BotPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_BotPlayers)) = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600161E RID: 5662 RVA: 0x0006DD5C File Offset: 0x0006BF5C
		// (set) Token: 0x0600161F RID: 5663 RVA: 0x0000757B File Offset: 0x0000577B
		public unsafe bool Password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_Password);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_Password)) = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x0006DD84 File Offset: 0x0006BF84
		// (set) Token: 0x06001621 RID: 5665 RVA: 0x00007596 File Offset: 0x00005796
		public unsafe bool Secure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_Secure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_Secure)) = value;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x0006DDAC File Offset: 0x0006BFAC
		// (set) Token: 0x06001623 RID: 5667 RVA: 0x000075B1 File Offset: 0x000057B1
		public unsafe uint TimeLastPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_TimeLastPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_TimeLastPlayed)) = value;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x0006DDD4 File Offset: 0x0006BFD4
		// (set) Token: 0x06001625 RID: 5669 RVA: 0x000075CC File Offset: 0x000057CC
		public unsafe int ServerVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_ServerVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_ServerVersion)) = value;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x0006DDFC File Offset: 0x0006BFFC
		// (set) Token: 0x06001627 RID: 5671 RVA: 0x000075E7 File Offset: 0x000057E7
		public unsafe Il2CppStructArray<byte> ServerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_ServerName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_ServerName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x0006DE2C File Offset: 0x0006C02C
		// (set) Token: 0x06001629 RID: 5673 RVA: 0x00007606 File Offset: 0x00005806
		public unsafe Il2CppStructArray<byte> GameTags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_GameTags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_GameTags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x0006DE5C File Offset: 0x0006C05C
		// (set) Token: 0x0600162B RID: 5675 RVA: 0x00007625 File Offset: 0x00005825
		public unsafe ulong SteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_SteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_SteamID)) = value;
			}
		}

		// Token: 0x04001B56 RID: 6998
		private static readonly IntPtr NativeFieldInfoPtr_NetAdr;

		// Token: 0x04001B57 RID: 6999
		private static readonly IntPtr NativeFieldInfoPtr_Ping;

		// Token: 0x04001B58 RID: 7000
		private static readonly IntPtr NativeFieldInfoPtr_HadSuccessfulResponse;

		// Token: 0x04001B59 RID: 7001
		private static readonly IntPtr NativeFieldInfoPtr_DoNotRefresh;

		// Token: 0x04001B5A RID: 7002
		private static readonly IntPtr NativeFieldInfoPtr_GameDir;

		// Token: 0x04001B5B RID: 7003
		private static readonly IntPtr NativeFieldInfoPtr_Map;

		// Token: 0x04001B5C RID: 7004
		private static readonly IntPtr NativeFieldInfoPtr_GameDescription;

		// Token: 0x04001B5D RID: 7005
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x04001B5E RID: 7006
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x04001B5F RID: 7007
		private static readonly IntPtr NativeFieldInfoPtr_MaxPlayers;

		// Token: 0x04001B60 RID: 7008
		private static readonly IntPtr NativeFieldInfoPtr_BotPlayers;

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeFieldInfoPtr_Password;

		// Token: 0x04001B62 RID: 7010
		private static readonly IntPtr NativeFieldInfoPtr_Secure;

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeFieldInfoPtr_TimeLastPlayed;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeFieldInfoPtr_ServerVersion;

		// Token: 0x04001B65 RID: 7013
		private static readonly IntPtr NativeFieldInfoPtr_ServerName;

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeFieldInfoPtr_GameTags;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeMethodInfoPtr_InternalConstruct_Internal_Static_Void_byref_gameserveritem_t_0;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetName_Internal_Static_Utf8StringPointer_byref_gameserveritem_t_0;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetName_Internal_Static_Void_byref_gameserveritem_t_String_0;

		// Token: 0x04001B6B RID: 7019
		private static readonly IntPtr NativeMethodInfoPtr_GameDirUTF8_Internal_String_0;

		// Token: 0x04001B6C RID: 7020
		private static readonly IntPtr NativeMethodInfoPtr_MapUTF8_Internal_String_0;

		// Token: 0x04001B6D RID: 7021
		private static readonly IntPtr NativeMethodInfoPtr_GameDescriptionUTF8_Internal_String_0;

		// Token: 0x04001B6E RID: 7022
		private static readonly IntPtr NativeMethodInfoPtr_ServerNameUTF8_Internal_String_0;

		// Token: 0x04001B6F RID: 7023
		private static readonly IntPtr NativeMethodInfoPtr_GameTagsUTF8_Internal_String_0;
	}
}
