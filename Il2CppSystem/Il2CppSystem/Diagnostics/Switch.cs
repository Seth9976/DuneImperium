using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x02000090 RID: 144
	public class Switch : Object
	{
		// Token: 0x06000AB6 RID: 2742 RVA: 0x00044E98 File Offset: 0x00043098
		// Note: this type is marked as 'beforefieldinit'.
		static Switch()
		{
			Il2CppClassPointerStore<Switch>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "Switch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Switch>.NativeClassPtr);
			Switch.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Switch>.NativeClassPtr, "description");
			Switch.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Switch>.NativeClassPtr, "displayName");
			Switch.NativeFieldInfoPtr_switchValueString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Switch>.NativeClassPtr, "switchValueString");
			Switch.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Switch>.NativeClassPtr, "defaultValue");
			Switch.NativeFieldInfoPtr_switches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Switch>.NativeClassPtr, "switches");
			Switch.NativeFieldInfoPtr_s_LastCollectionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Switch>.NativeClassPtr, "s_LastCollectionCount");
			Switch.NativeMethodInfoPtr__ctor_Protected_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Switch>.NativeClassPtr, 100664907);
			Switch.NativeMethodInfoPtr__ctor_Protected_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Switch>.NativeClassPtr, 100664908);
			Switch.NativeMethodInfoPtr__pruneCachedSwitches_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Switch>.NativeClassPtr, 100664909);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00044F7C File Offset: 0x0004317C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442655, XrefRangeEnd = 442658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Switch(string displayName, string description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Switch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Switch.NativeMethodInfoPtr__ctor_Protected_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00044FDC File Offset: 0x000431DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 442688, RefRangeEnd = 442691, XrefRangeStart = 442658, XrefRangeEnd = 442688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Switch(string displayName, string description, string defaultSwitchValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Switch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultSwitchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Switch.NativeMethodInfoPtr__ctor_Protected_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0004504C File Offset: 0x0004324C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 442754, RefRangeEnd = 442755, XrefRangeStart = 442691, XrefRangeEnd = 442754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _pruneCachedSwitches()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Switch.NativeMethodInfoPtr__pruneCachedSwitches_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public Switch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00045074 File Offset: 0x00043274
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00005BF1 File Offset: 0x00003DF1
		public unsafe string description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Switch.NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Switch.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0004509C File Offset: 0x0004329C
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00005C10 File Offset: 0x00003E10
		public unsafe string displayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Switch.NativeFieldInfoPtr_displayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Switch.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x000450C4 File Offset: 0x000432C4
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00005C2F File Offset: 0x00003E2F
		public unsafe string switchValueString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Switch.NativeFieldInfoPtr_switchValueString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Switch.NativeFieldInfoPtr_switchValueString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x000450EC File Offset: 0x000432EC
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00005C4E File Offset: 0x00003E4E
		public unsafe string defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Switch.NativeFieldInfoPtr_defaultValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Switch.NativeFieldInfoPtr_defaultValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00045114 File Offset: 0x00043314
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00005C6D File Offset: 0x00003E6D
		public unsafe static List<WeakReference> switches
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Switch.NativeFieldInfoPtr_switches, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeakReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Switch.NativeFieldInfoPtr_switches, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0004513C File Offset: 0x0004333C
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00005C7F File Offset: 0x00003E7F
		public unsafe static int s_LastCollectionCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Switch.NativeFieldInfoPtr_s_LastCollectionCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Switch.NativeFieldInfoPtr_s_LastCollectionCount, (void*)(&value));
			}
		}

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeFieldInfoPtr_displayName;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeFieldInfoPtr_switchValueString;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeFieldInfoPtr_switches;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeFieldInfoPtr_s_LastCollectionCount;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_String_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_String_String_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr__pruneCachedSwitches_Private_Static_Void_0;
	}
}
