using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ImaginationOverflow.UniversalDeepLinking
{
	// Token: 0x0200000E RID: 14
	[Serializable]
	public class LinkInformation : Object
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00004DC4 File Offset: 0x00002FC4
		// Note: this type is marked as 'beforefieldinit'.
		static LinkInformation()
		{
			Il2CppClassPointerStore<LinkInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking", "LinkInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkInformation>.NativeClassPtr);
			LinkInformation.NativeFieldInfoPtr__scheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInformation>.NativeClassPtr, "_scheme");
			LinkInformation.NativeFieldInfoPtr__host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInformation>.NativeClassPtr, "_host");
			LinkInformation.NativeFieldInfoPtr__path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInformation>.NativeClassPtr, "_path");
			LinkInformation.NativeMethodInfoPtr_get_Scheme_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkInformation>.NativeClassPtr, 100663416);
			LinkInformation.NativeMethodInfoPtr_set_Scheme_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkInformation>.NativeClassPtr, 100663417);
			LinkInformation.NativeMethodInfoPtr_get_Host_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkInformation>.NativeClassPtr, 100663418);
			LinkInformation.NativeMethodInfoPtr_set_Host_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkInformation>.NativeClassPtr, 100663419);
			LinkInformation.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkInformation>.NativeClassPtr, 100663420);
			LinkInformation.NativeMethodInfoPtr_set_Path_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkInformation>.NativeClassPtr, 100663421);
			LinkInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkInformation>.NativeClassPtr, 100663422);
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00004EBC File Offset: 0x000030BC
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00004EF4 File Offset: 0x000030F4
		public unsafe string Scheme
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkInformation.NativeMethodInfoPtr_get_Scheme_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkInformation.NativeMethodInfoPtr_set_Scheme_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00004F38 File Offset: 0x00003138
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00004F70 File Offset: 0x00003170
		public unsafe string Host
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkInformation.NativeMethodInfoPtr_get_Host_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkInformation.NativeMethodInfoPtr_set_Host_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004FB4 File Offset: 0x000031B4
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00004FEC File Offset: 0x000031EC
		public unsafe string Path
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkInformation.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkInformation.NativeMethodInfoPtr_set_Path_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00005030 File Offset: 0x00003230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240861, XrefRangeEnd = 1240869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000023AD File Offset: 0x000005AD
		public LinkInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000506C File Offset: 0x0000326C
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x000023B6 File Offset: 0x000005B6
		public unsafe string _scheme
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInformation.NativeFieldInfoPtr__scheme);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInformation.NativeFieldInfoPtr__scheme), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00005094 File Offset: 0x00003294
		// (set) Token: 0x060000AA RID: 170 RVA: 0x000023D5 File Offset: 0x000005D5
		public unsafe string _host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInformation.NativeFieldInfoPtr__host);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInformation.NativeFieldInfoPtr__host), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000050BC File Offset: 0x000032BC
		// (set) Token: 0x060000AC RID: 172 RVA: 0x000023F4 File Offset: 0x000005F4
		public unsafe string _path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInformation.NativeFieldInfoPtr__path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInformation.NativeFieldInfoPtr__path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr__scheme;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr__host;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr__path;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_get_Scheme_Public_get_String_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_set_Scheme_Public_set_Void_String_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_get_Host_Public_get_String_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_set_Host_Public_set_Void_String_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_set_Path_Public_set_Void_String_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
