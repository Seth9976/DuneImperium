using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x0200049D RID: 1181
	[Serializable]
	public sealed class DebuggerHiddenAttribute : Attribute
	{
		// Token: 0x06004976 RID: 18806 RVA: 0x0001AD9C File Offset: 0x00018F9C
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerHiddenAttribute()
		{
			Il2CppClassPointerStore<DebuggerHiddenAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerHiddenAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerHiddenAttribute>.NativeClassPtr);
			DebuggerHiddenAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerHiddenAttribute>.NativeClassPtr, 100674003);
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x00154B74 File Offset: 0x00152D74
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerHiddenAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerHiddenAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerHiddenAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x0001ADD5 File Offset: 0x00018FD5
		public DebuggerHiddenAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003C41 RID: 15425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
