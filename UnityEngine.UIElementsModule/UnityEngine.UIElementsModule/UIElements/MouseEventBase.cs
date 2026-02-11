using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F5 RID: 245
	public class MouseEventBase<T> : EventBase<T> where T : MouseEventBase<T>, new()
	{
		// Token: 0x060013DF RID: 5087 RVA: 0x00063100 File Offset: 0x00061300
		// Note: this type is marked as 'beforefieldinit'.
		static MouseEventBase()
		{
			Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr);
			MouseEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<modifiers>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__mousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<mousePosition>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__localMousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<localMousePosition>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__mouseDelta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<mouseDelta>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__clickCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<clickCount>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__button_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<button>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__pressedButtons_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<pressedButtons>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_triggeredByOS_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_recomputeTopElementUnderMouse_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_sourcePointerEvent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField");
			MouseEventBase<T>.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666141);
			MouseEventBase<T>.NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666142);
			MouseEventBase<T>.NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666143);
			MouseEventBase<T>.NativeMethodInfoPtr_set_mousePosition_Protected_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666144);
			MouseEventBase<T>.NativeMethodInfoPtr_get_localMousePosition_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666145);
			MouseEventBase<T>.NativeMethodInfoPtr_set_localMousePosition_Internal_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666146);
			MouseEventBase<T>.NativeMethodInfoPtr_get_mouseDelta_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666147);
			MouseEventBase<T>.NativeMethodInfoPtr_set_mouseDelta_Protected_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666148);
			MouseEventBase<T>.NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666149);
			MouseEventBase<T>.NativeMethodInfoPtr_set_clickCount_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666150);
			MouseEventBase<T>.NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666151);
			MouseEventBase<T>.NativeMethodInfoPtr_set_button_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666152);
			MouseEventBase<T>.NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666153);
			MouseEventBase<T>.NativeMethodInfoPtr_set_pressedButtons_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666154);
			MouseEventBase<T>.NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666155);
			MouseEventBase<T>.NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666156);
			MouseEventBase<T>.NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666157);
			MouseEventBase<T>.NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666158);
			MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_triggeredByOS_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666159);
			MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_triggeredByOS_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666160);
			MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_recomputeTopElementUnderMouse_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666161);
			MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_recomputeTopElementUnderMouse_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666162);
			MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_sourcePointerEvent_Private_Virtual_Final_New_get_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666163);
			MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_sourcePointerEvent_Private_Virtual_Final_New_set_Void_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666164);
			MouseEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666165);
			MouseEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666166);
			MouseEventBase<T>.NativeMethodInfoPtr_get_currentTarget_Public_Virtual_get_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666167);
			MouseEventBase<T>.NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_set_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666168);
			MouseEventBase<T>.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666169);
			MouseEventBase<T>.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666170);
			MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666171);
			MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_IMouseEvent_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666172);
			MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IMouseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666173);
			MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Protected_Static_T_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666174);
			MouseEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100666175);
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x000634F0 File Offset: 0x000616F0
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x0006352C File Offset: 0x0006172C
		public unsafe virtual EventModifiers modifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0006356C File Offset: 0x0006176C
		// (set) Token: 0x060013E3 RID: 5091 RVA: 0x000635A8 File Offset: 0x000617A8
		public unsafe virtual Vector2 mousePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_set_mousePosition_Protected_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x000635E8 File Offset: 0x000617E8
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x00063624 File Offset: 0x00061824
		public unsafe virtual Vector2 localMousePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_localMousePosition_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_set_localMousePosition_Internal_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x00063664 File Offset: 0x00061864
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x000636A0 File Offset: 0x000618A0
		public unsafe virtual Vector2 mouseDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_mouseDelta_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_set_mouseDelta_Protected_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x000636E0 File Offset: 0x000618E0
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x0006371C File Offset: 0x0006191C
		public unsafe virtual int clickCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 314558, RefRangeEnd = 314559, XrefRangeStart = 314558, XrefRangeEnd = 314558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_set_clickCount_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x0006375C File Offset: 0x0006195C
		// (set) Token: 0x060013EB RID: 5099 RVA: 0x00063798 File Offset: 0x00061998
		public unsafe virtual int button
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_set_button_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x000637D8 File Offset: 0x000619D8
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x00063814 File Offset: 0x00061A14
		public unsafe virtual int pressedButtons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 314559, RefRangeEnd = 314560, XrefRangeStart = 314559, XrefRangeEnd = 314559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_set_pressedButtons_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x00063854 File Offset: 0x00061A54
		public unsafe virtual bool shiftKey
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 314188, RefRangeEnd = 314194, XrefRangeStart = 314188, XrefRangeEnd = 314194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x00063890 File Offset: 0x00061A90
		public unsafe virtual bool ctrlKey
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 314194, RefRangeEnd = 314196, XrefRangeStart = 314194, XrefRangeEnd = 314196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x000638CC File Offset: 0x00061ACC
		public unsafe virtual bool commandKey
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 314196, RefRangeEnd = 314198, XrefRangeStart = 314196, XrefRangeEnd = 314198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x00063908 File Offset: 0x00061B08
		public unsafe virtual bool altKey
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 314198, RefRangeEnd = 314202, XrefRangeStart = 314198, XrefRangeEnd = 314202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x00063944 File Offset: 0x00061B44
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x00063980 File Offset: 0x00061B80
		public unsafe virtual bool UnityEngine.UIElements.IMouseEventInternal.triggeredByOS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_triggeredByOS_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_triggeredByOS_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x000639C0 File Offset: 0x00061BC0
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x000639FC File Offset: 0x00061BFC
		public unsafe virtual bool UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_recomputeTopElementUnderMouse_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_recomputeTopElementUnderMouse_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x00063A3C File Offset: 0x00061C3C
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x00063A7C File Offset: 0x00061C7C
		public unsafe virtual IPointerEvent UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_sourcePointerEvent_Private_Virtual_Final_New_get_IPointerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPointerEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_sourcePointerEvent_Private_Virtual_Final_New_set_Void_IPointerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00063AC0 File Offset: 0x00061CC0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 314563, RefRangeEnd = 314572, XrefRangeStart = 314560, XrefRangeEnd = 314563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00063AFC File Offset: 0x00061CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314572, XrefRangeEnd = 314586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x00063B30 File Offset: 0x00061D30
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x00063B7C File Offset: 0x00061D7C
		public unsafe override IEventHandler currentTarget
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314586, XrefRangeEnd = 314588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEventBase<T>.NativeMethodInfoPtr_get_currentTarget_Public_Virtual_get_IEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314588, XrefRangeEnd = 314593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEventBase<T>.NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_set_Void_IEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00063BCC File Offset: 0x00061DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314593, XrefRangeEnd = 314608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PreDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEventBase<T>.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00063C1C File Offset: 0x00061E1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314634, RefRangeEnd = 314637, XrefRangeStart = 314608, XrefRangeEnd = 314634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEventBase<T>.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00063C6C File Offset: 0x00061E6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314669, RefRangeEnd = 314672, XrefRangeStart = 314637, XrefRangeEnd = 314669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00063CAC File Offset: 0x00061EAC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 314682, RefRangeEnd = 314687, XrefRangeStart = 314672, XrefRangeEnd = 314682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, bool recomputeTopElementUnderMouse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mousePosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recomputeTopElementUnderMouse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_IMouseEvent_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00063D08 File Offset: 0x00061F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314687, XrefRangeEnd = 314728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IMouseEvent triggerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IMouseEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00063D48 File Offset: 0x00061F48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 314781, RefRangeEnd = 314785, XrefRangeStart = 314728, XrefRangeEnd = 314781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IPointerEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Protected_Static_T_IPointerEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00063D88 File Offset: 0x00061F88
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 314789, RefRangeEnd = 314812, XrefRangeStart = 314785, XrefRangeEnd = 314789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00009943 File Offset: 0x00007B43
		public MouseEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x00063DC4 File Offset: 0x00061FC4
		// (set) Token: 0x06001405 RID: 5125 RVA: 0x0000994C File Offset: 0x00007B4C
		public unsafe EventModifiers _modifiers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField)) = value;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x00063DEC File Offset: 0x00061FEC
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x00009967 File Offset: 0x00007B67
		public unsafe Vector2 _mousePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__mousePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__mousePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x00063E14 File Offset: 0x00062014
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x00009982 File Offset: 0x00007B82
		public unsafe Vector2 _localMousePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__localMousePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__localMousePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x00063E3C File Offset: 0x0006203C
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x0000999D File Offset: 0x00007B9D
		public unsafe Vector2 _mouseDelta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__mouseDelta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__mouseDelta_k__BackingField)) = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x00063E64 File Offset: 0x00062064
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x000099B8 File Offset: 0x00007BB8
		public unsafe int _clickCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__clickCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__clickCount_k__BackingField)) = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x00063E8C File Offset: 0x0006208C
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x000099D3 File Offset: 0x00007BD3
		public unsafe int _button_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__button_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__button_k__BackingField)) = value;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x00063EB4 File Offset: 0x000620B4
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x000099EE File Offset: 0x00007BEE
		public unsafe int _pressedButtons_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__pressedButtons_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__pressedButtons_k__BackingField)) = value;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x00063EDC File Offset: 0x000620DC
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x00009A09 File Offset: 0x00007C09
		public unsafe bool _UnityEngine_UIElements_IMouseEventInternal_triggeredByOS_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_triggeredByOS_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_triggeredByOS_k__BackingField)) = value;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x00063F04 File Offset: 0x00062104
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x00009A24 File Offset: 0x00007C24
		public unsafe bool _UnityEngine_UIElements_IMouseEventInternal_recomputeTopElementUnderMouse_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_recomputeTopElementUnderMouse_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_recomputeTopElementUnderMouse_k__BackingField)) = value;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x00063F2C File Offset: 0x0006212C
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x00009A3F File Offset: 0x00007C3F
		public unsafe IPointerEvent _UnityEngine_UIElements_IMouseEventInternal_sourcePointerEvent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_sourcePointerEvent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPointerEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_sourcePointerEvent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x00063F5C File Offset: 0x0006215C
		public bool actionKey
		{
			get
			{
				bool flag = Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer;
				bool flag2;
				if (flag)
				{
					flag2 = this.commandKey;
				}
				else
				{
					flag2 = this.ctrlKey;
				}
				return flag2;
			}
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x00063F98 File Offset: 0x00062198
		public static T GetPooled(Vector2 position, int button, int clickCount, Vector2 delta, [Optional] EventModifiers modifiers)
		{
			return MouseEventBase<T>.GetPooled(position, button, clickCount, delta, modifiers, false);
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00063FB8 File Offset: 0x000621B8
		public static T GetPooled(Vector2 position, int button, int clickCount, Vector2 delta, EventModifiers modifiers, bool fromOS)
		{
			T pooled = EventBase<T>.GetPooled();
			pooled.modifiers = modifiers;
			pooled.mousePosition = position;
			pooled.localMousePosition = position;
			pooled.mouseDelta = delta;
			pooled.button = button;
			pooled.pressedButtons = PointerDeviceState.GetPressedButtons(PointerId.mousePointerId);
			pooled.clickCount = clickCount;
			pooled.triggeredByOS = fromOS;
			pooled.recomputeTopElementUnderMouse = true;
			return pooled;
		}

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeFieldInfoPtr__modifiers_k__BackingField;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeFieldInfoPtr__mousePosition_k__BackingField;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeFieldInfoPtr__localMousePosition_k__BackingField;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeFieldInfoPtr__mouseDelta_k__BackingField;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeFieldInfoPtr__clickCount_k__BackingField;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeFieldInfoPtr__button_k__BackingField;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeFieldInfoPtr__pressedButtons_k__BackingField;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_triggeredByOS_k__BackingField;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_recomputeTopElementUnderMouse_k__BackingField;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_sourcePointerEvent_k__BackingField;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_set_mousePosition_Protected_set_Void_Vector2_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_get_localMousePosition_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_set_localMousePosition_Internal_set_Void_Vector2_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseDelta_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_set_mouseDelta_Protected_set_Void_Vector2_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_set_clickCount_Protected_set_Void_Int32_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_set_button_Protected_set_Void_Int32_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr_set_pressedButtons_Protected_set_Void_Int32_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_triggeredByOS_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_triggeredByOS_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_recomputeTopElementUnderMouse_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_recomputeTopElementUnderMouse_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_sourcePointerEvent_Private_Virtual_Final_New_get_IPointerEvent_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_sourcePointerEvent_Private_Virtual_Final_New_set_Void_IPointerEvent_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_get_currentTarget_Public_Virtual_get_IEventHandler_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_set_Void_IEventHandler_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_T_IMouseEvent_Vector2_Boolean_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_IMouseEvent_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Protected_Static_T_IPointerEvent_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
