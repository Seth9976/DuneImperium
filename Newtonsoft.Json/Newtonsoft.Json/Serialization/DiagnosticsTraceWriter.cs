using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Diagnostics;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000077 RID: 119
	public class DiagnosticsTraceWriter : Object
	{
		// Token: 0x06000A21 RID: 2593 RVA: 0x000416AC File Offset: 0x0003F8AC
		// Note: this type is marked as 'beforefieldinit'.
		static DiagnosticsTraceWriter()
		{
			Il2CppClassPointerStore<DiagnosticsTraceWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "DiagnosticsTraceWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiagnosticsTraceWriter>.NativeClassPtr);
			DiagnosticsTraceWriter.NativeFieldInfoPtr__LevelFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticsTraceWriter>.NativeClassPtr, "<LevelFilter>k__BackingField");
			DiagnosticsTraceWriter.NativeMethodInfoPtr_get_LevelFilter_Public_Virtual_Final_New_get_TraceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsTraceWriter>.NativeClassPtr, 100665262);
			DiagnosticsTraceWriter.NativeMethodInfoPtr_set_LevelFilter_Public_set_Void_TraceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsTraceWriter>.NativeClassPtr, 100665263);
			DiagnosticsTraceWriter.NativeMethodInfoPtr_GetTraceEventType_Private_TraceEventType_TraceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsTraceWriter>.NativeClassPtr, 100665264);
			DiagnosticsTraceWriter.NativeMethodInfoPtr_Trace_Public_Virtual_Final_New_Void_TraceLevel_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsTraceWriter>.NativeClassPtr, 100665265);
			DiagnosticsTraceWriter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsTraceWriter>.NativeClassPtr, 100665266);
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00041754 File Offset: 0x0003F954
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00041790 File Offset: 0x0003F990
		public unsafe virtual TraceLevel LevelFilter
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsTraceWriter.NativeMethodInfoPtr_get_LevelFilter_Public_Virtual_Final_New_get_TraceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsTraceWriter.NativeMethodInfoPtr_set_LevelFilter_Public_set_Void_TraceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x000417D0 File Offset: 0x0003F9D0
		[CallerCount(0)]
		public unsafe TraceEventType GetTraceEventType(TraceLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsTraceWriter.NativeMethodInfoPtr_GetTraceEventType_Private_TraceEventType_TraceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0004181C File Offset: 0x0003FA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748780, XrefRangeEnd = 748816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Trace(TraceLevel level, string message, Exception ex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsTraceWriter.NativeMethodInfoPtr_Trace_Public_Virtual_Final_New_Void_TraceLevel_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00041880 File Offset: 0x0003FA80
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiagnosticsTraceWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiagnosticsTraceWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsTraceWriter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00005100 File Offset: 0x00003300
		public DiagnosticsTraceWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x000418BC File Offset: 0x0003FABC
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00005109 File Offset: 0x00003309
		public unsafe TraceLevel _LevelFilter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticsTraceWriter.NativeFieldInfoPtr__LevelFilter_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticsTraceWriter.NativeFieldInfoPtr__LevelFilter_k__BackingField)) = value;
			}
		}

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeFieldInfoPtr__LevelFilter_k__BackingField;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_get_LevelFilter_Public_Virtual_Final_New_get_TraceLevel_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_set_LevelFilter_Public_set_Void_TraceLevel_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_GetTraceEventType_Private_TraceEventType_TraceLevel_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_Trace_Public_Virtual_Final_New_Void_TraceLevel_String_Exception_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
