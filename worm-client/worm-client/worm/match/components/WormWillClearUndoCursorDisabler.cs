using System;
using boardgames.match.behaviours;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.match.components
{
	// Token: 0x0200021F RID: 543
	public class WormWillClearUndoCursorDisabler : VersionedView<IAttribute<List<string>>>
	{
		// Token: 0x060017CD RID: 6093 RVA: 0x000603AC File Offset: 0x0005E5AC
		// Note: this type is marked as 'beforefieldinit'.
		static WormWillClearUndoCursorDisabler()
		{
			Il2CppClassPointerStore<WormWillClearUndoCursorDisabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormWillClearUndoCursorDisabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler>.NativeClassPtr);
			WormWillClearUndoCursorDisabler.NativeFieldInfoPtr_cursorManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler>.NativeClassPtr, "cursorManager");
			WormWillClearUndoCursorDisabler.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler>.NativeClassPtr, 100666594);
			WormWillClearUndoCursorDisabler.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler>.NativeClassPtr, 100666595);
			WormWillClearUndoCursorDisabler.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler>.NativeClassPtr, 100666596);
			WormWillClearUndoCursorDisabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler>.NativeClassPtr, 100666597);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00060440 File Offset: 0x0005E640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717745, XrefRangeEnd = 717757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWillClearUndoCursorDisabler.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0006047C File Offset: 0x0005E67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717757, XrefRangeEnd = 717762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorDisabler.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x000604BC File Offset: 0x0005E6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717762, XrefRangeEnd = 717775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWillClearUndoCursorDisabler.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x000604F8 File Offset: 0x0005E6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717775, XrefRangeEnd = 717778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormWillClearUndoCursorDisabler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorDisabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0000E360 File Offset: 0x0000C560
		public WormWillClearUndoCursorDisabler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x00060534 File Offset: 0x0005E734
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x0000E369 File Offset: 0x0000C569
		public unsafe CursorManager cursorManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorDisabler.NativeFieldInfoPtr_cursorManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CursorManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorDisabler.NativeFieldInfoPtr_cursorManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeFieldInfoPtr_cursorManager;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003FF RID: 1023
		[ObfuscatedName("worm.match.components.WormWillClearUndoCursorDisabler+<Init>d__2")]
		public sealed class _Init_d__2 : Object
		{
			// Token: 0x060029E0 RID: 10720 RVA: 0x00096F54 File Offset: 0x00095154
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__2()
			{
				Il2CppClassPointerStore<WormWillClearUndoCursorDisabler._Init_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler>.NativeClassPtr, "<Init>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler._Init_d__2>.NativeClassPtr);
				WormWillClearUndoCursorDisabler._Init_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler._Init_d__2>.NativeClassPtr, "<>1__state");
				WormWillClearUndoCursorDisabler._Init_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler._Init_d__2>.NativeClassPtr, "<>2__current");
				WormWillClearUndoCursorDisabler._Init_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler._Init_d__2>.NativeClassPtr, "<>4__this");
				WormWillClearUndoCursorDisabler._Init_d__2.NativeFieldInfoPtr__provider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler._Init_d__2>.NativeClassPtr, "<provider>5__2");
				WormWillClearUndoCursorDisabler._Init_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler._Init_d__2>.NativeClassPtr, 100666598);
				WormWillClearUndoCursorDisabler._Init_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler._Init_d__2>.NativeClassPtr, 100666599);
				WormWillClearUndoCursorDisabler._Init_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler._Init_d__2>.NativeClassPtr, 100666600);
				WormWillClearUndoCursorDisabler._Init_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler._Init_d__2>.NativeClassPtr, 100666601);
				WormWillClearUndoCursorDisabler._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler._Init_d__2>.NativeClassPtr, 100666602);
				WormWillClearUndoCursorDisabler._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler._Init_d__2>.NativeClassPtr, 100666603);
			}

			// Token: 0x060029E1 RID: 10721 RVA: 0x00097048 File Offset: 0x00095248
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWillClearUndoCursorDisabler._Init_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorDisabler._Init_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029E2 RID: 10722 RVA: 0x00097090 File Offset: 0x00095290
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorDisabler._Init_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029E3 RID: 10723 RVA: 0x000970C4 File Offset: 0x000952C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717732, XrefRangeEnd = 717740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorDisabler._Init_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BDB RID: 3035
			// (get) Token: 0x060029E4 RID: 10724 RVA: 0x00097100 File Offset: 0x00095300
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorDisabler._Init_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029E5 RID: 10725 RVA: 0x00097140 File Offset: 0x00095340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717740, XrefRangeEnd = 717745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorDisabler._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BDC RID: 3036
			// (get) Token: 0x060029E6 RID: 10726 RVA: 0x00097174 File Offset: 0x00095374
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorDisabler._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029E7 RID: 10727 RVA: 0x00016E7F File Offset: 0x0001507F
			public _Init_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BD7 RID: 3031
			// (get) Token: 0x060029E8 RID: 10728 RVA: 0x000971B4 File Offset: 0x000953B4
			// (set) Token: 0x060029E9 RID: 10729 RVA: 0x00016E88 File Offset: 0x00015088
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorDisabler._Init_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorDisabler._Init_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BD8 RID: 3032
			// (get) Token: 0x060029EA RID: 10730 RVA: 0x000971DC File Offset: 0x000953DC
			// (set) Token: 0x060029EB RID: 10731 RVA: 0x00016EA3 File Offset: 0x000150A3
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorDisabler._Init_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorDisabler._Init_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD9 RID: 3033
			// (get) Token: 0x060029EC RID: 10732 RVA: 0x0009720C File Offset: 0x0009540C
			// (set) Token: 0x060029ED RID: 10733 RVA: 0x00016EC2 File Offset: 0x000150C2
			public unsafe WormWillClearUndoCursorDisabler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorDisabler._Init_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormWillClearUndoCursorDisabler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorDisabler._Init_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BDA RID: 3034
			// (get) Token: 0x060029EE RID: 10734 RVA: 0x0009723C File Offset: 0x0009543C
			// (set) Token: 0x060029EF RID: 10735 RVA: 0x00016EE1 File Offset: 0x000150E1
			public unsafe DBGEntitiesProvider _provider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorDisabler._Init_d__2.NativeFieldInfoPtr__provider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorDisabler._Init_d__2.NativeFieldInfoPtr__provider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400182A RID: 6186
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400182B RID: 6187
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400182C RID: 6188
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400182D RID: 6189
			private static readonly IntPtr NativeFieldInfoPtr__provider_5__2;

			// Token: 0x0400182E RID: 6190
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400182F RID: 6191
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001830 RID: 6192
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001831 RID: 6193
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001832 RID: 6194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001833 RID: 6195
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
