using System;
using dwd.core.account;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.playerPrefs
{
	// Token: 0x020000C8 RID: 200
	public class AccountPrefFormatter : Object
	{
		// Token: 0x06000C7A RID: 3194 RVA: 0x00043560 File Offset: 0x00041760
		// Note: this type is marked as 'beforefieldinit'.
		static AccountPrefFormatter()
		{
			Il2CppClassPointerStore<AccountPrefFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs", "AccountPrefFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountPrefFormatter>.NativeClassPtr);
			AccountPrefFormatter.NativeMethodInfoPtr_get_accountProvider_Private_get_AccountProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountPrefFormatter>.NativeClassPtr, 100665051);
			AccountPrefFormatter.NativeMethodInfoPtr_AccountPrefKey_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountPrefFormatter>.NativeClassPtr, 100665052);
			AccountPrefFormatter.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountPrefFormatter>.NativeClassPtr, 100665053);
			AccountPrefFormatter.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountPrefFormatter>.NativeClassPtr, 100665054);
			AccountPrefFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountPrefFormatter>.NativeClassPtr, 100665055);
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x000435F4 File Offset: 0x000417F4
		public unsafe AccountProvider accountProvider
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864485, XrefRangeEnd = 864488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountPrefFormatter.NativeMethodInfoPtr_get_accountProvider_Private_get_AccountProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00043634 File Offset: 0x00041834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864488, XrefRangeEnd = 864505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string AccountPrefKey(string baseKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountPrefFormatter.NativeMethodInfoPtr_AccountPrefKey_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x0004367C File Offset: 0x0004187C
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864505, XrefRangeEnd = 864512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountPrefFormatter.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x000436B8 File Offset: 0x000418B8
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864512, XrefRangeEnd = 864522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountPrefFormatter.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x000436F4 File Offset: 0x000418F4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountPrefFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountPrefFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountPrefFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000066B0 File Offset: 0x000048B0
		public AccountPrefFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeMethodInfoPtr_get_accountProvider_Private_get_AccountProvider_0;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeMethodInfoPtr_AccountPrefKey_Public_Virtual_Final_New_String_String_0;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
