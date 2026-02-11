using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200027F RID: 639
	public class SerializedRetreatTroops : SerializedAction
	{
		// Token: 0x06001ADC RID: 6876 RVA: 0x000C142C File Offset: 0x000BF62C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedRetreatTroops()
		{
			Il2CppClassPointerStore<SerializedRetreatTroops>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedRetreatTroops");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedRetreatTroops>.NativeClassPtr);
			SerializedRetreatTroops.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRetreatTroops>.NativeClassPtr, 100668530);
			SerializedRetreatTroops.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRetreatTroops>.NativeClassPtr, 100668531);
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x000C1484 File Offset: 0x000BF684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144521, XrefRangeEnd = 144527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedRetreatTroops.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x000C14E0 File Offset: 0x000BF6E0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedRetreatTroops()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedRetreatTroops>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedRetreatTroops.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0000B88F File Offset: 0x00009A8F
		public SerializedRetreatTroops(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
