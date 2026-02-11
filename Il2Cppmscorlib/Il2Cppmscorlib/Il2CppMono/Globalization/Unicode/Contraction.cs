using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000021 RID: 33
	public class Contraction : Object
	{
		// Token: 0x060000FE RID: 254 RVA: 0x000291E0 File Offset: 0x000273E0
		// Note: this type is marked as 'beforefieldinit'.
		static Contraction()
		{
			Il2CppClassPointerStore<Contraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "Contraction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contraction>.NativeClassPtr);
			Contraction.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contraction>.NativeClassPtr, "Index");
			Contraction.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contraction>.NativeClassPtr, "Source");
			Contraction.NativeFieldInfoPtr_Replacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contraction>.NativeClassPtr, "Replacement");
			Contraction.NativeFieldInfoPtr_SortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contraction>.NativeClassPtr, "SortKey");
			Contraction.NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppStructArray_1_Char_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contraction>.NativeClassPtr, 100663489);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00029274 File Offset: 0x00027474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1276474, RefRangeEnd = 1276476, XrefRangeStart = 1276470, XrefRangeEnd = 1276474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contraction(int index, Il2CppStructArray<char> source, string replacement, Il2CppStructArray<byte> sortkey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contraction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacement);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sortkey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contraction.NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppStructArray_1_Char_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000026BB File Offset: 0x000008BB
		public Contraction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000292F4 File Offset: 0x000274F4
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000026C4 File Offset: 0x000008C4
		public unsafe int Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_Index)) = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0002931C File Offset: 0x0002751C
		// (set) Token: 0x06000104 RID: 260 RVA: 0x000026DF File Offset: 0x000008DF
		public unsafe Il2CppStructArray<char> Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_Source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0002934C File Offset: 0x0002754C
		// (set) Token: 0x06000106 RID: 262 RVA: 0x000026FE File Offset: 0x000008FE
		public unsafe string Replacement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_Replacement);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_Replacement), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00029374 File Offset: 0x00027574
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0000271D File Offset: 0x0000091D
		public unsafe Il2CppStructArray<byte> SortKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_SortKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_SortKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_Index;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_Source;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_Replacement;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_SortKey;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppStructArray_1_Char_String_Il2CppStructArray_1_Byte_0;
	}
}
