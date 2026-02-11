using System;
using Canis.messages.effect;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMicrosoft.Extensions.Logging;

namespace Canis.logging
{
	// Token: 0x0200009B RID: 155
	public class ServerLoggingMessage : EffectMessage
	{
		// Token: 0x060007A3 RID: 1955 RVA: 0x000386A0 File Offset: 0x000368A0
		// Note: this type is marked as 'beforefieldinit'.
		static ServerLoggingMessage()
		{
			Il2CppClassPointerStore<ServerLoggingMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.logging", "ServerLoggingMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerLoggingMessage>.NativeClassPtr);
			ServerLoggingMessage.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerLoggingMessage>.NativeClassPtr, "Message");
			ServerLoggingMessage.NativeFieldInfoPtr_LogLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerLoggingMessage>.NativeClassPtr, "LogLevel");
			ServerLoggingMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerLoggingMessage>.NativeClassPtr, 100664861);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0003870C File Offset: 0x0003690C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558088, XrefRangeEnd = 558092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerLoggingMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerLoggingMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerLoggingMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00004F43 File Offset: 0x00003143
		public ServerLoggingMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00038748 File Offset: 0x00036948
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00004F4C File Offset: 0x0000314C
		public unsafe string Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerLoggingMessage.NativeFieldInfoPtr_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerLoggingMessage.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x00038770 File Offset: 0x00036970
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x00004F6B File Offset: 0x0000316B
		public unsafe LogLevel LogLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerLoggingMessage.NativeFieldInfoPtr_LogLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerLoggingMessage.NativeFieldInfoPtr_LogLevel)) = value;
			}
		}

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr_LogLevel;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
