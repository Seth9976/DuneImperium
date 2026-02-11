using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platform.websocket
{
	// Token: 0x0200001B RID: 27
	public class WebSocketMessage : TypedMessage
	{
		// Token: 0x06000146 RID: 326 RVA: 0x00009E94 File Offset: 0x00008094
		// Note: this type is marked as 'beforefieldinit'.
		static WebSocketMessage()
		{
			Il2CppClassPointerStore<WebSocketMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket", "WebSocketMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocketMessage>.NativeClassPtr);
			WebSocketMessage.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketMessage>.NativeClassPtr, "Type");
			WebSocketMessage.NativeFieldInfoPtr_Body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketMessage>.NativeClassPtr, "Body");
			WebSocketMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketMessage>.NativeClassPtr, 100663560);
			WebSocketMessage.NativeMethodInfoPtr__ctor_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketMessage>.NativeClassPtr, 100663561);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00009F14 File Offset: 0x00008114
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocketMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00009F50 File Offset: 0x00008150
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 1167232, RefRangeEnd = 1167269, XrefRangeStart = 1167232, XrefRangeEnd = 1167269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocketMessage(string type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketMessage.NativeMethodInfoPtr__ctor_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000273E File Offset: 0x0000093E
		public WebSocketMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00009F9C File Offset: 0x0000819C
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002747 File Offset: 0x00000947
		public unsafe string Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketMessage.NativeFieldInfoPtr_Type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketMessage.NativeFieldInfoPtr_Type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00009FC4 File Offset: 0x000081C4
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002766 File Offset: 0x00000966
		public unsafe Dictionary<string, Object> Body
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketMessage.NativeFieldInfoPtr_Body);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketMessage.NativeFieldInfoPtr_Body), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_Body;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_0;
	}
}
