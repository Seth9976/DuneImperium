using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000287 RID: 647
	public class SerializedFreighterAction : SerializedAction
	{
		// Token: 0x06001B19 RID: 6937 RVA: 0x000C2438 File Offset: 0x000C0638
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedFreighterAction()
		{
			Il2CppClassPointerStore<SerializedFreighterAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedFreighterAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedFreighterAction>.NativeClassPtr);
			SerializedFreighterAction.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedFreighterAction>.NativeClassPtr, "PlayerID");
			SerializedFreighterAction.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedFreighterAction>.NativeClassPtr, "Amount");
			SerializedFreighterAction.NativeFieldInfoPtr_LogMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedFreighterAction>.NativeClassPtr, "LogMode");
			SerializedFreighterAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedFreighterAction>.NativeClassPtr, 100668624);
			SerializedFreighterAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedFreighterAction>.NativeClassPtr, 100668625);
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x000C24CC File Offset: 0x000C06CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145557, XrefRangeEnd = 145565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedFreighterAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x000C2528 File Offset: 0x000C0728
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedFreighterAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedFreighterAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedFreighterAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0000B97D File Offset: 0x00009B7D
		public SerializedFreighterAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x000C2564 File Offset: 0x000C0764
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x0000B986 File Offset: 0x00009B86
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedFreighterAction.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedFreighterAction.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x000C2594 File Offset: 0x000C0794
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x0000B9A5 File Offset: 0x00009BA5
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedFreighterAction.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedFreighterAction.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x000C25BC File Offset: 0x000C07BC
		// (set) Token: 0x06001B22 RID: 6946 RVA: 0x0000B9C0 File Offset: 0x00009BC0
		public unsafe ActionLogModes LogMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedFreighterAction.NativeFieldInfoPtr_LogMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedFreighterAction.NativeFieldInfoPtr_LogMode)) = value;
			}
		}

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeFieldInfoPtr_LogMode;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
