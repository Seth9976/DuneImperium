using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032C RID: 812
	[Serializable]
	public class FixupHolderList : Object
	{
		// Token: 0x060031C8 RID: 12744 RVA: 0x000FC8FC File Offset: 0x000FAAFC
		// Note: this type is marked as 'beforefieldinit'.
		static FixupHolderList()
		{
			Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "FixupHolderList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr);
			FixupHolderList.NativeFieldInfoPtr_m_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, "m_values");
			FixupHolderList.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, "m_count");
			FixupHolderList.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, 100671116);
			FixupHolderList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, 100671117);
			FixupHolderList.NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_FixupHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, 100671118);
			FixupHolderList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, 100671119);
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x000FC9A4 File Offset: 0x000FABA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385857, XrefRangeEnd = 1385862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixupHolderList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixupHolderList.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x000FC9E0 File Offset: 0x000FABE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385862, XrefRangeEnd = 1385867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixupHolderList(int startingSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixupHolderList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x000FCA28 File Offset: 0x000FAC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385867, XrefRangeEnd = 1385878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(FixupHolder fixup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FixupHolderList.NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_FixupHolder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x000FCA78 File Offset: 0x000FAC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385878, XrefRangeEnd = 1385884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnlargeArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixupHolderList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x000112BB File Offset: 0x0000F4BB
		public FixupHolderList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x000FCAAC File Offset: 0x000FACAC
		// (set) Token: 0x060031CF RID: 12751 RVA: 0x000112C4 File Offset: 0x0000F4C4
		public unsafe Il2CppReferenceArray<FixupHolder> m_values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolderList.NativeFieldInfoPtr_m_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FixupHolder>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolderList.NativeFieldInfoPtr_m_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x000FCADC File Offset: 0x000FACDC
		// (set) Token: 0x060031D1 RID: 12753 RVA: 0x000112E3 File Offset: 0x0000F4E3
		public unsafe int m_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolderList.NativeFieldInfoPtr_m_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolderList.NativeFieldInfoPtr_m_count)) = value;
			}
		}

		// Token: 0x040028ED RID: 10477
		private static readonly IntPtr NativeFieldInfoPtr_m_values;

		// Token: 0x040028EE RID: 10478
		private static readonly IntPtr NativeFieldInfoPtr_m_count;

		// Token: 0x040028EF RID: 10479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040028F0 RID: 10480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040028F1 RID: 10481
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_FixupHolder_0;

		// Token: 0x040028F2 RID: 10482
		private static readonly IntPtr NativeMethodInfoPtr_EnlargeArray_Private_Void_0;
	}
}
