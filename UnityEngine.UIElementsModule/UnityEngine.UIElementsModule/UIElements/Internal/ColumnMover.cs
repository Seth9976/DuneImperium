using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.Internal
{
	// Token: 0x020002AC RID: 684
	public class ColumnMover : PointerManipulator
	{
		// Token: 0x06003281 RID: 12929 RVA: 0x000D5C04 File Offset: 0x000D3E04
		// Note: this type is marked as 'beforefieldinit'.
		static ColumnMover()
		{
			Il2CppClassPointerStore<ColumnMover>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Internal", "ColumnMover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr);
			ColumnMover.NativeFieldInfoPtr_m_StartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "m_StartPos");
			ColumnMover.NativeFieldInfoPtr_m_LastPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "m_LastPos");
			ColumnMover.NativeFieldInfoPtr_m_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "m_Active");
			ColumnMover.NativeFieldInfoPtr_m_Moving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "m_Moving");
			ColumnMover.NativeFieldInfoPtr_m_Cancelled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "m_Cancelled");
			ColumnMover.NativeFieldInfoPtr_m_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "m_Header");
			ColumnMover.NativeFieldInfoPtr_m_PreviewElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "m_PreviewElement");
			ColumnMover.NativeFieldInfoPtr_m_LocationPreviewElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "m_LocationPreviewElement");
			ColumnMover.NativeFieldInfoPtr_m_ColumnToMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "m_ColumnToMove");
			ColumnMover.NativeFieldInfoPtr_m_ColumnToMovePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "m_ColumnToMovePos");
			ColumnMover.NativeFieldInfoPtr_m_ColumnToMoveWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "m_ColumnToMoveWidth");
			ColumnMover.NativeFieldInfoPtr_m_DestinationColumn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "m_DestinationColumn");
			ColumnMover.NativeFieldInfoPtr_m_MoveBeforeDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "m_MoveBeforeDestination");
			ColumnMover.NativeFieldInfoPtr__columnLayout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "<columnLayout>k__BackingField");
			ColumnMover.NativeFieldInfoPtr_activeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "activeChanged");
			ColumnMover.NativeFieldInfoPtr_movingChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, "movingChanged");
			ColumnMover.NativeMethodInfoPtr_get_columnLayout_Public_get_ColumnLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670633);
			ColumnMover.NativeMethodInfoPtr_set_columnLayout_Public_set_Void_ColumnLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670634);
			ColumnMover.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670635);
			ColumnMover.NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670636);
			ColumnMover.NativeMethodInfoPtr_get_moving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670637);
			ColumnMover.NativeMethodInfoPtr_set_moving_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670638);
			ColumnMover.NativeMethodInfoPtr_add_activeChanged_Public_add_Void_Action_1_ColumnMover_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670639);
			ColumnMover.NativeMethodInfoPtr_remove_activeChanged_Public_rem_Void_Action_1_ColumnMover_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670640);
			ColumnMover.NativeMethodInfoPtr_add_movingChanged_Public_add_Void_Action_1_ColumnMover_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670641);
			ColumnMover.NativeMethodInfoPtr_remove_movingChanged_Public_rem_Void_Action_1_ColumnMover_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670642);
			ColumnMover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670643);
			ColumnMover.NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670644);
			ColumnMover.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670645);
			ColumnMover.NativeMethodInfoPtr_OnMouseDown_Protected_Void_MouseDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670646);
			ColumnMover.NativeMethodInfoPtr_OnMouseMove_Protected_Void_MouseMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670647);
			ColumnMover.NativeMethodInfoPtr_OnMouseUp_Protected_Void_MouseUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670648);
			ColumnMover.NativeMethodInfoPtr_OnMouseCaptureOut_Private_Void_MouseCaptureOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670649);
			ColumnMover.NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670650);
			ColumnMover.NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670651);
			ColumnMover.NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670652);
			ColumnMover.NativeMethodInfoPtr_OnPointerCancel_Private_Void_PointerCancelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670653);
			ColumnMover.NativeMethodInfoPtr_OnPointerCaptureOut_Private_Void_PointerCaptureOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670654);
			ColumnMover.NativeMethodInfoPtr_IsNotMouseEvent_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670655);
			ColumnMover.NativeMethodInfoPtr_ProcessCancelEvent_Protected_Void_EventBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670656);
			ColumnMover.NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670657);
			ColumnMover.NativeMethodInfoPtr_ProcessDownEvent_Private_Void_EventBase_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670658);
			ColumnMover.NativeMethodInfoPtr_ProcessMoveEvent_Private_Void_EventBase_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670659);
			ColumnMover.NativeMethodInfoPtr_ProcessUpEvent_Private_Void_EventBase_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670660);
			ColumnMover.NativeMethodInfoPtr_BeginDragMove_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670661);
			ColumnMover.NativeMethodInfoPtr_DragMove_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670662);
			ColumnMover.NativeMethodInfoPtr_UpdatePreviewPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670663);
			ColumnMover.NativeMethodInfoPtr_UpdateMoveLocation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670664);
			ColumnMover.NativeMethodInfoPtr_EndDragMove_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr, 100670665);
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x000D6008 File Offset: 0x000D4208
		// (set) Token: 0x06003283 RID: 12931 RVA: 0x000D6048 File Offset: 0x000D4248
		public unsafe ColumnLayout columnLayout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_get_columnLayout_Public_get_ColumnLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColumnLayout>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_set_columnLayout_Public_set_Void_ColumnLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06003284 RID: 12932 RVA: 0x000D608C File Offset: 0x000D428C
		// (set) Token: 0x06003285 RID: 12933 RVA: 0x000D60C8 File Offset: 0x000D42C8
		public unsafe bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x06003286 RID: 12934 RVA: 0x000D6108 File Offset: 0x000D4308
		// (set) Token: 0x06003287 RID: 12935 RVA: 0x000D6144 File Offset: 0x000D4344
		public unsafe bool moving
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_get_moving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_set_moving_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x000D6184 File Offset: 0x000D4384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359875, XrefRangeEnd = 359880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_activeChanged(Action<ColumnMover> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_add_activeChanged_Public_add_Void_Action_1_ColumnMover_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x000D61C8 File Offset: 0x000D43C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359880, XrefRangeEnd = 359885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_activeChanged(Action<ColumnMover> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_remove_activeChanged_Public_rem_Void_Action_1_ColumnMover_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x000D620C File Offset: 0x000D440C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359885, XrefRangeEnd = 359890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_movingChanged(Action<ColumnMover> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_add_movingChanged_Public_add_Void_Action_1_ColumnMover_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x000D6250 File Offset: 0x000D4450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359890, XrefRangeEnd = 359895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_movingChanged(Action<ColumnMover> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_remove_movingChanged_Public_rem_Void_Action_1_ColumnMover_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x000D6294 File Offset: 0x000D4494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359895, XrefRangeEnd = 359899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColumnMover()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColumnMover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x000D62D0 File Offset: 0x000D44D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359899, XrefRangeEnd = 360000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RegisterCallbacksOnTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColumnMover.NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x000D630C File Offset: 0x000D450C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360000, XrefRangeEnd = 360101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnregisterCallbacksFromTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColumnMover.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x000D6348 File Offset: 0x000D4548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360101, XrefRangeEnd = 360108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseDown(MouseDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_OnMouseDown_Protected_Void_MouseDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x000D638C File Offset: 0x000D458C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360108, XrefRangeEnd = 360110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseMove(MouseMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_OnMouseMove_Protected_Void_MouseMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x000D63D0 File Offset: 0x000D45D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360110, XrefRangeEnd = 360117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseUp(MouseUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_OnMouseUp_Protected_Void_MouseUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x000D6414 File Offset: 0x000D4614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360117, XrefRangeEnd = 360122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseCaptureOut(MouseCaptureOutEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_OnMouseCaptureOut_Private_Void_MouseCaptureOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x000D6458 File Offset: 0x000D4658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360122, XrefRangeEnd = 360130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerDown(PointerDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x000D649C File Offset: 0x000D469C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360130, XrefRangeEnd = 360137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerMove(PointerMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x000D64E0 File Offset: 0x000D46E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360137, XrefRangeEnd = 360145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerUp(PointerUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x000D6524 File Offset: 0x000D4724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360145, XrefRangeEnd = 360152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerCancel(PointerCancelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_OnPointerCancel_Private_Void_PointerCancelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x000D6568 File Offset: 0x000D4768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360152, XrefRangeEnd = 360158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerCaptureOut(PointerCaptureOutEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_OnPointerCaptureOut_Private_Void_PointerCaptureOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x000D65AC File Offset: 0x000D47AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360158, XrefRangeEnd = 360162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNotMouseEvent(int pointerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_IsNotMouseEvent_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x000D65EC File Offset: 0x000D47EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 360177, RefRangeEnd = 360180, XrefRangeStart = 360162, XrefRangeEnd = 360177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCancelEvent(EventBase evt, int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_ProcessCancelEvent_Protected_Void_EventBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x000D663C File Offset: 0x000D483C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360180, XrefRangeEnd = 360186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnKeyDown(KeyDownEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x000D6680 File Offset: 0x000D4880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360204, RefRangeEnd = 360205, XrefRangeStart = 360186, XrefRangeEnd = 360204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_ProcessDownEvent_Private_Void_EventBase_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x000D66E0 File Offset: 0x000D48E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360213, RefRangeEnd = 360214, XrefRangeStart = 360205, XrefRangeEnd = 360213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMoveEvent(EventBase e, Vector2 localPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_ProcessMoveEvent_Private_Void_EventBase_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x000D6730 File Offset: 0x000D4930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360224, RefRangeEnd = 360225, XrefRangeStart = 360214, XrefRangeEnd = 360224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_ProcessUpEvent_Private_Void_EventBase_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x000D6790 File Offset: 0x000D4990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360289, RefRangeEnd = 360290, XrefRangeStart = 360225, XrefRangeEnd = 360289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginDragMove(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_BeginDragMove_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x000D67D0 File Offset: 0x000D49D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360290, XrefRangeEnd = 360291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DragMove(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_DragMove_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x000D6810 File Offset: 0x000D4A10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360309, RefRangeEnd = 360310, XrefRangeStart = 360291, XrefRangeEnd = 360309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePreviewPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_UpdatePreviewPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x000D6844 File Offset: 0x000D4A44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 360330, RefRangeEnd = 360333, XrefRangeStart = 360310, XrefRangeEnd = 360330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMoveLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_UpdateMoveLocation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x000D6878 File Offset: 0x000D4A78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360343, RefRangeEnd = 360344, XrefRangeStart = 360333, XrefRangeEnd = 360343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDragMove(bool cancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cancelled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnMover.NativeMethodInfoPtr_EndDragMove_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x000146A4 File Offset: 0x000128A4
		public ColumnMover(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x060032A4 RID: 12964 RVA: 0x000D68B8 File Offset: 0x000D4AB8
		// (set) Token: 0x060032A5 RID: 12965 RVA: 0x000146AD File Offset: 0x000128AD
		public unsafe float m_StartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_StartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_StartPos)) = value;
			}
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x060032A6 RID: 12966 RVA: 0x000D68E0 File Offset: 0x000D4AE0
		// (set) Token: 0x060032A7 RID: 12967 RVA: 0x000146C8 File Offset: 0x000128C8
		public unsafe float m_LastPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_LastPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_LastPos)) = value;
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x060032A8 RID: 12968 RVA: 0x000D6908 File Offset: 0x000D4B08
		// (set) Token: 0x060032A9 RID: 12969 RVA: 0x000146E3 File Offset: 0x000128E3
		public unsafe bool m_Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_Active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_Active)) = value;
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x000D6930 File Offset: 0x000D4B30
		// (set) Token: 0x060032AB RID: 12971 RVA: 0x000146FE File Offset: 0x000128FE
		public unsafe bool m_Moving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_Moving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_Moving)) = value;
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x000D6958 File Offset: 0x000D4B58
		// (set) Token: 0x060032AD RID: 12973 RVA: 0x00014719 File Offset: 0x00012919
		public unsafe bool m_Cancelled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_Cancelled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_Cancelled)) = value;
			}
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x060032AE RID: 12974 RVA: 0x000D6980 File Offset: 0x000D4B80
		// (set) Token: 0x060032AF RID: 12975 RVA: 0x00014734 File Offset: 0x00012934
		public unsafe MultiColumnCollectionHeader m_Header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_Header);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiColumnCollectionHeader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_Header), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x060032B0 RID: 12976 RVA: 0x000D69B0 File Offset: 0x000D4BB0
		// (set) Token: 0x060032B1 RID: 12977 RVA: 0x00014753 File Offset: 0x00012953
		public unsafe VisualElement m_PreviewElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_PreviewElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_PreviewElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x000D69E0 File Offset: 0x000D4BE0
		// (set) Token: 0x060032B3 RID: 12979 RVA: 0x00014772 File Offset: 0x00012972
		public unsafe MultiColumnHeaderColumnMoveLocationPreview m_LocationPreviewElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_LocationPreviewElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiColumnHeaderColumnMoveLocationPreview>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_LocationPreviewElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x000D6A10 File Offset: 0x000D4C10
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x00014791 File Offset: 0x00012991
		public unsafe Column m_ColumnToMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_ColumnToMove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Column>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_ColumnToMove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x000D6A40 File Offset: 0x000D4C40
		// (set) Token: 0x060032B7 RID: 12983 RVA: 0x000147B0 File Offset: 0x000129B0
		public unsafe float m_ColumnToMovePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_ColumnToMovePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_ColumnToMovePos)) = value;
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x000D6A68 File Offset: 0x000D4C68
		// (set) Token: 0x060032B9 RID: 12985 RVA: 0x000147CB File Offset: 0x000129CB
		public unsafe float m_ColumnToMoveWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_ColumnToMoveWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_ColumnToMoveWidth)) = value;
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x000D6A90 File Offset: 0x000D4C90
		// (set) Token: 0x060032BB RID: 12987 RVA: 0x000147E6 File Offset: 0x000129E6
		public unsafe Column m_DestinationColumn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_DestinationColumn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Column>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_DestinationColumn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x000D6AC0 File Offset: 0x000D4CC0
		// (set) Token: 0x060032BD RID: 12989 RVA: 0x00014805 File Offset: 0x00012A05
		public unsafe bool m_MoveBeforeDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_MoveBeforeDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_m_MoveBeforeDestination)) = value;
			}
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x060032BE RID: 12990 RVA: 0x000D6AE8 File Offset: 0x000D4CE8
		// (set) Token: 0x060032BF RID: 12991 RVA: 0x00014820 File Offset: 0x00012A20
		public unsafe ColumnLayout _columnLayout_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr__columnLayout_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColumnLayout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr__columnLayout_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x060032C0 RID: 12992 RVA: 0x000D6B18 File Offset: 0x000D4D18
		// (set) Token: 0x060032C1 RID: 12993 RVA: 0x0001483F File Offset: 0x00012A3F
		public unsafe Action<ColumnMover> activeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_activeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ColumnMover>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_activeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x000D6B48 File Offset: 0x000D4D48
		// (set) Token: 0x060032C3 RID: 12995 RVA: 0x0001485E File Offset: 0x00012A5E
		public unsafe Action<ColumnMover> movingChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_movingChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ColumnMover>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnMover.NativeFieldInfoPtr_movingChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400250A RID: 9482
		private static readonly IntPtr NativeFieldInfoPtr_m_StartPos;

		// Token: 0x0400250B RID: 9483
		private static readonly IntPtr NativeFieldInfoPtr_m_LastPos;

		// Token: 0x0400250C RID: 9484
		private static readonly IntPtr NativeFieldInfoPtr_m_Active;

		// Token: 0x0400250D RID: 9485
		private static readonly IntPtr NativeFieldInfoPtr_m_Moving;

		// Token: 0x0400250E RID: 9486
		private static readonly IntPtr NativeFieldInfoPtr_m_Cancelled;

		// Token: 0x0400250F RID: 9487
		private static readonly IntPtr NativeFieldInfoPtr_m_Header;

		// Token: 0x04002510 RID: 9488
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviewElement;

		// Token: 0x04002511 RID: 9489
		private static readonly IntPtr NativeFieldInfoPtr_m_LocationPreviewElement;

		// Token: 0x04002512 RID: 9490
		private static readonly IntPtr NativeFieldInfoPtr_m_ColumnToMove;

		// Token: 0x04002513 RID: 9491
		private static readonly IntPtr NativeFieldInfoPtr_m_ColumnToMovePos;

		// Token: 0x04002514 RID: 9492
		private static readonly IntPtr NativeFieldInfoPtr_m_ColumnToMoveWidth;

		// Token: 0x04002515 RID: 9493
		private static readonly IntPtr NativeFieldInfoPtr_m_DestinationColumn;

		// Token: 0x04002516 RID: 9494
		private static readonly IntPtr NativeFieldInfoPtr_m_MoveBeforeDestination;

		// Token: 0x04002517 RID: 9495
		private static readonly IntPtr NativeFieldInfoPtr__columnLayout_k__BackingField;

		// Token: 0x04002518 RID: 9496
		private static readonly IntPtr NativeFieldInfoPtr_activeChanged;

		// Token: 0x04002519 RID: 9497
		private static readonly IntPtr NativeFieldInfoPtr_movingChanged;

		// Token: 0x0400251A RID: 9498
		private static readonly IntPtr NativeMethodInfoPtr_get_columnLayout_Public_get_ColumnLayout_0;

		// Token: 0x0400251B RID: 9499
		private static readonly IntPtr NativeMethodInfoPtr_set_columnLayout_Public_set_Void_ColumnLayout_0;

		// Token: 0x0400251C RID: 9500
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x0400251D RID: 9501
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0;

		// Token: 0x0400251E RID: 9502
		private static readonly IntPtr NativeMethodInfoPtr_get_moving_Public_get_Boolean_0;

		// Token: 0x0400251F RID: 9503
		private static readonly IntPtr NativeMethodInfoPtr_set_moving_Public_set_Void_Boolean_0;

		// Token: 0x04002520 RID: 9504
		private static readonly IntPtr NativeMethodInfoPtr_add_activeChanged_Public_add_Void_Action_1_ColumnMover_0;

		// Token: 0x04002521 RID: 9505
		private static readonly IntPtr NativeMethodInfoPtr_remove_activeChanged_Public_rem_Void_Action_1_ColumnMover_0;

		// Token: 0x04002522 RID: 9506
		private static readonly IntPtr NativeMethodInfoPtr_add_movingChanged_Public_add_Void_Action_1_ColumnMover_0;

		// Token: 0x04002523 RID: 9507
		private static readonly IntPtr NativeMethodInfoPtr_remove_movingChanged_Public_rem_Void_Action_1_ColumnMover_0;

		// Token: 0x04002524 RID: 9508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002525 RID: 9509
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0;

		// Token: 0x04002526 RID: 9510
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0;

		// Token: 0x04002527 RID: 9511
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseDown_Protected_Void_MouseDownEvent_0;

		// Token: 0x04002528 RID: 9512
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseMove_Protected_Void_MouseMoveEvent_0;

		// Token: 0x04002529 RID: 9513
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseUp_Protected_Void_MouseUpEvent_0;

		// Token: 0x0400252A RID: 9514
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseCaptureOut_Private_Void_MouseCaptureOutEvent_0;

		// Token: 0x0400252B RID: 9515
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0;

		// Token: 0x0400252C RID: 9516
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0;

		// Token: 0x0400252D RID: 9517
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0;

		// Token: 0x0400252E RID: 9518
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerCancel_Private_Void_PointerCancelEvent_0;

		// Token: 0x0400252F RID: 9519
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerCaptureOut_Private_Void_PointerCaptureOutEvent_0;

		// Token: 0x04002530 RID: 9520
		private static readonly IntPtr NativeMethodInfoPtr_IsNotMouseEvent_Private_Static_Boolean_Int32_0;

		// Token: 0x04002531 RID: 9521
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCancelEvent_Protected_Void_EventBase_Int32_0;

		// Token: 0x04002532 RID: 9522
		private static readonly IntPtr NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0;

		// Token: 0x04002533 RID: 9523
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDownEvent_Private_Void_EventBase_Vector2_Int32_0;

		// Token: 0x04002534 RID: 9524
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMoveEvent_Private_Void_EventBase_Vector2_0;

		// Token: 0x04002535 RID: 9525
		private static readonly IntPtr NativeMethodInfoPtr_ProcessUpEvent_Private_Void_EventBase_Vector2_Int32_0;

		// Token: 0x04002536 RID: 9526
		private static readonly IntPtr NativeMethodInfoPtr_BeginDragMove_Private_Void_Single_0;

		// Token: 0x04002537 RID: 9527
		private static readonly IntPtr NativeMethodInfoPtr_DragMove_Internal_Void_Single_0;

		// Token: 0x04002538 RID: 9528
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePreviewPosition_Private_Void_0;

		// Token: 0x04002539 RID: 9529
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMoveLocation_Private_Void_0;

		// Token: 0x0400253A RID: 9530
		private static readonly IntPtr NativeMethodInfoPtr_EndDragMove_Private_Void_Boolean_0;

		// Token: 0x0400253B RID: 9531
		public const float k_StartDragDistance = 5f;
	}
}
