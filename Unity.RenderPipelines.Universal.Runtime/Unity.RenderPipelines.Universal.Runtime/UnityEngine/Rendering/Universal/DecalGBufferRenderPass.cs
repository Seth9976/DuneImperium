using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000079 RID: 121
	public class DecalGBufferRenderPass : ScriptableRenderPass
	{
		// Token: 0x06000A46 RID: 2630 RVA: 0x000386A8 File Offset: 0x000368A8
		// Note: this type is marked as 'beforefieldinit'.
		static DecalGBufferRenderPass()
		{
			Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalGBufferRenderPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr);
			DecalGBufferRenderPass.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr, "m_FilteringSettings");
			DecalGBufferRenderPass.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr, "m_ProfilingSampler");
			DecalGBufferRenderPass.NativeFieldInfoPtr_m_ShaderTagIdList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr, "m_ShaderTagIdList");
			DecalGBufferRenderPass.NativeFieldInfoPtr_m_DrawSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr, "m_DrawSystem");
			DecalGBufferRenderPass.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr, "m_Settings");
			DecalGBufferRenderPass.NativeFieldInfoPtr_m_DeferredLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr, "m_DeferredLights");
			DecalGBufferRenderPass.NativeFieldInfoPtr_m_GbufferAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr, "m_GbufferAttachments");
			DecalGBufferRenderPass.NativeFieldInfoPtr_m_DecalLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr, "m_DecalLayers");
			DecalGBufferRenderPass.NativeMethodInfoPtr__ctor_Public_Void_DecalScreenSpaceSettings_DecalDrawGBufferSystem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr, 100664637);
			DecalGBufferRenderPass.NativeMethodInfoPtr_Setup_Internal_Void_DeferredLights_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr, 100664638);
			DecalGBufferRenderPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr, 100664639);
			DecalGBufferRenderPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr, 100664640);
			DecalGBufferRenderPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr, 100664641);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000387DC File Offset: 0x000369DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 608108, RefRangeEnd = 608109, XrefRangeStart = 608058, XrefRangeEnd = 608108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalGBufferRenderPass(DecalScreenSpaceSettings settings, DecalDrawGBufferSystem drawSystem, bool decalLayers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalGBufferRenderPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drawSystem);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decalLayers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalGBufferRenderPass.NativeMethodInfoPtr__ctor_Public_Void_DecalScreenSpaceSettings_DecalDrawGBufferSystem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00038848 File Offset: 0x00036A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(DeferredLights deferredLights)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deferredLights);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalGBufferRenderPass.NativeMethodInfoPtr_Setup_Internal_Void_DeferredLights_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0003888C File Offset: 0x00036A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608109, XrefRangeEnd = 608169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraTextureDescriptor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalGBufferRenderPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x000388E8 File Offset: 0x00036AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608169, XrefRangeEnd = 608205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalGBufferRenderPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00038944 File Offset: 0x00036B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608205, XrefRangeEnd = 608226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraCleanup(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalGBufferRenderPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00006B22 File Offset: 0x00004D22
		public DecalGBufferRenderPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00038994 File Offset: 0x00036B94
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x00006B2B File Offset: 0x00004D2B
		public unsafe FilteringSettings m_FilteringSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_FilteringSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_FilteringSettings)) = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x000389BC File Offset: 0x00036BBC
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x00006B46 File Offset: 0x00004D46
		public unsafe ProfilingSampler m_ProfilingSampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_ProfilingSampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_ProfilingSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x000389EC File Offset: 0x00036BEC
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x00006B65 File Offset: 0x00004D65
		public unsafe List<ShaderTagId> m_ShaderTagIdList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_ShaderTagIdList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_ShaderTagIdList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00038A1C File Offset: 0x00036C1C
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00006B84 File Offset: 0x00004D84
		public unsafe DecalDrawGBufferSystem m_DrawSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_DrawSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalDrawGBufferSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_DrawSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00038A4C File Offset: 0x00036C4C
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00006BA3 File Offset: 0x00004DA3
		public unsafe DecalScreenSpaceSettings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalScreenSpaceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00038A7C File Offset: 0x00036C7C
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00006BC2 File Offset: 0x00004DC2
		public unsafe DeferredLights m_DeferredLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_DeferredLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeferredLights>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_DeferredLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00038AAC File Offset: 0x00036CAC
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00006BE1 File Offset: 0x00004DE1
		public unsafe Il2CppReferenceArray<RTHandle> m_GbufferAttachments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_GbufferAttachments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_GbufferAttachments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00038ADC File Offset: 0x00036CDC
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00006C00 File Offset: 0x00004E00
		public unsafe bool m_DecalLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_DecalLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGBufferRenderPass.NativeFieldInfoPtr_m_DecalLayers)) = value;
			}
		}

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeFieldInfoPtr_m_ShaderTagIdList;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawSystem;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeFieldInfoPtr_m_DeferredLights;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeFieldInfoPtr_m_GbufferAttachments;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalLayers;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalScreenSpaceSettings_DecalDrawGBufferSystem_Boolean_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Internal_Void_DeferredLights_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0;
	}
}
