using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.hasExecutionStack
{
	// Token: 0x0200008B RID: 139
	public static class MatchExecutionStackExtensions : Object
	{
		// Token: 0x06000762 RID: 1890 RVA: 0x00004CF8 File Offset: 0x00002EF8
		// Note: this type is marked as 'beforefieldinit'.
		static MatchExecutionStackExtensions()
		{
			Il2CppClassPointerStore<MatchExecutionStackExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.hasExecutionStack", "MatchExecutionStackExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchExecutionStackExtensions>.NativeClassPtr);
			MatchExecutionStackExtensions.NativeMethodInfoPtr_CreateHasExecutionStack_Public_Static_IHasExecutionStack_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchExecutionStackExtensions>.NativeClassPtr, 100664825);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000376A4 File Offset: 0x000358A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 557873, RefRangeEnd = 557874, XrefRangeStart = 557865, XrefRangeEnd = 557873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IHasExecutionStack CreateHasExecutionStack(this Match match, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchExecutionStackExtensions.NativeMethodInfoPtr_CreateHasExecutionStack_Public_Static_IHasExecutionStack_Match_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasExecutionStack>(intPtr3) : null;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00004D31 File Offset: 0x00002F31
		public MatchExecutionStackExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_CreateHasExecutionStack_Public_Static_IHasExecutionStack_Match_String_0;
	}
}
