using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public class AssetBundleUnloadOperation : AsyncOperation
	{
		// Token: 0x06000061 RID: 97 RVA: 0x000036A8 File Offset: 0x000018A8
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleUnloadOperation()
		{
			Il2CppClassPointerStore<AssetBundleUnloadOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundleUnloadOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleUnloadOperation>.NativeClassPtr);
			AssetBundleUnloadOperation.NativeMethodInfoPtr_WaitForCompletion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleUnloadOperation>.NativeClassPtr, 100663331);
			AssetBundleUnloadOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleUnloadOperation>.NativeClassPtr, 100663332);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003700 File Offset: 0x00001900
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1270137, RefRangeEnd = 1270139, XrefRangeStart = 1270135, XrefRangeEnd = 1270137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleUnloadOperation.NativeMethodInfoPtr_WaitForCompletion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003734 File Offset: 0x00001934
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleUnloadOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleUnloadOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleUnloadOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000210D File Offset: 0x0000030D
		public AssetBundleUnloadOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Void_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
