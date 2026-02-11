using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x02000165 RID: 357
	[Serializable]
	public class CompatibleComparer : Object
	{
		// Token: 0x060015AC RID: 5548 RVA: 0x00070640 File Offset: 0x0006E840
		// Note: this type is marked as 'beforefieldinit'.
		static CompatibleComparer()
		{
			Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "CompatibleComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr);
			CompatibleComparer.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, "_comparer");
			CompatibleComparer.NativeFieldInfoPtr_defaultComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, "defaultComparer");
			CompatibleComparer.NativeFieldInfoPtr__hcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, "_hcp");
			CompatibleComparer.NativeFieldInfoPtr_defaultHashProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, "defaultHashProvider");
			CompatibleComparer.NativeMethodInfoPtr__ctor_Internal_Void_IComparer_IHashCodeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100666596);
			CompatibleComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100666597);
			CompatibleComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100666598);
			CompatibleComparer.NativeMethodInfoPtr_get_Comparer_Public_get_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100666599);
			CompatibleComparer.NativeMethodInfoPtr_get_HashCodeProvider_Public_get_IHashCodeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100666600);
			CompatibleComparer.NativeMethodInfoPtr_get_DefaultComparer_Public_Static_get_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100666601);
			CompatibleComparer.NativeMethodInfoPtr_get_DefaultHashCodeProvider_Public_Static_get_IHashCodeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100666602);
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x0007074C File Offset: 0x0006E94C
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hashCodeProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr__ctor_Internal_Void_IComparer_IHashCodeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x000707AC File Offset: 0x0006E9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467502, XrefRangeEnd = 467512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Object a, Object b)
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

		// Token: 0x060015AF RID: 5551 RVA: 0x0007080C File Offset: 0x0006EA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467512, XrefRangeEnd = 467522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(Object obj)
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

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x0007085C File Offset: 0x0006EA5C
		public unsafe IComparer Comparer
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_get_Comparer_Public_get_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr3) : null;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x0007089C File Offset: 0x0006EA9C
		public unsafe IHashCodeProvider HashCodeProvider
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_get_HashCodeProvider_Public_get_IHashCodeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHashCodeProvider>(intPtr3) : null;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x000708DC File Offset: 0x0006EADC
		public unsafe static IComparer DefaultComparer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467522, XrefRangeEnd = 467539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_get_DefaultComparer_Public_Static_get_IComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr3) : null;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x00070910 File Offset: 0x0006EB10
		public unsafe static IHashCodeProvider DefaultHashCodeProvider
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467539, XrefRangeEnd = 467556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_get_DefaultHashCodeProvider_Public_Static_get_IHashCodeProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHashCodeProvider>(intPtr3) : null;
			}
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x0000983D File Offset: 0x00007A3D
		public CompatibleComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x00070944 File Offset: 0x0006EB44
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x00009846 File Offset: 0x00007A46
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

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x00070974 File Offset: 0x0006EB74
		// (set) Token: 0x060015B8 RID: 5560 RVA: 0x00009865 File Offset: 0x00007A65
		public unsafe static IComparer defaultComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CompatibleComparer.NativeFieldInfoPtr_defaultComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompatibleComparer.NativeFieldInfoPtr_defaultComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x0007099C File Offset: 0x0006EB9C
		// (set) Token: 0x060015BA RID: 5562 RVA: 0x00009877 File Offset: 0x00007A77
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

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x000709CC File Offset: 0x0006EBCC
		// (set) Token: 0x060015BC RID: 5564 RVA: 0x00009896 File Offset: 0x00007A96
		public unsafe static IHashCodeProvider defaultHashProvider
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CompatibleComparer.NativeFieldInfoPtr_defaultHashProvider, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHashCodeProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompatibleComparer.NativeFieldInfoPtr_defaultHashProvider, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeFieldInfoPtr_defaultComparer;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeFieldInfoPtr__hcp;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeFieldInfoPtr_defaultHashProvider;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IComparer_IHashCodeProvider_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_get_Comparer_Public_get_IComparer_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_get_HashCodeProvider_Public_get_IHashCodeProvider_0;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultComparer_Public_Static_get_IComparer_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultHashCodeProvider_Public_Static_get_IHashCodeProvider_0;
	}
}
