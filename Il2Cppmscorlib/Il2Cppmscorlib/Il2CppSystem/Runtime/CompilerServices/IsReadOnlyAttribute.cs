using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003BD RID: 957
	public sealed class IsReadOnlyAttribute : Attribute
	{
		// Token: 0x0600392A RID: 14634 RVA: 0x00015217 File Offset: 0x00013417
		// Note: this type is marked as 'beforefieldinit'.
		static IsReadOnlyAttribute()
		{
			Il2CppClassPointerStore<IsReadOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "IsReadOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsReadOnlyAttribute>.NativeClassPtr);
			IsReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsReadOnlyAttribute>.NativeClassPtr, 100671830);
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x001151A8 File Offset: 0x001133A8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IsReadOnlyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsReadOnlyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x00015250 File Offset: 0x00013450
		public IsReadOnlyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E87 RID: 11911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
