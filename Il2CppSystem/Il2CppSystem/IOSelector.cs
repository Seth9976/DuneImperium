using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000070 RID: 112
	public static class IOSelector : Object
	{
		// Token: 0x060006D1 RID: 1745 RVA: 0x0000434D File Offset: 0x0000254D
		// Note: this type is marked as 'beforefieldinit'.
		static IOSelector()
		{
			Il2CppClassPointerStore<IOSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IOSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOSelector>.NativeClassPtr);
			IOSelector.NativeMethodInfoPtr_Add_Public_Static_Void_IntPtr_IOSelectorJob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSelector>.NativeClassPtr, 100664416);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000368BC File Offset: 0x00034ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 437155, RefRangeEnd = 437156, XrefRangeStart = 437154, XrefRangeEnd = 437155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Add(IntPtr handle, IOSelectorJob job)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(job);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOSelector.NativeMethodInfoPtr_Add_Public_Static_Void_IntPtr_IOSelectorJob_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00004386 File Offset: 0x00002586
		public IOSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Void_IntPtr_IOSelectorJob_0;
	}
}
