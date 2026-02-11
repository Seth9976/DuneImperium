using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000022 RID: 34
	public class ComputeBufferPool : RenderGraphResourcePool<ComputeBuffer>
	{
		// Token: 0x06000314 RID: 788 RVA: 0x00018B14 File Offset: 0x00016D14
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeBufferPool()
		{
			Il2CppClassPointerStore<ComputeBufferPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "ComputeBufferPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeBufferPool>.NativeClassPtr);
			ComputeBufferPool.NativeMethodInfoPtr_ReleaseInternalResource_Protected_Virtual_Void_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferPool>.NativeClassPtr, 100663672);
			ComputeBufferPool.NativeMethodInfoPtr_GetResourceName_Protected_Virtual_String_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferPool>.NativeClassPtr, 100663673);
			ComputeBufferPool.NativeMethodInfoPtr_GetResourceSize_Protected_Virtual_Int64_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferPool>.NativeClassPtr, 100663674);
			ComputeBufferPool.NativeMethodInfoPtr_GetResourceTypeName_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferPool>.NativeClassPtr, 100663675);
			ComputeBufferPool.NativeMethodInfoPtr_GetSortIndex_Protected_Virtual_Int32_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferPool>.NativeClassPtr, 100663676);
			ComputeBufferPool.NativeMethodInfoPtr_PurgeUnusedResources_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferPool>.NativeClassPtr, 100663677);
			ComputeBufferPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferPool>.NativeClassPtr, 100663678);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00018BD0 File Offset: 0x00016DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957453, XrefRangeEnd = 957455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleaseInternalResource(ComputeBuffer res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComputeBufferPool.NativeMethodInfoPtr_ReleaseInternalResource_Protected_Virtual_Void_ComputeBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00018C20 File Offset: 0x00016E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957455, XrefRangeEnd = 957457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetResourceName(ComputeBuffer res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComputeBufferPool.NativeMethodInfoPtr_GetResourceName_Protected_Virtual_String_ComputeBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00018C74 File Offset: 0x00016E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957457, XrefRangeEnd = 957459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long GetResourceSize(ComputeBuffer res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComputeBufferPool.NativeMethodInfoPtr_GetResourceSize_Protected_Virtual_Int64_ComputeBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00018CCC File Offset: 0x00016ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957459, XrefRangeEnd = 957461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetResourceTypeName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComputeBufferPool.NativeMethodInfoPtr_GetResourceTypeName_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00018D10 File Offset: 0x00016F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetSortIndex(ComputeBuffer res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComputeBufferPool.NativeMethodInfoPtr_GetSortIndex_Protected_Virtual_Int32_ComputeBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00018D68 File Offset: 0x00016F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957461, XrefRangeEnd = 957518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PurgeUnusedResources(int currentFrameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentFrameIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComputeBufferPool.NativeMethodInfoPtr_PurgeUnusedResources_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00018DB4 File Offset: 0x00016FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957518, XrefRangeEnd = 957521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBufferPool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBufferPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000034CF File Offset: 0x000016CF
		public ComputeBufferPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInternalResource_Protected_Virtual_Void_ComputeBuffer_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceName_Protected_Virtual_String_ComputeBuffer_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceSize_Protected_Virtual_Int64_ComputeBuffer_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceTypeName_Protected_Virtual_String_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_GetSortIndex_Protected_Virtual_Int32_ComputeBuffer_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_PurgeUnusedResources_Public_Virtual_Void_Int32_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
