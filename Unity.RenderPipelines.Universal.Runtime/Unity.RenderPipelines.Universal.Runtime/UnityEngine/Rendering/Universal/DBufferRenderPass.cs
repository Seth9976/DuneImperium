using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000061 RID: 97
	public class DBufferRenderPass : ScriptableRenderPass
	{
		// Token: 0x0600085D RID: 2141 RVA: 0x000325E0 File Offset: 0x000307E0
		// Note: this type is marked as 'beforefieldinit'.
		static DBufferRenderPass()
		{
			Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DBufferRenderPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr);
			DBufferRenderPass.NativeFieldInfoPtr_s_DBufferNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, "s_DBufferNames");
			DBufferRenderPass.NativeFieldInfoPtr_s_DBufferDepthName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, "s_DBufferDepthName");
			DBufferRenderPass.NativeFieldInfoPtr_m_DrawSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, "m_DrawSystem");
			DBufferRenderPass.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, "m_Settings");
			DBufferRenderPass.NativeFieldInfoPtr_m_DBufferClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, "m_DBufferClear");
			DBufferRenderPass.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, "m_FilteringSettings");
			DBufferRenderPass.NativeFieldInfoPtr_m_ShaderTagIdList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, "m_ShaderTagIdList");
			DBufferRenderPass.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, "m_ProfilingSampler");
			DBufferRenderPass.NativeFieldInfoPtr_m_DBufferClearSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, "m_DBufferClearSampler");
			DBufferRenderPass.NativeFieldInfoPtr_m_DecalLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, "m_DecalLayers");
			DBufferRenderPass.NativeFieldInfoPtr_m_DBufferDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, "m_DBufferDepth");
			DBufferRenderPass.NativeFieldInfoPtr__dBufferColorHandles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, "<dBufferColorHandles>k__BackingField");
			DBufferRenderPass.NativeFieldInfoPtr__depthHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, "<depthHandle>k__BackingField");
			DBufferRenderPass.NativeMethodInfoPtr_get_dBufferColorHandles_Internal_get_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, 100664462);
			DBufferRenderPass.NativeMethodInfoPtr_set_dBufferColorHandles_Private_set_Void_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, 100664463);
			DBufferRenderPass.NativeMethodInfoPtr_get_depthHandle_Internal_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, 100664464);
			DBufferRenderPass.NativeMethodInfoPtr_set_depthHandle_Private_set_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, 100664465);
			DBufferRenderPass.NativeMethodInfoPtr_get_dBufferDepth_Internal_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, 100664466);
			DBufferRenderPass.NativeMethodInfoPtr__ctor_Public_Void_Material_DBufferSettings_DecalDrawDBufferSystem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, 100664467);
			DBufferRenderPass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, 100664468);
			DBufferRenderPass.NativeMethodInfoPtr_Setup_Public_Void_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, 100664469);
			DBufferRenderPass.NativeMethodInfoPtr_Setup_Public_Void_byref_CameraData_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, 100664470);
			DBufferRenderPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, 100664471);
			DBufferRenderPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, 100664472);
			DBufferRenderPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr, 100664473);
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x00032804 File Offset: 0x00030A04
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x00032844 File Offset: 0x00030A44
		public unsafe Il2CppReferenceArray<RTHandle> dBufferColorHandles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBufferRenderPass.NativeMethodInfoPtr_get_dBufferColorHandles_Internal_get_Il2CppReferenceArray_1_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBufferRenderPass.NativeMethodInfoPtr_set_dBufferColorHandles_Private_set_Void_Il2CppReferenceArray_1_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00032888 File Offset: 0x00030A88
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x000328C8 File Offset: 0x00030AC8
		public unsafe RTHandle depthHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBufferRenderPass.NativeMethodInfoPtr_get_depthHandle_Internal_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606306, XrefRangeEnd = 606308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBufferRenderPass.NativeMethodInfoPtr_set_depthHandle_Private_set_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x0003290C File Offset: 0x00030B0C
		public unsafe RTHandle dBufferDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBufferRenderPass.NativeMethodInfoPtr_get_dBufferDepth_Internal_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0003294C File Offset: 0x00030B4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606354, RefRangeEnd = 606355, XrefRangeStart = 606308, XrefRangeEnd = 606354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBufferRenderPass(Material dBufferClear, DBufferSettings settings, DecalDrawDBufferSystem drawSystem, bool decalLayers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBufferRenderPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dBufferClear);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drawSystem);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decalLayers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBufferRenderPass.NativeMethodInfoPtr__ctor_Public_Void_Material_DBufferSettings_DecalDrawDBufferSystem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000329CC File Offset: 0x00030BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606358, RefRangeEnd = 606359, XrefRangeStart = 606355, XrefRangeEnd = 606358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBufferRenderPass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00032A00 File Offset: 0x00030C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606359, XrefRangeEnd = 606369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup([In] ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBufferRenderPass.NativeMethodInfoPtr_Setup_Public_Void_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00032A44 File Offset: 0x00030C44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606397, RefRangeEnd = 606398, XrefRangeStart = 606369, XrefRangeEnd = 606397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup([In] ref CameraData cameraData, RTHandle depthTextureHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthTextureHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBufferRenderPass.NativeMethodInfoPtr_Setup_Public_Void_byref_CameraData_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00032A9C File Offset: 0x00030C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606398, XrefRangeEnd = 606399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBufferRenderPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00032AFC File Offset: 0x00030CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606399, XrefRangeEnd = 606442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBufferRenderPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00032B58 File Offset: 0x00030D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606442, XrefRangeEnd = 606463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraCleanup(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBufferRenderPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0000596F File Offset: 0x00003B6F
		public DBufferRenderPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00032BA8 File Offset: 0x00030DA8
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x00005978 File Offset: 0x00003B78
		public unsafe static Il2CppStringArray s_DBufferNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBufferRenderPass.NativeFieldInfoPtr_s_DBufferNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBufferRenderPass.NativeFieldInfoPtr_s_DBufferNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00032BD0 File Offset: 0x00030DD0
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x0000598A File Offset: 0x00003B8A
		public unsafe static string s_DBufferDepthName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBufferRenderPass.NativeFieldInfoPtr_s_DBufferDepthName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBufferRenderPass.NativeFieldInfoPtr_s_DBufferDepthName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00032BF0 File Offset: 0x00030DF0
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x0000599C File Offset: 0x00003B9C
		public unsafe DecalDrawDBufferSystem m_DrawSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_DrawSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalDrawDBufferSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_DrawSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00032C20 File Offset: 0x00030E20
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x000059BB File Offset: 0x00003BBB
		public unsafe DBufferSettings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBufferSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00032C50 File Offset: 0x00030E50
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x000059DA File Offset: 0x00003BDA
		public unsafe Material m_DBufferClear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_DBufferClear);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_DBufferClear), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00032C80 File Offset: 0x00030E80
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x000059F9 File Offset: 0x00003BF9
		public unsafe FilteringSettings m_FilteringSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_FilteringSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_FilteringSettings)) = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00032CA8 File Offset: 0x00030EA8
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00005A14 File Offset: 0x00003C14
		public unsafe List<ShaderTagId> m_ShaderTagIdList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_ShaderTagIdList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_ShaderTagIdList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00032CD8 File Offset: 0x00030ED8
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00005A33 File Offset: 0x00003C33
		public unsafe ProfilingSampler m_ProfilingSampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_ProfilingSampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_ProfilingSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00032D08 File Offset: 0x00030F08
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x00005A52 File Offset: 0x00003C52
		public unsafe ProfilingSampler m_DBufferClearSampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_DBufferClearSampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_DBufferClearSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x00032D38 File Offset: 0x00030F38
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x00005A71 File Offset: 0x00003C71
		public unsafe bool m_DecalLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_DecalLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_DecalLayers)) = value;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00032D60 File Offset: 0x00030F60
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x00005A8C File Offset: 0x00003C8C
		public unsafe RTHandle m_DBufferDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_DBufferDepth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr_m_DBufferDepth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x00032D90 File Offset: 0x00030F90
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x00005AAB File Offset: 0x00003CAB
		public unsafe Il2CppReferenceArray<RTHandle> _dBufferColorHandles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr__dBufferColorHandles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr__dBufferColorHandles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00032DC0 File Offset: 0x00030FC0
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x00005ACA File Offset: 0x00003CCA
		public unsafe RTHandle _depthHandle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr__depthHandle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferRenderPass.NativeFieldInfoPtr__depthHandle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeFieldInfoPtr_s_DBufferNames;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeFieldInfoPtr_s_DBufferDepthName;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawSystem;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeFieldInfoPtr_m_DBufferClear;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeFieldInfoPtr_m_ShaderTagIdList;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeFieldInfoPtr_m_DBufferClearSampler;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalLayers;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeFieldInfoPtr_m_DBufferDepth;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeFieldInfoPtr__dBufferColorHandles_k__BackingField;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeFieldInfoPtr__depthHandle_k__BackingField;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_get_dBufferColorHandles_Internal_get_Il2CppReferenceArray_1_RTHandle_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_set_dBufferColorHandles_Private_set_Void_Il2CppReferenceArray_1_RTHandle_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_get_depthHandle_Internal_get_RTHandle_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_set_depthHandle_Private_set_Void_RTHandle_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_get_dBufferDepth_Internal_get_RTHandle_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Material_DBufferSettings_DecalDrawDBufferSystem_Boolean_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_byref_CameraData_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_byref_CameraData_RTHandle_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0;
	}
}
