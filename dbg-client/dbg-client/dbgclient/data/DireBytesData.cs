using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dbgclient.data
{
	// Token: 0x020000CB RID: 203
	public class DireBytesData : VersionedDataComponent
	{
		// Token: 0x060008A3 RID: 2211 RVA: 0x0003897C File Offset: 0x00036B7C
		// Note: this type is marked as 'beforefieldinit'.
		static DireBytesData()
		{
			Il2CppClassPointerStore<DireBytesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "DireBytesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesData>.NativeClassPtr);
			DireBytesData.NativeFieldInfoPtr__DireBytesDataCompositions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesData>.NativeClassPtr, "<DireBytesDataCompositions>k__BackingField");
			DireBytesData.NativeMethodInfoPtr_get_DireBytesDataCompositions_Public_get_VersionedList_1_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesData>.NativeClassPtr, 100664550);
			DireBytesData.NativeMethodInfoPtr__ctor_Public_Void_VersionedList_1_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesData>.NativeClassPtr, 100664551);
			DireBytesData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesData>.NativeClassPtr, 100664552);
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x000389FC File Offset: 0x00036BFC
		public unsafe VersionedList<DataComposition> DireBytesDataCompositions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesData.NativeMethodInfoPtr_get_DireBytesDataCompositions_Public_get_VersionedList_1_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VersionedList<DataComposition>>(intPtr3) : null;
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00038A3C File Offset: 0x00036C3C
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 504779, RefRangeEnd = 504807, XrefRangeStart = 504777, XrefRangeEnd = 504779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireBytesData(VersionedList<DataComposition> direBytesDataCompositions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(direBytesDataCompositions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesData.NativeMethodInfoPtr__ctor_Public_Void_VersionedList_1_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00038A88 File Offset: 0x00036C88
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504807, XrefRangeEnd = 504808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireBytesData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x000060F5 File Offset: 0x000042F5
		public DireBytesData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00038AD0 File Offset: 0x00036CD0
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x000060FE File Offset: 0x000042FE
		public unsafe VersionedList<DataComposition> _DireBytesDataCompositions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesData.NativeFieldInfoPtr__DireBytesDataCompositions_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesData.NativeFieldInfoPtr__DireBytesDataCompositions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeFieldInfoPtr__DireBytesDataCompositions_k__BackingField;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_get_DireBytesDataCompositions_Public_get_VersionedList_1_DataComposition_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VersionedList_1_DataComposition_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;
	}
}
