using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000219 RID: 537
	public class IPGlobalProperties : Object
	{
		// Token: 0x06002461 RID: 9313 RVA: 0x000A8724 File Offset: 0x000A6924
		// Note: this type is marked as 'beforefieldinit'.
		static IPGlobalProperties()
		{
			Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "IPGlobalProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr);
			IPGlobalProperties.NativeMethodInfoPtr_GetIPGlobalProperties_Public_Static_IPGlobalProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100668729);
			IPGlobalProperties.NativeMethodInfoPtr_InternalGetIPGlobalProperties_Internal_Static_IPGlobalProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100668730);
			IPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100668731);
			IPGlobalProperties.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100668732);
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x000A87A4 File Offset: 0x000A69A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 486992, RefRangeEnd = 486994, XrefRangeStart = 486988, XrefRangeEnd = 486992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPGlobalProperties GetIPGlobalProperties()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPGlobalProperties.NativeMethodInfoPtr_GetIPGlobalProperties_Public_Static_IPGlobalProperties_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPGlobalProperties>(intPtr3) : null;
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x000A87D8 File Offset: 0x000A69D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 486992, RefRangeEnd = 486994, XrefRangeStart = 486992, XrefRangeEnd = 486994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPGlobalProperties InternalGetIPGlobalProperties()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPGlobalProperties.NativeMethodInfoPtr_InternalGetIPGlobalProperties_Internal_Static_IPGlobalProperties_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPGlobalProperties>(intPtr3) : null;
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x000A880C File Offset: 0x000A6A0C
		public unsafe virtual string DomainName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x000A8850 File Offset: 0x000A6A50
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPGlobalProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPGlobalProperties.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0000FB93 File Offset: 0x0000DD93
		public IPGlobalProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeMethodInfoPtr_GetIPGlobalProperties_Public_Static_IPGlobalProperties_0;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetIPGlobalProperties_Internal_Static_IPGlobalProperties_0;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
