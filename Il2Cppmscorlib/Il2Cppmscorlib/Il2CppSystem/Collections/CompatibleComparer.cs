using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004C5 RID: 1221
	[Serializable]
	public sealed class CompatibleComparer : Object
	{
		// Token: 0x06004AA9 RID: 19113 RVA: 0x001590D8 File Offset: 0x001572D8
		// Note: this type is marked as 'beforefieldinit'.
		static CompatibleComparer()
		{
			Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "CompatibleComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr);
			CompatibleComparer.NativeFieldInfoPtr__hcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, "_hcp");
			CompatibleComparer.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, "_comparer");
			CompatibleComparer.NativeMethodInfoPtr__ctor_Internal_Void_IHashCodeProvider_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100674172);
			CompatibleComparer.NativeMethodInfoPtr_get_HashCodeProvider_Internal_get_IHashCodeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100674173);
			CompatibleComparer.NativeMethodInfoPtr_get_Comparer_Internal_get_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100674174);
			CompatibleComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100674175);
			CompatibleComparer.NativeMethodInfoPtr_Compare_Public_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100674176);
			CompatibleComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100674177);
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x001591A8 File Offset: 0x001573A8
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompatibleComparer(IHashCodeProvider hashCodeProvider, IComparer comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashCodeProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr__ctor_Internal_Void_IHashCodeProvider_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06004AAB RID: 19115 RVA: 0x00159208 File Offset: 0x00157408
		public unsafe IHashCodeProvider HashCodeProvider
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_get_HashCodeProvider_Internal_get_IHashCodeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHashCodeProvider>(intPtr3) : null;
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06004AAC RID: 19116 RVA: 0x00159248 File Offset: 0x00157448
		public unsafe IComparer Comparer
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_get_Comparer_Internal_get_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr3) : null;
			}
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x00159288 File Offset: 0x00157488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414980, XrefRangeEnd = 1414993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Object a, Object b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x001592E8 File Offset: 0x001574E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414993, XrefRangeEnd = 1415002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(Object a, Object b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_Compare_Public_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x00159348 File Offset: 0x00157548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415002, XrefRangeEnd = 1415011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x0001B5CB File Offset: 0x000197CB
		public CompatibleComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06004AB1 RID: 19121 RVA: 0x00159398 File Offset: 0x00157598
		// (set) Token: 0x06004AB2 RID: 19122 RVA: 0x0001B5D4 File Offset: 0x000197D4
		public unsafe IHashCodeProvider _hcp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompatibleComparer.NativeFieldInfoPtr__hcp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHashCodeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompatibleComparer.NativeFieldInfoPtr__hcp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06004AB3 RID: 19123 RVA: 0x001593C8 File Offset: 0x001575C8
		// (set) Token: 0x06004AB4 RID: 19124 RVA: 0x0001B5F3 File Offset: 0x000197F3
		public unsafe IComparer _comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompatibleComparer.NativeFieldInfoPtr__comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompatibleComparer.NativeFieldInfoPtr__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D26 RID: 15654
		private static readonly IntPtr NativeFieldInfoPtr__hcp;

		// Token: 0x04003D27 RID: 15655
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x04003D28 RID: 15656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IHashCodeProvider_IComparer_0;

		// Token: 0x04003D29 RID: 15657
		private static readonly IntPtr NativeMethodInfoPtr_get_HashCodeProvider_Internal_get_IHashCodeProvider_0;

		// Token: 0x04003D2A RID: 15658
		private static readonly IntPtr NativeMethodInfoPtr_get_Comparer_Internal_get_IComparer_0;

		// Token: 0x04003D2B RID: 15659
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x04003D2C RID: 15660
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Int32_Object_Object_0;

		// Token: 0x04003D2D RID: 15661
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0;
	}
}
