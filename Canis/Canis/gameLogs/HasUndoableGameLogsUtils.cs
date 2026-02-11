using System;
using Canis.actions;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.gameLogs
{
	// Token: 0x020000AA RID: 170
	public static class HasUndoableGameLogsUtils : Object
	{
		// Token: 0x06000805 RID: 2053 RVA: 0x0000526D File Offset: 0x0000346D
		// Note: this type is marked as 'beforefieldinit'.
		static HasUndoableGameLogsUtils()
		{
			Il2CppClassPointerStore<HasUndoableGameLogsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "HasUndoableGameLogsUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasUndoableGameLogsUtils>.NativeClassPtr);
			HasUndoableGameLogsUtils.NativeMethodInfoPtr_UndoGameLogs_Public_Static_IEnumerable_1_Action_TMatchWithGameLogsAndUndos_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUndoableGameLogsUtils>.NativeClassPtr, 100664932);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00039D18 File Offset: 0x00037F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 559082, RefRangeEnd = 559083, XrefRangeStart = 559076, XrefRangeEnd = 559082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Canis.actions.Action> UndoGameLogs<TMatchWithGameLogsAndUndos>(this TMatchWithGameLogsAndUndos mwglau, UndoNode undoNode) where TMatchWithGameLogsAndUndos : Match
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TMatchWithGameLogsAndUndos).IsValueType)
				{
					TMatchWithGameLogsAndUndos tmatchWithGameLogsAndUndos = mwglau;
					intPtr = ((tmatchWithGameLogsAndUndos is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatchWithGameLogsAndUndos as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatchWithGameLogsAndUndos as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref mwglau;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoNode);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HasUndoableGameLogsUtils.MethodInfoStoreGeneric_UndoGameLogs_Public_Static_IEnumerable_1_Action_TMatchWithGameLogsAndUndos_UndoNode_0<TMatchWithGameLogsAndUndos>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr4) : null;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000052A6 File Offset: 0x000034A6
		public HasUndoableGameLogsUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_UndoGameLogs_Public_Static_IEnumerable_1_Action_TMatchWithGameLogsAndUndos_UndoNode_0;

		// Token: 0x020002E5 RID: 741
		[ObfuscatedName("Canis.gameLogs.HasUndoableGameLogsUtils+<>c__0`1")]
		[Serializable]
		public sealed class __c__0<TMatchWithGameLogsAndUndos> : Object where TMatchWithGameLogsAndUndos : Match
		{
			// Token: 0x06001EE6 RID: 7910 RVA: 0x0008EE78 File Offset: 0x0008D078
			// Note: this type is marked as 'beforefieldinit'.
			static __c__0()
			{
				Il2CppClassPointerStore<HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasUndoableGameLogsUtils>.NativeClassPtr, "<>c__0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatchWithGameLogsAndUndos>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr);
				HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, "<>9");
				HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, "<>9__0_0");
				HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, 100664934);
				HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr__UndoGameLogs_b__0_0_Internal_SerializedGameLog_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, 100664935);
			}

			// Token: 0x06001EE7 RID: 7911 RVA: 0x0008EF30 File Offset: 0x0008D130
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EE8 RID: 7912 RVA: 0x0008EF6C File Offset: 0x0008D16C
			[CallerCount(0)]
			public unsafe SerializedGameLog _UndoGameLogs_b__0_0(SerializedGameLog cancelLog)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cancelLog);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr__UndoGameLogs_b__0_0_Internal_SerializedGameLog_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
				}
			}

			// Token: 0x06001EE9 RID: 7913 RVA: 0x0000EDED File Offset: 0x0000CFED
			public __c__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700073D RID: 1853
			// (get) Token: 0x06001EEA RID: 7914 RVA: 0x0008EFBC File Offset: 0x0008D1BC
			// (set) Token: 0x06001EEB RID: 7915 RVA: 0x0000EDF6 File Offset: 0x0000CFF6
			public unsafe static HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073E RID: 1854
			// (get) Token: 0x06001EEC RID: 7916 RVA: 0x0008EFE4 File Offset: 0x0008D1E4
			// (set) Token: 0x06001EED RID: 7917 RVA: 0x0000EE08 File Offset: 0x0000D008
			public unsafe static Func<SerializedGameLog, SerializedGameLog> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedGameLog, SerializedGameLog>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUndoableGameLogsUtils.__c__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001383 RID: 4995
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001384 RID: 4996
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04001385 RID: 4997
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001386 RID: 4998
			private static readonly IntPtr NativeMethodInfoPtr__UndoGameLogs_b__0_0_Internal_SerializedGameLog_SerializedGameLog_0;
		}

		// Token: 0x020002E6 RID: 742
		[ObfuscatedName("Canis.gameLogs.HasUndoableGameLogsUtils+<UndoGameLogs>d__0`1")]
		public sealed class _UndoGameLogs_d__0<TMatchWithGameLogsAndUndos> : Object where TMatchWithGameLogsAndUndos : Match
		{
			// Token: 0x06001EEE RID: 7918 RVA: 0x0008F00C File Offset: 0x0008D20C
			// Note: this type is marked as 'beforefieldinit'.
			static _UndoGameLogs_d__0()
			{
				Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasUndoableGameLogsUtils>.NativeClassPtr, "<UndoGameLogs>d__0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatchWithGameLogsAndUndos>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr);
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, "<>1__state");
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, "<>2__current");
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, "<>l__initialThreadId");
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr_undoNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, "undoNode");
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___3__undoNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, "<>3__undoNode");
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr_mwglau = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, "mwglau");
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___3__mwglau = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, "<>3__mwglau");
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, "<>7__wrap1");
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, 100664936);
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, 100664937);
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, 100664938);
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, 100664939);
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, 100664940);
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, 100664941);
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, 100664942);
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, 100664943);
				HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr, 100664944);
			}

			// Token: 0x06001EEF RID: 7919 RVA: 0x0008F1C8 File Offset: 0x0008D3C8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UndoGameLogs_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EF0 RID: 7920 RVA: 0x0008F210 File Offset: 0x0008D410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558969, XrefRangeEnd = 558974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EF1 RID: 7921 RVA: 0x0008F244 File Offset: 0x0008D444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558974, XrefRangeEnd = 559020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001EF2 RID: 7922 RVA: 0x0008F280 File Offset: 0x0008D480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559020, XrefRangeEnd = 559060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000747 RID: 1863
			// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x0008F2B4 File Offset: 0x0008D4B4
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001EF4 RID: 7924 RVA: 0x0008F2F4 File Offset: 0x0008D4F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000748 RID: 1864
			// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x0008F328 File Offset: 0x0008D528
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001EF6 RID: 7926 RVA: 0x0008F368 File Offset: 0x0008D568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559060, XrefRangeEnd = 559068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001EF7 RID: 7927 RVA: 0x0008F3A8 File Offset: 0x0008D5A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559068, XrefRangeEnd = 559076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001EF8 RID: 7928 RVA: 0x0000EE1A File Offset: 0x0000D01A
			public _UndoGameLogs_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700073F RID: 1855
			// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x0008F3E8 File Offset: 0x0008D5E8
			// (set) Token: 0x06001EFA RID: 7930 RVA: 0x0000EE23 File Offset: 0x0000D023
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x06001EFB RID: 7931 RVA: 0x0008F410 File Offset: 0x0008D610
			// (set) Token: 0x06001EFC RID: 7932 RVA: 0x0000EE3E File Offset: 0x0000D03E
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000741 RID: 1857
			// (get) Token: 0x06001EFD RID: 7933 RVA: 0x0008F440 File Offset: 0x0008D640
			// (set) Token: 0x06001EFE RID: 7934 RVA: 0x0000EE5D File Offset: 0x0000D05D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000742 RID: 1858
			// (get) Token: 0x06001EFF RID: 7935 RVA: 0x0008F468 File Offset: 0x0008D668
			// (set) Token: 0x06001F00 RID: 7936 RVA: 0x0000EE78 File Offset: 0x0000D078
			public unsafe UndoNode undoNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr_undoNode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr_undoNode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000743 RID: 1859
			// (get) Token: 0x06001F01 RID: 7937 RVA: 0x0008F498 File Offset: 0x0008D698
			// (set) Token: 0x06001F02 RID: 7938 RVA: 0x0000EE97 File Offset: 0x0000D097
			public unsafe UndoNode __3__undoNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___3__undoNode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___3__undoNode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000744 RID: 1860
			// (get) Token: 0x06001F03 RID: 7939 RVA: 0x0008F4C8 File Offset: 0x0008D6C8
			// (set) Token: 0x06001F04 RID: 7940 RVA: 0x0008F4F0 File Offset: 0x0008D6F0
			public unsafe TMatchWithGameLogsAndUndos mwglau
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr_mwglau);
					return IL2CPP.PointerToValueGeneric<TMatchWithGameLogsAndUndos>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr_mwglau);
					Type typeFromHandle = typeof(TMatchWithGameLogsAndUndos);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x06001F05 RID: 7941 RVA: 0x0008F598 File Offset: 0x0008D798
			// (set) Token: 0x06001F06 RID: 7942 RVA: 0x0008F5C0 File Offset: 0x0008D7C0
			public unsafe TMatchWithGameLogsAndUndos __3__mwglau
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___3__mwglau);
					return IL2CPP.PointerToValueGeneric<TMatchWithGameLogsAndUndos>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___3__mwglau);
					Type typeFromHandle = typeof(TMatchWithGameLogsAndUndos);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x06001F07 RID: 7943 RVA: 0x0008F668 File Offset: 0x0008D868
			// (set) Token: 0x06001F08 RID: 7944 RVA: 0x0000EEB6 File Offset: 0x0000D0B6
			public List<int>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___7__wrap1);
					return new List<int>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<int>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUndoableGameLogsUtils._UndoGameLogs_d__0<TMatchWithGameLogsAndUndos>.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<int>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001387 RID: 4999
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001388 RID: 5000
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001389 RID: 5001
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400138A RID: 5002
			private static readonly IntPtr NativeFieldInfoPtr_undoNode;

			// Token: 0x0400138B RID: 5003
			private static readonly IntPtr NativeFieldInfoPtr___3__undoNode;

			// Token: 0x0400138C RID: 5004
			private static readonly IntPtr NativeFieldInfoPtr_mwglau;

			// Token: 0x0400138D RID: 5005
			private static readonly IntPtr NativeFieldInfoPtr___3__mwglau;

			// Token: 0x0400138E RID: 5006
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400138F RID: 5007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001390 RID: 5008
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001391 RID: 5009
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001392 RID: 5010
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001393 RID: 5011
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001394 RID: 5012
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001395 RID: 5013
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001396 RID: 5014
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001397 RID: 5015
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020002E7 RID: 743
		private sealed class MethodInfoStoreGeneric_UndoGameLogs_Public_Static_IEnumerable_1_Action_TMatchWithGameLogsAndUndos_UndoNode_0<TMatchWithGameLogsAndUndos>
		{
			// Token: 0x04001398 RID: 5016
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HasUndoableGameLogsUtils.NativeMethodInfoPtr_UndoGameLogs_Public_Static_IEnumerable_1_Action_TMatchWithGameLogsAndUndos_UndoNode_0, Il2CppClassPointerStore<HasUndoableGameLogsUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatchWithGameLogsAndUndos>.NativeClassPtr)) }))));
		}
	}
}
