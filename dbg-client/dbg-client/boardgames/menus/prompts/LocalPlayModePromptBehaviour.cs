using System;
using boardgames.menus.commands;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.menus.prompts
{
	// Token: 0x020001D3 RID: 467
	public class LocalPlayModePromptBehaviour : PromptBehaviour<LocalPlayModePrompt>
	{
		// Token: 0x06001559 RID: 5465 RVA: 0x00062B80 File Offset: 0x00060D80
		// Note: this type is marked as 'beforefieldinit'.
		static LocalPlayModePromptBehaviour()
		{
			Il2CppClassPointerStore<LocalPlayModePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "LocalPlayModePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPlayModePromptBehaviour>.NativeClassPtr);
			LocalPlayModePromptBehaviour.NativeMethodInfoPtr_Event_SinglePlayer_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayModePromptBehaviour>.NativeClassPtr, 100666438);
			LocalPlayModePromptBehaviour.NativeMethodInfoPtr_Event_PlayPassAndPlay_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayModePromptBehaviour>.NativeClassPtr, 100666439);
			LocalPlayModePromptBehaviour.NativeMethodInfoPtr_Event_Challenges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayModePromptBehaviour>.NativeClassPtr, 100666440);
			LocalPlayModePromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayModePromptBehaviour>.NativeClassPtr, 100666441);
			LocalPlayModePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayModePromptBehaviour>.NativeClassPtr, 100666442);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00062C14 File Offset: 0x00060E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522307, XrefRangeEnd = 522334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SinglePlayer(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayModePromptBehaviour.NativeMethodInfoPtr_Event_SinglePlayer_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00062C58 File Offset: 0x00060E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522334, XrefRangeEnd = 522361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_PlayPassAndPlay(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayModePromptBehaviour.NativeMethodInfoPtr_Event_PlayPassAndPlay_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00062C9C File Offset: 0x00060E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522361, XrefRangeEnd = 522366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Challenges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayModePromptBehaviour.NativeMethodInfoPtr_Event_Challenges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00062CD0 File Offset: 0x00060ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522366, XrefRangeEnd = 522371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayModePromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00062D04 File Offset: 0x00060F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522371, XrefRangeEnd = 522374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalPlayModePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPlayModePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayModePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0000C0AA File Offset: 0x0000A2AA
		public LocalPlayModePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_Event_SinglePlayer_Public_Void_DataComposition_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_Event_PlayPassAndPlay_Public_Void_DataComposition_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_Event_Challenges_Public_Void_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_Event_Back_Public_Void_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003C2 RID: 962
		[ObfuscatedName("boardgames.menus.prompts.LocalPlayModePromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002CD7 RID: 11479 RVA: 0x000AE6B8 File Offset: 0x000AC8B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LocalPlayModePromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalPlayModePromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPlayModePromptBehaviour.__c>.NativeClassPtr);
				LocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayModePromptBehaviour.__c>.NativeClassPtr, "<>9");
				LocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayModePromptBehaviour.__c>.NativeClassPtr, "<>9__0_0");
				LocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayModePromptBehaviour.__c>.NativeClassPtr, "<>9__1_0");
				LocalPlayModePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayModePromptBehaviour.__c>.NativeClassPtr, 100666444);
				LocalPlayModePromptBehaviour.__c.NativeMethodInfoPtr__Event_SinglePlayer_b__0_0_Internal_IFailable_RunConfigureOfflineMatchFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayModePromptBehaviour.__c>.NativeClassPtr, 100666445);
				LocalPlayModePromptBehaviour.__c.NativeMethodInfoPtr__Event_PlayPassAndPlay_b__1_0_Internal_IFailable_RunConfigureOfflineMatchFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayModePromptBehaviour.__c>.NativeClassPtr, 100666446);
			}

			// Token: 0x06002CD8 RID: 11480 RVA: 0x000AE75C File Offset: 0x000AC95C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPlayModePromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayModePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CD9 RID: 11481 RVA: 0x000AE798 File Offset: 0x000AC998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522295, XrefRangeEnd = 522301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _Event_SinglePlayer_b__0_0(RunConfigureOfflineMatchFlow _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayModePromptBehaviour.__c.NativeMethodInfoPtr__Event_SinglePlayer_b__0_0_Internal_IFailable_RunConfigureOfflineMatchFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
				}
			}

			// Token: 0x06002CDA RID: 11482 RVA: 0x000AE7E8 File Offset: 0x000AC9E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522301, XrefRangeEnd = 522307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _Event_PlayPassAndPlay_b__1_0(RunConfigureOfflineMatchFlow _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayModePromptBehaviour.__c.NativeMethodInfoPtr__Event_PlayPassAndPlay_b__1_0_Internal_IFailable_RunConfigureOfflineMatchFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
				}
			}

			// Token: 0x06002CDB RID: 11483 RVA: 0x0001737A File Offset: 0x0001557A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CBA RID: 3258
			// (get) Token: 0x06002CDC RID: 11484 RVA: 0x000AE838 File Offset: 0x000ACA38
			// (set) Token: 0x06002CDD RID: 11485 RVA: 0x00017383 File Offset: 0x00015583
			public unsafe static LocalPlayModePromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalPlayModePromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CBB RID: 3259
			// (get) Token: 0x06002CDE RID: 11486 RVA: 0x000AE860 File Offset: 0x000ACA60
			// (set) Token: 0x06002CDF RID: 11487 RVA: 0x00017395 File Offset: 0x00015595
			public unsafe static Func<RunConfigureOfflineMatchFlow, IFailable> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RunConfigureOfflineMatchFlow, IFailable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CBC RID: 3260
			// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x000AE888 File Offset: 0x000ACA88
			// (set) Token: 0x06002CE1 RID: 11489 RVA: 0x000173A7 File Offset: 0x000155A7
			public unsafe static Func<RunConfigureOfflineMatchFlow, IFailable> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RunConfigureOfflineMatchFlow, IFailable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BD5 RID: 7125
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001BD6 RID: 7126
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04001BD7 RID: 7127
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001BD8 RID: 7128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BD9 RID: 7129
			private static readonly IntPtr NativeMethodInfoPtr__Event_SinglePlayer_b__0_0_Internal_IFailable_RunConfigureOfflineMatchFlow_0;

			// Token: 0x04001BDA RID: 7130
			private static readonly IntPtr NativeMethodInfoPtr__Event_PlayPassAndPlay_b__1_0_Internal_IFailable_RunConfigureOfflineMatchFlow_0;
		}
	}
}
