using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.ExceptionServices
{
	// Token: 0x020003A1 RID: 929
	public sealed class HandleProcessCorruptedStateExceptionsAttribute : Attribute
	{
		// Token: 0x06003899 RID: 14489 RVA: 0x00014BE9 File Offset: 0x00012DE9
		// Note: this type is marked as 'beforefieldinit'.
		static HandleProcessCorruptedStateExceptionsAttribute()
		{
			Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ExceptionServices", "HandleProcessCorruptedStateExceptionsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr);
			HandleProcessCorruptedStateExceptionsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr, 100671762);
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x001137C0 File Offset: 0x001119C0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandleProcessCorruptedStateExceptionsAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleProcessCorruptedStateExceptionsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x00014C22 File Offset: 0x00012E22
		public HandleProcessCorruptedStateExceptionsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E38 RID: 11832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
