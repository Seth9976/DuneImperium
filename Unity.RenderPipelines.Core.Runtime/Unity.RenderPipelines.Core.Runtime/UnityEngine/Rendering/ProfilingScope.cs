using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000079 RID: 121
	[StructLayout(2)]
	public struct ProfilingScope
	{
		// Token: 0x06000803 RID: 2051 RVA: 0x0002BB38 File Offset: 0x00029D38
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilingScope()
		{
			Il2CppClassPointerStore<ProfilingScope>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProfilingScope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilingScope>.NativeClassPtr);
			ProfilingScope.NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingScope>.NativeClassPtr, 100664575);
			ProfilingScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingScope>.NativeClassPtr, 100664576);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0002BB90 File Offset: 0x00029D90
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilingScope(CommandBuffer cmd, ProfilingSampler sampler)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sampler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingScope.NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_ProfilingSampler_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0002BBD8 File Offset: 0x00029DD8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00005277 File Offset: 0x00003477
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilingScope>.NativeClassPtr, ref this));
		}

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_ProfilingSampler_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
