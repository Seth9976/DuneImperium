using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000072 RID: 114
	public class PhysicsRaycaster : BaseRaycaster
	{
		// Token: 0x06000B5B RID: 2907 RVA: 0x000333E8 File Offset: 0x000315E8
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsRaycaster()
		{
			Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "PhysicsRaycaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr);
			PhysicsRaycaster.NativeFieldInfoPtr_kNoEventMaskSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "kNoEventMaskSet");
			PhysicsRaycaster.NativeFieldInfoPtr_m_EventCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_EventCamera");
			PhysicsRaycaster.NativeFieldInfoPtr_m_EventMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_EventMask");
			PhysicsRaycaster.NativeFieldInfoPtr_m_MaxRayIntersections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_MaxRayIntersections");
			PhysicsRaycaster.NativeFieldInfoPtr_m_LastMaxRayIntersections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_LastMaxRayIntersections");
			PhysicsRaycaster.NativeFieldInfoPtr_m_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_Hits");
			PhysicsRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665164);
			PhysicsRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665165);
			PhysicsRaycaster.NativeMethodInfoPtr_get_depth_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665166);
			PhysicsRaycaster.NativeMethodInfoPtr_get_finalEventMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665167);
			PhysicsRaycaster.NativeMethodInfoPtr_get_eventMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665168);
			PhysicsRaycaster.NativeMethodInfoPtr_set_eventMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665169);
			PhysicsRaycaster.NativeMethodInfoPtr_get_maxRayIntersections_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665170);
			PhysicsRaycaster.NativeMethodInfoPtr_set_maxRayIntersections_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665171);
			PhysicsRaycaster.NativeMethodInfoPtr_ComputeRayAndDistance_Protected_Boolean_PointerEventData_byref_Ray_byref_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665172);
			PhysicsRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665173);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00033558 File Offset: 0x00031758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhysicsRaycaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00033594 File Offset: 0x00031794
		public unsafe override Camera eventCamera
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097667, XrefRangeEnd = 1097678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x000335E0 File Offset: 0x000317E0
		public unsafe virtual int depth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097678, XrefRangeEnd = 1097683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsRaycaster.NativeMethodInfoPtr_get_depth_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00033628 File Offset: 0x00031828
		public unsafe int finalEventMask
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1097689, RefRangeEnd = 1097693, XrefRangeStart = 1097683, XrefRangeEnd = 1097689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_get_finalEventMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x00033664 File Offset: 0x00031864
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x000336A0 File Offset: 0x000318A0
		public unsafe LayerMask eventMask
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_get_eventMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_set_eventMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x000336E0 File Offset: 0x000318E0
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x0003371C File Offset: 0x0003191C
		public unsafe int maxRayIntersections
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_get_maxRayIntersections_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_set_maxRayIntersections_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0003375C File Offset: 0x0003195C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1097709, RefRangeEnd = 1097711, XrefRangeStart = 1097693, XrefRangeEnd = 1097709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &eventDisplayIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &distanceToClipPlane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_ComputeRayAndDistance_Protected_Boolean_PointerEventData_byref_Ray_byref_Int32_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x000337D4 File Offset: 0x000319D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097711, XrefRangeEnd = 1097745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultAppendList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00006020 File Offset: 0x00004220
		public PhysicsRaycaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x00033834 File Offset: 0x00031A34
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x00006029 File Offset: 0x00004229
		public unsafe static int kNoEventMaskSet
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PhysicsRaycaster.NativeFieldInfoPtr_kNoEventMaskSet, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhysicsRaycaster.NativeFieldInfoPtr_kNoEventMaskSet, (void*)(&value));
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00033850 File Offset: 0x00031A50
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x00006037 File Offset: 0x00004237
		public unsafe Camera m_EventCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_EventCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_EventCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00033880 File Offset: 0x00031A80
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00006056 File Offset: 0x00004256
		public unsafe LayerMask m_EventMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_EventMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_EventMask)) = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x000338A8 File Offset: 0x00031AA8
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x00006071 File Offset: 0x00004271
		public unsafe int m_MaxRayIntersections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_MaxRayIntersections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_MaxRayIntersections)) = value;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x000338D0 File Offset: 0x00031AD0
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x0000608C File Offset: 0x0000428C
		public unsafe int m_LastMaxRayIntersections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_LastMaxRayIntersections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_LastMaxRayIntersections)) = value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x000338F8 File Offset: 0x00031AF8
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x000060A7 File Offset: 0x000042A7
		public unsafe Il2CppStructArray<RaycastHit> m_Hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_Hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_Hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeFieldInfoPtr_kNoEventMaskSet;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeFieldInfoPtr_m_EventCamera;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeFieldInfoPtr_m_EventMask;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxRayIntersections;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMaxRayIntersections;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeFieldInfoPtr_m_Hits;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_get_depth_Public_Virtual_New_get_Int32_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_get_finalEventMask_Public_get_Int32_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_get_eventMask_Public_get_LayerMask_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_set_eventMask_Public_set_Void_LayerMask_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_get_maxRayIntersections_Public_get_Int32_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_set_maxRayIntersections_Public_set_Void_Int32_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_ComputeRayAndDistance_Protected_Boolean_PointerEventData_byref_Ray_byref_Int32_byref_Single_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0;

		// Token: 0x020000D9 RID: 217
		public class RaycastHitComparer : Object
		{
			// Token: 0x06000DE8 RID: 3560 RVA: 0x0003B1AC File Offset: 0x000393AC
			// Note: this type is marked as 'beforefieldinit'.
			static RaycastHitComparer()
			{
				Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "RaycastHitComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr);
				PhysicsRaycaster.RaycastHitComparer.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr, "instance");
				PhysicsRaycaster.RaycastHitComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_RaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr, 100665174);
				PhysicsRaycaster.RaycastHitComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr, 100665175);
			}

			// Token: 0x06000DE9 RID: 3561 RVA: 0x0003B214 File Offset: 0x00039414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097664, XrefRangeEnd = 1097667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(RaycastHit x, RaycastHit y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.RaycastHitComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_RaycastHit_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DEA RID: 3562 RVA: 0x0003B26C File Offset: 0x0003946C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RaycastHitComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.RaycastHitComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DEB RID: 3563 RVA: 0x0000750E File Offset: 0x0000570E
			public RaycastHitComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000489 RID: 1161
			// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0003B2A8 File Offset: 0x000394A8
			// (set) Token: 0x06000DED RID: 3565 RVA: 0x00007517 File Offset: 0x00005717
			public unsafe static PhysicsRaycaster.RaycastHitComparer instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PhysicsRaycaster.RaycastHitComparer.NativeFieldInfoPtr_instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsRaycaster.RaycastHitComparer>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PhysicsRaycaster.RaycastHitComparer.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AC5 RID: 2757
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x04000AC6 RID: 2758
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_RaycastHit_RaycastHit_0;

			// Token: 0x04000AC7 RID: 2759
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
