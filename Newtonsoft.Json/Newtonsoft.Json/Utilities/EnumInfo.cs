using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000057 RID: 87
	public class EnumInfo : Object
	{
		// Token: 0x060007D9 RID: 2009 RVA: 0x000374C4 File Offset: 0x000356C4
		// Note: this type is marked as 'beforefieldinit'.
		static EnumInfo()
		{
			Il2CppClassPointerStore<EnumInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "EnumInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumInfo>.NativeClassPtr);
			EnumInfo.NativeFieldInfoPtr_IsFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumInfo>.NativeClassPtr, "IsFlags");
			EnumInfo.NativeFieldInfoPtr_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumInfo>.NativeClassPtr, "Values");
			EnumInfo.NativeFieldInfoPtr_Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumInfo>.NativeClassPtr, "Names");
			EnumInfo.NativeFieldInfoPtr_ResolvedNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumInfo>.NativeClassPtr, "ResolvedNames");
			EnumInfo.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Il2CppStructArray_1_UInt64_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumInfo>.NativeClassPtr, 100664826);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00037558 File Offset: 0x00035758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743126, XrefRangeEnd = 743130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumInfo(bool isFlags, Il2CppStructArray<ulong> values, Il2CppStringArray names, Il2CppStringArray resolvedNames)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isFlags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolvedNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumInfo.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Il2CppStructArray_1_UInt64_Il2CppStringArray_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00004698 File Offset: 0x00002898
		public EnumInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x000375D8 File Offset: 0x000357D8
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x000046A1 File Offset: 0x000028A1
		public unsafe bool IsFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumInfo.NativeFieldInfoPtr_IsFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumInfo.NativeFieldInfoPtr_IsFlags)) = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x00037600 File Offset: 0x00035800
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x000046BC File Offset: 0x000028BC
		public unsafe Il2CppStructArray<ulong> Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumInfo.NativeFieldInfoPtr_Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumInfo.NativeFieldInfoPtr_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00037630 File Offset: 0x00035830
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x000046DB File Offset: 0x000028DB
		public unsafe Il2CppStringArray Names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumInfo.NativeFieldInfoPtr_Names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumInfo.NativeFieldInfoPtr_Names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00037660 File Offset: 0x00035860
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x000046FA File Offset: 0x000028FA
		public unsafe Il2CppStringArray ResolvedNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumInfo.NativeFieldInfoPtr_ResolvedNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumInfo.NativeFieldInfoPtr_ResolvedNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr_IsFlags;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr_Values;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_Names;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr_ResolvedNames;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Il2CppStructArray_1_UInt64_Il2CppStringArray_Il2CppStringArray_0;
	}
}
