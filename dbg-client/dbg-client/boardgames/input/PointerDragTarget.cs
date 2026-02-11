using System;
using boardgames.match.selection;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace boardgames.input
{
	// Token: 0x0200013D RID: 317
	public class PointerDragTarget : ObserveOnce
	{
		// Token: 0x06000E6F RID: 3695 RVA: 0x0004B768 File Offset: 0x00049968
		// Note: this type is marked as 'beforefieldinit'.
		static PointerDragTarget()
		{
			Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "PointerDragTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr);
			PointerDragTarget.NativeFieldInfoPtr_isDefaultDragTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr, "isDefaultDragTarget");
			PointerDragTarget.NativeFieldInfoPtr_parentEntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr, "parentEntityID");
			PointerDragTarget.NativeFieldInfoPtr_dragTargetManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr, "dragTargetManager");
			PointerDragTarget.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr, "selectionResponder");
			PointerDragTarget.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr, 100665405);
			PointerDragTarget.NativeMethodInfoPtr_GetDragPileEntityID_Public_Virtual_Final_New_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr, 100665406);
			PointerDragTarget.NativeMethodInfoPtr_HandleDropOnTarget_Public_Virtual_New_Boolean_DraggableCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr, 100665407);
			PointerDragTarget.NativeMethodInfoPtr_GetIsSelectable_Public_Virtual_New_Boolean_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr, 100665408);
			PointerDragTarget.NativeMethodInfoPtr_ExclusiveOption_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr, 100665409);
			PointerDragTarget.NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr, 100665410);
			PointerDragTarget.NativeMethodInfoPtr_Unregister_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr, 100665411);
			PointerDragTarget.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr, 100665412);
			PointerDragTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr, 100665413);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0004B89C File Offset: 0x00049A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512134, XrefRangeEnd = 512140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDragTarget.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0004B8D0 File Offset: 0x00049AD0
		[CallerCount(0)]
		public unsafe virtual EntityID GetDragPileEntityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDragTarget.NativeMethodInfoPtr_GetDragPileEntityID_Public_Virtual_Final_New_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x0004B910 File Offset: 0x00049B10
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HandleDropOnTarget(DraggableCard draggableCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggableCard);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerDragTarget.NativeMethodInfoPtr_HandleDropOnTarget_Public_Virtual_New_Boolean_DraggableCard_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x0004B968 File Offset: 0x00049B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512140, XrefRangeEnd = 512147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetIsSelectable(List<EntityID> selectableEntities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectableEntities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerDragTarget.NativeMethodInfoPtr_GetIsSelectable_Public_Virtual_New_Boolean_List_1_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0004B9C0 File Offset: 0x00049BC0
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ExclusiveOption()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDragTarget.NativeMethodInfoPtr_ExclusiveOption_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0004B9FC File Offset: 0x00049BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512147, XrefRangeEnd = 512153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerDragTarget.NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0004BA44 File Offset: 0x00049C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512153, XrefRangeEnd = 512158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDragTarget.NativeMethodInfoPtr_Unregister_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0004BA78 File Offset: 0x00049C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512158, XrefRangeEnd = 512163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDragTarget.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0004BAAC File Offset: 0x00049CAC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerDragTarget()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerDragTarget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDragTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00008FA5 File Offset: 0x000071A5
		public PointerDragTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0004BAE8 File Offset: 0x00049CE8
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x00008FAE File Offset: 0x000071AE
		public unsafe bool isDefaultDragTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDragTarget.NativeFieldInfoPtr_isDefaultDragTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDragTarget.NativeFieldInfoPtr_isDefaultDragTarget)) = value;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x0004BB10 File Offset: 0x00049D10
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x00008FC9 File Offset: 0x000071C9
		public unsafe EntityID parentEntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDragTarget.NativeFieldInfoPtr_parentEntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDragTarget.NativeFieldInfoPtr_parentEntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x0004BB40 File Offset: 0x00049D40
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x00008FE8 File Offset: 0x000071E8
		public unsafe DragTargetManager dragTargetManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDragTarget.NativeFieldInfoPtr_dragTargetManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragTargetManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDragTarget.NativeFieldInfoPtr_dragTargetManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x0004BB70 File Offset: 0x00049D70
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x00009007 File Offset: 0x00007207
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDragTarget.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDragTarget.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeFieldInfoPtr_isDefaultDragTarget;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_parentEntityID;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_dragTargetManager;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeMethodInfoPtr_GetDragPileEntityID_Public_Virtual_Final_New_EntityID_0;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeMethodInfoPtr_HandleDropOnTarget_Public_Virtual_New_Boolean_DraggableCard_0;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeMethodInfoPtr_GetIsSelectable_Public_Virtual_New_Boolean_List_1_EntityID_0;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeMethodInfoPtr_ExclusiveOption_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Void_0;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
