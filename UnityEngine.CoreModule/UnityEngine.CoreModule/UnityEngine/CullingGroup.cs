using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200007B RID: 123
	public class CullingGroup : Object
	{
		// Token: 0x0600059C RID: 1436 RVA: 0x00028B04 File Offset: 0x00026D04
		// Note: this type is marked as 'beforefieldinit'.
		static CullingGroup()
		{
			Il2CppClassPointerStore<CullingGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CullingGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr);
			CullingGroup.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "m_Ptr");
			CullingGroup.NativeFieldInfoPtr_m_OnStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "m_OnStateChanged");
			CullingGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664004);
			CullingGroup.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664005);
			CullingGroup.NativeMethodInfoPtr_DisposeInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664006);
			CullingGroup.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664007);
			CullingGroup.NativeMethodInfoPtr_set_targetCamera_Public_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664008);
			CullingGroup.NativeMethodInfoPtr_SetBoundingSpheres_Public_Void_Il2CppStructArray_1_BoundingSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664009);
			CullingGroup.NativeMethodInfoPtr_SetBoundingSphereCount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664010);
			CullingGroup.NativeMethodInfoPtr_QueryIndices_Public_Int32_Boolean_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664011);
			CullingGroup.NativeMethodInfoPtr_QueryIndices_Private_Int32_Boolean_Int32_CullingQueryOptions_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664012);
			CullingGroup.NativeMethodInfoPtr_SetBoundingDistances_Public_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664013);
			CullingGroup.NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664014);
			CullingGroup.NativeMethodInfoPtr_SetDistanceReferencePoint_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664015);
			CullingGroup.NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664016);
			CullingGroup.NativeMethodInfoPtr_Init_Private_Static_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664017);
			CullingGroup.NativeMethodInfoPtr_FinalizerFailure_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664018);
			CullingGroup.NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664019);
			CullingGroup.get_enabledDelegateField = IL2CPP.ResolveICall<CullingGroup.get_enabledDelegate>("UnityEngine.CullingGroup::get_enabled");
			CullingGroup.set_enabledDelegateField = IL2CPP.ResolveICall<CullingGroup.set_enabledDelegate>("UnityEngine.CullingGroup::set_enabled");
			CullingGroup.get_targetCameraDelegateField = IL2CPP.ResolveICall<CullingGroup.get_targetCameraDelegate>("UnityEngine.CullingGroup::get_targetCamera");
			CullingGroup.EraseSwapBackDelegateField = IL2CPP.ResolveICall<CullingGroup.EraseSwapBackDelegate>("UnityEngine.CullingGroup::EraseSwapBack");
			CullingGroup.IsVisibleDelegateField = IL2CPP.ResolveICall<CullingGroup.IsVisibleDelegate>("UnityEngine.CullingGroup::IsVisible");
			CullingGroup.GetDistanceDelegateField = IL2CPP.ResolveICall<CullingGroup.GetDistanceDelegate>("UnityEngine.CullingGroup::GetDistance");
			CullingGroup.SetDistanceReferencePoint_InternalTransformDelegateField = IL2CPP.ResolveICall<CullingGroup.SetDistanceReferencePoint_InternalTransformDelegate>("UnityEngine.CullingGroup::SetDistanceReferencePoint_InternalTransform");
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00028D08 File Offset: 0x00026F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 646331, RefRangeEnd = 646332, XrefRangeStart = 646327, XrefRangeEnd = 646331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CullingGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00028D44 File Offset: 0x00026F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646332, XrefRangeEnd = 646338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CullingGroup.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00028D80 File Offset: 0x00026F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646338, XrefRangeEnd = 646340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_DisposeInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00028DB4 File Offset: 0x00026FB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 646342, RefRangeEnd = 646343, XrefRangeStart = 646340, XrefRangeEnd = 646342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x000291E4 File Offset: 0x000273E4
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x00028DE8 File Offset: 0x00026FE8
		public unsafe Camera targetCamera
		{
			get
			{
				IntPtr intPtr = CullingGroup.get_targetCameraDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 646345, RefRangeEnd = 646347, XrefRangeStart = 646343, XrefRangeEnd = 646345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_set_targetCamera_Public_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00028E2C File Offset: 0x0002702C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 646349, RefRangeEnd = 646351, XrefRangeStart = 646347, XrefRangeEnd = 646349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoundingSpheres(Il2CppStructArray<BoundingSphere> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SetBoundingSpheres_Public_Void_Il2CppStructArray_1_BoundingSphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00028E70 File Offset: 0x00027070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 646353, RefRangeEnd = 646355, XrefRangeStart = 646351, XrefRangeEnd = 646353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoundingSphereCount(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SetBoundingSphereCount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00028EB0 File Offset: 0x000270B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 646357, RefRangeEnd = 646359, XrefRangeStart = 646355, XrefRangeEnd = 646357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int QueryIndices(bool visible, Il2CppStructArray<int> result, int firstIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_QueryIndices_Public_Int32_Boolean_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00028F1C File Offset: 0x0002711C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646359, XrefRangeEnd = 646361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int QueryIndices(bool visible, int distanceIndex, CullingQueryOptions options, Il2CppStructArray<int> result, int firstIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_QueryIndices_Private_Int32_Boolean_Int32_CullingQueryOptions_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00028FA4 File Offset: 0x000271A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 646363, RefRangeEnd = 646365, XrefRangeStart = 646361, XrefRangeEnd = 646363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoundingDistances(Il2CppStructArray<float> distances)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(distances);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SetBoundingDistances_Public_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00028FE8 File Offset: 0x000271E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646365, XrefRangeEnd = 646367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDistanceReferencePoint_InternalVector3(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00029028 File Offset: 0x00027228
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 646369, RefRangeEnd = 646371, XrefRangeStart = 646367, XrefRangeEnd = 646369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDistanceReferencePoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SetDistanceReferencePoint_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00029068 File Offset: 0x00027268
		[CallerCount(0)]
		public unsafe static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cullingGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventsPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000290BC File Offset: 0x000272BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646371, XrefRangeEnd = 646373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Init(Object scripting)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scripting);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_Init_Private_Static_IntPtr_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00029100 File Offset: 0x00027300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646373, XrefRangeEnd = 646375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizerFailure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_FinalizerFailure_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00029134 File Offset: 0x00027334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646375, XrefRangeEnd = 646377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDistanceReferencePoint_InternalVector3_Injected(ref Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00004207 File Offset: 0x00002407
		public CullingGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x00029174 File Offset: 0x00027374
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x00004210 File Offset: 0x00002410
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0002919C File Offset: 0x0002739C
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0000422B File Offset: 0x0000242B
		public unsafe CullingGroup.StateChanged m_OnStateChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_OnStateChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CullingGroup.StateChanged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_OnStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x000291CC File Offset: 0x000273CC
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x0000424A File Offset: 0x0000244A
		public CullingGroup.StateChanged onStateChanged
		{
			get
			{
				return this.m_OnStateChanged;
			}
			set
			{
				this.m_OnStateChanged = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00004254 File Offset: 0x00002454
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00004266 File Offset: 0x00002466
		public bool enabled
		{
			get
			{
				return CullingGroup.get_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CullingGroup.set_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00004279 File Offset: 0x00002479
		public void EraseSwapBack(int index)
		{
			CullingGroup.EraseSwapBackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0000428C File Offset: 0x0000248C
		public static void EraseSwapBack<T>(int index, Il2CppArrayBase<T> myArray, ref int size)
		{
			size--;
			myArray[index] = myArray[size];
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00029210 File Offset: 0x00027410
		public int QueryIndices(int distanceIndex, Il2CppStructArray<int> result, int firstIndex)
		{
			return this.QueryIndices(false, distanceIndex, CullingQueryOptions.IgnoreVisibility, result, firstIndex);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00029230 File Offset: 0x00027430
		public int QueryIndices(bool visible, int distanceIndex, Il2CppStructArray<int> result, int firstIndex)
		{
			return this.QueryIndices(visible, distanceIndex, CullingQueryOptions.Normal, result, firstIndex);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000042A4 File Offset: 0x000024A4
		public bool IsVisible(int index)
		{
			return CullingGroup.IsVisibleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000042B7 File Offset: 0x000024B7
		public int GetDistance(int index)
		{
			return CullingGroup.GetDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000042CA File Offset: 0x000024CA
		public void SetDistanceReferencePoint_InternalTransform(Transform transform)
		{
			CullingGroup.SetDistanceReferencePoint_InternalTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform));
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000042E2 File Offset: 0x000024E2
		public void SetDistanceReferencePoint(Transform transform)
		{
			this.SetDistanceReferencePoint_InternalTransform(transform);
		}

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeFieldInfoPtr_m_OnStateChanged;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_DisposeInternal_Private_Void_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_set_targetCamera_Public_set_Void_Camera_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_SetBoundingSpheres_Public_Void_Il2CppStructArray_1_BoundingSphere_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_SetBoundingSphereCount_Public_Void_Int32_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_QueryIndices_Public_Int32_Boolean_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_QueryIndices_Private_Int32_Boolean_Int32_CullingQueryOptions_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_SetBoundingDistances_Public_Void_Il2CppStructArray_1_Single_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Private_Void_Vector3_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_SetDistanceReferencePoint_Public_Void_Vector3_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_IntPtr_Object_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_FinalizerFailure_Private_Void_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000504 RID: 1284
		private static readonly CullingGroup.get_enabledDelegate get_enabledDelegateField;

		// Token: 0x04000505 RID: 1285
		private static readonly CullingGroup.set_enabledDelegate set_enabledDelegateField;

		// Token: 0x04000506 RID: 1286
		private static readonly CullingGroup.get_targetCameraDelegate get_targetCameraDelegateField;

		// Token: 0x04000507 RID: 1287
		private static readonly CullingGroup.EraseSwapBackDelegate EraseSwapBackDelegateField;

		// Token: 0x04000508 RID: 1288
		private static readonly CullingGroup.IsVisibleDelegate IsVisibleDelegateField;

		// Token: 0x04000509 RID: 1289
		private static readonly CullingGroup.GetDistanceDelegate GetDistanceDelegateField;

		// Token: 0x0400050A RID: 1290
		private static readonly CullingGroup.SetDistanceReferencePoint_InternalTransformDelegate SetDistanceReferencePoint_InternalTransformDelegateField;

		// Token: 0x02000454 RID: 1108
		public sealed class StateChanged : MulticastDelegate
		{
			// Token: 0x0600319F RID: 12703 RVA: 0x00013B55 File Offset: 0x00011D55
			// Note: this type is marked as 'beforefieldinit'.
			static StateChanged()
			{
				Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "StateChanged");
				CullingGroup.StateChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr, 100664020);
				CullingGroup.StateChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr, 100664021);
			}

			// Token: 0x060031A0 RID: 12704 RVA: 0x000B86E8 File Offset: 0x000B68E8
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 646316, RefRangeEnd = 646327, XrefRangeStart = 646313, XrefRangeEnd = 646316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StateChanged(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.StateChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031A1 RID: 12705 RVA: 0x000B8744 File Offset: 0x000B6944
			[CallerCount(0)]
			public unsafe void Invoke(CullingGroupEvent sphere)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref sphere;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.StateChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060031A2 RID: 12706 RVA: 0x00013B93 File Offset: 0x00011D93
			public StateChanged(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060031A3 RID: 12707 RVA: 0x00013B9C File Offset: 0x00011D9C
			public static implicit operator CullingGroup.StateChanged(Action<CullingGroupEvent> A_0)
			{
				return DelegateSupport.ConvertDelegate<CullingGroup.StateChanged>(A_0);
			}

			// Token: 0x060031A4 RID: 12708 RVA: 0x00013BA4 File Offset: 0x00011DA4
			public static CullingGroup.StateChanged operator +(CullingGroup.StateChanged A_0, CullingGroup.StateChanged A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CullingGroup.StateChanged>();
			}

			// Token: 0x060031A5 RID: 12709 RVA: 0x00013BB2 File Offset: 0x00011DB2
			public static CullingGroup.StateChanged operator -(CullingGroup.StateChanged A_0, CullingGroup.StateChanged A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<CullingGroup.StateChanged>();
				}
				return delegate2;
			}

			// Token: 0x04002B66 RID: 11110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B67 RID: 11111
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0;
		}

		// Token: 0x02000455 RID: 1109
		// (Invoke) Token: 0x060031A7 RID: 12711
		private delegate bool get_enabledDelegate(IntPtr @this);

		// Token: 0x02000456 RID: 1110
		// (Invoke) Token: 0x060031A9 RID: 12713
		private delegate void set_enabledDelegate(IntPtr @this, bool value);

		// Token: 0x02000457 RID: 1111
		// (Invoke) Token: 0x060031AB RID: 12715
		private delegate IntPtr get_targetCameraDelegate(IntPtr @this);

		// Token: 0x02000458 RID: 1112
		// (Invoke) Token: 0x060031AD RID: 12717
		private delegate void EraseSwapBackDelegate(IntPtr @this, int index);

		// Token: 0x02000459 RID: 1113
		// (Invoke) Token: 0x060031AF RID: 12719
		private delegate bool IsVisibleDelegate(IntPtr @this, int index);

		// Token: 0x0200045A RID: 1114
		// (Invoke) Token: 0x060031B1 RID: 12721
		private delegate int GetDistanceDelegate(IntPtr @this, int index);

		// Token: 0x0200045B RID: 1115
		// (Invoke) Token: 0x060031B3 RID: 12723
		private delegate void SetDistanceReferencePoint_InternalTransformDelegate(IntPtr @this, IntPtr transform);
	}
}
