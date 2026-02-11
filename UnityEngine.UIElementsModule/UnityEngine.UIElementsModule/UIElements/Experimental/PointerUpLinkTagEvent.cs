using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x020002A4 RID: 676
	public class PointerUpLinkTagEvent : PointerEventBase<PointerUpLinkTagEvent>
	{
		// Token: 0x060031CF RID: 12751 RVA: 0x000D3224 File Offset: 0x000D1424
		// Note: this type is marked as 'beforefieldinit'.
		static PointerUpLinkTagEvent()
		{
			Il2CppClassPointerStore<PointerUpLinkTagEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Experimental", "PointerUpLinkTagEvent");
			PointerUpLinkTagEvent.NativeFieldInfoPtr__linkID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerUpLinkTagEvent>.NativeClassPtr, "<linkID>k__BackingField");
			PointerUpLinkTagEvent.NativeFieldInfoPtr__linkText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerUpLinkTagEvent>.NativeClassPtr, "<linkText>k__BackingField");
			PointerUpLinkTagEvent.NativeMethodInfoPtr_set_linkID_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerUpLinkTagEvent>.NativeClassPtr, 100670542);
			PointerUpLinkTagEvent.NativeMethodInfoPtr_set_linkText_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerUpLinkTagEvent>.NativeClassPtr, 100670543);
			PointerUpLinkTagEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerUpLinkTagEvent>.NativeClassPtr, 100670544);
			PointerUpLinkTagEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerUpLinkTagEvent>.NativeClassPtr, 100670545);
			PointerUpLinkTagEvent.NativeMethodInfoPtr_GetPooled_Public_Static_PointerUpLinkTagEvent_IPointerEvent_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerUpLinkTagEvent>.NativeClassPtr, 100670546);
			PointerUpLinkTagEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerUpLinkTagEvent>.NativeClassPtr, 100670547);
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x060031DB RID: 12763 RVA: 0x00014422 File Offset: 0x00012622
		// (set) Token: 0x060031D0 RID: 12752 RVA: 0x000D32EC File Offset: 0x000D14EC
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerUpLinkTagEvent.NativeMethodInfoPtr_set_linkID_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x060031DC RID: 12764 RVA: 0x0001442A File Offset: 0x0001262A
		// (set) Token: 0x060031D1 RID: 12753 RVA: 0x000D3330 File Offset: 0x000D1530
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerUpLinkTagEvent.NativeMethodInfoPtr_set_linkText_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x000D3374 File Offset: 0x000D1574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359554, XrefRangeEnd = 359557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerUpLinkTagEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x000D33B0 File Offset: 0x000D15B0
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerUpLinkTagEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x000D33E4 File Offset: 0x000D15E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359562, RefRangeEnd = 359563, XrefRangeStart = 359557, XrefRangeEnd = 359562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PointerUpLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerUpLinkTagEvent.NativeMethodInfoPtr_GetPooled_Public_Static_PointerUpLinkTagEvent_IPointerEvent_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerUpLinkTagEvent>(intPtr3) : null;
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x000D344C File Offset: 0x000D164C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359563, XrefRangeEnd = 359566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerUpLinkTagEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerUpLinkTagEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerUpLinkTagEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x000143DB File Offset: 0x000125DB
		public PointerUpLinkTagEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x060031D7 RID: 12759 RVA: 0x000D3488 File Offset: 0x000D1688
		// (set) Token: 0x060031D8 RID: 12760 RVA: 0x000143E4 File Offset: 0x000125E4
		public unsafe string _linkID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerUpLinkTagEvent.NativeFieldInfoPtr__linkID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerUpLinkTagEvent.NativeFieldInfoPtr__linkID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x060031D9 RID: 12761 RVA: 0x000D34B0 File Offset: 0x000D16B0
		// (set) Token: 0x060031DA RID: 12762 RVA: 0x00014403 File Offset: 0x00012603
		public unsafe string _linkText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerUpLinkTagEvent.NativeFieldInfoPtr__linkText_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerUpLinkTagEvent.NativeFieldInfoPtr__linkText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040024A1 RID: 9377
		private static readonly IntPtr NativeFieldInfoPtr__linkID_k__BackingField;

		// Token: 0x040024A2 RID: 9378
		private static readonly IntPtr NativeFieldInfoPtr__linkText_k__BackingField;

		// Token: 0x040024A3 RID: 9379
		private static readonly IntPtr NativeMethodInfoPtr_set_linkID_Private_set_Void_String_0;

		// Token: 0x040024A4 RID: 9380
		private static readonly IntPtr NativeMethodInfoPtr_set_linkText_Private_set_Void_String_0;

		// Token: 0x040024A5 RID: 9381
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040024A6 RID: 9382
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040024A7 RID: 9383
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_PointerUpLinkTagEvent_IPointerEvent_String_String_0;

		// Token: 0x040024A8 RID: 9384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000572 RID: 1394
		[ObfuscatedName("UnityEngine.UIElements.Experimental.PointerUpLinkTagEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004266 RID: 16998 RVA: 0x00104948 File Offset: 0x00102B48
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PointerUpLinkTagEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerUpLinkTagEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerUpLinkTagEvent.__c>.NativeClassPtr);
				PointerUpLinkTagEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerUpLinkTagEvent.__c>.NativeClassPtr, "<>9");
				PointerUpLinkTagEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerUpLinkTagEvent.__c>.NativeClassPtr, 100670549);
				PointerUpLinkTagEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerUpLinkTagEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerUpLinkTagEvent.__c>.NativeClassPtr, 100670550);
			}

			// Token: 0x06004267 RID: 16999 RVA: 0x001049B0 File Offset: 0x00102BB0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerUpLinkTagEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerUpLinkTagEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004268 RID: 17000 RVA: 0x001049EC File Offset: 0x00102BEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359548, XrefRangeEnd = 359554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerUpLinkTagEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerUpLinkTagEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerUpLinkTagEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerUpLinkTagEvent>(intPtr3) : null;
			}

			// Token: 0x06004269 RID: 17001 RVA: 0x0001C5B4 File Offset: 0x0001A7B4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013E5 RID: 5093
			// (get) Token: 0x0600426A RID: 17002 RVA: 0x00104A2C File Offset: 0x00102C2C
			// (set) Token: 0x0600426B RID: 17003 RVA: 0x0001C5BD File Offset: 0x0001A7BD
			public unsafe static PointerUpLinkTagEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PointerUpLinkTagEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerUpLinkTagEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PointerUpLinkTagEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E8D RID: 11917
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002E8E RID: 11918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E8F RID: 11919
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerUpLinkTagEvent_0;
		}

		// Token: 0x02000573 RID: 1395
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
