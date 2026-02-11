using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket
{
	// Token: 0x02000015 RID: 21
	public class OutgoingWebSocketMessage : WebSocketMessage
	{
		// Token: 0x0600011F RID: 287 RVA: 0x000096B0 File Offset: 0x000078B0
		// Note: this type is marked as 'beforefieldinit'.
		static OutgoingWebSocketMessage()
		{
			Il2CppClassPointerStore<OutgoingWebSocketMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket", "OutgoingWebSocketMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutgoingWebSocketMessage>.NativeClassPtr);
			OutgoingWebSocketMessage.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingWebSocketMessage>.NativeClassPtr, 100663530);
			OutgoingWebSocketMessage.NativeMethodInfoPtr_get_RequiresAuthentication_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingWebSocketMessage>.NativeClassPtr, 100663531);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00009708 File Offset: 0x00007908
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 1167232, RefRangeEnd = 1167269, XrefRangeStart = 1167223, XrefRangeEnd = 1167232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutgoingWebSocketMessage(string type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutgoingWebSocketMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutgoingWebSocketMessage.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00009754 File Offset: 0x00007954
		public unsafe virtual bool RequiresAuthentication
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OutgoingWebSocketMessage.NativeMethodInfoPtr_get_RequiresAuthentication_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002604 File Offset: 0x00000804
		public OutgoingWebSocketMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresAuthentication_Public_Virtual_New_get_Boolean_0;
	}
}
