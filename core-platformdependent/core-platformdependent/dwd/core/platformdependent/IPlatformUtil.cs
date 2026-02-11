using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platformdependent
{
	// Token: 0x02000009 RID: 9
	public class IPlatformUtil : Il2CppObjectBase
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00003814 File Offset: 0x00001A14
		// Note: this type is marked as 'beforefieldinit'.
		static IPlatformUtil()
		{
			Il2CppClassPointerStore<IPlatformUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "IPlatformUtil");
			IPlatformUtil.NativeMethodInfoPtr_get_Platforms_Public_Abstract_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformUtil>.NativeClassPtr, 100663309);
			IPlatformUtil.NativeMethodInfoPtr_get_PlatformMap_Public_Abstract_Virtual_New_get_Dictionary_2_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformUtil>.NativeClassPtr, 100663310);
			IPlatformUtil.NativeMethodInfoPtr_get_CurrentPlatform_Public_Abstract_Virtual_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformUtil>.NativeClassPtr, 100663311);
			IPlatformUtil.NativeMethodInfoPtr_set_CurrentPlatform_Public_Abstract_Virtual_New_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformUtil>.NativeClassPtr, 100663312);
			IPlatformUtil.NativeMethodInfoPtr_get_DefaultPlatform_Public_Abstract_Virtual_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformUtil>.NativeClassPtr, 100663313);
			IPlatformUtil.NativeMethodInfoPtr_get_CurrentPlatformAsString_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformUtil>.NativeClassPtr, 100663314);
			IPlatformUtil.NativeMethodInfoPtr_UpdatePlatform_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformUtil>.NativeClassPtr, 100663315);
			IPlatformUtil.NativeMethodInfoPtr_IsTabletOverride_Public_Virtual_New_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformUtil>.NativeClassPtr, 100663316);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000038DC File Offset: 0x00001ADC
		public unsafe virtual Il2CppStringArray Platforms
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformUtil.NativeMethodInfoPtr_get_Platforms_Public_Abstract_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00003928 File Offset: 0x00001B28
		public unsafe virtual Dictionary<uint, string> PlatformMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformUtil.NativeMethodInfoPtr_get_PlatformMap_Public_Abstract_Virtual_New_get_Dictionary_2_UInt32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00003974 File Offset: 0x00001B74
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000039BC File Offset: 0x00001BBC
		public unsafe virtual uint CurrentPlatform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformUtil.NativeMethodInfoPtr_get_CurrentPlatform_Public_Abstract_Virtual_New_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformUtil.NativeMethodInfoPtr_set_CurrentPlatform_Public_Abstract_Virtual_New_set_Void_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00003A08 File Offset: 0x00001C08
		public unsafe virtual uint DefaultPlatform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformUtil.NativeMethodInfoPtr_get_DefaultPlatform_Public_Abstract_Virtual_New_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003A50 File Offset: 0x00001C50
		public unsafe virtual string CurrentPlatformAsString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformUtil.NativeMethodInfoPtr_get_CurrentPlatformAsString_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003A94 File Offset: 0x00001C94
		[CallerCount(0)]
		public unsafe virtual void UpdatePlatform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformUtil.NativeMethodInfoPtr_UpdatePlatform_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003AD0 File Offset: 0x00001CD0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Nullable<bool> IsTabletOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformUtil.NativeMethodInfoPtr_IsTabletOverride_Public_Virtual_New_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<bool>(intPtr);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000021E1 File Offset: 0x000003E1
		public IPlatformUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_get_Platforms_Public_Abstract_Virtual_New_get_Il2CppStringArray_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_get_PlatformMap_Public_Abstract_Virtual_New_get_Dictionary_2_UInt32_String_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlatform_Public_Abstract_Virtual_New_get_UInt32_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlatform_Public_Abstract_Virtual_New_set_Void_UInt32_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPlatform_Public_Abstract_Virtual_New_get_UInt32_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlatformAsString_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlatform_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_IsTabletOverride_Public_Virtual_New_Nullable_1_Boolean_0;
	}
}
