using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Networking.selection.messages;
using Networking.selection.messages.outgoing;

namespace zen.match.selection
{
	// Token: 0x02000047 RID: 71
	public class SelectionFactory : Object
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x0001A33C File Offset: 0x0001853C
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionFactory()
		{
			Il2CppClassPointerStore<SelectionFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.match.selection", "SelectionFactory");
			SelectionFactory.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFactory>.NativeClassPtr, "Instance");
			SelectionFactory.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFactory>.NativeClassPtr, 100663795);
			SelectionFactory.NativeMethodInfoPtr_dwd_core_match_delorean_ISelectionCommandParser_GetCommand_Private_Virtual_Final_New_Command_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFactory>.NativeClassPtr, 100663796);
			SelectionFactory.NativeMethodInfoPtr_dwd_core_match_delorean_ISelectionCommandParser_GetCommand_Private_Virtual_Final_New_Command_SelectionFinished_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFactory>.NativeClassPtr, 100663797);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0001A3B4 File Offset: 0x000185B4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFactory.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0001A3F0 File Offset: 0x000185F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985432, XrefRangeEnd = 985436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command dwd_core_match_delorean_ISelectionCommandParser_GetCommand(SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFactory.NativeMethodInfoPtr_dwd_core_match_delorean_ISelectionCommandParser_GetCommand_Private_Virtual_Final_New_Command_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0001A440 File Offset: 0x00018640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985436, XrefRangeEnd = 985440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command dwd_core_match_delorean_ISelectionCommandParser_GetCommand(SelectionFinished message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFactory.NativeMethodInfoPtr_dwd_core_match_delorean_ISelectionCommandParser_GetCommand_Private_Virtual_Final_New_Command_SelectionFinished_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00003370 File Offset: 0x00001570
		public SelectionFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0001A490 File Offset: 0x00018690
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00003379 File Offset: 0x00001579
		public unsafe static SelectionFactory Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SelectionFactory.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionFactory>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SelectionFactory.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_match_delorean_ISelectionCommandParser_GetCommand_Private_Virtual_Final_New_Command_SelectionMessage_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_match_delorean_ISelectionCommandParser_GetCommand_Private_Virtual_Final_New_Command_SelectionFinished_0;
	}
}
