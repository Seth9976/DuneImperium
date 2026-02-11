using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000E9 RID: 233
	[StructLayout(2)]
	public struct RenderTextureDescriptor
	{
		// Token: 0x06001284 RID: 4740 RVA: 0x0005D090 File Offset: 0x0005B290
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTextureDescriptor()
		{
			Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderTextureDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr);
			RenderTextureDescriptor.NativeFieldInfoPtr__width_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<width>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<height>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__msaaSamples_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<msaaSamples>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__volumeDepth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<volumeDepth>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__mipCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<mipCount>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__graphicsFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "_graphicsFormat");
			RenderTextureDescriptor.NativeFieldInfoPtr__stencilFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<stencilFormat>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__depthStencilFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<depthStencilFormat>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__dimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<dimension>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__shadowSamplingMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<shadowSamplingMode>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__vrUsage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<vrUsage>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "_flags");
			RenderTextureDescriptor.NativeFieldInfoPtr__memoryless_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<memoryless>k__BackingField");
			RenderTextureDescriptor.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665892);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665893);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665894);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665895);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_msaaSamples_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665896);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_msaaSamples_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665897);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665898);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665899);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_mipCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665900);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_mipCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665901);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665902);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665903);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665904);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665905);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665906);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_colorFormat_Public_get_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665907);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_colorFormat_Public_set_Void_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665908);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665909);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665910);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_depthBufferBits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665911);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_depthBufferBits_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665912);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_dimension_Public_get_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665913);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665914);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_shadowSamplingMode_Public_get_ShadowSamplingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665915);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_shadowSamplingMode_Public_set_Void_ShadowSamplingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665916);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_vrUsage_Public_get_VRTextureUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665917);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665918);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_memoryless_Public_get_RenderTextureMemoryless_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665919);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_memoryless_Public_set_Void_RenderTextureMemoryless_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665920);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665921);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665922);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665923);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665924);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665925);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665926);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665927);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665928);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665929);
			RenderTextureDescriptor.NativeMethodInfoPtr_SetOrClearRenderTextureCreationFlag_Private_Void_Boolean_RenderTextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665930);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665931);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665932);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_autoGenerateMips_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665933);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665934);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_enableRandomWrite_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665935);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665936);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_bindMS_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665937);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_bindMS_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665938);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_createdFromScript_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665939);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665940);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665941);
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x0005D5AC File Offset: 0x0005B7AC
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x0005D5DC File Offset: 0x0005B7DC
		public unsafe int width
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_width_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x0005D610 File Offset: 0x0005B810
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x0005D640 File Offset: 0x0005B840
		public unsafe int height
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_height_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 320170, RefRangeEnd = 320176, XrefRangeStart = 320170, XrefRangeEnd = 320176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x0005D674 File Offset: 0x0005B874
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x0005D6A4 File Offset: 0x0005B8A4
		public unsafe int msaaSamples
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_msaaSamples_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_msaaSamples_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x0005D6D8 File Offset: 0x0005B8D8
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x0005D708 File Offset: 0x0005B908
		public unsafe int volumeDepth
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 310309, RefRangeEnd = 310312, XrefRangeStart = 310309, XrefRangeEnd = 310312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x0005D73C File Offset: 0x0005B93C
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x0005D76C File Offset: 0x0005B96C
		public unsafe int mipCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_mipCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_mipCount_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x0005D7A0 File Offset: 0x0005B9A0
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x0005D7D0 File Offset: 0x0005B9D0
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 334566, RefRangeEnd = 334587, XrefRangeStart = 334566, XrefRangeEnd = 334587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(55)]
			[CachedScanResults(RefRangeStart = 657518, RefRangeEnd = 657573, XrefRangeStart = 657509, XrefRangeEnd = 657518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x00007DA5 File Offset: 0x00005FA5
		// (set) Token: 0x06001291 RID: 4753 RVA: 0x0005D804 File Offset: 0x0005BA04
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat stencilFormat
		{
			get
			{
				return this._stencilFormat_k__BackingField;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x0005D838 File Offset: 0x0005BA38
		// (set) Token: 0x06001293 RID: 4755 RVA: 0x0005D868 File Offset: 0x0005BA68
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x0005D89C File Offset: 0x0005BA9C
		// (set) Token: 0x06001295 RID: 4757 RVA: 0x0005D8CC File Offset: 0x0005BACC
		public unsafe RenderTextureFormat colorFormat
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 657574, RefRangeEnd = 657577, XrefRangeStart = 657573, XrefRangeEnd = 657574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_colorFormat_Public_get_RenderTextureFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 657587, RefRangeEnd = 657590, XrefRangeStart = 657577, XrefRangeEnd = 657587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_colorFormat_Public_set_Void_RenderTextureFormat_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x0005D900 File Offset: 0x0005BB00
		// (set) Token: 0x06001297 RID: 4759 RVA: 0x0005D930 File Offset: 0x0005BB30
		public unsafe bool sRGB
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 657594, RefRangeEnd = 657595, XrefRangeStart = 657590, XrefRangeEnd = 657594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 657607, RefRangeEnd = 657610, XrefRangeStart = 657595, XrefRangeEnd = 657607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x0005D964 File Offset: 0x0005BB64
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x0005D994 File Offset: 0x0005BB94
		public unsafe int depthBufferBits
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 657614, RefRangeEnd = 657627, XrefRangeStart = 657610, XrefRangeEnd = 657614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_depthBufferBits_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(52)]
			[CachedScanResults(RefRangeStart = 657628, RefRangeEnd = 657680, XrefRangeStart = 657627, XrefRangeEnd = 657628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_depthBufferBits_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x0005D9C8 File Offset: 0x0005BBC8
		// (set) Token: 0x0600129B RID: 4763 RVA: 0x0005D9F8 File Offset: 0x0005BBF8
		public unsafe UnityEngine.Rendering.TextureDimension dimension
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_dimension_Public_get_TextureDimension_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_TextureDimension_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x0005DA2C File Offset: 0x0005BC2C
		// (set) Token: 0x0600129D RID: 4765 RVA: 0x0005DA5C File Offset: 0x0005BC5C
		public unsafe UnityEngine.Rendering.ShadowSamplingMode shadowSamplingMode
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_shadowSamplingMode_Public_get_ShadowSamplingMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_shadowSamplingMode_Public_set_Void_ShadowSamplingMode_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x0005DA90 File Offset: 0x0005BC90
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x0005DAC0 File Offset: 0x0005BCC0
		public unsafe VRTextureUsage vrUsage
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_vrUsage_Public_get_VRTextureUsage_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x0005DAF4 File Offset: 0x0005BCF4
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x0005DB24 File Offset: 0x0005BD24
		public unsafe RenderTextureMemoryless memoryless
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_memoryless_Public_get_RenderTextureMemoryless_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_memoryless_Public_set_Void_RenderTextureMemoryless_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0005DB58 File Offset: 0x0005BD58
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 657681, RefRangeEnd = 657691, XrefRangeStart = 657680, XrefRangeEnd = 657681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0005DB98 File Offset: 0x0005BD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657691, XrefRangeEnd = 657692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0005DBE8 File Offset: 0x0005BDE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 657697, RefRangeEnd = 657699, XrefRangeStart = 657692, XrefRangeEnd = 657697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0005DC44 File Offset: 0x0005BE44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 657705, RefRangeEnd = 657707, XrefRangeStart = 657699, XrefRangeEnd = 657705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x0005DCA0 File Offset: 0x0005BEA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 657708, RefRangeEnd = 657709, XrefRangeStart = 657707, XrefRangeEnd = 657708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x0005DD0C File Offset: 0x0005BF0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 657716, RefRangeEnd = 657718, XrefRangeStart = 657709, XrefRangeEnd = 657716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount, RenderTextureReadWrite readWrite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_RenderTextureReadWrite_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0005DD84 File Offset: 0x0005BF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657718, XrefRangeEnd = 657720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits, int mipCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0005DDF0 File Offset: 0x0005BFF0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 657725, RefRangeEnd = 657733, XrefRangeStart = 657720, XrefRangeEnd = 657725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStencilFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0005DE4C File Offset: 0x0005C04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657733, XrefRangeEnd = 657734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStencilFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0005DEB8 File Offset: 0x0005C0B8
		[CallerCount(0)]
		public unsafe void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_SetOrClearRenderTextureCreationFlag_Private_Void_Boolean_RenderTextureCreationFlags_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x0005DEF8 File Offset: 0x0005C0F8
		// (set) Token: 0x060012AD RID: 4781 RVA: 0x0005DF28 File Offset: 0x0005C128
		public unsafe bool useMipMap
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 657734, RefRangeEnd = 657739, XrefRangeStart = 657734, XrefRangeEnd = 657734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 657739, RefRangeEnd = 657757, XrefRangeStart = 657739, XrefRangeEnd = 657739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0005DF5C File Offset: 0x0005C15C
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x0005DF8C File Offset: 0x0005C18C
		public unsafe bool autoGenerateMips
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 657757, RefRangeEnd = 657762, XrefRangeStart = 657757, XrefRangeEnd = 657757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_autoGenerateMips_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 657762, RefRangeEnd = 657779, XrefRangeStart = 657762, XrefRangeEnd = 657762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x0005DFC0 File Offset: 0x0005C1C0
		// (set) Token: 0x060012B1 RID: 4785 RVA: 0x0005DFF0 File Offset: 0x0005C1F0
		public unsafe bool enableRandomWrite
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 657779, RefRangeEnd = 657784, XrefRangeStart = 657779, XrefRangeEnd = 657779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_enableRandomWrite_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 657784, RefRangeEnd = 657789, XrefRangeStart = 657784, XrefRangeEnd = 657784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x0005E024 File Offset: 0x0005C224
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x0005E054 File Offset: 0x0005C254
		public unsafe bool bindMS
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 657789, RefRangeEnd = 657797, XrefRangeStart = 657789, XrefRangeEnd = 657789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_bindMS_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 657797, RefRangeEnd = 657806, XrefRangeStart = 657797, XrefRangeEnd = 657797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_bindMS_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x0005E138 File Offset: 0x0005C338
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x0005E088 File Offset: 0x0005C288
		public unsafe bool createdFromScript
		{
			get
			{
				return (this._flags & RenderTextureCreationFlags.CreatedFromScript) > (RenderTextureCreationFlags)0;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_createdFromScript_Internal_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x0005E0BC File Offset: 0x0005C2BC
		// (set) Token: 0x060012B6 RID: 4790 RVA: 0x0005E0EC File Offset: 0x0005C2EC
		public unsafe bool useDynamicScale
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 657806, RefRangeEnd = 657813, XrefRangeStart = 657806, XrefRangeEnd = 657806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 657813, RefRangeEnd = 657819, XrefRangeStart = 657813, XrefRangeEnd = 657813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00007D93 File Offset: 0x00005F93
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, ref this));
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x0005E120 File Offset: 0x0005C320
		public RenderTextureCreationFlags flags
		{
			get
			{
				return this._flags;
			}
		}

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeFieldInfoPtr__width_k__BackingField;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeFieldInfoPtr__height_k__BackingField;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeFieldInfoPtr__msaaSamples_k__BackingField;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeFieldInfoPtr__volumeDepth_k__BackingField;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeFieldInfoPtr__mipCount_k__BackingField;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeFieldInfoPtr__graphicsFormat;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeFieldInfoPtr__stencilFormat_k__BackingField;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeFieldInfoPtr__depthStencilFormat_k__BackingField;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeFieldInfoPtr__dimension_k__BackingField;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeFieldInfoPtr__shadowSamplingMode_k__BackingField;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeFieldInfoPtr__vrUsage_k__BackingField;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeFieldInfoPtr__memoryless_k__BackingField;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_get_msaaSamples_Public_get_Int32_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_set_msaaSamples_Public_set_Void_Int32_0;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_get_mipCount_Public_get_Int32_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_set_mipCount_Public_set_Void_Int32_0;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_get_colorFormat_Public_get_RenderTextureFormat_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_set_colorFormat_Public_set_Void_RenderTextureFormat_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_get_depthBufferBits_Public_get_Int32_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_set_depthBufferBits_Public_set_Void_Int32_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_get_dimension_Public_get_TextureDimension_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_set_dimension_Public_set_Void_TextureDimension_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowSamplingMode_Public_get_ShadowSamplingMode_0;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowSamplingMode_Public_set_Void_ShadowSamplingMode_0;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeMethodInfoPtr_get_vrUsage_Public_get_VRTextureUsage_0;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeMethodInfoPtr_get_memoryless_Public_get_RenderTextureMemoryless_0;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr_set_memoryless_Public_set_Void_RenderTextureMemoryless_0;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_0;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_0;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_RenderTextureReadWrite_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_Int32_0;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr_SetOrClearRenderTextureCreationFlag_Private_Void_Boolean_RenderTextureCreationFlags_0;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeMethodInfoPtr_get_autoGenerateMips_Public_get_Boolean_0;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeMethodInfoPtr_get_enableRandomWrite_Public_get_Boolean_0;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr_get_bindMS_Public_get_Boolean_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_set_bindMS_Public_set_Void_Boolean_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_set_createdFromScript_Internal_set_Void_Boolean_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0;

		// Token: 0x04001094 RID: 4244
		[FieldOffset(0)]
		public int _width_k__BackingField;

		// Token: 0x04001095 RID: 4245
		[FieldOffset(4)]
		public int _height_k__BackingField;

		// Token: 0x04001096 RID: 4246
		[FieldOffset(8)]
		public int _msaaSamples_k__BackingField;

		// Token: 0x04001097 RID: 4247
		[FieldOffset(12)]
		public int _volumeDepth_k__BackingField;

		// Token: 0x04001098 RID: 4248
		[FieldOffset(16)]
		public int _mipCount_k__BackingField;

		// Token: 0x04001099 RID: 4249
		[FieldOffset(20)]
		public UnityEngine.Experimental.Rendering.GraphicsFormat _graphicsFormat;

		// Token: 0x0400109A RID: 4250
		[FieldOffset(24)]
		public UnityEngine.Experimental.Rendering.GraphicsFormat _stencilFormat_k__BackingField;

		// Token: 0x0400109B RID: 4251
		[FieldOffset(28)]
		public UnityEngine.Experimental.Rendering.GraphicsFormat _depthStencilFormat_k__BackingField;

		// Token: 0x0400109C RID: 4252
		[FieldOffset(32)]
		public UnityEngine.Rendering.TextureDimension _dimension_k__BackingField;

		// Token: 0x0400109D RID: 4253
		[FieldOffset(36)]
		public UnityEngine.Rendering.ShadowSamplingMode _shadowSamplingMode_k__BackingField;

		// Token: 0x0400109E RID: 4254
		[FieldOffset(40)]
		public VRTextureUsage _vrUsage_k__BackingField;

		// Token: 0x0400109F RID: 4255
		[FieldOffset(44)]
		public RenderTextureCreationFlags _flags;

		// Token: 0x040010A0 RID: 4256
		[FieldOffset(48)]
		public RenderTextureMemoryless _memoryless_k__BackingField;
	}
}
