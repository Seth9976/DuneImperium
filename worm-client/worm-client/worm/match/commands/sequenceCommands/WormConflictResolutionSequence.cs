using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using worm.canis.actions.phases;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000244 RID: 580
	public class WormConflictResolutionSequence : VoodooGroupedSequence
	{
		// Token: 0x060018DD RID: 6365 RVA: 0x00063B04 File Offset: 0x00061D04
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictResolutionSequence()
		{
			Il2CppClassPointerStore<WormConflictResolutionSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormConflictResolutionSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictResolutionSequence>.NativeClassPtr);
			WormConflictResolutionSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResolutionSequence>.NativeClassPtr, 100666809);
			WormConflictResolutionSequence.NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResolutionSequence>.NativeClassPtr, 100666810);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00063B5C File Offset: 0x00061D5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictResolutionSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictResolutionSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResolutionSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00063BCC File Offset: 0x00061DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719455, XrefRangeEnd = 719460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator PostLastGroupCommand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConflictResolutionSequence.NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0000EA72 File Offset: 0x0000CC72
		public WormConflictResolutionSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000414 RID: 1044
		[ObfuscatedName("worm.match.commands.sequenceCommands.WormConflictResolutionSequence+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002B18 RID: 11032 RVA: 0x0009A968 File Offset: 0x00098B68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormConflictResolutionSequence.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictResolutionSequence>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictResolutionSequence.__c>.NativeClassPtr);
				WormConflictResolutionSequence.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResolutionSequence.__c>.NativeClassPtr, "<>9");
				WormConflictResolutionSequence.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResolutionSequence.__c>.NativeClassPtr, "<>9__1_0");
				WormConflictResolutionSequence.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResolutionSequence.__c>.NativeClassPtr, 100666812);
				WormConflictResolutionSequence.__c.NativeMethodInfoPtr__PostLastGroupCommand_b__1_0_Internal_Int32_SerializedPlayerReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResolutionSequence.__c>.NativeClassPtr, 100666813);
			}

			// Token: 0x06002B19 RID: 11033 RVA: 0x0009A9E4 File Offset: 0x00098BE4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictResolutionSequence.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResolutionSequence.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B1A RID: 11034 RVA: 0x0009AA20 File Offset: 0x00098C20
			[CallerCount(0)]
			public unsafe int _PostLastGroupCommand_b__1_0(SerializedPlayerReward playerReward)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerReward);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResolutionSequence.__c.NativeMethodInfoPtr__PostLastGroupCommand_b__1_0_Internal_Int32_SerializedPlayerReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B1B RID: 11035 RVA: 0x00017888 File Offset: 0x00015A88
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C47 RID: 3143
			// (get) Token: 0x06002B1C RID: 11036 RVA: 0x0009AA70 File Offset: 0x00098C70
			// (set) Token: 0x06002B1D RID: 11037 RVA: 0x00017891 File Offset: 0x00015A91
			public unsafe static WormConflictResolutionSequence.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictResolutionSequence.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictResolutionSequence.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictResolutionSequence.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C48 RID: 3144
			// (get) Token: 0x06002B1E RID: 11038 RVA: 0x0009AA98 File Offset: 0x00098C98
			// (set) Token: 0x06002B1F RID: 11039 RVA: 0x000178A3 File Offset: 0x00015AA3
			public unsafe static Func<SerializedPlayerReward, int> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictResolutionSequence.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedPlayerReward, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictResolutionSequence.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001905 RID: 6405
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001906 RID: 6406
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001907 RID: 6407
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001908 RID: 6408
			private static readonly IntPtr NativeMethodInfoPtr__PostLastGroupCommand_b__1_0_Internal_Int32_SerializedPlayerReward_0;
		}

		// Token: 0x02000415 RID: 1045
		[ObfuscatedName("worm.match.commands.sequenceCommands.WormConflictResolutionSequence+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06002B20 RID: 11040 RVA: 0x0009AAC0 File Offset: 0x00098CC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<WormConflictResolutionSequence.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictResolutionSequence>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictResolutionSequence.__c__DisplayClass1_0>.NativeClassPtr);
				WormConflictResolutionSequence.__c__DisplayClass1_0.NativeFieldInfoPtr_firstPlayerReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResolutionSequence.__c__DisplayClass1_0>.NativeClassPtr, "firstPlayerReward");
				WormConflictResolutionSequence.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResolutionSequence.__c__DisplayClass1_0>.NativeClassPtr, 100666814);
				WormConflictResolutionSequence.__c__DisplayClass1_0.NativeMethodInfoPtr__PostLastGroupCommand_b__1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResolutionSequence.__c__DisplayClass1_0>.NativeClassPtr, 100666815);
			}

			// Token: 0x06002B21 RID: 11041 RVA: 0x0009AB28 File Offset: 0x00098D28
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictResolutionSequence.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResolutionSequence.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B22 RID: 11042 RVA: 0x0009AB64 File Offset: 0x00098D64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719327, XrefRangeEnd = 719333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PostLastGroupCommand_b__1(EntityComponent player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResolutionSequence.__c__DisplayClass1_0.NativeMethodInfoPtr__PostLastGroupCommand_b__1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B23 RID: 11043 RVA: 0x000178B5 File Offset: 0x00015AB5
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C49 RID: 3145
			// (get) Token: 0x06002B24 RID: 11044 RVA: 0x0009ABB4 File Offset: 0x00098DB4
			// (set) Token: 0x06002B25 RID: 11045 RVA: 0x000178BE File Offset: 0x00015ABE
			public unsafe Il2CppReferenceArray<SerializedPlayerReward> firstPlayerReward
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResolutionSequence.__c__DisplayClass1_0.NativeFieldInfoPtr_firstPlayerReward);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SerializedPlayerReward>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResolutionSequence.__c__DisplayClass1_0.NativeFieldInfoPtr_firstPlayerReward), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001909 RID: 6409
			private static readonly IntPtr NativeFieldInfoPtr_firstPlayerReward;

			// Token: 0x0400190A RID: 6410
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400190B RID: 6411
			private static readonly IntPtr NativeMethodInfoPtr__PostLastGroupCommand_b__1_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000416 RID: 1046
		[ObfuscatedName("worm.match.commands.sequenceCommands.WormConflictResolutionSequence+<PostLastGroupCommand>d__1")]
		public sealed class _PostLastGroupCommand_d__1 : Object
		{
			// Token: 0x06002B26 RID: 11046 RVA: 0x0009ABE4 File Offset: 0x00098DE4
			// Note: this type is marked as 'beforefieldinit'.
			static _PostLastGroupCommand_d__1()
			{
				Il2CppClassPointerStore<WormConflictResolutionSequence._PostLastGroupCommand_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictResolutionSequence>.NativeClassPtr, "<PostLastGroupCommand>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictResolutionSequence._PostLastGroupCommand_d__1>.NativeClassPtr);
				WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResolutionSequence._PostLastGroupCommand_d__1>.NativeClassPtr, "<>1__state");
				WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResolutionSequence._PostLastGroupCommand_d__1>.NativeClassPtr, "<>2__current");
				WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResolutionSequence._PostLastGroupCommand_d__1>.NativeClassPtr, "<>4__this");
				WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResolutionSequence._PostLastGroupCommand_d__1>.NativeClassPtr, "<>8__1");
				WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResolutionSequence._PostLastGroupCommand_d__1>.NativeClassPtr, 100666816);
				WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResolutionSequence._PostLastGroupCommand_d__1>.NativeClassPtr, 100666817);
				WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResolutionSequence._PostLastGroupCommand_d__1>.NativeClassPtr, 100666818);
				WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResolutionSequence._PostLastGroupCommand_d__1>.NativeClassPtr, 100666819);
				WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResolutionSequence._PostLastGroupCommand_d__1>.NativeClassPtr, 100666820);
				WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResolutionSequence._PostLastGroupCommand_d__1>.NativeClassPtr, 100666821);
			}

			// Token: 0x06002B27 RID: 11047 RVA: 0x0009ACD8 File Offset: 0x00098ED8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PostLastGroupCommand_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictResolutionSequence._PostLastGroupCommand_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B28 RID: 11048 RVA: 0x0009AD20 File Offset: 0x00098F20
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B29 RID: 11049 RVA: 0x0009AD54 File Offset: 0x00098F54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719333, XrefRangeEnd = 719450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C4E RID: 3150
			// (get) Token: 0x06002B2A RID: 11050 RVA: 0x0009AD90 File Offset: 0x00098F90
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B2B RID: 11051 RVA: 0x0009ADD0 File Offset: 0x00098FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719450, XrefRangeEnd = 719455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C4F RID: 3151
			// (get) Token: 0x06002B2C RID: 11052 RVA: 0x0009AE04 File Offset: 0x00099004
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B2D RID: 11053 RVA: 0x000178DD File Offset: 0x00015ADD
			public _PostLastGroupCommand_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C4A RID: 3146
			// (get) Token: 0x06002B2E RID: 11054 RVA: 0x0009AE44 File Offset: 0x00099044
			// (set) Token: 0x06002B2F RID: 11055 RVA: 0x000178E6 File Offset: 0x00015AE6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C4B RID: 3147
			// (get) Token: 0x06002B30 RID: 11056 RVA: 0x0009AE6C File Offset: 0x0009906C
			// (set) Token: 0x06002B31 RID: 11057 RVA: 0x00017901 File Offset: 0x00015B01
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C4C RID: 3148
			// (get) Token: 0x06002B32 RID: 11058 RVA: 0x0009AE9C File Offset: 0x0009909C
			// (set) Token: 0x06002B33 RID: 11059 RVA: 0x00017920 File Offset: 0x00015B20
			public unsafe WormConflictResolutionSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictResolutionSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C4D RID: 3149
			// (get) Token: 0x06002B34 RID: 11060 RVA: 0x0009AECC File Offset: 0x000990CC
			// (set) Token: 0x06002B35 RID: 11061 RVA: 0x0001793F File Offset: 0x00015B3F
			public unsafe WormConflictResolutionSequence.__c__DisplayClass1_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictResolutionSequence.__c__DisplayClass1_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResolutionSequence._PostLastGroupCommand_d__1.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400190C RID: 6412
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400190D RID: 6413
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400190E RID: 6414
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400190F RID: 6415
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001910 RID: 6416
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001911 RID: 6417
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001912 RID: 6418
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001913 RID: 6419
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001914 RID: 6420
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001915 RID: 6421
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
