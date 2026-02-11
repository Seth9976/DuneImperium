using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000032 RID: 50
	[StructLayout(2)]
	public struct UintOptions
	{
		// Token: 0x0600035C RID: 860 RVA: 0x00016AC0 File Offset: 0x00014CC0
		// Note: this type is marked as 'beforefieldinit'.
		static UintOptions()
		{
			Il2CppClassPointerStore<UintOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "UintOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UintOptions>.NativeClassPtr);
			UintOptions.NativeFieldInfoPtr_isNegativeChangeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UintOptions>.NativeClassPtr, "isNegativeChangeValue");
			UintOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UintOptions>.NativeClassPtr, 100664086);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00016B18 File Offset: 0x00014D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1050818, RefRangeEnd = 1050819, XrefRangeStart = 1050818, XrefRangeEnd = 1050819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UintOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00002EFA File Offset: 0x000010FA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UintOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr_isNegativeChangeValue;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x040002F0 RID: 752
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool isNegativeChangeValue;
	}
}
