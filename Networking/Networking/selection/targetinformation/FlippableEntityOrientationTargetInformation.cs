using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.targetinformation
{
	// Token: 0x0200006E RID: 110
	public class FlippableEntityOrientationTargetInformation : TargetInformation
	{
		// Token: 0x060003A3 RID: 931 RVA: 0x0000F4F4 File Offset: 0x0000D6F4
		// Note: this type is marked as 'beforefieldinit'.
		static FlippableEntityOrientationTargetInformation()
		{
			Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "FlippableEntityOrientationTargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation>.NativeClassPtr);
			FlippableEntityOrientationTargetInformation.NativeFieldInfoPtr_MappedFTs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation>.NativeClassPtr, "MappedFTs");
			FlippableEntityOrientationTargetInformation.NativeMethodInfoPtr_FlippableTargets_Public_List_1_FlippableTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation>.NativeClassPtr, 100663502);
			FlippableEntityOrientationTargetInformation.NativeMethodInfoPtr_get_HasValidTarget_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation>.NativeClassPtr, 100663503);
			FlippableEntityOrientationTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation>.NativeClassPtr, 100663504);
			FlippableEntityOrientationTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation>.NativeClassPtr, 100663505);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000F588 File Offset: 0x0000D788
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1194302, RefRangeEnd = 1194305, XrefRangeStart = 1194281, XrefRangeEnd = 1194302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<FlippableTarget> FlippableTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlippableEntityOrientationTargetInformation.NativeMethodInfoPtr_FlippableTargets_Public_List_1_FlippableTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FlippableTarget>>(intPtr3) : null;
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0000F5C8 File Offset: 0x0000D7C8
		public unsafe virtual bool HasValidTarget
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194305, XrefRangeEnd = 1194309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlippableEntityOrientationTargetInformation.NativeMethodInfoPtr_get_HasValidTarget_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000F604 File Offset: 0x0000D804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194309, XrefRangeEnd = 1194319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlippableEntityOrientationTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000F648 File Offset: 0x0000D848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194319, XrefRangeEnd = 1194327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlippableEntityOrientationTargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlippableEntityOrientationTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00004548 File Offset: 0x00002748
		public FlippableEntityOrientationTargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0000F684 File Offset: 0x0000D884
		// (set) Token: 0x060003AA RID: 938 RVA: 0x00004551 File Offset: 0x00002751
		public unsafe Dictionary<EntityID, List<FlippableOrientation>> MappedFTs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlippableEntityOrientationTargetInformation.NativeFieldInfoPtr_MappedFTs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, List<FlippableOrientation>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlippableEntityOrientationTargetInformation.NativeFieldInfoPtr_MappedFTs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr_MappedFTs;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_FlippableTargets_Public_List_1_FlippableTarget_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValidTarget_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C7 RID: 199
		[ObfuscatedName("Networking.selection.targetinformation.FlippableEntityOrientationTargetInformation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000676 RID: 1654 RVA: 0x00016DE0 File Offset: 0x00014FE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation.__c>.NativeClassPtr);
				FlippableEntityOrientationTargetInformation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation.__c>.NativeClassPtr, "<>9");
				FlippableEntityOrientationTargetInformation.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation.__c>.NativeClassPtr, "<>9__1_0");
				FlippableEntityOrientationTargetInformation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation.__c>.NativeClassPtr, 100663507);
				FlippableEntityOrientationTargetInformation.__c.NativeMethodInfoPtr__FlippableTargets_b__1_0_Internal_IEnumerable_1_FlippableTarget_KeyValuePair_2_EntityID_List_1_FlippableOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation.__c>.NativeClassPtr, 100663508);
			}

			// Token: 0x06000677 RID: 1655 RVA: 0x00016E5C File Offset: 0x0001505C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlippableEntityOrientationTargetInformation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000678 RID: 1656 RVA: 0x00016E98 File Offset: 0x00015098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194259, XrefRangeEnd = 1194275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<FlippableTarget> _FlippableTargets_b__1_0(KeyValuePair<EntityID, List<FlippableOrientation>> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlippableEntityOrientationTargetInformation.__c.NativeMethodInfoPtr__FlippableTargets_b__1_0_Internal_IEnumerable_1_FlippableTarget_KeyValuePair_2_EntityID_List_1_FlippableOrientation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FlippableTarget>>(intPtr3) : null;
				}
			}

			// Token: 0x06000679 RID: 1657 RVA: 0x00006052 File Offset: 0x00004252
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001DF RID: 479
			// (get) Token: 0x0600067A RID: 1658 RVA: 0x00016EF0 File Offset: 0x000150F0
			// (set) Token: 0x0600067B RID: 1659 RVA: 0x0000605B File Offset: 0x0000425B
			public unsafe static FlippableEntityOrientationTargetInformation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlippableEntityOrientationTargetInformation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlippableEntityOrientationTargetInformation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlippableEntityOrientationTargetInformation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001E0 RID: 480
			// (get) Token: 0x0600067C RID: 1660 RVA: 0x00016F18 File Offset: 0x00015118
			// (set) Token: 0x0600067D RID: 1661 RVA: 0x0000606D File Offset: 0x0000426D
			public unsafe static Func<KeyValuePair<EntityID, List<FlippableOrientation>>, IEnumerable<FlippableTarget>> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlippableEntityOrientationTargetInformation.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, List<FlippableOrientation>>, IEnumerable<FlippableTarget>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlippableEntityOrientationTargetInformation.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400035B RID: 859
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400035C RID: 860
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x0400035D RID: 861
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400035E RID: 862
			private static readonly IntPtr NativeMethodInfoPtr__FlippableTargets_b__1_0_Internal_IEnumerable_1_FlippableTarget_KeyValuePair_2_EntityID_List_1_FlippableOrientation_0;
		}

		// Token: 0x020000C8 RID: 200
		[ObfuscatedName("Networking.selection.targetinformation.FlippableEntityOrientationTargetInformation+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600067E RID: 1662 RVA: 0x00016F40 File Offset: 0x00015140
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation.__c__DisplayClass1_0>.NativeClassPtr);
				FlippableEntityOrientationTargetInformation.__c__DisplayClass1_0.NativeFieldInfoPtr_kvp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation.__c__DisplayClass1_0>.NativeClassPtr, "kvp");
				FlippableEntityOrientationTargetInformation.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation.__c__DisplayClass1_0>.NativeClassPtr, 100663509);
				FlippableEntityOrientationTargetInformation.__c__DisplayClass1_0.NativeMethodInfoPtr__FlippableTargets_b__1_Internal_FlippableTarget_FlippableOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation.__c__DisplayClass1_0>.NativeClassPtr, 100663510);
			}

			// Token: 0x0600067F RID: 1663 RVA: 0x00016FA8 File Offset: 0x000151A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlippableEntityOrientationTargetInformation.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlippableEntityOrientationTargetInformation.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000680 RID: 1664 RVA: 0x00016FE4 File Offset: 0x000151E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194275, XrefRangeEnd = 1194281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FlippableTarget _FlippableTargets_b__1(FlippableOrientation fo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(fo);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlippableEntityOrientationTargetInformation.__c__DisplayClass1_0.NativeMethodInfoPtr__FlippableTargets_b__1_Internal_FlippableTarget_FlippableOrientation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<FlippableTarget>(intPtr3) : null;
				}
			}

			// Token: 0x06000681 RID: 1665 RVA: 0x0000607F File Offset: 0x0000427F
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001E1 RID: 481
			// (get) Token: 0x06000682 RID: 1666 RVA: 0x00017034 File Offset: 0x00015234
			// (set) Token: 0x06000683 RID: 1667 RVA: 0x00006088 File Offset: 0x00004288
			public KeyValuePair<EntityID, List<FlippableOrientation>> kvp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlippableEntityOrientationTargetInformation.__c__DisplayClass1_0.NativeFieldInfoPtr_kvp);
					return new KeyValuePair<EntityID, List<FlippableOrientation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<EntityID, List<FlippableOrientation>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlippableEntityOrientationTargetInformation.__c__DisplayClass1_0.NativeFieldInfoPtr_kvp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<EntityID, List<FlippableOrientation>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400035F RID: 863
			private static readonly IntPtr NativeFieldInfoPtr_kvp;

			// Token: 0x04000360 RID: 864
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000361 RID: 865
			private static readonly IntPtr NativeMethodInfoPtr__FlippableTargets_b__1_Internal_FlippableTarget_FlippableOrientation_0;
		}
	}
}
