using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.EventSystems;

namespace dwd.core.input.compositeModule
{
	// Token: 0x0200008D RID: 141
	public static class InputModuleExtensions : Object
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x0000553C File Offset: 0x0000373C
		// Note: this type is marked as 'beforefieldinit'.
		static InputModuleExtensions()
		{
			Il2CppClassPointerStore<InputModuleExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "InputModuleExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputModuleExtensions>.NativeClassPtr);
			InputModuleExtensions.NativeMethodInfoPtr_GetModuleType_Public_Static_String_BaseInputModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleExtensions>.NativeClassPtr, 100664056);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0001A550 File Offset: 0x00018750
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1125189, RefRangeEnd = 1125194, XrefRangeStart = 1125178, XrefRangeEnd = 1125189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetModuleType(this BaseInputModule inputModule)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputModule);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleExtensions.NativeMethodInfoPtr_GetModuleType_Public_Static_String_BaseInputModule_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00005575 File Offset: 0x00003775
		public InputModuleExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_GetModuleType_Public_Static_String_BaseInputModule_0;
	}
}
