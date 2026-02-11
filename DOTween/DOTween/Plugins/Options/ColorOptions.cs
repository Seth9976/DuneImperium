using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000035 RID: 53
	[StructLayout(2)]
	public struct ColorOptions
	{
		// Token: 0x0600036C RID: 876 RVA: 0x00016CA0 File Offset: 0x00014EA0
		// Note: this type is marked as 'beforefieldinit'.
		static ColorOptions()
		{
			Il2CppClassPointerStore<ColorOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "ColorOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorOptions>.NativeClassPtr);
			ColorOptions.NativeFieldInfoPtr_alphaOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorOptions>.NativeClassPtr, "alphaOnly");
			ColorOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorOptions>.NativeClassPtr, 100664089);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00016CF8 File Offset: 0x00014EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1050818, RefRangeEnd = 1050819, XrefRangeStart = 1050818, XrefRangeEnd = 1050819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002FC7 File Offset: 0x000011C7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeFieldInfoPtr_alphaOnly;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x040002F8 RID: 760
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool alphaOnly;
	}
}
