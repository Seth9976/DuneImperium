using System;
using boardgames.match.selection;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001C8 RID: 456
	public class WormAbilityButton : MonoBehaviour
	{
		// Token: 0x060013FF RID: 5119 RVA: 0x00054DC0 File Offset: 0x00052FC0
		// Note: this type is marked as 'beforefieldinit'.
		static WormAbilityButton()
		{
			Il2CppClassPointerStore<WormAbilityButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormAbilityButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAbilityButton>.NativeClassPtr);
			WormAbilityButton.NativeFieldInfoPtr_keepImperiumRowOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityButton>.NativeClassPtr, "keepImperiumRowOpen");
			WormAbilityButton.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityButton>.NativeClassPtr, "parent");
			WormAbilityButton.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityButton>.NativeClassPtr, "selectionResponder");
			WormAbilityButton.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityButton>.NativeClassPtr, 100666043);
			WormAbilityButton.NativeMethodInfoPtr_Event_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityButton>.NativeClassPtr, 100666044);
			WormAbilityButton.NativeMethodInfoPtr_OnClick_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityButton>.NativeClassPtr, 100666045);
			WormAbilityButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityButton>.NativeClassPtr, 100666046);
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00054E7C File Offset: 0x0005307C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713623, XrefRangeEnd = 713631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityButton.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00054EB0 File Offset: 0x000530B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713631, XrefRangeEnd = 713637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityButton.NativeMethodInfoPtr_Event_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00054EE4 File Offset: 0x000530E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713637, XrefRangeEnd = 713642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityButton.NativeMethodInfoPtr_OnClick_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00054F24 File Offset: 0x00053124
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAbilityButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAbilityButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0000C432 File Offset: 0x0000A632
		public WormAbilityButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x00054F60 File Offset: 0x00053160
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x0000C43B File Offset: 0x0000A63B
		public unsafe bool keepImperiumRowOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton.NativeFieldInfoPtr_keepImperiumRowOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton.NativeFieldInfoPtr_keepImperiumRowOpen)) = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x00054F88 File Offset: 0x00053188
		// (set) Token: 0x06001408 RID: 5128 RVA: 0x0000C456 File Offset: 0x0000A656
		public unsafe EntityView parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x00054FB8 File Offset: 0x000531B8
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x0000C475 File Offset: 0x0000A675
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeFieldInfoPtr_keepImperiumRowOpen;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnClick_Public_Void_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_OnClick_Private_IEnumerator_0;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003CF RID: 975
		[ObfuscatedName("worm.match.components.WormAbilityButton+<OnClick>d__5")]
		public sealed class _OnClick_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x0600277D RID: 10109 RVA: 0x0008FEF4 File Offset: 0x0008E0F4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnClick_d__5()
			{
				Il2CppClassPointerStore<WormAbilityButton._OnClick_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAbilityButton>.NativeClassPtr, "<OnClick>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAbilityButton._OnClick_d__5>.NativeClassPtr);
				WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityButton._OnClick_d__5>.NativeClassPtr, "<>1__state");
				WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityButton._OnClick_d__5>.NativeClassPtr, "<>2__current");
				WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityButton._OnClick_d__5>.NativeClassPtr, "<>4__this");
				WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr__entityID_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityButton._OnClick_d__5>.NativeClassPtr, "<entityID>5__2");
				WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr__submitConfirmation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityButton._OnClick_d__5>.NativeClassPtr, "<submitConfirmation>5__3");
				WormAbilityButton._OnClick_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityButton._OnClick_d__5>.NativeClassPtr, 100666047);
				WormAbilityButton._OnClick_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityButton._OnClick_d__5>.NativeClassPtr, 100666048);
				WormAbilityButton._OnClick_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityButton._OnClick_d__5>.NativeClassPtr, 100666049);
				WormAbilityButton._OnClick_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityButton._OnClick_d__5>.NativeClassPtr, 100666050);
				WormAbilityButton._OnClick_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityButton._OnClick_d__5>.NativeClassPtr, 100666051);
				WormAbilityButton._OnClick_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityButton._OnClick_d__5>.NativeClassPtr, 100666052);
			}

			// Token: 0x0600277E RID: 10110 RVA: 0x0008FFFC File Offset: 0x0008E1FC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnClick_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAbilityButton._OnClick_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityButton._OnClick_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600277F RID: 10111 RVA: 0x00090044 File Offset: 0x0008E244
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityButton._OnClick_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002780 RID: 10112 RVA: 0x00090078 File Offset: 0x0008E278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713603, XrefRangeEnd = 713618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityButton._OnClick_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B08 RID: 2824
			// (get) Token: 0x06002781 RID: 10113 RVA: 0x000900B4 File Offset: 0x0008E2B4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityButton._OnClick_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002782 RID: 10114 RVA: 0x000900F4 File Offset: 0x0008E2F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713618, XrefRangeEnd = 713623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityButton._OnClick_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B09 RID: 2825
			// (get) Token: 0x06002783 RID: 10115 RVA: 0x00090128 File Offset: 0x0008E328
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityButton._OnClick_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002784 RID: 10116 RVA: 0x00015B39 File Offset: 0x00013D39
			public _OnClick_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B03 RID: 2819
			// (get) Token: 0x06002785 RID: 10117 RVA: 0x00090168 File Offset: 0x0008E368
			// (set) Token: 0x06002786 RID: 10118 RVA: 0x00015B42 File Offset: 0x00013D42
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B04 RID: 2820
			// (get) Token: 0x06002787 RID: 10119 RVA: 0x00090190 File Offset: 0x0008E390
			// (set) Token: 0x06002788 RID: 10120 RVA: 0x00015B5D File Offset: 0x00013D5D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B05 RID: 2821
			// (get) Token: 0x06002789 RID: 10121 RVA: 0x000901C0 File Offset: 0x0008E3C0
			// (set) Token: 0x0600278A RID: 10122 RVA: 0x00015B7C File Offset: 0x00013D7C
			public unsafe WormAbilityButton __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B06 RID: 2822
			// (get) Token: 0x0600278B RID: 10123 RVA: 0x000901F0 File Offset: 0x0008E3F0
			// (set) Token: 0x0600278C RID: 10124 RVA: 0x00015B9B File Offset: 0x00013D9B
			public unsafe EntityID _entityID_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr__entityID_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr__entityID_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B07 RID: 2823
			// (get) Token: 0x0600278D RID: 10125 RVA: 0x00090220 File Offset: 0x0008E420
			// (set) Token: 0x0600278E RID: 10126 RVA: 0x00015BBA File Offset: 0x00013DBA
			public unsafe IEnumerator<Nullable<bool>> _submitConfirmation_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr__submitConfirmation_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Nullable<bool>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButton._OnClick_d__5.NativeFieldInfoPtr__submitConfirmation_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016BF RID: 5823
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016C0 RID: 5824
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016C1 RID: 5825
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016C2 RID: 5826
			private static readonly IntPtr NativeFieldInfoPtr__entityID_5__2;

			// Token: 0x040016C3 RID: 5827
			private static readonly IntPtr NativeFieldInfoPtr__submitConfirmation_5__3;

			// Token: 0x040016C4 RID: 5828
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016C5 RID: 5829
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016C6 RID: 5830
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016C7 RID: 5831
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016C8 RID: 5832
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016C9 RID: 5833
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
