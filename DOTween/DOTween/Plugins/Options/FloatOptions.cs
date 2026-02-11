using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000036 RID: 54
	[StructLayout(2)]
	public struct FloatOptions
	{
		// Token: 0x0600036F RID: 879 RVA: 0x00016D20 File Offset: 0x00014F20
		// Note: this type is marked as 'beforefieldinit'.
		static FloatOptions()
		{
			Il2CppClassPointerStore<FloatOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "FloatOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatOptions>.NativeClassPtr);
			FloatOptions.NativeFieldInfoPtr_snapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatOptions>.NativeClassPtr, "snapping");
			FloatOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatOptions>.NativeClassPtr, 100664090);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00016D78 File Offset: 0x00014F78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1050818, RefRangeEnd = 1050819, XrefRangeStart = 1050818, XrefRangeEnd = 1050819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002FD9 File Offset: 0x000011D9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FloatOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeFieldInfoPtr_snapping;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x040002FB RID: 763
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool snapping;
	}
}
