using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004A6 RID: 1190
	[Serializable]
	public class StackTrace : Object
	{
		// Token: 0x060049C1 RID: 18881 RVA: 0x0015598C File Offset: 0x00153B8C
		// Note: this type is marked as 'beforefieldinit'.
		static StackTrace()
		{
			Il2CppClassPointerStore<StackTrace>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "StackTrace");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackTrace>.NativeClassPtr);
			StackTrace.NativeFieldInfoPtr_METHODS_TO_SKIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "METHODS_TO_SKIP");
			StackTrace.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "prefix");
			StackTrace.NativeFieldInfoPtr_frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "frames");
			StackTrace.NativeFieldInfoPtr_captured_traces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "captured_traces");
			StackTrace.NativeFieldInfoPtr_debug_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "debug_info");
			StackTrace.NativeFieldInfoPtr_isAotidSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "isAotidSet");
			StackTrace.NativeFieldInfoPtr_aotid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "aotid");
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674029);
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674030);
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674031);
			StackTrace.NativeMethodInfoPtr_init_frames_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674032);
			StackTrace.NativeMethodInfoPtr_get_trace_Private_Static_Il2CppReferenceArray_1_StackFrame_Exception_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674033);
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674034);
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Exception_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674035);
			StackTrace.NativeMethodInfoPtr_get_FrameCount_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674036);
			StackTrace.NativeMethodInfoPtr_GetFrame_Public_Virtual_New_StackFrame_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674037);
			StackTrace.NativeMethodInfoPtr_GetAotId_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674038);
			StackTrace.NativeMethodInfoPtr_AddFrames_Private_Boolean_StringBuilder_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674039);
			StackTrace.NativeMethodInfoPtr_GetFullNameForStackTrace_Private_Void_StringBuilder_MethodBase_Boolean_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674040);
			StackTrace.NativeMethodInfoPtr_ConvertAsyncStateMachineMethod_Private_Static_Void_byref_MethodBase_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674041);
			StackTrace.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674042);
			StackTrace.NativeMethodInfoPtr_ToString_Internal_String_TraceFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674043);
		}

		// Token: 0x060049C2 RID: 18882 RVA: 0x00155B74 File Offset: 0x00153D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414319, RefRangeEnd = 1414320, XrefRangeStart = 1414317, XrefRangeEnd = 1414319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x00155BB0 File Offset: 0x00153DB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414322, RefRangeEnd = 1414323, XrefRangeStart = 1414320, XrefRangeEnd = 1414322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace(bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fNeedFileInfo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x00155BF8 File Offset: 0x00153DF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1414325, RefRangeEnd = 1414329, XrefRangeStart = 1414323, XrefRangeEnd = 1414325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace(int skipFrames, bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipFrames;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C5 RID: 18885 RVA: 0x00155C50 File Offset: 0x00153E50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1414362, RefRangeEnd = 1414365, XrefRangeStart = 1414329, XrefRangeEnd = 1414362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void init_frames(int skipFrames, bool fNeedFileInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipFrames;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_init_frames_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C6 RID: 18886 RVA: 0x00155C9C File Offset: 0x00153E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414365, XrefRangeEnd = 1414366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<StackFrame> get_trace(Exception e, int skipFrames, bool fNeedFileInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipFrames;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_get_trace_Private_Static_Il2CppReferenceArray_1_StackFrame_Exception_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StackFrame>>(intPtr3) : null;
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x00155CFC File Offset: 0x00153EFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1414376, RefRangeEnd = 1414378, XrefRangeStart = 1414366, XrefRangeEnd = 1414376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace(Exception e, bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x00155D58 File Offset: 0x00153F58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1414395, RefRangeEnd = 1414397, XrefRangeStart = 1414378, XrefRangeEnd = 1414395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace(Exception e, int skipFrames, bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipFrames;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Exception_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x060049C9 RID: 18889 RVA: 0x00155DC0 File Offset: 0x00153FC0
		public unsafe virtual int FrameCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackTrace.NativeMethodInfoPtr_get_FrameCount_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x00155E08 File Offset: 0x00154008
		[CallerCount(0)]
		public unsafe virtual StackFrame GetFrame(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackTrace.NativeMethodInfoPtr_GetFrame_Public_Virtual_New_StackFrame_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StackFrame>(intPtr3) : null;
			}
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x00155E60 File Offset: 0x00154060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414409, RefRangeEnd = 1414410, XrefRangeStart = 1414397, XrefRangeEnd = 1414409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAotId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_GetAotId_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x00155E8C File Offset: 0x0015408C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1414466, RefRangeEnd = 1414468, XrefRangeStart = 1414410, XrefRangeEnd = 1414466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddFrames(StringBuilder sb, bool separator, out bool isAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref separator;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_AddFrames_Private_Boolean_StringBuilder_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x00155EF8 File Offset: 0x001540F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414525, RefRangeEnd = 1414526, XrefRangeStart = 1414468, XrefRangeEnd = 1414525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi, bool needsNewLine, out bool skipped, out bool isAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needsNewLine;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &skipped;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_GetFullNameForStackTrace_Private_Void_StringBuilder_MethodBase_Boolean_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x00155F78 File Offset: 0x00154178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414554, RefRangeEnd = 1414555, XrefRangeStart = 1414526, XrefRangeEnd = 1414554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertAsyncStateMachineMethod(ref MethodBase method, ref Type declaringType)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(method);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(declaringType);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_ConvertAsyncStateMachineMethod_Private_Static_Void_byref_MethodBase_byref_Type_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			method = ((intPtr5 == 0) ? null : new MethodBase(intPtr5));
			IntPtr intPtr6 = intPtr2;
			declaringType = ((intPtr6 == 0) ? null : new Type(intPtr6));
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x00155FEC File Offset: 0x001541EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414555, XrefRangeEnd = 1414571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackTrace.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x00156030 File Offset: 0x00154230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1017349, RefRangeEnd = 1017351, XrefRangeStart = 1017349, XrefRangeEnd = 1017351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(StackTrace.TraceFormat traceFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceFormat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_ToString_Internal_String_TraceFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x0001B027 File Offset: 0x00019227
		public StackTrace(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x060049D2 RID: 18898 RVA: 0x00156074 File Offset: 0x00154274
		// (set) Token: 0x060049D3 RID: 18899 RVA: 0x0001B030 File Offset: 0x00019230
		public unsafe static int METHODS_TO_SKIP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StackTrace.NativeFieldInfoPtr_METHODS_TO_SKIP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackTrace.NativeFieldInfoPtr_METHODS_TO_SKIP, (void*)(&value));
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x060049D4 RID: 18900 RVA: 0x00156090 File Offset: 0x00154290
		// (set) Token: 0x060049D5 RID: 18901 RVA: 0x0001B03E File Offset: 0x0001923E
		public unsafe static string prefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StackTrace.NativeFieldInfoPtr_prefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackTrace.NativeFieldInfoPtr_prefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x060049D6 RID: 18902 RVA: 0x001560B0 File Offset: 0x001542B0
		// (set) Token: 0x060049D7 RID: 18903 RVA: 0x0001B050 File Offset: 0x00019250
		public unsafe Il2CppReferenceArray<StackFrame> frames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_frames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StackFrame>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_frames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x060049D8 RID: 18904 RVA: 0x001560E0 File Offset: 0x001542E0
		// (set) Token: 0x060049D9 RID: 18905 RVA: 0x0001B06F File Offset: 0x0001926F
		public unsafe Il2CppReferenceArray<StackTrace> captured_traces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_captured_traces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StackTrace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_captured_traces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x060049DA RID: 18906 RVA: 0x00156110 File Offset: 0x00154310
		// (set) Token: 0x060049DB RID: 18907 RVA: 0x0001B08E File Offset: 0x0001928E
		public unsafe bool debug_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_debug_info);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_debug_info)) = value;
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x060049DC RID: 18908 RVA: 0x00156138 File Offset: 0x00154338
		// (set) Token: 0x060049DD RID: 18909 RVA: 0x0001B0A9 File Offset: 0x000192A9
		public unsafe static bool isAotidSet
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(StackTrace.NativeFieldInfoPtr_isAotidSet, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackTrace.NativeFieldInfoPtr_isAotidSet, (void*)(&value));
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x060049DE RID: 18910 RVA: 0x00156154 File Offset: 0x00154354
		// (set) Token: 0x060049DF RID: 18911 RVA: 0x0001B0B7 File Offset: 0x000192B7
		public unsafe static string aotid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StackTrace.NativeFieldInfoPtr_aotid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackTrace.NativeFieldInfoPtr_aotid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003C6F RID: 15471
		private static readonly IntPtr NativeFieldInfoPtr_METHODS_TO_SKIP;

		// Token: 0x04003C70 RID: 15472
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x04003C71 RID: 15473
		private static readonly IntPtr NativeFieldInfoPtr_frames;

		// Token: 0x04003C72 RID: 15474
		private static readonly IntPtr NativeFieldInfoPtr_captured_traces;

		// Token: 0x04003C73 RID: 15475
		private static readonly IntPtr NativeFieldInfoPtr_debug_info;

		// Token: 0x04003C74 RID: 15476
		private static readonly IntPtr NativeFieldInfoPtr_isAotidSet;

		// Token: 0x04003C75 RID: 15477
		private static readonly IntPtr NativeFieldInfoPtr_aotid;

		// Token: 0x04003C76 RID: 15478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003C77 RID: 15479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04003C78 RID: 15480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		// Token: 0x04003C79 RID: 15481
		private static readonly IntPtr NativeMethodInfoPtr_init_frames_Private_Void_Int32_Boolean_0;

		// Token: 0x04003C7A RID: 15482
		private static readonly IntPtr NativeMethodInfoPtr_get_trace_Private_Static_Il2CppReferenceArray_1_StackFrame_Exception_Int32_Boolean_0;

		// Token: 0x04003C7B RID: 15483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_Boolean_0;

		// Token: 0x04003C7C RID: 15484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_Int32_Boolean_0;

		// Token: 0x04003C7D RID: 15485
		private static readonly IntPtr NativeMethodInfoPtr_get_FrameCount_Public_Virtual_New_get_Int32_0;

		// Token: 0x04003C7E RID: 15486
		private static readonly IntPtr NativeMethodInfoPtr_GetFrame_Public_Virtual_New_StackFrame_Int32_0;

		// Token: 0x04003C7F RID: 15487
		private static readonly IntPtr NativeMethodInfoPtr_GetAotId_Private_Static_String_0;

		// Token: 0x04003C80 RID: 15488
		private static readonly IntPtr NativeMethodInfoPtr_AddFrames_Private_Boolean_StringBuilder_Boolean_byref_Boolean_0;

		// Token: 0x04003C81 RID: 15489
		private static readonly IntPtr NativeMethodInfoPtr_GetFullNameForStackTrace_Private_Void_StringBuilder_MethodBase_Boolean_byref_Boolean_byref_Boolean_0;

		// Token: 0x04003C82 RID: 15490
		private static readonly IntPtr NativeMethodInfoPtr_ConvertAsyncStateMachineMethod_Private_Static_Void_byref_MethodBase_byref_Type_0;

		// Token: 0x04003C83 RID: 15491
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003C84 RID: 15492
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_String_TraceFormat_0;

		// Token: 0x020006DD RID: 1757
		public enum TraceFormat
		{
			// Token: 0x04004C29 RID: 19497
			Normal,
			// Token: 0x04004C2A RID: 19498
			TrailingNewLine,
			// Token: 0x04004C2B RID: 19499
			NoResourceLookup
		}
	}
}
