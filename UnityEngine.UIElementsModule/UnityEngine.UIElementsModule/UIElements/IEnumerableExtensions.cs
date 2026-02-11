using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200013B RID: 315
	public static class IEnumerableExtensions : Object
	{
		// Token: 0x060017A9 RID: 6057 RVA: 0x0000AE50 File Offset: 0x00009050
		// Note: this type is marked as 'beforefieldinit'.
		static IEnumerableExtensions()
		{
			Il2CppClassPointerStore<IEnumerableExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IEnumerableExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IEnumerableExtensions>.NativeClassPtr);
			IEnumerableExtensions.NativeMethodInfoPtr_HasValues_Internal_Static_Boolean_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerableExtensions>.NativeClassPtr, 100666822);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00070CF8 File Offset: 0x0006EEF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319317, RefRangeEnd = 319318, XrefRangeStart = 319299, XrefRangeEnd = 319317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasValues(this IEnumerable<string> collection)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IEnumerableExtensions.NativeMethodInfoPtr_HasValues_Internal_Static_Boolean_IEnumerable_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0000AE89 File Offset: 0x00009089
		public IEnumerableExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_HasValues_Internal_Static_Boolean_IEnumerable_1_String_0;
	}
}
