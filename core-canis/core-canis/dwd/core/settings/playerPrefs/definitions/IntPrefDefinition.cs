using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.settings.playerPrefs.definitions
{
	// Token: 0x020000D9 RID: 217
	public class IntPrefDefinition : PrefDefinition<int>
	{
		// Token: 0x06000D22 RID: 3362 RVA: 0x0004698C File Offset: 0x00044B8C
		// Note: this type is marked as 'beforefieldinit'.
		static IntPrefDefinition()
		{
			Il2CppClassPointerStore<IntPrefDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs.definitions", "IntPrefDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntPrefDefinition>.NativeClassPtr);
			IntPrefDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPrefDefinition>.NativeClassPtr, 100665167);
			IntPrefDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPrefDefinition>.NativeClassPtr, 100665168);
			IntPrefDefinition.NativeMethodInfoPtr_UserPref_Public_Static_IntPrefDefinition_String_Int32_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPrefDefinition>.NativeClassPtr, 100665169);
			IntPrefDefinition.NativeMethodInfoPtr_SystemPref_Public_Static_IntPrefDefinition_String_Int32_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPrefDefinition>.NativeClassPtr, 100665170);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00046A0C File Offset: 0x00044C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865689, XrefRangeEnd = 865692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPrefDefinition(string key, bool isAccountSetting, int defaultValue, ISetting<string> namespaceSetting = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntPrefDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAccountSetting;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPrefDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_ISetting_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00046A88 File Offset: 0x00044C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865692, XrefRangeEnd = 865695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PrefSetting<int> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntPrefDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<int>>(intPtr3) : null;
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00046AD4 File Offset: 0x00044CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865695, XrefRangeEnd = 865701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPrefDefinition UserPref(string key, int defaultValue, ISetting<string> namespaceSetting = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPrefDefinition.NativeMethodInfoPtr_UserPref_Public_Static_IntPrefDefinition_String_Int32_ISetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntPrefDefinition>(intPtr3) : null;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00046B38 File Offset: 0x00044D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865701, XrefRangeEnd = 865707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPrefDefinition SystemPref(string key, int defaultValue, ISetting<string> namespaceSetting = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPrefDefinition.NativeMethodInfoPtr_SystemPref_Public_Static_IntPrefDefinition_String_Int32_ISetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntPrefDefinition>(intPtr3) : null;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00006918 File Offset: 0x00004B18
		public IntPrefDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_ISetting_1_String_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_Int32_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_UserPref_Public_Static_IntPrefDefinition_String_Int32_ISetting_1_String_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_SystemPref_Public_Static_IntPrefDefinition_String_Int32_ISetting_1_String_0;
	}
}
