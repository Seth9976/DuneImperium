using System;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001C1 RID: 449
	[Serializable]
	public class SerializedMoveMultiple : SerializedAction
	{
		// Token: 0x0600130D RID: 4877 RVA: 0x00066758 File Offset: 0x00064958
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedMoveMultiple()
		{
			Il2CppClassPointerStore<SerializedMoveMultiple>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedMoveMultiple");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedMoveMultiple>.NativeClassPtr);
			SerializedMoveMultiple.NativeFieldInfoPtr_DestinationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMoveMultiple>.NativeClassPtr, "DestinationID");
			SerializedMoveMultiple.NativeFieldInfoPtr_PositionInParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMoveMultiple>.NativeClassPtr, "PositionInParent");
			SerializedMoveMultiple.NativeFieldInfoPtr_SelectedTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMoveMultiple>.NativeClassPtr, "SelectedTargets");
			SerializedMoveMultiple.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMoveMultiple>.NativeClassPtr, 100667409);
			SerializedMoveMultiple.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMoveMultiple>.NativeClassPtr, 100667410);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x000667EC File Offset: 0x000649EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586423, XrefRangeEnd = 586455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedMoveMultiple.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00066848 File Offset: 0x00064A48
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedMoveMultiple()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedMoveMultiple>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMoveMultiple.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000095AD File Offset: 0x000077AD
		public SerializedMoveMultiple(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x00066884 File Offset: 0x00064A84
		// (set) Token: 0x06001312 RID: 4882 RVA: 0x000095B6 File Offset: 0x000077B6
		public unsafe EntityID DestinationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMoveMultiple.NativeFieldInfoPtr_DestinationID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMoveMultiple.NativeFieldInfoPtr_DestinationID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x000668B4 File Offset: 0x00064AB4
		// (set) Token: 0x06001314 RID: 4884 RVA: 0x000095D5 File Offset: 0x000077D5
		public Nullable<int> PositionInParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMoveMultiple.NativeFieldInfoPtr_PositionInParent);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMoveMultiple.NativeFieldInfoPtr_PositionInParent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x000668E4 File Offset: 0x00064AE4
		// (set) Token: 0x06001316 RID: 4886 RVA: 0x00009603 File Offset: 0x00007803
		public unsafe List<EntityID> SelectedTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMoveMultiple.NativeFieldInfoPtr_SelectedTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMoveMultiple.NativeFieldInfoPtr_SelectedTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeFieldInfoPtr_DestinationID;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeFieldInfoPtr_PositionInParent;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeFieldInfoPtr_SelectedTargets;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
