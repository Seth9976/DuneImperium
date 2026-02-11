using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000082 RID: 130
	public sealed class GeometryUtility : Object
	{
		// Token: 0x060006C9 RID: 1737 RVA: 0x0002C440 File Offset: 0x0002A640
		// Note: this type is marked as 'beforefieldinit'.
		static GeometryUtility()
		{
			Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GeometryUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr);
			GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Il2CppStructArray_1_Plane_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664130);
			GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664131);
			GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664132);
			GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664133);
			GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Private_Static_Void_Il2CppStructArray_1_Plane_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664134);
			GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_Il2CppStructArray_1_Plane_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664135);
			GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_Il2CppStructArray_1_Plane_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664136);
			GeometryUtility.Internal_CalculateBounds_InjectedDelegateField = IL2CPP.ResolveICall<GeometryUtility.Internal_CalculateBounds_InjectedDelegate>("UnityEngine.GeometryUtility::Internal_CalculateBounds_Injected");
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0002C50C File Offset: 0x0002A70C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 648601, RefRangeEnd = 648603, XrefRangeStart = 648591, XrefRangeEnd = 648601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Plane> CalculateFrustumPlanes(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Il2CppStructArray_1_Plane_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Plane>>(intPtr3) : null;
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0002C550 File Offset: 0x0002A750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 648610, RefRangeEnd = 648611, XrefRangeStart = 648603, XrefRangeEnd = 648610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateFrustumPlanes(Camera camera, Il2CppStructArray<Plane> planes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0002C598 File Offset: 0x0002A798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 648613, RefRangeEnd = 648614, XrefRangeStart = 648611, XrefRangeEnd = 648613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Il2CppStructArray<Plane> planes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref worldToProjectionMatrix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0002C5DC File Offset: 0x0002A7DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 648616, RefRangeEnd = 648619, XrefRangeStart = 648614, XrefRangeEnd = 648616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TestPlanesAABB(Il2CppStructArray<Plane> planes, Bounds bounds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0002C62C File Offset: 0x0002A82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648619, XrefRangeEnd = 648621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ExtractPlanes([Out] Il2CppStructArray<Plane> planes, Matrix4x4 worldToProjectionMatrix)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldToProjectionMatrix;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Private_Static_Void_Il2CppStructArray_1_Plane_Matrix4x4_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*planes = ((intPtr4 == 0) ? null : new Il2CppStructArray<Plane>(intPtr4));
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0002C680 File Offset: 0x0002A880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648621, XrefRangeEnd = 648623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TestPlanesAABB_Injected(Il2CppStructArray<Plane> planes, ref Bounds bounds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_Il2CppStructArray_1_Plane_byref_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0002C6D0 File Offset: 0x0002A8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648623, XrefRangeEnd = 648625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ExtractPlanes_Injected([Out] Il2CppStructArray<Plane> planes, ref Matrix4x4 worldToProjectionMatrix)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &worldToProjectionMatrix;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_Il2CppStructArray_1_Plane_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*planes = ((intPtr4 == 0) ? null : new Il2CppStructArray<Plane>(intPtr4));
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00004A95 File Offset: 0x00002C95
		public GeometryUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00004A9E File Offset: 0x00002C9E
		public static Il2CppStructArray<Plane> CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0002C724 File Offset: 0x0002A924
		public static Bounds CalculateBounds(Il2CppStructArray<Vector3> positions, Matrix4x4 transform)
		{
			bool flag = positions == null;
			if (flag)
			{
				throw new ArgumentNullException("positions");
			}
			bool flag2 = positions.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.", "positions");
			}
			return GeometryUtility.Internal_CalculateBounds(positions, transform);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0002C770 File Offset: 0x0002A970
		public static bool TryCreatePlaneFromPolygon(Il2CppStructArray<Vector3> vertices, out Plane plane)
		{
			bool flag = vertices == null || vertices.Length < 3;
			bool flag2;
			if (flag)
			{
				plane = new Plane(Vector3.up, 0f);
				flag2 = false;
			}
			else
			{
				bool flag3 = vertices.Length == 3;
				if (flag3)
				{
					Vector3 vector = vertices[0];
					Vector3 vector2 = vertices[1];
					Vector3 vector3 = vertices[2];
					plane = new Plane(vector, vector2, vector3);
					flag2 = plane.normal.sqrMagnitude > 0f;
				}
				else
				{
					Vector3 zero = Vector3.zero;
					int num = vertices.Length - 1;
					Vector3 vector4 = vertices[num];
					for (int i = 0; i < vertices.Length; i++)
					{
						Vector3 vector5 = vertices[i];
						zero.x += (vector4.y - vector5.y) * (vector4.z + vector5.z);
						zero.y += (vector4.z - vector5.z) * (vector4.x + vector5.x);
						zero.z += (vector4.x - vector5.x) * (vector4.y + vector5.y);
						vector4 = vector5;
					}
					zero.Normalize();
					float num2 = 0f;
					for (int j = 0; j < vertices.Length; j++)
					{
						Vector3 vector6 = vertices[j];
						num2 -= Vector3.Dot(zero, vector6);
					}
					num2 /= (float)vertices.Length;
					plane = new Plane(zero, num2);
					flag2 = plane.normal.sqrMagnitude > 0f;
				}
			}
			return flag2;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0002C94C File Offset: 0x0002AB4C
		public static Bounds Internal_CalculateBounds(Il2CppStructArray<Vector3> positions, Matrix4x4 transform)
		{
			Bounds bounds;
			GeometryUtility.Internal_CalculateBounds_Injected(positions, ref transform, out bounds);
			return bounds;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00004AAB File Offset: 0x00002CAB
		public static void Internal_CalculateBounds_Injected(Il2CppStructArray<Vector3> positions, ref Matrix4x4 transform, out Bounds ret)
		{
			GeometryUtility.Internal_CalculateBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(positions), ref transform, out ret);
		}

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Il2CppStructArray_1_Plane_Camera_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ExtractPlanes_Private_Static_Void_Il2CppStructArray_1_Plane_Matrix4x4_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_Il2CppStructArray_1_Plane_byref_Bounds_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_Il2CppStructArray_1_Plane_byref_Matrix4x4_0;

		// Token: 0x040005BC RID: 1468
		private static readonly GeometryUtility.Internal_CalculateBounds_InjectedDelegate Internal_CalculateBounds_InjectedDelegateField;

		// Token: 0x020004AA RID: 1194
		// (Invoke) Token: 0x0600325D RID: 12893
		private delegate void Internal_CalculateBounds_InjectedDelegate(IntPtr positions, IntPtr transform, [Out] IntPtr ret);
	}
}
