using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200025D RID: 605
	public static class MeshBuilder : Object
	{
		// Token: 0x06002C7A RID: 11386 RVA: 0x000BFA24 File Offset: 0x000BDC24
		// Note: this type is marked as 'beforefieldinit'.
		static MeshBuilder()
		{
			Il2CppClassPointerStore<MeshBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "MeshBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshBuilder>.NativeClassPtr);
			MeshBuilder.NativeFieldInfoPtr_s_VectorGraphics9Slice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilder>.NativeClassPtr, "s_VectorGraphics9Slice");
			MeshBuilder.NativeFieldInfoPtr_s_VectorGraphicsSplitTriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilder>.NativeClassPtr, "s_VectorGraphicsSplitTriangle");
			MeshBuilder.NativeFieldInfoPtr_s_VectorGraphicsScaleTriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilder>.NativeClassPtr, "s_VectorGraphicsScaleTriangle");
			MeshBuilder.NativeFieldInfoPtr_s_VectorGraphicsStretch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilder>.NativeClassPtr, "s_VectorGraphicsStretch");
			MeshBuilder.NativeFieldInfoPtr_s_MaxTextMeshVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilder>.NativeClassPtr, "s_MaxTextMeshVertices");
			MeshBuilder.NativeMethodInfoPtr_ConvertTextVertexToUIRVertex_Private_Static_Vertex_MeshInfo_Int32_Vector2_VertexFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilder>.NativeClassPtr, 100669866);
			MeshBuilder.NativeMethodInfoPtr_LimitTextVertices_Private_Static_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilder>.NativeClassPtr, 100669867);
			MeshBuilder.NativeMethodInfoPtr_MakeText_Internal_Static_Void_MeshInfo_Vector2_AllocMeshData_VertexFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilder>.NativeClassPtr, 100669868);
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x000BFAF4 File Offset: 0x000BDCF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 350356, RefRangeEnd = 350360, XrefRangeStart = 350355, XrefRangeEnd = 350356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vertex ConvertTextVertexToUIRVertex(MeshInfo info, int index, Vector2 offset, VertexFlags flags = VertexFlags.IsText, bool isDynamicColor = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDynamicColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilder.NativeMethodInfoPtr_ConvertTextVertexToUIRVertex_Private_Static_Vertex_MeshInfo_Int32_Vector2_VertexFlags_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x000BFB74 File Offset: 0x000BDD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350360, XrefRangeEnd = 350379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LimitTextVertices(int vertexCount, bool logTruncation = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logTruncation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilder.NativeMethodInfoPtr_LimitTextVertices_Private_Static_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x000BFBC0 File Offset: 0x000BDDC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350438, RefRangeEnd = 350439, XrefRangeStart = 350379, XrefRangeEnd = 350438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MakeText(MeshInfo meshInfo, Vector2 offset, MeshBuilder.AllocMeshData meshAlloc, VertexFlags flags = VertexFlags.IsText, bool isDynamicColor = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(meshInfo));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(meshAlloc));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDynamicColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilder.NativeMethodInfoPtr_MakeText_Internal_Static_Void_MeshInfo_Vector2_AllocMeshData_VertexFlags_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x00012100 File Offset: 0x00010300
		public MeshBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06002C7F RID: 11391 RVA: 0x000BFC3C File Offset: 0x000BDE3C
		// (set) Token: 0x06002C80 RID: 11392 RVA: 0x00012109 File Offset: 0x00010309
		public unsafe static ProfilerMarker s_VectorGraphics9Slice
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(MeshBuilder.NativeFieldInfoPtr_s_VectorGraphics9Slice, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshBuilder.NativeFieldInfoPtr_s_VectorGraphics9Slice, (void*)(&value));
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06002C81 RID: 11393 RVA: 0x000BFC58 File Offset: 0x000BDE58
		// (set) Token: 0x06002C82 RID: 11394 RVA: 0x00012117 File Offset: 0x00010317
		public unsafe static ProfilerMarker s_VectorGraphicsSplitTriangle
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(MeshBuilder.NativeFieldInfoPtr_s_VectorGraphicsSplitTriangle, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshBuilder.NativeFieldInfoPtr_s_VectorGraphicsSplitTriangle, (void*)(&value));
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06002C83 RID: 11395 RVA: 0x000BFC74 File Offset: 0x000BDE74
		// (set) Token: 0x06002C84 RID: 11396 RVA: 0x00012125 File Offset: 0x00010325
		public unsafe static ProfilerMarker s_VectorGraphicsScaleTriangle
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(MeshBuilder.NativeFieldInfoPtr_s_VectorGraphicsScaleTriangle, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshBuilder.NativeFieldInfoPtr_s_VectorGraphicsScaleTriangle, (void*)(&value));
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06002C85 RID: 11397 RVA: 0x000BFC90 File Offset: 0x000BDE90
		// (set) Token: 0x06002C86 RID: 11398 RVA: 0x00012133 File Offset: 0x00010333
		public unsafe static ProfilerMarker s_VectorGraphicsStretch
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(MeshBuilder.NativeFieldInfoPtr_s_VectorGraphicsStretch, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshBuilder.NativeFieldInfoPtr_s_VectorGraphicsStretch, (void*)(&value));
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06002C87 RID: 11399 RVA: 0x000BFCAC File Offset: 0x000BDEAC
		// (set) Token: 0x06002C88 RID: 11400 RVA: 0x00012141 File Offset: 0x00010341
		public unsafe static int s_MaxTextMeshVertices
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MeshBuilder.NativeFieldInfoPtr_s_MaxTextMeshVertices, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshBuilder.NativeFieldInfoPtr_s_MaxTextMeshVertices, (void*)(&value));
			}
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x000BFCC8 File Offset: 0x000BDEC8
		public static Vertex ConvertTextVertexToUIRVertex(TextVertex textVertex, Vector2 offset)
		{
			return new Vertex
			{
				position = new Vector3(textVertex.position.x + offset.x, textVertex.position.y + offset.y, 0f),
				uv = textVertex.uv0,
				tint = textVertex.color,
				flags = new Color32(1, 0, 0, 0)
			};
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x000BFD44 File Offset: 0x000BDF44
		public static void MakeText(NativeArray<TextVertex> uiVertices, Vector2 offset, MeshBuilder.AllocMeshData meshAlloc)
		{
			int num = MeshBuilder.LimitTextVertices(uiVertices.Length, true);
			int num2 = num / 4;
			MeshWriteData meshWriteData = meshAlloc.Allocate((uint)(num2 * 4), (uint)(num2 * 6));
			int i = 0;
			int num3 = 0;
			while (i < num2)
			{
				meshWriteData.SetNextVertex(MeshBuilder.ConvertTextVertexToUIRVertex(uiVertices[num3], offset));
				meshWriteData.SetNextVertex(MeshBuilder.ConvertTextVertexToUIRVertex(uiVertices[num3 + 1], offset));
				meshWriteData.SetNextVertex(MeshBuilder.ConvertTextVertexToUIRVertex(uiVertices[num3 + 2], offset));
				meshWriteData.SetNextVertex(MeshBuilder.ConvertTextVertexToUIRVertex(uiVertices[num3 + 3], offset));
				meshWriteData.SetNextIndex((ushort)num3);
				meshWriteData.SetNextIndex((ushort)(num3 + 1));
				meshWriteData.SetNextIndex((ushort)(num3 + 2));
				meshWriteData.SetNextIndex((ushort)(num3 + 2));
				meshWriteData.SetNextIndex((ushort)(num3 + 3));
				meshWriteData.SetNextIndex((ushort)num3);
				i++;
				num3 += 4;
			}
		}

		// Token: 0x04001FE2 RID: 8162
		private static readonly IntPtr NativeFieldInfoPtr_s_VectorGraphics9Slice;

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeFieldInfoPtr_s_VectorGraphicsSplitTriangle;

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeFieldInfoPtr_s_VectorGraphicsScaleTriangle;

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeFieldInfoPtr_s_VectorGraphicsStretch;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeFieldInfoPtr_s_MaxTextMeshVertices;

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTextVertexToUIRVertex_Private_Static_Vertex_MeshInfo_Int32_Vector2_VertexFlags_Boolean_0;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeMethodInfoPtr_LimitTextVertices_Private_Static_Int32_Int32_Boolean_0;

		// Token: 0x04001FE9 RID: 8169
		private static readonly IntPtr NativeMethodInfoPtr_MakeText_Internal_Static_Void_MeshInfo_Vector2_AllocMeshData_VertexFlags_Boolean_0;

		// Token: 0x02000550 RID: 1360
		public sealed class AllocMeshData : ValueType
		{
			// Token: 0x0600417B RID: 16763 RVA: 0x001026CC File Offset: 0x001008CC
			// Note: this type is marked as 'beforefieldinit'.
			static AllocMeshData()
			{
				Il2CppClassPointerStore<MeshBuilder.AllocMeshData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshBuilder>.NativeClassPtr, "AllocMeshData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshBuilder.AllocMeshData>.NativeClassPtr);
				MeshBuilder.AllocMeshData.NativeFieldInfoPtr_alloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilder.AllocMeshData>.NativeClassPtr, "alloc");
				MeshBuilder.AllocMeshData.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilder.AllocMeshData>.NativeClassPtr, "texture");
				MeshBuilder.AllocMeshData.NativeFieldInfoPtr_svgTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilder.AllocMeshData>.NativeClassPtr, "svgTexture");
				MeshBuilder.AllocMeshData.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilder.AllocMeshData>.NativeClassPtr, "material");
				MeshBuilder.AllocMeshData.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilder.AllocMeshData>.NativeClassPtr, "flags");
				MeshBuilder.AllocMeshData.NativeFieldInfoPtr_colorAlloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilder.AllocMeshData>.NativeClassPtr, "colorAlloc");
				MeshBuilder.AllocMeshData.NativeMethodInfoPtr_Allocate_Internal_MeshWriteData_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilder.AllocMeshData>.NativeClassPtr, 100669870);
			}

			// Token: 0x0600417C RID: 16764 RVA: 0x00102784 File Offset: 0x00100984
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 350354, RefRangeEnd = 350355, XrefRangeStart = 350354, XrefRangeEnd = 350354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshWriteData Allocate(uint vertexCount, uint indexCount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref vertexCount;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilder.AllocMeshData.NativeMethodInfoPtr_Allocate_Internal_MeshWriteData_UInt32_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshWriteData>(intPtr3) : null;
			}

			// Token: 0x0600417D RID: 16765 RVA: 0x0001BBF5 File Offset: 0x00019DF5
			public AllocMeshData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600417E RID: 16766 RVA: 0x0001BBFE File Offset: 0x00019DFE
			public AllocMeshData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshBuilder.AllocMeshData>.NativeClassPtr))
			{
			}

			// Token: 0x1700139F RID: 5023
			// (get) Token: 0x0600417F RID: 16767 RVA: 0x001027E4 File Offset: 0x001009E4
			// (set) Token: 0x06004180 RID: 16768 RVA: 0x0001BC10 File Offset: 0x00019E10
			public unsafe MeshBuilder.AllocMeshData.Allocator alloc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshBuilder.AllocMeshData.NativeFieldInfoPtr_alloc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshBuilder.AllocMeshData.Allocator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshBuilder.AllocMeshData.NativeFieldInfoPtr_alloc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013A0 RID: 5024
			// (get) Token: 0x06004181 RID: 16769 RVA: 0x00102814 File Offset: 0x00100A14
			// (set) Token: 0x06004182 RID: 16770 RVA: 0x0001BC2F File Offset: 0x00019E2F
			public unsafe Texture texture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshBuilder.AllocMeshData.NativeFieldInfoPtr_texture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshBuilder.AllocMeshData.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013A1 RID: 5025
			// (get) Token: 0x06004183 RID: 16771 RVA: 0x00102844 File Offset: 0x00100A44
			// (set) Token: 0x06004184 RID: 16772 RVA: 0x0001BC4E File Offset: 0x00019E4E
			public unsafe TextureId svgTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshBuilder.AllocMeshData.NativeFieldInfoPtr_svgTexture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshBuilder.AllocMeshData.NativeFieldInfoPtr_svgTexture)) = value;
				}
			}

			// Token: 0x170013A2 RID: 5026
			// (get) Token: 0x06004185 RID: 16773 RVA: 0x0010286C File Offset: 0x00100A6C
			// (set) Token: 0x06004186 RID: 16774 RVA: 0x0001BC69 File Offset: 0x00019E69
			public unsafe Material material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshBuilder.AllocMeshData.NativeFieldInfoPtr_material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshBuilder.AllocMeshData.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013A3 RID: 5027
			// (get) Token: 0x06004187 RID: 16775 RVA: 0x0010289C File Offset: 0x00100A9C
			// (set) Token: 0x06004188 RID: 16776 RVA: 0x0001BC88 File Offset: 0x00019E88
			public unsafe MeshGenerationContext.MeshFlags flags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshBuilder.AllocMeshData.NativeFieldInfoPtr_flags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshBuilder.AllocMeshData.NativeFieldInfoPtr_flags)) = value;
				}
			}

			// Token: 0x170013A4 RID: 5028
			// (get) Token: 0x06004189 RID: 16777 RVA: 0x001028C4 File Offset: 0x00100AC4
			// (set) Token: 0x0600418A RID: 16778 RVA: 0x0001BCA3 File Offset: 0x00019EA3
			public unsafe BMPAlloc colorAlloc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshBuilder.AllocMeshData.NativeFieldInfoPtr_colorAlloc);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshBuilder.AllocMeshData.NativeFieldInfoPtr_colorAlloc)) = value;
				}
			}

			// Token: 0x04002E07 RID: 11783
			private static readonly IntPtr NativeFieldInfoPtr_alloc;

			// Token: 0x04002E08 RID: 11784
			private static readonly IntPtr NativeFieldInfoPtr_texture;

			// Token: 0x04002E09 RID: 11785
			private static readonly IntPtr NativeFieldInfoPtr_svgTexture;

			// Token: 0x04002E0A RID: 11786
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x04002E0B RID: 11787
			private static readonly IntPtr NativeFieldInfoPtr_flags;

			// Token: 0x04002E0C RID: 11788
			private static readonly IntPtr NativeFieldInfoPtr_colorAlloc;

			// Token: 0x04002E0D RID: 11789
			private static readonly IntPtr NativeMethodInfoPtr_Allocate_Internal_MeshWriteData_UInt32_UInt32_0;

			// Token: 0x0200059F RID: 1439
			public sealed class Allocator : MulticastDelegate
			{
				// Token: 0x06004303 RID: 17155 RVA: 0x0001CA00 File Offset: 0x0001AC00
				// Note: this type is marked as 'beforefieldinit'.
				static Allocator()
				{
					Il2CppClassPointerStore<MeshBuilder.AllocMeshData.Allocator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshBuilder.AllocMeshData>.NativeClassPtr, "Allocator");
					MeshBuilder.AllocMeshData.Allocator.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilder.AllocMeshData.Allocator>.NativeClassPtr, 100669871);
					MeshBuilder.AllocMeshData.Allocator.NativeMethodInfoPtr_Invoke_Public_Virtual_New_MeshWriteData_UInt32_UInt32_byref_AllocMeshData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilder.AllocMeshData.Allocator>.NativeClassPtr, 100669872);
				}

				// Token: 0x06004304 RID: 17156 RVA: 0x00106738 File Offset: 0x00104938
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 350352, RefRangeEnd = 350354, XrefRangeStart = 350349, XrefRangeEnd = 350352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Allocator(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshBuilder.AllocMeshData.Allocator>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilder.AllocMeshData.Allocator.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06004305 RID: 17157 RVA: 0x00106794 File Offset: 0x00104994
				[CallerCount(0)]
				public unsafe MeshWriteData Invoke(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref vertexCount;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(allocatorData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilder.AllocMeshData.Allocator.NativeMethodInfoPtr_Invoke_Public_Virtual_New_MeshWriteData_UInt32_UInt32_byref_AllocMeshData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshWriteData>(intPtr3) : null;
				}

				// Token: 0x06004306 RID: 17158 RVA: 0x0001CA3E File Offset: 0x0001AC3E
				public Allocator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002EDC RID: 11996
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002EDD RID: 11997
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_MeshWriteData_UInt32_UInt32_byref_AllocMeshData_0;
			}
		}
	}
}
