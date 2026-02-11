using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200010F RID: 271
	public class GuidConverter : TypeConverter
	{
		// Token: 0x060010F8 RID: 4344 RVA: 0x0005C8F8 File Offset: 0x0005AAF8
		// Note: this type is marked as 'beforefieldinit'.
		static GuidConverter()
		{
			Il2CppClassPointerStore<GuidConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "GuidConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuidConverter>.NativeClassPtr);
			GuidConverter.NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidConverter>.NativeClassPtr, 100665757);
			GuidConverter.NativeMethodInfoPtr_CanConvertTo_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidConverter>.NativeClassPtr, 100665758);
			GuidConverter.NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidConverter>.NativeClassPtr, 100665759);
			GuidConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidConverter>.NativeClassPtr, 100665760);
			GuidConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidConverter>.NativeClassPtr, 100665761);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0005C98C File Offset: 0x0005AB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459282, XrefRangeEnd = 459291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuidConverter.NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0005C9F8 File Offset: 0x0005ABF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459291, XrefRangeEnd = 459300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuidConverter.NativeMethodInfoPtr_CanConvertTo_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0005CA64 File Offset: 0x0005AC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459300, XrefRangeEnd = 459309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuidConverter.NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0005CAE4 File Offset: 0x0005ACE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459309, XrefRangeEnd = 459348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuidConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x0005CB78 File Offset: 0x0005AD78
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuidConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuidConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuidConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0000806C File Offset: 0x0000626C
		public GuidConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertTo_Public_Virtual_Boolean_ITypeDescriptorContext_Type_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFrom_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
