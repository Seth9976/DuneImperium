using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000107 RID: 263
	public static class ExceptionHelpers : Object
	{
		// Token: 0x06000FCE RID: 4046 RVA: 0x00006EE0 File Offset: 0x000050E0
		// Note: this type is marked as 'beforefieldinit'.
		static ExceptionHelpers()
		{
			Il2CppClassPointerStore<ExceptionHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "ExceptionHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionHelpers>.NativeClassPtr);
			ExceptionHelpers.NativeMethodInfoPtr_UnwrapAndRethrow_Public_Static_Void_TargetInvocationException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelpers>.NativeClassPtr, 100666239);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00053360 File Offset: 0x00051560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026966, XrefRangeEnd = 1026968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnwrapAndRethrow(TargetInvocationException exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHelpers.NativeMethodInfoPtr_UnwrapAndRethrow_Public_Static_Void_TargetInvocationException_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00006F19 File Offset: 0x00005119
		public ExceptionHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_UnwrapAndRethrow_Public_Static_Void_TargetInvocationException_0;
	}
}
