using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR.Implementation
{
	// Token: 0x02000279 RID: 633
	public static class CommandGenerator : Object
	{
		// Token: 0x06002F02 RID: 12034 RVA: 0x000C7618 File Offset: 0x000C5818
		// Note: this type is marked as 'beforefieldinit'.
		static CommandGenerator()
		{
			Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR.Implementation", "CommandGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr);
			CommandGenerator.NativeFieldInfoPtr_k_GenerateEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, "k_GenerateEntries");
			CommandGenerator.NativeFieldInfoPtr_k_ConvertEntriesToCommandsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, "k_ConvertEntriesToCommandsMarker");
			CommandGenerator.NativeFieldInfoPtr_k_GenerateClosingCommandsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, "k_GenerateClosingCommandsMarker");
			CommandGenerator.NativeFieldInfoPtr_k_NudgeVerticesMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, "k_NudgeVerticesMarker");
			CommandGenerator.NativeFieldInfoPtr_k_UpdateOpacityIdMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, "k_UpdateOpacityIdMarker");
			CommandGenerator.NativeFieldInfoPtr_k_ComputeTransformMatrixMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, "k_ComputeTransformMatrixMarker");
			CommandGenerator.NativeFieldInfoPtr_s_blitMaterial_LinearToGamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, "s_blitMaterial_LinearToGamma");
			CommandGenerator.NativeFieldInfoPtr_s_blitMaterial_GammaToLinear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, "s_blitMaterial_GammaToLinear");
			CommandGenerator.NativeFieldInfoPtr_s_blitMaterial_NoChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, "s_blitMaterial_NoChange");
			CommandGenerator.NativeFieldInfoPtr_s_blitShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, "s_blitShader");
			CommandGenerator.NativeMethodInfoPtr_GetVerticesTransformInfo_Private_Static_Void_VisualElement_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670098);
			CommandGenerator.NativeMethodInfoPtr_ComputeTransformMatrix_Internal_Static_Void_VisualElement_VisualElement_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670099);
			CommandGenerator.NativeMethodInfoPtr_IsParentOrAncestorOf_Private_Static_Boolean_VisualElement_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670100);
			CommandGenerator.NativeMethodInfoPtr_PaintElement_Public_Static_ClosingInfo_RenderChain_VisualElement_byref_ChainBuilderStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670101);
			CommandGenerator.NativeMethodInfoPtr_InvokeGenerateVisualContent_Private_Static_Void_VisualElement_MeshGenerationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670102);
			CommandGenerator.NativeMethodInfoPtr_CreateBlitShader_Private_Static_Material_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670103);
			CommandGenerator.NativeMethodInfoPtr_GetBlitMaterial_Private_Static_Material_RenderTargetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670104);
			CommandGenerator.NativeMethodInfoPtr_ClosePaintElement_Public_Static_Void_VisualElement_ClosingInfo_RenderChain_byref_ChainBuilderStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670105);
			CommandGenerator.NativeMethodInfoPtr_UpdateOrAllocate_Private_Static_Void_byref_MeshHandle_Int32_Int32_UIRenderDevice_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_byref_UInt16_byref_ChainBuilderStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670106);
			CommandGenerator.NativeMethodInfoPtr_UpdateOpacityId_Public_Static_Void_VisualElement_RenderChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670107);
			CommandGenerator.NativeMethodInfoPtr_DoUpdateOpacityId_Private_Static_Void_VisualElement_RenderChain_MeshHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670108);
			CommandGenerator.NativeMethodInfoPtr_NudgeVerticesToNewSpace_Public_Static_Boolean_VisualElement_RenderChain_UIRenderDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670109);
			CommandGenerator.NativeMethodInfoPtr_PrepareNudgeVertices_Private_Static_Void_VisualElement_UIRenderDevice_MeshHandle_byref_IntPtr_byref_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670110);
			CommandGenerator.NativeMethodInfoPtr_InjectMeshDrawCommand_Private_Static_RenderChainCommand_RenderChain_VisualElement_byref_RenderChainCommand_byref_RenderChainCommand_MeshHandle_Int32_Int32_Material_TextureId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670111);
			CommandGenerator.NativeMethodInfoPtr_InjectClosingMeshDrawCommand_Private_Static_RenderChainCommand_RenderChain_VisualElement_byref_RenderChainCommand_byref_RenderChainCommand_MeshHandle_Int32_Int32_Material_TextureId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670112);
			CommandGenerator.NativeMethodInfoPtr_FindCommandInsertionPoint_Private_Static_Void_VisualElement_byref_RenderChainCommand_byref_RenderChainCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670113);
			CommandGenerator.NativeMethodInfoPtr_FindClosingCommandInsertionPoint_Private_Static_Void_VisualElement_byref_RenderChainCommand_byref_RenderChainCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670114);
			CommandGenerator.NativeMethodInfoPtr_InjectCommandInBetween_Private_Static_Void_RenderChain_RenderChainCommand_byref_RenderChainCommand_byref_RenderChainCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670115);
			CommandGenerator.NativeMethodInfoPtr_InjectClosingCommandInBetween_Private_Static_Void_RenderChain_RenderChainCommand_byref_RenderChainCommand_byref_RenderChainCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670116);
			CommandGenerator.NativeMethodInfoPtr_ResetCommands_Public_Static_Void_RenderChain_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandGenerator>.NativeClassPtr, 100670117);
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x000C78A0 File Offset: 0x000C5AA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352848, RefRangeEnd = 352850, XrefRangeStart = 352827, XrefRangeEnd = 352848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetVerticesTransformInfo(VisualElement ve, out Matrix4x4 transform)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &transform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_GetVerticesTransformInfo_Private_Static_Void_VisualElement_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x000C78E4 File Offset: 0x000C5AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352860, RefRangeEnd = 352861, XrefRangeStart = 352850, XrefRangeEnd = 352860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ComputeTransformMatrix(VisualElement ve, VisualElement ancestor, out Matrix4x4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ancestor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_ComputeTransformMatrix_Internal_Static_Void_VisualElement_VisualElement_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x000C793C File Offset: 0x000C5B3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352865, RefRangeEnd = 352867, XrefRangeStart = 352861, XrefRangeEnd = 352865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsParentOrAncestorOf(this VisualElement ve, VisualElement child)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(child);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_IsParentOrAncestorOf_Private_Static_Boolean_VisualElement_VisualElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x000C7990 File Offset: 0x000C5B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352867, XrefRangeEnd = 353122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIRStylePainter.ClosingInfo PaintElement(RenderChain renderChain, VisualElement ve, ref ChainBuilderStats stats)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stats;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_PaintElement_Public_Static_ClosingInfo_RenderChain_VisualElement_byref_ChainBuilderStats_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new UIRStylePainter.ClosingInfo(intPtr);
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x000C79EC File Offset: 0x000C5BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353122, XrefRangeEnd = 353134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeGenerateVisualContent(VisualElement ve, MeshGenerationContext ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_InvokeGenerateVisualContent_Private_Static_Void_VisualElement_MeshGenerationContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x000C7A34 File Offset: 0x000C5C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353134, XrefRangeEnd = 353174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material CreateBlitShader(float colorConversion)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref colorConversion;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_CreateBlitShader_Private_Static_Material_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x000C7A74 File Offset: 0x000C5C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353186, RefRangeEnd = 353187, XrefRangeStart = 353174, XrefRangeEnd = 353186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetBlitMaterial(VisualElement.RenderTargetMode mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_GetBlitMaterial_Private_Static_Material_RenderTargetMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x000C7AB4 File Offset: 0x000C5CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353187, XrefRangeEnd = 353226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClosePaintElement(VisualElement ve, UIRStylePainter.ClosingInfo closingInfo, RenderChain renderChain, ref ChainBuilderStats stats)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(closingInfo));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stats;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_ClosePaintElement_Public_Static_Void_VisualElement_ClosingInfo_RenderChain_byref_ChainBuilderStats_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x000C7B24 File Offset: 0x000C5D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353226, XrefRangeEnd = 353228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<Vertex> verts, out NativeSlice<ushort> indices, out ushort indexOffset, ref ChainBuilderStats stats)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(device);
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexOffset;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stats;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_UpdateOrAllocate_Private_Static_Void_byref_MeshHandle_Int32_Int32_UIRenderDevice_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_byref_UInt16_byref_ChainBuilderStats_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			data = ((intPtr6 == 0) ? null : new MeshHandle(intPtr6));
			IntPtr intPtr7 = intPtr2;
			verts = ((intPtr7 == 0) ? null : new NativeSlice<Vertex>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			indices = ((intPtr8 == 0) ? null : new NativeSlice<ushort>(intPtr8));
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x000C7C04 File Offset: 0x000C5E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353228, XrefRangeEnd = 353235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateOpacityId(VisualElement ve, RenderChain renderChain)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_UpdateOpacityId_Public_Static_Void_VisualElement_RenderChain_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x000C7C4C File Offset: 0x000C5E4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 353244, RefRangeEnd = 353248, XrefRangeStart = 353235, XrefRangeEnd = 353244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoUpdateOpacityId(VisualElement ve, RenderChain renderChain, MeshHandle mesh)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_DoUpdateOpacityId_Private_Static_Void_VisualElement_RenderChain_MeshHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x000C7CA8 File Offset: 0x000C5EA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353266, RefRangeEnd = 353267, XrefRangeStart = 353248, XrefRangeEnd = 353266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NudgeVerticesToNewSpace(VisualElement ve, RenderChain renderChain, UIRenderDevice device)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(device);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_NudgeVerticesToNewSpace_Public_Static_Boolean_VisualElement_RenderChain_UIRenderDevice_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x000C7D10 File Offset: 0x000C5F10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353278, RefRangeEnd = 353280, XrefRangeStart = 353267, XrefRangeEnd = 353278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrepareNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, out IntPtr src, out IntPtr dst, out int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(device);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &src;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dst;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_PrepareNudgeVertices_Private_Static_Void_VisualElement_UIRenderDevice_MeshHandle_byref_IntPtr_byref_IntPtr_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x000C7D98 File Offset: 0x000C5F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353289, RefRangeEnd = 353290, XrefRangeStart = 353280, XrefRangeEnd = 353289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderChainCommand InjectMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cmdPrev);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(cmdNext);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexOffset;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref texture;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilRef;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_InjectMeshDrawCommand_Private_Static_RenderChainCommand_RenderChain_VisualElement_byref_RenderChainCommand_byref_RenderChainCommand_MeshHandle_Int32_Int32_Material_TextureId_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			cmdPrev = ((intPtr5 == 0) ? null : new RenderChainCommand(intPtr5));
			IntPtr intPtr6 = intPtr2;
			cmdNext = ((intPtr6 == 0) ? null : new RenderChainCommand(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr7) : null;
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x000C7EA0 File Offset: 0x000C60A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353290, XrefRangeEnd = 353299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderChainCommand InjectClosingMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cmdPrev);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(cmdNext);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexOffset;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref texture;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilRef;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_InjectClosingMeshDrawCommand_Private_Static_RenderChainCommand_RenderChain_VisualElement_byref_RenderChainCommand_byref_RenderChainCommand_MeshHandle_Int32_Int32_Material_TextureId_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			cmdPrev = ((intPtr5 == 0) ? null : new RenderChainCommand(intPtr5));
			IntPtr intPtr6 = intPtr2;
			cmdNext = ((intPtr6 == 0) ? null : new RenderChainCommand(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr7) : null;
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x000C7FA8 File Offset: 0x000C61A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353317, RefRangeEnd = 353318, XrefRangeStart = 353299, XrefRangeEnd = 353317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FindCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_FindCommandInsertionPoint_Private_Static_Void_VisualElement_byref_RenderChainCommand_byref_RenderChainCommand_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prev = ((intPtr5 == 0) ? null : new RenderChainCommand(intPtr5));
			IntPtr intPtr6 = intPtr2;
			next = ((intPtr6 == 0) ? null : new RenderChainCommand(intPtr6));
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x000C8024 File Offset: 0x000C6224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353335, RefRangeEnd = 353336, XrefRangeStart = 353318, XrefRangeEnd = 353335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FindClosingCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_FindClosingCommandInsertionPoint_Private_Static_Void_VisualElement_byref_RenderChainCommand_byref_RenderChainCommand_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prev = ((intPtr5 == 0) ? null : new RenderChainCommand(intPtr5));
			IntPtr intPtr6 = intPtr2;
			next = ((intPtr6 == 0) ? null : new RenderChainCommand(intPtr6));
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x000C80A0 File Offset: 0x000C62A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353347, RefRangeEnd = 353348, XrefRangeStart = 353336, XrefRangeEnd = 353347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(prev);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(next);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_InjectCommandInBetween_Private_Static_Void_RenderChain_RenderChainCommand_byref_RenderChainCommand_byref_RenderChainCommand_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prev = ((intPtr5 == 0) ? null : new RenderChainCommand(intPtr5));
			IntPtr intPtr6 = intPtr2;
			next = ((intPtr6 == 0) ? null : new RenderChainCommand(intPtr6));
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x000C8138 File Offset: 0x000C6338
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 353362, RefRangeEnd = 353369, XrefRangeStart = 353348, XrefRangeEnd = 353362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InjectClosingCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(prev);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(next);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_InjectClosingCommandInBetween_Private_Static_Void_RenderChain_RenderChainCommand_byref_RenderChainCommand_byref_RenderChainCommand_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prev = ((intPtr5 == 0) ? null : new RenderChainCommand(intPtr5));
			IntPtr intPtr6 = intPtr2;
			next = ((intPtr6 == 0) ? null : new RenderChainCommand(intPtr6));
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x000C81D0 File Offset: 0x000C63D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353406, RefRangeEnd = 353408, XrefRangeStart = 353369, XrefRangeEnd = 353406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetCommands(RenderChain renderChain, VisualElement ve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandGenerator.NativeMethodInfoPtr_ResetCommands_Public_Static_Void_RenderChain_VisualElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x000136FB File Offset: 0x000118FB
		public CommandGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06002F18 RID: 12056 RVA: 0x000C8218 File Offset: 0x000C6418
		// (set) Token: 0x06002F19 RID: 12057 RVA: 0x00013704 File Offset: 0x00011904
		public unsafe static ProfilerMarker k_GenerateEntries
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(CommandGenerator.NativeFieldInfoPtr_k_GenerateEntries, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandGenerator.NativeFieldInfoPtr_k_GenerateEntries, (void*)(&value));
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06002F1A RID: 12058 RVA: 0x000C8234 File Offset: 0x000C6434
		// (set) Token: 0x06002F1B RID: 12059 RVA: 0x00013712 File Offset: 0x00011912
		public unsafe static ProfilerMarker k_ConvertEntriesToCommandsMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(CommandGenerator.NativeFieldInfoPtr_k_ConvertEntriesToCommandsMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandGenerator.NativeFieldInfoPtr_k_ConvertEntriesToCommandsMarker, (void*)(&value));
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06002F1C RID: 12060 RVA: 0x000C8250 File Offset: 0x000C6450
		// (set) Token: 0x06002F1D RID: 12061 RVA: 0x00013720 File Offset: 0x00011920
		public unsafe static ProfilerMarker k_GenerateClosingCommandsMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(CommandGenerator.NativeFieldInfoPtr_k_GenerateClosingCommandsMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandGenerator.NativeFieldInfoPtr_k_GenerateClosingCommandsMarker, (void*)(&value));
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06002F1E RID: 12062 RVA: 0x000C826C File Offset: 0x000C646C
		// (set) Token: 0x06002F1F RID: 12063 RVA: 0x0001372E File Offset: 0x0001192E
		public unsafe static ProfilerMarker k_NudgeVerticesMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(CommandGenerator.NativeFieldInfoPtr_k_NudgeVerticesMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandGenerator.NativeFieldInfoPtr_k_NudgeVerticesMarker, (void*)(&value));
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06002F20 RID: 12064 RVA: 0x000C8288 File Offset: 0x000C6488
		// (set) Token: 0x06002F21 RID: 12065 RVA: 0x0001373C File Offset: 0x0001193C
		public unsafe static ProfilerMarker k_UpdateOpacityIdMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(CommandGenerator.NativeFieldInfoPtr_k_UpdateOpacityIdMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandGenerator.NativeFieldInfoPtr_k_UpdateOpacityIdMarker, (void*)(&value));
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06002F22 RID: 12066 RVA: 0x000C82A4 File Offset: 0x000C64A4
		// (set) Token: 0x06002F23 RID: 12067 RVA: 0x0001374A File Offset: 0x0001194A
		public unsafe static ProfilerMarker k_ComputeTransformMatrixMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(CommandGenerator.NativeFieldInfoPtr_k_ComputeTransformMatrixMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandGenerator.NativeFieldInfoPtr_k_ComputeTransformMatrixMarker, (void*)(&value));
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06002F24 RID: 12068 RVA: 0x000C82C0 File Offset: 0x000C64C0
		// (set) Token: 0x06002F25 RID: 12069 RVA: 0x00013758 File Offset: 0x00011958
		public unsafe static Material s_blitMaterial_LinearToGamma
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CommandGenerator.NativeFieldInfoPtr_s_blitMaterial_LinearToGamma, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandGenerator.NativeFieldInfoPtr_s_blitMaterial_LinearToGamma, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x000C82E8 File Offset: 0x000C64E8
		// (set) Token: 0x06002F27 RID: 12071 RVA: 0x0001376A File Offset: 0x0001196A
		public unsafe static Material s_blitMaterial_GammaToLinear
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CommandGenerator.NativeFieldInfoPtr_s_blitMaterial_GammaToLinear, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandGenerator.NativeFieldInfoPtr_s_blitMaterial_GammaToLinear, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x000C8310 File Offset: 0x000C6510
		// (set) Token: 0x06002F29 RID: 12073 RVA: 0x0001377C File Offset: 0x0001197C
		public unsafe static Material s_blitMaterial_NoChange
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CommandGenerator.NativeFieldInfoPtr_s_blitMaterial_NoChange, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandGenerator.NativeFieldInfoPtr_s_blitMaterial_NoChange, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06002F2A RID: 12074 RVA: 0x000C8338 File Offset: 0x000C6538
		// (set) Token: 0x06002F2B RID: 12075 RVA: 0x0001378E File Offset: 0x0001198E
		public unsafe static Shader s_blitShader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CommandGenerator.NativeFieldInfoPtr_s_blitShader, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandGenerator.NativeFieldInfoPtr_s_blitShader, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x000C8360 File Offset: 0x000C6560
		public static void CopyTriangleIndicesFlipWindingOrder(NativeSlice<ushort> source, NativeSlice<ushort> target, int indexOffset)
		{
			Debug.Assert(source != target);
			int length = source.Length;
			for (int i = 0; i < length; i += 3)
			{
				ushort num = (ushort)((int)source[i] + indexOffset);
				target[i] = (ushort)((int)source[i + 1] + indexOffset);
				target[i + 1] = num;
				target[i + 2] = (ushort)((int)source[i + 2] + indexOffset);
			}
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x000C83DC File Offset: 0x000C65DC
		public static void CopyTriangleIndices(NativeSlice<ushort> source, NativeSlice<ushort> target, int indexOffset)
		{
			int length = source.Length;
			for (int i = 0; i < length; i++)
			{
				target[i] = (ushort)((int)source[i] + indexOffset);
			}
		}

		// Token: 0x040021C6 RID: 8646
		private static readonly IntPtr NativeFieldInfoPtr_k_GenerateEntries;

		// Token: 0x040021C7 RID: 8647
		private static readonly IntPtr NativeFieldInfoPtr_k_ConvertEntriesToCommandsMarker;

		// Token: 0x040021C8 RID: 8648
		private static readonly IntPtr NativeFieldInfoPtr_k_GenerateClosingCommandsMarker;

		// Token: 0x040021C9 RID: 8649
		private static readonly IntPtr NativeFieldInfoPtr_k_NudgeVerticesMarker;

		// Token: 0x040021CA RID: 8650
		private static readonly IntPtr NativeFieldInfoPtr_k_UpdateOpacityIdMarker;

		// Token: 0x040021CB RID: 8651
		private static readonly IntPtr NativeFieldInfoPtr_k_ComputeTransformMatrixMarker;

		// Token: 0x040021CC RID: 8652
		private static readonly IntPtr NativeFieldInfoPtr_s_blitMaterial_LinearToGamma;

		// Token: 0x040021CD RID: 8653
		private static readonly IntPtr NativeFieldInfoPtr_s_blitMaterial_GammaToLinear;

		// Token: 0x040021CE RID: 8654
		private static readonly IntPtr NativeFieldInfoPtr_s_blitMaterial_NoChange;

		// Token: 0x040021CF RID: 8655
		private static readonly IntPtr NativeFieldInfoPtr_s_blitShader;

		// Token: 0x040021D0 RID: 8656
		private static readonly IntPtr NativeMethodInfoPtr_GetVerticesTransformInfo_Private_Static_Void_VisualElement_byref_Matrix4x4_0;

		// Token: 0x040021D1 RID: 8657
		private static readonly IntPtr NativeMethodInfoPtr_ComputeTransformMatrix_Internal_Static_Void_VisualElement_VisualElement_byref_Matrix4x4_0;

		// Token: 0x040021D2 RID: 8658
		private static readonly IntPtr NativeMethodInfoPtr_IsParentOrAncestorOf_Private_Static_Boolean_VisualElement_VisualElement_0;

		// Token: 0x040021D3 RID: 8659
		private static readonly IntPtr NativeMethodInfoPtr_PaintElement_Public_Static_ClosingInfo_RenderChain_VisualElement_byref_ChainBuilderStats_0;

		// Token: 0x040021D4 RID: 8660
		private static readonly IntPtr NativeMethodInfoPtr_InvokeGenerateVisualContent_Private_Static_Void_VisualElement_MeshGenerationContext_0;

		// Token: 0x040021D5 RID: 8661
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlitShader_Private_Static_Material_Single_0;

		// Token: 0x040021D6 RID: 8662
		private static readonly IntPtr NativeMethodInfoPtr_GetBlitMaterial_Private_Static_Material_RenderTargetMode_0;

		// Token: 0x040021D7 RID: 8663
		private static readonly IntPtr NativeMethodInfoPtr_ClosePaintElement_Public_Static_Void_VisualElement_ClosingInfo_RenderChain_byref_ChainBuilderStats_0;

		// Token: 0x040021D8 RID: 8664
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOrAllocate_Private_Static_Void_byref_MeshHandle_Int32_Int32_UIRenderDevice_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_byref_UInt16_byref_ChainBuilderStats_0;

		// Token: 0x040021D9 RID: 8665
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOpacityId_Public_Static_Void_VisualElement_RenderChain_0;

		// Token: 0x040021DA RID: 8666
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdateOpacityId_Private_Static_Void_VisualElement_RenderChain_MeshHandle_0;

		// Token: 0x040021DB RID: 8667
		private static readonly IntPtr NativeMethodInfoPtr_NudgeVerticesToNewSpace_Public_Static_Boolean_VisualElement_RenderChain_UIRenderDevice_0;

		// Token: 0x040021DC RID: 8668
		private static readonly IntPtr NativeMethodInfoPtr_PrepareNudgeVertices_Private_Static_Void_VisualElement_UIRenderDevice_MeshHandle_byref_IntPtr_byref_IntPtr_byref_Int32_0;

		// Token: 0x040021DD RID: 8669
		private static readonly IntPtr NativeMethodInfoPtr_InjectMeshDrawCommand_Private_Static_RenderChainCommand_RenderChain_VisualElement_byref_RenderChainCommand_byref_RenderChainCommand_MeshHandle_Int32_Int32_Material_TextureId_Int32_0;

		// Token: 0x040021DE RID: 8670
		private static readonly IntPtr NativeMethodInfoPtr_InjectClosingMeshDrawCommand_Private_Static_RenderChainCommand_RenderChain_VisualElement_byref_RenderChainCommand_byref_RenderChainCommand_MeshHandle_Int32_Int32_Material_TextureId_Int32_0;

		// Token: 0x040021DF RID: 8671
		private static readonly IntPtr NativeMethodInfoPtr_FindCommandInsertionPoint_Private_Static_Void_VisualElement_byref_RenderChainCommand_byref_RenderChainCommand_0;

		// Token: 0x040021E0 RID: 8672
		private static readonly IntPtr NativeMethodInfoPtr_FindClosingCommandInsertionPoint_Private_Static_Void_VisualElement_byref_RenderChainCommand_byref_RenderChainCommand_0;

		// Token: 0x040021E1 RID: 8673
		private static readonly IntPtr NativeMethodInfoPtr_InjectCommandInBetween_Private_Static_Void_RenderChain_RenderChainCommand_byref_RenderChainCommand_byref_RenderChainCommand_0;

		// Token: 0x040021E2 RID: 8674
		private static readonly IntPtr NativeMethodInfoPtr_InjectClosingCommandInBetween_Private_Static_Void_RenderChain_RenderChainCommand_byref_RenderChainCommand_byref_RenderChainCommand_0;

		// Token: 0x040021E3 RID: 8675
		private static readonly IntPtr NativeMethodInfoPtr_ResetCommands_Public_Static_Void_RenderChain_VisualElement_0;
	}
}
