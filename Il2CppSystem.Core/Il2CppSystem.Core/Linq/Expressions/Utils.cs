using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200008B RID: 139
	public static class Utils : Object
	{
		// Token: 0x0600076D RID: 1901 RVA: 0x00032C3C File Offset: 0x00030E3C
		// Note: this type is marked as 'beforefieldinit'.
		static Utils()
		{
			Il2CppClassPointerStore<Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Utils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utils>.NativeClassPtr);
			Utils.NativeFieldInfoPtr_BoxedFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedFalse");
			Utils.NativeFieldInfoPtr_BoxedTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedTrue");
			Utils.NativeFieldInfoPtr_BoxedIntM1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedIntM1");
			Utils.NativeFieldInfoPtr_BoxedInt0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedInt0");
			Utils.NativeFieldInfoPtr_BoxedInt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedInt1");
			Utils.NativeFieldInfoPtr_BoxedInt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedInt2");
			Utils.NativeFieldInfoPtr_BoxedInt3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedInt3");
			Utils.NativeFieldInfoPtr_BoxedDefaultSByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedDefaultSByte");
			Utils.NativeFieldInfoPtr_BoxedDefaultChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedDefaultChar");
			Utils.NativeFieldInfoPtr_BoxedDefaultInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedDefaultInt16");
			Utils.NativeFieldInfoPtr_BoxedDefaultInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedDefaultInt64");
			Utils.NativeFieldInfoPtr_BoxedDefaultByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedDefaultByte");
			Utils.NativeFieldInfoPtr_BoxedDefaultUInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedDefaultUInt16");
			Utils.NativeFieldInfoPtr_BoxedDefaultUInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedDefaultUInt32");
			Utils.NativeFieldInfoPtr_BoxedDefaultUInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedDefaultUInt64");
			Utils.NativeFieldInfoPtr_BoxedDefaultSingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedDefaultSingle");
			Utils.NativeFieldInfoPtr_BoxedDefaultDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedDefaultDouble");
			Utils.NativeFieldInfoPtr_BoxedDefaultDecimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedDefaultDecimal");
			Utils.NativeFieldInfoPtr_BoxedDefaultDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "BoxedDefaultDateTime");
			Utils.NativeFieldInfoPtr_s_true = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "s_true");
			Utils.NativeFieldInfoPtr_s_false = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "s_false");
			Utils.NativeFieldInfoPtr_s_m1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "s_m1");
			Utils.NativeFieldInfoPtr_s_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "s_0");
			Utils.NativeFieldInfoPtr_s_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "s_1");
			Utils.NativeFieldInfoPtr_s_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "s_2");
			Utils.NativeFieldInfoPtr_s_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "s_3");
			Utils.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "Empty");
			Utils.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "Null");
			Utils.NativeMethodInfoPtr_Constant_Public_Static_ConstantExpression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664781);
			Utils.NativeMethodInfoPtr_Constant_Public_Static_ConstantExpression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664782);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00032EC4 File Offset: 0x000310C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1015420, RefRangeEnd = 1015423, XrefRangeStart = 1015416, XrefRangeEnd = 1015420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConstantExpression Constant(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Constant_Public_Static_ConstantExpression_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstantExpression>(intPtr3) : null;
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00032F04 File Offset: 0x00031104
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1015431, RefRangeEnd = 1015436, XrefRangeStart = 1015423, XrefRangeEnd = 1015431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConstantExpression Constant(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Constant_Public_Static_ConstantExpression_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstantExpression>(intPtr3) : null;
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00003DB2 File Offset: 0x00001FB2
		public Utils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00032F44 File Offset: 0x00031144
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x00003DBB File Offset: 0x00001FBB
		public unsafe static Object BoxedFalse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedFalse, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedFalse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00032F6C File Offset: 0x0003116C
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x00003DCD File Offset: 0x00001FCD
		public unsafe static Object BoxedTrue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedTrue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedTrue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x00032F94 File Offset: 0x00031194
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x00003DDF File Offset: 0x00001FDF
		public unsafe static Object BoxedIntM1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedIntM1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedIntM1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x00032FBC File Offset: 0x000311BC
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x00003DF1 File Offset: 0x00001FF1
		public unsafe static Object BoxedInt0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedInt0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedInt0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x00032FE4 File Offset: 0x000311E4
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x00003E03 File Offset: 0x00002003
		public unsafe static Object BoxedInt1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedInt1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedInt1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x0003300C File Offset: 0x0003120C
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x00003E15 File Offset: 0x00002015
		public unsafe static Object BoxedInt2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedInt2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedInt2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x00033034 File Offset: 0x00031234
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x00003E27 File Offset: 0x00002027
		public unsafe static Object BoxedInt3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedInt3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedInt3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x0003305C File Offset: 0x0003125C
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x00003E39 File Offset: 0x00002039
		public unsafe static Object BoxedDefaultSByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedDefaultSByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedDefaultSByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00033084 File Offset: 0x00031284
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00003E4B File Offset: 0x0000204B
		public unsafe static Object BoxedDefaultChar
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedDefaultChar, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedDefaultChar, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x000330AC File Offset: 0x000312AC
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x00003E5D File Offset: 0x0000205D
		public unsafe static Object BoxedDefaultInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedDefaultInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedDefaultInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x000330D4 File Offset: 0x000312D4
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x00003E6F File Offset: 0x0000206F
		public unsafe static Object BoxedDefaultInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedDefaultInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedDefaultInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x000330FC File Offset: 0x000312FC
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00003E81 File Offset: 0x00002081
		public unsafe static Object BoxedDefaultByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedDefaultByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedDefaultByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00033124 File Offset: 0x00031324
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x00003E93 File Offset: 0x00002093
		public unsafe static Object BoxedDefaultUInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedDefaultUInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedDefaultUInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x0003314C File Offset: 0x0003134C
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x00003EA5 File Offset: 0x000020A5
		public unsafe static Object BoxedDefaultUInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedDefaultUInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedDefaultUInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x00033174 File Offset: 0x00031374
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x00003EB7 File Offset: 0x000020B7
		public unsafe static Object BoxedDefaultUInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedDefaultUInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedDefaultUInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x0003319C File Offset: 0x0003139C
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x00003EC9 File Offset: 0x000020C9
		public unsafe static Object BoxedDefaultSingle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedDefaultSingle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedDefaultSingle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x000331C4 File Offset: 0x000313C4
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x00003EDB File Offset: 0x000020DB
		public unsafe static Object BoxedDefaultDouble
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedDefaultDouble, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedDefaultDouble, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x000331EC File Offset: 0x000313EC
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00003EED File Offset: 0x000020ED
		public unsafe static Object BoxedDefaultDecimal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedDefaultDecimal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedDefaultDecimal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00033214 File Offset: 0x00031414
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x00003EFF File Offset: 0x000020FF
		public unsafe static Object BoxedDefaultDateTime
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_BoxedDefaultDateTime, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_BoxedDefaultDateTime, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x0003323C File Offset: 0x0003143C
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x00003F11 File Offset: 0x00002111
		public unsafe static ConstantExpression s_true
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_s_true, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstantExpression>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_s_true, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00033264 File Offset: 0x00031464
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x00003F23 File Offset: 0x00002123
		public unsafe static ConstantExpression s_false
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_s_false, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstantExpression>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_s_false, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0003328C File Offset: 0x0003148C
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x00003F35 File Offset: 0x00002135
		public unsafe static ConstantExpression s_m1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_s_m1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstantExpression>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_s_m1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x000332B4 File Offset: 0x000314B4
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x00003F47 File Offset: 0x00002147
		public unsafe static ConstantExpression s_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_s_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstantExpression>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_s_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x000332DC File Offset: 0x000314DC
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00003F59 File Offset: 0x00002159
		public unsafe static ConstantExpression s_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_s_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstantExpression>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_s_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00033304 File Offset: 0x00031504
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00003F6B File Offset: 0x0000216B
		public unsafe static ConstantExpression s_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_s_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstantExpression>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_s_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0003332C File Offset: 0x0003152C
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00003F7D File Offset: 0x0000217D
		public unsafe static ConstantExpression s_3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_s_3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstantExpression>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_s_3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x00033354 File Offset: 0x00031554
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00003F8F File Offset: 0x0000218F
		public unsafe static DefaultExpression Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultExpression>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0003337C File Offset: 0x0003157C
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00003FA1 File Offset: 0x000021A1
		public unsafe static ConstantExpression Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstantExpression>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeFieldInfoPtr_BoxedFalse;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeFieldInfoPtr_BoxedTrue;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeFieldInfoPtr_BoxedIntM1;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeFieldInfoPtr_BoxedInt0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeFieldInfoPtr_BoxedInt1;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeFieldInfoPtr_BoxedInt2;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeFieldInfoPtr_BoxedInt3;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeFieldInfoPtr_BoxedDefaultSByte;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeFieldInfoPtr_BoxedDefaultChar;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeFieldInfoPtr_BoxedDefaultInt16;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeFieldInfoPtr_BoxedDefaultInt64;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeFieldInfoPtr_BoxedDefaultByte;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeFieldInfoPtr_BoxedDefaultUInt16;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeFieldInfoPtr_BoxedDefaultUInt32;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr_BoxedDefaultUInt64;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeFieldInfoPtr_BoxedDefaultSingle;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeFieldInfoPtr_BoxedDefaultDouble;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeFieldInfoPtr_BoxedDefaultDecimal;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeFieldInfoPtr_BoxedDefaultDateTime;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeFieldInfoPtr_s_true;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeFieldInfoPtr_s_false;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeFieldInfoPtr_s_m1;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeFieldInfoPtr_s_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeFieldInfoPtr_s_1;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeFieldInfoPtr_s_2;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeFieldInfoPtr_s_3;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_Constant_Public_Static_ConstantExpression_Boolean_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_Constant_Public_Static_ConstantExpression_Int32_0;
	}
}
