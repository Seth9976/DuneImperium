using System;
using Canis.logging;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace lotus.src.match.commands.messageCommands
{
	// Token: 0x020000F7 RID: 247
	public class ServerLoggingMessageCommand : Command
	{
		// Token: 0x06000BEC RID: 3052 RVA: 0x00036F60 File Offset: 0x00035160
		// Note: this type is marked as 'beforefieldinit'.
		static ServerLoggingMessageCommand()
		{
			Il2CppClassPointerStore<ServerLoggingMessageCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.src.match.commands.messageCommands", "ServerLoggingMessageCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerLoggingMessageCommand>.NativeClassPtr);
			ServerLoggingMessageCommand.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerLoggingMessageCommand>.NativeClassPtr, "message");
			ServerLoggingMessageCommand.NativeMethodInfoPtr__ctor_Public_Void_ServerLoggingMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerLoggingMessageCommand>.NativeClassPtr, 100665192);
			ServerLoggingMessageCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerLoggingMessageCommand>.NativeClassPtr, 100665193);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00036FCC File Offset: 0x000351CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerLoggingMessageCommand(ServerLoggingMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerLoggingMessageCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerLoggingMessageCommand.NativeMethodInfoPtr__ctor_Public_Void_ServerLoggingMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00037018 File Offset: 0x00035218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995122, XrefRangeEnd = 995127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerLoggingMessageCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00007810 File Offset: 0x00005A10
		public ServerLoggingMessageCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00037064 File Offset: 0x00035264
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00007819 File Offset: 0x00005A19
		public unsafe string message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerLoggingMessageCommand.NativeFieldInfoPtr_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerLoggingMessageCommand.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServerLoggingMessage_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200024A RID: 586
		[ObfuscatedName("lotus.src.match.commands.messageCommands.ServerLoggingMessageCommand+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06001B27 RID: 6951 RVA: 0x00064E94 File Offset: 0x00063094
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<ServerLoggingMessageCommand._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerLoggingMessageCommand>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerLoggingMessageCommand._execute_d__2>.NativeClassPtr);
				ServerLoggingMessageCommand._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerLoggingMessageCommand._execute_d__2>.NativeClassPtr, "<>1__state");
				ServerLoggingMessageCommand._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerLoggingMessageCommand._execute_d__2>.NativeClassPtr, "<>2__current");
				ServerLoggingMessageCommand._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerLoggingMessageCommand._execute_d__2>.NativeClassPtr, "<>4__this");
				ServerLoggingMessageCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerLoggingMessageCommand._execute_d__2>.NativeClassPtr, 100665194);
				ServerLoggingMessageCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerLoggingMessageCommand._execute_d__2>.NativeClassPtr, 100665195);
				ServerLoggingMessageCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerLoggingMessageCommand._execute_d__2>.NativeClassPtr, 100665196);
				ServerLoggingMessageCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerLoggingMessageCommand._execute_d__2>.NativeClassPtr, 100665197);
				ServerLoggingMessageCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerLoggingMessageCommand._execute_d__2>.NativeClassPtr, 100665198);
				ServerLoggingMessageCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerLoggingMessageCommand._execute_d__2>.NativeClassPtr, 100665199);
			}

			// Token: 0x06001B28 RID: 6952 RVA: 0x00064F74 File Offset: 0x00063174
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerLoggingMessageCommand._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerLoggingMessageCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B29 RID: 6953 RVA: 0x00064FBC File Offset: 0x000631BC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerLoggingMessageCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B2A RID: 6954 RVA: 0x00064FF0 File Offset: 0x000631F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995109, XrefRangeEnd = 995117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerLoggingMessageCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007FF RID: 2047
			// (get) Token: 0x06001B2B RID: 6955 RVA: 0x0006502C File Offset: 0x0006322C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerLoggingMessageCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B2C RID: 6956 RVA: 0x0006506C File Offset: 0x0006326C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995117, XrefRangeEnd = 995122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerLoggingMessageCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000800 RID: 2048
			// (get) Token: 0x06001B2D RID: 6957 RVA: 0x000650A0 File Offset: 0x000632A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerLoggingMessageCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B2E RID: 6958 RVA: 0x0000EBDE File Offset: 0x0000CDDE
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007FC RID: 2044
			// (get) Token: 0x06001B2F RID: 6959 RVA: 0x000650E0 File Offset: 0x000632E0
			// (set) Token: 0x06001B30 RID: 6960 RVA: 0x0000EBE7 File Offset: 0x0000CDE7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerLoggingMessageCommand._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerLoggingMessageCommand._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007FD RID: 2045
			// (get) Token: 0x06001B31 RID: 6961 RVA: 0x00065108 File Offset: 0x00063308
			// (set) Token: 0x06001B32 RID: 6962 RVA: 0x0000EC02 File Offset: 0x0000CE02
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerLoggingMessageCommand._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerLoggingMessageCommand._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007FE RID: 2046
			// (get) Token: 0x06001B33 RID: 6963 RVA: 0x00065138 File Offset: 0x00063338
			// (set) Token: 0x06001B34 RID: 6964 RVA: 0x0000EC21 File Offset: 0x0000CE21
			public unsafe ServerLoggingMessageCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerLoggingMessageCommand._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerLoggingMessageCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerLoggingMessageCommand._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400106A RID: 4202
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400106B RID: 4203
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400106C RID: 4204
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400106D RID: 4205
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400106E RID: 4206
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400106F RID: 4207
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001070 RID: 4208
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001071 RID: 4209
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001072 RID: 4210
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
