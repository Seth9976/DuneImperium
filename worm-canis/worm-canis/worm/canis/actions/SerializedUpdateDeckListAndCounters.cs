using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x020002AC RID: 684
	public class SerializedUpdateDeckListAndCounters : SerializedAction
	{
		// Token: 0x06001C3F RID: 7231 RVA: 0x000C6B00 File Offset: 0x000C4D00
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedUpdateDeckListAndCounters()
		{
			Il2CppClassPointerStore<SerializedUpdateDeckListAndCounters>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedUpdateDeckListAndCounters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedUpdateDeckListAndCounters>.NativeClassPtr);
			SerializedUpdateDeckListAndCounters.NativeFieldInfoPtr_IndexInRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedUpdateDeckListAndCounters>.NativeClassPtr, "IndexInRow");
			SerializedUpdateDeckListAndCounters.NativeFieldInfoPtr_HelenaIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedUpdateDeckListAndCounters>.NativeClassPtr, "HelenaIndex");
			SerializedUpdateDeckListAndCounters.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedUpdateDeckListAndCounters>.NativeClassPtr, 100669096);
			SerializedUpdateDeckListAndCounters.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedUpdateDeckListAndCounters>.NativeClassPtr, 100669097);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x000C6B80 File Offset: 0x000C4D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150655, XrefRangeEnd = 150659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedUpdateDeckListAndCounters.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x000C6BDC File Offset: 0x000C4DDC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedUpdateDeckListAndCounters()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedUpdateDeckListAndCounters>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedUpdateDeckListAndCounters.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		public SerializedUpdateDeckListAndCounters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x000C6C18 File Offset: 0x000C4E18
		// (set) Token: 0x06001C44 RID: 7236 RVA: 0x0000BFA9 File Offset: 0x0000A1A9
		public unsafe int IndexInRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedUpdateDeckListAndCounters.NativeFieldInfoPtr_IndexInRow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedUpdateDeckListAndCounters.NativeFieldInfoPtr_IndexInRow)) = value;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x000C6C40 File Offset: 0x000C4E40
		// (set) Token: 0x06001C46 RID: 7238 RVA: 0x0000BFC4 File Offset: 0x0000A1C4
		public unsafe int HelenaIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedUpdateDeckListAndCounters.NativeFieldInfoPtr_HelenaIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedUpdateDeckListAndCounters.NativeFieldInfoPtr_HelenaIndex)) = value;
			}
		}

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeFieldInfoPtr_IndexInRow;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeFieldInfoPtr_HelenaIndex;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
