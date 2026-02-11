using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x0200049B RID: 1179
	public sealed class StackTraceHiddenAttribute : Attribute
	{
		// Token: 0x06004970 RID: 18800 RVA: 0x0001AD18 File Offset: 0x00018F18
		// Note: this type is marked as 'beforefieldinit'.
		static StackTraceHiddenAttribute()
		{
			Il2CppClassPointerStore<StackTraceHiddenAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "StackTraceHiddenAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackTraceHiddenAttribute>.NativeClassPtr);
			StackTraceHiddenAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceHiddenAttribute>.NativeClassPtr, 100674001);
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x00154AFC File Offset: 0x00152CFC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTraceHiddenAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTraceHiddenAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTraceHiddenAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x0001AD51 File Offset: 0x00018F51
		public StackTraceHiddenAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003C3F RID: 15423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
