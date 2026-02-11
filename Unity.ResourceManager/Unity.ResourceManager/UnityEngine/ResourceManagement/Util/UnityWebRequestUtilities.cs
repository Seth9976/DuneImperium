using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x0200002A RID: 42
	public class UnityWebRequestUtilities : Object
	{
		// Token: 0x06000223 RID: 547 RVA: 0x0000D490 File Offset: 0x0000B690
		// Note: this type is marked as 'beforefieldinit'.
		static UnityWebRequestUtilities()
		{
			Il2CppClassPointerStore<UnityWebRequestUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "UnityWebRequestUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityWebRequestUtilities>.NativeClassPtr);
			UnityWebRequestUtilities.NativeMethodInfoPtr_RequestHasErrors_Public_Static_Boolean_UnityWebRequest_byref_UnityWebRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestUtilities>.NativeClassPtr, 100663662);
			UnityWebRequestUtilities.NativeMethodInfoPtr_IsAssetBundleDownloaded_Public_Static_Boolean_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestUtilities>.NativeClassPtr, 100663663);
			UnityWebRequestUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestUtilities>.NativeClassPtr, 100663664);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000D4FC File Offset: 0x0000B6FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1139155, RefRangeEnd = 1139159, XrefRangeStart = 1139151, XrefRangeEnd = 1139155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestHasErrors(UnityWebRequest webReq, out UnityWebRequestResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(webReq);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestUtilities.NativeMethodInfoPtr_RequestHasErrors_Public_Static_Boolean_UnityWebRequest_byref_UnityWebRequestResult_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new UnityWebRequestResult(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000D560 File Offset: 0x0000B760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1139167, RefRangeEnd = 1139168, XrefRangeStart = 1139159, XrefRangeEnd = 1139167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAssetBundleDownloaded(UnityWebRequestAsyncOperation op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestUtilities.NativeMethodInfoPtr_IsAssetBundleDownloaded_Public_Static_Boolean_UnityWebRequestAsyncOperation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000D5A4 File Offset: 0x0000B7A4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequestUtilities()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequestUtilities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002D96 File Offset: 0x00000F96
		public UnityWebRequestUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_RequestHasErrors_Public_Static_Boolean_UnityWebRequest_byref_UnityWebRequestResult_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_IsAssetBundleDownloaded_Public_Static_Boolean_UnityWebRequestAsyncOperation_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
