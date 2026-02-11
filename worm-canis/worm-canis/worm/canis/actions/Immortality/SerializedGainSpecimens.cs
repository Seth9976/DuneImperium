using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.Immortality
{
	// Token: 0x020002E1 RID: 737
	public class SerializedGainSpecimens : SerializedAction
	{
		// Token: 0x06001E56 RID: 7766 RVA: 0x000CF590 File Offset: 0x000CD790
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGainSpecimens()
		{
			Il2CppClassPointerStore<SerializedGainSpecimens>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.Immortality", "SerializedGainSpecimens");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGainSpecimens>.NativeClassPtr);
			SerializedGainSpecimens.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainSpecimens>.NativeClassPtr, "Amount");
			SerializedGainSpecimens.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainSpecimens>.NativeClassPtr, 100670420);
			SerializedGainSpecimens.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainSpecimens>.NativeClassPtr, 100670421);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x000CF5FC File Offset: 0x000CD7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170957, XrefRangeEnd = 170961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGainSpecimens.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x000CF658 File Offset: 0x000CD858
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGainSpecimens()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGainSpecimens>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGainSpecimens.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x0000CB24 File Offset: 0x0000AD24
		public SerializedGainSpecimens(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x000CF694 File Offset: 0x000CD894
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x0000CB2D File Offset: 0x0000AD2D
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainSpecimens.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainSpecimens.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
