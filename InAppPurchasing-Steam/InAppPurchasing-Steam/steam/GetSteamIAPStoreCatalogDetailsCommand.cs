using System;
using dwd.core.commands;
using dwd.core.networking.commands;
using dwd.iap.store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.iap.steam
{
	// Token: 0x02000005 RID: 5
	public class GetSteamIAPStoreCatalogDetailsCommand : Command
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002CC4 File Offset: 0x00000EC4
		// Note: this type is marked as 'beforefieldinit'.
		static GetSteamIAPStoreCatalogDetailsCommand()
		{
			Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Steam.dll", "dwd.iap.steam", "GetSteamIAPStoreCatalogDetailsCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand>.NativeClassPtr);
			GetSteamIAPStoreCatalogDetailsCommand.NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand>.NativeClassPtr, "model");
			GetSteamIAPStoreCatalogDetailsCommand.NativeMethodInfoPtr__ctor_Public_Void_SteamIAPStoreModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand>.NativeClassPtr, 100663323);
			GetSteamIAPStoreCatalogDetailsCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand>.NativeClassPtr, 100663324);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002D30 File Offset: 0x00000F30
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetSteamIAPStoreCatalogDetailsCommand(SteamIAPStoreModel m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamIAPStoreCatalogDetailsCommand.NativeMethodInfoPtr__ctor_Public_Void_SteamIAPStoreModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002D7C File Offset: 0x00000F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257594, XrefRangeEnd = 1257599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetSteamIAPStoreCatalogDetailsCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020A9 File Offset: 0x000002A9
		public GetSteamIAPStoreCatalogDetailsCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002DC8 File Offset: 0x00000FC8
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000020B2 File Offset: 0x000002B2
		public unsafe SteamIAPStoreModel model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand.NativeFieldInfoPtr_model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamIAPStoreModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand.NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_model;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SteamIAPStoreModel_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000010 RID: 16
		[ObfuscatedName("dwd.iap.steam.GetSteamIAPStoreCatalogDetailsCommand+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x0600009C RID: 156 RVA: 0x0000456C File Offset: 0x0000276C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr);
				GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr, "<>1__state");
				GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr, "<>2__current");
				GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr, "<>4__this");
				GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr, "<>7__wrap1");
				GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr__product_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr, "<product>5__3");
				GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr__country_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr, "<country>5__4");
				GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr__productDetails_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr, "<productDetails>5__5");
				GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr, 100663325);
				GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr, 100663326);
				GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr, 100663327);
				GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr, 100663328);
				GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr, 100663329);
				GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr, 100663330);
				GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr, 100663331);
			}

			// Token: 0x0600009D RID: 157 RVA: 0x000046B0 File Offset: 0x000028B0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetSteamIAPStoreCatalogDetailsCommand._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600009E RID: 158 RVA: 0x000046F8 File Offset: 0x000028F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257409, XrefRangeEnd = 1257414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600009F RID: 159 RVA: 0x0000472C File Offset: 0x0000292C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257414, XrefRangeEnd = 1257586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x00004768 File Offset: 0x00002968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257586, XrefRangeEnd = 1257589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000479C File Offset: 0x0000299C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x000047DC File Offset: 0x000029DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257589, XrefRangeEnd = 1257594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004810 File Offset: 0x00002A10
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x00002532 File Offset: 0x00000732
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x00004850 File Offset: 0x00002A50
			// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000253B File Offset: 0x0000073B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060000A7 RID: 167 RVA: 0x00004878 File Offset: 0x00002A78
			// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002556 File Offset: 0x00000756
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060000A9 RID: 169 RVA: 0x000048A8 File Offset: 0x00002AA8
			// (set) Token: 0x060000AA RID: 170 RVA: 0x00002575 File Offset: 0x00000775
			public unsafe GetSteamIAPStoreCatalogDetailsCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetSteamIAPStoreCatalogDetailsCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x060000AB RID: 171 RVA: 0x000048D8 File Offset: 0x00002AD8
			// (set) Token: 0x060000AC RID: 172 RVA: 0x00002594 File Offset: 0x00000794
			public unsafe IEnumerator<IAPProduct> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAPProduct>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x060000AD RID: 173 RVA: 0x00004908 File Offset: 0x00002B08
			// (set) Token: 0x060000AE RID: 174 RVA: 0x000025B3 File Offset: 0x000007B3
			public unsafe IAPProduct _product_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr__product_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPProduct>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr__product_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060000AF RID: 175 RVA: 0x00004938 File Offset: 0x00002B38
			// (set) Token: 0x060000B0 RID: 176 RVA: 0x000025D2 File Offset: 0x000007D2
			public unsafe string _country_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr__country_5__4);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr__country_5__4), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x060000B1 RID: 177 RVA: 0x00004960 File Offset: 0x00002B60
			// (set) Token: 0x060000B2 RID: 178 RVA: 0x000025F1 File Offset: 0x000007F1
			public unsafe DwdWebRequestCommand _productDetails_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr__productDetails_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamIAPStoreCatalogDetailsCommand._execute_d__2.NativeFieldInfoPtr__productDetails_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000058 RID: 88
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000059 RID: 89
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400005A RID: 90
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400005B RID: 91
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400005C RID: 92
			private static readonly IntPtr NativeFieldInfoPtr__product_5__3;

			// Token: 0x0400005D RID: 93
			private static readonly IntPtr NativeFieldInfoPtr__country_5__4;

			// Token: 0x0400005E RID: 94
			private static readonly IntPtr NativeFieldInfoPtr__productDetails_5__5;

			// Token: 0x0400005F RID: 95
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000060 RID: 96
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000061 RID: 97
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000062 RID: 98
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000063 RID: 99
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000064 RID: 100
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000065 RID: 101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
