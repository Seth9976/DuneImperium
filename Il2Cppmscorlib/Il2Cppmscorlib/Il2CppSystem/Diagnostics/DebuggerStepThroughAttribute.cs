using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x0200049C RID: 1180
	[Serializable]
	public sealed class DebuggerStepThroughAttribute : Attribute
	{
		// Token: 0x06004973 RID: 18803 RVA: 0x0001AD5A File Offset: 0x00018F5A
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerStepThroughAttribute()
		{
			Il2CppClassPointerStore<DebuggerStepThroughAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerStepThroughAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerStepThroughAttribute>.NativeClassPtr);
			DebuggerStepThroughAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerStepThroughAttribute>.NativeClassPtr, 100674002);
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x00154B38 File Offset: 0x00152D38
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerStepThroughAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerStepThroughAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerStepThroughAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x0001AD93 File Offset: 0x00018F93
		public DebuggerStepThroughAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003C40 RID: 15424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
