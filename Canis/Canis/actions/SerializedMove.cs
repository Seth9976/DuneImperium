using System;
using Canis.actions.serialized;
using Canis.analytics;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions
{
	// Token: 0x020001BD RID: 445
	[Serializable]
	public class SerializedMove : SerializedAction
	{
		// Token: 0x060012E5 RID: 4837 RVA: 0x00065E6C File Offset: 0x0006406C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedMove()
		{
			Il2CppClassPointerStore<SerializedMove>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedMove");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedMove>.NativeClassPtr);
			SerializedMove.NativeFieldInfoPtr_DestinationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMove>.NativeClassPtr, "DestinationID");
			SerializedMove.NativeFieldInfoPtr_PositionInParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMove>.NativeClassPtr, "PositionInParent");
			SerializedMove.NativeFieldInfoPtr_DisplayPositionInParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMove>.NativeClassPtr, "DisplayPositionInParent");
			SerializedMove.NativeFieldInfoPtr_SelectedTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMove>.NativeClassPtr, "SelectedTarget");
			SerializedMove.NativeFieldInfoPtr_AnalyticsBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMove>.NativeClassPtr, "AnalyticsBuilder");
			SerializedMove.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMove>.NativeClassPtr, 100667355);
			SerializedMove.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMove>.NativeClassPtr, 100667356);
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00065F28 File Offset: 0x00064128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586134, XrefRangeEnd = 586149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedMove.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00065F84 File Offset: 0x00064184
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedMove()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedMove>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMove.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00009445 File Offset: 0x00007645
		public SerializedMove(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00065FC0 File Offset: 0x000641C0
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x0000944E File Offset: 0x0000764E
		public unsafe EntityID DestinationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMove.NativeFieldInfoPtr_DestinationID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMove.NativeFieldInfoPtr_DestinationID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x00065FF0 File Offset: 0x000641F0
		// (set) Token: 0x060012EC RID: 4844 RVA: 0x0000946D File Offset: 0x0000766D
		public Nullable<int> PositionInParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMove.NativeFieldInfoPtr_PositionInParent);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMove.NativeFieldInfoPtr_PositionInParent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00066020 File Offset: 0x00064220
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x0000949B File Offset: 0x0000769B
		public Nullable<int> DisplayPositionInParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMove.NativeFieldInfoPtr_DisplayPositionInParent);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMove.NativeFieldInfoPtr_DisplayPositionInParent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00066050 File Offset: 0x00064250
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x000094C9 File Offset: 0x000076C9
		public unsafe EntityID SelectedTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMove.NativeFieldInfoPtr_SelectedTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMove.NativeFieldInfoPtr_SelectedTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00066080 File Offset: 0x00064280
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x000094E8 File Offset: 0x000076E8
		public unsafe AnalyticsMessageBuilder AnalyticsBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMove.NativeFieldInfoPtr_AnalyticsBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnalyticsMessageBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMove.NativeFieldInfoPtr_AnalyticsBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeFieldInfoPtr_DestinationID;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeFieldInfoPtr_PositionInParent;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeFieldInfoPtr_DisplayPositionInParent;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeFieldInfoPtr_SelectedTarget;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeFieldInfoPtr_AnalyticsBuilder;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
