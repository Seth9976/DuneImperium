using System;
using Canis.utils.ids;
using dwd.core.settings;
using dwd.core.settings.playerPrefs.definitions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.utils
{
	// Token: 0x02000109 RID: 265
	public class AccountsPrefDefinition : ListPrefDefinition<AccountID>
	{
		// Token: 0x06000CCF RID: 3279 RVA: 0x00039AA8 File Offset: 0x00037CA8
		// Note: this type is marked as 'beforefieldinit'.
		static AccountsPrefDefinition()
		{
			Il2CppClassPointerStore<AccountsPrefDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.utils", "AccountsPrefDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountsPrefDefinition>.NativeClassPtr);
			AccountsPrefDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_List_1_AccountID_IEqualityComparer_1_List_1_AccountID_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountsPrefDefinition>.NativeClassPtr, 100665304);
			AccountsPrefDefinition.NativeMethodInfoPtr_UserPref_Public_Static_AccountsPrefDefinition_String_List_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountsPrefDefinition>.NativeClassPtr, 100665305);
			AccountsPrefDefinition.NativeMethodInfoPtr_SystemPref_Public_Static_AccountsPrefDefinition_String_List_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountsPrefDefinition>.NativeClassPtr, 100665306);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00039B14 File Offset: 0x00037D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995934, XrefRangeEnd = 995937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountsPrefDefinition(string key, bool isAccountSetting, List<AccountID> defaultValue, IEqualityComparer<List<AccountID>> comparer = null, ISetting<string> namespaceSetting = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountsPrefDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAccountSetting;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountsPrefDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_List_1_AccountID_IEqualityComparer_1_List_1_AccountID_ISetting_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00039BA8 File Offset: 0x00037DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995937, XrefRangeEnd = 995943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static AccountsPrefDefinition UserPref(string key, List<AccountID> defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountsPrefDefinition.NativeMethodInfoPtr_UserPref_Public_Static_AccountsPrefDefinition_String_List_1_AccountID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountsPrefDefinition>(intPtr3) : null;
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00039C00 File Offset: 0x00037E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995943, XrefRangeEnd = 995949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static AccountsPrefDefinition SystemPref(string key, List<AccountID> defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountsPrefDefinition.NativeMethodInfoPtr_SystemPref_Public_Static_AccountsPrefDefinition_String_List_1_AccountID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountsPrefDefinition>(intPtr3) : null;
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00007E7A File Offset: 0x0000607A
		public AccountsPrefDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_List_1_AccountID_IEqualityComparer_1_List_1_AccountID_ISetting_1_String_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_UserPref_Public_Static_AccountsPrefDefinition_String_List_1_AccountID_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_SystemPref_Public_Static_AccountsPrefDefinition_String_List_1_AccountID_0;
	}
}
