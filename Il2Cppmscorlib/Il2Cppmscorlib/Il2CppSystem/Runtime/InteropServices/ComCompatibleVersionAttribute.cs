using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000395 RID: 917
	public sealed class ComCompatibleVersionAttribute : Attribute
	{
		// Token: 0x060037EA RID: 14314 RVA: 0x00110B6C File Offset: 0x0010ED6C
		// Note: this type is marked as 'beforefieldinit'.
		static ComCompatibleVersionAttribute()
		{
			Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ComCompatibleVersionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr);
			ComCompatibleVersionAttribute.NativeFieldInfoPtr__major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_major");
			ComCompatibleVersionAttribute.NativeFieldInfoPtr__minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_minor");
			ComCompatibleVersionAttribute.NativeFieldInfoPtr__build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_build");
			ComCompatibleVersionAttribute.NativeFieldInfoPtr__revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_revision");
			ComCompatibleVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, 100671647);
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x00110C00 File Offset: 0x0010EE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391366, XrefRangeEnd = 1391367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComCompatibleVersionAttribute(int major, int minor, int build, int revision)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComCompatibleVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x0001487F File Offset: 0x00012A7F
		public ComCompatibleVersionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x060037ED RID: 14317 RVA: 0x00110C74 File Offset: 0x0010EE74
		// (set) Token: 0x060037EE RID: 14318 RVA: 0x00014888 File Offset: 0x00012A88
		public unsafe int _major
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__major);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__major)) = value;
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x060037EF RID: 14319 RVA: 0x00110C9C File Offset: 0x0010EE9C
		// (set) Token: 0x060037F0 RID: 14320 RVA: 0x000148A3 File Offset: 0x00012AA3
		public unsafe int _minor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__minor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__minor)) = value;
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x060037F1 RID: 14321 RVA: 0x00110CC4 File Offset: 0x0010EEC4
		// (set) Token: 0x060037F2 RID: 14322 RVA: 0x000148BE File Offset: 0x00012ABE
		public unsafe int _build
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__build);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__build)) = value;
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x060037F3 RID: 14323 RVA: 0x00110CEC File Offset: 0x0010EEEC
		// (set) Token: 0x060037F4 RID: 14324 RVA: 0x000148D9 File Offset: 0x00012AD9
		public unsafe int _revision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__revision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__revision)) = value;
			}
		}

		// Token: 0x04002DAF RID: 11695
		private static readonly IntPtr NativeFieldInfoPtr__major;

		// Token: 0x04002DB0 RID: 11696
		private static readonly IntPtr NativeFieldInfoPtr__minor;

		// Token: 0x04002DB1 RID: 11697
		private static readonly IntPtr NativeFieldInfoPtr__build;

		// Token: 0x04002DB2 RID: 11698
		private static readonly IntPtr NativeFieldInfoPtr__revision;

		// Token: 0x04002DB3 RID: 11699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;
	}
}
