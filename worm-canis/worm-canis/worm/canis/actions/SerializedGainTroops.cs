using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000251 RID: 593
	public class SerializedGainTroops : SerializedAction
	{
		// Token: 0x0600199C RID: 6556 RVA: 0x000BC6B4 File Offset: 0x000BA8B4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGainTroops()
		{
			Il2CppClassPointerStore<SerializedGainTroops>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedGainTroops");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGainTroops>.NativeClassPtr);
			SerializedGainTroops.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainTroops>.NativeClassPtr, "Amount");
			SerializedGainTroops.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainTroops>.NativeClassPtr, 100667974);
			SerializedGainTroops.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainTroops>.NativeClassPtr, 100667975);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x000BC720 File Offset: 0x000BA920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137586, XrefRangeEnd = 137592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGainTroops.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x000BC77C File Offset: 0x000BA97C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGainTroops()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGainTroops>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGainTroops.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0000B0CA File Offset: 0x000092CA
		public SerializedGainTroops(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x000BC7B8 File Offset: 0x000BA9B8
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x0000B0D3 File Offset: 0x000092D3
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainTroops.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainTroops.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
