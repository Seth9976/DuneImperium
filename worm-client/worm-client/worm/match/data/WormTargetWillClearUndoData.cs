using System;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.data
{
	// Token: 0x020001A3 RID: 419
	public class WormTargetWillClearUndoData : DataComponent
	{
		// Token: 0x0600129E RID: 4766 RVA: 0x00050938 File Offset: 0x0004EB38
		// Note: this type is marked as 'beforefieldinit'.
		static WormTargetWillClearUndoData()
		{
			Il2CppClassPointerStore<WormTargetWillClearUndoData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormTargetWillClearUndoData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTargetWillClearUndoData>.NativeClassPtr);
			WormTargetWillClearUndoData.NativeFieldInfoPtr__TargetWillClearUndo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTargetWillClearUndoData>.NativeClassPtr, "<TargetWillClearUndo>k__BackingField");
			WormTargetWillClearUndoData.NativeMethodInfoPtr_get_TargetWillClearUndo_Public_get_IReadOnlyList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTargetWillClearUndoData>.NativeClassPtr, 100665835);
			WormTargetWillClearUndoData.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTargetWillClearUndoData>.NativeClassPtr, 100665836);
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x000509A4 File Offset: 0x0004EBA4
		public unsafe IReadOnlyList<EntityID> TargetWillClearUndo
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTargetWillClearUndoData.NativeMethodInfoPtr_get_TargetWillClearUndo_Public_get_IReadOnlyList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x000509E4 File Offset: 0x0004EBE4
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTargetWillClearUndoData(IReadOnlyList<EntityID> targetWillClearUndo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTargetWillClearUndoData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetWillClearUndo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTargetWillClearUndoData.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0000BA7D File Offset: 0x00009C7D
		public WormTargetWillClearUndoData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00050A30 File Offset: 0x0004EC30
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x0000BA86 File Offset: 0x00009C86
		public unsafe IReadOnlyList<EntityID> _TargetWillClearUndo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTargetWillClearUndoData.NativeFieldInfoPtr__TargetWillClearUndo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTargetWillClearUndoData.NativeFieldInfoPtr__TargetWillClearUndo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr__TargetWillClearUndo_k__BackingField;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetWillClearUndo_Public_get_IReadOnlyList_1_EntityID_0;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_EntityID_0;
	}
}
