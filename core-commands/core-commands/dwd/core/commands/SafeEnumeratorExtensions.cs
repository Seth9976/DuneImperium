using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.commands
{
	// Token: 0x02000034 RID: 52
	public static class SafeEnumeratorExtensions : Object
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x00002CEB File Offset: 0x00000EEB
		// Note: this type is marked as 'beforefieldinit'.
		static SafeEnumeratorExtensions()
		{
			Il2CppClassPointerStore<SafeEnumeratorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "SafeEnumeratorExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeEnumeratorExtensions>.NativeClassPtr);
			SafeEnumeratorExtensions.NativeMethodInfoPtr_WithNestedExceptionHandling_Public_Static_SafeEnumerator_IEnumerator_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeEnumeratorExtensions>.NativeClassPtr, 100663841);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000C680 File Offset: 0x0000A880
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1209749, RefRangeEnd = 1209751, XrefRangeStart = 1209739, XrefRangeEnd = 1209749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeEnumerator WithNestedExceptionHandling(this IEnumerator context, Action<Exception> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeEnumeratorExtensions.NativeMethodInfoPtr_WithNestedExceptionHandling_Public_Static_SafeEnumerator_IEnumerator_Action_1_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002D24 File Offset: 0x00000F24
		public SafeEnumeratorExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_WithNestedExceptionHandling_Public_Static_SafeEnumerator_IEnumerator_Action_1_Exception_0;
	}
}
