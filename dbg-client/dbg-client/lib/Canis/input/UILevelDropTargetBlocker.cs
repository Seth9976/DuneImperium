using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lib.canis.input
{
	// Token: 0x0200002D RID: 45
	public class UILevelDropTargetBlocker : MonoBehaviour
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x00002B3B File Offset: 0x00000D3B
		// Note: this type is marked as 'beforefieldinit'.
		static UILevelDropTargetBlocker()
		{
			Il2CppClassPointerStore<UILevelDropTargetBlocker>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.input", "UILevelDropTargetBlocker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UILevelDropTargetBlocker>.NativeClassPtr);
			UILevelDropTargetBlocker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILevelDropTargetBlocker>.NativeClassPtr, 100663591);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00023190 File Offset: 0x00021390
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UILevelDropTargetBlocker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UILevelDropTargetBlocker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILevelDropTargetBlocker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002B74 File Offset: 0x00000D74
		public UILevelDropTargetBlocker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
