using System;
using dwd.core.session;
using dwd.core.settings.serverSettings.save;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.serverSettings.storage
{
	// Token: 0x020000BC RID: 188
	public class WargServerSettingStorage : ServerSettingStorage
	{
		// Token: 0x06000BFB RID: 3067 RVA: 0x00041704 File Offset: 0x0003F904
		// Note: this type is marked as 'beforefieldinit'.
		static WargServerSettingStorage()
		{
			Il2CppClassPointerStore<WargServerSettingStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings.storage", "WargServerSettingStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WargServerSettingStorage>.NativeClassPtr);
			WargServerSettingStorage.NativeFieldInfoPtr_sessionProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WargServerSettingStorage>.NativeClassPtr, "sessionProvider");
			WargServerSettingStorage.NativeFieldInfoPtr_saves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WargServerSettingStorage>.NativeClassPtr, "saves");
			WargServerSettingStorage.NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WargServerSettingStorage>.NativeClassPtr, "map");
			WargServerSettingStorage.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargServerSettingStorage>.NativeClassPtr, 100664982);
			WargServerSettingStorage.NativeMethodInfoPtr_processSaves_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargServerSettingStorage>.NativeClassPtr, 100664983);
			WargServerSettingStorage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargServerSettingStorage>.NativeClassPtr, 100664984);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x000417AC File Offset: 0x0003F9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864166, XrefRangeEnd = 864176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WargServerSettingStorage.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x000417E8 File Offset: 0x0003F9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864176, XrefRangeEnd = 864181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator processSaves()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargServerSettingStorage.NativeMethodInfoPtr_processSaves_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00041828 File Offset: 0x0003FA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864181, XrefRangeEnd = 864203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WargServerSettingStorage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WargServerSettingStorage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargServerSettingStorage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x000063D4 File Offset: 0x000045D4
		public WargServerSettingStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x00041864 File Offset: 0x0003FA64
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x000063DD File Offset: 0x000045DD
		public unsafe SessionProvider sessionProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargServerSettingStorage.NativeFieldInfoPtr_sessionProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargServerSettingStorage.NativeFieldInfoPtr_sessionProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x00041894 File Offset: 0x0003FA94
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x000063FC File Offset: 0x000045FC
		public unsafe List<SaveRequest> saves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargServerSettingStorage.NativeFieldInfoPtr_saves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SaveRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargServerSettingStorage.NativeFieldInfoPtr_saves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x000418C4 File Offset: 0x0003FAC4
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x0000641B File Offset: 0x0000461B
		public unsafe VersionedMap<int, int> map
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargServerSettingStorage.NativeFieldInfoPtr_map);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedMap<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargServerSettingStorage.NativeFieldInfoPtr_map), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeFieldInfoPtr_sessionProvider;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeFieldInfoPtr_saves;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeFieldInfoPtr_map;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_processSaves_Private_IEnumerator_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200029C RID: 668
		[ObfuscatedName("dwd.core.settings.serverSettings.storage.WargServerSettingStorage+<processSaves>d__4")]
		public sealed class _processSaves_d__4 : Object
		{
			// Token: 0x06001FB4 RID: 8116 RVA: 0x0008FD74 File Offset: 0x0008DF74
			// Note: this type is marked as 'beforefieldinit'.
			static _processSaves_d__4()
			{
				Il2CppClassPointerStore<WargServerSettingStorage._processSaves_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WargServerSettingStorage>.NativeClassPtr, "<processSaves>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WargServerSettingStorage._processSaves_d__4>.NativeClassPtr);
				WargServerSettingStorage._processSaves_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WargServerSettingStorage._processSaves_d__4>.NativeClassPtr, "<>1__state");
				WargServerSettingStorage._processSaves_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WargServerSettingStorage._processSaves_d__4>.NativeClassPtr, "<>2__current");
				WargServerSettingStorage._processSaves_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WargServerSettingStorage._processSaves_d__4>.NativeClassPtr, "<>4__this");
				WargServerSettingStorage._processSaves_d__4.NativeFieldInfoPtr__saveToServer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WargServerSettingStorage._processSaves_d__4>.NativeClassPtr, "<saveToServer>5__2");
				WargServerSettingStorage._processSaves_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargServerSettingStorage._processSaves_d__4>.NativeClassPtr, 100664985);
				WargServerSettingStorage._processSaves_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargServerSettingStorage._processSaves_d__4>.NativeClassPtr, 100664986);
				WargServerSettingStorage._processSaves_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargServerSettingStorage._processSaves_d__4>.NativeClassPtr, 100664987);
				WargServerSettingStorage._processSaves_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargServerSettingStorage._processSaves_d__4>.NativeClassPtr, 100664988);
				WargServerSettingStorage._processSaves_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargServerSettingStorage._processSaves_d__4>.NativeClassPtr, 100664989);
				WargServerSettingStorage._processSaves_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargServerSettingStorage._processSaves_d__4>.NativeClassPtr, 100664990);
			}

			// Token: 0x06001FB5 RID: 8117 RVA: 0x0008FE68 File Offset: 0x0008E068
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _processSaves_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WargServerSettingStorage._processSaves_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargServerSettingStorage._processSaves_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FB6 RID: 8118 RVA: 0x0008FEB0 File Offset: 0x0008E0B0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargServerSettingStorage._processSaves_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FB7 RID: 8119 RVA: 0x0008FEE4 File Offset: 0x0008E0E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864144, XrefRangeEnd = 864161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargServerSettingStorage._processSaves_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008A5 RID: 2213
			// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x0008FF20 File Offset: 0x0008E120
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargServerSettingStorage._processSaves_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001FB9 RID: 8121 RVA: 0x0008FF60 File Offset: 0x0008E160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864161, XrefRangeEnd = 864166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargServerSettingStorage._processSaves_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008A6 RID: 2214
			// (get) Token: 0x06001FBA RID: 8122 RVA: 0x0008FF94 File Offset: 0x0008E194
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargServerSettingStorage._processSaves_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001FBB RID: 8123 RVA: 0x0000D7D2 File Offset: 0x0000B9D2
			public _processSaves_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A1 RID: 2209
			// (get) Token: 0x06001FBC RID: 8124 RVA: 0x0008FFD4 File Offset: 0x0008E1D4
			// (set) Token: 0x06001FBD RID: 8125 RVA: 0x0000D7DB File Offset: 0x0000B9DB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargServerSettingStorage._processSaves_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargServerSettingStorage._processSaves_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008A2 RID: 2210
			// (get) Token: 0x06001FBE RID: 8126 RVA: 0x0008FFFC File Offset: 0x0008E1FC
			// (set) Token: 0x06001FBF RID: 8127 RVA: 0x0000D7F6 File Offset: 0x0000B9F6
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargServerSettingStorage._processSaves_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargServerSettingStorage._processSaves_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A3 RID: 2211
			// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x0009002C File Offset: 0x0008E22C
			// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x0000D815 File Offset: 0x0000BA15
			public unsafe WargServerSettingStorage __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargServerSettingStorage._processSaves_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WargServerSettingStorage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargServerSettingStorage._processSaves_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A4 RID: 2212
			// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x0009005C File Offset: 0x0008E25C
			// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x0000D834 File Offset: 0x0000BA34
			public unsafe SaveAccountSettings _saveToServer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargServerSettingStorage._processSaves_d__4.NativeFieldInfoPtr__saveToServer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveAccountSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargServerSettingStorage._processSaves_d__4.NativeFieldInfoPtr__saveToServer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001630 RID: 5680
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001631 RID: 5681
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001632 RID: 5682
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001633 RID: 5683
			private static readonly IntPtr NativeFieldInfoPtr__saveToServer_5__2;

			// Token: 0x04001634 RID: 5684
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001635 RID: 5685
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001636 RID: 5686
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001637 RID: 5687
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001638 RID: 5688
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001639 RID: 5689
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
