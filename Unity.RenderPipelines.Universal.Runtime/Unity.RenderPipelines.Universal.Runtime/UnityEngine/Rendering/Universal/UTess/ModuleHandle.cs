using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x02000140 RID: 320
	[StructLayout(2)]
	public struct ModuleHandle
	{
		// Token: 0x06001ABB RID: 6843 RVA: 0x0006FC2C File Offset: 0x0006DE2C
		// Note: this type is marked as 'beforefieldinit'.
		static ModuleHandle()
		{
			Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "ModuleHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr);
			ModuleHandle.NativeFieldInfoPtr_kMaxArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, "kMaxArea");
			ModuleHandle.NativeFieldInfoPtr_kMaxEdgeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, "kMaxEdgeCount");
			ModuleHandle.NativeFieldInfoPtr_kMaxIndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, "kMaxIndexCount");
			ModuleHandle.NativeFieldInfoPtr_kMaxVertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, "kMaxVertexCount");
			ModuleHandle.NativeFieldInfoPtr_kMaxTriangleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, "kMaxTriangleCount");
			ModuleHandle.NativeFieldInfoPtr_kMaxRefineIterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, "kMaxRefineIterations");
			ModuleHandle.NativeFieldInfoPtr_kMaxSmoothenIterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, "kMaxSmoothenIterations");
			ModuleHandle.NativeFieldInfoPtr_kIncrementAreaFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, "kIncrementAreaFactor");
			ModuleHandle.NativeMethodInfoPtr_Copy_Internal_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666425);
			ModuleHandle.NativeMethodInfoPtr_Copy_Internal_Static_Void_NativeArray_1_T_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666426);
			ModuleHandle.NativeMethodInfoPtr_InsertionSort_Internal_Static_Void_ptr_Void_Int32_Int32_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666427);
			ModuleHandle.NativeMethodInfoPtr_GetLower_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666428);
			ModuleHandle.NativeMethodInfoPtr_GetUpper_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666429);
			ModuleHandle.NativeMethodInfoPtr_GetEqual_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666430);
			ModuleHandle.NativeMethodInfoPtr_OrientFast_Internal_Static_Single_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666431);
			ModuleHandle.NativeMethodInfoPtr_OrientFastDouble_Internal_Static_Double_double2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666432);
			ModuleHandle.NativeMethodInfoPtr_CircumCircle_Internal_Static_UCircle_UTriangle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666433);
			ModuleHandle.NativeMethodInfoPtr_IsInsideCircle_Internal_Static_Boolean_UCircle_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666434);
			ModuleHandle.NativeMethodInfoPtr_TriangleArea_Internal_Static_Single_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666435);
			ModuleHandle.NativeMethodInfoPtr_Sign_Internal_Static_Single_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666436);
			ModuleHandle.NativeMethodInfoPtr_IsInsideTriangle_Internal_Static_Boolean_float2_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666437);
			ModuleHandle.NativeMethodInfoPtr_IsInsideTriangleApproximate_Internal_Static_Boolean_float2_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666438);
			ModuleHandle.NativeMethodInfoPtr_IsInsideCircle_Internal_Static_Boolean_float2_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666439);
			ModuleHandle.NativeMethodInfoPtr_BuildTriangles_Internal_Static_Void_NativeArray_1_float2_Int32_NativeArray_1_Int32_Int32_byref_NativeArray_1_UTriangle_byref_Int32_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666440);
			ModuleHandle.NativeMethodInfoPtr_BuildTriangles_Internal_Static_Void_NativeArray_1_float2_Int32_NativeArray_1_Int32_Int32_byref_NativeArray_1_UTriangle_byref_Int32_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666441);
			ModuleHandle.NativeMethodInfoPtr_BuildTrianglesAndEdges_Internal_Static_Void_NativeArray_1_float2_Int32_NativeArray_1_Int32_Int32_byref_NativeArray_1_UTriangle_byref_Int32_byref_NativeArray_1_int4_byref_Int32_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666442);
			ModuleHandle.NativeMethodInfoPtr_CopyGraph_Private_Static_Void_NativeArray_1_float2_Int32_byref_NativeArray_1_float2_byref_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_int2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666443);
			ModuleHandle.NativeMethodInfoPtr_CopyGeometry_Private_Static_Void_NativeArray_1_Int32_Int32_byref_NativeArray_1_Int32_byref_Int32_NativeArray_1_float2_Int32_byref_NativeArray_1_float2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666444);
			ModuleHandle.NativeMethodInfoPtr_TransferOutput_Private_Static_Void_NativeArray_1_int2_Int32_byref_NativeArray_1_int2_byref_Int32_NativeArray_1_Int32_Int32_byref_NativeArray_1_Int32_byref_Int32_NativeArray_1_float2_Int32_byref_NativeArray_1_float2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666445);
			ModuleHandle.NativeMethodInfoPtr_GraphConditioner_Private_Static_Void_NativeArray_1_float2_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666446);
			ModuleHandle.NativeMethodInfoPtr_Reorder_Private_Static_Void_Int32_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_float2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666447);
			ModuleHandle.NativeMethodInfoPtr_VertexCleanupConditioner_Internal_Static_Void_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_float2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666448);
			ModuleHandle.NativeMethodInfoPtr_ConvexQuad_Public_Static_float4_Allocator_NativeArray_1_float2_NativeArray_1_int2_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_int2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666449);
			ModuleHandle.NativeMethodInfoPtr_Tessellate_Public_Static_float4_Allocator_NativeArray_1_float2_NativeArray_1_int2_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_int2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666450);
			ModuleHandle.NativeMethodInfoPtr_Subdivide_Public_Static_float4_Allocator_NativeArray_1_float2_NativeArray_1_int2_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_int2_byref_Int32_Single_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, 100666451);
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0006FF18 File Offset: 0x0006E118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629895, XrefRangeEnd = 629897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy<T>(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.MethodInfoStoreGeneric_Copy_Internal_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0006FF94 File Offset: 0x0006E194
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 629903, RefRangeEnd = 629906, XrefRangeStart = 629897, XrefRangeEnd = 629903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy<T>(NativeArray<T> src, NativeArray<T> dst, int length) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.MethodInfoStoreGeneric_Copy_Internal_Static_Void_NativeArray_1_T_NativeArray_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0006FFF4 File Offset: 0x0006E1F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 629908, RefRangeEnd = 629910, XrefRangeStart = 629906, XrefRangeEnd = 629908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertionSort<T, U>(void* array, int lo, int hi, U comp) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(U).IsValueType)
			{
				U u = comp;
				intPtr = ((u is string) ? IL2CPP.ManagedStringToIl2Cpp(u as string) : IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref comp;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.MethodInfoStoreGeneric_InsertionSort_Internal_Static_Void_ptr_Void_Int32_Int32_U_0<T, U>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0007008C File Offset: 0x0006E28C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629912, RefRangeEnd = 629913, XrefRangeStart = 629910, XrefRangeEnd = 629912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLower<T, U, X>(NativeArray<T> values, int count, U check, X condition) where T : new() where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(values));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(U).IsValueType)
			{
				U u = check;
				intPtr = ((u is string) ? IL2CPP.ManagedStringToIl2Cpp(u as string) : IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref check;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(X).IsValueType)
			{
				X x = condition;
				intPtr2 = ((x is string) ? IL2CPP.ManagedStringToIl2Cpp(x as string) : IL2CPP.Il2CppObjectBaseToPtr(x as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref condition;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.MethodInfoStoreGeneric_GetLower_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0<T, U, X>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x00070170 File Offset: 0x0006E370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629915, RefRangeEnd = 629916, XrefRangeStart = 629913, XrefRangeEnd = 629915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetUpper<T, U, X>(NativeArray<T> values, int count, U check, X condition) where T : new() where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(values));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(U).IsValueType)
			{
				U u = check;
				intPtr = ((u is string) ? IL2CPP.ManagedStringToIl2Cpp(u as string) : IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref check;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(X).IsValueType)
			{
				X x = condition;
				intPtr2 = ((x is string) ? IL2CPP.ManagedStringToIl2Cpp(x as string) : IL2CPP.Il2CppObjectBaseToPtr(x as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref condition;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.MethodInfoStoreGeneric_GetUpper_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0<T, U, X>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x00070254 File Offset: 0x0006E454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629919, RefRangeEnd = 629920, XrefRangeStart = 629916, XrefRangeEnd = 629919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetEqual<T, U, X>(NativeArray<T> values, int count, U check, X condition) where T : new() where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(values));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(U).IsValueType)
			{
				U u = check;
				intPtr = ((u is string) ? IL2CPP.ManagedStringToIl2Cpp(u as string) : IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref check;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(X).IsValueType)
			{
				X x = condition;
				intPtr2 = ((x is string) ? IL2CPP.ManagedStringToIl2Cpp(x as string) : IL2CPP.Il2CppObjectBaseToPtr(x as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref condition;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.MethodInfoStoreGeneric_GetEqual_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0<T, U, X>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00070338 File Offset: 0x0006E538
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 629920, RefRangeEnd = 629926, XrefRangeStart = 629920, XrefRangeEnd = 629920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float OrientFast(float2 a, float2 b, float2 c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_OrientFast_Internal_Static_Single_float2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x00070394 File Offset: 0x0006E594
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 629926, RefRangeEnd = 629930, XrefRangeStart = 629926, XrefRangeEnd = 629926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double OrientFastDouble(double2 a, double2 b, double2 c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_OrientFastDouble_Internal_Static_Double_double2_double2_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x000703F0 File Offset: 0x0006E5F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 629931, RefRangeEnd = 629934, XrefRangeStart = 629930, XrefRangeEnd = 629931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UCircle CircumCircle(UTriangle tri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tri;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_CircumCircle_Internal_Static_UCircle_UTriangle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00070430 File Offset: 0x0006E630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629934, XrefRangeEnd = 629935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInsideCircle(UCircle c, float2 v)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_IsInsideCircle_Internal_Static_Boolean_UCircle_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0007047C File Offset: 0x0006E67C
		[CallerCount(0)]
		public unsafe static float TriangleArea(float2 va, float2 vb, float2 vc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref va;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vb;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_TriangleArea_Internal_Static_Single_float2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x000704D8 File Offset: 0x0006E6D8
		[CallerCount(0)]
		public unsafe static float Sign(float2 p1, float2 p2, float2 p3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_Sign_Internal_Static_Single_float2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00070534 File Offset: 0x0006E734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629935, XrefRangeEnd = 629940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInsideTriangle(float2 pt, float2 v1, float2 v2, float2 v3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_IsInsideTriangle_Internal_Static_Boolean_float2_float2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x0007059C File Offset: 0x0006E79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629940, XrefRangeEnd = 629943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInsideTriangleApproximate(float2 pt, float2 v1, float2 v2, float2 v3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_IsInsideTriangleApproximate_Internal_Static_Boolean_float2_float2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00070604 File Offset: 0x0006E804
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 629945, RefRangeEnd = 629948, XrefRangeStart = 629943, XrefRangeEnd = 629945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInsideCircle(float2 a, float2 b, float2 c, float2 p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_IsInsideCircle_Internal_Static_Boolean_float2_float2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0007066C File Offset: 0x0006E86C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 629952, RefRangeEnd = 629954, XrefRangeStart = 629948, XrefRangeEnd = 629952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildTriangles(NativeArray<float2> vertices, int vertexCount, NativeArray<int> indices, int indexCount, ref NativeArray<UTriangle> triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vertices));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(indices));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(triangles);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &triangleCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxArea;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &avgArea;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &minArea;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_BuildTriangles_Internal_Static_Void_NativeArray_1_float2_Int32_NativeArray_1_Int32_Int32_byref_NativeArray_1_UTriangle_byref_Int32_byref_Single_byref_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x0007072C File Offset: 0x0006E92C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629961, RefRangeEnd = 629962, XrefRangeStart = 629954, XrefRangeEnd = 629961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildTriangles(NativeArray<float2> vertices, int vertexCount, NativeArray<int> indices, int indexCount, ref NativeArray<UTriangle> triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea, ref float maxEdge, ref float avgEdge, ref float minEdge)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vertices));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(indices));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(triangles);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &triangleCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxArea;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &avgArea;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &minArea;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxEdge;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &avgEdge;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &minEdge;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_BuildTriangles_Internal_Static_Void_NativeArray_1_float2_Int32_NativeArray_1_Int32_Int32_byref_NativeArray_1_UTriangle_byref_Int32_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0007081C File Offset: 0x0006EA1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629967, RefRangeEnd = 629968, XrefRangeStart = 629962, XrefRangeEnd = 629967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildTrianglesAndEdges(NativeArray<float2> vertices, int vertexCount, NativeArray<int> indices, int indexCount, ref NativeArray<UTriangle> triangles, ref int triangleCount, ref NativeArray<int4> delaEdges, ref int delaEdgeCount, ref float maxArea, ref float avgArea, ref float minArea)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vertices));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(indices));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(triangles);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &triangleCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(delaEdges);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &delaEdgeCount;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxArea;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &avgArea;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &minArea;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_BuildTrianglesAndEdges_Internal_Static_Void_NativeArray_1_float2_Int32_NativeArray_1_Int32_Int32_byref_NativeArray_1_UTriangle_byref_Int32_byref_NativeArray_1_int4_byref_Int32_byref_Single_byref_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00070900 File Offset: 0x0006EB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629968, XrefRangeEnd = 629977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyGraph(NativeArray<float2> srcPoints, int srcPointCount, ref NativeArray<float2> dstPoints, ref int dstPointCount, NativeArray<int2> srcEdges, int srcEdgeCount, ref NativeArray<int2> dstEdges, ref int dstEdgeCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(srcPoints));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcPointCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(dstPoints);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dstPointCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(srcEdges));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcEdgeCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(dstEdges);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dstEdgeCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_CopyGraph_Private_Static_Void_NativeArray_1_float2_Int32_byref_NativeArray_1_float2_byref_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_int2_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x000709B4 File Offset: 0x0006EBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629977, XrefRangeEnd = 629986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyGeometry(NativeArray<int> srcIndices, int srcIndexCount, ref NativeArray<int> dstIndices, ref int dstIndexCount, NativeArray<float2> srcVertices, int srcVertexCount, ref NativeArray<float2> dstVertices, ref int dstVertexCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(srcIndices));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndexCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(dstIndices);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dstIndexCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(srcVertices));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcVertexCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(dstVertices);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dstVertexCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_CopyGeometry_Private_Static_Void_NativeArray_1_Int32_Int32_byref_NativeArray_1_Int32_byref_Int32_NativeArray_1_float2_Int32_byref_NativeArray_1_float2_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00070A68 File Offset: 0x0006EC68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 629998, RefRangeEnd = 630000, XrefRangeStart = 629986, XrefRangeEnd = 629998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TransferOutput(NativeArray<int2> srcEdges, int srcEdgeCount, ref NativeArray<int2> dstEdges, ref int dstEdgeCount, NativeArray<int> srcIndices, int srcIndexCount, ref NativeArray<int> dstIndices, ref int dstIndexCount, NativeArray<float2> srcVertices, int srcVertexCount, ref NativeArray<float2> dstVertices, ref int dstVertexCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(srcEdges));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcEdgeCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(dstEdges);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dstEdgeCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(srcIndices));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndexCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(dstIndices);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dstIndexCount;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(srcVertices));
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcVertexCount;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(dstVertices);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dstVertexCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_TransferOutput_Private_Static_Void_NativeArray_1_int2_Int32_byref_NativeArray_1_int2_byref_Int32_NativeArray_1_Int32_Int32_byref_NativeArray_1_Int32_byref_Int32_NativeArray_1_float2_Int32_byref_NativeArray_1_float2_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00070B68 File Offset: 0x0006ED68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 630003, RefRangeEnd = 630004, XrefRangeStart = 630000, XrefRangeEnd = 630003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GraphConditioner(NativeArray<float2> points, ref NativeArray<float2> pgPoints, ref int pgPointCount, ref NativeArray<int2> pgEdges, ref int pgEdgeCount, bool resetTopology)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(points));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pgPoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pgPointCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pgEdges);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pgEdgeCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetTopology;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_GraphConditioner_Private_Static_Void_NativeArray_1_float2_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00070BF4 File Offset: 0x0006EDF4
		[CallerCount(0)]
		public unsafe static void Reorder(int startVertexCount, int index, ref NativeArray<int> indices, ref int indexCount, ref NativeArray<float2> vertices, ref int vertexCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startVertexCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(indices);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(vertices);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vertexCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_Reorder_Private_Static_Void_Int32_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_float2_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00070C78 File Offset: 0x0006EE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 630004, XrefRangeEnd = 630007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void VertexCleanupConditioner(int startVertexCount, ref NativeArray<int> indices, ref int indexCount, ref NativeArray<float2> vertices, ref int vertexCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startVertexCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(indices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(vertices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vertexCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_VertexCleanupConditioner_Internal_Static_Void_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_float2_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00070CF0 File Offset: 0x0006EEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 630007, XrefRangeEnd = 630030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 ConvexQuad(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2> outVertices, ref int outVertexCount, ref NativeArray<int> outIndices, ref int outIndexCount, ref NativeArray<int2> outEdges, ref int outEdgeCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allocator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(points));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(edges));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(outVertices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outVertexCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(outIndices);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outIndexCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(outEdges);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outEdgeCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_ConvexQuad_Public_Static_float4_Allocator_NativeArray_1_float2_NativeArray_1_int2_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_int2_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00070DC4 File Offset: 0x0006EFC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 630075, RefRangeEnd = 630076, XrefRangeStart = 630030, XrefRangeEnd = 630075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 Tessellate(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2> outVertices, ref int outVertexCount, ref NativeArray<int> outIndices, ref int outIndexCount, ref NativeArray<int2> outEdges, ref int outEdgeCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allocator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(points));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(edges));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(outVertices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outVertexCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(outIndices);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outIndexCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(outEdges);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outEdgeCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_Tessellate_Public_Static_float4_Allocator_NativeArray_1_float2_NativeArray_1_int2_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_int2_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00070E98 File Offset: 0x0006F098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 630076, XrefRangeEnd = 630160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 Subdivide(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2> outVertices, ref int outVertexCount, ref NativeArray<int> outIndices, ref int outIndexCount, ref NativeArray<int2> outEdges, ref int outEdgeCount, float areaFactor, float targetArea, int refineIterations, int smoothenIterations)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allocator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(points));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(edges));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(outVertices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outVertexCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(outIndices);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outIndexCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(outEdges);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outEdgeCount;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref areaFactor;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetArea;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refineIterations;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothenIterations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleHandle.NativeMethodInfoPtr_Subdivide_Public_Static_float4_Allocator_NativeArray_1_float2_NativeArray_1_int2_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_int2_byref_Int32_Single_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0000F2FB File Offset: 0x0000D4FB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x00070FA8 File Offset: 0x0006F1A8
		// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x0000F30D File Offset: 0x0000D50D
		public unsafe static int kMaxArea
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ModuleHandle.NativeFieldInfoPtr_kMaxArea, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuleHandle.NativeFieldInfoPtr_kMaxArea, (void*)(&value));
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x00070FC4 File Offset: 0x0006F1C4
		// (set) Token: 0x06001ADB RID: 6875 RVA: 0x0000F31B File Offset: 0x0000D51B
		public unsafe static int kMaxEdgeCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ModuleHandle.NativeFieldInfoPtr_kMaxEdgeCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuleHandle.NativeFieldInfoPtr_kMaxEdgeCount, (void*)(&value));
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x00070FE0 File Offset: 0x0006F1E0
		// (set) Token: 0x06001ADD RID: 6877 RVA: 0x0000F329 File Offset: 0x0000D529
		public unsafe static int kMaxIndexCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ModuleHandle.NativeFieldInfoPtr_kMaxIndexCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuleHandle.NativeFieldInfoPtr_kMaxIndexCount, (void*)(&value));
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x00070FFC File Offset: 0x0006F1FC
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x0000F337 File Offset: 0x0000D537
		public unsafe static int kMaxVertexCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ModuleHandle.NativeFieldInfoPtr_kMaxVertexCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuleHandle.NativeFieldInfoPtr_kMaxVertexCount, (void*)(&value));
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x00071018 File Offset: 0x0006F218
		// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x0000F345 File Offset: 0x0000D545
		public unsafe static int kMaxTriangleCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ModuleHandle.NativeFieldInfoPtr_kMaxTriangleCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuleHandle.NativeFieldInfoPtr_kMaxTriangleCount, (void*)(&value));
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x00071034 File Offset: 0x0006F234
		// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x0000F353 File Offset: 0x0000D553
		public unsafe static int kMaxRefineIterations
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ModuleHandle.NativeFieldInfoPtr_kMaxRefineIterations, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuleHandle.NativeFieldInfoPtr_kMaxRefineIterations, (void*)(&value));
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x00071050 File Offset: 0x0006F250
		// (set) Token: 0x06001AE5 RID: 6885 RVA: 0x0000F361 File Offset: 0x0000D561
		public unsafe static int kMaxSmoothenIterations
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ModuleHandle.NativeFieldInfoPtr_kMaxSmoothenIterations, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuleHandle.NativeFieldInfoPtr_kMaxSmoothenIterations, (void*)(&value));
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x0007106C File Offset: 0x0006F26C
		// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x0000F36F File Offset: 0x0000D56F
		public unsafe static float kIncrementAreaFactor
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ModuleHandle.NativeFieldInfoPtr_kIncrementAreaFactor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuleHandle.NativeFieldInfoPtr_kIncrementAreaFactor, (void*)(&value));
			}
		}

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeFieldInfoPtr_kMaxArea;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeFieldInfoPtr_kMaxEdgeCount;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeFieldInfoPtr_kMaxIndexCount;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeFieldInfoPtr_kMaxVertexCount;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeFieldInfoPtr_kMaxTriangleCount;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeFieldInfoPtr_kMaxRefineIterations;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeFieldInfoPtr_kMaxSmoothenIterations;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeFieldInfoPtr_kIncrementAreaFactor;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_Static_Void_NativeArray_1_T_NativeArray_1_T_Int32_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr_InsertionSort_Internal_Static_Void_ptr_Void_Int32_Int32_U_0;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_GetLower_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr_GetUpper_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_GetEqual_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_OrientFast_Internal_Static_Single_float2_float2_float2_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_OrientFastDouble_Internal_Static_Double_double2_double2_double2_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr_CircumCircle_Internal_Static_UCircle_UTriangle_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_IsInsideCircle_Internal_Static_Boolean_UCircle_float2_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_TriangleArea_Internal_Static_Single_float2_float2_float2_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_Sign_Internal_Static_Single_float2_float2_float2_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_IsInsideTriangle_Internal_Static_Boolean_float2_float2_float2_float2_0;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeMethodInfoPtr_IsInsideTriangleApproximate_Internal_Static_Boolean_float2_float2_float2_float2_0;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr_IsInsideCircle_Internal_Static_Boolean_float2_float2_float2_float2_0;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeMethodInfoPtr_BuildTriangles_Internal_Static_Void_NativeArray_1_float2_Int32_NativeArray_1_Int32_Int32_byref_NativeArray_1_UTriangle_byref_Int32_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeMethodInfoPtr_BuildTriangles_Internal_Static_Void_NativeArray_1_float2_Int32_NativeArray_1_Int32_Int32_byref_NativeArray_1_UTriangle_byref_Int32_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_BuildTrianglesAndEdges_Internal_Static_Void_NativeArray_1_float2_Int32_NativeArray_1_Int32_Int32_byref_NativeArray_1_UTriangle_byref_Int32_byref_NativeArray_1_int4_byref_Int32_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_CopyGraph_Private_Static_Void_NativeArray_1_float2_Int32_byref_NativeArray_1_float2_byref_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_int2_byref_Int32_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr_CopyGeometry_Private_Static_Void_NativeArray_1_Int32_Int32_byref_NativeArray_1_Int32_byref_Int32_NativeArray_1_float2_Int32_byref_NativeArray_1_float2_byref_Int32_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_TransferOutput_Private_Static_Void_NativeArray_1_int2_Int32_byref_NativeArray_1_int2_byref_Int32_NativeArray_1_Int32_Int32_byref_NativeArray_1_Int32_byref_Int32_NativeArray_1_float2_Int32_byref_NativeArray_1_float2_byref_Int32_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_GraphConditioner_Private_Static_Void_NativeArray_1_float2_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_Boolean_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_Reorder_Private_Static_Void_Int32_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_float2_byref_Int32_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_VertexCleanupConditioner_Internal_Static_Void_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_float2_byref_Int32_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_ConvexQuad_Public_Static_float4_Allocator_NativeArray_1_float2_NativeArray_1_int2_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_int2_byref_Int32_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_Tessellate_Public_Static_float4_Allocator_NativeArray_1_float2_NativeArray_1_int2_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_int2_byref_Int32_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_Subdivide_Public_Static_float4_Allocator_NativeArray_1_float2_NativeArray_1_int2_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_NativeArray_1_int2_byref_Int32_Single_Single_Int32_Int32_0;

		// Token: 0x0200020E RID: 526
		private sealed class MethodInfoStoreGeneric_Copy_Internal_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0<T>
		{
			// Token: 0x040018E1 RID: 6369
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ModuleHandle.NativeMethodInfoPtr_Copy_Internal_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200020F RID: 527
		private sealed class MethodInfoStoreGeneric_Copy_Internal_Static_Void_NativeArray_1_T_NativeArray_1_T_Int32_0<T>
		{
			// Token: 0x040018E2 RID: 6370
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ModuleHandle.NativeMethodInfoPtr_Copy_Internal_Static_Void_NativeArray_1_T_NativeArray_1_T_Int32_0, Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000210 RID: 528
		private sealed class MethodInfoStoreGeneric_InsertionSort_Internal_Static_Void_ptr_Void_Int32_Int32_U_0<T, U>
		{
			// Token: 0x040018E3 RID: 6371
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ModuleHandle.NativeMethodInfoPtr_InsertionSort_Internal_Static_Void_ptr_Void_Int32_Int32_U_0, Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000211 RID: 529
		private sealed class MethodInfoStoreGeneric_GetLower_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0<T, U, X>
		{
			// Token: 0x040018E4 RID: 6372
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ModuleHandle.NativeMethodInfoPtr_GetLower_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0, Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<X>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000212 RID: 530
		private sealed class MethodInfoStoreGeneric_GetUpper_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0<T, U, X>
		{
			// Token: 0x040018E5 RID: 6373
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ModuleHandle.NativeMethodInfoPtr_GetUpper_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0, Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<X>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000213 RID: 531
		private sealed class MethodInfoStoreGeneric_GetEqual_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0<T, U, X>
		{
			// Token: 0x040018E6 RID: 6374
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ModuleHandle.NativeMethodInfoPtr_GetEqual_Internal_Static_Int32_NativeArray_1_T_Int32_U_X_0, Il2CppClassPointerStore<ModuleHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<X>.NativeClassPtr))
			}))));
		}
	}
}
