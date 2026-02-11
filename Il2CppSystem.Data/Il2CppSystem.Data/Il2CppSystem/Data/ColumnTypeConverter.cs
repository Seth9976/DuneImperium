using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Data
{
	// Token: 0x02000020 RID: 32
	public sealed class ColumnTypeConverter : TypeConverter
	{
		// Token: 0x06000489 RID: 1161 RVA: 0x0001C370 File Offset: 0x0001A570
		// Note: this type is marked as 'beforefieldinit'.
		static ColumnTypeConverter()
		{
			Il2CppClassPointerStore<ColumnTypeConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "ColumnTypeConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColumnTypeConverter>.NativeClassPtr);
			ColumnTypeConverter.NativeFieldInfoPtr_s_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnTypeConverter>.NativeClassPtr, "s_types");
			ColumnTypeConverter.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnTypeConverter>.NativeClassPtr, "_values");
			ColumnTypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnTypeConverter>.NativeClassPtr, 100664089);
			ColumnTypeConverter.NativeMethodInfoPtr_CanConvertTo_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnTypeConverter>.NativeClassPtr, 100664090);
			ColumnTypeConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnTypeConverter>.NativeClassPtr, 100664091);
			ColumnTypeConverter.NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnTypeConverter>.NativeClassPtr, 100664092);
			ColumnTypeConverter.NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnTypeConverter>.NativeClassPtr, 100664093);
			ColumnTypeConverter.NativeMethodInfoPtr_GetStandardValues_Public_Virtual_StandardValuesCollection_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnTypeConverter>.NativeClassPtr, 100664094);
			ColumnTypeConverter.NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Virtual_Boolean_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnTypeConverter>.NativeClassPtr, 100664095);
			ColumnTypeConverter.NativeMethodInfoPtr_GetStandardValuesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnTypeConverter>.NativeClassPtr, 100664096);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001C468 File Offset: 0x0001A668
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColumnTypeConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColumnTypeConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnTypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0001C4A4 File Offset: 0x0001A6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897689, XrefRangeEnd = 897698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnTypeConverter.NativeMethodInfoPtr_CanConvertTo_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0001C504 File Offset: 0x0001A704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897698, XrefRangeEnd = 897753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnTypeConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0001C58C File Offset: 0x0001A78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897753, XrefRangeEnd = 897762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnTypeConverter.NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0001C5EC File Offset: 0x0001A7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897762, XrefRangeEnd = 897787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnTypeConverter.NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0001C660 File Offset: 0x0001A860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897787, XrefRangeEnd = 897804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnTypeConverter.NativeMethodInfoPtr_GetStandardValues_Public_Virtual_StandardValuesCollection_ITypeDescriptorContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter.StandardValuesCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0001C6B0 File Offset: 0x0001A8B0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnTypeConverter.NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Virtual_Boolean_ITypeDescriptorContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0001C700 File Offset: 0x0001A900
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnTypeConverter.NativeMethodInfoPtr_GetStandardValuesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00003417 File Offset: 0x00001617
		public ColumnTypeConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0001C750 File Offset: 0x0001A950
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00003420 File Offset: 0x00001620
		public unsafe static Il2CppReferenceArray<Type> s_types
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ColumnTypeConverter.NativeFieldInfoPtr_s_types, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColumnTypeConverter.NativeFieldInfoPtr_s_types, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0001C778 File Offset: 0x0001A978
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00003432 File Offset: 0x00001632
		public unsafe TypeConverter.StandardValuesCollection _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnTypeConverter.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeConverter.StandardValuesCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnTypeConverter.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeFieldInfoPtr_s_types;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertTo_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValues_Public_Virtual_StandardValuesCollection_ITypeDescriptorContext_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Virtual_Boolean_ITypeDescriptorContext_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValuesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0;
	}
}
