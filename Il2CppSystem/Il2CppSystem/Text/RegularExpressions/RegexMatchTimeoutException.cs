using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000083 RID: 131
	[Serializable]
	public class RegexMatchTimeoutException : TimeoutException
	{
		// Token: 0x06000969 RID: 2409 RVA: 0x000401F8 File Offset: 0x0003E3F8
		// Note: this type is marked as 'beforefieldinit'.
		static RegexMatchTimeoutException()
		{
			Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexMatchTimeoutException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr);
			RegexMatchTimeoutException.NativeFieldInfoPtr__Input_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, "<Input>k__BackingField");
			RegexMatchTimeoutException.NativeFieldInfoPtr__Pattern_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, "<Pattern>k__BackingField");
			RegexMatchTimeoutException.NativeFieldInfoPtr__MatchTimeout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, "<MatchTimeout>k__BackingField");
			RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Public_Void_String_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664750);
			RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664751);
			RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664752);
			RegexMatchTimeoutException.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664753);
			RegexMatchTimeoutException.NativeMethodInfoPtr_get_Input_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664754);
			RegexMatchTimeoutException.NativeMethodInfoPtr_get_Pattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664755);
			RegexMatchTimeoutException.NativeMethodInfoPtr_get_MatchTimeout_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664756);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000402F0 File Offset: 0x0003E4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440923, XrefRangeEnd = 440937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(regexInput);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(regexPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Public_Void_String_String_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0004035C File Offset: 0x0003E55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440937, XrefRangeEnd = 440947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexMatchTimeoutException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00040398 File Offset: 0x0003E598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440947, XrefRangeEnd = 440968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexMatchTimeoutException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000403FC File Offset: 0x0003E5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440968, XrefRangeEnd = 440982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00040458 File Offset: 0x0003E658
		public unsafe string Input
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr_get_Input_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00040490 File Offset: 0x0003E690
		public unsafe string Pattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr_get_Pattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x000404C8 File Offset: 0x0003E6C8
		public unsafe TimeSpan MatchTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr_get_MatchTimeout_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000052BC File Offset: 0x000034BC
		public RegexMatchTimeoutException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00040504 File Offset: 0x0003E704
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x000052C5 File Offset: 0x000034C5
		public unsafe string _Input_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr__Input_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr__Input_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0004052C File Offset: 0x0003E72C
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x000052E4 File Offset: 0x000034E4
		public unsafe string _Pattern_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr__Pattern_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr__Pattern_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x00040554 File Offset: 0x0003E754
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x00005303 File Offset: 0x00003503
		public unsafe TimeSpan _MatchTimeout_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr__MatchTimeout_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr__MatchTimeout_k__BackingField)) = value;
			}
		}

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeFieldInfoPtr__Input_k__BackingField;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeFieldInfoPtr__Pattern_k__BackingField;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeFieldInfoPtr__MatchTimeout_k__BackingField;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_TimeSpan_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_get_Input_Public_get_String_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_get_Pattern_Public_get_String_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchTimeout_Public_get_TimeSpan_0;
	}
}
