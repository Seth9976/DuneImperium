using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000116 RID: 278
	public class PointerEventBase<T> : EventBase<T> where T : PointerEventBase<T>, new()
	{
		// Token: 0x06001529 RID: 5417 RVA: 0x00067ED0 File Offset: 0x000660D0
		// Note: this type is marked as 'beforefieldinit'.
		static PointerEventBase()
		{
			Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr);
			PointerEventBase<T>.NativeFieldInfoPtr_m_AltitudeNeedsConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "m_AltitudeNeedsConversion");
			PointerEventBase<T>.NativeFieldInfoPtr_m_AzimuthNeedsConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "m_AzimuthNeedsConversion");
			PointerEventBase<T>.NativeFieldInfoPtr_m_AltitudeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "m_AltitudeAngle");
			PointerEventBase<T>.NativeFieldInfoPtr_m_AzimuthAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "m_AzimuthAngle");
			PointerEventBase<T>.NativeFieldInfoPtr_m_TiltNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "m_TiltNeeded");
			PointerEventBase<T>.NativeFieldInfoPtr_m_Tilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "m_Tilt");
			PointerEventBase<T>.NativeFieldInfoPtr__pointerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<pointerId>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__pointerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<pointerType>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__isPrimary_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<isPrimary>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__button_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<button>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__pressedButtons_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<pressedButtons>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<position>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__localPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<localPosition>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__deltaPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<deltaPosition>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__deltaTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<deltaTime>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__clickCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<clickCount>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__pressure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<pressure>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__tangentialPressure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<tangentialPressure>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__twist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<twist>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__penStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<penStatus>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__radius_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<radius>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__radiusVariance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<radiusVariance>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<modifiers>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<UnityEngine.UIElements.IPointerEventInternal.triggeredByOS>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer>k__BackingField");
			PointerEventBase<T>.NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666403);
			PointerEventBase<T>.NativeMethodInfoPtr_set_pointerId_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666404);
			PointerEventBase<T>.NativeMethodInfoPtr_get_pointerType_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666405);
			PointerEventBase<T>.NativeMethodInfoPtr_set_pointerType_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666406);
			PointerEventBase<T>.NativeMethodInfoPtr_get_isPrimary_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666407);
			PointerEventBase<T>.NativeMethodInfoPtr_set_isPrimary_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666408);
			PointerEventBase<T>.NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666409);
			PointerEventBase<T>.NativeMethodInfoPtr_set_button_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666410);
			PointerEventBase<T>.NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666411);
			PointerEventBase<T>.NativeMethodInfoPtr_set_pressedButtons_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666412);
			PointerEventBase<T>.NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666413);
			PointerEventBase<T>.NativeMethodInfoPtr_set_position_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666414);
			PointerEventBase<T>.NativeMethodInfoPtr_get_localPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666415);
			PointerEventBase<T>.NativeMethodInfoPtr_set_localPosition_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666416);
			PointerEventBase<T>.NativeMethodInfoPtr_get_deltaPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666417);
			PointerEventBase<T>.NativeMethodInfoPtr_set_deltaPosition_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666418);
			PointerEventBase<T>.NativeMethodInfoPtr_get_deltaTime_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666419);
			PointerEventBase<T>.NativeMethodInfoPtr_set_deltaTime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666420);
			PointerEventBase<T>.NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666421);
			PointerEventBase<T>.NativeMethodInfoPtr_set_clickCount_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666422);
			PointerEventBase<T>.NativeMethodInfoPtr_get_pressure_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666423);
			PointerEventBase<T>.NativeMethodInfoPtr_set_pressure_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666424);
			PointerEventBase<T>.NativeMethodInfoPtr_get_tangentialPressure_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666425);
			PointerEventBase<T>.NativeMethodInfoPtr_set_tangentialPressure_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666426);
			PointerEventBase<T>.NativeMethodInfoPtr_get_altitudeAngle_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666427);
			PointerEventBase<T>.NativeMethodInfoPtr_set_altitudeAngle_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666428);
			PointerEventBase<T>.NativeMethodInfoPtr_get_azimuthAngle_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666429);
			PointerEventBase<T>.NativeMethodInfoPtr_set_azimuthAngle_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666430);
			PointerEventBase<T>.NativeMethodInfoPtr_get_twist_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666431);
			PointerEventBase<T>.NativeMethodInfoPtr_set_twist_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666432);
			PointerEventBase<T>.NativeMethodInfoPtr_get_tilt_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666433);
			PointerEventBase<T>.NativeMethodInfoPtr_set_tilt_Protected_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666434);
			PointerEventBase<T>.NativeMethodInfoPtr_get_penStatus_Public_Virtual_Final_New_get_PenStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666435);
			PointerEventBase<T>.NativeMethodInfoPtr_set_penStatus_Protected_set_Void_PenStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666436);
			PointerEventBase<T>.NativeMethodInfoPtr_get_radius_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666437);
			PointerEventBase<T>.NativeMethodInfoPtr_set_radius_Protected_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666438);
			PointerEventBase<T>.NativeMethodInfoPtr_get_radiusVariance_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666439);
			PointerEventBase<T>.NativeMethodInfoPtr_set_radiusVariance_Protected_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666440);
			PointerEventBase<T>.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666441);
			PointerEventBase<T>.NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666442);
			PointerEventBase<T>.NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666443);
			PointerEventBase<T>.NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666444);
			PointerEventBase<T>.NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666445);
			PointerEventBase<T>.NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666446);
			PointerEventBase<T>.NativeMethodInfoPtr_get_actionKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666447);
			PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_get_triggeredByOS_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666448);
			PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_set_triggeredByOS_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666449);
			PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_get_recomputeTopElementUnderPointer_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666450);
			PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_set_recomputeTopElementUnderPointer_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666451);
			PointerEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666452);
			PointerEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666453);
			PointerEventBase<T>.NativeMethodInfoPtr_get_currentTarget_Public_Virtual_get_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666454);
			PointerEventBase<T>.NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_set_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666455);
			PointerEventBase<T>.NativeMethodInfoPtr_IsMouse_Private_Static_Boolean_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666456);
			PointerEventBase<T>.NativeMethodInfoPtr_IsTouch_Private_Static_Boolean_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666457);
			PointerEventBase<T>.NativeMethodInfoPtr_TiltToAzimuth_Private_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666458);
			PointerEventBase<T>.NativeMethodInfoPtr_AzimuthAndAlitutudeToTilt_Private_Static_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666459);
			PointerEventBase<T>.NativeMethodInfoPtr_TiltToAltitude_Private_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666460);
			PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666461);
			PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_EventType_Vector3_Vector2_Int32_Int32_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666462);
			PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Touch_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666463);
			PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_PenData_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666464);
			PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_IPointerEvent_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666465);
			PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666466);
			PointerEventBase<T>.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666467);
			PointerEventBase<T>.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666468);
			PointerEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100666469);
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x0006866C File Offset: 0x0006686C
		// (set) Token: 0x0600152B RID: 5419 RVA: 0x000686A8 File Offset: 0x000668A8
		public unsafe virtual int pointerId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315963, RefRangeEnd = 315964, XrefRangeStart = 315963, XrefRangeEnd = 315963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 315964, RefRangeEnd = 315969, XrefRangeStart = 315964, XrefRangeEnd = 315964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_pointerId_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x000686E8 File Offset: 0x000668E8
		// (set) Token: 0x0600152D RID: 5421 RVA: 0x00068720 File Offset: 0x00066920
		public unsafe virtual string pointerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_pointerType_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_pointerType_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x00068764 File Offset: 0x00066964
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x000687A0 File Offset: 0x000669A0
		public unsafe virtual bool isPrimary
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_isPrimary_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_isPrimary_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x000687E0 File Offset: 0x000669E0
		// (set) Token: 0x06001531 RID: 5425 RVA: 0x0006881C File Offset: 0x00066A1C
		public unsafe virtual int button
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 315969, RefRangeEnd = 315972, XrefRangeStart = 315969, XrefRangeEnd = 315969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_button_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x0006885C File Offset: 0x00066A5C
		// (set) Token: 0x06001533 RID: 5427 RVA: 0x00068898 File Offset: 0x00066A98
		public unsafe virtual int pressedButtons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_pressedButtons_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x000688D8 File Offset: 0x00066AD8
		// (set) Token: 0x06001535 RID: 5429 RVA: 0x00068914 File Offset: 0x00066B14
		public unsafe virtual Vector3 position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_position_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x00068954 File Offset: 0x00066B54
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x00068990 File Offset: 0x00066B90
		public unsafe virtual Vector3 localPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_localPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_localPosition_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x000689D0 File Offset: 0x00066BD0
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x00068A0C File Offset: 0x00066C0C
		public unsafe virtual Vector3 deltaPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_deltaPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_deltaPosition_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x00068A4C File Offset: 0x00066C4C
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x00068A88 File Offset: 0x00066C88
		public unsafe virtual float deltaTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_deltaTime_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_deltaTime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x00068AC8 File Offset: 0x00066CC8
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x00068B04 File Offset: 0x00066D04
		public unsafe virtual int clickCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_clickCount_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x00068B44 File Offset: 0x00066D44
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x00068B80 File Offset: 0x00066D80
		public unsafe virtual float pressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_pressure_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_pressure_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x00068BC0 File Offset: 0x00066DC0
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x00068BFC File Offset: 0x00066DFC
		public unsafe virtual float tangentialPressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_tangentialPressure_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_tangentialPressure_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00068C3C File Offset: 0x00066E3C
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x00068C78 File Offset: 0x00066E78
		public unsafe virtual float altitudeAngle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315972, XrefRangeEnd = 315976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_altitudeAngle_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_altitudeAngle_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x00068CB8 File Offset: 0x00066EB8
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x00068CF4 File Offset: 0x00066EF4
		public unsafe virtual float azimuthAngle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315976, XrefRangeEnd = 315983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_azimuthAngle_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_azimuthAngle_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x00068D34 File Offset: 0x00066F34
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x00068D70 File Offset: 0x00066F70
		public unsafe virtual float twist
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_twist_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_twist_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x00068DB0 File Offset: 0x00066FB0
		// (set) Token: 0x06001549 RID: 5449 RVA: 0x00068DEC File Offset: 0x00066FEC
		public unsafe virtual Vector2 tilt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315983, XrefRangeEnd = 316003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_tilt_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_tilt_Protected_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x00068E2C File Offset: 0x0006702C
		// (set) Token: 0x0600154B RID: 5451 RVA: 0x00068E68 File Offset: 0x00067068
		public unsafe virtual PenStatus penStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_penStatus_Public_Virtual_Final_New_get_PenStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_penStatus_Protected_set_Void_PenStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x00068EA8 File Offset: 0x000670A8
		// (set) Token: 0x0600154D RID: 5453 RVA: 0x00068EE4 File Offset: 0x000670E4
		public unsafe virtual Vector2 radius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_radius_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_radius_Protected_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x00068F24 File Offset: 0x00067124
		// (set) Token: 0x0600154F RID: 5455 RVA: 0x00068F60 File Offset: 0x00067160
		public unsafe virtual Vector2 radiusVariance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_radiusVariance_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_radiusVariance_Protected_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x00068FA0 File Offset: 0x000671A0
		// (set) Token: 0x06001551 RID: 5457 RVA: 0x00068FDC File Offset: 0x000671DC
		public unsafe virtual EventModifiers modifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x0006901C File Offset: 0x0006721C
		public unsafe virtual bool shiftKey
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 316003, RefRangeEnd = 316006, XrefRangeStart = 316003, XrefRangeEnd = 316003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x00069058 File Offset: 0x00067258
		public unsafe virtual bool ctrlKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x00069094 File Offset: 0x00067294
		public unsafe virtual bool commandKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x000690D0 File Offset: 0x000672D0
		public unsafe virtual bool altKey
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 316006, RefRangeEnd = 316007, XrefRangeStart = 316006, XrefRangeEnd = 316006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x0006910C File Offset: 0x0006730C
		public unsafe virtual bool actionKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316007, XrefRangeEnd = 316011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_actionKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x00069148 File Offset: 0x00067348
		// (set) Token: 0x06001558 RID: 5464 RVA: 0x00069184 File Offset: 0x00067384
		public unsafe virtual bool UnityEngine.UIElements.IPointerEventInternal.triggeredByOS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_get_triggeredByOS_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_set_triggeredByOS_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x000691C4 File Offset: 0x000673C4
		// (set) Token: 0x0600155A RID: 5466 RVA: 0x00069200 File Offset: 0x00067400
		public unsafe virtual bool UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_get_recomputeTopElementUnderPointer_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_set_recomputeTopElementUnderPointer_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00069240 File Offset: 0x00067440
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 316014, RefRangeEnd = 316027, XrefRangeStart = 316011, XrefRangeEnd = 316014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0006927C File Offset: 0x0006747C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316049, RefRangeEnd = 316051, XrefRangeStart = 316027, XrefRangeEnd = 316049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x000692B0 File Offset: 0x000674B0
		// (set) Token: 0x0600155E RID: 5470 RVA: 0x000692FC File Offset: 0x000674FC
		public unsafe override IEventHandler currentTarget
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventBase<T>.NativeMethodInfoPtr_get_currentTarget_Public_Virtual_get_IEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316051, XrefRangeEnd = 316055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventBase<T>.NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_set_Void_IEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0006934C File Offset: 0x0006754C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316055, XrefRangeEnd = 316056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMouse(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_IsMouse_Private_Static_Boolean_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00069390 File Offset: 0x00067590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316056, XrefRangeEnd = 316057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTouch(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_IsTouch_Private_Static_Boolean_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x000693D4 File Offset: 0x000675D4
		[CallerCount(0)]
		public unsafe static float TiltToAzimuth(Vector2 tilt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tilt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_TiltToAzimuth_Private_Static_Single_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00069414 File Offset: 0x00067614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316057, XrefRangeEnd = 316065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref altitude;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref azimuth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_AzimuthAndAlitutudeToTilt_Private_Static_Vector2_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00069460 File Offset: 0x00067660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316065, XrefRangeEnd = 316068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float TiltToAltitude(Vector2 tilt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tilt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_TiltToAltitude_Private_Static_Single_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x000694A0 File Offset: 0x000676A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316218, RefRangeEnd = 316219, XrefRangeStart = 316068, XrefRangeEnd = 316218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x000694E0 File Offset: 0x000676E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316264, RefRangeEnd = 316266, XrefRangeStart = 316219, XrefRangeEnd = 316264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(EventType eventType, Vector3 mousePosition, Vector2 delta, int button, int clickCount, EventModifiers modifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mousePosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delta;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref button;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clickCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_EventType_Vector3_Vector2_Int32_Int32_EventModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00069560 File Offset: 0x00067760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316266, XrefRangeEnd = 316348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(Touch touch, EventModifiers modifiers = EventModifiers.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Touch_EventModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x000695A8 File Offset: 0x000677A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316420, RefRangeEnd = 316421, XrefRangeStart = 316348, XrefRangeEnd = 316420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(PenData pen, EventModifiers modifiers = EventModifiers.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pen;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_PenData_EventModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x000695F0 File Offset: 0x000677F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 316435, RefRangeEnd = 316440, XrefRangeStart = 316421, XrefRangeEnd = 316435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_IPointerEvent_Vector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x0006964C File Offset: 0x0006784C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 316516, RefRangeEnd = 316526, XrefRangeStart = 316440, XrefRangeEnd = 316516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IPointerEvent triggerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IPointerEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0006968C File Offset: 0x0006788C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316526, XrefRangeEnd = 316537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PreDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventBase<T>.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x000696DC File Offset: 0x000678DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 316554, RefRangeEnd = 316558, XrefRangeStart = 316537, XrefRangeEnd = 316554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventBase<T>.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0006972C File Offset: 0x0006792C
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 316562, RefRangeEnd = 316592, XrefRangeStart = 316558, XrefRangeEnd = 316562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00009F28 File Offset: 0x00008128
		public PointerEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x00069768 File Offset: 0x00067968
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x00009F31 File Offset: 0x00008131
		public unsafe bool m_AltitudeNeedsConversion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr_m_AltitudeNeedsConversion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr_m_AltitudeNeedsConversion)) = value;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x00069790 File Offset: 0x00067990
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x00009F4C File Offset: 0x0000814C
		public unsafe bool m_AzimuthNeedsConversion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr_m_AzimuthNeedsConversion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr_m_AzimuthNeedsConversion)) = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x000697B8 File Offset: 0x000679B8
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x00009F67 File Offset: 0x00008167
		public unsafe float m_AltitudeAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr_m_AltitudeAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr_m_AltitudeAngle)) = value;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x000697E0 File Offset: 0x000679E0
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x00009F82 File Offset: 0x00008182
		public unsafe float m_AzimuthAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr_m_AzimuthAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr_m_AzimuthAngle)) = value;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x00069808 File Offset: 0x00067A08
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x00009F9D File Offset: 0x0000819D
		public unsafe bool m_TiltNeeded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr_m_TiltNeeded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr_m_TiltNeeded)) = value;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x00069830 File Offset: 0x00067A30
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x00009FB8 File Offset: 0x000081B8
		public unsafe Vector2 m_Tilt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr_m_Tilt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr_m_Tilt)) = value;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x00069858 File Offset: 0x00067A58
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x00009FD3 File Offset: 0x000081D3
		public unsafe int _pointerId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pointerId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pointerId_k__BackingField)) = value;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x00069880 File Offset: 0x00067A80
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x00009FEE File Offset: 0x000081EE
		public unsafe string _pointerType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pointerType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pointerType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x000698A8 File Offset: 0x00067AA8
		// (set) Token: 0x0600157F RID: 5503 RVA: 0x0000A00D File Offset: 0x0000820D
		public unsafe bool _isPrimary_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__isPrimary_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__isPrimary_k__BackingField)) = value;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x000698D0 File Offset: 0x00067AD0
		// (set) Token: 0x06001581 RID: 5505 RVA: 0x0000A028 File Offset: 0x00008228
		public unsafe int _button_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__button_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__button_k__BackingField)) = value;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x000698F8 File Offset: 0x00067AF8
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x0000A043 File Offset: 0x00008243
		public unsafe int _pressedButtons_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pressedButtons_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pressedButtons_k__BackingField)) = value;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x00069920 File Offset: 0x00067B20
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x0000A05E File Offset: 0x0000825E
		public unsafe Vector3 _position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__position_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__position_k__BackingField)) = value;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x00069948 File Offset: 0x00067B48
		// (set) Token: 0x06001587 RID: 5511 RVA: 0x0000A079 File Offset: 0x00008279
		public unsafe Vector3 _localPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__localPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__localPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x00069970 File Offset: 0x00067B70
		// (set) Token: 0x06001589 RID: 5513 RVA: 0x0000A094 File Offset: 0x00008294
		public unsafe Vector3 _deltaPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__deltaPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__deltaPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x00069998 File Offset: 0x00067B98
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x0000A0AF File Offset: 0x000082AF
		public unsafe float _deltaTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__deltaTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__deltaTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x000699C0 File Offset: 0x00067BC0
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x0000A0CA File Offset: 0x000082CA
		public unsafe int _clickCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__clickCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__clickCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x000699E8 File Offset: 0x00067BE8
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x0000A0E5 File Offset: 0x000082E5
		public unsafe float _pressure_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pressure_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pressure_k__BackingField)) = value;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x00069A10 File Offset: 0x00067C10
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x0000A100 File Offset: 0x00008300
		public unsafe float _tangentialPressure_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__tangentialPressure_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__tangentialPressure_k__BackingField)) = value;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00069A38 File Offset: 0x00067C38
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x0000A11B File Offset: 0x0000831B
		public unsafe float _twist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__twist_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__twist_k__BackingField)) = value;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x00069A60 File Offset: 0x00067C60
		// (set) Token: 0x06001595 RID: 5525 RVA: 0x0000A136 File Offset: 0x00008336
		public unsafe PenStatus _penStatus_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__penStatus_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__penStatus_k__BackingField)) = value;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x00069A88 File Offset: 0x00067C88
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x0000A151 File Offset: 0x00008351
		public unsafe Vector2 _radius_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__radius_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__radius_k__BackingField)) = value;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x00069AB0 File Offset: 0x00067CB0
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x0000A16C File Offset: 0x0000836C
		public unsafe Vector2 _radiusVariance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__radiusVariance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__radiusVariance_k__BackingField)) = value;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x00069AD8 File Offset: 0x00067CD8
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x0000A187 File Offset: 0x00008387
		public unsafe EventModifiers _modifiers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField)) = value;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x00069B00 File Offset: 0x00067D00
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x0000A1A2 File Offset: 0x000083A2
		public unsafe bool _UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField)) = value;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00069B28 File Offset: 0x00067D28
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x0000A1BD File Offset: 0x000083BD
		public unsafe bool _UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField)) = value;
			}
		}

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeFieldInfoPtr_m_AltitudeNeedsConversion;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeFieldInfoPtr_m_AzimuthNeedsConversion;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeFieldInfoPtr_m_AltitudeAngle;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeFieldInfoPtr_m_AzimuthAngle;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeFieldInfoPtr_m_TiltNeeded;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeFieldInfoPtr_m_Tilt;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeFieldInfoPtr__pointerId_k__BackingField;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeFieldInfoPtr__pointerType_k__BackingField;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeFieldInfoPtr__isPrimary_k__BackingField;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeFieldInfoPtr__button_k__BackingField;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeFieldInfoPtr__pressedButtons_k__BackingField;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeFieldInfoPtr__position_k__BackingField;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeFieldInfoPtr__localPosition_k__BackingField;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeFieldInfoPtr__deltaPosition_k__BackingField;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeFieldInfoPtr__deltaTime_k__BackingField;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeFieldInfoPtr__clickCount_k__BackingField;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeFieldInfoPtr__pressure_k__BackingField;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeFieldInfoPtr__tangentialPressure_k__BackingField;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeFieldInfoPtr__twist_k__BackingField;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeFieldInfoPtr__penStatus_k__BackingField;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeFieldInfoPtr__radius_k__BackingField;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeFieldInfoPtr__radiusVariance_k__BackingField;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeFieldInfoPtr__modifiers_k__BackingField;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerId_Protected_set_Void_Int32_0;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerType_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerType_Protected_set_Void_String_0;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_get_isPrimary_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_set_isPrimary_Protected_set_Void_Boolean_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr_set_button_Protected_set_Void_Int32_0;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr_set_pressedButtons_Protected_set_Void_Int32_0;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Protected_set_Void_Vector3_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr_set_localPosition_Protected_set_Void_Vector3_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaPosition_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr_set_deltaPosition_Protected_set_Void_Vector3_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_set_deltaTime_Protected_set_Void_Single_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr_set_clickCount_Protected_set_Void_Int32_0;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr_get_pressure_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr_set_pressure_Protected_set_Void_Single_0;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeMethodInfoPtr_get_tangentialPressure_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeMethodInfoPtr_set_tangentialPressure_Protected_set_Void_Single_0;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeMethodInfoPtr_get_altitudeAngle_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeMethodInfoPtr_set_altitudeAngle_Protected_set_Void_Single_0;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeMethodInfoPtr_get_azimuthAngle_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeMethodInfoPtr_set_azimuthAngle_Protected_set_Void_Single_0;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeMethodInfoPtr_get_twist_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr_set_twist_Protected_set_Void_Single_0;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeMethodInfoPtr_get_tilt_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeMethodInfoPtr_set_tilt_Protected_set_Void_Vector2_0;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeMethodInfoPtr_get_penStatus_Public_Virtual_Final_New_get_PenStatus_0;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeMethodInfoPtr_set_penStatus_Protected_set_Void_PenStatus_0;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeMethodInfoPtr_get_radius_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeMethodInfoPtr_set_radius_Protected_set_Void_Vector2_0;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_get_radiusVariance_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_set_radiusVariance_Protected_set_Void_Vector2_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeMethodInfoPtr_get_actionKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_get_triggeredByOS_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_set_triggeredByOS_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_get_recomputeTopElementUnderPointer_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_set_recomputeTopElementUnderPointer_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr_get_currentTarget_Public_Virtual_get_IEventHandler_0;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_set_Void_IEventHandler_0;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_IsMouse_Private_Static_Boolean_Event_0;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr_IsTouch_Private_Static_Boolean_Event_0;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeMethodInfoPtr_TiltToAzimuth_Private_Static_Single_Vector2_0;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr_AzimuthAndAlitutudeToTilt_Private_Static_Vector2_Single_Single_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr_TiltToAltitude_Private_Static_Single_Vector2_0;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_T_EventType_Vector3_Vector2_Int32_Int32_EventModifiers_0;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_Touch_EventModifiers_0;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_PenData_EventModifiers_0;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_T_IPointerEvent_Vector2_Int32_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_IPointerEvent_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000EC9 RID: 3785
		public const float k_DefaultButtonPressure = 0.5f;
	}
}
