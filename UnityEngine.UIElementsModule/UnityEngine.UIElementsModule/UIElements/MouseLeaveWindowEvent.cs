using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000FE RID: 254
	public class MouseLeaveWindowEvent : MouseEventBase<MouseLeaveWindowEvent>
	{
		// Token: 0x06001454 RID: 5204 RVA: 0x00064DC0 File Offset: 0x00062FC0
		// Note: this type is marked as 'beforefieldinit'.
		static MouseLeaveWindowEvent()
		{
			Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseLeaveWindowEvent");
			MouseLeaveWindowEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr, 100666245);
			MouseLeaveWindowEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr, 100666246);
			MouseLeaveWindowEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr, 100666247);
			MouseLeaveWindowEvent.NativeMethodInfoPtr_GetPooled_Public_Static_MouseLeaveWindowEvent_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr, 100666248);
			MouseLeaveWindowEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr, 100666249);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00064E4C File Offset: 0x0006304C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315070, XrefRangeEnd = 315076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseLeaveWindowEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00064E88 File Offset: 0x00063088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315076, XrefRangeEnd = 315079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseLeaveWindowEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00064EBC File Offset: 0x000630BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315079, XrefRangeEnd = 315085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseLeaveWindowEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseLeaveWindowEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00064EF8 File Offset: 0x000630F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315101, RefRangeEnd = 315102, XrefRangeStart = 315085, XrefRangeEnd = 315101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static MouseLeaveWindowEvent GetPooled(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseLeaveWindowEvent.NativeMethodInfoPtr_GetPooled_Public_Static_MouseLeaveWindowEvent_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseLeaveWindowEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00064F3C File Offset: 0x0006313C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315102, XrefRangeEnd = 315130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseLeaveWindowEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00009AF0 File Offset: 0x00007CF0
		public MouseLeaveWindowEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_MouseLeaveWindowEvent_Event_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x02000428 RID: 1064
		[ObfuscatedName("UnityEngine.UIElements.MouseLeaveWindowEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B25 RID: 15141 RVA: 0x000EEB60 File Offset: 0x000ECD60
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MouseLeaveWindowEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MouseLeaveWindowEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseLeaveWindowEvent.__c>.NativeClassPtr);
				MouseLeaveWindowEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseLeaveWindowEvent.__c>.NativeClassPtr, "<>9");
				MouseLeaveWindowEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveWindowEvent.__c>.NativeClassPtr, 100666251);
				MouseLeaveWindowEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseLeaveWindowEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLeaveWindowEvent.__c>.NativeClassPtr, 100666252);
			}

			// Token: 0x06003B26 RID: 15142 RVA: 0x000EEBC8 File Offset: 0x000ECDC8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseLeaveWindowEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseLeaveWindowEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B27 RID: 15143 RVA: 0x000EEC04 File Offset: 0x000ECE04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315061, XrefRangeEnd = 315070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseLeaveWindowEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseLeaveWindowEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseLeaveWindowEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseLeaveWindowEvent>(intPtr3) : null;
			}

			// Token: 0x06003B28 RID: 15144 RVA: 0x00018E5F File Offset: 0x0001705F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700120C RID: 4620
			// (get) Token: 0x06003B29 RID: 15145 RVA: 0x000EEC44 File Offset: 0x000ECE44
			// (set) Token: 0x06003B2A RID: 15146 RVA: 0x00018E68 File Offset: 0x00017068
			public unsafe static MouseLeaveWindowEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MouseLeaveWindowEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MouseLeaveWindowEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MouseLeaveWindowEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029C8 RID: 10696
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029C9 RID: 10697
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029CA RID: 10698
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseLeaveWindowEvent_0;
		}

		// Token: 0x02000429 RID: 1065
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
