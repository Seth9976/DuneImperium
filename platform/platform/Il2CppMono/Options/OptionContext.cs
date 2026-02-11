using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Options
{
	// Token: 0x0200000A RID: 10
	public class OptionContext : Object
	{
		// Token: 0x06000075 RID: 117 RVA: 0x000065B8 File Offset: 0x000047B8
		// Note: this type is marked as 'beforefieldinit'.
		static OptionContext()
		{
			Il2CppClassPointerStore<OptionContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "Mono.Options", "OptionContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionContext>.NativeClassPtr);
			OptionContext.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionContext>.NativeClassPtr, "option");
			OptionContext.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionContext>.NativeClassPtr, "name");
			OptionContext.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionContext>.NativeClassPtr, "index");
			OptionContext.NativeFieldInfoPtr_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionContext>.NativeClassPtr, "set");
			OptionContext.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionContext>.NativeClassPtr, "c");
			OptionContext.NativeMethodInfoPtr__ctor_Public_Void_OptionSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionContext>.NativeClassPtr, 100663389);
			OptionContext.NativeMethodInfoPtr_get_Option_Public_get_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionContext>.NativeClassPtr, 100663390);
			OptionContext.NativeMethodInfoPtr_set_Option_Public_set_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionContext>.NativeClassPtr, 100663391);
			OptionContext.NativeMethodInfoPtr_get_OptionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionContext>.NativeClassPtr, 100663392);
			OptionContext.NativeMethodInfoPtr_set_OptionName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionContext>.NativeClassPtr, 100663393);
			OptionContext.NativeMethodInfoPtr_get_OptionIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionContext>.NativeClassPtr, 100663394);
			OptionContext.NativeMethodInfoPtr_set_OptionIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionContext>.NativeClassPtr, 100663395);
			OptionContext.NativeMethodInfoPtr_get_OptionSet_Public_get_OptionSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionContext>.NativeClassPtr, 100663396);
			OptionContext.NativeMethodInfoPtr_get_OptionValues_Public_get_OptionValueCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionContext>.NativeClassPtr, 100663397);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00006700 File Offset: 0x00004900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166038, XrefRangeEnd = 1166053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionContext(OptionSet set)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionContext.NativeMethodInfoPtr__ctor_Public_Void_OptionSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000674C File Offset: 0x0000494C
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000678C File Offset: 0x0000498C
		public unsafe Option Option
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionContext.NativeMethodInfoPtr_get_Option_Public_get_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Option>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionContext.NativeMethodInfoPtr_set_Option_Public_set_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000067D0 File Offset: 0x000049D0
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00006808 File Offset: 0x00004A08
		public unsafe string OptionName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionContext.NativeMethodInfoPtr_get_OptionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionContext.NativeMethodInfoPtr_set_OptionName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000684C File Offset: 0x00004A4C
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00006888 File Offset: 0x00004A88
		public unsafe int OptionIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionContext.NativeMethodInfoPtr_get_OptionIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionContext.NativeMethodInfoPtr_set_OptionIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000068C8 File Offset: 0x00004AC8
		public unsafe OptionSet OptionSet
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionContext.NativeMethodInfoPtr_get_OptionSet_Public_get_OptionSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr3) : null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00006908 File Offset: 0x00004B08
		public unsafe OptionValueCollection OptionValues
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionContext.NativeMethodInfoPtr_get_OptionValues_Public_get_OptionValueCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionValueCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000022A7 File Offset: 0x000004A7
		public OptionContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00006948 File Offset: 0x00004B48
		// (set) Token: 0x06000081 RID: 129 RVA: 0x000022B0 File Offset: 0x000004B0
		public unsafe Option option
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionContext.NativeFieldInfoPtr_option);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Option>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionContext.NativeFieldInfoPtr_option), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00006978 File Offset: 0x00004B78
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000022CF File Offset: 0x000004CF
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionContext.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionContext.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000069A0 File Offset: 0x00004BA0
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000022EE File Offset: 0x000004EE
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionContext.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionContext.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000069C8 File Offset: 0x00004BC8
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002309 File Offset: 0x00000509
		public unsafe OptionSet set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionContext.NativeFieldInfoPtr_set);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionContext.NativeFieldInfoPtr_set), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000069F8 File Offset: 0x00004BF8
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002328 File Offset: 0x00000528
		public unsafe OptionValueCollection c
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionContext.NativeFieldInfoPtr_c);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionValueCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionContext.NativeFieldInfoPtr_c), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_option;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_set;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_c;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_OptionSet_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_get_Option_Public_get_Option_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_set_Option_Public_set_Void_Option_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_get_OptionName_Public_get_String_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_set_OptionName_Public_set_Void_String_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_get_OptionIndex_Public_get_Int32_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_set_OptionIndex_Public_set_Void_Int32_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_OptionSet_Public_get_OptionSet_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_get_OptionValues_Public_get_OptionValueCollection_0;
	}
}
