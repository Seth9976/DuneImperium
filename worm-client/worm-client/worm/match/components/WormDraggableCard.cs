using System;
using boardgames.hints;
using boardgames.input;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace worm.match.components
{
	// Token: 0x020001E7 RID: 487
	public class WormDraggableCard : DraggableCard
	{
		// Token: 0x0600157D RID: 5501 RVA: 0x000595AC File Offset: 0x000577AC
		// Note: this type is marked as 'beforefieldinit'.
		static WormDraggableCard()
		{
			Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormDraggableCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr);
			WormDraggableCard.NativeFieldInfoPtr_overPromptDragSortOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, "overPromptDragSortOrder");
			WormDraggableCard.NativeFieldInfoPtr_originSortOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, "originSortOrder");
			WormDraggableCard.NativeFieldInfoPtr_lineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, "lineRenderer");
			WormDraggableCard.NativeFieldInfoPtr_lineCursorDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, "lineCursorDisplay");
			WormDraggableCard.NativeFieldInfoPtr_hintManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, "hintManager");
			WormDraggableCard.NativeFieldInfoPtr__canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, "_canvas");
			WormDraggableCard.NativeFieldInfoPtr_isGraftDragHinting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, "isGraftDragHinting");
			WormDraggableCard.NativeFieldInfoPtr_GraftDragHintFlavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, "GraftDragHintFlavor");
			WormDraggableCard.NativeMethodInfoPtr_get_canvas_Private_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666259);
			WormDraggableCard.NativeMethodInfoPtr_get_AllowSelectOnClick_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666260);
			WormDraggableCard.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666261);
			WormDraggableCard.NativeMethodInfoPtr_StartDrag_Public_Virtual_Boolean_Camera_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666262);
			WormDraggableCard.NativeMethodInfoPtr_UpdateDrag_Public_Virtual_Boolean_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666263);
			WormDraggableCard.NativeMethodInfoPtr_StopDrag_Public_Virtual_IEnumerator_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666264);
			WormDraggableCard.NativeMethodInfoPtr_SetRequiresTarget_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666265);
			WormDraggableCard.NativeMethodInfoPtr_ResetDrag_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666266);
			WormDraggableCard.NativeMethodInfoPtr_ResetSorting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666267);
			WormDraggableCard.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666268);
			WormDraggableCard.NativeMethodInfoPtr_AnimateOnDropSelectEntity_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666269);
			WormDraggableCard.NativeMethodInfoPtr_Event_OnSubmit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666270);
			WormDraggableCard.NativeMethodInfoPtr_HandleSubmit_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666271);
			WormDraggableCard.NativeMethodInfoPtr_OnSubmitUnusualSelectionCancel_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666272);
			WormDraggableCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666273);
			WormDraggableCard.NativeMethodInfoPtr___n__0_Private_IEnumerator_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, 100666274);
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x000597BC File Offset: 0x000579BC
		public unsafe Canvas canvas
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 715451, RefRangeEnd = 715454, XrefRangeStart = 715443, XrefRangeEnd = 715451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard.NativeMethodInfoPtr_get_canvas_Private_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x000597FC File Offset: 0x000579FC
		public unsafe override bool AllowSelectOnClick
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDraggableCard.NativeMethodInfoPtr_get_AllowSelectOnClick_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00059844 File Offset: 0x00057A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715454, XrefRangeEnd = 715471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDraggableCard.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00059880 File Offset: 0x00057A80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 715514, RefRangeEnd = 715515, XrefRangeStart = 715471, XrefRangeEnd = 715514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool StartDrag(Camera withCamera, PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(withCamera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDraggableCard.NativeMethodInfoPtr_StartDrag_Public_Virtual_Boolean_Camera_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x000598EC File Offset: 0x00057AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715515, XrefRangeEnd = 715594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool UpdateDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDraggableCard.NativeMethodInfoPtr_UpdateDrag_Public_Virtual_Boolean_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00059944 File Offset: 0x00057B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715594, XrefRangeEnd = 715600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator StopDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDraggableCard.NativeMethodInfoPtr_StopDrag_Public_Virtual_IEnumerator_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x000599A0 File Offset: 0x00057BA0
		[CallerCount(0)]
		public unsafe void SetRequiresTarget(bool requiresTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref requiresTarget;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard.NativeMethodInfoPtr_SetRequiresTarget_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x000599E0 File Offset: 0x00057BE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 715654, RefRangeEnd = 715655, XrefRangeStart = 715600, XrefRangeEnd = 715654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDraggableCard.NativeMethodInfoPtr_ResetDrag_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00059A1C File Offset: 0x00057C1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 715663, RefRangeEnd = 715665, XrefRangeStart = 715655, XrefRangeEnd = 715663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetSorting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard.NativeMethodInfoPtr_ResetSorting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00059A50 File Offset: 0x00057C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715665, XrefRangeEnd = 715668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00059A84 File Offset: 0x00057C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715668, XrefRangeEnd = 715673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator AnimateOnDropSelectEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDraggableCard.NativeMethodInfoPtr_AnimateOnDropSelectEntity_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00059AD0 File Offset: 0x00057CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715673, XrefRangeEnd = 715679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard.NativeMethodInfoPtr_Event_OnSubmit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00059B04 File Offset: 0x00057D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715679, XrefRangeEnd = 715684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator HandleSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard.NativeMethodInfoPtr_HandleSubmit_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00059B44 File Offset: 0x00057D44
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmitUnusualSelectionCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDraggableCard.NativeMethodInfoPtr_OnSubmitUnusualSelectionCancel_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00059B80 File Offset: 0x00057D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715684, XrefRangeEnd = 715685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDraggableCard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00059BBC File Offset: 0x00057DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715685, XrefRangeEnd = 715686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard.NativeMethodInfoPtr___n__0_Private_IEnumerator_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x0000D09E File Offset: 0x0000B29E
		public WormDraggableCard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x00059C0C File Offset: 0x00057E0C
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x0000D0A7 File Offset: 0x0000B2A7
		public unsafe int overPromptDragSortOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard.NativeFieldInfoPtr_overPromptDragSortOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard.NativeFieldInfoPtr_overPromptDragSortOrder)) = value;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x00059C34 File Offset: 0x00057E34
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x0000D0C2 File Offset: 0x0000B2C2
		public unsafe int originSortOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard.NativeFieldInfoPtr_originSortOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard.NativeFieldInfoPtr_originSortOrder)) = value;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x00059C5C File Offset: 0x00057E5C
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x0000D0DD File Offset: 0x0000B2DD
		public unsafe LineRenderer lineRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard.NativeFieldInfoPtr_lineRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard.NativeFieldInfoPtr_lineRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x00059C8C File Offset: 0x00057E8C
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x0000D0FC File Offset: 0x0000B2FC
		public unsafe Transform lineCursorDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard.NativeFieldInfoPtr_lineCursorDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard.NativeFieldInfoPtr_lineCursorDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x00059CBC File Offset: 0x00057EBC
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x0000D11B File Offset: 0x0000B31B
		public unsafe DBGHintManager hintManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard.NativeFieldInfoPtr_hintManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGHintManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard.NativeFieldInfoPtr_hintManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x00059CEC File Offset: 0x00057EEC
		// (set) Token: 0x0600159A RID: 5530 RVA: 0x0000D13A File Offset: 0x0000B33A
		public unsafe Canvas _canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard.NativeFieldInfoPtr__canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard.NativeFieldInfoPtr__canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x00059D1C File Offset: 0x00057F1C
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x0000D159 File Offset: 0x0000B359
		public unsafe bool isGraftDragHinting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard.NativeFieldInfoPtr_isGraftDragHinting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard.NativeFieldInfoPtr_isGraftDragHinting)) = value;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x00059D44 File Offset: 0x00057F44
		// (set) Token: 0x0600159E RID: 5534 RVA: 0x0000D174 File Offset: 0x0000B374
		public unsafe static string GraftDragHintFlavor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormDraggableCard.NativeFieldInfoPtr_GraftDragHintFlavor, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormDraggableCard.NativeFieldInfoPtr_GraftDragHintFlavor, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeFieldInfoPtr_overPromptDragSortOrder;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeFieldInfoPtr_originSortOrder;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeFieldInfoPtr_lineRenderer;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeFieldInfoPtr_lineCursorDisplay;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeFieldInfoPtr_hintManager;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeFieldInfoPtr__canvas;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeFieldInfoPtr_isGraftDragHinting;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeFieldInfoPtr_GraftDragHintFlavor;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_get_canvas_Private_get_Canvas_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowSelectOnClick_Public_Virtual_get_Boolean_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_StartDrag_Public_Virtual_Boolean_Camera_PointerEventData_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_Public_Virtual_Boolean_PointerEventData_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_StopDrag_Public_Virtual_IEnumerator_PointerEventData_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_SetRequiresTarget_Public_Void_Boolean_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr_ResetDrag_Protected_Virtual_Void_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_ResetSorting_Private_Void_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_AnimateOnDropSelectEntity_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnSubmit_Public_Void_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_HandleSubmit_Private_IEnumerator_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmitUnusualSelectionCancel_Protected_Virtual_New_Void_0;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_PointerEventData_0;

		// Token: 0x020003E7 RID: 999
		[ObfuscatedName("worm.match.components.WormDraggableCard+<AnimateOnDropSelectEntity>d__20")]
		public sealed class _AnimateOnDropSelectEntity_d__20 : global::Il2CppSystem.Object
		{
			// Token: 0x0600287E RID: 10366 RVA: 0x00092BC8 File Offset: 0x00090DC8
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateOnDropSelectEntity_d__20()
			{
				Il2CppClassPointerStore<WormDraggableCard._AnimateOnDropSelectEntity_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, "<AnimateOnDropSelectEntity>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDraggableCard._AnimateOnDropSelectEntity_d__20>.NativeClassPtr);
				WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard._AnimateOnDropSelectEntity_d__20>.NativeClassPtr, "<>1__state");
				WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard._AnimateOnDropSelectEntity_d__20>.NativeClassPtr, "<>2__current");
				WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard._AnimateOnDropSelectEntity_d__20>.NativeClassPtr, "<>4__this");
				WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeFieldInfoPtr__anim_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard._AnimateOnDropSelectEntity_d__20>.NativeClassPtr, "<anim>5__2");
				WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._AnimateOnDropSelectEntity_d__20>.NativeClassPtr, 100666275);
				WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._AnimateOnDropSelectEntity_d__20>.NativeClassPtr, 100666276);
				WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._AnimateOnDropSelectEntity_d__20>.NativeClassPtr, 100666277);
				WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._AnimateOnDropSelectEntity_d__20>.NativeClassPtr, 100666278);
				WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._AnimateOnDropSelectEntity_d__20>.NativeClassPtr, 100666279);
				WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._AnimateOnDropSelectEntity_d__20>.NativeClassPtr, 100666280);
			}

			// Token: 0x0600287F RID: 10367 RVA: 0x00092CBC File Offset: 0x00090EBC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateOnDropSelectEntity_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDraggableCard._AnimateOnDropSelectEntity_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002880 RID: 10368 RVA: 0x00092D04 File Offset: 0x00090F04
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002881 RID: 10369 RVA: 0x00092D38 File Offset: 0x00090F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715307, XrefRangeEnd = 715387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B5A RID: 2906
			// (get) Token: 0x06002882 RID: 10370 RVA: 0x00092D74 File Offset: 0x00090F74
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002883 RID: 10371 RVA: 0x00092DB4 File Offset: 0x00090FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715387, XrefRangeEnd = 715392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B5B RID: 2907
			// (get) Token: 0x06002884 RID: 10372 RVA: 0x00092DE8 File Offset: 0x00090FE8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002885 RID: 10373 RVA: 0x00016382 File Offset: 0x00014582
			public _AnimateOnDropSelectEntity_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B56 RID: 2902
			// (get) Token: 0x06002886 RID: 10374 RVA: 0x00092E28 File Offset: 0x00091028
			// (set) Token: 0x06002887 RID: 10375 RVA: 0x0001638B File Offset: 0x0001458B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B57 RID: 2903
			// (get) Token: 0x06002888 RID: 10376 RVA: 0x00092E50 File Offset: 0x00091050
			// (set) Token: 0x06002889 RID: 10377 RVA: 0x000163A6 File Offset: 0x000145A6
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B58 RID: 2904
			// (get) Token: 0x0600288A RID: 10378 RVA: 0x00092E80 File Offset: 0x00091080
			// (set) Token: 0x0600288B RID: 10379 RVA: 0x000163C5 File Offset: 0x000145C5
			public unsafe WormDraggableCard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDraggableCard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B59 RID: 2905
			// (get) Token: 0x0600288C RID: 10380 RVA: 0x00092EB0 File Offset: 0x000910B0
			// (set) Token: 0x0600288D RID: 10381 RVA: 0x000163E4 File Offset: 0x000145E4
			public unsafe IEnumerator _anim_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeFieldInfoPtr__anim_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._AnimateOnDropSelectEntity_d__20.NativeFieldInfoPtr__anim_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001751 RID: 5969
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001752 RID: 5970
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001753 RID: 5971
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001754 RID: 5972
			private static readonly IntPtr NativeFieldInfoPtr__anim_5__2;

			// Token: 0x04001755 RID: 5973
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001756 RID: 5974
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001757 RID: 5975
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001758 RID: 5976
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001759 RID: 5977
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400175A RID: 5978
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003E8 RID: 1000
		[ObfuscatedName("worm.match.components.WormDraggableCard+<HandleSubmit>d__22")]
		public sealed class _HandleSubmit_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x0600288E RID: 10382 RVA: 0x00092EE0 File Offset: 0x000910E0
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleSubmit_d__22()
			{
				Il2CppClassPointerStore<WormDraggableCard._HandleSubmit_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, "<HandleSubmit>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDraggableCard._HandleSubmit_d__22>.NativeClassPtr);
				WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard._HandleSubmit_d__22>.NativeClassPtr, "<>1__state");
				WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard._HandleSubmit_d__22>.NativeClassPtr, "<>2__current");
				WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard._HandleSubmit_d__22>.NativeClassPtr, "<>4__this");
				WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr__selectEntity_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard._HandleSubmit_d__22>.NativeClassPtr, "<selectEntity>5__2");
				WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr__submitConfirmation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard._HandleSubmit_d__22>.NativeClassPtr, "<submitConfirmation>5__3");
				WormDraggableCard._HandleSubmit_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._HandleSubmit_d__22>.NativeClassPtr, 100666281);
				WormDraggableCard._HandleSubmit_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._HandleSubmit_d__22>.NativeClassPtr, 100666282);
				WormDraggableCard._HandleSubmit_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._HandleSubmit_d__22>.NativeClassPtr, 100666283);
				WormDraggableCard._HandleSubmit_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._HandleSubmit_d__22>.NativeClassPtr, 100666284);
				WormDraggableCard._HandleSubmit_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._HandleSubmit_d__22>.NativeClassPtr, 100666285);
				WormDraggableCard._HandleSubmit_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._HandleSubmit_d__22>.NativeClassPtr, 100666286);
			}

			// Token: 0x0600288F RID: 10383 RVA: 0x00092FE8 File Offset: 0x000911E8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HandleSubmit_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDraggableCard._HandleSubmit_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._HandleSubmit_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002890 RID: 10384 RVA: 0x00093030 File Offset: 0x00091230
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._HandleSubmit_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002891 RID: 10385 RVA: 0x00093064 File Offset: 0x00091264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715392, XrefRangeEnd = 715417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._HandleSubmit_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B61 RID: 2913
			// (get) Token: 0x06002892 RID: 10386 RVA: 0x000930A0 File Offset: 0x000912A0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._HandleSubmit_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002893 RID: 10387 RVA: 0x000930E0 File Offset: 0x000912E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715417, XrefRangeEnd = 715422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._HandleSubmit_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B62 RID: 2914
			// (get) Token: 0x06002894 RID: 10388 RVA: 0x00093114 File Offset: 0x00091314
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._HandleSubmit_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002895 RID: 10389 RVA: 0x00016403 File Offset: 0x00014603
			public _HandleSubmit_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B5C RID: 2908
			// (get) Token: 0x06002896 RID: 10390 RVA: 0x00093154 File Offset: 0x00091354
			// (set) Token: 0x06002897 RID: 10391 RVA: 0x0001640C File Offset: 0x0001460C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B5D RID: 2909
			// (get) Token: 0x06002898 RID: 10392 RVA: 0x0009317C File Offset: 0x0009137C
			// (set) Token: 0x06002899 RID: 10393 RVA: 0x00016427 File Offset: 0x00014627
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B5E RID: 2910
			// (get) Token: 0x0600289A RID: 10394 RVA: 0x000931AC File Offset: 0x000913AC
			// (set) Token: 0x0600289B RID: 10395 RVA: 0x00016446 File Offset: 0x00014646
			public unsafe WormDraggableCard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDraggableCard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B5F RID: 2911
			// (get) Token: 0x0600289C RID: 10396 RVA: 0x000931DC File Offset: 0x000913DC
			// (set) Token: 0x0600289D RID: 10397 RVA: 0x00016465 File Offset: 0x00014665
			public unsafe EntityID _selectEntity_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr__selectEntity_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr__selectEntity_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B60 RID: 2912
			// (get) Token: 0x0600289E RID: 10398 RVA: 0x0009320C File Offset: 0x0009140C
			// (set) Token: 0x0600289F RID: 10399 RVA: 0x00016484 File Offset: 0x00014684
			public unsafe IEnumerator<Nullable<bool>> _submitConfirmation_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr__submitConfirmation_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Nullable<bool>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._HandleSubmit_d__22.NativeFieldInfoPtr__submitConfirmation_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400175B RID: 5979
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400175C RID: 5980
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400175D RID: 5981
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400175E RID: 5982
			private static readonly IntPtr NativeFieldInfoPtr__selectEntity_5__2;

			// Token: 0x0400175F RID: 5983
			private static readonly IntPtr NativeFieldInfoPtr__submitConfirmation_5__3;

			// Token: 0x04001760 RID: 5984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001761 RID: 5985
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001762 RID: 5986
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001763 RID: 5987
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001764 RID: 5988
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001765 RID: 5989
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003E9 RID: 1001
		[ObfuscatedName("worm.match.components.WormDraggableCard+<StopDrag>d__15")]
		public sealed class _StopDrag_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x060028A0 RID: 10400 RVA: 0x0009323C File Offset: 0x0009143C
			// Note: this type is marked as 'beforefieldinit'.
			static _StopDrag_d__15()
			{
				Il2CppClassPointerStore<WormDraggableCard._StopDrag_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormDraggableCard>.NativeClassPtr, "<StopDrag>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDraggableCard._StopDrag_d__15>.NativeClassPtr);
				WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard._StopDrag_d__15>.NativeClassPtr, "<>1__state");
				WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard._StopDrag_d__15>.NativeClassPtr, "<>2__current");
				WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard._StopDrag_d__15>.NativeClassPtr, "<>4__this");
				WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard._StopDrag_d__15>.NativeClassPtr, "eventData");
				WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr__restoreTargeting_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableCard._StopDrag_d__15>.NativeClassPtr, "<restoreTargeting>5__2");
				WormDraggableCard._StopDrag_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._StopDrag_d__15>.NativeClassPtr, 100666287);
				WormDraggableCard._StopDrag_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._StopDrag_d__15>.NativeClassPtr, 100666288);
				WormDraggableCard._StopDrag_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._StopDrag_d__15>.NativeClassPtr, 100666289);
				WormDraggableCard._StopDrag_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._StopDrag_d__15>.NativeClassPtr, 100666290);
				WormDraggableCard._StopDrag_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._StopDrag_d__15>.NativeClassPtr, 100666291);
				WormDraggableCard._StopDrag_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableCard._StopDrag_d__15>.NativeClassPtr, 100666292);
			}

			// Token: 0x060028A1 RID: 10401 RVA: 0x00093344 File Offset: 0x00091544
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StopDrag_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDraggableCard._StopDrag_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._StopDrag_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028A2 RID: 10402 RVA: 0x0009338C File Offset: 0x0009158C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._StopDrag_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028A3 RID: 10403 RVA: 0x000933C0 File Offset: 0x000915C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715422, XrefRangeEnd = 715438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._StopDrag_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B68 RID: 2920
			// (get) Token: 0x060028A4 RID: 10404 RVA: 0x000933FC File Offset: 0x000915FC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._StopDrag_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028A5 RID: 10405 RVA: 0x0009343C File Offset: 0x0009163C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715438, XrefRangeEnd = 715443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._StopDrag_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B69 RID: 2921
			// (get) Token: 0x060028A6 RID: 10406 RVA: 0x00093470 File Offset: 0x00091670
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableCard._StopDrag_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028A7 RID: 10407 RVA: 0x000164A3 File Offset: 0x000146A3
			public _StopDrag_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B63 RID: 2915
			// (get) Token: 0x060028A8 RID: 10408 RVA: 0x000934B0 File Offset: 0x000916B0
			// (set) Token: 0x060028A9 RID: 10409 RVA: 0x000164AC File Offset: 0x000146AC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B64 RID: 2916
			// (get) Token: 0x060028AA RID: 10410 RVA: 0x000934D8 File Offset: 0x000916D8
			// (set) Token: 0x060028AB RID: 10411 RVA: 0x000164C7 File Offset: 0x000146C7
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B65 RID: 2917
			// (get) Token: 0x060028AC RID: 10412 RVA: 0x00093508 File Offset: 0x00091708
			// (set) Token: 0x060028AD RID: 10413 RVA: 0x000164E6 File Offset: 0x000146E6
			public unsafe WormDraggableCard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDraggableCard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B66 RID: 2918
			// (get) Token: 0x060028AE RID: 10414 RVA: 0x00093538 File Offset: 0x00091738
			// (set) Token: 0x060028AF RID: 10415 RVA: 0x00016505 File Offset: 0x00014705
			public unsafe PointerEventData eventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr_eventData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B67 RID: 2919
			// (get) Token: 0x060028B0 RID: 10416 RVA: 0x00093568 File Offset: 0x00091768
			// (set) Token: 0x060028B1 RID: 10417 RVA: 0x00016524 File Offset: 0x00014724
			public unsafe bool _restoreTargeting_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr__restoreTargeting_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableCard._StopDrag_d__15.NativeFieldInfoPtr__restoreTargeting_5__2)) = value;
				}
			}

			// Token: 0x04001766 RID: 5990
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001767 RID: 5991
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001768 RID: 5992
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001769 RID: 5993
			private static readonly IntPtr NativeFieldInfoPtr_eventData;

			// Token: 0x0400176A RID: 5994
			private static readonly IntPtr NativeFieldInfoPtr__restoreTargeting_5__2;

			// Token: 0x0400176B RID: 5995
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400176C RID: 5996
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400176D RID: 5997
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400176E RID: 5998
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400176F RID: 5999
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001770 RID: 6000
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
