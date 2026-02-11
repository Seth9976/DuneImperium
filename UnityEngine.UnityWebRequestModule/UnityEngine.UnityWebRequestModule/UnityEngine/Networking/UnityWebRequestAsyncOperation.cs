using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Networking
{
	// Token: 0x02000009 RID: 9
	public class UnityWebRequestAsyncOperation : AsyncOperation
	{
		// Token: 0x0600009C RID: 156 RVA: 0x000048A0 File Offset: 0x00002AA0
		// Note: this type is marked as 'beforefieldinit'.
		static UnityWebRequestAsyncOperation()
		{
			Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "UnityWebRequestAsyncOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr);
			UnityWebRequestAsyncOperation.NativeFieldInfoPtr__webRequest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr, "<webRequest>k__BackingField");
			UnityWebRequestAsyncOperation.NativeMethodInfoPtr_get_webRequest_Public_get_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr, 100663364);
			UnityWebRequestAsyncOperation.NativeMethodInfoPtr_set_webRequest_Internal_set_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr, 100663365);
			UnityWebRequestAsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr, 100663366);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00004920 File Offset: 0x00002B20
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00004960 File Offset: 0x00002B60
		public unsafe UnityWebRequest webRequest
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestAsyncOperation.NativeMethodInfoPtr_get_webRequest_Public_get_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestAsyncOperation.NativeMethodInfoPtr_set_webRequest_Internal_set_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000049A4 File Offset: 0x00002BA4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequestAsyncOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestAsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002332 File Offset: 0x00000532
		public UnityWebRequestAsyncOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000049E0 File Offset: 0x00002BE0
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000233B File Offset: 0x0000053B
		public unsafe UnityWebRequest _webRequest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestAsyncOperation.NativeFieldInfoPtr__webRequest_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestAsyncOperation.NativeFieldInfoPtr__webRequest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr__webRequest_k__BackingField;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_get_webRequest_Public_get_UnityWebRequest_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_set_webRequest_Internal_set_Void_UnityWebRequest_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
