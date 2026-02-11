using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000F7 RID: 247
	[Serializable]
	public class UnityObjectProperty : Object
	{
		// Token: 0x06000BDC RID: 3036 RVA: 0x00035D80 File Offset: 0x00033F80
		// Note: this type is marked as 'beforefieldinit'.
		static UnityObjectProperty()
		{
			Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "UnityObjectProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr);
			UnityObjectProperty.NativeFieldInfoPtr_m_PropertyPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, "m_PropertyPath");
			UnityObjectProperty.NativeFieldInfoPtr_m_TypeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, "m_TypeString");
			UnityObjectProperty.NativeFieldInfoPtr_m_VariantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, "m_VariantData");
			UnityObjectProperty.NativeFieldInfoPtr_m_VariantLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, "m_VariantLookup");
			UnityObjectProperty.NativeFieldInfoPtr__PropertyType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, "<PropertyType>k__BackingField");
			UnityObjectProperty.NativeMethodInfoPtr_get_PropertyPath_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, 100665250);
			UnityObjectProperty.NativeMethodInfoPtr_set_PropertyPath_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, 100665251);
			UnityObjectProperty.NativeMethodInfoPtr_get_PropertyType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, 100665252);
			UnityObjectProperty.NativeMethodInfoPtr_set_PropertyType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, 100665253);
			UnityObjectProperty.NativeMethodInfoPtr_HasVariant_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, 100665254);
			UnityObjectProperty.NativeMethodInfoPtr_RemoveVariant_Public_Void_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, 100665255);
			UnityObjectProperty.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Boolean_LocaleIdentifier_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, 100665256);
			UnityObjectProperty.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Boolean_LocaleIdentifier_LocaleIdentifier_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, 100665257);
			UnityObjectProperty.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_LocaleIdentifier_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, 100665258);
			UnityObjectProperty.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, 100665259);
			UnityObjectProperty.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, 100665260);
			UnityObjectProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, 100665261);
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00035F04 File Offset: 0x00034104
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x00035F3C File Offset: 0x0003413C
		public unsafe virtual string PropertyPath
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityObjectProperty.NativeMethodInfoPtr_get_PropertyPath_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityObjectProperty.NativeMethodInfoPtr_set_PropertyPath_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00035F80 File Offset: 0x00034180
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x00035FC0 File Offset: 0x000341C0
		public unsafe Type PropertyType
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityObjectProperty.NativeMethodInfoPtr_get_PropertyType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityObjectProperty.NativeMethodInfoPtr_set_PropertyType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00036004 File Offset: 0x00034204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079858, XrefRangeEnd = 1079861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasVariant(LocaleIdentifier localeIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityObjectProperty.NativeMethodInfoPtr_HasVariant_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00036058 File Offset: 0x00034258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079861, XrefRangeEnd = 1079864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveVariant(LocaleIdentifier localeIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityObjectProperty.NativeMethodInfoPtr_RemoveVariant_Public_Void_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x000360A0 File Offset: 0x000342A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079864, XrefRangeEnd = 1079869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetValue(LocaleIdentifier localeIdentifier, out Object foundValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnityObjectProperty.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Boolean_LocaleIdentifier_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			foundValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00036118 File Offset: 0x00034318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079869, XrefRangeEnd = 1079876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetValue(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback, out Object foundValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fallback));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnityObjectProperty.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Boolean_LocaleIdentifier_LocaleIdentifier_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			foundValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000361A4 File Offset: 0x000343A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079876, XrefRangeEnd = 1079890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValue(LocaleIdentifier localeIdentifier, Object newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityObjectProperty.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_LocaleIdentifier_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00036200 File Offset: 0x00034400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079890, XrefRangeEnd = 1079916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityObjectProperty.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00036234 File Offset: 0x00034434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079916, XrefRangeEnd = 1079946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityObjectProperty.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00036268 File Offset: 0x00034468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079946, XrefRangeEnd = 1079961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityObjectProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityObjectProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x000070AA File Offset: 0x000052AA
		public UnityObjectProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x000362A4 File Offset: 0x000344A4
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x000070B3 File Offset: 0x000052B3
		public unsafe string m_PropertyPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityObjectProperty.NativeFieldInfoPtr_m_PropertyPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityObjectProperty.NativeFieldInfoPtr_m_PropertyPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x000362CC File Offset: 0x000344CC
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x000070D2 File Offset: 0x000052D2
		public unsafe string m_TypeString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityObjectProperty.NativeFieldInfoPtr_m_TypeString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityObjectProperty.NativeFieldInfoPtr_m_TypeString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x000362F4 File Offset: 0x000344F4
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x000070F1 File Offset: 0x000052F1
		public unsafe List<UnityObjectProperty.LocaleIdentifierValuePair> m_VariantData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityObjectProperty.NativeFieldInfoPtr_m_VariantData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityObjectProperty.LocaleIdentifierValuePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityObjectProperty.NativeFieldInfoPtr_m_VariantData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00036324 File Offset: 0x00034524
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00007110 File Offset: 0x00005310
		public unsafe Dictionary<LocaleIdentifier, UnityObjectProperty.LocaleIdentifierValuePair> m_VariantLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityObjectProperty.NativeFieldInfoPtr_m_VariantLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LocaleIdentifier, UnityObjectProperty.LocaleIdentifierValuePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityObjectProperty.NativeFieldInfoPtr_m_VariantLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00036354 File Offset: 0x00034554
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x0000712F File Offset: 0x0000532F
		public unsafe Type _PropertyType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityObjectProperty.NativeFieldInfoPtr__PropertyType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityObjectProperty.NativeFieldInfoPtr__PropertyType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyPath;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeFieldInfoPtr_m_TypeString;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeFieldInfoPtr_m_VariantData;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeFieldInfoPtr_m_VariantLookup;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeFieldInfoPtr__PropertyType_k__BackingField;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyPath_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_set_PropertyPath_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyType_Public_get_Type_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_set_PropertyType_Public_set_Void_Type_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_HasVariant_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_RemoveVariant_Public_Void_LocaleIdentifier_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Boolean_LocaleIdentifier_byref_Object_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Boolean_LocaleIdentifier_LocaleIdentifier_byref_Object_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_LocaleIdentifier_Object_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000182 RID: 386
		[Serializable]
		public class LocaleIdentifierValuePair : Object
		{
			// Token: 0x06000FDA RID: 4058 RVA: 0x000436B4 File Offset: 0x000418B4
			// Note: this type is marked as 'beforefieldinit'.
			static LocaleIdentifierValuePair()
			{
				Il2CppClassPointerStore<UnityObjectProperty.LocaleIdentifierValuePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityObjectProperty>.NativeClassPtr, "LocaleIdentifierValuePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityObjectProperty.LocaleIdentifierValuePair>.NativeClassPtr);
				UnityObjectProperty.LocaleIdentifierValuePair.NativeFieldInfoPtr_localeIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityObjectProperty.LocaleIdentifierValuePair>.NativeClassPtr, "localeIdentifier");
				UnityObjectProperty.LocaleIdentifierValuePair.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityObjectProperty.LocaleIdentifierValuePair>.NativeClassPtr, "value");
				UnityObjectProperty.LocaleIdentifierValuePair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityObjectProperty.LocaleIdentifierValuePair>.NativeClassPtr, 100665262);
			}

			// Token: 0x06000FDB RID: 4059 RVA: 0x0004371C File Offset: 0x0004191C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LocaleIdentifierValuePair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityObjectProperty.LocaleIdentifierValuePair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityObjectProperty.LocaleIdentifierValuePair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FDC RID: 4060 RVA: 0x000089E0 File Offset: 0x00006BE0
			public LocaleIdentifierValuePair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700043E RID: 1086
			// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00043758 File Offset: 0x00041958
			// (set) Token: 0x06000FDE RID: 4062 RVA: 0x000089E9 File Offset: 0x00006BE9
			public LocaleIdentifier localeIdentifier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityObjectProperty.LocaleIdentifierValuePair.NativeFieldInfoPtr_localeIdentifier);
					return new LocaleIdentifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityObjectProperty.LocaleIdentifierValuePair.NativeFieldInfoPtr_localeIdentifier), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700043F RID: 1087
			// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00043788 File Offset: 0x00041988
			// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x00008A17 File Offset: 0x00006C17
			public LazyLoadReference<Object> value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityObjectProperty.LocaleIdentifierValuePair.NativeFieldInfoPtr_value);
					return new LazyLoadReference<Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LazyLoadReference<Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityObjectProperty.LocaleIdentifierValuePair.NativeFieldInfoPtr_value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LazyLoadReference<Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000AE2 RID: 2786
			private static readonly IntPtr NativeFieldInfoPtr_localeIdentifier;

			// Token: 0x04000AE3 RID: 2787
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04000AE4 RID: 2788
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
