using System;
using Canis;
using dbgclient.menus.commands;
using dwd.core;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dbgclient.dataProviders
{
	// Token: 0x020000C2 RID: 194
	public class DailyChallengeProvider<T> : DailyChallengeProvider where T : MatchInitData
	{
		// Token: 0x060007E3 RID: 2019 RVA: 0x00036324 File Offset: 0x00034524
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeProvider()
		{
			Il2CppClassPointerStore<DailyChallengeProvider<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataProviders", "DailyChallengeProvider`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeProvider<T>>.NativeClassPtr);
			DailyChallengeProvider<T>.NativeFieldInfoPtr__MatchInitData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider<T>>.NativeClassPtr, "<MatchInitData>k__BackingField");
			DailyChallengeProvider<T>.NativeMethodInfoPtr_get_MatchInitData_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider<T>>.NativeClassPtr, 100664470);
			DailyChallengeProvider<T>.NativeMethodInfoPtr_set_MatchInitData_Private_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider<T>>.NativeClassPtr, 100664471);
			DailyChallengeProvider<T>.NativeMethodInfoPtr_RequestInfo_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider<T>>.NativeClassPtr, 100664472);
			DailyChallengeProvider<T>.NativeMethodInfoPtr_GetPromptData_Public_Virtual_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider<T>>.NativeClassPtr, 100664473);
			DailyChallengeProvider<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider<T>>.NativeClassPtr, 100664474);
			DailyChallengeProvider<T>.NativeMethodInfoPtr__RequestInfo_b__4_0_Private_Void_RequestDailyChallengeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider<T>>.NativeClassPtr, 100664475);
			DailyChallengeProvider<T>.NativeMethodInfoPtr__RequestInfo_b__4_1_Private_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider<T>>.NativeClassPtr, 100664476);
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00036430 File Offset: 0x00034630
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x0003646C File Offset: 0x0003466C
		public unsafe T MatchInitData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider<T>.NativeMethodInfoPtr_get_MatchInitData_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider<T>.NativeMethodInfoPtr_set_MatchInitData_Private_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000364E4 File Offset: 0x000346E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504625, XrefRangeEnd = 504629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator RequestInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeProvider<T>.NativeMethodInfoPtr_RequestInfo_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00036530 File Offset: 0x00034730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504629, XrefRangeEnd = 504652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComposition GetPromptData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeProvider<T>.NativeMethodInfoPtr_GetPromptData_Public_Virtual_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0003657C File Offset: 0x0003477C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504658, RefRangeEnd = 504659, XrefRangeStart = 504652, XrefRangeEnd = 504658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeProvider<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000365B8 File Offset: 0x000347B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504659, XrefRangeEnd = 504682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RequestInfo_b__4_0(RequestDailyChallengeInfo dailyChallengeInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dailyChallengeInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider<T>.NativeMethodInfoPtr__RequestInfo_b__4_0_Private_Void_RequestDailyChallengeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000365FC File Offset: 0x000347FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504682, XrefRangeEnd = 504684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RequestInfo_b__4_1(ErrorInfo error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(error));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider<T>.NativeMethodInfoPtr__RequestInfo_b__4_1_Private_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00005AE9 File Offset: 0x00003CE9
		public DailyChallengeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x00036644 File Offset: 0x00034844
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x0003666C File Offset: 0x0003486C
		public unsafe T _MatchInitData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider<T>.NativeFieldInfoPtr__MatchInitData_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider<T>.NativeFieldInfoPtr__MatchInitData_k__BackingField);
				Type typeFromHandle = typeof(T);
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

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeFieldInfoPtr__MatchInitData_k__BackingField;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchInitData_Public_get_T_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchInitData_Private_set_Void_T_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_RequestInfo_Public_Virtual_IEnumerator_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_GetPromptData_Public_Virtual_DataComposition_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr__RequestInfo_b__4_0_Private_Void_RequestDailyChallengeInfo_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr__RequestInfo_b__4_1_Private_Void_ErrorInfo_0;

		// Token: 0x02000322 RID: 802
		[ObfuscatedName("dbgclient.dataProviders.DailyChallengeProvider`1+<RequestInfo>d__4")]
		public sealed class _RequestInfo_d__4 : Object
		{
			// Token: 0x060025CF RID: 9679 RVA: 0x000998C8 File Offset: 0x00097AC8
			// Note: this type is marked as 'beforefieldinit'.
			static _RequestInfo_d__4()
			{
				Il2CppClassPointerStore<DailyChallengeProvider<T>._RequestInfo_d__4>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyChallengeProvider<T>>.NativeClassPtr, "<RequestInfo>d__4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeProvider<T>._RequestInfo_d__4>.NativeClassPtr);
				DailyChallengeProvider<T>._RequestInfo_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider<T>._RequestInfo_d__4>.NativeClassPtr, "<>1__state");
				DailyChallengeProvider<T>._RequestInfo_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider<T>._RequestInfo_d__4>.NativeClassPtr, "<>2__current");
				DailyChallengeProvider<T>._RequestInfo_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider<T>._RequestInfo_d__4>.NativeClassPtr, "<>4__this");
				DailyChallengeProvider<T>._RequestInfo_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider<T>._RequestInfo_d__4>.NativeClassPtr, 100664477);
				DailyChallengeProvider<T>._RequestInfo_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider<T>._RequestInfo_d__4>.NativeClassPtr, 100664478);
				DailyChallengeProvider<T>._RequestInfo_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider<T>._RequestInfo_d__4>.NativeClassPtr, 100664479);
				DailyChallengeProvider<T>._RequestInfo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider<T>._RequestInfo_d__4>.NativeClassPtr, 100664480);
				DailyChallengeProvider<T>._RequestInfo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider<T>._RequestInfo_d__4>.NativeClassPtr, 100664481);
				DailyChallengeProvider<T>._RequestInfo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider<T>._RequestInfo_d__4>.NativeClassPtr, 100664482);
			}

			// Token: 0x060025D0 RID: 9680 RVA: 0x000999E4 File Offset: 0x00097BE4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RequestInfo_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeProvider<T>._RequestInfo_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider<T>._RequestInfo_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025D1 RID: 9681 RVA: 0x00099A2C File Offset: 0x00097C2C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider<T>._RequestInfo_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025D2 RID: 9682 RVA: 0x00099A60 File Offset: 0x00097C60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504614, XrefRangeEnd = 504625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider<T>._RequestInfo_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A6F RID: 2671
			// (get) Token: 0x060025D3 RID: 9683 RVA: 0x00099A9C File Offset: 0x00097C9C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider<T>._RequestInfo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025D4 RID: 9684 RVA: 0x00099ADC File Offset: 0x00097CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider<T>._RequestInfo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A70 RID: 2672
			// (get) Token: 0x060025D5 RID: 9685 RVA: 0x00099B10 File Offset: 0x00097D10
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider<T>._RequestInfo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025D6 RID: 9686 RVA: 0x00013A1B File Offset: 0x00011C1B
			public _RequestInfo_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A6C RID: 2668
			// (get) Token: 0x060025D7 RID: 9687 RVA: 0x00099B50 File Offset: 0x00097D50
			// (set) Token: 0x060025D8 RID: 9688 RVA: 0x00013A24 File Offset: 0x00011C24
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider<T>._RequestInfo_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider<T>._RequestInfo_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A6D RID: 2669
			// (get) Token: 0x060025D9 RID: 9689 RVA: 0x00099B78 File Offset: 0x00097D78
			// (set) Token: 0x060025DA RID: 9690 RVA: 0x00013A3F File Offset: 0x00011C3F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider<T>._RequestInfo_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider<T>._RequestInfo_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A6E RID: 2670
			// (get) Token: 0x060025DB RID: 9691 RVA: 0x00099BA8 File Offset: 0x00097DA8
			// (set) Token: 0x060025DC RID: 9692 RVA: 0x00013A5E File Offset: 0x00011C5E
			public unsafe DailyChallengeProvider<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider<T>._RequestInfo_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeProvider<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider<T>._RequestInfo_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017B6 RID: 6070
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017B7 RID: 6071
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017B8 RID: 6072
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017B9 RID: 6073
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017BA RID: 6074
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017BB RID: 6075
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017BC RID: 6076
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017BD RID: 6077
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017BE RID: 6078
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
