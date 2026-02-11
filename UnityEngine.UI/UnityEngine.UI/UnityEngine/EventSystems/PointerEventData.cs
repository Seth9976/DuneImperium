using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000050 RID: 80
	public class PointerEventData : BaseEventData
	{
		// Token: 0x06000910 RID: 2320 RVA: 0x0002AC98 File Offset: 0x00028E98
		// Note: this type is marked as 'beforefieldinit'.
		static PointerEventData()
		{
			Il2CppClassPointerStore<PointerEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "PointerEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr);
			PointerEventData.NativeFieldInfoPtr__pointerEnter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerEnter>k__BackingField");
			PointerEventData.NativeFieldInfoPtr_m_PointerPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "m_PointerPress");
			PointerEventData.NativeFieldInfoPtr__lastPress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<lastPress>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__rawPointerPress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<rawPointerPress>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerDrag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerDrag>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerClick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerClick>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerCurrentRaycast_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerCurrentRaycast>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerPressRaycast_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerPressRaycast>k__BackingField");
			PointerEventData.NativeFieldInfoPtr_hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "hovered");
			PointerEventData.NativeFieldInfoPtr__eligibleForClick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<eligibleForClick>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__displayIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<displayIndex>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerId>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<position>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__delta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<delta>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pressPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pressPosition>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__worldPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<worldPosition>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__worldNormal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<worldNormal>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__clickTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<clickTime>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__clickCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<clickCount>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__scrollDelta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<scrollDelta>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__useDragThreshold_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<useDragThreshold>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__dragging_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<dragging>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__button_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<button>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pressure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pressure>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__tangentialPressure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<tangentialPressure>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__altitudeAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<altitudeAngle>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__azimuthAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<azimuthAngle>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__twist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<twist>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__tilt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<tilt>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__penStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<penStatus>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__radius_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<radius>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__radiusVariance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<radiusVariance>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__fullyExited_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<fullyExited>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__reentered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<reentered>k__BackingField");
			PointerEventData.NativeMethodInfoPtr_get_pointerEnter_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664821);
			PointerEventData.NativeMethodInfoPtr_set_pointerEnter_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664822);
			PointerEventData.NativeMethodInfoPtr_get_lastPress_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664823);
			PointerEventData.NativeMethodInfoPtr_set_lastPress_Private_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664824);
			PointerEventData.NativeMethodInfoPtr_get_rawPointerPress_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664825);
			PointerEventData.NativeMethodInfoPtr_set_rawPointerPress_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664826);
			PointerEventData.NativeMethodInfoPtr_get_pointerDrag_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664827);
			PointerEventData.NativeMethodInfoPtr_set_pointerDrag_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664828);
			PointerEventData.NativeMethodInfoPtr_get_pointerClick_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664829);
			PointerEventData.NativeMethodInfoPtr_set_pointerClick_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664830);
			PointerEventData.NativeMethodInfoPtr_get_pointerCurrentRaycast_Public_get_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664831);
			PointerEventData.NativeMethodInfoPtr_set_pointerCurrentRaycast_Public_set_Void_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664832);
			PointerEventData.NativeMethodInfoPtr_get_pointerPressRaycast_Public_get_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664833);
			PointerEventData.NativeMethodInfoPtr_set_pointerPressRaycast_Public_set_Void_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664834);
			PointerEventData.NativeMethodInfoPtr_get_eligibleForClick_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664835);
			PointerEventData.NativeMethodInfoPtr_set_eligibleForClick_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664836);
			PointerEventData.NativeMethodInfoPtr_get_displayIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664837);
			PointerEventData.NativeMethodInfoPtr_set_displayIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664838);
			PointerEventData.NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664839);
			PointerEventData.NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664840);
			PointerEventData.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664841);
			PointerEventData.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664842);
			PointerEventData.NativeMethodInfoPtr_get_delta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664843);
			PointerEventData.NativeMethodInfoPtr_set_delta_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664844);
			PointerEventData.NativeMethodInfoPtr_get_pressPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664845);
			PointerEventData.NativeMethodInfoPtr_set_pressPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664846);
			PointerEventData.NativeMethodInfoPtr_get_worldPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664847);
			PointerEventData.NativeMethodInfoPtr_set_worldPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664848);
			PointerEventData.NativeMethodInfoPtr_get_worldNormal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664849);
			PointerEventData.NativeMethodInfoPtr_set_worldNormal_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664850);
			PointerEventData.NativeMethodInfoPtr_get_clickTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664851);
			PointerEventData.NativeMethodInfoPtr_set_clickTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664852);
			PointerEventData.NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664853);
			PointerEventData.NativeMethodInfoPtr_set_clickCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664854);
			PointerEventData.NativeMethodInfoPtr_get_scrollDelta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664855);
			PointerEventData.NativeMethodInfoPtr_set_scrollDelta_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664856);
			PointerEventData.NativeMethodInfoPtr_get_useDragThreshold_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664857);
			PointerEventData.NativeMethodInfoPtr_set_useDragThreshold_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664858);
			PointerEventData.NativeMethodInfoPtr_get_dragging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664859);
			PointerEventData.NativeMethodInfoPtr_set_dragging_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664860);
			PointerEventData.NativeMethodInfoPtr_get_button_Public_get_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664861);
			PointerEventData.NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664862);
			PointerEventData.NativeMethodInfoPtr_get_pressure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664863);
			PointerEventData.NativeMethodInfoPtr_set_pressure_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664864);
			PointerEventData.NativeMethodInfoPtr_get_tangentialPressure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664865);
			PointerEventData.NativeMethodInfoPtr_set_tangentialPressure_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664866);
			PointerEventData.NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664867);
			PointerEventData.NativeMethodInfoPtr_set_altitudeAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664868);
			PointerEventData.NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664869);
			PointerEventData.NativeMethodInfoPtr_set_azimuthAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664870);
			PointerEventData.NativeMethodInfoPtr_get_twist_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664871);
			PointerEventData.NativeMethodInfoPtr_set_twist_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664872);
			PointerEventData.NativeMethodInfoPtr_get_tilt_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664873);
			PointerEventData.NativeMethodInfoPtr_set_tilt_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664874);
			PointerEventData.NativeMethodInfoPtr_get_penStatus_Public_get_PenStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664875);
			PointerEventData.NativeMethodInfoPtr_set_penStatus_Public_set_Void_PenStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664876);
			PointerEventData.NativeMethodInfoPtr_get_radius_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664877);
			PointerEventData.NativeMethodInfoPtr_set_radius_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664878);
			PointerEventData.NativeMethodInfoPtr_get_radiusVariance_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664879);
			PointerEventData.NativeMethodInfoPtr_set_radiusVariance_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664880);
			PointerEventData.NativeMethodInfoPtr_get_fullyExited_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664881);
			PointerEventData.NativeMethodInfoPtr_set_fullyExited_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664882);
			PointerEventData.NativeMethodInfoPtr_get_reentered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664883);
			PointerEventData.NativeMethodInfoPtr_set_reentered_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664884);
			PointerEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664885);
			PointerEventData.NativeMethodInfoPtr_IsPointerMoving_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664886);
			PointerEventData.NativeMethodInfoPtr_IsScrolling_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664887);
			PointerEventData.NativeMethodInfoPtr_get_enterEventCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664888);
			PointerEventData.NativeMethodInfoPtr_get_pressEventCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664889);
			PointerEventData.NativeMethodInfoPtr_get_pointerPress_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664890);
			PointerEventData.NativeMethodInfoPtr_set_pointerPress_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664891);
			PointerEventData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664892);
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x0002B510 File Offset: 0x00029710
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x0002B550 File Offset: 0x00029750
		public unsafe GameObject pointerEnter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerEnter_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerEnter_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x0002B594 File Offset: 0x00029794
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x0002B5D4 File Offset: 0x000297D4
		public unsafe GameObject lastPress
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_lastPress_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_lastPress_Private_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0002B618 File Offset: 0x00029818
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x0002B658 File Offset: 0x00029858
		public unsafe GameObject rawPointerPress
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_rawPointerPress_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_rawPointerPress_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0002B69C File Offset: 0x0002989C
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x0002B6DC File Offset: 0x000298DC
		public unsafe GameObject pointerDrag
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerDrag_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerDrag_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x0002B720 File Offset: 0x00029920
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x0002B760 File Offset: 0x00029960
		public unsafe GameObject pointerClick
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerClick_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerClick_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0002B7A4 File Offset: 0x000299A4
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x0002B7DC File Offset: 0x000299DC
		public unsafe RaycastResult pointerCurrentRaycast
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerCurrentRaycast_Public_get_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RaycastResult(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094796, XrefRangeEnd = 1094797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerCurrentRaycast_Public_set_Void_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x0002B824 File Offset: 0x00029A24
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x0002B85C File Offset: 0x00029A5C
		public unsafe RaycastResult pointerPressRaycast
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerPressRaycast_Public_get_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RaycastResult(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094797, XrefRangeEnd = 1094798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerPressRaycast_Public_set_Void_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0002B8A4 File Offset: 0x00029AA4
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x0002B8E0 File Offset: 0x00029AE0
		public unsafe bool eligibleForClick
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_eligibleForClick_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_eligibleForClick_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0002B920 File Offset: 0x00029B20
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x0002B95C File Offset: 0x00029B5C
		public unsafe int displayIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_displayIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_displayIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0002B99C File Offset: 0x00029B9C
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x0002B9D8 File Offset: 0x00029BD8
		public unsafe int pointerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x0002BA18 File Offset: 0x00029C18
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x0002BA54 File Offset: 0x00029C54
		public unsafe Vector2 position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0002BA94 File Offset: 0x00029C94
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x0002BAD0 File Offset: 0x00029CD0
		public unsafe Vector2 delta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_delta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_delta_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0002BB10 File Offset: 0x00029D10
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x0002BB4C File Offset: 0x00029D4C
		public unsafe Vector2 pressPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pressPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pressPosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0002BB8C File Offset: 0x00029D8C
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x0002BBC8 File Offset: 0x00029DC8
		public unsafe Vector3 worldPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_worldPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_worldPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0002BC08 File Offset: 0x00029E08
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x0002BC44 File Offset: 0x00029E44
		public unsafe Vector3 worldNormal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_worldNormal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_worldNormal_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0002BC84 File Offset: 0x00029E84
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x0002BCC0 File Offset: 0x00029EC0
		public unsafe float clickTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_clickTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_clickTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x0002BD00 File Offset: 0x00029F00
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x0002BD3C File Offset: 0x00029F3C
		public unsafe int clickCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_clickCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0002BD7C File Offset: 0x00029F7C
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x0002BDB8 File Offset: 0x00029FB8
		public unsafe Vector2 scrollDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_scrollDelta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_scrollDelta_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x0002BDF8 File Offset: 0x00029FF8
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x0002BE34 File Offset: 0x0002A034
		public unsafe bool useDragThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_useDragThreshold_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_useDragThreshold_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0002BE74 File Offset: 0x0002A074
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x0002BEB0 File Offset: 0x0002A0B0
		public unsafe bool dragging
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_dragging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_dragging_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x0002BEF0 File Offset: 0x0002A0F0
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x0002BF2C File Offset: 0x0002A12C
		public unsafe PointerEventData.InputButton button
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_button_Public_get_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0002BF6C File Offset: 0x0002A16C
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x0002BFA8 File Offset: 0x0002A1A8
		public unsafe float pressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pressure_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pressure_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0002BFE8 File Offset: 0x0002A1E8
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x0002C024 File Offset: 0x0002A224
		public unsafe float tangentialPressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_tangentialPressure_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_tangentialPressure_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0002C064 File Offset: 0x0002A264
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x0002C0A0 File Offset: 0x0002A2A0
		public unsafe float altitudeAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_altitudeAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0002C0E0 File Offset: 0x0002A2E0
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x0002C11C File Offset: 0x0002A31C
		public unsafe float azimuthAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_azimuthAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0002C15C File Offset: 0x0002A35C
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x0002C198 File Offset: 0x0002A398
		public unsafe float twist
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_twist_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_twist_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x0002C1D8 File Offset: 0x0002A3D8
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x0002C214 File Offset: 0x0002A414
		public unsafe Vector2 tilt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_tilt_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_tilt_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x0002C254 File Offset: 0x0002A454
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x0002C290 File Offset: 0x0002A490
		public unsafe PenStatus penStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_penStatus_Public_get_PenStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_penStatus_Public_set_Void_PenStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0002C2D0 File Offset: 0x0002A4D0
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x0002C30C File Offset: 0x0002A50C
		public unsafe Vector2 radius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_radius_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_radius_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0002C34C File Offset: 0x0002A54C
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x0002C388 File Offset: 0x0002A588
		public unsafe Vector2 radiusVariance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_radiusVariance_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_radiusVariance_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0002C3C8 File Offset: 0x0002A5C8
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x0002C404 File Offset: 0x0002A604
		public unsafe bool fullyExited
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_fullyExited_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_fullyExited_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0002C444 File Offset: 0x0002A644
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x0002C480 File Offset: 0x0002A680
		public unsafe bool reentered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_reentered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_reentered_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0002C4C0 File Offset: 0x0002A6C0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1094819, RefRangeEnd = 1094827, XrefRangeStart = 1094798, XrefRangeEnd = 1094819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData(EventSystem eventSystem)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0002C50C File Offset: 0x0002A70C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1094827, RefRangeEnd = 1094828, XrefRangeStart = 1094827, XrefRangeEnd = 1094827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointerMoving()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_IsPointerMoving_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0002C548 File Offset: 0x0002A748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1094828, RefRangeEnd = 1094829, XrefRangeStart = 1094828, XrefRangeEnd = 1094828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsScrolling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_IsScrolling_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x0002C584 File Offset: 0x0002A784
		public unsafe Camera enterEventCamera
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1094833, RefRangeEnd = 1094841, XrefRangeStart = 1094829, XrefRangeEnd = 1094833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_enterEventCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0002C5C4 File Offset: 0x0002A7C4
		public unsafe Camera pressEventCamera
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1094845, RefRangeEnd = 1094860, XrefRangeStart = 1094841, XrefRangeEnd = 1094845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pressEventCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0002C604 File Offset: 0x0002A804
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x0002C644 File Offset: 0x0002A844
		public unsafe GameObject pointerPress
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerPress_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 1094866, RefRangeEnd = 1094886, XrefRangeStart = 1094860, XrefRangeEnd = 1094866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerPress_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0002C688 File Offset: 0x0002A888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094886, XrefRangeEnd = 1094996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00005130 File Offset: 0x00003330
		public PointerEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0002C6CC File Offset: 0x0002A8CC
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x00005139 File Offset: 0x00003339
		public unsafe GameObject _pointerEnter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerEnter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerEnter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x0002C6FC File Offset: 0x0002A8FC
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x00005158 File Offset: 0x00003358
		public unsafe GameObject m_PointerPress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr_m_PointerPress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr_m_PointerPress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x0002C72C File Offset: 0x0002A92C
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00005177 File Offset: 0x00003377
		public unsafe GameObject _lastPress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__lastPress_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__lastPress_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x0002C75C File Offset: 0x0002A95C
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x00005196 File Offset: 0x00003396
		public unsafe GameObject _rawPointerPress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__rawPointerPress_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__rawPointerPress_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x0002C78C File Offset: 0x0002A98C
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x000051B5 File Offset: 0x000033B5
		public unsafe GameObject _pointerDrag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerDrag_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerDrag_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x0002C7BC File Offset: 0x0002A9BC
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x000051D4 File Offset: 0x000033D4
		public unsafe GameObject _pointerClick_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerClick_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerClick_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x0002C7EC File Offset: 0x0002A9EC
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x000051F3 File Offset: 0x000033F3
		public RaycastResult _pointerCurrentRaycast_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerCurrentRaycast_k__BackingField);
				return new RaycastResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerCurrentRaycast_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x0002C81C File Offset: 0x0002AA1C
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00005221 File Offset: 0x00003421
		public RaycastResult _pointerPressRaycast_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerPressRaycast_k__BackingField);
				return new RaycastResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerPressRaycast_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0002C84C File Offset: 0x0002AA4C
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x0000524F File Offset: 0x0000344F
		public unsafe List<GameObject> hovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr_hovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr_hovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0002C87C File Offset: 0x0002AA7C
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x0000526E File Offset: 0x0000346E
		public unsafe bool _eligibleForClick_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__eligibleForClick_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__eligibleForClick_k__BackingField)) = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0002C8A4 File Offset: 0x0002AAA4
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x00005289 File Offset: 0x00003489
		public unsafe int _displayIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__displayIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__displayIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0002C8CC File Offset: 0x0002AACC
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x000052A4 File Offset: 0x000034A4
		public unsafe int _pointerId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerId_k__BackingField)) = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0002C8F4 File Offset: 0x0002AAF4
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x000052BF File Offset: 0x000034BF
		public unsafe Vector2 _position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__position_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__position_k__BackingField)) = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0002C91C File Offset: 0x0002AB1C
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x000052DA File Offset: 0x000034DA
		public unsafe Vector2 _delta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__delta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__delta_k__BackingField)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0002C944 File Offset: 0x0002AB44
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x000052F5 File Offset: 0x000034F5
		public unsafe Vector2 _pressPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pressPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pressPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0002C96C File Offset: 0x0002AB6C
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x00005310 File Offset: 0x00003510
		public unsafe Vector3 _worldPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__worldPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__worldPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x0002C994 File Offset: 0x0002AB94
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x0000532B File Offset: 0x0000352B
		public unsafe Vector3 _worldNormal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__worldNormal_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__worldNormal_k__BackingField)) = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0002C9BC File Offset: 0x0002ABBC
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x00005346 File Offset: 0x00003546
		public unsafe float _clickTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__clickTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__clickTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x0002C9E4 File Offset: 0x0002ABE4
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00005361 File Offset: 0x00003561
		public unsafe int _clickCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__clickCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__clickCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x0002CA0C File Offset: 0x0002AC0C
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x0000537C File Offset: 0x0000357C
		public unsafe Vector2 _scrollDelta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__scrollDelta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__scrollDelta_k__BackingField)) = value;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x0002CA34 File Offset: 0x0002AC34
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00005397 File Offset: 0x00003597
		public unsafe bool _useDragThreshold_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__useDragThreshold_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__useDragThreshold_k__BackingField)) = value;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0002CA5C File Offset: 0x0002AC5C
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x000053B2 File Offset: 0x000035B2
		public unsafe bool _dragging_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__dragging_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__dragging_k__BackingField)) = value;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x0002CA84 File Offset: 0x0002AC84
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x000053CD File Offset: 0x000035CD
		public unsafe PointerEventData.InputButton _button_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__button_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__button_k__BackingField)) = value;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x0002CAAC File Offset: 0x0002ACAC
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x000053E8 File Offset: 0x000035E8
		public unsafe float _pressure_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pressure_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pressure_k__BackingField)) = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x0002CAD4 File Offset: 0x0002ACD4
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00005403 File Offset: 0x00003603
		public unsafe float _tangentialPressure_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__tangentialPressure_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__tangentialPressure_k__BackingField)) = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x0002CAFC File Offset: 0x0002ACFC
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x0000541E File Offset: 0x0000361E
		public unsafe float _altitudeAngle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__altitudeAngle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__altitudeAngle_k__BackingField)) = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0002CB24 File Offset: 0x0002AD24
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x00005439 File Offset: 0x00003639
		public unsafe float _azimuthAngle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__azimuthAngle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__azimuthAngle_k__BackingField)) = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0002CB4C File Offset: 0x0002AD4C
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x00005454 File Offset: 0x00003654
		public unsafe float _twist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__twist_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__twist_k__BackingField)) = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0002CB74 File Offset: 0x0002AD74
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x0000546F File Offset: 0x0000366F
		public unsafe Vector2 _tilt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__tilt_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__tilt_k__BackingField)) = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0002CB9C File Offset: 0x0002AD9C
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x0000548A File Offset: 0x0000368A
		public unsafe PenStatus _penStatus_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__penStatus_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__penStatus_k__BackingField)) = value;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x0002CBC4 File Offset: 0x0002ADC4
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x000054A5 File Offset: 0x000036A5
		public unsafe Vector2 _radius_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__radius_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__radius_k__BackingField)) = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0002CBEC File Offset: 0x0002ADEC
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x000054C0 File Offset: 0x000036C0
		public unsafe Vector2 _radiusVariance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__radiusVariance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__radiusVariance_k__BackingField)) = value;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0002CC14 File Offset: 0x0002AE14
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x000054DB File Offset: 0x000036DB
		public unsafe bool _fullyExited_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__fullyExited_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__fullyExited_k__BackingField)) = value;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0002CC3C File Offset: 0x0002AE3C
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x000054F6 File Offset: 0x000036F6
		public unsafe bool _reentered_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__reentered_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__reentered_k__BackingField)) = value;
			}
		}

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeFieldInfoPtr__pointerEnter_k__BackingField;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerPress;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeFieldInfoPtr__lastPress_k__BackingField;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeFieldInfoPtr__rawPointerPress_k__BackingField;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeFieldInfoPtr__pointerDrag_k__BackingField;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeFieldInfoPtr__pointerClick_k__BackingField;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeFieldInfoPtr__pointerCurrentRaycast_k__BackingField;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeFieldInfoPtr__pointerPressRaycast_k__BackingField;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeFieldInfoPtr_hovered;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeFieldInfoPtr__eligibleForClick_k__BackingField;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeFieldInfoPtr__displayIndex_k__BackingField;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeFieldInfoPtr__pointerId_k__BackingField;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeFieldInfoPtr__position_k__BackingField;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeFieldInfoPtr__delta_k__BackingField;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeFieldInfoPtr__pressPosition_k__BackingField;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeFieldInfoPtr__worldPosition_k__BackingField;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeFieldInfoPtr__worldNormal_k__BackingField;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeFieldInfoPtr__clickTime_k__BackingField;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeFieldInfoPtr__clickCount_k__BackingField;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeFieldInfoPtr__scrollDelta_k__BackingField;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeFieldInfoPtr__useDragThreshold_k__BackingField;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeFieldInfoPtr__dragging_k__BackingField;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeFieldInfoPtr__button_k__BackingField;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeFieldInfoPtr__pressure_k__BackingField;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeFieldInfoPtr__tangentialPressure_k__BackingField;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeFieldInfoPtr__altitudeAngle_k__BackingField;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeFieldInfoPtr__azimuthAngle_k__BackingField;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeFieldInfoPtr__twist_k__BackingField;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeFieldInfoPtr__tilt_k__BackingField;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeFieldInfoPtr__penStatus_k__BackingField;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeFieldInfoPtr__radius_k__BackingField;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeFieldInfoPtr__radiusVariance_k__BackingField;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeFieldInfoPtr__fullyExited_k__BackingField;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeFieldInfoPtr__reentered_k__BackingField;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerEnter_Public_get_GameObject_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerEnter_Public_set_Void_GameObject_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_get_lastPress_Public_get_GameObject_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_set_lastPress_Private_set_Void_GameObject_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_get_rawPointerPress_Public_get_GameObject_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_set_rawPointerPress_Public_set_Void_GameObject_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerDrag_Public_get_GameObject_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerDrag_Public_set_Void_GameObject_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerClick_Public_get_GameObject_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerClick_Public_set_Void_GameObject_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerCurrentRaycast_Public_get_RaycastResult_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerCurrentRaycast_Public_set_Void_RaycastResult_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerPressRaycast_Public_get_RaycastResult_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerPressRaycast_Public_set_Void_RaycastResult_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_get_eligibleForClick_Public_get_Boolean_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_set_eligibleForClick_Public_set_Void_Boolean_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_get_displayIndex_Public_get_Int32_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_set_displayIndex_Public_set_Void_Int32_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_get_delta_Public_get_Vector2_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr_set_delta_Public_set_Void_Vector2_0;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr_get_pressPosition_Public_get_Vector2_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_set_pressPosition_Public_set_Void_Vector2_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr_get_worldPosition_Public_get_Vector3_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_set_worldPosition_Public_set_Void_Vector3_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_get_worldNormal_Public_get_Vector3_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_set_worldNormal_Public_set_Void_Vector3_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_get_clickTime_Public_get_Single_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_set_clickTime_Public_set_Void_Single_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_set_clickCount_Public_set_Void_Int32_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollDelta_Public_get_Vector2_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_set_scrollDelta_Public_set_Void_Vector2_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_get_useDragThreshold_Public_get_Boolean_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_set_useDragThreshold_Public_set_Void_Boolean_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_get_dragging_Public_get_Boolean_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_set_dragging_Public_set_Void_Boolean_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_get_InputButton_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_get_pressure_Public_get_Single_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_set_pressure_Public_set_Void_Single_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_get_tangentialPressure_Public_get_Single_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_set_tangentialPressure_Public_set_Void_Single_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_set_altitudeAngle_Public_set_Void_Single_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_set_azimuthAngle_Public_set_Void_Single_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_get_twist_Public_get_Single_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_set_twist_Public_set_Void_Single_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_get_tilt_Public_get_Vector2_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_set_tilt_Public_set_Void_Vector2_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_get_penStatus_Public_get_PenStatus_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_set_penStatus_Public_set_Void_PenStatus_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_get_radius_Public_get_Vector2_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_set_radius_Public_set_Void_Vector2_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_get_radiusVariance_Public_get_Vector2_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_set_radiusVariance_Public_set_Void_Vector2_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_get_fullyExited_Public_get_Boolean_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_set_fullyExited_Public_set_Void_Boolean_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_get_reentered_Public_get_Boolean_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_set_reentered_Public_set_Void_Boolean_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerMoving_Public_Boolean_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_IsScrolling_Public_Boolean_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_get_enterEventCamera_Public_get_Camera_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_get_pressEventCamera_Public_get_Camera_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerPress_Public_get_GameObject_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerPress_Public_set_Void_GameObject_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020000C7 RID: 199
		public enum InputButton
		{
			// Token: 0x04000A93 RID: 2707
			Left,
			// Token: 0x04000A94 RID: 2708
			Right,
			// Token: 0x04000A95 RID: 2709
			Middle
		}

		// Token: 0x020000C8 RID: 200
		public enum FramePressState
		{
			// Token: 0x04000A97 RID: 2711
			Pressed,
			// Token: 0x04000A98 RID: 2712
			Released,
			// Token: 0x04000A99 RID: 2713
			PressedAndReleased,
			// Token: 0x04000A9A RID: 2714
			NotChanged
		}
	}
}
