using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.Immortality
{
	// Token: 0x020002E5 RID: 741
	public class SerializedGraftCard : SerializedAction
	{
		// Token: 0x06001E8C RID: 7820 RVA: 0x000D011C File Offset: 0x000CE31C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGraftCard()
		{
			Il2CppClassPointerStore<SerializedGraftCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.Immortality", "SerializedGraftCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGraftCard>.NativeClassPtr);
			SerializedGraftCard.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGraftCard>.NativeClassPtr, "PlayerID");
			SerializedGraftCard.NativeFieldInfoPtr_GraftToID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGraftCard>.NativeClassPtr, "GraftToID");
			SerializedGraftCard.NativeFieldInfoPtr_GraftID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGraftCard>.NativeClassPtr, "GraftID");
			SerializedGraftCard.NativeFieldInfoPtr_KHAgentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGraftCard>.NativeClassPtr, "KHAgentID");
			SerializedGraftCard.NativeFieldInfoPtr_RanUndo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGraftCard>.NativeClassPtr, "RanUndo");
			SerializedGraftCard.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraftCard>.NativeClassPtr, 100670471);
			SerializedGraftCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraftCard>.NativeClassPtr, 100670472);
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x000D01D8 File Offset: 0x000CE3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171540, XrefRangeEnd = 171544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGraftCard.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x000D0234 File Offset: 0x000CE434
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGraftCard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGraftCard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraftCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x0000CCDA File Offset: 0x0000AEDA
		public SerializedGraftCard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x000D0270 File Offset: 0x000CE470
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x0000CCE3 File Offset: 0x0000AEE3
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraftCard.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraftCard.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x000D02A0 File Offset: 0x000CE4A0
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x0000CD02 File Offset: 0x0000AF02
		public unsafe EntityID GraftToID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraftCard.NativeFieldInfoPtr_GraftToID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraftCard.NativeFieldInfoPtr_GraftToID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x000D02D0 File Offset: 0x000CE4D0
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x0000CD21 File Offset: 0x0000AF21
		public unsafe EntityID GraftID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraftCard.NativeFieldInfoPtr_GraftID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraftCard.NativeFieldInfoPtr_GraftID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x000D0300 File Offset: 0x000CE500
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x0000CD40 File Offset: 0x0000AF40
		public unsafe EntityID KHAgentID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraftCard.NativeFieldInfoPtr_KHAgentID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraftCard.NativeFieldInfoPtr_KHAgentID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x000D0330 File Offset: 0x000CE530
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x0000CD5F File Offset: 0x0000AF5F
		public unsafe bool RanUndo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraftCard.NativeFieldInfoPtr_RanUndo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraftCard.NativeFieldInfoPtr_RanUndo)) = value;
			}
		}

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeFieldInfoPtr_GraftToID;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeFieldInfoPtr_GraftID;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeFieldInfoPtr_KHAgentID;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeFieldInfoPtr_RanUndo;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
