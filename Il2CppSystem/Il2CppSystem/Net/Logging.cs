using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001E8 RID: 488
	public static class Logging : Object
	{
		// Token: 0x06001E78 RID: 7800 RVA: 0x0000CF52 File Offset: 0x0000B152
		// Note: this type is marked as 'beforefieldinit'.
		static Logging()
		{
			Il2CppClassPointerStore<Logging>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Logging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Logging>.NativeClassPtr);
			Logging.NativeMethodInfoPtr_get_On_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logging>.NativeClassPtr, 100667939);
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001E79 RID: 7801 RVA: 0x00092778 File Offset: 0x00090978
		public unsafe static bool On
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logging.NativeMethodInfoPtr_get_On_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x0000CF8B File Offset: 0x0000B18B
		public Logging(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeMethodInfoPtr_get_On_Internal_Static_get_Boolean_0;
	}
}
