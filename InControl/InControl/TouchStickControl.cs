using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000050 RID: 80
	public class TouchStickControl : TouchControl
	{
		// Token: 0x06000759 RID: 1881 RVA: 0x00021FEC File Offset: 0x000201EC
		// Note: this type is marked as 'beforefieldinit'.
		static TouchStickControl()
		{
			Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "TouchStickControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr);
			TouchStickControl.NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "anchor");
			TouchStickControl.NativeFieldInfoPtr_offsetUnitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "offsetUnitType");
			TouchStickControl.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "offset");
			TouchStickControl.NativeFieldInfoPtr_areaUnitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "areaUnitType");
			TouchStickControl.NativeFieldInfoPtr_activeArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "activeArea");
			TouchStickControl.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "target");
			TouchStickControl.NativeFieldInfoPtr_snapAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "snapAngles");
			TouchStickControl.NativeFieldInfoPtr_lockToAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "lockToAxis");
			TouchStickControl.NativeFieldInfoPtr_lowerDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "lowerDeadZone");
			TouchStickControl.NativeFieldInfoPtr_upperDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "upperDeadZone");
			TouchStickControl.NativeFieldInfoPtr_inputCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "inputCurve");
			TouchStickControl.NativeFieldInfoPtr_allowDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "allowDragging");
			TouchStickControl.NativeFieldInfoPtr_allowDraggingAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "allowDraggingAxis");
			TouchStickControl.NativeFieldInfoPtr_snapToInitialTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "snapToInitialTouch");
			TouchStickControl.NativeFieldInfoPtr_resetWhenDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "resetWhenDone");
			TouchStickControl.NativeFieldInfoPtr_resetDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "resetDuration");
			TouchStickControl.NativeFieldInfoPtr_ring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "ring");
			TouchStickControl.NativeFieldInfoPtr_knob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "knob");
			TouchStickControl.NativeFieldInfoPtr_knobRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "knobRange");
			TouchStickControl.NativeFieldInfoPtr_resetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "resetPosition");
			TouchStickControl.NativeFieldInfoPtr_beganPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "beganPosition");
			TouchStickControl.NativeFieldInfoPtr_movedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "movedPosition");
			TouchStickControl.NativeFieldInfoPtr_ringResetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "ringResetSpeed");
			TouchStickControl.NativeFieldInfoPtr_knobResetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "knobResetSpeed");
			TouchStickControl.NativeFieldInfoPtr_worldActiveArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "worldActiveArea");
			TouchStickControl.NativeFieldInfoPtr_worldKnobRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "worldKnobRange");
			TouchStickControl.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "value");
			TouchStickControl.NativeFieldInfoPtr_currentTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "currentTouch");
			TouchStickControl.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, "dirty");
			TouchStickControl.NativeMethodInfoPtr_CreateControl_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664278);
			TouchStickControl.NativeMethodInfoPtr_DestroyControl_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664279);
			TouchStickControl.NativeMethodInfoPtr_ConfigureControl_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664280);
			TouchStickControl.NativeMethodInfoPtr_DrawGizmos_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664281);
			TouchStickControl.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664282);
			TouchStickControl.NativeMethodInfoPtr_SubmitControlState_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664283);
			TouchStickControl.NativeMethodInfoPtr_CommitControlState_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664284);
			TouchStickControl.NativeMethodInfoPtr_TouchBegan_Public_Virtual_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664285);
			TouchStickControl.NativeMethodInfoPtr_TouchMoved_Public_Virtual_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664286);
			TouchStickControl.NativeMethodInfoPtr_TouchEnded_Public_Virtual_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664287);
			TouchStickControl.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664288);
			TouchStickControl.NativeMethodInfoPtr_get_IsNotActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664289);
			TouchStickControl.NativeMethodInfoPtr_get_RingPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664290);
			TouchStickControl.NativeMethodInfoPtr_set_RingPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664291);
			TouchStickControl.NativeMethodInfoPtr_get_KnobPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664292);
			TouchStickControl.NativeMethodInfoPtr_set_KnobPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664293);
			TouchStickControl.NativeMethodInfoPtr_get_Anchor_Public_get_TouchControlAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664294);
			TouchStickControl.NativeMethodInfoPtr_set_Anchor_Public_set_Void_TouchControlAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664295);
			TouchStickControl.NativeMethodInfoPtr_get_Offset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664296);
			TouchStickControl.NativeMethodInfoPtr_set_Offset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664297);
			TouchStickControl.NativeMethodInfoPtr_get_OffsetUnitType_Public_get_TouchUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664298);
			TouchStickControl.NativeMethodInfoPtr_set_OffsetUnitType_Public_set_Void_TouchUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664299);
			TouchStickControl.NativeMethodInfoPtr_get_ActiveArea_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664300);
			TouchStickControl.NativeMethodInfoPtr_set_ActiveArea_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664301);
			TouchStickControl.NativeMethodInfoPtr_get_AreaUnitType_Public_get_TouchUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664302);
			TouchStickControl.NativeMethodInfoPtr_set_AreaUnitType_Public_set_Void_TouchUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664303);
			TouchStickControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr, 100664304);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0002247C File Offset: 0x0002067C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784716, XrefRangeEnd = 784724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchStickControl.NativeMethodInfoPtr_CreateControl_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000224B8 File Offset: 0x000206B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784724, XrefRangeEnd = 784733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchStickControl.NativeMethodInfoPtr_DestroyControl_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000224F4 File Offset: 0x000206F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784733, XrefRangeEnd = 784744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConfigureControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchStickControl.NativeMethodInfoPtr_ConfigureControl_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00022530 File Offset: 0x00020730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784744, XrefRangeEnd = 784763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchStickControl.NativeMethodInfoPtr_DrawGizmos_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0002256C File Offset: 0x0002076C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784763, XrefRangeEnd = 784809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x000225A0 File Offset: 0x000207A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784809, XrefRangeEnd = 784810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SubmitControlState(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchStickControl.NativeMethodInfoPtr_SubmitControlState_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000225F8 File Offset: 0x000207F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784810, XrefRangeEnd = 784811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CommitControlState(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchStickControl.NativeMethodInfoPtr_CommitControlState_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00022650 File Offset: 0x00020850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784811, XrefRangeEnd = 784823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TouchBegan(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchStickControl.NativeMethodInfoPtr_TouchBegan_Public_Virtual_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x000226A0 File Offset: 0x000208A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784823, XrefRangeEnd = 784843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TouchMoved(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchStickControl.NativeMethodInfoPtr_TouchMoved_Public_Virtual_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000226F0 File Offset: 0x000208F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784843, XrefRangeEnd = 784868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TouchEnded(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchStickControl.NativeMethodInfoPtr_TouchEnded_Public_Virtual_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00022740 File Offset: 0x00020940
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x0002277C File Offset: 0x0002097C
		public unsafe bool IsNotActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_get_IsNotActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x000227B8 File Offset: 0x000209B8
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x000227F4 File Offset: 0x000209F4
		public unsafe Vector3 RingPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784868, XrefRangeEnd = 784872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_get_RingPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 784878, RefRangeEnd = 784882, XrefRangeStart = 784872, XrefRangeEnd = 784878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_set_RingPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00022834 File Offset: 0x00020A34
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00022870 File Offset: 0x00020A70
		public unsafe Vector3 KnobPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784882, XrefRangeEnd = 784886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_get_KnobPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 784892, RefRangeEnd = 784897, XrefRangeStart = 784886, XrefRangeEnd = 784892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_set_KnobPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x000228B0 File Offset: 0x00020AB0
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x000228EC File Offset: 0x00020AEC
		public unsafe TouchControlAnchor Anchor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_get_Anchor_Public_get_TouchControlAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_set_Anchor_Public_set_Void_TouchControlAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x0002292C File Offset: 0x00020B2C
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00022968 File Offset: 0x00020B68
		public unsafe Vector2 Offset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_get_Offset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_set_Offset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x000229A8 File Offset: 0x00020BA8
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x000229E4 File Offset: 0x00020BE4
		public unsafe TouchUnitType OffsetUnitType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_get_OffsetUnitType_Public_get_TouchUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_set_OffsetUnitType_Public_set_Void_TouchUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00022A24 File Offset: 0x00020C24
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00022A60 File Offset: 0x00020C60
		public unsafe Rect ActiveArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_get_ActiveArea_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_set_ActiveArea_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00022AA0 File Offset: 0x00020CA0
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x00022ADC File Offset: 0x00020CDC
		public unsafe TouchUnitType AreaUnitType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_get_AreaUnitType_Public_get_TouchUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr_set_AreaUnitType_Public_set_Void_TouchUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00022B1C File Offset: 0x00020D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784897, XrefRangeEnd = 784909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchStickControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchStickControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchStickControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00004CC2 File Offset: 0x00002EC2
		public TouchStickControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00022B58 File Offset: 0x00020D58
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00004CCB File Offset: 0x00002ECB
		public unsafe TouchControlAnchor anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_anchor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_anchor)) = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00022B80 File Offset: 0x00020D80
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00004CE6 File Offset: 0x00002EE6
		public unsafe TouchUnitType offsetUnitType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_offsetUnitType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_offsetUnitType)) = value;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00022BA8 File Offset: 0x00020DA8
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x00004D01 File Offset: 0x00002F01
		public unsafe Vector2 offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x00022BD0 File Offset: 0x00020DD0
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x00004D1C File Offset: 0x00002F1C
		public unsafe TouchUnitType areaUnitType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_areaUnitType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_areaUnitType)) = value;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00022BF8 File Offset: 0x00020DF8
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00004D37 File Offset: 0x00002F37
		public unsafe Rect activeArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_activeArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_activeArea)) = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00022C20 File Offset: 0x00020E20
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00004D52 File Offset: 0x00002F52
		public unsafe TouchControl.AnalogTarget target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_target);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_target)) = value;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00022C48 File Offset: 0x00020E48
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00004D6D File Offset: 0x00002F6D
		public unsafe TouchControl.SnapAngles snapAngles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_snapAngles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_snapAngles)) = value;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00022C70 File Offset: 0x00020E70
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00004D88 File Offset: 0x00002F88
		public unsafe LockAxis lockToAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_lockToAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_lockToAxis)) = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00022C98 File Offset: 0x00020E98
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00004DA3 File Offset: 0x00002FA3
		public unsafe float lowerDeadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_lowerDeadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_lowerDeadZone)) = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00022CC0 File Offset: 0x00020EC0
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00004DBE File Offset: 0x00002FBE
		public unsafe float upperDeadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_upperDeadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_upperDeadZone)) = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00022CE8 File Offset: 0x00020EE8
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x00004DD9 File Offset: 0x00002FD9
		public unsafe AnimationCurve inputCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_inputCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_inputCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00022D18 File Offset: 0x00020F18
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x00004DF8 File Offset: 0x00002FF8
		public unsafe bool allowDragging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_allowDragging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_allowDragging)) = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00022D40 File Offset: 0x00020F40
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00004E13 File Offset: 0x00003013
		public unsafe DragAxis allowDraggingAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_allowDraggingAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_allowDraggingAxis)) = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00022D68 File Offset: 0x00020F68
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x00004E2E File Offset: 0x0000302E
		public unsafe bool snapToInitialTouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_snapToInitialTouch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_snapToInitialTouch)) = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00022D90 File Offset: 0x00020F90
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x00004E49 File Offset: 0x00003049
		public unsafe bool resetWhenDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_resetWhenDone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_resetWhenDone)) = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00022DB8 File Offset: 0x00020FB8
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x00004E64 File Offset: 0x00003064
		public unsafe float resetDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_resetDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_resetDuration)) = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00022DE0 File Offset: 0x00020FE0
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x00004E7F File Offset: 0x0000307F
		public unsafe TouchSprite ring
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_ring);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchSprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_ring), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00022E10 File Offset: 0x00021010
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x00004E9E File Offset: 0x0000309E
		public unsafe TouchSprite knob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_knob);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchSprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_knob), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00022E40 File Offset: 0x00021040
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x00004EBD File Offset: 0x000030BD
		public unsafe float knobRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_knobRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_knobRange)) = value;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00022E68 File Offset: 0x00021068
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x00004ED8 File Offset: 0x000030D8
		public unsafe Vector3 resetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_resetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_resetPosition)) = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00022E90 File Offset: 0x00021090
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00004EF3 File Offset: 0x000030F3
		public unsafe Vector3 beganPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_beganPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_beganPosition)) = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00022EB8 File Offset: 0x000210B8
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00004F0E File Offset: 0x0000310E
		public unsafe Vector3 movedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_movedPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_movedPosition)) = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00022EE0 File Offset: 0x000210E0
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x00004F29 File Offset: 0x00003129
		public unsafe float ringResetSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_ringResetSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_ringResetSpeed)) = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x00022F08 File Offset: 0x00021108
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x00004F44 File Offset: 0x00003144
		public unsafe float knobResetSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_knobResetSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_knobResetSpeed)) = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00022F30 File Offset: 0x00021130
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00004F5F File Offset: 0x0000315F
		public unsafe Rect worldActiveArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_worldActiveArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_worldActiveArea)) = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x00022F58 File Offset: 0x00021158
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x00004F7A File Offset: 0x0000317A
		public unsafe float worldKnobRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_worldKnobRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_worldKnobRange)) = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x00022F80 File Offset: 0x00021180
		// (set) Token: 0x060007AB RID: 1963 RVA: 0x00004F95 File Offset: 0x00003195
		public unsafe Vector3 value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x00022FA8 File Offset: 0x000211A8
		// (set) Token: 0x060007AD RID: 1965 RVA: 0x00004FB0 File Offset: 0x000031B0
		public unsafe Touch currentTouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_currentTouch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Touch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_currentTouch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x00022FD8 File Offset: 0x000211D8
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x00004FCF File Offset: 0x000031CF
		public unsafe bool dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_dirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchStickControl.NativeFieldInfoPtr_dirty)) = value;
			}
		}

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr_anchor;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeFieldInfoPtr_offsetUnitType;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr_areaUnitType;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr_activeArea;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeFieldInfoPtr_snapAngles;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr_lockToAxis;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeFieldInfoPtr_lowerDeadZone;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr_upperDeadZone;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr_inputCurve;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr_allowDragging;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeFieldInfoPtr_allowDraggingAxis;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeFieldInfoPtr_snapToInitialTouch;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeFieldInfoPtr_resetWhenDone;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeFieldInfoPtr_resetDuration;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeFieldInfoPtr_ring;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeFieldInfoPtr_knob;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeFieldInfoPtr_knobRange;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeFieldInfoPtr_resetPosition;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeFieldInfoPtr_beganPosition;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeFieldInfoPtr_movedPosition;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeFieldInfoPtr_ringResetSpeed;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeFieldInfoPtr_knobResetSpeed;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeFieldInfoPtr_worldActiveArea;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeFieldInfoPtr_worldKnobRange;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeFieldInfoPtr_currentTouch;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeFieldInfoPtr_dirty;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_CreateControl_Public_Virtual_Void_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_DestroyControl_Public_Virtual_Void_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureControl_Public_Virtual_Void_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_DrawGizmos_Public_Virtual_Void_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_SubmitControlState_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_CommitControlState_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_TouchBegan_Public_Virtual_Void_Touch_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_TouchMoved_Public_Virtual_Void_Touch_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_TouchEnded_Public_Virtual_Void_Touch_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNotActive_Public_get_Boolean_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_get_RingPosition_Public_get_Vector3_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_set_RingPosition_Public_set_Void_Vector3_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_get_KnobPosition_Public_get_Vector3_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_set_KnobPosition_Public_set_Void_Vector3_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_get_Anchor_Public_get_TouchControlAnchor_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_set_Anchor_Public_set_Void_TouchControlAnchor_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_get_Offset_Public_get_Vector2_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_set_Offset_Public_set_Void_Vector2_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetUnitType_Public_get_TouchUnitType_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_set_OffsetUnitType_Public_set_Void_TouchUnitType_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveArea_Public_get_Rect_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveArea_Public_set_Void_Rect_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_get_AreaUnitType_Public_get_TouchUnitType_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_set_AreaUnitType_Public_set_Void_TouchUnitType_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
