using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x020000DD RID: 221
	public class MeshGizmo : Object
	{
		// Token: 0x0600102D RID: 4141 RVA: 0x0004AE3C File Offset: 0x0004903C
		// Note: this type is marked as 'beforefieldinit'.
		static MeshGizmo()
		{
			Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "MeshGizmo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr);
			MeshGizmo.NativeFieldInfoPtr_vertexCountPerCube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, "vertexCountPerCube");
			MeshGizmo.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, "mesh");
			MeshGizmo.NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, "vertices");
			MeshGizmo.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, "indices");
			MeshGizmo.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, "colors");
			MeshGizmo.NativeFieldInfoPtr_wireMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, "wireMaterial");
			MeshGizmo.NativeFieldInfoPtr_dottedWireMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, "dottedWireMaterial");
			MeshGizmo.NativeFieldInfoPtr_solidMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, "solidMaterial");
			MeshGizmo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, 100665704);
			MeshGizmo.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, 100665705);
			MeshGizmo.NativeMethodInfoPtr_AddWireCube_Public_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, 100665706);
			MeshGizmo.NativeMethodInfoPtr_DrawMesh_Private_Void_Matrix4x4_Material_MeshTopology_CompareFunction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, 100665707);
			MeshGizmo.NativeMethodInfoPtr_RenderWireframe_Public_Void_Matrix4x4_CompareFunction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, 100665708);
			MeshGizmo.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, 100665709);
			MeshGizmo.NativeMethodInfoPtr_Method_Private_Void_Vector3_Vector3_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, 100665711);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0004AF98 File Offset: 0x00049198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977559, XrefRangeEnd = 977589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshGizmo(int capacity = 0)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGizmo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0004AFE0 File Offset: 0x000491E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977589, XrefRangeEnd = 977592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGizmo.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0004B014 File Offset: 0x00049214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977592, XrefRangeEnd = 977605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddWireCube(Vector3 center, Vector3 size, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGizmo.NativeMethodInfoPtr_AddWireCube_Public_Void_Vector3_Vector3_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0004B070 File Offset: 0x00049270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977605, XrefRangeEnd = 977624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawMesh(Matrix4x4 trs, Material mat, MeshTopology topology, CompareFunction depthTest, string gizmoName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref trs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTest;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gizmoName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGizmo.NativeMethodInfoPtr_DrawMesh_Private_Void_Matrix4x4_Material_MeshTopology_CompareFunction_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0004B0F0 File Offset: 0x000492F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977624, XrefRangeEnd = 977643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderWireframe(Matrix4x4 trs, CompareFunction depthTest = CompareFunction.LessEqual, string gizmoName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref trs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gizmoName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGizmo.NativeMethodInfoPtr_RenderWireframe_Public_Void_Matrix4x4_CompareFunction_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0004B150 File Offset: 0x00049350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977643, XrefRangeEnd = 977647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGizmo.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0004B184 File Offset: 0x00049384
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 977668, RefRangeEnd = 977680, XrefRangeStart = 977647, XrefRangeEnd = 977668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Vector3_Vector3_byref___c__DisplayClass10_0_0(Vector3 p1, Vector3 p2, ref MeshGizmo.__c__DisplayClass10_0 A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGizmo.NativeMethodInfoPtr_Method_Private_Void_Vector3_Vector3_byref___c__DisplayClass10_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x000088B8 File Offset: 0x00006AB8
		public MeshGizmo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x0004B1E4 File Offset: 0x000493E4
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x000088C1 File Offset: 0x00006AC1
		public unsafe static int vertexCountPerCube
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MeshGizmo.NativeFieldInfoPtr_vertexCountPerCube, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshGizmo.NativeFieldInfoPtr_vertexCountPerCube, (void*)(&value));
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x0004B200 File Offset: 0x00049400
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x000088CF File Offset: 0x00006ACF
		public unsafe Mesh mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x0004B230 File Offset: 0x00049430
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x000088EE File Offset: 0x00006AEE
		public unsafe List<Vector3> vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_vertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x0004B260 File Offset: 0x00049460
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x0000890D File Offset: 0x00006B0D
		public unsafe List<int> indices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_indices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_indices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x0004B290 File Offset: 0x00049490
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x0000892C File Offset: 0x00006B2C
		public unsafe List<Color> colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x0004B2C0 File Offset: 0x000494C0
		// (set) Token: 0x06001041 RID: 4161 RVA: 0x0000894B File Offset: 0x00006B4B
		public unsafe Material wireMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_wireMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_wireMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0004B2F0 File Offset: 0x000494F0
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x0000896A File Offset: 0x00006B6A
		public unsafe Material dottedWireMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_dottedWireMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_dottedWireMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x0004B320 File Offset: 0x00049520
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x00008989 File Offset: 0x00006B89
		public unsafe Material solidMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_solidMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_solidMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeFieldInfoPtr_vertexCountPerCube;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeFieldInfoPtr_mesh;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeFieldInfoPtr_vertices;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeFieldInfoPtr_indices;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeFieldInfoPtr_wireMaterial;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeFieldInfoPtr_dottedWireMaterial;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeFieldInfoPtr_solidMaterial;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_AddWireCube_Public_Void_Vector3_Vector3_Color_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Private_Void_Matrix4x4_Material_MeshTopology_CompareFunction_String_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_RenderWireframe_Public_Void_Matrix4x4_CompareFunction_String_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Vector3_Vector3_byref___c__DisplayClass10_0_0;

		// Token: 0x02000204 RID: 516
		[ObfuscatedName("UnityEngine.Rendering.MeshGizmo+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : ValueType
		{
			// Token: 0x06001AF1 RID: 6897 RVA: 0x0006E6E8 File Offset: 0x0006C8E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<MeshGizmo.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGizmo.__c__DisplayClass10_0>.NativeClassPtr);
				MeshGizmo.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGizmo.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				MeshGizmo.__c__DisplayClass10_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGizmo.__c__DisplayClass10_0>.NativeClassPtr, "color");
			}

			// Token: 0x06001AF2 RID: 6898 RVA: 0x0000D7F0 File Offset: 0x0000B9F0
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001AF3 RID: 6899 RVA: 0x0000D7F9 File Offset: 0x0000B9F9
			public __c__DisplayClass10_0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGizmo.__c__DisplayClass10_0>.NativeClassPtr))
			{
			}

			// Token: 0x1700079E RID: 1950
			// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x0006E73C File Offset: 0x0006C93C
			// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x0000D80B File Offset: 0x0000BA0B
			public unsafe MeshGizmo __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshGizmo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079F RID: 1951
			// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x0006E76C File Offset: 0x0006C96C
			// (set) Token: 0x06001AF7 RID: 6903 RVA: 0x0000D82A File Offset: 0x0000BA2A
			public unsafe Color color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.__c__DisplayClass10_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGizmo.__c__DisplayClass10_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x040013A7 RID: 5031
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013A8 RID: 5032
			private static readonly IntPtr NativeFieldInfoPtr_color;
		}
	}
}
