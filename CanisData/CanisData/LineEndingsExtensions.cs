using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace CanisData
{
	// Token: 0x02000007 RID: 7
	public static class LineEndingsExtensions : Object
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000020E7 File Offset: 0x000002E7
		// Note: this type is marked as 'beforefieldinit'.
		static LineEndingsExtensions()
		{
			Il2CppClassPointerStore<LineEndingsExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData", "LineEndingsExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineEndingsExtensions>.NativeClassPtr);
			LineEndingsExtensions.NativeMethodInfoPtr_AsString_Public_Static_String_LineEndings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineEndingsExtensions>.NativeClassPtr, 100663303);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003B28 File Offset: 0x00001D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221848, XrefRangeEnd = 1221856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string AsString(this LineEndings ending)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ending;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineEndingsExtensions.NativeMethodInfoPtr_AsString_Public_Static_String_LineEndings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002120 File Offset: 0x00000320
		public LineEndingsExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_AsString_Public_Static_String_LineEndings_0;
	}
}
