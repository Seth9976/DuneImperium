using System;
using Canis;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.entities
{
	// Token: 0x02000037 RID: 55
	public class WormTechNegotiationArea : WormPlayArea
	{
		// Token: 0x060004DD RID: 1245 RVA: 0x0007D72C File Offset: 0x0007B92C
		// Note: this type is marked as 'beforefieldinit'.
		static WormTechNegotiationArea()
		{
			Il2CppClassPointerStore<WormTechNegotiationArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormTechNegotiationArea");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechNegotiationArea>.NativeClassPtr);
			WormTechNegotiationArea.NativeMethodInfoPtr_get_Negotiators_Public_get_IEnumerable_1_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechNegotiationArea>.NativeClassPtr, 100664631);
			WormTechNegotiationArea.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechNegotiationArea>.NativeClassPtr, 100664632);
			WormTechNegotiationArea.NativeMethodInfoPtr_Initialize_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechNegotiationArea>.NativeClassPtr, 100664633);
			WormTechNegotiationArea.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechNegotiationArea>.NativeClassPtr, 100664634);
			WormTechNegotiationArea.NativeMethodInfoPtr_GetPlayerNegotiators_Public_WormPlayArea_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechNegotiationArea>.NativeClassPtr, 100664635);
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x0007D7C0 File Offset: 0x0007B9C0
		public unsafe IEnumerable<WormPlayArea> Negotiators
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47809, XrefRangeEnd = 47830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechNegotiationArea.NativeMethodInfoPtr_get_Negotiators_Public_get_IEnumerable_1_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormPlayArea>>(intPtr3) : null;
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0007D800 File Offset: 0x0007BA00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 47848, RefRangeEnd = 47850, XrefRangeStart = 47830, XrefRangeEnd = 47848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTechNegotiationArea(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechNegotiationArea>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechNegotiationArea.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0007D84C File Offset: 0x0007BA4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47905, RefRangeEnd = 47906, XrefRangeStart = 47850, XrefRangeEnd = 47905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(WormMatch m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechNegotiationArea.NativeMethodInfoPtr_Initialize_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0007D890 File Offset: 0x0007BA90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47907, RefRangeEnd = 47908, XrefRangeStart = 47906, XrefRangeEnd = 47907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTechNegotiationArea(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechNegotiationArea>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechNegotiationArea.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0007D900 File Offset: 0x0007BB00
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 47944, RefRangeEnd = 47958, XrefRangeStart = 47908, XrefRangeEnd = 47944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayArea GetPlayerNegotiators(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechNegotiationArea.NativeMethodInfoPtr_GetPlayerNegotiators_Public_WormPlayArea_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00003CD9 File Offset: 0x00001ED9
		public WormTechNegotiationArea(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_get_Negotiators_Public_get_IEnumerable_1_WormPlayArea_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_WormMatch_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerNegotiators_Public_WormPlayArea_WormPlayer_0;

		// Token: 0x020005D4 RID: 1492
		[ObfuscatedName("worm.canis.entities.WormTechNegotiationArea+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004880 RID: 18560 RVA: 0x0018ECB0 File Offset: 0x0018CEB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormTechNegotiationArea.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTechNegotiationArea>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechNegotiationArea.__c>.NativeClassPtr);
				WormTechNegotiationArea.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechNegotiationArea.__c>.NativeClassPtr, "<>9");
				WormTechNegotiationArea.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechNegotiationArea.__c>.NativeClassPtr, "<>9__1_0");
				WormTechNegotiationArea.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechNegotiationArea.__c>.NativeClassPtr, 100664637);
				WormTechNegotiationArea.__c.NativeMethodInfoPtr__get_Negotiators_b__1_0_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechNegotiationArea.__c>.NativeClassPtr, 100664638);
			}

			// Token: 0x06004881 RID: 18561 RVA: 0x0018ED2C File Offset: 0x0018CF2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechNegotiationArea.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechNegotiationArea.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004882 RID: 18562 RVA: 0x0018ED68 File Offset: 0x0018CF68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47804, XrefRangeEnd = 47809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_Negotiators_b__1_0(WormPlayArea _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechNegotiationArea.__c.NativeMethodInfoPtr__get_Negotiators_b__1_0_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004883 RID: 18563 RVA: 0x000188C8 File Offset: 0x00016AC8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700118B RID: 4491
			// (get) Token: 0x06004884 RID: 18564 RVA: 0x0018EDB8 File Offset: 0x0018CFB8
			// (set) Token: 0x06004885 RID: 18565 RVA: 0x000188D1 File Offset: 0x00016AD1
			public unsafe static WormTechNegotiationArea.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTechNegotiationArea.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTechNegotiationArea.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTechNegotiationArea.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700118C RID: 4492
			// (get) Token: 0x06004886 RID: 18566 RVA: 0x0018EDE0 File Offset: 0x0018CFE0
			// (set) Token: 0x06004887 RID: 18567 RVA: 0x000188E3 File Offset: 0x00016AE3
			public unsafe static Func<WormPlayArea, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTechNegotiationArea.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTechNegotiationArea.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002FA8 RID: 12200
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002FA9 RID: 12201
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04002FAA RID: 12202
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002FAB RID: 12203
			private static readonly IntPtr NativeMethodInfoPtr__get_Negotiators_b__1_0_Internal_Boolean_WormPlayArea_0;
		}

		// Token: 0x020005D5 RID: 1493
		[ObfuscatedName("worm.canis.entities.WormTechNegotiationArea+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06004888 RID: 18568 RVA: 0x0018EE08 File Offset: 0x0018D008
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<WormTechNegotiationArea.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTechNegotiationArea>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechNegotiationArea.__c__DisplayClass5_0>.NativeClassPtr);
				WormTechNegotiationArea.__c__DisplayClass5_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechNegotiationArea.__c__DisplayClass5_0>.NativeClassPtr, "player");
				WormTechNegotiationArea.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechNegotiationArea.__c__DisplayClass5_0>.NativeClassPtr, 100664639);
				WormTechNegotiationArea.__c__DisplayClass5_0.NativeMethodInfoPtr__GetPlayerNegotiators_b__0_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechNegotiationArea.__c__DisplayClass5_0>.NativeClassPtr, 100664640);
			}

			// Token: 0x06004889 RID: 18569 RVA: 0x0018EE70 File Offset: 0x0018D070
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechNegotiationArea.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechNegotiationArea.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600488A RID: 18570 RVA: 0x0018EEAC File Offset: 0x0018D0AC
			[CallerCount(0)]
			public unsafe bool _GetPlayerNegotiators_b__0(WormPlayArea negotiators)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(negotiators);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechNegotiationArea.__c__DisplayClass5_0.NativeMethodInfoPtr__GetPlayerNegotiators_b__0_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600488B RID: 18571 RVA: 0x000188F5 File Offset: 0x00016AF5
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700118D RID: 4493
			// (get) Token: 0x0600488C RID: 18572 RVA: 0x0018EEFC File Offset: 0x0018D0FC
			// (set) Token: 0x0600488D RID: 18573 RVA: 0x000188FE File Offset: 0x00016AFE
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechNegotiationArea.__c__DisplayClass5_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechNegotiationArea.__c__DisplayClass5_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002FAC RID: 12204
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002FAD RID: 12205
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002FAE RID: 12206
			private static readonly IntPtr NativeMethodInfoPtr__GetPlayerNegotiators_b__0_Internal_Boolean_WormPlayArea_0;
		}
	}
}
