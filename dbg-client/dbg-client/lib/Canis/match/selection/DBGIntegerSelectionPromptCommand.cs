using System;
using boardgames.match.selection;
using dwd.core.data.composition;
using dwd.core.match.selection;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lib.canis.match.selection
{
	// Token: 0x02000024 RID: 36
	public class DBGIntegerSelectionPromptCommand : DBGSelectionPromptCommand<IIntegerSelection>
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00021D34 File Offset: 0x0001FF34
		// Note: this type is marked as 'beforefieldinit'.
		static DBGIntegerSelectionPromptCommand()
		{
			Il2CppClassPointerStore<DBGIntegerSelectionPromptCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.match.selection", "DBGIntegerSelectionPromptCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGIntegerSelectionPromptCommand>.NativeClassPtr);
			DBGIntegerSelectionPromptCommand.NativeFieldInfoPtr_promptData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGIntegerSelectionPromptCommand>.NativeClassPtr, "promptData");
			DBGIntegerSelectionPromptCommand.NativeFieldInfoPtr_promptFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGIntegerSelectionPromptCommand>.NativeClassPtr, "promptFlavors");
			DBGIntegerSelectionPromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGIntegerSelectionPromptCommand>.NativeClassPtr, 100663547);
			DBGIntegerSelectionPromptCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGIntegerSelectionPromptCommand>.NativeClassPtr, 100663548);
			DBGIntegerSelectionPromptCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGIntegerSelectionPromptCommand>.NativeClassPtr, 100663549);
			DBGIntegerSelectionPromptCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGIntegerSelectionPromptCommand>.NativeClassPtr, 100663550);
			DBGIntegerSelectionPromptCommand.NativeMethodInfoPtr_getPromptData_Protected_Virtual_New_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGIntegerSelectionPromptCommand>.NativeClassPtr, 100663551);
			DBGIntegerSelectionPromptCommand.NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_New_PrefabFlavorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGIntegerSelectionPromptCommand>.NativeClassPtr, 100663552);
			DBGIntegerSelectionPromptCommand.NativeMethodInfoPtr_getPrompt_Protected_Virtual_DBGSelectionPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGIntegerSelectionPromptCommand>.NativeClassPtr, 100663553);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00021E18 File Offset: 0x00020018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497438, XrefRangeEnd = 497443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGIntegerSelectionPromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGIntegerSelectionPromptCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGIntegerSelectionPromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00021E74 File Offset: 0x00020074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497443, XrefRangeEnd = 497458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool submitSelection(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGIntegerSelectionPromptCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00021EC8 File Offset: 0x000200C8
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGIntegerSelectionPromptCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00021F10 File Offset: 0x00020110
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGIntegerSelectionPromptCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00021F5C File Offset: 0x0002015C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497458, XrefRangeEnd = 497478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataComposition getPromptData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGIntegerSelectionPromptCommand.NativeMethodInfoPtr_getPromptData_Protected_Virtual_New_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00021FA8 File Offset: 0x000201A8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PrefabFlavorContext getPromptFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGIntegerSelectionPromptCommand.NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_New_PrefabFlavorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PrefabFlavorContext(intPtr);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00021FEC File Offset: 0x000201EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497478, XrefRangeEnd = 497498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DBGSelectionPrompt getPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGIntegerSelectionPromptCommand.NativeMethodInfoPtr_getPrompt_Protected_Virtual_DBGSelectionPrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGSelectionPrompt>(intPtr3) : null;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002832 File Offset: 0x00000A32
		public DBGIntegerSelectionPromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00022038 File Offset: 0x00020238
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0000283B File Offset: 0x00000A3B
		public unsafe DataComposition promptData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGIntegerSelectionPromptCommand.NativeFieldInfoPtr_promptData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGIntegerSelectionPromptCommand.NativeFieldInfoPtr_promptData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00022068 File Offset: 0x00020268
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0000285A File Offset: 0x00000A5A
		public PrefabFlavorContext promptFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGIntegerSelectionPromptCommand.NativeFieldInfoPtr_promptFlavors);
				return new PrefabFlavorContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGIntegerSelectionPromptCommand.NativeFieldInfoPtr_promptFlavors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_promptData;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_promptFlavors;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_Int32_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_getPromptData_Protected_Virtual_New_DataComposition_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_New_PrefabFlavorContext_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_getPrompt_Protected_Virtual_DBGSelectionPrompt_0;
	}
}
