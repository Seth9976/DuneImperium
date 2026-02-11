using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages.effect
{
	// Token: 0x02000048 RID: 72
	public class TimedOutSelectionEffectMessage : EffectMessage
	{
		// Token: 0x06000267 RID: 615 RVA: 0x0000C074 File Offset: 0x0000A274
		// Note: this type is marked as 'beforefieldinit'.
		static TimedOutSelectionEffectMessage()
		{
			Il2CppClassPointerStore<TimedOutSelectionEffectMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.effect", "TimedOutSelectionEffectMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedOutSelectionEffectMessage>.NativeClassPtr);
			TimedOutSelectionEffectMessage.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedOutSelectionEffectMessage>.NativeClassPtr, "AccountID");
			TimedOutSelectionEffectMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedOutSelectionEffectMessage>.NativeClassPtr, 100663416);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000C0CC File Offset: 0x0000A2CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimedOutSelectionEffectMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimedOutSelectionEffectMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedOutSelectionEffectMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000039A1 File Offset: 0x00001BA1
		public TimedOutSelectionEffectMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000C108 File Offset: 0x0000A308
		// (set) Token: 0x0600026B RID: 619 RVA: 0x000039AA File Offset: 0x00001BAA
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedOutSelectionEffectMessage.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedOutSelectionEffectMessage.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
