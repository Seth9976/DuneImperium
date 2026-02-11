using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lib.canis.boardgames.src.match;
using TMPro;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000105 RID: 261
	public class WormChallengeProgressRenderer : VersionedView<WormChallengeProgressData>
	{
		// Token: 0x06000BAC RID: 2988 RVA: 0x0003B69C File Offset: 0x0003989C
		// Note: this type is marked as 'beforefieldinit'.
		static WormChallengeProgressRenderer()
		{
			Il2CppClassPointerStore<WormChallengeProgressRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormChallengeProgressRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChallengeProgressRenderer>.NativeClassPtr);
			WormChallengeProgressRenderer.NativeFieldInfoPtr_progressText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressRenderer>.NativeClassPtr, "progressText");
			WormChallengeProgressRenderer.NativeFieldInfoPtr_scenarioName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressRenderer>.NativeClassPtr, "scenarioName");
			WormChallengeProgressRenderer.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressRenderer>.NativeClassPtr, "archetypeProvider");
			WormChallengeProgressRenderer.NativeMethodInfoPtr_Initialize_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressRenderer>.NativeClassPtr, 100664897);
			WormChallengeProgressRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressRenderer>.NativeClassPtr, 100664898);
			WormChallengeProgressRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressRenderer>.NativeClassPtr, 100664899);
			WormChallengeProgressRenderer.NativeMethodInfoPtr__dirtyUpdate_b__4_3_Private_Boolean_KeyValuePair_2_ArchetypeID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressRenderer>.NativeClassPtr, 100664900);
			WormChallengeProgressRenderer.NativeMethodInfoPtr__dirtyUpdate_b__4_5_Private_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressRenderer>.NativeClassPtr, 100664901);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0003B76C File Offset: 0x0003996C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 703417, RefRangeEnd = 703418, XrefRangeStart = 703398, XrefRangeEnd = 703417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string scenario)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scenario);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressRenderer.NativeMethodInfoPtr_Initialize_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0003B7B0 File Offset: 0x000399B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703418, XrefRangeEnd = 703574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormChallengeProgressRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0003B7EC File Offset: 0x000399EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703574, XrefRangeEnd = 703577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormChallengeProgressRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChallengeProgressRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0003B828 File Offset: 0x00039A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703577, XrefRangeEnd = 703592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__4_3(KeyValuePair<ArchetypeID, int> s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressRenderer.NativeMethodInfoPtr__dirtyUpdate_b__4_3_Private_Boolean_KeyValuePair_2_ArchetypeID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0003B87C File Offset: 0x00039A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703592, XrefRangeEnd = 703613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__4_5(ArchetypeID c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressRenderer.NativeMethodInfoPtr__dirtyUpdate_b__4_5_Private_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0000829D File Offset: 0x0000649D
		public WormChallengeProgressRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x0003B8CC File Offset: 0x00039ACC
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x000082A6 File Offset: 0x000064A6
		public unsafe TMP_Text progressText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressRenderer.NativeFieldInfoPtr_progressText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressRenderer.NativeFieldInfoPtr_progressText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x0003B8FC File Offset: 0x00039AFC
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x000082C5 File Offset: 0x000064C5
		public unsafe string scenarioName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressRenderer.NativeFieldInfoPtr_scenarioName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressRenderer.NativeFieldInfoPtr_scenarioName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0003B924 File Offset: 0x00039B24
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x000082E4 File Offset: 0x000064E4
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressRenderer.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressRenderer.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeFieldInfoPtr_progressText;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeFieldInfoPtr_scenarioName;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__4_3_Private_Boolean_KeyValuePair_2_ArchetypeID_Int32_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__4_5_Private_Boolean_ArchetypeID_0;

		// Token: 0x02000367 RID: 871
		[ObfuscatedName("worm.match.dataRenderers.WormChallengeProgressRenderer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600231A RID: 8986 RVA: 0x00082B28 File Offset: 0x00080D28
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormChallengeProgressRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChallengeProgressRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChallengeProgressRenderer.__c>.NativeClassPtr);
				WormChallengeProgressRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressRenderer.__c>.NativeClassPtr, "<>9");
				WormChallengeProgressRenderer.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressRenderer.__c>.NativeClassPtr, "<>9__4_2");
				WormChallengeProgressRenderer.__c.NativeFieldInfoPtr___9__4_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressRenderer.__c>.NativeClassPtr, "<>9__4_4");
				WormChallengeProgressRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressRenderer.__c>.NativeClassPtr, 100664903);
				WormChallengeProgressRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__4_2_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressRenderer.__c>.NativeClassPtr, 100664904);
				WormChallengeProgressRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__4_4_Internal_Boolean_KeyValuePair_2_ArchetypeID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressRenderer.__c>.NativeClassPtr, 100664905);
			}

			// Token: 0x0600231B RID: 8987 RVA: 0x00082BCC File Offset: 0x00080DCC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChallengeProgressRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600231C RID: 8988 RVA: 0x00082C08 File Offset: 0x00080E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703377, XrefRangeEnd = 703389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__4_2(EntityComponent token)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__4_2_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600231D RID: 8989 RVA: 0x00082C58 File Offset: 0x00080E58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703389, XrefRangeEnd = 703390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__4_4(KeyValuePair<ArchetypeID, int> s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__4_4_Internal_Boolean_KeyValuePair_2_ArchetypeID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600231E RID: 8990 RVA: 0x000139DD File Offset: 0x00011BDD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009AE RID: 2478
			// (get) Token: 0x0600231F RID: 8991 RVA: 0x00082CAC File Offset: 0x00080EAC
			// (set) Token: 0x06002320 RID: 8992 RVA: 0x000139E6 File Offset: 0x00011BE6
			public unsafe static WormChallengeProgressRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormChallengeProgressRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormChallengeProgressRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormChallengeProgressRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009AF RID: 2479
			// (get) Token: 0x06002321 RID: 8993 RVA: 0x00082CD4 File Offset: 0x00080ED4
			// (set) Token: 0x06002322 RID: 8994 RVA: 0x000139F8 File Offset: 0x00011BF8
			public unsafe static Func<EntityComponent, bool> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormChallengeProgressRenderer.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormChallengeProgressRenderer.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B0 RID: 2480
			// (get) Token: 0x06002323 RID: 8995 RVA: 0x00082CFC File Offset: 0x00080EFC
			// (set) Token: 0x06002324 RID: 8996 RVA: 0x00013A0A File Offset: 0x00011C0A
			public unsafe static Func<KeyValuePair<ArchetypeID, int>, bool> __9__4_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormChallengeProgressRenderer.__c.NativeFieldInfoPtr___9__4_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<ArchetypeID, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormChallengeProgressRenderer.__c.NativeFieldInfoPtr___9__4_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400142D RID: 5165
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400142E RID: 5166
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x0400142F RID: 5167
			private static readonly IntPtr NativeFieldInfoPtr___9__4_4;

			// Token: 0x04001430 RID: 5168
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001431 RID: 5169
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__4_2_Internal_Boolean_EntityComponent_0;

			// Token: 0x04001432 RID: 5170
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__4_4_Internal_Boolean_KeyValuePair_2_ArchetypeID_Int32_0;
		}

		// Token: 0x02000368 RID: 872
		[ObfuscatedName("worm.match.dataRenderers.WormChallengeProgressRenderer+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06002325 RID: 8997 RVA: 0x00082D24 File Offset: 0x00080F24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<WormChallengeProgressRenderer.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChallengeProgressRenderer>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChallengeProgressRenderer.__c__DisplayClass4_0>.NativeClassPtr);
				WormChallengeProgressRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_solari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressRenderer.__c__DisplayClass4_0>.NativeClassPtr, "solari");
				WormChallengeProgressRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressRenderer.__c__DisplayClass4_0>.NativeClassPtr, 100664906);
				WormChallengeProgressRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressRenderer.__c__DisplayClass4_0>.NativeClassPtr, 100664907);
				WormChallengeProgressRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressRenderer.__c__DisplayClass4_0>.NativeClassPtr, 100664908);
			}

			// Token: 0x06002326 RID: 8998 RVA: 0x00082DA0 File Offset: 0x00080FA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChallengeProgressRenderer.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002327 RID: 8999 RVA: 0x00082DDC File Offset: 0x00080FDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703390, XrefRangeEnd = 703394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__0(IAttribute<Nullable<int>> s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002328 RID: 9000 RVA: 0x00082E2C File Offset: 0x0008102C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703394, XrefRangeEnd = 703398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__1(IAttribute<Nullable<int>> s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002329 RID: 9001 RVA: 0x00013A1C File Offset: 0x00011C1C
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009B1 RID: 2481
			// (get) Token: 0x0600232A RID: 9002 RVA: 0x00082E7C File Offset: 0x0008107C
			// (set) Token: 0x0600232B RID: 9003 RVA: 0x00013A25 File Offset: 0x00011C25
			public unsafe int solari
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_solari);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_solari)) = value;
				}
			}

			// Token: 0x04001433 RID: 5171
			private static readonly IntPtr NativeFieldInfoPtr_solari;

			// Token: 0x04001434 RID: 5172
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001435 RID: 5173
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_IAttribute_1_Nullable_1_Int32_0;

			// Token: 0x04001436 RID: 5174
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_IAttribute_1_Nullable_1_Int32_0;
		}
	}
}
