using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000051 RID: 81
	public class TouchSwipeControl : TouchControl
	{
		// Token: 0x060007B0 RID: 1968 RVA: 0x00023000 File Offset: 0x00021200
		// Note: this type is marked as 'beforefieldinit'.
		static TouchSwipeControl()
		{
			Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "TouchSwipeControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr);
			TouchSwipeControl.NativeFieldInfoPtr_areaUnitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "areaUnitType");
			TouchSwipeControl.NativeFieldInfoPtr_activeArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "activeArea");
			TouchSwipeControl.NativeFieldInfoPtr_sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "sensitivity");
			TouchSwipeControl.NativeFieldInfoPtr_oneSwipePerTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "oneSwipePerTouch");
			TouchSwipeControl.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "target");
			TouchSwipeControl.NativeFieldInfoPtr_snapAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "snapAngles");
			TouchSwipeControl.NativeFieldInfoPtr_upTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "upTarget");
			TouchSwipeControl.NativeFieldInfoPtr_downTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "downTarget");
			TouchSwipeControl.NativeFieldInfoPtr_leftTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "leftTarget");
			TouchSwipeControl.NativeFieldInfoPtr_rightTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "rightTarget");
			TouchSwipeControl.NativeFieldInfoPtr_tapTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "tapTarget");
			TouchSwipeControl.NativeFieldInfoPtr_worldActiveArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "worldActiveArea");
			TouchSwipeControl.NativeFieldInfoPtr_currentVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "currentVector");
			TouchSwipeControl.NativeFieldInfoPtr_currentVectorIsSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "currentVectorIsSet");
			TouchSwipeControl.NativeFieldInfoPtr_beganPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "beganPosition");
			TouchSwipeControl.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "lastPosition");
			TouchSwipeControl.NativeFieldInfoPtr_currentTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "currentTouch");
			TouchSwipeControl.NativeFieldInfoPtr_fireButtonTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "fireButtonTarget");
			TouchSwipeControl.NativeFieldInfoPtr_nextButtonTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "nextButtonTarget");
			TouchSwipeControl.NativeFieldInfoPtr_lastButtonTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "lastButtonTarget");
			TouchSwipeControl.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, "dirty");
			TouchSwipeControl.NativeMethodInfoPtr_CreateControl_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664305);
			TouchSwipeControl.NativeMethodInfoPtr_DestroyControl_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664306);
			TouchSwipeControl.NativeMethodInfoPtr_ConfigureControl_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664307);
			TouchSwipeControl.NativeMethodInfoPtr_DrawGizmos_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664308);
			TouchSwipeControl.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664309);
			TouchSwipeControl.NativeMethodInfoPtr_SubmitControlState_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664310);
			TouchSwipeControl.NativeMethodInfoPtr_CommitControlState_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664311);
			TouchSwipeControl.NativeMethodInfoPtr_TouchBegan_Public_Virtual_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664312);
			TouchSwipeControl.NativeMethodInfoPtr_TouchMoved_Public_Virtual_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664313);
			TouchSwipeControl.NativeMethodInfoPtr_TouchEnded_Public_Virtual_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664314);
			TouchSwipeControl.NativeMethodInfoPtr_GetButtonTargetForVector_Private_ButtonTarget_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664315);
			TouchSwipeControl.NativeMethodInfoPtr_get_ActiveArea_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664316);
			TouchSwipeControl.NativeMethodInfoPtr_set_ActiveArea_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664317);
			TouchSwipeControl.NativeMethodInfoPtr_get_AreaUnitType_Public_get_TouchUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664318);
			TouchSwipeControl.NativeMethodInfoPtr_set_AreaUnitType_Public_set_Void_TouchUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664319);
			TouchSwipeControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr, 100664320);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00023314 File Offset: 0x00021514
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchSwipeControl.NativeMethodInfoPtr_CreateControl_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00023350 File Offset: 0x00021550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784909, XrefRangeEnd = 784910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchSwipeControl.NativeMethodInfoPtr_DestroyControl_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0002338C File Offset: 0x0002158C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784910, XrefRangeEnd = 784911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConfigureControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchSwipeControl.NativeMethodInfoPtr_ConfigureControl_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000233C8 File Offset: 0x000215C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784911, XrefRangeEnd = 784915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchSwipeControl.NativeMethodInfoPtr_DrawGizmos_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00023404 File Offset: 0x00021604
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSwipeControl.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00023438 File Offset: 0x00021638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784915, XrefRangeEnd = 784928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchSwipeControl.NativeMethodInfoPtr_SubmitControlState_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00023490 File Offset: 0x00021690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784928, XrefRangeEnd = 784934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchSwipeControl.NativeMethodInfoPtr_CommitControlState_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000234E8 File Offset: 0x000216E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784934, XrefRangeEnd = 784938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TouchBegan(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchSwipeControl.NativeMethodInfoPtr_TouchBegan_Public_Virtual_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00023538 File Offset: 0x00021738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784938, XrefRangeEnd = 784942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TouchMoved(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchSwipeControl.NativeMethodInfoPtr_TouchMoved_Public_Virtual_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00023588 File Offset: 0x00021788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784942, XrefRangeEnd = 784947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TouchEnded(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchSwipeControl.NativeMethodInfoPtr_TouchEnded_Public_Virtual_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000235D8 File Offset: 0x000217D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 784955, RefRangeEnd = 784956, XrefRangeStart = 784947, XrefRangeEnd = 784955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchControl.ButtonTarget GetButtonTargetForVector(Vector2 vector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSwipeControl.NativeMethodInfoPtr_GetButtonTargetForVector_Private_ButtonTarget_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00023624 File Offset: 0x00021824
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x00023660 File Offset: 0x00021860
		public unsafe Rect ActiveArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSwipeControl.NativeMethodInfoPtr_get_ActiveArea_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSwipeControl.NativeMethodInfoPtr_set_ActiveArea_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x000236A0 File Offset: 0x000218A0
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x000236DC File Offset: 0x000218DC
		public unsafe TouchUnitType AreaUnitType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSwipeControl.NativeMethodInfoPtr_get_AreaUnitType_Public_get_TouchUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSwipeControl.NativeMethodInfoPtr_set_AreaUnitType_Public_set_Void_TouchUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0002371C File Offset: 0x0002191C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784956, XrefRangeEnd = 784957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchSwipeControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchSwipeControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSwipeControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00004FEA File Offset: 0x000031EA
		public TouchSwipeControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00023758 File Offset: 0x00021958
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x00004FF3 File Offset: 0x000031F3
		public unsafe TouchUnitType areaUnitType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_areaUnitType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_areaUnitType)) = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00023780 File Offset: 0x00021980
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x0000500E File Offset: 0x0000320E
		public unsafe Rect activeArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_activeArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_activeArea)) = value;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x000237A8 File Offset: 0x000219A8
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00005029 File Offset: 0x00003229
		public unsafe float sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_sensitivity)) = value;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x000237D0 File Offset: 0x000219D0
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00005044 File Offset: 0x00003244
		public unsafe bool oneSwipePerTouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_oneSwipePerTouch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_oneSwipePerTouch)) = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x000237F8 File Offset: 0x000219F8
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x0000505F File Offset: 0x0000325F
		public unsafe TouchControl.AnalogTarget target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_target);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_target)) = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00023820 File Offset: 0x00021A20
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x0000507A File Offset: 0x0000327A
		public unsafe TouchControl.SnapAngles snapAngles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_snapAngles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_snapAngles)) = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x00023848 File Offset: 0x00021A48
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x00005095 File Offset: 0x00003295
		public unsafe TouchControl.ButtonTarget upTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_upTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_upTarget)) = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00023870 File Offset: 0x00021A70
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x000050B0 File Offset: 0x000032B0
		public unsafe TouchControl.ButtonTarget downTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_downTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_downTarget)) = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00023898 File Offset: 0x00021A98
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x000050CB File Offset: 0x000032CB
		public unsafe TouchControl.ButtonTarget leftTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_leftTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_leftTarget)) = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x000238C0 File Offset: 0x00021AC0
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x000050E6 File Offset: 0x000032E6
		public unsafe TouchControl.ButtonTarget rightTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_rightTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_rightTarget)) = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x000238E8 File Offset: 0x00021AE8
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x00005101 File Offset: 0x00003301
		public unsafe TouchControl.ButtonTarget tapTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_tapTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_tapTarget)) = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00023910 File Offset: 0x00021B10
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x0000511C File Offset: 0x0000331C
		public unsafe Rect worldActiveArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_worldActiveArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_worldActiveArea)) = value;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00023938 File Offset: 0x00021B38
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x00005137 File Offset: 0x00003337
		public unsafe Vector3 currentVector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_currentVector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_currentVector)) = value;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x00023960 File Offset: 0x00021B60
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x00005152 File Offset: 0x00003352
		public unsafe bool currentVectorIsSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_currentVectorIsSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_currentVectorIsSet)) = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x00023988 File Offset: 0x00021B88
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x0000516D File Offset: 0x0000336D
		public unsafe Vector3 beganPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_beganPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_beganPosition)) = value;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x000239B0 File Offset: 0x00021BB0
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00005188 File Offset: 0x00003388
		public unsafe Vector3 lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x000239D8 File Offset: 0x00021BD8
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x000051A3 File Offset: 0x000033A3
		public unsafe Touch currentTouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_currentTouch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Touch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_currentTouch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00023A08 File Offset: 0x00021C08
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x000051C2 File Offset: 0x000033C2
		public unsafe bool fireButtonTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_fireButtonTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_fireButtonTarget)) = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00023A30 File Offset: 0x00021C30
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x000051DD File Offset: 0x000033DD
		public unsafe TouchControl.ButtonTarget nextButtonTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_nextButtonTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_nextButtonTarget)) = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00023A58 File Offset: 0x00021C58
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x000051F8 File Offset: 0x000033F8
		public unsafe TouchControl.ButtonTarget lastButtonTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_lastButtonTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_lastButtonTarget)) = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00023A80 File Offset: 0x00021C80
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00005213 File Offset: 0x00003413
		public unsafe bool dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_dirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSwipeControl.NativeFieldInfoPtr_dirty)) = value;
			}
		}

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeFieldInfoPtr_areaUnitType;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeFieldInfoPtr_activeArea;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeFieldInfoPtr_sensitivity;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeFieldInfoPtr_oneSwipePerTouch;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeFieldInfoPtr_snapAngles;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeFieldInfoPtr_upTarget;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeFieldInfoPtr_downTarget;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeFieldInfoPtr_leftTarget;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeFieldInfoPtr_rightTarget;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeFieldInfoPtr_tapTarget;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeFieldInfoPtr_worldActiveArea;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeFieldInfoPtr_currentVector;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeFieldInfoPtr_currentVectorIsSet;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeFieldInfoPtr_beganPosition;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeFieldInfoPtr_currentTouch;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeFieldInfoPtr_fireButtonTarget;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeFieldInfoPtr_nextButtonTarget;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeFieldInfoPtr_lastButtonTarget;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_dirty;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_CreateControl_Public_Virtual_Void_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_DestroyControl_Public_Virtual_Void_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureControl_Public_Virtual_Void_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_DrawGizmos_Public_Virtual_Void_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_SubmitControlState_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_CommitControlState_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_TouchBegan_Public_Virtual_Void_Touch_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_TouchMoved_Public_Virtual_Void_Touch_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_TouchEnded_Public_Virtual_Void_Touch_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonTargetForVector_Private_ButtonTarget_Vector2_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveArea_Public_get_Rect_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveArea_Public_set_Void_Rect_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_get_AreaUnitType_Public_get_TouchUnitType_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_set_AreaUnitType_Public_set_Void_TouchUnitType_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
