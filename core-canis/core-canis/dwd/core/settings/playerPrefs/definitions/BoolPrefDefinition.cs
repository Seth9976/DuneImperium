using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.settings.playerPrefs.definitions
{
	// Token: 0x020000D5 RID: 213
	public class BoolPrefDefinition : PrefDefinition<bool>
	{
		// Token: 0x06000D06 RID: 3334 RVA: 0x00045E9C File Offset: 0x0004409C
		// Note: this type is marked as 'beforefieldinit'.
		static BoolPrefDefinition()
		{
			Il2CppClassPointerStore<BoolPrefDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs.definitions", "BoolPrefDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolPrefDefinition>.NativeClassPtr);
			BoolPrefDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolPrefDefinition>.NativeClassPtr, 100665146);
			BoolPrefDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolPrefDefinition>.NativeClassPtr, 100665147);
			BoolPrefDefinition.NativeMethodInfoPtr_UserPref_Public_Static_BoolPrefDefinition_String_Boolean_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolPrefDefinition>.NativeClassPtr, 100665148);
			BoolPrefDefinition.NativeMethodInfoPtr_SystemPref_Public_Static_BoolPrefDefinition_String_Boolean_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolPrefDefinition>.NativeClassPtr, 100665149);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00045F1C File Offset: 0x0004411C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865483, XrefRangeEnd = 865486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolPrefDefinition(string key, bool isAccountSetting, bool defaultValue, ISetting<string> namespaceSetting = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolPrefDefinition>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolPrefDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_ISetting_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00045F98 File Offset: 0x00044198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865486, XrefRangeEnd = 865489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PrefSetting<bool> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolPrefDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<bool>>(intPtr3) : null;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00045FE4 File Offset: 0x000441E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865489, XrefRangeEnd = 865495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BoolPrefDefinition UserPref(string key, bool defaultValue, ISetting<string> namespaceSetting = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolPrefDefinition.NativeMethodInfoPtr_UserPref_Public_Static_BoolPrefDefinition_String_Boolean_ISetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr3) : null;
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00046048 File Offset: 0x00044248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865495, XrefRangeEnd = 865501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BoolPrefDefinition SystemPref(string key, bool defaultValue, ISetting<string> namespaceSetting = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolPrefDefinition.NativeMethodInfoPtr_SystemPref_Public_Static_BoolPrefDefinition_String_Boolean_ISetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr3) : null;
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x000068D5 File Offset: 0x00004AD5
		public BoolPrefDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_ISetting_1_String_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_Boolean_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_UserPref_Public_Static_BoolPrefDefinition_String_Boolean_ISetting_1_String_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_SystemPref_Public_Static_BoolPrefDefinition_String_Boolean_ISetting_1_String_0;
	}
}
