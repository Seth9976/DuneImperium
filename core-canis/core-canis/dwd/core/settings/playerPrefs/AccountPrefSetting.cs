using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.playerPrefs
{
	// Token: 0x020000C9 RID: 201
	public class AccountPrefSetting<T> : PrefSetting<T>
	{
		// Token: 0x06000C81 RID: 3201 RVA: 0x00043730 File Offset: 0x00041930
		// Note: this type is marked as 'beforefieldinit'.
		static AccountPrefSetting()
		{
			Il2CppClassPointerStore<AccountPrefSetting<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs", "AccountPrefSetting`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountPrefSetting<T>>.NativeClassPtr);
			AccountPrefSetting<T>.NativeFieldInfoPtr_accountPrefFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountPrefSetting<T>>.NativeClassPtr, "accountPrefFormatter");
			AccountPrefSetting<T>.NativeFieldInfoPtr_accountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountPrefSetting<T>>.NativeClassPtr, "accountKey");
			AccountPrefSetting<T>.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountPrefSetting<T>>.NativeClassPtr, "cachedVersion");
			AccountPrefSetting<T>.NativeMethodInfoPtr__ctor_Public_Void_String_T_Load_T_Store_T_DeleteKey_T_IAccountPrefFormatter_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountPrefSetting<T>>.NativeClassPtr, 100665056);
			AccountPrefSetting<T>.NativeMethodInfoPtr_Get_Public_Virtual_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountPrefSetting<T>>.NativeClassPtr, 100665057);
			AccountPrefSetting<T>.NativeMethodInfoPtr_get_storageKey_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountPrefSetting<T>>.NativeClassPtr, 100665058);
			AccountPrefSetting<T>.NativeMethodInfoPtr_updateAccountID_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountPrefSetting<T>>.NativeClassPtr, 100665059);
			AccountPrefSetting<T>.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountPrefSetting<T>>.NativeClassPtr, 100665060);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0004383C File Offset: 0x00041A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 864526, RefRangeEnd = 864527, XrefRangeStart = 864522, XrefRangeEnd = 864526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountPrefSetting(string key, T defaultValue, PrefSetting<T>.Load load, PrefSetting<T>.Store save, PrefSetting<T>.DeleteKey delete, IAccountPrefFormatter accountPrefFormatter, IEqualityComparer<T> comparer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountPrefSetting<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = defaultValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultValue;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(load);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(save);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(delete);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountPrefFormatter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AccountPrefSetting<T>.NativeMethodInfoPtr__ctor_Public_Void_String_T_Load_T_Store_T_DeleteKey_T_IAccountPrefFormatter_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00043930 File Offset: 0x00041B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864527, XrefRangeEnd = 864543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override T Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AccountPrefSetting<T>.NativeMethodInfoPtr_Get_Public_Virtual_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00043974 File Offset: 0x00041B74
		public unsafe override string storageKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864543, XrefRangeEnd = 864544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AccountPrefSetting<T>.NativeMethodInfoPtr_get_storageKey_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x000439B8 File Offset: 0x00041BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864544, XrefRangeEnd = 864551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateAccountID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountPrefSetting<T>.NativeMethodInfoPtr_updateAccountID_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x000439EC File Offset: 0x00041BEC
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864551, XrefRangeEnd = 864568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AccountPrefSetting<T>.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x000066B9 File Offset: 0x000048B9
		public AccountPrefSetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00043A34 File Offset: 0x00041C34
		// (set) Token: 0x06000C89 RID: 3209 RVA: 0x000066C2 File Offset: 0x000048C2
		public unsafe IAccountPrefFormatter accountPrefFormatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPrefSetting<T>.NativeFieldInfoPtr_accountPrefFormatter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAccountPrefFormatter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPrefSetting<T>.NativeFieldInfoPtr_accountPrefFormatter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x00043A64 File Offset: 0x00041C64
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x000066E1 File Offset: 0x000048E1
		public unsafe string accountKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPrefSetting<T>.NativeFieldInfoPtr_accountKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPrefSetting<T>.NativeFieldInfoPtr_accountKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00043A8C File Offset: 0x00041C8C
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00006700 File Offset: 0x00004900
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPrefSetting<T>.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPrefSetting<T>.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeFieldInfoPtr_accountPrefFormatter;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeFieldInfoPtr_accountKey;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_T_Load_T_Store_T_DeleteKey_T_IAccountPrefFormatter_IEqualityComparer_1_T_0;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_T_0;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr_get_storageKey_Protected_Virtual_get_String_0;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr_updateAccountID_Private_Void_0;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;
	}
}
