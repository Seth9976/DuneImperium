using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000063 RID: 99
	public class DecalForwardEmissivePass : ScriptableRenderPass
	{
		// Token: 0x06000889 RID: 2185 RVA: 0x00032EEC File Offset: 0x000310EC
		// Note: this type is marked as 'beforefieldinit'.
		static DecalForwardEmissivePass()
		{
			Il2CppClassPointerStore<DecalForwardEmissivePass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalForwardEmissivePass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalForwardEmissivePass>.NativeClassPtr);
			DecalForwardEmissivePass.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalForwardEmissivePass>.NativeClassPtr, "m_FilteringSettings");
			DecalForwardEmissivePass.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalForwardEmissivePass>.NativeClassPtr, "m_ProfilingSampler");
			DecalForwardEmissivePass.NativeFieldInfoPtr_m_ShaderTagIdList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalForwardEmissivePass>.NativeClassPtr, "m_ShaderTagIdList");
			DecalForwardEmissivePass.NativeFieldInfoPtr_m_DrawSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalForwardEmissivePass>.NativeClassPtr, "m_DrawSystem");
			DecalForwardEmissivePass.NativeMethodInfoPtr__ctor_Public_Void_DecalDrawFowardEmissiveSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalForwardEmissivePass>.NativeClassPtr, 100664477);
			DecalForwardEmissivePass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalForwardEmissivePass>.NativeClassPtr, 100664478);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00032F94 File Offset: 0x00031194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606503, RefRangeEnd = 606504, XrefRangeStart = 606470, XrefRangeEnd = 606503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalForwardEmissivePass(DecalDrawFowardEmissiveSystem drawSystem)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalForwardEmissivePass>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drawSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalForwardEmissivePass.NativeMethodInfoPtr__ctor_Public_Void_DecalDrawFowardEmissiveSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00032FE0 File Offset: 0x000311E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606504, XrefRangeEnd = 606517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalForwardEmissivePass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00005AF2 File Offset: 0x00003CF2
		public DecalForwardEmissivePass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x0003303C File Offset: 0x0003123C
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x00005AFB File Offset: 0x00003CFB
		public unsafe FilteringSettings m_FilteringSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalForwardEmissivePass.NativeFieldInfoPtr_m_FilteringSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalForwardEmissivePass.NativeFieldInfoPtr_m_FilteringSettings)) = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00033064 File Offset: 0x00031264
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00005B16 File Offset: 0x00003D16
		public unsafe ProfilingSampler m_ProfilingSampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalForwardEmissivePass.NativeFieldInfoPtr_m_ProfilingSampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalForwardEmissivePass.NativeFieldInfoPtr_m_ProfilingSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00033094 File Offset: 0x00031294
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x00005B35 File Offset: 0x00003D35
		public unsafe List<ShaderTagId> m_ShaderTagIdList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalForwardEmissivePass.NativeFieldInfoPtr_m_ShaderTagIdList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalForwardEmissivePass.NativeFieldInfoPtr_m_ShaderTagIdList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x000330C4 File Offset: 0x000312C4
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x00005B54 File Offset: 0x00003D54
		public unsafe DecalDrawFowardEmissiveSystem m_DrawSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalForwardEmissivePass.NativeFieldInfoPtr_m_DrawSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalDrawFowardEmissiveSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalForwardEmissivePass.NativeFieldInfoPtr_m_DrawSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeFieldInfoPtr_m_ShaderTagIdList;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawSystem;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalDrawFowardEmissiveSystem_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;
	}
}
