using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000021 RID: 33
	public class ComputeBufferResource : RenderGraphResource<ComputeBufferDesc, ComputeBuffer>
	{
		// Token: 0x0600030A RID: 778 RVA: 0x00018810 File Offset: 0x00016A10
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeBufferResource()
		{
			Il2CppClassPointerStore<ComputeBufferResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "ComputeBufferResource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeBufferResource>.NativeClassPtr);
			ComputeBufferResource.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferResource>.NativeClassPtr, 100663664);
			ComputeBufferResource.NativeMethodInfoPtr_CreatePooledGraphicsResource_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferResource>.NativeClassPtr, 100663665);
			ComputeBufferResource.NativeMethodInfoPtr_ReleasePooledGraphicsResource_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferResource>.NativeClassPtr, 100663666);
			ComputeBufferResource.NativeMethodInfoPtr_CreateGraphicsResource_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferResource>.NativeClassPtr, 100663667);
			ComputeBufferResource.NativeMethodInfoPtr_ReleaseGraphicsResource_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferResource>.NativeClassPtr, 100663668);
			ComputeBufferResource.NativeMethodInfoPtr_LogCreation_Public_Virtual_Void_RenderGraphLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferResource>.NativeClassPtr, 100663669);
			ComputeBufferResource.NativeMethodInfoPtr_LogRelease_Public_Virtual_Void_RenderGraphLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferResource>.NativeClassPtr, 100663670);
			ComputeBufferResource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferResource>.NativeClassPtr, 100663671);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000188E0 File Offset: 0x00016AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957371, XrefRangeEnd = 957372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComputeBufferResource.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00018924 File Offset: 0x00016B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957372, XrefRangeEnd = 957392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreatePooledGraphicsResource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComputeBufferResource.NativeMethodInfoPtr_CreatePooledGraphicsResource_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00018960 File Offset: 0x00016B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957392, XrefRangeEnd = 957410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleasePooledGraphicsResource(int frameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref frameIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComputeBufferResource.NativeMethodInfoPtr_ReleasePooledGraphicsResource_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000189AC File Offset: 0x00016BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957410, XrefRangeEnd = 957430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateGraphicsResource(string name = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComputeBufferResource.NativeMethodInfoPtr_CreateGraphicsResource_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000189FC File Offset: 0x00016BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957430, XrefRangeEnd = 957434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleaseGraphicsResource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComputeBufferResource.NativeMethodInfoPtr_ReleaseGraphicsResource_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00018A38 File Offset: 0x00016C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957434, XrefRangeEnd = 957442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LogCreation(RenderGraphLogger logger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComputeBufferResource.NativeMethodInfoPtr_LogCreation_Public_Virtual_Void_RenderGraphLogger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00018A88 File Offset: 0x00016C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957442, XrefRangeEnd = 957450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LogRelease(RenderGraphLogger logger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComputeBufferResource.NativeMethodInfoPtr_LogRelease_Public_Virtual_Void_RenderGraphLogger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00018AD8 File Offset: 0x00016CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957450, XrefRangeEnd = 957453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferResource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBufferResource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBufferResource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000034C6 File Offset: 0x000016C6
		public ComputeBufferResource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_CreatePooledGraphicsResource_Public_Virtual_Void_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePooledGraphicsResource_Public_Virtual_Void_Int32_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_CreateGraphicsResource_Public_Virtual_Void_String_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseGraphicsResource_Public_Virtual_Void_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_LogCreation_Public_Virtual_Void_RenderGraphLogger_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_LogRelease_Public_Virtual_Void_RenderGraphLogger_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
