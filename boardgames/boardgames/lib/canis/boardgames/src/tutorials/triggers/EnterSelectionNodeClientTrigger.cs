using System;
using dwd.core.eventTriggers.clientTriggers;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Networking.clientevents;

namespace lib.canis.boardgames.src.tutorials.triggers
{
	// Token: 0x02000036 RID: 54
	public class EnterSelectionNodeClientTrigger : ClientTrigger
	{
		// Token: 0x06000245 RID: 581 RVA: 0x00018390 File Offset: 0x00016590
		// Note: this type is marked as 'beforefieldinit'.
		static EnterSelectionNodeClientTrigger()
		{
			Il2CppClassPointerStore<EnterSelectionNodeClientTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lib.canis.boardgames.src.tutorials.triggers", "EnterSelectionNodeClientTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnterSelectionNodeClientTrigger>.NativeClassPtr);
			EnterSelectionNodeClientTrigger.NativeFieldInfoPtr_selectionNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnterSelectionNodeClientTrigger>.NativeClassPtr, "selectionNode");
			EnterSelectionNodeClientTrigger.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterSelectionNodeClientTrigger>.NativeClassPtr, 100663720);
			EnterSelectionNodeClientTrigger.NativeMethodInfoPtr_matches_Protected_Virtual_Boolean_ClientEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterSelectionNodeClientTrigger>.NativeClassPtr, 100663721);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000183FC File Offset: 0x000165FC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 983240, RefRangeEnd = 983255, XrefRangeStart = 983240, XrefRangeEnd = 983255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnterSelectionNodeClientTrigger(ISelectionNode selectionNode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnterSelectionNodeClientTrigger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterSelectionNodeClientTrigger.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00018448 File Offset: 0x00016648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984786, XrefRangeEnd = 984793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool matches(ClientEvent clientEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnterSelectionNodeClientTrigger.NativeMethodInfoPtr_matches_Protected_Virtual_Boolean_ClientEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002FC9 File Offset: 0x000011C9
		public EnterSelectionNodeClientTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000249 RID: 585 RVA: 0x000184A0 File Offset: 0x000166A0
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00002FD2 File Offset: 0x000011D2
		public unsafe ISelectionNode selectionNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterSelectionNodeClientTrigger.NativeFieldInfoPtr_selectionNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterSelectionNodeClientTrigger.NativeFieldInfoPtr_selectionNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_selectionNode;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_matches_Protected_Virtual_Boolean_ClientEvent_0;
	}
}
