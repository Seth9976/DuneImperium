using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000020 RID: 32
	public sealed class IEnumerableCallSite : ServiceCallSite
	{
		// Token: 0x06000148 RID: 328 RVA: 0x00008BC8 File Offset: 0x00006DC8
		// Note: this type is marked as 'beforefieldinit'.
		static IEnumerableCallSite()
		{
			Il2CppClassPointerStore<IEnumerableCallSite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "IEnumerableCallSite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IEnumerableCallSite>.NativeClassPtr);
			IEnumerableCallSite.NativeFieldInfoPtr__ItemType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IEnumerableCallSite>.NativeClassPtr, "<ItemType>k__BackingField");
			IEnumerableCallSite.NativeFieldInfoPtr__ServiceCallSites_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IEnumerableCallSite>.NativeClassPtr, "<ServiceCallSites>k__BackingField");
			IEnumerableCallSite.NativeFieldInfoPtr__Kind_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IEnumerableCallSite>.NativeClassPtr, "<Kind>k__BackingField");
			IEnumerableCallSite.NativeMethodInfoPtr_get_ItemType_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerableCallSite>.NativeClassPtr, 100663525);
			IEnumerableCallSite.NativeMethodInfoPtr_get_ServiceCallSites_Internal_get_Il2CppReferenceArray_1_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerableCallSite>.NativeClassPtr, 100663526);
			IEnumerableCallSite.NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_Il2CppReferenceArray_1_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerableCallSite>.NativeClassPtr, 100663527);
			IEnumerableCallSite.NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerableCallSite>.NativeClassPtr, 100663528);
			IEnumerableCallSite.NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerableCallSite>.NativeClassPtr, 100663529);
			IEnumerableCallSite.NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerableCallSite>.NativeClassPtr, 100663530);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00008CAC File Offset: 0x00006EAC
		public unsafe Type ItemType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IEnumerableCallSite.NativeMethodInfoPtr_get_ItemType_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00008CEC File Offset: 0x00006EEC
		public unsafe Il2CppReferenceArray<ServiceCallSite> ServiceCallSites
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IEnumerableCallSite.NativeMethodInfoPtr_get_ServiceCallSites_Internal_get_Il2CppReferenceArray_1_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ServiceCallSite>>(intPtr3) : null;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00008D2C File Offset: 0x00006F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204726, XrefRangeEnd = 1204730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerableCallSite(ResultCache cache, Type itemType, Il2CppReferenceArray<ServiceCallSite> serviceCallSites)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IEnumerableCallSite>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cache));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceCallSites);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IEnumerableCallSite.NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_Il2CppReferenceArray_1_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00008DA0 File Offset: 0x00006FA0
		public unsafe override Type ServiceType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204730, XrefRangeEnd = 1204745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IEnumerableCallSite.NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00008DE0 File Offset: 0x00006FE0
		public unsafe override Type ImplementationType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204745, XrefRangeEnd = 1204746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IEnumerableCallSite.NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00008E20 File Offset: 0x00007020
		public unsafe override CallSiteKind Kind
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IEnumerableCallSite.NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000026E8 File Offset: 0x000008E8
		public IEnumerableCallSite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00008E5C File Offset: 0x0000705C
		// (set) Token: 0x06000151 RID: 337 RVA: 0x000026F1 File Offset: 0x000008F1
		public unsafe Type _ItemType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IEnumerableCallSite.NativeFieldInfoPtr__ItemType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IEnumerableCallSite.NativeFieldInfoPtr__ItemType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00008E8C File Offset: 0x0000708C
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00002710 File Offset: 0x00000910
		public unsafe Il2CppReferenceArray<ServiceCallSite> _ServiceCallSites_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IEnumerableCallSite.NativeFieldInfoPtr__ServiceCallSites_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ServiceCallSite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IEnumerableCallSite.NativeFieldInfoPtr__ServiceCallSites_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00008EBC File Offset: 0x000070BC
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0000272F File Offset: 0x0000092F
		public unsafe CallSiteKind _Kind_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IEnumerableCallSite.NativeFieldInfoPtr__Kind_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IEnumerableCallSite.NativeFieldInfoPtr__Kind_k__BackingField)) = value;
			}
		}

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr__ItemType_k__BackingField;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr__ServiceCallSites_k__BackingField;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr__Kind_k__BackingField;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Internal_get_Type_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceCallSites_Internal_get_Il2CppReferenceArray_1_ServiceCallSite_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_Il2CppReferenceArray_1_ServiceCallSite_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0;
	}
}
