using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200047A RID: 1146
	[Serializable]
	public sealed class SortVersion : Object
	{
		// Token: 0x0600451E RID: 17694 RVA: 0x001447DC File Offset: 0x001429DC
		// Note: this type is marked as 'beforefieldinit'.
		static SortVersion()
		{
			Il2CppClassPointerStore<SortVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "SortVersion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortVersion>.NativeClassPtr);
			SortVersion.NativeFieldInfoPtr_m_NlsVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortVersion>.NativeClassPtr, "m_NlsVersion");
			SortVersion.NativeFieldInfoPtr_m_SortId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortVersion>.NativeClassPtr, "m_SortId");
			SortVersion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortVersion>.NativeClassPtr, 100673465);
			SortVersion.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortVersion>.NativeClassPtr, 100673466);
			SortVersion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortVersion>.NativeClassPtr, 100673467);
			SortVersion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SortVersion_SortVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortVersion>.NativeClassPtr, 100673468);
			SortVersion.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SortVersion_SortVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortVersion>.NativeClassPtr, 100673469);
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x00144898 File Offset: 0x00142A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408881, XrefRangeEnd = 1408886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortVersion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x001448E8 File Offset: 0x00142AE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1408888, RefRangeEnd = 1408890, XrefRangeStart = 1408886, XrefRangeEnd = 1408888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SortVersion other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortVersion.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x00144938 File Offset: 0x00142B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408890, XrefRangeEnd = 1408891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortVersion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x00144974 File Offset: 0x00142B74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1408891, RefRangeEnd = 1408892, XrefRangeStart = 1408891, XrefRangeEnd = 1408891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SortVersion left, SortVersion right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortVersion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SortVersion_SortVersion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x001449C8 File Offset: 0x00142BC8
		[CallerCount(0)]
		public unsafe static bool operator !=(SortVersion left, SortVersion right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortVersion.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SortVersion_SortVersion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x00019145 File Offset: 0x00017345
		public SortVersion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06004525 RID: 17701 RVA: 0x00144A1C File Offset: 0x00142C1C
		// (set) Token: 0x06004526 RID: 17702 RVA: 0x0001914E File Offset: 0x0001734E
		public unsafe int m_NlsVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortVersion.NativeFieldInfoPtr_m_NlsVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortVersion.NativeFieldInfoPtr_m_NlsVersion)) = value;
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06004527 RID: 17703 RVA: 0x00144A44 File Offset: 0x00142C44
		// (set) Token: 0x06004528 RID: 17704 RVA: 0x00019169 File Offset: 0x00017369
		public unsafe Guid m_SortId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortVersion.NativeFieldInfoPtr_m_SortId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortVersion.NativeFieldInfoPtr_m_SortId)) = value;
			}
		}

		// Token: 0x0400391E RID: 14622
		private static readonly IntPtr NativeFieldInfoPtr_m_NlsVersion;

		// Token: 0x0400391F RID: 14623
		private static readonly IntPtr NativeFieldInfoPtr_m_SortId;

		// Token: 0x04003920 RID: 14624
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003921 RID: 14625
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortVersion_0;

		// Token: 0x04003922 RID: 14626
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003923 RID: 14627
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SortVersion_SortVersion_0;

		// Token: 0x04003924 RID: 14628
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SortVersion_SortVersion_0;
	}
}
