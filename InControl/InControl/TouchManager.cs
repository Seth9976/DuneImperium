using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000057 RID: 87
	public class TouchManager : SingletonMonoBehavior<TouchManager>
	{
		// Token: 0x06000868 RID: 2152 RVA: 0x00025434 File Offset: 0x00023634
		// Note: this type is marked as 'beforefieldinit'.
		static TouchManager()
		{
			Il2CppClassPointerStore<TouchManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "TouchManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchManager>.NativeClassPtr);
			TouchManager.NativeFieldInfoPtr_touchCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "touchCamera");
			TouchManager.NativeFieldInfoPtr_controlsShowGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "controlsShowGizmos");
			TouchManager.NativeFieldInfoPtr_enableControlsOnTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "enableControlsOnTouch");
			TouchManager.NativeFieldInfoPtr__controlsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "_controlsEnabled");
			TouchManager.NativeFieldInfoPtr_controlsLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "controlsLayer");
			TouchManager.NativeFieldInfoPtr_OnSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "OnSetup");
			TouchManager.NativeFieldInfoPtr_device = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "device");
			TouchManager.NativeFieldInfoPtr_viewSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "viewSize");
			TouchManager.NativeFieldInfoPtr_screenSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "screenSize");
			TouchManager.NativeFieldInfoPtr_halfScreenSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "halfScreenSize");
			TouchManager.NativeFieldInfoPtr_percentToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "percentToWorld");
			TouchManager.NativeFieldInfoPtr_halfPercentToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "halfPercentToWorld");
			TouchManager.NativeFieldInfoPtr_pixelToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "pixelToWorld");
			TouchManager.NativeFieldInfoPtr_halfPixelToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "halfPixelToWorld");
			TouchManager.NativeFieldInfoPtr_touchControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "touchControls");
			TouchManager.NativeFieldInfoPtr_cachedTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "cachedTouches");
			TouchManager.NativeFieldInfoPtr_activeTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "activeTouches");
			TouchManager.NativeFieldInfoPtr_readOnlyActiveTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "readOnlyActiveTouches");
			TouchManager.NativeFieldInfoPtr_isReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "isReady");
			TouchManager.NativeFieldInfoPtr_mouseTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "mouseTouches");
			TouchManager.NativeMethodInfoPtr_add_OnSetup_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664369);
			TouchManager.NativeMethodInfoPtr_remove_OnSetup_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664370);
			TouchManager.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664371);
			TouchManager.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664372);
			TouchManager.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664373);
			TouchManager.NativeMethodInfoPtr_Setup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664374);
			TouchManager.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664375);
			TouchManager.NativeMethodInfoPtr_UpdateScreenSizeAtEndOfFrame_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664376);
			TouchManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664377);
			TouchManager.NativeMethodInfoPtr_CreateDevice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664378);
			TouchManager.NativeMethodInfoPtr_UpdateDevice_Private_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664379);
			TouchManager.NativeMethodInfoPtr_CommitDevice_Private_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664380);
			TouchManager.NativeMethodInfoPtr_SubmitControlStates_Private_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664381);
			TouchManager.NativeMethodInfoPtr_CommitControlStates_Private_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664382);
			TouchManager.NativeMethodInfoPtr_UpdateScreenSize_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664383);
			TouchManager.NativeMethodInfoPtr_CreateTouches_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664384);
			TouchManager.NativeMethodInfoPtr_UpdateTouches_Private_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664385);
			TouchManager.NativeMethodInfoPtr_SendTouchBegan_Private_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664386);
			TouchManager.NativeMethodInfoPtr_SendTouchMoved_Private_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664387);
			TouchManager.NativeMethodInfoPtr_SendTouchEnded_Private_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664388);
			TouchManager.NativeMethodInfoPtr_InvokeTouchEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664389);
			TouchManager.NativeMethodInfoPtr_TouchCameraIsValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664390);
			TouchManager.NativeMethodInfoPtr_ConvertScreenToWorldPoint_Private_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664391);
			TouchManager.NativeMethodInfoPtr_ConvertViewToWorldPoint_Private_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664392);
			TouchManager.NativeMethodInfoPtr_ConvertScreenToViewPoint_Private_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664393);
			TouchManager.NativeMethodInfoPtr_GetCurrentScreenSize_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664394);
			TouchManager.NativeMethodInfoPtr_get_controlsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664395);
			TouchManager.NativeMethodInfoPtr_set_controlsEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664396);
			TouchManager.NativeMethodInfoPtr_get_Touches_Public_Static_get_ReadOnlyCollection_1_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664397);
			TouchManager.NativeMethodInfoPtr_get_TouchCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664398);
			TouchManager.NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664399);
			TouchManager.NativeMethodInfoPtr_GetTouchByFingerId_Public_Static_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664400);
			TouchManager.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664401);
			TouchManager.NativeMethodInfoPtr_ViewToWorldPoint_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664402);
			TouchManager.NativeMethodInfoPtr_ScreenToViewPoint_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664403);
			TouchManager.NativeMethodInfoPtr_ConvertToWorld_Public_Static_Single_Single_TouchUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664404);
			TouchManager.NativeMethodInfoPtr_PercentToWorldRect_Public_Static_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664405);
			TouchManager.NativeMethodInfoPtr_PixelToWorldRect_Public_Static_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664406);
			TouchManager.NativeMethodInfoPtr_ConvertToWorld_Public_Static_Rect_Rect_TouchUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664407);
			TouchManager.NativeMethodInfoPtr_get_Camera_Public_Static_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664408);
			TouchManager.NativeMethodInfoPtr_get_Device_Public_Static_get_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664409);
			TouchManager.NativeMethodInfoPtr_get_ViewSize_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664410);
			TouchManager.NativeMethodInfoPtr_get_PercentToWorld_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664411);
			TouchManager.NativeMethodInfoPtr_get_HalfPercentToWorld_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664412);
			TouchManager.NativeMethodInfoPtr_get_PixelToWorld_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664413);
			TouchManager.NativeMethodInfoPtr_get_HalfPixelToWorld_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664414);
			TouchManager.NativeMethodInfoPtr_get_ScreenSize_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664415);
			TouchManager.NativeMethodInfoPtr_get_HalfScreenSize_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664416);
			TouchManager.NativeMethodInfoPtr_get_ControlsShowGizmos_Public_Static_get_GizmoShowOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664417);
			TouchManager.NativeMethodInfoPtr_get_ControlsEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664418);
			TouchManager.NativeMethodInfoPtr_set_ControlsEnabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664419);
			TouchManager.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TouchManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, 100664420);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00025A04 File Offset: 0x00023C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785235, XrefRangeEnd = 785242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSetup(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_add_OnSetup_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00025A3C File Offset: 0x00023C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785242, XrefRangeEnd = 785249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSetup(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_remove_OnSetup_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00025A74 File Offset: 0x00023C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785249, XrefRangeEnd = 785259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00025AB0 File Offset: 0x00023CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785259, XrefRangeEnd = 785335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00025AE4 File Offset: 0x00023CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785335, XrefRangeEnd = 785411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00025B18 File Offset: 0x00023D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785411, XrefRangeEnd = 785420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_Setup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00025B4C File Offset: 0x00023D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785420, XrefRangeEnd = 785432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00025B80 File Offset: 0x00023D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785432, XrefRangeEnd = 785437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator UpdateScreenSizeAtEndOfFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_UpdateScreenSizeAtEndOfFrame_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00025BC0 File Offset: 0x00023DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785437, XrefRangeEnd = 785451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00025BF4 File Offset: 0x00023DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 785526, RefRangeEnd = 785527, XrefRangeStart = 785451, XrefRangeEnd = 785526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateDevice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_CreateDevice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00025C28 File Offset: 0x00023E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785527, XrefRangeEnd = 785531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDevice(ulong updateTick, float deltaTime)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_UpdateDevice_Private_Void_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00025C74 File Offset: 0x00023E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785531, XrefRangeEnd = 785534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommitDevice(ulong updateTick, float deltaTime)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_CommitDevice_Private_Void_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00025CC0 File Offset: 0x00023EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785534, XrefRangeEnd = 785537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitControlStates(ulong updateTick, float deltaTime)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_SubmitControlStates_Private_Void_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00025D0C File Offset: 0x00023F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommitControlStates(ulong updateTick, float deltaTime)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_CommitControlStates_Private_Void_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00025D58 File Offset: 0x00023F58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 785547, RefRangeEnd = 785550, XrefRangeStart = 785537, XrefRangeEnd = 785547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScreenSize(Vector2 currentScreenSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentScreenSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_UpdateScreenSize_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00025D98 File Offset: 0x00023F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 785579, RefRangeEnd = 785580, XrefRangeStart = 785550, XrefRangeEnd = 785579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTouches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_CreateTouches_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00025DCC File Offset: 0x00023FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 785642, RefRangeEnd = 785643, XrefRangeStart = 785580, XrefRangeEnd = 785642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTouches(ulong updateTick, float deltaTime)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_UpdateTouches_Private_Void_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00025E18 File Offset: 0x00024018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 785646, RefRangeEnd = 785648, XrefRangeStart = 785643, XrefRangeEnd = 785646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTouchBegan(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_SendTouchBegan_Private_Void_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00025E5C File Offset: 0x0002405C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 785651, RefRangeEnd = 785653, XrefRangeStart = 785648, XrefRangeEnd = 785651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTouchMoved(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_SendTouchMoved_Private_Void_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00025EA0 File Offset: 0x000240A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 785656, RefRangeEnd = 785658, XrefRangeStart = 785653, XrefRangeEnd = 785656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTouchEnded(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_SendTouchEnded_Private_Void_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00025EE4 File Offset: 0x000240E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785658, XrefRangeEnd = 785671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeTouchEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_InvokeTouchEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00025F18 File Offset: 0x00024118
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 785696, RefRangeEnd = 785702, XrefRangeStart = 785671, XrefRangeEnd = 785696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TouchCameraIsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_TouchCameraIsValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00025F54 File Offset: 0x00024154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785702, XrefRangeEnd = 785705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ConvertScreenToWorldPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_ConvertScreenToWorldPoint_Private_Vector3_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00025FA0 File Offset: 0x000241A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 785708, RefRangeEnd = 785711, XrefRangeStart = 785705, XrefRangeEnd = 785708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ConvertViewToWorldPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_ConvertViewToWorldPoint_Private_Vector3_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00025FEC File Offset: 0x000241EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785711, XrefRangeEnd = 785714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ConvertScreenToViewPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_ConvertScreenToViewPoint_Private_Vector3_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00026038 File Offset: 0x00024238
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 785717, RefRangeEnd = 785719, XrefRangeStart = 785714, XrefRangeEnd = 785717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetCurrentScreenSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_GetCurrentScreenSize_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00026074 File Offset: 0x00024274
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x000260B0 File Offset: 0x000242B0
		public unsafe bool controlsEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_get_controlsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 785720, RefRangeEnd = 785723, XrefRangeStart = 785719, XrefRangeEnd = 785720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_set_controlsEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x000260F0 File Offset: 0x000242F0
		public unsafe static ReadOnlyCollection<Touch> Touches
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785723, XrefRangeEnd = 785729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_get_Touches_Public_Static_get_ReadOnlyCollection_1_Touch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Touch>>(intPtr3) : null;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00026124 File Offset: 0x00024324
		public unsafe static int TouchCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 785736, RefRangeEnd = 785738, XrefRangeStart = 785729, XrefRangeEnd = 785736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_get_TouchCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00026154 File Offset: 0x00024354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 785748, RefRangeEnd = 785750, XrefRangeStart = 785738, XrefRangeEnd = 785748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Touch GetTouch(int touchIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Touch>(intPtr3) : null;
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00026194 File Offset: 0x00024394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785750, XrefRangeEnd = 785760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Touch GetTouchByFingerId(int fingerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fingerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_GetTouchByFingerId_Public_Static_Touch_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Touch>(intPtr3) : null;
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000261D4 File Offset: 0x000243D4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 785773, RefRangeEnd = 785784, XrefRangeStart = 785760, XrefRangeEnd = 785773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ScreenToWorldPoint(Vector2 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Static_Vector3_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00026214 File Offset: 0x00024414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785784, XrefRangeEnd = 785791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ViewToWorldPoint(Vector2 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_ViewToWorldPoint_Public_Static_Vector3_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00026254 File Offset: 0x00024454
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 785804, RefRangeEnd = 785806, XrefRangeStart = 785791, XrefRangeEnd = 785804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ScreenToViewPoint(Vector2 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_ScreenToViewPoint_Public_Static_Vector3_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00026294 File Offset: 0x00024494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785806, XrefRangeEnd = 785807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ConvertToWorld(float value, TouchUnitType unitType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unitType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_ConvertToWorld_Public_Static_Single_Single_TouchUnitType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x000262E0 File Offset: 0x000244E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 785831, RefRangeEnd = 785832, XrefRangeStart = 785807, XrefRangeEnd = 785831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect PercentToWorldRect(Rect rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_PercentToWorldRect_Public_Static_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00026320 File Offset: 0x00024520
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 785862, RefRangeEnd = 785866, XrefRangeStart = 785832, XrefRangeEnd = 785862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect PixelToWorldRect(Rect rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_PixelToWorldRect_Public_Static_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00026360 File Offset: 0x00024560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785866, XrefRangeEnd = 785867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect ConvertToWorld(Rect rect, TouchUnitType unitType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unitType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_ConvertToWorld_Public_Static_Rect_Rect_TouchUnitType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x000263AC File Offset: 0x000245AC
		public unsafe static Camera Camera
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785867, XrefRangeEnd = 785873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_get_Camera_Public_Static_get_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x000263E0 File Offset: 0x000245E0
		public unsafe static InputDevice Device
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 785879, RefRangeEnd = 785893, XrefRangeStart = 785873, XrefRangeEnd = 785879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_get_Device_Public_Static_get_InputDevice_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr3) : null;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00026414 File Offset: 0x00024614
		public unsafe static Vector3 ViewSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785893, XrefRangeEnd = 785899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_get_ViewSize_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00026444 File Offset: 0x00024644
		public unsafe static float PercentToWorld
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 785905, RefRangeEnd = 785908, XrefRangeStart = 785899, XrefRangeEnd = 785905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_get_PercentToWorld_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00026474 File Offset: 0x00024674
		public unsafe static float HalfPercentToWorld
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785908, XrefRangeEnd = 785914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_get_HalfPercentToWorld_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x000264A4 File Offset: 0x000246A4
		public unsafe static float PixelToWorld
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 785920, RefRangeEnd = 785925, XrefRangeStart = 785914, XrefRangeEnd = 785920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_get_PixelToWorld_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x000264D4 File Offset: 0x000246D4
		public unsafe static float HalfPixelToWorld
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785925, XrefRangeEnd = 785931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_get_HalfPixelToWorld_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00026504 File Offset: 0x00024704
		public unsafe static Vector2 ScreenSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785931, XrefRangeEnd = 785937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_get_ScreenSize_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x00026534 File Offset: 0x00024734
		public unsafe static Vector2 HalfScreenSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 785943, RefRangeEnd = 785945, XrefRangeStart = 785937, XrefRangeEnd = 785943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_get_HalfScreenSize_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x00026564 File Offset: 0x00024764
		public unsafe static TouchManager.GizmoShowOption ControlsShowGizmos
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 785951, RefRangeEnd = 785954, XrefRangeStart = 785945, XrefRangeEnd = 785951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_get_ControlsShowGizmos_Public_Static_get_GizmoShowOption_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00026594 File Offset: 0x00024794
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x000265C4 File Offset: 0x000247C4
		public unsafe static bool ControlsEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785954, XrefRangeEnd = 785960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_get_ControlsEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 785968, RefRangeEnd = 785969, XrefRangeStart = 785960, XrefRangeEnd = 785968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_set_ControlsEnabled_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x000265F8 File Offset: 0x000247F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785969, XrefRangeEnd = 785973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator bool(TouchManager instance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TouchManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0000560B File Offset: 0x0000380B
		public TouchManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0002663C File Offset: 0x0002483C
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00005614 File Offset: 0x00003814
		public unsafe Camera touchCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_touchCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_touchCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0002666C File Offset: 0x0002486C
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00005633 File Offset: 0x00003833
		public unsafe TouchManager.GizmoShowOption controlsShowGizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_controlsShowGizmos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_controlsShowGizmos)) = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00026694 File Offset: 0x00024894
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x0000564E File Offset: 0x0000384E
		public unsafe bool enableControlsOnTouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_enableControlsOnTouch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_enableControlsOnTouch)) = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x000266BC File Offset: 0x000248BC
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00005669 File Offset: 0x00003869
		public unsafe bool _controlsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr__controlsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr__controlsEnabled)) = value;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x000266E4 File Offset: 0x000248E4
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00005684 File Offset: 0x00003884
		public unsafe int controlsLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_controlsLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_controlsLayer)) = value;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0002670C File Offset: 0x0002490C
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x0000569F File Offset: 0x0000389F
		public unsafe static Action OnSetup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TouchManager.NativeFieldInfoPtr_OnSetup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchManager.NativeFieldInfoPtr_OnSetup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00026734 File Offset: 0x00024934
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x000056B1 File Offset: 0x000038B1
		public unsafe InputDevice device
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_device);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_device), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00026764 File Offset: 0x00024964
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x000056D0 File Offset: 0x000038D0
		public unsafe Vector3 viewSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_viewSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_viewSize)) = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0002678C File Offset: 0x0002498C
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x000056EB File Offset: 0x000038EB
		public unsafe Vector2 screenSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_screenSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_screenSize)) = value;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x000267B4 File Offset: 0x000249B4
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00005706 File Offset: 0x00003906
		public unsafe Vector2 halfScreenSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_halfScreenSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_halfScreenSize)) = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x000267DC File Offset: 0x000249DC
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00005721 File Offset: 0x00003921
		public unsafe float percentToWorld
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_percentToWorld);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_percentToWorld)) = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00026804 File Offset: 0x00024A04
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x0000573C File Offset: 0x0000393C
		public unsafe float halfPercentToWorld
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_halfPercentToWorld);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_halfPercentToWorld)) = value;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x0002682C File Offset: 0x00024A2C
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00005757 File Offset: 0x00003957
		public unsafe float pixelToWorld
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_pixelToWorld);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_pixelToWorld)) = value;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00026854 File Offset: 0x00024A54
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00005772 File Offset: 0x00003972
		public unsafe float halfPixelToWorld
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_halfPixelToWorld);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_halfPixelToWorld)) = value;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0002687C File Offset: 0x00024A7C
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x0000578D File Offset: 0x0000398D
		public unsafe Il2CppReferenceArray<TouchControl> touchControls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_touchControls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TouchControl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_touchControls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x000268AC File Offset: 0x00024AAC
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x000057AC File Offset: 0x000039AC
		public unsafe TouchPool cachedTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_cachedTouches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_cachedTouches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x000268DC File Offset: 0x00024ADC
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x000057CB File Offset: 0x000039CB
		public unsafe List<Touch> activeTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_activeTouches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Touch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_activeTouches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0002690C File Offset: 0x00024B0C
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x000057EA File Offset: 0x000039EA
		public unsafe ReadOnlyCollection<Touch> readOnlyActiveTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_readOnlyActiveTouches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Touch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_readOnlyActiveTouches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0002693C File Offset: 0x00024B3C
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00005809 File Offset: 0x00003A09
		public unsafe bool isReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_isReady);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_isReady)) = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00026964 File Offset: 0x00024B64
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00005824 File Offset: 0x00003A24
		public unsafe Il2CppReferenceArray<Touch> mouseTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_mouseTouches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Touch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager.NativeFieldInfoPtr_mouseTouches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeFieldInfoPtr_touchCamera;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeFieldInfoPtr_controlsShowGizmos;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeFieldInfoPtr_enableControlsOnTouch;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeFieldInfoPtr__controlsEnabled;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeFieldInfoPtr_controlsLayer;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeFieldInfoPtr_OnSetup;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeFieldInfoPtr_device;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeFieldInfoPtr_viewSize;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeFieldInfoPtr_screenSize;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeFieldInfoPtr_halfScreenSize;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeFieldInfoPtr_percentToWorld;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeFieldInfoPtr_halfPercentToWorld;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeFieldInfoPtr_pixelToWorld;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeFieldInfoPtr_halfPixelToWorld;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeFieldInfoPtr_touchControls;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeFieldInfoPtr_cachedTouches;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeFieldInfoPtr_activeTouches;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeFieldInfoPtr_readOnlyActiveTouches;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeFieldInfoPtr_isReady;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeFieldInfoPtr_mouseTouches;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSetup_Public_Static_add_Void_Action_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSetup_Public_Static_rem_Void_Action_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Private_Void_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScreenSizeAtEndOfFrame_Private_IEnumerator_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_CreateDevice_Private_Void_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDevice_Private_Void_UInt64_Single_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_CommitDevice_Private_Void_UInt64_Single_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_SubmitControlStates_Private_Void_UInt64_Single_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_CommitControlStates_Private_Void_UInt64_Single_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScreenSize_Private_Void_Vector2_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_CreateTouches_Private_Void_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTouches_Private_Void_UInt64_Single_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_SendTouchBegan_Private_Void_Touch_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_SendTouchMoved_Private_Void_Touch_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_SendTouchEnded_Private_Void_Touch_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_InvokeTouchEvents_Private_Void_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_TouchCameraIsValid_Private_Boolean_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_ConvertScreenToWorldPoint_Private_Vector3_Vector2_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_ConvertViewToWorldPoint_Private_Vector3_Vector2_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_ConvertScreenToViewPoint_Private_Vector3_Vector2_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentScreenSize_Private_Vector2_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_get_controlsEnabled_Public_get_Boolean_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_set_controlsEnabled_Public_set_Void_Boolean_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_get_Touches_Public_Static_get_ReadOnlyCollection_1_Touch_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_get_TouchCount_Public_Static_get_Int32_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchByFingerId_Public_Static_Touch_Int32_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Static_Vector3_Vector2_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_ViewToWorldPoint_Public_Static_Vector3_Vector2_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToViewPoint_Public_Static_Vector3_Vector2_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToWorld_Public_Static_Single_Single_TouchUnitType_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_PercentToWorldRect_Public_Static_Rect_Rect_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_PixelToWorldRect_Public_Static_Rect_Rect_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToWorld_Public_Static_Rect_Rect_TouchUnitType_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_get_Camera_Public_Static_get_Camera_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_get_Device_Public_Static_get_InputDevice_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_get_ViewSize_Public_Static_get_Vector3_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentToWorld_Public_Static_get_Single_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_get_HalfPercentToWorld_Public_Static_get_Single_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_get_PixelToWorld_Public_Static_get_Single_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_get_HalfPixelToWorld_Public_Static_get_Single_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenSize_Public_Static_get_Vector2_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_get_HalfScreenSize_Public_Static_get_Vector2_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_get_ControlsShowGizmos_Public_Static_get_GizmoShowOption_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_get_ControlsEnabled_Public_Static_get_Boolean_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_set_ControlsEnabled_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TouchManager_0;

		// Token: 0x0200021C RID: 540
		public enum GizmoShowOption
		{
			// Token: 0x04000DE2 RID: 3554
			Never,
			// Token: 0x04000DE3 RID: 3555
			WhenSelected,
			// Token: 0x04000DE4 RID: 3556
			UnlessPlaying,
			// Token: 0x04000DE5 RID: 3557
			Always
		}

		// Token: 0x0200021D RID: 541
		[ObfuscatedName("InControl.TouchManager+<UpdateScreenSizeAtEndOfFrame>d__28")]
		public sealed class _UpdateScreenSizeAtEndOfFrame_d__28 : global::Il2CppSystem.Object
		{
			// Token: 0x060011A7 RID: 4519 RVA: 0x00045580 File Offset: 0x00043780
			// Note: this type is marked as 'beforefieldinit'.
			static _UpdateScreenSizeAtEndOfFrame_d__28()
			{
				Il2CppClassPointerStore<TouchManager._UpdateScreenSizeAtEndOfFrame_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchManager>.NativeClassPtr, "<UpdateScreenSizeAtEndOfFrame>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchManager._UpdateScreenSizeAtEndOfFrame_d__28>.NativeClassPtr);
				TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager._UpdateScreenSizeAtEndOfFrame_d__28>.NativeClassPtr, "<>1__state");
				TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager._UpdateScreenSizeAtEndOfFrame_d__28>.NativeClassPtr, "<>2__current");
				TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchManager._UpdateScreenSizeAtEndOfFrame_d__28>.NativeClassPtr, "<>4__this");
				TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager._UpdateScreenSizeAtEndOfFrame_d__28>.NativeClassPtr, 100664421);
				TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager._UpdateScreenSizeAtEndOfFrame_d__28>.NativeClassPtr, 100664422);
				TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager._UpdateScreenSizeAtEndOfFrame_d__28>.NativeClassPtr, 100664423);
				TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager._UpdateScreenSizeAtEndOfFrame_d__28>.NativeClassPtr, 100664424);
				TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager._UpdateScreenSizeAtEndOfFrame_d__28>.NativeClassPtr, 100664425);
				TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchManager._UpdateScreenSizeAtEndOfFrame_d__28>.NativeClassPtr, 100664426);
			}

			// Token: 0x060011A8 RID: 4520 RVA: 0x00045660 File Offset: 0x00043860
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UpdateScreenSizeAtEndOfFrame_d__28(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchManager._UpdateScreenSizeAtEndOfFrame_d__28>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060011A9 RID: 4521 RVA: 0x000456A8 File Offset: 0x000438A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011AA RID: 4522 RVA: 0x000456DC File Offset: 0x000438DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785229, XrefRangeEnd = 785230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170003DC RID: 988
			// (get) Token: 0x060011AB RID: 4523 RVA: 0x00045718 File Offset: 0x00043918
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060011AC RID: 4524 RVA: 0x00045758 File Offset: 0x00043958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785230, XrefRangeEnd = 785235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003DD RID: 989
			// (get) Token: 0x060011AD RID: 4525 RVA: 0x0004578C File Offset: 0x0004398C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060011AE RID: 4526 RVA: 0x0000719C File Offset: 0x0000539C
			public _UpdateScreenSizeAtEndOfFrame_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003D9 RID: 985
			// (get) Token: 0x060011AF RID: 4527 RVA: 0x000457CC File Offset: 0x000439CC
			// (set) Token: 0x060011B0 RID: 4528 RVA: 0x000071A5 File Offset: 0x000053A5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003DA RID: 986
			// (get) Token: 0x060011B1 RID: 4529 RVA: 0x000457F4 File Offset: 0x000439F4
			// (set) Token: 0x060011B2 RID: 4530 RVA: 0x000071C0 File Offset: 0x000053C0
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003DB RID: 987
			// (get) Token: 0x060011B3 RID: 4531 RVA: 0x00045824 File Offset: 0x00043A24
			// (set) Token: 0x060011B4 RID: 4532 RVA: 0x000071DF File Offset: 0x000053DF
			public unsafe TouchManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchManager._UpdateScreenSizeAtEndOfFrame_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DE6 RID: 3558
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000DE7 RID: 3559
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000DE8 RID: 3560
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000DE9 RID: 3561
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000DEA RID: 3562
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000DEB RID: 3563
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000DEC RID: 3564
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000DED RID: 3565
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000DEE RID: 3566
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
