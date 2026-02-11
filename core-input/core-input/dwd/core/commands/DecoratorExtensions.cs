using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.commands
{
	// Token: 0x02000039 RID: 57
	public static class DecoratorExtensions : Object
	{
		// Token: 0x060001BD RID: 445 RVA: 0x00002FE1 File Offset: 0x000011E1
		// Note: this type is marked as 'beforefieldinit'.
		static DecoratorExtensions()
		{
			Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.commands", "DecoratorExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr);
			DecoratorExtensions.NativeMethodInfoPtr_WithBlockingInputContext_Public_Static_IEnumerator_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663533);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000C77C File Offset: 0x0000A97C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1120303, RefRangeEnd = 1120311, XrefRangeStart = 1120284, XrefRangeEnd = 1120303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator WithBlockingInputContext(this IEnumerator innerCommand)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerCommand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.NativeMethodInfoPtr_WithBlockingInputContext_Public_Static_IEnumerator_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000301A File Offset: 0x0000121A
		public DecoratorExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_WithBlockingInputContext_Public_Static_IEnumerator_IEnumerator_0;
	}
}
