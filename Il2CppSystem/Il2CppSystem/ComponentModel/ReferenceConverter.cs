using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000124 RID: 292
	public class ReferenceConverter : TypeConverter
	{
		// Token: 0x06001204 RID: 4612 RVA: 0x000613B4 File Offset: 0x0005F5B4
		// Note: this type is marked as 'beforefieldinit'.
		static ReferenceConverter()
		{
			Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ReferenceConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr);
			ReferenceConverter.NativeFieldInfoPtr_s_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr, "s_none");
			ReferenceConverter.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr, "_type");
			ReferenceConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr, 100665928);
			ReferenceConverter.NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr, 100665929);
			ReferenceConverter.NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr, 100665930);
			ReferenceConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr, 100665931);
			ReferenceConverter.NativeMethodInfoPtr_GetStandardValues_Public_Virtual_StandardValuesCollection_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr, 100665932);
			ReferenceConverter.NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Virtual_Boolean_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr, 100665933);
			ReferenceConverter.NativeMethodInfoPtr_GetStandardValuesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr, 100665934);
			ReferenceConverter.NativeMethodInfoPtr_IsValueAllowed_Protected_Virtual_New_Boolean_ITypeDescriptorContext_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr, 100665935);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x000614AC File Offset: 0x0005F6AC
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReferenceConverter(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x000614F8 File Offset: 0x0005F6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460098, XrefRangeEnd = 460107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReferenceConverter.NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00061564 File Offset: 0x0005F764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460107, XrefRangeEnd = 460131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReferenceConverter.NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x000615E4 File Offset: 0x0005F7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460131, XrefRangeEnd = 460154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReferenceConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00061678 File Offset: 0x0005F878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460154, XrefRangeEnd = 460219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReferenceConverter.NativeMethodInfoPtr_GetStandardValues_Public_Virtual_StandardValuesCollection_ITypeDescriptorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter.StandardValuesCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x000616D4 File Offset: 0x0005F8D4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReferenceConverter.NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Virtual_Boolean_ITypeDescriptorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0006172C File Offset: 0x0005F92C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReferenceConverter.NativeMethodInfoPtr_GetStandardValuesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00061784 File Offset: 0x0005F984
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValueAllowed(ITypeDescriptorContext context, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReferenceConverter.NativeMethodInfoPtr_IsValueAllowed_Protected_Virtual_New_Boolean_ITypeDescriptorContext_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0000855D File Offset: 0x0000675D
		public ReferenceConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x000617F0 File Offset: 0x0005F9F0
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x00008566 File Offset: 0x00006766
		public unsafe static string s_none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReferenceConverter.NativeFieldInfoPtr_s_none, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReferenceConverter.NativeFieldInfoPtr_s_none, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x00061810 File Offset: 0x0005FA10
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x00008578 File Offset: 0x00006778
		public unsafe Type _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceConverter.NativeFieldInfoPtr__type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceConverter.NativeFieldInfoPtr__type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeFieldInfoPtr_s_none;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValues_Public_Virtual_StandardValuesCollection_ITypeDescriptorContext_0;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Virtual_Boolean_ITypeDescriptorContext_0;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValuesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeMethodInfoPtr_IsValueAllowed_Protected_Virtual_New_Boolean_ITypeDescriptorContext_Object_0;

		// Token: 0x020002DD RID: 733
		public class ReferenceComparer : Object
		{
			// Token: 0x06002C32 RID: 11314 RVA: 0x000C2C4C File Offset: 0x000C0E4C
			// Note: this type is marked as 'beforefieldinit'.
			static ReferenceComparer()
			{
				Il2CppClassPointerStore<ReferenceConverter.ReferenceComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr, "ReferenceComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferenceConverter.ReferenceComparer>.NativeClassPtr);
				ReferenceConverter.ReferenceComparer.NativeFieldInfoPtr__converter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceConverter.ReferenceComparer>.NativeClassPtr, "_converter");
				ReferenceConverter.ReferenceComparer.NativeMethodInfoPtr__ctor_Public_Void_ReferenceConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceConverter.ReferenceComparer>.NativeClassPtr, 100665937);
				ReferenceConverter.ReferenceComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceConverter.ReferenceComparer>.NativeClassPtr, 100665938);
			}

			// Token: 0x06002C33 RID: 11315 RVA: 0x000C2CB4 File Offset: 0x000C0EB4
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReferenceComparer(ReferenceConverter converter)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferenceConverter.ReferenceComparer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(converter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceConverter.ReferenceComparer.NativeMethodInfoPtr__ctor_Public_Void_ReferenceConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C34 RID: 11316 RVA: 0x000C2D00 File Offset: 0x000C0F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460091, XrefRangeEnd = 460098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceConverter.ReferenceComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002C35 RID: 11317 RVA: 0x00013E92 File Offset: 0x00012092
			public ReferenceComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DE0 RID: 3552
			// (get) Token: 0x06002C36 RID: 11318 RVA: 0x000C2D60 File Offset: 0x000C0F60
			// (set) Token: 0x06002C37 RID: 11319 RVA: 0x00013E9B File Offset: 0x0001209B
			public unsafe ReferenceConverter _converter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceConverter.ReferenceComparer.NativeFieldInfoPtr__converter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReferenceConverter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceConverter.ReferenceComparer.NativeFieldInfoPtr__converter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022EB RID: 8939
			private static readonly IntPtr NativeFieldInfoPtr__converter;

			// Token: 0x040022EC RID: 8940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReferenceConverter_0;

			// Token: 0x040022ED RID: 8941
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;
		}
	}
}
