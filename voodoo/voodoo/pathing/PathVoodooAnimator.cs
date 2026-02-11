using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace voodoo.pathing
{
	// Token: 0x02000033 RID: 51
	public class PathVoodooAnimator : MonoBehaviour
	{
		// Token: 0x0600029A RID: 666 RVA: 0x0001166C File Offset: 0x0000F86C
		// Note: this type is marked as 'beforefieldinit'.
		static PathVoodooAnimator()
		{
			Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.pathing", "PathVoodooAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr);
			PathVoodooAnimator.NativeFieldInfoPtr_pathVoodoo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "pathVoodoo");
			PathVoodooAnimator.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "target");
			PathVoodooAnimator.NativeFieldInfoPtr_updateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "updateMode");
			PathVoodooAnimator.NativeFieldInfoPtr_autoStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "autoStart");
			PathVoodooAnimator.NativeFieldInfoPtr_velocityBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "velocityBias");
			PathVoodooAnimator.NativeFieldInfoPtr_currentPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "currentPos");
			PathVoodooAnimator.NativeFieldInfoPtr_isPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "isPlaying");
			PathVoodooAnimator.NativeFieldInfoPtr_globalLookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "globalLookAt");
			PathVoodooAnimator.NativeFieldInfoPtr_disableOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "disableOrientation");
			PathVoodooAnimator.NativeFieldInfoPtr_disablePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "disablePosition");
			PathVoodooAnimator.NativeFieldInfoPtr_globalFollowPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "globalFollowPath");
			PathVoodooAnimator.NativeFieldInfoPtr_waypointChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "waypointChanged");
			PathVoodooAnimator.NativeFieldInfoPtr__lastPassedWayponint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "_lastPassedWayponint");
			PathVoodooAnimator.NativeFieldInfoPtr__lastVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "_lastVelocity");
			PathVoodooAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663584);
			PathVoodooAnimator.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663585);
			PathVoodooAnimator.NativeMethodInfoPtr_get_PathVoodoo_Public_get_PathVoodoo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663586);
			PathVoodooAnimator.NativeMethodInfoPtr_set_PathVoodoo_Public_set_Void_PathVoodoo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663587);
			PathVoodooAnimator.NativeMethodInfoPtr_get_Target_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663588);
			PathVoodooAnimator.NativeMethodInfoPtr_get_UpdateMode_Public_get_UpdateModeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663589);
			PathVoodooAnimator.NativeMethodInfoPtr_set_UpdateMode_Public_set_Void_UpdateModeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663590);
			PathVoodooAnimator.NativeMethodInfoPtr_get_AutoStart_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663591);
			PathVoodooAnimator.NativeMethodInfoPtr_set_AutoStart_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663592);
			PathVoodooAnimator.NativeMethodInfoPtr_get_VelocityBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663593);
			PathVoodooAnimator.NativeMethodInfoPtr_set_VelocityBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663594);
			PathVoodooAnimator.NativeMethodInfoPtr_get_CurrentPos_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663595);
			PathVoodooAnimator.NativeMethodInfoPtr_set_CurrentPos_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663596);
			PathVoodooAnimator.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663597);
			PathVoodooAnimator.NativeMethodInfoPtr_get_GlobalLookAt_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663598);
			PathVoodooAnimator.NativeMethodInfoPtr_set_GlobalLookAt_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663599);
			PathVoodooAnimator.NativeMethodInfoPtr_get_DisableOrientation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663600);
			PathVoodooAnimator.NativeMethodInfoPtr_set_DisableOrientation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663601);
			PathVoodooAnimator.NativeMethodInfoPtr_get_DisablePosition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663602);
			PathVoodooAnimator.NativeMethodInfoPtr_set_DisablePosition_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663603);
			PathVoodooAnimator.NativeMethodInfoPtr_get_WaypointChanged_Public_get_WaypointChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663604);
			PathVoodooAnimator.NativeMethodInfoPtr_set_WaypointChanged_Public_set_Void_WaypointChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663605);
			PathVoodooAnimator.NativeMethodInfoPtr_get_LastPassedWayponint_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663606);
			PathVoodooAnimator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663607);
			PathVoodooAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663608);
			PathVoodooAnimator.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663609);
			PathVoodooAnimator.NativeMethodInfoPtr_DoUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663610);
			PathVoodooAnimator.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663611);
			PathVoodooAnimator.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663612);
			PathVoodooAnimator.NativeMethodInfoPtr_Rewind_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663613);
			PathVoodooAnimator.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663614);
			PathVoodooAnimator.NativeMethodInfoPtr_UpdateTarget_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663615);
			PathVoodooAnimator.NativeMethodInfoPtr_UpdateTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663616);
			PathVoodooAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, 100663617);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00011A5C File Offset: 0x0000FC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108182, XrefRangeEnd = 1108186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00011A90 File Offset: 0x0000FC90
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00011AC4 File Offset: 0x0000FCC4
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00011B04 File Offset: 0x0000FD04
		public unsafe PathVoodoo PathVoodoo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_get_PathVoodoo_Public_get_PathVoodoo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathVoodoo>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_set_PathVoodoo_Public_set_Void_PathVoodoo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00011B48 File Offset: 0x0000FD48
		public unsafe Transform Target
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_get_Target_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00011B88 File Offset: 0x0000FD88
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00011BC4 File Offset: 0x0000FDC4
		public unsafe PathVoodooAnimator.UpdateModeType UpdateMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_get_UpdateMode_Public_get_UpdateModeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_set_UpdateMode_Public_set_Void_UpdateModeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00011C04 File Offset: 0x0000FE04
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00011C40 File Offset: 0x0000FE40
		public unsafe bool AutoStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_get_AutoStart_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_set_AutoStart_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00011C80 File Offset: 0x0000FE80
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00011CBC File Offset: 0x0000FEBC
		public unsafe float VelocityBias
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_get_VelocityBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 850305, RefRangeEnd = 850310, XrefRangeStart = 850305, XrefRangeEnd = 850310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_set_VelocityBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00011CFC File Offset: 0x0000FEFC
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00011D38 File Offset: 0x0000FF38
		public unsafe float CurrentPos
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_get_CurrentPos_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604707, RefRangeEnd = 604708, XrefRangeStart = 604707, XrefRangeEnd = 604708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_set_CurrentPos_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00011D78 File Offset: 0x0000FF78
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00011DB4 File Offset: 0x0000FFB4
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00011DF4 File Offset: 0x0000FFF4
		public unsafe Transform GlobalLookAt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_get_GlobalLookAt_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_set_GlobalLookAt_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00011E38 File Offset: 0x00010038
		// (set) Token: 0x060002AC RID: 684 RVA: 0x00011E74 File Offset: 0x00010074
		public unsafe bool DisableOrientation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_get_DisableOrientation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_set_DisableOrientation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00011EB4 File Offset: 0x000100B4
		// (set) Token: 0x060002AE RID: 686 RVA: 0x00011EF0 File Offset: 0x000100F0
		public unsafe bool DisablePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_get_DisablePosition_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_set_DisablePosition_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00011F30 File Offset: 0x00010130
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00011F70 File Offset: 0x00010170
		public unsafe PathVoodooAnimator.WaypointChangedEvent WaypointChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_get_WaypointChanged_Public_get_WaypointChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathVoodooAnimator.WaypointChangedEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_set_WaypointChanged_Public_set_Void_WaypointChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00011FB4 File Offset: 0x000101B4
		public unsafe int LastPassedWayponint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_get_LastPassedWayponint_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00011FF0 File Offset: 0x000101F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108186, XrefRangeEnd = 1108190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00012024 File Offset: 0x00010224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108190, XrefRangeEnd = 1108195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00012058 File Offset: 0x00010258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108195, XrefRangeEnd = 1108196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0001208C File Offset: 0x0001028C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1108210, RefRangeEnd = 1108212, XrefRangeStart = 1108196, XrefRangeEnd = 1108210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_DoUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000120C0 File Offset: 0x000102C0
		[CallerCount(0)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000120F4 File Offset: 0x000102F4
		[CallerCount(0)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00012128 File Offset: 0x00010328
		[CallerCount(0)]
		public unsafe void Rewind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_Rewind_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0001215C File Offset: 0x0001035C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108212, XrefRangeEnd = 1108215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00012190 File Offset: 0x00010390
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1108225, RefRangeEnd = 1108227, XrefRangeStart = 1108215, XrefRangeEnd = 1108225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTarget(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_UpdateTarget_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000121DC File Offset: 0x000103DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1108252, RefRangeEnd = 1108255, XrefRangeStart = 1108227, XrefRangeEnd = 1108252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr_UpdateTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00012210 File Offset: 0x00010410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108255, XrefRangeEnd = 1108256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathVoodooAnimator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00003617 File Offset: 0x00001817
		public PathVoodooAnimator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0001224C File Offset: 0x0001044C
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00003620 File Offset: 0x00001820
		public unsafe PathVoodoo pathVoodoo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_pathVoodoo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathVoodoo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_pathVoodoo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0001227C File Offset: 0x0001047C
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x0000363F File Offset: 0x0000183F
		public unsafe Transform target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x000122AC File Offset: 0x000104AC
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x0000365E File Offset: 0x0000185E
		public unsafe PathVoodooAnimator.UpdateModeType updateMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_updateMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_updateMode)) = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x000122D4 File Offset: 0x000104D4
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00003679 File Offset: 0x00001879
		public unsafe bool autoStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_autoStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_autoStart)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x000122FC File Offset: 0x000104FC
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00003694 File Offset: 0x00001894
		public unsafe float velocityBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_velocityBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_velocityBias)) = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00012324 File Offset: 0x00010524
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x000036AF File Offset: 0x000018AF
		public unsafe float currentPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_currentPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_currentPos)) = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0001234C File Offset: 0x0001054C
		// (set) Token: 0x060002CB RID: 715 RVA: 0x000036CA File Offset: 0x000018CA
		public unsafe bool isPlaying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_isPlaying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_isPlaying)) = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00012374 File Offset: 0x00010574
		// (set) Token: 0x060002CD RID: 717 RVA: 0x000036E5 File Offset: 0x000018E5
		public unsafe Transform globalLookAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_globalLookAt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_globalLookAt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000123A4 File Offset: 0x000105A4
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00003704 File Offset: 0x00001904
		public unsafe bool disableOrientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_disableOrientation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_disableOrientation)) = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x000123CC File Offset: 0x000105CC
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x0000371F File Offset: 0x0000191F
		public unsafe bool disablePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_disablePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_disablePosition)) = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x000123F4 File Offset: 0x000105F4
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x0000373A File Offset: 0x0000193A
		public unsafe bool globalFollowPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_globalFollowPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_globalFollowPath)) = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0001241C File Offset: 0x0001061C
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00003755 File Offset: 0x00001955
		public unsafe PathVoodooAnimator.WaypointChangedEvent waypointChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_waypointChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathVoodooAnimator.WaypointChangedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr_waypointChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0001244C File Offset: 0x0001064C
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00003774 File Offset: 0x00001974
		public unsafe int _lastPassedWayponint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr__lastPassedWayponint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr__lastPassedWayponint)) = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00012474 File Offset: 0x00010674
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0000378F File Offset: 0x0000198F
		public unsafe float _lastVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr__lastVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooAnimator.NativeFieldInfoPtr__lastVelocity)) = value;
			}
		}

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_pathVoodoo;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_updateMode;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_autoStart;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_velocityBias;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_currentPos;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_isPlaying;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_globalLookAt;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_disableOrientation;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_disablePosition;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_globalFollowPath;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_waypointChanged;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeFieldInfoPtr__lastPassedWayponint;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeFieldInfoPtr__lastVelocity;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_get_PathVoodoo_Public_get_PathVoodoo_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_set_PathVoodoo_Public_set_Void_PathVoodoo_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Transform_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateMode_Public_get_UpdateModeType_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateMode_Public_set_Void_UpdateModeType_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoStart_Public_get_Boolean_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoStart_Public_set_Void_Boolean_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_get_VelocityBias_Public_get_Single_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_set_VelocityBias_Public_set_Void_Single_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPos_Public_get_Single_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPos_Public_set_Void_Single_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalLookAt_Public_get_Transform_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_set_GlobalLookAt_Public_set_Void_Transform_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_get_DisableOrientation_Public_get_Boolean_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_set_DisableOrientation_Public_set_Void_Boolean_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_get_DisablePosition_Public_get_Boolean_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_set_DisablePosition_Public_set_Void_Boolean_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_get_WaypointChanged_Public_get_WaypointChangedEvent_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_set_WaypointChanged_Public_set_Void_WaypointChangedEvent_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_get_LastPassedWayponint_Public_get_Int32_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdate_Public_Void_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_Rewind_Public_Void_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTarget_Public_Void_Vector3_Quaternion_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTarget_Public_Void_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C3 RID: 195
		[Serializable]
		public class WaypointChangedEvent : UnityEvent<int>
		{
			// Token: 0x06000A94 RID: 2708 RVA: 0x0000732F File Offset: 0x0000552F
			// Note: this type is marked as 'beforefieldinit'.
			static WaypointChangedEvent()
			{
				Il2CppClassPointerStore<PathVoodooAnimator.WaypointChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathVoodooAnimator>.NativeClassPtr, "WaypointChangedEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathVoodooAnimator.WaypointChangedEvent>.NativeClassPtr);
				PathVoodooAnimator.WaypointChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooAnimator.WaypointChangedEvent>.NativeClassPtr, 100663618);
			}

			// Token: 0x06000A95 RID: 2709 RVA: 0x0002C194 File Offset: 0x0002A394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108179, XrefRangeEnd = 1108182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WaypointChangedEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathVoodooAnimator.WaypointChangedEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooAnimator.WaypointChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A96 RID: 2710 RVA: 0x00007363 File Offset: 0x00005563
			public WaypointChangedEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400068C RID: 1676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000C4 RID: 196
		public enum UpdateModeType
		{
			// Token: 0x0400068E RID: 1678
			OnUpdate,
			// Token: 0x0400068F RID: 1679
			OnFixedUpdate
		}
	}
}
