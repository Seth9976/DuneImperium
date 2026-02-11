using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements.UIR.Implementation
{
	// Token: 0x0200027C RID: 636
	public class UIRStylePainter : Object
	{
		// Token: 0x06002F4F RID: 12111 RVA: 0x000C90F4 File Offset: 0x000C72F4
		// Note: this type is marked as 'beforefieldinit'.
		static UIRStylePainter()
		{
			Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR.Implementation", "UIRStylePainter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr);
			UIRStylePainter.NativeFieldInfoPtr_m_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_Owner");
			UIRStylePainter.NativeFieldInfoPtr_m_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_Entries");
			UIRStylePainter.NativeFieldInfoPtr_m_Atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_Atlas");
			UIRStylePainter.NativeFieldInfoPtr_m_VectorImageManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_VectorImageManager");
			UIRStylePainter.NativeFieldInfoPtr_m_CurrentEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_CurrentEntry");
			UIRStylePainter.NativeFieldInfoPtr_m_ClosingInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_ClosingInfo");
			UIRStylePainter.NativeFieldInfoPtr_m_MaskDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_MaskDepth");
			UIRStylePainter.NativeFieldInfoPtr_m_StencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_StencilRef");
			UIRStylePainter.NativeFieldInfoPtr_m_ClipRectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_ClipRectID");
			UIRStylePainter.NativeFieldInfoPtr_m_SVGBackgroundEntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_SVGBackgroundEntryIndex");
			UIRStylePainter.NativeFieldInfoPtr_m_VertsPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_VertsPool");
			UIRStylePainter.NativeFieldInfoPtr_m_IndicesPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_IndicesPool");
			UIRStylePainter.NativeFieldInfoPtr_m_MeshWriteDataPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_MeshWriteDataPool");
			UIRStylePainter.NativeFieldInfoPtr_m_NextMeshWriteDataPoolItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_NextMeshWriteDataPoolItem");
			UIRStylePainter.NativeFieldInfoPtr_m_RepeatRectUVList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_RepeatRectUVList");
			UIRStylePainter.NativeFieldInfoPtr_m_AllocRawVertsIndicesDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_AllocRawVertsIndicesDelegate");
			UIRStylePainter.NativeFieldInfoPtr_m_AllocThroughDrawMeshDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_AllocThroughDrawMeshDelegate");
			UIRStylePainter.NativeFieldInfoPtr__meshGenerationContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "<meshGenerationContext>k__BackingField");
			UIRStylePainter.NativeFieldInfoPtr__currentElement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "<currentElement>k__BackingField");
			UIRStylePainter.NativeFieldInfoPtr__totalVertices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "<totalVertices>k__BackingField");
			UIRStylePainter.NativeFieldInfoPtr__totalIndices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "<totalIndices>k__BackingField");
			UIRStylePainter.NativeFieldInfoPtr_m_TextInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "m_TextInfo");
			UIRStylePainter.NativeMethodInfoPtr_GetPooledMeshWriteData_Private_MeshWriteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670146);
			UIRStylePainter.NativeMethodInfoPtr_AllocRawVertsIndices_Private_MeshWriteData_UInt32_UInt32_byref_AllocMeshData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670147);
			UIRStylePainter.NativeMethodInfoPtr_AllocThroughDrawMesh_Private_MeshWriteData_UInt32_UInt32_byref_AllocMeshData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670148);
			UIRStylePainter.NativeMethodInfoPtr__ctor_Public_Void_RenderChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670149);
			UIRStylePainter.NativeMethodInfoPtr_get_meshGenerationContext_Public_get_MeshGenerationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670150);
			UIRStylePainter.NativeMethodInfoPtr_get_currentElement_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670151);
			UIRStylePainter.NativeMethodInfoPtr_set_currentElement_Private_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670152);
			UIRStylePainter.NativeMethodInfoPtr_get_entries_Public_get_List_1_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670153);
			UIRStylePainter.NativeMethodInfoPtr_get_closingInfo_Public_get_ClosingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670154);
			UIRStylePainter.NativeMethodInfoPtr_get_totalVertices_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670155);
			UIRStylePainter.NativeMethodInfoPtr_set_totalVertices_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670156);
			UIRStylePainter.NativeMethodInfoPtr_get_totalIndices_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670157);
			UIRStylePainter.NativeMethodInfoPtr_set_totalIndices_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670158);
			UIRStylePainter.NativeMethodInfoPtr_Begin_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670159);
			UIRStylePainter.NativeMethodInfoPtr_LandClipUnregisterMeshDrawCommand_Public_Void_RenderChainCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670160);
			UIRStylePainter.NativeMethodInfoPtr_LandClipRegisterMesh_Public_Void_NativeSlice_1_Vertex_NativeSlice_1_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670161);
			UIRStylePainter.NativeMethodInfoPtr_DrawMesh_Public_Virtual_Final_New_MeshWriteData_Int32_Int32_Texture_Material_MeshFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670162);
			UIRStylePainter.NativeMethodInfoPtr_TryAtlasTexture_Internal_Void_Texture_MeshFlags_byref_Rect_byref_Boolean_byref_TextureId_byref_VertexFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670163);
			UIRStylePainter.NativeMethodInfoPtr_BuildEntryFromNativeMesh_Internal_Void_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670164);
			UIRStylePainter.NativeMethodInfoPtr_BuildGradientEntryFromNativeMesh_Internal_Void_MeshWriteDataInterface_TextureId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670165);
			UIRStylePainter.NativeMethodInfoPtr_BuildRawEntryFromNativeMesh_Public_Void_MeshWriteDataInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670166);
			UIRStylePainter.NativeMethodInfoPtr_DrawText_Public_Virtual_Final_New_Void_TextElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670167);
			UIRStylePainter.NativeMethodInfoPtr_DrawTextInfo_Private_Void_TextInfo_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670168);
			UIRStylePainter.NativeMethodInfoPtr_DrawRectangle_Public_Virtual_Final_New_Void_RectangleParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670169);
			UIRStylePainter.NativeMethodInfoPtr_DrawBorder_Public_Virtual_Final_New_Void_BorderParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670170);
			UIRStylePainter.NativeMethodInfoPtr_DrawImmediate_Public_Virtual_Final_New_Void_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670171);
			UIRStylePainter.NativeMethodInfoPtr_get_visualElement_Public_Virtual_Final_New_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670172);
			UIRStylePainter.NativeMethodInfoPtr_DrawVisualElementBackground_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670173);
			UIRStylePainter.NativeMethodInfoPtr_DrawRectangleRepeat_Private_Void_RectangleParams_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670174);
			UIRStylePainter.NativeMethodInfoPtr_StampRectangleWithSubRect_Private_Void_RectangleParams_Rect_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670175);
			UIRStylePainter.NativeMethodInfoPtr_DrawVisualElementBorder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670176);
			UIRStylePainter.NativeMethodInfoPtr_ApplyVisualElementClipping_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670177);
			UIRStylePainter.NativeMethodInfoPtr_AdjustSpriteWinding_Private_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670178);
			UIRStylePainter.NativeMethodInfoPtr_DrawSprite_Public_Void_RectangleParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670179);
			UIRStylePainter.NativeMethodInfoPtr_DrawVectorImage_Public_Void_RectangleParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670180);
			UIRStylePainter.NativeMethodInfoPtr_MakeVectorGraphics_Private_Void_RectangleParams_Boolean_TextureId_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670181);
			UIRStylePainter.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670182);
			UIRStylePainter.NativeMethodInfoPtr_ValidateMeshWriteData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670183);
			UIRStylePainter.NativeMethodInfoPtr_GenerateStencilClipEntryForRoundedRectBackground_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670184);
			UIRStylePainter.NativeMethodInfoPtr_GenerateStencilClipEntryForSVGBackground_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, 100670185);
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x000C95FC File Offset: 0x000C77FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354225, RefRangeEnd = 354227, XrefRangeStart = 354213, XrefRangeEnd = 354225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshWriteData GetPooledMeshWriteData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_GetPooledMeshWriteData_Private_MeshWriteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshWriteData>(intPtr3) : null;
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x000C963C File Offset: 0x000C783C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354227, XrefRangeEnd = 354235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshWriteData AllocRawVertsIndices(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_AllocRawVertsIndices_Private_MeshWriteData_UInt32_UInt32_byref_AllocMeshData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshWriteData>(intPtr3) : null;
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x000C96AC File Offset: 0x000C78AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354235, XrefRangeEnd = 354236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshWriteData AllocThroughDrawMesh(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_AllocThroughDrawMesh_Private_MeshWriteData_UInt32_UInt32_byref_AllocMeshData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshWriteData>(intPtr3) : null;
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x000C971C File Offset: 0x000C791C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354295, RefRangeEnd = 354296, XrefRangeStart = 354236, XrefRangeEnd = 354295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIRStylePainter(RenderChain renderChain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr__ctor_Public_Void_RenderChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06002F54 RID: 12116 RVA: 0x000C9768 File Offset: 0x000C7968
		public unsafe MeshGenerationContext meshGenerationContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_get_meshGenerationContext_Public_get_MeshGenerationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshGenerationContext>(intPtr3) : null;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06002F55 RID: 12117 RVA: 0x000C97A8 File Offset: 0x000C79A8
		// (set) Token: 0x06002F56 RID: 12118 RVA: 0x000C97E8 File Offset: 0x000C79E8
		public unsafe VisualElement currentElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_get_currentElement_Public_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_set_currentElement_Private_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06002F57 RID: 12119 RVA: 0x000C982C File Offset: 0x000C7A2C
		public unsafe List<UIRStylePainter.Entry> entries
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 318167, RefRangeEnd = 318212, XrefRangeStart = 318167, XrefRangeEnd = 318212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_get_entries_Public_get_List_1_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<UIRStylePainter.Entry>>(intPtr3) : null;
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06002F58 RID: 12120 RVA: 0x000C986C File Offset: 0x000C7A6C
		public unsafe UIRStylePainter.ClosingInfo closingInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_get_closingInfo_Public_get_ClosingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new UIRStylePainter.ClosingInfo(intPtr);
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06002F59 RID: 12121 RVA: 0x000C98A4 File Offset: 0x000C7AA4
		// (set) Token: 0x06002F5A RID: 12122 RVA: 0x000C98E0 File Offset: 0x000C7AE0
		public unsafe int totalVertices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_get_totalVertices_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_set_totalVertices_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x000C9920 File Offset: 0x000C7B20
		// (set) Token: 0x06002F5C RID: 12124 RVA: 0x000C995C File Offset: 0x000C7B5C
		public unsafe int totalIndices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_get_totalIndices_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_set_totalIndices_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x000C999C File Offset: 0x000C7B9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354341, RefRangeEnd = 354343, XrefRangeStart = 354296, XrefRangeEnd = 354341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_Begin_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x000C99E0 File Offset: 0x000C7BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354343, XrefRangeEnd = 354348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_LandClipUnregisterMeshDrawCommand_Public_Void_RenderChainCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x000C9A24 File Offset: 0x000C7C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354348, XrefRangeEnd = 354352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LandClipRegisterMesh(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, int indexOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vertices));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(indices));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_LandClipRegisterMesh_Public_Void_NativeSlice_1_Vertex_NativeSlice_1_UInt16_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x000C9A90 File Offset: 0x000C7C90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354395, RefRangeEnd = 354396, XrefRangeStart = 354352, XrefRangeEnd = 354395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshGenerationContext.MeshFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_DrawMesh_Public_Virtual_Final_New_MeshWriteData_Int32_Int32_Texture_Material_MeshFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshWriteData>(intPtr3) : null;
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x000C9B20 File Offset: 0x000C7D20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354403, RefRangeEnd = 354404, XrefRangeStart = 354396, XrefRangeEnd = 354403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryAtlasTexture(Texture texture, MeshGenerationContext.MeshFlags flags, out Rect outUVRegion, out bool outIsAtlas, out TextureId outTextureId, out VertexFlags outAddFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outUVRegion;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outIsAtlas;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outTextureId;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outAddFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_TryAtlasTexture_Internal_Void_Texture_MeshFlags_byref_Rect_byref_Boolean_byref_TextureId_byref_VertexFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x000C9BAC File Offset: 0x000C7DAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 354464, RefRangeEnd = 354468, XrefRangeStart = 354404, XrefRangeEnd = 354464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildEntryFromNativeMesh(MeshWriteDataInterface meshData, Texture texture, TextureId textureId, bool isAtlas, Material material, MeshGenerationContext.MeshFlags flags, Rect uvRegion, VertexFlags addFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref meshData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAtlas;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uvRegion;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_BuildEntryFromNativeMesh_Internal_Void_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x000C9C58 File Offset: 0x000C7E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354468, XrefRangeEnd = 354522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildGradientEntryFromNativeMesh(MeshWriteDataInterface meshData, TextureId svgTextureId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref meshData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref svgTextureId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_BuildGradientEntryFromNativeMesh_Internal_Void_MeshWriteDataInterface_TextureId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x000C9CA4 File Offset: 0x000C7EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354551, RefRangeEnd = 354552, XrefRangeStart = 354522, XrefRangeEnd = 354551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildRawEntryFromNativeMesh(MeshWriteDataInterface meshData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref meshData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_BuildRawEntryFromNativeMesh_Public_Void_MeshWriteDataInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x000C9CE4 File Offset: 0x000C7EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354552, XrefRangeEnd = 354557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DrawText(TextElement te)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(te);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_DrawText_Public_Virtual_Final_New_Void_TextElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x000C9D28 File Offset: 0x000C7F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354607, RefRangeEnd = 354608, XrefRangeStart = 354557, XrefRangeEnd = 354607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawTextInfo(TextInfo textInfo, Vector2 offset, bool useHints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useHints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_DrawTextInfo_Private_Void_TextInfo_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x000C9D88 File Offset: 0x000C7F88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 354628, RefRangeEnd = 354631, XrefRangeStart = 354608, XrefRangeEnd = 354628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rectParams));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_DrawRectangle_Public_Virtual_Final_New_Void_RectangleParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x000C9DD0 File Offset: 0x000C7FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354631, XrefRangeEnd = 354634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DrawBorder(MeshGenerationContextUtils.BorderParams borderParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(borderParams));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_DrawBorder_Public_Virtual_Final_New_Void_BorderParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x000C9E18 File Offset: 0x000C8018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354634, XrefRangeEnd = 354641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DrawImmediate(Action callback, bool cullingEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cullingEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_DrawImmediate_Public_Virtual_Final_New_Void_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06002F6A RID: 12138 RVA: 0x000C9E68 File Offset: 0x000C8068
		public unsafe virtual VisualElement visualElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_get_visualElement_Public_Virtual_Final_New_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x000C9EA8 File Offset: 0x000C80A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354784, RefRangeEnd = 354785, XrefRangeStart = 354641, XrefRangeEnd = 354784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawVisualElementBackground()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_DrawVisualElementBackground_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x000C9EDC File Offset: 0x000C80DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354785, XrefRangeEnd = 354954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawRectangleRepeat(MeshGenerationContextUtils.RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rectParams));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalRect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaledPixelsPerPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_DrawRectangleRepeat_Private_Void_RectangleParams_Rect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x000C9F40 File Offset: 0x000C8140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354967, RefRangeEnd = 354968, XrefRangeStart = 354954, XrefRangeEnd = 354967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StampRectangleWithSubRect(MeshGenerationContextUtils.RectangleParams rectParams, Rect targetRect, Rect totalRect, Rect targetUV)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rectParams));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetRect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetUV;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_StampRectangleWithSubRect_Private_Void_RectangleParams_Rect_Rect_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x000C9FB4 File Offset: 0x000C81B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355025, RefRangeEnd = 355026, XrefRangeStart = 354968, XrefRangeEnd = 355025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawVisualElementBorder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_DrawVisualElementBorder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x000C9FE8 File Offset: 0x000C81E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 355044, RefRangeEnd = 355046, XrefRangeStart = 355026, XrefRangeEnd = 355044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyVisualElementClipping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_ApplyVisualElementClipping_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x000CA01C File Offset: 0x000C821C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355067, RefRangeEnd = 355068, XrefRangeStart = 355046, XrefRangeEnd = 355067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<ushort> AdjustSpriteWinding(Il2CppStructArray<Vector2> vertices, Il2CppStructArray<ushort> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_AdjustSpriteWinding_Private_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr3) : null;
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x000CA080 File Offset: 0x000C8280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355099, RefRangeEnd = 355100, XrefRangeStart = 355068, XrefRangeEnd = 355099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawSprite(MeshGenerationContextUtils.RectangleParams rectParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rectParams));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_DrawSprite_Public_Void_RectangleParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x000CA0C8 File Offset: 0x000C82C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355152, RefRangeEnd = 355153, XrefRangeStart = 355100, XrefRangeEnd = 355152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawVectorImage(MeshGenerationContextUtils.RectangleParams rectParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rectParams));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_DrawVectorImage_Public_Void_RectangleParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x000CA110 File Offset: 0x000C8310
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355170, RefRangeEnd = 355171, XrefRangeStart = 355153, XrefRangeEnd = 355170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeVectorGraphics(MeshGenerationContextUtils.RectangleParams rectParams, bool isUsingGradients, TextureId svgTexture, int settingIndexOffset, out int finalVertexCount, out int finalIndexCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rectParams));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isUsingGradients;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref svgTexture;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref settingIndexOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &finalVertexCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &finalIndexCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_MakeVectorGraphics_Private_Void_RectangleParams_Boolean_TextureId_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x000CA1A0 File Offset: 0x000C83A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 355175, RefRangeEnd = 355177, XrefRangeStart = 355171, XrefRangeEnd = 355175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x000CA1D4 File Offset: 0x000C83D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355233, RefRangeEnd = 355234, XrefRangeStart = 355177, XrefRangeEnd = 355233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateMeshWriteData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_ValidateMeshWriteData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x000CA208 File Offset: 0x000C8408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355291, RefRangeEnd = 355292, XrefRangeStart = 355234, XrefRangeEnd = 355291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateStencilClipEntryForRoundedRectBackground()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_GenerateStencilClipEntryForRoundedRectBackground_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x000CA23C File Offset: 0x000C843C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355324, RefRangeEnd = 355325, XrefRangeStart = 355292, XrefRangeEnd = 355324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateStencilClipEntryForSVGBackground()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRStylePainter.NativeMethodInfoPtr_GenerateStencilClipEntryForSVGBackground_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x000137C4 File Offset: 0x000119C4
		public UIRStylePainter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06002F79 RID: 12153 RVA: 0x000CA270 File Offset: 0x000C8470
		// (set) Token: 0x06002F7A RID: 12154 RVA: 0x000137CD File Offset: 0x000119CD
		public unsafe RenderChain m_Owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_Owner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_Owner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06002F7B RID: 12155 RVA: 0x000CA2A0 File Offset: 0x000C84A0
		// (set) Token: 0x06002F7C RID: 12156 RVA: 0x000137EC File Offset: 0x000119EC
		public unsafe List<UIRStylePainter.Entry> m_Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIRStylePainter.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06002F7D RID: 12157 RVA: 0x000CA2D0 File Offset: 0x000C84D0
		// (set) Token: 0x06002F7E RID: 12158 RVA: 0x0001380B File Offset: 0x00011A0B
		public unsafe AtlasBase m_Atlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_Atlas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtlasBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_Atlas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06002F7F RID: 12159 RVA: 0x000CA300 File Offset: 0x000C8500
		// (set) Token: 0x06002F80 RID: 12160 RVA: 0x0001382A File Offset: 0x00011A2A
		public unsafe VectorImageManager m_VectorImageManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_VectorImageManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VectorImageManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_VectorImageManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06002F81 RID: 12161 RVA: 0x000CA330 File Offset: 0x000C8530
		// (set) Token: 0x06002F82 RID: 12162 RVA: 0x00013849 File Offset: 0x00011A49
		public UIRStylePainter.Entry m_CurrentEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_CurrentEntry);
				return new UIRStylePainter.Entry(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_CurrentEntry), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06002F83 RID: 12163 RVA: 0x000CA360 File Offset: 0x000C8560
		// (set) Token: 0x06002F84 RID: 12164 RVA: 0x00013877 File Offset: 0x00011A77
		public UIRStylePainter.ClosingInfo m_ClosingInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_ClosingInfo);
				return new UIRStylePainter.ClosingInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_ClosingInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x000CA390 File Offset: 0x000C8590
		// (set) Token: 0x06002F86 RID: 12166 RVA: 0x000138A5 File Offset: 0x00011AA5
		public unsafe int m_MaskDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_MaskDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_MaskDepth)) = value;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x000CA3B8 File Offset: 0x000C85B8
		// (set) Token: 0x06002F88 RID: 12168 RVA: 0x000138C0 File Offset: 0x00011AC0
		public unsafe int m_StencilRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_StencilRef);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_StencilRef)) = value;
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x000CA3E0 File Offset: 0x000C85E0
		// (set) Token: 0x06002F8A RID: 12170 RVA: 0x000138DB File Offset: 0x00011ADB
		public unsafe BMPAlloc m_ClipRectID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_ClipRectID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_ClipRectID)) = value;
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06002F8B RID: 12171 RVA: 0x000CA408 File Offset: 0x000C8608
		// (set) Token: 0x06002F8C RID: 12172 RVA: 0x000138F6 File Offset: 0x00011AF6
		public unsafe int m_SVGBackgroundEntryIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_SVGBackgroundEntryIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_SVGBackgroundEntryIndex)) = value;
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06002F8D RID: 12173 RVA: 0x000CA430 File Offset: 0x000C8630
		// (set) Token: 0x06002F8E RID: 12174 RVA: 0x00013911 File Offset: 0x00011B11
		public unsafe TempAllocator<Vertex> m_VertsPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_VertsPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TempAllocator<Vertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_VertsPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06002F8F RID: 12175 RVA: 0x000CA460 File Offset: 0x000C8660
		// (set) Token: 0x06002F90 RID: 12176 RVA: 0x00013930 File Offset: 0x00011B30
		public unsafe TempAllocator<ushort> m_IndicesPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_IndicesPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TempAllocator<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_IndicesPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x000CA490 File Offset: 0x000C8690
		// (set) Token: 0x06002F92 RID: 12178 RVA: 0x0001394F File Offset: 0x00011B4F
		public unsafe List<MeshWriteData> m_MeshWriteDataPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_MeshWriteDataPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshWriteData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_MeshWriteDataPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06002F93 RID: 12179 RVA: 0x000CA4C0 File Offset: 0x000C86C0
		// (set) Token: 0x06002F94 RID: 12180 RVA: 0x0001396E File Offset: 0x00011B6E
		public unsafe int m_NextMeshWriteDataPoolItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_NextMeshWriteDataPoolItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_NextMeshWriteDataPoolItem)) = value;
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06002F95 RID: 12181 RVA: 0x000CA4E8 File Offset: 0x000C86E8
		// (set) Token: 0x06002F96 RID: 12182 RVA: 0x00013989 File Offset: 0x00011B89
		public unsafe Il2CppReferenceArray<List<UIRStylePainter.RepeatRectUV>> m_RepeatRectUVList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_RepeatRectUVList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<UIRStylePainter.RepeatRectUV>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_RepeatRectUVList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06002F97 RID: 12183 RVA: 0x000CA518 File Offset: 0x000C8718
		// (set) Token: 0x06002F98 RID: 12184 RVA: 0x000139A8 File Offset: 0x00011BA8
		public unsafe MeshBuilder.AllocMeshData.Allocator m_AllocRawVertsIndicesDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_AllocRawVertsIndicesDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshBuilder.AllocMeshData.Allocator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_AllocRawVertsIndicesDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06002F99 RID: 12185 RVA: 0x000CA548 File Offset: 0x000C8748
		// (set) Token: 0x06002F9A RID: 12186 RVA: 0x000139C7 File Offset: 0x00011BC7
		public unsafe MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawMeshDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_AllocThroughDrawMeshDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshBuilder.AllocMeshData.Allocator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_AllocThroughDrawMeshDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06002F9B RID: 12187 RVA: 0x000CA578 File Offset: 0x000C8778
		// (set) Token: 0x06002F9C RID: 12188 RVA: 0x000139E6 File Offset: 0x00011BE6
		public unsafe MeshGenerationContext _meshGenerationContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr__meshGenerationContext_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshGenerationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr__meshGenerationContext_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06002F9D RID: 12189 RVA: 0x000CA5A8 File Offset: 0x000C87A8
		// (set) Token: 0x06002F9E RID: 12190 RVA: 0x00013A05 File Offset: 0x00011C05
		public unsafe VisualElement _currentElement_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr__currentElement_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr__currentElement_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06002F9F RID: 12191 RVA: 0x000CA5D8 File Offset: 0x000C87D8
		// (set) Token: 0x06002FA0 RID: 12192 RVA: 0x00013A24 File Offset: 0x00011C24
		public unsafe int _totalVertices_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr__totalVertices_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr__totalVertices_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x000CA600 File Offset: 0x000C8800
		// (set) Token: 0x06002FA2 RID: 12194 RVA: 0x00013A3F File Offset: 0x00011C3F
		public unsafe int _totalIndices_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr__totalIndices_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr__totalIndices_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x000CA628 File Offset: 0x000C8828
		// (set) Token: 0x06002FA4 RID: 12196 RVA: 0x00013A5A File Offset: 0x00011C5A
		public unsafe TextInfo m_TextInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_TextInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.NativeFieldInfoPtr_m_TextInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x00013A79 File Offset: 0x00011C79
		public MeshWriteData AddGradientsEntry(int vertexCount, int indexCount, TextureId texture, Material material, MeshGenerationContext.MeshFlags flags)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x000CA658 File Offset: 0x000C8858
		public void DrawText(string text, Vector2 pos, float fontSize, Color color, FontAsset font)
		{
			PanelTextSettings textSettingsFrom = TextUtilities.GetTextSettingsFrom(this.currentElement);
			this.m_TextInfo.Clear();
			TextGenerationSettings textGenerationSettings = new TextGenerationSettings
			{
				text = text,
				screenRect = Rect.zero,
				fontAsset = font,
				textSettings = textSettingsFrom,
				fontSize = fontSize,
				color = color,
				material = font.material,
				inverseYAxis = true
			};
			TextGenerator.GenerateText(textGenerationSettings, this.m_TextInfo);
			this.DrawTextInfo(this.m_TextInfo, pos, false);
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x00013A86 File Offset: 0x00011C86
		public void DrawVectorImage(VectorImage vectorImage, Vector2 offset, Angle rotationAngle, Vector2 scale)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x000CA6E4 File Offset: 0x000C88E4
		public void RegisterVectorImageGradient(VectorImage vi, out int settingIndexOffset, out TextureId texture)
		{
			texture = default(TextureId);
			GradientRemap gradientRemap = this.m_VectorImageManager.AddUser(vi, this.currentElement);
			settingIndexOffset = gradientRemap.destIndex;
			bool flag = gradientRemap.atlas != TextureId.invalid;
			if (flag)
			{
				texture = gradientRemap.atlas;
			}
			else
			{
				texture = TextureRegistry.instance.Acquire(vi.atlas);
				this.m_Owner.InsertTexture(this.currentElement, vi.atlas, texture, false);
			}
		}

		// Token: 0x04002205 RID: 8709
		private static readonly IntPtr NativeFieldInfoPtr_m_Owner;

		// Token: 0x04002206 RID: 8710
		private static readonly IntPtr NativeFieldInfoPtr_m_Entries;

		// Token: 0x04002207 RID: 8711
		private static readonly IntPtr NativeFieldInfoPtr_m_Atlas;

		// Token: 0x04002208 RID: 8712
		private static readonly IntPtr NativeFieldInfoPtr_m_VectorImageManager;

		// Token: 0x04002209 RID: 8713
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentEntry;

		// Token: 0x0400220A RID: 8714
		private static readonly IntPtr NativeFieldInfoPtr_m_ClosingInfo;

		// Token: 0x0400220B RID: 8715
		private static readonly IntPtr NativeFieldInfoPtr_m_MaskDepth;

		// Token: 0x0400220C RID: 8716
		private static readonly IntPtr NativeFieldInfoPtr_m_StencilRef;

		// Token: 0x0400220D RID: 8717
		private static readonly IntPtr NativeFieldInfoPtr_m_ClipRectID;

		// Token: 0x0400220E RID: 8718
		private static readonly IntPtr NativeFieldInfoPtr_m_SVGBackgroundEntryIndex;

		// Token: 0x0400220F RID: 8719
		private static readonly IntPtr NativeFieldInfoPtr_m_VertsPool;

		// Token: 0x04002210 RID: 8720
		private static readonly IntPtr NativeFieldInfoPtr_m_IndicesPool;

		// Token: 0x04002211 RID: 8721
		private static readonly IntPtr NativeFieldInfoPtr_m_MeshWriteDataPool;

		// Token: 0x04002212 RID: 8722
		private static readonly IntPtr NativeFieldInfoPtr_m_NextMeshWriteDataPoolItem;

		// Token: 0x04002213 RID: 8723
		private static readonly IntPtr NativeFieldInfoPtr_m_RepeatRectUVList;

		// Token: 0x04002214 RID: 8724
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocRawVertsIndicesDelegate;

		// Token: 0x04002215 RID: 8725
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocThroughDrawMeshDelegate;

		// Token: 0x04002216 RID: 8726
		private static readonly IntPtr NativeFieldInfoPtr__meshGenerationContext_k__BackingField;

		// Token: 0x04002217 RID: 8727
		private static readonly IntPtr NativeFieldInfoPtr__currentElement_k__BackingField;

		// Token: 0x04002218 RID: 8728
		private static readonly IntPtr NativeFieldInfoPtr__totalVertices_k__BackingField;

		// Token: 0x04002219 RID: 8729
		private static readonly IntPtr NativeFieldInfoPtr__totalIndices_k__BackingField;

		// Token: 0x0400221A RID: 8730
		private static readonly IntPtr NativeFieldInfoPtr_m_TextInfo;

		// Token: 0x0400221B RID: 8731
		private static readonly IntPtr NativeMethodInfoPtr_GetPooledMeshWriteData_Private_MeshWriteData_0;

		// Token: 0x0400221C RID: 8732
		private static readonly IntPtr NativeMethodInfoPtr_AllocRawVertsIndices_Private_MeshWriteData_UInt32_UInt32_byref_AllocMeshData_0;

		// Token: 0x0400221D RID: 8733
		private static readonly IntPtr NativeMethodInfoPtr_AllocThroughDrawMesh_Private_MeshWriteData_UInt32_UInt32_byref_AllocMeshData_0;

		// Token: 0x0400221E RID: 8734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderChain_0;

		// Token: 0x0400221F RID: 8735
		private static readonly IntPtr NativeMethodInfoPtr_get_meshGenerationContext_Public_get_MeshGenerationContext_0;

		// Token: 0x04002220 RID: 8736
		private static readonly IntPtr NativeMethodInfoPtr_get_currentElement_Public_get_VisualElement_0;

		// Token: 0x04002221 RID: 8737
		private static readonly IntPtr NativeMethodInfoPtr_set_currentElement_Private_set_Void_VisualElement_0;

		// Token: 0x04002222 RID: 8738
		private static readonly IntPtr NativeMethodInfoPtr_get_entries_Public_get_List_1_Entry_0;

		// Token: 0x04002223 RID: 8739
		private static readonly IntPtr NativeMethodInfoPtr_get_closingInfo_Public_get_ClosingInfo_0;

		// Token: 0x04002224 RID: 8740
		private static readonly IntPtr NativeMethodInfoPtr_get_totalVertices_Public_get_Int32_0;

		// Token: 0x04002225 RID: 8741
		private static readonly IntPtr NativeMethodInfoPtr_set_totalVertices_Private_set_Void_Int32_0;

		// Token: 0x04002226 RID: 8742
		private static readonly IntPtr NativeMethodInfoPtr_get_totalIndices_Public_get_Int32_0;

		// Token: 0x04002227 RID: 8743
		private static readonly IntPtr NativeMethodInfoPtr_set_totalIndices_Private_set_Void_Int32_0;

		// Token: 0x04002228 RID: 8744
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_VisualElement_0;

		// Token: 0x04002229 RID: 8745
		private static readonly IntPtr NativeMethodInfoPtr_LandClipUnregisterMeshDrawCommand_Public_Void_RenderChainCommand_0;

		// Token: 0x0400222A RID: 8746
		private static readonly IntPtr NativeMethodInfoPtr_LandClipRegisterMesh_Public_Void_NativeSlice_1_Vertex_NativeSlice_1_UInt16_Int32_0;

		// Token: 0x0400222B RID: 8747
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Virtual_Final_New_MeshWriteData_Int32_Int32_Texture_Material_MeshFlags_0;

		// Token: 0x0400222C RID: 8748
		private static readonly IntPtr NativeMethodInfoPtr_TryAtlasTexture_Internal_Void_Texture_MeshFlags_byref_Rect_byref_Boolean_byref_TextureId_byref_VertexFlags_0;

		// Token: 0x0400222D RID: 8749
		private static readonly IntPtr NativeMethodInfoPtr_BuildEntryFromNativeMesh_Internal_Void_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags_0;

		// Token: 0x0400222E RID: 8750
		private static readonly IntPtr NativeMethodInfoPtr_BuildGradientEntryFromNativeMesh_Internal_Void_MeshWriteDataInterface_TextureId_0;

		// Token: 0x0400222F RID: 8751
		private static readonly IntPtr NativeMethodInfoPtr_BuildRawEntryFromNativeMesh_Public_Void_MeshWriteDataInterface_0;

		// Token: 0x04002230 RID: 8752
		private static readonly IntPtr NativeMethodInfoPtr_DrawText_Public_Virtual_Final_New_Void_TextElement_0;

		// Token: 0x04002231 RID: 8753
		private static readonly IntPtr NativeMethodInfoPtr_DrawTextInfo_Private_Void_TextInfo_Vector2_Boolean_0;

		// Token: 0x04002232 RID: 8754
		private static readonly IntPtr NativeMethodInfoPtr_DrawRectangle_Public_Virtual_Final_New_Void_RectangleParams_0;

		// Token: 0x04002233 RID: 8755
		private static readonly IntPtr NativeMethodInfoPtr_DrawBorder_Public_Virtual_Final_New_Void_BorderParams_0;

		// Token: 0x04002234 RID: 8756
		private static readonly IntPtr NativeMethodInfoPtr_DrawImmediate_Public_Virtual_Final_New_Void_Action_Boolean_0;

		// Token: 0x04002235 RID: 8757
		private static readonly IntPtr NativeMethodInfoPtr_get_visualElement_Public_Virtual_Final_New_get_VisualElement_0;

		// Token: 0x04002236 RID: 8758
		private static readonly IntPtr NativeMethodInfoPtr_DrawVisualElementBackground_Public_Void_0;

		// Token: 0x04002237 RID: 8759
		private static readonly IntPtr NativeMethodInfoPtr_DrawRectangleRepeat_Private_Void_RectangleParams_Rect_Single_0;

		// Token: 0x04002238 RID: 8760
		private static readonly IntPtr NativeMethodInfoPtr_StampRectangleWithSubRect_Private_Void_RectangleParams_Rect_Rect_Rect_0;

		// Token: 0x04002239 RID: 8761
		private static readonly IntPtr NativeMethodInfoPtr_DrawVisualElementBorder_Public_Void_0;

		// Token: 0x0400223A RID: 8762
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVisualElementClipping_Public_Void_0;

		// Token: 0x0400223B RID: 8763
		private static readonly IntPtr NativeMethodInfoPtr_AdjustSpriteWinding_Private_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_UInt16_0;

		// Token: 0x0400223C RID: 8764
		private static readonly IntPtr NativeMethodInfoPtr_DrawSprite_Public_Void_RectangleParams_0;

		// Token: 0x0400223D RID: 8765
		private static readonly IntPtr NativeMethodInfoPtr_DrawVectorImage_Public_Void_RectangleParams_0;

		// Token: 0x0400223E RID: 8766
		private static readonly IntPtr NativeMethodInfoPtr_MakeVectorGraphics_Private_Void_RectangleParams_Boolean_TextureId_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x0400223F RID: 8767
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x04002240 RID: 8768
		private static readonly IntPtr NativeMethodInfoPtr_ValidateMeshWriteData_Private_Void_0;

		// Token: 0x04002241 RID: 8769
		private static readonly IntPtr NativeMethodInfoPtr_GenerateStencilClipEntryForRoundedRectBackground_Private_Void_0;

		// Token: 0x04002242 RID: 8770
		private static readonly IntPtr NativeMethodInfoPtr_GenerateStencilClipEntryForSVGBackground_Private_Void_0;

		// Token: 0x02000562 RID: 1378
		public sealed class Entry : ValueType
		{
			// Token: 0x06004207 RID: 16903 RVA: 0x00103BD0 File Offset: 0x00101DD0
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr);
				UIRStylePainter.Entry.NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, "vertices");
				UIRStylePainter.Entry.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, "indices");
				UIRStylePainter.Entry.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, "material");
				UIRStylePainter.Entry.NativeFieldInfoPtr_fontTexSDFScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, "fontTexSDFScale");
				UIRStylePainter.Entry.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, "texture");
				UIRStylePainter.Entry.NativeFieldInfoPtr_customCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, "customCommand");
				UIRStylePainter.Entry.NativeFieldInfoPtr_clipRectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, "clipRectID");
				UIRStylePainter.Entry.NativeFieldInfoPtr_addFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, "addFlags");
				UIRStylePainter.Entry.NativeFieldInfoPtr_uvIsDisplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, "uvIsDisplacement");
				UIRStylePainter.Entry.NativeFieldInfoPtr_isTextEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, "isTextEntry");
				UIRStylePainter.Entry.NativeFieldInfoPtr_isClipRegisterEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, "isClipRegisterEntry");
				UIRStylePainter.Entry.NativeFieldInfoPtr_stencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, "stencilRef");
				UIRStylePainter.Entry.NativeFieldInfoPtr_maskDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr, "maskDepth");
			}

			// Token: 0x06004208 RID: 16904 RVA: 0x0001C1A0 File Offset: 0x0001A3A0
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004209 RID: 16905 RVA: 0x0001C1A9 File Offset: 0x0001A3A9
			public Entry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRStylePainter.Entry>.NativeClassPtr))
			{
			}

			// Token: 0x170013CA RID: 5066
			// (get) Token: 0x0600420A RID: 16906 RVA: 0x00103D00 File Offset: 0x00101F00
			// (set) Token: 0x0600420B RID: 16907 RVA: 0x0001C1BB File Offset: 0x0001A3BB
			public NativeSlice<Vertex> vertices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_vertices);
					return new NativeSlice<Vertex>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeSlice<Vertex>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_vertices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<Vertex>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170013CB RID: 5067
			// (get) Token: 0x0600420C RID: 16908 RVA: 0x00103D30 File Offset: 0x00101F30
			// (set) Token: 0x0600420D RID: 16909 RVA: 0x0001C1E9 File Offset: 0x0001A3E9
			public NativeSlice<ushort> indices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_indices);
					return new NativeSlice<ushort>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeSlice<ushort>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_indices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<ushort>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170013CC RID: 5068
			// (get) Token: 0x0600420E RID: 16910 RVA: 0x00103D60 File Offset: 0x00101F60
			// (set) Token: 0x0600420F RID: 16911 RVA: 0x0001C217 File Offset: 0x0001A417
			public unsafe Material material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013CD RID: 5069
			// (get) Token: 0x06004210 RID: 16912 RVA: 0x00103D90 File Offset: 0x00101F90
			// (set) Token: 0x06004211 RID: 16913 RVA: 0x0001C236 File Offset: 0x0001A436
			public unsafe float fontTexSDFScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_fontTexSDFScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_fontTexSDFScale)) = value;
				}
			}

			// Token: 0x170013CE RID: 5070
			// (get) Token: 0x06004212 RID: 16914 RVA: 0x00103DB8 File Offset: 0x00101FB8
			// (set) Token: 0x06004213 RID: 16915 RVA: 0x0001C251 File Offset: 0x0001A451
			public unsafe TextureId texture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_texture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_texture)) = value;
				}
			}

			// Token: 0x170013CF RID: 5071
			// (get) Token: 0x06004214 RID: 16916 RVA: 0x00103DE0 File Offset: 0x00101FE0
			// (set) Token: 0x06004215 RID: 16917 RVA: 0x0001C26C File Offset: 0x0001A46C
			public unsafe RenderChainCommand customCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_customCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_customCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013D0 RID: 5072
			// (get) Token: 0x06004216 RID: 16918 RVA: 0x00103E10 File Offset: 0x00102010
			// (set) Token: 0x06004217 RID: 16919 RVA: 0x0001C28B File Offset: 0x0001A48B
			public unsafe BMPAlloc clipRectID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_clipRectID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_clipRectID)) = value;
				}
			}

			// Token: 0x170013D1 RID: 5073
			// (get) Token: 0x06004218 RID: 16920 RVA: 0x00103E38 File Offset: 0x00102038
			// (set) Token: 0x06004219 RID: 16921 RVA: 0x0001C2A6 File Offset: 0x0001A4A6
			public unsafe VertexFlags addFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_addFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_addFlags)) = value;
				}
			}

			// Token: 0x170013D2 RID: 5074
			// (get) Token: 0x0600421A RID: 16922 RVA: 0x00103E60 File Offset: 0x00102060
			// (set) Token: 0x0600421B RID: 16923 RVA: 0x0001C2C1 File Offset: 0x0001A4C1
			public unsafe bool uvIsDisplacement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_uvIsDisplacement);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_uvIsDisplacement)) = value;
				}
			}

			// Token: 0x170013D3 RID: 5075
			// (get) Token: 0x0600421C RID: 16924 RVA: 0x00103E88 File Offset: 0x00102088
			// (set) Token: 0x0600421D RID: 16925 RVA: 0x0001C2DC File Offset: 0x0001A4DC
			public unsafe bool isTextEntry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_isTextEntry);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_isTextEntry)) = value;
				}
			}

			// Token: 0x170013D4 RID: 5076
			// (get) Token: 0x0600421E RID: 16926 RVA: 0x00103EB0 File Offset: 0x001020B0
			// (set) Token: 0x0600421F RID: 16927 RVA: 0x0001C2F7 File Offset: 0x0001A4F7
			public unsafe bool isClipRegisterEntry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_isClipRegisterEntry);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_isClipRegisterEntry)) = value;
				}
			}

			// Token: 0x170013D5 RID: 5077
			// (get) Token: 0x06004220 RID: 16928 RVA: 0x00103ED8 File Offset: 0x001020D8
			// (set) Token: 0x06004221 RID: 16929 RVA: 0x0001C312 File Offset: 0x0001A512
			public unsafe int stencilRef
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_stencilRef);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_stencilRef)) = value;
				}
			}

			// Token: 0x170013D6 RID: 5078
			// (get) Token: 0x06004222 RID: 16930 RVA: 0x00103F00 File Offset: 0x00102100
			// (set) Token: 0x06004223 RID: 16931 RVA: 0x0001C32D File Offset: 0x0001A52D
			public unsafe int maskDepth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_maskDepth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.Entry.NativeFieldInfoPtr_maskDepth)) = value;
				}
			}

			// Token: 0x04002E4E RID: 11854
			private static readonly IntPtr NativeFieldInfoPtr_vertices;

			// Token: 0x04002E4F RID: 11855
			private static readonly IntPtr NativeFieldInfoPtr_indices;

			// Token: 0x04002E50 RID: 11856
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x04002E51 RID: 11857
			private static readonly IntPtr NativeFieldInfoPtr_fontTexSDFScale;

			// Token: 0x04002E52 RID: 11858
			private static readonly IntPtr NativeFieldInfoPtr_texture;

			// Token: 0x04002E53 RID: 11859
			private static readonly IntPtr NativeFieldInfoPtr_customCommand;

			// Token: 0x04002E54 RID: 11860
			private static readonly IntPtr NativeFieldInfoPtr_clipRectID;

			// Token: 0x04002E55 RID: 11861
			private static readonly IntPtr NativeFieldInfoPtr_addFlags;

			// Token: 0x04002E56 RID: 11862
			private static readonly IntPtr NativeFieldInfoPtr_uvIsDisplacement;

			// Token: 0x04002E57 RID: 11863
			private static readonly IntPtr NativeFieldInfoPtr_isTextEntry;

			// Token: 0x04002E58 RID: 11864
			private static readonly IntPtr NativeFieldInfoPtr_isClipRegisterEntry;

			// Token: 0x04002E59 RID: 11865
			private static readonly IntPtr NativeFieldInfoPtr_stencilRef;

			// Token: 0x04002E5A RID: 11866
			private static readonly IntPtr NativeFieldInfoPtr_maskDepth;
		}

		// Token: 0x02000563 RID: 1379
		public sealed class ClosingInfo : ValueType
		{
			// Token: 0x06004224 RID: 16932 RVA: 0x00103F28 File Offset: 0x00102128
			// Note: this type is marked as 'beforefieldinit'.
			static ClosingInfo()
			{
				Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "ClosingInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr);
				UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_needsClosing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr, "needsClosing");
				UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_popViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr, "popViewMatrix");
				UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_popScissorClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr, "popScissorClip");
				UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_blitAndPopRenderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr, "blitAndPopRenderTexture");
				UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_PopDefaultMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr, "PopDefaultMaterial");
				UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_clipUnregisterDrawCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr, "clipUnregisterDrawCommand");
				UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_clipperRegisterVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr, "clipperRegisterVertices");
				UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_clipperRegisterIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr, "clipperRegisterIndices");
				UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_clipperRegisterIndexOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr, "clipperRegisterIndexOffset");
				UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_maskStencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr, "maskStencilRef");
			}

			// Token: 0x06004225 RID: 16933 RVA: 0x0001C348 File Offset: 0x0001A548
			public ClosingInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004226 RID: 16934 RVA: 0x0001C351 File Offset: 0x0001A551
			public ClosingInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRStylePainter.ClosingInfo>.NativeClassPtr))
			{
			}

			// Token: 0x170013D7 RID: 5079
			// (get) Token: 0x06004227 RID: 16935 RVA: 0x0010401C File Offset: 0x0010221C
			// (set) Token: 0x06004228 RID: 16936 RVA: 0x0001C363 File Offset: 0x0001A563
			public unsafe bool needsClosing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_needsClosing);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_needsClosing)) = value;
				}
			}

			// Token: 0x170013D8 RID: 5080
			// (get) Token: 0x06004229 RID: 16937 RVA: 0x00104044 File Offset: 0x00102244
			// (set) Token: 0x0600422A RID: 16938 RVA: 0x0001C37E File Offset: 0x0001A57E
			public unsafe bool popViewMatrix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_popViewMatrix);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_popViewMatrix)) = value;
				}
			}

			// Token: 0x170013D9 RID: 5081
			// (get) Token: 0x0600422B RID: 16939 RVA: 0x0010406C File Offset: 0x0010226C
			// (set) Token: 0x0600422C RID: 16940 RVA: 0x0001C399 File Offset: 0x0001A599
			public unsafe bool popScissorClip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_popScissorClip);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_popScissorClip)) = value;
				}
			}

			// Token: 0x170013DA RID: 5082
			// (get) Token: 0x0600422D RID: 16941 RVA: 0x00104094 File Offset: 0x00102294
			// (set) Token: 0x0600422E RID: 16942 RVA: 0x0001C3B4 File Offset: 0x0001A5B4
			public unsafe bool blitAndPopRenderTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_blitAndPopRenderTexture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_blitAndPopRenderTexture)) = value;
				}
			}

			// Token: 0x170013DB RID: 5083
			// (get) Token: 0x0600422F RID: 16943 RVA: 0x001040BC File Offset: 0x001022BC
			// (set) Token: 0x06004230 RID: 16944 RVA: 0x0001C3CF File Offset: 0x0001A5CF
			public unsafe bool PopDefaultMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_PopDefaultMaterial);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_PopDefaultMaterial)) = value;
				}
			}

			// Token: 0x170013DC RID: 5084
			// (get) Token: 0x06004231 RID: 16945 RVA: 0x001040E4 File Offset: 0x001022E4
			// (set) Token: 0x06004232 RID: 16946 RVA: 0x0001C3EA File Offset: 0x0001A5EA
			public unsafe RenderChainCommand clipUnregisterDrawCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_clipUnregisterDrawCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_clipUnregisterDrawCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013DD RID: 5085
			// (get) Token: 0x06004233 RID: 16947 RVA: 0x00104114 File Offset: 0x00102314
			// (set) Token: 0x06004234 RID: 16948 RVA: 0x0001C409 File Offset: 0x0001A609
			public NativeSlice<Vertex> clipperRegisterVertices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_clipperRegisterVertices);
					return new NativeSlice<Vertex>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeSlice<Vertex>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_clipperRegisterVertices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<Vertex>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170013DE RID: 5086
			// (get) Token: 0x06004235 RID: 16949 RVA: 0x00104144 File Offset: 0x00102344
			// (set) Token: 0x06004236 RID: 16950 RVA: 0x0001C437 File Offset: 0x0001A637
			public NativeSlice<ushort> clipperRegisterIndices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_clipperRegisterIndices);
					return new NativeSlice<ushort>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeSlice<ushort>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_clipperRegisterIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<ushort>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170013DF RID: 5087
			// (get) Token: 0x06004237 RID: 16951 RVA: 0x00104174 File Offset: 0x00102374
			// (set) Token: 0x06004238 RID: 16952 RVA: 0x0001C465 File Offset: 0x0001A665
			public unsafe int clipperRegisterIndexOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_clipperRegisterIndexOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_clipperRegisterIndexOffset)) = value;
				}
			}

			// Token: 0x170013E0 RID: 5088
			// (get) Token: 0x06004239 RID: 16953 RVA: 0x0010419C File Offset: 0x0010239C
			// (set) Token: 0x0600423A RID: 16954 RVA: 0x0001C480 File Offset: 0x0001A680
			public unsafe int maskStencilRef
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_maskStencilRef);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRStylePainter.ClosingInfo.NativeFieldInfoPtr_maskStencilRef)) = value;
				}
			}

			// Token: 0x04002E5B RID: 11867
			private static readonly IntPtr NativeFieldInfoPtr_needsClosing;

			// Token: 0x04002E5C RID: 11868
			private static readonly IntPtr NativeFieldInfoPtr_popViewMatrix;

			// Token: 0x04002E5D RID: 11869
			private static readonly IntPtr NativeFieldInfoPtr_popScissorClip;

			// Token: 0x04002E5E RID: 11870
			private static readonly IntPtr NativeFieldInfoPtr_blitAndPopRenderTexture;

			// Token: 0x04002E5F RID: 11871
			private static readonly IntPtr NativeFieldInfoPtr_PopDefaultMaterial;

			// Token: 0x04002E60 RID: 11872
			private static readonly IntPtr NativeFieldInfoPtr_clipUnregisterDrawCommand;

			// Token: 0x04002E61 RID: 11873
			private static readonly IntPtr NativeFieldInfoPtr_clipperRegisterVertices;

			// Token: 0x04002E62 RID: 11874
			private static readonly IntPtr NativeFieldInfoPtr_clipperRegisterIndices;

			// Token: 0x04002E63 RID: 11875
			private static readonly IntPtr NativeFieldInfoPtr_clipperRegisterIndexOffset;

			// Token: 0x04002E64 RID: 11876
			private static readonly IntPtr NativeFieldInfoPtr_maskStencilRef;
		}

		// Token: 0x02000564 RID: 1380
		[StructLayout(2)]
		public struct RepeatRectUV
		{
			// Token: 0x0600423B RID: 16955 RVA: 0x001041C4 File Offset: 0x001023C4
			// Note: this type is marked as 'beforefieldinit'.
			static RepeatRectUV()
			{
				Il2CppClassPointerStore<UIRStylePainter.RepeatRectUV>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIRStylePainter>.NativeClassPtr, "RepeatRectUV");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRStylePainter.RepeatRectUV>.NativeClassPtr);
				UIRStylePainter.RepeatRectUV.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.RepeatRectUV>.NativeClassPtr, "rect");
				UIRStylePainter.RepeatRectUV.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRStylePainter.RepeatRectUV>.NativeClassPtr, "uv");
			}

			// Token: 0x0600423C RID: 16956 RVA: 0x0001C49B File Offset: 0x0001A69B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIRStylePainter.RepeatRectUV>.NativeClassPtr, ref this));
			}

			// Token: 0x04002E65 RID: 11877
			private static readonly IntPtr NativeFieldInfoPtr_rect;

			// Token: 0x04002E66 RID: 11878
			private static readonly IntPtr NativeFieldInfoPtr_uv;

			// Token: 0x04002E67 RID: 11879
			[FieldOffset(0)]
			public Rect rect;

			// Token: 0x04002E68 RID: 11880
			[FieldOffset(16)]
			public Rect uv;
		}
	}
}
