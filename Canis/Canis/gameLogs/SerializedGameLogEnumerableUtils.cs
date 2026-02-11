using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.gameLogs
{
	// Token: 0x020000AC RID: 172
	public static class SerializedGameLogEnumerableUtils : Object
	{
		// Token: 0x06000816 RID: 2070 RVA: 0x00039FC0 File Offset: 0x000381C0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGameLogEnumerableUtils()
		{
			Il2CppClassPointerStore<SerializedGameLogEnumerableUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "SerializedGameLogEnumerableUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils>.NativeClassPtr);
			SerializedGameLogEnumerableUtils.NativeMethodInfoPtr_NextLogID_Public_Static_Int32_IEnumerable_1_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils>.NativeClassPtr, 100664947);
			SerializedGameLogEnumerableUtils.NativeMethodInfoPtr_GetChildren_Public_Static_IEnumerable_1_SerializedGameLog_IEnumerable_1_SerializedGameLog_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils>.NativeClassPtr, 100664948);
			SerializedGameLogEnumerableUtils.NativeMethodInfoPtr_GetChildren_Public_Static_IEnumerable_1_SerializedGameLog_IEnumerable_1_SerializedGameLog_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils>.NativeClassPtr, 100664949);
			SerializedGameLogEnumerableUtils.NativeMethodInfoPtr_GetAncestors_Public_Static_IEnumerable_1_SerializedGameLog_IReadOnlyList_1_SerializedGameLog_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils>.NativeClassPtr, 100664950);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0003A040 File Offset: 0x00038240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 559200, RefRangeEnd = 559201, XrefRangeStart = 559162, XrefRangeEnd = 559200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NextLogID(this IEnumerable<SerializedGameLog> storedGameLogs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storedGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils.NativeMethodInfoPtr_NextLogID_Public_Static_Int32_IEnumerable_1_SerializedGameLog_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0003A084 File Offset: 0x00038284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559201, XrefRangeEnd = 559215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<SerializedGameLog> GetChildren(this IEnumerable<SerializedGameLog> storedGameLogs, int parent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storedGameLogs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils.NativeMethodInfoPtr_GetChildren_Public_Static_IEnumerable_1_SerializedGameLog_IEnumerable_1_SerializedGameLog_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SerializedGameLog>>(intPtr3) : null;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0003A0D8 File Offset: 0x000382D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559215, XrefRangeEnd = 559229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<SerializedGameLog> GetChildren(this IEnumerable<SerializedGameLog> storedGameLogs, SerializedGameLog parent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storedGameLogs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils.NativeMethodInfoPtr_GetChildren_Public_Static_IEnumerable_1_SerializedGameLog_IEnumerable_1_SerializedGameLog_SerializedGameLog_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SerializedGameLog>>(intPtr3) : null;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0003A130 File Offset: 0x00038330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559229, XrefRangeEnd = 559236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<SerializedGameLog> GetAncestors(this IReadOnlyList<SerializedGameLog> storedGameLogs, SerializedGameLog log)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storedGameLogs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(log);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils.NativeMethodInfoPtr_GetAncestors_Public_Static_IEnumerable_1_SerializedGameLog_IReadOnlyList_1_SerializedGameLog_SerializedGameLog_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SerializedGameLog>>(intPtr3) : null;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0000535A File Offset: 0x0000355A
		public SerializedGameLogEnumerableUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_NextLogID_Public_Static_Int32_IEnumerable_1_SerializedGameLog_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_GetChildren_Public_Static_IEnumerable_1_SerializedGameLog_IEnumerable_1_SerializedGameLog_Int32_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_GetChildren_Public_Static_IEnumerable_1_SerializedGameLog_IEnumerable_1_SerializedGameLog_SerializedGameLog_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_GetAncestors_Public_Static_IEnumerable_1_SerializedGameLog_IReadOnlyList_1_SerializedGameLog_SerializedGameLog_0;

		// Token: 0x020002E8 RID: 744
		[ObfuscatedName("Canis.gameLogs.SerializedGameLogEnumerableUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001F0A RID: 7946 RVA: 0x0008F6EC File Offset: 0x0008D8EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c>.NativeClassPtr);
				SerializedGameLogEnumerableUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c>.NativeClassPtr, "<>9");
				SerializedGameLogEnumerableUtils.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c>.NativeClassPtr, "<>9__0_0");
				SerializedGameLogEnumerableUtils.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c>.NativeClassPtr, "<>9__0_1");
				SerializedGameLogEnumerableUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c>.NativeClassPtr, 100664952);
				SerializedGameLogEnumerableUtils.__c.NativeMethodInfoPtr__NextLogID_b__0_0_Internal_Int32_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c>.NativeClassPtr, 100664953);
				SerializedGameLogEnumerableUtils.__c.NativeMethodInfoPtr__NextLogID_b__0_1_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c>.NativeClassPtr, 100664954);
			}

			// Token: 0x06001F0B RID: 7947 RVA: 0x0008F790 File Offset: 0x0008D990
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F0C RID: 7948 RVA: 0x0008F7CC File Offset: 0x0008D9CC
			[CallerCount(0)]
			public unsafe int _NextLogID_b__0_0(SerializedGameLog sgl)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sgl);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils.__c.NativeMethodInfoPtr__NextLogID_b__0_0_Internal_Int32_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F0D RID: 7949 RVA: 0x0008F81C File Offset: 0x0008DA1C
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _NextLogID_b__0_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils.__c.NativeMethodInfoPtr__NextLogID_b__0_1_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001F0E RID: 7950 RVA: 0x0000EEE4 File Offset: 0x0000D0E4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000749 RID: 1865
			// (get) Token: 0x06001F0F RID: 7951 RVA: 0x0008F858 File Offset: 0x0008DA58
			// (set) Token: 0x06001F10 RID: 7952 RVA: 0x0000EEED File Offset: 0x0000D0ED
			public unsafe static SerializedGameLogEnumerableUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SerializedGameLogEnumerableUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLogEnumerableUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SerializedGameLogEnumerableUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700074A RID: 1866
			// (get) Token: 0x06001F11 RID: 7953 RVA: 0x0008F880 File Offset: 0x0008DA80
			// (set) Token: 0x06001F12 RID: 7954 RVA: 0x0000EEFF File Offset: 0x0000D0FF
			public unsafe static Func<SerializedGameLog, int> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SerializedGameLogEnumerableUtils.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedGameLog, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SerializedGameLogEnumerableUtils.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x06001F13 RID: 7955 RVA: 0x0008F8A8 File Offset: 0x0008DAA8
			// (set) Token: 0x06001F14 RID: 7956 RVA: 0x0000EF11 File Offset: 0x0000D111
			public unsafe static Func<int> __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SerializedGameLogEnumerableUtils.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SerializedGameLogEnumerableUtils.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001399 RID: 5017
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400139A RID: 5018
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x0400139B RID: 5019
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x0400139C RID: 5020
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400139D RID: 5021
			private static readonly IntPtr NativeMethodInfoPtr__NextLogID_b__0_0_Internal_Int32_SerializedGameLog_0;

			// Token: 0x0400139E RID: 5022
			private static readonly IntPtr NativeMethodInfoPtr__NextLogID_b__0_1_Internal_Int32_0;
		}

		// Token: 0x020002E9 RID: 745
		[ObfuscatedName("Canis.gameLogs.SerializedGameLogEnumerableUtils+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06001F15 RID: 7957 RVA: 0x0008F8D0 File Offset: 0x0008DAD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c__DisplayClass1_0>.NativeClassPtr);
				SerializedGameLogEnumerableUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c__DisplayClass1_0>.NativeClassPtr, "parent");
				SerializedGameLogEnumerableUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c__DisplayClass1_0>.NativeClassPtr, 100664955);
				SerializedGameLogEnumerableUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__GetChildren_b__0_Internal_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c__DisplayClass1_0>.NativeClassPtr, 100664956);
			}

			// Token: 0x06001F16 RID: 7958 RVA: 0x0008F938 File Offset: 0x0008DB38
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F17 RID: 7959 RVA: 0x0008F974 File Offset: 0x0008DB74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559090, XrefRangeEnd = 559092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetChildren_b__0(SerializedGameLog _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__GetChildren_b__0_Internal_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F18 RID: 7960 RVA: 0x0000EF23 File Offset: 0x0000D123
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700074C RID: 1868
			// (get) Token: 0x06001F19 RID: 7961 RVA: 0x0008F9C4 File Offset: 0x0008DBC4
			// (set) Token: 0x06001F1A RID: 7962 RVA: 0x0000EF2C File Offset: 0x0000D12C
			public unsafe int parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_parent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_parent)) = value;
				}
			}

			// Token: 0x0400139F RID: 5023
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x040013A0 RID: 5024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013A1 RID: 5025
			private static readonly IntPtr NativeMethodInfoPtr__GetChildren_b__0_Internal_Boolean_SerializedGameLog_0;
		}

		// Token: 0x020002EA RID: 746
		[ObfuscatedName("Canis.gameLogs.SerializedGameLogEnumerableUtils+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06001F1B RID: 7963 RVA: 0x0008F9EC File Offset: 0x0008DBEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c__DisplayClass3_0>.NativeClassPtr);
				SerializedGameLogEnumerableUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c__DisplayClass3_0>.NativeClassPtr, "log");
				SerializedGameLogEnumerableUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c__DisplayClass3_0>.NativeClassPtr, 100664957);
				SerializedGameLogEnumerableUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__GetAncestors_b__0_Internal_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c__DisplayClass3_0>.NativeClassPtr, 100664958);
			}

			// Token: 0x06001F1C RID: 7964 RVA: 0x0008FA54 File Offset: 0x0008DC54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F1D RID: 7965 RVA: 0x0008FA90 File Offset: 0x0008DC90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559092, XrefRangeEnd = 559094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAncestors_b__0(SerializedGameLog _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__GetAncestors_b__0_Internal_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F1E RID: 7966 RVA: 0x0000EF47 File Offset: 0x0000D147
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700074D RID: 1869
			// (get) Token: 0x06001F1F RID: 7967 RVA: 0x0008FAE0 File Offset: 0x0008DCE0
			// (set) Token: 0x06001F20 RID: 7968 RVA: 0x0000EF50 File Offset: 0x0000D150
			public unsafe SerializedGameLog log
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_log);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_log), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013A2 RID: 5026
			private static readonly IntPtr NativeFieldInfoPtr_log;

			// Token: 0x040013A3 RID: 5027
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013A4 RID: 5028
			private static readonly IntPtr NativeMethodInfoPtr__GetAncestors_b__0_Internal_Boolean_SerializedGameLog_0;
		}

		// Token: 0x020002EB RID: 747
		[ObfuscatedName("Canis.gameLogs.SerializedGameLogEnumerableUtils+<GetAncestors>d__3")]
		public sealed class _GetAncestors_d__3 : Object
		{
			// Token: 0x06001F21 RID: 7969 RVA: 0x0008FB10 File Offset: 0x0008DD10
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAncestors_d__3()
			{
				Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils>.NativeClassPtr, "<GetAncestors>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr);
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, "<>1__state");
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, "<>2__current");
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, "<>l__initialThreadId");
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr_log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, "log");
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___3__log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, "<>3__log");
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr_storedGameLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, "storedGameLogs");
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___3__storedGameLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, "<>3__storedGameLogs");
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr__parent_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, "<parent>5__2");
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, "<>7__wrap2");
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, 100664959);
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, 100664960);
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, 100664961);
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, 100664962);
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_gameLogs_SerializedGameLog__get_Current_Private_Virtual_Final_New_get_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, 100664963);
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, 100664964);
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, 100664965);
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_gameLogs_SerializedGameLog__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, 100664966);
				SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr, 100664967);
			}

			// Token: 0x06001F22 RID: 7970 RVA: 0x0008FCA4 File Offset: 0x0008DEA4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetAncestors_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGameLogEnumerableUtils._GetAncestors_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F23 RID: 7971 RVA: 0x0008FCEC File Offset: 0x0008DEEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559094, XrefRangeEnd = 559099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F24 RID: 7972 RVA: 0x0008FD20 File Offset: 0x0008DF20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559099, XrefRangeEnd = 559145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001F25 RID: 7973 RVA: 0x0008FD5C File Offset: 0x0008DF5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559145, XrefRangeEnd = 559148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000757 RID: 1879
			// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0008FD90 File Offset: 0x0008DF90
			public unsafe SerializedGameLog System.Collections.Generic.IEnumerator<Canis.gameLogs.SerializedGameLog>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_gameLogs_SerializedGameLog__get_Current_Private_Virtual_Final_New_get_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
				}
			}

			// Token: 0x06001F27 RID: 7975 RVA: 0x0008FDD0 File Offset: 0x0008DFD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559148, XrefRangeEnd = 559153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x06001F28 RID: 7976 RVA: 0x0008FE04 File Offset: 0x0008E004
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F29 RID: 7977 RVA: 0x0008FE44 File Offset: 0x0008E044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559153, XrefRangeEnd = 559162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<SerializedGameLog> System_Collections_Generic_IEnumerable_Canis_gameLogs_SerializedGameLog__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_gameLogs_SerializedGameLog__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<SerializedGameLog>>(intPtr3) : null;
			}

			// Token: 0x06001F2A RID: 7978 RVA: 0x0008FE84 File Offset: 0x0008E084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001F2B RID: 7979 RVA: 0x0000EF6F File Offset: 0x0000D16F
			public _GetAncestors_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700074E RID: 1870
			// (get) Token: 0x06001F2C RID: 7980 RVA: 0x0008FEC4 File Offset: 0x0008E0C4
			// (set) Token: 0x06001F2D RID: 7981 RVA: 0x0000EF78 File Offset: 0x0000D178
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700074F RID: 1871
			// (get) Token: 0x06001F2E RID: 7982 RVA: 0x0008FEEC File Offset: 0x0008E0EC
			// (set) Token: 0x06001F2F RID: 7983 RVA: 0x0000EF93 File Offset: 0x0000D193
			public unsafe SerializedGameLog __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000750 RID: 1872
			// (get) Token: 0x06001F30 RID: 7984 RVA: 0x0008FF1C File Offset: 0x0008E11C
			// (set) Token: 0x06001F31 RID: 7985 RVA: 0x0000EFB2 File Offset: 0x0000D1B2
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000751 RID: 1873
			// (get) Token: 0x06001F32 RID: 7986 RVA: 0x0008FF44 File Offset: 0x0008E144
			// (set) Token: 0x06001F33 RID: 7987 RVA: 0x0000EFCD File Offset: 0x0000D1CD
			public unsafe SerializedGameLog log
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr_log);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr_log), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000752 RID: 1874
			// (get) Token: 0x06001F34 RID: 7988 RVA: 0x0008FF74 File Offset: 0x0008E174
			// (set) Token: 0x06001F35 RID: 7989 RVA: 0x0000EFEC File Offset: 0x0000D1EC
			public unsafe SerializedGameLog __3__log
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___3__log);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___3__log), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000753 RID: 1875
			// (get) Token: 0x06001F36 RID: 7990 RVA: 0x0008FFA4 File Offset: 0x0008E1A4
			// (set) Token: 0x06001F37 RID: 7991 RVA: 0x0000F00B File Offset: 0x0000D20B
			public unsafe IReadOnlyList<SerializedGameLog> storedGameLogs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr_storedGameLogs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SerializedGameLog>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr_storedGameLogs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000754 RID: 1876
			// (get) Token: 0x06001F38 RID: 7992 RVA: 0x0008FFD4 File Offset: 0x0008E1D4
			// (set) Token: 0x06001F39 RID: 7993 RVA: 0x0000F02A File Offset: 0x0000D22A
			public unsafe IReadOnlyList<SerializedGameLog> __3__storedGameLogs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___3__storedGameLogs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SerializedGameLog>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___3__storedGameLogs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000755 RID: 1877
			// (get) Token: 0x06001F3A RID: 7994 RVA: 0x00090004 File Offset: 0x0008E204
			// (set) Token: 0x06001F3B RID: 7995 RVA: 0x0000F049 File Offset: 0x0000D249
			public unsafe SerializedGameLog _parent_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr__parent_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr__parent_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x06001F3C RID: 7996 RVA: 0x00090034 File Offset: 0x0008E234
			// (set) Token: 0x06001F3D RID: 7997 RVA: 0x0000F068 File Offset: 0x0000D268
			public unsafe IEnumerator<SerializedGameLog> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<SerializedGameLog>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLogEnumerableUtils._GetAncestors_d__3.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013A5 RID: 5029
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040013A6 RID: 5030
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040013A7 RID: 5031
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040013A8 RID: 5032
			private static readonly IntPtr NativeFieldInfoPtr_log;

			// Token: 0x040013A9 RID: 5033
			private static readonly IntPtr NativeFieldInfoPtr___3__log;

			// Token: 0x040013AA RID: 5034
			private static readonly IntPtr NativeFieldInfoPtr_storedGameLogs;

			// Token: 0x040013AB RID: 5035
			private static readonly IntPtr NativeFieldInfoPtr___3__storedGameLogs;

			// Token: 0x040013AC RID: 5036
			private static readonly IntPtr NativeFieldInfoPtr__parent_5__2;

			// Token: 0x040013AD RID: 5037
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040013AE RID: 5038
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040013AF RID: 5039
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013B0 RID: 5040
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040013B1 RID: 5041
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040013B2 RID: 5042
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_gameLogs_SerializedGameLog__get_Current_Private_Virtual_Final_New_get_SerializedGameLog_0;

			// Token: 0x040013B3 RID: 5043
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013B4 RID: 5044
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040013B5 RID: 5045
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_gameLogs_SerializedGameLog__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SerializedGameLog_0;

			// Token: 0x040013B6 RID: 5046
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
