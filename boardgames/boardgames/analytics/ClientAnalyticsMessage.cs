using System;
using analytics;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.analytics
{
	// Token: 0x0200017C RID: 380
	public class ClientAnalyticsMessage : BaseAnalyticsMessage
	{
		// Token: 0x060012EF RID: 4847 RVA: 0x0004B684 File Offset: 0x00049884
		// Note: this type is marked as 'beforefieldinit'.
		static ClientAnalyticsMessage()
		{
			Il2CppClassPointerStore<ClientAnalyticsMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.analytics", "ClientAnalyticsMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientAnalyticsMessage>.NativeClassPtr);
			ClientAnalyticsMessage.NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAnalyticsMessage>.NativeClassPtr, 100666083);
			ClientAnalyticsMessage.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAnalyticsMessage>.NativeClassPtr, 100666084);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0004B6DC File Offset: 0x000498DC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1001482, RefRangeEnd = 1001493, XrefRangeStart = 1001481, XrefRangeEnd = 1001482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientAnalyticsMessage(string eventName, Dictionary<string, Object> dict)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientAnalyticsMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dict);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientAnalyticsMessage.NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0004B73C File Offset: 0x0004993C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1001504, RefRangeEnd = 1001508, XrefRangeStart = 1001493, XrefRangeEnd = 1001504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string body(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientAnalyticsMessage.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0000AD33 File Offset: 0x00008F33
		public ClientAnalyticsMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_Object_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0;
	}
}
