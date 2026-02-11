using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using voodoo.pathing;

namespace lotus
{
	// Token: 0x02000079 RID: 121
	[Serializable]
	public class UnitPath : Object
	{
		// Token: 0x06000729 RID: 1833 RVA: 0x00021278 File Offset: 0x0001F478
		// Note: this type is marked as 'beforefieldinit'.
		static UnitPath()
		{
			Il2CppClassPointerStore<UnitPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "UnitPath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitPath>.NativeClassPtr);
			UnitPath.NativeFieldInfoPtr_sequenceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPath>.NativeClassPtr, "sequenceName");
			UnitPath.NativeFieldInfoPtr_destinationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPath>.NativeClassPtr, "destinationID");
			UnitPath.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPath>.NativeClassPtr, "path");
			UnitPath.NativeFieldInfoPtr_stagger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPath>.NativeClassPtr, "stagger");
			UnitPath.NativeFieldInfoPtr_useRandomStagger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPath>.NativeClassPtr, "useRandomStagger");
			UnitPath.NativeFieldInfoPtr_minStagger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPath>.NativeClassPtr, "minStagger");
			UnitPath.NativeFieldInfoPtr_maxStagger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPath>.NativeClassPtr, "maxStagger");
			UnitPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPath>.NativeClassPtr, 100664277);
			UnitPath.NativeMethodInfoPtr__ctor_Public_Void_UnitPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPath>.NativeClassPtr, 100664278);
			UnitPath.NativeMethodInfoPtr_GetStagger_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPath>.NativeClassPtr, 100664279);
			UnitPath.NativeMethodInfoPtr_HasStagger_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPath>.NativeClassPtr, 100664280);
			UnitPath.NativeMethodInfoPtr_GetKey_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPath>.NativeClassPtr, 100664281);
			UnitPath.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPath>.NativeClassPtr, 100664282);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x000213AC File Offset: 0x0001F5AC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitPath()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitPath>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x000213E8 File Offset: 0x0001F5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114179, XrefRangeEnd = 1114181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitPath(UnitPath original)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitPath>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitPath.NativeMethodInfoPtr__ctor_Public_Void_UnitPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00021434 File Offset: 0x0001F634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114181, XrefRangeEnd = 1114182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetStagger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitPath.NativeMethodInfoPtr_GetStagger_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00021470 File Offset: 0x0001F670
		[CallerCount(0)]
		public unsafe virtual bool HasStagger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitPath.NativeMethodInfoPtr_HasStagger_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000214AC File Offset: 0x0001F6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114182, XrefRangeEnd = 1114183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitPath.NativeMethodInfoPtr_GetKey_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000214E4 File Offset: 0x0001F6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114183, XrefRangeEnd = 1114202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitPath.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00005877 File Offset: 0x00003A77
		public UnitPath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00021528 File Offset: 0x0001F728
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x00005880 File Offset: 0x00003A80
		public unsafe string sequenceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPath.NativeFieldInfoPtr_sequenceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPath.NativeFieldInfoPtr_sequenceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00021550 File Offset: 0x0001F750
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x0000589F File Offset: 0x00003A9F
		public unsafe string destinationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPath.NativeFieldInfoPtr_destinationID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPath.NativeFieldInfoPtr_destinationID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00021578 File Offset: 0x0001F778
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x000058BE File Offset: 0x00003ABE
		public unsafe PathVoodoo path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPath.NativeFieldInfoPtr_path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathVoodoo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPath.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x000215A8 File Offset: 0x0001F7A8
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x000058DD File Offset: 0x00003ADD
		public unsafe float stagger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPath.NativeFieldInfoPtr_stagger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPath.NativeFieldInfoPtr_stagger)) = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x000215D0 File Offset: 0x0001F7D0
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x000058F8 File Offset: 0x00003AF8
		public unsafe bool useRandomStagger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPath.NativeFieldInfoPtr_useRandomStagger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPath.NativeFieldInfoPtr_useRandomStagger)) = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x000215F8 File Offset: 0x0001F7F8
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00005913 File Offset: 0x00003B13
		public unsafe float minStagger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPath.NativeFieldInfoPtr_minStagger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPath.NativeFieldInfoPtr_minStagger)) = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00021620 File Offset: 0x0001F820
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x0000592E File Offset: 0x00003B2E
		public unsafe float maxStagger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPath.NativeFieldInfoPtr_maxStagger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPath.NativeFieldInfoPtr_maxStagger)) = value;
			}
		}

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeFieldInfoPtr_sequenceName;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeFieldInfoPtr_destinationID;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeFieldInfoPtr_stagger;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeFieldInfoPtr_useRandomStagger;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeFieldInfoPtr_minStagger;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeFieldInfoPtr_maxStagger;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnitPath_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_GetStagger_Public_Virtual_Final_New_Single_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_HasStagger_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Virtual_Final_New_String_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
