using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace boardgames.input
{
	// Token: 0x0200013E RID: 318
	public class SelectDraggedEntityDragTarget : ObserveOnce
	{
		// Token: 0x06000E82 RID: 3714 RVA: 0x0004BBA0 File Offset: 0x00049DA0
		// Note: this type is marked as 'beforefieldinit'.
		static SelectDraggedEntityDragTarget()
		{
			Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "SelectDraggedEntityDragTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr);
			SelectDraggedEntityDragTarget.NativeFieldInfoPtr_exclusiveOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr, "exclusiveOption");
			SelectDraggedEntityDragTarget.NativeFieldInfoPtr_parentEntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr, "parentEntityID");
			SelectDraggedEntityDragTarget.NativeFieldInfoPtr_dragTargetManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr, "dragTargetManager");
			SelectDraggedEntityDragTarget.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr, 100665414);
			SelectDraggedEntityDragTarget.NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr, 100665415);
			SelectDraggedEntityDragTarget.NativeMethodInfoPtr_Unregister_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr, 100665416);
			SelectDraggedEntityDragTarget.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr, 100665417);
			SelectDraggedEntityDragTarget.NativeMethodInfoPtr_ExclusiveOption_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr, 100665418);
			SelectDraggedEntityDragTarget.NativeMethodInfoPtr_GetDragPileEntityID_Public_Virtual_Final_New_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr, 100665419);
			SelectDraggedEntityDragTarget.NativeMethodInfoPtr_HandleDropOnTarget_Public_Virtual_Final_New_Boolean_DraggableCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr, 100665420);
			SelectDraggedEntityDragTarget.NativeMethodInfoPtr_GetIsSelectable_Public_Virtual_Final_New_Boolean_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr, 100665421);
			SelectDraggedEntityDragTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr, 100665422);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0004BCC0 File Offset: 0x00049EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512163, XrefRangeEnd = 512166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectDraggedEntityDragTarget.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0004BCF4 File Offset: 0x00049EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512166, XrefRangeEnd = 512172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectDraggedEntityDragTarget.NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0004BD3C File Offset: 0x00049F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512172, XrefRangeEnd = 512177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectDraggedEntityDragTarget.NativeMethodInfoPtr_Unregister_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0004BD70 File Offset: 0x00049F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512177, XrefRangeEnd = 512182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectDraggedEntityDragTarget.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0004BDA4 File Offset: 0x00049FA4
		[CallerCount(0)]
		public unsafe virtual bool ExclusiveOption()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectDraggedEntityDragTarget.NativeMethodInfoPtr_ExclusiveOption_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0004BDE0 File Offset: 0x00049FE0
		[CallerCount(0)]
		public unsafe virtual EntityID GetDragPileEntityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectDraggedEntityDragTarget.NativeMethodInfoPtr_GetDragPileEntityID_Public_Virtual_Final_New_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0004BE20 File Offset: 0x0004A020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512182, XrefRangeEnd = 512191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HandleDropOnTarget(DraggableCard draggableCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggableCard);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectDraggedEntityDragTarget.NativeMethodInfoPtr_HandleDropOnTarget_Public_Virtual_Final_New_Boolean_DraggableCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0004BE70 File Offset: 0x0004A070
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetIsSelectable(List<EntityID> selectableEntities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectableEntities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectDraggedEntityDragTarget.NativeMethodInfoPtr_GetIsSelectable_Public_Virtual_Final_New_Boolean_List_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0004BEC0 File Offset: 0x0004A0C0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectDraggedEntityDragTarget()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectDraggedEntityDragTarget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectDraggedEntityDragTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00009026 File Offset: 0x00007226
		public SelectDraggedEntityDragTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x0004BEFC File Offset: 0x0004A0FC
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x0000902F File Offset: 0x0000722F
		public unsafe bool exclusiveOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectDraggedEntityDragTarget.NativeFieldInfoPtr_exclusiveOption);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectDraggedEntityDragTarget.NativeFieldInfoPtr_exclusiveOption)) = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x0004BF24 File Offset: 0x0004A124
		// (set) Token: 0x06000E90 RID: 3728 RVA: 0x0000904A File Offset: 0x0000724A
		public unsafe EntityID parentEntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectDraggedEntityDragTarget.NativeFieldInfoPtr_parentEntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectDraggedEntityDragTarget.NativeFieldInfoPtr_parentEntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x0004BF54 File Offset: 0x0004A154
		// (set) Token: 0x06000E92 RID: 3730 RVA: 0x00009069 File Offset: 0x00007269
		public unsafe DragTargetManager dragTargetManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectDraggedEntityDragTarget.NativeFieldInfoPtr_dragTargetManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragTargetManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectDraggedEntityDragTarget.NativeFieldInfoPtr_dragTargetManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeFieldInfoPtr_exclusiveOption;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeFieldInfoPtr_parentEntityID;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr_dragTargetManager;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Void_0;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr_ExclusiveOption_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeMethodInfoPtr_GetDragPileEntityID_Public_Virtual_Final_New_EntityID_0;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeMethodInfoPtr_HandleDropOnTarget_Public_Virtual_Final_New_Boolean_DraggableCard_0;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeMethodInfoPtr_GetIsSelectable_Public_Virtual_Final_New_Boolean_List_1_EntityID_0;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
