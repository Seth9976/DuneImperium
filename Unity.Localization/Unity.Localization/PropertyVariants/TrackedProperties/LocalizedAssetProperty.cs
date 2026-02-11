using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000E3 RID: 227
	[Serializable]
	public class LocalizedAssetProperty : Object
	{
		// Token: 0x06000B73 RID: 2931 RVA: 0x00034714 File Offset: 0x00032914
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedAssetProperty()
		{
			Il2CppClassPointerStore<LocalizedAssetProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "LocalizedAssetProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedAssetProperty>.NativeClassPtr);
			LocalizedAssetProperty.NativeFieldInfoPtr_m_Localized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedAssetProperty>.NativeClassPtr, "m_Localized");
			LocalizedAssetProperty.NativeFieldInfoPtr_m_PropertyPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedAssetProperty>.NativeClassPtr, "m_PropertyPath");
			LocalizedAssetProperty.NativeMethodInfoPtr_get_LocalizedObject_Public_get_LocalizedAssetBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetProperty>.NativeClassPtr, 100665198);
			LocalizedAssetProperty.NativeMethodInfoPtr_set_LocalizedObject_Public_set_Void_LocalizedAssetBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetProperty>.NativeClassPtr, 100665199);
			LocalizedAssetProperty.NativeMethodInfoPtr_get_PropertyPath_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetProperty>.NativeClassPtr, 100665200);
			LocalizedAssetProperty.NativeMethodInfoPtr_set_PropertyPath_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetProperty>.NativeClassPtr, 100665201);
			LocalizedAssetProperty.NativeMethodInfoPtr_HasVariant_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetProperty>.NativeClassPtr, 100665202);
			LocalizedAssetProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetProperty>.NativeClassPtr, 100665203);
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x000347E4 File Offset: 0x000329E4
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x00034824 File Offset: 0x00032A24
		public unsafe LocalizedAssetBase LocalizedObject
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetProperty.NativeMethodInfoPtr_get_LocalizedObject_Public_get_LocalizedAssetBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedAssetBase>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetProperty.NativeMethodInfoPtr_set_LocalizedObject_Public_set_Void_LocalizedAssetBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00034868 File Offset: 0x00032A68
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x000348A0 File Offset: 0x00032AA0
		public unsafe virtual string PropertyPath
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetProperty.NativeMethodInfoPtr_get_PropertyPath_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetProperty.NativeMethodInfoPtr_set_PropertyPath_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x000348E4 File Offset: 0x00032AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079629, XrefRangeEnd = 1079630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasVariant(LocaleIdentifier localeIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetProperty.NativeMethodInfoPtr_HasVariant_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00034938 File Offset: 0x00032B38
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedAssetProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedAssetProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00006C09 File Offset: 0x00004E09
		public LocalizedAssetProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00034974 File Offset: 0x00032B74
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x00006C12 File Offset: 0x00004E12
		public unsafe LocalizedAssetBase m_Localized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAssetProperty.NativeFieldInfoPtr_m_Localized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedAssetBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAssetProperty.NativeFieldInfoPtr_m_Localized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x000349A4 File Offset: 0x00032BA4
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x00006C31 File Offset: 0x00004E31
		public unsafe string m_PropertyPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAssetProperty.NativeFieldInfoPtr_m_PropertyPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAssetProperty.NativeFieldInfoPtr_m_PropertyPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeFieldInfoPtr_m_Localized;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyPath;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalizedObject_Public_get_LocalizedAssetBase_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalizedObject_Public_set_Void_LocalizedAssetBase_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyPath_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_set_PropertyPath_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_HasVariant_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
