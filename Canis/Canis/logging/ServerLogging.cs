using System;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.logging
{
	// Token: 0x0200009C RID: 156
	public static class ServerLogging : Object
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x00004F86 File Offset: 0x00003186
		// Note: this type is marked as 'beforefieldinit'.
		static ServerLogging()
		{
			Il2CppClassPointerStore<ServerLogging>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.logging", "ServerLogging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerLogging>.NativeClassPtr);
			ServerLogging.NativeMethodInfoPtr_LogToClient_Public_Static_Action_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerLogging>.NativeClassPtr, 100664862);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00038798 File Offset: 0x00036998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558092, XrefRangeEnd = 558101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action LogToClient(Match match, string toLog)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(toLog);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerLogging.NativeMethodInfoPtr_LogToClient_Public_Static_Action_Match_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00004FBF File Offset: 0x000031BF
		public ServerLogging(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_LogToClient_Public_Static_Action_Match_String_0;
	}
}
