using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace worm.match.components
{
	// Token: 0x020001E8 RID: 488
	public class WormDraggableIntrigueCard : WormDraggableCard
	{
		// Token: 0x0600159F RID: 5535 RVA: 0x00059D64 File Offset: 0x00057F64
		// Note: this type is marked as 'beforefieldinit'.
		static WormDraggableIntrigueCard()
		{
			Il2CppClassPointerStore<WormDraggableIntrigueCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormDraggableIntrigueCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDraggableIntrigueCard>.NativeClassPtr);
			WormDraggableIntrigueCard.NativeFieldInfoPtr_onResetDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableIntrigueCard>.NativeClassPtr, "onResetDrag");
			WormDraggableIntrigueCard.NativeFieldInfoPtr_playHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableIntrigueCard>.NativeClassPtr, "playHandler");
			WormDraggableIntrigueCard.NativeFieldInfoPtr_cursorHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDraggableIntrigueCard>.NativeClassPtr, "cursorHandler");
			WormDraggableIntrigueCard.NativeMethodInfoPtr_StartDrag_Public_Virtual_Boolean_Camera_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableIntrigueCard>.NativeClassPtr, 100666293);
			WormDraggableIntrigueCard.NativeMethodInfoPtr_ResetDrag_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableIntrigueCard>.NativeClassPtr, 100666294);
			WormDraggableIntrigueCard.NativeMethodInfoPtr_AnimateOnDropSelectEntity_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableIntrigueCard>.NativeClassPtr, 100666295);
			WormDraggableIntrigueCard.NativeMethodInfoPtr_OnSubmitUnusualSelectionCancel_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableIntrigueCard>.NativeClassPtr, 100666296);
			WormDraggableIntrigueCard.NativeMethodInfoPtr_GetCursorHandler_Private_WormWillClearUndoCursorHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableIntrigueCard>.NativeClassPtr, 100666297);
			WormDraggableIntrigueCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDraggableIntrigueCard>.NativeClassPtr, 100666298);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00059E48 File Offset: 0x00058048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715686, XrefRangeEnd = 715694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDraggableIntrigueCard.NativeMethodInfoPtr_StartDrag_Public_Virtual_Boolean_Camera_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00059EB4 File Offset: 0x000580B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715694, XrefRangeEnd = 715703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDraggableIntrigueCard.NativeMethodInfoPtr_ResetDrag_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00059EF0 File Offset: 0x000580F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715703, XrefRangeEnd = 715708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator AnimateOnDropSelectEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDraggableIntrigueCard.NativeMethodInfoPtr_AnimateOnDropSelectEntity_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00059F3C File Offset: 0x0005813C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715708, XrefRangeEnd = 715709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSubmitUnusualSelectionCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDraggableIntrigueCard.NativeMethodInfoPtr_OnSubmitUnusualSelectionCancel_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00059F78 File Offset: 0x00058178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 715717, RefRangeEnd = 715719, XrefRangeStart = 715709, XrefRangeEnd = 715717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormWillClearUndoCursorHandler GetCursorHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableIntrigueCard.NativeMethodInfoPtr_GetCursorHandler_Private_WormWillClearUndoCursorHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormWillClearUndoCursorHandler>(intPtr3) : null;
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00059FB8 File Offset: 0x000581B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715719, XrefRangeEnd = 715725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDraggableIntrigueCard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDraggableIntrigueCard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDraggableIntrigueCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x0000D186 File Offset: 0x0000B386
		public WormDraggableIntrigueCard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00059FF4 File Offset: 0x000581F4
		// (set) Token: 0x060015A8 RID: 5544 RVA: 0x0000D18F File Offset: 0x0000B38F
		public unsafe UnityEvent onResetDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableIntrigueCard.NativeFieldInfoPtr_onResetDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableIntrigueCard.NativeFieldInfoPtr_onResetDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x0005A024 File Offset: 0x00058224
		// (set) Token: 0x060015AA RID: 5546 RVA: 0x0000D1AE File Offset: 0x0000B3AE
		public unsafe WormIntrigueCardPlayHandler playHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableIntrigueCard.NativeFieldInfoPtr_playHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntrigueCardPlayHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableIntrigueCard.NativeFieldInfoPtr_playHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x0005A054 File Offset: 0x00058254
		// (set) Token: 0x060015AC RID: 5548 RVA: 0x0000D1CD File Offset: 0x0000B3CD
		public unsafe WormWillClearUndoCursorHandler cursorHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableIntrigueCard.NativeFieldInfoPtr_cursorHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormWillClearUndoCursorHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDraggableIntrigueCard.NativeFieldInfoPtr_cursorHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeFieldInfoPtr_onResetDrag;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeFieldInfoPtr_playHandler;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeFieldInfoPtr_cursorHandler;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_StartDrag_Public_Virtual_Boolean_Camera_PointerEventData_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_ResetDrag_Protected_Virtual_Void_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_AnimateOnDropSelectEntity_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmitUnusualSelectionCancel_Protected_Virtual_Void_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorHandler_Private_WormWillClearUndoCursorHandler_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
