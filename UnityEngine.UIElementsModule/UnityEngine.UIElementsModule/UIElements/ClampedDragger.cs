using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000024 RID: 36
	public class ClampedDragger<T> : Clickable
	{
		// Token: 0x0600022A RID: 554 RVA: 0x000240A8 File Offset: 0x000222A8
		// Note: this type is marked as 'beforefieldinit'.
		static ClampedDragger()
		{
			Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ClampedDragger`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr);
			ClampedDragger<T>.NativeFieldInfoPtr_dragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, "dragging");
			ClampedDragger<T>.NativeFieldInfoPtr_draggingEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, "draggingEnded");
			ClampedDragger<T>.NativeFieldInfoPtr__dragDirection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, "<dragDirection>k__BackingField");
			ClampedDragger<T>.NativeFieldInfoPtr__slider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, "<slider>k__BackingField");
			ClampedDragger<T>.NativeFieldInfoPtr__startMousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, "<startMousePosition>k__BackingField");
			ClampedDragger<T>.NativeMethodInfoPtr_add_dragging_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, 100663569);
			ClampedDragger<T>.NativeMethodInfoPtr_remove_dragging_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, 100663570);
			ClampedDragger<T>.NativeMethodInfoPtr_add_draggingEnded_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, 100663571);
			ClampedDragger<T>.NativeMethodInfoPtr_remove_draggingEnded_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, 100663572);
			ClampedDragger<T>.NativeMethodInfoPtr_get_dragDirection_Public_get_DragDirection_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, 100663573);
			ClampedDragger<T>.NativeMethodInfoPtr_set_dragDirection_Public_set_Void_DragDirection_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, 100663574);
			ClampedDragger<T>.NativeMethodInfoPtr_set_slider_Private_set_Void_BaseSlider_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, 100663575);
			ClampedDragger<T>.NativeMethodInfoPtr_get_startMousePosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, 100663576);
			ClampedDragger<T>.NativeMethodInfoPtr_set_startMousePosition_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, 100663577);
			ClampedDragger<T>.NativeMethodInfoPtr_get_delta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, 100663578);
			ClampedDragger<T>.NativeMethodInfoPtr__ctor_Public_Void_BaseSlider_1_T_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, 100663579);
			ClampedDragger<T>.NativeMethodInfoPtr_ProcessDownEvent_Protected_Virtual_Void_EventBase_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, 100663580);
			ClampedDragger<T>.NativeMethodInfoPtr_ProcessUpEvent_Protected_Virtual_Void_EventBase_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, 100663581);
			ClampedDragger<T>.NativeMethodInfoPtr_ProcessMoveEvent_Protected_Virtual_Void_EventBase_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr, 100663582);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00024290 File Offset: 0x00022490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284326, XrefRangeEnd = 284330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_dragging(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClampedDragger<T>.NativeMethodInfoPtr_add_dragging_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000242D4 File Offset: 0x000224D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284330, XrefRangeEnd = 284334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_dragging(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClampedDragger<T>.NativeMethodInfoPtr_remove_dragging_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00024318 File Offset: 0x00022518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284334, XrefRangeEnd = 284338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_draggingEnded(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClampedDragger<T>.NativeMethodInfoPtr_add_draggingEnded_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0002435C File Offset: 0x0002255C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284338, XrefRangeEnd = 284342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_draggingEnded(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClampedDragger<T>.NativeMethodInfoPtr_remove_draggingEnded_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600022F RID: 559 RVA: 0x000243A0 File Offset: 0x000225A0
		// (set) Token: 0x06000230 RID: 560 RVA: 0x000243DC File Offset: 0x000225DC
		public unsafe ClampedDragger<T>.DragDirection dragDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClampedDragger<T>.NativeMethodInfoPtr_get_dragDirection_Public_get_DragDirection_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClampedDragger<T>.NativeMethodInfoPtr_set_dragDirection_Public_set_Void_DragDirection_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00002A9A File Offset: 0x00000C9A
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0002441C File Offset: 0x0002261C
		public unsafe BaseSlider<T> slider
		{
			get
			{
				return this._slider_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClampedDragger<T>.NativeMethodInfoPtr_set_slider_Private_set_Void_BaseSlider_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00024460 File Offset: 0x00022660
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0002449C File Offset: 0x0002269C
		public unsafe Vector2 startMousePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClampedDragger<T>.NativeMethodInfoPtr_get_startMousePosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClampedDragger<T>.NativeMethodInfoPtr_set_startMousePosition_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000234 RID: 564 RVA: 0x000244DC File Offset: 0x000226DC
		public unsafe Vector2 delta
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 284342, RefRangeEnd = 284344, XrefRangeStart = 284342, XrefRangeEnd = 284342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClampedDragger<T>.NativeMethodInfoPtr_get_delta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00024518 File Offset: 0x00022718
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284350, RefRangeEnd = 284351, XrefRangeStart = 284344, XrefRangeEnd = 284350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClampedDragger(BaseSlider<T> slider, Action clickHandler, Action dragHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClampedDragger<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clickHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClampedDragger<T>.NativeMethodInfoPtr__ctor_Public_Void_BaseSlider_1_T_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00024588 File Offset: 0x00022788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284351, XrefRangeEnd = 284352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClampedDragger<T>.NativeMethodInfoPtr_ProcessDownEvent_Protected_Virtual_Void_EventBase_Vector2_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000245F4 File Offset: 0x000227F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284352, XrefRangeEnd = 284353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClampedDragger<T>.NativeMethodInfoPtr_ProcessUpEvent_Protected_Virtual_Void_EventBase_Vector2_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00024660 File Offset: 0x00022860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284353, XrefRangeEnd = 284367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessMoveEvent(EventBase evt, Vector2 localPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClampedDragger<T>.NativeMethodInfoPtr_ProcessMoveEvent_Protected_Virtual_Void_EventBase_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000029EB File Offset: 0x00000BEB
		public ClampedDragger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600023A RID: 570 RVA: 0x000246BC File Offset: 0x000228BC
		// (set) Token: 0x0600023B RID: 571 RVA: 0x000029F4 File Offset: 0x00000BF4
		public unsafe Action dragging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedDragger<T>.NativeFieldInfoPtr_dragging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedDragger<T>.NativeFieldInfoPtr_dragging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600023C RID: 572 RVA: 0x000246EC File Offset: 0x000228EC
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00002A13 File Offset: 0x00000C13
		public unsafe Action draggingEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedDragger<T>.NativeFieldInfoPtr_draggingEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedDragger<T>.NativeFieldInfoPtr_draggingEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0002471C File Offset: 0x0002291C
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00002A32 File Offset: 0x00000C32
		public unsafe ClampedDragger<T>.DragDirection _dragDirection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedDragger<T>.NativeFieldInfoPtr__dragDirection_k__BackingField);
				return *intPtr;
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedDragger<T>.NativeFieldInfoPtr__dragDirection_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClampedDragger<T>.DragDirection>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00024744 File Offset: 0x00022944
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00002A60 File Offset: 0x00000C60
		public unsafe BaseSlider<T> _slider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedDragger<T>.NativeFieldInfoPtr__slider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseSlider<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedDragger<T>.NativeFieldInfoPtr__slider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00024774 File Offset: 0x00022974
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00002A7F File Offset: 0x00000C7F
		public unsafe Vector2 _startMousePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedDragger<T>.NativeFieldInfoPtr__startMousePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedDragger<T>.NativeFieldInfoPtr__startMousePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr_dragging;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_draggingEnded;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr__dragDirection_k__BackingField;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr__slider_k__BackingField;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr__startMousePosition_k__BackingField;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_add_dragging_Public_add_Void_Action_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_remove_dragging_Public_rem_Void_Action_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_add_draggingEnded_Public_add_Void_Action_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_remove_draggingEnded_Public_rem_Void_Action_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_get_dragDirection_Public_get_DragDirection_T_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_set_dragDirection_Public_set_Void_DragDirection_T_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_set_slider_Private_set_Void_BaseSlider_1_T_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_get_startMousePosition_Public_get_Vector2_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_set_startMousePosition_Private_set_Void_Vector2_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_get_delta_Public_get_Vector2_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseSlider_1_T_Action_Action_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDownEvent_Protected_Virtual_Void_EventBase_Vector2_Int32_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_ProcessUpEvent_Protected_Virtual_Void_EventBase_Vector2_Int32_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMoveEvent_Protected_Virtual_Void_EventBase_Vector2_0;

		// Token: 0x02000325 RID: 805
		[Flags]
		public enum DragDirection
		{
			// Token: 0x04002637 RID: 9783
			None = 0,
			// Token: 0x04002638 RID: 9784
			LowToHigh = 1,
			// Token: 0x04002639 RID: 9785
			HighToLow = 2,
			// Token: 0x0400263A RID: 9786
			Free = 4
		}
	}
}
