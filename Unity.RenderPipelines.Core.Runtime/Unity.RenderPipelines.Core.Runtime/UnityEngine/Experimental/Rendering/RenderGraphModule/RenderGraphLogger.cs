using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x0200001A RID: 26
	public class RenderGraphLogger : Object
	{
		// Token: 0x06000284 RID: 644 RVA: 0x0001692C File Offset: 0x00014B2C
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphLogger()
		{
			Il2CppClassPointerStore<RenderGraphLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphLogger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphLogger>.NativeClassPtr);
			RenderGraphLogger.NativeFieldInfoPtr_m_LogMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphLogger>.NativeClassPtr, "m_LogMap");
			RenderGraphLogger.NativeFieldInfoPtr_m_CurrentBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphLogger>.NativeClassPtr, "m_CurrentBuilder");
			RenderGraphLogger.NativeFieldInfoPtr_m_CurrentIndentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphLogger>.NativeClassPtr, "m_CurrentIndentation");
			RenderGraphLogger.NativeMethodInfoPtr_Initialize_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphLogger>.NativeClassPtr, 100663588);
			RenderGraphLogger.NativeMethodInfoPtr_IncrementIndentation_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphLogger>.NativeClassPtr, 100663589);
			RenderGraphLogger.NativeMethodInfoPtr_DecrementIndentation_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphLogger>.NativeClassPtr, 100663590);
			RenderGraphLogger.NativeMethodInfoPtr_LogLine_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphLogger>.NativeClassPtr, 100663591);
			RenderGraphLogger.NativeMethodInfoPtr_GetLog_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphLogger>.NativeClassPtr, 100663592);
			RenderGraphLogger.NativeMethodInfoPtr_GetAllLogs_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphLogger>.NativeClassPtr, 100663593);
			RenderGraphLogger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphLogger>.NativeClassPtr, 100663594);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00016A24 File Offset: 0x00014C24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 956886, RefRangeEnd = 956889, XrefRangeStart = 956874, XrefRangeEnd = 956886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string logName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphLogger.NativeMethodInfoPtr_Initialize_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00016A68 File Offset: 0x00014C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956889, XrefRangeEnd = 956892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementIndentation(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphLogger.NativeMethodInfoPtr_IncrementIndentation_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00016AA8 File Offset: 0x00014CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956892, XrefRangeEnd = 956896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecrementIndentation(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphLogger.NativeMethodInfoPtr_DecrementIndentation_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00016AE8 File Offset: 0x00014CE8
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 956900, RefRangeEnd = 956916, XrefRangeStart = 956896, XrefRangeEnd = 956900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogLine(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphLogger.NativeMethodInfoPtr_LogLine_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00016B4C File Offset: 0x00014D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956916, XrefRangeEnd = 956921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLog(string logName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphLogger.NativeMethodInfoPtr_GetLog_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00016B94 File Offset: 0x00014D94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 956940, RefRangeEnd = 956943, XrefRangeStart = 956921, XrefRangeEnd = 956940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAllLogs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphLogger.NativeMethodInfoPtr_GetAllLogs_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00016BCC File Offset: 0x00014DCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 956951, RefRangeEnd = 956954, XrefRangeStart = 956943, XrefRangeEnd = 956951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphLogger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphLogger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphLogger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00003162 File Offset: 0x00001362
		public void LogLine(string format, params Object[] args)
		{
			this.LogLine(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00003171 File Offset: 0x00001371
		public RenderGraphLogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00016C08 File Offset: 0x00014E08
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0000317A File Offset: 0x0000137A
		public unsafe Dictionary<string, StringBuilder> m_LogMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphLogger.NativeFieldInfoPtr_m_LogMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, StringBuilder>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphLogger.NativeFieldInfoPtr_m_LogMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00016C38 File Offset: 0x00014E38
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00003199 File Offset: 0x00001399
		public unsafe StringBuilder m_CurrentBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphLogger.NativeFieldInfoPtr_m_CurrentBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphLogger.NativeFieldInfoPtr_m_CurrentBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00016C68 File Offset: 0x00014E68
		// (set) Token: 0x06000293 RID: 659 RVA: 0x000031B8 File Offset: 0x000013B8
		public unsafe int m_CurrentIndentation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphLogger.NativeFieldInfoPtr_m_CurrentIndentation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphLogger.NativeFieldInfoPtr_m_CurrentIndentation)) = value;
			}
		}

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr_m_LogMap;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentBuilder;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentIndentation;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_IncrementIndentation_Public_Void_Int32_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_DecrementIndentation_Public_Void_Int32_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_LogLine_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_GetLog_Public_String_String_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_GetAllLogs_Public_String_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
