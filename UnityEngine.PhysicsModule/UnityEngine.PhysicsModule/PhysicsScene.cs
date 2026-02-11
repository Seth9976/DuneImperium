using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	[StructLayout(2)]
	public struct PhysicsScene
	{
		// Token: 0x0600029A RID: 666 RVA: 0x0000A170 File Offset: 0x00008370
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsScene()
		{
			Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "PhysicsScene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr);
			PhysicsScene.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, "m_Handle");
			PhysicsScene.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663417);
			PhysicsScene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663418);
			PhysicsScene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663419);
			PhysicsScene.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663420);
			PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663421);
			PhysicsScene.NativeMethodInfoPtr_Internal_RaycastTest_Private_Static_Boolean_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663422);
			PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663423);
			PhysicsScene.NativeMethodInfoPtr_Internal_Raycast_Private_Static_Boolean_PhysicsScene_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663424);
			PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663425);
			PhysicsScene.NativeMethodInfoPtr_Internal_RaycastNonAlloc_Private_Static_Int32_PhysicsScene_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663426);
			PhysicsScene.NativeMethodInfoPtr_Internal_RaycastTest_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663427);
			PhysicsScene.NativeMethodInfoPtr_Internal_Raycast_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663428);
			PhysicsScene.NativeMethodInfoPtr_Internal_RaycastNonAlloc_Injected_Private_Static_Int32_byref_PhysicsScene_byref_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663429);
			PhysicsScene.IsValid_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.IsValid_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::IsValid_Internal_Injected");
			PhysicsScene.IsEmpty_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.IsEmpty_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::IsEmpty_Internal_Injected");
			PhysicsScene.Query_CapsuleCast_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Query_CapsuleCast_InjectedDelegate>("UnityEngine.PhysicsScene::Query_CapsuleCast_Injected");
			PhysicsScene.Internal_CapsuleCastNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Internal_CapsuleCastNonAlloc_InjectedDelegate>("UnityEngine.PhysicsScene::Internal_CapsuleCastNonAlloc_Injected");
			PhysicsScene.OverlapCapsuleNonAlloc_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.OverlapCapsuleNonAlloc_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::OverlapCapsuleNonAlloc_Internal_Injected");
			PhysicsScene.Query_SphereCast_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Query_SphereCast_InjectedDelegate>("UnityEngine.PhysicsScene::Query_SphereCast_Injected");
			PhysicsScene.Internal_SphereCastNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Internal_SphereCastNonAlloc_InjectedDelegate>("UnityEngine.PhysicsScene::Internal_SphereCastNonAlloc_Injected");
			PhysicsScene.OverlapSphereNonAlloc_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.OverlapSphereNonAlloc_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::OverlapSphereNonAlloc_Internal_Injected");
			PhysicsScene.Query_BoxCast_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Query_BoxCast_InjectedDelegate>("UnityEngine.PhysicsScene::Query_BoxCast_Injected");
			PhysicsScene.OverlapBoxNonAlloc_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.OverlapBoxNonAlloc_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::OverlapBoxNonAlloc_Internal_Injected");
			PhysicsScene.Internal_BoxCastNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Internal_BoxCastNonAlloc_InjectedDelegate>("UnityEngine.PhysicsScene::Internal_BoxCastNonAlloc_Injected");
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000A360 File Offset: 0x00008560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255203, XrefRangeEnd = 1255214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000A38C File Offset: 0x0000858C
		[CallerCount(236)]
		[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000A3BC File Offset: 0x000085BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255214, XrefRangeEnd = 1255217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000A400 File Offset: 0x00008600
		[CallerCount(0)]
		public unsafe bool Equals(PhysicsScene other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000A440 File Offset: 0x00008640
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1255222, RefRangeEnd = 1255224, XrefRangeStart = 1255217, XrefRangeEnd = 1255222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000A4B8 File Offset: 0x000086B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255224, XrefRangeEnd = 1255226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_RaycastTest_Private_Static_Boolean_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000A530 File Offset: 0x00008730
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1255231, RefRangeEnd = 1255239, XrefRangeStart = 1255226, XrefRangeEnd = 1255231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000A5B4 File Offset: 0x000087B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255239, XrefRangeEnd = 1255241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_Raycast_Private_Static_Boolean_PhysicsScene_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000A638 File Offset: 0x00008838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255241, XrefRangeEnd = 1255247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Raycast(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastHits);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000A6C0 File Offset: 0x000088C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255247, XrefRangeEnd = 1255249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastHits);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_RaycastNonAlloc_Private_Static_Int32_PhysicsScene_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000A748 File Offset: 0x00008948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255249, XrefRangeEnd = 1255251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_RaycastTest_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000A7C0 File Offset: 0x000089C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255251, XrefRangeEnd = 1255253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_Raycast_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000A844 File Offset: 0x00008A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255253, XrefRangeEnd = 1255255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastHits);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_RaycastNonAlloc_Injected_Private_Static_Int32_byref_PhysicsScene_byref_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000344A File Offset: 0x0000164A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, ref this));
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000A8CC File Offset: 0x00008ACC
		public static bool operator ==(PhysicsScene lhs, PhysicsScene rhs)
		{
			return lhs.m_Handle == rhs.m_Handle;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000A8EC File Offset: 0x00008AEC
		public static bool operator !=(PhysicsScene lhs, PhysicsScene rhs)
		{
			return lhs.m_Handle != rhs.m_Handle;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000A910 File Offset: 0x00008B10
		public bool IsValid()
		{
			return PhysicsScene.IsValid_Internal(this);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000345C File Offset: 0x0000165C
		public static bool IsValid_Internal(PhysicsScene physicsScene)
		{
			return PhysicsScene.IsValid_Internal_Injected(ref physicsScene);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000A930 File Offset: 0x00008B30
		public bool IsEmpty()
		{
			bool flag = this.IsValid();
			if (flag)
			{
				return PhysicsScene.IsEmpty_Internal(this);
			}
			throw new InvalidOperationException("Cannot check if physics scene is empty as it is invalid.");
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00003465 File Offset: 0x00001665
		public static bool IsEmpty_Internal(PhysicsScene physicsScene)
		{
			return PhysicsScene.IsEmpty_Internal_Injected(ref physicsScene);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000A964 File Offset: 0x00008B64
		public void Simulate(float step)
		{
			bool flag = this.IsValid();
			if (flag)
			{
				bool flag2 = this == Physics.defaultPhysicsScene && Physics.simulationMode != SimulationMode.Script;
				if (flag2)
				{
					Debug.LogWarning("PhysicsScene.Simulate(...) was called but simulation mode is not set to Script. You should set simulation mode to Script first before calling this function therefore the simulation was not run.");
				}
				else
				{
					Physics.Simulate_Internal(this, step);
				}
				return;
			}
			throw new InvalidOperationException("Cannot simulate the physics scene as it is invalid.");
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000A9CC File Offset: 0x00008BCC
		public void InterpolateBodies()
		{
			bool flag = !this.IsValid();
			if (flag)
			{
				throw new InvalidOperationException("Cannot interpolate the physics scene as it is invalid.");
			}
			bool flag2 = this == Physics.defaultPhysicsScene;
			if (flag2)
			{
				Debug.LogWarning("PhysicsScene.InterpolateBodies() was called on the default Physics Scene. This is done automatically and the call will be ignored");
			}
			else
			{
				Physics.InterpolateBodies_Internal(this);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000AA20 File Offset: 0x00008C20
		public void ResetInterpolationPoses()
		{
			bool flag = !this.IsValid();
			if (flag)
			{
				throw new InvalidOperationException("Cannot reset poses of the physics scene as it is invalid.");
			}
			bool flag2 = this == Physics.defaultPhysicsScene;
			if (flag2)
			{
				Debug.LogWarning("PhysicsScene.ResetInterpolationPoses() was called on the default Physics Scene. This is done automatically and the call will be ignored");
			}
			else
			{
				Physics.ResetInterpolationPoses_Internal(this);
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000AA74 File Offset: 0x00008C74
		public static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_CapsuleCast_Injected(ref physicsScene, ref point1, ref point2, radius, ref direction, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000AA98 File Offset: 0x00008C98
		public static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			hitInfo = default(RaycastHit);
			bool flag = magnitude > float.Epsilon;
			bool flag2;
			if (flag)
			{
				Vector3 vector = direction / magnitude;
				flag2 = PhysicsScene.Query_CapsuleCast(physicsScene, point1, point2, radius, vector, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_CapsuleCast(this, point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000AB14 File Offset: 0x00008D14
		public static int Internal_CapsuleCastNonAlloc(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_CapsuleCastNonAlloc_Injected(ref physicsScene, ref p0, ref p1, radius, ref direction, raycastHits, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000AB38 File Offset: 0x00008D38
		public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			bool flag = magnitude > float.Epsilon;
			int num;
			if (flag)
			{
				num = PhysicsScene.Internal_CapsuleCastNonAlloc(this, point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000346E File Offset: 0x0000166E
		public static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapCapsuleNonAlloc_Internal_Injected(ref physicsScene, ref point0, ref point1, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000AB7C File Offset: 0x00008D7C
		public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapCapsuleNonAlloc_Internal(this, point0, point1, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00003482 File Offset: 0x00001682
		public static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_SphereCast_Injected(ref physicsScene, ref origin, radius, ref direction, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000ABA4 File Offset: 0x00008DA4
		public static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			hitInfo = default(RaycastHit);
			bool flag = magnitude > float.Epsilon;
			bool flag2;
			if (flag)
			{
				Vector3 vector = direction / magnitude;
				flag2 = PhysicsScene.Query_SphereCast(physicsScene, origin, radius, vector, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_SphereCast(this, origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00003498 File Offset: 0x00001698
		public static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_SphereCastNonAlloc_Injected(ref physicsScene, ref origin, radius, ref direction, raycastHits, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000AC18 File Offset: 0x00008E18
		public int SphereCast(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			bool flag = magnitude > float.Epsilon;
			int num;
			if (flag)
			{
				num = PhysicsScene.Internal_SphereCastNonAlloc(this, origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000034AE File Offset: 0x000016AE
		public static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapSphereNonAlloc_Internal_Injected(ref physicsScene, ref position, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000AC5C File Offset: 0x00008E5C
		public int OverlapSphere(Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapSphereNonAlloc_Internal(this, position, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000AC80 File Offset: 0x00008E80
		public static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_BoxCast_Injected(ref physicsScene, ref center, ref halfExtents, ref direction, ref orientation, maxDistance, ref outHit, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000ACA4 File Offset: 0x00008EA4
		public static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			hitInfo = default(RaycastHit);
			bool flag = magnitude > float.Epsilon;
			bool flag2;
			if (flag)
			{
				Vector3 vector = direction / magnitude;
				flag2 = PhysicsScene.Query_BoxCast(physicsScene, center, halfExtents, vector, orientation, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000ACF4 File Offset: 0x00008EF4
		public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_BoxCast(this, center, halfExtents, orientation, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000AD20 File Offset: 0x00008F20
		public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo)
		{
			return PhysicsScene.Internal_BoxCast(this, center, halfExtents, Quaternion.identity, direction, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000034BF File Offset: 0x000016BF
		public static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapBoxNonAlloc_Internal_Injected(ref physicsScene, ref center, ref halfExtents, results, ref orientation, mask, queryTriggerInteraction);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000AD50 File Offset: 0x00008F50
		public int OverlapBox(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapBoxNonAlloc_Internal(this, center, halfExtents, results, orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000AD78 File Offset: 0x00008F78
		public int OverlapBox(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results)
		{
			return PhysicsScene.OverlapBoxNonAlloc_Internal(this, center, halfExtents, results, Quaternion.identity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		public static int Internal_BoxCastNonAlloc(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_BoxCastNonAlloc_Injected(ref physicsScene, ref center, ref halfExtents, ref direction, raycastHits, ref orientation, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000ADC4 File Offset: 0x00008FC4
		public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			bool flag = magnitude > float.Epsilon;
			int num;
			if (flag)
			{
				num = PhysicsScene.Internal_BoxCastNonAlloc(this, center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction);
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000AE08 File Offset: 0x00009008
		public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			return this.BoxCast(center, halfExtents, direction, results, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000034D3 File Offset: 0x000016D3
		public static bool IsValid_Internal_Injected(ref PhysicsScene physicsScene)
		{
			return PhysicsScene.IsValid_Internal_InjectedDelegateField(ref physicsScene);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000034E0 File Offset: 0x000016E0
		public static bool IsEmpty_Internal_Injected(ref PhysicsScene physicsScene)
		{
			return PhysicsScene.IsEmpty_Internal_InjectedDelegateField(ref physicsScene);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000AE34 File Offset: 0x00009034
		public static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_CapsuleCast_InjectedDelegateField(ref physicsScene, ref point1, ref point2, radius, ref direction, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000AE5C File Offset: 0x0000905C
		public static int Internal_CapsuleCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_CapsuleCastNonAlloc_InjectedDelegateField(ref physicsScene, ref p0, ref p1, radius, ref direction, IL2CPP.Il2CppObjectBaseToPtr(raycastHits), maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000034ED File Offset: 0x000016ED
		public static int OverlapCapsuleNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapCapsuleNonAlloc_Internal_InjectedDelegateField(ref physicsScene, ref point0, ref point1, radius, IL2CPP.Il2CppObjectBaseToPtr(results), layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000AE88 File Offset: 0x00009088
		public static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_SphereCast_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000AEAC File Offset: 0x000090AC
		public static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_SphereCastNonAlloc_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, IL2CPP.Il2CppObjectBaseToPtr(raycastHits), maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00003508 File Offset: 0x00001708
		public static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapSphereNonAlloc_Internal_InjectedDelegateField(ref physicsScene, ref position, radius, IL2CPP.Il2CppObjectBaseToPtr(results), layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000AED4 File Offset: 0x000090D4
		public static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_BoxCast_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref direction, ref orientation, maxDistance, ref outHit, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00003521 File Offset: 0x00001721
		public static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Il2CppReferenceArray<Collider> results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapBoxNonAlloc_Internal_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, IL2CPP.Il2CppObjectBaseToPtr(results), ref orientation, mask, queryTriggerInteraction);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000AEFC File Offset: 0x000090FC
		public static int Internal_BoxCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, ref Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_BoxCastNonAlloc_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref direction, IL2CPP.Il2CppObjectBaseToPtr(raycastHits), ref orientation, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastTest_Private_Static_Boolean_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Raycast_Private_Static_Boolean_PhysicsScene_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastNonAlloc_Private_Static_Int32_PhysicsScene_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastTest_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Raycast_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastNonAlloc_Injected_Private_Static_Int32_byref_PhysicsScene_byref_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000193 RID: 403
		[FieldOffset(0)]
		public int m_Handle;

		// Token: 0x04000194 RID: 404
		private static readonly PhysicsScene.IsValid_Internal_InjectedDelegate IsValid_Internal_InjectedDelegateField;

		// Token: 0x04000195 RID: 405
		private static readonly PhysicsScene.IsEmpty_Internal_InjectedDelegate IsEmpty_Internal_InjectedDelegateField;

		// Token: 0x04000196 RID: 406
		private static readonly PhysicsScene.Query_CapsuleCast_InjectedDelegate Query_CapsuleCast_InjectedDelegateField;

		// Token: 0x04000197 RID: 407
		private static readonly PhysicsScene.Internal_CapsuleCastNonAlloc_InjectedDelegate Internal_CapsuleCastNonAlloc_InjectedDelegateField;

		// Token: 0x04000198 RID: 408
		private static readonly PhysicsScene.OverlapCapsuleNonAlloc_Internal_InjectedDelegate OverlapCapsuleNonAlloc_Internal_InjectedDelegateField;

		// Token: 0x04000199 RID: 409
		private static readonly PhysicsScene.Query_SphereCast_InjectedDelegate Query_SphereCast_InjectedDelegateField;

		// Token: 0x0400019A RID: 410
		private static readonly PhysicsScene.Internal_SphereCastNonAlloc_InjectedDelegate Internal_SphereCastNonAlloc_InjectedDelegateField;

		// Token: 0x0400019B RID: 411
		private static readonly PhysicsScene.OverlapSphereNonAlloc_Internal_InjectedDelegate OverlapSphereNonAlloc_Internal_InjectedDelegateField;

		// Token: 0x0400019C RID: 412
		private static readonly PhysicsScene.Query_BoxCast_InjectedDelegate Query_BoxCast_InjectedDelegateField;

		// Token: 0x0400019D RID: 413
		private static readonly PhysicsScene.OverlapBoxNonAlloc_Internal_InjectedDelegate OverlapBoxNonAlloc_Internal_InjectedDelegateField;

		// Token: 0x0400019E RID: 414
		private static readonly PhysicsScene.Internal_BoxCastNonAlloc_InjectedDelegate Internal_BoxCastNonAlloc_InjectedDelegateField;

		// Token: 0x020000F0 RID: 240
		// (Invoke) Token: 0x060005B8 RID: 1464
		private delegate bool IsValid_Internal_InjectedDelegate(IntPtr physicsScene);

		// Token: 0x020000F1 RID: 241
		// (Invoke) Token: 0x060005BA RID: 1466
		private delegate bool IsEmpty_Internal_InjectedDelegate(IntPtr physicsScene);

		// Token: 0x020000F2 RID: 242
		// (Invoke) Token: 0x060005BC RID: 1468
		private delegate bool Query_CapsuleCast_InjectedDelegate(IntPtr physicsScene, IntPtr point1, IntPtr point2, float radius, IntPtr direction, float maxDistance, IntPtr hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000F3 RID: 243
		// (Invoke) Token: 0x060005BE RID: 1470
		private delegate int Internal_CapsuleCastNonAlloc_InjectedDelegate(IntPtr physicsScene, IntPtr p0, IntPtr p1, float radius, IntPtr direction, IntPtr raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000F4 RID: 244
		// (Invoke) Token: 0x060005C0 RID: 1472
		private delegate int OverlapCapsuleNonAlloc_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point0, IntPtr point1, float radius, IntPtr results, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x060005C2 RID: 1474
		private delegate bool Query_SphereCast_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, float maxDistance, IntPtr hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000F6 RID: 246
		// (Invoke) Token: 0x060005C4 RID: 1476
		private delegate int Internal_SphereCastNonAlloc_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, IntPtr raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x060005C6 RID: 1478
		private delegate int OverlapSphereNonAlloc_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr position, float radius, IntPtr results, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x060005C8 RID: 1480
		private delegate bool Query_BoxCast_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr direction, IntPtr orientation, float maxDistance, IntPtr outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x060005CA RID: 1482
		private delegate int OverlapBoxNonAlloc_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr results, IntPtr orientation, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x060005CC RID: 1484
		private delegate int Internal_BoxCastNonAlloc_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr direction, IntPtr raycastHits, IntPtr orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);
	}
}
