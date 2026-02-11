using System;
using Canis.messages;
using dwd.core.ui.prompt.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace boardgames.match.behaviours
{
	// Token: 0x02000282 RID: 642
	public class KickObserversButton : MonoBehaviour
	{
		// Token: 0x06001E0C RID: 7692 RVA: 0x00081C40 File Offset: 0x0007FE40
		// Note: this type is marked as 'beforefieldinit'.
		static KickObserversButton()
		{
			Il2CppClassPointerStore<KickObserversButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.behaviours", "KickObserversButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KickObserversButton>.NativeClassPtr);
			KickObserversButton.NativeFieldInfoPtr_observersProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KickObserversButton>.NativeClassPtr, "observersProvider");
			KickObserversButton.NativeFieldInfoPtr_promptCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KickObserversButton>.NativeClassPtr, "promptCoroutine");
			KickObserversButton.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KickObserversButton>.NativeClassPtr, 100668222);
			KickObserversButton.NativeMethodInfoPtr_Event_Click_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KickObserversButton>.NativeClassPtr, 100668223);
			KickObserversButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KickObserversButton>.NativeClassPtr, 100668224);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00081CD4 File Offset: 0x0007FED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538269, XrefRangeEnd = 538273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KickObserversButton.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00081D08 File Offset: 0x0007FF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538273, XrefRangeEnd = 538361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Click()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KickObserversButton.NativeMethodInfoPtr_Event_Click_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00081D3C File Offset: 0x0007FF3C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KickObserversButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KickObserversButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KickObserversButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x0000FDB5 File Offset: 0x0000DFB5
		public KickObserversButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x00081D78 File Offset: 0x0007FF78
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x0000FDBE File Offset: 0x0000DFBE
		public unsafe ObserversProvider observersProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KickObserversButton.NativeFieldInfoPtr_observersProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObserversProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KickObserversButton.NativeFieldInfoPtr_observersProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x00081DA8 File Offset: 0x0007FFA8
		// (set) Token: 0x06001E14 RID: 7700 RVA: 0x0000FDDD File Offset: 0x0000DFDD
		public unsafe Coroutine promptCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KickObserversButton.NativeFieldInfoPtr_promptCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KickObserversButton.NativeFieldInfoPtr_promptCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeFieldInfoPtr_observersProvider;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeFieldInfoPtr_promptCoroutine;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr_Event_Click_Public_Void_0;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000471 RID: 1137
		[ObfuscatedName("boardgames.match.behaviours.KickObserversButton+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060035DA RID: 13786 RVA: 0x000C95C8 File Offset: 0x000C77C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KickObserversButton.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KickObserversButton>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KickObserversButton.__c>.NativeClassPtr);
				KickObserversButton.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KickObserversButton.__c>.NativeClassPtr, "<>9");
				KickObserversButton.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KickObserversButton.__c>.NativeClassPtr, "<>9__3_0");
				KickObserversButton.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KickObserversButton.__c>.NativeClassPtr, 100668226);
				KickObserversButton.__c.NativeMethodInfoPtr__Event_Click_b__3_0_Internal_String_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KickObserversButton.__c>.NativeClassPtr, 100668227);
			}

			// Token: 0x060035DB RID: 13787 RVA: 0x000C9644 File Offset: 0x000C7844
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KickObserversButton.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KickObserversButton.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035DC RID: 13788 RVA: 0x000C9680 File Offset: 0x000C7880
			[CallerCount(0)]
			public unsafe string _Event_Click_b__3_0(AccountIDUsernameMetadata o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KickObserversButton.__c.NativeMethodInfoPtr__Event_Click_b__3_0_Internal_String_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060035DD RID: 13789 RVA: 0x0001BC32 File Offset: 0x00019E32
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FCE RID: 4046
			// (get) Token: 0x060035DE RID: 13790 RVA: 0x000C96C8 File Offset: 0x000C78C8
			// (set) Token: 0x060035DF RID: 13791 RVA: 0x0001BC3B File Offset: 0x00019E3B
			public unsafe static KickObserversButton.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KickObserversButton.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KickObserversButton.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KickObserversButton.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FCF RID: 4047
			// (get) Token: 0x060035E0 RID: 13792 RVA: 0x000C96F0 File Offset: 0x000C78F0
			// (set) Token: 0x060035E1 RID: 13793 RVA: 0x0001BC4D File Offset: 0x00019E4D
			public unsafe static Func<AccountIDUsernameMetadata, string> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KickObserversButton.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountIDUsernameMetadata, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KickObserversButton.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002129 RID: 8489
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400212A RID: 8490
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400212B RID: 8491
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400212C RID: 8492
			private static readonly IntPtr NativeMethodInfoPtr__Event_Click_b__3_0_Internal_String_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000472 RID: 1138
		[ObfuscatedName("boardgames.match.behaviours.KickObserversButton+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060035E2 RID: 13794 RVA: 0x000C9718 File Offset: 0x000C7918
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<KickObserversButton.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KickObserversButton>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KickObserversButton.__c__DisplayClass3_0>.NativeClassPtr);
				KickObserversButton.__c__DisplayClass3_0.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KickObserversButton.__c__DisplayClass3_0>.NativeClassPtr, "prompt");
				KickObserversButton.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KickObserversButton.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				KickObserversButton.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KickObserversButton.__c__DisplayClass3_0>.NativeClassPtr, 100668228);
				KickObserversButton.__c__DisplayClass3_0.NativeMethodInfoPtr__Event_Click_b__1_Internal_Void_DisplayGenericPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KickObserversButton.__c__DisplayClass3_0>.NativeClassPtr, 100668229);
			}

			// Token: 0x060035E3 RID: 13795 RVA: 0x000C9794 File Offset: 0x000C7994
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KickObserversButton.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KickObserversButton.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035E4 RID: 13796 RVA: 0x000C97D0 File Offset: 0x000C79D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538249, XrefRangeEnd = 538269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Event_Click_b__1(DisplayGenericPrompt _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KickObserversButton.__c__DisplayClass3_0.NativeMethodInfoPtr__Event_Click_b__1_Internal_Void_DisplayGenericPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060035E5 RID: 13797 RVA: 0x0001BC5F File Offset: 0x00019E5F
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FD0 RID: 4048
			// (get) Token: 0x060035E6 RID: 13798 RVA: 0x000C9814 File Offset: 0x000C7A14
			// (set) Token: 0x060035E7 RID: 13799 RVA: 0x0001BC68 File Offset: 0x00019E68
			public unsafe ConfirmOrDenyPrompt prompt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KickObserversButton.__c__DisplayClass3_0.NativeFieldInfoPtr_prompt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KickObserversButton.__c__DisplayClass3_0.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD1 RID: 4049
			// (get) Token: 0x060035E8 RID: 13800 RVA: 0x000C9844 File Offset: 0x000C7A44
			// (set) Token: 0x060035E9 RID: 13801 RVA: 0x0001BC87 File Offset: 0x00019E87
			public unsafe KickObserversButton __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KickObserversButton.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KickObserversButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KickObserversButton.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400212D RID: 8493
			private static readonly IntPtr NativeFieldInfoPtr_prompt;

			// Token: 0x0400212E RID: 8494
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400212F RID: 8495
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002130 RID: 8496
			private static readonly IntPtr NativeMethodInfoPtr__Event_Click_b__1_Internal_Void_DisplayGenericPrompt_0;
		}
	}
}
