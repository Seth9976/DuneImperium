using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace iap.claims
{
	// Token: 0x0200000B RID: 11
	public class RemovePendingClaim : Command
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00003EE0 File Offset: 0x000020E0
		// Note: this type is marked as 'beforefieldinit'.
		static RemovePendingClaim()
		{
			Il2CppClassPointerStore<RemovePendingClaim>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Claims.dll", "iap.claims", "RemovePendingClaim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemovePendingClaim>.NativeClassPtr);
			RemovePendingClaim.NativeFieldInfoPtr_claimId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePendingClaim>.NativeClassPtr, "claimId");
			RemovePendingClaim.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePendingClaim>.NativeClassPtr, 100663348);
			RemovePendingClaim.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePendingClaim>.NativeClassPtr, 100663349);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003F4C File Offset: 0x0000214C
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemovePendingClaim(string claimId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemovePendingClaim>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(claimId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemovePendingClaim.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003F98 File Offset: 0x00002198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268086, XrefRangeEnd = 1268091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemovePendingClaim.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002455 File Offset: 0x00000655
		public RemovePendingClaim(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003FE4 File Offset: 0x000021E4
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000245E File Offset: 0x0000065E
		public unsafe string claimId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemovePendingClaim.NativeFieldInfoPtr_claimId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemovePendingClaim.NativeFieldInfoPtr_claimId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_claimId;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000015 RID: 21
		[ObfuscatedName("iap.claims.RemovePendingClaim+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06000100 RID: 256 RVA: 0x000056EC File Offset: 0x000038EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<RemovePendingClaim.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemovePendingClaim>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemovePendingClaim.__c__DisplayClass2_0>.NativeClassPtr);
				RemovePendingClaim.__c__DisplayClass2_0.NativeFieldInfoPtr_existingClaims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePendingClaim.__c__DisplayClass2_0>.NativeClassPtr, "existingClaims");
				RemovePendingClaim.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePendingClaim.__c__DisplayClass2_0>.NativeClassPtr, 100663350);
				RemovePendingClaim.__c__DisplayClass2_0.NativeMethodInfoPtr__execute_b__0_Internal_Void_PendingClaims_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePendingClaim.__c__DisplayClass2_0>.NativeClassPtr, 100663351);
			}

			// Token: 0x06000101 RID: 257 RVA: 0x00005754 File Offset: 0x00003954
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemovePendingClaim.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemovePendingClaim.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000102 RID: 258 RVA: 0x00005790 File Offset: 0x00003990
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__0(PendingClaims c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemovePendingClaim.__c__DisplayClass2_0.NativeMethodInfoPtr__execute_b__0_Internal_Void_PendingClaims_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000103 RID: 259 RVA: 0x0000299C File Offset: 0x00000B9C
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000104 RID: 260 RVA: 0x000057D4 File Offset: 0x000039D4
			// (set) Token: 0x06000105 RID: 261 RVA: 0x000029A5 File Offset: 0x00000BA5
			public unsafe PendingClaims existingClaims
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemovePendingClaim.__c__DisplayClass2_0.NativeFieldInfoPtr_existingClaims);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingClaims>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemovePendingClaim.__c__DisplayClass2_0.NativeFieldInfoPtr_existingClaims), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400008B RID: 139
			private static readonly IntPtr NativeFieldInfoPtr_existingClaims;

			// Token: 0x0400008C RID: 140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400008D RID: 141
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Void_PendingClaims_0;
		}

		// Token: 0x02000016 RID: 22
		[ObfuscatedName("iap.claims.RemovePendingClaim+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06000106 RID: 262 RVA: 0x00005804 File Offset: 0x00003A04
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<RemovePendingClaim._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemovePendingClaim>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemovePendingClaim._execute_d__2>.NativeClassPtr);
				RemovePendingClaim._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePendingClaim._execute_d__2>.NativeClassPtr, "<>1__state");
				RemovePendingClaim._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePendingClaim._execute_d__2>.NativeClassPtr, "<>2__current");
				RemovePendingClaim._execute_d__2.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePendingClaim._execute_d__2>.NativeClassPtr, "<>8__1");
				RemovePendingClaim._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePendingClaim._execute_d__2>.NativeClassPtr, "<>4__this");
				RemovePendingClaim._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePendingClaim._execute_d__2>.NativeClassPtr, 100663352);
				RemovePendingClaim._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePendingClaim._execute_d__2>.NativeClassPtr, 100663353);
				RemovePendingClaim._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePendingClaim._execute_d__2>.NativeClassPtr, 100663354);
				RemovePendingClaim._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePendingClaim._execute_d__2>.NativeClassPtr, 100663355);
				RemovePendingClaim._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePendingClaim._execute_d__2>.NativeClassPtr, 100663356);
				RemovePendingClaim._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePendingClaim._execute_d__2>.NativeClassPtr, 100663357);
			}

			// Token: 0x06000107 RID: 263 RVA: 0x000058F8 File Offset: 0x00003AF8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemovePendingClaim._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemovePendingClaim._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000108 RID: 264 RVA: 0x00005940 File Offset: 0x00003B40
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemovePendingClaim._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000109 RID: 265 RVA: 0x00005974 File Offset: 0x00003B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268042, XrefRangeEnd = 1268081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemovePendingClaim._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x0600010A RID: 266 RVA: 0x000059B0 File Offset: 0x00003BB0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemovePendingClaim._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600010B RID: 267 RVA: 0x000059F0 File Offset: 0x00003BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268081, XrefRangeEnd = 1268086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemovePendingClaim._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x0600010C RID: 268 RVA: 0x00005A24 File Offset: 0x00003C24
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemovePendingClaim._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600010D RID: 269 RVA: 0x000029C4 File Offset: 0x00000BC4
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x0600010E RID: 270 RVA: 0x00005A64 File Offset: 0x00003C64
			// (set) Token: 0x0600010F RID: 271 RVA: 0x000029CD File Offset: 0x00000BCD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemovePendingClaim._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemovePendingClaim._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000110 RID: 272 RVA: 0x00005A8C File Offset: 0x00003C8C
			// (set) Token: 0x06000111 RID: 273 RVA: 0x000029E8 File Offset: 0x00000BE8
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemovePendingClaim._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemovePendingClaim._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000112 RID: 274 RVA: 0x00005ABC File Offset: 0x00003CBC
			// (set) Token: 0x06000113 RID: 275 RVA: 0x00002A07 File Offset: 0x00000C07
			public unsafe RemovePendingClaim.__c__DisplayClass2_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemovePendingClaim._execute_d__2.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemovePendingClaim.__c__DisplayClass2_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemovePendingClaim._execute_d__2.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000114 RID: 276 RVA: 0x00005AEC File Offset: 0x00003CEC
			// (set) Token: 0x06000115 RID: 277 RVA: 0x00002A26 File Offset: 0x00000C26
			public unsafe RemovePendingClaim __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemovePendingClaim._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemovePendingClaim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemovePendingClaim._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400008E RID: 142
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400008F RID: 143
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000090 RID: 144
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04000091 RID: 145
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000092 RID: 146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000093 RID: 147
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000094 RID: 148
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000095 RID: 149
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000096 RID: 150
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000097 RID: 151
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
