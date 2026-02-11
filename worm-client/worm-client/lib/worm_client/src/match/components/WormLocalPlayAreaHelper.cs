using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lib.worm_client.src.match.components
{
	// Token: 0x02000031 RID: 49
	public class WormLocalPlayAreaHelper : MonoBehaviour
	{
		// Token: 0x0600021A RID: 538 RVA: 0x00002FA2 File Offset: 0x000011A2
		// Note: this type is marked as 'beforefieldinit'.
		static WormLocalPlayAreaHelper()
		{
			Il2CppClassPointerStore<WormLocalPlayAreaHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "lib.worm_client.src.match.components", "WormLocalPlayAreaHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLocalPlayAreaHelper>.NativeClassPtr);
			WormLocalPlayAreaHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayAreaHelper>.NativeClassPtr, 100663667);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0001F874 File Offset: 0x0001DA74
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLocalPlayAreaHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLocalPlayAreaHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayAreaHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002FDB File Offset: 0x000011DB
		public WormLocalPlayAreaHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
