using System;
using boardgames.match.selection;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lib.canis.match.selection
{
	// Token: 0x02000021 RID: 33
	public class DBGArchetypeCustomChoiceSelectionPromptCommand : DBGBaseArchetypeCustomChoiceSelectionPromptCommand<ArchetypeCustomChoiceNode>
	{
		// Token: 0x06000135 RID: 309 RVA: 0x00021770 File Offset: 0x0001F970
		// Note: this type is marked as 'beforefieldinit'.
		static DBGArchetypeCustomChoiceSelectionPromptCommand()
		{
			Il2CppClassPointerStore<DBGArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.match.selection", "DBGArchetypeCustomChoiceSelectionPromptCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr);
			DBGArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, 100663536);
			DBGArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, 100663537);
			DBGArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_getPrompt_Protected_Virtual_DBGSelectionPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, 100663538);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000217DC File Offset: 0x0001F9DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497369, RefRangeEnd = 497370, XrefRangeStart = 497366, XrefRangeEnd = 497369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGArchetypeCustomChoiceSelectionPromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00021838 File Offset: 0x0001FA38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497378, RefRangeEnd = 497379, XrefRangeStart = 497370, XrefRangeEnd = 497378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool submitSelection(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0002188C File Offset: 0x0001FA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497379, XrefRangeEnd = 497387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DBGSelectionPrompt getPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_getPrompt_Protected_Virtual_DBGSelectionPrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGSelectionPrompt>(intPtr3) : null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002780 File Offset: 0x00000980
		public DBGArchetypeCustomChoiceSelectionPromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_Int32_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_getPrompt_Protected_Virtual_DBGSelectionPrompt_0;
	}
}
