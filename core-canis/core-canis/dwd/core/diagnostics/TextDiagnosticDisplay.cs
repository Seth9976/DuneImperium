using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.diagnostics
{
	// Token: 0x020001BF RID: 447
	public class TextDiagnosticDisplay : DiagnosticsDisplay
	{
		// Token: 0x060018FA RID: 6394 RVA: 0x000775A0 File Offset: 0x000757A0
		// Note: this type is marked as 'beforefieldinit'.
		static TextDiagnosticDisplay()
		{
			Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.diagnostics", "TextDiagnosticDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr);
			TextDiagnosticDisplay.NativeFieldInfoPtr_FpsFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, "FpsFormat");
			TextDiagnosticDisplay.NativeFieldInfoPtr_MemoryFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, "MemoryFormat");
			TextDiagnosticDisplay.NativeFieldInfoPtr_PingFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, "PingFormat");
			TextDiagnosticDisplay.NativeFieldInfoPtr_SystemInfoFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, "SystemInfoFormat");
			TextDiagnosticDisplay.NativeFieldInfoPtr_fpsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, "fpsText");
			TextDiagnosticDisplay.NativeFieldInfoPtr_memoryText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, "memoryText");
			TextDiagnosticDisplay.NativeFieldInfoPtr_pingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, "pingText");
			TextDiagnosticDisplay.NativeFieldInfoPtr_systemInfoText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, "systemInfoText");
			TextDiagnosticDisplay.NativeFieldInfoPtr_additionalInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, "additionalInfos");
			TextDiagnosticDisplay.NativeFieldInfoPtr_cachedFormatParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, "cachedFormatParams");
			TextDiagnosticDisplay.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, 100667277);
			TextDiagnosticDisplay.NativeMethodInfoPtr_visibilityChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, 100667278);
			TextDiagnosticDisplay.NativeMethodInfoPtr_SetFps_Protected_Virtual_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, 100667279);
			TextDiagnosticDisplay.NativeMethodInfoPtr_SetMemory_Protected_Virtual_Void_UInt64_UInt64_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, 100667280);
			TextDiagnosticDisplay.NativeMethodInfoPtr_SetPing_Protected_Virtual_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, 100667281);
			TextDiagnosticDisplay.NativeMethodInfoPtr_FastToString_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, 100667282);
			TextDiagnosticDisplay.NativeMethodInfoPtr_FastToString_Private_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, 100667283);
			TextDiagnosticDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr, 100667284);
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00077738 File Offset: 0x00075938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880763, XrefRangeEnd = 880804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextDiagnosticDisplay.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00077774 File Offset: 0x00075974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880804, XrefRangeEnd = 880830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void visibilityChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextDiagnosticDisplay.NativeMethodInfoPtr_visibilityChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x000777B0 File Offset: 0x000759B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880830, XrefRangeEnd = 880838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetFps(int current, int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextDiagnosticDisplay.NativeMethodInfoPtr_SetFps_Protected_Virtual_Void_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00077818 File Offset: 0x00075A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880838, XrefRangeEnd = 880861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetMemory(ulong current, ulong min, ulong max, ulong free, ulong profiler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref free;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref profiler;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextDiagnosticDisplay.NativeMethodInfoPtr_SetMemory_Protected_Virtual_Void_UInt64_UInt64_UInt64_UInt64_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0007789C File Offset: 0x00075A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880861, XrefRangeEnd = 880869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetPing(double latencyAverage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref latencyAverage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextDiagnosticDisplay.NativeMethodInfoPtr_SetPing_Protected_Virtual_Void_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x000778E8 File Offset: 0x00075AE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 880872, RefRangeEnd = 880875, XrefRangeStart = 880869, XrefRangeEnd = 880872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FastToString(int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextDiagnosticDisplay.NativeMethodInfoPtr_FastToString_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0007792C File Offset: 0x00075B2C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 880878, RefRangeEnd = 880883, XrefRangeStart = 880875, XrefRangeEnd = 880878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FastToString(ulong num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextDiagnosticDisplay.NativeMethodInfoPtr_FastToString_Private_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00077970 File Offset: 0x00075B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880883, XrefRangeEnd = 880900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextDiagnosticDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextDiagnosticDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextDiagnosticDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x0000AF50 File Offset: 0x00009150
		public TextDiagnosticDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x000779AC File Offset: 0x00075BAC
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x0000AF59 File Offset: 0x00009159
		public unsafe string FpsFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_FpsFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_FpsFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x000779D4 File Offset: 0x00075BD4
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x0000AF78 File Offset: 0x00009178
		public unsafe string MemoryFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_MemoryFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_MemoryFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x000779FC File Offset: 0x00075BFC
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x0000AF97 File Offset: 0x00009197
		public unsafe string PingFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_PingFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_PingFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x00077A24 File Offset: 0x00075C24
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x0000AFB6 File Offset: 0x000091B6
		public unsafe string SystemInfoFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_SystemInfoFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_SystemInfoFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x00077A4C File Offset: 0x00075C4C
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x0000AFD5 File Offset: 0x000091D5
		public unsafe Text fpsText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_fpsText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_fpsText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x00077A7C File Offset: 0x00075C7C
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x0000AFF4 File Offset: 0x000091F4
		public unsafe Text memoryText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_memoryText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_memoryText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x00077AAC File Offset: 0x00075CAC
		// (set) Token: 0x06001911 RID: 6417 RVA: 0x0000B013 File Offset: 0x00009213
		public unsafe Text pingText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_pingText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_pingText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x00077ADC File Offset: 0x00075CDC
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x0000B032 File Offset: 0x00009232
		public unsafe Text systemInfoText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_systemInfoText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_systemInfoText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x00077B0C File Offset: 0x00075D0C
		// (set) Token: 0x06001915 RID: 6421 RVA: 0x0000B051 File Offset: 0x00009251
		public unsafe Il2CppReferenceArray<GameObject> additionalInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_additionalInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_additionalInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x00077B3C File Offset: 0x00075D3C
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x0000B070 File Offset: 0x00009270
		public unsafe Il2CppReferenceArray<global::Il2CppSystem.Object> cachedFormatParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_cachedFormatParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<global::Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDiagnosticDisplay.NativeFieldInfoPtr_cachedFormatParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeFieldInfoPtr_FpsFormat;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeFieldInfoPtr_MemoryFormat;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeFieldInfoPtr_PingFormat;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeFieldInfoPtr_SystemInfoFormat;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeFieldInfoPtr_fpsText;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeFieldInfoPtr_memoryText;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeFieldInfoPtr_pingText;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeFieldInfoPtr_systemInfoText;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeFieldInfoPtr_additionalInfos;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeFieldInfoPtr_cachedFormatParams;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr_visibilityChanged_Protected_Virtual_Void_0;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr_SetFps_Protected_Virtual_Void_Int32_Int32_Int32_0;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr_SetMemory_Protected_Virtual_Void_UInt64_UInt64_UInt64_UInt64_UInt64_0;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr_SetPing_Protected_Virtual_Void_Double_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr_FastToString_Private_String_Int32_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_FastToString_Private_String_UInt64_0;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
