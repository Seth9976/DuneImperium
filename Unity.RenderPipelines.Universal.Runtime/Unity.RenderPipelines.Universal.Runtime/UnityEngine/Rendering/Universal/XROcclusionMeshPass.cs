using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000B8 RID: 184
	public class XROcclusionMeshPass : ScriptableRenderPass
	{
		// Token: 0x06000EA6 RID: 3750 RVA: 0x00048050 File Offset: 0x00046250
		// Note: this type is marked as 'beforefieldinit'.
		static XROcclusionMeshPass()
		{
			Il2CppClassPointerStore<XROcclusionMeshPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "XROcclusionMeshPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XROcclusionMeshPass>.NativeClassPtr);
			XROcclusionMeshPass.NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XROcclusionMeshPass>.NativeClassPtr, "m_PassData");
			XROcclusionMeshPass.NativeFieldInfoPtr_m_IsActiveTargetBackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XROcclusionMeshPass>.NativeClassPtr, "m_IsActiveTargetBackBuffer");
			XROcclusionMeshPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMeshPass>.NativeClassPtr, 100665172);
			XROcclusionMeshPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMeshPass>.NativeClassPtr, 100665173);
			XROcclusionMeshPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMeshPass>.NativeClassPtr, 100665174);
			XROcclusionMeshPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMeshPass>.NativeClassPtr, 100665175);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x000480F8 File Offset: 0x000462F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 614397, RefRangeEnd = 614398, XrefRangeStart = 614375, XrefRangeEnd = 614397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XROcclusionMeshPass(RenderPassEvent evt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XROcclusionMeshPass>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XROcclusionMeshPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00048140 File Offset: 0x00046340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 614402, RefRangeEnd = 614404, XrefRangeStart = 614398, XrefRangeEnd = 614402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutePass(ScriptableRenderContext context, XROcclusionMeshPass.PassData data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XROcclusionMeshPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00048184 File Offset: 0x00046384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 614404, XrefRangeEnd = 614407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XROcclusionMeshPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x000481E0 File Offset: 0x000463E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 614437, RefRangeEnd = 614438, XrefRangeStart = 614407, XrefRangeEnd = 614437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderGraph renderGraph, [In] ref TextureHandle cameraColorAttachment, [In] ref TextureHandle cameraDepthAttachment, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cameraColorAttachment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cameraDepthAttachment;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XROcclusionMeshPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00009089 File Offset: 0x00007289
		public XROcclusionMeshPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x00048254 File Offset: 0x00046454
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x00009092 File Offset: 0x00007292
		public unsafe XROcclusionMeshPass.PassData m_PassData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMeshPass.NativeFieldInfoPtr_m_PassData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XROcclusionMeshPass.PassData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMeshPass.NativeFieldInfoPtr_m_PassData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x00048284 File Offset: 0x00046484
		// (set) Token: 0x06000EAF RID: 3759 RVA: 0x000090B1 File Offset: 0x000072B1
		public unsafe bool m_IsActiveTargetBackBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMeshPass.NativeFieldInfoPtr_m_IsActiveTargetBackBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMeshPass.NativeFieldInfoPtr_m_IsActiveTargetBackBuffer)) = value;
			}
		}

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeFieldInfoPtr_m_PassData;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeFieldInfoPtr_m_IsActiveTargetBackBuffer;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_0;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0;

		// Token: 0x020001AD RID: 429
		public class PassData : Object
		{
			// Token: 0x06001F42 RID: 8002 RVA: 0x0007BBFC File Offset: 0x00079DFC
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<XROcclusionMeshPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XROcclusionMeshPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XROcclusionMeshPass.PassData>.NativeClassPtr);
				XROcclusionMeshPass.PassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XROcclusionMeshPass.PassData>.NativeClassPtr, "renderingData");
				XROcclusionMeshPass.PassData.NativeFieldInfoPtr_cameraColorAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XROcclusionMeshPass.PassData>.NativeClassPtr, "cameraColorAttachment");
				XROcclusionMeshPass.PassData.NativeFieldInfoPtr_cameraDepthAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XROcclusionMeshPass.PassData>.NativeClassPtr, "cameraDepthAttachment");
				XROcclusionMeshPass.PassData.NativeFieldInfoPtr_isActiveTargetBackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XROcclusionMeshPass.PassData>.NativeClassPtr, "isActiveTargetBackBuffer");
				XROcclusionMeshPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMeshPass.PassData>.NativeClassPtr, 100665176);
			}

			// Token: 0x06001F43 RID: 8003 RVA: 0x0007BC8C File Offset: 0x00079E8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XROcclusionMeshPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XROcclusionMeshPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F44 RID: 8004 RVA: 0x00011E7D File Offset: 0x0001007D
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B3A RID: 2874
			// (get) Token: 0x06001F45 RID: 8005 RVA: 0x0007BCC8 File Offset: 0x00079EC8
			// (set) Token: 0x06001F46 RID: 8006 RVA: 0x00011E86 File Offset: 0x00010086
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMeshPass.PassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMeshPass.PassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000B3B RID: 2875
			// (get) Token: 0x06001F47 RID: 8007 RVA: 0x0007BCF8 File Offset: 0x00079EF8
			// (set) Token: 0x06001F48 RID: 8008 RVA: 0x00011EB4 File Offset: 0x000100B4
			public unsafe TextureHandle cameraColorAttachment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMeshPass.PassData.NativeFieldInfoPtr_cameraColorAttachment);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMeshPass.PassData.NativeFieldInfoPtr_cameraColorAttachment)) = value;
				}
			}

			// Token: 0x17000B3C RID: 2876
			// (get) Token: 0x06001F49 RID: 8009 RVA: 0x0007BD20 File Offset: 0x00079F20
			// (set) Token: 0x06001F4A RID: 8010 RVA: 0x00011ECF File Offset: 0x000100CF
			public unsafe TextureHandle cameraDepthAttachment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMeshPass.PassData.NativeFieldInfoPtr_cameraDepthAttachment);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMeshPass.PassData.NativeFieldInfoPtr_cameraDepthAttachment)) = value;
				}
			}

			// Token: 0x17000B3D RID: 2877
			// (get) Token: 0x06001F4B RID: 8011 RVA: 0x0007BD48 File Offset: 0x00079F48
			// (set) Token: 0x06001F4C RID: 8012 RVA: 0x00011EEA File Offset: 0x000100EA
			public unsafe bool isActiveTargetBackBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMeshPass.PassData.NativeFieldInfoPtr_isActiveTargetBackBuffer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMeshPass.PassData.NativeFieldInfoPtr_isActiveTargetBackBuffer)) = value;
				}
			}

			// Token: 0x04001645 RID: 5701
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x04001646 RID: 5702
			private static readonly IntPtr NativeFieldInfoPtr_cameraColorAttachment;

			// Token: 0x04001647 RID: 5703
			private static readonly IntPtr NativeFieldInfoPtr_cameraDepthAttachment;

			// Token: 0x04001648 RID: 5704
			private static readonly IntPtr NativeFieldInfoPtr_isActiveTargetBackBuffer;

			// Token: 0x04001649 RID: 5705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001AE RID: 430
		[ObfuscatedName("UnityEngine.Rendering.Universal.XROcclusionMeshPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001F4D RID: 8013 RVA: 0x0007BD70 File Offset: 0x00079F70
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<XROcclusionMeshPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XROcclusionMeshPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XROcclusionMeshPass.__c>.NativeClassPtr);
				XROcclusionMeshPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XROcclusionMeshPass.__c>.NativeClassPtr, "<>9");
				XROcclusionMeshPass.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XROcclusionMeshPass.__c>.NativeClassPtr, "<>9__6_0");
				XROcclusionMeshPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMeshPass.__c>.NativeClassPtr, 100665178);
				XROcclusionMeshPass.__c.NativeMethodInfoPtr__Render_b__6_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMeshPass.__c>.NativeClassPtr, 100665179);
			}

			// Token: 0x06001F4E RID: 8014 RVA: 0x0007BDEC File Offset: 0x00079FEC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XROcclusionMeshPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XROcclusionMeshPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F4F RID: 8015 RVA: 0x0007BE28 File Offset: 0x0007A028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 614352, XrefRangeEnd = 614375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__6_0(XROcclusionMeshPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XROcclusionMeshPass.__c.NativeMethodInfoPtr__Render_b__6_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F50 RID: 8016 RVA: 0x00011F05 File Offset: 0x00010105
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B3E RID: 2878
			// (get) Token: 0x06001F51 RID: 8017 RVA: 0x0007BE7C File Offset: 0x0007A07C
			// (set) Token: 0x06001F52 RID: 8018 RVA: 0x00011F0E File Offset: 0x0001010E
			public unsafe static XROcclusionMeshPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XROcclusionMeshPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XROcclusionMeshPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XROcclusionMeshPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B3F RID: 2879
			// (get) Token: 0x06001F53 RID: 8019 RVA: 0x0007BEA4 File Offset: 0x0007A0A4
			// (set) Token: 0x06001F54 RID: 8020 RVA: 0x00011F20 File Offset: 0x00010120
			public unsafe static RenderFunc<XROcclusionMeshPass.PassData> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XROcclusionMeshPass.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<XROcclusionMeshPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XROcclusionMeshPass.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400164A RID: 5706
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400164B RID: 5707
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400164C RID: 5708
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400164D RID: 5709
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__6_0_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}
