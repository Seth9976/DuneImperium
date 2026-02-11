using System;
using boardgames.match.selection;
using dwd.core.data.composition;
using dwd.core.match.selection;
using dwd.core.ui.match.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using worm.match.prompts.behaviours;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000288 RID: 648
	public class WormSelectCardPromptDragTargetCommand : DBGBasicEntityListSelectionCommand
	{
		// Token: 0x06001A69 RID: 6761 RVA: 0x00069554 File Offset: 0x00067754
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectCardPromptDragTargetCommand()
		{
			Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormSelectCardPromptDragTargetCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr);
			WormSelectCardPromptDragTargetCommand.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr, "prompt");
			WormSelectCardPromptDragTargetCommand.NativeFieldInfoPtr_viewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr, "viewManager");
			WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_get_ShowSelectionPrompt_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr, 100667166);
			WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr, 100667167);
			WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr, 100667168);
			WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr, 100667169);
			WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr, 100667170);
			WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_makeDataComposition_Protected_Virtual_New_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr, 100667171);
			WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr, 100667172);
			WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr, 100667173);
			WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr, 100667174);
			WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr, 100667175);
			WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr, 100667176);
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00069688 File Offset: 0x00067888
		public unsafe override bool ShowSelectionPrompt
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_get_ShowSelectionPrompt_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x000696D0 File Offset: 0x000678D0
		public unsafe virtual string promptHeaderLoc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x00069714 File Offset: 0x00067914
		public unsafe virtual string promptFlavor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00069758 File Offset: 0x00067958
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 723215, RefRangeEnd = 723223, XrefRangeStart = 723210, XrefRangeEnd = 723215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectCardPromptDragTargetCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x000697B4 File Offset: 0x000679B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00069800 File Offset: 0x00067A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723223, XrefRangeEnd = 723252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataComposition makeDataComposition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_makeDataComposition_Protected_Virtual_New_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0006984C File Offset: 0x00067A4C
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00069894 File Offset: 0x00067A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 723294, RefRangeEnd = 723295, XrefRangeStart = 723252, XrefRangeEnd = 723294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNode(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x000698E0 File Offset: 0x00067AE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 723338, RefRangeEnd = 723339, XrefRangeStart = 723295, XrefRangeEnd = 723338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void exitNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0006991C File Offset: 0x00067B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723339, XrefRangeEnd = 723348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNodeHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00069958 File Offset: 0x00067B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723348, XrefRangeEnd = 723351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void resetHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectCardPromptDragTargetCommand.NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0000F620 File Offset: 0x0000D820
		public WormSelectCardPromptDragTargetCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x00069994 File Offset: 0x00067B94
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x0000F629 File Offset: 0x0000D829
		public unsafe FlavoredDismissablePrompt prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectCardPromptDragTargetCommand.NativeFieldInfoPtr_prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredDismissablePrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectCardPromptDragTargetCommand.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x000699C4 File Offset: 0x00067BC4
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x0000F648 File Offset: 0x0000D848
		public unsafe ViewManager viewManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectCardPromptDragTargetCommand.NativeFieldInfoPtr_viewManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectCardPromptDragTargetCommand.NativeFieldInfoPtr_viewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeFieldInfoPtr_prompt;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeFieldInfoPtr_viewManager;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeMethodInfoPtr_get_ShowSelectionPrompt_Protected_Virtual_get_Boolean_0;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeMethodInfoPtr_get_promptFlavor_Protected_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeMethodInfoPtr_makeDataComposition_Protected_Virtual_New_DataComposition_0;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0;

		// Token: 0x02000434 RID: 1076
		[ObfuscatedName("worm.match.commands.selectionCommands.WormSelectCardPromptDragTargetCommand+<idle>d__9")]
		public sealed class _idle_d__9 : Object
		{
			// Token: 0x06002CBB RID: 11451 RVA: 0x0009FB20 File Offset: 0x0009DD20
			// Note: this type is marked as 'beforefieldinit'.
			static _idle_d__9()
			{
				Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand._idle_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand>.NativeClassPtr, "<idle>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand._idle_d__9>.NativeClassPtr);
				WormSelectCardPromptDragTargetCommand._idle_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand._idle_d__9>.NativeClassPtr, "<>1__state");
				WormSelectCardPromptDragTargetCommand._idle_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand._idle_d__9>.NativeClassPtr, "<>2__current");
				WormSelectCardPromptDragTargetCommand._idle_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand._idle_d__9>.NativeClassPtr, "<>4__this");
				WormSelectCardPromptDragTargetCommand._idle_d__9.NativeFieldInfoPtr__existingPromptBehaviour_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand._idle_d__9>.NativeClassPtr, "<existingPromptBehaviour>5__2");
				WormSelectCardPromptDragTargetCommand._idle_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand._idle_d__9>.NativeClassPtr, 100667177);
				WormSelectCardPromptDragTargetCommand._idle_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand._idle_d__9>.NativeClassPtr, 100667178);
				WormSelectCardPromptDragTargetCommand._idle_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand._idle_d__9>.NativeClassPtr, 100667179);
				WormSelectCardPromptDragTargetCommand._idle_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand._idle_d__9>.NativeClassPtr, 100667180);
				WormSelectCardPromptDragTargetCommand._idle_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand._idle_d__9>.NativeClassPtr, 100667181);
				WormSelectCardPromptDragTargetCommand._idle_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand._idle_d__9>.NativeClassPtr, 100667182);
			}

			// Token: 0x06002CBC RID: 11452 RVA: 0x0009FC14 File Offset: 0x0009DE14
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _idle_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectCardPromptDragTargetCommand._idle_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectCardPromptDragTargetCommand._idle_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002CBD RID: 11453 RVA: 0x0009FC5C File Offset: 0x0009DE5C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectCardPromptDragTargetCommand._idle_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CBE RID: 11454 RVA: 0x0009FC90 File Offset: 0x0009DE90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723172, XrefRangeEnd = 723205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectCardPromptDragTargetCommand._idle_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CD9 RID: 3289
			// (get) Token: 0x06002CBF RID: 11455 RVA: 0x0009FCCC File Offset: 0x0009DECC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectCardPromptDragTargetCommand._idle_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CC0 RID: 11456 RVA: 0x0009FD0C File Offset: 0x0009DF0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723205, XrefRangeEnd = 723210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectCardPromptDragTargetCommand._idle_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CDA RID: 3290
			// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x0009FD40 File Offset: 0x0009DF40
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectCardPromptDragTargetCommand._idle_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CC2 RID: 11458 RVA: 0x00018481 File Offset: 0x00016681
			public _idle_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CD5 RID: 3285
			// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x0009FD80 File Offset: 0x0009DF80
			// (set) Token: 0x06002CC4 RID: 11460 RVA: 0x0001848A File Offset: 0x0001668A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectCardPromptDragTargetCommand._idle_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectCardPromptDragTargetCommand._idle_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CD6 RID: 3286
			// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x0009FDA8 File Offset: 0x0009DFA8
			// (set) Token: 0x06002CC6 RID: 11462 RVA: 0x000184A5 File Offset: 0x000166A5
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectCardPromptDragTargetCommand._idle_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectCardPromptDragTargetCommand._idle_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CD7 RID: 3287
			// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x0009FDD8 File Offset: 0x0009DFD8
			// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x000184C4 File Offset: 0x000166C4
			public unsafe WormSelectCardPromptDragTargetCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectCardPromptDragTargetCommand._idle_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSelectCardPromptDragTargetCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectCardPromptDragTargetCommand._idle_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CD8 RID: 3288
			// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x0009FE08 File Offset: 0x0009E008
			// (set) Token: 0x06002CCA RID: 11466 RVA: 0x000184E3 File Offset: 0x000166E3
			public unsafe WormImperiumRowPromptBehaviour _existingPromptBehaviour_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectCardPromptDragTargetCommand._idle_d__9.NativeFieldInfoPtr__existingPromptBehaviour_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumRowPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectCardPromptDragTargetCommand._idle_d__9.NativeFieldInfoPtr__existingPromptBehaviour_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A06 RID: 6662
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A07 RID: 6663
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A08 RID: 6664
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A09 RID: 6665
			private static readonly IntPtr NativeFieldInfoPtr__existingPromptBehaviour_5__2;

			// Token: 0x04001A0A RID: 6666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A0B RID: 6667
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A0C RID: 6668
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A0D RID: 6669
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A0E RID: 6670
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A0F RID: 6671
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
