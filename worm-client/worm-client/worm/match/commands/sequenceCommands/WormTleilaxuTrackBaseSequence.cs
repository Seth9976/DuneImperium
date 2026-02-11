using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.match.prompts.behaviours;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000264 RID: 612
	public class WormTleilaxuTrackBaseSequence : WormStingerSequence
	{
		// Token: 0x06001955 RID: 6485 RVA: 0x000653E0 File Offset: 0x000635E0
		// Note: this type is marked as 'beforefieldinit'.
		static WormTleilaxuTrackBaseSequence()
		{
			Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormTleilaxuTrackBaseSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence>.NativeClassPtr);
			WormTleilaxuTrackBaseSequence.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence>.NativeClassPtr, "prompt");
			WormTleilaxuTrackBaseSequence.NativeFieldInfoPtr_animate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence>.NativeClassPtr, "animate");
			WormTleilaxuTrackBaseSequence.NativeFieldInfoPtr_imperiumRowWasOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence>.NativeClassPtr, "imperiumRowWasOpen");
			WormTleilaxuTrackBaseSequence.NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence>.NativeClassPtr, 100666921);
			WormTleilaxuTrackBaseSequence.NativeMethodInfoPtr_PreSequence_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence>.NativeClassPtr, 100666922);
			WormTleilaxuTrackBaseSequence.NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence>.NativeClassPtr, 100666923);
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00065488 File Offset: 0x00063688
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTleilaxuTrackBaseSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrackBaseSequence.NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x000654F8 File Offset: 0x000636F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720117, XrefRangeEnd = 720122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator PreSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTleilaxuTrackBaseSequence.NativeMethodInfoPtr_PreSequence_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00065544 File Offset: 0x00063744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720122, XrefRangeEnd = 720130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator PostLastGroupCommand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTleilaxuTrackBaseSequence.NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0000EFBE File Offset: 0x0000D1BE
		public WormTleilaxuTrackBaseSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x00065590 File Offset: 0x00063790
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x0000EFC7 File Offset: 0x0000D1C7
		public unsafe WormTleilaxPromptBehaviour prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrackBaseSequence.NativeFieldInfoPtr_prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTleilaxPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrackBaseSequence.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x000655C0 File Offset: 0x000637C0
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x0000EFE6 File Offset: 0x0000D1E6
		public unsafe bool animate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrackBaseSequence.NativeFieldInfoPtr_animate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrackBaseSequence.NativeFieldInfoPtr_animate)) = value;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x000655E8 File Offset: 0x000637E8
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x0000F001 File Offset: 0x0000D201
		public unsafe bool imperiumRowWasOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrackBaseSequence.NativeFieldInfoPtr_imperiumRowWasOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrackBaseSequence.NativeFieldInfoPtr_imperiumRowWasOpen)) = value;
			}
		}

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeFieldInfoPtr_prompt;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeFieldInfoPtr_animate;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeFieldInfoPtr_imperiumRowWasOpen;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr_PreSequence_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200041F RID: 1055
		[ObfuscatedName("worm.match.commands.sequenceCommands.WormTleilaxuTrackBaseSequence+<PreSequence>d__4")]
		public sealed class _PreSequence_d__4 : Object
		{
			// Token: 0x06002BA8 RID: 11176 RVA: 0x0009C5E0 File Offset: 0x0009A7E0
			// Note: this type is marked as 'beforefieldinit'.
			static _PreSequence_d__4()
			{
				Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence._PreSequence_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence>.NativeClassPtr, "<PreSequence>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence._PreSequence_d__4>.NativeClassPtr);
				WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence._PreSequence_d__4>.NativeClassPtr, "<>1__state");
				WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence._PreSequence_d__4>.NativeClassPtr, "<>2__current");
				WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence._PreSequence_d__4>.NativeClassPtr, "<>4__this");
				WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence._PreSequence_d__4>.NativeClassPtr, 100666924);
				WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence._PreSequence_d__4>.NativeClassPtr, 100666925);
				WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence._PreSequence_d__4>.NativeClassPtr, 100666926);
				WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence._PreSequence_d__4>.NativeClassPtr, 100666927);
				WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence._PreSequence_d__4>.NativeClassPtr, 100666928);
				WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence._PreSequence_d__4>.NativeClassPtr, 100666929);
			}

			// Token: 0x06002BA9 RID: 11177 RVA: 0x0009C6C0 File Offset: 0x0009A8C0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PreSequence_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTleilaxuTrackBaseSequence._PreSequence_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002BAA RID: 11178 RVA: 0x0009C708 File Offset: 0x0009A908
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BAB RID: 11179 RVA: 0x0009C73C File Offset: 0x0009A93C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720104, XrefRangeEnd = 720112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C7C RID: 3196
			// (get) Token: 0x06002BAC RID: 11180 RVA: 0x0009C778 File Offset: 0x0009A978
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002BAD RID: 11181 RVA: 0x0009C7B8 File Offset: 0x0009A9B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720112, XrefRangeEnd = 720117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C7D RID: 3197
			// (get) Token: 0x06002BAE RID: 11182 RVA: 0x0009C7EC File Offset: 0x0009A9EC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002BAF RID: 11183 RVA: 0x00017C8D File Offset: 0x00015E8D
			public _PreSequence_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C79 RID: 3193
			// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x0009C82C File Offset: 0x0009AA2C
			// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x00017C96 File Offset: 0x00015E96
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C7A RID: 3194
			// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x0009C854 File Offset: 0x0009AA54
			// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x00017CB1 File Offset: 0x00015EB1
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C7B RID: 3195
			// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x0009C884 File Offset: 0x0009AA84
			// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x00017CD0 File Offset: 0x00015ED0
			public unsafe WormTleilaxuTrackBaseSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTleilaxuTrackBaseSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrackBaseSequence._PreSequence_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400195F RID: 6495
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001960 RID: 6496
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001961 RID: 6497
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001962 RID: 6498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001963 RID: 6499
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001964 RID: 6500
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001965 RID: 6501
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001966 RID: 6502
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001967 RID: 6503
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
