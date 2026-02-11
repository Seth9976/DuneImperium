using System;
using boardgames.hints;
using boardgames.match.selection;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace boardgames.input
{
	// Token: 0x02000134 RID: 308
	public class DragTargetManager : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x06000DE3 RID: 3555 RVA: 0x000498EC File Offset: 0x00047AEC
		// Note: this type is marked as 'beforefieldinit'.
		static DragTargetManager()
		{
			Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "DragTargetManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr);
			DragTargetManager.NativeFieldInfoPtr_defaultDragTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, "defaultDragTarget");
			DragTargetManager.NativeFieldInfoPtr_selectableDragTargetList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, "selectableDragTargetList");
			DragTargetManager.NativeFieldInfoPtr_activeAnimators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, "activeAnimators");
			DragTargetManager.NativeFieldInfoPtr_hinter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, "hinter");
			DragTargetManager.NativeFieldInfoPtr_tapAndTap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, "tapAndTap");
			DragTargetManager.NativeFieldInfoPtr_registeredDragTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, "registeredDragTargets");
			DragTargetManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665300);
			DragTargetManager.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665301);
			DragTargetManager.NativeMethodInfoPtr_UpdateTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665302);
			DragTargetManager.NativeMethodInfoPtr_StartDragHints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665303);
			DragTargetManager.NativeMethodInfoPtr_getPointerDragTarget_Protected_Virtual_New_IDragTarget_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665304);
			DragTargetManager.NativeMethodInfoPtr_HasExclusiveDragTarget_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665305);
			DragTargetManager.NativeMethodInfoPtr_IsValidDragTarget_Public_Virtual_New_Boolean_PointerEventData_byref_IDragTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665306);
			DragTargetManager.NativeMethodInfoPtr_UpdateDropPosition_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665307);
			DragTargetManager.NativeMethodInfoPtr_SetTapAndTapOverride_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665308);
			DragTargetManager.NativeMethodInfoPtr_RegisterDragTarget_Public_Void_EntityID_IDragTarget_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665309);
			DragTargetManager.NativeMethodInfoPtr_UnregisterDragTarget_Public_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665310);
			DragTargetManager.NativeMethodInfoPtr_UnregisterMultipleDragTargets_Public_Void_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665311);
			DragTargetManager.NativeMethodInfoPtr_resetDragTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665312);
			DragTargetManager.NativeMethodInfoPtr_StopDragHints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665313);
			DragTargetManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, 100665314);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00049AC0 File Offset: 0x00047CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511355, XrefRangeEnd = 511362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00049AF4 File Offset: 0x00047CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511362, XrefRangeEnd = 511363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragTargetManager.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00049B30 File Offset: 0x00047D30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 511408, RefRangeEnd = 511412, XrefRangeStart = 511363, XrefRangeEnd = 511408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetManager.NativeMethodInfoPtr_UpdateTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00049B64 File Offset: 0x00047D64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 511438, RefRangeEnd = 511439, XrefRangeStart = 511412, XrefRangeEnd = 511438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDragHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetManager.NativeMethodInfoPtr_StartDragHints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00049B98 File Offset: 0x00047D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511439, XrefRangeEnd = 511482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDragTarget getPointerDragTarget(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragTargetManager.NativeMethodInfoPtr_getPointerDragTarget_Protected_Virtual_New_IDragTarget_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDragTarget>(intPtr3) : null;
			}
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00049BF4 File Offset: 0x00047DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511482, XrefRangeEnd = 511500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasExclusiveDragTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetManager.NativeMethodInfoPtr_HasExclusiveDragTarget_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00049C30 File Offset: 0x00047E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511500, XrefRangeEnd = 511502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValidDragTarget(PointerEventData eventData, out IDragTarget dragTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragTargetManager.NativeMethodInfoPtr_IsValidDragTarget_Public_Virtual_New_Boolean_PointerEventData_byref_IDragTarget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dragTarget = ((intPtr4 == 0) ? null : new IDragTarget(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00049CAC File Offset: 0x00047EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511502, XrefRangeEnd = 511527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateDropPosition(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragTargetManager.NativeMethodInfoPtr_UpdateDropPosition_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00049CFC File Offset: 0x00047EFC
		[CallerCount(0)]
		public unsafe void SetTapAndTapOverride(bool tatOverride)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tatOverride;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetManager.NativeMethodInfoPtr_SetTapAndTapOverride_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00049D3C File Offset: 0x00047F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511527, XrefRangeEnd = 511533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDragTarget(EntityID key, IDragTarget target, bool isDefault = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetManager.NativeMethodInfoPtr_RegisterDragTarget_Public_Void_EntityID_IDragTarget_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00049DA0 File Offset: 0x00047FA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 511541, RefRangeEnd = 511545, XrefRangeStart = 511533, XrefRangeEnd = 511541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterDragTarget(EntityID key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetManager.NativeMethodInfoPtr_UnregisterDragTarget_Public_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00049DE4 File Offset: 0x00047FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511545, XrefRangeEnd = 511566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterMultipleDragTargets(List<EntityID> keys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetManager.NativeMethodInfoPtr_UnregisterMultipleDragTargets_Public_Void_List_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00049E28 File Offset: 0x00048028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511566, XrefRangeEnd = 511569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void resetDragTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetManager.NativeMethodInfoPtr_resetDragTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00049E5C File Offset: 0x0004805C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 511598, RefRangeEnd = 511602, XrefRangeStart = 511569, XrefRangeEnd = 511598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopDragHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetManager.NativeMethodInfoPtr_StopDragHints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00049E90 File Offset: 0x00048090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511602, XrefRangeEnd = 511626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragTargetManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00008BC4 File Offset: 0x00006DC4
		public DragTargetManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x00049ECC File Offset: 0x000480CC
		// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x00008BCD File Offset: 0x00006DCD
		public unsafe IDragTarget defaultDragTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetManager.NativeFieldInfoPtr_defaultDragTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDragTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetManager.NativeFieldInfoPtr_defaultDragTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x00049EFC File Offset: 0x000480FC
		// (set) Token: 0x06000DF7 RID: 3575 RVA: 0x00008BEC File Offset: 0x00006DEC
		public unsafe List<IDragTarget> selectableDragTargetList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetManager.NativeFieldInfoPtr_selectableDragTargetList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IDragTarget>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetManager.NativeFieldInfoPtr_selectableDragTargetList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x00049F2C File Offset: 0x0004812C
		// (set) Token: 0x06000DF9 RID: 3577 RVA: 0x00008C0B File Offset: 0x00006E0B
		public unsafe List<EntityID> activeAnimators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetManager.NativeFieldInfoPtr_activeAnimators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetManager.NativeFieldInfoPtr_activeAnimators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x00049F5C File Offset: 0x0004815C
		// (set) Token: 0x06000DFB RID: 3579 RVA: 0x00008C2A File Offset: 0x00006E2A
		public unsafe DBGHintManager hinter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetManager.NativeFieldInfoPtr_hinter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGHintManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetManager.NativeFieldInfoPtr_hinter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00049F8C File Offset: 0x0004818C
		// (set) Token: 0x06000DFD RID: 3581 RVA: 0x00008C49 File Offset: 0x00006E49
		public unsafe bool tapAndTap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetManager.NativeFieldInfoPtr_tapAndTap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetManager.NativeFieldInfoPtr_tapAndTap)) = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x00049FB4 File Offset: 0x000481B4
		// (set) Token: 0x06000DFF RID: 3583 RVA: 0x00008C64 File Offset: 0x00006E64
		public unsafe Dictionary<EntityID, IDragTarget> registeredDragTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetManager.NativeFieldInfoPtr_registeredDragTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, IDragTarget>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetManager.NativeFieldInfoPtr_registeredDragTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeFieldInfoPtr_defaultDragTarget;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeFieldInfoPtr_selectableDragTargetList;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeFieldInfoPtr_activeAnimators;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeFieldInfoPtr_hinter;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeFieldInfoPtr_tapAndTap;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeFieldInfoPtr_registeredDragTargets;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTargets_Private_Void_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_StartDragHints_Public_Void_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_getPointerDragTarget_Protected_Virtual_New_IDragTarget_PointerEventData_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_HasExclusiveDragTarget_Public_Boolean_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_IsValidDragTarget_Public_Virtual_New_Boolean_PointerEventData_byref_IDragTarget_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDropPosition_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_SetTapAndTapOverride_Public_Void_Boolean_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDragTarget_Public_Void_EntityID_IDragTarget_Boolean_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDragTarget_Public_Void_EntityID_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterMultipleDragTargets_Public_Void_List_1_EntityID_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_resetDragTargets_Private_Void_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_StopDragHints_Public_Void_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200035F RID: 863
		[ObfuscatedName("boardgames.input.DragTargetManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060028A0 RID: 10400 RVA: 0x000A23B4 File Offset: 0x000A05B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DragTargetManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DragTargetManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragTargetManager.__c>.NativeClassPtr);
				DragTargetManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTargetManager.__c>.NativeClassPtr, "<>9");
				DragTargetManager.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTargetManager.__c>.NativeClassPtr, "<>9__11_0");
				DragTargetManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager.__c>.NativeClassPtr, 100665316);
				DragTargetManager.__c.NativeMethodInfoPtr__HasExclusiveDragTarget_b__11_0_Internal_Boolean_KeyValuePair_2_EntityID_IDragTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetManager.__c>.NativeClassPtr, 100665317);
			}

			// Token: 0x060028A1 RID: 10401 RVA: 0x000A2430 File Offset: 0x000A0630
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragTargetManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028A2 RID: 10402 RVA: 0x000A246C File Offset: 0x000A066C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511350, XrefRangeEnd = 511355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasExclusiveDragTarget_b__11_0(KeyValuePair<EntityID, IDragTarget> item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetManager.__c.NativeMethodInfoPtr__HasExclusiveDragTarget_b__11_0_Internal_Boolean_KeyValuePair_2_EntityID_IDragTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060028A3 RID: 10403 RVA: 0x00014F7A File Offset: 0x0001317A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B61 RID: 2913
			// (get) Token: 0x060028A4 RID: 10404 RVA: 0x000A24C0 File Offset: 0x000A06C0
			// (set) Token: 0x060028A5 RID: 10405 RVA: 0x00014F83 File Offset: 0x00013183
			public unsafe static DragTargetManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DragTargetManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragTargetManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DragTargetManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B62 RID: 2914
			// (get) Token: 0x060028A6 RID: 10406 RVA: 0x000A24E8 File Offset: 0x000A06E8
			// (set) Token: 0x060028A7 RID: 10407 RVA: 0x00014F95 File Offset: 0x00013195
			public unsafe static Func<KeyValuePair<EntityID, IDragTarget>, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DragTargetManager.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, IDragTarget>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DragTargetManager.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001970 RID: 6512
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001971 RID: 6513
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04001972 RID: 6514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001973 RID: 6515
			private static readonly IntPtr NativeMethodInfoPtr__HasExclusiveDragTarget_b__11_0_Internal_Boolean_KeyValuePair_2_EntityID_IDragTarget_0;
		}
	}
}
