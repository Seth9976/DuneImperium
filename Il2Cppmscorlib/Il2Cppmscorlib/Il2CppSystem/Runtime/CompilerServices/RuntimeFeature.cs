using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003C1 RID: 961
	public static class RuntimeFeature : Object
	{
		// Token: 0x06003938 RID: 14648 RVA: 0x00115340 File Offset: 0x00113540
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeFeature()
		{
			Il2CppClassPointerStore<RuntimeFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "RuntimeFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeFeature>.NativeClassPtr);
			RuntimeFeature.NativeMethodInfoPtr_get_IsDynamicCodeSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFeature>.NativeClassPtr, 100671834);
			RuntimeFeature.NativeMethodInfoPtr_get_IsDynamicCodeCompiled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFeature>.NativeClassPtr, 100671835);
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06003939 RID: 14649 RVA: 0x00115398 File Offset: 0x00113598
		public unsafe static bool IsDynamicCodeSupported
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFeature.NativeMethodInfoPtr_get_IsDynamicCodeSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x0600393A RID: 14650 RVA: 0x001153C8 File Offset: 0x001135C8
		public unsafe static bool IsDynamicCodeCompiled
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFeature.NativeMethodInfoPtr_get_IsDynamicCodeCompiled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x000152ED File Offset: 0x000134ED
		public RuntimeFeature(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E8C RID: 11916
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDynamicCodeSupported_Public_Static_get_Boolean_0;

		// Token: 0x04002E8D RID: 11917
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDynamicCodeCompiled_Public_Static_get_Boolean_0;
	}
}
