using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace voodoo.pathing.CameraTools
{
	// Token: 0x02000037 RID: 55
	public class PathVoodooFollower : MonoBehaviour
	{
		// Token: 0x06000342 RID: 834 RVA: 0x00013A18 File Offset: 0x00011C18
		// Note: this type is marked as 'beforefieldinit'.
		static PathVoodooFollower()
		{
			Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.pathing.CameraTools", "PathVoodooFollower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr);
			PathVoodooFollower.NativeFieldInfoPtr_pathVoodoo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, "pathVoodoo");
			PathVoodooFollower.NativeFieldInfoPtr_pathVoodooAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, "pathVoodooAnimator");
			PathVoodooFollower.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, "target");
			PathVoodooFollower.NativeFieldInfoPtr_precision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, "precision");
			PathVoodooFollower.NativeFieldInfoPtr_accurate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, "accurate");
			PathVoodooFollower.NativeFieldInfoPtr_waypointsOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, "waypointsOnly");
			PathVoodooFollower.NativeFieldInfoPtr_lerpPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, "lerpPosition");
			PathVoodooFollower.NativeFieldInfoPtr_lerpFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, "lerpFactor");
			PathVoodooFollower.NativeMethodInfoPtr_get_Target_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663664);
			PathVoodooFollower.NativeMethodInfoPtr_set_Target_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663665);
			PathVoodooFollower.NativeMethodInfoPtr_get_Precision_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663666);
			PathVoodooFollower.NativeMethodInfoPtr_set_Precision_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663667);
			PathVoodooFollower.NativeMethodInfoPtr_get_Accurate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663668);
			PathVoodooFollower.NativeMethodInfoPtr_set_Accurate_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663669);
			PathVoodooFollower.NativeMethodInfoPtr_get_WaypointsOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663670);
			PathVoodooFollower.NativeMethodInfoPtr_set_WaypointsOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663671);
			PathVoodooFollower.NativeMethodInfoPtr_get_LerpPosition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663672);
			PathVoodooFollower.NativeMethodInfoPtr_set_LerpPosition_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663673);
			PathVoodooFollower.NativeMethodInfoPtr_get_LerpFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663674);
			PathVoodooFollower.NativeMethodInfoPtr_set_LerpFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663675);
			PathVoodooFollower.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663676);
			PathVoodooFollower.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663677);
			PathVoodooFollower.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663678);
			PathVoodooFollower.NativeMethodInfoPtr_get_CurrentPos_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663679);
			PathVoodooFollower.NativeMethodInfoPtr_set_CurrentPos_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663680);
			PathVoodooFollower.NativeMethodInfoPtr_get_Path_Public_get_PathVoodoo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663681);
			PathVoodooFollower.NativeMethodInfoPtr_get_PointOfView_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663682);
			PathVoodooFollower.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663683);
			PathVoodooFollower.NativeMethodInfoPtr_computeWaypointPosAtMinDistance_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663684);
			PathVoodooFollower.NativeMethodInfoPtr_computePosAtMinDistance_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663685);
			PathVoodooFollower.NativeMethodInfoPtr_GetPositionForPos_Private_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663686);
			PathVoodooFollower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr, 100663687);
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00013CC8 File Offset: 0x00011EC8
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00013D08 File Offset: 0x00011F08
		public unsafe Transform Target
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_get_Target_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_set_Target_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00013D4C File Offset: 0x00011F4C
		// (set) Token: 0x06000346 RID: 838 RVA: 0x00013D88 File Offset: 0x00011F88
		public unsafe int Precision
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_get_Precision_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_set_Precision_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00013DC8 File Offset: 0x00011FC8
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00013E04 File Offset: 0x00012004
		public unsafe bool Accurate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_get_Accurate_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_set_Accurate_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00013E44 File Offset: 0x00012044
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00013E80 File Offset: 0x00012080
		public unsafe bool WaypointsOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_get_WaypointsOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_set_WaypointsOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00013EC0 File Offset: 0x000120C0
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00013EFC File Offset: 0x000120FC
		public unsafe bool LerpPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_get_LerpPosition_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_set_LerpPosition_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00013F3C File Offset: 0x0001213C
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00013F78 File Offset: 0x00012178
		public unsafe float LerpFactor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300360, RefRangeEnd = 300361, XrefRangeStart = 300360, XrefRangeEnd = 300361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_get_LerpFactor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 599561, RefRangeEnd = 599562, XrefRangeStart = 599561, XrefRangeEnd = 599562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_set_LerpFactor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00013FB8 File Offset: 0x000121B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108402, XrefRangeEnd = 1108419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00013FEC File Offset: 0x000121EC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00014020 File Offset: 0x00012220
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00014054 File Offset: 0x00012254
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00014090 File Offset: 0x00012290
		public unsafe float CurrentPos
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1108426, RefRangeEnd = 1108433, XrefRangeStart = 1108419, XrefRangeEnd = 1108426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_get_CurrentPos_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108433, XrefRangeEnd = 1108441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_set_CurrentPos_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000354 RID: 852 RVA: 0x000140D0 File Offset: 0x000122D0
		public unsafe PathVoodoo Path
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1108448, RefRangeEnd = 1108470, XrefRangeStart = 1108441, XrefRangeEnd = 1108448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_get_Path_Public_get_PathVoodoo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathVoodoo>(intPtr3) : null;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00014110 File Offset: 0x00012310
		public unsafe Vector3 PointOfView
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108470, XrefRangeEnd = 1108485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_get_PointOfView_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0001414C File Offset: 0x0001234C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108485, XrefRangeEnd = 1108503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00014180 File Offset: 0x00012380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1108527, RefRangeEnd = 1108528, XrefRangeStart = 1108503, XrefRangeEnd = 1108527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float computeWaypointPosAtMinDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_computeWaypointPosAtMinDistance_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000141BC File Offset: 0x000123BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1108550, RefRangeEnd = 1108551, XrefRangeStart = 1108528, XrefRangeEnd = 1108550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float computePosAtMinDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_computePosAtMinDistance_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000141F8 File Offset: 0x000123F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1108566, RefRangeEnd = 1108568, XrefRangeStart = 1108551, XrefRangeEnd = 1108566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPositionForPos(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr_GetPositionForPos_Private_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00014244 File Offset: 0x00012444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108568, XrefRangeEnd = 1108569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathVoodooFollower()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathVoodooFollower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooFollower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00003AB2 File Offset: 0x00001CB2
		public PathVoodooFollower(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00014280 File Offset: 0x00012480
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00003ABB File Offset: 0x00001CBB
		public unsafe PathVoodoo pathVoodoo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_pathVoodoo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathVoodoo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_pathVoodoo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600035E RID: 862 RVA: 0x000142B0 File Offset: 0x000124B0
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00003ADA File Offset: 0x00001CDA
		public unsafe PathVoodooAnimator pathVoodooAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_pathVoodooAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathVoodooAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_pathVoodooAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000360 RID: 864 RVA: 0x000142E0 File Offset: 0x000124E0
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00003AF9 File Offset: 0x00001CF9
		public unsafe Transform target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00014310 File Offset: 0x00012510
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00003B18 File Offset: 0x00001D18
		public unsafe int precision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_precision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_precision)) = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00014338 File Offset: 0x00012538
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00003B33 File Offset: 0x00001D33
		public unsafe bool accurate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_accurate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_accurate)) = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00014360 File Offset: 0x00012560
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00003B4E File Offset: 0x00001D4E
		public unsafe bool waypointsOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_waypointsOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_waypointsOnly)) = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00014388 File Offset: 0x00012588
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00003B69 File Offset: 0x00001D69
		public unsafe bool lerpPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_lerpPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_lerpPosition)) = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000143B0 File Offset: 0x000125B0
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00003B84 File Offset: 0x00001D84
		public unsafe float lerpFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_lerpFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooFollower.NativeFieldInfoPtr_lerpFactor)) = value;
			}
		}

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_pathVoodoo;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_pathVoodooAnimator;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_precision;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_accurate;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_waypointsOnly;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_lerpPosition;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_lerpFactor;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Transform_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Public_set_Void_Transform_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_get_Precision_Public_get_Int32_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_set_Precision_Public_set_Void_Int32_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_get_Accurate_Public_get_Boolean_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_set_Accurate_Public_set_Void_Boolean_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_get_WaypointsOnly_Public_get_Boolean_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_set_WaypointsOnly_Public_set_Void_Boolean_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_get_LerpPosition_Public_get_Boolean_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_set_LerpPosition_Public_set_Void_Boolean_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_get_LerpFactor_Public_get_Single_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_set_LerpFactor_Public_set_Void_Single_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPos_Public_get_Single_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPos_Public_set_Void_Single_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_PathVoodoo_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_get_PointOfView_Public_get_Vector3_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_computeWaypointPosAtMinDistance_Private_Single_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_computePosAtMinDistance_Private_Single_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionForPos_Private_Vector3_Single_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
