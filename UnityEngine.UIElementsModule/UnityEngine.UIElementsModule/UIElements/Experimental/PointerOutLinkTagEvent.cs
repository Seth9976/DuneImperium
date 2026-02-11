using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x020002A2 RID: 674
	public class PointerOutLinkTagEvent : PointerEventBase<PointerOutLinkTagEvent>
	{
		// Token: 0x060031BB RID: 12731 RVA: 0x000D2DFC File Offset: 0x000D0FFC
		// Note: this type is marked as 'beforefieldinit'.
		static PointerOutLinkTagEvent()
		{
			Il2CppClassPointerStore<PointerOutLinkTagEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Experimental", "PointerOutLinkTagEvent");
			PointerOutLinkTagEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOutLinkTagEvent>.NativeClassPtr, 100670524);
			PointerOutLinkTagEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOutLinkTagEvent>.NativeClassPtr, 100670525);
			PointerOutLinkTagEvent.NativeMethodInfoPtr_GetPooled_Public_Static_PointerOutLinkTagEvent_IPointerEvent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOutLinkTagEvent>.NativeClassPtr, 100670526);
			PointerOutLinkTagEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOutLinkTagEvent>.NativeClassPtr, 100670527);
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x000D2E74 File Offset: 0x000D1074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359519, XrefRangeEnd = 359522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerOutLinkTagEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x000D2EB0 File Offset: 0x000D10B0
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOutLinkTagEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x000D2EE4 File Offset: 0x000D10E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359525, RefRangeEnd = 359527, XrefRangeStart = 359522, XrefRangeEnd = 359525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PointerOutLinkTagEvent GetPooled(IPointerEvent evt, string linkID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOutLinkTagEvent.NativeMethodInfoPtr_GetPooled_Public_Static_PointerOutLinkTagEvent_IPointerEvent_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerOutLinkTagEvent>(intPtr3) : null;
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x000D2F3C File Offset: 0x000D113C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359527, XrefRangeEnd = 359530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerOutLinkTagEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerOutLinkTagEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOutLinkTagEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x0001437B File Offset: 0x0001257B
		public PointerOutLinkTagEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002495 RID: 9365
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04002496 RID: 9366
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04002497 RID: 9367
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_PointerOutLinkTagEvent_IPointerEvent_String_0;

		// Token: 0x04002498 RID: 9368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200056E RID: 1390
		[ObfuscatedName("UnityEngine.UIElements.Experimental.PointerOutLinkTagEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600425A RID: 16986 RVA: 0x00104730 File Offset: 0x00102930
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PointerOutLinkTagEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerOutLinkTagEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerOutLinkTagEvent.__c>.NativeClassPtr);
				PointerOutLinkTagEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerOutLinkTagEvent.__c>.NativeClassPtr, "<>9");
				PointerOutLinkTagEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOutLinkTagEvent.__c>.NativeClassPtr, 100670529);
				PointerOutLinkTagEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerOutLinkTagEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOutLinkTagEvent.__c>.NativeClassPtr, 100670530);
			}

			// Token: 0x0600425B RID: 16987 RVA: 0x00104798 File Offset: 0x00102998
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerOutLinkTagEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOutLinkTagEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600425C RID: 16988 RVA: 0x001047D4 File Offset: 0x001029D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359513, XrefRangeEnd = 359519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerOutLinkTagEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOutLinkTagEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerOutLinkTagEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerOutLinkTagEvent>(intPtr3) : null;
			}

			// Token: 0x0600425D RID: 16989 RVA: 0x0001C57E File Offset: 0x0001A77E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013E3 RID: 5091
			// (get) Token: 0x0600425E RID: 16990 RVA: 0x00104814 File Offset: 0x00102A14
			// (set) Token: 0x0600425F RID: 16991 RVA: 0x0001C587 File Offset: 0x0001A787
			public unsafe static PointerOutLinkTagEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PointerOutLinkTagEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerOutLinkTagEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PointerOutLinkTagEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E87 RID: 11911
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002E88 RID: 11912
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E89 RID: 11913
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerOutLinkTagEvent_0;
		}

		// Token: 0x0200056F RID: 1391
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
