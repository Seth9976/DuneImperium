using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x020000A8 RID: 168
	public static class BinaryCompatibility : Object
	{
		// Token: 0x060011E7 RID: 4583 RVA: 0x00007A0A File Offset: 0x00005C0A
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCompatibility()
		{
			Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BinaryCompatibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr);
			BinaryCompatibility.NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, 100666262);
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x00065420 File Offset: 0x00063620
		public unsafe static bool TargetsAtLeast_Desktop_V4_5_2
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCompatibility.NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00007A43 File Offset: 0x00005C43
		public BinaryCompatibility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Public_Static_get_Boolean_0;
	}
}
