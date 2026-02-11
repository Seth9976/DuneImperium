using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000FF RID: 255
	public class CultureInfoConverter : TypeConverter
	{
		// Token: 0x06001013 RID: 4115 RVA: 0x00058A50 File Offset: 0x00056C50
		// Note: this type is marked as 'beforefieldinit'.
		static CultureInfoConverter()
		{
			Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "CultureInfoConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr);
			CultureInfoConverter.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr, "_values");
			CultureInfoConverter.NativeFieldInfoPtr_DefaultInvariantCultureString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr, "DefaultInvariantCultureString");
			CultureInfoConverter.NativeMethodInfoPtr_get_DefaultCultureString_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr, 100665608);
			CultureInfoConverter.NativeMethodInfoPtr_GetCultureName_Protected_Virtual_New_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr, 100665609);
			CultureInfoConverter.NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr, 100665610);
			CultureInfoConverter.NativeMethodInfoPtr_CanConvertTo_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr, 100665611);
			CultureInfoConverter.NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr, 100665612);
			CultureInfoConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr, 100665613);
			CultureInfoConverter.NativeMethodInfoPtr_GetStandardValues_Public_Virtual_StandardValuesCollection_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr, 100665614);
			CultureInfoConverter.NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Virtual_Boolean_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr, 100665615);
			CultureInfoConverter.NativeMethodInfoPtr_GetStandardValuesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr, 100665616);
			CultureInfoConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr, 100665617);
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x00058B70 File Offset: 0x00056D70
		public unsafe string DefaultCultureString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458415, XrefRangeEnd = 458417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfoConverter.NativeMethodInfoPtr_get_DefaultCultureString_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00058BA8 File Offset: 0x00056DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458417, XrefRangeEnd = 458418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetCultureName(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfoConverter.NativeMethodInfoPtr_GetCultureName_Protected_Virtual_New_String_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00058BFC File Offset: 0x00056DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458418, XrefRangeEnd = 458427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfoConverter.NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00058C68 File Offset: 0x00056E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458427, XrefRangeEnd = 458436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfoConverter.NativeMethodInfoPtr_CanConvertTo_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00058CD4 File Offset: 0x00056ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458436, XrefRangeEnd = 458513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfoConverter.NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00058D54 File Offset: 0x00056F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458513, XrefRangeEnd = 458558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfoConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00058DE8 File Offset: 0x00056FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458558, XrefRangeEnd = 458588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfoConverter.NativeMethodInfoPtr_GetStandardValues_Public_Virtual_StandardValuesCollection_ITypeDescriptorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter.StandardValuesCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00058E44 File Offset: 0x00057044
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfoConverter.NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Virtual_Boolean_ITypeDescriptorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00058E9C File Offset: 0x0005709C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfoConverter.NativeMethodInfoPtr_GetStandardValuesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00058EF4 File Offset: 0x000570F4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfoConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfoConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00007C6B File Offset: 0x00005E6B
		public CultureInfoConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x00058F30 File Offset: 0x00057130
		// (set) Token: 0x06001020 RID: 4128 RVA: 0x00007C74 File Offset: 0x00005E74
		public unsafe TypeConverter.StandardValuesCollection _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfoConverter.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeConverter.StandardValuesCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfoConverter.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x00058F60 File Offset: 0x00057160
		// (set) Token: 0x06001022 RID: 4130 RVA: 0x00007C93 File Offset: 0x00005E93
		public unsafe static string DefaultInvariantCultureString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfoConverter.NativeFieldInfoPtr_DefaultInvariantCultureString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfoConverter.NativeFieldInfoPtr_DefaultInvariantCultureString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeFieldInfoPtr_DefaultInvariantCultureString;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultCultureString_Private_get_String_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureName_Protected_Virtual_New_String_CultureInfo_0;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertTo_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValues_Public_Virtual_StandardValuesCollection_ITypeDescriptorContext_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Virtual_Boolean_ITypeDescriptorContext_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValuesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D9 RID: 729
		public class CultureComparer : Object
		{
			// Token: 0x06002C0D RID: 11277 RVA: 0x000C24D8 File Offset: 0x000C06D8
			// Note: this type is marked as 'beforefieldinit'.
			static CultureComparer()
			{
				Il2CppClassPointerStore<CultureInfoConverter.CultureComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr, "CultureComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureInfoConverter.CultureComparer>.NativeClassPtr);
				CultureInfoConverter.CultureComparer.NativeFieldInfoPtr__converter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfoConverter.CultureComparer>.NativeClassPtr, "_converter");
				CultureInfoConverter.CultureComparer.NativeMethodInfoPtr__ctor_Public_Void_CultureInfoConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfoConverter.CultureComparer>.NativeClassPtr, 100665618);
				CultureInfoConverter.CultureComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfoConverter.CultureComparer>.NativeClassPtr, 100665619);
			}

			// Token: 0x06002C0E RID: 11278 RVA: 0x000C2540 File Offset: 0x000C0740
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CultureComparer(CultureInfoConverter cultureConverter)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfoConverter.CultureComparer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cultureConverter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfoConverter.CultureComparer.NativeMethodInfoPtr__ctor_Public_Void_CultureInfoConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C0F RID: 11279 RVA: 0x000C258C File Offset: 0x000C078C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456751, XrefRangeEnd = 456757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(Object item1, Object item2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfoConverter.CultureComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002C10 RID: 11280 RVA: 0x00013DAE File Offset: 0x00011FAE
			public CultureComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DD4 RID: 3540
			// (get) Token: 0x06002C11 RID: 11281 RVA: 0x000C25EC File Offset: 0x000C07EC
			// (set) Token: 0x06002C12 RID: 11282 RVA: 0x00013DB7 File Offset: 0x00011FB7
			public unsafe CultureInfoConverter _converter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfoConverter.CultureComparer.NativeFieldInfoPtr__converter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfoConverter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfoConverter.CultureComparer.NativeFieldInfoPtr__converter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022D5 RID: 8917
			private static readonly IntPtr NativeFieldInfoPtr__converter;

			// Token: 0x040022D6 RID: 8918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CultureInfoConverter_0;

			// Token: 0x040022D7 RID: 8919
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;
		}

		// Token: 0x020002DA RID: 730
		public static class CultureInfoMapper : Object
		{
			// Token: 0x06002C13 RID: 11283 RVA: 0x000C261C File Offset: 0x000C081C
			// Note: this type is marked as 'beforefieldinit'.
			static CultureInfoMapper()
			{
				Il2CppClassPointerStore<CultureInfoConverter.CultureInfoMapper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CultureInfoConverter>.NativeClassPtr, "CultureInfoMapper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureInfoConverter.CultureInfoMapper>.NativeClassPtr);
				CultureInfoConverter.CultureInfoMapper.NativeFieldInfoPtr_s_cultureInfoNameMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfoConverter.CultureInfoMapper>.NativeClassPtr, "s_cultureInfoNameMap");
				CultureInfoConverter.CultureInfoMapper.NativeMethodInfoPtr_CreateMap_Private_Static_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfoConverter.CultureInfoMapper>.NativeClassPtr, 100665620);
				CultureInfoConverter.CultureInfoMapper.NativeMethodInfoPtr_GetCultureInfoName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfoConverter.CultureInfoMapper>.NativeClassPtr, 100665621);
			}

			// Token: 0x06002C14 RID: 11284 RVA: 0x000C2684 File Offset: 0x000C0884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456757, XrefRangeEnd = 458408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Dictionary<string, string> CreateMap()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfoConverter.CultureInfoMapper.NativeMethodInfoPtr_CreateMap_Private_Static_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}

			// Token: 0x06002C15 RID: 11285 RVA: 0x000C26B8 File Offset: 0x000C08B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458408, XrefRangeEnd = 458415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string GetCultureInfoName(string cultureInfoDisplayName)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureInfoDisplayName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfoConverter.CultureInfoMapper.NativeMethodInfoPtr_GetCultureInfoName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002C16 RID: 11286 RVA: 0x00013DD6 File Offset: 0x00011FD6
			public CultureInfoMapper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DD5 RID: 3541
			// (get) Token: 0x06002C17 RID: 11287 RVA: 0x000C26F4 File Offset: 0x000C08F4
			// (set) Token: 0x06002C18 RID: 11288 RVA: 0x00013DDF File Offset: 0x00011FDF
			public unsafe static Dictionary<string, string> s_cultureInfoNameMap
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CultureInfoConverter.CultureInfoMapper.NativeFieldInfoPtr_s_cultureInfoNameMap, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CultureInfoConverter.CultureInfoMapper.NativeFieldInfoPtr_s_cultureInfoNameMap, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022D8 RID: 8920
			private static readonly IntPtr NativeFieldInfoPtr_s_cultureInfoNameMap;

			// Token: 0x040022D9 RID: 8921
			private static readonly IntPtr NativeMethodInfoPtr_CreateMap_Private_Static_Dictionary_2_String_String_0;

			// Token: 0x040022DA RID: 8922
			private static readonly IntPtr NativeMethodInfoPtr_GetCultureInfoName_Public_Static_String_String_0;
		}
	}
}
