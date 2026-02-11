using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Networking.selection.targetresponse;

namespace Canis.selectionfilters
{
	// Token: 0x0200005A RID: 90
	[Serializable]
	public class SelectionNodeFilterData : Object
	{
		// Token: 0x06000537 RID: 1335 RVA: 0x0002D85C File Offset: 0x0002BA5C
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionNodeFilterData()
		{
			Il2CppClassPointerStore<SelectionNodeFilterData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.selectionfilters", "SelectionNodeFilterData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionNodeFilterData>.NativeClassPtr);
			SelectionNodeFilterData.NativeFieldInfoPtr_ExpectedTargetResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionNodeFilterData>.NativeClassPtr, "ExpectedTargetResponse");
			SelectionNodeFilterData.NativeFieldInfoPtr_Forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionNodeFilterData>.NativeClassPtr, "Forced");
			SelectionNodeFilterData.NativeFieldInfoPtr_CanCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionNodeFilterData>.NativeClassPtr, "CanCancel");
			SelectionNodeFilterData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFilterData>.NativeClassPtr, 100664354);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0002D8DC File Offset: 0x0002BADC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionNodeFilterData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionNodeFilterData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFilterData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x000044C7 File Offset: 0x000026C7
		public SelectionNodeFilterData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0002D918 File Offset: 0x0002BB18
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x000044D0 File Offset: 0x000026D0
		public unsafe TargetResponse ExpectedTargetResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNodeFilterData.NativeFieldInfoPtr_ExpectedTargetResponse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNodeFilterData.NativeFieldInfoPtr_ExpectedTargetResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0002D948 File Offset: 0x0002BB48
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x000044EF File Offset: 0x000026EF
		public unsafe bool Forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNodeFilterData.NativeFieldInfoPtr_Forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNodeFilterData.NativeFieldInfoPtr_Forced)) = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0002D970 File Offset: 0x0002BB70
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x0000450A File Offset: 0x0000270A
		public unsafe bool CanCancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNodeFilterData.NativeFieldInfoPtr_CanCancel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNodeFilterData.NativeFieldInfoPtr_CanCancel)) = value;
			}
		}

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeFieldInfoPtr_ExpectedTargetResponse;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeFieldInfoPtr_Forced;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeFieldInfoPtr_CanCancel;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
