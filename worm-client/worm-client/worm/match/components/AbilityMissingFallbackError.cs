using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001A8 RID: 424
	public class AbilityMissingFallbackError : MonoBehaviour
	{
		// Token: 0x060012C9 RID: 4809 RVA: 0x00051294 File Offset: 0x0004F494
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityMissingFallbackError()
		{
			Il2CppClassPointerStore<AbilityMissingFallbackError>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "AbilityMissingFallbackError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityMissingFallbackError>.NativeClassPtr);
			AbilityMissingFallbackError.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMissingFallbackError>.NativeClassPtr, 100665854);
			AbilityMissingFallbackError.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMissingFallbackError>.NativeClassPtr, 100665855);
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x000512EC File Offset: 0x0004F4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712415, XrefRangeEnd = 712420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityMissingFallbackError.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0005132C File Offset: 0x0004F52C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityMissingFallbackError()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityMissingFallbackError>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityMissingFallbackError.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0000BB7F File Offset: 0x00009D7F
		public AbilityMissingFallbackError(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003BF RID: 959
		[ObfuscatedName("worm.match.components.AbilityMissingFallbackError+<Start>d__0")]
		public sealed class _Start_d__0 : global::Il2CppSystem.Object
		{
			// Token: 0x060026B4 RID: 9908 RVA: 0x0008D958 File Offset: 0x0008BB58
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__0()
			{
				Il2CppClassPointerStore<AbilityMissingFallbackError._Start_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityMissingFallbackError>.NativeClassPtr, "<Start>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityMissingFallbackError._Start_d__0>.NativeClassPtr);
				AbilityMissingFallbackError._Start_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMissingFallbackError._Start_d__0>.NativeClassPtr, "<>1__state");
				AbilityMissingFallbackError._Start_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMissingFallbackError._Start_d__0>.NativeClassPtr, "<>2__current");
				AbilityMissingFallbackError._Start_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMissingFallbackError._Start_d__0>.NativeClassPtr, "<>4__this");
				AbilityMissingFallbackError._Start_d__0.NativeFieldInfoPtr__view_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMissingFallbackError._Start_d__0>.NativeClassPtr, "<view>5__2");
				AbilityMissingFallbackError._Start_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMissingFallbackError._Start_d__0>.NativeClassPtr, 100665856);
				AbilityMissingFallbackError._Start_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMissingFallbackError._Start_d__0>.NativeClassPtr, 100665857);
				AbilityMissingFallbackError._Start_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMissingFallbackError._Start_d__0>.NativeClassPtr, 100665858);
				AbilityMissingFallbackError._Start_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMissingFallbackError._Start_d__0>.NativeClassPtr, 100665859);
				AbilityMissingFallbackError._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMissingFallbackError._Start_d__0>.NativeClassPtr, 100665860);
				AbilityMissingFallbackError._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMissingFallbackError._Start_d__0>.NativeClassPtr, 100665861);
			}

			// Token: 0x060026B5 RID: 9909 RVA: 0x0008DA4C File Offset: 0x0008BC4C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityMissingFallbackError._Start_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityMissingFallbackError._Start_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026B6 RID: 9910 RVA: 0x0008DA94 File Offset: 0x0008BC94
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityMissingFallbackError._Start_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026B7 RID: 9911 RVA: 0x0008DAC8 File Offset: 0x0008BCC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712399, XrefRangeEnd = 712410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityMissingFallbackError._Start_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AC3 RID: 2755
			// (get) Token: 0x060026B8 RID: 9912 RVA: 0x0008DB04 File Offset: 0x0008BD04
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityMissingFallbackError._Start_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026B9 RID: 9913 RVA: 0x0008DB44 File Offset: 0x0008BD44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712410, XrefRangeEnd = 712415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityMissingFallbackError._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AC4 RID: 2756
			// (get) Token: 0x060026BA RID: 9914 RVA: 0x0008DB78 File Offset: 0x0008BD78
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityMissingFallbackError._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026BB RID: 9915 RVA: 0x0001557D File Offset: 0x0001377D
			public _Start_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ABF RID: 2751
			// (get) Token: 0x060026BC RID: 9916 RVA: 0x0008DBB8 File Offset: 0x0008BDB8
			// (set) Token: 0x060026BD RID: 9917 RVA: 0x00015586 File Offset: 0x00013786
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMissingFallbackError._Start_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMissingFallbackError._Start_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AC0 RID: 2752
			// (get) Token: 0x060026BE RID: 9918 RVA: 0x0008DBE0 File Offset: 0x0008BDE0
			// (set) Token: 0x060026BF RID: 9919 RVA: 0x000155A1 File Offset: 0x000137A1
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMissingFallbackError._Start_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMissingFallbackError._Start_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AC1 RID: 2753
			// (get) Token: 0x060026C0 RID: 9920 RVA: 0x0008DC10 File Offset: 0x0008BE10
			// (set) Token: 0x060026C1 RID: 9921 RVA: 0x000155C0 File Offset: 0x000137C0
			public unsafe AbilityMissingFallbackError __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMissingFallbackError._Start_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityMissingFallbackError>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMissingFallbackError._Start_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AC2 RID: 2754
			// (get) Token: 0x060026C2 RID: 9922 RVA: 0x0008DC40 File Offset: 0x0008BE40
			// (set) Token: 0x060026C3 RID: 9923 RVA: 0x000155DF File Offset: 0x000137DF
			public unsafe EntityView _view_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMissingFallbackError._Start_d__0.NativeFieldInfoPtr__view_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMissingFallbackError._Start_d__0.NativeFieldInfoPtr__view_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001648 RID: 5704
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001649 RID: 5705
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400164A RID: 5706
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400164B RID: 5707
			private static readonly IntPtr NativeFieldInfoPtr__view_5__2;

			// Token: 0x0400164C RID: 5708
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400164D RID: 5709
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400164E RID: 5710
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400164F RID: 5711
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001650 RID: 5712
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001651 RID: 5713
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
