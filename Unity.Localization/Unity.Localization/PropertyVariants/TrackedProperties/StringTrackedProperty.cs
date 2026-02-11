using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000F6 RID: 246
	[Serializable]
	public class StringTrackedProperty : TrackedProperty<string>
	{
		// Token: 0x06000BD7 RID: 3031 RVA: 0x00035C30 File Offset: 0x00033E30
		// Note: this type is marked as 'beforefieldinit'.
		static StringTrackedProperty()
		{
			Il2CppClassPointerStore<StringTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "StringTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringTrackedProperty>.NativeClassPtr);
			StringTrackedProperty.NativeMethodInfoPtr_ConvertFromString_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTrackedProperty>.NativeClassPtr, 100665247);
			StringTrackedProperty.NativeMethodInfoPtr_ConvertToString_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTrackedProperty>.NativeClassPtr, 100665248);
			StringTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTrackedProperty>.NativeClassPtr, 100665249);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00035C9C File Offset: 0x00033E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ConvertFromString(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringTrackedProperty.NativeMethodInfoPtr_ConvertFromString_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00035CF0 File Offset: 0x00033EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ConvertToString(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringTrackedProperty.NativeMethodInfoPtr_ConvertToString_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00035D44 File Offset: 0x00033F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079855, XrefRangeEnd = 1079858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x000070A1 File Offset: 0x000052A1
		public StringTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromString_Protected_Virtual_String_String_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToString_Protected_Virtual_String_String_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
