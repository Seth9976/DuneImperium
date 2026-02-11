using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x0200009A RID: 154
	[Serializable]
	public class LocalesProvider : Object
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x00025DC8 File Offset: 0x00023FC8
		// Note: this type is marked as 'beforefieldinit'.
		static LocalesProvider()
		{
			Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "LocalesProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr);
			LocalesProvider.NativeFieldInfoPtr_m_Locales = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr, "m_Locales");
			LocalesProvider.NativeFieldInfoPtr_m_LoadOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr, "m_LoadOperation");
			LocalesProvider.NativeMethodInfoPtr_get_Locales_Public_Virtual_Final_New_get_List_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr, 100664627);
			LocalesProvider.NativeMethodInfoPtr_get_PreloadOperation_Public_Virtual_Final_New_get_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr, 100664628);
			LocalesProvider.NativeMethodInfoPtr_GetLocale_Public_Virtual_Final_New_Locale_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr, 100664629);
			LocalesProvider.NativeMethodInfoPtr_GetLocale_Public_Locale_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr, 100664630);
			LocalesProvider.NativeMethodInfoPtr_GetLocale_Public_Locale_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr, 100664631);
			LocalesProvider.NativeMethodInfoPtr_AddLocale_Public_Virtual_Final_New_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr, 100664632);
			LocalesProvider.NativeMethodInfoPtr_RemoveLocale_Public_Virtual_Final_New_Boolean_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr, 100664633);
			LocalesProvider.NativeMethodInfoPtr_FindFallbackLocale_Public_Locale_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr, 100664634);
			LocalesProvider.NativeMethodInfoPtr_ResetState_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr, 100664635);
			LocalesProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr, 100664636);
			LocalesProvider.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr, 100664637);
			LocalesProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr, 100664638);
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00025F10 File Offset: 0x00024110
		public unsafe virtual List<Locale> Locales
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1075108, RefRangeEnd = 1075110, XrefRangeStart = 1075103, XrefRangeEnd = 1075108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalesProvider.NativeMethodInfoPtr_get_Locales_Public_Virtual_Final_New_get_List_1_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Locale>>(intPtr3) : null;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00025F50 File Offset: 0x00024150
		public unsafe virtual AsyncOperationHandle PreloadOperation
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1075126, RefRangeEnd = 1075128, XrefRangeStart = 1075110, XrefRangeEnd = 1075126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalesProvider.NativeMethodInfoPtr_get_PreloadOperation_Public_Virtual_Final_New_get_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00025F88 File Offset: 0x00024188
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1075146, RefRangeEnd = 1075149, XrefRangeStart = 1075128, XrefRangeEnd = 1075146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Locale GetLocale(LocaleIdentifier id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(id));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalesProvider.NativeMethodInfoPtr_GetLocale_Public_Virtual_Final_New_Locale_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00025FE0 File Offset: 0x000241E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075149, XrefRangeEnd = 1075151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Locale GetLocale(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalesProvider.NativeMethodInfoPtr_GetLocale_Public_Locale_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00026030 File Offset: 0x00024230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075151, XrefRangeEnd = 1075153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Locale GetLocale(SystemLanguage systemLanguage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref systemLanguage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalesProvider.NativeMethodInfoPtr_GetLocale_Public_Locale_SystemLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0002607C File Offset: 0x0002427C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075153, XrefRangeEnd = 1075193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddLocale(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalesProvider.NativeMethodInfoPtr_AddLocale_Public_Virtual_Final_New_Void_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000260C0 File Offset: 0x000242C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075193, XrefRangeEnd = 1075202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool RemoveLocale(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalesProvider.NativeMethodInfoPtr_RemoveLocale_Public_Virtual_Final_New_Boolean_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00026110 File Offset: 0x00024310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075202, XrefRangeEnd = 1075214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Locale FindFallbackLocale(LocaleIdentifier localeIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalesProvider.NativeMethodInfoPtr_FindFallbackLocale_Public_Locale_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00026168 File Offset: 0x00024368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075214, XrefRangeEnd = 1075216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalesProvider.NativeMethodInfoPtr_ResetState_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0002619C File Offset: 0x0002439C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075216, XrefRangeEnd = 1075220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalesProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000261D8 File Offset: 0x000243D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075220, XrefRangeEnd = 1075228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalesProvider.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0002620C File Offset: 0x0002440C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075228, XrefRangeEnd = 1075236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalesProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalesProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalesProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00004DD2 File Offset: 0x00002FD2
		public LocalesProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00026248 File Offset: 0x00024448
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00004DDB File Offset: 0x00002FDB
		public unsafe List<Locale> m_Locales
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalesProvider.NativeFieldInfoPtr_m_Locales);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Locale>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalesProvider.NativeFieldInfoPtr_m_Locales), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00026278 File Offset: 0x00024478
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00004DFA File Offset: 0x00002FFA
		public AsyncOperationHandle m_LoadOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalesProvider.NativeFieldInfoPtr_m_LoadOperation);
				return new AsyncOperationHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalesProvider.NativeFieldInfoPtr_m_LoadOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr_m_Locales;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadOperation;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_get_Locales_Public_Virtual_Final_New_get_List_1_Locale_0;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_get_PreloadOperation_Public_Virtual_Final_New_get_AsyncOperationHandle_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_GetLocale_Public_Virtual_Final_New_Locale_LocaleIdentifier_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_GetLocale_Public_Locale_String_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_GetLocale_Public_Locale_SystemLanguage_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_AddLocale_Public_Virtual_Final_New_Void_Locale_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLocale_Public_Virtual_Final_New_Boolean_Locale_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_FindFallbackLocale_Public_Locale_LocaleIdentifier_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_ResetState_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
