using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine.UIElements.UIR.Implementation;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000261 RID: 609
	public class RenderChain : Object
	{
		// Token: 0x06002CB3 RID: 11443 RVA: 0x000C083C File Offset: 0x000BEA3C
		// Note: this type is marked as 'beforefieldinit'.
		static RenderChain()
		{
			Il2CppClassPointerStore<RenderChain>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "RenderChain");
			RenderChain.NativeFieldInfoPtr_m_FirstCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_FirstCommand");
			RenderChain.NativeFieldInfoPtr_m_DirtyTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_DirtyTracker");
			RenderChain.NativeFieldInfoPtr_m_CommandPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_CommandPool");
			RenderChain.NativeFieldInfoPtr_m_TexturePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_TexturePool");
			RenderChain.NativeFieldInfoPtr_m_RenderNodesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_RenderNodesData");
			RenderChain.NativeFieldInfoPtr_m_DefaultShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_DefaultShader");
			RenderChain.NativeFieldInfoPtr_m_DefaultWorldSpaceShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_DefaultWorldSpaceShader");
			RenderChain.NativeFieldInfoPtr_m_DefaultMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_DefaultMat");
			RenderChain.NativeFieldInfoPtr_m_DefaultWorldSpaceMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_DefaultWorldSpaceMat");
			RenderChain.NativeFieldInfoPtr_m_BlockDirtyRegistration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_BlockDirtyRegistration");
			RenderChain.NativeFieldInfoPtr_m_StaticIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_StaticIndex");
			RenderChain.NativeFieldInfoPtr_m_ActiveRenderNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_ActiveRenderNodes");
			RenderChain.NativeFieldInfoPtr_m_CustomMaterialCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_CustomMaterialCommands");
			RenderChain.NativeFieldInfoPtr_m_Stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_Stats");
			RenderChain.NativeFieldInfoPtr_m_StatsElementsAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_StatsElementsAdded");
			RenderChain.NativeFieldInfoPtr_m_StatsElementsRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_StatsElementsRemoved");
			RenderChain.NativeFieldInfoPtr_m_TextureRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "m_TextureRegistry");
			RenderChain.NativeFieldInfoPtr__opacityIdAccelerator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "<opacityIdAccelerator>k__BackingField");
			RenderChain.NativeFieldInfoPtr_s_MarkerProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "s_MarkerProcess");
			RenderChain.NativeFieldInfoPtr_s_MarkerClipProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "s_MarkerClipProcessing");
			RenderChain.NativeFieldInfoPtr_s_MarkerOpacityProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "s_MarkerOpacityProcessing");
			RenderChain.NativeFieldInfoPtr_s_MarkerColorsProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "s_MarkerColorsProcessing");
			RenderChain.NativeFieldInfoPtr_s_MarkerTransformProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "s_MarkerTransformProcessing");
			RenderChain.NativeFieldInfoPtr_s_MarkerVisualsProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "s_MarkerVisualsProcessing");
			RenderChain.NativeFieldInfoPtr_s_MarkerTextRegen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "s_MarkerTextRegen");
			RenderChain.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "<disposed>k__BackingField");
			RenderChain.NativeFieldInfoPtr_OnPreRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "OnPreRender");
			RenderChain.NativeFieldInfoPtr__panel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "<panel>k__BackingField");
			RenderChain.NativeFieldInfoPtr__device_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "<device>k__BackingField");
			RenderChain.NativeFieldInfoPtr__atlas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "<atlas>k__BackingField");
			RenderChain.NativeFieldInfoPtr__vectorImageManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "<vectorImageManager>k__BackingField");
			RenderChain.NativeFieldInfoPtr__vertsPool_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "<vertsPool>k__BackingField");
			RenderChain.NativeFieldInfoPtr__indicesPool_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "<indicesPool>k__BackingField");
			RenderChain.NativeFieldInfoPtr__jobManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "<jobManager>k__BackingField");
			RenderChain.NativeFieldInfoPtr_shaderInfoAllocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "shaderInfoAllocator");
			RenderChain.NativeFieldInfoPtr__painter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "<painter>k__BackingField");
			RenderChain.NativeFieldInfoPtr__drawStats_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "<drawStats>k__BackingField");
			RenderChain.NativeFieldInfoPtr__drawInCameras_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "<drawInCameras>k__BackingField");
			RenderChain.NativeMethodInfoPtr_get_opacityIdAccelerator_Public_get_OpacityIdAccelerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669889);
			RenderChain.NativeMethodInfoPtr_set_opacityIdAccelerator_Private_set_Void_OpacityIdAccelerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669890);
			RenderChain.NativeMethodInfoPtr__ctor_Public_Void_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669892);
			RenderChain.NativeMethodInfoPtr_Constructor_Private_Void_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669893);
			RenderChain.NativeMethodInfoPtr_Destructor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669894);
			RenderChain.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669895);
			RenderChain.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669896);
			RenderChain.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669897);
			RenderChain.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669898);
			RenderChain.NativeMethodInfoPtr_ProcessChanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669899);
			RenderChain.NativeMethodInfoPtr_Render_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669900);
			RenderChain.NativeMethodInfoPtr_UIEOnChildAdded_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669901);
			RenderChain.NativeMethodInfoPtr_UIEOnChildrenReordered_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669902);
			RenderChain.NativeMethodInfoPtr_UIEOnChildRemoving_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669903);
			RenderChain.NativeMethodInfoPtr_UIEOnRenderHintsChanged_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669904);
			RenderChain.NativeMethodInfoPtr_UIEOnClippingChanged_Public_Void_VisualElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669905);
			RenderChain.NativeMethodInfoPtr_UIEOnOpacityChanged_Public_Void_VisualElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669906);
			RenderChain.NativeMethodInfoPtr_UIEOnColorChanged_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669907);
			RenderChain.NativeMethodInfoPtr_UIEOnTransformOrSizeChanged_Public_Void_VisualElement_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669908);
			RenderChain.NativeMethodInfoPtr_UIEOnVisualsChanged_Public_Void_VisualElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669909);
			RenderChain.NativeMethodInfoPtr_UIEOnOpacityIdChanged_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669910);
			RenderChain.NativeMethodInfoPtr_get_panel_Internal_get_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669911);
			RenderChain.NativeMethodInfoPtr_set_panel_Private_set_Void_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669912);
			RenderChain.NativeMethodInfoPtr_get_device_Internal_get_UIRenderDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669913);
			RenderChain.NativeMethodInfoPtr_set_device_Private_set_Void_UIRenderDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669914);
			RenderChain.NativeMethodInfoPtr_get_atlas_Internal_get_AtlasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669915);
			RenderChain.NativeMethodInfoPtr_set_atlas_Private_set_Void_AtlasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669916);
			RenderChain.NativeMethodInfoPtr_get_vectorImageManager_Internal_get_VectorImageManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669917);
			RenderChain.NativeMethodInfoPtr_set_vectorImageManager_Private_set_Void_VectorImageManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669918);
			RenderChain.NativeMethodInfoPtr_get_vertsPool_Internal_get_TempAllocator_1_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669919);
			RenderChain.NativeMethodInfoPtr_set_vertsPool_Private_set_Void_TempAllocator_1_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669920);
			RenderChain.NativeMethodInfoPtr_get_indicesPool_Internal_get_TempAllocator_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669921);
			RenderChain.NativeMethodInfoPtr_set_indicesPool_Private_set_Void_TempAllocator_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669922);
			RenderChain.NativeMethodInfoPtr_get_jobManager_Internal_get_JobManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669923);
			RenderChain.NativeMethodInfoPtr_set_jobManager_Private_set_Void_JobManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669924);
			RenderChain.NativeMethodInfoPtr_get_painter_Internal_get_UIRStylePainter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669925);
			RenderChain.NativeMethodInfoPtr_set_painter_Private_set_Void_UIRStylePainter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669926);
			RenderChain.NativeMethodInfoPtr_get_drawStats_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669927);
			RenderChain.NativeMethodInfoPtr_set_drawStats_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669928);
			RenderChain.NativeMethodInfoPtr_get_drawInCameras_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669929);
			RenderChain.NativeMethodInfoPtr_set_drawInCameras_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669930);
			RenderChain.NativeMethodInfoPtr_set_defaultShader_Internal_set_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669931);
			RenderChain.NativeMethodInfoPtr_set_defaultWorldSpaceShader_Internal_set_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669932);
			RenderChain.NativeMethodInfoPtr_GetStandardMaterial_Internal_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669933);
			RenderChain.NativeMethodInfoPtr_GetStandardWorldSpaceMaterial_Internal_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669934);
			RenderChain.NativeMethodInfoPtr_EnsureFitsDepth_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669935);
			RenderChain.NativeMethodInfoPtr_ChildWillBeRemoved_Internal_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669936);
			RenderChain.NativeMethodInfoPtr_AllocCommand_Internal_RenderChainCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669937);
			RenderChain.NativeMethodInfoPtr_FreeCommand_Internal_Void_RenderChainCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669938);
			RenderChain.NativeMethodInfoPtr_OnRenderCommandAdded_Internal_Void_RenderChainCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669939);
			RenderChain.NativeMethodInfoPtr_OnRenderCommandsRemoved_Internal_Void_RenderChainCommand_RenderChainCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669940);
			RenderChain.NativeMethodInfoPtr_AccessRenderNodeData_Private_Static_RenderNodeData_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669941);
			RenderChain.NativeMethodInfoPtr_OnRenderNodeExecute_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669942);
			RenderChain.NativeMethodInfoPtr_OnRegisterIntermediateRenderers_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669943);
			RenderChain.NativeMethodInfoPtr_OnRegisterIntermediateRendererMat_Private_Static_Void_BaseRuntimePanel_RenderChain_byref_RenderNodeData_Camera_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669944);
			RenderChain.NativeMethodInfoPtr_RepaintTexturedElements_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669945);
			RenderChain.NativeMethodInfoPtr_InsertTexture_Public_Void_VisualElement_Texture_TextureId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669946);
			RenderChain.NativeMethodInfoPtr_ResetTextures_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669947);
			RenderChain.NativeMethodInfoPtr_DrawStats_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669948);
			RenderChain.NativeMethodInfoPtr_GetFirstElementInPanel_Private_Static_VisualElement_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, 100669949);
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x000C100C File Offset: 0x000BF20C
		// (set) Token: 0x06002CB5 RID: 11445 RVA: 0x000C104C File Offset: 0x000BF24C
		public unsafe OpacityIdAccelerator opacityIdAccelerator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_get_opacityIdAccelerator_Public_get_OpacityIdAccelerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OpacityIdAccelerator>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_set_opacityIdAccelerator_Private_set_Void_OpacityIdAccelerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x000C1090 File Offset: 0x000BF290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350717, RefRangeEnd = 350718, XrefRangeStart = 350649, XrefRangeEnd = 350717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderChain(BaseVisualElementPanel panel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderChain>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr__ctor_Public_Void_BaseVisualElementPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x000C10DC File Offset: 0x000BF2DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350829, RefRangeEnd = 350830, XrefRangeStart = 350718, XrefRangeEnd = 350829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Constructor(BaseVisualElementPanel panelObj, UIRenderDevice deviceObj, AtlasBase atlas, VectorImageManager vectorImageMan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panelObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deviceObj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(atlas);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vectorImageMan);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_Constructor_Private_Void_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x000C1158 File Offset: 0x000BF358
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 350904, RefRangeEnd = 350906, XrefRangeStart = 350830, XrefRangeEnd = 350904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destructor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_Destructor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x000C118C File Offset: 0x000BF38C
		// (set) Token: 0x06002CBA RID: 11450 RVA: 0x000C11C8 File Offset: 0x000BF3C8
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x000C1208 File Offset: 0x000BF408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350911, RefRangeEnd = 350912, XrefRangeStart = 350906, XrefRangeEnd = 350911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x000C123C File Offset: 0x000BF43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350912, XrefRangeEnd = 350913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x000C127C File Offset: 0x000BF47C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350979, RefRangeEnd = 350980, XrefRangeStart = 350913, XrefRangeEnd = 350979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_ProcessChanges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x000C12B0 File Offset: 0x000BF4B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351020, RefRangeEnd = 351021, XrefRangeStart = 350980, XrefRangeEnd = 351020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_Render_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x000C12E4 File Offset: 0x000BF4E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351037, RefRangeEnd = 351039, XrefRangeStart = 351021, XrefRangeEnd = 351037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UIEOnChildAdded(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_UIEOnChildAdded_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x000C1328 File Offset: 0x000BF528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351052, RefRangeEnd = 351053, XrefRangeStart = 351039, XrefRangeEnd = 351052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UIEOnChildrenReordered(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_UIEOnChildrenReordered_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x000C136C File Offset: 0x000BF56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351053, XrefRangeEnd = 351068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UIEOnChildRemoving(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_UIEOnChildRemoving_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x000C13B0 File Offset: 0x000BF5B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351081, RefRangeEnd = 351082, XrefRangeStart = 351068, XrefRangeEnd = 351081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UIEOnRenderHintsChanged(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_UIEOnRenderHintsChanged_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x000C13F4 File Offset: 0x000BF5F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351083, RefRangeEnd = 351084, XrefRangeStart = 351082, XrefRangeEnd = 351083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UIEOnClippingChanged(VisualElement ve, bool hierarchical)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hierarchical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_UIEOnClippingChanged_Public_Void_VisualElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x000C1444 File Offset: 0x000BF644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351085, RefRangeEnd = 351086, XrefRangeStart = 351084, XrefRangeEnd = 351085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hierarchical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_UIEOnOpacityChanged_Public_Void_VisualElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x000C1494 File Offset: 0x000BF694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351087, RefRangeEnd = 351088, XrefRangeStart = 351086, XrefRangeEnd = 351087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UIEOnColorChanged(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_UIEOnColorChanged_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x000C14D8 File Offset: 0x000BF6D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351089, RefRangeEnd = 351091, XrefRangeStart = 351088, XrefRangeEnd = 351089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transformChanged;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipRectSizeChanged;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_UIEOnTransformOrSizeChanged_Public_Void_VisualElement_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x000C1538 File Offset: 0x000BF738
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 351092, RefRangeEnd = 351100, XrefRangeStart = 351091, XrefRangeEnd = 351092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UIEOnVisualsChanged(VisualElement ve, bool hierarchical)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hierarchical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_UIEOnVisualsChanged_Public_Void_VisualElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x000C1588 File Offset: 0x000BF788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351101, RefRangeEnd = 351102, XrefRangeStart = 351100, XrefRangeEnd = 351101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UIEOnOpacityIdChanged(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_UIEOnOpacityIdChanged_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x000C15CC File Offset: 0x000BF7CC
		// (set) Token: 0x06002CCA RID: 11466 RVA: 0x000C160C File Offset: 0x000BF80C
		public unsafe BaseVisualElementPanel panel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_get_panel_Internal_get_BaseVisualElementPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseVisualElementPanel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351102, XrefRangeEnd = 351112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_set_panel_Private_set_Void_BaseVisualElementPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x000C1650 File Offset: 0x000BF850
		// (set) Token: 0x06002CCC RID: 11468 RVA: 0x000C1690 File Offset: 0x000BF890
		public unsafe UIRenderDevice device
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_get_device_Internal_get_UIRenderDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIRenderDevice>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_set_device_Private_set_Void_UIRenderDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06002CCD RID: 11469 RVA: 0x000C16D4 File Offset: 0x000BF8D4
		// (set) Token: 0x06002CCE RID: 11470 RVA: 0x000C1714 File Offset: 0x000BF914
		public unsafe AtlasBase atlas
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_get_atlas_Internal_get_AtlasBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AtlasBase>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351112, XrefRangeEnd = 351113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_set_atlas_Private_set_Void_AtlasBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06002CCF RID: 11471 RVA: 0x000C1758 File Offset: 0x000BF958
		// (set) Token: 0x06002CD0 RID: 11472 RVA: 0x000C1798 File Offset: 0x000BF998
		public unsafe VectorImageManager vectorImageManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_get_vectorImageManager_Internal_get_VectorImageManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VectorImageManager>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351113, XrefRangeEnd = 351114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_set_vectorImageManager_Private_set_Void_VectorImageManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x000C17DC File Offset: 0x000BF9DC
		// (set) Token: 0x06002CD2 RID: 11474 RVA: 0x000C181C File Offset: 0x000BFA1C
		public unsafe TempAllocator<Vertex> vertsPool
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_get_vertsPool_Internal_get_TempAllocator_1_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TempAllocator<Vertex>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351114, XrefRangeEnd = 351115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_set_vertsPool_Private_set_Void_TempAllocator_1_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x000C1860 File Offset: 0x000BFA60
		// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x000C18A0 File Offset: 0x000BFAA0
		public unsafe TempAllocator<ushort> indicesPool
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_get_indicesPool_Internal_get_TempAllocator_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TempAllocator<ushort>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_set_indicesPool_Private_set_Void_TempAllocator_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x000C18E4 File Offset: 0x000BFAE4
		// (set) Token: 0x06002CD6 RID: 11478 RVA: 0x000C1924 File Offset: 0x000BFB24
		public unsafe JobManager jobManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_get_jobManager_Internal_get_JobManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JobManager>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351115, XrefRangeEnd = 351116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_set_jobManager_Private_set_Void_JobManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06002CD7 RID: 11479 RVA: 0x000C1968 File Offset: 0x000BFB68
		// (set) Token: 0x06002CD8 RID: 11480 RVA: 0x000C19A8 File Offset: 0x000BFBA8
		public unsafe UnityEngine.UIElements.UIR.Implementation.UIRStylePainter painter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_get_painter_Internal_get_UIRStylePainter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351116, XrefRangeEnd = 351117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_set_painter_Private_set_Void_UIRStylePainter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x000C19EC File Offset: 0x000BFBEC
		// (set) Token: 0x06002CDA RID: 11482 RVA: 0x000C1A28 File Offset: 0x000BFC28
		public unsafe bool drawStats
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_get_drawStats_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_set_drawStats_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x000C1A68 File Offset: 0x000BFC68
		// (set) Token: 0x06002CDC RID: 11484 RVA: 0x000C1AA4 File Offset: 0x000BFCA4
		public unsafe bool drawInCameras
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_get_drawInCameras_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_set_drawInCameras_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x000C2678 File Offset: 0x000C0878
		// (set) Token: 0x06002CDD RID: 11485 RVA: 0x000C1AE4 File Offset: 0x000BFCE4
		public unsafe Shader defaultShader
		{
			get
			{
				return this.m_DefaultShader;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 351127, RefRangeEnd = 351129, XrefRangeStart = 351117, XrefRangeEnd = 351127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_set_defaultShader_Internal_set_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x000C2690 File Offset: 0x000C0890
		// (set) Token: 0x06002CDE RID: 11486 RVA: 0x000C1B28 File Offset: 0x000BFD28
		public unsafe Shader defaultWorldSpaceShader
		{
			get
			{
				return this.m_DefaultWorldSpaceShader;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 351139, RefRangeEnd = 351141, XrefRangeStart = 351129, XrefRangeEnd = 351139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_set_defaultWorldSpaceShader_Internal_set_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x000C1B6C File Offset: 0x000BFD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351141, XrefRangeEnd = 351155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetStandardMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_GetStandardMaterial_Internal_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x000C1BAC File Offset: 0x000BFDAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351169, RefRangeEnd = 351170, XrefRangeStart = 351155, XrefRangeEnd = 351169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetStandardWorldSpaceMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_GetStandardWorldSpaceMaterial_Internal_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x000C1BEC File Offset: 0x000BFDEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351171, RefRangeEnd = 351172, XrefRangeStart = 351170, XrefRangeEnd = 351171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureFitsDepth(int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_EnsureFitsDepth_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x000C1C2C File Offset: 0x000BFE2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351180, RefRangeEnd = 351181, XrefRangeStart = 351172, XrefRangeEnd = 351180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChildWillBeRemoved(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_ChildWillBeRemoved_Internal_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x000C1C70 File Offset: 0x000BFE70
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 351185, RefRangeEnd = 351198, XrefRangeStart = 351181, XrefRangeEnd = 351185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderChainCommand AllocCommand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_AllocCommand_Internal_RenderChainCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr3) : null;
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x000C1CB0 File Offset: 0x000BFEB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 351207, RefRangeEnd = 351211, XrefRangeStart = 351198, XrefRangeEnd = 351207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeCommand(RenderChainCommand cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_FreeCommand_Internal_Void_RenderChainCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x000C1CF4 File Offset: 0x000BFEF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 351216, RefRangeEnd = 351219, XrefRangeStart = 351211, XrefRangeEnd = 351216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRenderCommandAdded(RenderChainCommand command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_OnRenderCommandAdded_Internal_Void_RenderChainCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x000C1D38 File Offset: 0x000BFF38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351220, RefRangeEnd = 351222, XrefRangeStart = 351219, XrefRangeEnd = 351220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstCommand);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastCommand);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_OnRenderCommandsRemoved_Internal_Void_RenderChainCommand_RenderChainCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x000C1D8C File Offset: 0x000BFF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351222, XrefRangeEnd = 351229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderChain.RenderNodeData AccessRenderNodeData(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_AccessRenderNodeData_Private_Static_RenderNodeData_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RenderChain.RenderNodeData(intPtr);
			}
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x000C1DC4 File Offset: 0x000BFFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351229, XrefRangeEnd = 351240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnRenderNodeExecute(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_OnRenderNodeExecute_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x000C1DF8 File Offset: 0x000BFFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351240, XrefRangeEnd = 351297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnRegisterIntermediateRenderers(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_OnRegisterIntermediateRenderers_Private_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x000C1E30 File Offset: 0x000C0030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351325, RefRangeEnd = 351327, XrefRangeStart = 351297, XrefRangeEnd = 351325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnRegisterIntermediateRendererMat(BaseRuntimePanel rtp, RenderChain renderChain, ref RenderChain.RenderNodeData rnd, Camera camera, int sameDistanceSortPriority)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rtp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(rnd);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sameDistanceSortPriority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_OnRegisterIntermediateRendererMat_Private_Static_Void_BaseRuntimePanel_RenderChain_byref_RenderNodeData_Camera_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x000C1EAC File Offset: 0x000C00AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351334, RefRangeEnd = 351336, XrefRangeStart = 351327, XrefRangeEnd = 351334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepaintTexturedElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_RepaintTexturedElements_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x000C1EE0 File Offset: 0x000C00E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 351344, RefRangeEnd = 351349, XrefRangeStart = 351336, XrefRangeEnd = 351344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAtlas;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_InsertTexture_Public_Void_VisualElement_Texture_TextureId_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x000C1F50 File Offset: 0x000C0150
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 351358, RefRangeEnd = 351361, XrefRangeStart = 351349, XrefRangeEnd = 351358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTextures(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_ResetTextures_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x000C1F94 File Offset: 0x000C0194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351514, RefRangeEnd = 351515, XrefRangeStart = 351361, XrefRangeEnd = 351514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawStats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_DrawStats_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x000C1FC8 File Offset: 0x000C01C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351515, XrefRangeEnd = 351517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisualElement GetFirstElementInPanel(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.NativeMethodInfoPtr_GetFirstElementInPanel_Private_Static_VisualElement_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x000122A0 File Offset: 0x000104A0
		public RenderChain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x000C200C File Offset: 0x000C020C
		// (set) Token: 0x06002CF2 RID: 11506 RVA: 0x000122A9 File Offset: 0x000104A9
		public unsafe RenderChainCommand m_FirstCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_FirstCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_FirstCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x000C203C File Offset: 0x000C023C
		// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x000122C8 File Offset: 0x000104C8
		public RenderChain.DepthOrderedDirtyTracking m_DirtyTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_DirtyTracker);
				return new RenderChain.DepthOrderedDirtyTracking(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderChain.DepthOrderedDirtyTracking>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_DirtyTracker), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderChain.DepthOrderedDirtyTracking>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x000C206C File Offset: 0x000C026C
		// (set) Token: 0x06002CF6 RID: 11510 RVA: 0x000122F6 File Offset: 0x000104F6
		public unsafe LinkedPool<RenderChainCommand> m_CommandPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_CommandPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedPool<RenderChainCommand>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_CommandPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x000C209C File Offset: 0x000C029C
		// (set) Token: 0x06002CF8 RID: 11512 RVA: 0x00012315 File Offset: 0x00010515
		public unsafe BasicNodePool<TextureEntry> m_TexturePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_TexturePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicNodePool<TextureEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_TexturePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x000C20CC File Offset: 0x000C02CC
		// (set) Token: 0x06002CFA RID: 11514 RVA: 0x00012334 File Offset: 0x00010534
		public unsafe List<RenderChain.RenderNodeData> m_RenderNodesData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_RenderNodesData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RenderChain.RenderNodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_RenderNodesData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x000C20FC File Offset: 0x000C02FC
		// (set) Token: 0x06002CFC RID: 11516 RVA: 0x00012353 File Offset: 0x00010553
		public unsafe Shader m_DefaultShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_DefaultShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_DefaultShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x000C212C File Offset: 0x000C032C
		// (set) Token: 0x06002CFE RID: 11518 RVA: 0x00012372 File Offset: 0x00010572
		public unsafe Shader m_DefaultWorldSpaceShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_DefaultWorldSpaceShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_DefaultWorldSpaceShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x000C215C File Offset: 0x000C035C
		// (set) Token: 0x06002D00 RID: 11520 RVA: 0x00012391 File Offset: 0x00010591
		public unsafe Material m_DefaultMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_DefaultMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_DefaultMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x000C218C File Offset: 0x000C038C
		// (set) Token: 0x06002D02 RID: 11522 RVA: 0x000123B0 File Offset: 0x000105B0
		public unsafe Material m_DefaultWorldSpaceMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_DefaultWorldSpaceMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_DefaultWorldSpaceMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06002D03 RID: 11523 RVA: 0x000C21BC File Offset: 0x000C03BC
		// (set) Token: 0x06002D04 RID: 11524 RVA: 0x000123CF File Offset: 0x000105CF
		public unsafe bool m_BlockDirtyRegistration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_BlockDirtyRegistration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_BlockDirtyRegistration)) = value;
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06002D05 RID: 11525 RVA: 0x000C21E4 File Offset: 0x000C03E4
		// (set) Token: 0x06002D06 RID: 11526 RVA: 0x000123EA File Offset: 0x000105EA
		public unsafe int m_StaticIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_StaticIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_StaticIndex)) = value;
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06002D07 RID: 11527 RVA: 0x000C220C File Offset: 0x000C040C
		// (set) Token: 0x06002D08 RID: 11528 RVA: 0x00012405 File Offset: 0x00010605
		public unsafe int m_ActiveRenderNodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_ActiveRenderNodes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_ActiveRenderNodes)) = value;
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x000C2234 File Offset: 0x000C0434
		// (set) Token: 0x06002D0A RID: 11530 RVA: 0x00012420 File Offset: 0x00010620
		public unsafe int m_CustomMaterialCommands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_CustomMaterialCommands);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_CustomMaterialCommands)) = value;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x000C225C File Offset: 0x000C045C
		// (set) Token: 0x06002D0C RID: 11532 RVA: 0x0001243B File Offset: 0x0001063B
		public unsafe ChainBuilderStats m_Stats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_Stats);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_Stats)) = value;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x000C2284 File Offset: 0x000C0484
		// (set) Token: 0x06002D0E RID: 11534 RVA: 0x00012456 File Offset: 0x00010656
		public unsafe uint m_StatsElementsAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_StatsElementsAdded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_StatsElementsAdded)) = value;
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06002D0F RID: 11535 RVA: 0x000C22AC File Offset: 0x000C04AC
		// (set) Token: 0x06002D10 RID: 11536 RVA: 0x00012471 File Offset: 0x00010671
		public unsafe uint m_StatsElementsRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_StatsElementsRemoved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_StatsElementsRemoved)) = value;
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x000C22D4 File Offset: 0x000C04D4
		// (set) Token: 0x06002D12 RID: 11538 RVA: 0x0001248C File Offset: 0x0001068C
		public unsafe TextureRegistry m_TextureRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_TextureRegistry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureRegistry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_m_TextureRegistry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06002D13 RID: 11539 RVA: 0x000C2304 File Offset: 0x000C0504
		// (set) Token: 0x06002D14 RID: 11540 RVA: 0x000124AB File Offset: 0x000106AB
		public unsafe OpacityIdAccelerator _opacityIdAccelerator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__opacityIdAccelerator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OpacityIdAccelerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__opacityIdAccelerator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x000C2334 File Offset: 0x000C0534
		// (set) Token: 0x06002D16 RID: 11542 RVA: 0x000124CA File Offset: 0x000106CA
		public unsafe static ProfilerMarker s_MarkerProcess
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(RenderChain.NativeFieldInfoPtr_s_MarkerProcess, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderChain.NativeFieldInfoPtr_s_MarkerProcess, (void*)(&value));
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x000C2350 File Offset: 0x000C0550
		// (set) Token: 0x06002D18 RID: 11544 RVA: 0x000124D8 File Offset: 0x000106D8
		public unsafe static ProfilerMarker s_MarkerClipProcessing
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(RenderChain.NativeFieldInfoPtr_s_MarkerClipProcessing, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderChain.NativeFieldInfoPtr_s_MarkerClipProcessing, (void*)(&value));
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06002D19 RID: 11545 RVA: 0x000C236C File Offset: 0x000C056C
		// (set) Token: 0x06002D1A RID: 11546 RVA: 0x000124E6 File Offset: 0x000106E6
		public unsafe static ProfilerMarker s_MarkerOpacityProcessing
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(RenderChain.NativeFieldInfoPtr_s_MarkerOpacityProcessing, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderChain.NativeFieldInfoPtr_s_MarkerOpacityProcessing, (void*)(&value));
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06002D1B RID: 11547 RVA: 0x000C2388 File Offset: 0x000C0588
		// (set) Token: 0x06002D1C RID: 11548 RVA: 0x000124F4 File Offset: 0x000106F4
		public unsafe static ProfilerMarker s_MarkerColorsProcessing
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(RenderChain.NativeFieldInfoPtr_s_MarkerColorsProcessing, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderChain.NativeFieldInfoPtr_s_MarkerColorsProcessing, (void*)(&value));
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x000C23A4 File Offset: 0x000C05A4
		// (set) Token: 0x06002D1E RID: 11550 RVA: 0x00012502 File Offset: 0x00010702
		public unsafe static ProfilerMarker s_MarkerTransformProcessing
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(RenderChain.NativeFieldInfoPtr_s_MarkerTransformProcessing, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderChain.NativeFieldInfoPtr_s_MarkerTransformProcessing, (void*)(&value));
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06002D1F RID: 11551 RVA: 0x000C23C0 File Offset: 0x000C05C0
		// (set) Token: 0x06002D20 RID: 11552 RVA: 0x00012510 File Offset: 0x00010710
		public unsafe static ProfilerMarker s_MarkerVisualsProcessing
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(RenderChain.NativeFieldInfoPtr_s_MarkerVisualsProcessing, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderChain.NativeFieldInfoPtr_s_MarkerVisualsProcessing, (void*)(&value));
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06002D21 RID: 11553 RVA: 0x000C23DC File Offset: 0x000C05DC
		// (set) Token: 0x06002D22 RID: 11554 RVA: 0x0001251E File Offset: 0x0001071E
		public unsafe static ProfilerMarker s_MarkerTextRegen
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(RenderChain.NativeFieldInfoPtr_s_MarkerTextRegen, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderChain.NativeFieldInfoPtr_s_MarkerTextRegen, (void*)(&value));
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06002D23 RID: 11555 RVA: 0x000C23F8 File Offset: 0x000C05F8
		// (set) Token: 0x06002D24 RID: 11556 RVA: 0x0001252C File Offset: 0x0001072C
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06002D25 RID: 11557 RVA: 0x000C2420 File Offset: 0x000C0620
		// (set) Token: 0x06002D26 RID: 11558 RVA: 0x00012547 File Offset: 0x00010747
		public unsafe static Action OnPreRender
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderChain.NativeFieldInfoPtr_OnPreRender, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderChain.NativeFieldInfoPtr_OnPreRender, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06002D27 RID: 11559 RVA: 0x000C2448 File Offset: 0x000C0648
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x00012559 File Offset: 0x00010759
		public unsafe BaseVisualElementPanel _panel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__panel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVisualElementPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__panel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x000C2478 File Offset: 0x000C0678
		// (set) Token: 0x06002D2A RID: 11562 RVA: 0x00012578 File Offset: 0x00010778
		public unsafe UIRenderDevice _device_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__device_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIRenderDevice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__device_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x000C24A8 File Offset: 0x000C06A8
		// (set) Token: 0x06002D2C RID: 11564 RVA: 0x00012597 File Offset: 0x00010797
		public unsafe AtlasBase _atlas_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__atlas_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtlasBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__atlas_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06002D2D RID: 11565 RVA: 0x000C24D8 File Offset: 0x000C06D8
		// (set) Token: 0x06002D2E RID: 11566 RVA: 0x000125B6 File Offset: 0x000107B6
		public unsafe VectorImageManager _vectorImageManager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__vectorImageManager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VectorImageManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__vectorImageManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06002D2F RID: 11567 RVA: 0x000C2508 File Offset: 0x000C0708
		// (set) Token: 0x06002D30 RID: 11568 RVA: 0x000125D5 File Offset: 0x000107D5
		public unsafe TempAllocator<Vertex> _vertsPool_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__vertsPool_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TempAllocator<Vertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__vertsPool_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06002D31 RID: 11569 RVA: 0x000C2538 File Offset: 0x000C0738
		// (set) Token: 0x06002D32 RID: 11570 RVA: 0x000125F4 File Offset: 0x000107F4
		public unsafe TempAllocator<ushort> _indicesPool_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__indicesPool_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TempAllocator<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__indicesPool_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06002D33 RID: 11571 RVA: 0x000C2568 File Offset: 0x000C0768
		// (set) Token: 0x06002D34 RID: 11572 RVA: 0x00012613 File Offset: 0x00010813
		public unsafe JobManager _jobManager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__jobManager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JobManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__jobManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x000C2598 File Offset: 0x000C0798
		// (set) Token: 0x06002D36 RID: 11574 RVA: 0x00012632 File Offset: 0x00010832
		public UIRVEShaderInfoAllocator shaderInfoAllocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_shaderInfoAllocator);
				return new UIRVEShaderInfoAllocator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr_shaderInfoAllocator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x000C25C8 File Offset: 0x000C07C8
		// (set) Token: 0x06002D38 RID: 11576 RVA: 0x00012660 File Offset: 0x00010860
		public unsafe UnityEngine.UIElements.UIR.Implementation.UIRStylePainter _painter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__painter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__painter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06002D39 RID: 11577 RVA: 0x000C25F8 File Offset: 0x000C07F8
		// (set) Token: 0x06002D3A RID: 11578 RVA: 0x0001267F File Offset: 0x0001087F
		public unsafe bool _drawStats_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__drawStats_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__drawStats_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x000C2620 File Offset: 0x000C0820
		// (set) Token: 0x06002D3C RID: 11580 RVA: 0x0001269A File Offset: 0x0001089A
		public unsafe bool _drawInCameras_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__drawInCameras_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.NativeFieldInfoPtr__drawInCameras_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x000C2648 File Offset: 0x000C0848
		public RenderChainCommand firstCommand
		{
			get
			{
				return this.m_FirstCommand;
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x000C2660 File Offset: 0x000C0860
		public ChainBuilderStats stats
		{
			get
			{
				return this.m_Stats;
			}
		}

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstCommand;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeFieldInfoPtr_m_DirtyTracker;

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeFieldInfoPtr_m_CommandPool;

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeFieldInfoPtr_m_TexturePool;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderNodesData;

		// Token: 0x04002039 RID: 8249
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultShader;

		// Token: 0x0400203A RID: 8250
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultWorldSpaceShader;

		// Token: 0x0400203B RID: 8251
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultMat;

		// Token: 0x0400203C RID: 8252
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultWorldSpaceMat;

		// Token: 0x0400203D RID: 8253
		private static readonly IntPtr NativeFieldInfoPtr_m_BlockDirtyRegistration;

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeFieldInfoPtr_m_StaticIndex;

		// Token: 0x0400203F RID: 8255
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveRenderNodes;

		// Token: 0x04002040 RID: 8256
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomMaterialCommands;

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeFieldInfoPtr_m_Stats;

		// Token: 0x04002042 RID: 8258
		private static readonly IntPtr NativeFieldInfoPtr_m_StatsElementsAdded;

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeFieldInfoPtr_m_StatsElementsRemoved;

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeFieldInfoPtr_m_TextureRegistry;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeFieldInfoPtr__opacityIdAccelerator_k__BackingField;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerProcess;

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerClipProcessing;

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerOpacityProcessing;

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerColorsProcessing;

		// Token: 0x0400204A RID: 8266
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerTransformProcessing;

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerVisualsProcessing;

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerTextRegen;

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeFieldInfoPtr_OnPreRender;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeFieldInfoPtr__panel_k__BackingField;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeFieldInfoPtr__device_k__BackingField;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeFieldInfoPtr__atlas_k__BackingField;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeFieldInfoPtr__vectorImageManager_k__BackingField;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeFieldInfoPtr__vertsPool_k__BackingField;

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeFieldInfoPtr__indicesPool_k__BackingField;

		// Token: 0x04002055 RID: 8277
		private static readonly IntPtr NativeFieldInfoPtr__jobManager_k__BackingField;

		// Token: 0x04002056 RID: 8278
		private static readonly IntPtr NativeFieldInfoPtr_shaderInfoAllocator;

		// Token: 0x04002057 RID: 8279
		private static readonly IntPtr NativeFieldInfoPtr__painter_k__BackingField;

		// Token: 0x04002058 RID: 8280
		private static readonly IntPtr NativeFieldInfoPtr__drawStats_k__BackingField;

		// Token: 0x04002059 RID: 8281
		private static readonly IntPtr NativeFieldInfoPtr__drawInCameras_k__BackingField;

		// Token: 0x0400205A RID: 8282
		private static readonly IntPtr NativeMethodInfoPtr_get_opacityIdAccelerator_Public_get_OpacityIdAccelerator_0;

		// Token: 0x0400205B RID: 8283
		private static readonly IntPtr NativeMethodInfoPtr_set_opacityIdAccelerator_Private_set_Void_OpacityIdAccelerator_0;

		// Token: 0x0400205C RID: 8284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseVisualElementPanel_0;

		// Token: 0x0400205D RID: 8285
		private static readonly IntPtr NativeMethodInfoPtr_Constructor_Private_Void_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager_0;

		// Token: 0x0400205E RID: 8286
		private static readonly IntPtr NativeMethodInfoPtr_Destructor_Private_Void_0;

		// Token: 0x0400205F RID: 8287
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x04002060 RID: 8288
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x04002061 RID: 8289
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002062 RID: 8290
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;

		// Token: 0x04002063 RID: 8291
		private static readonly IntPtr NativeMethodInfoPtr_ProcessChanges_Public_Void_0;

		// Token: 0x04002064 RID: 8292
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_0;

		// Token: 0x04002065 RID: 8293
		private static readonly IntPtr NativeMethodInfoPtr_UIEOnChildAdded_Public_Void_VisualElement_0;

		// Token: 0x04002066 RID: 8294
		private static readonly IntPtr NativeMethodInfoPtr_UIEOnChildrenReordered_Public_Void_VisualElement_0;

		// Token: 0x04002067 RID: 8295
		private static readonly IntPtr NativeMethodInfoPtr_UIEOnChildRemoving_Public_Void_VisualElement_0;

		// Token: 0x04002068 RID: 8296
		private static readonly IntPtr NativeMethodInfoPtr_UIEOnRenderHintsChanged_Public_Void_VisualElement_0;

		// Token: 0x04002069 RID: 8297
		private static readonly IntPtr NativeMethodInfoPtr_UIEOnClippingChanged_Public_Void_VisualElement_Boolean_0;

		// Token: 0x0400206A RID: 8298
		private static readonly IntPtr NativeMethodInfoPtr_UIEOnOpacityChanged_Public_Void_VisualElement_Boolean_0;

		// Token: 0x0400206B RID: 8299
		private static readonly IntPtr NativeMethodInfoPtr_UIEOnColorChanged_Public_Void_VisualElement_0;

		// Token: 0x0400206C RID: 8300
		private static readonly IntPtr NativeMethodInfoPtr_UIEOnTransformOrSizeChanged_Public_Void_VisualElement_Boolean_Boolean_0;

		// Token: 0x0400206D RID: 8301
		private static readonly IntPtr NativeMethodInfoPtr_UIEOnVisualsChanged_Public_Void_VisualElement_Boolean_0;

		// Token: 0x0400206E RID: 8302
		private static readonly IntPtr NativeMethodInfoPtr_UIEOnOpacityIdChanged_Public_Void_VisualElement_0;

		// Token: 0x0400206F RID: 8303
		private static readonly IntPtr NativeMethodInfoPtr_get_panel_Internal_get_BaseVisualElementPanel_0;

		// Token: 0x04002070 RID: 8304
		private static readonly IntPtr NativeMethodInfoPtr_set_panel_Private_set_Void_BaseVisualElementPanel_0;

		// Token: 0x04002071 RID: 8305
		private static readonly IntPtr NativeMethodInfoPtr_get_device_Internal_get_UIRenderDevice_0;

		// Token: 0x04002072 RID: 8306
		private static readonly IntPtr NativeMethodInfoPtr_set_device_Private_set_Void_UIRenderDevice_0;

		// Token: 0x04002073 RID: 8307
		private static readonly IntPtr NativeMethodInfoPtr_get_atlas_Internal_get_AtlasBase_0;

		// Token: 0x04002074 RID: 8308
		private static readonly IntPtr NativeMethodInfoPtr_set_atlas_Private_set_Void_AtlasBase_0;

		// Token: 0x04002075 RID: 8309
		private static readonly IntPtr NativeMethodInfoPtr_get_vectorImageManager_Internal_get_VectorImageManager_0;

		// Token: 0x04002076 RID: 8310
		private static readonly IntPtr NativeMethodInfoPtr_set_vectorImageManager_Private_set_Void_VectorImageManager_0;

		// Token: 0x04002077 RID: 8311
		private static readonly IntPtr NativeMethodInfoPtr_get_vertsPool_Internal_get_TempAllocator_1_Vertex_0;

		// Token: 0x04002078 RID: 8312
		private static readonly IntPtr NativeMethodInfoPtr_set_vertsPool_Private_set_Void_TempAllocator_1_Vertex_0;

		// Token: 0x04002079 RID: 8313
		private static readonly IntPtr NativeMethodInfoPtr_get_indicesPool_Internal_get_TempAllocator_1_UInt16_0;

		// Token: 0x0400207A RID: 8314
		private static readonly IntPtr NativeMethodInfoPtr_set_indicesPool_Private_set_Void_TempAllocator_1_UInt16_0;

		// Token: 0x0400207B RID: 8315
		private static readonly IntPtr NativeMethodInfoPtr_get_jobManager_Internal_get_JobManager_0;

		// Token: 0x0400207C RID: 8316
		private static readonly IntPtr NativeMethodInfoPtr_set_jobManager_Private_set_Void_JobManager_0;

		// Token: 0x0400207D RID: 8317
		private static readonly IntPtr NativeMethodInfoPtr_get_painter_Internal_get_UIRStylePainter_0;

		// Token: 0x0400207E RID: 8318
		private static readonly IntPtr NativeMethodInfoPtr_set_painter_Private_set_Void_UIRStylePainter_0;

		// Token: 0x0400207F RID: 8319
		private static readonly IntPtr NativeMethodInfoPtr_get_drawStats_Internal_get_Boolean_0;

		// Token: 0x04002080 RID: 8320
		private static readonly IntPtr NativeMethodInfoPtr_set_drawStats_Internal_set_Void_Boolean_0;

		// Token: 0x04002081 RID: 8321
		private static readonly IntPtr NativeMethodInfoPtr_get_drawInCameras_Internal_get_Boolean_0;

		// Token: 0x04002082 RID: 8322
		private static readonly IntPtr NativeMethodInfoPtr_set_drawInCameras_Private_set_Void_Boolean_0;

		// Token: 0x04002083 RID: 8323
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultShader_Internal_set_Void_Shader_0;

		// Token: 0x04002084 RID: 8324
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultWorldSpaceShader_Internal_set_Void_Shader_0;

		// Token: 0x04002085 RID: 8325
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardMaterial_Internal_Material_0;

		// Token: 0x04002086 RID: 8326
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardWorldSpaceMaterial_Internal_Material_0;

		// Token: 0x04002087 RID: 8327
		private static readonly IntPtr NativeMethodInfoPtr_EnsureFitsDepth_Internal_Void_Int32_0;

		// Token: 0x04002088 RID: 8328
		private static readonly IntPtr NativeMethodInfoPtr_ChildWillBeRemoved_Internal_Void_VisualElement_0;

		// Token: 0x04002089 RID: 8329
		private static readonly IntPtr NativeMethodInfoPtr_AllocCommand_Internal_RenderChainCommand_0;

		// Token: 0x0400208A RID: 8330
		private static readonly IntPtr NativeMethodInfoPtr_FreeCommand_Internal_Void_RenderChainCommand_0;

		// Token: 0x0400208B RID: 8331
		private static readonly IntPtr NativeMethodInfoPtr_OnRenderCommandAdded_Internal_Void_RenderChainCommand_0;

		// Token: 0x0400208C RID: 8332
		private static readonly IntPtr NativeMethodInfoPtr_OnRenderCommandsRemoved_Internal_Void_RenderChainCommand_RenderChainCommand_0;

		// Token: 0x0400208D RID: 8333
		private static readonly IntPtr NativeMethodInfoPtr_AccessRenderNodeData_Private_Static_RenderNodeData_IntPtr_0;

		// Token: 0x0400208E RID: 8334
		private static readonly IntPtr NativeMethodInfoPtr_OnRenderNodeExecute_Private_Static_Void_IntPtr_0;

		// Token: 0x0400208F RID: 8335
		private static readonly IntPtr NativeMethodInfoPtr_OnRegisterIntermediateRenderers_Private_Static_Void_Camera_0;

		// Token: 0x04002090 RID: 8336
		private static readonly IntPtr NativeMethodInfoPtr_OnRegisterIntermediateRendererMat_Private_Static_Void_BaseRuntimePanel_RenderChain_byref_RenderNodeData_Camera_Int32_0;

		// Token: 0x04002091 RID: 8337
		private static readonly IntPtr NativeMethodInfoPtr_RepaintTexturedElements_Internal_Void_0;

		// Token: 0x04002092 RID: 8338
		private static readonly IntPtr NativeMethodInfoPtr_InsertTexture_Public_Void_VisualElement_Texture_TextureId_Boolean_0;

		// Token: 0x04002093 RID: 8339
		private static readonly IntPtr NativeMethodInfoPtr_ResetTextures_Public_Void_VisualElement_0;

		// Token: 0x04002094 RID: 8340
		private static readonly IntPtr NativeMethodInfoPtr_DrawStats_Private_Void_0;

		// Token: 0x04002095 RID: 8341
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstElementInPanel_Private_Static_VisualElement_VisualElement_0;

		// Token: 0x02000552 RID: 1362
		public sealed class DepthOrderedDirtyTracking : ValueType
		{
			// Token: 0x06004195 RID: 16789 RVA: 0x00102A34 File Offset: 0x00100C34
			// Note: this type is marked as 'beforefieldinit'.
			static DepthOrderedDirtyTracking()
			{
				Il2CppClassPointerStore<RenderChain.DepthOrderedDirtyTracking>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "DepthOrderedDirtyTracking");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderChain.DepthOrderedDirtyTracking>.NativeClassPtr);
				RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_heads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.DepthOrderedDirtyTracking>.NativeClassPtr, "heads");
				RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_tails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.DepthOrderedDirtyTracking>.NativeClassPtr, "tails");
				RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_minDepths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.DepthOrderedDirtyTracking>.NativeClassPtr, "minDepths");
				RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_maxDepths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.DepthOrderedDirtyTracking>.NativeClassPtr, "maxDepths");
				RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_dirtyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.DepthOrderedDirtyTracking>.NativeClassPtr, "dirtyID");
				RenderChain.DepthOrderedDirtyTracking.NativeMethodInfoPtr_EnsureFits_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain.DepthOrderedDirtyTracking>.NativeClassPtr, 100669950);
				RenderChain.DepthOrderedDirtyTracking.NativeMethodInfoPtr_RegisterDirty_Public_Void_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain.DepthOrderedDirtyTracking>.NativeClassPtr, 100669951);
				RenderChain.DepthOrderedDirtyTracking.NativeMethodInfoPtr_ClearDirty_Public_Void_VisualElement_RenderDataDirtyTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain.DepthOrderedDirtyTracking>.NativeClassPtr, 100669952);
				RenderChain.DepthOrderedDirtyTracking.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain.DepthOrderedDirtyTracking>.NativeClassPtr, 100669953);
			}

			// Token: 0x06004196 RID: 16790 RVA: 0x00102B14 File Offset: 0x00100D14
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 350541, RefRangeEnd = 350542, XrefRangeStart = 350530, XrefRangeEnd = 350541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EnsureFits(int maxDepth)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref maxDepth;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.DepthOrderedDirtyTracking.NativeMethodInfoPtr_EnsureFits_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004197 RID: 16791 RVA: 0x00102B58 File Offset: 0x00100D58
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 350554, RefRangeEnd = 350567, XrefRangeStart = 350542, XrefRangeEnd = 350554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirtyTypes;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirtyTypeClass;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.DepthOrderedDirtyTracking.NativeMethodInfoPtr_RegisterDirty_Public_Void_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004198 RID: 16792 RVA: 0x00102BBC File Offset: 0x00100DBC
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 350591, RefRangeEnd = 350597, XrefRangeStart = 350567, XrefRangeEnd = 350591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ClearDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypesInverse)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirtyTypesInverse;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.DepthOrderedDirtyTracking.NativeMethodInfoPtr_ClearDirty_Public_Void_VisualElement_RenderDataDirtyTypes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004199 RID: 16793 RVA: 0x00102C14 File Offset: 0x00100E14
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 350598, RefRangeEnd = 350600, XrefRangeStart = 350597, XrefRangeEnd = 350598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.DepthOrderedDirtyTracking.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600419A RID: 16794 RVA: 0x0001BD50 File Offset: 0x00019F50
			public DepthOrderedDirtyTracking(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600419B RID: 16795 RVA: 0x0001BD59 File Offset: 0x00019F59
			public DepthOrderedDirtyTracking()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderChain.DepthOrderedDirtyTracking>.NativeClassPtr))
			{
			}

			// Token: 0x170013A8 RID: 5032
			// (get) Token: 0x0600419C RID: 16796 RVA: 0x00102C4C File Offset: 0x00100E4C
			// (set) Token: 0x0600419D RID: 16797 RVA: 0x0001BD6B File Offset: 0x00019F6B
			public unsafe List<VisualElement> heads
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_heads);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_heads), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013A9 RID: 5033
			// (get) Token: 0x0600419E RID: 16798 RVA: 0x00102C7C File Offset: 0x00100E7C
			// (set) Token: 0x0600419F RID: 16799 RVA: 0x0001BD8A File Offset: 0x00019F8A
			public unsafe List<VisualElement> tails
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_tails);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_tails), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013AA RID: 5034
			// (get) Token: 0x060041A0 RID: 16800 RVA: 0x00102CAC File Offset: 0x00100EAC
			// (set) Token: 0x060041A1 RID: 16801 RVA: 0x0001BDA9 File Offset: 0x00019FA9
			public unsafe Il2CppStructArray<int> minDepths
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_minDepths);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_minDepths), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013AB RID: 5035
			// (get) Token: 0x060041A2 RID: 16802 RVA: 0x00102CDC File Offset: 0x00100EDC
			// (set) Token: 0x060041A3 RID: 16803 RVA: 0x0001BDC8 File Offset: 0x00019FC8
			public unsafe Il2CppStructArray<int> maxDepths
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_maxDepths);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_maxDepths), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013AC RID: 5036
			// (get) Token: 0x060041A4 RID: 16804 RVA: 0x00102D0C File Offset: 0x00100F0C
			// (set) Token: 0x060041A5 RID: 16805 RVA: 0x0001BDE7 File Offset: 0x00019FE7
			public unsafe uint dirtyID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_dirtyID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.DepthOrderedDirtyTracking.NativeFieldInfoPtr_dirtyID)) = value;
				}
			}

			// Token: 0x04002E12 RID: 11794
			private static readonly IntPtr NativeFieldInfoPtr_heads;

			// Token: 0x04002E13 RID: 11795
			private static readonly IntPtr NativeFieldInfoPtr_tails;

			// Token: 0x04002E14 RID: 11796
			private static readonly IntPtr NativeFieldInfoPtr_minDepths;

			// Token: 0x04002E15 RID: 11797
			private static readonly IntPtr NativeFieldInfoPtr_maxDepths;

			// Token: 0x04002E16 RID: 11798
			private static readonly IntPtr NativeFieldInfoPtr_dirtyID;

			// Token: 0x04002E17 RID: 11799
			private static readonly IntPtr NativeMethodInfoPtr_EnsureFits_Public_Void_Int32_0;

			// Token: 0x04002E18 RID: 11800
			private static readonly IntPtr NativeMethodInfoPtr_RegisterDirty_Public_Void_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses_0;

			// Token: 0x04002E19 RID: 11801
			private static readonly IntPtr NativeMethodInfoPtr_ClearDirty_Public_Void_VisualElement_RenderDataDirtyTypes_0;

			// Token: 0x04002E1A RID: 11802
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
		}

		// Token: 0x02000553 RID: 1363
		[StructLayout(2)]
		public struct RenderChainStaticIndexAllocator
		{
			// Token: 0x060041A6 RID: 16806 RVA: 0x00102D34 File Offset: 0x00100F34
			// Note: this type is marked as 'beforefieldinit'.
			static RenderChainStaticIndexAllocator()
			{
				Il2CppClassPointerStore<RenderChain.RenderChainStaticIndexAllocator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "RenderChainStaticIndexAllocator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderChain.RenderChainStaticIndexAllocator>.NativeClassPtr);
				RenderChain.RenderChainStaticIndexAllocator.NativeFieldInfoPtr_renderChains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.RenderChainStaticIndexAllocator>.NativeClassPtr, "renderChains");
				RenderChain.RenderChainStaticIndexAllocator.NativeMethodInfoPtr_AllocateIndex_Public_Static_Int32_RenderChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain.RenderChainStaticIndexAllocator>.NativeClassPtr, 100669954);
				RenderChain.RenderChainStaticIndexAllocator.NativeMethodInfoPtr_FreeIndex_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain.RenderChainStaticIndexAllocator>.NativeClassPtr, 100669955);
				RenderChain.RenderChainStaticIndexAllocator.NativeMethodInfoPtr_AccessIndex_Public_Static_RenderChain_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain.RenderChainStaticIndexAllocator>.NativeClassPtr, 100669956);
			}

			// Token: 0x060041A7 RID: 16807 RVA: 0x00102DB0 File Offset: 0x00100FB0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 350615, RefRangeEnd = 350616, XrefRangeStart = 350600, XrefRangeEnd = 350615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int AllocateIndex(RenderChain renderChain)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.RenderChainStaticIndexAllocator.NativeMethodInfoPtr_AllocateIndex_Public_Static_Int32_RenderChain_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060041A8 RID: 16808 RVA: 0x00102DF4 File Offset: 0x00100FF4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 350634, RefRangeEnd = 350635, XrefRangeStart = 350616, XrefRangeEnd = 350634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void FreeIndex(int index)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.RenderChainStaticIndexAllocator.NativeMethodInfoPtr_FreeIndex_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060041A9 RID: 16809 RVA: 0x00102E28 File Offset: 0x00101028
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 350643, RefRangeEnd = 350645, XrefRangeStart = 350635, XrefRangeEnd = 350643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static RenderChain AccessIndex(int index)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.RenderChainStaticIndexAllocator.NativeMethodInfoPtr_AccessIndex_Public_Static_RenderChain_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderChain>(intPtr3) : null;
				}
			}

			// Token: 0x060041AA RID: 16810 RVA: 0x0001BE02 File Offset: 0x0001A002
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderChain.RenderChainStaticIndexAllocator>.NativeClassPtr, ref this));
			}

			// Token: 0x170013AD RID: 5037
			// (get) Token: 0x060041AB RID: 16811 RVA: 0x00102E68 File Offset: 0x00101068
			// (set) Token: 0x060041AC RID: 16812 RVA: 0x0001BE14 File Offset: 0x0001A014
			public unsafe static List<RenderChain> renderChains
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RenderChain.RenderChainStaticIndexAllocator.NativeFieldInfoPtr_renderChains, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RenderChain>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderChain.RenderChainStaticIndexAllocator.NativeFieldInfoPtr_renderChains, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E1B RID: 11803
			private static readonly IntPtr NativeFieldInfoPtr_renderChains;

			// Token: 0x04002E1C RID: 11804
			private static readonly IntPtr NativeMethodInfoPtr_AllocateIndex_Public_Static_Int32_RenderChain_0;

			// Token: 0x04002E1D RID: 11805
			private static readonly IntPtr NativeMethodInfoPtr_FreeIndex_Public_Static_Void_Int32_0;

			// Token: 0x04002E1E RID: 11806
			private static readonly IntPtr NativeMethodInfoPtr_AccessIndex_Public_Static_RenderChain_Int32_0;
		}

		// Token: 0x02000554 RID: 1364
		public sealed class RenderNodeData : ValueType
		{
			// Token: 0x060041AD RID: 16813 RVA: 0x00102E90 File Offset: 0x00101090
			// Note: this type is marked as 'beforefieldinit'.
			static RenderNodeData()
			{
				Il2CppClassPointerStore<RenderChain.RenderNodeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "RenderNodeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderChain.RenderNodeData>.NativeClassPtr);
				RenderChain.RenderNodeData.NativeFieldInfoPtr_standardMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.RenderNodeData>.NativeClassPtr, "standardMaterial");
				RenderChain.RenderNodeData.NativeFieldInfoPtr_initialMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.RenderNodeData>.NativeClassPtr, "initialMaterial");
				RenderChain.RenderNodeData.NativeFieldInfoPtr_matPropBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.RenderNodeData>.NativeClassPtr, "matPropBlock");
				RenderChain.RenderNodeData.NativeFieldInfoPtr_firstCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.RenderNodeData>.NativeClassPtr, "firstCommand");
				RenderChain.RenderNodeData.NativeFieldInfoPtr_device = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.RenderNodeData>.NativeClassPtr, "device");
				RenderChain.RenderNodeData.NativeFieldInfoPtr_vectorAtlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.RenderNodeData>.NativeClassPtr, "vectorAtlas");
				RenderChain.RenderNodeData.NativeFieldInfoPtr_shaderInfoAtlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.RenderNodeData>.NativeClassPtr, "shaderInfoAtlas");
				RenderChain.RenderNodeData.NativeFieldInfoPtr_dpiScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.RenderNodeData>.NativeClassPtr, "dpiScale");
				RenderChain.RenderNodeData.NativeFieldInfoPtr_transformConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.RenderNodeData>.NativeClassPtr, "transformConstants");
				RenderChain.RenderNodeData.NativeFieldInfoPtr_clipRectConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.RenderNodeData>.NativeClassPtr, "clipRectConstants");
			}

			// Token: 0x060041AE RID: 16814 RVA: 0x0001BE26 File Offset: 0x0001A026
			public RenderNodeData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060041AF RID: 16815 RVA: 0x0001BE2F File Offset: 0x0001A02F
			public RenderNodeData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderChain.RenderNodeData>.NativeClassPtr))
			{
			}

			// Token: 0x170013AE RID: 5038
			// (get) Token: 0x060041B0 RID: 16816 RVA: 0x00102F84 File Offset: 0x00101184
			// (set) Token: 0x060041B1 RID: 16817 RVA: 0x0001BE41 File Offset: 0x0001A041
			public unsafe Material standardMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_standardMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_standardMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013AF RID: 5039
			// (get) Token: 0x060041B2 RID: 16818 RVA: 0x00102FB4 File Offset: 0x001011B4
			// (set) Token: 0x060041B3 RID: 16819 RVA: 0x0001BE60 File Offset: 0x0001A060
			public unsafe Material initialMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_initialMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_initialMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013B0 RID: 5040
			// (get) Token: 0x060041B4 RID: 16820 RVA: 0x00102FE4 File Offset: 0x001011E4
			// (set) Token: 0x060041B5 RID: 16821 RVA: 0x0001BE7F File Offset: 0x0001A07F
			public unsafe MaterialPropertyBlock matPropBlock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_matPropBlock);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_matPropBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013B1 RID: 5041
			// (get) Token: 0x060041B6 RID: 16822 RVA: 0x00103014 File Offset: 0x00101214
			// (set) Token: 0x060041B7 RID: 16823 RVA: 0x0001BE9E File Offset: 0x0001A09E
			public unsafe RenderChainCommand firstCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_firstCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_firstCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013B2 RID: 5042
			// (get) Token: 0x060041B8 RID: 16824 RVA: 0x00103044 File Offset: 0x00101244
			// (set) Token: 0x060041B9 RID: 16825 RVA: 0x0001BEBD File Offset: 0x0001A0BD
			public unsafe UIRenderDevice device
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_device);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIRenderDevice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_device), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013B3 RID: 5043
			// (get) Token: 0x060041BA RID: 16826 RVA: 0x00103074 File Offset: 0x00101274
			// (set) Token: 0x060041BB RID: 16827 RVA: 0x0001BEDC File Offset: 0x0001A0DC
			public unsafe Texture vectorAtlas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_vectorAtlas);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_vectorAtlas), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013B4 RID: 5044
			// (get) Token: 0x060041BC RID: 16828 RVA: 0x001030A4 File Offset: 0x001012A4
			// (set) Token: 0x060041BD RID: 16829 RVA: 0x0001BEFB File Offset: 0x0001A0FB
			public unsafe Texture shaderInfoAtlas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_shaderInfoAtlas);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_shaderInfoAtlas), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013B5 RID: 5045
			// (get) Token: 0x060041BE RID: 16830 RVA: 0x001030D4 File Offset: 0x001012D4
			// (set) Token: 0x060041BF RID: 16831 RVA: 0x0001BF1A File Offset: 0x0001A11A
			public unsafe float dpiScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_dpiScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_dpiScale)) = value;
				}
			}

			// Token: 0x170013B6 RID: 5046
			// (get) Token: 0x060041C0 RID: 16832 RVA: 0x001030FC File Offset: 0x001012FC
			// (set) Token: 0x060041C1 RID: 16833 RVA: 0x0001BF35 File Offset: 0x0001A135
			public NativeSlice<Transform3x4> transformConstants
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_transformConstants);
					return new NativeSlice<Transform3x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeSlice<Transform3x4>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_transformConstants), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<Transform3x4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170013B7 RID: 5047
			// (get) Token: 0x060041C2 RID: 16834 RVA: 0x0010312C File Offset: 0x0010132C
			// (set) Token: 0x060041C3 RID: 16835 RVA: 0x0001BF63 File Offset: 0x0001A163
			public NativeSlice<Vector4> clipRectConstants
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_clipRectConstants);
					return new NativeSlice<Vector4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeSlice<Vector4>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChain.RenderNodeData.NativeFieldInfoPtr_clipRectConstants), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<Vector4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002E1F RID: 11807
			private static readonly IntPtr NativeFieldInfoPtr_standardMaterial;

			// Token: 0x04002E20 RID: 11808
			private static readonly IntPtr NativeFieldInfoPtr_initialMaterial;

			// Token: 0x04002E21 RID: 11809
			private static readonly IntPtr NativeFieldInfoPtr_matPropBlock;

			// Token: 0x04002E22 RID: 11810
			private static readonly IntPtr NativeFieldInfoPtr_firstCommand;

			// Token: 0x04002E23 RID: 11811
			private static readonly IntPtr NativeFieldInfoPtr_device;

			// Token: 0x04002E24 RID: 11812
			private static readonly IntPtr NativeFieldInfoPtr_vectorAtlas;

			// Token: 0x04002E25 RID: 11813
			private static readonly IntPtr NativeFieldInfoPtr_shaderInfoAtlas;

			// Token: 0x04002E26 RID: 11814
			private static readonly IntPtr NativeFieldInfoPtr_dpiScale;

			// Token: 0x04002E27 RID: 11815
			private static readonly IntPtr NativeFieldInfoPtr_transformConstants;

			// Token: 0x04002E28 RID: 11816
			private static readonly IntPtr NativeFieldInfoPtr_clipRectConstants;
		}

		// Token: 0x02000555 RID: 1365
		[ObfuscatedName("UnityEngine.UIElements.UIR.RenderChain+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060041C4 RID: 16836 RVA: 0x0010315C File Offset: 0x0010135C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RenderChain.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderChain>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderChain.__c>.NativeClassPtr);
				RenderChain.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.__c>.NativeClassPtr, "<>9");
				RenderChain.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.__c>.NativeClassPtr, "<>9__34_0");
				RenderChain.__c.NativeFieldInfoPtr___9__34_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChain.__c>.NativeClassPtr, "<>9__34_1");
				RenderChain.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain.__c>.NativeClassPtr, 100669959);
				RenderChain.__c.NativeMethodInfoPtr___ctor_b__34_0_Internal_RenderChainCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain.__c>.NativeClassPtr, 100669960);
				RenderChain.__c.NativeMethodInfoPtr___ctor_b__34_1_Internal_Void_RenderChainCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChain.__c>.NativeClassPtr, 100669961);
			}

			// Token: 0x060041C5 RID: 16837 RVA: 0x00103200 File Offset: 0x00101400
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderChain.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060041C6 RID: 16838 RVA: 0x0010323C File Offset: 0x0010143C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350645, XrefRangeEnd = 350649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RenderChainCommand __ctor_b__34_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.__c.NativeMethodInfoPtr___ctor_b__34_0_Internal_RenderChainCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr3) : null;
			}

			// Token: 0x060041C7 RID: 16839 RVA: 0x0010327C File Offset: 0x0010147C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__34_1(RenderChainCommand cmd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChain.__c.NativeMethodInfoPtr___ctor_b__34_1_Internal_Void_RenderChainCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060041C8 RID: 16840 RVA: 0x0001BF91 File Offset: 0x0001A191
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013B8 RID: 5048
			// (get) Token: 0x060041C9 RID: 16841 RVA: 0x001032C0 File Offset: 0x001014C0
			// (set) Token: 0x060041CA RID: 16842 RVA: 0x0001BF9A File Offset: 0x0001A19A
			public unsafe static RenderChain.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RenderChain.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChain.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderChain.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013B9 RID: 5049
			// (get) Token: 0x060041CB RID: 16843 RVA: 0x001032E8 File Offset: 0x001014E8
			// (set) Token: 0x060041CC RID: 16844 RVA: 0x0001BFAC File Offset: 0x0001A1AC
			public unsafe static Func<RenderChainCommand> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RenderChain.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RenderChainCommand>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderChain.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013BA RID: 5050
			// (get) Token: 0x060041CD RID: 16845 RVA: 0x00103310 File Offset: 0x00101510
			// (set) Token: 0x060041CE RID: 16846 RVA: 0x0001BFBE File Offset: 0x0001A1BE
			public unsafe static Action<RenderChainCommand> __9__34_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RenderChain.__c.NativeFieldInfoPtr___9__34_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RenderChainCommand>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderChain.__c.NativeFieldInfoPtr___9__34_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E29 RID: 11817
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002E2A RID: 11818
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x04002E2B RID: 11819
			private static readonly IntPtr NativeFieldInfoPtr___9__34_1;

			// Token: 0x04002E2C RID: 11820
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E2D RID: 11821
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__34_0_Internal_RenderChainCommand_0;

			// Token: 0x04002E2E RID: 11822
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__34_1_Internal_Void_RenderChainCommand_0;
		}

		// Token: 0x02000556 RID: 1366
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
