using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000260 RID: 608
	public class WormStingerSequence : VoodooGroupedSequence
	{
		// Token: 0x06001944 RID: 6468 RVA: 0x00064FC8 File Offset: 0x000631C8
		// Note: this type is marked as 'beforefieldinit'.
		static WormStingerSequence()
		{
			Il2CppClassPointerStore<WormStingerSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormStingerSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerSequence>.NativeClassPtr);
			WormStingerSequence.NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerSequence>.NativeClassPtr, 100666900);
			WormStingerSequence.NativeMethodInfoPtr_get_StingerName_Protected_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerSequence>.NativeClassPtr, 100666901);
			WormStingerSequence.NativeMethodInfoPtr_get_OnlyShowOpponents_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerSequence>.NativeClassPtr, 100666902);
			WormStingerSequence.NativeMethodInfoPtr_get_Show_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerSequence>.NativeClassPtr, 100666903);
			WormStingerSequence.NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerSequence>.NativeClassPtr, 100666904);
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0006505C File Offset: 0x0006325C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormStingerSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerSequence.NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x000650CC File Offset: 0x000632CC
		public unsafe virtual string StingerName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormStingerSequence.NativeMethodInfoPtr_get_StingerName_Protected_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001947 RID: 6471 RVA: 0x00065110 File Offset: 0x00063310
		public unsafe virtual bool OnlyShowOpponents
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormStingerSequence.NativeMethodInfoPtr_get_OnlyShowOpponents_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x00065158 File Offset: 0x00063358
		public unsafe virtual bool Show
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720003, XrefRangeEnd = 720061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormStingerSequence.NativeMethodInfoPtr_get_Show_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x000651A0 File Offset: 0x000633A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720061, XrefRangeEnd = 720066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator PostLastGroupCommand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormStingerSequence.NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0000EF28 File Offset: 0x0000D128
		public WormStingerSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr_get_StingerName_Protected_Virtual_New_get_String_0;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_get_OnlyShowOpponents_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_get_Show_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200041D RID: 1053
		[ObfuscatedName("worm.match.commands.sequenceCommands.WormStingerSequence+<PostLastGroupCommand>d__7")]
		public sealed class _PostLastGroupCommand_d__7 : Object
		{
			// Token: 0x06002B8C RID: 11148 RVA: 0x0009C038 File Offset: 0x0009A238
			// Note: this type is marked as 'beforefieldinit'.
			static _PostLastGroupCommand_d__7()
			{
				Il2CppClassPointerStore<WormStingerSequence._PostLastGroupCommand_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormStingerSequence>.NativeClassPtr, "<PostLastGroupCommand>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerSequence._PostLastGroupCommand_d__7>.NativeClassPtr);
				WormStingerSequence._PostLastGroupCommand_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerSequence._PostLastGroupCommand_d__7>.NativeClassPtr, "<>1__state");
				WormStingerSequence._PostLastGroupCommand_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerSequence._PostLastGroupCommand_d__7>.NativeClassPtr, "<>2__current");
				WormStingerSequence._PostLastGroupCommand_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerSequence._PostLastGroupCommand_d__7>.NativeClassPtr, "<>4__this");
				WormStingerSequence._PostLastGroupCommand_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerSequence._PostLastGroupCommand_d__7>.NativeClassPtr, 100666905);
				WormStingerSequence._PostLastGroupCommand_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerSequence._PostLastGroupCommand_d__7>.NativeClassPtr, 100666906);
				WormStingerSequence._PostLastGroupCommand_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerSequence._PostLastGroupCommand_d__7>.NativeClassPtr, 100666907);
				WormStingerSequence._PostLastGroupCommand_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerSequence._PostLastGroupCommand_d__7>.NativeClassPtr, 100666908);
				WormStingerSequence._PostLastGroupCommand_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerSequence._PostLastGroupCommand_d__7>.NativeClassPtr, 100666909);
				WormStingerSequence._PostLastGroupCommand_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerSequence._PostLastGroupCommand_d__7>.NativeClassPtr, 100666910);
			}

			// Token: 0x06002B8D RID: 11149 RVA: 0x0009C118 File Offset: 0x0009A318
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PostLastGroupCommand_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerSequence._PostLastGroupCommand_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerSequence._PostLastGroupCommand_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B8E RID: 11150 RVA: 0x0009C160 File Offset: 0x0009A360
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerSequence._PostLastGroupCommand_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B8F RID: 11151 RVA: 0x0009C194 File Offset: 0x0009A394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719987, XrefRangeEnd = 719998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerSequence._PostLastGroupCommand_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C72 RID: 3186
			// (get) Token: 0x06002B90 RID: 11152 RVA: 0x0009C1D0 File Offset: 0x0009A3D0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerSequence._PostLastGroupCommand_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B91 RID: 11153 RVA: 0x0009C210 File Offset: 0x0009A410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719998, XrefRangeEnd = 720003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerSequence._PostLastGroupCommand_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C73 RID: 3187
			// (get) Token: 0x06002B92 RID: 11154 RVA: 0x0009C244 File Offset: 0x0009A444
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerSequence._PostLastGroupCommand_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B93 RID: 11155 RVA: 0x00017BC9 File Offset: 0x00015DC9
			public _PostLastGroupCommand_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C6F RID: 3183
			// (get) Token: 0x06002B94 RID: 11156 RVA: 0x0009C284 File Offset: 0x0009A484
			// (set) Token: 0x06002B95 RID: 11157 RVA: 0x00017BD2 File Offset: 0x00015DD2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerSequence._PostLastGroupCommand_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerSequence._PostLastGroupCommand_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C70 RID: 3184
			// (get) Token: 0x06002B96 RID: 11158 RVA: 0x0009C2AC File Offset: 0x0009A4AC
			// (set) Token: 0x06002B97 RID: 11159 RVA: 0x00017BED File Offset: 0x00015DED
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerSequence._PostLastGroupCommand_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerSequence._PostLastGroupCommand_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C71 RID: 3185
			// (get) Token: 0x06002B98 RID: 11160 RVA: 0x0009C2DC File Offset: 0x0009A4DC
			// (set) Token: 0x06002B99 RID: 11161 RVA: 0x00017C0C File Offset: 0x00015E0C
			public unsafe WormStingerSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerSequence._PostLastGroupCommand_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormStingerSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerSequence._PostLastGroupCommand_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400194D RID: 6477
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400194E RID: 6478
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400194F RID: 6479
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001950 RID: 6480
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001951 RID: 6481
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001952 RID: 6482
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001953 RID: 6483
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001954 RID: 6484
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001955 RID: 6485
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
