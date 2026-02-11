using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000289 RID: 649
	public class SerializedGainShippingTrackTroops : SerializedAction
	{
		// Token: 0x06001B2B RID: 6955 RVA: 0x000C27F8 File Offset: 0x000C09F8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGainShippingTrackTroops()
		{
			Il2CppClassPointerStore<SerializedGainShippingTrackTroops>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedGainShippingTrackTroops");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGainShippingTrackTroops>.NativeClassPtr);
			SerializedGainShippingTrackTroops.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainShippingTrackTroops>.NativeClassPtr, 100668646);
			SerializedGainShippingTrackTroops.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainShippingTrackTroops>.NativeClassPtr, 100668647);
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x000C2850 File Offset: 0x000C0A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145728, XrefRangeEnd = 145735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGainShippingTrackTroops.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x000C28AC File Offset: 0x000C0AAC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGainShippingTrackTroops()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGainShippingTrackTroops>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGainShippingTrackTroops.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0000BA03 File Offset: 0x00009C03
		public SerializedGainShippingTrackTroops(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
