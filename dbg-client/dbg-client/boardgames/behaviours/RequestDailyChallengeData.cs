using System;
using dbgclient.dataProviders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace boardgames.behaviours
{
	// Token: 0x020002AB RID: 683
	public class RequestDailyChallengeData : MonoBehaviour
	{
		// Token: 0x06002068 RID: 8296 RVA: 0x00089950 File Offset: 0x00087B50
		// Note: this type is marked as 'beforefieldinit'.
		static RequestDailyChallengeData()
		{
			Il2CppClassPointerStore<RequestDailyChallengeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "RequestDailyChallengeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestDailyChallengeData>.NativeClassPtr);
			RequestDailyChallengeData.NativeFieldInfoPtr_onRefreshed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeData>.NativeClassPtr, "onRefreshed");
			RequestDailyChallengeData.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeData>.NativeClassPtr, 100668684);
			RequestDailyChallengeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeData>.NativeClassPtr, 100668685);
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x000899BC File Offset: 0x00087BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542413, XrefRangeEnd = 542418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeData.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x000899FC File Offset: 0x00087BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542418, XrefRangeEnd = 542424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestDailyChallengeData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestDailyChallengeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00010FB6 File Offset: 0x0000F1B6
		public RequestDailyChallengeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x00089A38 File Offset: 0x00087C38
		// (set) Token: 0x0600206D RID: 8301 RVA: 0x00010FBF File Offset: 0x0000F1BF
		public unsafe UnityEvent onRefreshed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeData.NativeFieldInfoPtr_onRefreshed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeData.NativeFieldInfoPtr_onRefreshed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeFieldInfoPtr_onRefreshed;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004A1 RID: 1185
		[ObfuscatedName("boardgames.behaviours.RequestDailyChallengeData+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x0600383F RID: 14399 RVA: 0x0001CEBA File Offset: 0x0001B0BA
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<RequestDailyChallengeData.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RequestDailyChallengeData>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestDailyChallengeData.__O>.NativeClassPtr);
				RequestDailyChallengeData.__O.NativeFieldInfoPtr__0___IsLoggedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeData.__O>.NativeClassPtr, "<0>__IsLoggedIn");
			}

			// Token: 0x06003840 RID: 14400 RVA: 0x0001CEEE File Offset: 0x0001B0EE
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700109F RID: 4255
			// (get) Token: 0x06003841 RID: 14401 RVA: 0x000D0858 File Offset: 0x000CEA58
			// (set) Token: 0x06003842 RID: 14402 RVA: 0x0001CEF7 File Offset: 0x0001B0F7
			public unsafe static Func<bool> _0___IsLoggedIn
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RequestDailyChallengeData.__O.NativeFieldInfoPtr__0___IsLoggedIn, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RequestDailyChallengeData.__O.NativeFieldInfoPtr__0___IsLoggedIn, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002295 RID: 8853
			private static readonly IntPtr NativeFieldInfoPtr__0___IsLoggedIn;
		}

		// Token: 0x020004A2 RID: 1186
		[ObfuscatedName("boardgames.behaviours.RequestDailyChallengeData+<Start>d__1")]
		public sealed class _Start_d__1 : global::Il2CppSystem.Object
		{
			// Token: 0x06003843 RID: 14403 RVA: 0x000D0880 File Offset: 0x000CEA80
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__1()
			{
				Il2CppClassPointerStore<RequestDailyChallengeData._Start_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RequestDailyChallengeData>.NativeClassPtr, "<Start>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestDailyChallengeData._Start_d__1>.NativeClassPtr);
				RequestDailyChallengeData._Start_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeData._Start_d__1>.NativeClassPtr, "<>1__state");
				RequestDailyChallengeData._Start_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeData._Start_d__1>.NativeClassPtr, "<>2__current");
				RequestDailyChallengeData._Start_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeData._Start_d__1>.NativeClassPtr, "<>4__this");
				RequestDailyChallengeData._Start_d__1.NativeFieldInfoPtr__provider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeData._Start_d__1>.NativeClassPtr, "<provider>5__2");
				RequestDailyChallengeData._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeData._Start_d__1>.NativeClassPtr, 100668686);
				RequestDailyChallengeData._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeData._Start_d__1>.NativeClassPtr, 100668687);
				RequestDailyChallengeData._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeData._Start_d__1>.NativeClassPtr, 100668688);
				RequestDailyChallengeData._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeData._Start_d__1>.NativeClassPtr, 100668689);
				RequestDailyChallengeData._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeData._Start_d__1>.NativeClassPtr, 100668690);
				RequestDailyChallengeData._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeData._Start_d__1>.NativeClassPtr, 100668691);
			}

			// Token: 0x06003844 RID: 14404 RVA: 0x000D0974 File Offset: 0x000CEB74
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestDailyChallengeData._Start_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeData._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003845 RID: 14405 RVA: 0x000D09BC File Offset: 0x000CEBBC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeData._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003846 RID: 14406 RVA: 0x000D09F0 File Offset: 0x000CEBF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542403, XrefRangeEnd = 542408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeData._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170010A4 RID: 4260
			// (get) Token: 0x06003847 RID: 14407 RVA: 0x000D0A2C File Offset: 0x000CEC2C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeData._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003848 RID: 14408 RVA: 0x000D0A6C File Offset: 0x000CEC6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542408, XrefRangeEnd = 542413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeData._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010A5 RID: 4261
			// (get) Token: 0x06003849 RID: 14409 RVA: 0x000D0AA0 File Offset: 0x000CECA0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeData._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600384A RID: 14410 RVA: 0x0001CF09 File Offset: 0x0001B109
			public _Start_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010A0 RID: 4256
			// (get) Token: 0x0600384B RID: 14411 RVA: 0x000D0AE0 File Offset: 0x000CECE0
			// (set) Token: 0x0600384C RID: 14412 RVA: 0x0001CF12 File Offset: 0x0001B112
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeData._Start_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeData._Start_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170010A1 RID: 4257
			// (get) Token: 0x0600384D RID: 14413 RVA: 0x000D0B08 File Offset: 0x000CED08
			// (set) Token: 0x0600384E RID: 14414 RVA: 0x0001CF2D File Offset: 0x0001B12D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeData._Start_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeData._Start_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A2 RID: 4258
			// (get) Token: 0x0600384F RID: 14415 RVA: 0x000D0B38 File Offset: 0x000CED38
			// (set) Token: 0x06003850 RID: 14416 RVA: 0x0001CF4C File Offset: 0x0001B14C
			public unsafe RequestDailyChallengeData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeData._Start_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestDailyChallengeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeData._Start_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A3 RID: 4259
			// (get) Token: 0x06003851 RID: 14417 RVA: 0x000D0B68 File Offset: 0x000CED68
			// (set) Token: 0x06003852 RID: 14418 RVA: 0x0001CF6B File Offset: 0x0001B16B
			public unsafe DailyChallengeProvider _provider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeData._Start_d__1.NativeFieldInfoPtr__provider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeData._Start_d__1.NativeFieldInfoPtr__provider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002296 RID: 8854
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002297 RID: 8855
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002298 RID: 8856
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002299 RID: 8857
			private static readonly IntPtr NativeFieldInfoPtr__provider_5__2;

			// Token: 0x0400229A RID: 8858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400229B RID: 8859
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400229C RID: 8860
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400229D RID: 8861
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400229E RID: 8862
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400229F RID: 8863
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
