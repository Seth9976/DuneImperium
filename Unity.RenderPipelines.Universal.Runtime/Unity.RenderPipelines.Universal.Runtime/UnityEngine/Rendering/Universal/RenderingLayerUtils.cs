using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000CB RID: 203
	public static class RenderingLayerUtils : Object
	{
		// Token: 0x06000FD4 RID: 4052 RVA: 0x0004B634 File Offset: 0x00049834
		// Note: this type is marked as 'beforefieldinit'.
		static RenderingLayerUtils()
		{
			Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "RenderingLayerUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr);
			RenderingLayerUtils.NativeMethodInfoPtr_CombineRendererEvents_Public_Static_Void_Boolean_Int32_Event_byref_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665275);
			RenderingLayerUtils.NativeMethodInfoPtr_RequireRenderingLayers_Public_Static_Boolean_UniversalRendererData_Int32_byref_Event_byref_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665276);
			RenderingLayerUtils.NativeMethodInfoPtr_RequireRenderingLayers_Public_Static_Boolean_UniversalRenderer_List_1_ScriptableRendererFeature_Int32_byref_Event_byref_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665277);
			RenderingLayerUtils.NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665278);
			RenderingLayerUtils.NativeMethodInfoPtr_GetFormat_Public_Static_GraphicsFormat_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665279);
			RenderingLayerUtils.NativeMethodInfoPtr_ToValidRenderingLayers_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665280);
			RenderingLayerUtils.NativeMethodInfoPtr_GetMaskSize_Private_Static_MaskSize_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665281);
			RenderingLayerUtils.NativeMethodInfoPtr_GetBits_Private_Static_Int32_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665282);
			RenderingLayerUtils.NativeMethodInfoPtr_Combine_Private_Static_Event_Event_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665283);
			RenderingLayerUtils.NativeMethodInfoPtr_Combine_Private_Static_MaskSize_MaskSize_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665284);
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0004B72C File Offset: 0x0004992C
		[CallerCount(0)]
		public unsafe static void CombineRendererEvents(bool isDeferred, int msaaSampleCount, RenderingLayerUtils.Event rendererEvent, ref RenderingLayerUtils.Event combinedEvent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isDeferred;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msaaSampleCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rendererEvent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &combinedEvent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingLayerUtils.NativeMethodInfoPtr_CombineRendererEvents_Public_Static_Void_Boolean_Int32_Event_byref_Event_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0004B788 File Offset: 0x00049988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615881, XrefRangeEnd = 615909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequireRenderingLayers(UniversalRendererData universalRendererData, int msaaSampleCount, out RenderingLayerUtils.Event combinedEvent, out RenderingLayerUtils.MaskSize combinedMaskSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(universalRendererData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msaaSampleCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &combinedEvent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &combinedMaskSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingLayerUtils.NativeMethodInfoPtr_RequireRenderingLayers_Public_Static_Boolean_UniversalRendererData_Int32_byref_Event_byref_MaskSize_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0004B7F4 File Offset: 0x000499F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 615939, RefRangeEnd = 615940, XrefRangeStart = 615909, XrefRangeEnd = 615939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequireRenderingLayers(UniversalRenderer universalRenderer, List<ScriptableRendererFeature> rendererFeatures, int msaaSampleCount, out RenderingLayerUtils.Event combinedEvent, out RenderingLayerUtils.MaskSize combinedMaskSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(universalRenderer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rendererFeatures);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msaaSampleCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &combinedEvent;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &combinedMaskSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingLayerUtils.NativeMethodInfoPtr_RequireRenderingLayers_Public_Static_Boolean_UniversalRenderer_List_1_ScriptableRendererFeature_Int32_byref_Event_byref_MaskSize_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0004B874 File Offset: 0x00049A74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 615956, RefRangeEnd = 615958, XrefRangeStart = 615940, XrefRangeEnd = 615956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupProperties(CommandBuffer cmd, RenderingLayerUtils.MaskSize maskSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maskSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingLayerUtils.NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_MaskSize_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0004B8B8 File Offset: 0x00049AB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 615958, RefRangeEnd = 615960, XrefRangeStart = 615958, XrefRangeEnd = 615958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetFormat(RenderingLayerUtils.MaskSize maskSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maskSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingLayerUtils.NativeMethodInfoPtr_GetFormat_Public_Static_GraphicsFormat_MaskSize_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0004B8F8 File Offset: 0x00049AF8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 615968, RefRangeEnd = 615975, XrefRangeStart = 615960, XrefRangeEnd = 615968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToValidRenderingLayers(uint renderingLayers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderingLayers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingLayerUtils.NativeMethodInfoPtr_ToValidRenderingLayers_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0004B938 File Offset: 0x00049B38
		[CallerCount(0)]
		public unsafe static RenderingLayerUtils.MaskSize GetMaskSize(int bits)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingLayerUtils.NativeMethodInfoPtr_GetMaskSize_Private_Static_MaskSize_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0004B978 File Offset: 0x00049B78
		[CallerCount(0)]
		public unsafe static int GetBits(RenderingLayerUtils.MaskSize maskSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maskSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingLayerUtils.NativeMethodInfoPtr_GetBits_Private_Static_Int32_MaskSize_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x0004B9B8 File Offset: 0x00049BB8
		[CallerCount(0)]
		public unsafe static RenderingLayerUtils.Event Combine(RenderingLayerUtils.Event a, RenderingLayerUtils.Event b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingLayerUtils.NativeMethodInfoPtr_Combine_Private_Static_Event_Event_Event_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x0004BA04 File Offset: 0x00049C04
		[CallerCount(0)]
		public unsafe static RenderingLayerUtils.MaskSize Combine(RenderingLayerUtils.MaskSize a, RenderingLayerUtils.MaskSize b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingLayerUtils.NativeMethodInfoPtr_Combine_Private_Static_MaskSize_MaskSize_MaskSize_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00009C37 File Offset: 0x00007E37
		public RenderingLayerUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_CombineRendererEvents_Public_Static_Void_Boolean_Int32_Event_byref_Event_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_RequireRenderingLayers_Public_Static_Boolean_UniversalRendererData_Int32_byref_Event_byref_MaskSize_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_RequireRenderingLayers_Public_Static_Boolean_UniversalRenderer_List_1_ScriptableRendererFeature_Int32_byref_Event_byref_MaskSize_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_MaskSize_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Static_GraphicsFormat_MaskSize_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_ToValidRenderingLayers_Public_Static_UInt32_UInt32_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_GetMaskSize_Private_Static_MaskSize_Int32_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_GetBits_Private_Static_Int32_MaskSize_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Private_Static_Event_Event_Event_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Private_Static_MaskSize_MaskSize_MaskSize_0;

		// Token: 0x020001BA RID: 442
		public enum Event
		{
			// Token: 0x040016BA RID: 5818
			DepthNormalPrePass,
			// Token: 0x040016BB RID: 5819
			Opaque
		}

		// Token: 0x020001BB RID: 443
		public enum MaskSize
		{
			// Token: 0x040016BD RID: 5821
			Bits8,
			// Token: 0x040016BE RID: 5822
			Bits16,
			// Token: 0x040016BF RID: 5823
			Bits24,
			// Token: 0x040016C0 RID: 5824
			Bits32
		}
	}
}
