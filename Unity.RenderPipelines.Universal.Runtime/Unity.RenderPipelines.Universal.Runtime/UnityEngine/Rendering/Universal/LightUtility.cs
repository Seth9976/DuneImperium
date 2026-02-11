using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200002B RID: 43
	public static class LightUtility : Object
	{
		// Token: 0x0600033D RID: 829 RVA: 0x00021234 File Offset: 0x0001F434
		// Note: this type is marked as 'beforefieldinit'.
		static LightUtility()
		{
			Il2CppClassPointerStore<LightUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LightUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightUtility>.NativeClassPtr);
			LightUtility.NativeMethodInfoPtr_CheckForChange_Public_Static_Boolean_LightType_byref_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, 100663712);
			LightUtility.NativeMethodInfoPtr_CheckForChange_Public_Static_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, 100663713);
			LightUtility.NativeMethodInfoPtr_CheckForChange_Public_Static_Boolean_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, 100663714);
			LightUtility.NativeMethodInfoPtr_CheckForChange_Public_Static_Boolean_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, 100663715);
			LightUtility.NativeMethodInfoPtr_TestPivot_Private_Static_Boolean_List_1_IntPoint_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, 100663716);
			LightUtility.NativeMethodInfoPtr_DegeneratePivots_Private_Static_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, 100663717);
			LightUtility.NativeMethodInfoPtr_SortPivots_Private_Static_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, 100663718);
			LightUtility.NativeMethodInfoPtr_FixPivots_Private_Static_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, 100663719);
			LightUtility.NativeMethodInfoPtr_GetOutlinePath_Internal_Static_List_1_Vector2_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, 100663720);
			LightUtility.NativeMethodInfoPtr_TransferToMesh_Private_Static_Void_NativeArray_1_LightMeshVertex_Int32_NativeArray_1_UInt16_Int32_Light2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, 100663721);
			LightUtility.NativeMethodInfoPtr_GenerateShapeMesh_Public_Static_Bounds_Light2D_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, 100663722);
			LightUtility.NativeMethodInfoPtr_GenerateParametricMesh_Public_Static_Bounds_Light2D_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, 100663723);
			LightUtility.NativeMethodInfoPtr_GenerateSpriteMesh_Public_Static_Bounds_Light2D_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, 100663724);
			LightUtility.NativeMethodInfoPtr_GetShapePathHash_Public_Static_Int32_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, 100663725);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0002137C File Offset: 0x0001F57C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 599974, RefRangeEnd = 599976, XrefRangeStart = 599974, XrefRangeEnd = 599974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckForChange(Light2D.LightType a, ref Light2D.LightType b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightUtility.NativeMethodInfoPtr_CheckForChange_Public_Static_Boolean_LightType_byref_LightType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000213C8 File Offset: 0x0001F5C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 599974, RefRangeEnd = 599976, XrefRangeStart = 599974, XrefRangeEnd = 599976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckForChange(int a, ref int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightUtility.NativeMethodInfoPtr_CheckForChange_Public_Static_Boolean_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00021414 File Offset: 0x0001F614
		[CallerCount(0)]
		public unsafe static bool CheckForChange(float a, ref float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightUtility.NativeMethodInfoPtr_CheckForChange_Public_Static_Boolean_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00021460 File Offset: 0x0001F660
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 599976, RefRangeEnd = 599977, XrefRangeStart = 599976, XrefRangeEnd = 599976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckForChange(bool a, ref bool b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightUtility.NativeMethodInfoPtr_CheckForChange_Public_Static_Boolean_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000214AC File Offset: 0x0001F6AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 599982, RefRangeEnd = 599983, XrefRangeStart = 599977, XrefRangeEnd = 599982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TestPivot(List<IntPoint> path, int activePoint, long lastPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activePoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightUtility.NativeMethodInfoPtr_TestPivot_Private_Static_Boolean_List_1_IntPoint_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0002150C File Offset: 0x0001F70C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 600028, RefRangeEnd = 600029, XrefRangeStart = 599983, XrefRangeEnd = 600028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<IntPoint> DegeneratePivots(List<IntPoint> path, List<IntPoint> inPath, ref int interiorStart)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &interiorStart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightUtility.NativeMethodInfoPtr_DegeneratePivots_Private_Static_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IntPoint>>(intPtr3) : null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00021570 File Offset: 0x0001F770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 600063, RefRangeEnd = 600064, XrefRangeStart = 600029, XrefRangeEnd = 600063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<IntPoint> SortPivots(List<IntPoint> outPath, List<IntPoint> inPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightUtility.NativeMethodInfoPtr_SortPivots_Private_Static_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IntPoint>>(intPtr3) : null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000215C8 File Offset: 0x0001F7C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 600099, RefRangeEnd = 600101, XrefRangeStart = 600064, XrefRangeEnd = 600099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<IntPoint> FixPivots(List<IntPoint> outPath, List<IntPoint> inPath, ref int interiorStart)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &interiorStart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightUtility.NativeMethodInfoPtr_FixPivots_Private_Static_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IntPoint>>(intPtr3) : null;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0002162C File Offset: 0x0001F82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600101, XrefRangeEnd = 600147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2> GetOutlinePath(Il2CppStructArray<Vector3> shapePath, float offsetDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shapePath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightUtility.NativeMethodInfoPtr_GetOutlinePath_Internal_Static_List_1_Vector2_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00021680 File Offset: 0x0001F880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600147, XrefRangeEnd = 600173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TransferToMesh(NativeArray<LightUtility.LightMeshVertex> vertices, int vertexCount, NativeArray<ushort> indices, int indexCount, Light2D light)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vertices));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(indices));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(light);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightUtility.NativeMethodInfoPtr_TransferToMesh_Private_Static_Void_NativeArray_1_LightMeshVertex_Int32_NativeArray_1_UInt16_Int32_Light2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00021704 File Offset: 0x0001F904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 600297, RefRangeEnd = 600298, XrefRangeStart = 600173, XrefRangeEnd = 600297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds GenerateShapeMesh(Light2D light, Il2CppStructArray<Vector3> shapePath, float falloffDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shapePath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref falloffDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightUtility.NativeMethodInfoPtr_GenerateShapeMesh_Public_Static_Bounds_Light2D_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00021768 File Offset: 0x0001F968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 600345, RefRangeEnd = 600346, XrefRangeStart = 600298, XrefRangeEnd = 600345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds GenerateParametricMesh(Light2D light, float radius, float falloffDistance, float angle, int sides)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref falloffDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightUtility.NativeMethodInfoPtr_GenerateParametricMesh_Public_Static_Bounds_Light2D_Single_Single_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000217E4 File Offset: 0x0001F9E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 600403, RefRangeEnd = 600405, XrefRangeStart = 600346, XrefRangeEnd = 600403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds GenerateSpriteMesh(Light2D light, Sprite sprite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightUtility.NativeMethodInfoPtr_GenerateSpriteMesh_Public_Static_Bounds_Light2D_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00021838 File Offset: 0x0001FA38
		[CallerCount(0)]
		public unsafe static int GetShapePathHash(Il2CppStructArray<Vector3> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightUtility.NativeMethodInfoPtr_GetShapePathHash_Public_Static_Int32_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000365F File Offset: 0x0000185F
		public LightUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_CheckForChange_Public_Static_Boolean_LightType_byref_LightType_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_CheckForChange_Public_Static_Boolean_Int32_byref_Int32_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_CheckForChange_Public_Static_Boolean_Single_byref_Single_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_CheckForChange_Public_Static_Boolean_Boolean_byref_Boolean_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_TestPivot_Private_Static_Boolean_List_1_IntPoint_Int32_Int64_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_DegeneratePivots_Private_Static_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_byref_Int32_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_SortPivots_Private_Static_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_FixPivots_Private_Static_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_byref_Int32_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_GetOutlinePath_Internal_Static_List_1_Vector2_Il2CppStructArray_1_Vector3_Single_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_TransferToMesh_Private_Static_Void_NativeArray_1_LightMeshVertex_Int32_NativeArray_1_UInt16_Int32_Light2D_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_GenerateShapeMesh_Public_Static_Bounds_Light2D_Il2CppStructArray_1_Vector3_Single_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_GenerateParametricMesh_Public_Static_Bounds_Light2D_Single_Single_Single_Int32_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSpriteMesh_Public_Static_Bounds_Light2D_Sprite_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_GetShapePathHash_Public_Static_Int32_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0200015A RID: 346
		public enum PivotType
		{
			// Token: 0x04001404 RID: 5124
			PivotBase,
			// Token: 0x04001405 RID: 5125
			PivotCurve,
			// Token: 0x04001406 RID: 5126
			PivotIntersect,
			// Token: 0x04001407 RID: 5127
			PivotSkip,
			// Token: 0x04001408 RID: 5128
			PivotClip
		}

		// Token: 0x0200015B RID: 347
		[Serializable]
		[StructLayout(2)]
		public struct LightMeshVertex
		{
			// Token: 0x06001B7B RID: 7035 RVA: 0x00072664 File Offset: 0x00070864
			// Note: this type is marked as 'beforefieldinit'.
			static LightMeshVertex()
			{
				Il2CppClassPointerStore<LightUtility.LightMeshVertex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightUtility>.NativeClassPtr, "LightMeshVertex");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightUtility.LightMeshVertex>.NativeClassPtr);
				LightUtility.LightMeshVertex.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightUtility.LightMeshVertex>.NativeClassPtr, "position");
				LightUtility.LightMeshVertex.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightUtility.LightMeshVertex>.NativeClassPtr, "color");
				LightUtility.LightMeshVertex.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightUtility.LightMeshVertex>.NativeClassPtr, "uv");
				LightUtility.LightMeshVertex.NativeFieldInfoPtr_VertexLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightUtility.LightMeshVertex>.NativeClassPtr, "VertexLayout");
			}

			// Token: 0x06001B7C RID: 7036 RVA: 0x0000F8C9 File Offset: 0x0000DAC9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightUtility.LightMeshVertex>.NativeClassPtr, ref this));
			}

			// Token: 0x170009E2 RID: 2530
			// (get) Token: 0x06001B7D RID: 7037 RVA: 0x000726E0 File Offset: 0x000708E0
			// (set) Token: 0x06001B7E RID: 7038 RVA: 0x0000F8DB File Offset: 0x0000DADB
			public unsafe static Il2CppStructArray<VertexAttributeDescriptor> VertexLayout
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LightUtility.LightMeshVertex.NativeFieldInfoPtr_VertexLayout, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<VertexAttributeDescriptor>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightUtility.LightMeshVertex.NativeFieldInfoPtr_VertexLayout, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001409 RID: 5129
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x0400140A RID: 5130
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x0400140B RID: 5131
			private static readonly IntPtr NativeFieldInfoPtr_uv;

			// Token: 0x0400140C RID: 5132
			private static readonly IntPtr NativeFieldInfoPtr_VertexLayout;

			// Token: 0x0400140D RID: 5133
			[FieldOffset(0)]
			public Vector3 position;

			// Token: 0x0400140E RID: 5134
			[FieldOffset(12)]
			public Color color;

			// Token: 0x0400140F RID: 5135
			[FieldOffset(28)]
			public Vector2 uv;
		}
	}
}
