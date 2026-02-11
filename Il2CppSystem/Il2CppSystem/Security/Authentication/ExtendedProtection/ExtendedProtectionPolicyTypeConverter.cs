using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Security.Authentication.ExtendedProtection
{
	// Token: 0x020000B1 RID: 177
	public class ExtendedProtectionPolicyTypeConverter : TypeConverter
	{
		// Token: 0x06000C82 RID: 3202 RVA: 0x0004A7E4 File Offset: 0x000489E4
		// Note: this type is marked as 'beforefieldinit'.
		static ExtendedProtectionPolicyTypeConverter()
		{
			Il2CppClassPointerStore<ExtendedProtectionPolicyTypeConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Authentication.ExtendedProtection", "ExtendedProtectionPolicyTypeConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtendedProtectionPolicyTypeConverter>.NativeClassPtr);
			ExtendedProtectionPolicyTypeConverter.NativeMethodInfoPtr_CanConvertTo_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedProtectionPolicyTypeConverter>.NativeClassPtr, 100665079);
			ExtendedProtectionPolicyTypeConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedProtectionPolicyTypeConverter>.NativeClassPtr, 100665080);
			ExtendedProtectionPolicyTypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedProtectionPolicyTypeConverter>.NativeClassPtr, 100665081);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0004A850 File Offset: 0x00048A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452037, XrefRangeEnd = 452042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedProtectionPolicyTypeConverter.NativeMethodInfoPtr_CanConvertTo_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0004A8BC File Offset: 0x00048ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452042, XrefRangeEnd = 452047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedProtectionPolicyTypeConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0004A950 File Offset: 0x00048B50
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtendedProtectionPolicyTypeConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtendedProtectionPolicyTypeConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedProtectionPolicyTypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00006AEE File Offset: 0x00004CEE
		public ExtendedProtectionPolicyTypeConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertTo_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
