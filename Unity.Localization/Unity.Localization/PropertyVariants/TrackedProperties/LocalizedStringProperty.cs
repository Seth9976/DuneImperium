using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000E4 RID: 228
	[Serializable]
	public class LocalizedStringProperty : Object
	{
		// Token: 0x06000B7F RID: 2943 RVA: 0x000349CC File Offset: 0x00032BCC
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedStringProperty()
		{
			Il2CppClassPointerStore<LocalizedStringProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "LocalizedStringProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedStringProperty>.NativeClassPtr);
			LocalizedStringProperty.NativeFieldInfoPtr_m_Localized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringProperty>.NativeClassPtr, "m_Localized");
			LocalizedStringProperty.NativeFieldInfoPtr_m_PropertyPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringProperty>.NativeClassPtr, "m_PropertyPath");
			LocalizedStringProperty.NativeMethodInfoPtr_get_LocalizedString_Public_get_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProperty>.NativeClassPtr, 100665204);
			LocalizedStringProperty.NativeMethodInfoPtr_set_LocalizedString_Public_set_Void_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProperty>.NativeClassPtr, 100665205);
			LocalizedStringProperty.NativeMethodInfoPtr_get_PropertyPath_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProperty>.NativeClassPtr, 100665206);
			LocalizedStringProperty.NativeMethodInfoPtr_set_PropertyPath_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProperty>.NativeClassPtr, 100665207);
			LocalizedStringProperty.NativeMethodInfoPtr_HasVariant_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProperty>.NativeClassPtr, 100665208);
			LocalizedStringProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProperty>.NativeClassPtr, 100665209);
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x00034A9C File Offset: 0x00032C9C
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x00034ADC File Offset: 0x00032CDC
		public unsafe LocalizedString LocalizedString
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringProperty.NativeMethodInfoPtr_get_LocalizedString_Public_get_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringProperty.NativeMethodInfoPtr_set_LocalizedString_Public_set_Void_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x00034B20 File Offset: 0x00032D20
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x00034B58 File Offset: 0x00032D58
		public unsafe virtual string PropertyPath
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringProperty.NativeMethodInfoPtr_get_PropertyPath_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringProperty.NativeMethodInfoPtr_set_PropertyPath_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00034B9C File Offset: 0x00032D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasVariant(LocaleIdentifier localeIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringProperty.NativeMethodInfoPtr_HasVariant_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00034BF0 File Offset: 0x00032DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079630, XrefRangeEnd = 1079636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedStringProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedStringProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00006C50 File Offset: 0x00004E50
		public LocalizedStringProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00034C2C File Offset: 0x00032E2C
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x00006C59 File Offset: 0x00004E59
		public unsafe LocalizedString m_Localized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedStringProperty.NativeFieldInfoPtr_m_Localized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedStringProperty.NativeFieldInfoPtr_m_Localized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00034C5C File Offset: 0x00032E5C
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x00006C78 File Offset: 0x00004E78
		public unsafe string m_PropertyPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedStringProperty.NativeFieldInfoPtr_m_PropertyPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedStringProperty.NativeFieldInfoPtr_m_PropertyPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeFieldInfoPtr_m_Localized;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyPath;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalizedString_Public_get_LocalizedString_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalizedString_Public_set_Void_LocalizedString_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyPath_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_set_PropertyPath_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_HasVariant_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
