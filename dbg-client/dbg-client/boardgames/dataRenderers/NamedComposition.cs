using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.dataRenderers
{
	// Token: 0x0200014B RID: 331
	public sealed class NamedComposition : ValueType
	{
		// Token: 0x06000F07 RID: 3847 RVA: 0x0004D7F0 File Offset: 0x0004B9F0
		// Note: this type is marked as 'beforefieldinit'.
		static NamedComposition()
		{
			Il2CppClassPointerStore<NamedComposition>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "NamedComposition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamedComposition>.NativeClassPtr);
			NamedComposition.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedComposition>.NativeClassPtr, "name");
			NamedComposition.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedComposition>.NativeClassPtr, "data");
			NamedComposition.NativeMethodInfoPtr__ctor_Public_Void_String_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedComposition>.NativeClassPtr, 100665478);
			NamedComposition.NativeMethodInfoPtr_Compare_Public_Static_Int32_NamedComposition_NamedComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedComposition>.NativeClassPtr, 100665479);
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0004D870 File Offset: 0x0004BA70
		[CallerCount(238)]
		[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamedComposition(string name_, DataComposition data_)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamedComposition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name_);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data_);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedComposition.NativeMethodInfoPtr__ctor_Public_Void_String_DataComposition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0004D8D4 File Offset: 0x0004BAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512834, XrefRangeEnd = 512835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(NamedComposition a, NamedComposition b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedComposition.NativeMethodInfoPtr_Compare_Public_Static_Int32_NamedComposition_NamedComposition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0000937B File Offset: 0x0000757B
		public NamedComposition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00009384 File Offset: 0x00007584
		public NamedComposition()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamedComposition>.NativeClassPtr))
		{
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x0004D934 File Offset: 0x0004BB34
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x00009396 File Offset: 0x00007596
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedComposition.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedComposition.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x0004D95C File Offset: 0x0004BB5C
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x000093B5 File Offset: 0x000075B5
		public unsafe DataComposition data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedComposition.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedComposition.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_DataComposition_0;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_NamedComposition_NamedComposition_0;
	}
}
