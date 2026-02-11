using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000F5 RID: 245
	public class ArrayConverter : CollectionConverter
	{
		// Token: 0x06000FB7 RID: 4023 RVA: 0x00057164 File Offset: 0x00055364
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayConverter()
		{
			Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ArrayConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr);
			ArrayConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr, 100665556);
			ArrayConverter.NativeMethodInfoPtr_GetProperties_Public_Virtual_PropertyDescriptorCollection_ITypeDescriptorContext_Object_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr, 100665557);
			ArrayConverter.NativeMethodInfoPtr_GetPropertiesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr, 100665558);
			ArrayConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr, 100665559);
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x000571E4 File Offset: 0x000553E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456402, XrefRangeEnd = 456418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00057278 File Offset: 0x00055478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456418, XrefRangeEnd = 456443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, Object value, Il2CppReferenceArray<Attribute> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayConverter.NativeMethodInfoPtr_GetProperties_Public_Virtual_PropertyDescriptorCollection_ITypeDescriptorContext_Object_Il2CppReferenceArray_1_Attribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x000572F8 File Offset: 0x000554F8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayConverter.NativeMethodInfoPtr_GetPropertiesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00057350 File Offset: 0x00055550
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00007ACC File Offset: 0x00005CCC
		public ArrayConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Virtual_PropertyDescriptorCollection_ITypeDescriptorContext_Object_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D7 RID: 727
		public class ArrayPropertyDescriptor : TypeConverter.SimplePropertyDescriptor
		{
			// Token: 0x06002BFF RID: 11263 RVA: 0x000C2260 File Offset: 0x000C0460
			// Note: this type is marked as 'beforefieldinit'.
			static ArrayPropertyDescriptor()
			{
				Il2CppClassPointerStore<ArrayConverter.ArrayPropertyDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr, "ArrayPropertyDescriptor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayConverter.ArrayPropertyDescriptor>.NativeClassPtr);
				ArrayConverter.ArrayPropertyDescriptor.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayConverter.ArrayPropertyDescriptor>.NativeClassPtr, "_index");
				ArrayConverter.ArrayPropertyDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayConverter.ArrayPropertyDescriptor>.NativeClassPtr, 100665560);
				ArrayConverter.ArrayPropertyDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayConverter.ArrayPropertyDescriptor>.NativeClassPtr, 100665561);
				ArrayConverter.ArrayPropertyDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayConverter.ArrayPropertyDescriptor>.NativeClassPtr, 100665562);
			}

			// Token: 0x06002C00 RID: 11264 RVA: 0x000C22DC File Offset: 0x000C04DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456382, XrefRangeEnd = 456389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArrayPropertyDescriptor(Type arrayType, Type elementType, int index)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayConverter.ArrayPropertyDescriptor>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrayType);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementType);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayConverter.ArrayPropertyDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C01 RID: 11265 RVA: 0x000C2348 File Offset: 0x000C0548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456389, XrefRangeEnd = 456394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object GetValue(Object instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayConverter.ArrayPropertyDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C02 RID: 11266 RVA: 0x000C23A4 File Offset: 0x000C05A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456394, XrefRangeEnd = 456402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void SetValue(Object instance, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayConverter.ArrayPropertyDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C03 RID: 11267 RVA: 0x00013D35 File Offset: 0x00011F35
			public ArrayPropertyDescriptor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DD1 RID: 3537
			// (get) Token: 0x06002C04 RID: 11268 RVA: 0x000C2404 File Offset: 0x000C0604
			// (set) Token: 0x06002C05 RID: 11269 RVA: 0x00013D3E File Offset: 0x00011F3E
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayConverter.ArrayPropertyDescriptor.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayConverter.ArrayPropertyDescriptor.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x040022CF RID: 8911
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x040022D0 RID: 8912
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Type_Int32_0;

			// Token: 0x040022D1 RID: 8913
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0;

			// Token: 0x040022D2 RID: 8914
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0;
		}
	}
}
