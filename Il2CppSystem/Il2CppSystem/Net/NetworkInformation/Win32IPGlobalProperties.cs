using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x0200021D RID: 541
	public class Win32IPGlobalProperties : IPGlobalProperties
	{
		// Token: 0x0600246A RID: 9322 RVA: 0x000A88C0 File Offset: 0x000A6AC0
		// Note: this type is marked as 'beforefieldinit'.
		static Win32IPGlobalProperties()
		{
			Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32IPGlobalProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr);
			Win32IPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr, 100668734);
			Win32IPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr, 100668735);
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x000A8918 File Offset: 0x000A6B18
		public unsafe override string DomainName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486994, XrefRangeEnd = 486995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Win32IPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x000A895C File Offset: 0x000A6B5C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32IPGlobalProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32IPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x0000FBDE File Offset: 0x0000DDDE
		public Win32IPGlobalProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
