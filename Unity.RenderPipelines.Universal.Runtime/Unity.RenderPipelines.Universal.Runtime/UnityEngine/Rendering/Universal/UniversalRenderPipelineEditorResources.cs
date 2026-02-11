using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000054 RID: 84
	public class UniversalRenderPipelineEditorResources : ScriptableObject
	{
		// Token: 0x06000700 RID: 1792 RVA: 0x0002DBFC File Offset: 0x0002BDFC
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalRenderPipelineEditorResources()
		{
			Il2CppClassPointerStore<UniversalRenderPipelineEditorResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalRenderPipelineEditorResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources>.NativeClassPtr);
			UniversalRenderPipelineEditorResources.NativeFieldInfoPtr_shaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources>.NativeClassPtr, "shaders");
			UniversalRenderPipelineEditorResources.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources>.NativeClassPtr, "materials");
			UniversalRenderPipelineEditorResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources>.NativeClassPtr, 100664112);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0002DC68 File Offset: 0x0002BE68
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalRenderPipelineEditorResources()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineEditorResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00005147 File Offset: 0x00003347
		public UniversalRenderPipelineEditorResources(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x0002DCA4 File Offset: 0x0002BEA4
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00005150 File Offset: 0x00003350
		public unsafe UniversalRenderPipelineEditorResources.ShaderResources shaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.NativeFieldInfoPtr_shaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalRenderPipelineEditorResources.ShaderResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.NativeFieldInfoPtr_shaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x0002DCD4 File Offset: 0x0002BED4
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x0000516F File Offset: 0x0000336F
		public unsafe UniversalRenderPipelineEditorResources.MaterialResources materials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.NativeFieldInfoPtr_materials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalRenderPipelineEditorResources.MaterialResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeFieldInfoPtr_shaders;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeFieldInfoPtr_materials;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000169 RID: 361
		[Serializable]
		public sealed class ShaderResources : Object
		{
			// Token: 0x06001BE3 RID: 7139 RVA: 0x0007367C File Offset: 0x0007187C
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderResources()
			{
				Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.ShaderResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources>.NativeClassPtr, "ShaderResources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.ShaderResources>.NativeClassPtr);
				UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_autodeskInteractivePS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.ShaderResources>.NativeClassPtr, "autodeskInteractivePS");
				UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_autodeskInteractiveTransparentPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.ShaderResources>.NativeClassPtr, "autodeskInteractiveTransparentPS");
				UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_autodeskInteractiveMaskedPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.ShaderResources>.NativeClassPtr, "autodeskInteractiveMaskedPS");
				UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_defaultSpeedTree7PS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.ShaderResources>.NativeClassPtr, "defaultSpeedTree7PS");
				UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_defaultSpeedTree8PS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.ShaderResources>.NativeClassPtr, "defaultSpeedTree8PS");
				UniversalRenderPipelineEditorResources.ShaderResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.ShaderResources>.NativeClassPtr, 100664113);
			}

			// Token: 0x06001BE4 RID: 7140 RVA: 0x00073720 File Offset: 0x00071920
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShaderResources()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.ShaderResources>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineEditorResources.ShaderResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BE5 RID: 7141 RVA: 0x0000FD4F File Offset: 0x0000DF4F
			public ShaderResources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A02 RID: 2562
			// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x0007375C File Offset: 0x0007195C
			// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x0000FD58 File Offset: 0x0000DF58
			public unsafe Shader autodeskInteractivePS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_autodeskInteractivePS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_autodeskInteractivePS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A03 RID: 2563
			// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x0007378C File Offset: 0x0007198C
			// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x0000FD77 File Offset: 0x0000DF77
			public unsafe Shader autodeskInteractiveTransparentPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_autodeskInteractiveTransparentPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_autodeskInteractiveTransparentPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A04 RID: 2564
			// (get) Token: 0x06001BEA RID: 7146 RVA: 0x000737BC File Offset: 0x000719BC
			// (set) Token: 0x06001BEB RID: 7147 RVA: 0x0000FD96 File Offset: 0x0000DF96
			public unsafe Shader autodeskInteractiveMaskedPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_autodeskInteractiveMaskedPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_autodeskInteractiveMaskedPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A05 RID: 2565
			// (get) Token: 0x06001BEC RID: 7148 RVA: 0x000737EC File Offset: 0x000719EC
			// (set) Token: 0x06001BED RID: 7149 RVA: 0x0000FDB5 File Offset: 0x0000DFB5
			public unsafe Shader defaultSpeedTree7PS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_defaultSpeedTree7PS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_defaultSpeedTree7PS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A06 RID: 2566
			// (get) Token: 0x06001BEE RID: 7150 RVA: 0x0007381C File Offset: 0x00071A1C
			// (set) Token: 0x06001BEF RID: 7151 RVA: 0x0000FDD4 File Offset: 0x0000DFD4
			public unsafe Shader defaultSpeedTree8PS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_defaultSpeedTree8PS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.ShaderResources.NativeFieldInfoPtr_defaultSpeedTree8PS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001456 RID: 5206
			private static readonly IntPtr NativeFieldInfoPtr_autodeskInteractivePS;

			// Token: 0x04001457 RID: 5207
			private static readonly IntPtr NativeFieldInfoPtr_autodeskInteractiveTransparentPS;

			// Token: 0x04001458 RID: 5208
			private static readonly IntPtr NativeFieldInfoPtr_autodeskInteractiveMaskedPS;

			// Token: 0x04001459 RID: 5209
			private static readonly IntPtr NativeFieldInfoPtr_defaultSpeedTree7PS;

			// Token: 0x0400145A RID: 5210
			private static readonly IntPtr NativeFieldInfoPtr_defaultSpeedTree8PS;

			// Token: 0x0400145B RID: 5211
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200016A RID: 362
		[Serializable]
		public sealed class MaterialResources : Object
		{
			// Token: 0x06001BF0 RID: 7152 RVA: 0x0007384C File Offset: 0x00071A4C
			// Note: this type is marked as 'beforefieldinit'.
			static MaterialResources()
			{
				Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.MaterialResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources>.NativeClassPtr, "MaterialResources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.MaterialResources>.NativeClassPtr);
				UniversalRenderPipelineEditorResources.MaterialResources.NativeFieldInfoPtr_lit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.MaterialResources>.NativeClassPtr, "lit");
				UniversalRenderPipelineEditorResources.MaterialResources.NativeFieldInfoPtr_particleLit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.MaterialResources>.NativeClassPtr, "particleLit");
				UniversalRenderPipelineEditorResources.MaterialResources.NativeFieldInfoPtr_terrainLit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.MaterialResources>.NativeClassPtr, "terrainLit");
				UniversalRenderPipelineEditorResources.MaterialResources.NativeFieldInfoPtr_decal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.MaterialResources>.NativeClassPtr, "decal");
				UniversalRenderPipelineEditorResources.MaterialResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.MaterialResources>.NativeClassPtr, 100664114);
			}

			// Token: 0x06001BF1 RID: 7153 RVA: 0x000738DC File Offset: 0x00071ADC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MaterialResources()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderPipelineEditorResources.MaterialResources>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineEditorResources.MaterialResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BF2 RID: 7154 RVA: 0x0000FDF3 File Offset: 0x0000DFF3
			public MaterialResources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A07 RID: 2567
			// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00073918 File Offset: 0x00071B18
			// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x0000FDFC File Offset: 0x0000DFFC
			public unsafe Material lit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.MaterialResources.NativeFieldInfoPtr_lit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.MaterialResources.NativeFieldInfoPtr_lit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A08 RID: 2568
			// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x00073948 File Offset: 0x00071B48
			// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x0000FE1B File Offset: 0x0000E01B
			public unsafe Material particleLit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.MaterialResources.NativeFieldInfoPtr_particleLit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.MaterialResources.NativeFieldInfoPtr_particleLit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A09 RID: 2569
			// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x00073978 File Offset: 0x00071B78
			// (set) Token: 0x06001BF8 RID: 7160 RVA: 0x0000FE3A File Offset: 0x0000E03A
			public unsafe Material terrainLit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.MaterialResources.NativeFieldInfoPtr_terrainLit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.MaterialResources.NativeFieldInfoPtr_terrainLit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A0A RID: 2570
			// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x000739A8 File Offset: 0x00071BA8
			// (set) Token: 0x06001BFA RID: 7162 RVA: 0x0000FE59 File Offset: 0x0000E059
			public unsafe Material decal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.MaterialResources.NativeFieldInfoPtr_decal);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineEditorResources.MaterialResources.NativeFieldInfoPtr_decal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400145C RID: 5212
			private static readonly IntPtr NativeFieldInfoPtr_lit;

			// Token: 0x0400145D RID: 5213
			private static readonly IntPtr NativeFieldInfoPtr_particleLit;

			// Token: 0x0400145E RID: 5214
			private static readonly IntPtr NativeFieldInfoPtr_terrainLit;

			// Token: 0x0400145F RID: 5215
			private static readonly IntPtr NativeFieldInfoPtr_decal;

			// Token: 0x04001460 RID: 5216
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
