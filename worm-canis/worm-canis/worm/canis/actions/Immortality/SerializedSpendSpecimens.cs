using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.Immortality
{
	// Token: 0x020002EB RID: 747
	public class SerializedSpendSpecimens : SerializedAction
	{
		// Token: 0x06001EC5 RID: 7877 RVA: 0x000D0E18 File Offset: 0x000CF018
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSpendSpecimens()
		{
			Il2CppClassPointerStore<SerializedSpendSpecimens>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.Immortality", "SerializedSpendSpecimens");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSpendSpecimens>.NativeClassPtr);
			SerializedSpendSpecimens.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSpendSpecimens>.NativeClassPtr, "Amount");
			SerializedSpendSpecimens.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSpendSpecimens>.NativeClassPtr, 100670543);
			SerializedSpendSpecimens.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSpendSpecimens>.NativeClassPtr, 100670544);
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x000D0E84 File Offset: 0x000CF084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172025, XrefRangeEnd = 172029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedSpendSpecimens.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x000D0EE0 File Offset: 0x000CF0E0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSpendSpecimens()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSpendSpecimens>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSpendSpecimens.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x0000CE7C File Offset: 0x0000B07C
		public SerializedSpendSpecimens(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x000D0F1C File Offset: 0x000CF11C
		// (set) Token: 0x06001ECA RID: 7882 RVA: 0x0000CE85 File Offset: 0x0000B085
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSpendSpecimens.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSpendSpecimens.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
