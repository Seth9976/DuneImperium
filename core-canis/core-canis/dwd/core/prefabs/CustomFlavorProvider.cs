using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.prefabs
{
	// Token: 0x02000101 RID: 257
	public class CustomFlavorProvider : FlavorProvider
	{
		// Token: 0x06000F0E RID: 3854 RVA: 0x0004F754 File Offset: 0x0004D954
		// Note: this type is marked as 'beforefieldinit'.
		static CustomFlavorProvider()
		{
			Il2CppClassPointerStore<CustomFlavorProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs", "CustomFlavorProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomFlavorProvider>.NativeClassPtr);
			CustomFlavorProvider.NativeFieldInfoPtr_flavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomFlavorProvider>.NativeClassPtr, "flavors");
			CustomFlavorProvider.NativeMethodInfoPtr_GetFlavors_Public_Virtual_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomFlavorProvider>.NativeClassPtr, 100665480);
			CustomFlavorProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomFlavorProvider>.NativeClassPtr, 100665481);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0004F7C0 File Offset: 0x0004D9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867971, XrefRangeEnd = 867977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<string> GetFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomFlavorProvider.NativeMethodInfoPtr_GetFlavors_Public_Virtual_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0004F80C File Offset: 0x0004DA0C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomFlavorProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomFlavorProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomFlavorProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x000071A5 File Offset: 0x000053A5
		public CustomFlavorProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x0004F848 File Offset: 0x0004DA48
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x000071AE File Offset: 0x000053AE
		public unsafe Il2CppStringArray flavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomFlavorProvider.NativeFieldInfoPtr_flavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomFlavorProvider.NativeFieldInfoPtr_flavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeFieldInfoPtr_flavors;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeMethodInfoPtr_GetFlavors_Public_Virtual_IEnumerable_1_String_0;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002B9 RID: 697
		[ObfuscatedName("dwd.core.prefabs.CustomFlavorProvider+<GetFlavors>d__1")]
		public sealed class _GetFlavors_d__1 : Object
		{
			// Token: 0x06002093 RID: 8339 RVA: 0x0009313C File Offset: 0x0009133C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFlavors_d__1()
			{
				Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomFlavorProvider>.NativeClassPtr, "<GetFlavors>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr);
				CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr, "<>1__state");
				CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr, "<>2__current");
				CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr, "<>l__initialThreadId");
				CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr, "<>4__this");
				CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr, "<i>5__2");
				CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100665482);
				CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100665483);
				CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100665484);
				CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100665485);
				CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100665486);
				CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100665487);
				CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100665488);
				CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100665489);
			}

			// Token: 0x06002094 RID: 8340 RVA: 0x0009326C File Offset: 0x0009146C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetFlavors_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomFlavorProvider._GetFlavors_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002095 RID: 8341 RVA: 0x000932B4 File Offset: 0x000914B4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002096 RID: 8342 RVA: 0x000932E8 File Offset: 0x000914E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867962, XrefRangeEnd = 867964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008DE RID: 2270
			// (get) Token: 0x06002097 RID: 8343 RVA: 0x00093324 File Offset: 0x00091524
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002098 RID: 8344 RVA: 0x0009335C File Offset: 0x0009155C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867964, XrefRangeEnd = 867969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008DF RID: 2271
			// (get) Token: 0x06002099 RID: 8345 RVA: 0x00093390 File Offset: 0x00091590
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600209A RID: 8346 RVA: 0x000933D0 File Offset: 0x000915D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867969, XrefRangeEnd = 867971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x0600209B RID: 8347 RVA: 0x00093410 File Offset: 0x00091610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600209C RID: 8348 RVA: 0x0000DDB0 File Offset: 0x0000BFB0
			public _GetFlavors_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008D9 RID: 2265
			// (get) Token: 0x0600209D RID: 8349 RVA: 0x00093450 File Offset: 0x00091650
			// (set) Token: 0x0600209E RID: 8350 RVA: 0x0000DDB9 File Offset: 0x0000BFB9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008DA RID: 2266
			// (get) Token: 0x0600209F RID: 8351 RVA: 0x00093478 File Offset: 0x00091678
			// (set) Token: 0x060020A0 RID: 8352 RVA: 0x0000DDD4 File Offset: 0x0000BFD4
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170008DB RID: 2267
			// (get) Token: 0x060020A1 RID: 8353 RVA: 0x000934A0 File Offset: 0x000916A0
			// (set) Token: 0x060020A2 RID: 8354 RVA: 0x0000DDF3 File Offset: 0x0000BFF3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170008DC RID: 2268
			// (get) Token: 0x060020A3 RID: 8355 RVA: 0x000934C8 File Offset: 0x000916C8
			// (set) Token: 0x060020A4 RID: 8356 RVA: 0x0000DE0E File Offset: 0x0000C00E
			public unsafe CustomFlavorProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomFlavorProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x060020A5 RID: 8357 RVA: 0x000934F8 File Offset: 0x000916F8
			// (set) Token: 0x060020A6 RID: 8358 RVA: 0x0000DE2D File Offset: 0x0000C02D
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040016A9 RID: 5801
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016AA RID: 5802
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016AB RID: 5803
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040016AC RID: 5804
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016AD RID: 5805
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040016AE RID: 5806
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016AF RID: 5807
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016B0 RID: 5808
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016B1 RID: 5809
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x040016B2 RID: 5810
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016B3 RID: 5811
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016B4 RID: 5812
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x040016B5 RID: 5813
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
