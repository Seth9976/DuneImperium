using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x020002A0 RID: 672
	public class SerializedTrashCard : SerializedAction
	{
		// Token: 0x06001BEE RID: 7150 RVA: 0x000C56FC File Offset: 0x000C38FC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedTrashCard()
		{
			Il2CppClassPointerStore<SerializedTrashCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedTrashCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedTrashCard>.NativeClassPtr);
			SerializedTrashCard.NativeFieldInfoPtr_LogMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTrashCard>.NativeClassPtr, "LogMode");
			SerializedTrashCard.NativeFieldInfoPtr_ShowSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTrashCard>.NativeClassPtr, "ShowSequence");
			SerializedTrashCard.NativeFieldInfoPtr_ReplaceImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTrashCard>.NativeClassPtr, "ReplaceImperiumRow");
			SerializedTrashCard.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTrashCard>.NativeClassPtr, 100668950);
			SerializedTrashCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTrashCard>.NativeClassPtr, 100668951);
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x000C5790 File Offset: 0x000C3990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148985, XrefRangeEnd = 148989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedTrashCard.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x000C57EC File Offset: 0x000C39EC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedTrashCard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedTrashCard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedTrashCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x0000BE41 File Offset: 0x0000A041
		public SerializedTrashCard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x000C5828 File Offset: 0x000C3A28
		// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x0000BE4A File Offset: 0x0000A04A
		public unsafe ActionLogModes LogMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTrashCard.NativeFieldInfoPtr_LogMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTrashCard.NativeFieldInfoPtr_LogMode)) = value;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x000C5850 File Offset: 0x000C3A50
		// (set) Token: 0x06001BF5 RID: 7157 RVA: 0x0000BE65 File Offset: 0x0000A065
		public unsafe bool ShowSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTrashCard.NativeFieldInfoPtr_ShowSequence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTrashCard.NativeFieldInfoPtr_ShowSequence)) = value;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x000C5878 File Offset: 0x000C3A78
		// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x0000BE80 File Offset: 0x0000A080
		public unsafe bool ReplaceImperiumRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTrashCard.NativeFieldInfoPtr_ReplaceImperiumRow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTrashCard.NativeFieldInfoPtr_ReplaceImperiumRow)) = value;
			}
		}

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeFieldInfoPtr_LogMode;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeFieldInfoPtr_ShowSequence;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeFieldInfoPtr_ReplaceImperiumRow;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
