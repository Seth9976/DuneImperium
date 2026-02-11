using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200003F RID: 63
	[Serializable]
	public class PostProcessData : ScriptableObject
	{
		// Token: 0x060005C1 RID: 1473 RVA: 0x00029904 File Offset: 0x00027B04
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessData()
		{
			Il2CppClassPointerStore<PostProcessData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PostProcessData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessData>.NativeClassPtr);
			PostProcessData.NativeFieldInfoPtr_shaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData>.NativeClassPtr, "shaders");
			PostProcessData.NativeFieldInfoPtr_textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData>.NativeClassPtr, "textures");
			PostProcessData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessData>.NativeClassPtr, 100663966);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00029970 File Offset: 0x00027B70
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00004862 File Offset: 0x00002A62
		public PostProcessData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x000299AC File Offset: 0x00027BAC
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x0000486B File Offset: 0x00002A6B
		public unsafe PostProcessData.ShaderResources shaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.NativeFieldInfoPtr_shaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessData.ShaderResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.NativeFieldInfoPtr_shaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x000299DC File Offset: 0x00027BDC
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x0000488A File Offset: 0x00002A8A
		public unsafe PostProcessData.TextureResources textures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.NativeFieldInfoPtr_textures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessData.TextureResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.NativeFieldInfoPtr_textures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeFieldInfoPtr_shaders;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeFieldInfoPtr_textures;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000166 RID: 358
		[Serializable]
		public sealed class ShaderResources : Object
		{
			// Token: 0x06001BAF RID: 7087 RVA: 0x00072F24 File Offset: 0x00071124
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderResources()
			{
				Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessData>.NativeClassPtr, "ShaderResources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr);
				PostProcessData.ShaderResources.NativeFieldInfoPtr_stopNanPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "stopNanPS");
				PostProcessData.ShaderResources.NativeFieldInfoPtr_subpixelMorphologicalAntialiasingPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "subpixelMorphologicalAntialiasingPS");
				PostProcessData.ShaderResources.NativeFieldInfoPtr_gaussianDepthOfFieldPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "gaussianDepthOfFieldPS");
				PostProcessData.ShaderResources.NativeFieldInfoPtr_bokehDepthOfFieldPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "bokehDepthOfFieldPS");
				PostProcessData.ShaderResources.NativeFieldInfoPtr_cameraMotionBlurPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "cameraMotionBlurPS");
				PostProcessData.ShaderResources.NativeFieldInfoPtr_paniniProjectionPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "paniniProjectionPS");
				PostProcessData.ShaderResources.NativeFieldInfoPtr_lutBuilderLdrPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "lutBuilderLdrPS");
				PostProcessData.ShaderResources.NativeFieldInfoPtr_lutBuilderHdrPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "lutBuilderHdrPS");
				PostProcessData.ShaderResources.NativeFieldInfoPtr_bloomPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "bloomPS");
				PostProcessData.ShaderResources.NativeFieldInfoPtr_temporalAntialiasingPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "temporalAntialiasingPS");
				PostProcessData.ShaderResources.NativeFieldInfoPtr_LensFlareDataDrivenPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "LensFlareDataDrivenPS");
				PostProcessData.ShaderResources.NativeFieldInfoPtr_scalingSetupPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "scalingSetupPS");
				PostProcessData.ShaderResources.NativeFieldInfoPtr_easuPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "easuPS");
				PostProcessData.ShaderResources.NativeFieldInfoPtr_uberPostPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "uberPostPS");
				PostProcessData.ShaderResources.NativeFieldInfoPtr_finalPostPassPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, "finalPostPassPS");
				PostProcessData.ShaderResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr, 100663967);
			}

			// Token: 0x06001BB0 RID: 7088 RVA: 0x00073090 File Offset: 0x00071290
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShaderResources()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessData.ShaderResources>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessData.ShaderResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BB1 RID: 7089 RVA: 0x0000FAA9 File Offset: 0x0000DCA9
			public ShaderResources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009ED RID: 2541
			// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x000730CC File Offset: 0x000712CC
			// (set) Token: 0x06001BB3 RID: 7091 RVA: 0x0000FAB2 File Offset: 0x0000DCB2
			public unsafe Shader stopNanPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_stopNanPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_stopNanPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009EE RID: 2542
			// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x000730FC File Offset: 0x000712FC
			// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x0000FAD1 File Offset: 0x0000DCD1
			public unsafe Shader subpixelMorphologicalAntialiasingPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_subpixelMorphologicalAntialiasingPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_subpixelMorphologicalAntialiasingPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009EF RID: 2543
			// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x0007312C File Offset: 0x0007132C
			// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x0000FAF0 File Offset: 0x0000DCF0
			public unsafe Shader gaussianDepthOfFieldPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_gaussianDepthOfFieldPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_gaussianDepthOfFieldPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F0 RID: 2544
			// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x0007315C File Offset: 0x0007135C
			// (set) Token: 0x06001BB9 RID: 7097 RVA: 0x0000FB0F File Offset: 0x0000DD0F
			public unsafe Shader bokehDepthOfFieldPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_bokehDepthOfFieldPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_bokehDepthOfFieldPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F1 RID: 2545
			// (get) Token: 0x06001BBA RID: 7098 RVA: 0x0007318C File Offset: 0x0007138C
			// (set) Token: 0x06001BBB RID: 7099 RVA: 0x0000FB2E File Offset: 0x0000DD2E
			public unsafe Shader cameraMotionBlurPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_cameraMotionBlurPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_cameraMotionBlurPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F2 RID: 2546
			// (get) Token: 0x06001BBC RID: 7100 RVA: 0x000731BC File Offset: 0x000713BC
			// (set) Token: 0x06001BBD RID: 7101 RVA: 0x0000FB4D File Offset: 0x0000DD4D
			public unsafe Shader paniniProjectionPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_paniniProjectionPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_paniniProjectionPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F3 RID: 2547
			// (get) Token: 0x06001BBE RID: 7102 RVA: 0x000731EC File Offset: 0x000713EC
			// (set) Token: 0x06001BBF RID: 7103 RVA: 0x0000FB6C File Offset: 0x0000DD6C
			public unsafe Shader lutBuilderLdrPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_lutBuilderLdrPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_lutBuilderLdrPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F4 RID: 2548
			// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x0007321C File Offset: 0x0007141C
			// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x0000FB8B File Offset: 0x0000DD8B
			public unsafe Shader lutBuilderHdrPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_lutBuilderHdrPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_lutBuilderHdrPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F5 RID: 2549
			// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x0007324C File Offset: 0x0007144C
			// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x0000FBAA File Offset: 0x0000DDAA
			public unsafe Shader bloomPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_bloomPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_bloomPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F6 RID: 2550
			// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x0007327C File Offset: 0x0007147C
			// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x0000FBC9 File Offset: 0x0000DDC9
			public unsafe Shader temporalAntialiasingPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_temporalAntialiasingPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_temporalAntialiasingPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F7 RID: 2551
			// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x000732AC File Offset: 0x000714AC
			// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
			public unsafe Shader LensFlareDataDrivenPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_LensFlareDataDrivenPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_LensFlareDataDrivenPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F8 RID: 2552
			// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x000732DC File Offset: 0x000714DC
			// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x0000FC07 File Offset: 0x0000DE07
			public unsafe Shader scalingSetupPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_scalingSetupPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_scalingSetupPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F9 RID: 2553
			// (get) Token: 0x06001BCA RID: 7114 RVA: 0x0007330C File Offset: 0x0007150C
			// (set) Token: 0x06001BCB RID: 7115 RVA: 0x0000FC26 File Offset: 0x0000DE26
			public unsafe Shader easuPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_easuPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_easuPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FA RID: 2554
			// (get) Token: 0x06001BCC RID: 7116 RVA: 0x0007333C File Offset: 0x0007153C
			// (set) Token: 0x06001BCD RID: 7117 RVA: 0x0000FC45 File Offset: 0x0000DE45
			public unsafe Shader uberPostPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_uberPostPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_uberPostPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FB RID: 2555
			// (get) Token: 0x06001BCE RID: 7118 RVA: 0x0007336C File Offset: 0x0007156C
			// (set) Token: 0x06001BCF RID: 7119 RVA: 0x0000FC64 File Offset: 0x0000DE64
			public unsafe Shader finalPostPassPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_finalPostPassPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.ShaderResources.NativeFieldInfoPtr_finalPostPassPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400143D RID: 5181
			private static readonly IntPtr NativeFieldInfoPtr_stopNanPS;

			// Token: 0x0400143E RID: 5182
			private static readonly IntPtr NativeFieldInfoPtr_subpixelMorphologicalAntialiasingPS;

			// Token: 0x0400143F RID: 5183
			private static readonly IntPtr NativeFieldInfoPtr_gaussianDepthOfFieldPS;

			// Token: 0x04001440 RID: 5184
			private static readonly IntPtr NativeFieldInfoPtr_bokehDepthOfFieldPS;

			// Token: 0x04001441 RID: 5185
			private static readonly IntPtr NativeFieldInfoPtr_cameraMotionBlurPS;

			// Token: 0x04001442 RID: 5186
			private static readonly IntPtr NativeFieldInfoPtr_paniniProjectionPS;

			// Token: 0x04001443 RID: 5187
			private static readonly IntPtr NativeFieldInfoPtr_lutBuilderLdrPS;

			// Token: 0x04001444 RID: 5188
			private static readonly IntPtr NativeFieldInfoPtr_lutBuilderHdrPS;

			// Token: 0x04001445 RID: 5189
			private static readonly IntPtr NativeFieldInfoPtr_bloomPS;

			// Token: 0x04001446 RID: 5190
			private static readonly IntPtr NativeFieldInfoPtr_temporalAntialiasingPS;

			// Token: 0x04001447 RID: 5191
			private static readonly IntPtr NativeFieldInfoPtr_LensFlareDataDrivenPS;

			// Token: 0x04001448 RID: 5192
			private static readonly IntPtr NativeFieldInfoPtr_scalingSetupPS;

			// Token: 0x04001449 RID: 5193
			private static readonly IntPtr NativeFieldInfoPtr_easuPS;

			// Token: 0x0400144A RID: 5194
			private static readonly IntPtr NativeFieldInfoPtr_uberPostPS;

			// Token: 0x0400144B RID: 5195
			private static readonly IntPtr NativeFieldInfoPtr_finalPostPassPS;

			// Token: 0x0400144C RID: 5196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000167 RID: 359
		[Serializable]
		public sealed class TextureResources : Object
		{
			// Token: 0x06001BD0 RID: 7120 RVA: 0x0007339C File Offset: 0x0007159C
			// Note: this type is marked as 'beforefieldinit'.
			static TextureResources()
			{
				Il2CppClassPointerStore<PostProcessData.TextureResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessData>.NativeClassPtr, "TextureResources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessData.TextureResources>.NativeClassPtr);
				PostProcessData.TextureResources.NativeFieldInfoPtr_blueNoise16LTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.TextureResources>.NativeClassPtr, "blueNoise16LTex");
				PostProcessData.TextureResources.NativeFieldInfoPtr_filmGrainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.TextureResources>.NativeClassPtr, "filmGrainTex");
				PostProcessData.TextureResources.NativeFieldInfoPtr_smaaAreaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.TextureResources>.NativeClassPtr, "smaaAreaTex");
				PostProcessData.TextureResources.NativeFieldInfoPtr_smaaSearchTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessData.TextureResources>.NativeClassPtr, "smaaSearchTex");
				PostProcessData.TextureResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessData.TextureResources>.NativeClassPtr, 100663968);
			}

			// Token: 0x06001BD1 RID: 7121 RVA: 0x0007342C File Offset: 0x0007162C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextureResources()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessData.TextureResources>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessData.TextureResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BD2 RID: 7122 RVA: 0x0000FC83 File Offset: 0x0000DE83
			public TextureResources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009FC RID: 2556
			// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x00073468 File Offset: 0x00071668
			// (set) Token: 0x06001BD4 RID: 7124 RVA: 0x0000FC8C File Offset: 0x0000DE8C
			public unsafe Il2CppReferenceArray<Texture2D> blueNoise16LTex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.TextureResources.NativeFieldInfoPtr_blueNoise16LTex);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.TextureResources.NativeFieldInfoPtr_blueNoise16LTex), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FD RID: 2557
			// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x00073498 File Offset: 0x00071698
			// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x0000FCAB File Offset: 0x0000DEAB
			public unsafe Il2CppReferenceArray<Texture2D> filmGrainTex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.TextureResources.NativeFieldInfoPtr_filmGrainTex);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.TextureResources.NativeFieldInfoPtr_filmGrainTex), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FE RID: 2558
			// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x000734C8 File Offset: 0x000716C8
			// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x0000FCCA File Offset: 0x0000DECA
			public unsafe Texture2D smaaAreaTex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.TextureResources.NativeFieldInfoPtr_smaaAreaTex);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.TextureResources.NativeFieldInfoPtr_smaaAreaTex), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FF RID: 2559
			// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x000734F8 File Offset: 0x000716F8
			// (set) Token: 0x06001BDA RID: 7130 RVA: 0x0000FCE9 File Offset: 0x0000DEE9
			public unsafe Texture2D smaaSearchTex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.TextureResources.NativeFieldInfoPtr_smaaSearchTex);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessData.TextureResources.NativeFieldInfoPtr_smaaSearchTex), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400144D RID: 5197
			private static readonly IntPtr NativeFieldInfoPtr_blueNoise16LTex;

			// Token: 0x0400144E RID: 5198
			private static readonly IntPtr NativeFieldInfoPtr_filmGrainTex;

			// Token: 0x0400144F RID: 5199
			private static readonly IntPtr NativeFieldInfoPtr_smaaAreaTex;

			// Token: 0x04001450 RID: 5200
			private static readonly IntPtr NativeFieldInfoPtr_smaaSearchTex;

			// Token: 0x04001451 RID: 5201
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
