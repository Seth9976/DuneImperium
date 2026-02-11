using System;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001E6 RID: 486
	public class ConfirmMatchReconnectPrompt : ConfirmOrDenyPrompt
	{
		// Token: 0x060016D5 RID: 5845 RVA: 0x00067808 File Offset: 0x00065A08
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmMatchReconnectPrompt()
		{
			Il2CppClassPointerStore<ConfirmMatchReconnectPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ConfirmMatchReconnectPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmMatchReconnectPrompt>.NativeClassPtr);
			ConfirmMatchReconnectPrompt.NativeFieldInfoPtr__GameID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmMatchReconnectPrompt>.NativeClassPtr, "<GameID>k__BackingField");
			ConfirmMatchReconnectPrompt.NativeMethodInfoPtr_get_GameID_Public_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmMatchReconnectPrompt>.NativeClassPtr, 100666641);
			ConfirmMatchReconnectPrompt.NativeMethodInfoPtr__ctor_Public_Void_GameID_DataComposition_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmMatchReconnectPrompt>.NativeClassPtr, 100666642);
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x00067874 File Offset: 0x00065A74
		public unsafe GameID GameID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmMatchReconnectPrompt.NativeMethodInfoPtr_get_GameID_Public_get_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x000678B4 File Offset: 0x00065AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524960, RefRangeEnd = 524961, XrefRangeStart = 524955, XrefRangeEnd = 524960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmMatchReconnectPrompt(GameID gameID, DataComposition promptData, string confirmKey, string cancelKey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmMatchReconnectPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(confirmKey);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cancelKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmMatchReconnectPrompt.NativeMethodInfoPtr__ctor_Public_Void_GameID_DataComposition_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0000CD62 File Offset: 0x0000AF62
		public ConfirmMatchReconnectPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x00067938 File Offset: 0x00065B38
		// (set) Token: 0x060016DA RID: 5850 RVA: 0x0000CD6B File Offset: 0x0000AF6B
		public unsafe GameID _GameID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmMatchReconnectPrompt.NativeFieldInfoPtr__GameID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmMatchReconnectPrompt.NativeFieldInfoPtr__GameID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeFieldInfoPtr__GameID_k__BackingField;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_get_GameID_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_DataComposition_String_String_0;
	}
}
