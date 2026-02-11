using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000CF RID: 207
	public static class Nullable : Object
	{
		// Token: 0x06000D30 RID: 3376 RVA: 0x00005337 File Offset: 0x00003537
		// Note: this type is marked as 'beforefieldinit'.
		static Nullable()
		{
			Il2CppClassPointerStore<Nullable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Nullable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Nullable>.NativeClassPtr);
			Nullable.NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Nullable>.NativeClassPtr, 100665606);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00062F50 File Offset: 0x00061150
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1316407, RefRangeEnd = 1316430, XrefRangeStart = 1316401, XrefRangeEnd = 1316407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetUnderlyingType(Type nullableType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullableType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Nullable.NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00005370 File Offset: 0x00003570
		public Nullable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0;
	}
}
