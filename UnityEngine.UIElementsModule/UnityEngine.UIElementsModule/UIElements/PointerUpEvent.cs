using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011A RID: 282
	public sealed class PointerUpEvent : PointerEventBase<PointerUpEvent>
	{
		// Token: 0x060015B5 RID: 5557 RVA: 0x00069FF8 File Offset: 0x000681F8
		// Note: this type is marked as 'beforefieldinit'.
		static PointerUpEvent()
		{
			Il2CppClassPointerStore<PointerUpEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerUpEvent");
			PointerUpEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerUpEvent>.NativeClassPtr, 100666496);
			PointerUpEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerUpEvent>.NativeClassPtr, 100666497);
			PointerUpEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerUpEvent>.NativeClassPtr, 100666498);
			PointerUpEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerUpEvent>.NativeClassPtr, 100666499);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0006A070 File Offset: 0x00068270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316797, XrefRangeEnd = 316805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerUpEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0006A0A4 File Offset: 0x000682A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316805, XrefRangeEnd = 316810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerUpEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x0006A0D8 File Offset: 0x000682D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316810, XrefRangeEnd = 316818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerUpEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerUpEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerUpEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x0006A114 File Offset: 0x00068314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316818, XrefRangeEnd = 316850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerUpEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x0000A20E File Offset: 0x0000840E
		public PointerUpEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x02000445 RID: 1093
		[ObfuscatedName("UnityEngine.UIElements.PointerUpEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B7F RID: 15231 RVA: 0x000EFC20 File Offset: 0x000EDE20
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PointerUpEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerUpEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerUpEvent.__c>.NativeClassPtr);
				PointerUpEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerUpEvent.__c>.NativeClassPtr, "<>9");
				PointerUpEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerUpEvent.__c>.NativeClassPtr, 100666501);
				PointerUpEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerUpEvent.__c>.NativeClassPtr, 100666502);
			}

			// Token: 0x06003B80 RID: 15232 RVA: 0x000EFC88 File Offset: 0x000EDE88
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerUpEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerUpEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B81 RID: 15233 RVA: 0x000EFCC4 File Offset: 0x000EDEC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316786, XrefRangeEnd = 316797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerUpEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerUpEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerUpEvent>(intPtr3) : null;
			}

			// Token: 0x06003B82 RID: 15234 RVA: 0x00019013 File Offset: 0x00017213
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700121E RID: 4638
			// (get) Token: 0x06003B83 RID: 15235 RVA: 0x000EFD04 File Offset: 0x000EDF04
			// (set) Token: 0x06003B84 RID: 15236 RVA: 0x0001901C File Offset: 0x0001721C
			public unsafe static PointerUpEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PointerUpEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerUpEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PointerUpEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A03 RID: 10755
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A04 RID: 10756
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A05 RID: 10757
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerUpEvent_0;
		}

		// Token: 0x02000446 RID: 1094
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
