using System;
using boardgames.camera;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace boardgames.input
{
	// Token: 0x0200013A RID: 314
	public class PlaymatDragHandler : MonoBehaviour
	{
		// Token: 0x06000E23 RID: 3619 RVA: 0x0004A824 File Offset: 0x00048A24
		// Note: this type is marked as 'beforefieldinit'.
		static PlaymatDragHandler()
		{
			Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "PlaymatDragHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr);
			PlaymatDragHandler.NativeFieldInfoPtr_endDragSmoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, "endDragSmoothTime");
			PlaymatDragHandler.NativeFieldInfoPtr_onDragStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, "onDragStart");
			PlaymatDragHandler.NativeFieldInfoPtr_onDragEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, "onDragEnd");
			PlaymatDragHandler.NativeFieldInfoPtr_cameraControlProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, "cameraControlProvider");
			PlaymatDragHandler.NativeFieldInfoPtr_endDragPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, "endDragPosition");
			PlaymatDragHandler.NativeFieldInfoPtr_endDragVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, "endDragVelocity");
			PlaymatDragHandler.NativeFieldInfoPtr_endDragDamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, "endDragDamp");
			PlaymatDragHandler.NativeMethodInfoPtr_get_OnDragStart_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, 100665353);
			PlaymatDragHandler.NativeMethodInfoPtr_get_OnDragEnd_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, 100665354);
			PlaymatDragHandler.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, 100665355);
			PlaymatDragHandler.NativeMethodInfoPtr_get_AllowSelectOnClick_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, 100665356);
			PlaymatDragHandler.NativeMethodInfoPtr_StartDrag_Public_Virtual_Final_New_Boolean_Camera_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, 100665357);
			PlaymatDragHandler.NativeMethodInfoPtr_UpdateDrag_Public_Virtual_Final_New_Boolean_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, 100665358);
			PlaymatDragHandler.NativeMethodInfoPtr_StopDrag_Public_Virtual_Final_New_IEnumerator_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, 100665359);
			PlaymatDragHandler.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, 100665360);
			PlaymatDragHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, 100665361);
			PlaymatDragHandler.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, 100665362);
			PlaymatDragHandler.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, 100665363);
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x0004A9BC File Offset: 0x00048BBC
		public unsafe UnityEvent OnDragStart
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler.NativeMethodInfoPtr_get_OnDragStart_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x0004A9FC File Offset: 0x00048BFC
		public unsafe UnityEvent OnDragEnd
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler.NativeMethodInfoPtr_get_OnDragEnd_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0004AA3C File Offset: 0x00048C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511799, XrefRangeEnd = 511803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x0004AA70 File Offset: 0x00048C70
		public unsafe virtual bool AllowSelectOnClick
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler.NativeMethodInfoPtr_get_AllowSelectOnClick_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0004AAAC File Offset: 0x00048CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511803, XrefRangeEnd = 511808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler.NativeMethodInfoPtr_StartDrag_Public_Virtual_Final_New_Boolean_Camera_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0004AB0C File Offset: 0x00048D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511808, XrefRangeEnd = 511812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UpdateDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler.NativeMethodInfoPtr_UpdateDrag_Public_Virtual_Final_New_Boolean_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0004AB5C File Offset: 0x00048D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511812, XrefRangeEnd = 511818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator StopDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler.NativeMethodInfoPtr_StopDrag_Public_Virtual_Final_New_IEnumerator_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0004ABAC File Offset: 0x00048DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511818, XrefRangeEnd = 511827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0004ABE0 File Offset: 0x00048DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511827, XrefRangeEnd = 511837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaymatDragHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0004AC1C File Offset: 0x00048E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject IGameObject_get_gameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0004AC5C File Offset: 0x00048E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform IGameObject_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00008D30 File Offset: 0x00006F30
		public PlaymatDragHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x0004AC9C File Offset: 0x00048E9C
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x00008D39 File Offset: 0x00006F39
		public unsafe float endDragSmoothTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler.NativeFieldInfoPtr_endDragSmoothTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler.NativeFieldInfoPtr_endDragSmoothTime)) = value;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x0004ACC4 File Offset: 0x00048EC4
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x00008D54 File Offset: 0x00006F54
		public unsafe UnityEvent onDragStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler.NativeFieldInfoPtr_onDragStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler.NativeFieldInfoPtr_onDragStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x0004ACF4 File Offset: 0x00048EF4
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00008D73 File Offset: 0x00006F73
		public unsafe UnityEvent onDragEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler.NativeFieldInfoPtr_onDragEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler.NativeFieldInfoPtr_onDragEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x0004AD24 File Offset: 0x00048F24
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x00008D92 File Offset: 0x00006F92
		public unsafe ICameraTranslator cameraControlProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler.NativeFieldInfoPtr_cameraControlProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICameraTranslator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler.NativeFieldInfoPtr_cameraControlProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x0004AD54 File Offset: 0x00048F54
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00008DB1 File Offset: 0x00006FB1
		public unsafe Vector3 endDragPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler.NativeFieldInfoPtr_endDragPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler.NativeFieldInfoPtr_endDragPosition)) = value;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x0004AD7C File Offset: 0x00048F7C
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x00008DCC File Offset: 0x00006FCC
		public unsafe Vector3 endDragVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler.NativeFieldInfoPtr_endDragVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler.NativeFieldInfoPtr_endDragVelocity)) = value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x0004ADA4 File Offset: 0x00048FA4
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x00008DE7 File Offset: 0x00006FE7
		public unsafe Vector3 endDragDamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler.NativeFieldInfoPtr_endDragDamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler.NativeFieldInfoPtr_endDragDamp)) = value;
			}
		}

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeFieldInfoPtr_endDragSmoothTime;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeFieldInfoPtr_onDragStart;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeFieldInfoPtr_onDragEnd;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeFieldInfoPtr_cameraControlProvider;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeFieldInfoPtr_endDragPosition;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeFieldInfoPtr_endDragVelocity;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeFieldInfoPtr_endDragDamp;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr_get_OnDragStart_Public_get_UnityEvent_0;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr_get_OnDragEnd_Public_get_UnityEvent_0;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowSelectOnClick_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_StartDrag_Public_Virtual_Final_New_Boolean_Camera_PointerEventData_0;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_Public_Virtual_Final_New_Boolean_PointerEventData_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_StopDrag_Public_Virtual_Final_New_IEnumerator_PointerEventData_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0;

		// Token: 0x02000363 RID: 867
		[ObfuscatedName("boardgames.input.PlaymatDragHandler+<StopDrag>d__16")]
		public sealed class _StopDrag_d__16 : global::Il2CppSystem.Object
		{
			// Token: 0x060028D3 RID: 10451 RVA: 0x000A2D38 File Offset: 0x000A0F38
			// Note: this type is marked as 'beforefieldinit'.
			static _StopDrag_d__16()
			{
				Il2CppClassPointerStore<PlaymatDragHandler._StopDrag_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaymatDragHandler>.NativeClassPtr, "<StopDrag>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymatDragHandler._StopDrag_d__16>.NativeClassPtr);
				PlaymatDragHandler._StopDrag_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatDragHandler._StopDrag_d__16>.NativeClassPtr, "<>1__state");
				PlaymatDragHandler._StopDrag_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatDragHandler._StopDrag_d__16>.NativeClassPtr, "<>2__current");
				PlaymatDragHandler._StopDrag_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatDragHandler._StopDrag_d__16>.NativeClassPtr, "<>4__this");
				PlaymatDragHandler._StopDrag_d__16.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatDragHandler._StopDrag_d__16>.NativeClassPtr, "eventData");
				PlaymatDragHandler._StopDrag_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler._StopDrag_d__16>.NativeClassPtr, 100665364);
				PlaymatDragHandler._StopDrag_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler._StopDrag_d__16>.NativeClassPtr, 100665365);
				PlaymatDragHandler._StopDrag_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler._StopDrag_d__16>.NativeClassPtr, 100665366);
				PlaymatDragHandler._StopDrag_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler._StopDrag_d__16>.NativeClassPtr, 100665367);
				PlaymatDragHandler._StopDrag_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler._StopDrag_d__16>.NativeClassPtr, 100665368);
				PlaymatDragHandler._StopDrag_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatDragHandler._StopDrag_d__16>.NativeClassPtr, 100665369);
			}

			// Token: 0x060028D4 RID: 10452 RVA: 0x000A2E2C File Offset: 0x000A102C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StopDrag_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymatDragHandler._StopDrag_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler._StopDrag_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028D5 RID: 10453 RVA: 0x000A2E74 File Offset: 0x000A1074
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler._StopDrag_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028D6 RID: 10454 RVA: 0x000A2EA8 File Offset: 0x000A10A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511789, XrefRangeEnd = 511794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler._StopDrag_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B76 RID: 2934
			// (get) Token: 0x060028D7 RID: 10455 RVA: 0x000A2EE4 File Offset: 0x000A10E4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler._StopDrag_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028D8 RID: 10456 RVA: 0x000A2F24 File Offset: 0x000A1124
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511794, XrefRangeEnd = 511799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler._StopDrag_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B77 RID: 2935
			// (get) Token: 0x060028D9 RID: 10457 RVA: 0x000A2F58 File Offset: 0x000A1158
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatDragHandler._StopDrag_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028DA RID: 10458 RVA: 0x000150E8 File Offset: 0x000132E8
			public _StopDrag_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B72 RID: 2930
			// (get) Token: 0x060028DB RID: 10459 RVA: 0x000A2F98 File Offset: 0x000A1198
			// (set) Token: 0x060028DC RID: 10460 RVA: 0x000150F1 File Offset: 0x000132F1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler._StopDrag_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler._StopDrag_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B73 RID: 2931
			// (get) Token: 0x060028DD RID: 10461 RVA: 0x000A2FC0 File Offset: 0x000A11C0
			// (set) Token: 0x060028DE RID: 10462 RVA: 0x0001510C File Offset: 0x0001330C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler._StopDrag_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler._StopDrag_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B74 RID: 2932
			// (get) Token: 0x060028DF RID: 10463 RVA: 0x000A2FF0 File Offset: 0x000A11F0
			// (set) Token: 0x060028E0 RID: 10464 RVA: 0x0001512B File Offset: 0x0001332B
			public unsafe PlaymatDragHandler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler._StopDrag_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaymatDragHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler._StopDrag_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B75 RID: 2933
			// (get) Token: 0x060028E1 RID: 10465 RVA: 0x000A3020 File Offset: 0x000A1220
			// (set) Token: 0x060028E2 RID: 10466 RVA: 0x0001514A File Offset: 0x0001334A
			public unsafe PointerEventData eventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler._StopDrag_d__16.NativeFieldInfoPtr_eventData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatDragHandler._StopDrag_d__16.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400198E RID: 6542
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400198F RID: 6543
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001990 RID: 6544
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001991 RID: 6545
			private static readonly IntPtr NativeFieldInfoPtr_eventData;

			// Token: 0x04001992 RID: 6546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001993 RID: 6547
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001994 RID: 6548
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001995 RID: 6549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001996 RID: 6550
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001997 RID: 6551
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
