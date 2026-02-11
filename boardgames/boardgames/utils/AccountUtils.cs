using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.utils
{
	// Token: 0x0200010A RID: 266
	public static class AccountUtils : Object
	{
		// Token: 0x06000CD4 RID: 3284 RVA: 0x00039C58 File Offset: 0x00037E58
		// Note: this type is marked as 'beforefieldinit'.
		static AccountUtils()
		{
			Il2CppClassPointerStore<AccountUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.utils", "AccountUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountUtils>.NativeClassPtr);
			AccountUtils.NativeMethodInfoPtr_GetLoggedInID_Public_Static_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountUtils>.NativeClassPtr, 100665307);
			AccountUtils.NativeMethodInfoPtr_GetLoggedInIDOrThrow_Public_Static_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountUtils>.NativeClassPtr, 100665308);
			AccountUtils.NativeMethodInfoPtr_GetLoggedInOrOfflineID_Public_Static_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountUtils>.NativeClassPtr, 100665309);
			AccountUtils.NativeMethodInfoPtr_TryGetLoggedInID_Public_Static_Boolean_byref_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountUtils>.NativeClassPtr, 100665310);
			AccountUtils.NativeMethodInfoPtr_GetOfflineAccountID_Public_Static_AccountID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountUtils>.NativeClassPtr, 100665311);
			AccountUtils.NativeMethodInfoPtr_GetCurrentGameAccountID_Public_Static_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountUtils>.NativeClassPtr, 100665312);
			AccountUtils.NativeMethodInfoPtr_IsLoggedIn_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountUtils>.NativeClassPtr, 100665313);
			AccountUtils.NativeMethodInfoPtr_SaveCredentials_Public_Static_Void_String_String_String_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountUtils>.NativeClassPtr, 100665314);
			AccountUtils.NativeMethodInfoPtr_ClearCredentials_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountUtils>.NativeClassPtr, 100665315);
			AccountUtils.NativeMethodInfoPtr_ClearCredentialsExceptUsername_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountUtils>.NativeClassPtr, 100665316);
			AccountUtils.NativeMethodInfoPtr_ClearProviders_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountUtils>.NativeClassPtr, 100665317);
			AccountUtils.NativeMethodInfoPtr_LogoutProviders_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountUtils>.NativeClassPtr, 100665318);
			AccountUtils.NativeMethodInfoPtr_LogoutAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountUtils>.NativeClassPtr, 100665319);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00039D8C File Offset: 0x00037F8C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 995950, RefRangeEnd = 995965, XrefRangeStart = 995949, XrefRangeEnd = 995950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AccountID GetLoggedInID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountUtils.NativeMethodInfoPtr_GetLoggedInID_Public_Static_AccountID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00039DC0 File Offset: 0x00037FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995965, XrefRangeEnd = 995966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AccountID GetLoggedInIDOrThrow()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountUtils.NativeMethodInfoPtr_GetLoggedInIDOrThrow_Public_Static_AccountID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00039DF4 File Offset: 0x00037FF4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 995967, RefRangeEnd = 995972, XrefRangeStart = 995966, XrefRangeEnd = 995967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AccountID GetLoggedInOrOfflineID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountUtils.NativeMethodInfoPtr_GetLoggedInOrOfflineID_Public_Static_AccountID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00039E28 File Offset: 0x00038028
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 995994, RefRangeEnd = 996004, XrefRangeStart = 995972, XrefRangeEnd = 995994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetLoggedInID(out AccountID id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AccountUtils.NativeMethodInfoPtr_TryGetLoggedInID_Public_Static_Boolean_byref_AccountID_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				id = ((intPtr4 == 0) ? null : new AccountID(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00039E7C File Offset: 0x0003807C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 996019, RefRangeEnd = 996023, XrefRangeStart = 996004, XrefRangeEnd = 996019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AccountID GetOfflineAccountID(int index = 0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountUtils.NativeMethodInfoPtr_GetOfflineAccountID_Public_Static_AccountID_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00039EBC File Offset: 0x000380BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 996027, RefRangeEnd = 996031, XrefRangeStart = 996023, XrefRangeEnd = 996027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AccountID GetCurrentGameAccountID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountUtils.NativeMethodInfoPtr_GetCurrentGameAccountID_Public_Static_AccountID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00039EF0 File Offset: 0x000380F0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 996041, RefRangeEnd = 996055, XrefRangeStart = 996031, XrefRangeEnd = 996041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLoggedIn()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountUtils.NativeMethodInfoPtr_IsLoggedIn_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00039F20 File Offset: 0x00038120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 996077, RefRangeEnd = 996078, XrefRangeStart = 996055, XrefRangeEnd = 996077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SaveCredentials(string username, string password, string screenName, string screenNameID, AccountID accountID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(screenName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(screenNameID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountUtils.NativeMethodInfoPtr_SaveCredentials_Public_Static_Void_String_String_String_String_AccountID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00039FA0 File Offset: 0x000381A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 996108, RefRangeEnd = 996114, XrefRangeStart = 996078, XrefRangeEnd = 996108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCredentials(bool resetLastAccountIDForPrefs = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resetLastAccountIDForPrefs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountUtils.NativeMethodInfoPtr_ClearCredentials_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00039FD4 File Offset: 0x000381D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 996136, RefRangeEnd = 996138, XrefRangeStart = 996114, XrefRangeEnd = 996136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCredentialsExceptUsername()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountUtils.NativeMethodInfoPtr_ClearCredentialsExceptUsername_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00039FFC File Offset: 0x000381FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 996154, RefRangeEnd = 996157, XrefRangeStart = 996138, XrefRangeEnd = 996154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearProviders()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountUtils.NativeMethodInfoPtr_ClearProviders_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0003A024 File Offset: 0x00038224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 996161, RefRangeEnd = 996162, XrefRangeStart = 996157, XrefRangeEnd = 996161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogoutProviders()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountUtils.NativeMethodInfoPtr_LogoutProviders_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0003A04C File Offset: 0x0003824C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 996211, RefRangeEnd = 996213, XrefRangeStart = 996162, XrefRangeEnd = 996211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogoutAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountUtils.NativeMethodInfoPtr_LogoutAll_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00007E83 File Offset: 0x00006083
		public AccountUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_GetLoggedInID_Public_Static_AccountID_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_GetLoggedInIDOrThrow_Public_Static_AccountID_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_GetLoggedInOrOfflineID_Public_Static_AccountID_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_TryGetLoggedInID_Public_Static_Boolean_byref_AccountID_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_GetOfflineAccountID_Public_Static_AccountID_Int32_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentGameAccountID_Public_Static_AccountID_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_IsLoggedIn_Public_Static_Boolean_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_SaveCredentials_Public_Static_Void_String_String_String_String_AccountID_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_ClearCredentials_Public_Static_Void_Boolean_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_ClearCredentialsExceptUsername_Public_Static_Void_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_ClearProviders_Public_Static_Void_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_LogoutProviders_Public_Static_Void_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_LogoutAll_Public_Static_Void_0;
	}
}
