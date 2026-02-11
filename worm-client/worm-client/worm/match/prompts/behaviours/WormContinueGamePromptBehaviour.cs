using System;
using boardgames.menus.prompts;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using zen.src.matchMaking.commands;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000CA RID: 202
	public class WormContinueGamePromptBehaviour : ContinueGamePromptBehaviour
	{
		// Token: 0x0600087E RID: 2174 RVA: 0x0003234C File Offset: 0x0003054C
		// Note: this type is marked as 'beforefieldinit'.
		static WormContinueGamePromptBehaviour()
		{
			Il2CppClassPointerStore<WormContinueGamePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormContinueGamePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormContinueGamePromptBehaviour>.NativeClassPtr);
			WormContinueGamePromptBehaviour.NativeMethodInfoPtr_OnGotReconnectableGames_Protected_Virtual_Void_GetReconnectableGames_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContinueGamePromptBehaviour>.NativeClassPtr, 100664453);
			WormContinueGamePromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContinueGamePromptBehaviour>.NativeClassPtr, 100664454);
			WormContinueGamePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContinueGamePromptBehaviour>.NativeClassPtr, 100664455);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000323B8 File Offset: 0x000305B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698504, XrefRangeEnd = 698527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGotReconnectableGames(GetReconnectableGames command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormContinueGamePromptBehaviour.NativeMethodInfoPtr_OnGotReconnectableGames_Protected_Virtual_Void_GetReconnectableGames_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00032408 File Offset: 0x00030608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698527, XrefRangeEnd = 698532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContinueGamePromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0003243C File Offset: 0x0003063C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698532, XrefRangeEnd = 698533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormContinueGamePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormContinueGamePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContinueGamePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0000658D File Offset: 0x0000478D
		public WormContinueGamePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_OnGotReconnectableGames_Protected_Virtual_Void_GetReconnectableGames_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_Event_Back_Public_Void_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200032D RID: 813
		[ObfuscatedName("worm.match.prompts.behaviours.WormContinueGamePromptBehaviour+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060020D4 RID: 8404 RVA: 0x0007C198 File Offset: 0x0007A398
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormContinueGamePromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormContinueGamePromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormContinueGamePromptBehaviour.__c>.NativeClassPtr);
				WormContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContinueGamePromptBehaviour.__c>.NativeClassPtr, "<>9");
				WormContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContinueGamePromptBehaviour.__c>.NativeClassPtr, "<>9__0_0");
				WormContinueGamePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContinueGamePromptBehaviour.__c>.NativeClassPtr, 100664457);
				WormContinueGamePromptBehaviour.__c.NativeMethodInfoPtr__OnGotReconnectableGames_b__0_0_Internal_Boolean_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContinueGamePromptBehaviour.__c>.NativeClassPtr, 100664458);
			}

			// Token: 0x060020D5 RID: 8405 RVA: 0x0007C214 File Offset: 0x0007A414
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormContinueGamePromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContinueGamePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020D6 RID: 8406 RVA: 0x0007C250 File Offset: 0x0007A450
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698495, XrefRangeEnd = 698504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnGotReconnectableGames_b__0_0(SaveMetaData game)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContinueGamePromptBehaviour.__c.NativeMethodInfoPtr__OnGotReconnectableGames_b__0_0_Internal_Boolean_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060020D7 RID: 8407 RVA: 0x000127E6 File Offset: 0x000109E6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000905 RID: 2309
			// (get) Token: 0x060020D8 RID: 8408 RVA: 0x0007C2A0 File Offset: 0x0007A4A0
			// (set) Token: 0x060020D9 RID: 8409 RVA: 0x000127EF File Offset: 0x000109EF
			public unsafe static WormContinueGamePromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormContinueGamePromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000906 RID: 2310
			// (get) Token: 0x060020DA RID: 8410 RVA: 0x0007C2C8 File Offset: 0x0007A4C8
			// (set) Token: 0x060020DB RID: 8411 RVA: 0x00012801 File Offset: 0x00010A01
			public unsafe static Func<SaveMetaData, bool> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SaveMetaData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012EA RID: 4842
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040012EB RID: 4843
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x040012EC RID: 4844
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012ED RID: 4845
			private static readonly IntPtr NativeMethodInfoPtr__OnGotReconnectableGames_b__0_0_Internal_Boolean_SaveMetaData_0;
		}
	}
}
