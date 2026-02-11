using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000160 RID: 352
	public class YieldInstruction : Object
	{
		// Token: 0x06001A01 RID: 6657 RVA: 0x0000A054 File Offset: 0x00008254
		// Note: this type is marked as 'beforefieldinit'.
		static YieldInstruction()
		{
			Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "YieldInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr);
			YieldInstruction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr, 100666917);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0007A4C0 File Offset: 0x000786C0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YieldInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldInstruction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0000A08D File Offset: 0x0000828D
		public YieldInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
