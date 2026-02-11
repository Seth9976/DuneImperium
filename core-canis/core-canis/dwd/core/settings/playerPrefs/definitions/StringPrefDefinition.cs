using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.settings.playerPrefs.definitions
{
	// Token: 0x020000DD RID: 221
	public class StringPrefDefinition : PrefDefinition<string>
	{
		// Token: 0x06000D5F RID: 3423 RVA: 0x00047D98 File Offset: 0x00045F98
		// Note: this type is marked as 'beforefieldinit'.
		static StringPrefDefinition()
		{
			Il2CppClassPointerStore<StringPrefDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs.definitions", "StringPrefDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringPrefDefinition>.NativeClassPtr);
			StringPrefDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_String_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringPrefDefinition>.NativeClassPtr, 100665208);
			StringPrefDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringPrefDefinition>.NativeClassPtr, 100665209);
			StringPrefDefinition.NativeMethodInfoPtr_UserPref_Public_Static_StringPrefDefinition_String_String_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringPrefDefinition>.NativeClassPtr, 100665210);
			StringPrefDefinition.NativeMethodInfoPtr_SystemPref_Public_Static_StringPrefDefinition_String_String_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringPrefDefinition>.NativeClassPtr, 100665211);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00047E18 File Offset: 0x00046018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866049, XrefRangeEnd = 866052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringPrefDefinition(string key, bool isAccountSetting, string defaultValue, ISetting<string> namespaceSetting = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringPrefDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAccountSetting;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringPrefDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_String_ISetting_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00047E98 File Offset: 0x00046098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866052, XrefRangeEnd = 866055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PrefSetting<string> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringPrefDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<string>>(intPtr3) : null;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00047EE4 File Offset: 0x000460E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866055, XrefRangeEnd = 866061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringPrefDefinition UserPref(string key, string defaultValue, ISetting<string> namespaceSetting = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringPrefDefinition.NativeMethodInfoPtr_UserPref_Public_Static_StringPrefDefinition_String_String_ISetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr3) : null;
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00047F4C File Offset: 0x0004614C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866061, XrefRangeEnd = 866067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringPrefDefinition SystemPref(string key, string defaultValue, ISetting<string> namespaceSetting = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringPrefDefinition.NativeMethodInfoPtr_SystemPref_Public_Static_StringPrefDefinition_String_String_ISetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr3) : null;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000069D3 File Offset: 0x00004BD3
		public StringPrefDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_String_ISetting_1_String_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_String_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_UserPref_Public_Static_StringPrefDefinition_String_String_ISetting_1_String_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_SystemPref_Public_Static_StringPrefDefinition_String_String_ISetting_1_String_0;
	}
}
