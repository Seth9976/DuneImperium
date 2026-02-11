using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003AE RID: 942
	[Serializable]
	public sealed class CompilerGeneratedAttribute : Attribute
	{
		// Token: 0x060038E7 RID: 14567 RVA: 0x00014EE8 File Offset: 0x000130E8
		// Note: this type is marked as 'beforefieldinit'.
		static CompilerGeneratedAttribute()
		{
			Il2CppClassPointerStore<CompilerGeneratedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "CompilerGeneratedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompilerGeneratedAttribute>.NativeClassPtr);
			CompilerGeneratedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerGeneratedAttribute>.NativeClassPtr, 100671792);
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x00114740 File Offset: 0x00112940
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompilerGeneratedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompilerGeneratedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilerGeneratedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x00014F21 File Offset: 0x00013121
		public CompilerGeneratedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E6B RID: 11883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
