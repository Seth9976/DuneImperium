using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x0200001B RID: 27
	public sealed class StaticFilterOptionsMonitor : Object
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00005200 File Offset: 0x00003400
		// Note: this type is marked as 'beforefieldinit'.
		static StaticFilterOptionsMonitor()
		{
			Il2CppClassPointerStore<StaticFilterOptionsMonitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "StaticFilterOptionsMonitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticFilterOptionsMonitor>.NativeClassPtr);
			StaticFilterOptionsMonitor.NativeFieldInfoPtr__CurrentValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticFilterOptionsMonitor>.NativeClassPtr, "<CurrentValue>k__BackingField");
			StaticFilterOptionsMonitor.NativeMethodInfoPtr__ctor_Public_Void_LoggerFilterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticFilterOptionsMonitor>.NativeClassPtr, 100663376);
			StaticFilterOptionsMonitor.NativeMethodInfoPtr_OnChange_Public_Virtual_Final_New_IDisposable_Action_2_LoggerFilterOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticFilterOptionsMonitor>.NativeClassPtr, 100663377);
			StaticFilterOptionsMonitor.NativeMethodInfoPtr_get_CurrentValue_Public_Virtual_Final_New_get_LoggerFilterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticFilterOptionsMonitor>.NativeClassPtr, 100663378);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005280 File Offset: 0x00003480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264412, XrefRangeEnd = 1264421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticFilterOptionsMonitor(LoggerFilterOptions currentValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticFilterOptionsMonitor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticFilterOptionsMonitor.NativeMethodInfoPtr__ctor_Public_Void_LoggerFilterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000052CC File Offset: 0x000034CC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDisposable OnChange(Action<LoggerFilterOptions, string> listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticFilterOptionsMonitor.NativeMethodInfoPtr_OnChange_Public_Virtual_Final_New_IDisposable_Action_2_LoggerFilterOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000531C File Offset: 0x0000351C
		public unsafe LoggerFilterOptions CurrentValue
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticFilterOptionsMonitor.NativeMethodInfoPtr_get_CurrentValue_Public_Virtual_Final_New_get_LoggerFilterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoggerFilterOptions>(intPtr3) : null;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002759 File Offset: 0x00000959
		public StaticFilterOptionsMonitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000535C File Offset: 0x0000355C
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002762 File Offset: 0x00000962
		public unsafe LoggerFilterOptions _CurrentValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticFilterOptionsMonitor.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoggerFilterOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticFilterOptionsMonitor.NativeFieldInfoPtr__CurrentValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr__CurrentValue_k__BackingField;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoggerFilterOptions_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_OnChange_Public_Virtual_Final_New_IDisposable_Action_2_LoggerFilterOptions_String_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_Virtual_Final_New_get_LoggerFilterOptions_0;
	}
}
