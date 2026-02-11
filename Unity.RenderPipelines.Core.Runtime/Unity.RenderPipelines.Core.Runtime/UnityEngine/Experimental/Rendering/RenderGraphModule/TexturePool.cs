using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000031 RID: 49
	public class TexturePool : RenderGraphResourcePool<RTHandle>
	{
		// Token: 0x06000436 RID: 1078 RVA: 0x0001D0FC File Offset: 0x0001B2FC
		// Note: this type is marked as 'beforefieldinit'.
		static TexturePool()
		{
			Il2CppClassPointerStore<TexturePool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "TexturePool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePool>.NativeClassPtr);
			TexturePool.NativeMethodInfoPtr_ReleaseInternalResource_Protected_Virtual_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100663824);
			TexturePool.NativeMethodInfoPtr_GetResourceName_Protected_Virtual_String_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100663825);
			TexturePool.NativeMethodInfoPtr_GetResourceSize_Protected_Virtual_Int64_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100663826);
			TexturePool.NativeMethodInfoPtr_GetResourceTypeName_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100663827);
			TexturePool.NativeMethodInfoPtr_GetSortIndex_Protected_Virtual_Int32_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100663828);
			TexturePool.NativeMethodInfoPtr_PurgeUnusedResources_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100663829);
			TexturePool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100663830);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0001D1B8 File Offset: 0x0001B3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958690, XrefRangeEnd = 958692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleaseInternalResource(RTHandle res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TexturePool.NativeMethodInfoPtr_ReleaseInternalResource_Protected_Virtual_Void_RTHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0001D208 File Offset: 0x0001B408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958692, XrefRangeEnd = 958694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetResourceName(RTHandle res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TexturePool.NativeMethodInfoPtr_GetResourceName_Protected_Virtual_String_RTHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0001D25C File Offset: 0x0001B45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958694, XrefRangeEnd = 958696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long GetResourceSize(RTHandle res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TexturePool.NativeMethodInfoPtr_GetResourceSize_Protected_Virtual_Int64_RTHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0001D2B4 File Offset: 0x0001B4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958696, XrefRangeEnd = 958698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetResourceTypeName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TexturePool.NativeMethodInfoPtr_GetResourceTypeName_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0001D2F8 File Offset: 0x0001B4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958698, XrefRangeEnd = 958700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetSortIndex(RTHandle res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TexturePool.NativeMethodInfoPtr_GetSortIndex_Protected_Virtual_Int32_RTHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0001D350 File Offset: 0x0001B550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958700, XrefRangeEnd = 958757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PurgeUnusedResources(int currentFrameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentFrameIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TexturePool.NativeMethodInfoPtr_PurgeUnusedResources_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0001D39C File Offset: 0x0001B59C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 958760, RefRangeEnd = 958761, XrefRangeStart = 958757, XrefRangeEnd = 958760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TexturePool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TexturePool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00003BD2 File Offset: 0x00001DD2
		public TexturePool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInternalResource_Protected_Virtual_Void_RTHandle_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceName_Protected_Virtual_String_RTHandle_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceSize_Protected_Virtual_Int64_RTHandle_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceTypeName_Protected_Virtual_String_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_GetSortIndex_Protected_Virtual_Int32_RTHandle_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_PurgeUnusedResources_Public_Virtual_Void_Int32_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
