using System;
using boardgames.match.selection;
using boardgames.moz;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace boardgames.input
{
	// Token: 0x02000133 RID: 307
	public class DraggableCard : Observer
	{
		// Token: 0x06000D9F RID: 3487 RVA: 0x00048AB4 File Offset: 0x00046CB4
		// Note: this type is marked as 'beforefieldinit'.
		static DraggableCard()
		{
			Il2CppClassPointerStore<DraggableCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "DraggableCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr);
			DraggableCard.NativeFieldInfoPtr_CurrentlyDraggedCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "CurrentlyDraggedCard");
			DraggableCard.NativeFieldInfoPtr_collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "collider");
			DraggableCard.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "canvasGroup");
			DraggableCard.NativeFieldInfoPtr_gutterScreenFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "gutterScreenFraction");
			DraggableCard.NativeFieldInfoPtr_requiresDragTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "requiresDragTarget");
			DraggableCard.NativeFieldInfoPtr_disableMozOnDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "disableMozOnDrag");
			DraggableCard.NativeFieldInfoPtr_canDragWithoutSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "canDragWithoutSelection");
			DraggableCard.NativeFieldInfoPtr_ignoreDragX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "ignoreDragX");
			DraggableCard.NativeFieldInfoPtr_ignoreDragY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "ignoreDragY");
			DraggableCard.NativeFieldInfoPtr_hopOnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "hopOnClick");
			DraggableCard.NativeFieldInfoPtr_clickHopAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "clickHopAnimator");
			DraggableCard.NativeFieldInfoPtr_OnBeginDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "OnBeginDrag");
			DraggableCard.NativeFieldInfoPtr_OnStopDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "OnStopDrag");
			DraggableCard.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "selectionResponder");
			DraggableCard.NativeFieldInfoPtr_poolManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "poolManager");
			DraggableCard.NativeFieldInfoPtr_mozManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "mozManager");
			DraggableCard.NativeFieldInfoPtr_dragPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "dragPosition");
			DraggableCard.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "cam");
			DraggableCard.NativeFieldInfoPtr_camT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "camT");
			DraggableCard.NativeFieldInfoPtr_dragTargetManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "dragTargetManager");
			DraggableCard.NativeFieldInfoPtr_clickHop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "clickHop");
			DraggableCard.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665264);
			DraggableCard.NativeMethodInfoPtr_get_AllowSelectOnClick_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665265);
			DraggableCard.NativeMethodInfoPtr_getHandEntityName_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665266);
			DraggableCard.NativeMethodInfoPtr_StartDrag_Public_Virtual_New_Boolean_Camera_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665267);
			DraggableCard.NativeMethodInfoPtr_getCanDrag_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665268);
			DraggableCard.NativeMethodInfoPtr_UpdateDrag_Public_Virtual_New_Boolean_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665269);
			DraggableCard.NativeMethodInfoPtr_StopDrag_Public_Virtual_New_IEnumerator_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665270);
			DraggableCard.NativeMethodInfoPtr_IsValidNoTargetDrop_Protected_Boolean_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665271);
			DraggableCard.NativeMethodInfoPtr_ToggleMoz_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665272);
			DraggableCard.NativeMethodInfoPtr_ForceCancel_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665273);
			DraggableCard.NativeMethodInfoPtr_ResetDrag_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665274);
			DraggableCard.NativeMethodInfoPtr_getOverView_Protected_Virtual_New_EntityView_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665275);
			DraggableCard.NativeMethodInfoPtr_getParentUnit_Public_Virtual_New_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665276);
			DraggableCard.NativeMethodInfoPtr_processCardIfUI_Protected_Virtual_New_Void_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665277);
			DraggableCard.NativeMethodInfoPtr_isDropSelectionBlocked_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665278);
			DraggableCard.NativeMethodInfoPtr_attemptSelection_Protected_Virtual_New_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665279);
			DraggableCard.NativeMethodInfoPtr_selfSelectionOnDrop_Protected_Virtual_New_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665280);
			DraggableCard.NativeMethodInfoPtr_AttemptCancelOnFailedDrop_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665281);
			DraggableCard.NativeMethodInfoPtr_AnimateOnDropSelectEntity_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665282);
			DraggableCard.NativeMethodInfoPtr_OnMouseDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665283);
			DraggableCard.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665284);
			DraggableCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665285);
			DraggableCard.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665286);
			DraggableCard.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, 100665287);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00048E68 File Offset: 0x00047068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 511051, RefRangeEnd = 511052, XrefRangeStart = 511041, XrefRangeEnd = 511051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00048EA4 File Offset: 0x000470A4
		public unsafe virtual bool AllowSelectOnClick
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511052, XrefRangeEnd = 511053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_get_AllowSelectOnClick_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00048EEC File Offset: 0x000470EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511053, XrefRangeEnd = 511055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string getHandEntityName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_getHandEntityName_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00048F30 File Offset: 0x00047130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511055, XrefRangeEnd = 511139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartDrag(Camera withCamera, PointerEventData eventData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_StartDrag_Public_Virtual_New_Boolean_Camera_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00048F9C File Offset: 0x0004719C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511139, XrefRangeEnd = 511140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool getCanDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_getCanDrag_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00048FE4 File Offset: 0x000471E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511140, XrefRangeEnd = 511227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UpdateDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_UpdateDrag_Public_Virtual_New_Boolean_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0004903C File Offset: 0x0004723C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 511233, RefRangeEnd = 511235, XrefRangeStart = 511227, XrefRangeEnd = 511233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator StopDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_StopDrag_Public_Virtual_New_IEnumerator_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00049098 File Offset: 0x00047298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511235, XrefRangeEnd = 511247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidNoTargetDrop(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard.NativeMethodInfoPtr_IsValidNoTargetDrop_Protected_Boolean_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x000490E8 File Offset: 0x000472E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 511256, RefRangeEnd = 511259, XrefRangeStart = 511247, XrefRangeEnd = 511256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleMoz(bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard.NativeMethodInfoPtr_ToggleMoz_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00049128 File Offset: 0x00047328
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ForceCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_ForceCancel_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00049170 File Offset: 0x00047370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 511284, RefRangeEnd = 511285, XrefRangeStart = 511259, XrefRangeEnd = 511284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_ResetDrag_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x000491AC File Offset: 0x000473AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511285, XrefRangeEnd = 511292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EntityView getOverView(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_getOverView_Protected_Virtual_New_EntityView_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr3) : null;
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00049208 File Offset: 0x00047408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511292, XrefRangeEnd = 511293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual UnitView getParentUnit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_getParentUnit_Public_Virtual_New_UnitView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr3) : null;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00049254 File Offset: 0x00047454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511293, XrefRangeEnd = 511314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void processCardIfUI(LocalTransform currentPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_processCardIfUI_Protected_Virtual_New_Void_LocalTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x000492A0 File Offset: 0x000474A0
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool isDropSelectionBlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_isDropSelectionBlocked_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x000492E8 File Offset: 0x000474E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511314, XrefRangeEnd = 511318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool attemptSelection(EntityID selectEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_attemptSelection_Protected_Virtual_New_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00049340 File Offset: 0x00047540
		[CallerCount(0)]
		public unsafe virtual EntityID selfSelectionOnDrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_selfSelectionOnDrop_Protected_Virtual_New_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0004938C File Offset: 0x0004758C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AttemptCancelOnFailedDrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_AttemptCancelOnFailedDrop_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x000493D4 File Offset: 0x000475D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511318, XrefRangeEnd = 511322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator AnimateOnDropSelectEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableCard.NativeMethodInfoPtr_AnimateOnDropSelectEntity_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00049420 File Offset: 0x00047620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511322, XrefRangeEnd = 511329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard.NativeMethodInfoPtr_OnMouseDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00049454 File Offset: 0x00047654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511329, XrefRangeEnd = 511334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00049488 File Offset: 0x00047688
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 511347, RefRangeEnd = 511349, XrefRangeStart = 511334, XrefRangeEnd = 511347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DraggableCard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x000494C4 File Offset: 0x000476C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511349, XrefRangeEnd = 511350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject IGameObject_get_gameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00049504 File Offset: 0x00047704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform IGameObject_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0000895D File Offset: 0x00006B5D
		public DraggableCard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x00049544 File Offset: 0x00047744
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x00008966 File Offset: 0x00006B66
		public unsafe static DraggableCard CurrentlyDraggedCard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DraggableCard.NativeFieldInfoPtr_CurrentlyDraggedCard, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableCard>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DraggableCard.NativeFieldInfoPtr_CurrentlyDraggedCard, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x0004956C File Offset: 0x0004776C
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x00008978 File Offset: 0x00006B78
		public unsafe Collider collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x0004959C File Offset: 0x0004779C
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x00008997 File Offset: 0x00006B97
		public unsafe CanvasGroup canvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_canvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x000495CC File Offset: 0x000477CC
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x000089B6 File Offset: 0x00006BB6
		public unsafe float gutterScreenFraction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_gutterScreenFraction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_gutterScreenFraction)) = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x000495F4 File Offset: 0x000477F4
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x000089D1 File Offset: 0x00006BD1
		public unsafe bool requiresDragTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_requiresDragTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_requiresDragTarget)) = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x0004961C File Offset: 0x0004781C
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x000089EC File Offset: 0x00006BEC
		public unsafe bool disableMozOnDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_disableMozOnDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_disableMozOnDrag)) = value;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00049644 File Offset: 0x00047844
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x00008A07 File Offset: 0x00006C07
		public unsafe bool canDragWithoutSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_canDragWithoutSelection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_canDragWithoutSelection)) = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x0004966C File Offset: 0x0004786C
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x00008A22 File Offset: 0x00006C22
		public unsafe bool ignoreDragX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_ignoreDragX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_ignoreDragX)) = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00049694 File Offset: 0x00047894
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x00008A3D File Offset: 0x00006C3D
		public unsafe bool ignoreDragY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_ignoreDragY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_ignoreDragY)) = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x000496BC File Offset: 0x000478BC
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x00008A58 File Offset: 0x00006C58
		public unsafe bool hopOnClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_hopOnClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_hopOnClick)) = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x000496E4 File Offset: 0x000478E4
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x00008A73 File Offset: 0x00006C73
		public unsafe Animator clickHopAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_clickHopAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_clickHopAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00049714 File Offset: 0x00047914
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x00008A92 File Offset: 0x00006C92
		public unsafe UnityEvent OnBeginDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_OnBeginDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_OnBeginDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00049744 File Offset: 0x00047944
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x00008AB1 File Offset: 0x00006CB1
		public unsafe UnityEvent OnStopDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_OnStopDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_OnStopDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00049774 File Offset: 0x00047974
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x00008AD0 File Offset: 0x00006CD0
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x000497A4 File Offset: 0x000479A4
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x00008AEF File Offset: 0x00006CEF
		public unsafe PoolManager poolManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_poolManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_poolManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x000497D4 File Offset: 0x000479D4
		// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x00008B0E File Offset: 0x00006D0E
		public unsafe MozManager mozManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_mozManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MozManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_mozManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00049804 File Offset: 0x00047A04
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x00008B2D File Offset: 0x00006D2D
		public unsafe UnitPosition dragPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_dragPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_dragPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00049834 File Offset: 0x00047A34
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x00008B4C File Offset: 0x00006D4C
		public unsafe Camera cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x00049864 File Offset: 0x00047A64
		// (set) Token: 0x06000DDE RID: 3550 RVA: 0x00008B6B File Offset: 0x00006D6B
		public unsafe Transform camT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_camT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_camT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x00049894 File Offset: 0x00047A94
		// (set) Token: 0x06000DE0 RID: 3552 RVA: 0x00008B8A File Offset: 0x00006D8A
		public unsafe DragTargetManager dragTargetManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_dragTargetManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragTargetManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_dragTargetManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x000498C4 File Offset: 0x00047AC4
		// (set) Token: 0x06000DE2 RID: 3554 RVA: 0x00008BA9 File Offset: 0x00006DA9
		public unsafe int clickHop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_clickHop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard.NativeFieldInfoPtr_clickHop)) = value;
			}
		}

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeFieldInfoPtr_CurrentlyDraggedCard;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeFieldInfoPtr_collider;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeFieldInfoPtr_gutterScreenFraction;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeFieldInfoPtr_requiresDragTarget;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeFieldInfoPtr_disableMozOnDrag;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeFieldInfoPtr_canDragWithoutSelection;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeFieldInfoPtr_ignoreDragX;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeFieldInfoPtr_ignoreDragY;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeFieldInfoPtr_hopOnClick;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeFieldInfoPtr_clickHopAnimator;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeFieldInfoPtr_OnBeginDrag;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeFieldInfoPtr_OnStopDrag;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeFieldInfoPtr_poolManager;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeFieldInfoPtr_mozManager;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeFieldInfoPtr_dragPosition;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeFieldInfoPtr_camT;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeFieldInfoPtr_dragTargetManager;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeFieldInfoPtr_clickHop;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowSelectOnClick_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_getHandEntityName_Protected_Virtual_New_String_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_StartDrag_Public_Virtual_New_Boolean_Camera_PointerEventData_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_getCanDrag_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_Public_Virtual_New_Boolean_PointerEventData_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_StopDrag_Public_Virtual_New_IEnumerator_PointerEventData_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_IsValidNoTargetDrop_Protected_Boolean_PointerEventData_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_ToggleMoz_Protected_Void_Boolean_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_ForceCancel_Protected_Virtual_New_Boolean_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_ResetDrag_Protected_Virtual_New_Void_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_getOverView_Protected_Virtual_New_EntityView_PointerEventData_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_getParentUnit_Public_Virtual_New_UnitView_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_processCardIfUI_Protected_Virtual_New_Void_LocalTransform_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_isDropSelectionBlocked_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_attemptSelection_Protected_Virtual_New_Boolean_EntityID_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_selfSelectionOnDrop_Protected_Virtual_New_EntityID_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_AttemptCancelOnFailedDrop_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_AnimateOnDropSelectEntity_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseDown_Public_Void_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0;

		// Token: 0x0200035D RID: 861
		[ObfuscatedName("boardgames.input.DraggableCard+<AnimateOnDropSelectEntity>d__40")]
		public sealed class _AnimateOnDropSelectEntity_d__40 : global::Il2CppSystem.Object
		{
			// Token: 0x0600287C RID: 10364 RVA: 0x000A1D04 File Offset: 0x0009FF04
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateOnDropSelectEntity_d__40()
			{
				Il2CppClassPointerStore<DraggableCard._AnimateOnDropSelectEntity_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "<AnimateOnDropSelectEntity>d__40");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DraggableCard._AnimateOnDropSelectEntity_d__40>.NativeClassPtr);
				DraggableCard._AnimateOnDropSelectEntity_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard._AnimateOnDropSelectEntity_d__40>.NativeClassPtr, "<>1__state");
				DraggableCard._AnimateOnDropSelectEntity_d__40.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard._AnimateOnDropSelectEntity_d__40>.NativeClassPtr, "<>2__current");
				DraggableCard._AnimateOnDropSelectEntity_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard._AnimateOnDropSelectEntity_d__40>.NativeClassPtr, 100665288);
				DraggableCard._AnimateOnDropSelectEntity_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard._AnimateOnDropSelectEntity_d__40>.NativeClassPtr, 100665289);
				DraggableCard._AnimateOnDropSelectEntity_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard._AnimateOnDropSelectEntity_d__40>.NativeClassPtr, 100665290);
				DraggableCard._AnimateOnDropSelectEntity_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard._AnimateOnDropSelectEntity_d__40>.NativeClassPtr, 100665291);
				DraggableCard._AnimateOnDropSelectEntity_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard._AnimateOnDropSelectEntity_d__40>.NativeClassPtr, 100665292);
				DraggableCard._AnimateOnDropSelectEntity_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard._AnimateOnDropSelectEntity_d__40>.NativeClassPtr, 100665293);
			}

			// Token: 0x0600287D RID: 10365 RVA: 0x000A1DD0 File Offset: 0x0009FFD0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateOnDropSelectEntity_d__40(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DraggableCard._AnimateOnDropSelectEntity_d__40>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard._AnimateOnDropSelectEntity_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600287E RID: 10366 RVA: 0x000A1E18 File Offset: 0x000A0018
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard._AnimateOnDropSelectEntity_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600287F RID: 10367 RVA: 0x000A1E4C File Offset: 0x000A004C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard._AnimateOnDropSelectEntity_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B55 RID: 2901
			// (get) Token: 0x06002880 RID: 10368 RVA: 0x000A1E88 File Offset: 0x000A0088
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard._AnimateOnDropSelectEntity_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002881 RID: 10369 RVA: 0x000A1EC8 File Offset: 0x000A00C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510948, XrefRangeEnd = 510953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard._AnimateOnDropSelectEntity_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B56 RID: 2902
			// (get) Token: 0x06002882 RID: 10370 RVA: 0x000A1EFC File Offset: 0x000A00FC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard._AnimateOnDropSelectEntity_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002883 RID: 10371 RVA: 0x00014E3E File Offset: 0x0001303E
			public _AnimateOnDropSelectEntity_d__40(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B53 RID: 2899
			// (get) Token: 0x06002884 RID: 10372 RVA: 0x000A1F3C File Offset: 0x000A013C
			// (set) Token: 0x06002885 RID: 10373 RVA: 0x00014E47 File Offset: 0x00013047
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._AnimateOnDropSelectEntity_d__40.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._AnimateOnDropSelectEntity_d__40.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B54 RID: 2900
			// (get) Token: 0x06002886 RID: 10374 RVA: 0x000A1F64 File Offset: 0x000A0164
			// (set) Token: 0x06002887 RID: 10375 RVA: 0x00014E62 File Offset: 0x00013062
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._AnimateOnDropSelectEntity_d__40.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._AnimateOnDropSelectEntity_d__40.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400195A RID: 6490
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400195B RID: 6491
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400195C RID: 6492
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400195D RID: 6493
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400195E RID: 6494
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400195F RID: 6495
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001960 RID: 6496
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001961 RID: 6497
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200035E RID: 862
		[ObfuscatedName("boardgames.input.DraggableCard+<StopDrag>d__28")]
		public sealed class _StopDrag_d__28 : global::Il2CppSystem.Object
		{
			// Token: 0x06002888 RID: 10376 RVA: 0x000A1F94 File Offset: 0x000A0194
			// Note: this type is marked as 'beforefieldinit'.
			static _StopDrag_d__28()
			{
				Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DraggableCard>.NativeClassPtr, "<StopDrag>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr);
				DraggableCard._StopDrag_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr, "<>1__state");
				DraggableCard._StopDrag_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr, "<>2__current");
				DraggableCard._StopDrag_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr, "<>4__this");
				DraggableCard._StopDrag_d__28.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr, "eventData");
				DraggableCard._StopDrag_d__28.NativeFieldInfoPtr__selectSelfOnStopDrag_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr, "<selectSelfOnStopDrag>5__2");
				DraggableCard._StopDrag_d__28.NativeFieldInfoPtr__selectEntity_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr, "<selectEntity>5__3");
				DraggableCard._StopDrag_d__28.NativeFieldInfoPtr__dropAnimation_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr, "<dropAnimation>5__4");
				DraggableCard._StopDrag_d__28.NativeFieldInfoPtr__submitConfirmation_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr, "<submitConfirmation>5__5");
				DraggableCard._StopDrag_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr, 100665294);
				DraggableCard._StopDrag_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr, 100665295);
				DraggableCard._StopDrag_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr, 100665296);
				DraggableCard._StopDrag_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr, 100665297);
				DraggableCard._StopDrag_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr, 100665298);
				DraggableCard._StopDrag_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr, 100665299);
			}

			// Token: 0x06002889 RID: 10377 RVA: 0x000A20D8 File Offset: 0x000A02D8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StopDrag_d__28(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DraggableCard._StopDrag_d__28>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard._StopDrag_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600288A RID: 10378 RVA: 0x000A2120 File Offset: 0x000A0320
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard._StopDrag_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600288B RID: 10379 RVA: 0x000A2154 File Offset: 0x000A0354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510953, XrefRangeEnd = 511036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard._StopDrag_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B5F RID: 2911
			// (get) Token: 0x0600288C RID: 10380 RVA: 0x000A2190 File Offset: 0x000A0390
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard._StopDrag_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600288D RID: 10381 RVA: 0x000A21D0 File Offset: 0x000A03D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511036, XrefRangeEnd = 511041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard._StopDrag_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B60 RID: 2912
			// (get) Token: 0x0600288E RID: 10382 RVA: 0x000A2204 File Offset: 0x000A0404
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableCard._StopDrag_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600288F RID: 10383 RVA: 0x00014E81 File Offset: 0x00013081
			public _StopDrag_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B57 RID: 2903
			// (get) Token: 0x06002890 RID: 10384 RVA: 0x000A2244 File Offset: 0x000A0444
			// (set) Token: 0x06002891 RID: 10385 RVA: 0x00014E8A File Offset: 0x0001308A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B58 RID: 2904
			// (get) Token: 0x06002892 RID: 10386 RVA: 0x000A226C File Offset: 0x000A046C
			// (set) Token: 0x06002893 RID: 10387 RVA: 0x00014EA5 File Offset: 0x000130A5
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B59 RID: 2905
			// (get) Token: 0x06002894 RID: 10388 RVA: 0x000A229C File Offset: 0x000A049C
			// (set) Token: 0x06002895 RID: 10389 RVA: 0x00014EC4 File Offset: 0x000130C4
			public unsafe DraggableCard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableCard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B5A RID: 2906
			// (get) Token: 0x06002896 RID: 10390 RVA: 0x000A22CC File Offset: 0x000A04CC
			// (set) Token: 0x06002897 RID: 10391 RVA: 0x00014EE3 File Offset: 0x000130E3
			public unsafe PointerEventData eventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr_eventData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B5B RID: 2907
			// (get) Token: 0x06002898 RID: 10392 RVA: 0x000A22FC File Offset: 0x000A04FC
			// (set) Token: 0x06002899 RID: 10393 RVA: 0x00014F02 File Offset: 0x00013102
			public unsafe bool _selectSelfOnStopDrag_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr__selectSelfOnStopDrag_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr__selectSelfOnStopDrag_5__2)) = value;
				}
			}

			// Token: 0x17000B5C RID: 2908
			// (get) Token: 0x0600289A RID: 10394 RVA: 0x000A2324 File Offset: 0x000A0524
			// (set) Token: 0x0600289B RID: 10395 RVA: 0x00014F1D File Offset: 0x0001311D
			public unsafe EntityID _selectEntity_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr__selectEntity_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr__selectEntity_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B5D RID: 2909
			// (get) Token: 0x0600289C RID: 10396 RVA: 0x000A2354 File Offset: 0x000A0554
			// (set) Token: 0x0600289D RID: 10397 RVA: 0x00014F3C File Offset: 0x0001313C
			public unsafe IEnumerator _dropAnimation_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr__dropAnimation_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr__dropAnimation_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B5E RID: 2910
			// (get) Token: 0x0600289E RID: 10398 RVA: 0x000A2384 File Offset: 0x000A0584
			// (set) Token: 0x0600289F RID: 10399 RVA: 0x00014F5B File Offset: 0x0001315B
			public unsafe IEnumerator<Nullable<bool>> _submitConfirmation_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr__submitConfirmation_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Nullable<bool>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableCard._StopDrag_d__28.NativeFieldInfoPtr__submitConfirmation_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001962 RID: 6498
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001963 RID: 6499
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001964 RID: 6500
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001965 RID: 6501
			private static readonly IntPtr NativeFieldInfoPtr_eventData;

			// Token: 0x04001966 RID: 6502
			private static readonly IntPtr NativeFieldInfoPtr__selectSelfOnStopDrag_5__2;

			// Token: 0x04001967 RID: 6503
			private static readonly IntPtr NativeFieldInfoPtr__selectEntity_5__3;

			// Token: 0x04001968 RID: 6504
			private static readonly IntPtr NativeFieldInfoPtr__dropAnimation_5__4;

			// Token: 0x04001969 RID: 6505
			private static readonly IntPtr NativeFieldInfoPtr__submitConfirmation_5__5;

			// Token: 0x0400196A RID: 6506
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400196B RID: 6507
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400196C RID: 6508
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400196D RID: 6509
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400196E RID: 6510
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400196F RID: 6511
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
