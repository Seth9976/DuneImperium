using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000F5 RID: 245
	[Serializable]
	public class BoolTrackedProperty : TrackedProperty<bool>
	{
		// Token: 0x06000BD2 RID: 3026 RVA: 0x00035AE0 File Offset: 0x00033CE0
		// Note: this type is marked as 'beforefieldinit'.
		static BoolTrackedProperty()
		{
			Il2CppClassPointerStore<BoolTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "BoolTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolTrackedProperty>.NativeClassPtr);
			BoolTrackedProperty.NativeMethodInfoPtr_ConvertFromString_Protected_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolTrackedProperty>.NativeClassPtr, 100665244);
			BoolTrackedProperty.NativeMethodInfoPtr_ConvertToString_Protected_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolTrackedProperty>.NativeClassPtr, 100665245);
			BoolTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolTrackedProperty>.NativeClassPtr, 100665246);
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00035B4C File Offset: 0x00033D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079839, XrefRangeEnd = 1079848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ConvertFromString(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolTrackedProperty.NativeMethodInfoPtr_ConvertFromString_Protected_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00035BA4 File Offset: 0x00033DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079848, XrefRangeEnd = 1079852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ConvertToString(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolTrackedProperty.NativeMethodInfoPtr_ConvertToString_Protected_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00035BF4 File Offset: 0x00033DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079852, XrefRangeEnd = 1079855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00007098 File Offset: 0x00005298
		public BoolTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromString_Protected_Virtual_Boolean_String_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToString_Protected_Virtual_String_Boolean_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
