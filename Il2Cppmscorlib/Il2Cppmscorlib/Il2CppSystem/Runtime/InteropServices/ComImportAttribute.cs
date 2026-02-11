using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200038B RID: 907
	public sealed class ComImportAttribute : Attribute
	{
		// Token: 0x060037B3 RID: 14259 RVA: 0x000145C1 File Offset: 0x000127C1
		// Note: this type is marked as 'beforefieldinit'.
		static ComImportAttribute()
		{
			Il2CppClassPointerStore<ComImportAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ComImportAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComImportAttribute>.NativeClassPtr);
			ComImportAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComImportAttribute>.NativeClassPtr, 100671634);
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x00110368 File Offset: 0x0010E568
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComImportAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComImportAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComImportAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x000145FA File Offset: 0x000127FA
		public ComImportAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002D8E RID: 11662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
