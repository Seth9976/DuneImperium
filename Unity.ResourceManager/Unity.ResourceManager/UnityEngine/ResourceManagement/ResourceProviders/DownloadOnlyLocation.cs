using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x0200002C RID: 44
	public class DownloadOnlyLocation : LocationWrapper
	{
		// Token: 0x0600023D RID: 573 RVA: 0x00002E3B File Offset: 0x0000103B
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadOnlyLocation()
		{
			Il2CppClassPointerStore<DownloadOnlyLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "DownloadOnlyLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadOnlyLocation>.NativeClassPtr);
			DownloadOnlyLocation.NativeMethodInfoPtr__ctor_Public_Void_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadOnlyLocation>.NativeClassPtr, 100663674);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000DA20 File Offset: 0x0000BC20
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadOnlyLocation(IResourceLocation location)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadOnlyLocation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadOnlyLocation.NativeMethodInfoPtr__ctor_Public_Void_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002E74 File Offset: 0x00001074
		public DownloadOnlyLocation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IResourceLocation_0;
	}
}
