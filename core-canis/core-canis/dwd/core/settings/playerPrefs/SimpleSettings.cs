using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.playerPrefs
{
	// Token: 0x020000D4 RID: 212
	public static class SimpleSettings : Object
	{
		// Token: 0x06000CF8 RID: 3320 RVA: 0x00045A14 File Offset: 0x00043C14
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleSettings()
		{
			Il2CppClassPointerStore<SimpleSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs", "SimpleSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleSettings>.NativeClassPtr);
			SimpleSettings.NativeFieldInfoPtr_accountPrefFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSettings>.NativeClassPtr, "accountPrefFormatter");
			SimpleSettings.NativeMethodInfoPtr_get_AccountPrefFormatter_Public_Static_get_IAccountPrefFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSettings>.NativeClassPtr, 100665136);
			SimpleSettings.NativeMethodInfoPtr_set_AccountPrefFormatter_Public_Static_set_Void_IAccountPrefFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSettings>.NativeClassPtr, 100665137);
			SimpleSettings.NativeMethodInfoPtr_CreateSystemBool_Public_Static_PrefSetting_1_Boolean_String_Boolean_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSettings>.NativeClassPtr, 100665138);
			SimpleSettings.NativeMethodInfoPtr_CreateAccountBool_Public_Static_PrefSetting_1_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSettings>.NativeClassPtr, 100665139);
			SimpleSettings.NativeMethodInfoPtr_CreateSystemFloat_Public_Static_PrefSetting_1_Single_String_Single_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSettings>.NativeClassPtr, 100665140);
			SimpleSettings.NativeMethodInfoPtr_CreateAccountFloat_Public_Static_PrefSetting_1_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSettings>.NativeClassPtr, 100665141);
			SimpleSettings.NativeMethodInfoPtr_CreateSystemInt_Public_Static_PrefSetting_1_Int32_String_Int32_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSettings>.NativeClassPtr, 100665142);
			SimpleSettings.NativeMethodInfoPtr_CreateAccountInt_Public_Static_PrefSetting_1_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSettings>.NativeClassPtr, 100665143);
			SimpleSettings.NativeMethodInfoPtr_CreateSystemString_Public_Static_PrefSetting_1_String_String_String_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSettings>.NativeClassPtr, 100665144);
			SimpleSettings.NativeMethodInfoPtr_CreateAccountString_Public_Static_PrefSetting_1_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSettings>.NativeClassPtr, 100665145);
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x00045B20 File Offset: 0x00043D20
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x00045B54 File Offset: 0x00043D54
		public unsafe static IAccountPrefFormatter AccountPrefFormatter
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 865125, RefRangeEnd = 865127, XrefRangeStart = 865119, XrefRangeEnd = 865125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSettings.NativeMethodInfoPtr_get_AccountPrefFormatter_Public_Static_get_IAccountPrefFormatter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAccountPrefFormatter>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865127, XrefRangeEnd = 865131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSettings.NativeMethodInfoPtr_set_AccountPrefFormatter_Public_Static_set_Void_IAccountPrefFormatter_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00045B8C File Offset: 0x00043D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 865171, RefRangeEnd = 865172, XrefRangeStart = 865131, XrefRangeEnd = 865171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrefSetting<bool> CreateSystemBool(string key, bool defaultValue, ISetting<string> namespaceSetting = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSettings.NativeMethodInfoPtr_CreateSystemBool_Public_Static_PrefSetting_1_Boolean_String_Boolean_ISetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<bool>>(intPtr3) : null;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00045BF0 File Offset: 0x00043DF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 865218, RefRangeEnd = 865219, XrefRangeStart = 865172, XrefRangeEnd = 865218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrefSetting<bool> CreateAccountBool(string key, bool defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSettings.NativeMethodInfoPtr_CreateAccountBool_Public_Static_PrefSetting_1_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<bool>>(intPtr3) : null;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00045C44 File Offset: 0x00043E44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 865259, RefRangeEnd = 865260, XrefRangeStart = 865219, XrefRangeEnd = 865259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrefSetting<float> CreateSystemFloat(string key, float defaultValue, ISetting<string> namespaceSetting = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSettings.NativeMethodInfoPtr_CreateSystemFloat_Public_Static_PrefSetting_1_Single_String_Single_ISetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<float>>(intPtr3) : null;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00045CA8 File Offset: 0x00043EA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 865306, RefRangeEnd = 865307, XrefRangeStart = 865260, XrefRangeEnd = 865306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrefSetting<float> CreateAccountFloat(string key, float defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSettings.NativeMethodInfoPtr_CreateAccountFloat_Public_Static_PrefSetting_1_Single_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<float>>(intPtr3) : null;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00045CFC File Offset: 0x00043EFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 865347, RefRangeEnd = 865348, XrefRangeStart = 865307, XrefRangeEnd = 865347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrefSetting<int> CreateSystemInt(string key, int defaultValue, ISetting<string> namespaceSetting = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSettings.NativeMethodInfoPtr_CreateSystemInt_Public_Static_PrefSetting_1_Int32_String_Int32_ISetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<int>>(intPtr3) : null;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00045D60 File Offset: 0x00043F60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 865394, RefRangeEnd = 865395, XrefRangeStart = 865348, XrefRangeEnd = 865394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrefSetting<int> CreateAccountInt(string key, int defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSettings.NativeMethodInfoPtr_CreateAccountInt_Public_Static_PrefSetting_1_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<int>>(intPtr3) : null;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00045DB4 File Offset: 0x00043FB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 865435, RefRangeEnd = 865436, XrefRangeStart = 865395, XrefRangeEnd = 865435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrefSetting<string> CreateSystemString(string key, string defaultValue, ISetting<string> namespaceSetting = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSettings.NativeMethodInfoPtr_CreateSystemString_Public_Static_PrefSetting_1_String_String_String_ISetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<string>>(intPtr3) : null;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00045E1C File Offset: 0x0004401C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 865482, RefRangeEnd = 865483, XrefRangeStart = 865436, XrefRangeEnd = 865482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrefSetting<string> CreateAccountString(string key, string defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleSettings.NativeMethodInfoPtr_CreateAccountString_Public_Static_PrefSetting_1_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<string>>(intPtr3) : null;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x000068BA File Offset: 0x00004ABA
		public SimpleSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x00045E74 File Offset: 0x00044074
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x000068C3 File Offset: 0x00004AC3
		public unsafe static IAccountPrefFormatter accountPrefFormatter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SimpleSettings.NativeFieldInfoPtr_accountPrefFormatter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAccountPrefFormatter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleSettings.NativeFieldInfoPtr_accountPrefFormatter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeFieldInfoPtr_accountPrefFormatter;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_get_AccountPrefFormatter_Public_Static_get_IAccountPrefFormatter_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr_set_AccountPrefFormatter_Public_Static_set_Void_IAccountPrefFormatter_0;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr_CreateSystemBool_Public_Static_PrefSetting_1_Boolean_String_Boolean_ISetting_1_String_0;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_CreateAccountBool_Public_Static_PrefSetting_1_Boolean_String_Boolean_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_CreateSystemFloat_Public_Static_PrefSetting_1_Single_String_Single_ISetting_1_String_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_CreateAccountFloat_Public_Static_PrefSetting_1_Single_String_Single_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_CreateSystemInt_Public_Static_PrefSetting_1_Int32_String_Int32_ISetting_1_String_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_CreateAccountInt_Public_Static_PrefSetting_1_Int32_String_Int32_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_CreateSystemString_Public_Static_PrefSetting_1_String_String_String_ISetting_1_String_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_CreateAccountString_Public_Static_PrefSetting_1_String_String_String_0;

		// Token: 0x020002A3 RID: 675
		[ObfuscatedName("dwd.core.settings.playerPrefs.SimpleSettings+<>O")]
		public static class __O : Object
		{
			// Token: 0x06001FFE RID: 8190 RVA: 0x00090D48 File Offset: 0x0008EF48
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<SimpleSettings.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleSettings>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleSettings.__O>.NativeClassPtr);
				SimpleSettings.__O.NativeFieldInfoPtr__0___TryGetBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSettings.__O>.NativeClassPtr, "<0>__TryGetBool");
				SimpleSettings.__O.NativeFieldInfoPtr__1___SetBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSettings.__O>.NativeClassPtr, "<1>__SetBool");
				SimpleSettings.__O.NativeFieldInfoPtr__2___DeleteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSettings.__O>.NativeClassPtr, "<2>__DeleteKey");
				SimpleSettings.__O.NativeFieldInfoPtr__3___TryGetFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSettings.__O>.NativeClassPtr, "<3>__TryGetFloat");
				SimpleSettings.__O.NativeFieldInfoPtr__4___SetFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSettings.__O>.NativeClassPtr, "<4>__SetFloat");
				SimpleSettings.__O.NativeFieldInfoPtr__5___DeleteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSettings.__O>.NativeClassPtr, "<5>__DeleteKey");
				SimpleSettings.__O.NativeFieldInfoPtr__6___TryGetInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSettings.__O>.NativeClassPtr, "<6>__TryGetInt");
				SimpleSettings.__O.NativeFieldInfoPtr__7___SetInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSettings.__O>.NativeClassPtr, "<7>__SetInt");
				SimpleSettings.__O.NativeFieldInfoPtr__8___DeleteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSettings.__O>.NativeClassPtr, "<8>__DeleteKey");
				SimpleSettings.__O.NativeFieldInfoPtr__9___TryGetString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSettings.__O>.NativeClassPtr, "<9>__TryGetString");
				SimpleSettings.__O.NativeFieldInfoPtr__10___SetString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSettings.__O>.NativeClassPtr, "<10>__SetString");
				SimpleSettings.__O.NativeFieldInfoPtr__11___DeleteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSettings.__O>.NativeClassPtr, "<11>__DeleteKey");
			}

			// Token: 0x06001FFF RID: 8191 RVA: 0x0000D9E3 File Offset: 0x0000BBE3
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008B4 RID: 2228
			// (get) Token: 0x06002000 RID: 8192 RVA: 0x00090E64 File Offset: 0x0008F064
			// (set) Token: 0x06002001 RID: 8193 RVA: 0x0000D9EC File Offset: 0x0000BBEC
			public unsafe static PrefSetting<bool>.Load _0___TryGetBool
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimpleSettings.__O.NativeFieldInfoPtr__0___TryGetBool, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<bool>.Load>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimpleSettings.__O.NativeFieldInfoPtr__0___TryGetBool, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B5 RID: 2229
			// (get) Token: 0x06002002 RID: 8194 RVA: 0x00090E8C File Offset: 0x0008F08C
			// (set) Token: 0x06002003 RID: 8195 RVA: 0x0000D9FE File Offset: 0x0000BBFE
			public unsafe static PrefSetting<bool>.Store _1___SetBool
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimpleSettings.__O.NativeFieldInfoPtr__1___SetBool, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<bool>.Store>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimpleSettings.__O.NativeFieldInfoPtr__1___SetBool, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B6 RID: 2230
			// (get) Token: 0x06002004 RID: 8196 RVA: 0x00090EB4 File Offset: 0x0008F0B4
			// (set) Token: 0x06002005 RID: 8197 RVA: 0x0000DA10 File Offset: 0x0000BC10
			public unsafe static PrefSetting<bool>.DeleteKey _2___DeleteKey
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimpleSettings.__O.NativeFieldInfoPtr__2___DeleteKey, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<bool>.DeleteKey>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimpleSettings.__O.NativeFieldInfoPtr__2___DeleteKey, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B7 RID: 2231
			// (get) Token: 0x06002006 RID: 8198 RVA: 0x00090EDC File Offset: 0x0008F0DC
			// (set) Token: 0x06002007 RID: 8199 RVA: 0x0000DA22 File Offset: 0x0000BC22
			public unsafe static PrefSetting<float>.Load _3___TryGetFloat
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimpleSettings.__O.NativeFieldInfoPtr__3___TryGetFloat, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<float>.Load>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimpleSettings.__O.NativeFieldInfoPtr__3___TryGetFloat, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B8 RID: 2232
			// (get) Token: 0x06002008 RID: 8200 RVA: 0x00090F04 File Offset: 0x0008F104
			// (set) Token: 0x06002009 RID: 8201 RVA: 0x0000DA34 File Offset: 0x0000BC34
			public unsafe static PrefSetting<float>.Store _4___SetFloat
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimpleSettings.__O.NativeFieldInfoPtr__4___SetFloat, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<float>.Store>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimpleSettings.__O.NativeFieldInfoPtr__4___SetFloat, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B9 RID: 2233
			// (get) Token: 0x0600200A RID: 8202 RVA: 0x00090F2C File Offset: 0x0008F12C
			// (set) Token: 0x0600200B RID: 8203 RVA: 0x0000DA46 File Offset: 0x0000BC46
			public unsafe static PrefSetting<float>.DeleteKey _5___DeleteKey
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimpleSettings.__O.NativeFieldInfoPtr__5___DeleteKey, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<float>.DeleteKey>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimpleSettings.__O.NativeFieldInfoPtr__5___DeleteKey, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BA RID: 2234
			// (get) Token: 0x0600200C RID: 8204 RVA: 0x00090F54 File Offset: 0x0008F154
			// (set) Token: 0x0600200D RID: 8205 RVA: 0x0000DA58 File Offset: 0x0000BC58
			public unsafe static PrefSetting<int>.Load _6___TryGetInt
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimpleSettings.__O.NativeFieldInfoPtr__6___TryGetInt, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<int>.Load>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimpleSettings.__O.NativeFieldInfoPtr__6___TryGetInt, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BB RID: 2235
			// (get) Token: 0x0600200E RID: 8206 RVA: 0x00090F7C File Offset: 0x0008F17C
			// (set) Token: 0x0600200F RID: 8207 RVA: 0x0000DA6A File Offset: 0x0000BC6A
			public unsafe static PrefSetting<int>.Store _7___SetInt
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimpleSettings.__O.NativeFieldInfoPtr__7___SetInt, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<int>.Store>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimpleSettings.__O.NativeFieldInfoPtr__7___SetInt, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BC RID: 2236
			// (get) Token: 0x06002010 RID: 8208 RVA: 0x00090FA4 File Offset: 0x0008F1A4
			// (set) Token: 0x06002011 RID: 8209 RVA: 0x0000DA7C File Offset: 0x0000BC7C
			public unsafe static PrefSetting<int>.DeleteKey _8___DeleteKey
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimpleSettings.__O.NativeFieldInfoPtr__8___DeleteKey, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<int>.DeleteKey>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimpleSettings.__O.NativeFieldInfoPtr__8___DeleteKey, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BD RID: 2237
			// (get) Token: 0x06002012 RID: 8210 RVA: 0x00090FCC File Offset: 0x0008F1CC
			// (set) Token: 0x06002013 RID: 8211 RVA: 0x0000DA8E File Offset: 0x0000BC8E
			public unsafe static PrefSetting<string>.Load _9___TryGetString
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimpleSettings.__O.NativeFieldInfoPtr__9___TryGetString, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<string>.Load>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimpleSettings.__O.NativeFieldInfoPtr__9___TryGetString, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BE RID: 2238
			// (get) Token: 0x06002014 RID: 8212 RVA: 0x00090FF4 File Offset: 0x0008F1F4
			// (set) Token: 0x06002015 RID: 8213 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
			public unsafe static PrefSetting<string>.Store _10___SetString
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimpleSettings.__O.NativeFieldInfoPtr__10___SetString, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<string>.Store>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimpleSettings.__O.NativeFieldInfoPtr__10___SetString, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BF RID: 2239
			// (get) Token: 0x06002016 RID: 8214 RVA: 0x0009101C File Offset: 0x0008F21C
			// (set) Token: 0x06002017 RID: 8215 RVA: 0x0000DAB2 File Offset: 0x0000BCB2
			public unsafe static PrefSetting<string>.DeleteKey _11___DeleteKey
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimpleSettings.__O.NativeFieldInfoPtr__11___DeleteKey, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<string>.DeleteKey>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimpleSettings.__O.NativeFieldInfoPtr__11___DeleteKey, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001657 RID: 5719
			private static readonly IntPtr NativeFieldInfoPtr__0___TryGetBool;

			// Token: 0x04001658 RID: 5720
			private static readonly IntPtr NativeFieldInfoPtr__1___SetBool;

			// Token: 0x04001659 RID: 5721
			private static readonly IntPtr NativeFieldInfoPtr__2___DeleteKey;

			// Token: 0x0400165A RID: 5722
			private static readonly IntPtr NativeFieldInfoPtr__3___TryGetFloat;

			// Token: 0x0400165B RID: 5723
			private static readonly IntPtr NativeFieldInfoPtr__4___SetFloat;

			// Token: 0x0400165C RID: 5724
			private static readonly IntPtr NativeFieldInfoPtr__5___DeleteKey;

			// Token: 0x0400165D RID: 5725
			private static readonly IntPtr NativeFieldInfoPtr__6___TryGetInt;

			// Token: 0x0400165E RID: 5726
			private static readonly IntPtr NativeFieldInfoPtr__7___SetInt;

			// Token: 0x0400165F RID: 5727
			private static readonly IntPtr NativeFieldInfoPtr__8___DeleteKey;

			// Token: 0x04001660 RID: 5728
			private static readonly IntPtr NativeFieldInfoPtr__9___TryGetString;

			// Token: 0x04001661 RID: 5729
			private static readonly IntPtr NativeFieldInfoPtr__10___SetString;

			// Token: 0x04001662 RID: 5730
			private static readonly IntPtr NativeFieldInfoPtr__11___DeleteKey;
		}
	}
}
