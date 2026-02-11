using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml
{
	// Token: 0x020000A9 RID: 169
	public static class Res : Object
	{
		// Token: 0x060011EA RID: 4586 RVA: 0x00065450 File Offset: 0x00063650
		// Note: this type is marked as 'beforefieldinit'.
		static Res()
		{
			Il2CppClassPointerStore<Res>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Res");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Res>.NativeClassPtr);
			Res.NativeMethodInfoPtr_GetString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Res>.NativeClassPtr, 100666263);
			Res.NativeMethodInfoPtr_GetString_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Res>.NativeClassPtr, 100666264);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000654A8 File Offset: 0x000636A8
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Res.NativeMethodInfoPtr_GetString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x000654E4 File Offset: 0x000636E4
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 383252, RefRangeEnd = 383277, XrefRangeStart = 383251, XrefRangeEnd = 383252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string name, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Res.NativeMethodInfoPtr_GetString_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00007A4C File Offset: 0x00005C4C
		public static string GetString(string name, params Object[] args)
		{
			return Res.GetString(name, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00007A5A File Offset: 0x00005C5A
		public Res(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_0;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;
	}
}
