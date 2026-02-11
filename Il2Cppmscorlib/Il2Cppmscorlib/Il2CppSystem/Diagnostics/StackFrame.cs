using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004A5 RID: 1189
	[Serializable]
	public class StackFrame : Object
	{
		// Token: 0x0600499E RID: 18846 RVA: 0x00155214 File Offset: 0x00153414
		// Note: this type is marked as 'beforefieldinit'.
		static StackFrame()
		{
			Il2CppClassPointerStore<StackFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "StackFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackFrame>.NativeClassPtr);
			StackFrame.NativeFieldInfoPtr_OFFSET_UNKNOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "OFFSET_UNKNOWN");
			StackFrame.NativeFieldInfoPtr_ilOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "ilOffset");
			StackFrame.NativeFieldInfoPtr_nativeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "nativeOffset");
			StackFrame.NativeFieldInfoPtr_methodAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "methodAddress");
			StackFrame.NativeFieldInfoPtr_methodIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "methodIndex");
			StackFrame.NativeFieldInfoPtr_methodBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "methodBase");
			StackFrame.NativeFieldInfoPtr_fileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "fileName");
			StackFrame.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "lineNumber");
			StackFrame.NativeFieldInfoPtr_columnNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "columnNumber");
			StackFrame.NativeFieldInfoPtr_internalMethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "internalMethodName");
			StackFrame.NativeMethodInfoPtr_get_frame_info_Private_Static_Boolean_Int32_Boolean_byref_MethodBase_byref_Int32_byref_Int32_byref_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674016);
			StackFrame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674017);
			StackFrame.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674018);
			StackFrame.NativeMethodInfoPtr_GetFileLineNumber_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674019);
			StackFrame.NativeMethodInfoPtr_GetFileName_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674020);
			StackFrame.NativeMethodInfoPtr_GetSecureFileName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674021);
			StackFrame.NativeMethodInfoPtr_GetILOffset_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674022);
			StackFrame.NativeMethodInfoPtr_GetMethod_Public_Virtual_New_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674023);
			StackFrame.NativeMethodInfoPtr_GetNativeOffset_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674024);
			StackFrame.NativeMethodInfoPtr_GetMethodAddress_Internal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674025);
			StackFrame.NativeMethodInfoPtr_GetMethodIndex_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674026);
			StackFrame.NativeMethodInfoPtr_GetInternalMethodName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674027);
			StackFrame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674028);
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x00155410 File Offset: 0x00153610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414267, XrefRangeEnd = 1414268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skip;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needFileInfo;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &iloffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &native_offset;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &line;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &column;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_get_frame_info_Private_Static_Boolean_Int32_Boolean_byref_MethodBase_byref_Int32_byref_Int32_byref_String_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			method = ((intPtr5 == 0) ? null : new MethodBase(intPtr5));
			file = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x001554D8 File Offset: 0x001536D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414268, XrefRangeEnd = 1414270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackFrame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackFrame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x00155514 File Offset: 0x00153714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1414272, RefRangeEnd = 1414274, XrefRangeStart = 1414270, XrefRangeEnd = 1414272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackFrame(int skipFrames, bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackFrame>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipFrames;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x0015556C File Offset: 0x0015376C
		[CallerCount(0)]
		public unsafe virtual int GetFileLineNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetFileLineNumber_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x001555B4 File Offset: 0x001537B4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetFileName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetFileName_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x001555F8 File Offset: 0x001537F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1414277, RefRangeEnd = 1414279, XrefRangeStart = 1414274, XrefRangeEnd = 1414277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSecureFileName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_GetSecureFileName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060049A5 RID: 18853 RVA: 0x00155630 File Offset: 0x00153830
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetILOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetILOffset_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x00155678 File Offset: 0x00153878
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodBase GetMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetMethod_Public_Virtual_New_MethodBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x001556C4 File Offset: 0x001538C4
		[CallerCount(0)]
		public unsafe virtual int GetNativeOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetNativeOffset_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x0015570C File Offset: 0x0015390C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetMethodAddress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_GetMethodAddress_Internal_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x00155748 File Offset: 0x00153948
		[CallerCount(0)]
		public unsafe uint GetMethodIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_GetMethodIndex_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x00155784 File Offset: 0x00153984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetInternalMethodName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_GetInternalMethodName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x001557BC File Offset: 0x001539BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414279, XrefRangeEnd = 1414317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x0001AF11 File Offset: 0x00019111
		public StackFrame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x060049AD RID: 18861 RVA: 0x00155800 File Offset: 0x00153A00
		// (set) Token: 0x060049AE RID: 18862 RVA: 0x0001AF1A File Offset: 0x0001911A
		public unsafe static int OFFSET_UNKNOWN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StackFrame.NativeFieldInfoPtr_OFFSET_UNKNOWN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackFrame.NativeFieldInfoPtr_OFFSET_UNKNOWN, (void*)(&value));
			}
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x060049AF RID: 18863 RVA: 0x0015581C File Offset: 0x00153A1C
		// (set) Token: 0x060049B0 RID: 18864 RVA: 0x0001AF28 File Offset: 0x00019128
		public unsafe int ilOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_ilOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_ilOffset)) = value;
			}
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x060049B1 RID: 18865 RVA: 0x00155844 File Offset: 0x00153A44
		// (set) Token: 0x060049B2 RID: 18866 RVA: 0x0001AF43 File Offset: 0x00019143
		public unsafe int nativeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_nativeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_nativeOffset)) = value;
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x060049B3 RID: 18867 RVA: 0x0015586C File Offset: 0x00153A6C
		// (set) Token: 0x060049B4 RID: 18868 RVA: 0x0001AF5E File Offset: 0x0001915E
		public unsafe long methodAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodAddress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodAddress)) = value;
			}
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x060049B5 RID: 18869 RVA: 0x00155894 File Offset: 0x00153A94
		// (set) Token: 0x060049B6 RID: 18870 RVA: 0x0001AF79 File Offset: 0x00019179
		public unsafe uint methodIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodIndex)) = value;
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x060049B7 RID: 18871 RVA: 0x001558BC File Offset: 0x00153ABC
		// (set) Token: 0x060049B8 RID: 18872 RVA: 0x0001AF94 File Offset: 0x00019194
		public unsafe MethodBase methodBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x060049B9 RID: 18873 RVA: 0x001558EC File Offset: 0x00153AEC
		// (set) Token: 0x060049BA RID: 18874 RVA: 0x0001AFB3 File Offset: 0x000191B3
		public unsafe string fileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_fileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_fileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x060049BB RID: 18875 RVA: 0x00155914 File Offset: 0x00153B14
		// (set) Token: 0x060049BC RID: 18876 RVA: 0x0001AFD2 File Offset: 0x000191D2
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x060049BD RID: 18877 RVA: 0x0015593C File Offset: 0x00153B3C
		// (set) Token: 0x060049BE RID: 18878 RVA: 0x0001AFED File Offset: 0x000191ED
		public unsafe int columnNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_columnNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_columnNumber)) = value;
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x060049BF RID: 18879 RVA: 0x00155964 File Offset: 0x00153B64
		// (set) Token: 0x060049C0 RID: 18880 RVA: 0x0001B008 File Offset: 0x00019208
		public unsafe string internalMethodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_internalMethodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_internalMethodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003C58 RID: 15448
		private static readonly IntPtr NativeFieldInfoPtr_OFFSET_UNKNOWN;

		// Token: 0x04003C59 RID: 15449
		private static readonly IntPtr NativeFieldInfoPtr_ilOffset;

		// Token: 0x04003C5A RID: 15450
		private static readonly IntPtr NativeFieldInfoPtr_nativeOffset;

		// Token: 0x04003C5B RID: 15451
		private static readonly IntPtr NativeFieldInfoPtr_methodAddress;

		// Token: 0x04003C5C RID: 15452
		private static readonly IntPtr NativeFieldInfoPtr_methodIndex;

		// Token: 0x04003C5D RID: 15453
		private static readonly IntPtr NativeFieldInfoPtr_methodBase;

		// Token: 0x04003C5E RID: 15454
		private static readonly IntPtr NativeFieldInfoPtr_fileName;

		// Token: 0x04003C5F RID: 15455
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x04003C60 RID: 15456
		private static readonly IntPtr NativeFieldInfoPtr_columnNumber;

		// Token: 0x04003C61 RID: 15457
		private static readonly IntPtr NativeFieldInfoPtr_internalMethodName;

		// Token: 0x04003C62 RID: 15458
		private static readonly IntPtr NativeMethodInfoPtr_get_frame_info_Private_Static_Boolean_Int32_Boolean_byref_MethodBase_byref_Int32_byref_Int32_byref_String_byref_Int32_byref_Int32_0;

		// Token: 0x04003C63 RID: 15459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003C64 RID: 15460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		// Token: 0x04003C65 RID: 15461
		private static readonly IntPtr NativeMethodInfoPtr_GetFileLineNumber_Public_Virtual_New_Int32_0;

		// Token: 0x04003C66 RID: 15462
		private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Public_Virtual_New_String_0;

		// Token: 0x04003C67 RID: 15463
		private static readonly IntPtr NativeMethodInfoPtr_GetSecureFileName_Internal_String_0;

		// Token: 0x04003C68 RID: 15464
		private static readonly IntPtr NativeMethodInfoPtr_GetILOffset_Public_Virtual_New_Int32_0;

		// Token: 0x04003C69 RID: 15465
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Public_Virtual_New_MethodBase_0;

		// Token: 0x04003C6A RID: 15466
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeOffset_Public_Virtual_New_Int32_0;

		// Token: 0x04003C6B RID: 15467
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodAddress_Internal_Int64_0;

		// Token: 0x04003C6C RID: 15468
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodIndex_Internal_UInt32_0;

		// Token: 0x04003C6D RID: 15469
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalMethodName_Internal_String_0;

		// Token: 0x04003C6E RID: 15470
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
