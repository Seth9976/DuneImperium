using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000FB RID: 251
	public class CharConverter : TypeConverter
	{
		// Token: 0x06000FFD RID: 4093 RVA: 0x00058538 File Offset: 0x00056738
		// Note: this type is marked as 'beforefieldinit'.
		static CharConverter()
		{
			Il2CppClassPointerStore<CharConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "CharConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharConverter>.NativeClassPtr);
			CharConverter.NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharConverter>.NativeClassPtr, 100665599);
			CharConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharConverter>.NativeClassPtr, 100665600);
			CharConverter.NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharConverter>.NativeClassPtr, 100665601);
			CharConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharConverter>.NativeClassPtr, 100665602);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x000585B8 File Offset: 0x000567B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456696, XrefRangeEnd = 456705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharConverter.NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00058624 File Offset: 0x00056824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456705, XrefRangeEnd = 456719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x000586B8 File Offset: 0x000568B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456719, XrefRangeEnd = 456729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharConverter.NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00058738 File Offset: 0x00056938
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00007BEF File Offset: 0x00005DEF
		public CharConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
