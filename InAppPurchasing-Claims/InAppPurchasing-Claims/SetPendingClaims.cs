using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace iap.claims
{
	// Token: 0x0200000C RID: 12
	public class SetPendingClaims : Command
	{
		// Token: 0x06000075 RID: 117 RVA: 0x0000400C File Offset: 0x0000220C
		// Note: this type is marked as 'beforefieldinit'.
		static SetPendingClaims()
		{
			Il2CppClassPointerStore<SetPendingClaims>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Claims.dll", "iap.claims", "SetPendingClaims");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPendingClaims>.NativeClassPtr);
			SetPendingClaims.NativeFieldInfoPtr_pendingClaims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPendingClaims>.NativeClassPtr, "pendingClaims");
			SetPendingClaims.NativeMethodInfoPtr__ctor_Public_Void_PendingClaims_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPendingClaims>.NativeClassPtr, 100663358);
			SetPendingClaims.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPendingClaims>.NativeClassPtr, 100663359);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004078 File Offset: 0x00002278
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetPendingClaims(PendingClaims pendingClaims)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetPendingClaims>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pendingClaims);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPendingClaims.NativeMethodInfoPtr__ctor_Public_Void_PendingClaims_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000040C4 File Offset: 0x000022C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268105, XrefRangeEnd = 1268110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetPendingClaims.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000247D File Offset: 0x0000067D
		public SetPendingClaims(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00004110 File Offset: 0x00002310
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002486 File Offset: 0x00000686
		public unsafe PendingClaims pendingClaims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetPendingClaims.NativeFieldInfoPtr_pendingClaims);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingClaims>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetPendingClaims.NativeFieldInfoPtr_pendingClaims), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_pendingClaims;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PendingClaims_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000017 RID: 23
		[ObfuscatedName("iap.claims.SetPendingClaims+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06000116 RID: 278 RVA: 0x00005B1C File Offset: 0x00003D1C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<SetPendingClaims._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetPendingClaims>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPendingClaims._execute_d__2>.NativeClassPtr);
				SetPendingClaims._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPendingClaims._execute_d__2>.NativeClassPtr, "<>1__state");
				SetPendingClaims._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPendingClaims._execute_d__2>.NativeClassPtr, "<>2__current");
				SetPendingClaims._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPendingClaims._execute_d__2>.NativeClassPtr, "<>4__this");
				SetPendingClaims._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPendingClaims._execute_d__2>.NativeClassPtr, 100663360);
				SetPendingClaims._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPendingClaims._execute_d__2>.NativeClassPtr, 100663361);
				SetPendingClaims._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPendingClaims._execute_d__2>.NativeClassPtr, 100663362);
				SetPendingClaims._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPendingClaims._execute_d__2>.NativeClassPtr, 100663363);
				SetPendingClaims._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPendingClaims._execute_d__2>.NativeClassPtr, 100663364);
				SetPendingClaims._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPendingClaims._execute_d__2>.NativeClassPtr, 100663365);
			}

			// Token: 0x06000117 RID: 279 RVA: 0x00005BFC File Offset: 0x00003DFC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetPendingClaims._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPendingClaims._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000118 RID: 280 RVA: 0x00005C44 File Offset: 0x00003E44
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPendingClaims._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000119 RID: 281 RVA: 0x00005C78 File Offset: 0x00003E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268091, XrefRangeEnd = 1268100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPendingClaims._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x0600011A RID: 282 RVA: 0x00005CB4 File Offset: 0x00003EB4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPendingClaims._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600011B RID: 283 RVA: 0x00005CF4 File Offset: 0x00003EF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268100, XrefRangeEnd = 1268105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPendingClaims._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x0600011C RID: 284 RVA: 0x00005D28 File Offset: 0x00003F28
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPendingClaims._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600011D RID: 285 RVA: 0x00002A45 File Offset: 0x00000C45
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x0600011E RID: 286 RVA: 0x00005D68 File Offset: 0x00003F68
			// (set) Token: 0x0600011F RID: 287 RVA: 0x00002A4E File Offset: 0x00000C4E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetPendingClaims._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetPendingClaims._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000120 RID: 288 RVA: 0x00005D90 File Offset: 0x00003F90
			// (set) Token: 0x06000121 RID: 289 RVA: 0x00002A69 File Offset: 0x00000C69
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetPendingClaims._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetPendingClaims._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000122 RID: 290 RVA: 0x00005DC0 File Offset: 0x00003FC0
			// (set) Token: 0x06000123 RID: 291 RVA: 0x00002A88 File Offset: 0x00000C88
			public unsafe SetPendingClaims __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetPendingClaims._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetPendingClaims>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetPendingClaims._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000098 RID: 152
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000099 RID: 153
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400009A RID: 154
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400009B RID: 155
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400009C RID: 156
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400009D RID: 157
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400009E RID: 158
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400009F RID: 159
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000A0 RID: 160
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
