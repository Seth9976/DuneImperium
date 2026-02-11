using System;
using Canis;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000263 RID: 611
	public class SerializedMatchAction : SerializedMatchAction<WormMatch, WormPlayer>
	{
		// Token: 0x06001A1C RID: 6684 RVA: 0x000BE778 File Offset: 0x000BC978
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedMatchAction()
		{
			Il2CppClassPointerStore<SerializedMatchAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedMatchAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedMatchAction>.NativeClassPtr);
			SerializedMatchAction.NativeMethodInfoPtr_GenMatchAction_Protected_Virtual_MatchAction_2_WormMatch_WormPlayer_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMatchAction>.NativeClassPtr, 100668202);
			SerializedMatchAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMatchAction>.NativeClassPtr, 100668203);
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x000BE7D0 File Offset: 0x000BC9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140050, XrefRangeEnd = 140056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MatchAction<WormMatch, WormPlayer> GenMatchAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedMatchAction.NativeMethodInfoPtr_GenMatchAction_Protected_Virtual_MatchAction_2_WormMatch_WormPlayer_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchAction<WormMatch, WormPlayer>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000BE82C File Offset: 0x000BCA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140056, XrefRangeEnd = 140059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedMatchAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedMatchAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMatchAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0000B378 File Offset: 0x00009578
		public SerializedMatchAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeMethodInfoPtr_GenMatchAction_Protected_Virtual_MatchAction_2_WormMatch_WormPlayer_Match_0;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
