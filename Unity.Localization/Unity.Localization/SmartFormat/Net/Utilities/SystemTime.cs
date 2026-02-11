using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.SmartFormat.Net.Utilities
{
	// Token: 0x0200003B RID: 59
	public static class SystemTime : Object
	{
		// Token: 0x060003A9 RID: 937 RVA: 0x00017C04 File Offset: 0x00015E04
		// Note: this type is marked as 'beforefieldinit'.
		static SystemTime()
		{
			Il2CppClassPointerStore<SystemTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Net.Utilities", "SystemTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemTime>.NativeClassPtr);
			SystemTime.NativeFieldInfoPtr_Now = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTime>.NativeClassPtr, "Now");
			SystemTime.NativeFieldInfoPtr_OffsetNow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTime>.NativeClassPtr, "OffsetNow");
			SystemTime.NativeMethodInfoPtr_SetDateTime_Public_Static_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTime>.NativeClassPtr, 100663970);
			SystemTime.NativeMethodInfoPtr_SetDateTimeOffset_Public_Static_Void_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTime>.NativeClassPtr, 100663971);
			SystemTime.NativeMethodInfoPtr_ResetDateTime_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTime>.NativeClassPtr, 100663972);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00017C98 File Offset: 0x00015E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069647, XrefRangeEnd = 1069688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDateTime(DateTime dateTimeNow)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTimeNow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTime.NativeMethodInfoPtr_SetDateTime_Public_Static_Void_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00017CCC File Offset: 0x00015ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069688, XrefRangeEnd = 1069705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDateTimeOffset(DateTimeOffset dateTimeOffset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTimeOffset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTime.NativeMethodInfoPtr_SetDateTimeOffset_Public_Static_Void_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00017D00 File Offset: 0x00015F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069705, XrefRangeEnd = 1069745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetDateTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTime.NativeMethodInfoPtr_ResetDateTime_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00003409 File Offset: 0x00001609
		public SystemTime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00017D28 File Offset: 0x00015F28
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00003412 File Offset: 0x00001612
		public unsafe static Func<DateTime> Now
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SystemTime.NativeFieldInfoPtr_Now, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DateTime>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemTime.NativeFieldInfoPtr_Now, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00017D50 File Offset: 0x00015F50
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00003424 File Offset: 0x00001624
		public unsafe static Func<DateTimeOffset> OffsetNow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SystemTime.NativeFieldInfoPtr_OffsetNow, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DateTimeOffset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemTime.NativeFieldInfoPtr_OffsetNow, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeFieldInfoPtr_Now;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeFieldInfoPtr_OffsetNow;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_SetDateTime_Public_Static_Void_DateTime_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_SetDateTimeOffset_Public_Static_Void_DateTimeOffset_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_ResetDateTime_Public_Static_Void_0;

		// Token: 0x02000135 RID: 309
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Net.Utilities.SystemTime+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000D7C RID: 3452 RVA: 0x0003BBBC File Offset: 0x00039DBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SystemTime.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SystemTime>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemTime.__c>.NativeClassPtr);
				SystemTime.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTime.__c>.NativeClassPtr, "<>9");
				SystemTime.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTime.__c>.NativeClassPtr, "<>9__4_0");
				SystemTime.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTime.__c>.NativeClassPtr, "<>9__4_1");
				SystemTime.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTime.__c>.NativeClassPtr, 100663975);
				SystemTime.__c.NativeMethodInfoPtr__ResetDateTime_b__4_0_Internal_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTime.__c>.NativeClassPtr, 100663976);
				SystemTime.__c.NativeMethodInfoPtr__ResetDateTime_b__4_1_Internal_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTime.__c>.NativeClassPtr, 100663977);
				SystemTime.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTime.__c>.NativeClassPtr, 100663978);
				SystemTime.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTime.__c>.NativeClassPtr, 100663979);
			}

			// Token: 0x06000D7D RID: 3453 RVA: 0x0003BC88 File Offset: 0x00039E88
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemTime.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTime.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D7E RID: 3454 RVA: 0x0003BCC4 File Offset: 0x00039EC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069631, XrefRangeEnd = 1069635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DateTime _ResetDateTime_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTime.__c.NativeMethodInfoPtr__ResetDateTime_b__4_0_Internal_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D7F RID: 3455 RVA: 0x0003BD00 File Offset: 0x00039F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069635, XrefRangeEnd = 1069639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DateTimeOffset _ResetDateTime_b__4_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTime.__c.NativeMethodInfoPtr__ResetDateTime_b__4_1_Internal_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D80 RID: 3456 RVA: 0x0003BD3C File Offset: 0x00039F3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069639, XrefRangeEnd = 1069643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DateTime __cctor_b__5_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTime.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D81 RID: 3457 RVA: 0x0003BD78 File Offset: 0x00039F78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069643, XrefRangeEnd = 1069647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DateTimeOffset __cctor_b__5_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTime.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D82 RID: 3458 RVA: 0x000079DB File Offset: 0x00005BDB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700039B RID: 923
			// (get) Token: 0x06000D83 RID: 3459 RVA: 0x0003BDB4 File Offset: 0x00039FB4
			// (set) Token: 0x06000D84 RID: 3460 RVA: 0x000079E4 File Offset: 0x00005BE4
			public unsafe static SystemTime.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SystemTime.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SystemTime.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SystemTime.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700039C RID: 924
			// (get) Token: 0x06000D85 RID: 3461 RVA: 0x0003BDDC File Offset: 0x00039FDC
			// (set) Token: 0x06000D86 RID: 3462 RVA: 0x000079F6 File Offset: 0x00005BF6
			public unsafe static Func<DateTime> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SystemTime.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DateTime>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SystemTime.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700039D RID: 925
			// (get) Token: 0x06000D87 RID: 3463 RVA: 0x0003BE04 File Offset: 0x0003A004
			// (set) Token: 0x06000D88 RID: 3464 RVA: 0x00007A08 File Offset: 0x00005C08
			public unsafe static Func<DateTimeOffset> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SystemTime.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DateTimeOffset>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SystemTime.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400095D RID: 2397
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400095E RID: 2398
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400095F RID: 2399
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04000960 RID: 2400
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000961 RID: 2401
			private static readonly IntPtr NativeMethodInfoPtr__ResetDateTime_b__4_0_Internal_DateTime_0;

			// Token: 0x04000962 RID: 2402
			private static readonly IntPtr NativeMethodInfoPtr__ResetDateTime_b__4_1_Internal_DateTimeOffset_0;

			// Token: 0x04000963 RID: 2403
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_DateTime_0;

			// Token: 0x04000964 RID: 2404
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_1_Internal_DateTimeOffset_0;
		}

		// Token: 0x02000136 RID: 310
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Net.Utilities.SystemTime+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06000D89 RID: 3465 RVA: 0x0003BE2C File Offset: 0x0003A02C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<SystemTime.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SystemTime>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemTime.__c__DisplayClass1_0>.NativeClassPtr);
				SystemTime.__c__DisplayClass1_0.NativeFieldInfoPtr_dateTimeNow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTime.__c__DisplayClass1_0>.NativeClassPtr, "dateTimeNow");
				SystemTime.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTime.__c__DisplayClass1_0>.NativeClassPtr, 100663980);
				SystemTime.__c__DisplayClass1_0.NativeMethodInfoPtr__SetDateTime_b__0_Internal_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTime.__c__DisplayClass1_0>.NativeClassPtr, 100663981);
			}

			// Token: 0x06000D8A RID: 3466 RVA: 0x0003BE94 File Offset: 0x0003A094
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemTime.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTime.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D8B RID: 3467 RVA: 0x0003BED0 File Offset: 0x0003A0D0
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DateTime _SetDateTime_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTime.__c__DisplayClass1_0.NativeMethodInfoPtr__SetDateTime_b__0_Internal_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D8C RID: 3468 RVA: 0x00007A1A File Offset: 0x00005C1A
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700039E RID: 926
			// (get) Token: 0x06000D8D RID: 3469 RVA: 0x0003BF0C File Offset: 0x0003A10C
			// (set) Token: 0x06000D8E RID: 3470 RVA: 0x00007A23 File Offset: 0x00005C23
			public unsafe DateTime dateTimeNow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTime.__c__DisplayClass1_0.NativeFieldInfoPtr_dateTimeNow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTime.__c__DisplayClass1_0.NativeFieldInfoPtr_dateTimeNow)) = value;
				}
			}

			// Token: 0x04000965 RID: 2405
			private static readonly IntPtr NativeFieldInfoPtr_dateTimeNow;

			// Token: 0x04000966 RID: 2406
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000967 RID: 2407
			private static readonly IntPtr NativeMethodInfoPtr__SetDateTime_b__0_Internal_DateTime_0;
		}

		// Token: 0x02000137 RID: 311
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Net.Utilities.SystemTime+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06000D8F RID: 3471 RVA: 0x0003BF34 File Offset: 0x0003A134
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<SystemTime.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SystemTime>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemTime.__c__DisplayClass3_0>.NativeClassPtr);
				SystemTime.__c__DisplayClass3_0.NativeFieldInfoPtr_dateTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTime.__c__DisplayClass3_0>.NativeClassPtr, "dateTimeOffset");
				SystemTime.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTime.__c__DisplayClass3_0>.NativeClassPtr, 100663982);
				SystemTime.__c__DisplayClass3_0.NativeMethodInfoPtr__SetDateTimeOffset_b__0_Internal_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTime.__c__DisplayClass3_0>.NativeClassPtr, 100663983);
			}

			// Token: 0x06000D90 RID: 3472 RVA: 0x0003BF9C File Offset: 0x0003A19C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemTime.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTime.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D91 RID: 3473 RVA: 0x0003BFD8 File Offset: 0x0003A1D8
			[CallerCount(0)]
			public unsafe DateTimeOffset _SetDateTimeOffset_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTime.__c__DisplayClass3_0.NativeMethodInfoPtr__SetDateTimeOffset_b__0_Internal_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D92 RID: 3474 RVA: 0x00007A3E File Offset: 0x00005C3E
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700039F RID: 927
			// (get) Token: 0x06000D93 RID: 3475 RVA: 0x0003C014 File Offset: 0x0003A214
			// (set) Token: 0x06000D94 RID: 3476 RVA: 0x00007A47 File Offset: 0x00005C47
			public unsafe DateTimeOffset dateTimeOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTime.__c__DisplayClass3_0.NativeFieldInfoPtr_dateTimeOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTime.__c__DisplayClass3_0.NativeFieldInfoPtr_dateTimeOffset)) = value;
				}
			}

			// Token: 0x04000968 RID: 2408
			private static readonly IntPtr NativeFieldInfoPtr_dateTimeOffset;

			// Token: 0x04000969 RID: 2409
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400096A RID: 2410
			private static readonly IntPtr NativeMethodInfoPtr__SetDateTimeOffset_b__0_Internal_DateTimeOffset_0;
		}
	}
}
