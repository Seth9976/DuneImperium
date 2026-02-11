using System;
using dwd.iap.store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace worm.client.iap
{
	// Token: 0x020002A7 RID: 679
	public class WormIAPStoreBehaviour : IAPStoreBehaviour
	{
		// Token: 0x06001BB0 RID: 7088 RVA: 0x0006D3A0 File Offset: 0x0006B5A0
		// Note: this type is marked as 'beforefieldinit'.
		static WormIAPStoreBehaviour()
		{
			Il2CppClassPointerStore<WormIAPStoreBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.iap", "WormIAPStoreBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormIAPStoreBehaviour>.NativeClassPtr);
			WormIAPStoreBehaviour.NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIAPStoreBehaviour>.NativeClassPtr, 100667332);
			WormIAPStoreBehaviour.NativeMethodInfoPtr_getCommerceURL_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIAPStoreBehaviour>.NativeClassPtr, 100667333);
			WormIAPStoreBehaviour.NativeMethodInfoPtr_initializedFailed_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIAPStoreBehaviour>.NativeClassPtr, 100667334);
			WormIAPStoreBehaviour.NativeMethodInfoPtr_ShowDLCFailed_Private_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIAPStoreBehaviour>.NativeClassPtr, 100667335);
			WormIAPStoreBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIAPStoreBehaviour>.NativeClassPtr, 100667336);
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x0006D434 File Offset: 0x0006B634
		public unsafe override string AnonymousClaimToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725342, XrefRangeEnd = 725350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIAPStoreBehaviour.NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0006D478 File Offset: 0x0006B678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725350, XrefRangeEnd = 725361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string getCommerceURL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIAPStoreBehaviour.NativeMethodInfoPtr_getCommerceURL_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0006D4BC File Offset: 0x0006B6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725361, XrefRangeEnd = 725367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initializedFailed(string error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIAPStoreBehaviour.NativeMethodInfoPtr_initializedFailed_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0006D50C File Offset: 0x0006B70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725367, XrefRangeEnd = 725372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowDLCFailed(string error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIAPStoreBehaviour.NativeMethodInfoPtr_ShowDLCFailed_Private_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0006D55C File Offset: 0x0006B75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725372, XrefRangeEnd = 725373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormIAPStoreBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormIAPStoreBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIAPStoreBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x0000FFCB File Offset: 0x0000E1CB
		public WormIAPStoreBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Virtual_get_String_0;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeMethodInfoPtr_getCommerceURL_Protected_Virtual_String_0;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeMethodInfoPtr_initializedFailed_Protected_Virtual_Void_String_0;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeMethodInfoPtr_ShowDLCFailed_Private_IEnumerator_String_0;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000446 RID: 1094
		[ObfuscatedName("worm.client.iap.WormIAPStoreBehaviour+<ShowDLCFailed>d__4")]
		public sealed class _ShowDLCFailed_d__4 : Object
		{
			// Token: 0x06002D66 RID: 11622 RVA: 0x000A19BC File Offset: 0x0009FBBC
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowDLCFailed_d__4()
			{
				Il2CppClassPointerStore<WormIAPStoreBehaviour._ShowDLCFailed_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormIAPStoreBehaviour>.NativeClassPtr, "<ShowDLCFailed>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormIAPStoreBehaviour._ShowDLCFailed_d__4>.NativeClassPtr);
				WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIAPStoreBehaviour._ShowDLCFailed_d__4>.NativeClassPtr, "<>1__state");
				WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIAPStoreBehaviour._ShowDLCFailed_d__4>.NativeClassPtr, "<>2__current");
				WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIAPStoreBehaviour._ShowDLCFailed_d__4>.NativeClassPtr, "error");
				WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIAPStoreBehaviour._ShowDLCFailed_d__4>.NativeClassPtr, 100667337);
				WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIAPStoreBehaviour._ShowDLCFailed_d__4>.NativeClassPtr, 100667338);
				WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIAPStoreBehaviour._ShowDLCFailed_d__4>.NativeClassPtr, 100667339);
				WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIAPStoreBehaviour._ShowDLCFailed_d__4>.NativeClassPtr, 100667340);
				WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIAPStoreBehaviour._ShowDLCFailed_d__4>.NativeClassPtr, 100667341);
				WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIAPStoreBehaviour._ShowDLCFailed_d__4>.NativeClassPtr, 100667342);
			}

			// Token: 0x06002D67 RID: 11623 RVA: 0x000A1A9C File Offset: 0x0009FC9C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowDLCFailed_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormIAPStoreBehaviour._ShowDLCFailed_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D68 RID: 11624 RVA: 0x000A1AE4 File Offset: 0x0009FCE4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D69 RID: 11625 RVA: 0x000A1B18 File Offset: 0x0009FD18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725331, XrefRangeEnd = 725337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D09 RID: 3337
			// (get) Token: 0x06002D6A RID: 11626 RVA: 0x000A1B54 File Offset: 0x0009FD54
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D6B RID: 11627 RVA: 0x000A1B94 File Offset: 0x0009FD94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725337, XrefRangeEnd = 725342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D0A RID: 3338
			// (get) Token: 0x06002D6C RID: 11628 RVA: 0x000A1BC8 File Offset: 0x0009FDC8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D6D RID: 11629 RVA: 0x0001899F File Offset: 0x00016B9F
			public _ShowDLCFailed_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D06 RID: 3334
			// (get) Token: 0x06002D6E RID: 11630 RVA: 0x000A1C08 File Offset: 0x0009FE08
			// (set) Token: 0x06002D6F RID: 11631 RVA: 0x000189A8 File Offset: 0x00016BA8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D07 RID: 3335
			// (get) Token: 0x06002D70 RID: 11632 RVA: 0x000A1C30 File Offset: 0x0009FE30
			// (set) Token: 0x06002D71 RID: 11633 RVA: 0x000189C3 File Offset: 0x00016BC3
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D08 RID: 3336
			// (get) Token: 0x06002D72 RID: 11634 RVA: 0x000A1C60 File Offset: 0x0009FE60
			// (set) Token: 0x06002D73 RID: 11635 RVA: 0x000189E2 File Offset: 0x00016BE2
			public unsafe string error
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeFieldInfoPtr_error);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIAPStoreBehaviour._ShowDLCFailed_d__4.NativeFieldInfoPtr_error), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001A62 RID: 6754
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A63 RID: 6755
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A64 RID: 6756
			private static readonly IntPtr NativeFieldInfoPtr_error;

			// Token: 0x04001A65 RID: 6757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A66 RID: 6758
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A67 RID: 6759
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A68 RID: 6760
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A69 RID: 6761
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A6A RID: 6762
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
