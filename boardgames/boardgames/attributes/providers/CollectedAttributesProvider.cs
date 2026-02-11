using System;
using Canis.attributes;
using Canis.attributes.meta;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.attributes.providers
{
	// Token: 0x0200016A RID: 362
	public class CollectedAttributesProvider : MonoBehaviour
	{
		// Token: 0x06001240 RID: 4672 RVA: 0x00049120 File Offset: 0x00047320
		// Note: this type is marked as 'beforefieldinit'.
		static CollectedAttributesProvider()
		{
			Il2CppClassPointerStore<CollectedAttributesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes.providers", "CollectedAttributesProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectedAttributesProvider>.NativeClassPtr);
			CollectedAttributesProvider.NativeFieldInfoPtr_references = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedAttributesProvider>.NativeClassPtr, "references");
			CollectedAttributesProvider.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedAttributesProvider>.NativeClassPtr, "attributes");
			CollectedAttributesProvider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedAttributesProvider>.NativeClassPtr, 100665957);
			CollectedAttributesProvider.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedAttributesProvider>.NativeClassPtr, 100665958);
			CollectedAttributesProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedAttributesProvider>.NativeClassPtr, 100665959);
			CollectedAttributesProvider.NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedAttributesProvider>.NativeClassPtr, 100665960);
			CollectedAttributesProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedAttributesProvider>.NativeClassPtr, 100665961);
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x000491DC File Offset: 0x000473DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000759, XrefRangeEnd = 1000774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectedAttributesProvider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00049210 File Offset: 0x00047410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000774, XrefRangeEnd = 1000795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectedAttributesProvider.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00049244 File Offset: 0x00047444
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IHasAttributes GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectedAttributesProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00049284 File Offset: 0x00047484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000795, XrefRangeEnd = 1000813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<IAttributeDefinition> ProvidesAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectedAttributesProvider.NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttributeDefinition>>(intPtr3) : null;
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x000492C4 File Offset: 0x000474C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000813, XrefRangeEnd = 1000818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectedAttributesProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectedAttributesProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectedAttributesProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0000A89A File Offset: 0x00008A9A
		public CollectedAttributesProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00049300 File Offset: 0x00047500
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x0000A8A3 File Offset: 0x00008AA3
		public unsafe Il2CppReferenceArray<CollectedAttributesProvider.AttributeReference> references
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.NativeFieldInfoPtr_references);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CollectedAttributesProvider.AttributeReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.NativeFieldInfoPtr_references), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x00049330 File Offset: 0x00047530
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x0000A8C2 File Offset: 0x00008AC2
		public unsafe MetaAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeFieldInfoPtr_references;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000284 RID: 644
		[Serializable]
		public class AttributeReference : global::Il2CppSystem.Object
		{
			// Token: 0x06001DC7 RID: 7623 RVA: 0x0006CDE0 File Offset: 0x0006AFE0
			// Note: this type is marked as 'beforefieldinit'.
			static AttributeReference()
			{
				Il2CppClassPointerStore<CollectedAttributesProvider.AttributeReference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollectedAttributesProvider>.NativeClassPtr, "AttributeReference");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectedAttributesProvider.AttributeReference>.NativeClassPtr);
				CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedAttributesProvider.AttributeReference>.NativeClassPtr, "provider");
				CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedAttributesProvider.AttributeReference>.NativeClassPtr, "attribute");
				CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_remapAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedAttributesProvider.AttributeReference>.NativeClassPtr, "remapAttribute");
				CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_lastData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedAttributesProvider.AttributeReference>.NativeClassPtr, "lastData");
				CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedAttributesProvider.AttributeReference>.NativeClassPtr, "definition");
				CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_lastAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedAttributesProvider.AttributeReference>.NativeClassPtr, "lastAttribute");
				CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_lastRemapAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedAttributesProvider.AttributeReference>.NativeClassPtr, "lastRemapAttribute");
				CollectedAttributesProvider.AttributeReference.NativeMethodInfoPtr_get_Definition_Public_get_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedAttributesProvider.AttributeReference>.NativeClassPtr, 100665962);
				CollectedAttributesProvider.AttributeReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedAttributesProvider.AttributeReference>.NativeClassPtr, 100665963);
			}

			// Token: 0x170008ED RID: 2285
			// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x0006CEC0 File Offset: 0x0006B0C0
			public unsafe IAttributeDefinition Definition
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 1000753, RefRangeEnd = 1000757, XrefRangeStart = 1000744, XrefRangeEnd = 1000753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectedAttributesProvider.AttributeReference.NativeMethodInfoPtr_get_Definition_Public_get_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttributeDefinition>(intPtr3) : null;
				}
			}

			// Token: 0x06001DC9 RID: 7625 RVA: 0x0006CF00 File Offset: 0x0006B100
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttributeReference()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectedAttributesProvider.AttributeReference>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectedAttributesProvider.AttributeReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DCA RID: 7626 RVA: 0x00010047 File Offset: 0x0000E247
			public AttributeReference(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008E6 RID: 2278
			// (get) Token: 0x06001DCB RID: 7627 RVA: 0x0006CF3C File Offset: 0x0006B13C
			// (set) Token: 0x06001DCC RID: 7628 RVA: 0x00010050 File Offset: 0x0000E250
			public unsafe SerializedInterface<IAttributesProvider> provider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_provider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedInterface<IAttributesProvider>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E7 RID: 2279
			// (get) Token: 0x06001DCD RID: 7629 RVA: 0x0006CF6C File Offset: 0x0006B16C
			// (set) Token: 0x06001DCE RID: 7630 RVA: 0x0001006F File Offset: 0x0000E26F
			public unsafe int attribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_attribute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_attribute)) = value;
				}
			}

			// Token: 0x170008E8 RID: 2280
			// (get) Token: 0x06001DCF RID: 7631 RVA: 0x0006CF94 File Offset: 0x0006B194
			// (set) Token: 0x06001DD0 RID: 7632 RVA: 0x0001008A File Offset: 0x0000E28A
			public unsafe int remapAttribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_remapAttribute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_remapAttribute)) = value;
				}
			}

			// Token: 0x170008E9 RID: 2281
			// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x0006CFBC File Offset: 0x0006B1BC
			// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x000100A5 File Offset: 0x0000E2A5
			public unsafe IHasAttributes lastData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_lastData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_lastData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008EA RID: 2282
			// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x0006CFEC File Offset: 0x0006B1EC
			// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x000100C4 File Offset: 0x0000E2C4
			public unsafe IAttributeDefinition definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttributeDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008EB RID: 2283
			// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x0006D01C File Offset: 0x0006B21C
			// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x000100E3 File Offset: 0x0000E2E3
			public unsafe int lastAttribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_lastAttribute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_lastAttribute)) = value;
				}
			}

			// Token: 0x170008EC RID: 2284
			// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x0006D044 File Offset: 0x0006B244
			// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x000100FE File Offset: 0x0000E2FE
			public unsafe int lastRemapAttribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_lastRemapAttribute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectedAttributesProvider.AttributeReference.NativeFieldInfoPtr_lastRemapAttribute)) = value;
				}
			}

			// Token: 0x0400121E RID: 4638
			private static readonly IntPtr NativeFieldInfoPtr_provider;

			// Token: 0x0400121F RID: 4639
			private static readonly IntPtr NativeFieldInfoPtr_attribute;

			// Token: 0x04001220 RID: 4640
			private static readonly IntPtr NativeFieldInfoPtr_remapAttribute;

			// Token: 0x04001221 RID: 4641
			private static readonly IntPtr NativeFieldInfoPtr_lastData;

			// Token: 0x04001222 RID: 4642
			private static readonly IntPtr NativeFieldInfoPtr_definition;

			// Token: 0x04001223 RID: 4643
			private static readonly IntPtr NativeFieldInfoPtr_lastAttribute;

			// Token: 0x04001224 RID: 4644
			private static readonly IntPtr NativeFieldInfoPtr_lastRemapAttribute;

			// Token: 0x04001225 RID: 4645
			private static readonly IntPtr NativeMethodInfoPtr_get_Definition_Public_get_IAttributeDefinition_0;

			// Token: 0x04001226 RID: 4646
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000285 RID: 645
		[ObfuscatedName("boardgames.attributes.providers.CollectedAttributesProvider+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001DD9 RID: 7641 RVA: 0x0006D06C File Offset: 0x0006B26C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CollectedAttributesProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollectedAttributesProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectedAttributesProvider.__c>.NativeClassPtr);
				CollectedAttributesProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedAttributesProvider.__c>.NativeClassPtr, "<>9");
				CollectedAttributesProvider.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedAttributesProvider.__c>.NativeClassPtr, "<>9__6_0");
				CollectedAttributesProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedAttributesProvider.__c>.NativeClassPtr, 100665965);
				CollectedAttributesProvider.__c.NativeMethodInfoPtr__ProvidesAttributes_b__6_0_Internal_IAttributeDefinition_AttributeReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedAttributesProvider.__c>.NativeClassPtr, 100665966);
			}

			// Token: 0x06001DDA RID: 7642 RVA: 0x0006D0E8 File Offset: 0x0006B2E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectedAttributesProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectedAttributesProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DDB RID: 7643 RVA: 0x0006D124 File Offset: 0x0006B324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000757, XrefRangeEnd = 1000759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAttributeDefinition _ProvidesAttributes_b__6_0(CollectedAttributesProvider.AttributeReference r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectedAttributesProvider.__c.NativeMethodInfoPtr__ProvidesAttributes_b__6_0_Internal_IAttributeDefinition_AttributeReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttributeDefinition>(intPtr3) : null;
				}
			}

			// Token: 0x06001DDC RID: 7644 RVA: 0x00010119 File Offset: 0x0000E319
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008EE RID: 2286
			// (get) Token: 0x06001DDD RID: 7645 RVA: 0x0006D174 File Offset: 0x0006B374
			// (set) Token: 0x06001DDE RID: 7646 RVA: 0x00010122 File Offset: 0x0000E322
			public unsafe static CollectedAttributesProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CollectedAttributesProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollectedAttributesProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CollectedAttributesProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008EF RID: 2287
			// (get) Token: 0x06001DDF RID: 7647 RVA: 0x0006D19C File Offset: 0x0006B39C
			// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x00010134 File Offset: 0x0000E334
			public unsafe static Func<CollectedAttributesProvider.AttributeReference, IAttributeDefinition> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CollectedAttributesProvider.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CollectedAttributesProvider.AttributeReference, IAttributeDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CollectedAttributesProvider.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001227 RID: 4647
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001228 RID: 4648
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04001229 RID: 4649
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400122A RID: 4650
			private static readonly IntPtr NativeMethodInfoPtr__ProvidesAttributes_b__6_0_Internal_IAttributeDefinition_AttributeReference_0;
		}
	}
}
