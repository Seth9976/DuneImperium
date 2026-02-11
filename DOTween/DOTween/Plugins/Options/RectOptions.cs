using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000037 RID: 55
	[StructLayout(2)]
	public struct RectOptions
	{
		// Token: 0x06000372 RID: 882 RVA: 0x00016DA0 File Offset: 0x00014FA0
		// Note: this type is marked as 'beforefieldinit'.
		static RectOptions()
		{
			Il2CppClassPointerStore<RectOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "RectOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectOptions>.NativeClassPtr);
			RectOptions.NativeFieldInfoPtr_snapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectOptions>.NativeClassPtr, "snapping");
			RectOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOptions>.NativeClassPtr, 100664091);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00016DF8 File Offset: 0x00014FF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1050818, RefRangeEnd = 1050819, XrefRangeStart = 1050818, XrefRangeEnd = 1050819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002FEB File Offset: 0x000011EB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RectOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr_snapping;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x040002FE RID: 766
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool snapping;
	}
}
