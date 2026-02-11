using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200012A RID: 298
	public sealed class ExecuteAlways : Attribute
	{
		// Token: 0x060017A0 RID: 6048 RVA: 0x00009570 File Offset: 0x00007770
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteAlways()
		{
			Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExecuteAlways");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr);
			ExecuteAlways.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr, 100666526);
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0006FFE0 File Offset: 0x0006E1E0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteAlways()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteAlways.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x000095A9 File Offset: 0x000077A9
		public ExecuteAlways(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
