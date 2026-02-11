using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public sealed class UnityString : Object
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002215 File Offset: 0x00000415
		// Note: this type is marked as 'beforefieldinit'.
		static UnityString()
		{
			Il2CppClassPointerStore<UnityString>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine", "UnityString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityString>.NativeClassPtr);
			UnityString.NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityString>.NativeClassPtr, 100663306);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002C98 File Offset: 0x00000E98
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 1268997, RefRangeEnd = 1269034, XrefRangeStart = 1268991, XrefRangeEnd = 1268997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string fmt, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fmt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityString.NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000224E File Offset: 0x0000044E
		public static string Format(string fmt, params Object[] args)
		{
			return UnityString.Format(fmt, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000225C File Offset: 0x0000045C
		public UnityString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;
	}
}
