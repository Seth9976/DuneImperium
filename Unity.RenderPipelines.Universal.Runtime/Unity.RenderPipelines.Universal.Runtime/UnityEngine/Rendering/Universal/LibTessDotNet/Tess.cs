using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.LibTessDotNet
{
	// Token: 0x02000110 RID: 272
	public class Tess : Object
	{
		// Token: 0x060016AA RID: 5802 RVA: 0x000610F4 File Offset: 0x0005F2F4
		// Note: this type is marked as 'beforefieldinit'.
		static Tess()
		{
			Il2CppClassPointerStore<Tess>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.LibTessDotNet", "Tess");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tess>.NativeClassPtr);
			Tess.NativeFieldInfoPtr__mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_mesh");
			Tess.NativeFieldInfoPtr__normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_normal");
			Tess.NativeFieldInfoPtr__sUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_sUnit");
			Tess.NativeFieldInfoPtr__tUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_tUnit");
			Tess.NativeFieldInfoPtr__bminX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_bminX");
			Tess.NativeFieldInfoPtr__bminY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_bminY");
			Tess.NativeFieldInfoPtr__bmaxX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_bmaxX");
			Tess.NativeFieldInfoPtr__bmaxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_bmaxY");
			Tess.NativeFieldInfoPtr__windingRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_windingRule");
			Tess.NativeFieldInfoPtr__dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_dict");
			Tess.NativeFieldInfoPtr__pq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_pq");
			Tess.NativeFieldInfoPtr__event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_event");
			Tess.NativeFieldInfoPtr__combineCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_combineCallback");
			Tess.NativeFieldInfoPtr__vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_vertices");
			Tess.NativeFieldInfoPtr__vertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_vertexCount");
			Tess.NativeFieldInfoPtr__elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_elements");
			Tess.NativeFieldInfoPtr__elementCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "_elementCount");
			Tess.NativeFieldInfoPtr_SUnitX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "SUnitX");
			Tess.NativeFieldInfoPtr_SUnitY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "SUnitY");
			Tess.NativeFieldInfoPtr_SentinelCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "SentinelCoord");
			Tess.NativeFieldInfoPtr_NoEmptyPolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "NoEmptyPolygons");
			Tess.NativeFieldInfoPtr_UsePooling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess>.NativeClassPtr, "UsePooling");
			Tess.NativeMethodInfoPtr_RegionBelow_Private_ActiveRegion_ActiveRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665963);
			Tess.NativeMethodInfoPtr_RegionAbove_Private_ActiveRegion_ActiveRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665964);
			Tess.NativeMethodInfoPtr_EdgeLeq_Private_Boolean_ActiveRegion_ActiveRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665965);
			Tess.NativeMethodInfoPtr_DeleteRegion_Private_Void_ActiveRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665966);
			Tess.NativeMethodInfoPtr_FixUpperEdge_Private_Void_ActiveRegion_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665967);
			Tess.NativeMethodInfoPtr_TopLeftRegion_Private_ActiveRegion_ActiveRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665968);
			Tess.NativeMethodInfoPtr_TopRightRegion_Private_ActiveRegion_ActiveRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665969);
			Tess.NativeMethodInfoPtr_AddRegionBelow_Private_ActiveRegion_ActiveRegion_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665970);
			Tess.NativeMethodInfoPtr_ComputeWinding_Private_Void_ActiveRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665971);
			Tess.NativeMethodInfoPtr_FinishRegion_Private_Void_ActiveRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665972);
			Tess.NativeMethodInfoPtr_FinishLeftRegions_Private_Edge_ActiveRegion_ActiveRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665973);
			Tess.NativeMethodInfoPtr_AddRightEdges_Private_Void_ActiveRegion_Edge_Edge_Edge_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665974);
			Tess.NativeMethodInfoPtr_SpliceMergeVertices_Private_Void_Edge_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665975);
			Tess.NativeMethodInfoPtr_VertexWeights_Private_Void_Vertex_Vertex_Vertex_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665976);
			Tess.NativeMethodInfoPtr_GetIntersectData_Private_Void_Vertex_Vertex_Vertex_Vertex_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665977);
			Tess.NativeMethodInfoPtr_CheckForRightSplice_Private_Boolean_ActiveRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665978);
			Tess.NativeMethodInfoPtr_CheckForLeftSplice_Private_Boolean_ActiveRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665979);
			Tess.NativeMethodInfoPtr_CheckForIntersect_Private_Boolean_ActiveRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665980);
			Tess.NativeMethodInfoPtr_WalkDirtyRegions_Private_Void_ActiveRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665981);
			Tess.NativeMethodInfoPtr_ConnectRightVertex_Private_Void_ActiveRegion_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665982);
			Tess.NativeMethodInfoPtr_ConnectLeftDegenerate_Private_Void_ActiveRegion_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665983);
			Tess.NativeMethodInfoPtr_ConnectLeftVertex_Private_Void_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665984);
			Tess.NativeMethodInfoPtr_SweepEvent_Private_Void_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665985);
			Tess.NativeMethodInfoPtr_AddSentinel_Private_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665986);
			Tess.NativeMethodInfoPtr_InitEdgeDict_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665987);
			Tess.NativeMethodInfoPtr_DoneEdgeDict_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665988);
			Tess.NativeMethodInfoPtr_RemoveDegenerateEdges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665989);
			Tess.NativeMethodInfoPtr_InitPriorityQ_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665990);
			Tess.NativeMethodInfoPtr_DonePriorityQ_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665991);
			Tess.NativeMethodInfoPtr_RemoveDegenerateFaces_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665992);
			Tess.NativeMethodInfoPtr_ComputeInterior_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665993);
			Tess.NativeMethodInfoPtr_get_Normal_Public_get_Vec3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665994);
			Tess.NativeMethodInfoPtr_set_Normal_Public_set_Void_Vec3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665995);
			Tess.NativeMethodInfoPtr_get_Vertices_Public_get_Il2CppReferenceArray_1_ContourVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665996);
			Tess.NativeMethodInfoPtr_get_VertexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665997);
			Tess.NativeMethodInfoPtr_get_Elements_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665998);
			Tess.NativeMethodInfoPtr_get_ElementCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100665999);
			Tess.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666000);
			Tess.NativeMethodInfoPtr_ComputeNormal_Private_Void_byref_Vec3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666001);
			Tess.NativeMethodInfoPtr_CheckOrientation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666002);
			Tess.NativeMethodInfoPtr_ProjectPolygon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666003);
			Tess.NativeMethodInfoPtr_TessellateMonoRegion_Private_Void_Face_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666004);
			Tess.NativeMethodInfoPtr_TessellateInterior_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666005);
			Tess.NativeMethodInfoPtr_DiscardExterior_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666006);
			Tess.NativeMethodInfoPtr_SetWindingNumber_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666007);
			Tess.NativeMethodInfoPtr_GetNeighbourFace_Private_Int32_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666008);
			Tess.NativeMethodInfoPtr_OutputPolymesh_Private_Void_ElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666009);
			Tess.NativeMethodInfoPtr_OutputContours_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666010);
			Tess.NativeMethodInfoPtr_SignedArea_Private_Single_Il2CppReferenceArray_1_ContourVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666011);
			Tess.NativeMethodInfoPtr_AddContour_Public_Void_Il2CppReferenceArray_1_ContourVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666012);
			Tess.NativeMethodInfoPtr_AddContour_Public_Void_Il2CppReferenceArray_1_ContourVertex_ContourOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666013);
			Tess.NativeMethodInfoPtr_Tessellate_Public_Void_WindingRule_ElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666014);
			Tess.NativeMethodInfoPtr_Tessellate_Public_Void_WindingRule_ElementType_Int32_CombineCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess>.NativeClassPtr, 100666015);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00061700 File Offset: 0x0005F900
		[CallerCount(0)]
		public unsafe Tess.ActiveRegion RegionBelow(Tess.ActiveRegion reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_RegionBelow_Private_ActiveRegion_ActiveRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tess.ActiveRegion>(intPtr3) : null;
			}
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00061750 File Offset: 0x0005F950
		[CallerCount(0)]
		public unsafe Tess.ActiveRegion RegionAbove(Tess.ActiveRegion reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_RegionAbove_Private_ActiveRegion_ActiveRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tess.ActiveRegion>(intPtr3) : null;
			}
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x000617A0 File Offset: 0x0005F9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623648, XrefRangeEnd = 623650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EdgeLeq(Tess.ActiveRegion reg1, Tess.ActiveRegion reg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_EdgeLeq_Private_Boolean_ActiveRegion_ActiveRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00061800 File Offset: 0x0005FA00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623655, RefRangeEnd = 623656, XrefRangeStart = 623650, XrefRangeEnd = 623655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteRegion(Tess.ActiveRegion reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_DeleteRegion_Private_Void_ActiveRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00061844 File Offset: 0x0005FA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623656, XrefRangeEnd = 623660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixUpperEdge(Tess.ActiveRegion reg, MeshUtils.Edge newEdge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newEdge);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_FixUpperEdge_Private_Void_ActiveRegion_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00061898 File Offset: 0x0005FA98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 623664, RefRangeEnd = 623668, XrefRangeStart = 623660, XrefRangeEnd = 623664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tess.ActiveRegion TopLeftRegion(Tess.ActiveRegion reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_TopLeftRegion_Private_ActiveRegion_ActiveRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tess.ActiveRegion>(intPtr3) : null;
			}
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x000618E8 File Offset: 0x0005FAE8
		[CallerCount(0)]
		public unsafe Tess.ActiveRegion TopRightRegion(Tess.ActiveRegion reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_TopRightRegion_Private_ActiveRegion_ActiveRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tess.ActiveRegion>(intPtr3) : null;
			}
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00061938 File Offset: 0x0005FB38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623678, RefRangeEnd = 623679, XrefRangeStart = 623668, XrefRangeEnd = 623678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tess.ActiveRegion AddRegionBelow(Tess.ActiveRegion regAbove, MeshUtils.Edge eNewUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regAbove);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eNewUp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_AddRegionBelow_Private_ActiveRegion_ActiveRegion_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tess.ActiveRegion>(intPtr3) : null;
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0006199C File Offset: 0x0005FB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623679, XrefRangeEnd = 623680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeWinding(Tess.ActiveRegion reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_ComputeWinding_Private_Void_ActiveRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x000619E0 File Offset: 0x0005FBE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 623686, RefRangeEnd = 623688, XrefRangeStart = 623680, XrefRangeEnd = 623686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishRegion(Tess.ActiveRegion reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_FinishRegion_Private_Void_ActiveRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00061A24 File Offset: 0x0005FC24
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 623697, RefRangeEnd = 623703, XrefRangeStart = 623688, XrefRangeEnd = 623697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshUtils.Edge FinishLeftRegions(Tess.ActiveRegion regFirst, Tess.ActiveRegion regLast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regFirst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(regLast);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_FinishLeftRegions_Private_Edge_ActiveRegion_ActiveRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr3) : null;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00061A88 File Offset: 0x0005FC88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 623724, RefRangeEnd = 623728, XrefRangeStart = 623703, XrefRangeEnd = 623724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRightEdges(Tess.ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regUp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eFirst);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eLast);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eTopLeft);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cleanUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_AddRightEdges_Private_Void_ActiveRegion_Edge_Edge_Edge_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00061B10 File Offset: 0x0005FD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623728, XrefRangeEnd = 623730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_SpliceMergeVertices_Private_Void_Edge_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00061B64 File Offset: 0x0005FD64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 623736, RefRangeEnd = 623738, XrefRangeStart = 623730, XrefRangeEnd = 623736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(isect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(org);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &w0;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &w1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_VertexWeights_Private_Void_Vertex_Vertex_Vertex_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00061BE8 File Offset: 0x0005FDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623738, XrefRangeEnd = 623759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(isect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orgUp);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dstUp);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orgLo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dstLo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_GetIntersectData_Private_Void_Vertex_Vertex_Vertex_Vertex_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00061C74 File Offset: 0x0005FE74
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 623768, RefRangeEnd = 623773, XrefRangeStart = 623759, XrefRangeEnd = 623768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForRightSplice(Tess.ActiveRegion regUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regUp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_CheckForRightSplice_Private_Boolean_ActiveRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00061CC4 File Offset: 0x0005FEC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623776, RefRangeEnd = 623777, XrefRangeStart = 623773, XrefRangeEnd = 623776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForLeftSplice(Tess.ActiveRegion regUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regUp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_CheckForLeftSplice_Private_Boolean_ActiveRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00061D14 File Offset: 0x0005FF14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 623792, RefRangeEnd = 623795, XrefRangeStart = 623777, XrefRangeEnd = 623792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForIntersect(Tess.ActiveRegion regUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regUp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_CheckForIntersect_Private_Boolean_ActiveRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00061D64 File Offset: 0x0005FF64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 623809, RefRangeEnd = 623812, XrefRangeStart = 623795, XrefRangeEnd = 623809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WalkDirtyRegions(Tess.ActiveRegion regUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regUp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_WalkDirtyRegions_Private_Void_ActiveRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00061DA8 File Offset: 0x0005FFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623812, XrefRangeEnd = 623819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectRightVertex(Tess.ActiveRegion regUp, MeshUtils.Edge eBottomLeft)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regUp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eBottomLeft);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_ConnectRightVertex_Private_Void_ActiveRegion_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00061DFC File Offset: 0x0005FFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623819, XrefRangeEnd = 623836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectLeftDegenerate(Tess.ActiveRegion regUp, MeshUtils.Vertex vEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regUp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_ConnectLeftDegenerate_Private_Void_ActiveRegion_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00061E50 File Offset: 0x00060050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623855, RefRangeEnd = 623856, XrefRangeStart = 623836, XrefRangeEnd = 623855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectLeftVertex(MeshUtils.Vertex vEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_ConnectLeftVertex_Private_Void_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00061E94 File Offset: 0x00060094
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 623861, RefRangeEnd = 623866, XrefRangeStart = 623856, XrefRangeEnd = 623861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SweepEvent(MeshUtils.Vertex vEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_SweepEvent_Private_Void_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00061ED8 File Offset: 0x000600D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 623881, RefRangeEnd = 623885, XrefRangeStart = 623866, XrefRangeEnd = 623881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSentinel(float smin, float smax, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref smin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_AddSentinel_Private_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00061F34 File Offset: 0x00060134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623885, XrefRangeEnd = 623900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEdgeDict()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_InitEdgeDict_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00061F68 File Offset: 0x00060168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623900, XrefRangeEnd = 623911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoneEdgeDict()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_DoneEdgeDict_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00061F9C File Offset: 0x0006019C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623911, XrefRangeEnd = 623915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDegenerateEdges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_RemoveDegenerateEdges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00061FD0 File Offset: 0x000601D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623950, RefRangeEnd = 623951, XrefRangeStart = 623915, XrefRangeEnd = 623950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitPriorityQ()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_InitPriorityQ_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00062004 File Offset: 0x00060204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DonePriorityQ()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_DonePriorityQ_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00062038 File Offset: 0x00060238
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 623953, RefRangeEnd = 623955, XrefRangeStart = 623951, XrefRangeEnd = 623953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDegenerateFaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_RemoveDegenerateFaces_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x0006206C File Offset: 0x0006026C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624122, RefRangeEnd = 624123, XrefRangeStart = 623955, XrefRangeEnd = 624122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeInterior()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_ComputeInterior_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x000620A0 File Offset: 0x000602A0
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x000620DC File Offset: 0x000602DC
		public unsafe Vec3 Normal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_get_Normal_Public_get_Vec3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_set_Normal_Public_set_Void_Vec3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x0006211C File Offset: 0x0006031C
		public unsafe Il2CppReferenceArray<ContourVertex> Vertices
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_get_Vertices_Public_get_Il2CppReferenceArray_1_ContourVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ContourVertex>>(intPtr3) : null;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x0006215C File Offset: 0x0006035C
		public unsafe int VertexCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_get_VertexCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x00062198 File Offset: 0x00060398
		public unsafe Il2CppStructArray<int> Elements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_get_Elements_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x000621D8 File Offset: 0x000603D8
		public unsafe int ElementCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_get_ElementCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00062214 File Offset: 0x00060414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624131, RefRangeEnd = 624132, XrefRangeStart = 624123, XrefRangeEnd = 624131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tess()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tess>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00062250 File Offset: 0x00060450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624177, RefRangeEnd = 624178, XrefRangeStart = 624132, XrefRangeEnd = 624177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeNormal(ref Vec3 norm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &norm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_ComputeNormal_Private_Void_byref_Vec3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00062290 File Offset: 0x00060490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624178, XrefRangeEnd = 624184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_CheckOrientation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x000622C4 File Offset: 0x000604C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624217, RefRangeEnd = 624218, XrefRangeStart = 624184, XrefRangeEnd = 624217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProjectPolygon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_ProjectPolygon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x000622F8 File Offset: 0x000604F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 624228, RefRangeEnd = 624230, XrefRangeStart = 624218, XrefRangeEnd = 624228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TessellateMonoRegion(MeshUtils.Face face)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(face);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_TessellateMonoRegion_Private_Void_Face_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x0006233C File Offset: 0x0006053C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624230, XrefRangeEnd = 624232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TessellateInterior()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_TessellateInterior_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00062370 File Offset: 0x00060570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624232, XrefRangeEnd = 624234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DiscardExterior()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_DiscardExterior_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x000623A4 File Offset: 0x000605A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624234, XrefRangeEnd = 624238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWindingNumber(int value, bool keepOnlyBoundary)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepOnlyBoundary;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_SetWindingNumber_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x000623F0 File Offset: 0x000605F0
		[CallerCount(0)]
		public unsafe int GetNeighbourFace(MeshUtils.Edge edge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_GetNeighbourFace_Private_Int32_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00062440 File Offset: 0x00060640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624260, RefRangeEnd = 624261, XrefRangeStart = 624238, XrefRangeEnd = 624260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OutputPolymesh(ElementType elementType, int polySize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref polySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_OutputPolymesh_Private_Void_ElementType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x0006248C File Offset: 0x0006068C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624272, RefRangeEnd = 624273, XrefRangeStart = 624261, XrefRangeEnd = 624272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OutputContours()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_OutputContours_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x000624C0 File Offset: 0x000606C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624273, XrefRangeEnd = 624274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float SignedArea(Il2CppReferenceArray<ContourVertex> vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_SignedArea_Private_Single_Il2CppReferenceArray_1_ContourVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00062510 File Offset: 0x00060710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624274, XrefRangeEnd = 624275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddContour(Il2CppReferenceArray<ContourVertex> vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_AddContour_Public_Void_Il2CppReferenceArray_1_ContourVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00062554 File Offset: 0x00060754
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 624291, RefRangeEnd = 624293, XrefRangeStart = 624275, XrefRangeEnd = 624291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddContour(Il2CppReferenceArray<ContourVertex> vertices, ContourOrientation forceOrientation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceOrientation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_AddContour_Public_Void_Il2CppReferenceArray_1_ContourVertex_ContourOrientation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x000625A4 File Offset: 0x000607A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624293, XrefRangeEnd = 624294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Tessellate(WindingRule windingRule, ElementType elementType, int polySize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windingRule;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref polySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_Tessellate_Public_Void_WindingRule_ElementType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00062600 File Offset: 0x00060800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 624315, RefRangeEnd = 624317, XrefRangeStart = 624294, XrefRangeEnd = 624315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Tessellate(WindingRule windingRule, ElementType elementType, int polySize, CombineCallback combineCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windingRule;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref polySize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(combineCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.NativeMethodInfoPtr_Tessellate_Public_Void_WindingRule_ElementType_Int32_CombineCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x0000D136 File Offset: 0x0000B336
		public Tess(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00062670 File Offset: 0x00060870
		// (set) Token: 0x060016E2 RID: 5858 RVA: 0x0000D13F File Offset: 0x0000B33F
		public unsafe Mesh _mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x000626A0 File Offset: 0x000608A0
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x0000D15E File Offset: 0x0000B35E
		public unsafe Vec3 _normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__normal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__normal)) = value;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x000626C8 File Offset: 0x000608C8
		// (set) Token: 0x060016E6 RID: 5862 RVA: 0x0000D179 File Offset: 0x0000B379
		public unsafe Vec3 _sUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__sUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__sUnit)) = value;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x000626F0 File Offset: 0x000608F0
		// (set) Token: 0x060016E8 RID: 5864 RVA: 0x0000D194 File Offset: 0x0000B394
		public unsafe Vec3 _tUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__tUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__tUnit)) = value;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060016E9 RID: 5865 RVA: 0x00062718 File Offset: 0x00060918
		// (set) Token: 0x060016EA RID: 5866 RVA: 0x0000D1AF File Offset: 0x0000B3AF
		public unsafe float _bminX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__bminX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__bminX)) = value;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060016EB RID: 5867 RVA: 0x00062740 File Offset: 0x00060940
		// (set) Token: 0x060016EC RID: 5868 RVA: 0x0000D1CA File Offset: 0x0000B3CA
		public unsafe float _bminY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__bminY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__bminY)) = value;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x00062768 File Offset: 0x00060968
		// (set) Token: 0x060016EE RID: 5870 RVA: 0x0000D1E5 File Offset: 0x0000B3E5
		public unsafe float _bmaxX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__bmaxX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__bmaxX)) = value;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x00062790 File Offset: 0x00060990
		// (set) Token: 0x060016F0 RID: 5872 RVA: 0x0000D200 File Offset: 0x0000B400
		public unsafe float _bmaxY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__bmaxY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__bmaxY)) = value;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x000627B8 File Offset: 0x000609B8
		// (set) Token: 0x060016F2 RID: 5874 RVA: 0x0000D21B File Offset: 0x0000B41B
		public unsafe WindingRule _windingRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__windingRule);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__windingRule)) = value;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x000627E0 File Offset: 0x000609E0
		// (set) Token: 0x060016F4 RID: 5876 RVA: 0x0000D236 File Offset: 0x0000B436
		public unsafe Dict<Tess.ActiveRegion> _dict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__dict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dict<Tess.ActiveRegion>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__dict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x00062810 File Offset: 0x00060A10
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x0000D255 File Offset: 0x0000B455
		public unsafe PriorityQueue<MeshUtils.Vertex> _pq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__pq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PriorityQueue<MeshUtils.Vertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__pq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x00062840 File Offset: 0x00060A40
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x0000D274 File Offset: 0x0000B474
		public unsafe MeshUtils.Vertex _event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Vertex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x00062870 File Offset: 0x00060A70
		// (set) Token: 0x060016FA RID: 5882 RVA: 0x0000D293 File Offset: 0x0000B493
		public unsafe CombineCallback _combineCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__combineCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombineCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__combineCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x000628A0 File Offset: 0x00060AA0
		// (set) Token: 0x060016FC RID: 5884 RVA: 0x0000D2B2 File Offset: 0x0000B4B2
		public unsafe Il2CppReferenceArray<ContourVertex> _vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__vertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ContourVertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x000628D0 File Offset: 0x00060AD0
		// (set) Token: 0x060016FE RID: 5886 RVA: 0x0000D2D1 File Offset: 0x0000B4D1
		public unsafe int _vertexCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__vertexCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__vertexCount)) = value;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x000628F8 File Offset: 0x00060AF8
		// (set) Token: 0x06001700 RID: 5888 RVA: 0x0000D2EC File Offset: 0x0000B4EC
		public unsafe Il2CppStructArray<int> _elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x00062928 File Offset: 0x00060B28
		// (set) Token: 0x06001702 RID: 5890 RVA: 0x0000D30B File Offset: 0x0000B50B
		public unsafe int _elementCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__elementCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr__elementCount)) = value;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x00062950 File Offset: 0x00060B50
		// (set) Token: 0x06001704 RID: 5892 RVA: 0x0000D326 File Offset: 0x0000B526
		public unsafe float SUnitX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr_SUnitX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr_SUnitX)) = value;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x00062978 File Offset: 0x00060B78
		// (set) Token: 0x06001706 RID: 5894 RVA: 0x0000D341 File Offset: 0x0000B541
		public unsafe float SUnitY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr_SUnitY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr_SUnitY)) = value;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x000629A0 File Offset: 0x00060BA0
		// (set) Token: 0x06001708 RID: 5896 RVA: 0x0000D35C File Offset: 0x0000B55C
		public unsafe float SentinelCoord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr_SentinelCoord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr_SentinelCoord)) = value;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x000629C8 File Offset: 0x00060BC8
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x0000D377 File Offset: 0x0000B577
		public unsafe bool NoEmptyPolygons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr_NoEmptyPolygons);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr_NoEmptyPolygons)) = value;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x000629F0 File Offset: 0x00060BF0
		// (set) Token: 0x0600170C RID: 5900 RVA: 0x0000D392 File Offset: 0x0000B592
		public unsafe bool UsePooling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr_UsePooling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.NativeFieldInfoPtr_UsePooling)) = value;
			}
		}

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeFieldInfoPtr__mesh;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeFieldInfoPtr__normal;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeFieldInfoPtr__sUnit;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeFieldInfoPtr__tUnit;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeFieldInfoPtr__bminX;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeFieldInfoPtr__bminY;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeFieldInfoPtr__bmaxX;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeFieldInfoPtr__bmaxY;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeFieldInfoPtr__windingRule;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeFieldInfoPtr__dict;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeFieldInfoPtr__pq;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeFieldInfoPtr__event;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeFieldInfoPtr__combineCallback;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeFieldInfoPtr__vertices;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeFieldInfoPtr__vertexCount;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeFieldInfoPtr__elements;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeFieldInfoPtr__elementCount;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeFieldInfoPtr_SUnitX;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeFieldInfoPtr_SUnitY;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeFieldInfoPtr_SentinelCoord;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeFieldInfoPtr_NoEmptyPolygons;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeFieldInfoPtr_UsePooling;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr_RegionBelow_Private_ActiveRegion_ActiveRegion_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_RegionAbove_Private_ActiveRegion_ActiveRegion_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_EdgeLeq_Private_Boolean_ActiveRegion_ActiveRegion_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr_DeleteRegion_Private_Void_ActiveRegion_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_FixUpperEdge_Private_Void_ActiveRegion_Edge_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_TopLeftRegion_Private_ActiveRegion_ActiveRegion_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_TopRightRegion_Private_ActiveRegion_ActiveRegion_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_AddRegionBelow_Private_ActiveRegion_ActiveRegion_Edge_0;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr_ComputeWinding_Private_Void_ActiveRegion_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_FinishRegion_Private_Void_ActiveRegion_0;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_FinishLeftRegions_Private_Edge_ActiveRegion_ActiveRegion_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_AddRightEdges_Private_Void_ActiveRegion_Edge_Edge_Edge_Boolean_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_SpliceMergeVertices_Private_Void_Edge_Edge_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_VertexWeights_Private_Void_Vertex_Vertex_Vertex_byref_Single_byref_Single_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_GetIntersectData_Private_Void_Vertex_Vertex_Vertex_Vertex_Vertex_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_CheckForRightSplice_Private_Boolean_ActiveRegion_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_CheckForLeftSplice_Private_Boolean_ActiveRegion_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_CheckForIntersect_Private_Boolean_ActiveRegion_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_WalkDirtyRegions_Private_Void_ActiveRegion_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_ConnectRightVertex_Private_Void_ActiveRegion_Edge_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_ConnectLeftDegenerate_Private_Void_ActiveRegion_Vertex_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_ConnectLeftVertex_Private_Void_Vertex_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_SweepEvent_Private_Void_Vertex_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_AddSentinel_Private_Void_Single_Single_Single_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_InitEdgeDict_Private_Void_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_DoneEdgeDict_Private_Void_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDegenerateEdges_Private_Void_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_InitPriorityQ_Private_Void_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_DonePriorityQ_Private_Void_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDegenerateFaces_Private_Void_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_ComputeInterior_Protected_Void_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_Vec3_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_set_Normal_Public_set_Void_Vec3_0;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_get_Vertices_Public_get_Il2CppReferenceArray_1_ContourVertex_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_get_VertexCount_Public_get_Int32_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_get_Elements_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementCount_Public_get_Int32_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_ComputeNormal_Private_Void_byref_Vec3_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_CheckOrientation_Private_Void_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_ProjectPolygon_Private_Void_0;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr_TessellateMonoRegion_Private_Void_Face_0;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr_TessellateInterior_Private_Void_0;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeMethodInfoPtr_DiscardExterior_Private_Void_0;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr_SetWindingNumber_Private_Void_Int32_Boolean_0;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr_GetNeighbourFace_Private_Int32_Edge_0;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeMethodInfoPtr_OutputPolymesh_Private_Void_ElementType_Int32_0;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeMethodInfoPtr_OutputContours_Private_Void_0;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr_SignedArea_Private_Single_Il2CppReferenceArray_1_ContourVertex_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr_AddContour_Public_Void_Il2CppReferenceArray_1_ContourVertex_0;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeMethodInfoPtr_AddContour_Public_Void_Il2CppReferenceArray_1_ContourVertex_ContourOrientation_0;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeMethodInfoPtr_Tessellate_Public_Void_WindingRule_ElementType_Int32_0;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr_Tessellate_Public_Void_WindingRule_ElementType_Int32_CombineCallback_0;

		// Token: 0x020001E1 RID: 481
		public class ActiveRegion : Object
		{
			// Token: 0x0600217B RID: 8571 RVA: 0x00081B0C File Offset: 0x0007FD0C
			// Note: this type is marked as 'beforefieldinit'.
			static ActiveRegion()
			{
				Il2CppClassPointerStore<Tess.ActiveRegion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tess>.NativeClassPtr, "ActiveRegion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tess.ActiveRegion>.NativeClassPtr);
				Tess.ActiveRegion.NativeFieldInfoPtr__eUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess.ActiveRegion>.NativeClassPtr, "_eUp");
				Tess.ActiveRegion.NativeFieldInfoPtr__nodeUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess.ActiveRegion>.NativeClassPtr, "_nodeUp");
				Tess.ActiveRegion.NativeFieldInfoPtr__windingNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess.ActiveRegion>.NativeClassPtr, "_windingNumber");
				Tess.ActiveRegion.NativeFieldInfoPtr__inside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess.ActiveRegion>.NativeClassPtr, "_inside");
				Tess.ActiveRegion.NativeFieldInfoPtr__sentinel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess.ActiveRegion>.NativeClassPtr, "_sentinel");
				Tess.ActiveRegion.NativeFieldInfoPtr__dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess.ActiveRegion>.NativeClassPtr, "_dirty");
				Tess.ActiveRegion.NativeFieldInfoPtr__fixUpperEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess.ActiveRegion>.NativeClassPtr, "_fixUpperEdge");
				Tess.ActiveRegion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tess.ActiveRegion>.NativeClassPtr, 100666016);
			}

			// Token: 0x0600217C RID: 8572 RVA: 0x00081BD8 File Offset: 0x0007FDD8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActiveRegion()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tess.ActiveRegion>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tess.ActiveRegion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600217D RID: 8573 RVA: 0x000132AA File Offset: 0x000114AA
			public ActiveRegion(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C09 RID: 3081
			// (get) Token: 0x0600217E RID: 8574 RVA: 0x00081C14 File Offset: 0x0007FE14
			// (set) Token: 0x0600217F RID: 8575 RVA: 0x000132B3 File Offset: 0x000114B3
			public unsafe MeshUtils.Edge _eUp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.ActiveRegion.NativeFieldInfoPtr__eUp);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.ActiveRegion.NativeFieldInfoPtr__eUp), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C0A RID: 3082
			// (get) Token: 0x06002180 RID: 8576 RVA: 0x00081C44 File Offset: 0x0007FE44
			// (set) Token: 0x06002181 RID: 8577 RVA: 0x000132D2 File Offset: 0x000114D2
			public unsafe Dict<Tess.ActiveRegion>.Node _nodeUp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.ActiveRegion.NativeFieldInfoPtr__nodeUp);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dict<Tess.ActiveRegion>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.ActiveRegion.NativeFieldInfoPtr__nodeUp), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C0B RID: 3083
			// (get) Token: 0x06002182 RID: 8578 RVA: 0x00081C74 File Offset: 0x0007FE74
			// (set) Token: 0x06002183 RID: 8579 RVA: 0x000132F1 File Offset: 0x000114F1
			public unsafe int _windingNumber
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.ActiveRegion.NativeFieldInfoPtr__windingNumber);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.ActiveRegion.NativeFieldInfoPtr__windingNumber)) = value;
				}
			}

			// Token: 0x17000C0C RID: 3084
			// (get) Token: 0x06002184 RID: 8580 RVA: 0x00081C9C File Offset: 0x0007FE9C
			// (set) Token: 0x06002185 RID: 8581 RVA: 0x0001330C File Offset: 0x0001150C
			public unsafe bool _inside
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.ActiveRegion.NativeFieldInfoPtr__inside);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.ActiveRegion.NativeFieldInfoPtr__inside)) = value;
				}
			}

			// Token: 0x17000C0D RID: 3085
			// (get) Token: 0x06002186 RID: 8582 RVA: 0x00081CC4 File Offset: 0x0007FEC4
			// (set) Token: 0x06002187 RID: 8583 RVA: 0x00013327 File Offset: 0x00011527
			public unsafe bool _sentinel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.ActiveRegion.NativeFieldInfoPtr__sentinel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.ActiveRegion.NativeFieldInfoPtr__sentinel)) = value;
				}
			}

			// Token: 0x17000C0E RID: 3086
			// (get) Token: 0x06002188 RID: 8584 RVA: 0x00081CEC File Offset: 0x0007FEEC
			// (set) Token: 0x06002189 RID: 8585 RVA: 0x00013342 File Offset: 0x00011542
			public unsafe bool _dirty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.ActiveRegion.NativeFieldInfoPtr__dirty);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.ActiveRegion.NativeFieldInfoPtr__dirty)) = value;
				}
			}

			// Token: 0x17000C0F RID: 3087
			// (get) Token: 0x0600218A RID: 8586 RVA: 0x00081D14 File Offset: 0x0007FF14
			// (set) Token: 0x0600218B RID: 8587 RVA: 0x0001335D File Offset: 0x0001155D
			public unsafe bool _fixUpperEdge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.ActiveRegion.NativeFieldInfoPtr__fixUpperEdge);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tess.ActiveRegion.NativeFieldInfoPtr__fixUpperEdge)) = value;
				}
			}

			// Token: 0x040017B8 RID: 6072
			private static readonly IntPtr NativeFieldInfoPtr__eUp;

			// Token: 0x040017B9 RID: 6073
			private static readonly IntPtr NativeFieldInfoPtr__nodeUp;

			// Token: 0x040017BA RID: 6074
			private static readonly IntPtr NativeFieldInfoPtr__windingNumber;

			// Token: 0x040017BB RID: 6075
			private static readonly IntPtr NativeFieldInfoPtr__inside;

			// Token: 0x040017BC RID: 6076
			private static readonly IntPtr NativeFieldInfoPtr__sentinel;

			// Token: 0x040017BD RID: 6077
			private static readonly IntPtr NativeFieldInfoPtr__dirty;

			// Token: 0x040017BE RID: 6078
			private static readonly IntPtr NativeFieldInfoPtr__fixUpperEdge;

			// Token: 0x040017BF RID: 6079
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001E2 RID: 482
		[ObfuscatedName("UnityEngine.Rendering.Universal.LibTessDotNet.Tess+<>O")]
		public static class __O : Object
		{
			// Token: 0x0600218C RID: 8588 RVA: 0x00013378 File Offset: 0x00011578
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<Tess.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tess>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tess.__O>.NativeClassPtr);
				Tess.__O.NativeFieldInfoPtr__0___VertLeq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tess.__O>.NativeClassPtr, "<0>__VertLeq");
			}

			// Token: 0x0600218D RID: 8589 RVA: 0x000133AC File Offset: 0x000115AC
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C10 RID: 3088
			// (get) Token: 0x0600218E RID: 8590 RVA: 0x00081D3C File Offset: 0x0007FF3C
			// (set) Token: 0x0600218F RID: 8591 RVA: 0x000133B5 File Offset: 0x000115B5
			public unsafe static PriorityHeap<MeshUtils.Vertex>.LessOrEqual _0___VertLeq
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Tess.__O.NativeFieldInfoPtr__0___VertLeq, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PriorityHeap<MeshUtils.Vertex>.LessOrEqual>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Tess.__O.NativeFieldInfoPtr__0___VertLeq, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017C0 RID: 6080
			private static readonly IntPtr NativeFieldInfoPtr__0___VertLeq;
		}
	}
}
