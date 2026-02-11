using System;
using boardgames.src.broadcast.motd;
using Canis.utils.localization;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using localization;

namespace lotus
{
	// Token: 0x020000A9 RID: 169
	public class InitLocalization : Command
	{
		// Token: 0x0600081A RID: 2074 RVA: 0x0002A918 File Offset: 0x00028B18
		// Note: this type is marked as 'beforefieldinit'.
		static InitLocalization()
		{
			Il2CppClassPointerStore<InitLocalization>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "InitLocalization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitLocalization>.NativeClassPtr);
			InitLocalization.NativeFieldInfoPtr_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitLocalization>.NativeClassPtr, "locale");
			InitLocalization.NativeFieldInfoPtr_debugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitLocalization>.NativeClassPtr, "debugMode");
			InitLocalization.NativeMethodInfoPtr__ctor_Public_Void_Locale_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitLocalization>.NativeClassPtr, 100664569);
			InitLocalization.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitLocalization>.NativeClassPtr, 100664570);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0002A998 File Offset: 0x00028B98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 991336, RefRangeEnd = 991337, XrefRangeStart = 991335, XrefRangeEnd = 991336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitLocalization(TextLocalization.Locale locale, bool debugMode = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitLocalization>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref locale;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debugMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitLocalization.NativeMethodInfoPtr__ctor_Public_Void_Locale_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0002A9F0 File Offset: 0x00028BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991337, XrefRangeEnd = 991342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitLocalization.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00005AF9 File Offset: 0x00003CF9
		public InitLocalization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x0002AA3C File Offset: 0x00028C3C
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x00005B02 File Offset: 0x00003D02
		public unsafe TextLocalization.Locale locale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitLocalization.NativeFieldInfoPtr_locale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitLocalization.NativeFieldInfoPtr_locale)) = value;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0002AA64 File Offset: 0x00028C64
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x00005B1D File Offset: 0x00003D1D
		public unsafe bool debugMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitLocalization.NativeFieldInfoPtr_debugMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitLocalization.NativeFieldInfoPtr_debugMode)) = value;
			}
		}

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeFieldInfoPtr_locale;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeFieldInfoPtr_debugMode;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Locale_Boolean_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000218 RID: 536
		[ObfuscatedName("lotus.InitLocalization+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x0600188B RID: 6283 RVA: 0x0005D2B0 File Offset: 0x0005B4B0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<InitLocalization._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitLocalization>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitLocalization._execute_d__3>.NativeClassPtr);
				InitLocalization._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitLocalization._execute_d__3>.NativeClassPtr, "<>1__state");
				InitLocalization._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitLocalization._execute_d__3>.NativeClassPtr, "<>2__current");
				InitLocalization._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitLocalization._execute_d__3>.NativeClassPtr, "<>4__this");
				InitLocalization._execute_d__3.NativeFieldInfoPtr__localizationDB_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitLocalization._execute_d__3>.NativeClassPtr, "<localizationDB>5__2");
				InitLocalization._execute_d__3.NativeFieldInfoPtr__broadcastProvider_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitLocalization._execute_d__3>.NativeClassPtr, "<broadcastProvider>5__3");
				InitLocalization._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitLocalization._execute_d__3>.NativeClassPtr, 100664571);
				InitLocalization._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitLocalization._execute_d__3>.NativeClassPtr, 100664572);
				InitLocalization._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitLocalization._execute_d__3>.NativeClassPtr, 100664573);
				InitLocalization._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitLocalization._execute_d__3>.NativeClassPtr, 100664574);
				InitLocalization._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitLocalization._execute_d__3>.NativeClassPtr, 100664575);
				InitLocalization._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitLocalization._execute_d__3>.NativeClassPtr, 100664576);
			}

			// Token: 0x0600188C RID: 6284 RVA: 0x0005D3B8 File Offset: 0x0005B5B8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitLocalization._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitLocalization._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600188D RID: 6285 RVA: 0x0005D400 File Offset: 0x0005B600
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitLocalization._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600188E RID: 6286 RVA: 0x0005D434 File Offset: 0x0005B634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991293, XrefRangeEnd = 991330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitLocalization._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000716 RID: 1814
			// (get) Token: 0x0600188F RID: 6287 RVA: 0x0005D470 File Offset: 0x0005B670
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitLocalization._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001890 RID: 6288 RVA: 0x0005D4B0 File Offset: 0x0005B6B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991330, XrefRangeEnd = 991335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitLocalization._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000717 RID: 1815
			// (get) Token: 0x06001891 RID: 6289 RVA: 0x0005D4E4 File Offset: 0x0005B6E4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitLocalization._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001892 RID: 6290 RVA: 0x0000D6BC File Offset: 0x0000B8BC
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000711 RID: 1809
			// (get) Token: 0x06001893 RID: 6291 RVA: 0x0005D524 File Offset: 0x0005B724
			// (set) Token: 0x06001894 RID: 6292 RVA: 0x0000D6C5 File Offset: 0x0000B8C5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitLocalization._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitLocalization._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000712 RID: 1810
			// (get) Token: 0x06001895 RID: 6293 RVA: 0x0005D54C File Offset: 0x0005B74C
			// (set) Token: 0x06001896 RID: 6294 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitLocalization._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitLocalization._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000713 RID: 1811
			// (get) Token: 0x06001897 RID: 6295 RVA: 0x0005D57C File Offset: 0x0005B77C
			// (set) Token: 0x06001898 RID: 6296 RVA: 0x0000D6FF File Offset: 0x0000B8FF
			public unsafe InitLocalization __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitLocalization._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InitLocalization>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitLocalization._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000714 RID: 1812
			// (get) Token: 0x06001899 RID: 6297 RVA: 0x0005D5AC File Offset: 0x0005B7AC
			// (set) Token: 0x0600189A RID: 6298 RVA: 0x0000D71E File Offset: 0x0000B91E
			public unsafe LocalizationLookup _localizationDB_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitLocalization._execute_d__3.NativeFieldInfoPtr__localizationDB_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizationLookup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitLocalization._execute_d__3.NativeFieldInfoPtr__localizationDB_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000715 RID: 1813
			// (get) Token: 0x0600189B RID: 6299 RVA: 0x0005D5DC File Offset: 0x0005B7DC
			// (set) Token: 0x0600189C RID: 6300 RVA: 0x0000D73D File Offset: 0x0000B93D
			public unsafe BroadcastContentProvider _broadcastProvider_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitLocalization._execute_d__3.NativeFieldInfoPtr__broadcastProvider_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BroadcastContentProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitLocalization._execute_d__3.NativeFieldInfoPtr__broadcastProvider_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000EDD RID: 3805
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000EDE RID: 3806
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000EDF RID: 3807
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000EE0 RID: 3808
			private static readonly IntPtr NativeFieldInfoPtr__localizationDB_5__2;

			// Token: 0x04000EE1 RID: 3809
			private static readonly IntPtr NativeFieldInfoPtr__broadcastProvider_5__3;

			// Token: 0x04000EE2 RID: 3810
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000EE3 RID: 3811
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EE4 RID: 3812
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000EE5 RID: 3813
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000EE6 RID: 3814
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EE7 RID: 3815
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
