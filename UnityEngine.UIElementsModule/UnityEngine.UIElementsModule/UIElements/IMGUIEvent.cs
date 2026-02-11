using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200012A RID: 298
	public class IMGUIEvent : EventBase<IMGUIEvent>
	{
		// Token: 0x0600161F RID: 5663 RVA: 0x0006B2F0 File Offset: 0x000694F0
		// Note: this type is marked as 'beforefieldinit'.
		static IMGUIEvent()
		{
			Il2CppClassPointerStore<IMGUIEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IMGUIEvent");
			IMGUIEvent.NativeMethodInfoPtr_GetPooled_Public_Static_IMGUIEvent_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIEvent>.NativeClassPtr, 100666602);
			IMGUIEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIEvent>.NativeClassPtr, 100666603);
			IMGUIEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIEvent>.NativeClassPtr, 100666604);
			IMGUIEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIEvent>.NativeClassPtr, 100666605);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x0006B368 File Offset: 0x00069568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317358, RefRangeEnd = 317359, XrefRangeStart = 317351, XrefRangeEnd = 317358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMGUIEvent GetPooled(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIEvent.NativeMethodInfoPtr_GetPooled_Public_Static_IMGUIEvent_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMGUIEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0006B3AC File Offset: 0x000695AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317359, XrefRangeEnd = 317362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMGUIEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0006B3E8 File Offset: 0x000695E8
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0006B41C File Offset: 0x0006961C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317362, XrefRangeEnd = 317368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMGUIEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IMGUIEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x0000A50F File Offset: 0x0000870F
		public IMGUIEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_IMGUIEvent_Event_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000463 RID: 1123
		[ObfuscatedName("UnityEngine.UIElements.IMGUIEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003BDE RID: 15326 RVA: 0x000F0D3C File Offset: 0x000EEF3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IMGUIEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IMGUIEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IMGUIEvent.__c>.NativeClassPtr);
				IMGUIEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIEvent.__c>.NativeClassPtr, "<>9");
				IMGUIEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIEvent.__c>.NativeClassPtr, 100666607);
				IMGUIEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_IMGUIEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIEvent.__c>.NativeClassPtr, 100666608);
			}

			// Token: 0x06003BDF RID: 15327 RVA: 0x000F0DA4 File Offset: 0x000EEFA4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IMGUIEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003BE0 RID: 15328 RVA: 0x000F0DE0 File Offset: 0x000EEFE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317342, XrefRangeEnd = 317351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IMGUIEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_IMGUIEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMGUIEvent>(intPtr3) : null;
			}

			// Token: 0x06003BE1 RID: 15329 RVA: 0x000191D6 File Offset: 0x000173D6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700122F RID: 4655
			// (get) Token: 0x06003BE2 RID: 15330 RVA: 0x000F0E20 File Offset: 0x000EF020
			// (set) Token: 0x06003BE3 RID: 15331 RVA: 0x000191DF File Offset: 0x000173DF
			public unsafe static IMGUIEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IMGUIEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMGUIEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IMGUIEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A38 RID: 10808
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A39 RID: 10809
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A3A RID: 10810
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_IMGUIEvent_0;
		}

		// Token: 0x02000464 RID: 1124
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
