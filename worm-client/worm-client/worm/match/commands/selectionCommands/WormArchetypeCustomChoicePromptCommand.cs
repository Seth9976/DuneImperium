using System;
using boardgames.match.selection;
using dwd.core.data.composition;
using dwd.core.match.selection;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000272 RID: 626
	public class WormArchetypeCustomChoicePromptCommand : DBGSelectionCommand<ArchetypeCustomChoiceTargetInfoNode>
	{
		// Token: 0x060019B7 RID: 6583 RVA: 0x00066C94 File Offset: 0x00064E94
		// Note: this type is marked as 'beforefieldinit'.
		static WormArchetypeCustomChoicePromptCommand()
		{
			Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormArchetypeCustomChoicePromptCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand>.NativeClassPtr);
			WormArchetypeCustomChoicePromptCommand.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand>.NativeClassPtr, "prompt");
			WormArchetypeCustomChoicePromptCommand.NativeFieldInfoPtr_promptData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand>.NativeClassPtr, "promptData");
			WormArchetypeCustomChoicePromptCommand.NativeFieldInfoPtr_promptFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand>.NativeClassPtr, "promptFlavors");
			WormArchetypeCustomChoicePromptCommand.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand>.NativeClassPtr, 100667008);
			WormArchetypeCustomChoicePromptCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand>.NativeClassPtr, 100667009);
			WormArchetypeCustomChoicePromptCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand>.NativeClassPtr, 100667010);
			WormArchetypeCustomChoicePromptCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand>.NativeClassPtr, 100667011);
			WormArchetypeCustomChoicePromptCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand>.NativeClassPtr, 100667012);
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00066D64 File Offset: 0x00064F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720840, XrefRangeEnd = 720843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormArchetypeCustomChoicePromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptCommand.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x00066DC0 File Offset: 0x00064FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720843, XrefRangeEnd = 720848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCustomChoicePromptCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x00066E0C File Offset: 0x0006500C
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCustomChoicePromptCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00066E54 File Offset: 0x00065054
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNode(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCustomChoicePromptCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00066EA0 File Offset: 0x000650A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720848, XrefRangeEnd = 720851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void exitNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCustomChoicePromptCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0000F16E File Offset: 0x0000D36E
		public WormArchetypeCustomChoicePromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x00066EDC File Offset: 0x000650DC
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x0000F177 File Offset: 0x0000D377
		public unsafe ArchetypeCustomChoiceInfoPrompt prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptCommand.NativeFieldInfoPtr_prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeCustomChoiceInfoPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptCommand.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x00066F0C File Offset: 0x0006510C
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x0000F196 File Offset: 0x0000D396
		public unsafe DataComposition promptData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptCommand.NativeFieldInfoPtr_promptData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptCommand.NativeFieldInfoPtr_promptData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x00066F3C File Offset: 0x0006513C
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0000F1B5 File Offset: 0x0000D3B5
		public PrefabFlavorContext promptFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptCommand.NativeFieldInfoPtr_promptFlavors);
				return new PrefabFlavorContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptCommand.NativeFieldInfoPtr_promptFlavors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeFieldInfoPtr_prompt;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeFieldInfoPtr_promptData;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeFieldInfoPtr_promptFlavors;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0;

		// Token: 0x02000424 RID: 1060
		[ObfuscatedName("worm.match.commands.selectionCommands.WormArchetypeCustomChoicePromptCommand+<idle>d__4")]
		public sealed class _idle_d__4 : Object
		{
			// Token: 0x06002BF8 RID: 11256 RVA: 0x0009D590 File Offset: 0x0009B790
			// Note: this type is marked as 'beforefieldinit'.
			static _idle_d__4()
			{
				Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand._idle_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand>.NativeClassPtr, "<idle>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand._idle_d__4>.NativeClassPtr);
				WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand._idle_d__4>.NativeClassPtr, "<>1__state");
				WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand._idle_d__4>.NativeClassPtr, "<>2__current");
				WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand._idle_d__4>.NativeClassPtr, "<>4__this");
				WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand._idle_d__4>.NativeClassPtr, 100667013);
				WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand._idle_d__4>.NativeClassPtr, 100667014);
				WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand._idle_d__4>.NativeClassPtr, 100667015);
				WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand._idle_d__4>.NativeClassPtr, 100667016);
				WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand._idle_d__4>.NativeClassPtr, 100667017);
				WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand._idle_d__4>.NativeClassPtr, 100667018);
			}

			// Token: 0x06002BF9 RID: 11257 RVA: 0x0009D670 File Offset: 0x0009B870
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _idle_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptCommand._idle_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002BFA RID: 11258 RVA: 0x0009D6B8 File Offset: 0x0009B8B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BFB RID: 11259 RVA: 0x0009D6EC File Offset: 0x0009B8EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720821, XrefRangeEnd = 720835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C98 RID: 3224
			// (get) Token: 0x06002BFC RID: 11260 RVA: 0x0009D728 File Offset: 0x0009B928
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002BFD RID: 11261 RVA: 0x0009D768 File Offset: 0x0009B968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720835, XrefRangeEnd = 720840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C99 RID: 3225
			// (get) Token: 0x06002BFE RID: 11262 RVA: 0x0009D79C File Offset: 0x0009B99C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002BFF RID: 11263 RVA: 0x00017EC8 File Offset: 0x000160C8
			public _idle_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C95 RID: 3221
			// (get) Token: 0x06002C00 RID: 11264 RVA: 0x0009D7DC File Offset: 0x0009B9DC
			// (set) Token: 0x06002C01 RID: 11265 RVA: 0x00017ED1 File Offset: 0x000160D1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C96 RID: 3222
			// (get) Token: 0x06002C02 RID: 11266 RVA: 0x0009D804 File Offset: 0x0009BA04
			// (set) Token: 0x06002C03 RID: 11267 RVA: 0x00017EEC File Offset: 0x000160EC
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C97 RID: 3223
			// (get) Token: 0x06002C04 RID: 11268 RVA: 0x0009D834 File Offset: 0x0009BA34
			// (set) Token: 0x06002C05 RID: 11269 RVA: 0x00017F0B File Offset: 0x0001610B
			public unsafe WormArchetypeCustomChoicePromptCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormArchetypeCustomChoicePromptCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptCommand._idle_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001991 RID: 6545
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001992 RID: 6546
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001993 RID: 6547
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001994 RID: 6548
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001995 RID: 6549
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001996 RID: 6550
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001997 RID: 6551
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001998 RID: 6552
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001999 RID: 6553
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
