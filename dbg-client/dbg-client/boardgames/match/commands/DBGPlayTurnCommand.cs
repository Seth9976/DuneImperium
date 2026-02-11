using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Networking.game;
using UnityEngine.Networking;

namespace boardgames.match.commands
{
	// Token: 0x02000297 RID: 663
	public class DBGPlayTurnCommand : FailableCommand
	{
		// Token: 0x06001F24 RID: 7972 RVA: 0x000856FC File Offset: 0x000838FC
		// Note: this type is marked as 'beforefieldinit'.
		static DBGPlayTurnCommand()
		{
			Il2CppClassPointerStore<DBGPlayTurnCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "DBGPlayTurnCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGPlayTurnCommand>.NativeClassPtr);
			DBGPlayTurnCommand.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlayTurnCommand>.NativeClassPtr, "gameID");
			DBGPlayTurnCommand.NativeMethodInfoPtr__ctor_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlayTurnCommand>.NativeClassPtr, 100668501);
			DBGPlayTurnCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlayTurnCommand>.NativeClassPtr, 100668502);
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00085768 File Offset: 0x00083968
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 539238, RefRangeEnd = 539243, XrefRangeStart = 539238, XrefRangeEnd = 539243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGPlayTurnCommand(GameID gameID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGPlayTurnCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlayTurnCommand.NativeMethodInfoPtr__ctor_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x000857B4 File Offset: 0x000839B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540862, XrefRangeEnd = 540867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGPlayTurnCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x000105FB File Offset: 0x0000E7FB
		public DBGPlayTurnCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x00085800 File Offset: 0x00083A00
		// (set) Token: 0x06001F29 RID: 7977 RVA: 0x00010604 File Offset: 0x0000E804
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_0;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000494 RID: 1172
		[ObfuscatedName("boardgames.match.commands.DBGPlayTurnCommand+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600379A RID: 14234 RVA: 0x000CEAA4 File Offset: 0x000CCCA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGPlayTurnCommand.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGPlayTurnCommand>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGPlayTurnCommand.__c>.NativeClassPtr);
				DBGPlayTurnCommand.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlayTurnCommand.__c>.NativeClassPtr, "<>9");
				DBGPlayTurnCommand.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlayTurnCommand.__c>.NativeClassPtr, "<>9__2_0");
				DBGPlayTurnCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlayTurnCommand.__c>.NativeClassPtr, 100668504);
				DBGPlayTurnCommand.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlayTurnCommand.__c>.NativeClassPtr, 100668505);
			}

			// Token: 0x0600379B RID: 14235 RVA: 0x000CEB20 File Offset: 0x000CCD20
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGPlayTurnCommand.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlayTurnCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600379C RID: 14236 RVA: 0x000CEB5C File Offset: 0x000CCD5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540816, XrefRangeEnd = 540824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__2_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlayTurnCommand.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600379D RID: 14237 RVA: 0x0001C95B File Offset: 0x0001AB5B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001067 RID: 4199
			// (get) Token: 0x0600379E RID: 14238 RVA: 0x000CEBA0 File Offset: 0x000CCDA0
			// (set) Token: 0x0600379F RID: 14239 RVA: 0x0001C964 File Offset: 0x0001AB64
			public unsafe static DBGPlayTurnCommand.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGPlayTurnCommand.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGPlayTurnCommand.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGPlayTurnCommand.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001068 RID: 4200
			// (get) Token: 0x060037A0 RID: 14240 RVA: 0x000CEBC8 File Offset: 0x000CCDC8
			// (set) Token: 0x060037A1 RID: 14241 RVA: 0x0001C976 File Offset: 0x0001AB76
			public unsafe static Action<UnityWebRequest> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGPlayTurnCommand.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGPlayTurnCommand.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002236 RID: 8758
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002237 RID: 8759
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04002238 RID: 8760
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002239 RID: 8761
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x02000495 RID: 1173
		[ObfuscatedName("boardgames.match.commands.DBGPlayTurnCommand+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060037A2 RID: 14242 RVA: 0x000CEBF0 File Offset: 0x000CCDF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DBGPlayTurnCommand.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGPlayTurnCommand>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGPlayTurnCommand.__c__DisplayClass2_0>.NativeClassPtr);
				DBGPlayTurnCommand.__c__DisplayClass2_0.NativeFieldInfoPtr_gameSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlayTurnCommand.__c__DisplayClass2_0>.NativeClassPtr, "gameSession");
				DBGPlayTurnCommand.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlayTurnCommand.__c__DisplayClass2_0>.NativeClassPtr, 100668506);
				DBGPlayTurnCommand.__c__DisplayClass2_0.NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlayTurnCommand.__c__DisplayClass2_0>.NativeClassPtr, 100668507);
			}

			// Token: 0x060037A3 RID: 14243 RVA: 0x000CEC58 File Offset: 0x000CCE58
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGPlayTurnCommand.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlayTurnCommand.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037A4 RID: 14244 RVA: 0x000CEC94 File Offset: 0x000CCE94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540824, XrefRangeEnd = 540833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__1(DwdWebRequestCommand request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlayTurnCommand.__c__DisplayClass2_0.NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037A5 RID: 14245 RVA: 0x0001C988 File Offset: 0x0001AB88
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001069 RID: 4201
			// (get) Token: 0x060037A6 RID: 14246 RVA: 0x000CECD8 File Offset: 0x000CCED8
			// (set) Token: 0x060037A7 RID: 14247 RVA: 0x0001C991 File Offset: 0x0001AB91
			public unsafe DWDGameSession gameSession
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand.__c__DisplayClass2_0.NativeFieldInfoPtr_gameSession);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDGameSession>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand.__c__DisplayClass2_0.NativeFieldInfoPtr_gameSession), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400223A RID: 8762
			private static readonly IntPtr NativeFieldInfoPtr_gameSession;

			// Token: 0x0400223B RID: 8763
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400223C RID: 8764
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0;
		}

		// Token: 0x02000496 RID: 1174
		[ObfuscatedName("boardgames.match.commands.DBGPlayTurnCommand+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x060037A8 RID: 14248 RVA: 0x000CED08 File Offset: 0x000CCF08
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGPlayTurnCommand>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr);
				DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr, "<>1__state");
				DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr, "<>2__current");
				DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr, "<>4__this");
				DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr, "<>8__1");
				DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr__url_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr, "<url>5__2");
				DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr__requestCommand_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr, "<requestCommand>5__3");
				DBGPlayTurnCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr, 100668508);
				DBGPlayTurnCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr, 100668509);
				DBGPlayTurnCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr, 100668510);
				DBGPlayTurnCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr, 100668511);
				DBGPlayTurnCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr, 100668512);
				DBGPlayTurnCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr, 100668513);
			}

			// Token: 0x060037A9 RID: 14249 RVA: 0x000CEE24 File Offset: 0x000CD024
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGPlayTurnCommand._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlayTurnCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037AA RID: 14250 RVA: 0x000CEE6C File Offset: 0x000CD06C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlayTurnCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037AB RID: 14251 RVA: 0x000CEEA0 File Offset: 0x000CD0A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540833, XrefRangeEnd = 540857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlayTurnCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001070 RID: 4208
			// (get) Token: 0x060037AC RID: 14252 RVA: 0x000CEEDC File Offset: 0x000CD0DC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlayTurnCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060037AD RID: 14253 RVA: 0x000CEF1C File Offset: 0x000CD11C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540857, XrefRangeEnd = 540862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlayTurnCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001071 RID: 4209
			// (get) Token: 0x060037AE RID: 14254 RVA: 0x000CEF50 File Offset: 0x000CD150
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlayTurnCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060037AF RID: 14255 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700106A RID: 4202
			// (get) Token: 0x060037B0 RID: 14256 RVA: 0x000CEF90 File Offset: 0x000CD190
			// (set) Token: 0x060037B1 RID: 14257 RVA: 0x0001C9B9 File Offset: 0x0001ABB9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700106B RID: 4203
			// (get) Token: 0x060037B2 RID: 14258 RVA: 0x000CEFB8 File Offset: 0x000CD1B8
			// (set) Token: 0x060037B3 RID: 14259 RVA: 0x0001C9D4 File Offset: 0x0001ABD4
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700106C RID: 4204
			// (get) Token: 0x060037B4 RID: 14260 RVA: 0x000CEFE8 File Offset: 0x000CD1E8
			// (set) Token: 0x060037B5 RID: 14261 RVA: 0x0001C9F3 File Offset: 0x0001ABF3
			public unsafe DBGPlayTurnCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGPlayTurnCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700106D RID: 4205
			// (get) Token: 0x060037B6 RID: 14262 RVA: 0x000CF018 File Offset: 0x000CD218
			// (set) Token: 0x060037B7 RID: 14263 RVA: 0x0001CA12 File Offset: 0x0001AC12
			public unsafe DBGPlayTurnCommand.__c__DisplayClass2_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGPlayTurnCommand.__c__DisplayClass2_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700106E RID: 4206
			// (get) Token: 0x060037B8 RID: 14264 RVA: 0x000CF048 File Offset: 0x000CD248
			// (set) Token: 0x060037B9 RID: 14265 RVA: 0x0001CA31 File Offset: 0x0001AC31
			public unsafe string _url_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr__url_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr__url_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700106F RID: 4207
			// (get) Token: 0x060037BA RID: 14266 RVA: 0x000CF070 File Offset: 0x000CD270
			// (set) Token: 0x060037BB RID: 14267 RVA: 0x0001CA50 File Offset: 0x0001AC50
			public unsafe DwdWebRequestCommand _requestCommand_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr__requestCommand_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlayTurnCommand._execute_d__2.NativeFieldInfoPtr__requestCommand_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400223D RID: 8765
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400223E RID: 8766
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400223F RID: 8767
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002240 RID: 8768
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04002241 RID: 8769
			private static readonly IntPtr NativeFieldInfoPtr__url_5__2;

			// Token: 0x04002242 RID: 8770
			private static readonly IntPtr NativeFieldInfoPtr__requestCommand_5__3;

			// Token: 0x04002243 RID: 8771
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002244 RID: 8772
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002245 RID: 8773
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002246 RID: 8774
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002247 RID: 8775
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002248 RID: 8776
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
