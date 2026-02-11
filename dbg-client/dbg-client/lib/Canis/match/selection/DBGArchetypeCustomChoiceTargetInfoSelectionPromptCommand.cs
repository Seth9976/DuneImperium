using System;
using boardgames.match.selection;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lib.canis.match.selection
{
	// Token: 0x02000022 RID: 34
	public class DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand : DBGBaseArchetypeCustomChoiceSelectionPromptCommand<ArchetypeCustomChoiceTargetInfoNode>
	{
		// Token: 0x0600013A RID: 314 RVA: 0x000218D8 File Offset: 0x0001FAD8
		// Note: this type is marked as 'beforefieldinit'.
		static DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand()
		{
			Il2CppClassPointerStore<DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.match.selection", "DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand>.NativeClassPtr);
			DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand>.NativeClassPtr, 100663539);
			DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand>.NativeClassPtr, 100663540);
			DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand.NativeMethodInfoPtr_getPrompt_Protected_Virtual_DBGSelectionPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand>.NativeClassPtr, 100663541);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00021944 File Offset: 0x0001FB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497387, XrefRangeEnd = 497390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000219A0 File Offset: 0x0001FBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497390, XrefRangeEnd = 497399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool submitSelection(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000219F4 File Offset: 0x0001FBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497399, XrefRangeEnd = 497407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DBGSelectionPrompt getPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand.NativeMethodInfoPtr_getPrompt_Protected_Virtual_DBGSelectionPrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGSelectionPrompt>(intPtr3) : null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002789 File Offset: 0x00000989
		public DBGArchetypeCustomChoiceTargetInfoSelectionPromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_Int32_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_getPrompt_Protected_Virtual_DBGSelectionPrompt_0;
	}
}
