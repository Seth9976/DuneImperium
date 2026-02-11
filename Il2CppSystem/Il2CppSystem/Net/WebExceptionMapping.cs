using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001C4 RID: 452
	public static class WebExceptionMapping : Object
	{
		// Token: 0x06001B98 RID: 7064 RVA: 0x000880FC File Offset: 0x000862FC
		// Note: this type is marked as 'beforefieldinit'.
		static WebExceptionMapping()
		{
			Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebExceptionMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr);
			WebExceptionMapping.NativeFieldInfoPtr_s_Mapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr, "s_Mapping");
			WebExceptionMapping.NativeMethodInfoPtr_GetWebStatusString_Internal_Static_String_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr, 100667549);
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x00088154 File Offset: 0x00086354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 474841, RefRangeEnd = 474843, XrefRangeStart = 474823, XrefRangeEnd = 474841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWebStatusString(WebExceptionStatus status)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebExceptionMapping.NativeMethodInfoPtr_GetWebStatusString_Internal_Static_String_WebExceptionStatus_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0000BD47 File Offset: 0x00009F47
		public WebExceptionMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x0008818C File Offset: 0x0008638C
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x0000BD50 File Offset: 0x00009F50
		public unsafe static Il2CppStringArray s_Mapping
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebExceptionMapping.NativeFieldInfoPtr_s_Mapping, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebExceptionMapping.NativeFieldInfoPtr_s_Mapping, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001602 RID: 5634
		private static readonly IntPtr NativeFieldInfoPtr_s_Mapping;

		// Token: 0x04001603 RID: 5635
		private static readonly IntPtr NativeMethodInfoPtr_GetWebStatusString_Internal_Static_String_WebExceptionStatus_0;
	}
}
