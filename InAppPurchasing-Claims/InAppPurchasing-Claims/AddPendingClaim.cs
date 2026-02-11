using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace iap.claims
{
	// Token: 0x02000003 RID: 3
	public class AddPendingClaim : Command
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002CDC File Offset: 0x00000EDC
		// Note: this type is marked as 'beforefieldinit'.
		static AddPendingClaim()
		{
			Il2CppClassPointerStore<AddPendingClaim>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Claims.dll", "iap.claims", "AddPendingClaim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddPendingClaim>.NativeClassPtr);
			AddPendingClaim.NativeFieldInfoPtr_claimId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPendingClaim>.NativeClassPtr, "claimId");
			AddPendingClaim.NativeFieldInfoPtr_archetypeIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPendingClaim>.NativeClassPtr, "archetypeIds");
			AddPendingClaim.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPendingClaim>.NativeClassPtr, 100663299);
			AddPendingClaim.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPendingClaim>.NativeClassPtr, 100663300);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002D5C File Offset: 0x00000F5C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 495165, RefRangeEnd = 495182, XrefRangeStart = 495165, XrefRangeEnd = 495182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddPendingClaim(string claimId, List<ArchetypeID> archetypeIds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddPendingClaim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(claimId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetypeIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPendingClaim.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002DBC File Offset: 0x00000FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267851, XrefRangeEnd = 1267856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddPendingClaim.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002059 File Offset: 0x00000259
		public AddPendingClaim(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002E08 File Offset: 0x00001008
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe string claimId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPendingClaim.NativeFieldInfoPtr_claimId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPendingClaim.NativeFieldInfoPtr_claimId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002E30 File Offset: 0x00001030
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002081 File Offset: 0x00000281
		public unsafe List<ArchetypeID> archetypeIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPendingClaim.NativeFieldInfoPtr_archetypeIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPendingClaim.NativeFieldInfoPtr_archetypeIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_claimId;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_archetypeIds;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_ArchetypeID_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000010 RID: 16
		[ObfuscatedName("iap.claims.AddPendingClaim+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060000B8 RID: 184 RVA: 0x00004994 File Offset: 0x00002B94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<AddPendingClaim.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddPendingClaim>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddPendingClaim.__c__DisplayClass3_0>.NativeClassPtr);
				AddPendingClaim.__c__DisplayClass3_0.NativeFieldInfoPtr_existingClaims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPendingClaim.__c__DisplayClass3_0>.NativeClassPtr, "existingClaims");
				AddPendingClaim.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPendingClaim.__c__DisplayClass3_0>.NativeClassPtr, 100663301);
				AddPendingClaim.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_Void_PendingClaims_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPendingClaim.__c__DisplayClass3_0>.NativeClassPtr, 100663302);
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x000049FC File Offset: 0x00002BFC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddPendingClaim.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPendingClaim.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00004A38 File Offset: 0x00002C38
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPendingClaim.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_Void_PendingClaims_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000BB RID: 187 RVA: 0x0000273E File Offset: 0x0000093E
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060000BC RID: 188 RVA: 0x00004A7C File Offset: 0x00002C7C
			// (set) Token: 0x060000BD RID: 189 RVA: 0x00002747 File Offset: 0x00000947
			public unsafe PendingClaims existingClaims
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPendingClaim.__c__DisplayClass3_0.NativeFieldInfoPtr_existingClaims);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingClaims>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPendingClaim.__c__DisplayClass3_0.NativeFieldInfoPtr_existingClaims), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000060 RID: 96
			private static readonly IntPtr NativeFieldInfoPtr_existingClaims;

			// Token: 0x04000061 RID: 97
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000062 RID: 98
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Void_PendingClaims_0;
		}

		// Token: 0x02000011 RID: 17
		[ObfuscatedName("iap.claims.AddPendingClaim+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x060000BE RID: 190 RVA: 0x00004AAC File Offset: 0x00002CAC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<AddPendingClaim._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddPendingClaim>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddPendingClaim._execute_d__3>.NativeClassPtr);
				AddPendingClaim._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPendingClaim._execute_d__3>.NativeClassPtr, "<>1__state");
				AddPendingClaim._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPendingClaim._execute_d__3>.NativeClassPtr, "<>2__current");
				AddPendingClaim._execute_d__3.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPendingClaim._execute_d__3>.NativeClassPtr, "<>8__1");
				AddPendingClaim._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPendingClaim._execute_d__3>.NativeClassPtr, "<>4__this");
				AddPendingClaim._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPendingClaim._execute_d__3>.NativeClassPtr, 100663303);
				AddPendingClaim._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPendingClaim._execute_d__3>.NativeClassPtr, 100663304);
				AddPendingClaim._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPendingClaim._execute_d__3>.NativeClassPtr, 100663305);
				AddPendingClaim._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPendingClaim._execute_d__3>.NativeClassPtr, 100663306);
				AddPendingClaim._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPendingClaim._execute_d__3>.NativeClassPtr, 100663307);
				AddPendingClaim._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPendingClaim._execute_d__3>.NativeClassPtr, 100663308);
			}

			// Token: 0x060000BF RID: 191 RVA: 0x00004BA0 File Offset: 0x00002DA0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddPendingClaim._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPendingClaim._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x00004BE8 File Offset: 0x00002DE8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPendingClaim._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x00004C1C File Offset: 0x00002E1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267800, XrefRangeEnd = 1267846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPendingClaim._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060000C2 RID: 194 RVA: 0x00004C58 File Offset: 0x00002E58
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPendingClaim._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x00004C98 File Offset: 0x00002E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267846, XrefRangeEnd = 1267851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPendingClaim._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060000C4 RID: 196 RVA: 0x00004CCC File Offset: 0x00002ECC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPendingClaim._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x00002766 File Offset: 0x00000966
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060000C6 RID: 198 RVA: 0x00004D0C File Offset: 0x00002F0C
			// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000276F File Offset: 0x0000096F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPendingClaim._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPendingClaim._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060000C8 RID: 200 RVA: 0x00004D34 File Offset: 0x00002F34
			// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000278A File Offset: 0x0000098A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPendingClaim._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPendingClaim._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060000CA RID: 202 RVA: 0x00004D64 File Offset: 0x00002F64
			// (set) Token: 0x060000CB RID: 203 RVA: 0x000027A9 File Offset: 0x000009A9
			public unsafe AddPendingClaim.__c__DisplayClass3_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPendingClaim._execute_d__3.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddPendingClaim.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPendingClaim._execute_d__3.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060000CC RID: 204 RVA: 0x00004D94 File Offset: 0x00002F94
			// (set) Token: 0x060000CD RID: 205 RVA: 0x000027C8 File Offset: 0x000009C8
			public unsafe AddPendingClaim __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPendingClaim._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddPendingClaim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPendingClaim._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000063 RID: 99
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000064 RID: 100
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000065 RID: 101
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04000066 RID: 102
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000067 RID: 103
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000068 RID: 104
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000069 RID: 105
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400006A RID: 106
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400006B RID: 107
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400006C RID: 108
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
