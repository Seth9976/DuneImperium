using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000CB RID: 203
	public sealed class RethrowException : Exception
	{
		// Token: 0x06000C51 RID: 3153 RVA: 0x00005C16 File Offset: 0x00003E16
		// Note: this type is marked as 'beforefieldinit'.
		static RethrowException()
		{
			Il2CppClassPointerStore<RethrowException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "RethrowException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RethrowException>.NativeClassPtr);
			RethrowException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RethrowException>.NativeClassPtr, 100665529);
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00042870 File Offset: 0x00040A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1020022, RefRangeEnd = 1020023, XrefRangeStart = 1020018, XrefRangeEnd = 1020022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RethrowException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RethrowException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RethrowException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00005C4F File Offset: 0x00003E4F
		public RethrowException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
