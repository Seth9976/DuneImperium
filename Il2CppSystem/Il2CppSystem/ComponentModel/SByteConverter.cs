using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000128 RID: 296
	public class SByteConverter : BaseNumberConverter
	{
		// Token: 0x06001231 RID: 4657 RVA: 0x00061DA8 File Offset: 0x0005FFA8
		// Note: this type is marked as 'beforefieldinit'.
		static SByteConverter()
		{
			Il2CppClassPointerStore<SByteConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "SByteConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SByteConverter>.NativeClassPtr);
			SByteConverter.NativeMethodInfoPtr_get_TargetType_Internal_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SByteConverter>.NativeClassPtr, 100665947);
			SByteConverter.NativeMethodInfoPtr_FromString_Internal_Virtual_Object_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SByteConverter>.NativeClassPtr, 100665948);
			SByteConverter.NativeMethodInfoPtr_FromString_Internal_Virtual_Object_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SByteConverter>.NativeClassPtr, 100665949);
			SByteConverter.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Object_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SByteConverter>.NativeClassPtr, 100665950);
			SByteConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SByteConverter>.NativeClassPtr, 100665951);
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00061E3C File Offset: 0x0006003C
		public unsafe override Type TargetType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460376, XrefRangeEnd = 460382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SByteConverter.NativeMethodInfoPtr_get_TargetType_Internal_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00061E88 File Offset: 0x00060088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460382, XrefRangeEnd = 460389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object FromString(string value, int radix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SByteConverter.NativeMethodInfoPtr_FromString_Internal_Virtual_Object_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00061EF4 File Offset: 0x000600F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460389, XrefRangeEnd = 460393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object FromString(string value, NumberFormatInfo formatInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SByteConverter.NativeMethodInfoPtr_FromString_Internal_Virtual_Object_String_NumberFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00061F64 File Offset: 0x00060164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460393, XrefRangeEnd = 460399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(Object value, NumberFormatInfo formatInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SByteConverter.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Object_NumberFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00061FCC File Offset: 0x000601CC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SByteConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SByteConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SByteConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000086AE File Offset: 0x000068AE
		public SByteConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetType_Internal_Virtual_get_Type_0;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeMethodInfoPtr_FromString_Internal_Virtual_Object_String_Int32_0;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeMethodInfoPtr_FromString_Internal_Virtual_Object_String_NumberFormatInfo_0;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_String_Object_NumberFormatInfo_0;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
