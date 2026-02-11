using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.commands
{
	// Token: 0x02000010 RID: 16
	public sealed class CommandExecutor : MonoBehaviour
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00006714 File Offset: 0x00004914
		// Note: this type is marked as 'beforefieldinit'.
		static CommandExecutor()
		{
			Il2CppClassPointerStore<CommandExecutor>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "CommandExecutor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandExecutor>.NativeClassPtr);
			CommandExecutor.NativeFieldInfoPtr_LogExecutions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandExecutor>.NativeClassPtr, "LogExecutions");
			CommandExecutor.NativeMethodInfoPtr_Execute_Public_Coroutine_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandExecutor>.NativeClassPtr, 100663372);
			CommandExecutor.NativeMethodInfoPtr_Execute_Public_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandExecutor>.NativeClassPtr, 100663373);
			CommandExecutor.NativeMethodInfoPtr_Get_Public_Static_CommandExecutor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandExecutor>.NativeClassPtr, 100663374);
			CommandExecutor.NativeMethodInfoPtr_Find_Public_Static_CommandExecutor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandExecutor>.NativeClassPtr, 100663375);
			CommandExecutor.NativeMethodInfoPtr_getPendingCommands_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandExecutor>.NativeClassPtr, 100663376);
			CommandExecutor.NativeMethodInfoPtr_getExecutingCommands_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandExecutor>.NativeClassPtr, 100663377);
			CommandExecutor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandExecutor>.NativeClassPtr, 100663378);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000067E4 File Offset: 0x000049E4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1206706, RefRangeEnd = 1206724, XrefRangeStart = 1206690, XrefRangeEnd = 1206706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine Execute(Command command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandExecutor.NativeMethodInfoPtr_Execute_Public_Coroutine_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00006834 File Offset: 0x00004A34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1206726, RefRangeEnd = 1206728, XrefRangeStart = 1206724, XrefRangeEnd = 1206726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine Execute(IEnumerator coroutine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandExecutor.NativeMethodInfoPtr_Execute_Public_Coroutine_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00006884 File Offset: 0x00004A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206728, XrefRangeEnd = 1206731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CommandExecutor Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandExecutor.NativeMethodInfoPtr_Get_Public_Static_CommandExecutor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CommandExecutor>(intPtr3) : null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000068B8 File Offset: 0x00004AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206731, XrefRangeEnd = 1206734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CommandExecutor Find()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandExecutor.NativeMethodInfoPtr_Find_Public_Static_CommandExecutor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CommandExecutor>(intPtr3) : null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000068EC File Offset: 0x00004AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206734, XrefRangeEnd = 1206796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getPendingCommands()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandExecutor.NativeMethodInfoPtr_getPendingCommands_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00006924 File Offset: 0x00004B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206796, XrefRangeEnd = 1206858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getExecutingCommands()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandExecutor.NativeMethodInfoPtr_getExecutingCommands_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000695C File Offset: 0x00004B5C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandExecutor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandExecutor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandExecutor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002437 File Offset: 0x00000637
		public CommandExecutor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00006998 File Offset: 0x00004B98
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002440 File Offset: 0x00000640
		public unsafe bool LogExecutions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandExecutor.NativeFieldInfoPtr_LogExecutions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandExecutor.NativeFieldInfoPtr_LogExecutions)) = value;
			}
		}

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_LogExecutions;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Coroutine_Command_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Coroutine_IEnumerator_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_CommandExecutor_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_CommandExecutor_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_getPendingCommands_Public_String_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_getExecutingCommands_Public_String_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000040 RID: 64
		[ObfuscatedName("dwd.core.commands.CommandExecutor+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000259 RID: 601 RVA: 0x0000D8AC File Offset: 0x0000BAAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CommandExecutor.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandExecutor>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandExecutor.__c>.NativeClassPtr);
				CommandExecutor.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandExecutor.__c>.NativeClassPtr, "<>9");
				CommandExecutor.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandExecutor.__c>.NativeClassPtr, "<>9__5_0");
				CommandExecutor.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandExecutor.__c>.NativeClassPtr, "<>9__6_0");
				CommandExecutor.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandExecutor.__c>.NativeClassPtr, 100663380);
				CommandExecutor.__c.NativeMethodInfoPtr__getPendingCommands_b__5_0_Internal_String_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandExecutor.__c>.NativeClassPtr, 100663381);
				CommandExecutor.__c.NativeMethodInfoPtr__getExecutingCommands_b__6_0_Internal_String_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandExecutor.__c>.NativeClassPtr, 100663382);
			}

			// Token: 0x0600025A RID: 602 RVA: 0x0000D950 File Offset: 0x0000BB50
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandExecutor.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandExecutor.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600025B RID: 603 RVA: 0x0000D98C File Offset: 0x0000BB8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _getPendingCommands_b__5_0(Command x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandExecutor.__c.NativeMethodInfoPtr__getPendingCommands_b__5_0_Internal_String_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600025C RID: 604 RVA: 0x0000D9D4 File Offset: 0x0000BBD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _getExecutingCommands_b__6_0(Command x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandExecutor.__c.NativeMethodInfoPtr__getExecutingCommands_b__6_0_Internal_String_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600025D RID: 605 RVA: 0x0000304D File Offset: 0x0000124D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x0600025E RID: 606 RVA: 0x0000DA1C File Offset: 0x0000BC1C
			// (set) Token: 0x0600025F RID: 607 RVA: 0x00003056 File Offset: 0x00001256
			public unsafe static CommandExecutor.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CommandExecutor.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandExecutor.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CommandExecutor.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x06000260 RID: 608 RVA: 0x0000DA44 File Offset: 0x0000BC44
			// (set) Token: 0x06000261 RID: 609 RVA: 0x00003068 File Offset: 0x00001268
			public unsafe static Func<Command, string> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CommandExecutor.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CommandExecutor.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x06000262 RID: 610 RVA: 0x0000DA6C File Offset: 0x0000BC6C
			// (set) Token: 0x06000263 RID: 611 RVA: 0x0000307A File Offset: 0x0000127A
			public unsafe static Func<Command, string> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CommandExecutor.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CommandExecutor.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000170 RID: 368
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000171 RID: 369
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04000172 RID: 370
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04000173 RID: 371
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000174 RID: 372
			private static readonly IntPtr NativeMethodInfoPtr__getPendingCommands_b__5_0_Internal_String_Command_0;

			// Token: 0x04000175 RID: 373
			private static readonly IntPtr NativeMethodInfoPtr__getExecutingCommands_b__6_0_Internal_String_Command_0;
		}
	}
}
