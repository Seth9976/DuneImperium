using System;
using boardgames.match.selection;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using worm.match.prompts.behaviours;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000284 RID: 644
	public class WormResearchSelectionCommand : DBGBasicEntityListSelectionCommand
	{
		// Token: 0x06001A41 RID: 6721 RVA: 0x00068C94 File Offset: 0x00066E94
		// Note: this type is marked as 'beforefieldinit'.
		static WormResearchSelectionCommand()
		{
			Il2CppClassPointerStore<WormResearchSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormResearchSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormResearchSelectionCommand>.NativeClassPtr);
			WormResearchSelectionCommand.NativeFieldInfoPtr_isTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchSelectionCommand>.NativeClassPtr, "isTutorial");
			WormResearchSelectionCommand.NativeFieldInfoPtr_imperiumRowWasOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchSelectionCommand>.NativeClassPtr, "imperiumRowWasOpen");
			WormResearchSelectionCommand.NativeFieldInfoPtr_wasOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchSelectionCommand>.NativeClassPtr, "wasOpen");
			WormResearchSelectionCommand.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchSelectionCommand>.NativeClassPtr, "prompt");
			WormResearchSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchSelectionCommand>.NativeClassPtr, 100667121);
			WormResearchSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchSelectionCommand>.NativeClassPtr, 100667122);
			WormResearchSelectionCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchSelectionCommand>.NativeClassPtr, 100667123);
			WormResearchSelectionCommand.NativeMethodInfoPtr_RestoreModalState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchSelectionCommand>.NativeClassPtr, 100667124);
			WormResearchSelectionCommand.NativeMethodInfoPtr___n__0_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchSelectionCommand>.NativeClassPtr, 100667125);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x00068D78 File Offset: 0x00066F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormResearchSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormResearchSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x00068DD4 File Offset: 0x00066FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722765, XrefRangeEnd = 722770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormResearchSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00068E20 File Offset: 0x00067020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722770, XrefRangeEnd = 722785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void exitNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormResearchSelectionCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00068E5C File Offset: 0x0006705C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 722792, RefRangeEnd = 722794, XrefRangeStart = 722785, XrefRangeEnd = 722792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreModalState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchSelectionCommand.NativeMethodInfoPtr_RestoreModalState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00068E90 File Offset: 0x00067090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchSelectionCommand.NativeMethodInfoPtr___n__0_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0000F4FA File Offset: 0x0000D6FA
		public WormResearchSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001A48 RID: 6728 RVA: 0x00068ED0 File Offset: 0x000670D0
		// (set) Token: 0x06001A49 RID: 6729 RVA: 0x0000F503 File Offset: 0x0000D703
		public unsafe bool isTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchSelectionCommand.NativeFieldInfoPtr_isTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchSelectionCommand.NativeFieldInfoPtr_isTutorial)) = value;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x00068EF8 File Offset: 0x000670F8
		// (set) Token: 0x06001A4B RID: 6731 RVA: 0x0000F51E File Offset: 0x0000D71E
		public unsafe bool imperiumRowWasOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchSelectionCommand.NativeFieldInfoPtr_imperiumRowWasOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchSelectionCommand.NativeFieldInfoPtr_imperiumRowWasOpen)) = value;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x00068F20 File Offset: 0x00067120
		// (set) Token: 0x06001A4D RID: 6733 RVA: 0x0000F539 File Offset: 0x0000D739
		public unsafe bool wasOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchSelectionCommand.NativeFieldInfoPtr_wasOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchSelectionCommand.NativeFieldInfoPtr_wasOpen)) = value;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x00068F48 File Offset: 0x00067148
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x0000F554 File Offset: 0x0000D754
		public unsafe WormTleilaxPromptBehaviour prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchSelectionCommand.NativeFieldInfoPtr_prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTleilaxPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchSelectionCommand.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeFieldInfoPtr_isTutorial;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeFieldInfoPtr_imperiumRowWasOpen;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeFieldInfoPtr_wasOpen;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeFieldInfoPtr_prompt;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeMethodInfoPtr_RestoreModalState_Private_Void_0;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_0;

		// Token: 0x0200042F RID: 1071
		[ObfuscatedName("worm.match.commands.selectionCommands.WormResearchSelectionCommand+<idle>d__5")]
		public sealed class _idle_d__5 : Object
		{
			// Token: 0x06002C6F RID: 11375 RVA: 0x0009ECF4 File Offset: 0x0009CEF4
			// Note: this type is marked as 'beforefieldinit'.
			static _idle_d__5()
			{
				Il2CppClassPointerStore<WormResearchSelectionCommand._idle_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormResearchSelectionCommand>.NativeClassPtr, "<idle>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormResearchSelectionCommand._idle_d__5>.NativeClassPtr);
				WormResearchSelectionCommand._idle_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchSelectionCommand._idle_d__5>.NativeClassPtr, "<>1__state");
				WormResearchSelectionCommand._idle_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchSelectionCommand._idle_d__5>.NativeClassPtr, "<>2__current");
				WormResearchSelectionCommand._idle_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchSelectionCommand._idle_d__5>.NativeClassPtr, "<>4__this");
				WormResearchSelectionCommand._idle_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchSelectionCommand._idle_d__5>.NativeClassPtr, 100667126);
				WormResearchSelectionCommand._idle_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchSelectionCommand._idle_d__5>.NativeClassPtr, 100667127);
				WormResearchSelectionCommand._idle_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchSelectionCommand._idle_d__5>.NativeClassPtr, 100667128);
				WormResearchSelectionCommand._idle_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchSelectionCommand._idle_d__5>.NativeClassPtr, 100667129);
				WormResearchSelectionCommand._idle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchSelectionCommand._idle_d__5>.NativeClassPtr, 100667130);
				WormResearchSelectionCommand._idle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchSelectionCommand._idle_d__5>.NativeClassPtr, 100667131);
			}

			// Token: 0x06002C70 RID: 11376 RVA: 0x0009EDD4 File Offset: 0x0009CFD4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _idle_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormResearchSelectionCommand._idle_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchSelectionCommand._idle_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C71 RID: 11377 RVA: 0x0009EE1C File Offset: 0x0009D01C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchSelectionCommand._idle_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C72 RID: 11378 RVA: 0x0009EE50 File Offset: 0x0009D050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722749, XrefRangeEnd = 722760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchSelectionCommand._idle_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CBC RID: 3260
			// (get) Token: 0x06002C73 RID: 11379 RVA: 0x0009EE8C File Offset: 0x0009D08C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchSelectionCommand._idle_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C74 RID: 11380 RVA: 0x0009EECC File Offset: 0x0009D0CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722760, XrefRangeEnd = 722765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchSelectionCommand._idle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CBD RID: 3261
			// (get) Token: 0x06002C75 RID: 11381 RVA: 0x0009EF00 File Offset: 0x0009D100
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchSelectionCommand._idle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C76 RID: 11382 RVA: 0x00018216 File Offset: 0x00016416
			public _idle_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CB9 RID: 3257
			// (get) Token: 0x06002C77 RID: 11383 RVA: 0x0009EF40 File Offset: 0x0009D140
			// (set) Token: 0x06002C78 RID: 11384 RVA: 0x0001821F File Offset: 0x0001641F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchSelectionCommand._idle_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchSelectionCommand._idle_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CBA RID: 3258
			// (get) Token: 0x06002C79 RID: 11385 RVA: 0x0009EF68 File Offset: 0x0009D168
			// (set) Token: 0x06002C7A RID: 11386 RVA: 0x0001823A File Offset: 0x0001643A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchSelectionCommand._idle_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchSelectionCommand._idle_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CBB RID: 3259
			// (get) Token: 0x06002C7B RID: 11387 RVA: 0x0009EF98 File Offset: 0x0009D198
			// (set) Token: 0x06002C7C RID: 11388 RVA: 0x00018259 File Offset: 0x00016459
			public unsafe WormResearchSelectionCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchSelectionCommand._idle_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormResearchSelectionCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchSelectionCommand._idle_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019D8 RID: 6616
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019D9 RID: 6617
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019DA RID: 6618
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019DB RID: 6619
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019DC RID: 6620
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019DD RID: 6621
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019DE RID: 6622
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019DF RID: 6623
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019E0 RID: 6624
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
