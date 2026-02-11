using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000087 RID: 135
	public static class Ref : Object
	{
		// Token: 0x06000F7F RID: 3967 RVA: 0x00007059 File Offset: 0x00005259
		// Note: this type is marked as 'beforefieldinit'.
		static Ref()
		{
			Il2CppClassPointerStore<Ref>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Ref");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ref>.NativeClassPtr);
			Ref.NativeMethodInfoPtr_Equal_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ref>.NativeClassPtr, 100665845);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00059DF8 File Offset: 0x00057FF8
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 378270, XrefRangeStart = 376359, XrefRangeEnd = 376359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Equal(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ref.NativeMethodInfoPtr_Equal_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00007092 File Offset: 0x00005292
		public Ref(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_Equal_Public_Static_Boolean_String_String_0;
	}
}
