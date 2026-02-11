using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x020002A0 RID: 672
	public class PointerOverLinkTagEvent : PointerEventBase<PointerOverLinkTagEvent>
	{
		// Token: 0x0600319F RID: 12703 RVA: 0x000D2894 File Offset: 0x000D0A94
		// Note: this type is marked as 'beforefieldinit'.
		static PointerOverLinkTagEvent()
		{
			Il2CppClassPointerStore<PointerOverLinkTagEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Experimental", "PointerOverLinkTagEvent");
			PointerOverLinkTagEvent.NativeFieldInfoPtr__linkID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerOverLinkTagEvent>.NativeClassPtr, "<linkID>k__BackingField");
			PointerOverLinkTagEvent.NativeFieldInfoPtr__linkText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerOverLinkTagEvent>.NativeClassPtr, "<linkText>k__BackingField");
			PointerOverLinkTagEvent.NativeMethodInfoPtr_set_linkID_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOverLinkTagEvent>.NativeClassPtr, 100670504);
			PointerOverLinkTagEvent.NativeMethodInfoPtr_set_linkText_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOverLinkTagEvent>.NativeClassPtr, 100670505);
			PointerOverLinkTagEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOverLinkTagEvent>.NativeClassPtr, 100670506);
			PointerOverLinkTagEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOverLinkTagEvent>.NativeClassPtr, 100670507);
			PointerOverLinkTagEvent.NativeMethodInfoPtr_GetPooled_Public_Static_PointerOverLinkTagEvent_IPointerEvent_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOverLinkTagEvent>.NativeClassPtr, 100670508);
			PointerOverLinkTagEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOverLinkTagEvent>.NativeClassPtr, 100670509);
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x060031AB RID: 12715 RVA: 0x00014314 File Offset: 0x00012514
		// (set) Token: 0x060031A0 RID: 12704 RVA: 0x000D295C File Offset: 0x000D0B5C
		public unsafe string linkID
		{
			get
			{
				return this._linkID_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOverLinkTagEvent.NativeMethodInfoPtr_set_linkID_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x060031AC RID: 12716 RVA: 0x0001431C File Offset: 0x0001251C
		// (set) Token: 0x060031A1 RID: 12705 RVA: 0x000D29A0 File Offset: 0x000D0BA0
		public unsafe string linkText
		{
			get
			{
				return this._linkText_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOverLinkTagEvent.NativeMethodInfoPtr_set_linkText_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x000D29E4 File Offset: 0x000D0BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359483, XrefRangeEnd = 359486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerOverLinkTagEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x000D2A20 File Offset: 0x000D0C20
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOverLinkTagEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x000D2A54 File Offset: 0x000D0C54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359491, RefRangeEnd = 359492, XrefRangeStart = 359486, XrefRangeEnd = 359491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PointerOverLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOverLinkTagEvent.NativeMethodInfoPtr_GetPooled_Public_Static_PointerOverLinkTagEvent_IPointerEvent_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerOverLinkTagEvent>(intPtr3) : null;
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x000D2ABC File Offset: 0x000D0CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359492, XrefRangeEnd = 359495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerOverLinkTagEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerOverLinkTagEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOverLinkTagEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x000142CD File Offset: 0x000124CD
		public PointerOverLinkTagEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x060031A7 RID: 12711 RVA: 0x000D2AF8 File Offset: 0x000D0CF8
		// (set) Token: 0x060031A8 RID: 12712 RVA: 0x000142D6 File Offset: 0x000124D6
		public unsafe string _linkID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerOverLinkTagEvent.NativeFieldInfoPtr__linkID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerOverLinkTagEvent.NativeFieldInfoPtr__linkID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x000D2B20 File Offset: 0x000D0D20
		// (set) Token: 0x060031AA RID: 12714 RVA: 0x000142F5 File Offset: 0x000124F5
		public unsafe string _linkText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerOverLinkTagEvent.NativeFieldInfoPtr__linkText_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerOverLinkTagEvent.NativeFieldInfoPtr__linkText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002485 RID: 9349
		private static readonly IntPtr NativeFieldInfoPtr__linkID_k__BackingField;

		// Token: 0x04002486 RID: 9350
		private static readonly IntPtr NativeFieldInfoPtr__linkText_k__BackingField;

		// Token: 0x04002487 RID: 9351
		private static readonly IntPtr NativeMethodInfoPtr_set_linkID_Private_set_Void_String_0;

		// Token: 0x04002488 RID: 9352
		private static readonly IntPtr NativeMethodInfoPtr_set_linkText_Private_set_Void_String_0;

		// Token: 0x04002489 RID: 9353
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x0400248A RID: 9354
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x0400248B RID: 9355
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_PointerOverLinkTagEvent_IPointerEvent_String_String_0;

		// Token: 0x0400248C RID: 9356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200056A RID: 1386
		[ObfuscatedName("UnityEngine.UIElements.Experimental.PointerOverLinkTagEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600424E RID: 16974 RVA: 0x00104518 File Offset: 0x00102718
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PointerOverLinkTagEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerOverLinkTagEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerOverLinkTagEvent.__c>.NativeClassPtr);
				PointerOverLinkTagEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerOverLinkTagEvent.__c>.NativeClassPtr, "<>9");
				PointerOverLinkTagEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOverLinkTagEvent.__c>.NativeClassPtr, 100670511);
				PointerOverLinkTagEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerOverLinkTagEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOverLinkTagEvent.__c>.NativeClassPtr, 100670512);
			}

			// Token: 0x0600424F RID: 16975 RVA: 0x00104580 File Offset: 0x00102780
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerOverLinkTagEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOverLinkTagEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004250 RID: 16976 RVA: 0x001045BC File Offset: 0x001027BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359477, XrefRangeEnd = 359483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerOverLinkTagEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOverLinkTagEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerOverLinkTagEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerOverLinkTagEvent>(intPtr3) : null;
			}

			// Token: 0x06004251 RID: 16977 RVA: 0x0001C548 File Offset: 0x0001A748
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013E1 RID: 5089
			// (get) Token: 0x06004252 RID: 16978 RVA: 0x001045FC File Offset: 0x001027FC
			// (set) Token: 0x06004253 RID: 16979 RVA: 0x0001C551 File Offset: 0x0001A751
			public unsafe static PointerOverLinkTagEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PointerOverLinkTagEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerOverLinkTagEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PointerOverLinkTagEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E81 RID: 11905
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002E82 RID: 11906
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E83 RID: 11907
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerOverLinkTagEvent_0;
		}

		// Token: 0x0200056B RID: 1387
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
