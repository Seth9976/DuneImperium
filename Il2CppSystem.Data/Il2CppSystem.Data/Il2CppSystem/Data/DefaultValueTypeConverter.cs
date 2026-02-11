using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Data
{
	// Token: 0x0200004D RID: 77
	public sealed class DefaultValueTypeConverter : StringConverter
	{
		// Token: 0x06000823 RID: 2083 RVA: 0x0002BAF8 File Offset: 0x00029CF8
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultValueTypeConverter()
		{
			Il2CppClassPointerStore<DefaultValueTypeConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DefaultValueTypeConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultValueTypeConverter>.NativeClassPtr);
			DefaultValueTypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultValueTypeConverter>.NativeClassPtr, 100664647);
			DefaultValueTypeConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultValueTypeConverter>.NativeClassPtr, 100664648);
			DefaultValueTypeConverter.NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultValueTypeConverter>.NativeClassPtr, 100664649);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0002BB64 File Offset: 0x00029D64
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultValueTypeConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultValueTypeConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultValueTypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0002BBA0 File Offset: 0x00029DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902794, XrefRangeEnd = 902811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultValueTypeConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0002BC28 File Offset: 0x00029E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902811, XrefRangeEnd = 902834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultValueTypeConverter.NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00004746 File Offset: 0x00002946
		public DefaultValueTypeConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0;
	}
}
