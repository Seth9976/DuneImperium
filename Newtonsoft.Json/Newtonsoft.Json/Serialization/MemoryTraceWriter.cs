using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000098 RID: 152
	public class MemoryTraceWriter : Object
	{
		// Token: 0x06000D3D RID: 3389 RVA: 0x0004F240 File Offset: 0x0004D440
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryTraceWriter()
		{
			Il2CppClassPointerStore<MemoryTraceWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "MemoryTraceWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryTraceWriter>.NativeClassPtr);
			MemoryTraceWriter.NativeFieldInfoPtr__traceMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryTraceWriter>.NativeClassPtr, "_traceMessages");
			MemoryTraceWriter.NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryTraceWriter>.NativeClassPtr, "_lock");
			MemoryTraceWriter.NativeFieldInfoPtr__LevelFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryTraceWriter>.NativeClassPtr, "<LevelFilter>k__BackingField");
			MemoryTraceWriter.NativeMethodInfoPtr_get_LevelFilter_Public_Virtual_Final_New_get_TraceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTraceWriter>.NativeClassPtr, 100665717);
			MemoryTraceWriter.NativeMethodInfoPtr_set_LevelFilter_Public_set_Void_TraceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTraceWriter>.NativeClassPtr, 100665718);
			MemoryTraceWriter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTraceWriter>.NativeClassPtr, 100665719);
			MemoryTraceWriter.NativeMethodInfoPtr_Trace_Public_Virtual_Final_New_Void_TraceLevel_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTraceWriter>.NativeClassPtr, 100665720);
			MemoryTraceWriter.NativeMethodInfoPtr_GetTraceMessages_Public_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTraceWriter>.NativeClassPtr, 100665721);
			MemoryTraceWriter.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTraceWriter>.NativeClassPtr, 100665722);
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x0004F324 File Offset: 0x0004D524
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x0004F360 File Offset: 0x0004D560
		public unsafe virtual TraceLevel LevelFilter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTraceWriter.NativeMethodInfoPtr_get_LevelFilter_Public_Virtual_Final_New_get_TraceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTraceWriter.NativeMethodInfoPtr_set_LevelFilter_Public_set_Void_TraceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x0004F3A0 File Offset: 0x0004D5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753628, XrefRangeEnd = 753641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryTraceWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryTraceWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTraceWriter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x0004F3DC File Offset: 0x0004D5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753641, XrefRangeEnd = 753681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTraceWriter.NativeMethodInfoPtr_Trace_Public_Virtual_Final_New_Void_TraceLevel_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0004F440 File Offset: 0x0004D640
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<string> GetTraceMessages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTraceWriter.NativeMethodInfoPtr_GetTraceMessages_Public_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0004F480 File Offset: 0x0004D680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753681, XrefRangeEnd = 753708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryTraceWriter.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x000064C6 File Offset: 0x000046C6
		public MemoryTraceWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0004F4C4 File Offset: 0x0004D6C4
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x000064CF File Offset: 0x000046CF
		public unsafe Queue<string> _traceMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTraceWriter.NativeFieldInfoPtr__traceMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTraceWriter.NativeFieldInfoPtr__traceMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0004F4F4 File Offset: 0x0004D6F4
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x000064EE File Offset: 0x000046EE
		public unsafe Object _lock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTraceWriter.NativeFieldInfoPtr__lock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTraceWriter.NativeFieldInfoPtr__lock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x0004F524 File Offset: 0x0004D724
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x0000650D File Offset: 0x0000470D
		public unsafe TraceLevel _LevelFilter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTraceWriter.NativeFieldInfoPtr__LevelFilter_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTraceWriter.NativeFieldInfoPtr__LevelFilter_k__BackingField)) = value;
			}
		}

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeFieldInfoPtr__traceMessages;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeFieldInfoPtr__lock;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeFieldInfoPtr__LevelFilter_k__BackingField;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_get_LevelFilter_Public_Virtual_Final_New_get_TraceLevel_0;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr_set_LevelFilter_Public_set_Void_TraceLevel_0;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr_Trace_Public_Virtual_Final_New_Void_TraceLevel_String_Exception_0;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr_GetTraceMessages_Public_IEnumerable_1_String_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
