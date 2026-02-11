using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000067 RID: 103
	public class DebugShapes : Object
	{
		// Token: 0x0600074E RID: 1870 RVA: 0x00029110 File Offset: 0x00027310
		// Note: this type is marked as 'beforefieldinit'.
		static DebugShapes()
		{
			Il2CppClassPointerStore<DebugShapes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DebugShapes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr);
			DebugShapes.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, "s_Instance");
			DebugShapes.NativeFieldInfoPtr_m_sphereMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, "m_sphereMesh");
			DebugShapes.NativeFieldInfoPtr_m_boxMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, "m_boxMesh");
			DebugShapes.NativeFieldInfoPtr_m_coneMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, "m_coneMesh");
			DebugShapes.NativeFieldInfoPtr_m_pyramidMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, "m_pyramidMesh");
			DebugShapes.NativeMethodInfoPtr_get_instance_Public_Static_get_DebugShapes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, 100664298);
			DebugShapes.NativeMethodInfoPtr_BuildSphere_Private_Void_byref_Mesh_Single_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, 100664299);
			DebugShapes.NativeMethodInfoPtr_BuildBox_Private_Void_byref_Mesh_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, 100664300);
			DebugShapes.NativeMethodInfoPtr_BuildCone_Private_Void_byref_Mesh_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, 100664301);
			DebugShapes.NativeMethodInfoPtr_BuildPyramid_Private_Void_byref_Mesh_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, 100664302);
			DebugShapes.NativeMethodInfoPtr_BuildShapes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, 100664303);
			DebugShapes.NativeMethodInfoPtr_RebuildResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, 100664304);
			DebugShapes.NativeMethodInfoPtr_RequestSphereMesh_Public_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, 100664305);
			DebugShapes.NativeMethodInfoPtr_RequestBoxMesh_Public_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, 100664306);
			DebugShapes.NativeMethodInfoPtr_RequestConeMesh_Public_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, 100664307);
			DebugShapes.NativeMethodInfoPtr_RequestPyramidMesh_Public_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, 100664308);
			DebugShapes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr, 100664309);
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00029294 File Offset: 0x00027494
		public unsafe static DebugShapes instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963549, XrefRangeEnd = 963557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugShapes.NativeMethodInfoPtr_get_instance_Public_Static_get_DebugShapes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugShapes>(intPtr3) : null;
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x000292C8 File Offset: 0x000274C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 963598, RefRangeEnd = 963600, XrefRangeStart = 963557, XrefRangeEnd = 963598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildSphere(ref Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(outputMesh);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref longSubdiv;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref latSubdiv;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DebugShapes.NativeMethodInfoPtr_BuildSphere_Private_Void_byref_Mesh_Single_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outputMesh = ((intPtr4 == 0) ? null : new Mesh(intPtr4));
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0002934C File Offset: 0x0002754C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 963634, RefRangeEnd = 963636, XrefRangeStart = 963600, XrefRangeEnd = 963634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildBox(ref Mesh outputMesh, float length, float width, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(outputMesh);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DebugShapes.NativeMethodInfoPtr_BuildBox_Private_Void_byref_Mesh_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outputMesh = ((intPtr4 == 0) ? null : new Mesh(intPtr4));
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x000293D0 File Offset: 0x000275D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 963673, RefRangeEnd = 963675, XrefRangeStart = 963636, XrefRangeEnd = 963673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildCone(ref Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(outputMesh);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottomRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nbSides;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DebugShapes.NativeMethodInfoPtr_BuildCone_Private_Void_byref_Mesh_Single_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outputMesh = ((intPtr4 == 0) ? null : new Mesh(intPtr4));
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00029460 File Offset: 0x00027660
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 963694, RefRangeEnd = 963696, XrefRangeStart = 963675, XrefRangeEnd = 963694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildPyramid(ref Mesh outputMesh, float width, float height, float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(outputMesh);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DebugShapes.NativeMethodInfoPtr_BuildPyramid_Private_Void_byref_Mesh_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outputMesh = ((intPtr4 == 0) ? null : new Mesh(intPtr4));
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x000294E4 File Offset: 0x000276E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963696, XrefRangeEnd = 963717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildShapes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugShapes.NativeMethodInfoPtr_BuildShapes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00029518 File Offset: 0x00027718
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 963751, RefRangeEnd = 963755, XrefRangeStart = 963717, XrefRangeEnd = 963751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugShapes.NativeMethodInfoPtr_RebuildResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0002954C File Offset: 0x0002774C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963755, XrefRangeEnd = 963756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mesh RequestSphereMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugShapes.NativeMethodInfoPtr_RequestSphereMesh_Public_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0002958C File Offset: 0x0002778C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963756, XrefRangeEnd = 963757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mesh RequestBoxMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugShapes.NativeMethodInfoPtr_RequestBoxMesh_Public_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x000295CC File Offset: 0x000277CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963757, XrefRangeEnd = 963758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mesh RequestConeMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugShapes.NativeMethodInfoPtr_RequestConeMesh_Public_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0002960C File Offset: 0x0002780C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963758, XrefRangeEnd = 963759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mesh RequestPyramidMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugShapes.NativeMethodInfoPtr_RequestPyramidMesh_Public_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0002964C File Offset: 0x0002784C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugShapes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugShapes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugShapes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00004E9E File Offset: 0x0000309E
		public DebugShapes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00029688 File Offset: 0x00027888
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x00004EA7 File Offset: 0x000030A7
		public unsafe static DebugShapes s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugShapes.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugShapes>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugShapes.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x000296B0 File Offset: 0x000278B0
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00004EB9 File Offset: 0x000030B9
		public unsafe Mesh m_sphereMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugShapes.NativeFieldInfoPtr_m_sphereMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugShapes.NativeFieldInfoPtr_m_sphereMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x000296E0 File Offset: 0x000278E0
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00004ED8 File Offset: 0x000030D8
		public unsafe Mesh m_boxMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugShapes.NativeFieldInfoPtr_m_boxMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugShapes.NativeFieldInfoPtr_m_boxMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00029710 File Offset: 0x00027910
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x00004EF7 File Offset: 0x000030F7
		public unsafe Mesh m_coneMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugShapes.NativeFieldInfoPtr_m_coneMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugShapes.NativeFieldInfoPtr_m_coneMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00029740 File Offset: 0x00027940
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x00004F16 File Offset: 0x00003116
		public unsafe Mesh m_pyramidMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugShapes.NativeFieldInfoPtr_m_pyramidMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugShapes.NativeFieldInfoPtr_m_pyramidMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr_m_sphereMesh;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeFieldInfoPtr_m_boxMesh;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeFieldInfoPtr_m_coneMesh;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeFieldInfoPtr_m_pyramidMesh;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_DebugShapes_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_BuildSphere_Private_Void_byref_Mesh_Single_UInt32_UInt32_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_BuildBox_Private_Void_byref_Mesh_Single_Single_Single_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_BuildCone_Private_Void_byref_Mesh_Single_Single_Single_Int32_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_BuildPyramid_Private_Void_byref_Mesh_Single_Single_Single_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_BuildShapes_Private_Void_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_RebuildResources_Private_Void_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_RequestSphereMesh_Public_Mesh_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_RequestBoxMesh_Public_Mesh_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_RequestConeMesh_Public_Mesh_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_RequestPyramidMesh_Public_Mesh_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
