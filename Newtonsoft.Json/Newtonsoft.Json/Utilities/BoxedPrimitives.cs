using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000044 RID: 68
	public static class BoxedPrimitives : Object
	{
		// Token: 0x06000657 RID: 1623 RVA: 0x00030770 File Offset: 0x0002E970
		// Note: this type is marked as 'beforefieldinit'.
		static BoxedPrimitives()
		{
			Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "BoxedPrimitives");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr);
			BoxedPrimitives.NativeFieldInfoPtr_BooleanTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "BooleanTrue");
			BoxedPrimitives.NativeFieldInfoPtr_BooleanFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "BooleanFalse");
			BoxedPrimitives.NativeFieldInfoPtr_Int32_M1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int32_M1");
			BoxedPrimitives.NativeFieldInfoPtr_Int32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int32_0");
			BoxedPrimitives.NativeFieldInfoPtr_Int32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int32_1");
			BoxedPrimitives.NativeFieldInfoPtr_Int32_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int32_2");
			BoxedPrimitives.NativeFieldInfoPtr_Int32_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int32_3");
			BoxedPrimitives.NativeFieldInfoPtr_Int32_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int32_4");
			BoxedPrimitives.NativeFieldInfoPtr_Int32_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int32_5");
			BoxedPrimitives.NativeFieldInfoPtr_Int32_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int32_6");
			BoxedPrimitives.NativeFieldInfoPtr_Int32_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int32_7");
			BoxedPrimitives.NativeFieldInfoPtr_Int32_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int32_8");
			BoxedPrimitives.NativeFieldInfoPtr_Int64_M1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int64_M1");
			BoxedPrimitives.NativeFieldInfoPtr_Int64_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int64_0");
			BoxedPrimitives.NativeFieldInfoPtr_Int64_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int64_1");
			BoxedPrimitives.NativeFieldInfoPtr_Int64_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int64_2");
			BoxedPrimitives.NativeFieldInfoPtr_Int64_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int64_3");
			BoxedPrimitives.NativeFieldInfoPtr_Int64_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int64_4");
			BoxedPrimitives.NativeFieldInfoPtr_Int64_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int64_5");
			BoxedPrimitives.NativeFieldInfoPtr_Int64_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int64_6");
			BoxedPrimitives.NativeFieldInfoPtr_Int64_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int64_7");
			BoxedPrimitives.NativeFieldInfoPtr_Int64_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "Int64_8");
			BoxedPrimitives.NativeFieldInfoPtr_DecimalZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "DecimalZero");
			BoxedPrimitives.NativeFieldInfoPtr_DoubleNaN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "DoubleNaN");
			BoxedPrimitives.NativeFieldInfoPtr_DoublePositiveInfinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "DoublePositiveInfinity");
			BoxedPrimitives.NativeFieldInfoPtr_DoubleNegativeInfinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "DoubleNegativeInfinity");
			BoxedPrimitives.NativeFieldInfoPtr_DoubleZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, "DoubleZero");
			BoxedPrimitives.NativeMethodInfoPtr_Get_Internal_Static_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, 100664575);
			BoxedPrimitives.NativeMethodInfoPtr_Get_Internal_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, 100664576);
			BoxedPrimitives.NativeMethodInfoPtr_Get_Internal_Static_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, 100664577);
			BoxedPrimitives.NativeMethodInfoPtr_Get_Internal_Static_Object_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, 100664578);
			BoxedPrimitives.NativeMethodInfoPtr_Get_Internal_Static_Object_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxedPrimitives>.NativeClassPtr, 100664579);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00030A20 File Offset: 0x0002EC20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 739338, RefRangeEnd = 739341, XrefRangeStart = 739334, XrefRangeEnd = 739338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Get(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxedPrimitives.NativeMethodInfoPtr_Get_Internal_Static_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00030A60 File Offset: 0x0002EC60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 739346, RefRangeEnd = 739349, XrefRangeStart = 739341, XrefRangeEnd = 739346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Get(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxedPrimitives.NativeMethodInfoPtr_Get_Internal_Static_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00030AA0 File Offset: 0x0002ECA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 739354, RefRangeEnd = 739359, XrefRangeStart = 739349, XrefRangeEnd = 739354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Get(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxedPrimitives.NativeMethodInfoPtr_Get_Internal_Static_Object_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00030AE0 File Offset: 0x0002ECE0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 739368, RefRangeEnd = 739374, XrefRangeStart = 739359, XrefRangeEnd = 739368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Get(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxedPrimitives.NativeMethodInfoPtr_Get_Internal_Static_Object_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00030B20 File Offset: 0x0002ED20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 739379, RefRangeEnd = 739383, XrefRangeStart = 739374, XrefRangeEnd = 739379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Get(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxedPrimitives.NativeMethodInfoPtr_Get_Internal_Static_Object_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00003F0C File Offset: 0x0000210C
		public BoxedPrimitives(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00030B60 File Offset: 0x0002ED60
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x00003F15 File Offset: 0x00002115
		public unsafe static Object BooleanTrue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_BooleanTrue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_BooleanTrue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00030B88 File Offset: 0x0002ED88
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x00003F27 File Offset: 0x00002127
		public unsafe static Object BooleanFalse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_BooleanFalse, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_BooleanFalse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00030BB0 File Offset: 0x0002EDB0
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00003F39 File Offset: 0x00002139
		public unsafe static Object Int32_M1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_M1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_M1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00030BD8 File Offset: 0x0002EDD8
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00003F4B File Offset: 0x0000214B
		public unsafe static Object Int32_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00030C00 File Offset: 0x0002EE00
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00003F5D File Offset: 0x0000215D
		public unsafe static Object Int32_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00030C28 File Offset: 0x0002EE28
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00003F6F File Offset: 0x0000216F
		public unsafe static Object Int32_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00030C50 File Offset: 0x0002EE50
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00003F81 File Offset: 0x00002181
		public unsafe static Object Int32_3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00030C78 File Offset: 0x0002EE78
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00003F93 File Offset: 0x00002193
		public unsafe static Object Int32_4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00030CA0 File Offset: 0x0002EEA0
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00003FA5 File Offset: 0x000021A5
		public unsafe static Object Int32_5
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_5, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_5, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00030CC8 File Offset: 0x0002EEC8
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00003FB7 File Offset: 0x000021B7
		public unsafe static Object Int32_6
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_6, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_6, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00030CF0 File Offset: 0x0002EEF0
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00003FC9 File Offset: 0x000021C9
		public unsafe static Object Int32_7
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_7, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_7, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00030D18 File Offset: 0x0002EF18
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00003FDB File Offset: 0x000021DB
		public unsafe static Object Int32_8
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_8, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int32_8, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00030D40 File Offset: 0x0002EF40
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x00003FED File Offset: 0x000021ED
		public unsafe static Object Int64_M1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_M1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_M1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00030D68 File Offset: 0x0002EF68
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x00003FFF File Offset: 0x000021FF
		public unsafe static Object Int64_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00030D90 File Offset: 0x0002EF90
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x00004011 File Offset: 0x00002211
		public unsafe static Object Int64_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00030DB8 File Offset: 0x0002EFB8
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00004023 File Offset: 0x00002223
		public unsafe static Object Int64_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x00030DE0 File Offset: 0x0002EFE0
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00004035 File Offset: 0x00002235
		public unsafe static Object Int64_3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x00030E08 File Offset: 0x0002F008
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00004047 File Offset: 0x00002247
		public unsafe static Object Int64_4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x00030E30 File Offset: 0x0002F030
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x00004059 File Offset: 0x00002259
		public unsafe static Object Int64_5
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_5, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_5, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x00030E58 File Offset: 0x0002F058
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x0000406B File Offset: 0x0000226B
		public unsafe static Object Int64_6
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_6, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_6, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00030E80 File Offset: 0x0002F080
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x0000407D File Offset: 0x0000227D
		public unsafe static Object Int64_7
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_7, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_7, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00030EA8 File Offset: 0x0002F0A8
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x0000408F File Offset: 0x0000228F
		public unsafe static Object Int64_8
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_8, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_Int64_8, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00030ED0 File Offset: 0x0002F0D0
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x000040A1 File Offset: 0x000022A1
		public unsafe static Object DecimalZero
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_DecimalZero, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_DecimalZero, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00030EF8 File Offset: 0x0002F0F8
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x000040B3 File Offset: 0x000022B3
		public unsafe static Object DoubleNaN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_DoubleNaN, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_DoubleNaN, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00030F20 File Offset: 0x0002F120
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x000040C5 File Offset: 0x000022C5
		public unsafe static Object DoublePositiveInfinity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_DoublePositiveInfinity, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_DoublePositiveInfinity, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00030F48 File Offset: 0x0002F148
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x000040D7 File Offset: 0x000022D7
		public unsafe static Object DoubleNegativeInfinity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_DoubleNegativeInfinity, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_DoubleNegativeInfinity, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00030F70 File Offset: 0x0002F170
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x000040E9 File Offset: 0x000022E9
		public unsafe static Object DoubleZero
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxedPrimitives.NativeFieldInfoPtr_DoubleZero, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxedPrimitives.NativeFieldInfoPtr_DoubleZero, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeFieldInfoPtr_BooleanTrue;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeFieldInfoPtr_BooleanFalse;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeFieldInfoPtr_Int32_M1;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeFieldInfoPtr_Int32_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeFieldInfoPtr_Int32_1;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeFieldInfoPtr_Int32_2;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeFieldInfoPtr_Int32_3;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeFieldInfoPtr_Int32_4;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeFieldInfoPtr_Int32_5;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeFieldInfoPtr_Int32_6;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeFieldInfoPtr_Int32_7;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeFieldInfoPtr_Int32_8;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeFieldInfoPtr_Int64_M1;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeFieldInfoPtr_Int64_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeFieldInfoPtr_Int64_1;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeFieldInfoPtr_Int64_2;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeFieldInfoPtr_Int64_3;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeFieldInfoPtr_Int64_4;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeFieldInfoPtr_Int64_5;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeFieldInfoPtr_Int64_6;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeFieldInfoPtr_Int64_7;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeFieldInfoPtr_Int64_8;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeFieldInfoPtr_DecimalZero;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeFieldInfoPtr_DoubleNaN;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_DoublePositiveInfinity;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_DoubleNegativeInfinity;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_DoubleZero;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Static_Object_Boolean_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Static_Object_Int32_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Static_Object_Int64_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Static_Object_Decimal_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Static_Object_Double_0;
	}
}
