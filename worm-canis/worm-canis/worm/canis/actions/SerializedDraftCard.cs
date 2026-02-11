using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.actions
{
	// Token: 0x0200023B RID: 571
	public class SerializedDraftCard : SerializedAction
	{
		// Token: 0x060018EE RID: 6382 RVA: 0x000B9F10 File Offset: 0x000B8110
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedDraftCard()
		{
			Il2CppClassPointerStore<SerializedDraftCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedDraftCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedDraftCard>.NativeClassPtr);
			SerializedDraftCard.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedDraftCard>.NativeClassPtr, "PlayerID");
			SerializedDraftCard.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedDraftCard>.NativeClassPtr, "Options");
			SerializedDraftCard.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDraftCard>.NativeClassPtr, 100667721);
			SerializedDraftCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDraftCard>.NativeClassPtr, 100667722);
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x000B9F90 File Offset: 0x000B8190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134600, XrefRangeEnd = 134613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedDraftCard.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x000B9FEC File Offset: 0x000B81EC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedDraftCard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedDraftCard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedDraftCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0000ABDC File Offset: 0x00008DDC
		public SerializedDraftCard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x000BA028 File Offset: 0x000B8228
		// (set) Token: 0x060018F3 RID: 6387 RVA: 0x0000ABE5 File Offset: 0x00008DE5
		public unsafe AccountID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDraftCard.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDraftCard.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x000BA058 File Offset: 0x000B8258
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x0000AC04 File Offset: 0x00008E04
		public unsafe List<ArchetypeID> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDraftCard.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDraftCard.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
