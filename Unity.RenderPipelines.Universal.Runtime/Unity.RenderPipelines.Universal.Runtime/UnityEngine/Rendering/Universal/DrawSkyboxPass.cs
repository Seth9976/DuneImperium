using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000AE RID: 174
	public class DrawSkyboxPass : ScriptableRenderPass
	{
		// Token: 0x06000DAE RID: 3502 RVA: 0x00044AC0 File Offset: 0x00042CC0
		// Note: this type is marked as 'beforefieldinit'.
		static DrawSkyboxPass()
		{
			Il2CppClassPointerStore<DrawSkyboxPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DrawSkyboxPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawSkyboxPass>.NativeClassPtr);
			DrawSkyboxPass.NativeFieldInfoPtr_m_IsActiveTargetBackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawSkyboxPass>.NativeClassPtr, "m_IsActiveTargetBackBuffer");
			DrawSkyboxPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawSkyboxPass>.NativeClassPtr, 100665074);
			DrawSkyboxPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawSkyboxPass>.NativeClassPtr, 100665075);
			DrawSkyboxPass.NativeMethodInfoPtr_CreateSkyboxRendererList_Private_RendererList_ScriptableRenderContext_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawSkyboxPass>.NativeClassPtr, 100665076);
			DrawSkyboxPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawSkyboxPass>.NativeClassPtr, 100665077);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00044B54 File Offset: 0x00042D54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 612630, RefRangeEnd = 612631, XrefRangeStart = 612619, XrefRangeEnd = 612630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawSkyboxPass(RenderPassEvent evt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawSkyboxPass>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawSkyboxPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00044B9C File Offset: 0x00042D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612631, XrefRangeEnd = 612647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrawSkyboxPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00044BF8 File Offset: 0x00042DF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 612667, RefRangeEnd = 612668, XrefRangeStart = 612647, XrefRangeEnd = 612667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateSkyboxRendererList(ScriptableRenderContext context, CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawSkyboxPass.NativeMethodInfoPtr_CreateSkyboxRendererList_Private_RendererList_ScriptableRenderContext_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00044C58 File Offset: 0x00042E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 612699, RefRangeEnd = 612700, XrefRangeStart = 612668, XrefRangeEnd = 612699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorTarget;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTarget;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawSkyboxPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x000087B0 File Offset: 0x000069B0
		public DrawSkyboxPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x00044CCC File Offset: 0x00042ECC
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x000087B9 File Offset: 0x000069B9
		public unsafe bool m_IsActiveTargetBackBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawSkyboxPass.NativeFieldInfoPtr_m_IsActiveTargetBackBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawSkyboxPass.NativeFieldInfoPtr_m_IsActiveTargetBackBuffer)) = value;
			}
		}

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeFieldInfoPtr_m_IsActiveTargetBackBuffer;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Private_RendererList_ScriptableRenderContext_CameraData_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_byref_RenderingData_0;

		// Token: 0x020001A0 RID: 416
		public class PassData : Object
		{
			// Token: 0x06001E53 RID: 7763 RVA: 0x00079EE8 File Offset: 0x000780E8
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<DrawSkyboxPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawSkyboxPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawSkyboxPass.PassData>.NativeClassPtr);
				DrawSkyboxPass.PassData.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawSkyboxPass.PassData>.NativeClassPtr, "color");
				DrawSkyboxPass.PassData.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawSkyboxPass.PassData>.NativeClassPtr, "depth");
				DrawSkyboxPass.PassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawSkyboxPass.PassData>.NativeClassPtr, "renderingData");
				DrawSkyboxPass.PassData.NativeFieldInfoPtr_pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawSkyboxPass.PassData>.NativeClassPtr, "pass");
				DrawSkyboxPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawSkyboxPass.PassData>.NativeClassPtr, 100665078);
			}

			// Token: 0x06001E54 RID: 7764 RVA: 0x00079F78 File Offset: 0x00078178
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawSkyboxPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawSkyboxPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E55 RID: 7765 RVA: 0x00011619 File Offset: 0x0000F819
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AD7 RID: 2775
			// (get) Token: 0x06001E56 RID: 7766 RVA: 0x00079FB4 File Offset: 0x000781B4
			// (set) Token: 0x06001E57 RID: 7767 RVA: 0x00011622 File Offset: 0x0000F822
			public unsafe TextureHandle color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawSkyboxPass.PassData.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawSkyboxPass.PassData.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x17000AD8 RID: 2776
			// (get) Token: 0x06001E58 RID: 7768 RVA: 0x00079FDC File Offset: 0x000781DC
			// (set) Token: 0x06001E59 RID: 7769 RVA: 0x0001163D File Offset: 0x0000F83D
			public unsafe TextureHandle depth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawSkyboxPass.PassData.NativeFieldInfoPtr_depth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawSkyboxPass.PassData.NativeFieldInfoPtr_depth)) = value;
				}
			}

			// Token: 0x17000AD9 RID: 2777
			// (get) Token: 0x06001E5A RID: 7770 RVA: 0x0007A004 File Offset: 0x00078204
			// (set) Token: 0x06001E5B RID: 7771 RVA: 0x00011658 File Offset: 0x0000F858
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawSkyboxPass.PassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawSkyboxPass.PassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000ADA RID: 2778
			// (get) Token: 0x06001E5C RID: 7772 RVA: 0x0007A034 File Offset: 0x00078234
			// (set) Token: 0x06001E5D RID: 7773 RVA: 0x00011686 File Offset: 0x0000F886
			public unsafe DrawSkyboxPass pass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawSkyboxPass.PassData.NativeFieldInfoPtr_pass);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawSkyboxPass>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawSkyboxPass.PassData.NativeFieldInfoPtr_pass), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015CF RID: 5583
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x040015D0 RID: 5584
			private static readonly IntPtr NativeFieldInfoPtr_depth;

			// Token: 0x040015D1 RID: 5585
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x040015D2 RID: 5586
			private static readonly IntPtr NativeFieldInfoPtr_pass;

			// Token: 0x040015D3 RID: 5587
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001A1 RID: 417
		[ObfuscatedName("UnityEngine.Rendering.Universal.DrawSkyboxPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E5E RID: 7774 RVA: 0x0007A064 File Offset: 0x00078264
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DrawSkyboxPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawSkyboxPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawSkyboxPass.__c>.NativeClassPtr);
				DrawSkyboxPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawSkyboxPass.__c>.NativeClassPtr, "<>9");
				DrawSkyboxPass.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawSkyboxPass.__c>.NativeClassPtr, "<>9__5_0");
				DrawSkyboxPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawSkyboxPass.__c>.NativeClassPtr, 100665080);
				DrawSkyboxPass.__c.NativeMethodInfoPtr__Render_b__5_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawSkyboxPass.__c>.NativeClassPtr, 100665081);
			}

			// Token: 0x06001E5F RID: 7775 RVA: 0x0007A0E0 File Offset: 0x000782E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawSkyboxPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawSkyboxPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E60 RID: 7776 RVA: 0x0007A11C File Offset: 0x0007831C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612618, XrefRangeEnd = 612619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__5_0(DrawSkyboxPass.PassData data, RenderGraphContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawSkyboxPass.__c.NativeMethodInfoPtr__Render_b__5_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E61 RID: 7777 RVA: 0x000116A5 File Offset: 0x0000F8A5
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ADB RID: 2779
			// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0007A170 File Offset: 0x00078370
			// (set) Token: 0x06001E63 RID: 7779 RVA: 0x000116AE File Offset: 0x0000F8AE
			public unsafe static DrawSkyboxPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DrawSkyboxPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawSkyboxPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DrawSkyboxPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ADC RID: 2780
			// (get) Token: 0x06001E64 RID: 7780 RVA: 0x0007A198 File Offset: 0x00078398
			// (set) Token: 0x06001E65 RID: 7781 RVA: 0x000116C0 File Offset: 0x0000F8C0
			public unsafe static RenderFunc<DrawSkyboxPass.PassData> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DrawSkyboxPass.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<DrawSkyboxPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DrawSkyboxPass.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015D4 RID: 5588
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015D5 RID: 5589
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040015D6 RID: 5590
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015D7 RID: 5591
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__5_0_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}
