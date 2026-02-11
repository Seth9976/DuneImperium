using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.data
{
	// Token: 0x02000193 RID: 403
	public class SelectionStageData : DataComponent
	{
		// Token: 0x060011F5 RID: 4597 RVA: 0x00056B98 File Offset: 0x00054D98
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionStageData()
		{
			Il2CppClassPointerStore<SelectionStageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "SelectionStageData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionStageData>.NativeClassPtr);
			SelectionStageData.NativeFieldInfoPtr_stage1Only = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionStageData>.NativeClassPtr, "stage1Only");
			SelectionStageData.NativeFieldInfoPtr_stage2Only = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionStageData>.NativeClassPtr, "stage2Only");
			SelectionStageData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionStageData>.NativeClassPtr, 100665812);
			SelectionStageData.NativeMethodInfoPtr_get_SelectionStage_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionStageData>.NativeClassPtr, 100665813);
			SelectionStageData.NativeMethodInfoPtr_StageIsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionStageData>.NativeClassPtr, 100665814);
			SelectionStageData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionStageData>.NativeClassPtr, 100665815);
			SelectionStageData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionStageData>.NativeClassPtr, 100665816);
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00056C54 File Offset: 0x00054E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515621, XrefRangeEnd = 515635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionStageData(IHasAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionStageData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionStageData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00056CA0 File Offset: 0x00054EA0
		public unsafe int SelectionStage
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 515642, RefRangeEnd = 515647, XrefRangeStart = 515635, XrefRangeEnd = 515642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionStageData.NativeMethodInfoPtr_get_SelectionStage_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00056CDC File Offset: 0x00054EDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 515648, RefRangeEnd = 515651, XrefRangeStart = 515647, XrefRangeEnd = 515648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StageIsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionStageData.NativeMethodInfoPtr_StageIsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00056D18 File Offset: 0x00054F18
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515651, XrefRangeEnd = 515656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionStageData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00056D54 File Offset: 0x00054F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515656, XrefRangeEnd = 515665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionStageData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0000A97D File Offset: 0x00008B7D
		public SelectionStageData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x00056D98 File Offset: 0x00054F98
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x0000A986 File Offset: 0x00008B86
		public unsafe IAttribute<Nullable<bool>> stage1Only
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionStageData.NativeFieldInfoPtr_stage1Only);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionStageData.NativeFieldInfoPtr_stage1Only), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x00056DC8 File Offset: 0x00054FC8
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x0000A9A5 File Offset: 0x00008BA5
		public unsafe IAttribute<Nullable<bool>> stage2Only
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionStageData.NativeFieldInfoPtr_stage2Only);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionStageData.NativeFieldInfoPtr_stage2Only), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeFieldInfoPtr_stage1Only;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeFieldInfoPtr_stage2Only;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionStage_Public_get_Int32_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_StageIsValid_Public_Boolean_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
