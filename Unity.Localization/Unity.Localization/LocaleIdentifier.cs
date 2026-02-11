using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.Localization
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	public sealed class LocaleIdentifier : ValueType
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00009B2C File Offset: 0x00007D2C
		// Note: this type is marked as 'beforefieldinit'.
		static LocaleIdentifier()
		{
			Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocaleIdentifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr);
			LocaleIdentifier.NativeFieldInfoPtr_m_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, "m_Code");
			LocaleIdentifier.NativeFieldInfoPtr_m_CultureInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, "m_CultureInfo");
			LocaleIdentifier.NativeMethodInfoPtr_get_Code_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663330);
			LocaleIdentifier.NativeMethodInfoPtr_get_CultureInfo_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663331);
			LocaleIdentifier.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663332);
			LocaleIdentifier.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663333);
			LocaleIdentifier.NativeMethodInfoPtr__ctor_Public_Void_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663334);
			LocaleIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_LocaleIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663335);
			LocaleIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_LocaleIdentifier_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663336);
			LocaleIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_LocaleIdentifier_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663337);
			LocaleIdentifier.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663338);
			LocaleIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663339);
			LocaleIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663340);
			LocaleIdentifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663341);
			LocaleIdentifier.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663342);
			LocaleIdentifier.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocaleIdentifier_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663343);
			LocaleIdentifier.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_LocaleIdentifier_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, 100663344);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00009CB0 File Offset: 0x00007EB0
		public unsafe string Code
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr_get_Code_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00009CEC File Offset: 0x00007EEC
		public unsafe CultureInfo CultureInfo
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 1065098, RefRangeEnd = 1065124, XrefRangeStart = 1065091, XrefRangeEnd = 1065098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr_get_CultureInfo_Public_get_CultureInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00009D30 File Offset: 0x00007F30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1065126, RefRangeEnd = 1065130, XrefRangeStart = 1065124, XrefRangeEnd = 1065126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocaleIdentifier(string code)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00009D80 File Offset: 0x00007F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065130, XrefRangeEnd = 1065138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocaleIdentifier(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00009DD0 File Offset: 0x00007FD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1065141, RefRangeEnd = 1065144, XrefRangeStart = 1065138, XrefRangeEnd = 1065141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocaleIdentifier(SystemLanguage systemLanguage)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref systemLanguage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr__ctor_Public_Void_SystemLanguage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00009E1C File Offset: 0x0000801C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1065146, RefRangeEnd = 1065149, XrefRangeStart = 1065144, XrefRangeEnd = 1065146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator LocaleIdentifier(string code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_LocaleIdentifier_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LocaleIdentifier(intPtr);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00009E58 File Offset: 0x00008058
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1065151, RefRangeEnd = 1065155, XrefRangeStart = 1065149, XrefRangeEnd = 1065151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator LocaleIdentifier(CultureInfo culture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_LocaleIdentifier_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LocaleIdentifier(intPtr);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00009E94 File Offset: 0x00008094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1065158, RefRangeEnd = 1065159, XrefRangeStart = 1065155, XrefRangeEnd = 1065158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator LocaleIdentifier(SystemLanguage systemLanguage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref systemLanguage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_LocaleIdentifier_SystemLanguage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LocaleIdentifier(intPtr);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00009ECC File Offset: 0x000080CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065159, XrefRangeEnd = 1065171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00009F08 File Offset: 0x00008108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065171, XrefRangeEnd = 1065176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00009F5C File Offset: 0x0000815C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1065178, RefRangeEnd = 1065179, XrefRangeStart = 1065176, XrefRangeEnd = 1065178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(LocaleIdentifier other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00009FB4 File Offset: 0x000081B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065179, XrefRangeEnd = 1065184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00009FF8 File Offset: 0x000081F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065184, XrefRangeEnd = 1065189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(LocaleIdentifier other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_LocaleIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000A050 File Offset: 0x00008250
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1065191, RefRangeEnd = 1065194, XrefRangeStart = 1065189, XrefRangeEnd = 1065191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(LocaleIdentifier l1, LocaleIdentifier l2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(l1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(l2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocaleIdentifier_LocaleIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000A0B0 File Offset: 0x000082B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1065196, RefRangeEnd = 1065198, XrefRangeStart = 1065194, XrefRangeEnd = 1065196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(LocaleIdentifier l1, LocaleIdentifier l2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(l1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(l2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleIdentifier.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_LocaleIdentifier_LocaleIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000020BB File Offset: 0x000002BB
		public LocaleIdentifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000020C4 File Offset: 0x000002C4
		public LocaleIdentifier()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr))
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000A110 File Offset: 0x00008310
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000020D6 File Offset: 0x000002D6
		public unsafe string m_Code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocaleIdentifier.NativeFieldInfoPtr_m_Code);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocaleIdentifier.NativeFieldInfoPtr_m_Code), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000A138 File Offset: 0x00008338
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000020F5 File Offset: 0x000002F5
		public unsafe CultureInfo m_CultureInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocaleIdentifier.NativeFieldInfoPtr_m_CultureInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocaleIdentifier.NativeFieldInfoPtr_m_CultureInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_m_Code;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_m_CultureInfo;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_Code_Public_get_String_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureInfo_Public_get_CultureInfo_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SystemLanguage_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LocaleIdentifier_String_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LocaleIdentifier_CultureInfo_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LocaleIdentifier_SystemLanguage_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_LocaleIdentifier_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocaleIdentifier_LocaleIdentifier_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_LocaleIdentifier_LocaleIdentifier_0;
	}
}
