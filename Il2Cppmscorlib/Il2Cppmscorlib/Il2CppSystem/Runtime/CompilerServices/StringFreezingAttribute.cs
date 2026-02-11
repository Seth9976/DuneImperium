using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003C4 RID: 964
	[Serializable]
	public sealed class StringFreezingAttribute : Attribute
	{
		// Token: 0x0600394B RID: 14667 RVA: 0x00015346 File Offset: 0x00013546
		// Note: this type is marked as 'beforefieldinit'.
		static StringFreezingAttribute()
		{
			Il2CppClassPointerStore<StringFreezingAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "StringFreezingAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringFreezingAttribute>.NativeClassPtr);
			StringFreezingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFreezingAttribute>.NativeClassPtr, 100671843);
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x00115780 File Offset: 0x00113980
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringFreezingAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringFreezingAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFreezingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x0001537F File Offset: 0x0001357F
		public StringFreezingAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E97 RID: 11927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
