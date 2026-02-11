using System;
using dwd.core.eventTriggers.clientTriggers;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Networking.clientevents;

namespace lib.canis.boardgames.src.tutorials.triggers
{
	// Token: 0x02000037 RID: 55
	public class EnterSelectionWithPromptClientTrigger : ClientTrigger
	{
		// Token: 0x0600024B RID: 587 RVA: 0x000184D0 File Offset: 0x000166D0
		// Note: this type is marked as 'beforefieldinit'.
		static EnterSelectionWithPromptClientTrigger()
		{
			Il2CppClassPointerStore<EnterSelectionWithPromptClientTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lib.canis.boardgames.src.tutorials.triggers", "EnterSelectionWithPromptClientTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnterSelectionWithPromptClientTrigger>.NativeClassPtr);
			EnterSelectionWithPromptClientTrigger.NativeFieldInfoPtr_selectionNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnterSelectionWithPromptClientTrigger>.NativeClassPtr, "selectionNode");
			EnterSelectionWithPromptClientTrigger.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterSelectionWithPromptClientTrigger>.NativeClassPtr, 100663722);
			EnterSelectionWithPromptClientTrigger.NativeMethodInfoPtr_matches_Protected_Virtual_Boolean_ClientEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterSelectionWithPromptClientTrigger>.NativeClassPtr, 100663723);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0001853C File Offset: 0x0001673C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 983240, RefRangeEnd = 983255, XrefRangeStart = 983240, XrefRangeEnd = 983255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnterSelectionWithPromptClientTrigger(ISelectionNode selectionNode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnterSelectionWithPromptClientTrigger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterSelectionWithPromptClientTrigger.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00018588 File Offset: 0x00016788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984793, XrefRangeEnd = 984800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool matches(ClientEvent clientEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnterSelectionWithPromptClientTrigger.NativeMethodInfoPtr_matches_Protected_Virtual_Boolean_ClientEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002FF1 File Offset: 0x000011F1
		public EnterSelectionWithPromptClientTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600024F RID: 591 RVA: 0x000185E0 File Offset: 0x000167E0
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00002FFA File Offset: 0x000011FA
		public unsafe ISelectionNode selectionNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterSelectionWithPromptClientTrigger.NativeFieldInfoPtr_selectionNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterSelectionWithPromptClientTrigger.NativeFieldInfoPtr_selectionNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_selectionNode;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_matches_Protected_Virtual_Boolean_ClientEvent_0;
	}
}
