using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x0200010D RID: 269
	[Serializable]
	public sealed class Version : Object
	{
		// Token: 0x06001219 RID: 4633 RVA: 0x0007D0AC File Offset: 0x0007B2AC
		// Note: this type is marked as 'beforefieldinit'.
		static Version()
		{
			Il2CppClassPointerStore<Version>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Version");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Version>.NativeClassPtr);
			Version.NativeFieldInfoPtr__Major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "_Major");
			Version.NativeFieldInfoPtr__Minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "_Minor");
			Version.NativeFieldInfoPtr__Build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "_Build");
			Version.NativeFieldInfoPtr__Revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "_Revision");
			Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666452);
			Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666453);
			Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666454);
			Version.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666455);
			Version.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666456);
			Version.NativeMethodInfoPtr__ctor_Private_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666457);
			Version.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666458);
			Version.NativeMethodInfoPtr_get_Major_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666459);
			Version.NativeMethodInfoPtr_get_Minor_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666460);
			Version.NativeMethodInfoPtr_get_Build_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666461);
			Version.NativeMethodInfoPtr_get_Revision_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666462);
			Version.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666463);
			Version.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666464);
			Version.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666465);
			Version.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666466);
			Version.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666467);
			Version.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666468);
			Version.NativeMethodInfoPtr_ToString_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666469);
			Version.NativeMethodInfoPtr_TryFormat_Public_Boolean_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666470);
			Version.NativeMethodInfoPtr_TryFormat_Public_Boolean_Span_1_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666471);
			Version.NativeMethodInfoPtr_System_ISpanFormattable_TryFormat_Private_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666472);
			Version.NativeMethodInfoPtr_get_DefaultFormatFieldCount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666473);
			Version.NativeMethodInfoPtr_ToCachedStringBuilder_Private_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666474);
			Version.NativeMethodInfoPtr_Parse_Public_Static_Version_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666475);
			Version.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666476);
			Version.NativeMethodInfoPtr_ParseVersion_Private_Static_Version_ReadOnlySpan_1_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666477);
			Version.NativeMethodInfoPtr_TryParseComponent_Private_Static_Boolean_ReadOnlySpan_1_Char_String_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666478);
			Version.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Version_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666479);
			Version.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Version_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666480);
			Version.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Version_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666481);
			Version.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Version_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666482);
			Version.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Version_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666483);
			Version.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Version_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666484);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0007D3C0 File Offset: 0x0007B5C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1333510, RefRangeEnd = 1333513, XrefRangeStart = 1333509, XrefRangeEnd = 1333510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Version(int major, int minor, int build, int revision)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref major;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref build;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref revision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0007D434 File Offset: 0x0007B634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1333513, XrefRangeEnd = 1333514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Version(int major, int minor, int build)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref major;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref build;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x0007D498 File Offset: 0x0007B698
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1333515, RefRangeEnd = 1333517, XrefRangeStart = 1333514, XrefRangeEnd = 1333515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Version(int major, int minor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref major;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0007D4F0 File Offset: 0x0007B6F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1333521, RefRangeEnd = 1333525, XrefRangeStart = 1333517, XrefRangeEnd = 1333521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Version(string version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0007D53C File Offset: 0x0007B73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1333525, XrefRangeEnd = 1333526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Version()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0007D578 File Offset: 0x0007B778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1333526, XrefRangeEnd = 1333527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Version(Version version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Private_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0007D5C4 File Offset: 0x0007B7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1333527, XrefRangeEnd = 1333531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x0007D604 File Offset: 0x0007B804
		public unsafe int Major
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_Major_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x0007D640 File Offset: 0x0007B840
		public unsafe int Minor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_Minor_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x0007D67C File Offset: 0x0007B87C
		public unsafe int Build
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_Build_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x0007D6B8 File Offset: 0x0007B8B8
		public unsafe int Revision
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_Revision_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x0007D6F4 File Offset: 0x0007B8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1333531, XrefRangeEnd = 1333533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x0007D744 File Offset: 0x0007B944
		[CallerCount(0)]
		public unsafe int CompareTo(Version value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x0007D794 File Offset: 0x0007B994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1333533, XrefRangeEnd = 1333535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0007D7E4 File Offset: 0x0007B9E4
		[CallerCount(0)]
		public unsafe bool Equals(Version obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0007D834 File Offset: 0x0007BA34
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0007D870 File Offset: 0x0007BA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1333535, XrefRangeEnd = 1333537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0007D8A8 File Offset: 0x0007BAA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1333539, RefRangeEnd = 1333541, XrefRangeStart = 1333537, XrefRangeEnd = 1333539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(int fieldCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fieldCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_ToString_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0007D8EC File Offset: 0x0007BAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1333541, XrefRangeEnd = 1333551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFormat(Span<char> destination, out int charsWritten)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_TryFormat_Public_Boolean_Span_1_Char_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0007D94C File Offset: 0x0007BB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1333551, XrefRangeEnd = 1333563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFormat(Span<char> destination, int fieldCount, out int charsWritten)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_TryFormat_Public_Boolean_Span_1_Char_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0007D9BC File Offset: 0x0007BBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_ISpanFormattable_TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_System_ISpanFormattable_TryFormat_Private_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x0007DA48 File Offset: 0x0007BC48
		public unsafe int DefaultFormatFieldCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_DefaultFormatFieldCount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0007DA84 File Offset: 0x0007BC84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1333571, RefRangeEnd = 1333575, XrefRangeStart = 1333563, XrefRangeEnd = 1333571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder ToCachedStringBuilder(int fieldCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fieldCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_ToCachedStringBuilder_Private_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0007DAD0 File Offset: 0x0007BCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1333575, XrefRangeEnd = 1333578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Version Parse(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_Parse_Public_Static_Version_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0007DB14 File Offset: 0x0007BD14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1333582, RefRangeEnd = 1333584, XrefRangeStart = 1333578, XrefRangeEnd = 1333582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, out Version result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Version_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Version(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0007DB78 File Offset: 0x0007BD78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1333617, RefRangeEnd = 1333620, XrefRangeStart = 1333584, XrefRangeEnd = 1333617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Version ParseVersion(ReadOnlySpan<char> input, bool throwOnFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(input));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_ParseVersion_Private_Static_Version_ReadOnlySpan_1_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0007DBD0 File Offset: 0x0007BDD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1333625, RefRangeEnd = 1333627, XrefRangeStart = 1333620, XrefRangeEnd = 1333625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseComponent(ReadOnlySpan<char> component, string componentName, bool throwOnFailure, out int parsedComponent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(component));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(componentName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnFailure;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parsedComponent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_TryParseComponent_Private_Static_Boolean_ReadOnlySpan_1_Char_String_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0007DC44 File Offset: 0x0007BE44
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1333627, RefRangeEnd = 1333643, XrefRangeStart = 1333627, XrefRangeEnd = 1333627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Version v1, Version v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Version_Version_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0007DC98 File Offset: 0x0007BE98
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1333643, RefRangeEnd = 1333651, XrefRangeStart = 1333643, XrefRangeEnd = 1333643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Version v1, Version v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Version_Version_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0007DCEC File Offset: 0x0007BEEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1333651, RefRangeEnd = 1333652, XrefRangeStart = 1333651, XrefRangeEnd = 1333651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(Version v1, Version v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Version_Version_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0007DD40 File Offset: 0x0007BF40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1333652, RefRangeEnd = 1333653, XrefRangeStart = 1333652, XrefRangeEnd = 1333652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <=(Version v1, Version v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Version_Version_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0007DD94 File Offset: 0x0007BF94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1333653, RefRangeEnd = 1333654, XrefRangeStart = 1333653, XrefRangeEnd = 1333653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >(Version v1, Version v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Version_Version_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0007DDE8 File Offset: 0x0007BFE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1333654, RefRangeEnd = 1333655, XrefRangeStart = 1333654, XrefRangeEnd = 1333654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >=(Version v1, Version v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Version_Version_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00005FC4 File Offset: 0x000041C4
		public Version(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x0007DE3C File Offset: 0x0007C03C
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x00005FCD File Offset: 0x000041CD
		public unsafe int _Major
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Major);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Major)) = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x0007DE64 File Offset: 0x0007C064
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x00005FE8 File Offset: 0x000041E8
		public unsafe int _Minor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Minor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Minor)) = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x0007DE8C File Offset: 0x0007C08C
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x00006003 File Offset: 0x00004203
		public unsafe int _Build
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Build);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Build)) = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x0007DEB4 File Offset: 0x0007C0B4
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x0000601E File Offset: 0x0000421E
		public unsafe int _Revision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Revision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Revision)) = value;
			}
		}

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeFieldInfoPtr__Major;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeFieldInfoPtr__Minor;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeFieldInfoPtr__Build;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeFieldInfoPtr__Revision;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Version_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_get_Major_Public_get_Int32_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_get_Minor_Public_get_Int32_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_get_Build_Public_get_Int32_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_get_Revision_Public_get_Int32_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Version_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Version_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_Int32_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_TryFormat_Public_Boolean_Span_1_Char_byref_Int32_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_TryFormat_Public_Boolean_Span_1_Char_Int32_byref_Int32_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_System_ISpanFormattable_TryFormat_Private_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultFormatFieldCount_Private_get_Int32_0;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_ToCachedStringBuilder_Private_StringBuilder_Int32_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Version_String_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Version_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_ParseVersion_Private_Static_Version_ReadOnlySpan_1_Char_Boolean_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_TryParseComponent_Private_Static_Boolean_ReadOnlySpan_1_Char_String_Boolean_byref_Int32_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Version_Version_0;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Version_Version_0;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Version_Version_0;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Version_Version_0;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Version_Version_0;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Version_Version_0;
	}
}
