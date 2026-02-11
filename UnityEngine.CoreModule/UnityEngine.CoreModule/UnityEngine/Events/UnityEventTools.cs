using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x020001A1 RID: 417
	public class UnityEventTools : Object
	{
		// Token: 0x06001EFB RID: 7931 RVA: 0x0000BC00 File Offset: 0x00009E00
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventTools()
		{
			Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEventTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr);
			UnityEventTools.NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr, 100667549);
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x0008AA20 File Offset: 0x00088C20
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 678100, RefRangeEnd = 678105, XrefRangeStart = 678069, XrefRangeEnd = 678100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TidyAssemblyTypeName(string assemblyTypeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyTypeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventTools.NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x0000BC39 File Offset: 0x00009E39
		public UnityEventTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0;
	}
}
