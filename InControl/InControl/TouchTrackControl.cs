using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000052 RID: 82
	public class TouchTrackControl : TouchControl
	{
		// Token: 0x060007EC RID: 2028 RVA: 0x00023AA8 File Offset: 0x00021CA8
		// Note: this type is marked as 'beforefieldinit'.
		static TouchTrackControl()
		{
			Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "TouchTrackControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr);
			TouchTrackControl.NativeFieldInfoPtr_areaUnitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "areaUnitType");
			TouchTrackControl.NativeFieldInfoPtr_activeArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "activeArea");
			TouchTrackControl.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "target");
			TouchTrackControl.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "scale");
			TouchTrackControl.NativeFieldInfoPtr_tapTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "tapTarget");
			TouchTrackControl.NativeFieldInfoPtr_maxTapDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "maxTapDuration");
			TouchTrackControl.NativeFieldInfoPtr_maxTapMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "maxTapMovement");
			TouchTrackControl.NativeFieldInfoPtr_worldActiveArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "worldActiveArea");
			TouchTrackControl.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "lastPosition");
			TouchTrackControl.NativeFieldInfoPtr_thisPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "thisPosition");
			TouchTrackControl.NativeFieldInfoPtr_currentTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "currentTouch");
			TouchTrackControl.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "dirty");
			TouchTrackControl.NativeFieldInfoPtr_fireButtonTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "fireButtonTarget");
			TouchTrackControl.NativeFieldInfoPtr_beganTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "beganTime");
			TouchTrackControl.NativeFieldInfoPtr_beganPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, "beganPosition");
			TouchTrackControl.NativeMethodInfoPtr_CreateControl_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664321);
			TouchTrackControl.NativeMethodInfoPtr_DestroyControl_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664322);
			TouchTrackControl.NativeMethodInfoPtr_ConfigureControl_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664323);
			TouchTrackControl.NativeMethodInfoPtr_DrawGizmos_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664324);
			TouchTrackControl.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664325);
			TouchTrackControl.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664326);
			TouchTrackControl.NativeMethodInfoPtr_SubmitControlState_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664327);
			TouchTrackControl.NativeMethodInfoPtr_CommitControlState_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664328);
			TouchTrackControl.NativeMethodInfoPtr_TouchBegan_Public_Virtual_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664329);
			TouchTrackControl.NativeMethodInfoPtr_TouchMoved_Public_Virtual_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664330);
			TouchTrackControl.NativeMethodInfoPtr_TouchEnded_Public_Virtual_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664331);
			TouchTrackControl.NativeMethodInfoPtr_get_ActiveArea_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664332);
			TouchTrackControl.NativeMethodInfoPtr_set_ActiveArea_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664333);
			TouchTrackControl.NativeMethodInfoPtr_get_AreaUnitType_Public_get_TouchUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664334);
			TouchTrackControl.NativeMethodInfoPtr_set_AreaUnitType_Public_set_Void_TouchUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664335);
			TouchTrackControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr, 100664336);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00023D44 File Offset: 0x00021F44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312313, RefRangeEnd = 312315, XrefRangeStart = 312313, XrefRangeEnd = 312315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchTrackControl.NativeMethodInfoPtr_CreateControl_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00023D80 File Offset: 0x00021F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784957, XrefRangeEnd = 784958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchTrackControl.NativeMethodInfoPtr_DestroyControl_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00023DBC File Offset: 0x00021FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784958, XrefRangeEnd = 784959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConfigureControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchTrackControl.NativeMethodInfoPtr_ConfigureControl_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00023DF8 File Offset: 0x00021FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784959, XrefRangeEnd = 784963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchTrackControl.NativeMethodInfoPtr_DrawGizmos_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00023E34 File Offset: 0x00022034
		[CallerCount(0)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchTrackControl.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00023E68 File Offset: 0x00022068
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchTrackControl.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00023E9C File Offset: 0x0002209C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784963, XrefRangeEnd = 784974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchTrackControl.NativeMethodInfoPtr_SubmitControlState_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00023EF4 File Offset: 0x000220F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784974, XrefRangeEnd = 784976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchTrackControl.NativeMethodInfoPtr_CommitControlState_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00023F4C File Offset: 0x0002214C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784976, XrefRangeEnd = 784980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TouchBegan(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchTrackControl.NativeMethodInfoPtr_TouchBegan_Public_Virtual_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00023F9C File Offset: 0x0002219C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784980, XrefRangeEnd = 784981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TouchMoved(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchTrackControl.NativeMethodInfoPtr_TouchMoved_Public_Virtual_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00023FEC File Offset: 0x000221EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784981, XrefRangeEnd = 784989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TouchEnded(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchTrackControl.NativeMethodInfoPtr_TouchEnded_Public_Virtual_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0002403C File Offset: 0x0002223C
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00024078 File Offset: 0x00022278
		public unsafe Rect ActiveArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchTrackControl.NativeMethodInfoPtr_get_ActiveArea_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchTrackControl.NativeMethodInfoPtr_set_ActiveArea_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000240B8 File Offset: 0x000222B8
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x000240F4 File Offset: 0x000222F4
		public unsafe TouchUnitType AreaUnitType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchTrackControl.NativeMethodInfoPtr_get_AreaUnitType_Public_get_TouchUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchTrackControl.NativeMethodInfoPtr_set_AreaUnitType_Public_set_Void_TouchUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00024134 File Offset: 0x00022334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784989, XrefRangeEnd = 784990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchTrackControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchTrackControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchTrackControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0000522E File Offset: 0x0000342E
		public TouchTrackControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00024170 File Offset: 0x00022370
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x00005237 File Offset: 0x00003437
		public unsafe TouchUnitType areaUnitType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_areaUnitType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_areaUnitType)) = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00024198 File Offset: 0x00022398
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00005252 File Offset: 0x00003452
		public unsafe Rect activeArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_activeArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_activeArea)) = value;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x000241C0 File Offset: 0x000223C0
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x0000526D File Offset: 0x0000346D
		public unsafe TouchControl.AnalogTarget target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_target);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_target)) = value;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x000241E8 File Offset: 0x000223E8
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00005288 File Offset: 0x00003488
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00024210 File Offset: 0x00022410
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x000052A3 File Offset: 0x000034A3
		public unsafe TouchControl.ButtonTarget tapTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_tapTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_tapTarget)) = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00024238 File Offset: 0x00022438
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x000052BE File Offset: 0x000034BE
		public unsafe float maxTapDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_maxTapDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_maxTapDuration)) = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00024260 File Offset: 0x00022460
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x000052D9 File Offset: 0x000034D9
		public unsafe float maxTapMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_maxTapMovement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_maxTapMovement)) = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00024288 File Offset: 0x00022488
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x000052F4 File Offset: 0x000034F4
		public unsafe Rect worldActiveArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_worldActiveArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_worldActiveArea)) = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x000242B0 File Offset: 0x000224B0
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x0000530F File Offset: 0x0000350F
		public unsafe Vector3 lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x000242D8 File Offset: 0x000224D8
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x0000532A File Offset: 0x0000352A
		public unsafe Vector3 thisPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_thisPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_thisPosition)) = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00024300 File Offset: 0x00022500
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x00005345 File Offset: 0x00003545
		public unsafe Touch currentTouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_currentTouch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Touch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_currentTouch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00024330 File Offset: 0x00022530
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x00005364 File Offset: 0x00003564
		public unsafe bool dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_dirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_dirty)) = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00024358 File Offset: 0x00022558
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x0000537F File Offset: 0x0000357F
		public unsafe bool fireButtonTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_fireButtonTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_fireButtonTarget)) = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00024380 File Offset: 0x00022580
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x0000539A File Offset: 0x0000359A
		public unsafe float beganTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_beganTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_beganTime)) = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x000243A8 File Offset: 0x000225A8
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x000053B5 File Offset: 0x000035B5
		public unsafe Vector3 beganPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_beganPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchTrackControl.NativeFieldInfoPtr_beganPosition)) = value;
			}
		}

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeFieldInfoPtr_areaUnitType;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeFieldInfoPtr_activeArea;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeFieldInfoPtr_tapTarget;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeFieldInfoPtr_maxTapDuration;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeFieldInfoPtr_maxTapMovement;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeFieldInfoPtr_worldActiveArea;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeFieldInfoPtr_thisPosition;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeFieldInfoPtr_currentTouch;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeFieldInfoPtr_dirty;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeFieldInfoPtr_fireButtonTarget;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeFieldInfoPtr_beganTime;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeFieldInfoPtr_beganPosition;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_CreateControl_Public_Virtual_Void_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_DestroyControl_Public_Virtual_Void_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureControl_Public_Virtual_Void_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_DrawGizmos_Public_Virtual_Void_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_SubmitControlState_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_CommitControlState_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_TouchBegan_Public_Virtual_Void_Touch_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_TouchMoved_Public_Virtual_Void_Touch_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_TouchEnded_Public_Virtual_Void_Touch_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveArea_Public_get_Rect_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveArea_Public_set_Void_Rect_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_get_AreaUnitType_Public_get_TouchUnitType_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_set_AreaUnitType_Public_set_Void_TouchUnitType_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
