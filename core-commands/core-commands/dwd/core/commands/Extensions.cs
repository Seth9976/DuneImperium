using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.commands
{
	// Token: 0x02000028 RID: 40
	public static class Extensions : Object
	{
		// Token: 0x0600019A RID: 410 RVA: 0x00002A5C File Offset: 0x00000C5C
		// Note: this type is marked as 'beforefieldinit'.
		static Extensions()
		{
			Il2CppClassPointerStore<Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "Extensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions>.NativeClassPtr);
			Extensions.NativeMethodInfoPtr_MoveNextWithExceptionHandling_Public_Static_Boolean_IEnumerator_byref_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100663756);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000B2EC File Offset: 0x000094EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1209450, RefRangeEnd = 1209452, XrefRangeStart = 1209442, XrefRangeEnd = 1209450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MoveNextWithExceptionHandling(this IEnumerator command, out ErrorInfo status)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Extensions.NativeMethodInfoPtr_MoveNextWithExceptionHandling_Public_Static_Boolean_IEnumerator_byref_ErrorInfo_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			status = ((intPtr4 == 0) ? null : new ErrorInfo(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002A95 File Offset: 0x00000C95
		public Extensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_MoveNextWithExceptionHandling_Public_Static_Boolean_IEnumerator_byref_ErrorInfo_0;
	}
}
