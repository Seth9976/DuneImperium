using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x0200001C RID: 28
	public sealed class ConstantCallSite : ServiceCallSite
	{
		// Token: 0x06000117 RID: 279 RVA: 0x0000805C File Offset: 0x0000625C
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantCallSite()
		{
			Il2CppClassPointerStore<ConstantCallSite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "ConstantCallSite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantCallSite>.NativeClassPtr);
			ConstantCallSite.NativeFieldInfoPtr__serviceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantCallSite>.NativeClassPtr, "_serviceType");
			ConstantCallSite.NativeFieldInfoPtr__Kind_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantCallSite>.NativeClassPtr, "<Kind>k__BackingField");
			ConstantCallSite.NativeMethodInfoPtr_get_DefaultValue_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantCallSite>.NativeClassPtr, 100663499);
			ConstantCallSite.NativeMethodInfoPtr__ctor_Public_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantCallSite>.NativeClassPtr, 100663500);
			ConstantCallSite.NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantCallSite>.NativeClassPtr, 100663501);
			ConstantCallSite.NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantCallSite>.NativeClassPtr, 100663502);
			ConstantCallSite.NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantCallSite>.NativeClassPtr, 100663503);
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00008118 File Offset: 0x00006318
		public unsafe Object DefaultValue
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantCallSite.NativeMethodInfoPtr_get_DefaultValue_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00008158 File Offset: 0x00006358
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1204574, RefRangeEnd = 1204579, XrefRangeStart = 1204549, XrefRangeEnd = 1204574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantCallSite(Type serviceType, Object defaultValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantCallSite>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantCallSite.NativeMethodInfoPtr__ctor_Public_Void_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000081B8 File Offset: 0x000063B8
		public unsafe override Type ServiceType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantCallSite.NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000081F8 File Offset: 0x000063F8
		public unsafe override Type ImplementationType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204579, XrefRangeEnd = 1204580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantCallSite.NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00008238 File Offset: 0x00006438
		public unsafe override CallSiteKind Kind
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantCallSite.NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000259A File Offset: 0x0000079A
		public ConstantCallSite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00008274 File Offset: 0x00006474
		// (set) Token: 0x0600011F RID: 287 RVA: 0x000025A3 File Offset: 0x000007A3
		public unsafe Type _serviceType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantCallSite.NativeFieldInfoPtr__serviceType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantCallSite.NativeFieldInfoPtr__serviceType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000082A4 File Offset: 0x000064A4
		// (set) Token: 0x06000121 RID: 289 RVA: 0x000025C2 File Offset: 0x000007C2
		public unsafe CallSiteKind _Kind_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantCallSite.NativeFieldInfoPtr__Kind_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantCallSite.NativeFieldInfoPtr__Kind_k__BackingField)) = value;
			}
		}

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr__serviceType;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr__Kind_k__BackingField;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Internal_get_Object_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Object_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0;
	}
}
