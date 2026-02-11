using System;
using dwd.core.conditions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.input
{
	// Token: 0x02000056 RID: 86
	public class PressFilter : Condition<Press>
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x00003AB0 File Offset: 0x00001CB0
		// Note: this type is marked as 'beforefieldinit'.
		static PressFilter()
		{
			Il2CppClassPointerStore<PressFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "PressFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressFilter>.NativeClassPtr);
			PressFilter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressFilter>.NativeClassPtr, 100663647);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00010110 File Offset: 0x0000E310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PressFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressFilter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00003AE9 File Offset: 0x00001CE9
		public PressFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
