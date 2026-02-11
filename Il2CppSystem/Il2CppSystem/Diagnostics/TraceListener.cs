using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x02000098 RID: 152
	public class TraceListener : MarshalByRefObject
	{
		// Token: 0x06000B01 RID: 2817 RVA: 0x00045C74 File Offset: 0x00043E74
		// Note: this type is marked as 'beforefieldinit'.
		static TraceListener()
		{
			Il2CppClassPointerStore<TraceListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "TraceListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceListener>.NativeClassPtr);
			TraceListener.NativeFieldInfoPtr_indentLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, "indentLevel");
			TraceListener.NativeFieldInfoPtr_indentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, "indentSize");
			TraceListener.NativeFieldInfoPtr_traceOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, "traceOptions");
			TraceListener.NativeFieldInfoPtr_needIndent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, "needIndent");
			TraceListener.NativeFieldInfoPtr_listenerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, "listenerName");
			TraceListener.NativeFieldInfoPtr_filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, "filter");
			TraceListener.NativeMethodInfoPtr__ctor_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664934);
			TraceListener.NativeMethodInfoPtr_get_IsThreadSafe_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664935);
			TraceListener.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664936);
			TraceListener.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664937);
			TraceListener.NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664938);
			TraceListener.NativeMethodInfoPtr_set_IndentLevel_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664939);
			TraceListener.NativeMethodInfoPtr_set_IndentSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664940);
			TraceListener.NativeMethodInfoPtr_get_Filter_Public_get_TraceFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664941);
			TraceListener.NativeMethodInfoPtr_get_NeedIndent_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664942);
			TraceListener.NativeMethodInfoPtr_set_NeedIndent_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664943);
			TraceListener.NativeMethodInfoPtr_get_TraceOutputOptions_Public_get_TraceOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664944);
			TraceListener.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664945);
			TraceListener.NativeMethodInfoPtr_WriteIndent_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664946);
			TraceListener.NativeMethodInfoPtr_WriteLine_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664947);
			TraceListener.NativeMethodInfoPtr_TraceEvent_Public_Virtual_New_Void_TraceEventCache_String_TraceEventType_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664948);
			TraceListener.NativeMethodInfoPtr_WriteHeader_Private_Void_String_TraceEventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664949);
			TraceListener.NativeMethodInfoPtr_WriteFooter_Private_Void_TraceEventCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664950);
			TraceListener.NativeMethodInfoPtr_IsEnabled_Internal_Boolean_TraceOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceListener>.NativeClassPtr, 100664951);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00045E84 File Offset: 0x00044084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450874, XrefRangeEnd = 450876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceListener(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceListener>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceListener.NativeMethodInfoPtr__ctor_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00045ED0 File Offset: 0x000440D0
		public unsafe virtual bool IsThreadSafe
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceListener.NativeMethodInfoPtr_get_IsThreadSafe_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00045F18 File Offset: 0x00044118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450876, XrefRangeEnd = 450880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceListener.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00045F4C File Offset: 0x0004414C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceListener.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00045F98 File Offset: 0x00044198
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceListener.NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000336 RID: 822
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x00045FD4 File Offset: 0x000441D4
		public unsafe int IndentLevel
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceListener.NativeMethodInfoPtr_set_IndentLevel_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000337 RID: 823
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00046014 File Offset: 0x00044214
		public unsafe int IndentSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 450880, RefRangeEnd = 450882, XrefRangeStart = 450880, XrefRangeEnd = 450880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceListener.NativeMethodInfoPtr_set_IndentSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00046054 File Offset: 0x00044254
		public unsafe TraceFilter Filter
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceListener.NativeMethodInfoPtr_get_Filter_Public_get_TraceFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceFilter>(intPtr3) : null;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x00046094 File Offset: 0x00044294
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x000460D0 File Offset: 0x000442D0
		public unsafe bool NeedIndent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceListener.NativeMethodInfoPtr_get_NeedIndent_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceListener.NativeMethodInfoPtr_set_NeedIndent_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x00046110 File Offset: 0x00044310
		public unsafe TraceOptions TraceOutputOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceListener.NativeMethodInfoPtr_get_TraceOutputOptions_Public_get_TraceOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0004614C File Offset: 0x0004434C
		[CallerCount(0)]
		public unsafe virtual void Write(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceListener.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0004619C File Offset: 0x0004439C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450882, XrefRangeEnd = 450887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteIndent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceListener.NativeMethodInfoPtr_WriteIndent_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x000461D8 File Offset: 0x000443D8
		[CallerCount(0)]
		public unsafe virtual void WriteLine(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceListener.NativeMethodInfoPtr_WriteLine_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00046228 File Offset: 0x00044428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450887, XrefRangeEnd = 450900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventCache);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceListener.NativeMethodInfoPtr_TraceEvent_Public_Virtual_New_Void_TraceEventCache_String_TraceEventType_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x000462B8 File Offset: 0x000444B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450900, XrefRangeEnd = 450912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteHeader(string source, TraceEventType eventType, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceListener.NativeMethodInfoPtr_WriteHeader_Private_Void_String_TraceEventType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00046318 File Offset: 0x00044518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 451008, RefRangeEnd = 451009, XrefRangeStart = 450912, XrefRangeEnd = 451008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteFooter(TraceEventCache eventCache)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventCache);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceListener.NativeMethodInfoPtr_WriteFooter_Private_Void_TraceEventCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0004635C File Offset: 0x0004455C
		[CallerCount(0)]
		public unsafe bool IsEnabled(TraceOptions opts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceListener.NativeMethodInfoPtr_IsEnabled_Internal_Boolean_TraceOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00005DC0 File Offset: 0x00003FC0
		public TraceListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x000463A8 File Offset: 0x000445A8
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00005DC9 File Offset: 0x00003FC9
		public unsafe int indentLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceListener.NativeFieldInfoPtr_indentLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceListener.NativeFieldInfoPtr_indentLevel)) = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x000463D0 File Offset: 0x000445D0
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00005DE4 File Offset: 0x00003FE4
		public unsafe int indentSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceListener.NativeFieldInfoPtr_indentSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceListener.NativeFieldInfoPtr_indentSize)) = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x000463F8 File Offset: 0x000445F8
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x00005DFF File Offset: 0x00003FFF
		public unsafe TraceOptions traceOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceListener.NativeFieldInfoPtr_traceOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceListener.NativeFieldInfoPtr_traceOptions)) = value;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00046420 File Offset: 0x00044620
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00005E1A File Offset: 0x0000401A
		public unsafe bool needIndent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceListener.NativeFieldInfoPtr_needIndent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceListener.NativeFieldInfoPtr_needIndent)) = value;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00046448 File Offset: 0x00044648
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00005E35 File Offset: 0x00004035
		public unsafe string listenerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceListener.NativeFieldInfoPtr_listenerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceListener.NativeFieldInfoPtr_listenerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00046470 File Offset: 0x00044670
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x00005E54 File Offset: 0x00004054
		public unsafe TraceFilter filter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceListener.NativeFieldInfoPtr_filter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceListener.NativeFieldInfoPtr_filter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeFieldInfoPtr_indentLevel;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeFieldInfoPtr_indentSize;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_traceOptions;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeFieldInfoPtr_needIndent;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeFieldInfoPtr_listenerName;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeFieldInfoPtr_filter;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_0;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeMethodInfoPtr_get_IsThreadSafe_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_set_IndentLevel_Public_set_Void_Int32_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_set_IndentSize_Public_set_Void_Int32_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_get_Filter_Public_get_TraceFilter_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedIndent_Protected_get_Boolean_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_set_NeedIndent_Protected_set_Void_Boolean_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_get_TraceOutputOptions_Public_get_TraceOptions_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_WriteIndent_Protected_Virtual_New_Void_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_TraceEvent_Public_Virtual_New_Void_TraceEventCache_String_TraceEventType_Int32_String_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr_WriteHeader_Private_Void_String_TraceEventType_Int32_0;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeMethodInfoPtr_WriteFooter_Private_Void_TraceEventCache_0;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Internal_Boolean_TraceOptions_0;
	}
}
