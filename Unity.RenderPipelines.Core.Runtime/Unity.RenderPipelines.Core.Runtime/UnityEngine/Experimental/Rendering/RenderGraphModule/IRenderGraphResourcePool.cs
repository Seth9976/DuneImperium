using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000023 RID: 35
	public class IRenderGraphResourcePool : Object
	{
		// Token: 0x0600031D RID: 797 RVA: 0x00018DF0 File Offset: 0x00016FF0
		// Note: this type is marked as 'beforefieldinit'.
		static IRenderGraphResourcePool()
		{
			Il2CppClassPointerStore<IRenderGraphResourcePool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "IRenderGraphResourcePool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IRenderGraphResourcePool>.NativeClassPtr);
			IRenderGraphResourcePool.NativeMethodInfoPtr_PurgeUnusedResources_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResourcePool>.NativeClassPtr, 100663679);
			IRenderGraphResourcePool.NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResourcePool>.NativeClassPtr, 100663680);
			IRenderGraphResourcePool.NativeMethodInfoPtr_CheckFrameAllocation_Public_Abstract_Virtual_New_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResourcePool>.NativeClassPtr, 100663681);
			IRenderGraphResourcePool.NativeMethodInfoPtr_LogResources_Public_Abstract_Virtual_New_Void_RenderGraphLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResourcePool>.NativeClassPtr, 100663682);
			IRenderGraphResourcePool.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResourcePool>.NativeClassPtr, 100663683);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00018E84 File Offset: 0x00017084
		[CallerCount(0)]
		public unsafe virtual void PurgeUnusedResources(int currentFrameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentFrameIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResourcePool.NativeMethodInfoPtr_PurgeUnusedResources_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00018ED0 File Offset: 0x000170D0
		[CallerCount(0)]
		public unsafe virtual void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResourcePool.NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00018F0C File Offset: 0x0001710C
		[CallerCount(0)]
		public unsafe virtual void CheckFrameAllocation(bool onException, int frameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onException;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResourcePool.NativeMethodInfoPtr_CheckFrameAllocation_Public_Abstract_Virtual_New_Void_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00018F64 File Offset: 0x00017164
		[CallerCount(0)]
		public unsafe virtual void LogResources(RenderGraphLogger logger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResourcePool.NativeMethodInfoPtr_LogResources_Public_Abstract_Virtual_New_Void_RenderGraphLogger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00018FB4 File Offset: 0x000171B4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRenderGraphResourcePool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IRenderGraphResourcePool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRenderGraphResourcePool.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000034D8 File Offset: 0x000016D8
		public IRenderGraphResourcePool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_PurgeUnusedResources_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_CheckFrameAllocation_Public_Abstract_Virtual_New_Void_Boolean_Int32_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_LogResources_Public_Abstract_Virtual_New_Void_RenderGraphLogger_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
