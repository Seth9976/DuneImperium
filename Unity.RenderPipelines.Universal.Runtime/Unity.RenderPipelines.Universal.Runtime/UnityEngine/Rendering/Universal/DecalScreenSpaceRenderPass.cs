using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200007B RID: 123
	public class DecalScreenSpaceRenderPass : ScriptableRenderPass
	{
		// Token: 0x06000A61 RID: 2657 RVA: 0x00038C00 File Offset: 0x00036E00
		// Note: this type is marked as 'beforefieldinit'.
		static DecalScreenSpaceRenderPass()
		{
			Il2CppClassPointerStore<DecalScreenSpaceRenderPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalScreenSpaceRenderPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalScreenSpaceRenderPass>.NativeClassPtr);
			DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalScreenSpaceRenderPass>.NativeClassPtr, "m_FilteringSettings");
			DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalScreenSpaceRenderPass>.NativeClassPtr, "m_ProfilingSampler");
			DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_ShaderTagIdList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalScreenSpaceRenderPass>.NativeClassPtr, "m_ShaderTagIdList");
			DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_DrawSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalScreenSpaceRenderPass>.NativeClassPtr, "m_DrawSystem");
			DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalScreenSpaceRenderPass>.NativeClassPtr, "m_Settings");
			DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_DecalLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalScreenSpaceRenderPass>.NativeClassPtr, "m_DecalLayers");
			DecalScreenSpaceRenderPass.NativeMethodInfoPtr__ctor_Public_Void_DecalScreenSpaceSettings_DecalDrawScreenSpaceSystem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalScreenSpaceRenderPass>.NativeClassPtr, 100664644);
			DecalScreenSpaceRenderPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalScreenSpaceRenderPass>.NativeClassPtr, 100664645);
			DecalScreenSpaceRenderPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalScreenSpaceRenderPass>.NativeClassPtr, 100664646);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00038CE4 File Offset: 0x00036EE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 608268, RefRangeEnd = 608269, XrefRangeStart = 608233, XrefRangeEnd = 608268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalScreenSpaceRenderPass(DecalScreenSpaceSettings settings, DecalDrawScreenSpaceSystem drawSystem, bool decalLayers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalScreenSpaceRenderPass>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalScreenSpaceRenderPass.NativeMethodInfoPtr__ctor_Public_Void_DecalScreenSpaceSettings_DecalDrawScreenSpaceSystem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00038D50 File Offset: 0x00036F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608269, XrefRangeEnd = 608317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalScreenSpaceRenderPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00038DAC File Offset: 0x00036FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608317, XrefRangeEnd = 608338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraCleanup(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalScreenSpaceRenderPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00006C24 File Offset: 0x00004E24
		public DecalScreenSpaceRenderPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00038DFC File Offset: 0x00036FFC
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00006C2D File Offset: 0x00004E2D
		public unsafe FilteringSettings m_FilteringSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_FilteringSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_FilteringSettings)) = value;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00038E24 File Offset: 0x00037024
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00006C48 File Offset: 0x00004E48
		public unsafe ProfilingSampler m_ProfilingSampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_ProfilingSampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_ProfilingSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x00038E54 File Offset: 0x00037054
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x00006C67 File Offset: 0x00004E67
		public unsafe List<ShaderTagId> m_ShaderTagIdList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_ShaderTagIdList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_ShaderTagIdList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00038E84 File Offset: 0x00037084
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x00006C86 File Offset: 0x00004E86
		public unsafe DecalDrawScreenSpaceSystem m_DrawSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_DrawSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalDrawScreenSpaceSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_DrawSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00038EB4 File Offset: 0x000370B4
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x00006CA5 File Offset: 0x00004EA5
		public unsafe DecalScreenSpaceSettings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalScreenSpaceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00038EE4 File Offset: 0x000370E4
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00006CC4 File Offset: 0x00004EC4
		public unsafe bool m_DecalLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_DecalLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalScreenSpaceRenderPass.NativeFieldInfoPtr_m_DecalLayers)) = value;
			}
		}

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeFieldInfoPtr_m_ShaderTagIdList;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawSystem;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalLayers;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalScreenSpaceSettings_DecalDrawScreenSpaceSystem_Boolean_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0;
	}
}
