using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x02000043 RID: 67
	public class ServerError : TypedMessage
	{
		// Token: 0x06000258 RID: 600 RVA: 0x0000C940 File Offset: 0x0000AB40
		// Note: this type is marked as 'beforefieldinit'.
		static ServerError()
		{
			Il2CppClassPointerStore<ServerError>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "ServerError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerError>.NativeClassPtr);
			ServerError.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerError>.NativeClassPtr, "Message");
			ServerError.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerError>.NativeClassPtr, 100663639);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000C998 File Offset: 0x0000AB98
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerError()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerError>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerError.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00003354 File Offset: 0x00001554
		public ServerError(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		// (set) Token: 0x0600025C RID: 604 RVA: 0x0000335D File Offset: 0x0000155D
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

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
