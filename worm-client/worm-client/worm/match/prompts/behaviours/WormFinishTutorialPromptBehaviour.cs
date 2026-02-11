using System;
using boardgames.match.behaviours;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000D6 RID: 214
	public class WormFinishTutorialPromptBehaviour : TutorialPromptBehaviour
	{
		// Token: 0x06000906 RID: 2310 RVA: 0x00033CE4 File Offset: 0x00031EE4
		// Note: this type is marked as 'beforefieldinit'.
		static WormFinishTutorialPromptBehaviour()
		{
			Il2CppClassPointerStore<WormFinishTutorialPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormFinishTutorialPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFinishTutorialPromptBehaviour>.NativeClassPtr);
			WormFinishTutorialPromptBehaviour.NativeMethodInfoPtr_Event_ExitTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFinishTutorialPromptBehaviour>.NativeClassPtr, 100664524);
			WormFinishTutorialPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFinishTutorialPromptBehaviour>.NativeClassPtr, 100664525);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00033D3C File Offset: 0x00031F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699237, XrefRangeEnd = 699338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ExitTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFinishTutorialPromptBehaviour.NativeMethodInfoPtr_Event_ExitTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00033D70 File Offset: 0x00031F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699338, XrefRangeEnd = 699339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFinishTutorialPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFinishTutorialPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFinishTutorialPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x000069F3 File Offset: 0x00004BF3
		public WormFinishTutorialPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_Event_ExitTutorial_Public_Void_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000332 RID: 818
		[ObfuscatedName("worm.match.prompts.behaviours.WormFinishTutorialPromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002114 RID: 8468 RVA: 0x0007CD74 File Offset: 0x0007AF74
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormFinishTutorialPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormFinishTutorialPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFinishTutorialPromptBehaviour.__c>.NativeClassPtr);
				WormFinishTutorialPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFinishTutorialPromptBehaviour.__c>.NativeClassPtr, "<>9");
				WormFinishTutorialPromptBehaviour.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFinishTutorialPromptBehaviour.__c>.NativeClassPtr, "<>9__0_0");
				WormFinishTutorialPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFinishTutorialPromptBehaviour.__c>.NativeClassPtr, 100664527);
				WormFinishTutorialPromptBehaviour.__c.NativeMethodInfoPtr__Event_ExitTutorial_b__0_0_Internal_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFinishTutorialPromptBehaviour.__c>.NativeClassPtr, 100664528);
			}

			// Token: 0x06002115 RID: 8469 RVA: 0x0007CDF0 File Offset: 0x0007AFF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFinishTutorialPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFinishTutorialPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002116 RID: 8470 RVA: 0x0007CE2C File Offset: 0x0007B02C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699235, XrefRangeEnd = 699237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_ExitTutorial_b__0_0(MatchInitData match)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFinishTutorialPromptBehaviour.__c.NativeMethodInfoPtr__Event_ExitTutorial_b__0_0_Internal_Boolean_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002117 RID: 8471 RVA: 0x000129D5 File Offset: 0x00010BD5
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700091B RID: 2331
			// (get) Token: 0x06002118 RID: 8472 RVA: 0x0007CE7C File Offset: 0x0007B07C
			// (set) Token: 0x06002119 RID: 8473 RVA: 0x000129DE File Offset: 0x00010BDE
			public unsafe static WormFinishTutorialPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormFinishTutorialPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormFinishTutorialPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormFinishTutorialPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091C RID: 2332
			// (get) Token: 0x0600211A RID: 8474 RVA: 0x0007CEA4 File Offset: 0x0007B0A4
			// (set) Token: 0x0600211B RID: 8475 RVA: 0x000129F0 File Offset: 0x00010BF0
			public unsafe static Func<MatchInitData, bool> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormFinishTutorialPromptBehaviour.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormFinishTutorialPromptBehaviour.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001310 RID: 4880
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001311 RID: 4881
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04001312 RID: 4882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001313 RID: 4883
			private static readonly IntPtr NativeMethodInfoPtr__Event_ExitTutorial_b__0_0_Internal_Boolean_MatchInitData_0;
		}
	}
}
