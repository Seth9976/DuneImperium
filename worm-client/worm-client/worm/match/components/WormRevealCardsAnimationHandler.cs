using System;
using Canis.attributes;
using dwd.core.animation;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using worm.canis.data.enums;

namespace worm.match.components
{
	// Token: 0x0200020D RID: 525
	public class WormRevealCardsAnimationHandler : VersionedView<IAttribute<Nullable<PlayerTurnTypes>>>
	{
		// Token: 0x06001740 RID: 5952 RVA: 0x0005E97C File Offset: 0x0005CB7C
		// Note: this type is marked as 'beforefieldinit'.
		static WormRevealCardsAnimationHandler()
		{
			Il2CppClassPointerStore<WormRevealCardsAnimationHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormRevealCardsAnimationHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRevealCardsAnimationHandler>.NativeClassPtr);
			WormRevealCardsAnimationHandler.NativeFieldInfoPtr_revealAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealCardsAnimationHandler>.NativeClassPtr, "revealAnimation");
			WormRevealCardsAnimationHandler.NativeMethodInfoPtr_get_RevealAnimation_Public_get_BoolBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsAnimationHandler>.NativeClassPtr, 100666523);
			WormRevealCardsAnimationHandler.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsAnimationHandler>.NativeClassPtr, 100666524);
			WormRevealCardsAnimationHandler.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsAnimationHandler>.NativeClassPtr, 100666525);
			WormRevealCardsAnimationHandler.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsAnimationHandler>.NativeClassPtr, 100666526);
			WormRevealCardsAnimationHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsAnimationHandler>.NativeClassPtr, 100666527);
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x0005EA24 File Offset: 0x0005CC24
		public unsafe BoolBlockingAnimation RevealAnimation
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsAnimationHandler.NativeMethodInfoPtr_get_RevealAnimation_Public_get_BoolBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoolBlockingAnimation>(intPtr3) : null;
			}
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0005EA64 File Offset: 0x0005CC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717276, XrefRangeEnd = 717285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRevealCardsAnimationHandler.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0005EAA0 File Offset: 0x0005CCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717285, XrefRangeEnd = 717290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsAnimationHandler.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x0005EAE0 File Offset: 0x0005CCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717290, XrefRangeEnd = 717296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRevealCardsAnimationHandler.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0005EB1C File Offset: 0x0005CD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717296, XrefRangeEnd = 717299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRevealCardsAnimationHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRevealCardsAnimationHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsAnimationHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0000DEF3 File Offset: 0x0000C0F3
		public WormRevealCardsAnimationHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x0005EB58 File Offset: 0x0005CD58
		// (set) Token: 0x06001748 RID: 5960 RVA: 0x0000DEFC File Offset: 0x0000C0FC
		public unsafe BoolBlockingAnimation revealAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsAnimationHandler.NativeFieldInfoPtr_revealAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsAnimationHandler.NativeFieldInfoPtr_revealAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeFieldInfoPtr_revealAnimation;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_get_RevealAnimation_Public_get_BoolBlockingAnimation_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003FB RID: 1019
		[ObfuscatedName("worm.match.components.WormRevealCardsAnimationHandler+<Init>d__4")]
		public sealed class _Init_d__4 : Object
		{
			// Token: 0x060029A0 RID: 10656 RVA: 0x000962F4 File Offset: 0x000944F4
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__4()
			{
				Il2CppClassPointerStore<WormRevealCardsAnimationHandler._Init_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormRevealCardsAnimationHandler>.NativeClassPtr, "<Init>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRevealCardsAnimationHandler._Init_d__4>.NativeClassPtr);
				WormRevealCardsAnimationHandler._Init_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealCardsAnimationHandler._Init_d__4>.NativeClassPtr, "<>1__state");
				WormRevealCardsAnimationHandler._Init_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealCardsAnimationHandler._Init_d__4>.NativeClassPtr, "<>2__current");
				WormRevealCardsAnimationHandler._Init_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealCardsAnimationHandler._Init_d__4>.NativeClassPtr, "<>4__this");
				WormRevealCardsAnimationHandler._Init_d__4.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealCardsAnimationHandler._Init_d__4>.NativeClassPtr, "<entitiesProvider>5__2");
				WormRevealCardsAnimationHandler._Init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsAnimationHandler._Init_d__4>.NativeClassPtr, 100666528);
				WormRevealCardsAnimationHandler._Init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsAnimationHandler._Init_d__4>.NativeClassPtr, 100666529);
				WormRevealCardsAnimationHandler._Init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsAnimationHandler._Init_d__4>.NativeClassPtr, 100666530);
				WormRevealCardsAnimationHandler._Init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsAnimationHandler._Init_d__4>.NativeClassPtr, 100666531);
				WormRevealCardsAnimationHandler._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsAnimationHandler._Init_d__4>.NativeClassPtr, 100666532);
				WormRevealCardsAnimationHandler._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsAnimationHandler._Init_d__4>.NativeClassPtr, 100666533);
			}

			// Token: 0x060029A1 RID: 10657 RVA: 0x000963E8 File Offset: 0x000945E8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRevealCardsAnimationHandler._Init_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsAnimationHandler._Init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029A2 RID: 10658 RVA: 0x00096430 File Offset: 0x00094630
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsAnimationHandler._Init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029A3 RID: 10659 RVA: 0x00096464 File Offset: 0x00094664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717260, XrefRangeEnd = 717271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsAnimationHandler._Init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BC3 RID: 3011
			// (get) Token: 0x060029A4 RID: 10660 RVA: 0x000964A0 File Offset: 0x000946A0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsAnimationHandler._Init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029A5 RID: 10661 RVA: 0x000964E0 File Offset: 0x000946E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717271, XrefRangeEnd = 717276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsAnimationHandler._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BC4 RID: 3012
			// (get) Token: 0x060029A6 RID: 10662 RVA: 0x00096514 File Offset: 0x00094714
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsAnimationHandler._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029A7 RID: 10663 RVA: 0x00016C7B File Offset: 0x00014E7B
			public _Init_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BBF RID: 3007
			// (get) Token: 0x060029A8 RID: 10664 RVA: 0x00096554 File Offset: 0x00094754
			// (set) Token: 0x060029A9 RID: 10665 RVA: 0x00016C84 File Offset: 0x00014E84
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsAnimationHandler._Init_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsAnimationHandler._Init_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BC0 RID: 3008
			// (get) Token: 0x060029AA RID: 10666 RVA: 0x0009657C File Offset: 0x0009477C
			// (set) Token: 0x060029AB RID: 10667 RVA: 0x00016C9F File Offset: 0x00014E9F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsAnimationHandler._Init_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsAnimationHandler._Init_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC1 RID: 3009
			// (get) Token: 0x060029AC RID: 10668 RVA: 0x000965AC File Offset: 0x000947AC
			// (set) Token: 0x060029AD RID: 10669 RVA: 0x00016CBE File Offset: 0x00014EBE
			public unsafe WormRevealCardsAnimationHandler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsAnimationHandler._Init_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormRevealCardsAnimationHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsAnimationHandler._Init_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC2 RID: 3010
			// (get) Token: 0x060029AE RID: 10670 RVA: 0x000965DC File Offset: 0x000947DC
			// (set) Token: 0x060029AF RID: 10671 RVA: 0x00016CDD File Offset: 0x00014EDD
			public unsafe EntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsAnimationHandler._Init_d__4.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsAnimationHandler._Init_d__4.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001802 RID: 6146
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001803 RID: 6147
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001804 RID: 6148
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001805 RID: 6149
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x04001806 RID: 6150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001807 RID: 6151
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001808 RID: 6152
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001809 RID: 6153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400180A RID: 6154
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400180B RID: 6155
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
