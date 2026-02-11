using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	// Token: 0x02000057 RID: 87
	public class UnityWebRequestOperation : AsyncOperationBase<UnityWebRequest>
	{
		// Token: 0x0600053A RID: 1338 RVA: 0x00019F18 File Offset: 0x00018118
		// Note: this type is marked as 'beforefieldinit'.
		static UnityWebRequestOperation()
		{
			Il2CppClassPointerStore<UnityWebRequestOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.AsyncOperations", "UnityWebRequestOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityWebRequestOperation>.NativeClassPtr);
			UnityWebRequestOperation.NativeFieldInfoPtr_m_UWR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequestOperation>.NativeClassPtr, "m_UWR");
			UnityWebRequestOperation.NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestOperation>.NativeClassPtr, 100664186);
			UnityWebRequestOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestOperation>.NativeClassPtr, 100664187);
			UnityWebRequestOperation.NativeMethodInfoPtr__Execute_b__2_0_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestOperation>.NativeClassPtr, 100664188);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00019F98 File Offset: 0x00018198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1143782, RefRangeEnd = 1143783, XrefRangeStart = 1143778, XrefRangeEnd = 1143782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequestOperation(UnityWebRequest webRequest)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequestOperation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestOperation.NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00019FE4 File Offset: 0x000181E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143783, XrefRangeEnd = 1143792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityWebRequestOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0001A020 File Offset: 0x00018220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143792, XrefRangeEnd = 1143798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Execute_b__2_0(AsyncOperation request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestOperation.NativeMethodInfoPtr__Execute_b__2_0_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00003EA1 File Offset: 0x000020A1
		public UnityWebRequestOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0001A064 File Offset: 0x00018264
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00003EAA File Offset: 0x000020AA
		public unsafe UnityWebRequest m_UWR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestOperation.NativeFieldInfoPtr_m_UWR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestOperation.NativeFieldInfoPtr_m_UWR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeFieldInfoPtr_m_UWR;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr__Execute_b__2_0_Private_Void_AsyncOperation_0;
	}
}
