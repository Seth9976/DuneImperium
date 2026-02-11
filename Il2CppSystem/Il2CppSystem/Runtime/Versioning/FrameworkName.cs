using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Versioning
{
	// Token: 0x02000072 RID: 114
	[Serializable]
	public sealed class FrameworkName : Object
	{
		// Token: 0x060006DC RID: 1756 RVA: 0x00036C20 File Offset: 0x00034E20
		// Note: this type is marked as 'beforefieldinit'.
		static FrameworkName()
		{
			Il2CppClassPointerStore<FrameworkName>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Runtime.Versioning", "FrameworkName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr);
			FrameworkName.NativeFieldInfoPtr_m_identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr, "m_identifier");
			FrameworkName.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr, "m_version");
			FrameworkName.NativeFieldInfoPtr_m_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr, "m_profile");
			FrameworkName.NativeFieldInfoPtr_m_fullName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr, "m_fullName");
			FrameworkName.NativeMethodInfoPtr_get_Identifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr, 100664423);
			FrameworkName.NativeMethodInfoPtr_get_Version_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr, 100664424);
			FrameworkName.NativeMethodInfoPtr_get_Profile_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr, 100664425);
			FrameworkName.NativeMethodInfoPtr_get_FullName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr, 100664426);
			FrameworkName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr, 100664427);
			FrameworkName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FrameworkName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr, 100664428);
			FrameworkName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr, 100664429);
			FrameworkName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr, 100664430);
			FrameworkName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr, 100664431);
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00036D54 File Offset: 0x00034F54
		public unsafe string Identifier
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameworkName.NativeMethodInfoPtr_get_Identifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00036D8C File Offset: 0x00034F8C
		public unsafe Version Version
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameworkName.NativeMethodInfoPtr_get_Version_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00036DCC File Offset: 0x00034FCC
		public unsafe string Profile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameworkName.NativeMethodInfoPtr_get_Profile_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00036E04 File Offset: 0x00035004
		public unsafe string FullName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437212, XrefRangeEnd = 437232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameworkName.NativeMethodInfoPtr_get_FullName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00036E3C File Offset: 0x0003503C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437232, XrefRangeEnd = 437237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameworkName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00036E8C File Offset: 0x0003508C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437237, XrefRangeEnd = 437240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(FrameworkName other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameworkName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FrameworkName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00036EDC File Offset: 0x000350DC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameworkName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00036F18 File Offset: 0x00035118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameworkName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00036F50 File Offset: 0x00035150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 437268, RefRangeEnd = 437269, XrefRangeStart = 437240, XrefRangeEnd = 437268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FrameworkName(string frameworkName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameworkName>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(frameworkName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameworkName.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00004398 File Offset: 0x00002598
		public FrameworkName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00036F9C File Offset: 0x0003519C
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x000043A1 File Offset: 0x000025A1
		public unsafe string m_identifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameworkName.NativeFieldInfoPtr_m_identifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameworkName.NativeFieldInfoPtr_m_identifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00036FC4 File Offset: 0x000351C4
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x000043C0 File Offset: 0x000025C0
		public unsafe Version m_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameworkName.NativeFieldInfoPtr_m_version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameworkName.NativeFieldInfoPtr_m_version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00036FF4 File Offset: 0x000351F4
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x000043DF File Offset: 0x000025DF
		public unsafe string m_profile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameworkName.NativeFieldInfoPtr_m_profile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameworkName.NativeFieldInfoPtr_m_profile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x0003701C File Offset: 0x0003521C
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x000043FE File Offset: 0x000025FE
		public unsafe string m_fullName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameworkName.NativeFieldInfoPtr_m_fullName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameworkName.NativeFieldInfoPtr_m_fullName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr_m_identifier;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_m_version;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeFieldInfoPtr_m_profile;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeFieldInfoPtr_m_fullName;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_get_String_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Version_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_get_Profile_Public_get_String_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_get_String_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FrameworkName_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
