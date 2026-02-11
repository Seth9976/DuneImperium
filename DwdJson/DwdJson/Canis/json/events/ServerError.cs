using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.json.events
{
	// Token: 0x0200001F RID: 31
	public class ServerError : NetworkMessageEvent
	{
		// Token: 0x060000FE RID: 254 RVA: 0x000062D8 File Offset: 0x000044D8
		// Note: this type is marked as 'beforefieldinit'.
		static ServerError()
		{
			Il2CppClassPointerStore<ServerError>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json.events", "ServerError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerError>.NativeClassPtr);
			ServerError.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerError>.NativeClassPtr, "Message");
			ServerError.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerError>.NativeClassPtr, 100663419);
			ServerError.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerError>.NativeClassPtr, 100663420);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00006344 File Offset: 0x00004544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249634, XrefRangeEnd = 1249637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerError.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00006388 File Offset: 0x00004588
		[CallerCount(293)]
		[CachedScanResults(RefRangeStart = 881929, RefRangeEnd = 882222, XrefRangeStart = 881929, XrefRangeEnd = 882222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerError()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerError>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerError.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002617 File Offset: 0x00000817
		public ServerError(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000063C4 File Offset: 0x000045C4
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002620 File Offset: 0x00000820
		public unsafe string Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerError.NativeFieldInfoPtr_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerError.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
