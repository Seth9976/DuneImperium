using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.prefabs
{
	// Token: 0x02000109 RID: 265
	public class PrefabLookup<MetaType> : PrefabLookup where MetaType : new()
	{
		// Token: 0x06000F3F RID: 3903 RVA: 0x00050438 File Offset: 0x0004E638
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabLookup()
		{
			Il2CppClassPointerStore<PrefabLookup<MetaType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs", "PrefabLookup`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MetaType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabLookup<MetaType>>.NativeClassPtr);
			PrefabLookup<MetaType>.NativeMethodInfoPtr_GetMetaType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup<MetaType>>.NativeClassPtr, 100665523);
			PrefabLookup<MetaType>.NativeMethodInfoPtr_get_baseEntries_Protected_Abstract_Virtual_New_get_IEnumerable_1_PrefabLookupEntry_1_MetaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup<MetaType>>.NativeClassPtr, 100665524);
			PrefabLookup<MetaType>.NativeMethodInfoPtr_get_Entries_Public_get_IEnumerable_1_PrefabLookupEntry_1_MetaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup<MetaType>>.NativeClassPtr, 100665525);
			PrefabLookup<MetaType>.NativeMethodInfoPtr_TryGetFirst_Public_Boolean_IMetadataMatcher_1_MetaType_byref_PrefabLookupEntry_1_MetaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup<MetaType>>.NativeClassPtr, 100665526);
			PrefabLookup<MetaType>.NativeMethodInfoPtr_GetAll_Public_Void_IMetadataMatcher_1_MetaType_IList_1_PrefabLookupEntry_1_MetaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup<MetaType>>.NativeClassPtr, 100665527);
			PrefabLookup<MetaType>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup<MetaType>>.NativeClassPtr, 100665528);
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0005051C File Offset: 0x0004E71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868120, XrefRangeEnd = 868124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetMetaType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookup<MetaType>.NativeMethodInfoPtr_GetMetaType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00050568 File Offset: 0x0004E768
		public unsafe virtual IEnumerable<PrefabLookupEntry<MetaType>> baseEntries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookup<MetaType>.NativeMethodInfoPtr_get_baseEntries_Protected_Abstract_Virtual_New_get_IEnumerable_1_PrefabLookupEntry_1_MetaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PrefabLookupEntry<MetaType>>>(intPtr3) : null;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x000505B4 File Offset: 0x0004E7B4
		public unsafe IEnumerable<PrefabLookupEntry<MetaType>> Entries
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 868124, RefRangeEnd = 868148, XrefRangeStart = 868124, XrefRangeEnd = 868124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLookup<MetaType>.NativeMethodInfoPtr_get_Entries_Public_get_IEnumerable_1_PrefabLookupEntry_1_MetaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PrefabLookupEntry<MetaType>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x000505F4 File Offset: 0x0004E7F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 868169, RefRangeEnd = 868172, XrefRangeStart = 868148, XrefRangeEnd = 868169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetFirst(IMetadataMatcher<MetaType> matcher, out PrefabLookupEntry<MetaType> entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matcher);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefabLookup<MetaType>.NativeMethodInfoPtr_TryGetFirst_Public_Boolean_IMetadataMatcher_1_MetaType_byref_PrefabLookupEntry_1_MetaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			entry = ((intPtr4 == 0) ? null : new PrefabLookupEntry<MetaType>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00050664 File Offset: 0x0004E864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868172, XrefRangeEnd = 868192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetAll(IMetadataMatcher<MetaType> matcher, IList<PrefabLookupEntry<MetaType>> matches)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matcher);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matches);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLookup<MetaType>.NativeMethodInfoPtr_GetAll_Public_Void_IMetadataMatcher_1_MetaType_IList_1_PrefabLookupEntry_1_MetaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x000506B8 File Offset: 0x0004E8B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 868197, RefRangeEnd = 868198, XrefRangeStart = 868192, XrefRangeEnd = 868197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabLookup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabLookup<MetaType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLookup<MetaType>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00007280 File Offset: 0x00005480
		public PrefabLookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_GetMetaType_Public_Virtual_Type_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_get_baseEntries_Protected_Abstract_Virtual_New_get_IEnumerable_1_PrefabLookupEntry_1_MetaType_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_get_Entries_Public_get_IEnumerable_1_PrefabLookupEntry_1_MetaType_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFirst_Public_Boolean_IMetadataMatcher_1_MetaType_byref_PrefabLookupEntry_1_MetaType_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_Void_IMetadataMatcher_1_MetaType_IList_1_PrefabLookupEntry_1_MetaType_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
