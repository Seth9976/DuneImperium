using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net
{
	// Token: 0x020001E6 RID: 486
	public class AutoWebProxyScriptEngine : Object
	{
		// Token: 0x06001E72 RID: 7794 RVA: 0x00092630 File Offset: 0x00090830
		// Note: this type is marked as 'beforefieldinit'.
		static AutoWebProxyScriptEngine()
		{
			Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "AutoWebProxyScriptEngine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr);
			AutoWebProxyScriptEngine.NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr, 100667932);
			AutoWebProxyScriptEngine.NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr, 100667933);
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x00092688 File Offset: 0x00090888
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 478486, RefRangeEnd = 478489, XrefRangeStart = 478485, XrefRangeEnd = 478486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetProxies(Uri destination, out IList<string> proxyList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AutoWebProxyScriptEngine.NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			proxyList = ((intPtr4 == 0) ? null : new IList<string>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x000926F8 File Offset: 0x000908F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 478486, RefRangeEnd = 478489, XrefRangeStart = 478486, XrefRangeEnd = 478489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetProxies(Uri destination, out IList<string> proxyList, ref int syncStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &syncStatus;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AutoWebProxyScriptEngine.NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			proxyList = ((intPtr4 == 0) ? null : new IList<string>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0000CF1B File Offset: 0x0000B11B
		public AutoWebProxyScriptEngine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_0;

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_byref_Int32_0;
	}
}
