using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000034 RID: 52
	[StructLayout(2)]
	public struct NoOptions
	{
		// Token: 0x06000369 RID: 873 RVA: 0x00002F7C File Offset: 0x0000117C
		// Note: this type is marked as 'beforefieldinit'.
		static NoOptions()
		{
			Il2CppClassPointerStore<NoOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "NoOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoOptions>.NativeClassPtr);
			NoOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoOptions>.NativeClassPtr, 100664088);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00016C78 File Offset: 0x00014E78
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002FB5 File Offset: 0x000011B5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NoOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
