using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000FD RID: 253
	public class MouseEnterWindowEvent : MouseEventBase<MouseEnterWindowEvent>
	{
		// Token: 0x0600144E RID: 5198 RVA: 0x00064C4C File Offset: 0x00062E4C
		// Note: this type is marked as 'beforefieldinit'.
		static MouseEnterWindowEvent()
		{
			Il2CppClassPointerStore<MouseEnterWindowEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseEnterWindowEvent");
			MouseEnterWindowEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEnterWindowEvent>.NativeClassPtr, 100666237);
			MouseEnterWindowEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEnterWindowEvent>.NativeClassPtr, 100666238);
			MouseEnterWindowEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEnterWindowEvent>.NativeClassPtr, 100666239);
			MouseEnterWindowEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEnterWindowEvent>.NativeClassPtr, 100666240);
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00064CC4 File Offset: 0x00062EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315026, XrefRangeEnd = 315029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEnterWindowEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00064D00 File Offset: 0x00062F00
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEnterWindowEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00064D34 File Offset: 0x00062F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315032, RefRangeEnd = 315033, XrefRangeStart = 315029, XrefRangeEnd = 315032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseEnterWindowEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseEnterWindowEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEnterWindowEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00064D70 File Offset: 0x00062F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315033, XrefRangeEnd = 315061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEnterWindowEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00009AE7 File Offset: 0x00007CE7
		public MouseEnterWindowEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x02000426 RID: 1062
		[ObfuscatedName("UnityEngine.UIElements.MouseEnterWindowEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B1F RID: 15135 RVA: 0x000EEA54 File Offset: 0x000ECC54
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MouseEnterWindowEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MouseEnterWindowEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseEnterWindowEvent.__c>.NativeClassPtr);
				MouseEnterWindowEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEnterWindowEvent.__c>.NativeClassPtr, "<>9");
				MouseEnterWindowEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEnterWindowEvent.__c>.NativeClassPtr, 100666242);
				MouseEnterWindowEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseEnterWindowEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEnterWindowEvent.__c>.NativeClassPtr, 100666243);
			}

			// Token: 0x06003B20 RID: 15136 RVA: 0x000EEABC File Offset: 0x000ECCBC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseEnterWindowEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEnterWindowEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B21 RID: 15137 RVA: 0x000EEAF8 File Offset: 0x000ECCF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315022, XrefRangeEnd = 315026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseEnterWindowEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEnterWindowEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseEnterWindowEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseEnterWindowEvent>(intPtr3) : null;
			}

			// Token: 0x06003B22 RID: 15138 RVA: 0x00018E44 File Offset: 0x00017044
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700120B RID: 4619
			// (get) Token: 0x06003B23 RID: 15139 RVA: 0x000EEB38 File Offset: 0x000ECD38
			// (set) Token: 0x06003B24 RID: 15140 RVA: 0x00018E4D File Offset: 0x0001704D
			public unsafe static MouseEnterWindowEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MouseEnterWindowEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MouseEnterWindowEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MouseEnterWindowEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029C5 RID: 10693
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029C6 RID: 10694
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029C7 RID: 10695
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseEnterWindowEvent_0;
		}

		// Token: 0x02000427 RID: 1063
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
