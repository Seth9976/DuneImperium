using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000011 RID: 17
	public sealed class RenderGraphExecution : ValueType
	{
		// Token: 0x0600014E RID: 334 RVA: 0x00012068 File Offset: 0x00010268
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphExecution()
		{
			Il2CppClassPointerStore<RenderGraphExecution>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphExecution");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphExecution>.NativeClassPtr);
			RenderGraphExecution.NativeFieldInfoPtr_renderGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphExecution>.NativeClassPtr, "renderGraph");
			RenderGraphExecution.NativeMethodInfoPtr__ctor_Internal_Void_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphExecution>.NativeClassPtr, 100663417);
			RenderGraphExecution.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphExecution>.NativeClassPtr, 100663418);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000120D4 File Offset: 0x000102D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphExecution(RenderGraph renderGraph)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphExecution>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphExecution.NativeMethodInfoPtr__ctor_Internal_Void_RenderGraph_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00012124 File Offset: 0x00010324
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 954597, RefRangeEnd = 954599, XrefRangeStart = 954595, XrefRangeEnd = 954597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphExecution.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002977 File Offset: 0x00000B77
		public RenderGraphExecution(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002980 File Offset: 0x00000B80
		public RenderGraphExecution()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphExecution>.NativeClassPtr))
		{
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0001215C File Offset: 0x0001035C
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002992 File Offset: 0x00000B92
		public unsafe RenderGraph renderGraph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphExecution.NativeFieldInfoPtr_renderGraph);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraph>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphExecution.NativeFieldInfoPtr_renderGraph), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_renderGraph;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RenderGraph_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
