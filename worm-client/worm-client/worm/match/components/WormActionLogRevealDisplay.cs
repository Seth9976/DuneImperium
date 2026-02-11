using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001CF RID: 463
	public class WormActionLogRevealDisplay : MonoBehaviour
	{
		// Token: 0x06001488 RID: 5256 RVA: 0x00056690 File Offset: 0x00054890
		// Note: this type is marked as 'beforefieldinit'.
		static WormActionLogRevealDisplay()
		{
			Il2CppClassPointerStore<WormActionLogRevealDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormActionLogRevealDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormActionLogRevealDisplay>.NativeClassPtr);
			WormActionLogRevealDisplay.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogRevealDisplay>.NativeClassPtr, 100666102);
			WormActionLogRevealDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogRevealDisplay>.NativeClassPtr, 100666103);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x000566E8 File Offset: 0x000548E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714291, XrefRangeEnd = 714297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogRevealDisplay.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0005671C File Offset: 0x0005491C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormActionLogRevealDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormActionLogRevealDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogRevealDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x0000C98D File Offset: 0x0000AB8D
		public WormActionLogRevealDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
