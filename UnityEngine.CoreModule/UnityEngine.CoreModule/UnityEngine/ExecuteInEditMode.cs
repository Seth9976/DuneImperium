using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000129 RID: 297
	public sealed class ExecuteInEditMode : Attribute
	{
		// Token: 0x0600179D RID: 6045 RVA: 0x0000952E File Offset: 0x0000772E
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteInEditMode()
		{
			Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExecuteInEditMode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr);
			ExecuteInEditMode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr, 100666525);
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x0006FFA4 File Offset: 0x0006E1A4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteInEditMode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteInEditMode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00009567 File Offset: 0x00007767
		public ExecuteInEditMode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
