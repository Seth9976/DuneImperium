using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.settings.playerPrefs.definitions
{
	// Token: 0x020000D8 RID: 216
	public class FloatPrefDefinition : PrefDefinition<float>
	{
		// Token: 0x06000D1C RID: 3356 RVA: 0x0004677C File Offset: 0x0004497C
		// Note: this type is marked as 'beforefieldinit'.
		static FloatPrefDefinition()
		{
			Il2CppClassPointerStore<FloatPrefDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs.definitions", "FloatPrefDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatPrefDefinition>.NativeClassPtr);
			FloatPrefDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Single_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatPrefDefinition>.NativeClassPtr, 100665163);
			FloatPrefDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatPrefDefinition>.NativeClassPtr, 100665164);
			FloatPrefDefinition.NativeMethodInfoPtr_UserPref_Public_Static_FloatPrefDefinition_String_Single_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatPrefDefinition>.NativeClassPtr, 100665165);
			FloatPrefDefinition.NativeMethodInfoPtr_SystemPref_Public_Static_FloatPrefDefinition_String_Single_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatPrefDefinition>.NativeClassPtr, 100665166);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x000467FC File Offset: 0x000449FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865671, XrefRangeEnd = 865674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatPrefDefinition(string key, bool isAccountSetting, float defaultValue, ISetting<string> namespaceSetting = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatPrefDefinition>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatPrefDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Single_ISetting_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00046878 File Offset: 0x00044A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865674, XrefRangeEnd = 865677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PrefSetting<float> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloatPrefDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<float>>(intPtr3) : null;
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x000468C4 File Offset: 0x00044AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865677, XrefRangeEnd = 865683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FloatPrefDefinition UserPref(string key, float defaultValue, ISetting<string> namespaceSetting = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatPrefDefinition.NativeMethodInfoPtr_UserPref_Public_Static_FloatPrefDefinition_String_Single_ISetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FloatPrefDefinition>(intPtr3) : null;
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00046928 File Offset: 0x00044B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865683, XrefRangeEnd = 865689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FloatPrefDefinition SystemPref(string key, float defaultValue, ISetting<string> namespaceSetting = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatPrefDefinition.NativeMethodInfoPtr_SystemPref_Public_Static_FloatPrefDefinition_String_Single_ISetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FloatPrefDefinition>(intPtr3) : null;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0000690F File Offset: 0x00004B0F
		public FloatPrefDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Single_ISetting_1_String_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_Single_0;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_UserPref_Public_Static_FloatPrefDefinition_String_Single_ISetting_1_String_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_SystemPref_Public_Static_FloatPrefDefinition_String_Single_ISetting_1_String_0;
	}
}
