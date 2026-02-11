using System;
using boardgames.match;
using boardgames.match.behaviours;
using boardgames.match.commands;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.match;
using dwd.core.ui.match.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lib.canis.dbg_client.voodoo;
using lotus;

namespace dbgclient.sequences
{
	// Token: 0x0200008F RID: 143
	public class DBGPassToPlayerSequence : VoodooGenericSequence
	{
		// Token: 0x06000591 RID: 1425 RVA: 0x0002F388 File Offset: 0x0002D588
		// Note: this type is marked as 'beforefieldinit'.
		static DBGPassToPlayerSequence()
		{
			Il2CppClassPointerStore<DBGPassToPlayerSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.sequences", "DBGPassToPlayerSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGPassToPlayerSequence>.NativeClassPtr);
			DBGPassToPlayerSequence.NativeMethodInfoPtr_get_SkipAICurtain_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerSequence>.NativeClassPtr, 100664147);
			DBGPassToPlayerSequence.NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerSequence>.NativeClassPtr, 100664148);
			DBGPassToPlayerSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerSequence>.NativeClassPtr, 100664149);
			DBGPassToPlayerSequence.NativeMethodInfoPtr_GetPromptData_Protected_Abstract_Virtual_New_DataComposition_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerSequence>.NativeClassPtr, 100664150);
			DBGPassToPlayerSequence.NativeMethodInfoPtr_SkipPlayer_Protected_Virtual_New_Boolean_AccountID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerSequence>.NativeClassPtr, 100664151);
			DBGPassToPlayerSequence.NativeMethodInfoPtr_PostUIReinit_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerSequence>.NativeClassPtr, 100664152);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0002F430 File Offset: 0x0002D630
		public unsafe virtual bool SkipAICurtain
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGPassToPlayerSequence.NativeMethodInfoPtr_get_SkipAICurtain_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0002F478 File Offset: 0x0002D678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGPassToPlayerSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGPassToPlayerSequence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerSequence.NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0002F4E8 File Offset: 0x0002D6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502088, XrefRangeEnd = 502093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator executeSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGPassToPlayerSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0002F534 File Offset: 0x0002D734
		[CallerCount(0)]
		public unsafe virtual DataComposition GetPromptData(EntityComponent newPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGPassToPlayerSequence.NativeMethodInfoPtr_GetPromptData_Protected_Abstract_Virtual_New_DataComposition_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0002F590 File Offset: 0x0002D790
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SkipPlayer(AccountID accountID, EntityComponent playerEntityComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerEntityComponent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGPassToPlayerSequence.NativeMethodInfoPtr_SkipPlayer_Protected_Virtual_New_Boolean_AccountID_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0002F5FC File Offset: 0x0002D7FC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostUIReinit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGPassToPlayerSequence.NativeMethodInfoPtr_PostUIReinit_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000047F0 File Offset: 0x000029F0
		public DBGPassToPlayerSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_get_SkipAICurtain_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_GetPromptData_Protected_Abstract_Virtual_New_DataComposition_EntityComponent_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_SkipPlayer_Protected_Virtual_New_Boolean_AccountID_EntityComponent_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_PostUIReinit_Protected_Virtual_New_Void_0;

		// Token: 0x02000303 RID: 771
		[ObfuscatedName("dbgclient.sequences.DBGPassToPlayerSequence+<executeSequence>d__3")]
		public sealed class _executeSequence_d__3 : Object
		{
			// Token: 0x0600246F RID: 9327 RVA: 0x000956C4 File Offset: 0x000938C4
			// Note: this type is marked as 'beforefieldinit'.
			static _executeSequence_d__3()
			{
				Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGPassToPlayerSequence>.NativeClassPtr, "<executeSequence>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr);
				DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, "<>1__state");
				DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, "<>2__current");
				DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, "<>4__this");
				DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__passToPlayer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, "<passToPlayer>5__2");
				DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__entities_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, "<entities>5__3");
				DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__curtain_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, "<curtain>5__4");
				DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__matchHub_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, "<matchHub>5__5");
				DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__playerUIViews_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, "<playerUIViews>5__6");
				DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr___7__wrap6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, "<>7__wrap6");
				DBGPassToPlayerSequence._executeSequence_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, 100664153);
				DBGPassToPlayerSequence._executeSequence_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, 100664154);
				DBGPassToPlayerSequence._executeSequence_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, 100664155);
				DBGPassToPlayerSequence._executeSequence_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, 100664156);
				DBGPassToPlayerSequence._executeSequence_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, 100664157);
				DBGPassToPlayerSequence._executeSequence_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, 100664158);
				DBGPassToPlayerSequence._executeSequence_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr, 100664159);
			}

			// Token: 0x06002470 RID: 9328 RVA: 0x00095830 File Offset: 0x00093A30
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _executeSequence_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGPassToPlayerSequence._executeSequence_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerSequence._executeSequence_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002471 RID: 9329 RVA: 0x00095878 File Offset: 0x00093A78
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 501958, RefRangeEnd = 501959, XrefRangeStart = 501953, XrefRangeEnd = 501958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerSequence._executeSequence_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002472 RID: 9330 RVA: 0x000958AC File Offset: 0x00093AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501959, XrefRangeEnd = 502080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerSequence._executeSequence_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002473 RID: 9331 RVA: 0x000958E8 File Offset: 0x00093AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502080, XrefRangeEnd = 502083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerSequence._executeSequence_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A00 RID: 2560
			// (get) Token: 0x06002474 RID: 9332 RVA: 0x0009591C File Offset: 0x00093B1C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerSequence._executeSequence_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002475 RID: 9333 RVA: 0x0009595C File Offset: 0x00093B5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502083, XrefRangeEnd = 502088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerSequence._executeSequence_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A01 RID: 2561
			// (get) Token: 0x06002476 RID: 9334 RVA: 0x00095990 File Offset: 0x00093B90
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerSequence._executeSequence_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002477 RID: 9335 RVA: 0x00012F5C File Offset: 0x0001115C
			public _executeSequence_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009F7 RID: 2551
			// (get) Token: 0x06002478 RID: 9336 RVA: 0x000959D0 File Offset: 0x00093BD0
			// (set) Token: 0x06002479 RID: 9337 RVA: 0x00012F65 File Offset: 0x00011165
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009F8 RID: 2552
			// (get) Token: 0x0600247A RID: 9338 RVA: 0x000959F8 File Offset: 0x00093BF8
			// (set) Token: 0x0600247B RID: 9339 RVA: 0x00012F80 File Offset: 0x00011180
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F9 RID: 2553
			// (get) Token: 0x0600247C RID: 9340 RVA: 0x00095A28 File Offset: 0x00093C28
			// (set) Token: 0x0600247D RID: 9341 RVA: 0x00012F9F File Offset: 0x0001119F
			public unsafe DBGPassToPlayerSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGPassToPlayerSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FA RID: 2554
			// (get) Token: 0x0600247E RID: 9342 RVA: 0x00095A58 File Offset: 0x00093C58
			// (set) Token: 0x0600247F RID: 9343 RVA: 0x00012FBE File Offset: 0x000111BE
			public unsafe DBGPassToPlayerCommand _passToPlayer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__passToPlayer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGPassToPlayerCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__passToPlayer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FB RID: 2555
			// (get) Token: 0x06002480 RID: 9344 RVA: 0x00095A88 File Offset: 0x00093C88
			// (set) Token: 0x06002481 RID: 9345 RVA: 0x00012FDD File Offset: 0x000111DD
			public unsafe DBGEntities _entities_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__entities_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__entities_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FC RID: 2556
			// (get) Token: 0x06002482 RID: 9346 RVA: 0x00095AB8 File Offset: 0x00093CB8
			// (set) Token: 0x06002483 RID: 9347 RVA: 0x00012FFC File Offset: 0x000111FC
			public unsafe FlavoredDismissablePrompt _curtain_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__curtain_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredDismissablePrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__curtain_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FD RID: 2557
			// (get) Token: 0x06002484 RID: 9348 RVA: 0x00095AE8 File Offset: 0x00093CE8
			// (set) Token: 0x06002485 RID: 9349 RVA: 0x0001301B File Offset: 0x0001121B
			public unsafe DBGMatchHub _matchHub_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__matchHub_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__matchHub_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FE RID: 2558
			// (get) Token: 0x06002486 RID: 9350 RVA: 0x00095B18 File Offset: 0x00093D18
			// (set) Token: 0x06002487 RID: 9351 RVA: 0x0001303A File Offset: 0x0001123A
			public unsafe Il2CppReferenceArray<PassAndPlayResetView> _playerUIViews_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__playerUIViews_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PassAndPlayResetView>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr__playerUIViews_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FF RID: 2559
			// (get) Token: 0x06002488 RID: 9352 RVA: 0x00095B48 File Offset: 0x00093D48
			// (set) Token: 0x06002489 RID: 9353 RVA: 0x00013059 File Offset: 0x00011259
			public unsafe IEnumerator<Command> __7__wrap6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr___7__wrap6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerSequence._executeSequence_d__3.NativeFieldInfoPtr___7__wrap6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016E3 RID: 5859
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016E4 RID: 5860
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016E5 RID: 5861
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016E6 RID: 5862
			private static readonly IntPtr NativeFieldInfoPtr__passToPlayer_5__2;

			// Token: 0x040016E7 RID: 5863
			private static readonly IntPtr NativeFieldInfoPtr__entities_5__3;

			// Token: 0x040016E8 RID: 5864
			private static readonly IntPtr NativeFieldInfoPtr__curtain_5__4;

			// Token: 0x040016E9 RID: 5865
			private static readonly IntPtr NativeFieldInfoPtr__matchHub_5__5;

			// Token: 0x040016EA RID: 5866
			private static readonly IntPtr NativeFieldInfoPtr__playerUIViews_5__6;

			// Token: 0x040016EB RID: 5867
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap6;

			// Token: 0x040016EC RID: 5868
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016ED RID: 5869
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016EE RID: 5870
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016EF RID: 5871
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040016F0 RID: 5872
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016F1 RID: 5873
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016F2 RID: 5874
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
