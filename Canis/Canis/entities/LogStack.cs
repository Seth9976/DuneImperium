using System;
using Canis.gameLogs;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000EC RID: 236
	public class LogStack : LogHolder
	{
		// Token: 0x06000A73 RID: 2675 RVA: 0x00045E00 File Offset: 0x00044000
		// Note: this type is marked as 'beforefieldinit'.
		static LogStack()
		{
			Il2CppClassPointerStore<LogStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "LogStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogStack>.NativeClassPtr);
			LogStack.NativeMethodInfoPtr__ctor_Public_Void_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack>.NativeClassPtr, 100665514);
			LogStack.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack>.NativeClassPtr, 100665515);
			LogStack.NativeMethodInfoPtr_get_CurrentGameLogID_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack>.NativeClassPtr, 100665516);
			LogStack.NativeMethodInfoPtr_get_CurrentGameLog_Public_get_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack>.NativeClassPtr, 100665517);
			LogStack.NativeMethodInfoPtr_get_CurrentGameLogParent_Public_get_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack>.NativeClassPtr, 100665518);
			LogStack.NativeMethodInfoPtr_get_CurrentLogStack_Public_get_IEnumerable_1_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack>.NativeClassPtr, 100665519);
			LogStack.NativeMethodInfoPtr_FindGameLogAncestors_Private_IEnumerable_1_Int32_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack>.NativeClassPtr, 100665520);
			LogStack.NativeMethodInfoPtr_UpsertGameLog_Public_Virtual_Void_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack>.NativeClassPtr, 100665521);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00045ED0 File Offset: 0x000440D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 566281, RefRangeEnd = 566282, XrefRangeStart = 566254, XrefRangeEnd = 566281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogStack(Match m, string entityName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogStack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entityName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.NativeMethodInfoPtr__ctor_Public_Void_Match_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00045F30 File Offset: 0x00044130
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 553228, RefRangeEnd = 553234, XrefRangeStart = 553228, XrefRangeEnd = 553234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogStack(SerializedEntity se, Match match, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogStack>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00045FA0 File Offset: 0x000441A0
		public unsafe Nullable<int> CurrentGameLogID
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 566304, RefRangeEnd = 566308, XrefRangeStart = 566282, XrefRangeEnd = 566304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.NativeMethodInfoPtr_get_CurrentGameLogID_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00045FD8 File Offset: 0x000441D8
		public unsafe SerializedGameLog CurrentGameLog
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 566347, RefRangeEnd = 566350, XrefRangeStart = 566308, XrefRangeEnd = 566347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.NativeMethodInfoPtr_get_CurrentGameLog_Public_get_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00046018 File Offset: 0x00044218
		public unsafe SerializedGameLog CurrentGameLogParent
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 566361, RefRangeEnd = 566364, XrefRangeStart = 566350, XrefRangeEnd = 566361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.NativeMethodInfoPtr_get_CurrentGameLogParent_Public_get_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00046058 File Offset: 0x00044258
		public unsafe IEnumerable<SerializedGameLog> CurrentLogStack
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 566370, RefRangeEnd = 566371, XrefRangeStart = 566364, XrefRangeEnd = 566370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.NativeMethodInfoPtr_get_CurrentLogStack_Public_get_IEnumerable_1_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SerializedGameLog>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00046098 File Offset: 0x00044298
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 566378, RefRangeEnd = 566380, XrefRangeStart = 566371, XrefRangeEnd = 566378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<int> FindGameLogAncestors(SerializedGameLog log)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.NativeMethodInfoPtr_FindGameLogAncestors_Private_IEnumerable_1_Int32_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x000460E8 File Offset: 0x000442E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566380, XrefRangeEnd = 566392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpsertGameLog(SerializedGameLog log)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LogStack.NativeMethodInfoPtr_UpsertGameLog_Public_Virtual_Void_SerializedGameLog_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00005D65 File Offset: 0x00003F65
		public LogStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_String_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGameLogID_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGameLog_Public_get_SerializedGameLog_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGameLogParent_Public_get_SerializedGameLog_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLogStack_Public_get_IEnumerable_1_SerializedGameLog_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_FindGameLogAncestors_Private_IEnumerable_1_Int32_SerializedGameLog_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_UpsertGameLog_Public_Virtual_Void_SerializedGameLog_0;

		// Token: 0x0200032B RID: 811
		[ObfuscatedName("Canis.entities.LogStack+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x060021B0 RID: 8624 RVA: 0x00098B88 File Offset: 0x00096D88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<LogStack.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogStack>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogStack.__c__DisplayClass10_0>.NativeClassPtr);
				LogStack.__c__DisplayClass10_0.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack.__c__DisplayClass10_0>.NativeClassPtr, "parent");
				LogStack.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack.__c__DisplayClass10_0>.NativeClassPtr, 100665522);
				LogStack.__c__DisplayClass10_0.NativeMethodInfoPtr__FindGameLogAncestors_b__0_Internal_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack.__c__DisplayClass10_0>.NativeClassPtr, 100665523);
			}

			// Token: 0x060021B1 RID: 8625 RVA: 0x00098BF0 File Offset: 0x00096DF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogStack.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021B2 RID: 8626 RVA: 0x00098C2C File Offset: 0x00096E2C
			[CallerCount(0)]
			public unsafe bool _FindGameLogAncestors_b__0(SerializedGameLog _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.__c__DisplayClass10_0.NativeMethodInfoPtr__FindGameLogAncestors_b__0_Internal_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021B3 RID: 8627 RVA: 0x0001029B File Offset: 0x0000E49B
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700081F RID: 2079
			// (get) Token: 0x060021B4 RID: 8628 RVA: 0x00098C7C File Offset: 0x00096E7C
			// (set) Token: 0x060021B5 RID: 8629 RVA: 0x000102A4 File Offset: 0x0000E4A4
			public unsafe int parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack.__c__DisplayClass10_0.NativeFieldInfoPtr_parent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack.__c__DisplayClass10_0.NativeFieldInfoPtr_parent)) = value;
				}
			}

			// Token: 0x04001531 RID: 5425
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x04001532 RID: 5426
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001533 RID: 5427
			private static readonly IntPtr NativeMethodInfoPtr__FindGameLogAncestors_b__0_Internal_Boolean_SerializedGameLog_0;
		}

		// Token: 0x0200032C RID: 812
		[ObfuscatedName("Canis.entities.LogStack+<>c__DisplayClass5_0")]
		public new sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x060021B6 RID: 8630 RVA: 0x00098CA4 File Offset: 0x00096EA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<LogStack.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogStack>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogStack.__c__DisplayClass5_0>.NativeClassPtr);
				LogStack.__c__DisplayClass5_0.NativeFieldInfoPtr_logID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack.__c__DisplayClass5_0>.NativeClassPtr, "logID");
				LogStack.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack.__c__DisplayClass5_0>.NativeClassPtr, 100665524);
				LogStack.__c__DisplayClass5_0.NativeMethodInfoPtr__get_CurrentGameLog_b__0_Internal_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack.__c__DisplayClass5_0>.NativeClassPtr, 100665525);
			}

			// Token: 0x060021B7 RID: 8631 RVA: 0x00098D0C File Offset: 0x00096F0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogStack.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021B8 RID: 8632 RVA: 0x00098D48 File Offset: 0x00096F48
			[CallerCount(0)]
			public unsafe bool _get_CurrentGameLog_b__0(SerializedGameLog _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.__c__DisplayClass5_0.NativeMethodInfoPtr__get_CurrentGameLog_b__0_Internal_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021B9 RID: 8633 RVA: 0x000102BF File Offset: 0x0000E4BF
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000820 RID: 2080
			// (get) Token: 0x060021BA RID: 8634 RVA: 0x00098D98 File Offset: 0x00096F98
			// (set) Token: 0x060021BB RID: 8635 RVA: 0x000102C8 File Offset: 0x0000E4C8
			public unsafe int logID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack.__c__DisplayClass5_0.NativeFieldInfoPtr_logID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack.__c__DisplayClass5_0.NativeFieldInfoPtr_logID)) = value;
				}
			}

			// Token: 0x04001534 RID: 5428
			private static readonly IntPtr NativeFieldInfoPtr_logID;

			// Token: 0x04001535 RID: 5429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001536 RID: 5430
			private static readonly IntPtr NativeMethodInfoPtr__get_CurrentGameLog_b__0_Internal_Boolean_SerializedGameLog_0;
		}

		// Token: 0x0200032D RID: 813
		[ObfuscatedName("Canis.entities.LogStack+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x060021BC RID: 8636 RVA: 0x00098DC0 File Offset: 0x00096FC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<LogStack.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogStack>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogStack.__c__DisplayClass7_0>.NativeClassPtr);
				LogStack.__c__DisplayClass7_0.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack.__c__DisplayClass7_0>.NativeClassPtr, "parent");
				LogStack.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack.__c__DisplayClass7_0>.NativeClassPtr, 100665526);
				LogStack.__c__DisplayClass7_0.NativeMethodInfoPtr__get_CurrentGameLogParent_b__0_Internal_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack.__c__DisplayClass7_0>.NativeClassPtr, 100665527);
			}

			// Token: 0x060021BD RID: 8637 RVA: 0x00098E28 File Offset: 0x00097028
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogStack.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021BE RID: 8638 RVA: 0x00098E64 File Offset: 0x00097064
			[CallerCount(0)]
			public unsafe bool _get_CurrentGameLogParent_b__0(SerializedGameLog _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.__c__DisplayClass7_0.NativeMethodInfoPtr__get_CurrentGameLogParent_b__0_Internal_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021BF RID: 8639 RVA: 0x000102E3 File Offset: 0x0000E4E3
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000821 RID: 2081
			// (get) Token: 0x060021C0 RID: 8640 RVA: 0x00098EB4 File Offset: 0x000970B4
			// (set) Token: 0x060021C1 RID: 8641 RVA: 0x000102EC File Offset: 0x0000E4EC
			public unsafe int parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack.__c__DisplayClass7_0.NativeFieldInfoPtr_parent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack.__c__DisplayClass7_0.NativeFieldInfoPtr_parent)) = value;
				}
			}

			// Token: 0x04001537 RID: 5431
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x04001538 RID: 5432
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001539 RID: 5433
			private static readonly IntPtr NativeMethodInfoPtr__get_CurrentGameLogParent_b__0_Internal_Boolean_SerializedGameLog_0;
		}

		// Token: 0x0200032E RID: 814
		[ObfuscatedName("Canis.entities.LogStack+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x060021C2 RID: 8642 RVA: 0x00098EDC File Offset: 0x000970DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<LogStack.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogStack>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogStack.__c__DisplayClass9_0>.NativeClassPtr);
				LogStack.__c__DisplayClass9_0.NativeFieldInfoPtr_logID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack.__c__DisplayClass9_0>.NativeClassPtr, "logID");
				LogStack.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack.__c__DisplayClass9_0>.NativeClassPtr, 100665528);
				LogStack.__c__DisplayClass9_0.NativeMethodInfoPtr__get_CurrentLogStack_b__0_Internal_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack.__c__DisplayClass9_0>.NativeClassPtr, 100665529);
			}

			// Token: 0x060021C3 RID: 8643 RVA: 0x00098F44 File Offset: 0x00097144
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogStack.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021C4 RID: 8644 RVA: 0x00098F80 File Offset: 0x00097180
			[CallerCount(0)]
			public unsafe bool _get_CurrentLogStack_b__0(SerializedGameLog _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack.__c__DisplayClass9_0.NativeMethodInfoPtr__get_CurrentLogStack_b__0_Internal_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021C5 RID: 8645 RVA: 0x00010307 File Offset: 0x0000E507
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000822 RID: 2082
			// (get) Token: 0x060021C6 RID: 8646 RVA: 0x00098FD0 File Offset: 0x000971D0
			// (set) Token: 0x060021C7 RID: 8647 RVA: 0x00010310 File Offset: 0x0000E510
			public unsafe int logID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack.__c__DisplayClass9_0.NativeFieldInfoPtr_logID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack.__c__DisplayClass9_0.NativeFieldInfoPtr_logID)) = value;
				}
			}

			// Token: 0x0400153A RID: 5434
			private static readonly IntPtr NativeFieldInfoPtr_logID;

			// Token: 0x0400153B RID: 5435
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400153C RID: 5436
			private static readonly IntPtr NativeMethodInfoPtr__get_CurrentLogStack_b__0_Internal_Boolean_SerializedGameLog_0;
		}

		// Token: 0x0200032F RID: 815
		[ObfuscatedName("Canis.entities.LogStack+<FindGameLogAncestors>d__10")]
		public sealed class _FindGameLogAncestors_d__10 : Object
		{
			// Token: 0x060021C8 RID: 8648 RVA: 0x00098FF8 File Offset: 0x000971F8
			// Note: this type is marked as 'beforefieldinit'.
			static _FindGameLogAncestors_d__10()
			{
				Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogStack>.NativeClassPtr, "<FindGameLogAncestors>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr);
				LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, "<>1__state");
				LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, "<>2__current");
				LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, "<>l__initialThreadId");
				LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr_log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, "log");
				LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___3__log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, "<>3__log");
				LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, "<>8__1");
				LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, "<>4__this");
				LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, "<>7__wrap1");
				LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, 100665530);
				LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, 100665531);
				LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, 100665532);
				LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, 100665533);
				LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, 100665534);
				LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, 100665535);
				LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, 100665536);
				LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, 100665537);
				LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr, 100665538);
			}

			// Token: 0x060021C9 RID: 8649 RVA: 0x00099178 File Offset: 0x00097378
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 286249, RefRangeEnd = 286258, XrefRangeStart = 286249, XrefRangeEnd = 286258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FindGameLogAncestors_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogStack._FindGameLogAncestors_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021CA RID: 8650 RVA: 0x000991C0 File Offset: 0x000973C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566131, XrefRangeEnd = 566136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021CB RID: 8651 RVA: 0x000991F4 File Offset: 0x000973F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566136, XrefRangeEnd = 566173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060021CC RID: 8652 RVA: 0x00099230 File Offset: 0x00097430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566173, XrefRangeEnd = 566176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700082B RID: 2091
			// (get) Token: 0x060021CD RID: 8653 RVA: 0x00099264 File Offset: 0x00097464
			public unsafe int System.Collections.Generic.IEnumerator<System.Int32>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021CE RID: 8654 RVA: 0x000992A0 File Offset: 0x000974A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566176, XrefRangeEnd = 566181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700082C RID: 2092
			// (get) Token: 0x060021CF RID: 8655 RVA: 0x000992D4 File Offset: 0x000974D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566181, XrefRangeEnd = 566184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060021D0 RID: 8656 RVA: 0x00099314 File Offset: 0x00097514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566184, XrefRangeEnd = 566193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<int> System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<int>>(intPtr3) : null;
			}

			// Token: 0x060021D1 RID: 8657 RVA: 0x00099354 File Offset: 0x00097554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._FindGameLogAncestors_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060021D2 RID: 8658 RVA: 0x0001032B File Offset: 0x0000E52B
			public _FindGameLogAncestors_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000823 RID: 2083
			// (get) Token: 0x060021D3 RID: 8659 RVA: 0x00099394 File Offset: 0x00097594
			// (set) Token: 0x060021D4 RID: 8660 RVA: 0x00010334 File Offset: 0x0000E534
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000824 RID: 2084
			// (get) Token: 0x060021D5 RID: 8661 RVA: 0x000993BC File Offset: 0x000975BC
			// (set) Token: 0x060021D6 RID: 8662 RVA: 0x0001034F File Offset: 0x0000E54F
			public unsafe int __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x17000825 RID: 2085
			// (get) Token: 0x060021D7 RID: 8663 RVA: 0x000993E4 File Offset: 0x000975E4
			// (set) Token: 0x060021D8 RID: 8664 RVA: 0x0001036A File Offset: 0x0000E56A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000826 RID: 2086
			// (get) Token: 0x060021D9 RID: 8665 RVA: 0x0009940C File Offset: 0x0009760C
			// (set) Token: 0x060021DA RID: 8666 RVA: 0x00010385 File Offset: 0x0000E585
			public unsafe SerializedGameLog log
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr_log);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr_log), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000827 RID: 2087
			// (get) Token: 0x060021DB RID: 8667 RVA: 0x0009943C File Offset: 0x0009763C
			// (set) Token: 0x060021DC RID: 8668 RVA: 0x000103A4 File Offset: 0x0000E5A4
			public unsafe SerializedGameLog __3__log
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___3__log);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___3__log), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000828 RID: 2088
			// (get) Token: 0x060021DD RID: 8669 RVA: 0x0009946C File Offset: 0x0009766C
			// (set) Token: 0x060021DE RID: 8670 RVA: 0x000103C3 File Offset: 0x0000E5C3
			public unsafe LogStack.__c__DisplayClass10_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogStack.__c__DisplayClass10_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000829 RID: 2089
			// (get) Token: 0x060021DF RID: 8671 RVA: 0x0009949C File Offset: 0x0009769C
			// (set) Token: 0x060021E0 RID: 8672 RVA: 0x000103E2 File Offset: 0x0000E5E2
			public unsafe LogStack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogStack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700082A RID: 2090
			// (get) Token: 0x060021E1 RID: 8673 RVA: 0x000994CC File Offset: 0x000976CC
			// (set) Token: 0x060021E2 RID: 8674 RVA: 0x00010401 File Offset: 0x0000E601
			public unsafe IEnumerator<int> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._FindGameLogAncestors_d__10.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400153D RID: 5437
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400153E RID: 5438
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400153F RID: 5439
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001540 RID: 5440
			private static readonly IntPtr NativeFieldInfoPtr_log;

			// Token: 0x04001541 RID: 5441
			private static readonly IntPtr NativeFieldInfoPtr___3__log;

			// Token: 0x04001542 RID: 5442
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001543 RID: 5443
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001544 RID: 5444
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001545 RID: 5445
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001546 RID: 5446
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001547 RID: 5447
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001548 RID: 5448
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001549 RID: 5449
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x0400154A RID: 5450
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400154B RID: 5451
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400154C RID: 5452
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0;

			// Token: 0x0400154D RID: 5453
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000330 RID: 816
		[ObfuscatedName("Canis.entities.LogStack+<get_CurrentLogStack>d__9")]
		public sealed class _get_CurrentLogStack_d__9 : Object
		{
			// Token: 0x060021E3 RID: 8675 RVA: 0x000994FC File Offset: 0x000976FC
			// Note: this type is marked as 'beforefieldinit'.
			static _get_CurrentLogStack_d__9()
			{
				Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogStack>.NativeClassPtr, "<get_CurrentLogStack>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr);
				LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr, "<>1__state");
				LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr, "<>2__current");
				LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr, "<>l__initialThreadId");
				LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr, "<>4__this");
				LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr, "<>7__wrap1");
				LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr, 100665539);
				LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr, 100665540);
				LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr, 100665541);
				LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr, 100665542);
				LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_gameLogs_SerializedGameLog__get_Current_Private_Virtual_Final_New_get_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr, 100665543);
				LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr, 100665544);
				LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr, 100665545);
				LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_gameLogs_SerializedGameLog__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr, 100665546);
				LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr, 100665547);
			}

			// Token: 0x060021E4 RID: 8676 RVA: 0x00099640 File Offset: 0x00097840
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_CurrentLogStack_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogStack._get_CurrentLogStack_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021E5 RID: 8677 RVA: 0x00099688 File Offset: 0x00097888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566193, XrefRangeEnd = 566198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021E6 RID: 8678 RVA: 0x000996BC File Offset: 0x000978BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566198, XrefRangeEnd = 566244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060021E7 RID: 8679 RVA: 0x000996F8 File Offset: 0x000978F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566244, XrefRangeEnd = 566247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000832 RID: 2098
			// (get) Token: 0x060021E8 RID: 8680 RVA: 0x0009972C File Offset: 0x0009792C
			public unsafe SerializedGameLog System.Collections.Generic.IEnumerator<Canis.gameLogs.SerializedGameLog>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_gameLogs_SerializedGameLog__get_Current_Private_Virtual_Final_New_get_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
				}
			}

			// Token: 0x060021E9 RID: 8681 RVA: 0x0009976C File Offset: 0x0009796C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566247, XrefRangeEnd = 566252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000833 RID: 2099
			// (get) Token: 0x060021EA RID: 8682 RVA: 0x000997A0 File Offset: 0x000979A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060021EB RID: 8683 RVA: 0x000997E0 File Offset: 0x000979E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566252, XrefRangeEnd = 566254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<SerializedGameLog> System_Collections_Generic_IEnumerable_Canis_gameLogs_SerializedGameLog__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_gameLogs_SerializedGameLog__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<SerializedGameLog>>(intPtr3) : null;
			}

			// Token: 0x060021EC RID: 8684 RVA: 0x00099820 File Offset: 0x00097A20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogStack._get_CurrentLogStack_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060021ED RID: 8685 RVA: 0x00010420 File Offset: 0x0000E620
			public _get_CurrentLogStack_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700082D RID: 2093
			// (get) Token: 0x060021EE RID: 8686 RVA: 0x00099860 File Offset: 0x00097A60
			// (set) Token: 0x060021EF RID: 8687 RVA: 0x00010429 File Offset: 0x0000E629
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700082E RID: 2094
			// (get) Token: 0x060021F0 RID: 8688 RVA: 0x00099888 File Offset: 0x00097A88
			// (set) Token: 0x060021F1 RID: 8689 RVA: 0x00010444 File Offset: 0x0000E644
			public unsafe SerializedGameLog __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700082F RID: 2095
			// (get) Token: 0x060021F2 RID: 8690 RVA: 0x000998B8 File Offset: 0x00097AB8
			// (set) Token: 0x060021F3 RID: 8691 RVA: 0x00010463 File Offset: 0x0000E663
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000830 RID: 2096
			// (get) Token: 0x060021F4 RID: 8692 RVA: 0x000998E0 File Offset: 0x00097AE0
			// (set) Token: 0x060021F5 RID: 8693 RVA: 0x0001047E File Offset: 0x0000E67E
			public unsafe LogStack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogStack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000831 RID: 2097
			// (get) Token: 0x060021F6 RID: 8694 RVA: 0x00099910 File Offset: 0x00097B10
			// (set) Token: 0x060021F7 RID: 8695 RVA: 0x0001049D File Offset: 0x0000E69D
			public List<int>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___7__wrap1);
					return new List<int>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<int>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogStack._get_CurrentLogStack_d__9.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<int>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400154E RID: 5454
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400154F RID: 5455
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001550 RID: 5456
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001551 RID: 5457
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001552 RID: 5458
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001553 RID: 5459
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001554 RID: 5460
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001555 RID: 5461
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001556 RID: 5462
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001557 RID: 5463
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_gameLogs_SerializedGameLog__get_Current_Private_Virtual_Final_New_get_SerializedGameLog_0;

			// Token: 0x04001558 RID: 5464
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001559 RID: 5465
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400155A RID: 5466
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_gameLogs_SerializedGameLog__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SerializedGameLog_0;

			// Token: 0x0400155B RID: 5467
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
