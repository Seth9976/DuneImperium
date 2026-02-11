using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000076 RID: 118
	[Serializable]
	public class Group : Capture
	{
		// Token: 0x0600072D RID: 1837 RVA: 0x000381C8 File Offset: 0x000363C8
		// Note: this type is marked as 'beforefieldinit'.
		static Group()
		{
			Il2CppClassPointerStore<Group>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "Group");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Group>.NativeClassPtr);
			Group.NativeFieldInfoPtr_s_emptyGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "s_emptyGroup");
			Group.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "_caps");
			Group.NativeFieldInfoPtr__capcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "_capcount");
			Group.NativeFieldInfoPtr__capcoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "_capcoll");
			Group.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "<Name>k__BackingField");
			Group.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStructArray_1_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Group>.NativeClassPtr, 100664482);
			Group.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Group>.NativeClassPtr, 100664483);
			Group.NativeMethodInfoPtr_get_Captures_Public_get_CaptureCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Group>.NativeClassPtr, 100664484);
			Group.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Group>.NativeClassPtr, 100664486);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000382AC File Offset: 0x000364AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437466, XrefRangeEnd = 437473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Group(string text, Il2CppStructArray<int> caps, int capcount, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Group>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capcount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Group.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStructArray_1_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x0003832C File Offset: 0x0003652C
		public unsafe bool Success
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 437473, RefRangeEnd = 437488, XrefRangeStart = 437473, XrefRangeEnd = 437473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Group.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00038368 File Offset: 0x00036568
		public unsafe CaptureCollection Captures
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 437494, RefRangeEnd = 437497, XrefRangeStart = 437488, XrefRangeEnd = 437494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Group.NativeMethodInfoPtr_get_Captures_Public_get_CaptureCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CaptureCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000383A8 File Offset: 0x000365A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437497, XrefRangeEnd = 437500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Group()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Group>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Group.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000044E6 File Offset: 0x000026E6
		public Group(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x000383E4 File Offset: 0x000365E4
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x000044EF File Offset: 0x000026EF
		public unsafe static Group s_emptyGroup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Group.NativeFieldInfoPtr_s_emptyGroup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Group>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Group.NativeFieldInfoPtr_s_emptyGroup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x0003840C File Offset: 0x0003660C
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x00004501 File Offset: 0x00002701
		public unsafe Il2CppStructArray<int> _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x0003843C File Offset: 0x0003663C
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x00004520 File Offset: 0x00002720
		public unsafe int _capcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__capcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__capcount)) = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00038464 File Offset: 0x00036664
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x0000453B File Offset: 0x0000273B
		public unsafe CaptureCollection _capcoll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__capcoll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CaptureCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__capcoll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00038494 File Offset: 0x00036694
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x0000455A File Offset: 0x0000275A
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeFieldInfoPtr_s_emptyGroup;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeFieldInfoPtr__capcount;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeFieldInfoPtr__capcoll;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStructArray_1_Int32_Int32_String_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_get_Boolean_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_get_Captures_Public_get_CaptureCollection_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
