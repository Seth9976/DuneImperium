using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace core.widgets
{
	// Token: 0x02000007 RID: 7
	public class DestroyInRelease : MonoBehaviour
	{
		// Token: 0x06000037 RID: 55 RVA: 0x0000355C File Offset: 0x0000175C
		// Note: this type is marked as 'beforefieldinit'.
		static DestroyInRelease()
		{
			Il2CppClassPointerStore<DestroyInRelease>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "core.widgets", "DestroyInRelease");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyInRelease>.NativeClassPtr);
			DestroyInRelease.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyInRelease>.NativeClassPtr, 100663309);
			DestroyInRelease.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyInRelease>.NativeClassPtr, 100663310);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000035B4 File Offset: 0x000017B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255494, XrefRangeEnd = 1255499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyInRelease.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000035E8 File Offset: 0x000017E8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DestroyInRelease()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyInRelease>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyInRelease.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002289 File Offset: 0x00000489
		public DestroyInRelease(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
