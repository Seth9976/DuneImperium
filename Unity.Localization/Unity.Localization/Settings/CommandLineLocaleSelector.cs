using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x0200009D RID: 157
	[Serializable]
	public class CommandLineLocaleSelector : Object
	{
		// Token: 0x060007DB RID: 2011 RVA: 0x00027964 File Offset: 0x00025B64
		// Note: this type is marked as 'beforefieldinit'.
		static CommandLineLocaleSelector()
		{
			Il2CppClassPointerStore<CommandLineLocaleSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "CommandLineLocaleSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandLineLocaleSelector>.NativeClassPtr);
			CommandLineLocaleSelector.NativeFieldInfoPtr_m_CommandLineArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandLineLocaleSelector>.NativeClassPtr, "m_CommandLineArgument");
			CommandLineLocaleSelector.NativeMethodInfoPtr_get_CommandLineArgument_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandLineLocaleSelector>.NativeClassPtr, 100664702);
			CommandLineLocaleSelector.NativeMethodInfoPtr_set_CommandLineArgument_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandLineLocaleSelector>.NativeClassPtr, 100664703);
			CommandLineLocaleSelector.NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandLineLocaleSelector>.NativeClassPtr, 100664704);
			CommandLineLocaleSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandLineLocaleSelector>.NativeClassPtr, 100664705);
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x000279F8 File Offset: 0x00025BF8
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x00027A30 File Offset: 0x00025C30
		public unsafe string CommandLineArgument
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandLineLocaleSelector.NativeMethodInfoPtr_get_CommandLineArgument_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandLineLocaleSelector.NativeMethodInfoPtr_set_CommandLineArgument_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00027A74 File Offset: 0x00025C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075867, XrefRangeEnd = 1075903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Locale GetStartupLocale(ILocalesProvider availableLocales)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableLocales);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandLineLocaleSelector.NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00027AC4 File Offset: 0x00025CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075903, XrefRangeEnd = 1075908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandLineLocaleSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandLineLocaleSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandLineLocaleSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00005060 File Offset: 0x00003260
		public CommandLineLocaleSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00027B00 File Offset: 0x00025D00
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00005069 File Offset: 0x00003269
		public unsafe string m_CommandLineArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandLineLocaleSelector.NativeFieldInfoPtr_m_CommandLineArgument);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandLineLocaleSelector.NativeFieldInfoPtr_m_CommandLineArgument), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeFieldInfoPtr_m_CommandLineArgument;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_get_CommandLineArgument_Public_get_String_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr_set_CommandLineArgument_Public_set_Void_String_0;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
