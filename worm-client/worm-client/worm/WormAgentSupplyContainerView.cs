using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;

namespace worm
{
	// Token: 0x02000042 RID: 66
	public class WormAgentSupplyContainerView : LayoutPileView
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x000218E4 File Offset: 0x0001FAE4
		// Note: this type is marked as 'beforefieldinit'.
		static WormAgentSupplyContainerView()
		{
			Il2CppClassPointerStore<WormAgentSupplyContainerView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormAgentSupplyContainerView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAgentSupplyContainerView>.NativeClassPtr);
			WormAgentSupplyContainerView.NativeFieldInfoPtr_canShowMercenaryAgents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentSupplyContainerView>.NativeClassPtr, "canShowMercenaryAgents");
			WormAgentSupplyContainerView.NativeFieldInfoPtr_mercenaryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentSupplyContainerView>.NativeClassPtr, "mercenaryContainer");
			WormAgentSupplyContainerView.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentSupplyContainerView>.NativeClassPtr, 100663749);
			WormAgentSupplyContainerView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentSupplyContainerView>.NativeClassPtr, 100663750);
			WormAgentSupplyContainerView.NativeMethodInfoPtr_UpdateMercenaryHinters_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentSupplyContainerView>.NativeClassPtr, 100663751);
			WormAgentSupplyContainerView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentSupplyContainerView>.NativeClassPtr, 100663752);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0002198C File Offset: 0x0001FB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690742, XrefRangeEnd = 690761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentSupplyContainerView.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000219C0 File Offset: 0x0001FBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690761, XrefRangeEnd = 690770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LayoutViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAgentSupplyContainerView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000219FC File Offset: 0x0001FBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690770, XrefRangeEnd = 690775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator UpdateMercenaryHinters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentSupplyContainerView.NativeMethodInfoPtr_UpdateMercenaryHinters_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00021A3C File Offset: 0x0001FC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAgentSupplyContainerView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAgentSupplyContainerView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentSupplyContainerView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000034FE File Offset: 0x000016FE
		public WormAgentSupplyContainerView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00021A78 File Offset: 0x0001FC78
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00003507 File Offset: 0x00001707
		public unsafe bool canShowMercenaryAgents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSupplyContainerView.NativeFieldInfoPtr_canShowMercenaryAgents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSupplyContainerView.NativeFieldInfoPtr_canShowMercenaryAgents)) = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002DE RID: 734 RVA: 0x00021AA0 File Offset: 0x0001FCA0
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00003522 File Offset: 0x00001722
		public unsafe Transform mercenaryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSupplyContainerView.NativeFieldInfoPtr_mercenaryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSupplyContainerView.NativeFieldInfoPtr_mercenaryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr_canShowMercenaryAgents;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr_mercenaryContainer;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMercenaryHinters_Private_IEnumerator_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D9 RID: 729
		[ObfuscatedName("worm.WormAgentSupplyContainerView+<UpdateMercenaryHinters>d__4")]
		public sealed class _UpdateMercenaryHinters_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x06001DB9 RID: 7609 RVA: 0x00073448 File Offset: 0x00071648
			// Note: this type is marked as 'beforefieldinit'.
			static _UpdateMercenaryHinters_d__4()
			{
				Il2CppClassPointerStore<WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAgentSupplyContainerView>.NativeClassPtr, "<UpdateMercenaryHinters>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4>.NativeClassPtr);
				WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4>.NativeClassPtr, "<>1__state");
				WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4>.NativeClassPtr, "<>2__current");
				WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4>.NativeClassPtr, "<>4__this");
				WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4>.NativeClassPtr, "<i>5__2");
				WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr__view_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4>.NativeClassPtr, "<view>5__3");
				WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4>.NativeClassPtr, 100663753);
				WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4>.NativeClassPtr, 100663754);
				WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4>.NativeClassPtr, 100663755);
				WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4>.NativeClassPtr, 100663756);
				WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4>.NativeClassPtr, 100663757);
				WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4>.NativeClassPtr, 100663758);
			}

			// Token: 0x06001DBA RID: 7610 RVA: 0x00073550 File Offset: 0x00071750
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UpdateMercenaryHinters_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DBB RID: 7611 RVA: 0x00073598 File Offset: 0x00071798
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DBC RID: 7612 RVA: 0x000735CC File Offset: 0x000717CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690716, XrefRangeEnd = 690737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700082C RID: 2092
			// (get) Token: 0x06001DBD RID: 7613 RVA: 0x00073608 File Offset: 0x00071808
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001DBE RID: 7614 RVA: 0x00073648 File Offset: 0x00071848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690737, XrefRangeEnd = 690742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700082D RID: 2093
			// (get) Token: 0x06001DBF RID: 7615 RVA: 0x0007367C File Offset: 0x0007187C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001DC0 RID: 7616 RVA: 0x00010F2B File Offset: 0x0000F12B
			public _UpdateMercenaryHinters_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000827 RID: 2087
			// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x000736BC File Offset: 0x000718BC
			// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x00010F34 File Offset: 0x0000F134
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000828 RID: 2088
			// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x000736E4 File Offset: 0x000718E4
			// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x00010F4F File Offset: 0x0000F14F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000829 RID: 2089
			// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x00073714 File Offset: 0x00071914
			// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x00010F6E File Offset: 0x0000F16E
			public unsafe WormAgentSupplyContainerView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAgentSupplyContainerView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700082A RID: 2090
			// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x00073744 File Offset: 0x00071944
			// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x00010F8D File Offset: 0x0000F18D
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x1700082B RID: 2091
			// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x0007376C File Offset: 0x0007196C
			// (set) Token: 0x06001DCA RID: 7626 RVA: 0x00010FA8 File Offset: 0x0000F1A8
			public unsafe UnitView _view_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr__view_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSupplyContainerView._UpdateMercenaryHinters_d__4.NativeFieldInfoPtr__view_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400113F RID: 4415
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001140 RID: 4416
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001141 RID: 4417
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001142 RID: 4418
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04001143 RID: 4419
			private static readonly IntPtr NativeFieldInfoPtr__view_5__3;

			// Token: 0x04001144 RID: 4420
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001145 RID: 4421
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001146 RID: 4422
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001147 RID: 4423
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001148 RID: 4424
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001149 RID: 4425
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
