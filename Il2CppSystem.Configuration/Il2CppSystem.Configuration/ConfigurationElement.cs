using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Configuration
{
	// Token: 0x02000002 RID: 2
	[DefaultMember("Item")]
	public class ConfigurationElement : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002170 File Offset: 0x00000370
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationElement()
		{
			Il2CppClassPointerStore<ConfigurationElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Configuration.dll", "System.Configuration", "ConfigurationElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationElement>.NativeClassPtr);
			ConfigurationElement.NativeMethodInfoPtr_get_Properties_FamOrAssem_Virtual_New_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationElement>.NativeClassPtr, 100663297);
			ConfigurationElement.NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationElement>.NativeClassPtr, 100663298);
			ConfigurationElement.NativeMethodInfoPtr_Reset_FamOrAssem_Virtual_New_Void_ConfigurationElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationElement>.NativeClassPtr, 100663299);
			ConfigurationElement.NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationElement>.NativeClassPtr, 100663300);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000021F0 File Offset: 0x000003F0
		public unsafe virtual ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275205, XrefRangeEnd = 1275208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationElement.NativeMethodInfoPtr_get_Properties_FamOrAssem_Virtual_New_get_ConfigurationPropertyCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000223C File Offset: 0x0000043C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275208, XrefRangeEnd = 1275211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsModified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationElement.NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002284 File Offset: 0x00000484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275211, XrefRangeEnd = 1275214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset(ConfigurationElement parentElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentElement);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationElement.NativeMethodInfoPtr_Reset_FamOrAssem_Virtual_New_Void_ConfigurationElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000022D4 File Offset: 0x000004D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275214, XrefRangeEnd = 1275217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetModified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationElement.NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		public ConfigurationElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_FamOrAssem_Virtual_New_get_ConfigurationPropertyCollection_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_New_Boolean_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_Reset_FamOrAssem_Virtual_New_Void_ConfigurationElement_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_New_Void_0;
	}
}
