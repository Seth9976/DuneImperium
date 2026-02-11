using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.commands
{
	// Token: 0x02000013 RID: 19
	public static class CommandUtil : global::Il2CppSystem.Object
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x000071E4 File Offset: 0x000053E4
		// Note: this type is marked as 'beforefieldinit'.
		static CommandUtil()
		{
			Il2CppClassPointerStore<CommandUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "CommandUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr);
			CommandUtil.NativeMethodInfoPtr_Execute_Public_Static_Coroutine_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr, 100663437);
			CommandUtil.NativeMethodInfoPtr_Execute_Public_Static_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr, 100663438);
			CommandUtil.NativeMethodInfoPtr_Enqueue_Public_Static_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr, 100663439);
			CommandUtil.NativeMethodInfoPtr_Enqueue_Public_Static_Void_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr, 100663440);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00007264 File Offset: 0x00005464
		[CallerCount(217)]
		[CachedScanResults(RefRangeStart = 1207186, RefRangeEnd = 1207403, XrefRangeStart = 1207181, XrefRangeEnd = 1207186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine Execute(this Command command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil.NativeMethodInfoPtr_Execute_Public_Static_Coroutine_Command_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000072A8 File Offset: 0x000054A8
		[CallerCount(130)]
		[CachedScanResults(RefRangeStart = 1207409, RefRangeEnd = 1207539, XrefRangeStart = 1207403, XrefRangeEnd = 1207409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine Execute(this IEnumerator command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil.NativeMethodInfoPtr_Execute_Public_Static_Coroutine_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000072EC File Offset: 0x000054EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207539, XrefRangeEnd = 1207544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enqueue(this IEnumerator command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil.NativeMethodInfoPtr_Enqueue_Public_Static_Void_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00007324 File Offset: 0x00005524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207544, XrefRangeEnd = 1207548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enqueue(this Command command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil.NativeMethodInfoPtr_Enqueue_Public_Static_Void_Command_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002516 File Offset: 0x00000716
		public CommandUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Static_Coroutine_Command_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Static_Coroutine_IEnumerator_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Static_Void_IEnumerator_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Static_Void_Command_0;
	}
}
