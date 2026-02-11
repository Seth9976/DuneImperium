using System;
using Canis.messages.effect;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.logging.messages
{
	// Token: 0x02000177 RID: 375
	public class AIInfoMessage : EffectMessage
	{
		// Token: 0x06001584 RID: 5508 RVA: 0x00069F90 File Offset: 0x00068190
		// Note: this type is marked as 'beforefieldinit'.
		static AIInfoMessage()
		{
			Il2CppClassPointerStore<AIInfoMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.logging.messages", "AIInfoMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIInfoMessage>.NativeClassPtr);
			AIInfoMessage.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIInfoMessage>.NativeClassPtr, "Message");
			AIInfoMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIInfoMessage>.NativeClassPtr, 100666540);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00069FE8 File Offset: 0x000681E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876347, XrefRangeEnd = 876351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIInfoMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIInfoMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIInfoMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x000097E0 File Offset: 0x000079E0
		public AIInfoMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x0006A024 File Offset: 0x00068224
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x000097E9 File Offset: 0x000079E9
		public unsafe string Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIInfoMessage.NativeFieldInfoPtr_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIInfoMessage.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
