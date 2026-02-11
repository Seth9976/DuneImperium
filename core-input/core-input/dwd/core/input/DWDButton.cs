using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.UI;

namespace dwd.core.input
{
	// Token: 0x0200003B RID: 59
	public class DWDButton : Button
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x000030DA File Offset: 0x000012DA
		// Note: this type is marked as 'beforefieldinit'.
		static DWDButton()
		{
			Il2CppClassPointerStore<DWDButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "DWDButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDButton>.NativeClassPtr);
			DWDButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDButton>.NativeClassPtr, 100663544);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000CABC File Offset: 0x0000ACBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120343, XrefRangeEnd = 1120344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DWDButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00003113 File Offset: 0x00001313
		public DWDButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
