using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x020002A3 RID: 675
	public sealed class PointerDownLinkTagEvent : PointerEventBase<PointerDownLinkTagEvent>
	{
		// Token: 0x060031C1 RID: 12737 RVA: 0x000D2F78 File Offset: 0x000D1178
		// Note: this type is marked as 'beforefieldinit'.
		static PointerDownLinkTagEvent()
		{
			Il2CppClassPointerStore<PointerDownLinkTagEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Experimental", "PointerDownLinkTagEvent");
			PointerDownLinkTagEvent.NativeFieldInfoPtr__linkID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDownLinkTagEvent>.NativeClassPtr, "<linkID>k__BackingField");
			PointerDownLinkTagEvent.NativeFieldInfoPtr__linkText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDownLinkTagEvent>.NativeClassPtr, "<linkText>k__BackingField");
			PointerDownLinkTagEvent.NativeMethodInfoPtr_set_linkID_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDownLinkTagEvent>.NativeClassPtr, 100670532);
			PointerDownLinkTagEvent.NativeMethodInfoPtr_set_linkText_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDownLinkTagEvent>.NativeClassPtr, 100670533);
			PointerDownLinkTagEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDownLinkTagEvent>.NativeClassPtr, 100670534);
			PointerDownLinkTagEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDownLinkTagEvent>.NativeClassPtr, 100670535);
			PointerDownLinkTagEvent.NativeMethodInfoPtr_GetPooled_Public_Static_PointerDownLinkTagEvent_IPointerEvent_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDownLinkTagEvent>.NativeClassPtr, 100670536);
			PointerDownLinkTagEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDownLinkTagEvent>.NativeClassPtr, 100670537);
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x060031CD RID: 12749 RVA: 0x000143CB File Offset: 0x000125CB
		// (set) Token: 0x060031C2 RID: 12738 RVA: 0x000D3040 File Offset: 0x000D1240
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDownLinkTagEvent.NativeMethodInfoPtr_set_linkID_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x000143D3 File Offset: 0x000125D3
		// (set) Token: 0x060031C3 RID: 12739 RVA: 0x000D3084 File Offset: 0x000D1284
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDownLinkTagEvent.NativeMethodInfoPtr_set_linkText_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x000D30C8 File Offset: 0x000D12C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359536, XrefRangeEnd = 359539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDownLinkTagEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x000D30FC File Offset: 0x000D12FC
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDownLinkTagEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x000D3130 File Offset: 0x000D1330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359544, RefRangeEnd = 359545, XrefRangeStart = 359539, XrefRangeEnd = 359544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PointerDownLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDownLinkTagEvent.NativeMethodInfoPtr_GetPooled_Public_Static_PointerDownLinkTagEvent_IPointerEvent_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerDownLinkTagEvent>(intPtr3) : null;
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x000D3198 File Offset: 0x000D1398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359545, XrefRangeEnd = 359548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerDownLinkTagEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerDownLinkTagEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDownLinkTagEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x00014384 File Offset: 0x00012584
		public PointerDownLinkTagEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x060031C9 RID: 12745 RVA: 0x000D31D4 File Offset: 0x000D13D4
		// (set) Token: 0x060031CA RID: 12746 RVA: 0x0001438D File Offset: 0x0001258D
		public unsafe string _linkID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDownLinkTagEvent.NativeFieldInfoPtr__linkID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDownLinkTagEvent.NativeFieldInfoPtr__linkID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x060031CB RID: 12747 RVA: 0x000D31FC File Offset: 0x000D13FC
		// (set) Token: 0x060031CC RID: 12748 RVA: 0x000143AC File Offset: 0x000125AC
		public unsafe string _linkText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDownLinkTagEvent.NativeFieldInfoPtr__linkText_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDownLinkTagEvent.NativeFieldInfoPtr__linkText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002499 RID: 9369
		private static readonly IntPtr NativeFieldInfoPtr__linkID_k__BackingField;

		// Token: 0x0400249A RID: 9370
		private static readonly IntPtr NativeFieldInfoPtr__linkText_k__BackingField;

		// Token: 0x0400249B RID: 9371
		private static readonly IntPtr NativeMethodInfoPtr_set_linkID_Private_set_Void_String_0;

		// Token: 0x0400249C RID: 9372
		private static readonly IntPtr NativeMethodInfoPtr_set_linkText_Private_set_Void_String_0;

		// Token: 0x0400249D RID: 9373
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x0400249E RID: 9374
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x0400249F RID: 9375
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_PointerDownLinkTagEvent_IPointerEvent_String_String_0;

		// Token: 0x040024A0 RID: 9376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000570 RID: 1392
		[ObfuscatedName("UnityEngine.UIElements.Experimental.PointerDownLinkTagEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004260 RID: 16992 RVA: 0x0010483C File Offset: 0x00102A3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PointerDownLinkTagEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerDownLinkTagEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerDownLinkTagEvent.__c>.NativeClassPtr);
				PointerDownLinkTagEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDownLinkTagEvent.__c>.NativeClassPtr, "<>9");
				PointerDownLinkTagEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDownLinkTagEvent.__c>.NativeClassPtr, 100670539);
				PointerDownLinkTagEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerDownLinkTagEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDownLinkTagEvent.__c>.NativeClassPtr, 100670540);
			}

			// Token: 0x06004261 RID: 16993 RVA: 0x001048A4 File Offset: 0x00102AA4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerDownLinkTagEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDownLinkTagEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004262 RID: 16994 RVA: 0x001048E0 File Offset: 0x00102AE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359530, XrefRangeEnd = 359536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerDownLinkTagEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDownLinkTagEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerDownLinkTagEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerDownLinkTagEvent>(intPtr3) : null;
			}

			// Token: 0x06004263 RID: 16995 RVA: 0x0001C599 File Offset: 0x0001A799
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013E4 RID: 5092
			// (get) Token: 0x06004264 RID: 16996 RVA: 0x00104920 File Offset: 0x00102B20
			// (set) Token: 0x06004265 RID: 16997 RVA: 0x0001C5A2 File Offset: 0x0001A7A2
			public unsafe static PointerDownLinkTagEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PointerDownLinkTagEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerDownLinkTagEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PointerDownLinkTagEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E8A RID: 11914
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002E8B RID: 11915
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E8C RID: 11916
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerDownLinkTagEvent_0;
		}

		// Token: 0x02000571 RID: 1393
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
