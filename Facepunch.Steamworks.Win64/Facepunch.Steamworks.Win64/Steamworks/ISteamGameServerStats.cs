using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000014 RID: 20
	public class ISteamGameServerStats : SteamInterface
	{
		// Token: 0x06000251 RID: 593 RVA: 0x0001BD64 File Offset: 0x00019F64
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamGameServerStats()
		{
			Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamGameServerStats");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr);
			ISteamGameServerStats.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663852);
			ISteamGameServerStats.NativeMethodInfoPtr_SteamAPI_SteamGameServerStats_v001_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663853);
			ISteamGameServerStats.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663854);
			ISteamGameServerStats.NativeMethodInfoPtr__RequestUserStats_Private_Static_SteamAPICall_t_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663855);
			ISteamGameServerStats.NativeMethodInfoPtr_RequestUserStats_Internal_CallResult_1_GSStatsReceived_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663856);
			ISteamGameServerStats.NativeMethodInfoPtr__GetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663857);
			ISteamGameServerStats.NativeMethodInfoPtr_GetUserStat_Internal_Boolean_SteamId_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663858);
			ISteamGameServerStats.NativeMethodInfoPtr__GetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663859);
			ISteamGameServerStats.NativeMethodInfoPtr_GetUserStat_Internal_Boolean_SteamId_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663860);
			ISteamGameServerStats.NativeMethodInfoPtr__GetUserAchievement_Private_Static_Boolean_IntPtr_SteamId_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663861);
			ISteamGameServerStats.NativeMethodInfoPtr_GetUserAchievement_Internal_Boolean_SteamId_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663862);
			ISteamGameServerStats.NativeMethodInfoPtr__SetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663863);
			ISteamGameServerStats.NativeMethodInfoPtr_SetUserStat_Internal_Boolean_SteamId_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663864);
			ISteamGameServerStats.NativeMethodInfoPtr__SetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663865);
			ISteamGameServerStats.NativeMethodInfoPtr_SetUserStat_Internal_Boolean_SteamId_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663866);
			ISteamGameServerStats.NativeMethodInfoPtr__UpdateUserAvgRateStat_Private_Static_Boolean_IntPtr_SteamId_String_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663867);
			ISteamGameServerStats.NativeMethodInfoPtr_UpdateUserAvgRateStat_Internal_Boolean_SteamId_String_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663868);
			ISteamGameServerStats.NativeMethodInfoPtr__SetUserAchievement_Private_Static_Boolean_IntPtr_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663869);
			ISteamGameServerStats.NativeMethodInfoPtr_SetUserAchievement_Internal_Boolean_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663870);
			ISteamGameServerStats.NativeMethodInfoPtr__ClearUserAchievement_Private_Static_Boolean_IntPtr_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663871);
			ISteamGameServerStats.NativeMethodInfoPtr_ClearUserAchievement_Internal_Boolean_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663872);
			ISteamGameServerStats.NativeMethodInfoPtr__StoreUserStats_Private_Static_SteamAPICall_t_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663873);
			ISteamGameServerStats.NativeMethodInfoPtr_StoreUserStats_Internal_CallResult_1_GSStatsStored_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr, 100663874);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0001BF60 File Offset: 0x0001A160
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamGameServerStats(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamGameServerStats>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0001BFA8 File Offset: 0x0001A1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932361, XrefRangeEnd = 932363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamGameServerStats_v001()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr_SteamAPI_SteamGameServerStats_v001_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0001BFD8 File Offset: 0x0001A1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetServerInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamGameServerStats.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0001C020 File Offset: 0x0001A220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932363, XrefRangeEnd = 932365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _RequestUserStats(IntPtr self, SteamId steamIDUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr__RequestUserStats_Private_Static_SteamAPICall_t_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0001C06C File Offset: 0x0001A26C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932370, RefRangeEnd = 932371, XrefRangeStart = 932365, XrefRangeEnd = 932370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<GSStatsReceived_t> RequestUserStats(SteamId steamIDUser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr_RequestUserStats_Internal_CallResult_1_GSStatsReceived_t_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<GSStatsReceived_t>(intPtr);
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932371, XrefRangeEnd = 932374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetUserStat(IntPtr self, SteamId steamIDUser, string pchName, ref int pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr__GetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001C11C File Offset: 0x0001A31C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932377, RefRangeEnd = 932378, XrefRangeStart = 932374, XrefRangeEnd = 932377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetUserStat(SteamId steamIDUser, string pchName, ref int pData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr_GetUserStat_Internal_Boolean_SteamId_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0001C188 File Offset: 0x0001A388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932378, XrefRangeEnd = 932381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetUserStat(IntPtr self, SteamId steamIDUser, string pchName, ref float pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr__GetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0001C1F4 File Offset: 0x0001A3F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932384, RefRangeEnd = 932385, XrefRangeStart = 932381, XrefRangeEnd = 932384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetUserStat(SteamId steamIDUser, string pchName, ref float pData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr_GetUserStat_Internal_Boolean_SteamId_String_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0001C260 File Offset: 0x0001A460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932385, XrefRangeEnd = 932388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetUserAchievement(IntPtr self, SteamId steamIDUser, string pchName, ref bool pbAchieved)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr__GetUserAchievement_Private_Static_Boolean_IntPtr_SteamId_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0001C2CC File Offset: 0x0001A4CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932391, RefRangeEnd = 932392, XrefRangeStart = 932388, XrefRangeEnd = 932391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetUserAchievement(SteamId steamIDUser, string pchName, ref bool pbAchieved)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr_GetUserAchievement_Internal_Boolean_SteamId_String_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0001C338 File Offset: 0x0001A538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932392, XrefRangeEnd = 932395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetUserStat(IntPtr self, SteamId steamIDUser, string pchName, int nData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr__SetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0001C3A4 File Offset: 0x0001A5A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932398, RefRangeEnd = 932399, XrefRangeStart = 932395, XrefRangeEnd = 932398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetUserStat(SteamId steamIDUser, string pchName, int nData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr_SetUserStat_Internal_Boolean_SteamId_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0001C410 File Offset: 0x0001A610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932399, XrefRangeEnd = 932402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetUserStat(IntPtr self, SteamId steamIDUser, string pchName, float fData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr__SetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0001C47C File Offset: 0x0001A67C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932405, RefRangeEnd = 932406, XrefRangeStart = 932402, XrefRangeEnd = 932405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetUserStat(SteamId steamIDUser, string pchName, float fData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr_SetUserStat_Internal_Boolean_SteamId_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932406, XrefRangeEnd = 932409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _UpdateUserAvgRateStat(IntPtr self, SteamId steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flCountThisSession;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dSessionLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr__UpdateUserAvgRateStat_Private_Static_Boolean_IntPtr_SteamId_String_Single_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0001C564 File Offset: 0x0001A764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932409, XrefRangeEnd = 932412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateUserAvgRateStat(SteamId steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flCountThisSession;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dSessionLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr_UpdateUserAvgRateStat_Internal_Boolean_SteamId_String_Single_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0001C5DC File Offset: 0x0001A7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932412, XrefRangeEnd = 932415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetUserAchievement(IntPtr self, SteamId steamIDUser, string pchName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr__SetUserAchievement_Private_Static_Boolean_IntPtr_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0001C63C File Offset: 0x0001A83C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932418, RefRangeEnd = 932419, XrefRangeStart = 932415, XrefRangeEnd = 932418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetUserAchievement(SteamId steamIDUser, string pchName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr_SetUserAchievement_Internal_Boolean_SteamId_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0001C698 File Offset: 0x0001A898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932419, XrefRangeEnd = 932422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ClearUserAchievement(IntPtr self, SteamId steamIDUser, string pchName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr__ClearUserAchievement_Private_Static_Boolean_IntPtr_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0001C6F8 File Offset: 0x0001A8F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932425, RefRangeEnd = 932426, XrefRangeStart = 932422, XrefRangeEnd = 932425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ClearUserAchievement(SteamId steamIDUser, string pchName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr_ClearUserAchievement_Internal_Boolean_SteamId_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0001C754 File Offset: 0x0001A954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932426, XrefRangeEnd = 932428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _StoreUserStats(IntPtr self, SteamId steamIDUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr__StoreUserStats_Private_Static_SteamAPICall_t_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932433, RefRangeEnd = 932434, XrefRangeStart = 932428, XrefRangeEnd = 932433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<GSStatsStored_t> StoreUserStats(SteamId steamIDUser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServerStats.NativeMethodInfoPtr_StoreUserStats_Internal_CallResult_1_GSStatsStored_t_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<GSStatsStored_t>(intPtr);
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002312 File Offset: 0x00000512
		public ISteamGameServerStats(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamGameServerStats_v001_Internal_Static_IntPtr_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr__RequestUserStats_Private_Static_SteamAPICall_t_IntPtr_SteamId_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_RequestUserStats_Internal_CallResult_1_GSStatsReceived_t_SteamId_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr__GetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_byref_Int32_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_GetUserStat_Internal_Boolean_SteamId_String_byref_Int32_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr__GetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_byref_Single_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_GetUserStat_Internal_Boolean_SteamId_String_byref_Single_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr__GetUserAchievement_Private_Static_Boolean_IntPtr_SteamId_String_byref_Boolean_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_GetUserAchievement_Internal_Boolean_SteamId_String_byref_Boolean_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr__SetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_Int32_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_SetUserStat_Internal_Boolean_SteamId_String_Int32_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr__SetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_Single_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_SetUserStat_Internal_Boolean_SteamId_String_Single_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr__UpdateUserAvgRateStat_Private_Static_Boolean_IntPtr_SteamId_String_Single_Double_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUserAvgRateStat_Internal_Boolean_SteamId_String_Single_Double_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr__SetUserAchievement_Private_Static_Boolean_IntPtr_SteamId_String_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_SetUserAchievement_Internal_Boolean_SteamId_String_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr__ClearUserAchievement_Private_Static_Boolean_IntPtr_SteamId_String_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_ClearUserAchievement_Internal_Boolean_SteamId_String_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr__StoreUserStats_Private_Static_SteamAPICall_t_IntPtr_SteamId_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_StoreUserStats_Internal_CallResult_1_GSStatsStored_t_SteamId_0;
	}
}
