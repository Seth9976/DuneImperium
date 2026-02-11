using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200012C RID: 300
	public class FieldMouseDragger<T> : BaseFieldMouseDragger
	{
		// Token: 0x0600162A RID: 5674 RVA: 0x0006B5A0 File Offset: 0x000697A0
		// Note: this type is marked as 'beforefieldinit'.
		static FieldMouseDragger()
		{
			Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FieldMouseDragger`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr);
			FieldMouseDragger<T>.NativeFieldInfoPtr_m_DrivenField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, "m_DrivenField");
			FieldMouseDragger<T>.NativeFieldInfoPtr_m_DragElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, "m_DragElement");
			FieldMouseDragger<T>.NativeFieldInfoPtr_m_DragHotZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, "m_DragHotZone");
			FieldMouseDragger<T>.NativeFieldInfoPtr__dragging_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, "<dragging>k__BackingField");
			FieldMouseDragger<T>.NativeFieldInfoPtr__startValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, "<startValue>k__BackingField");
			FieldMouseDragger<T>.NativeMethodInfoPtr__ctor_Public_Void_IValueField_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, 100666612);
			FieldMouseDragger<T>.NativeMethodInfoPtr_get_dragging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, 100666613);
			FieldMouseDragger<T>.NativeMethodInfoPtr_set_dragging_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, 100666614);
			FieldMouseDragger<T>.NativeMethodInfoPtr_get_startValue_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, 100666615);
			FieldMouseDragger<T>.NativeMethodInfoPtr_set_startValue_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, 100666616);
			FieldMouseDragger<T>.NativeMethodInfoPtr_SetDragZone_Public_Virtual_Final_Void_VisualElement_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, 100666617);
			FieldMouseDragger<T>.NativeMethodInfoPtr_CanStartDrag_Private_Boolean_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, 100666618);
			FieldMouseDragger<T>.NativeMethodInfoPtr_UpdateValueOnPointerDown_Private_Void_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, 100666619);
			FieldMouseDragger<T>.NativeMethodInfoPtr_ProcessDownEvent_Private_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, 100666620);
			FieldMouseDragger<T>.NativeMethodInfoPtr_UpdateValueOnPointerMove_Private_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, 100666621);
			FieldMouseDragger<T>.NativeMethodInfoPtr_ProcessMoveEvent_Private_Void_Boolean_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, 100666622);
			FieldMouseDragger<T>.NativeMethodInfoPtr_UpdateValueOnPointerUp_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, 100666623);
			FieldMouseDragger<T>.NativeMethodInfoPtr_ProcessUpEvent_Private_Void_EventBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, 100666624);
			FieldMouseDragger<T>.NativeMethodInfoPtr_UpdateValueOnKeyDown_Private_Void_KeyDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr, 100666625);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0006B788 File Offset: 0x00069988
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 317374, RefRangeEnd = 317381, XrefRangeStart = 317371, XrefRangeEnd = 317374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldMouseDragger(IValueField<T> drivenField)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldMouseDragger<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drivenField);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMouseDragger<T>.NativeMethodInfoPtr__ctor_Public_Void_IValueField_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x0006B7D4 File Offset: 0x000699D4
		// (set) Token: 0x0600162D RID: 5677 RVA: 0x0006B810 File Offset: 0x00069A10
		public unsafe bool dragging
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMouseDragger<T>.NativeMethodInfoPtr_get_dragging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMouseDragger<T>.NativeMethodInfoPtr_set_dragging_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x0006B850 File Offset: 0x00069A50
		// (set) Token: 0x0600162F RID: 5679 RVA: 0x0006B88C File Offset: 0x00069A8C
		public unsafe T startValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMouseDragger<T>.NativeMethodInfoPtr_get_startValue_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FieldMouseDragger<T>.NativeMethodInfoPtr_set_startValue_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x0006B904 File Offset: 0x00069B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317381, XrefRangeEnd = 317421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetDragZone(VisualElement dragElement, Rect hotZone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hotZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMouseDragger<T>.NativeMethodInfoPtr_SetDragZone_Public_Virtual_Final_Void_VisualElement_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x0006B954 File Offset: 0x00069B54
		[CallerCount(0)]
		public unsafe bool CanStartDrag(int button, Vector2 localPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMouseDragger<T>.NativeMethodInfoPtr_CanStartDrag_Private_Boolean_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x0006B9AC File Offset: 0x00069BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317421, XrefRangeEnd = 317442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValueOnPointerDown(PointerDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMouseDragger<T>.NativeMethodInfoPtr_UpdateValueOnPointerDown_Private_Void_PointerDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x0006B9F0 File Offset: 0x00069BF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317460, RefRangeEnd = 317461, XrefRangeStart = 317442, XrefRangeEnd = 317460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessDownEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMouseDragger<T>.NativeMethodInfoPtr_ProcessDownEvent_Private_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x0006BA34 File Offset: 0x00069C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317461, XrefRangeEnd = 317471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValueOnPointerMove(PointerMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMouseDragger<T>.NativeMethodInfoPtr_UpdateValueOnPointerMove_Private_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x0006BA78 File Offset: 0x00069C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317471, XrefRangeEnd = 317474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMoveEvent(bool shiftKey, bool altKey, Vector2 deltaPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shiftKey;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref altKey;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMouseDragger<T>.NativeMethodInfoPtr_ProcessMoveEvent_Private_Void_Boolean_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0006BAD4 File Offset: 0x00069CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317474, XrefRangeEnd = 317487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValueOnPointerUp(PointerUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMouseDragger<T>.NativeMethodInfoPtr_UpdateValueOnPointerUp_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0006BB18 File Offset: 0x00069D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317511, RefRangeEnd = 317512, XrefRangeStart = 317487, XrefRangeEnd = 317511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessUpEvent(EventBase evt, int pointerId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMouseDragger<T>.NativeMethodInfoPtr_ProcessUpEvent_Private_Void_EventBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x0006BB68 File Offset: 0x00069D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317512, XrefRangeEnd = 317533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValueOnKeyDown(KeyDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMouseDragger<T>.NativeMethodInfoPtr_UpdateValueOnKeyDown_Private_Void_KeyDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0000A521 File Offset: 0x00008721
		public FieldMouseDragger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x0006BBAC File Offset: 0x00069DAC
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x0000A52A File Offset: 0x0000872A
		public unsafe IValueField<T> m_DrivenField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMouseDragger<T>.NativeFieldInfoPtr_m_DrivenField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IValueField<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMouseDragger<T>.NativeFieldInfoPtr_m_DrivenField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x0006BBDC File Offset: 0x00069DDC
		// (set) Token: 0x0600163D RID: 5693 RVA: 0x0000A549 File Offset: 0x00008749
		public unsafe VisualElement m_DragElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMouseDragger<T>.NativeFieldInfoPtr_m_DragElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMouseDragger<T>.NativeFieldInfoPtr_m_DragElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x0006BC0C File Offset: 0x00069E0C
		// (set) Token: 0x0600163F RID: 5695 RVA: 0x0000A568 File Offset: 0x00008768
		public unsafe Rect m_DragHotZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMouseDragger<T>.NativeFieldInfoPtr_m_DragHotZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMouseDragger<T>.NativeFieldInfoPtr_m_DragHotZone)) = value;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x0006BC34 File Offset: 0x00069E34
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x0000A583 File Offset: 0x00008783
		public unsafe bool _dragging_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMouseDragger<T>.NativeFieldInfoPtr__dragging_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMouseDragger<T>.NativeFieldInfoPtr__dragging_k__BackingField)) = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x0006BC5C File Offset: 0x00069E5C
		// (set) Token: 0x06001643 RID: 5699 RVA: 0x0006BC84 File Offset: 0x00069E84
		public unsafe T _startValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMouseDragger<T>.NativeFieldInfoPtr__startValue_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMouseDragger<T>.NativeFieldInfoPtr__startValue_k__BackingField);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeFieldInfoPtr_m_DrivenField;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeFieldInfoPtr_m_DragElement;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeFieldInfoPtr_m_DragHotZone;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeFieldInfoPtr__dragging_k__BackingField;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeFieldInfoPtr__startValue_k__BackingField;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IValueField_1_T_0;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeMethodInfoPtr_get_dragging_Public_get_Boolean_0;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeMethodInfoPtr_set_dragging_Public_set_Void_Boolean_0;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeMethodInfoPtr_get_startValue_Public_get_T_0;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeMethodInfoPtr_set_startValue_Public_set_Void_T_0;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeMethodInfoPtr_SetDragZone_Public_Virtual_Final_Void_VisualElement_Rect_0;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeMethodInfoPtr_CanStartDrag_Private_Boolean_Int32_Vector2_0;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueOnPointerDown_Private_Void_PointerDownEvent_0;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDownEvent_Private_Void_EventBase_0;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueOnPointerMove_Private_Void_PointerMoveEvent_0;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMoveEvent_Private_Void_Boolean_Boolean_Vector2_0;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueOnPointerUp_Private_Void_PointerUpEvent_0;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeMethodInfoPtr_ProcessUpEvent_Private_Void_EventBase_Int32_0;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueOnKeyDown_Private_Void_KeyDownEvent_0;
	}
}
