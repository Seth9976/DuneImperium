using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000498 RID: 1176
	public class Punycode : Bootstring
	{
		// Token: 0x06004939 RID: 18745 RVA: 0x0001AB61 File Offset: 0x00018D61
		// Note: this type is marked as 'beforefieldinit'.
		static Punycode()
		{
			Il2CppClassPointerStore<Punycode>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "Punycode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Punycode>.NativeClassPtr);
			Punycode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Punycode>.NativeClassPtr, 100673976);
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x00153F28 File Offset: 0x00152128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414149, XrefRangeEnd = 1414150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Punycode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Punycode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Punycode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x0001AB9A File Offset: 0x00018D9A
		public Punycode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003C1A RID: 15386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
