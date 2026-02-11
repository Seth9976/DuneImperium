using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace voodoo.pathing.Meshes
{
	// Token: 0x02000038 RID: 56
	public class PathVoodooMesh : MonoBehaviour
	{
		// Token: 0x0600036C RID: 876 RVA: 0x000143D8 File Offset: 0x000125D8
		// Note: this type is marked as 'beforefieldinit'.
		static PathVoodooMesh()
		{
			Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.pathing.Meshes", "PathVoodooMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr);
			PathVoodooMesh.NativeFieldInfoPtr__mf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "_mf");
			PathVoodooMesh.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "mesh");
			PathVoodooMesh.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "path");
			PathVoodooMesh.NativeFieldInfoPtr_startingFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "startingFrom");
			PathVoodooMesh.NativeFieldInfoPtr_endTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "endTo");
			PathVoodooMesh.NativeFieldInfoPtr_pieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "pieces");
			PathVoodooMesh.NativeFieldInfoPtr_sections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "sections");
			PathVoodooMesh.NativeFieldInfoPtr_flipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "flipped");
			PathVoodooMesh.NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "vertices");
			PathVoodooMesh.NativeFieldInfoPtr_triangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "triangles");
			PathVoodooMesh.NativeFieldInfoPtr_triangles2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "triangles2");
			PathVoodooMesh.NativeFieldInfoPtr_triangles3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "triangles3");
			PathVoodooMesh.NativeFieldInfoPtr_normals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "normals");
			PathVoodooMesh.NativeFieldInfoPtr_UVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "UVs");
			PathVoodooMesh.NativeFieldInfoPtr_autoUpdateMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, "autoUpdateMesh");
			PathVoodooMesh.NativeMethodInfoPtr_Generate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, 100663688);
			PathVoodooMesh.NativeMethodInfoPtr_AddQuad1_Protected_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, 100663689);
			PathVoodooMesh.NativeMethodInfoPtr_AddQuad2_Protected_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, 100663690);
			PathVoodooMesh.NativeMethodInfoPtr_AddQuad3_Protected_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, 100663691);
			PathVoodooMesh.NativeMethodInfoPtr_GetNumberOfMaterials_Protected_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, 100663692);
			PathVoodooMesh.NativeMethodInfoPtr_InitializeMesh_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, 100663693);
			PathVoodooMesh.NativeMethodInfoPtr_FinalizeMesh_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, 100663694);
			PathVoodooMesh.NativeMethodInfoPtr_GenerateMeshPart_Protected_Abstract_Virtual_New_Void_Int32_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, 100663695);
			PathVoodooMesh.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr, 100663696);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000145E8 File Offset: 0x000127E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108569, XrefRangeEnd = 1108678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Generate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooMesh.NativeMethodInfoPtr_Generate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0001461C File Offset: 0x0001281C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1108696, RefRangeEnd = 1108698, XrefRangeStart = 1108678, XrefRangeEnd = 1108696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddQuad1(int a, int b, int c, int d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooMesh.NativeMethodInfoPtr_AddQuad1_Protected_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00014684 File Offset: 0x00012884
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1108716, RefRangeEnd = 1108718, XrefRangeStart = 1108698, XrefRangeEnd = 1108716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddQuad2(int a, int b, int c, int d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooMesh.NativeMethodInfoPtr_AddQuad2_Protected_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000146EC File Offset: 0x000128EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1108736, RefRangeEnd = 1108738, XrefRangeStart = 1108718, XrefRangeEnd = 1108736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddQuad3(int a, int b, int c, int d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooMesh.NativeMethodInfoPtr_AddQuad3_Protected_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00014754 File Offset: 0x00012954
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetNumberOfMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodooMesh.NativeMethodInfoPtr_GetNumberOfMaterials_Protected_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0001479C File Offset: 0x0001299C
		[CallerCount(0)]
		public unsafe virtual void InitializeMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodooMesh.NativeMethodInfoPtr_InitializeMesh_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000147D8 File Offset: 0x000129D8
		[CallerCount(0)]
		public unsafe virtual void FinalizeMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodooMesh.NativeMethodInfoPtr_FinalizeMesh_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00014814 File Offset: 0x00012A14
		[CallerCount(0)]
		public unsafe virtual void GenerateMeshPart(int piece, Vector3 position, Vector3 direction, Vector3 xd, Vector3 yd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref piece;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xd;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodooMesh.NativeMethodInfoPtr_GenerateMeshPart_Protected_Abstract_Virtual_New_Void_Int32_Vector3_Vector3_Vector3_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00014898 File Offset: 0x00012A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108738, XrefRangeEnd = 1108739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathVoodooMesh()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathVoodooMesh>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooMesh.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00003B9F File Offset: 0x00001D9F
		public PathVoodooMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000377 RID: 887 RVA: 0x000148D4 File Offset: 0x00012AD4
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00003BA8 File Offset: 0x00001DA8
		public unsafe MeshFilter _mf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr__mf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr__mf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00014904 File Offset: 0x00012B04
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00003BC7 File Offset: 0x00001DC7
		public unsafe Mesh mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00014934 File Offset: 0x00012B34
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00003BE6 File Offset: 0x00001DE6
		public unsafe PathVoodoo path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathVoodoo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00014964 File Offset: 0x00012B64
		// (set) Token: 0x0600037E RID: 894 RVA: 0x00003C05 File Offset: 0x00001E05
		public unsafe float startingFrom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_startingFrom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_startingFrom)) = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0001498C File Offset: 0x00012B8C
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00003C20 File Offset: 0x00001E20
		public unsafe float endTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_endTo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_endTo)) = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000381 RID: 897 RVA: 0x000149B4 File Offset: 0x00012BB4
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00003C3B File Offset: 0x00001E3B
		public unsafe int pieces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_pieces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_pieces)) = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000383 RID: 899 RVA: 0x000149DC File Offset: 0x00012BDC
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00003C56 File Offset: 0x00001E56
		public unsafe int sections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_sections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_sections)) = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00014A04 File Offset: 0x00012C04
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00003C71 File Offset: 0x00001E71
		public unsafe bool flipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_flipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_flipped)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00014A2C File Offset: 0x00012C2C
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00003C8C File Offset: 0x00001E8C
		public unsafe List<Vector3> vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_vertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00014A5C File Offset: 0x00012C5C
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00003CAB File Offset: 0x00001EAB
		public unsafe List<int> triangles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_triangles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_triangles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00014A8C File Offset: 0x00012C8C
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00003CCA File Offset: 0x00001ECA
		public unsafe List<int> triangles2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_triangles2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_triangles2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00014ABC File Offset: 0x00012CBC
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00003CE9 File Offset: 0x00001EE9
		public unsafe List<int> triangles3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_triangles3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_triangles3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00014AEC File Offset: 0x00012CEC
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00003D08 File Offset: 0x00001F08
		public unsafe List<Vector3> normals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_normals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_normals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00014B1C File Offset: 0x00012D1C
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00003D27 File Offset: 0x00001F27
		public unsafe List<Vector2> UVs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_UVs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_UVs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00014B4C File Offset: 0x00012D4C
		// (set) Token: 0x06000394 RID: 916 RVA: 0x00003D46 File Offset: 0x00001F46
		public unsafe bool autoUpdateMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_autoUpdateMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooMesh.NativeFieldInfoPtr_autoUpdateMesh)) = value;
			}
		}

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeFieldInfoPtr__mf;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeFieldInfoPtr_mesh;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr_startingFrom;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_endTo;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeFieldInfoPtr_pieces;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeFieldInfoPtr_sections;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeFieldInfoPtr_flipped;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeFieldInfoPtr_vertices;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeFieldInfoPtr_triangles;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeFieldInfoPtr_triangles2;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeFieldInfoPtr_triangles3;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeFieldInfoPtr_normals;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr_UVs;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeFieldInfoPtr_autoUpdateMesh;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Void_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_AddQuad1_Protected_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_AddQuad2_Protected_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_AddQuad3_Protected_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberOfMaterials_Protected_Virtual_New_Int32_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_InitializeMesh_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeMesh_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMeshPart_Protected_Abstract_Virtual_New_Void_Int32_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
