using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.menus
{
	// Token: 0x02000150 RID: 336
	public class LoadingBlackout : MonoBehaviour
	{
		// Token: 0x06001148 RID: 4424 RVA: 0x0000A107 File Offset: 0x00008307
		// Note: this type is marked as 'beforefieldinit'.
		static LoadingBlackout()
		{
			Il2CppClassPointerStore<LoadingBlackout>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.menus", "LoadingBlackout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingBlackout>.NativeClassPtr);
			LoadingBlackout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingBlackout>.NativeClassPtr, 100665838);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x000461A0 File Offset: 0x000443A0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadingBlackout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingBlackout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingBlackout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x0000A140 File Offset: 0x00008340
		public LoadingBlackout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
