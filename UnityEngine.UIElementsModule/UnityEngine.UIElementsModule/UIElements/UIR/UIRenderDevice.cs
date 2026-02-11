using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000249 RID: 585
	public class UIRenderDevice : Object
	{
		// Token: 0x06002B14 RID: 11028 RVA: 0x000BAE9C File Offset: 0x000B909C
		// Note: this type is marked as 'beforefieldinit'.
		static UIRenderDevice()
		{
			Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "UIRenderDevice");
			UIRenderDevice.NativeFieldInfoPtr_m_MockDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_MockDevice");
			UIRenderDevice.NativeFieldInfoPtr_m_DefaultStencilState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_DefaultStencilState");
			UIRenderDevice.NativeFieldInfoPtr_m_VertexDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_VertexDecl");
			UIRenderDevice.NativeFieldInfoPtr_m_FirstPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_FirstPage");
			UIRenderDevice.NativeFieldInfoPtr_m_NextPageVertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_NextPageVertexCount");
			UIRenderDevice.NativeFieldInfoPtr_m_LargeMeshVertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_LargeMeshVertexCount");
			UIRenderDevice.NativeFieldInfoPtr_m_IndexToVertexCountRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_IndexToVertexCountRatio");
			UIRenderDevice.NativeFieldInfoPtr_m_DeferredFrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_DeferredFrees");
			UIRenderDevice.NativeFieldInfoPtr_m_Updates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_Updates");
			UIRenderDevice.NativeFieldInfoPtr_m_Fences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_Fences");
			UIRenderDevice.NativeFieldInfoPtr_m_StandardMatProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_StandardMatProps");
			UIRenderDevice.NativeFieldInfoPtr_m_FrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_FrameIndex");
			UIRenderDevice.NativeFieldInfoPtr_m_NextUpdateID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_NextUpdateID");
			UIRenderDevice.NativeFieldInfoPtr_m_DrawStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_DrawStats");
			UIRenderDevice.NativeFieldInfoPtr_m_MeshHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_MeshHandles");
			UIRenderDevice.NativeFieldInfoPtr_m_DrawParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_DrawParams");
			UIRenderDevice.NativeFieldInfoPtr_m_TextureSlotManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_TextureSlotManager");
			UIRenderDevice.NativeFieldInfoPtr_m_DeviceFreeQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_DeviceFreeQueue");
			UIRenderDevice.NativeFieldInfoPtr_m_ActiveDeviceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_ActiveDeviceCount");
			UIRenderDevice.NativeFieldInfoPtr_m_SubscribedToNotifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_SubscribedToNotifications");
			UIRenderDevice.NativeFieldInfoPtr_m_SynchronousFree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "m_SynchronousFree");
			UIRenderDevice.NativeFieldInfoPtr_s_GradientSettingsTexID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "s_GradientSettingsTexID");
			UIRenderDevice.NativeFieldInfoPtr_s_ShaderInfoTexID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "s_ShaderInfoTexID");
			UIRenderDevice.NativeFieldInfoPtr_s_TransformsPropID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "s_TransformsPropID");
			UIRenderDevice.NativeFieldInfoPtr_s_ClipRectsPropID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "s_ClipRectsPropID");
			UIRenderDevice.NativeFieldInfoPtr_s_MarkerAllocate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "s_MarkerAllocate");
			UIRenderDevice.NativeFieldInfoPtr_s_MarkerFree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "s_MarkerFree");
			UIRenderDevice.NativeFieldInfoPtr_s_MarkerAdvanceFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "s_MarkerAdvanceFrame");
			UIRenderDevice.NativeFieldInfoPtr_s_MarkerFence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "s_MarkerFence");
			UIRenderDevice.NativeFieldInfoPtr_s_MarkerBeforeDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "s_MarkerBeforeDraw");
			UIRenderDevice.NativeFieldInfoPtr_s_VertexTexturingIsAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "s_VertexTexturingIsAvailable");
			UIRenderDevice.NativeFieldInfoPtr_s_ShaderModelIs35 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "s_ShaderModelIs35");
			UIRenderDevice.NativeFieldInfoPtr__maxVerticesPerPage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "<maxVerticesPerPage>k__BackingField");
			UIRenderDevice.NativeFieldInfoPtr__breakBatches_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "<breakBatches>k__BackingField");
			UIRenderDevice.NativeFieldInfoPtr_s_DefaultShaderInfoTexFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "s_DefaultShaderInfoTexFloat");
			UIRenderDevice.NativeFieldInfoPtr_s_DefaultShaderInfoTexARGB8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "s_DefaultShaderInfoTexARGB8");
			UIRenderDevice.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "<disposed>k__BackingField");
			UIRenderDevice.NativeMethodInfoPtr_get_maxVerticesPerPage_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669725);
			UIRenderDevice.NativeMethodInfoPtr_get_breakBatches_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669726);
			UIRenderDevice.NativeMethodInfoPtr_set_breakBatches_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669727);
			UIRenderDevice.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669729);
			UIRenderDevice.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669730);
			UIRenderDevice.NativeMethodInfoPtr_get_defaultShaderInfoTexFloat_Internal_Static_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669731);
			UIRenderDevice.NativeMethodInfoPtr_get_defaultShaderInfoTexARGB8_Internal_Static_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669732);
			UIRenderDevice.NativeMethodInfoPtr_get_vertexTexturingIsAvailable_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669733);
			UIRenderDevice.NativeMethodInfoPtr_get_shaderModelIs35_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669734);
			UIRenderDevice.NativeMethodInfoPtr_InitVertexDeclaration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669735);
			UIRenderDevice.NativeMethodInfoPtr_CompleteCreation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669736);
			UIRenderDevice.NativeMethodInfoPtr_get_fullyCreated_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669737);
			UIRenderDevice.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669738);
			UIRenderDevice.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669739);
			UIRenderDevice.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669740);
			UIRenderDevice.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669741);
			UIRenderDevice.NativeMethodInfoPtr_Allocate_Public_MeshHandle_UInt32_UInt32_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669742);
			UIRenderDevice.NativeMethodInfoPtr_Update_Public_Void_MeshHandle_UInt32_byref_NativeSlice_1_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669743);
			UIRenderDevice.NativeMethodInfoPtr_Update_Public_Void_MeshHandle_UInt32_UInt32_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669744);
			UIRenderDevice.NativeMethodInfoPtr_UpdateCopyBackIndices_Private_Void_MeshHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669745);
			UIRenderDevice.NativeMethodInfoPtr_ActiveUpdatesForMeshHandle_Internal_List_1_AllocToUpdate_MeshHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669746);
			UIRenderDevice.NativeMethodInfoPtr_TryAllocFromPage_Private_Boolean_Page_UInt32_UInt32_byref_Alloc_byref_Alloc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669747);
			UIRenderDevice.NativeMethodInfoPtr_Allocate_Private_Void_MeshHandle_UInt32_UInt32_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669748);
			UIRenderDevice.NativeMethodInfoPtr_UpdateAfterGPUUsedData_Private_Void_MeshHandle_UInt32_UInt32_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_byref_UInt16_byref_AllocToUpdate_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669749);
			UIRenderDevice.NativeMethodInfoPtr_Free_Public_Void_MeshHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669750);
			UIRenderDevice.NativeMethodInfoPtr_OnFrameRenderingBegin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669751);
			UIRenderDevice.NativeMethodInfoPtr_PtrToSlice_Internal_Static_NativeSlice_1_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669752);
			UIRenderDevice.NativeMethodInfoPtr_ApplyDrawCommandState_Private_Void_RenderChainCommand_Int32_Material_Boolean_byref_EvaluationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669753);
			UIRenderDevice.NativeMethodInfoPtr_ApplyBatchState_Private_Void_byref_EvaluationState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669754);
			UIRenderDevice.NativeMethodInfoPtr_EvaluateChain_Public_Void_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_1_Transform3x4_NativeSlice_1_Vector4_MaterialPropertyBlock_Boolean_byref_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669755);
			UIRenderDevice.NativeMethodInfoPtr_UpdateFenceValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669756);
			UIRenderDevice.NativeMethodInfoPtr_KickRanges_Private_Void_ptr_DrawBufferRange_byref_Int32_byref_Int32_Int32_Page_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669757);
			UIRenderDevice.NativeMethodInfoPtr_DrawRanges_Private_Void_GPUBuffer_1_I_GPUBuffer_1_T_NativeSlice_1_DrawBufferRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669758);
			UIRenderDevice.NativeMethodInfoPtr_WaitOnCpuFence_Private_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669759);
			UIRenderDevice.NativeMethodInfoPtr_AdvanceFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669760);
			UIRenderDevice.NativeMethodInfoPtr_PruneUnusedPages_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669761);
			UIRenderDevice.NativeMethodInfoPtr_PrepareForGfxDeviceRecreate_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669762);
			UIRenderDevice.NativeMethodInfoPtr_WrapUpGfxDeviceRecreate_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669763);
			UIRenderDevice.NativeMethodInfoPtr_FlushAllPendingDeviceDisposes_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669764);
			UIRenderDevice.NativeMethodInfoPtr_GatherDrawStatistics_Internal_DrawStatistics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669765);
			UIRenderDevice.NativeMethodInfoPtr_ProcessDeviceFreeQueue_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669766);
			UIRenderDevice.NativeMethodInfoPtr_OnEngineUpdateGlobal_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669767);
			UIRenderDevice.NativeMethodInfoPtr_OnFlushPendingResources_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, 100669768);
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x000BB504 File Offset: 0x000B9704
		public unsafe uint maxVerticesPerPage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_get_maxVerticesPerPage_Internal_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06002B16 RID: 11030 RVA: 0x000BB540 File Offset: 0x000B9740
		// (set) Token: 0x06002B17 RID: 11031 RVA: 0x000BB57C File Offset: 0x000B977C
		public unsafe bool breakBatches
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_get_breakBatches_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_set_breakBatches_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000BB5BC File Offset: 0x000B97BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348326, XrefRangeEnd = 348327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIRenderDevice(uint initialVertexCapacity = 0U, uint initialIndexCapacity = 0U)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialVertexCapacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialIndexCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x000BB614 File Offset: 0x000B9814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348463, RefRangeEnd = 348465, XrefRangeStart = 348327, XrefRangeEnd = 348463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIRenderDevice(uint initialVertexCapacity, uint initialIndexCapacity, bool mockDevice)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialVertexCapacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialIndexCapacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mockDevice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002B1A RID: 11034 RVA: 0x000BB678 File Offset: 0x000B9878
		public unsafe static Texture2D defaultShaderInfoTexFloat
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348525, RefRangeEnd = 348526, XrefRangeStart = 348465, XrefRangeEnd = 348525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_get_defaultShaderInfoTexFloat_Internal_Static_get_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002B1B RID: 11035 RVA: 0x000BB6AC File Offset: 0x000B98AC
		public unsafe static Texture2D defaultShaderInfoTexARGB8
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348574, RefRangeEnd = 348575, XrefRangeStart = 348526, XrefRangeEnd = 348574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_get_defaultShaderInfoTexARGB8_Internal_Static_get_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06002B1C RID: 11036 RVA: 0x000BB6E0 File Offset: 0x000B98E0
		public unsafe static bool vertexTexturingIsAvailable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348611, RefRangeEnd = 348612, XrefRangeStart = 348575, XrefRangeEnd = 348611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_get_vertexTexturingIsAvailable_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06002B1D RID: 11037 RVA: 0x000BB710 File Offset: 0x000B9910
		public unsafe static bool shaderModelIs35
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348612, XrefRangeEnd = 348648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_get_shaderModelIs35_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x000BB740 File Offset: 0x000B9940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348666, RefRangeEnd = 348667, XrefRangeStart = 348648, XrefRangeEnd = 348666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitVertexDeclaration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_InitVertexDeclaration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x000BB774 File Offset: 0x000B9974
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348696, RefRangeEnd = 348698, XrefRangeStart = 348667, XrefRangeEnd = 348696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteCreation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_CompleteCreation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06002B20 RID: 11040 RVA: 0x000BB7A8 File Offset: 0x000B99A8
		public unsafe bool fullyCreated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_get_fullyCreated_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x000BB7E4 File Offset: 0x000B99E4
		// (set) Token: 0x06002B22 RID: 11042 RVA: 0x000BB820 File Offset: 0x000B9A20
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x000BB860 File Offset: 0x000B9A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348698, XrefRangeEnd = 348702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x000BB894 File Offset: 0x000B9A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348702, XrefRangeEnd = 348721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIRenderDevice.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x000BB8E0 File Offset: 0x000B9AE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 348725, RefRangeEnd = 348728, XrefRangeStart = 348721, XrefRangeEnd = 348725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexOffset;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_Allocate_Public_MeshHandle_UInt32_UInt32_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_byref_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			vertexData = ((intPtr5 == 0) ? null : new NativeSlice<Vertex>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			indexData = ((intPtr6 == 0) ? null : new NativeSlice<ushort>(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<MeshHandle>(intPtr7) : null;
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x000BB990 File Offset: 0x000B9B90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348743, RefRangeEnd = 348745, XrefRangeStart = 348728, XrefRangeEnd = 348743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<Vertex> vertexData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_Update_Public_Void_MeshHandle_UInt32_byref_NativeSlice_1_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			vertexData = ((intPtr4 == 0) ? null : new NativeSlice<Vertex>(intPtr4));
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x000BBA04 File Offset: 0x000B9C04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348753, RefRangeEnd = 348755, XrefRangeStart = 348745, XrefRangeEnd = 348753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexOffset;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_Update_Public_Void_MeshHandle_UInt32_UInt32_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_byref_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			vertexData = ((intPtr5 == 0) ? null : new NativeSlice<Vertex>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			indexData = ((intPtr6 == 0) ? null : new NativeSlice<ushort>(intPtr6));
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x000BBAB8 File Offset: 0x000B9CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348755, XrefRangeEnd = 348765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyBackIndices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_UpdateCopyBackIndices_Private_Void_MeshHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x000BBB08 File Offset: 0x000B9D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348765, XrefRangeEnd = 348770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<UIRenderDevice.AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_ActiveUpdatesForMeshHandle_Internal_List_1_AllocToUpdate_MeshHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<UIRenderDevice.AllocToUpdate>>(intPtr3) : null;
			}
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x000BBB58 File Offset: 0x000B9D58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348776, RefRangeEnd = 348778, XrefRangeStart = 348770, XrefRangeEnd = 348776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAllocFromPage(Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(page);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(va);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(ia);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shortLived;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_TryAllocFromPage_Private_Boolean_Page_UInt32_UInt32_byref_Alloc_byref_Alloc_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x000BBBF8 File Offset: 0x000B9DF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348844, RefRangeEnd = 348846, XrefRangeStart = 348778, XrefRangeEnd = 348844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, bool shortLived)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shortLived;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_Allocate_Private_Void_MeshHandle_UInt32_UInt32_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			vertexData = ((intPtr5 == 0) ? null : new NativeSlice<Vertex>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			indexData = ((intPtr6 == 0) ? null : new NativeSlice<ushort>(intPtr6));
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x000BBCAC File Offset: 0x000B9EAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348907, RefRangeEnd = 348909, XrefRangeStart = 348846, XrefRangeEnd = 348907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset, out UIRenderDevice.AllocToUpdate allocToUpdate, bool copyBackIndices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexOffset;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyBackIndices;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_UpdateAfterGPUUsedData_Private_Void_MeshHandle_UInt32_UInt32_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_byref_UInt16_byref_AllocToUpdate_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			vertexData = ((intPtr6 == 0) ? null : new NativeSlice<Vertex>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			indexData = ((intPtr7 == 0) ? null : new NativeSlice<ushort>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			allocToUpdate = ((intPtr8 == 0) ? null : new UIRenderDevice.AllocToUpdate(intPtr8));
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x000BBD94 File Offset: 0x000B9F94
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 348966, RefRangeEnd = 348973, XrefRangeStart = 348909, XrefRangeEnd = 348966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Free(MeshHandle mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_Free_Public_Void_MeshHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x000BBDD8 File Offset: 0x000B9FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348973, XrefRangeEnd = 348980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFrameRenderingBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_OnFrameRenderingBegin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x000BBE0C File Offset: 0x000BA00C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 348982, RefRangeEnd = 348985, XrefRangeStart = 348980, XrefRangeEnd = 348982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NativeSlice<T> PtrToSlice<T>(void* p, int count) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.MethodInfoStoreGeneric_PtrToSlice_Internal_Static_NativeSlice_1_T_ptr_Void_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeSlice<T>(intPtr);
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x000BBE54 File Offset: 0x000BA054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348985, XrefRangeEnd = 348997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, ref UIRenderDevice.EvaluationState st)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureSlot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newMat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMatDiffers;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(st);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_ApplyDrawCommandState_Private_Void_RenderChainCommand_Int32_Material_Boolean_byref_EvaluationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x000BBED8 File Offset: 0x000BA0D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 349014, RefRangeEnd = 349016, XrefRangeStart = 348997, XrefRangeEnd = 349014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyBatchState(ref UIRenderDevice.EvaluationState st, bool allowMaterialChange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowMaterialChange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_ApplyBatchState_Private_Void_byref_EvaluationState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x000BBF2C File Offset: 0x000BA12C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 349155, RefRangeEnd = 349157, XrefRangeStart = 349016, XrefRangeEnd = 349155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, NativeSlice<Transform3x4> transforms, NativeSlice<Vector4> clipRects, MaterialPropertyBlock stateMatProps, bool allowMaterialChange, ref Exception immediateException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(head);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initialMat);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultMat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gradientSettings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shaderInfo);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerPoint;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(transforms));
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(clipRects));
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateMatProps);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowMaterialChange;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(immediateException);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_EvaluateChain_Public_Void_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_1_Transform3x4_NativeSlice_1_Vector4_MaterialPropertyBlock_Boolean_byref_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			immediateException = ((intPtr4 == 0) ? null : new Exception(intPtr4));
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x000BC044 File Offset: 0x000BA244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349157, XrefRangeEnd = 349163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFenceValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_UpdateFenceValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x000BC078 File Offset: 0x000BA278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 349187, RefRangeEnd = 349189, XrefRangeStart = 349163, XrefRangeEnd = 349187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, Page curPage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ranges;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rangesReady;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rangesStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rangesCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(curPage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_KickRanges_Private_Void_ptr_DrawBufferRange_byref_Int32_byref_Int32_Int32_Page_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x000BC0F4 File Offset: 0x000BA2F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 349202, RefRangeEnd = 349205, XrefRangeStart = 349189, XrefRangeEnd = 349202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawRanges<I, T>(Utility.GPUBuffer<I> ib, Utility.GPUBuffer<T> vb, NativeSlice<DrawBufferRange> ranges) where I : new() where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ib);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vb);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ranges));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.MethodInfoStoreGeneric_DrawRanges_Private_Void_GPUBuffer_1_I_GPUBuffer_1_T_NativeSlice_1_DrawBufferRange_0<I, T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x000BC160 File Offset: 0x000BA360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349205, XrefRangeEnd = 349214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaitOnCpuFence(uint fence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fence;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_WaitOnCpuFence_Private_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x000BC1A0 File Offset: 0x000BA3A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 349309, RefRangeEnd = 349311, XrefRangeStart = 349214, XrefRangeEnd = 349309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdvanceFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_AdvanceFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x000BC1D4 File Offset: 0x000BA3D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349325, RefRangeEnd = 349326, XrefRangeStart = 349311, XrefRangeEnd = 349325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PruneUnusedPages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_PruneUnusedPages_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x000BC208 File Offset: 0x000BA408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349360, RefRangeEnd = 349361, XrefRangeStart = 349326, XrefRangeEnd = 349360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrepareForGfxDeviceRecreate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_PrepareForGfxDeviceRecreate_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x000BC230 File Offset: 0x000BA430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349365, RefRangeEnd = 349366, XrefRangeStart = 349361, XrefRangeEnd = 349365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WrapUpGfxDeviceRecreate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_WrapUpGfxDeviceRecreate_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x000BC258 File Offset: 0x000BA458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349366, XrefRangeEnd = 349375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FlushAllPendingDeviceDisposes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_FlushAllPendingDeviceDisposes_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x000BC280 File Offset: 0x000BA480
		[CallerCount(0)]
		public unsafe UIRenderDevice.DrawStatistics GatherDrawStatistics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_GatherDrawStatistics_Internal_DrawStatistics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x000BC2BC File Offset: 0x000BA4BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 349456, RefRangeEnd = 349461, XrefRangeStart = 349375, XrefRangeEnd = 349456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessDeviceFreeQueue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_ProcessDeviceFreeQueue_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x000BC2E4 File Offset: 0x000BA4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349461, XrefRangeEnd = 349465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnEngineUpdateGlobal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_OnEngineUpdateGlobal_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x000BC30C File Offset: 0x000BA50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349465, XrefRangeEnd = 349470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnFlushPendingResources()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.NativeMethodInfoPtr_OnFlushPendingResources_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x000115E9 File Offset: 0x0000F7E9
		public UIRenderDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06002B41 RID: 11073 RVA: 0x000BC334 File Offset: 0x000BA534
		// (set) Token: 0x06002B42 RID: 11074 RVA: 0x000115F2 File Offset: 0x0000F7F2
		public unsafe bool m_MockDevice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_MockDevice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_MockDevice)) = value;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06002B43 RID: 11075 RVA: 0x000BC35C File Offset: 0x000BA55C
		// (set) Token: 0x06002B44 RID: 11076 RVA: 0x0001160D File Offset: 0x0000F80D
		public unsafe IntPtr m_DefaultStencilState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_DefaultStencilState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_DefaultStencilState)) = value;
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06002B45 RID: 11077 RVA: 0x000BC384 File Offset: 0x000BA584
		// (set) Token: 0x06002B46 RID: 11078 RVA: 0x00011628 File Offset: 0x0000F828
		public unsafe IntPtr m_VertexDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_VertexDecl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_VertexDecl)) = value;
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x000BC3AC File Offset: 0x000BA5AC
		// (set) Token: 0x06002B48 RID: 11080 RVA: 0x00011643 File Offset: 0x0000F843
		public unsafe Page m_FirstPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_FirstPage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Page>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_FirstPage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06002B49 RID: 11081 RVA: 0x000BC3DC File Offset: 0x000BA5DC
		// (set) Token: 0x06002B4A RID: 11082 RVA: 0x00011662 File Offset: 0x0000F862
		public unsafe uint m_NextPageVertexCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_NextPageVertexCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_NextPageVertexCount)) = value;
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06002B4B RID: 11083 RVA: 0x000BC404 File Offset: 0x000BA604
		// (set) Token: 0x06002B4C RID: 11084 RVA: 0x0001167D File Offset: 0x0000F87D
		public unsafe uint m_LargeMeshVertexCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_LargeMeshVertexCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_LargeMeshVertexCount)) = value;
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06002B4D RID: 11085 RVA: 0x000BC42C File Offset: 0x000BA62C
		// (set) Token: 0x06002B4E RID: 11086 RVA: 0x00011698 File Offset: 0x0000F898
		public unsafe float m_IndexToVertexCountRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_IndexToVertexCountRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_IndexToVertexCountRatio)) = value;
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06002B4F RID: 11087 RVA: 0x000BC454 File Offset: 0x000BA654
		// (set) Token: 0x06002B50 RID: 11088 RVA: 0x000116B3 File Offset: 0x0000F8B3
		public unsafe List<List<UIRenderDevice.AllocToFree>> m_DeferredFrees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_DeferredFrees);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<List<UIRenderDevice.AllocToFree>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_DeferredFrees), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06002B51 RID: 11089 RVA: 0x000BC484 File Offset: 0x000BA684
		// (set) Token: 0x06002B52 RID: 11090 RVA: 0x000116D2 File Offset: 0x0000F8D2
		public unsafe List<List<UIRenderDevice.AllocToUpdate>> m_Updates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_Updates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<List<UIRenderDevice.AllocToUpdate>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_Updates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06002B53 RID: 11091 RVA: 0x000BC4B4 File Offset: 0x000BA6B4
		// (set) Token: 0x06002B54 RID: 11092 RVA: 0x000116F1 File Offset: 0x0000F8F1
		public unsafe Il2CppStructArray<uint> m_Fences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_Fences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_Fences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x000BC4E4 File Offset: 0x000BA6E4
		// (set) Token: 0x06002B56 RID: 11094 RVA: 0x00011710 File Offset: 0x0000F910
		public unsafe MaterialPropertyBlock m_StandardMatProps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_StandardMatProps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_StandardMatProps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x000BC514 File Offset: 0x000BA714
		// (set) Token: 0x06002B58 RID: 11096 RVA: 0x0001172F File Offset: 0x0000F92F
		public unsafe uint m_FrameIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_FrameIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_FrameIndex)) = value;
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x000BC53C File Offset: 0x000BA73C
		// (set) Token: 0x06002B5A RID: 11098 RVA: 0x0001174A File Offset: 0x0000F94A
		public unsafe uint m_NextUpdateID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_NextUpdateID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_NextUpdateID)) = value;
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06002B5B RID: 11099 RVA: 0x000BC564 File Offset: 0x000BA764
		// (set) Token: 0x06002B5C RID: 11100 RVA: 0x00011765 File Offset: 0x0000F965
		public unsafe UIRenderDevice.DrawStatistics m_DrawStats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_DrawStats);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_DrawStats)) = value;
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x000BC58C File Offset: 0x000BA78C
		// (set) Token: 0x06002B5E RID: 11102 RVA: 0x00011780 File Offset: 0x0000F980
		public unsafe LinkedPool<MeshHandle> m_MeshHandles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_MeshHandles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedPool<MeshHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_MeshHandles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06002B5F RID: 11103 RVA: 0x000BC5BC File Offset: 0x000BA7BC
		// (set) Token: 0x06002B60 RID: 11104 RVA: 0x0001179F File Offset: 0x0000F99F
		public unsafe DrawParams m_DrawParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_DrawParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawParams>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_DrawParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06002B61 RID: 11105 RVA: 0x000BC5EC File Offset: 0x000BA7EC
		// (set) Token: 0x06002B62 RID: 11106 RVA: 0x000117BE File Offset: 0x0000F9BE
		public unsafe TextureSlotManager m_TextureSlotManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_TextureSlotManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureSlotManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr_m_TextureSlotManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06002B63 RID: 11107 RVA: 0x000BC61C File Offset: 0x000BA81C
		// (set) Token: 0x06002B64 RID: 11108 RVA: 0x000117DD File Offset: 0x0000F9DD
		public unsafe static LinkedList<UIRenderDevice.DeviceToFree> m_DeviceFreeQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_m_DeviceFreeQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<UIRenderDevice.DeviceToFree>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_m_DeviceFreeQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x000BC644 File Offset: 0x000BA844
		// (set) Token: 0x06002B66 RID: 11110 RVA: 0x000117EF File Offset: 0x0000F9EF
		public unsafe static int m_ActiveDeviceCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_m_ActiveDeviceCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_m_ActiveDeviceCount, (void*)(&value));
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x000BC660 File Offset: 0x000BA860
		// (set) Token: 0x06002B68 RID: 11112 RVA: 0x000117FD File Offset: 0x0000F9FD
		public unsafe static bool m_SubscribedToNotifications
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_m_SubscribedToNotifications, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_m_SubscribedToNotifications, (void*)(&value));
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x000BC67C File Offset: 0x000BA87C
		// (set) Token: 0x06002B6A RID: 11114 RVA: 0x0001180B File Offset: 0x0000FA0B
		public unsafe static bool m_SynchronousFree
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_m_SynchronousFree, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_m_SynchronousFree, (void*)(&value));
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06002B6B RID: 11115 RVA: 0x000BC698 File Offset: 0x000BA898
		// (set) Token: 0x06002B6C RID: 11116 RVA: 0x00011819 File Offset: 0x0000FA19
		public unsafe static int s_GradientSettingsTexID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_s_GradientSettingsTexID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_s_GradientSettingsTexID, (void*)(&value));
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x000BC6B4 File Offset: 0x000BA8B4
		// (set) Token: 0x06002B6E RID: 11118 RVA: 0x00011827 File Offset: 0x0000FA27
		public unsafe static int s_ShaderInfoTexID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_s_ShaderInfoTexID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_s_ShaderInfoTexID, (void*)(&value));
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06002B6F RID: 11119 RVA: 0x000BC6D0 File Offset: 0x000BA8D0
		// (set) Token: 0x06002B70 RID: 11120 RVA: 0x00011835 File Offset: 0x0000FA35
		public unsafe static int s_TransformsPropID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_s_TransformsPropID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_s_TransformsPropID, (void*)(&value));
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06002B71 RID: 11121 RVA: 0x000BC6EC File Offset: 0x000BA8EC
		// (set) Token: 0x06002B72 RID: 11122 RVA: 0x00011843 File Offset: 0x0000FA43
		public unsafe static int s_ClipRectsPropID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_s_ClipRectsPropID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_s_ClipRectsPropID, (void*)(&value));
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06002B73 RID: 11123 RVA: 0x000BC708 File Offset: 0x000BA908
		// (set) Token: 0x06002B74 RID: 11124 RVA: 0x00011851 File Offset: 0x0000FA51
		public unsafe static ProfilerMarker s_MarkerAllocate
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_s_MarkerAllocate, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_s_MarkerAllocate, (void*)(&value));
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06002B75 RID: 11125 RVA: 0x000BC724 File Offset: 0x000BA924
		// (set) Token: 0x06002B76 RID: 11126 RVA: 0x0001185F File Offset: 0x0000FA5F
		public unsafe static ProfilerMarker s_MarkerFree
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_s_MarkerFree, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_s_MarkerFree, (void*)(&value));
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06002B77 RID: 11127 RVA: 0x000BC740 File Offset: 0x000BA940
		// (set) Token: 0x06002B78 RID: 11128 RVA: 0x0001186D File Offset: 0x0000FA6D
		public unsafe static ProfilerMarker s_MarkerAdvanceFrame
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_s_MarkerAdvanceFrame, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_s_MarkerAdvanceFrame, (void*)(&value));
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06002B79 RID: 11129 RVA: 0x000BC75C File Offset: 0x000BA95C
		// (set) Token: 0x06002B7A RID: 11130 RVA: 0x0001187B File Offset: 0x0000FA7B
		public unsafe static ProfilerMarker s_MarkerFence
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_s_MarkerFence, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_s_MarkerFence, (void*)(&value));
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06002B7B RID: 11131 RVA: 0x000BC778 File Offset: 0x000BA978
		// (set) Token: 0x06002B7C RID: 11132 RVA: 0x00011889 File Offset: 0x0000FA89
		public unsafe static ProfilerMarker s_MarkerBeforeDraw
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_s_MarkerBeforeDraw, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_s_MarkerBeforeDraw, (void*)(&value));
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06002B7D RID: 11133 RVA: 0x000BC794 File Offset: 0x000BA994
		// (set) Token: 0x06002B7E RID: 11134 RVA: 0x00011897 File Offset: 0x0000FA97
		public unsafe static Nullable<bool> s_VertexTexturingIsAvailable
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_s_VertexTexturingIsAvailable, intPtr);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_s_VertexTexturingIsAvailable, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x000BC7D0 File Offset: 0x000BA9D0
		// (set) Token: 0x06002B80 RID: 11136 RVA: 0x000118AE File Offset: 0x0000FAAE
		public unsafe static Nullable<bool> s_ShaderModelIs35
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_s_ShaderModelIs35, intPtr);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_s_ShaderModelIs35, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06002B81 RID: 11137 RVA: 0x000BC80C File Offset: 0x000BAA0C
		// (set) Token: 0x06002B82 RID: 11138 RVA: 0x000118C5 File Offset: 0x0000FAC5
		public unsafe uint _maxVerticesPerPage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr__maxVerticesPerPage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr__maxVerticesPerPage_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x000BC834 File Offset: 0x000BAA34
		// (set) Token: 0x06002B84 RID: 11140 RVA: 0x000118E0 File Offset: 0x0000FAE0
		public unsafe bool _breakBatches_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr__breakBatches_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr__breakBatches_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x000BC85C File Offset: 0x000BAA5C
		// (set) Token: 0x06002B86 RID: 11142 RVA: 0x000118FB File Offset: 0x0000FAFB
		public unsafe static Texture2D s_DefaultShaderInfoTexFloat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_s_DefaultShaderInfoTexFloat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_s_DefaultShaderInfoTexFloat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06002B87 RID: 11143 RVA: 0x000BC884 File Offset: 0x000BAA84
		// (set) Token: 0x06002B88 RID: 11144 RVA: 0x0001190D File Offset: 0x0000FB0D
		public unsafe static Texture2D s_DefaultShaderInfoTexARGB8
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.NativeFieldInfoPtr_s_DefaultShaderInfoTexARGB8, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.NativeFieldInfoPtr_s_DefaultShaderInfoTexARGB8, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06002B89 RID: 11145 RVA: 0x000BC8AC File Offset: 0x000BAAAC
		// (set) Token: 0x06002B8A RID: 11146 RVA: 0x0001191F File Offset: 0x0000FB1F
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x0001193A File Offset: 0x0000FB3A
		public void DisposeImmediate()
		{
			Debug.Assert(!UIRenderDevice.m_SynchronousFree);
			UIRenderDevice.m_SynchronousFree = true;
			this.Dispose();
			UIRenderDevice.m_SynchronousFree = false;
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x0001195E File Offset: 0x0000FB5E
		public void WaitOnAllCpuFences()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001EAE RID: 7854
		private static readonly IntPtr NativeFieldInfoPtr_m_MockDevice;

		// Token: 0x04001EAF RID: 7855
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultStencilState;

		// Token: 0x04001EB0 RID: 7856
		private static readonly IntPtr NativeFieldInfoPtr_m_VertexDecl;

		// Token: 0x04001EB1 RID: 7857
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstPage;

		// Token: 0x04001EB2 RID: 7858
		private static readonly IntPtr NativeFieldInfoPtr_m_NextPageVertexCount;

		// Token: 0x04001EB3 RID: 7859
		private static readonly IntPtr NativeFieldInfoPtr_m_LargeMeshVertexCount;

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeFieldInfoPtr_m_IndexToVertexCountRatio;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeFieldInfoPtr_m_DeferredFrees;

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeFieldInfoPtr_m_Updates;

		// Token: 0x04001EB7 RID: 7863
		private static readonly IntPtr NativeFieldInfoPtr_m_Fences;

		// Token: 0x04001EB8 RID: 7864
		private static readonly IntPtr NativeFieldInfoPtr_m_StandardMatProps;

		// Token: 0x04001EB9 RID: 7865
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameIndex;

		// Token: 0x04001EBA RID: 7866
		private static readonly IntPtr NativeFieldInfoPtr_m_NextUpdateID;

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawStats;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeFieldInfoPtr_m_MeshHandles;

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawParams;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeFieldInfoPtr_m_TextureSlotManager;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeFieldInfoPtr_m_DeviceFreeQueue;

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveDeviceCount;

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeFieldInfoPtr_m_SubscribedToNotifications;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeFieldInfoPtr_m_SynchronousFree;

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeFieldInfoPtr_s_GradientSettingsTexID;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeFieldInfoPtr_s_ShaderInfoTexID;

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeFieldInfoPtr_s_TransformsPropID;

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeFieldInfoPtr_s_ClipRectsPropID;

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerAllocate;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerFree;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerAdvanceFrame;

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerFence;

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerBeforeDraw;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeFieldInfoPtr_s_VertexTexturingIsAvailable;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeFieldInfoPtr_s_ShaderModelIs35;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeFieldInfoPtr__maxVerticesPerPage_k__BackingField;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeFieldInfoPtr__breakBatches_k__BackingField;

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultShaderInfoTexFloat;

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultShaderInfoTexARGB8;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeMethodInfoPtr_get_maxVerticesPerPage_Internal_get_UInt32_0;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeMethodInfoPtr_get_breakBatches_Internal_get_Boolean_0;

		// Token: 0x04001ED5 RID: 7893
		private static readonly IntPtr NativeMethodInfoPtr_set_breakBatches_Internal_set_Void_Boolean_0;

		// Token: 0x04001ED6 RID: 7894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0;

		// Token: 0x04001ED7 RID: 7895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_UInt32_Boolean_0;

		// Token: 0x04001ED8 RID: 7896
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultShaderInfoTexFloat_Internal_Static_get_Texture2D_0;

		// Token: 0x04001ED9 RID: 7897
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultShaderInfoTexARGB8_Internal_Static_get_Texture2D_0;

		// Token: 0x04001EDA RID: 7898
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexTexturingIsAvailable_Internal_Static_get_Boolean_0;

		// Token: 0x04001EDB RID: 7899
		private static readonly IntPtr NativeMethodInfoPtr_get_shaderModelIs35_Internal_Static_get_Boolean_0;

		// Token: 0x04001EDC RID: 7900
		private static readonly IntPtr NativeMethodInfoPtr_InitVertexDeclaration_Private_Void_0;

		// Token: 0x04001EDD RID: 7901
		private static readonly IntPtr NativeMethodInfoPtr_CompleteCreation_Private_Void_0;

		// Token: 0x04001EDE RID: 7902
		private static readonly IntPtr NativeMethodInfoPtr_get_fullyCreated_Private_get_Boolean_0;

		// Token: 0x04001EDF RID: 7903
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x04001EE0 RID: 7904
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x04001EE1 RID: 7905
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001EE2 RID: 7906
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001EE3 RID: 7907
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Public_MeshHandle_UInt32_UInt32_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_byref_UInt16_0;

		// Token: 0x04001EE4 RID: 7908
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_MeshHandle_UInt32_byref_NativeSlice_1_Vertex_0;

		// Token: 0x04001EE5 RID: 7909
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_MeshHandle_UInt32_UInt32_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_byref_UInt16_0;

		// Token: 0x04001EE6 RID: 7910
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCopyBackIndices_Private_Void_MeshHandle_Boolean_0;

		// Token: 0x04001EE7 RID: 7911
		private static readonly IntPtr NativeMethodInfoPtr_ActiveUpdatesForMeshHandle_Internal_List_1_AllocToUpdate_MeshHandle_0;

		// Token: 0x04001EE8 RID: 7912
		private static readonly IntPtr NativeMethodInfoPtr_TryAllocFromPage_Private_Boolean_Page_UInt32_UInt32_byref_Alloc_byref_Alloc_Boolean_0;

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Private_Void_MeshHandle_UInt32_UInt32_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_Boolean_0;

		// Token: 0x04001EEA RID: 7914
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAfterGPUUsedData_Private_Void_MeshHandle_UInt32_UInt32_byref_NativeSlice_1_Vertex_byref_NativeSlice_1_UInt16_byref_UInt16_byref_AllocToUpdate_Boolean_0;

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Void_MeshHandle_0;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeMethodInfoPtr_OnFrameRenderingBegin_Public_Void_0;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeMethodInfoPtr_PtrToSlice_Internal_Static_NativeSlice_1_T_ptr_Void_Int32_0;

		// Token: 0x04001EEE RID: 7918
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDrawCommandState_Private_Void_RenderChainCommand_Int32_Material_Boolean_byref_EvaluationState_0;

		// Token: 0x04001EEF RID: 7919
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBatchState_Private_Void_byref_EvaluationState_Boolean_0;

		// Token: 0x04001EF0 RID: 7920
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateChain_Public_Void_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_1_Transform3x4_NativeSlice_1_Vector4_MaterialPropertyBlock_Boolean_byref_Exception_0;

		// Token: 0x04001EF1 RID: 7921
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFenceValue_Private_Void_0;

		// Token: 0x04001EF2 RID: 7922
		private static readonly IntPtr NativeMethodInfoPtr_KickRanges_Private_Void_ptr_DrawBufferRange_byref_Int32_byref_Int32_Int32_Page_0;

		// Token: 0x04001EF3 RID: 7923
		private static readonly IntPtr NativeMethodInfoPtr_DrawRanges_Private_Void_GPUBuffer_1_I_GPUBuffer_1_T_NativeSlice_1_DrawBufferRange_0;

		// Token: 0x04001EF4 RID: 7924
		private static readonly IntPtr NativeMethodInfoPtr_WaitOnCpuFence_Private_Void_UInt32_0;

		// Token: 0x04001EF5 RID: 7925
		private static readonly IntPtr NativeMethodInfoPtr_AdvanceFrame_Public_Void_0;

		// Token: 0x04001EF6 RID: 7926
		private static readonly IntPtr NativeMethodInfoPtr_PruneUnusedPages_Private_Void_0;

		// Token: 0x04001EF7 RID: 7927
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForGfxDeviceRecreate_Internal_Static_Void_0;

		// Token: 0x04001EF8 RID: 7928
		private static readonly IntPtr NativeMethodInfoPtr_WrapUpGfxDeviceRecreate_Internal_Static_Void_0;

		// Token: 0x04001EF9 RID: 7929
		private static readonly IntPtr NativeMethodInfoPtr_FlushAllPendingDeviceDisposes_Internal_Static_Void_0;

		// Token: 0x04001EFA RID: 7930
		private static readonly IntPtr NativeMethodInfoPtr_GatherDrawStatistics_Internal_DrawStatistics_0;

		// Token: 0x04001EFB RID: 7931
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDeviceFreeQueue_Public_Static_Void_0;

		// Token: 0x04001EFC RID: 7932
		private static readonly IntPtr NativeMethodInfoPtr_OnEngineUpdateGlobal_Private_Static_Void_0;

		// Token: 0x04001EFD RID: 7933
		private static readonly IntPtr NativeMethodInfoPtr_OnFlushPendingResources_Private_Static_Void_0;

		// Token: 0x04001EFE RID: 7934
		public const uint k_MaxQueuedFrameCount = 4U;

		// Token: 0x04001EFF RID: 7935
		public const int k_PruneEmptyPageFrameCount = 60;

		// Token: 0x04001F00 RID: 7936
		public const string k_VertexTexturingIsAvailableTag = "UIE_VertexTexturingIsAvailable";

		// Token: 0x04001F01 RID: 7937
		public const string k_VertexTexturingIsAvailableTrue = "1";

		// Token: 0x04001F02 RID: 7938
		public const string k_ShaderModelIs35Tag = "UIE_ShaderModelIs35";

		// Token: 0x04001F03 RID: 7939
		public const string k_ShaderModelIs35True = "1";

		// Token: 0x02000543 RID: 1347
		public sealed class AllocToUpdate : ValueType
		{
			// Token: 0x060040F0 RID: 16624 RVA: 0x001010AC File Offset: 0x000FF2AC
			// Note: this type is marked as 'beforefieldinit'.
			static AllocToUpdate()
			{
				Il2CppClassPointerStore<UIRenderDevice.AllocToUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "AllocToUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRenderDevice.AllocToUpdate>.NativeClassPtr);
				UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.AllocToUpdate>.NativeClassPtr, "id");
				UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_allocTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.AllocToUpdate>.NativeClassPtr, "allocTime");
				UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_meshHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.AllocToUpdate>.NativeClassPtr, "meshHandle");
				UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_permAllocVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.AllocToUpdate>.NativeClassPtr, "permAllocVerts");
				UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_permAllocIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.AllocToUpdate>.NativeClassPtr, "permAllocIndices");
				UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_permPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.AllocToUpdate>.NativeClassPtr, "permPage");
				UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_copyBackIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.AllocToUpdate>.NativeClassPtr, "copyBackIndices");
			}

			// Token: 0x060040F1 RID: 16625 RVA: 0x0001B5EA File Offset: 0x000197EA
			public AllocToUpdate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060040F2 RID: 16626 RVA: 0x0001B5F3 File Offset: 0x000197F3
			public AllocToUpdate()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRenderDevice.AllocToUpdate>.NativeClassPtr))
			{
			}

			// Token: 0x17001370 RID: 4976
			// (get) Token: 0x060040F3 RID: 16627 RVA: 0x00101164 File Offset: 0x000FF364
			// (set) Token: 0x060040F4 RID: 16628 RVA: 0x0001B605 File Offset: 0x00019805
			public unsafe uint id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17001371 RID: 4977
			// (get) Token: 0x060040F5 RID: 16629 RVA: 0x0010118C File Offset: 0x000FF38C
			// (set) Token: 0x060040F6 RID: 16630 RVA: 0x0001B620 File Offset: 0x00019820
			public unsafe uint allocTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_allocTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_allocTime)) = value;
				}
			}

			// Token: 0x17001372 RID: 4978
			// (get) Token: 0x060040F7 RID: 16631 RVA: 0x001011B4 File Offset: 0x000FF3B4
			// (set) Token: 0x060040F8 RID: 16632 RVA: 0x0001B63B File Offset: 0x0001983B
			public unsafe MeshHandle meshHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_meshHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_meshHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001373 RID: 4979
			// (get) Token: 0x060040F9 RID: 16633 RVA: 0x001011E4 File Offset: 0x000FF3E4
			// (set) Token: 0x060040FA RID: 16634 RVA: 0x0001B65A File Offset: 0x0001985A
			public Alloc permAllocVerts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_permAllocVerts);
					return new Alloc(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Alloc>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_permAllocVerts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Alloc>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001374 RID: 4980
			// (get) Token: 0x060040FB RID: 16635 RVA: 0x00101214 File Offset: 0x000FF414
			// (set) Token: 0x060040FC RID: 16636 RVA: 0x0001B688 File Offset: 0x00019888
			public Alloc permAllocIndices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_permAllocIndices);
					return new Alloc(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Alloc>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_permAllocIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Alloc>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001375 RID: 4981
			// (get) Token: 0x060040FD RID: 16637 RVA: 0x00101244 File Offset: 0x000FF444
			// (set) Token: 0x060040FE RID: 16638 RVA: 0x0001B6B6 File Offset: 0x000198B6
			public unsafe Page permPage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_permPage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Page>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_permPage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001376 RID: 4982
			// (get) Token: 0x060040FF RID: 16639 RVA: 0x00101274 File Offset: 0x000FF474
			// (set) Token: 0x06004100 RID: 16640 RVA: 0x0001B6D5 File Offset: 0x000198D5
			public unsafe bool copyBackIndices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_copyBackIndices);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToUpdate.NativeFieldInfoPtr_copyBackIndices)) = value;
				}
			}

			// Token: 0x04002DB0 RID: 11696
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04002DB1 RID: 11697
			private static readonly IntPtr NativeFieldInfoPtr_allocTime;

			// Token: 0x04002DB2 RID: 11698
			private static readonly IntPtr NativeFieldInfoPtr_meshHandle;

			// Token: 0x04002DB3 RID: 11699
			private static readonly IntPtr NativeFieldInfoPtr_permAllocVerts;

			// Token: 0x04002DB4 RID: 11700
			private static readonly IntPtr NativeFieldInfoPtr_permAllocIndices;

			// Token: 0x04002DB5 RID: 11701
			private static readonly IntPtr NativeFieldInfoPtr_permPage;

			// Token: 0x04002DB6 RID: 11702
			private static readonly IntPtr NativeFieldInfoPtr_copyBackIndices;
		}

		// Token: 0x02000544 RID: 1348
		public sealed class AllocToFree : ValueType
		{
			// Token: 0x06004101 RID: 16641 RVA: 0x0010129C File Offset: 0x000FF49C
			// Note: this type is marked as 'beforefieldinit'.
			static AllocToFree()
			{
				Il2CppClassPointerStore<UIRenderDevice.AllocToFree>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "AllocToFree");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRenderDevice.AllocToFree>.NativeClassPtr);
				UIRenderDevice.AllocToFree.NativeFieldInfoPtr_alloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.AllocToFree>.NativeClassPtr, "alloc");
				UIRenderDevice.AllocToFree.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.AllocToFree>.NativeClassPtr, "page");
				UIRenderDevice.AllocToFree.NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.AllocToFree>.NativeClassPtr, "vertices");
			}

			// Token: 0x06004102 RID: 16642 RVA: 0x0001B6F0 File Offset: 0x000198F0
			public AllocToFree(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004103 RID: 16643 RVA: 0x0001B6F9 File Offset: 0x000198F9
			public AllocToFree()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRenderDevice.AllocToFree>.NativeClassPtr))
			{
			}

			// Token: 0x17001377 RID: 4983
			// (get) Token: 0x06004104 RID: 16644 RVA: 0x00101304 File Offset: 0x000FF504
			// (set) Token: 0x06004105 RID: 16645 RVA: 0x0001B70B File Offset: 0x0001990B
			public Alloc alloc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToFree.NativeFieldInfoPtr_alloc);
					return new Alloc(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Alloc>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToFree.NativeFieldInfoPtr_alloc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Alloc>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001378 RID: 4984
			// (get) Token: 0x06004106 RID: 16646 RVA: 0x00101334 File Offset: 0x000FF534
			// (set) Token: 0x06004107 RID: 16647 RVA: 0x0001B739 File Offset: 0x00019939
			public unsafe Page page
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToFree.NativeFieldInfoPtr_page);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Page>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToFree.NativeFieldInfoPtr_page), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001379 RID: 4985
			// (get) Token: 0x06004108 RID: 16648 RVA: 0x00101364 File Offset: 0x000FF564
			// (set) Token: 0x06004109 RID: 16649 RVA: 0x0001B758 File Offset: 0x00019958
			public unsafe bool vertices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToFree.NativeFieldInfoPtr_vertices);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.AllocToFree.NativeFieldInfoPtr_vertices)) = value;
				}
			}

			// Token: 0x04002DB7 RID: 11703
			private static readonly IntPtr NativeFieldInfoPtr_alloc;

			// Token: 0x04002DB8 RID: 11704
			private static readonly IntPtr NativeFieldInfoPtr_page;

			// Token: 0x04002DB9 RID: 11705
			private static readonly IntPtr NativeFieldInfoPtr_vertices;
		}

		// Token: 0x02000545 RID: 1349
		public sealed class DeviceToFree : ValueType
		{
			// Token: 0x0600410A RID: 16650 RVA: 0x0010138C File Offset: 0x000FF58C
			// Note: this type is marked as 'beforefieldinit'.
			static DeviceToFree()
			{
				Il2CppClassPointerStore<UIRenderDevice.DeviceToFree>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "DeviceToFree");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRenderDevice.DeviceToFree>.NativeClassPtr);
				UIRenderDevice.DeviceToFree.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.DeviceToFree>.NativeClassPtr, "handle");
				UIRenderDevice.DeviceToFree.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.DeviceToFree>.NativeClassPtr, "page");
				UIRenderDevice.DeviceToFree.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice.DeviceToFree>.NativeClassPtr, 100669769);
			}

			// Token: 0x0600410B RID: 16651 RVA: 0x001013F4 File Offset: 0x000FF5F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348319, RefRangeEnd = 348320, XrefRangeStart = 348314, XrefRangeEnd = 348319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.DeviceToFree.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600410C RID: 16652 RVA: 0x0001B773 File Offset: 0x00019973
			public DeviceToFree(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600410D RID: 16653 RVA: 0x0001B77C File Offset: 0x0001997C
			public DeviceToFree()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRenderDevice.DeviceToFree>.NativeClassPtr))
			{
			}

			// Token: 0x1700137A RID: 4986
			// (get) Token: 0x0600410E RID: 16654 RVA: 0x0010142C File Offset: 0x000FF62C
			// (set) Token: 0x0600410F RID: 16655 RVA: 0x0001B78E File Offset: 0x0001998E
			public unsafe uint handle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.DeviceToFree.NativeFieldInfoPtr_handle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.DeviceToFree.NativeFieldInfoPtr_handle)) = value;
				}
			}

			// Token: 0x1700137B RID: 4987
			// (get) Token: 0x06004110 RID: 16656 RVA: 0x00101454 File Offset: 0x000FF654
			// (set) Token: 0x06004111 RID: 16657 RVA: 0x0001B7A9 File Offset: 0x000199A9
			public unsafe Page page
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.DeviceToFree.NativeFieldInfoPtr_page);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Page>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.DeviceToFree.NativeFieldInfoPtr_page), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002DBA RID: 11706
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x04002DBB RID: 11707
			private static readonly IntPtr NativeFieldInfoPtr_page;

			// Token: 0x04002DBC RID: 11708
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
		}

		// Token: 0x02000546 RID: 1350
		public sealed class EvaluationState : ValueType
		{
			// Token: 0x06004112 RID: 16658 RVA: 0x00101484 File Offset: 0x000FF684
			// Note: this type is marked as 'beforefieldinit'.
			static EvaluationState()
			{
				Il2CppClassPointerStore<UIRenderDevice.EvaluationState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "EvaluationState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRenderDevice.EvaluationState>.NativeClassPtr);
				UIRenderDevice.EvaluationState.NativeFieldInfoPtr_stateMatProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.EvaluationState>.NativeClassPtr, "stateMatProps");
				UIRenderDevice.EvaluationState.NativeFieldInfoPtr_defaultMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.EvaluationState>.NativeClassPtr, "defaultMat");
				UIRenderDevice.EvaluationState.NativeFieldInfoPtr_curState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.EvaluationState>.NativeClassPtr, "curState");
				UIRenderDevice.EvaluationState.NativeFieldInfoPtr_curPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.EvaluationState>.NativeClassPtr, "curPage");
				UIRenderDevice.EvaluationState.NativeFieldInfoPtr_mustApplyMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.EvaluationState>.NativeClassPtr, "mustApplyMaterial");
				UIRenderDevice.EvaluationState.NativeFieldInfoPtr_mustApplyCommonBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.EvaluationState>.NativeClassPtr, "mustApplyCommonBlock");
				UIRenderDevice.EvaluationState.NativeFieldInfoPtr_mustApplyStateBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.EvaluationState>.NativeClassPtr, "mustApplyStateBlock");
				UIRenderDevice.EvaluationState.NativeFieldInfoPtr_mustApplyStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.EvaluationState>.NativeClassPtr, "mustApplyStencil");
			}

			// Token: 0x06004113 RID: 16659 RVA: 0x0001B7C8 File Offset: 0x000199C8
			public EvaluationState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004114 RID: 16660 RVA: 0x0001B7D1 File Offset: 0x000199D1
			public EvaluationState()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRenderDevice.EvaluationState>.NativeClassPtr))
			{
			}

			// Token: 0x1700137C RID: 4988
			// (get) Token: 0x06004115 RID: 16661 RVA: 0x00101550 File Offset: 0x000FF750
			// (set) Token: 0x06004116 RID: 16662 RVA: 0x0001B7E3 File Offset: 0x000199E3
			public unsafe MaterialPropertyBlock stateMatProps
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_stateMatProps);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_stateMatProps), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700137D RID: 4989
			// (get) Token: 0x06004117 RID: 16663 RVA: 0x00101580 File Offset: 0x000FF780
			// (set) Token: 0x06004118 RID: 16664 RVA: 0x0001B802 File Offset: 0x00019A02
			public unsafe Material defaultMat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_defaultMat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_defaultMat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700137E RID: 4990
			// (get) Token: 0x06004119 RID: 16665 RVA: 0x001015B0 File Offset: 0x000FF7B0
			// (set) Token: 0x0600411A RID: 16666 RVA: 0x0001B821 File Offset: 0x00019A21
			public State curState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_curState);
					return new State(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<State>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_curState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<State>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700137F RID: 4991
			// (get) Token: 0x0600411B RID: 16667 RVA: 0x001015E0 File Offset: 0x000FF7E0
			// (set) Token: 0x0600411C RID: 16668 RVA: 0x0001B84F File Offset: 0x00019A4F
			public unsafe Page curPage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_curPage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Page>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_curPage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001380 RID: 4992
			// (get) Token: 0x0600411D RID: 16669 RVA: 0x00101610 File Offset: 0x000FF810
			// (set) Token: 0x0600411E RID: 16670 RVA: 0x0001B86E File Offset: 0x00019A6E
			public unsafe bool mustApplyMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_mustApplyMaterial);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_mustApplyMaterial)) = value;
				}
			}

			// Token: 0x17001381 RID: 4993
			// (get) Token: 0x0600411F RID: 16671 RVA: 0x00101638 File Offset: 0x000FF838
			// (set) Token: 0x06004120 RID: 16672 RVA: 0x0001B889 File Offset: 0x00019A89
			public unsafe bool mustApplyCommonBlock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_mustApplyCommonBlock);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_mustApplyCommonBlock)) = value;
				}
			}

			// Token: 0x17001382 RID: 4994
			// (get) Token: 0x06004121 RID: 16673 RVA: 0x00101660 File Offset: 0x000FF860
			// (set) Token: 0x06004122 RID: 16674 RVA: 0x0001B8A4 File Offset: 0x00019AA4
			public unsafe bool mustApplyStateBlock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_mustApplyStateBlock);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_mustApplyStateBlock)) = value;
				}
			}

			// Token: 0x17001383 RID: 4995
			// (get) Token: 0x06004123 RID: 16675 RVA: 0x00101688 File Offset: 0x000FF888
			// (set) Token: 0x06004124 RID: 16676 RVA: 0x0001B8BF File Offset: 0x00019ABF
			public unsafe bool mustApplyStencil
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_mustApplyStencil);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRenderDevice.EvaluationState.NativeFieldInfoPtr_mustApplyStencil)) = value;
				}
			}

			// Token: 0x04002DBD RID: 11709
			private static readonly IntPtr NativeFieldInfoPtr_stateMatProps;

			// Token: 0x04002DBE RID: 11710
			private static readonly IntPtr NativeFieldInfoPtr_defaultMat;

			// Token: 0x04002DBF RID: 11711
			private static readonly IntPtr NativeFieldInfoPtr_curState;

			// Token: 0x04002DC0 RID: 11712
			private static readonly IntPtr NativeFieldInfoPtr_curPage;

			// Token: 0x04002DC1 RID: 11713
			private static readonly IntPtr NativeFieldInfoPtr_mustApplyMaterial;

			// Token: 0x04002DC2 RID: 11714
			private static readonly IntPtr NativeFieldInfoPtr_mustApplyCommonBlock;

			// Token: 0x04002DC3 RID: 11715
			private static readonly IntPtr NativeFieldInfoPtr_mustApplyStateBlock;

			// Token: 0x04002DC4 RID: 11716
			private static readonly IntPtr NativeFieldInfoPtr_mustApplyStencil;
		}

		// Token: 0x02000547 RID: 1351
		[StructLayout(2)]
		public struct DrawStatistics
		{
			// Token: 0x06004125 RID: 16677 RVA: 0x001016B0 File Offset: 0x000FF8B0
			// Note: this type is marked as 'beforefieldinit'.
			static DrawStatistics()
			{
				Il2CppClassPointerStore<UIRenderDevice.DrawStatistics>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "DrawStatistics");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRenderDevice.DrawStatistics>.NativeClassPtr);
				UIRenderDevice.DrawStatistics.NativeFieldInfoPtr_currentFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.DrawStatistics>.NativeClassPtr, "currentFrameIndex");
				UIRenderDevice.DrawStatistics.NativeFieldInfoPtr_totalIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.DrawStatistics>.NativeClassPtr, "totalIndices");
				UIRenderDevice.DrawStatistics.NativeFieldInfoPtr_commandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.DrawStatistics>.NativeClassPtr, "commandCount");
				UIRenderDevice.DrawStatistics.NativeFieldInfoPtr_drawCommandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.DrawStatistics>.NativeClassPtr, "drawCommandCount");
				UIRenderDevice.DrawStatistics.NativeFieldInfoPtr_materialSetCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.DrawStatistics>.NativeClassPtr, "materialSetCount");
				UIRenderDevice.DrawStatistics.NativeFieldInfoPtr_drawRangeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.DrawStatistics>.NativeClassPtr, "drawRangeCount");
				UIRenderDevice.DrawStatistics.NativeFieldInfoPtr_drawRangeCallCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.DrawStatistics>.NativeClassPtr, "drawRangeCallCount");
				UIRenderDevice.DrawStatistics.NativeFieldInfoPtr_immediateDraws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.DrawStatistics>.NativeClassPtr, "immediateDraws");
				UIRenderDevice.DrawStatistics.NativeFieldInfoPtr_stencilRefChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.DrawStatistics>.NativeClassPtr, "stencilRefChanges");
			}

			// Token: 0x06004126 RID: 16678 RVA: 0x0001B8DA File Offset: 0x00019ADA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIRenderDevice.DrawStatistics>.NativeClassPtr, ref this));
			}

			// Token: 0x04002DC5 RID: 11717
			private static readonly IntPtr NativeFieldInfoPtr_currentFrameIndex;

			// Token: 0x04002DC6 RID: 11718
			private static readonly IntPtr NativeFieldInfoPtr_totalIndices;

			// Token: 0x04002DC7 RID: 11719
			private static readonly IntPtr NativeFieldInfoPtr_commandCount;

			// Token: 0x04002DC8 RID: 11720
			private static readonly IntPtr NativeFieldInfoPtr_drawCommandCount;

			// Token: 0x04002DC9 RID: 11721
			private static readonly IntPtr NativeFieldInfoPtr_materialSetCount;

			// Token: 0x04002DCA RID: 11722
			private static readonly IntPtr NativeFieldInfoPtr_drawRangeCount;

			// Token: 0x04002DCB RID: 11723
			private static readonly IntPtr NativeFieldInfoPtr_drawRangeCallCount;

			// Token: 0x04002DCC RID: 11724
			private static readonly IntPtr NativeFieldInfoPtr_immediateDraws;

			// Token: 0x04002DCD RID: 11725
			private static readonly IntPtr NativeFieldInfoPtr_stencilRefChanges;

			// Token: 0x04002DCE RID: 11726
			[FieldOffset(0)]
			public int currentFrameIndex;

			// Token: 0x04002DCF RID: 11727
			[FieldOffset(4)]
			public uint totalIndices;

			// Token: 0x04002DD0 RID: 11728
			[FieldOffset(8)]
			public uint commandCount;

			// Token: 0x04002DD1 RID: 11729
			[FieldOffset(12)]
			public uint drawCommandCount;

			// Token: 0x04002DD2 RID: 11730
			[FieldOffset(16)]
			public uint materialSetCount;

			// Token: 0x04002DD3 RID: 11731
			[FieldOffset(20)]
			public uint drawRangeCount;

			// Token: 0x04002DD4 RID: 11732
			[FieldOffset(24)]
			public uint drawRangeCallCount;

			// Token: 0x04002DD5 RID: 11733
			[FieldOffset(28)]
			public uint immediateDraws;

			// Token: 0x04002DD6 RID: 11734
			[FieldOffset(32)]
			public uint stencilRefChanges;
		}

		// Token: 0x02000548 RID: 1352
		[ObfuscatedName("UnityEngine.UIElements.UIR.UIRenderDevice+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004127 RID: 16679 RVA: 0x00101790 File Offset: 0x000FF990
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UIRenderDevice.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRenderDevice.__c>.NativeClassPtr);
				UIRenderDevice.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.__c>.NativeClassPtr, "<>9");
				UIRenderDevice.__c.NativeFieldInfoPtr___9__50_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.__c>.NativeClassPtr, "<>9__50_0");
				UIRenderDevice.__c.NativeFieldInfoPtr___9__50_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderDevice.__c>.NativeClassPtr, "<>9__50_1");
				UIRenderDevice.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice.__c>.NativeClassPtr, 100669771);
				UIRenderDevice.__c.NativeMethodInfoPtr___ctor_b__50_0_Internal_MeshHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice.__c>.NativeClassPtr, 100669772);
				UIRenderDevice.__c.NativeMethodInfoPtr___ctor_b__50_1_Internal_Void_MeshHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderDevice.__c>.NativeClassPtr, 100669773);
			}

			// Token: 0x06004128 RID: 16680 RVA: 0x00101834 File Offset: 0x000FFA34
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRenderDevice.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004129 RID: 16681 RVA: 0x00101870 File Offset: 0x000FFA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348320, XrefRangeEnd = 348326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshHandle __ctor_b__50_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.__c.NativeMethodInfoPtr___ctor_b__50_0_Internal_MeshHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshHandle>(intPtr3) : null;
			}

			// Token: 0x0600412A RID: 16682 RVA: 0x001018B0 File Offset: 0x000FFAB0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__50_1(MeshHandle mh)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mh);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRenderDevice.__c.NativeMethodInfoPtr___ctor_b__50_1_Internal_Void_MeshHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600412B RID: 16683 RVA: 0x0001B8EC File Offset: 0x00019AEC
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001384 RID: 4996
			// (get) Token: 0x0600412C RID: 16684 RVA: 0x001018F4 File Offset: 0x000FFAF4
			// (set) Token: 0x0600412D RID: 16685 RVA: 0x0001B8F5 File Offset: 0x00019AF5
			public unsafe static UIRenderDevice.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIRenderDevice.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001385 RID: 4997
			// (get) Token: 0x0600412E RID: 16686 RVA: 0x0010191C File Offset: 0x000FFB1C
			// (set) Token: 0x0600412F RID: 16687 RVA: 0x0001B907 File Offset: 0x00019B07
			public unsafe static Func<MeshHandle> __9__50_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.__c.NativeFieldInfoPtr___9__50_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MeshHandle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.__c.NativeFieldInfoPtr___9__50_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001386 RID: 4998
			// (get) Token: 0x06004130 RID: 16688 RVA: 0x00101944 File Offset: 0x000FFB44
			// (set) Token: 0x06004131 RID: 16689 RVA: 0x0001B919 File Offset: 0x00019B19
			public unsafe static Action<MeshHandle> __9__50_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIRenderDevice.__c.NativeFieldInfoPtr___9__50_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MeshHandle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIRenderDevice.__c.NativeFieldInfoPtr___9__50_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002DD7 RID: 11735
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002DD8 RID: 11736
			private static readonly IntPtr NativeFieldInfoPtr___9__50_0;

			// Token: 0x04002DD9 RID: 11737
			private static readonly IntPtr NativeFieldInfoPtr___9__50_1;

			// Token: 0x04002DDA RID: 11738
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002DDB RID: 11739
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__50_0_Internal_MeshHandle_0;

			// Token: 0x04002DDC RID: 11740
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__50_1_Internal_Void_MeshHandle_0;
		}

		// Token: 0x02000549 RID: 1353
		private sealed class MethodInfoStoreGeneric_PtrToSlice_Internal_Static_NativeSlice_1_T_ptr_Void_Int32_0<T>
		{
			// Token: 0x04002DDD RID: 11741
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UIRenderDevice.NativeMethodInfoPtr_PtrToSlice_Internal_Static_NativeSlice_1_T_ptr_Void_Int32_0, Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200054A RID: 1354
		private sealed class MethodInfoStoreGeneric_DrawRanges_Private_Void_GPUBuffer_1_I_GPUBuffer_1_T_NativeSlice_1_DrawBufferRange_0<I, T>
		{
			// Token: 0x04002DDE RID: 11742
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UIRenderDevice.NativeMethodInfoPtr_DrawRanges_Private_Void_GPUBuffer_1_I_GPUBuffer_1_T_NativeSlice_1_DrawBufferRange_0, Il2CppClassPointerStore<UIRenderDevice>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<I>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200054B RID: 1355
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
