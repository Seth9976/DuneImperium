using System;
using Canis.messages.effect;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.logging.messages
{
	// Token: 0x020000A4 RID: 164
	public class AIDetailLoggingMessage : EffectMessage
	{
		// Token: 0x060007E0 RID: 2016 RVA: 0x00029DBC File Offset: 0x00027FBC
		// Note: this type is marked as 'beforefieldinit'.
		static AIDetailLoggingMessage()
		{
			Il2CppClassPointerStore<AIDetailLoggingMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dwd.core.logging.messages", "AIDetailLoggingMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIDetailLoggingMessage>.NativeClassPtr);
			AIDetailLoggingMessage.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIDetailLoggingMessage>.NativeClassPtr, "Message");
			AIDetailLoggingMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIDetailLoggingMessage>.NativeClassPtr, 100664538);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00029E14 File Offset: 0x00028014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991121, XrefRangeEnd = 991125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIDetailLoggingMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIDetailLoggingMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIDetailLoggingMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00005932 File Offset: 0x00003B32
		public AIDetailLoggingMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00029E50 File Offset: 0x00028050
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x0000593B File Offset: 0x00003B3B
		public unsafe string Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIDetailLoggingMessage.NativeFieldInfoPtr_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIDetailLoggingMessage.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
