using System;
using boardgames.match.behaviours;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.canis.dbg_client.input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using UnityEngine.EventSystems;

namespace boardgames.input
{
	// Token: 0x0200013C RID: 316
	public class PlaymatPhysicsInput : MonoBehaviour
	{
		// Token: 0x06000E56 RID: 3670 RVA: 0x0004B160 File Offset: 0x00049360
		// Note: this type is marked as 'beforefieldinit'.
		static PlaymatPhysicsInput()
		{
			Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "PlaymatPhysicsInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr);
			PlaymatPhysicsInput.NativeFieldInfoPtr_targetCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, "targetCamera");
			PlaymatPhysicsInput.NativeFieldInfoPtr__currentDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, "_currentDrag");
			PlaymatPhysicsInput.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, "selectionResponder");
			PlaymatPhysicsInput.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, "entitiesProvider");
			PlaymatPhysicsInput.NativeFieldInfoPtr_dragPassthrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, "dragPassthrough");
			PlaymatPhysicsInput.NativeMethodInfoPtr_get_currentDrag_Protected_Static_get_IDraggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, 100665374);
			PlaymatPhysicsInput.NativeMethodInfoPtr_set_currentDrag_Protected_Static_set_Void_IDraggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, 100665375);
			PlaymatPhysicsInput.NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, 100665376);
			PlaymatPhysicsInput.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, 100665377);
			PlaymatPhysicsInput.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, 100665378);
			PlaymatPhysicsInput.NativeMethodInfoPtr_PointerClick_Private_IEnumerator_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, 100665379);
			PlaymatPhysicsInput.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, 100665380);
			PlaymatPhysicsInput.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, 100665381);
			PlaymatPhysicsInput.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, 100665382);
			PlaymatPhysicsInput.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, 100665383);
			PlaymatPhysicsInput.NativeMethodInfoPtr_Submit_Private_IEnumerator_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, 100665384);
			PlaymatPhysicsInput.NativeMethodInfoPtr_Select_Private_IEnumerator_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, 100665385);
			PlaymatPhysicsInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, 100665386);
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x0004B2F8 File Offset: 0x000494F8
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x0004B32C File Offset: 0x0004952C
		public unsafe static IDraggable currentDrag
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 511994, RefRangeEnd = 512000, XrefRangeStart = 511987, XrefRangeEnd = 511994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput.NativeMethodInfoPtr_get_currentDrag_Protected_Static_get_IDraggable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDraggable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512000, XrefRangeEnd = 512004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput.NativeMethodInfoPtr_set_currentDrag_Protected_Static_set_Void_IDraggable_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x0004B364 File Offset: 0x00049564
		public unsafe bool IsDragging
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512004, XrefRangeEnd = 512005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput.NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0004B3A0 File Offset: 0x000495A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512005, XrefRangeEnd = 512024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaymatPhysicsInput.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0004B3DC File Offset: 0x000495DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512024, XrefRangeEnd = 512031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaymatPhysicsInput.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x0004B42C File Offset: 0x0004962C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512031, XrefRangeEnd = 512037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput.NativeMethodInfoPtr_PointerClick_Private_IEnumerator_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0004B47C File Offset: 0x0004967C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512037, XrefRangeEnd = 512062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaymatPhysicsInput.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x0004B4CC File Offset: 0x000496CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512062, XrefRangeEnd = 512087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x0004B510 File Offset: 0x00049710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512087, XrefRangeEnd = 512112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaymatPhysicsInput.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x0004B560 File Offset: 0x00049760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 512120, RefRangeEnd = 512121, XrefRangeStart = 512112, XrefRangeEnd = 512120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0004B5A4 File Offset: 0x000497A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512121, XrefRangeEnd = 512127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Submit(GameObject selectedObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput.NativeMethodInfoPtr_Submit_Private_IEnumerator_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x0004B5F4 File Offset: 0x000497F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 512133, RefRangeEnd = 512134, XrefRangeStart = 512127, XrefRangeEnd = 512133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Select(EntityView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput.NativeMethodInfoPtr_Select_Private_IEnumerator_EntityView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0004B644 File Offset: 0x00049844
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaymatPhysicsInput()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00008F0E File Offset: 0x0000710E
		public PlaymatPhysicsInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x0004B680 File Offset: 0x00049880
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x00008F17 File Offset: 0x00007117
		public unsafe Camera targetCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput.NativeFieldInfoPtr_targetCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput.NativeFieldInfoPtr_targetCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x0004B6B0 File Offset: 0x000498B0
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x00008F36 File Offset: 0x00007136
		public unsafe static IDraggable _currentDrag
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlaymatPhysicsInput.NativeFieldInfoPtr__currentDrag, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDraggable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlaymatPhysicsInput.NativeFieldInfoPtr__currentDrag, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x0004B6D8 File Offset: 0x000498D8
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x00008F48 File Offset: 0x00007148
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x0004B708 File Offset: 0x00049908
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x00008F67 File Offset: 0x00007167
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x0004B738 File Offset: 0x00049938
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00008F86 File Offset: 0x00007186
		public unsafe IDragPassthrough dragPassthrough
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput.NativeFieldInfoPtr_dragPassthrough);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDragPassthrough>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput.NativeFieldInfoPtr_dragPassthrough), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeFieldInfoPtr_targetCamera;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeFieldInfoPtr__currentDrag;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeFieldInfoPtr_dragPassthrough;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_get_currentDrag_Protected_Static_get_IDraggable_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_set_currentDrag_Protected_Static_set_Void_IDraggable_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_PointerClick_Private_IEnumerator_PointerEventData_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeMethodInfoPtr_Submit_Private_IEnumerator_GameObject_0;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeMethodInfoPtr_Select_Private_IEnumerator_EntityView_0;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000364 RID: 868
		[ObfuscatedName("boardgames.input.PlaymatPhysicsInput+<PointerClick>d__12")]
		public sealed class _PointerClick_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x060028E3 RID: 10467 RVA: 0x000A3050 File Offset: 0x000A1250
			// Note: this type is marked as 'beforefieldinit'.
			static _PointerClick_d__12()
			{
				Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, "<PointerClick>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr);
				PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr, "<>1__state");
				PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr, "<>2__current");
				PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr, "eventData");
				PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr, "<>4__this");
				PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr__clickedObject_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr, "<clickedObject>5__2");
				PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr__selected_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr, "<selected>5__3");
				PlaymatPhysicsInput._PointerClick_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr, 100665387);
				PlaymatPhysicsInput._PointerClick_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr, 100665388);
				PlaymatPhysicsInput._PointerClick_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr, 100665389);
				PlaymatPhysicsInput._PointerClick_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr, 100665390);
				PlaymatPhysicsInput._PointerClick_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr, 100665391);
				PlaymatPhysicsInput._PointerClick_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr, 100665392);
			}

			// Token: 0x060028E4 RID: 10468 RVA: 0x000A316C File Offset: 0x000A136C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PointerClick_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymatPhysicsInput._PointerClick_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._PointerClick_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028E5 RID: 10469 RVA: 0x000A31B4 File Offset: 0x000A13B4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._PointerClick_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028E6 RID: 10470 RVA: 0x000A31E8 File Offset: 0x000A13E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511898, XrefRangeEnd = 511932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._PointerClick_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B7E RID: 2942
			// (get) Token: 0x060028E7 RID: 10471 RVA: 0x000A3224 File Offset: 0x000A1424
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._PointerClick_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028E8 RID: 10472 RVA: 0x000A3264 File Offset: 0x000A1464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511932, XrefRangeEnd = 511937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._PointerClick_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B7F RID: 2943
			// (get) Token: 0x060028E9 RID: 10473 RVA: 0x000A3298 File Offset: 0x000A1498
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._PointerClick_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028EA RID: 10474 RVA: 0x00015169 File Offset: 0x00013369
			public _PointerClick_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B78 RID: 2936
			// (get) Token: 0x060028EB RID: 10475 RVA: 0x000A32D8 File Offset: 0x000A14D8
			// (set) Token: 0x060028EC RID: 10476 RVA: 0x00015172 File Offset: 0x00013372
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B79 RID: 2937
			// (get) Token: 0x060028ED RID: 10477 RVA: 0x000A3300 File Offset: 0x000A1500
			// (set) Token: 0x060028EE RID: 10478 RVA: 0x0001518D File Offset: 0x0001338D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B7A RID: 2938
			// (get) Token: 0x060028EF RID: 10479 RVA: 0x000A3330 File Offset: 0x000A1530
			// (set) Token: 0x060028F0 RID: 10480 RVA: 0x000151AC File Offset: 0x000133AC
			public unsafe PointerEventData eventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr_eventData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B7B RID: 2939
			// (get) Token: 0x060028F1 RID: 10481 RVA: 0x000A3360 File Offset: 0x000A1560
			// (set) Token: 0x060028F2 RID: 10482 RVA: 0x000151CB File Offset: 0x000133CB
			public unsafe PlaymatPhysicsInput __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaymatPhysicsInput>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B7C RID: 2940
			// (get) Token: 0x060028F3 RID: 10483 RVA: 0x000A3390 File Offset: 0x000A1590
			// (set) Token: 0x060028F4 RID: 10484 RVA: 0x000151EA File Offset: 0x000133EA
			public unsafe GameObject _clickedObject_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr__clickedObject_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr__clickedObject_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B7D RID: 2941
			// (get) Token: 0x060028F5 RID: 10485 RVA: 0x000A33C0 File Offset: 0x000A15C0
			// (set) Token: 0x060028F6 RID: 10486 RVA: 0x00015209 File Offset: 0x00013409
			public unsafe bool _selected_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr__selected_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._PointerClick_d__12.NativeFieldInfoPtr__selected_5__3)) = value;
				}
			}

			// Token: 0x04001998 RID: 6552
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001999 RID: 6553
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400199A RID: 6554
			private static readonly IntPtr NativeFieldInfoPtr_eventData;

			// Token: 0x0400199B RID: 6555
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400199C RID: 6556
			private static readonly IntPtr NativeFieldInfoPtr__clickedObject_5__2;

			// Token: 0x0400199D RID: 6557
			private static readonly IntPtr NativeFieldInfoPtr__selected_5__3;

			// Token: 0x0400199E RID: 6558
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400199F RID: 6559
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019A0 RID: 6560
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019A1 RID: 6561
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019A2 RID: 6562
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019A3 RID: 6563
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000365 RID: 869
		[ObfuscatedName("boardgames.input.PlaymatPhysicsInput+<Select>d__18")]
		public sealed class _Select_d__18 : global::Il2CppSystem.Object
		{
			// Token: 0x060028F7 RID: 10487 RVA: 0x000A33E8 File Offset: 0x000A15E8
			// Note: this type is marked as 'beforefieldinit'.
			static _Select_d__18()
			{
				Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, "<Select>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr);
				PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr, "<>1__state");
				PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr, "<>2__current");
				PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr, "<>4__this");
				PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr, "view");
				PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr__selected_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr, "<selected>5__2");
				PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr__selectEntity_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr, "<selectEntity>5__3");
				PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr__submitConfirmation_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr, "<submitConfirmation>5__4");
				PlaymatPhysicsInput._Select_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr, 100665393);
				PlaymatPhysicsInput._Select_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr, 100665394);
				PlaymatPhysicsInput._Select_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr, 100665395);
				PlaymatPhysicsInput._Select_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr, 100665396);
				PlaymatPhysicsInput._Select_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr, 100665397);
				PlaymatPhysicsInput._Select_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr, 100665398);
			}

			// Token: 0x060028F8 RID: 10488 RVA: 0x000A3518 File Offset: 0x000A1718
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Select_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymatPhysicsInput._Select_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._Select_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028F9 RID: 10489 RVA: 0x000A3560 File Offset: 0x000A1760
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._Select_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028FA RID: 10490 RVA: 0x000A3594 File Offset: 0x000A1794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511937, XrefRangeEnd = 511968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._Select_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B87 RID: 2951
			// (get) Token: 0x060028FB RID: 10491 RVA: 0x000A35D0 File Offset: 0x000A17D0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._Select_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028FC RID: 10492 RVA: 0x000A3610 File Offset: 0x000A1810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511968, XrefRangeEnd = 511973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._Select_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B88 RID: 2952
			// (get) Token: 0x060028FD RID: 10493 RVA: 0x000A3644 File Offset: 0x000A1844
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._Select_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028FE RID: 10494 RVA: 0x00015224 File Offset: 0x00013424
			public _Select_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B80 RID: 2944
			// (get) Token: 0x060028FF RID: 10495 RVA: 0x000A3684 File Offset: 0x000A1884
			// (set) Token: 0x06002900 RID: 10496 RVA: 0x0001522D File Offset: 0x0001342D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B81 RID: 2945
			// (get) Token: 0x06002901 RID: 10497 RVA: 0x000A36AC File Offset: 0x000A18AC
			// (set) Token: 0x06002902 RID: 10498 RVA: 0x00015248 File Offset: 0x00013448
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B82 RID: 2946
			// (get) Token: 0x06002903 RID: 10499 RVA: 0x000A36DC File Offset: 0x000A18DC
			// (set) Token: 0x06002904 RID: 10500 RVA: 0x00015267 File Offset: 0x00013467
			public unsafe PlaymatPhysicsInput __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaymatPhysicsInput>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B83 RID: 2947
			// (get) Token: 0x06002905 RID: 10501 RVA: 0x000A370C File Offset: 0x000A190C
			// (set) Token: 0x06002906 RID: 10502 RVA: 0x00015286 File Offset: 0x00013486
			public unsafe EntityView view
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr_view);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B84 RID: 2948
			// (get) Token: 0x06002907 RID: 10503 RVA: 0x000A373C File Offset: 0x000A193C
			// (set) Token: 0x06002908 RID: 10504 RVA: 0x000152A5 File Offset: 0x000134A5
			public unsafe bool _selected_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr__selected_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr__selected_5__2)) = value;
				}
			}

			// Token: 0x17000B85 RID: 2949
			// (get) Token: 0x06002909 RID: 10505 RVA: 0x000A3764 File Offset: 0x000A1964
			// (set) Token: 0x0600290A RID: 10506 RVA: 0x000152C0 File Offset: 0x000134C0
			public unsafe EntityID _selectEntity_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr__selectEntity_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr__selectEntity_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B86 RID: 2950
			// (get) Token: 0x0600290B RID: 10507 RVA: 0x000A3794 File Offset: 0x000A1994
			// (set) Token: 0x0600290C RID: 10508 RVA: 0x000152DF File Offset: 0x000134DF
			public unsafe IEnumerator<Nullable<bool>> _submitConfirmation_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr__submitConfirmation_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Nullable<bool>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Select_d__18.NativeFieldInfoPtr__submitConfirmation_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019A4 RID: 6564
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019A5 RID: 6565
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019A6 RID: 6566
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019A7 RID: 6567
			private static readonly IntPtr NativeFieldInfoPtr_view;

			// Token: 0x040019A8 RID: 6568
			private static readonly IntPtr NativeFieldInfoPtr__selected_5__2;

			// Token: 0x040019A9 RID: 6569
			private static readonly IntPtr NativeFieldInfoPtr__selectEntity_5__3;

			// Token: 0x040019AA RID: 6570
			private static readonly IntPtr NativeFieldInfoPtr__submitConfirmation_5__4;

			// Token: 0x040019AB RID: 6571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019AC RID: 6572
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019AD RID: 6573
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019AE RID: 6574
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019AF RID: 6575
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019B0 RID: 6576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000366 RID: 870
		[ObfuscatedName("boardgames.input.PlaymatPhysicsInput+<Submit>d__17")]
		public sealed class _Submit_d__17 : global::Il2CppSystem.Object
		{
			// Token: 0x0600290D RID: 10509 RVA: 0x000A37C4 File Offset: 0x000A19C4
			// Note: this type is marked as 'beforefieldinit'.
			static _Submit_d__17()
			{
				Il2CppClassPointerStore<PlaymatPhysicsInput._Submit_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaymatPhysicsInput>.NativeClassPtr, "<Submit>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymatPhysicsInput._Submit_d__17>.NativeClassPtr);
				PlaymatPhysicsInput._Submit_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._Submit_d__17>.NativeClassPtr, "<>1__state");
				PlaymatPhysicsInput._Submit_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._Submit_d__17>.NativeClassPtr, "<>2__current");
				PlaymatPhysicsInput._Submit_d__17.NativeFieldInfoPtr_selectedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._Submit_d__17>.NativeClassPtr, "selectedObject");
				PlaymatPhysicsInput._Submit_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInput._Submit_d__17>.NativeClassPtr, "<>4__this");
				PlaymatPhysicsInput._Submit_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._Submit_d__17>.NativeClassPtr, 100665399);
				PlaymatPhysicsInput._Submit_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._Submit_d__17>.NativeClassPtr, 100665400);
				PlaymatPhysicsInput._Submit_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._Submit_d__17>.NativeClassPtr, 100665401);
				PlaymatPhysicsInput._Submit_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._Submit_d__17>.NativeClassPtr, 100665402);
				PlaymatPhysicsInput._Submit_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._Submit_d__17>.NativeClassPtr, 100665403);
				PlaymatPhysicsInput._Submit_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInput._Submit_d__17>.NativeClassPtr, 100665404);
			}

			// Token: 0x0600290E RID: 10510 RVA: 0x000A38B8 File Offset: 0x000A1AB8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Submit_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymatPhysicsInput._Submit_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._Submit_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600290F RID: 10511 RVA: 0x000A3900 File Offset: 0x000A1B00
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._Submit_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002910 RID: 10512 RVA: 0x000A3934 File Offset: 0x000A1B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511973, XrefRangeEnd = 511982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._Submit_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B8D RID: 2957
			// (get) Token: 0x06002911 RID: 10513 RVA: 0x000A3970 File Offset: 0x000A1B70
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._Submit_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002912 RID: 10514 RVA: 0x000A39B0 File Offset: 0x000A1BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511982, XrefRangeEnd = 511987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._Submit_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B8E RID: 2958
			// (get) Token: 0x06002913 RID: 10515 RVA: 0x000A39E4 File Offset: 0x000A1BE4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInput._Submit_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002914 RID: 10516 RVA: 0x000152FE File Offset: 0x000134FE
			public _Submit_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B89 RID: 2953
			// (get) Token: 0x06002915 RID: 10517 RVA: 0x000A3A24 File Offset: 0x000A1C24
			// (set) Token: 0x06002916 RID: 10518 RVA: 0x00015307 File Offset: 0x00013507
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Submit_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Submit_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B8A RID: 2954
			// (get) Token: 0x06002917 RID: 10519 RVA: 0x000A3A4C File Offset: 0x000A1C4C
			// (set) Token: 0x06002918 RID: 10520 RVA: 0x00015322 File Offset: 0x00013522
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Submit_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Submit_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B8B RID: 2955
			// (get) Token: 0x06002919 RID: 10521 RVA: 0x000A3A7C File Offset: 0x000A1C7C
			// (set) Token: 0x0600291A RID: 10522 RVA: 0x00015341 File Offset: 0x00013541
			public unsafe GameObject selectedObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Submit_d__17.NativeFieldInfoPtr_selectedObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Submit_d__17.NativeFieldInfoPtr_selectedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B8C RID: 2956
			// (get) Token: 0x0600291B RID: 10523 RVA: 0x000A3AAC File Offset: 0x000A1CAC
			// (set) Token: 0x0600291C RID: 10524 RVA: 0x00015360 File Offset: 0x00013560
			public unsafe PlaymatPhysicsInput __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Submit_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaymatPhysicsInput>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInput._Submit_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019B1 RID: 6577
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019B2 RID: 6578
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019B3 RID: 6579
			private static readonly IntPtr NativeFieldInfoPtr_selectedObject;

			// Token: 0x040019B4 RID: 6580
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019B5 RID: 6581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019B6 RID: 6582
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019B7 RID: 6583
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019B8 RID: 6584
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019B9 RID: 6585
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019BA RID: 6586
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
