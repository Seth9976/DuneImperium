using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x020002A1 RID: 673
	public class PointerMoveLinkTagEvent : PointerEventBase<PointerMoveLinkTagEvent>
	{
		// Token: 0x060031AD RID: 12717 RVA: 0x000D2B48 File Offset: 0x000D0D48
		// Note: this type is marked as 'beforefieldinit'.
		static PointerMoveLinkTagEvent()
		{
			Il2CppClassPointerStore<PointerMoveLinkTagEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Experimental", "PointerMoveLinkTagEvent");
			PointerMoveLinkTagEvent.NativeFieldInfoPtr__linkID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerMoveLinkTagEvent>.NativeClassPtr, "<linkID>k__BackingField");
			PointerMoveLinkTagEvent.NativeFieldInfoPtr__linkText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerMoveLinkTagEvent>.NativeClassPtr, "<linkText>k__BackingField");
			PointerMoveLinkTagEvent.NativeMethodInfoPtr_set_linkID_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveLinkTagEvent>.NativeClassPtr, 100670514);
			PointerMoveLinkTagEvent.NativeMethodInfoPtr_set_linkText_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveLinkTagEvent>.NativeClassPtr, 100670515);
			PointerMoveLinkTagEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveLinkTagEvent>.NativeClassPtr, 100670516);
			PointerMoveLinkTagEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveLinkTagEvent>.NativeClassPtr, 100670517);
			PointerMoveLinkTagEvent.NativeMethodInfoPtr_GetPooled_Public_Static_PointerMoveLinkTagEvent_IPointerEvent_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveLinkTagEvent>.NativeClassPtr, 100670518);
			PointerMoveLinkTagEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveLinkTagEvent>.NativeClassPtr, 100670519);
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x0001436B File Offset: 0x0001256B
		// (set) Token: 0x060031AE RID: 12718 RVA: 0x000D2C10 File Offset: 0x000D0E10
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveLinkTagEvent.NativeMethodInfoPtr_set_linkID_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x060031BA RID: 12730 RVA: 0x00014373 File Offset: 0x00012573
		// (set) Token: 0x060031AF RID: 12719 RVA: 0x000D2C54 File Offset: 0x000D0E54
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveLinkTagEvent.NativeMethodInfoPtr_set_linkText_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x000D2C98 File Offset: 0x000D0E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359501, XrefRangeEnd = 359504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerMoveLinkTagEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x000D2CD4 File Offset: 0x000D0ED4
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveLinkTagEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x000D2D08 File Offset: 0x000D0F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359509, RefRangeEnd = 359510, XrefRangeStart = 359504, XrefRangeEnd = 359509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PointerMoveLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveLinkTagEvent.NativeMethodInfoPtr_GetPooled_Public_Static_PointerMoveLinkTagEvent_IPointerEvent_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerMoveLinkTagEvent>(intPtr3) : null;
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x000D2D70 File Offset: 0x000D0F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359510, XrefRangeEnd = 359513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerMoveLinkTagEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerMoveLinkTagEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveLinkTagEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x00014324 File Offset: 0x00012524
		public PointerMoveLinkTagEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x000D2DAC File Offset: 0x000D0FAC
		// (set) Token: 0x060031B6 RID: 12726 RVA: 0x0001432D File Offset: 0x0001252D
		public unsafe string _linkID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerMoveLinkTagEvent.NativeFieldInfoPtr__linkID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerMoveLinkTagEvent.NativeFieldInfoPtr__linkID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x000D2DD4 File Offset: 0x000D0FD4
		// (set) Token: 0x060031B8 RID: 12728 RVA: 0x0001434C File Offset: 0x0001254C
		public unsafe string _linkText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerMoveLinkTagEvent.NativeFieldInfoPtr__linkText_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerMoveLinkTagEvent.NativeFieldInfoPtr__linkText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400248D RID: 9357
		private static readonly IntPtr NativeFieldInfoPtr__linkID_k__BackingField;

		// Token: 0x0400248E RID: 9358
		private static readonly IntPtr NativeFieldInfoPtr__linkText_k__BackingField;

		// Token: 0x0400248F RID: 9359
		private static readonly IntPtr NativeMethodInfoPtr_set_linkID_Private_set_Void_String_0;

		// Token: 0x04002490 RID: 9360
		private static readonly IntPtr NativeMethodInfoPtr_set_linkText_Private_set_Void_String_0;

		// Token: 0x04002491 RID: 9361
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04002492 RID: 9362
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04002493 RID: 9363
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_PointerMoveLinkTagEvent_IPointerEvent_String_String_0;

		// Token: 0x04002494 RID: 9364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200056C RID: 1388
		[ObfuscatedName("UnityEngine.UIElements.Experimental.PointerMoveLinkTagEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004254 RID: 16980 RVA: 0x00104624 File Offset: 0x00102824
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PointerMoveLinkTagEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerMoveLinkTagEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerMoveLinkTagEvent.__c>.NativeClassPtr);
				PointerMoveLinkTagEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerMoveLinkTagEvent.__c>.NativeClassPtr, "<>9");
				PointerMoveLinkTagEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveLinkTagEvent.__c>.NativeClassPtr, 100670521);
				PointerMoveLinkTagEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerMoveLinkTagEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveLinkTagEvent.__c>.NativeClassPtr, 100670522);
			}

			// Token: 0x06004255 RID: 16981 RVA: 0x0010468C File Offset: 0x0010288C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerMoveLinkTagEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveLinkTagEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004256 RID: 16982 RVA: 0x001046C8 File Offset: 0x001028C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359495, XrefRangeEnd = 359501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerMoveLinkTagEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveLinkTagEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerMoveLinkTagEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerMoveLinkTagEvent>(intPtr3) : null;
			}

			// Token: 0x06004257 RID: 16983 RVA: 0x0001C563 File Offset: 0x0001A763
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013E2 RID: 5090
			// (get) Token: 0x06004258 RID: 16984 RVA: 0x00104708 File Offset: 0x00102908
			// (set) Token: 0x06004259 RID: 16985 RVA: 0x0001C56C File Offset: 0x0001A76C
			public unsafe static PointerMoveLinkTagEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PointerMoveLinkTagEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerMoveLinkTagEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PointerMoveLinkTagEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E84 RID: 11908
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002E85 RID: 11909
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E86 RID: 11910
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerMoveLinkTagEvent_0;
		}

		// Token: 0x0200056D RID: 1389
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
