using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000054 RID: 84
	public class TouchControl : MonoBehaviour
	{
		// Token: 0x0600084B RID: 2123 RVA: 0x00024AD0 File Offset: 0x00022CD0
		// Note: this type is marked as 'beforefieldinit'.
		static TouchControl()
		{
			Il2CppClassPointerStore<TouchControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "TouchControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchControl>.NativeClassPtr);
			TouchControl.NativeMethodInfoPtr_CreateControl_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664344);
			TouchControl.NativeMethodInfoPtr_DestroyControl_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664345);
			TouchControl.NativeMethodInfoPtr_ConfigureControl_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664346);
			TouchControl.NativeMethodInfoPtr_SubmitControlState_Public_Abstract_Virtual_New_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664347);
			TouchControl.NativeMethodInfoPtr_CommitControlState_Public_Abstract_Virtual_New_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664348);
			TouchControl.NativeMethodInfoPtr_TouchBegan_Public_Abstract_Virtual_New_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664349);
			TouchControl.NativeMethodInfoPtr_TouchMoved_Public_Abstract_Virtual_New_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664350);
			TouchControl.NativeMethodInfoPtr_TouchEnded_Public_Abstract_Virtual_New_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664351);
			TouchControl.NativeMethodInfoPtr_DrawGizmos_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664352);
			TouchControl.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664353);
			TouchControl.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664354);
			TouchControl.NativeMethodInfoPtr_Setup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664355);
			TouchControl.NativeMethodInfoPtr_OffsetToWorldPosition_Protected_Vector3_TouchControlAnchor_Vector2_TouchUnitType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664356);
			TouchControl.NativeMethodInfoPtr_SubmitButtonState_Protected_Void_ButtonTarget_Boolean_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664357);
			TouchControl.NativeMethodInfoPtr_SubmitButtonValue_Protected_Void_ButtonTarget_Single_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664358);
			TouchControl.NativeMethodInfoPtr_CommitButton_Protected_Void_ButtonTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664359);
			TouchControl.NativeMethodInfoPtr_SubmitAnalogValue_Protected_Void_AnalogTarget_Vector2_Single_Single_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664360);
			TouchControl.NativeMethodInfoPtr_CommitAnalog_Protected_Void_AnalogTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664361);
			TouchControl.NativeMethodInfoPtr_SubmitRawAnalogValue_Protected_Void_AnalogTarget_Vector2_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664362);
			TouchControl.NativeMethodInfoPtr_SnapTo_Protected_Static_Vector3_Vector2_SnapAngles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664363);
			TouchControl.NativeMethodInfoPtr_SnapTo_Protected_Static_Vector3_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664364);
			TouchControl.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664365);
			TouchControl.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664366);
			TouchControl.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664367);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00024CE0 File Offset: 0x00022EE0
		[CallerCount(0)]
		public unsafe virtual void CreateControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_CreateControl_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00024D1C File Offset: 0x00022F1C
		[CallerCount(0)]
		public unsafe virtual void DestroyControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_DestroyControl_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00024D58 File Offset: 0x00022F58
		[CallerCount(0)]
		public unsafe virtual void ConfigureControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_ConfigureControl_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00024D94 File Offset: 0x00022F94
		[CallerCount(0)]
		public unsafe virtual void SubmitControlState(ulong updateTick, float deltaTime)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_SubmitControlState_Public_Abstract_Virtual_New_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00024DEC File Offset: 0x00022FEC
		[CallerCount(0)]
		public unsafe virtual void CommitControlState(ulong updateTick, float deltaTime)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_CommitControlState_Public_Abstract_Virtual_New_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00024E44 File Offset: 0x00023044
		[CallerCount(0)]
		public unsafe virtual void TouchBegan(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_TouchBegan_Public_Abstract_Virtual_New_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00024E94 File Offset: 0x00023094
		[CallerCount(0)]
		public unsafe virtual void TouchMoved(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_TouchMoved_Public_Abstract_Virtual_New_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00024EE4 File Offset: 0x000230E4
		[CallerCount(0)]
		public unsafe virtual void TouchEnded(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_TouchEnded_Public_Abstract_Virtual_New_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00024F34 File Offset: 0x00023134
		[CallerCount(0)]
		public unsafe virtual void DrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_DrawGizmos_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00024F70 File Offset: 0x00023170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785043, XrefRangeEnd = 785056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00024FA4 File Offset: 0x000231A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785056, XrefRangeEnd = 785057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00024FD8 File Offset: 0x000231D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785057, XrefRangeEnd = 785058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_Setup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0002500C File Offset: 0x0002320C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 785088, RefRangeEnd = 785090, XrefRangeStart = 785058, XrefRangeEnd = 785088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 OffsetToWorldPosition(TouchControlAnchor anchor, Vector2 offset, TouchUnitType offsetUnitType, bool lockAspectRatio)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref anchor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetUnitType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockAspectRatio;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_OffsetToWorldPosition_Protected_Vector3_TouchControlAnchor_Vector2_TouchUnitType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00025080 File Offset: 0x00023280
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 785103, RefRangeEnd = 785110, XrefRangeStart = 785090, XrefRangeEnd = 785103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitButtonState(TouchControl.ButtonTarget target, bool state, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_SubmitButtonState_Protected_Void_ButtonTarget_Boolean_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000250E8 File Offset: 0x000232E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785110, XrefRangeEnd = 785123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitButtonValue(TouchControl.ButtonTarget target, float value, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_SubmitButtonValue_Protected_Void_ButtonTarget_Single_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00025150 File Offset: 0x00023350
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 785136, RefRangeEnd = 785143, XrefRangeStart = 785123, XrefRangeEnd = 785136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommitButton(TouchControl.ButtonTarget target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_CommitButton_Protected_Void_ButtonTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00025190 File Offset: 0x00023390
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 785154, RefRangeEnd = 785156, XrefRangeStart = 785143, XrefRangeEnd = 785154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitAnalogValue(TouchControl.AnalogTarget target, Vector2 value, float lowerDeadZone, float upperDeadZone, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerDeadZone;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upperDeadZone;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_SubmitAnalogValue_Protected_Void_AnalogTarget_Vector2_Single_Single_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00025214 File Offset: 0x00023414
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 785166, RefRangeEnd = 785169, XrefRangeStart = 785156, XrefRangeEnd = 785166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommitAnalog(TouchControl.AnalogTarget target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_CommitAnalog_Protected_Void_AnalogTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00025254 File Offset: 0x00023454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785169, XrefRangeEnd = 785179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitRawAnalogValue(TouchControl.AnalogTarget target, Vector2 rawValue, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rawValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_SubmitRawAnalogValue_Protected_Void_AnalogTarget_Vector2_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000252BC File Offset: 0x000234BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785179, XrefRangeEnd = 785180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SnapTo(Vector2 vector, TouchControl.SnapAngles snapAngles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapAngles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_SnapTo_Protected_Static_Vector3_Vector2_SnapAngles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00025308 File Offset: 0x00023508
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 785203, RefRangeEnd = 785207, XrefRangeStart = 785180, XrefRangeEnd = 785203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SnapTo(Vector2 vector, float snapAngle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_SnapTo_Protected_Static_Vector3_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00025354 File Offset: 0x00023554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785207, XrefRangeEnd = 785218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00025388 File Offset: 0x00023588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785218, XrefRangeEnd = 785223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000253BC File Offset: 0x000235BC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000055C0 File Offset: 0x000037C0
		public TouchControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_CreateControl_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_DestroyControl_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureControl_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_SubmitControlState_Public_Abstract_Virtual_New_Void_UInt64_Single_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_CommitControlState_Public_Abstract_Virtual_New_Void_UInt64_Single_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_TouchBegan_Public_Abstract_Virtual_New_Void_Touch_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_TouchMoved_Public_Abstract_Virtual_New_Void_Touch_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_TouchEnded_Public_Abstract_Virtual_New_Void_Touch_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_DrawGizmos_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Private_Void_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_OffsetToWorldPosition_Protected_Vector3_TouchControlAnchor_Vector2_TouchUnitType_Boolean_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_SubmitButtonState_Protected_Void_ButtonTarget_Boolean_UInt64_Single_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_SubmitButtonValue_Protected_Void_ButtonTarget_Single_UInt64_Single_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_CommitButton_Protected_Void_ButtonTarget_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_SubmitAnalogValue_Protected_Void_AnalogTarget_Vector2_Single_Single_UInt64_Single_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_CommitAnalog_Protected_Void_AnalogTarget_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_SubmitRawAnalogValue_Protected_Void_AnalogTarget_Vector2_UInt64_Single_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_SnapTo_Protected_Static_Vector3_Vector2_SnapAngles_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_SnapTo_Protected_Static_Vector3_Vector2_Single_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000219 RID: 537
		public enum ButtonTarget
		{
			// Token: 0x04000DAD RID: 3501
			None,
			// Token: 0x04000DAE RID: 3502
			DPadDown = 12,
			// Token: 0x04000DAF RID: 3503
			DPadLeft,
			// Token: 0x04000DB0 RID: 3504
			DPadRight,
			// Token: 0x04000DB1 RID: 3505
			DPadUp = 11,
			// Token: 0x04000DB2 RID: 3506
			LeftTrigger = 15,
			// Token: 0x04000DB3 RID: 3507
			RightTrigger,
			// Token: 0x04000DB4 RID: 3508
			LeftBumper,
			// Token: 0x04000DB5 RID: 3509
			RightBumper,
			// Token: 0x04000DB6 RID: 3510
			Action1,
			// Token: 0x04000DB7 RID: 3511
			Action2,
			// Token: 0x04000DB8 RID: 3512
			Action3,
			// Token: 0x04000DB9 RID: 3513
			Action4,
			// Token: 0x04000DBA RID: 3514
			Action5,
			// Token: 0x04000DBB RID: 3515
			Action6,
			// Token: 0x04000DBC RID: 3516
			Action7,
			// Token: 0x04000DBD RID: 3517
			Action8,
			// Token: 0x04000DBE RID: 3518
			Action9,
			// Token: 0x04000DBF RID: 3519
			Action10,
			// Token: 0x04000DC0 RID: 3520
			Action11,
			// Token: 0x04000DC1 RID: 3521
			Action12,
			// Token: 0x04000DC2 RID: 3522
			Menu = 106,
			// Token: 0x04000DC3 RID: 3523
			Button0 = 500,
			// Token: 0x04000DC4 RID: 3524
			Button1,
			// Token: 0x04000DC5 RID: 3525
			Button2,
			// Token: 0x04000DC6 RID: 3526
			Button3,
			// Token: 0x04000DC7 RID: 3527
			Button4,
			// Token: 0x04000DC8 RID: 3528
			Button5,
			// Token: 0x04000DC9 RID: 3529
			Button6,
			// Token: 0x04000DCA RID: 3530
			Button7,
			// Token: 0x04000DCB RID: 3531
			Button8,
			// Token: 0x04000DCC RID: 3532
			Button9,
			// Token: 0x04000DCD RID: 3533
			Button10,
			// Token: 0x04000DCE RID: 3534
			Button11,
			// Token: 0x04000DCF RID: 3535
			Button12,
			// Token: 0x04000DD0 RID: 3536
			Button13,
			// Token: 0x04000DD1 RID: 3537
			Button14,
			// Token: 0x04000DD2 RID: 3538
			Button15,
			// Token: 0x04000DD3 RID: 3539
			Button16,
			// Token: 0x04000DD4 RID: 3540
			Button17,
			// Token: 0x04000DD5 RID: 3541
			Button18,
			// Token: 0x04000DD6 RID: 3542
			Button19
		}

		// Token: 0x0200021A RID: 538
		public enum AnalogTarget
		{
			// Token: 0x04000DD8 RID: 3544
			None,
			// Token: 0x04000DD9 RID: 3545
			LeftStick,
			// Token: 0x04000DDA RID: 3546
			RightStick,
			// Token: 0x04000DDB RID: 3547
			Both
		}

		// Token: 0x0200021B RID: 539
		public enum SnapAngles
		{
			// Token: 0x04000DDD RID: 3549
			None,
			// Token: 0x04000DDE RID: 3550
			Four = 4,
			// Token: 0x04000DDF RID: 3551
			Eight = 8,
			// Token: 0x04000DE0 RID: 3552
			Sixteen = 16
		}
	}
}
