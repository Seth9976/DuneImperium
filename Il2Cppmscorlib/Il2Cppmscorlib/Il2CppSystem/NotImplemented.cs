using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000110 RID: 272
	public static class NotImplemented : Object
	{
		// Token: 0x0600124B RID: 4683 RVA: 0x00006079 File Offset: 0x00004279
		// Note: this type is marked as 'beforefieldinit'.
		static NotImplemented()
		{
			Il2CppClassPointerStore<NotImplemented>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NotImplemented");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotImplemented>.NativeClassPtr);
			NotImplemented.NativeMethodInfoPtr_get_ByDesign_Internal_Static_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotImplemented>.NativeClassPtr, 100666488);
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x0007E02C File Offset: 0x0007C22C
		public unsafe static Exception ByDesign
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1333681, RefRangeEnd = 1333699, XrefRangeStart = 1333677, XrefRangeEnd = 1333681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotImplemented.NativeMethodInfoPtr_get_ByDesign_Internal_Static_get_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x000060B2 File Offset: 0x000042B2
		public NotImplemented(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_get_ByDesign_Internal_Static_get_Exception_0;
	}
}
