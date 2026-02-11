using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000045 RID: 69
	public class ConditionValue : Object
	{
		// Token: 0x0600056A RID: 1386 RVA: 0x0001FAF8 File Offset: 0x0001DCF8
		// Note: this type is marked as 'beforefieldinit'.
		static ConditionValue()
		{
			Il2CppClassPointerStore<ConditionValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "ConditionValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionValue>.NativeClassPtr);
			ConditionValue.NativeFieldInfoPtr__RelativeDate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionValue>.NativeClassPtr, "<RelativeDate>k__BackingField");
			ConditionValue.NativeFieldInfoPtr__UserEnteredValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionValue>.NativeClassPtr, "<UserEnteredValue>k__BackingField");
			ConditionValue.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionValue>.NativeClassPtr, "<ETag>k__BackingField");
			ConditionValue.NativeMethodInfoPtr_get_RelativeDate_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionValue>.NativeClassPtr, 100664179);
			ConditionValue.NativeMethodInfoPtr_set_RelativeDate_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionValue>.NativeClassPtr, 100664180);
			ConditionValue.NativeMethodInfoPtr_get_UserEnteredValue_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionValue>.NativeClassPtr, 100664181);
			ConditionValue.NativeMethodInfoPtr_set_UserEnteredValue_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionValue>.NativeClassPtr, 100664182);
			ConditionValue.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionValue>.NativeClassPtr, 100664183);
			ConditionValue.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionValue>.NativeClassPtr, 100664184);
			ConditionValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionValue>.NativeClassPtr, 100664185);
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0001FBF0 File Offset: 0x0001DDF0
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x0001FC34 File Offset: 0x0001DE34
		public unsafe virtual string RelativeDate
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionValue.NativeMethodInfoPtr_get_RelativeDate_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionValue.NativeMethodInfoPtr_set_RelativeDate_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x0001FC84 File Offset: 0x0001DE84
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x0001FCC8 File Offset: 0x0001DEC8
		public unsafe virtual string UserEnteredValue
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionValue.NativeMethodInfoPtr_get_UserEnteredValue_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionValue.NativeMethodInfoPtr_set_UserEnteredValue_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0001FD18 File Offset: 0x0001DF18
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x0001FD5C File Offset: 0x0001DF5C
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionValue.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionValue.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0001FDAC File Offset: 0x0001DFAC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConditionValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x000048A1 File Offset: 0x00002AA1
		public ConditionValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0001FDE8 File Offset: 0x0001DFE8
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x000048AA File Offset: 0x00002AAA
		public unsafe string _RelativeDate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionValue.NativeFieldInfoPtr__RelativeDate_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionValue.NativeFieldInfoPtr__RelativeDate_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0001FE10 File Offset: 0x0001E010
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x000048C9 File Offset: 0x00002AC9
		public unsafe string _UserEnteredValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionValue.NativeFieldInfoPtr__UserEnteredValue_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionValue.NativeFieldInfoPtr__UserEnteredValue_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0001FE38 File Offset: 0x0001E038
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x000048E8 File Offset: 0x00002AE8
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionValue.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionValue.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr__RelativeDate_k__BackingField;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr__UserEnteredValue_k__BackingField;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDate_Public_Virtual_New_get_String_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_set_RelativeDate_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_get_UserEnteredValue_Public_Virtual_New_get_String_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_set_UserEnteredValue_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
