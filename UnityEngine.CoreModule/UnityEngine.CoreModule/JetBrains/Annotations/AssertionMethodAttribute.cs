using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JetBrains.Annotations
{
	// Token: 0x02000062 RID: 98
	public sealed class AssertionMethodAttribute : Attribute
	{
		// Token: 0x0600031E RID: 798 RVA: 0x00003A1E File Offset: 0x00001C1E
		// Note: this type is marked as 'beforefieldinit'.
		static AssertionMethodAttribute()
		{
			Il2CppClassPointerStore<AssertionMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "AssertionMethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssertionMethodAttribute>.NativeClassPtr);
			AssertionMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMethodAttribute>.NativeClassPtr, 100663588);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0001ECA0 File Offset: 0x0001CEA0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssertionMethodAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssertionMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00003A57 File Offset: 0x00001C57
		public AssertionMethodAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
