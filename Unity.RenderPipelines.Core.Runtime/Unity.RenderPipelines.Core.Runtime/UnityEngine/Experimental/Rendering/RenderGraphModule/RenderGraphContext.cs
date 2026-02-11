using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x0200000F RID: 15
	public class RenderGraphContext : Object
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00011D7C File Offset: 0x0000FF7C
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphContext()
		{
			Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr);
			RenderGraphContext.NativeFieldInfoPtr_renderContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr, "renderContext");
			RenderGraphContext.NativeFieldInfoPtr_cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr, "cmd");
			RenderGraphContext.NativeFieldInfoPtr_renderGraphPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr, "renderGraphPool");
			RenderGraphContext.NativeFieldInfoPtr_defaultResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr, "defaultResources");
			RenderGraphContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr, 100663416);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00011E10 File Offset: 0x00010010
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000284C File Offset: 0x00000A4C
		public RenderGraphContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00011E4C File Offset: 0x0001004C
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00002855 File Offset: 0x00000A55
		public unsafe ScriptableRenderContext renderContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphContext.NativeFieldInfoPtr_renderContext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphContext.NativeFieldInfoPtr_renderContext)) = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00011E74 File Offset: 0x00010074
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002870 File Offset: 0x00000A70
		public unsafe CommandBuffer cmd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphContext.NativeFieldInfoPtr_cmd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphContext.NativeFieldInfoPtr_cmd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00011EA4 File Offset: 0x000100A4
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0000288F File Offset: 0x00000A8F
		public unsafe RenderGraphObjectPool renderGraphPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphContext.NativeFieldInfoPtr_renderGraphPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphObjectPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphContext.NativeFieldInfoPtr_renderGraphPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00011ED4 File Offset: 0x000100D4
		// (set) Token: 0x06000140 RID: 320 RVA: 0x000028AE File Offset: 0x00000AAE
		public unsafe RenderGraphDefaultResources defaultResources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphContext.NativeFieldInfoPtr_defaultResources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphDefaultResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphContext.NativeFieldInfoPtr_defaultResources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_renderContext;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_cmd;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_renderGraphPool;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_defaultResources;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
