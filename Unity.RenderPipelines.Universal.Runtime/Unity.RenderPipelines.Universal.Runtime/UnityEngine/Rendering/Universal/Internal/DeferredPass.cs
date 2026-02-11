using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x0200011F RID: 287
	public class DeferredPass : ScriptableRenderPass
	{
		// Token: 0x060018F1 RID: 6385 RVA: 0x000690C4 File Offset: 0x000672C4
		// Note: this type is marked as 'beforefieldinit'.
		static DeferredPass()
		{
			Il2CppClassPointerStore<DeferredPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "DeferredPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeferredPass>.NativeClassPtr);
			DeferredPass.NativeFieldInfoPtr_m_DeferredLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredPass>.NativeClassPtr, "m_DeferredLights");
			DeferredPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_DeferredLights_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredPass>.NativeClassPtr, 100666217);
			DeferredPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredPass>.NativeClassPtr, 100666218);
			DeferredPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredPass>.NativeClassPtr, 100666219);
			DeferredPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_Il2CppStructArray_1_TextureHandle_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredPass>.NativeClassPtr, 100666220);
			DeferredPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredPass>.NativeClassPtr, 100666221);
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0006916C File Offset: 0x0006736C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 627304, RefRangeEnd = 627305, XrefRangeStart = 627292, XrefRangeEnd = 627304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeferredPass(RenderPassEvent evt, DeferredLights deferredLights)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeferredPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deferredLights);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_DeferredLights_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x000691C8 File Offset: 0x000673C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627305, XrefRangeEnd = 627310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescripor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraTextureDescripor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeferredPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00069224 File Offset: 0x00067424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627310, XrefRangeEnd = 627312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeferredPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00069280 File Offset: 0x00067480
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 627346, RefRangeEnd = 627347, XrefRangeStart = 627312, XrefRangeEnd = 627346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderGraph renderGraph, TextureHandle color, TextureHandle depth, Il2CppStructArray<TextureHandle> gbuffer, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gbuffer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_Il2CppStructArray_1_TextureHandle_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00069308 File Offset: 0x00067508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627347, XrefRangeEnd = 627349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraCleanup(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeferredPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0000E337 File Offset: 0x0000C537
		public DeferredPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00069358 File Offset: 0x00067558
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x0000E340 File Offset: 0x0000C540
		public unsafe DeferredLights m_DeferredLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredPass.NativeFieldInfoPtr_m_DeferredLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeferredLights>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredPass.NativeFieldInfoPtr_m_DeferredLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeFieldInfoPtr_m_DeferredLights;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_DeferredLights_0;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_Il2CppStructArray_1_TextureHandle_byref_RenderingData_0;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x020001F3 RID: 499
		public class PassData : Object
		{
			// Token: 0x060022C0 RID: 8896 RVA: 0x00084188 File Offset: 0x00082388
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<DeferredPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeferredPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeferredPass.PassData>.NativeClassPtr);
				DeferredPass.PassData.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredPass.PassData>.NativeClassPtr, "color");
				DeferredPass.PassData.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredPass.PassData>.NativeClassPtr, "depth");
				DeferredPass.PassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredPass.PassData>.NativeClassPtr, "renderingData");
				DeferredPass.PassData.NativeFieldInfoPtr_deferredLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredPass.PassData>.NativeClassPtr, "deferredLights");
				DeferredPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredPass.PassData>.NativeClassPtr, 100666222);
			}

			// Token: 0x060022C1 RID: 8897 RVA: 0x00084218 File Offset: 0x00082418
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeferredPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022C2 RID: 8898 RVA: 0x00013DC0 File Offset: 0x00011FC0
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C90 RID: 3216
			// (get) Token: 0x060022C3 RID: 8899 RVA: 0x00084254 File Offset: 0x00082454
			// (set) Token: 0x060022C4 RID: 8900 RVA: 0x00013DC9 File Offset: 0x00011FC9
			public unsafe TextureHandle color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredPass.PassData.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredPass.PassData.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x17000C91 RID: 3217
			// (get) Token: 0x060022C5 RID: 8901 RVA: 0x0008427C File Offset: 0x0008247C
			// (set) Token: 0x060022C6 RID: 8902 RVA: 0x00013DE4 File Offset: 0x00011FE4
			public unsafe TextureHandle depth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredPass.PassData.NativeFieldInfoPtr_depth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredPass.PassData.NativeFieldInfoPtr_depth)) = value;
				}
			}

			// Token: 0x17000C92 RID: 3218
			// (get) Token: 0x060022C7 RID: 8903 RVA: 0x000842A4 File Offset: 0x000824A4
			// (set) Token: 0x060022C8 RID: 8904 RVA: 0x00013DFF File Offset: 0x00011FFF
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredPass.PassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredPass.PassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000C93 RID: 3219
			// (get) Token: 0x060022C9 RID: 8905 RVA: 0x000842D4 File Offset: 0x000824D4
			// (set) Token: 0x060022CA RID: 8906 RVA: 0x00013E2D File Offset: 0x0001202D
			public unsafe DeferredLights deferredLights
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredPass.PassData.NativeFieldInfoPtr_deferredLights);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeferredLights>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeferredPass.PassData.NativeFieldInfoPtr_deferredLights), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400186B RID: 6251
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x0400186C RID: 6252
			private static readonly IntPtr NativeFieldInfoPtr_depth;

			// Token: 0x0400186D RID: 6253
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x0400186E RID: 6254
			private static readonly IntPtr NativeFieldInfoPtr_deferredLights;

			// Token: 0x0400186F RID: 6255
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F4 RID: 500
		[ObfuscatedName("UnityEngine.Rendering.Universal.Internal.DeferredPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060022CB RID: 8907 RVA: 0x00084304 File Offset: 0x00082504
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DeferredPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeferredPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeferredPass.__c>.NativeClassPtr);
				DeferredPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredPass.__c>.NativeClassPtr, "<>9");
				DeferredPass.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredPass.__c>.NativeClassPtr, "<>9__5_0");
				DeferredPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredPass.__c>.NativeClassPtr, 100666224);
				DeferredPass.__c.NativeMethodInfoPtr__Render_b__5_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredPass.__c>.NativeClassPtr, 100666225);
			}

			// Token: 0x060022CC RID: 8908 RVA: 0x00084380 File Offset: 0x00082580
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeferredPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022CD RID: 8909 RVA: 0x000843BC File Offset: 0x000825BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627227, XrefRangeEnd = 627292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__5_0(DeferredPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredPass.__c.NativeMethodInfoPtr__Render_b__5_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022CE RID: 8910 RVA: 0x00013E4C File Offset: 0x0001204C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C94 RID: 3220
			// (get) Token: 0x060022CF RID: 8911 RVA: 0x00084410 File Offset: 0x00082610
			// (set) Token: 0x060022D0 RID: 8912 RVA: 0x00013E55 File Offset: 0x00012055
			public unsafe static DeferredPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeferredPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeferredPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C95 RID: 3221
			// (get) Token: 0x060022D1 RID: 8913 RVA: 0x00084438 File Offset: 0x00082638
			// (set) Token: 0x060022D2 RID: 8914 RVA: 0x00013E67 File Offset: 0x00012067
			public unsafe static RenderFunc<DeferredPass.PassData> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeferredPass.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<DeferredPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeferredPass.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001870 RID: 6256
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001871 RID: 6257
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001872 RID: 6258
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001873 RID: 6259
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__5_0_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}
