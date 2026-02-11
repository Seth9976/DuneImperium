using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000101 RID: 257
	public class ContextualMenuPopulateEvent : MouseEventBase<ContextualMenuPopulateEvent>
	{
		// Token: 0x06001461 RID: 5217 RVA: 0x00065004 File Offset: 0x00063204
		// Note: this type is marked as 'beforefieldinit'.
		static ContextualMenuPopulateEvent()
		{
			Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ContextualMenuPopulateEvent");
			ContextualMenuPopulateEvent.NativeFieldInfoPtr__menu_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr, "<menu>k__BackingField");
			ContextualMenuPopulateEvent.NativeFieldInfoPtr__triggerEvent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr, "<triggerEvent>k__BackingField");
			ContextualMenuPopulateEvent.NativeFieldInfoPtr_m_ContextualMenuManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr, "m_ContextualMenuManager");
			ContextualMenuPopulateEvent.NativeMethodInfoPtr_get_menu_Public_get_DropdownMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr, 100666264);
			ContextualMenuPopulateEvent.NativeMethodInfoPtr_set_menu_Private_set_Void_DropdownMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr, 100666265);
			ContextualMenuPopulateEvent.NativeMethodInfoPtr_get_triggerEvent_Public_get_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr, 100666266);
			ContextualMenuPopulateEvent.NativeMethodInfoPtr_set_triggerEvent_Private_set_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr, 100666267);
			ContextualMenuPopulateEvent.NativeMethodInfoPtr_GetPooled_Public_Static_ContextualMenuPopulateEvent_EventBase_DropdownMenu_IEventHandler_ContextualMenuManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr, 100666268);
			ContextualMenuPopulateEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr, 100666269);
			ContextualMenuPopulateEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr, 100666270);
			ContextualMenuPopulateEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr, 100666271);
			ContextualMenuPopulateEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr, 100666272);
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0006511C File Offset: 0x0006331C
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x0006515C File Offset: 0x0006335C
		public unsafe DropdownMenu menu
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuPopulateEvent.NativeMethodInfoPtr_get_menu_Public_get_DropdownMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DropdownMenu>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuPopulateEvent.NativeMethodInfoPtr_set_menu_Private_set_Void_DropdownMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x000651A0 File Offset: 0x000633A0
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x000651E0 File Offset: 0x000633E0
		public unsafe EventBase triggerEvent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuPopulateEvent.NativeMethodInfoPtr_get_triggerEvent_Public_get_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuPopulateEvent.NativeMethodInfoPtr_set_triggerEvent_Private_set_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00065224 File Offset: 0x00063424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315230, RefRangeEnd = 315231, XrefRangeStart = 315171, XrefRangeEnd = 315230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContextualMenuPopulateEvent GetPooled(EventBase triggerEvent, DropdownMenu menu, IEventHandler target, ContextualMenuManager menuManager)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(menu);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(menuManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuPopulateEvent.NativeMethodInfoPtr_GetPooled_Public_Static_ContextualMenuPopulateEvent_EventBase_DropdownMenu_IEventHandler_ContextualMenuManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextualMenuPopulateEvent>(intPtr3) : null;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x000652A0 File Offset: 0x000634A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315231, XrefRangeEnd = 315235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextualMenuPopulateEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x000652DC File Offset: 0x000634DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315238, RefRangeEnd = 315241, XrefRangeStart = 315235, XrefRangeEnd = 315238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuPopulateEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00065310 File Offset: 0x00063510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315241, XrefRangeEnd = 315261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextualMenuPopulateEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuPopulateEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0006534C File Offset: 0x0006354C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315261, XrefRangeEnd = 315283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextualMenuPopulateEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00009B69 File Offset: 0x00007D69
		public ContextualMenuPopulateEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x0006539C File Offset: 0x0006359C
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x00009B72 File Offset: 0x00007D72
		public unsafe DropdownMenu _menu_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualMenuPopulateEvent.NativeFieldInfoPtr__menu_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DropdownMenu>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualMenuPopulateEvent.NativeFieldInfoPtr__menu_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x000653CC File Offset: 0x000635CC
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x00009B91 File Offset: 0x00007D91
		public unsafe EventBase _triggerEvent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualMenuPopulateEvent.NativeFieldInfoPtr__triggerEvent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualMenuPopulateEvent.NativeFieldInfoPtr__triggerEvent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x000653FC File Offset: 0x000635FC
		// (set) Token: 0x06001471 RID: 5233 RVA: 0x00009BB0 File Offset: 0x00007DB0
		public unsafe ContextualMenuManager m_ContextualMenuManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualMenuPopulateEvent.NativeFieldInfoPtr_m_ContextualMenuManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextualMenuManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualMenuPopulateEvent.NativeFieldInfoPtr_m_ContextualMenuManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeFieldInfoPtr__menu_k__BackingField;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeFieldInfoPtr__triggerEvent_k__BackingField;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeFieldInfoPtr_m_ContextualMenuManager;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_get_menu_Public_get_DropdownMenu_0;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_set_menu_Private_set_Void_DropdownMenu_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_get_triggerEvent_Public_get_EventBase_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_set_triggerEvent_Private_set_Void_EventBase_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_ContextualMenuPopulateEvent_EventBase_DropdownMenu_IEventHandler_ContextualMenuManager_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x0200042E RID: 1070
		[ObfuscatedName("UnityEngine.UIElements.ContextualMenuPopulateEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B37 RID: 15159 RVA: 0x000EEE84 File Offset: 0x000ED084
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ContextualMenuPopulateEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContextualMenuPopulateEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextualMenuPopulateEvent.__c>.NativeClassPtr);
				ContextualMenuPopulateEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextualMenuPopulateEvent.__c>.NativeClassPtr, "<>9");
				ContextualMenuPopulateEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuPopulateEvent.__c>.NativeClassPtr, 100666274);
				ContextualMenuPopulateEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_ContextualMenuPopulateEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuPopulateEvent.__c>.NativeClassPtr, 100666275);
			}

			// Token: 0x06003B38 RID: 15160 RVA: 0x000EEEEC File Offset: 0x000ED0EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextualMenuPopulateEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuPopulateEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B39 RID: 15161 RVA: 0x000EEF28 File Offset: 0x000ED128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315164, XrefRangeEnd = 315171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContextualMenuPopulateEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuPopulateEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_ContextualMenuPopulateEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextualMenuPopulateEvent>(intPtr3) : null;
			}

			// Token: 0x06003B3A RID: 15162 RVA: 0x00018EB0 File Offset: 0x000170B0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700120F RID: 4623
			// (get) Token: 0x06003B3B RID: 15163 RVA: 0x000EEF68 File Offset: 0x000ED168
			// (set) Token: 0x06003B3C RID: 15164 RVA: 0x00018EB9 File Offset: 0x000170B9
			public unsafe static ContextualMenuPopulateEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ContextualMenuPopulateEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextualMenuPopulateEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ContextualMenuPopulateEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029D1 RID: 10705
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029D2 RID: 10706
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029D3 RID: 10707
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_ContextualMenuPopulateEvent_0;
		}

		// Token: 0x0200042F RID: 1071
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
