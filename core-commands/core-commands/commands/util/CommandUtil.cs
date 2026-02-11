using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace commands.util
{
	// Token: 0x02000006 RID: 6
	public static class CommandUtil : Object
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000020E7 File Offset: 0x000002E7
		// Note: this type is marked as 'beforefieldinit'.
		static CommandUtil()
		{
			Il2CppClassPointerStore<CommandUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "commands.util", "CommandUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr);
			CommandUtil.NativeMethodInfoPtr_GetTypeTree_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr, 100663303);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00004C50 File Offset: 0x00002E50
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1205761, RefRangeEnd = 1205766, XrefRangeStart = 1205744, XrefRangeEnd = 1205761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTypeTree(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil.NativeMethodInfoPtr_GetTypeTree_Public_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002120 File Offset: 0x00000320
		public CommandUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeTree_Public_Static_String_Type_0;
	}
}
