using System;
using Canis.gameLogs;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000EB RID: 235
	public class LogHolder : Entity
	{
		// Token: 0x06000A6B RID: 2667 RVA: 0x00045BF0 File Offset: 0x00043DF0
		// Note: this type is marked as 'beforefieldinit'.
		static LogHolder()
		{
			Il2CppClassPointerStore<LogHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "LogHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogHolder>.NativeClassPtr);
			LogHolder.NativeFieldInfoPtr_SOFT_LOG_CAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogHolder>.NativeClassPtr, "SOFT_LOG_CAP");
			LogHolder.NativeMethodInfoPtr__ctor_Public_Void_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHolder>.NativeClassPtr, 100665506);
			LogHolder.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHolder>.NativeClassPtr, 100665507);
			LogHolder.NativeMethodInfoPtr_get_StoredGameLogs_Public_get_IEnumerable_1_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHolder>.NativeClassPtr, 100665508);
			LogHolder.NativeMethodInfoPtr_UpsertGameLog_Public_Virtual_New_Void_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHolder>.NativeClassPtr, 100665509);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00045C84 File Offset: 0x00043E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566017, XrefRangeEnd = 566031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogHolder(Match m, string entityName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entityName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogHolder.NativeMethodInfoPtr__ctor_Public_Void_Match_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00045CE4 File Offset: 0x00043EE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 553228, RefRangeEnd = 553234, XrefRangeStart = 553228, XrefRangeEnd = 553234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogHolder(SerializedEntity se, Match match, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogHolder.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00045D54 File Offset: 0x00043F54
		public unsafe IEnumerable<SerializedGameLog> StoredGameLogs
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 566044, RefRangeEnd = 566050, XrefRangeStart = 566031, XrefRangeEnd = 566044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogHolder.NativeMethodInfoPtr_get_StoredGameLogs_Public_get_IEnumerable_1_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SerializedGameLog>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00045D94 File Offset: 0x00043F94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 566130, RefRangeEnd = 566131, XrefRangeStart = 566050, XrefRangeEnd = 566130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpsertGameLog(SerializedGameLog log)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LogHolder.NativeMethodInfoPtr_UpsertGameLog_Public_Virtual_New_Void_SerializedGameLog_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00005D4E File Offset: 0x00003F4E
		public LogHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00045DE4 File Offset: 0x00043FE4
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x00005D57 File Offset: 0x00003F57
		public unsafe static int SOFT_LOG_CAP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LogHolder.NativeFieldInfoPtr_SOFT_LOG_CAP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LogHolder.NativeFieldInfoPtr_SOFT_LOG_CAP, (void*)(&value));
			}
		}

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_SOFT_LOG_CAP;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_String_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredGameLogs_Public_get_IEnumerable_1_SerializedGameLog_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_UpsertGameLog_Public_Virtual_New_Void_SerializedGameLog_0;

		// Token: 0x02000329 RID: 809
		[ObfuscatedName("Canis.entities.LogHolder+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x060021A4 RID: 8612 RVA: 0x00098940 File Offset: 0x00096B40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<LogHolder.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogHolder>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogHolder.__c__DisplayClass5_0>.NativeClassPtr);
				LogHolder.__c__DisplayClass5_0.NativeFieldInfoPtr_log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogHolder.__c__DisplayClass5_0>.NativeClassPtr, "log");
				LogHolder.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHolder.__c__DisplayClass5_0>.NativeClassPtr, 100665510);
				LogHolder.__c__DisplayClass5_0.NativeMethodInfoPtr__UpsertGameLog_b__0_Internal_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHolder.__c__DisplayClass5_0>.NativeClassPtr, 100665511);
			}

			// Token: 0x060021A5 RID: 8613 RVA: 0x000989A8 File Offset: 0x00096BA8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogHolder.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogHolder.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021A6 RID: 8614 RVA: 0x000989E4 File Offset: 0x00096BE4
			[CallerCount(0)]
			public unsafe bool _UpsertGameLog_b__0(SerializedGameLog _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogHolder.__c__DisplayClass5_0.NativeMethodInfoPtr__UpsertGameLog_b__0_Internal_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021A7 RID: 8615 RVA: 0x0001024B File Offset: 0x0000E44B
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700081D RID: 2077
			// (get) Token: 0x060021A8 RID: 8616 RVA: 0x00098A34 File Offset: 0x00096C34
			// (set) Token: 0x060021A9 RID: 8617 RVA: 0x00010254 File Offset: 0x0000E454
			public unsafe SerializedGameLog log
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogHolder.__c__DisplayClass5_0.NativeFieldInfoPtr_log);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogHolder.__c__DisplayClass5_0.NativeFieldInfoPtr_log), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400152B RID: 5419
			private static readonly IntPtr NativeFieldInfoPtr_log;

			// Token: 0x0400152C RID: 5420
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400152D RID: 5421
			private static readonly IntPtr NativeMethodInfoPtr__UpsertGameLog_b__0_Internal_Boolean_SerializedGameLog_0;
		}

		// Token: 0x0200032A RID: 810
		[ObfuscatedName("Canis.entities.LogHolder+<>c__DisplayClass5_1")]
		public sealed class __c__DisplayClass5_1 : Object
		{
			// Token: 0x060021AA RID: 8618 RVA: 0x00098A64 File Offset: 0x00096C64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_1()
			{
				Il2CppClassPointerStore<LogHolder.__c__DisplayClass5_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogHolder>.NativeClassPtr, "<>c__DisplayClass5_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogHolder.__c__DisplayClass5_1>.NativeClassPtr);
				LogHolder.__c__DisplayClass5_1.NativeFieldInfoPtr_keepCandidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogHolder.__c__DisplayClass5_1>.NativeClassPtr, "keepCandidate");
				LogHolder.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHolder.__c__DisplayClass5_1>.NativeClassPtr, 100665512);
				LogHolder.__c__DisplayClass5_1.NativeMethodInfoPtr__UpsertGameLog_b__1_Internal_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHolder.__c__DisplayClass5_1>.NativeClassPtr, 100665513);
			}

			// Token: 0x060021AB RID: 8619 RVA: 0x00098ACC File Offset: 0x00096CCC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogHolder.__c__DisplayClass5_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogHolder.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021AC RID: 8620 RVA: 0x00098B08 File Offset: 0x00096D08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566015, XrefRangeEnd = 566017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpsertGameLog_b__1(SerializedGameLog _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogHolder.__c__DisplayClass5_1.NativeMethodInfoPtr__UpsertGameLog_b__1_Internal_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021AD RID: 8621 RVA: 0x00010273 File Offset: 0x0000E473
			public __c__DisplayClass5_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700081E RID: 2078
			// (get) Token: 0x060021AE RID: 8622 RVA: 0x00098B58 File Offset: 0x00096D58
			// (set) Token: 0x060021AF RID: 8623 RVA: 0x0001027C File Offset: 0x0000E47C
			public unsafe SerializedGameLog keepCandidate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogHolder.__c__DisplayClass5_1.NativeFieldInfoPtr_keepCandidate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogHolder.__c__DisplayClass5_1.NativeFieldInfoPtr_keepCandidate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400152E RID: 5422
			private static readonly IntPtr NativeFieldInfoPtr_keepCandidate;

			// Token: 0x0400152F RID: 5423
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001530 RID: 5424
			private static readonly IntPtr NativeMethodInfoPtr__UpsertGameLog_b__1_Internal_Boolean_SerializedGameLog_0;
		}
	}
}
