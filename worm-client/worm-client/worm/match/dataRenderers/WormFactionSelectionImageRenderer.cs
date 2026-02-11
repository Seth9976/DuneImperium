using System;
using boardgames.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine.UI;

namespace worm.match.dataRenderers
{
	// Token: 0x02000124 RID: 292
	public class WormFactionSelectionImageRenderer : Observer
	{
		// Token: 0x06000D5B RID: 3419 RVA: 0x00040898 File Offset: 0x0003EA98
		// Note: this type is marked as 'beforefieldinit'.
		static WormFactionSelectionImageRenderer()
		{
			Il2CppClassPointerStore<WormFactionSelectionImageRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormFactionSelectionImageRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionSelectionImageRenderer>.NativeClassPtr);
			WormFactionSelectionImageRenderer.NativeFieldInfoPtr_atlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionSelectionImageRenderer>.NativeClassPtr, "atlasName");
			WormFactionSelectionImageRenderer.NativeFieldInfoPtr_spriteNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionSelectionImageRenderer>.NativeClassPtr, "spriteNameFormat");
			WormFactionSelectionImageRenderer.NativeFieldInfoPtr_influenceDeltaPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionSelectionImageRenderer>.NativeClassPtr, "influenceDeltaPairs");
			WormFactionSelectionImageRenderer.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionSelectionImageRenderer>.NativeClassPtr, "selectionResponder");
			WormFactionSelectionImageRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionSelectionImageRenderer>.NativeClassPtr, "image");
			WormFactionSelectionImageRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionSelectionImageRenderer>.NativeClassPtr, 100665123);
			WormFactionSelectionImageRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionSelectionImageRenderer>.NativeClassPtr, 100665124);
			WormFactionSelectionImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionSelectionImageRenderer>.NativeClassPtr, 100665125);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00040968 File Offset: 0x0003EB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705542, XrefRangeEnd = 705550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionSelectionImageRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x000409A4 File Offset: 0x0003EBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705550, XrefRangeEnd = 705604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionSelectionImageRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x000409E0 File Offset: 0x0003EBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705604, XrefRangeEnd = 705617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionSelectionImageRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionSelectionImageRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionSelectionImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00009117 File Offset: 0x00007317
		public WormFactionSelectionImageRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x00040A1C File Offset: 0x0003EC1C
		// (set) Token: 0x06000D61 RID: 3425 RVA: 0x00009120 File Offset: 0x00007320
		public unsafe string atlasName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.NativeFieldInfoPtr_atlasName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.NativeFieldInfoPtr_atlasName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x00040A44 File Offset: 0x0003EC44
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x0000913F File Offset: 0x0000733F
		public unsafe string spriteNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.NativeFieldInfoPtr_spriteNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.NativeFieldInfoPtr_spriteNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x00040A6C File Offset: 0x0003EC6C
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x0000915E File Offset: 0x0000735E
		public unsafe Il2CppReferenceArray<WormFactionSelectionImageRenderer.InfluenceDeltaPair> influenceDeltaPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.NativeFieldInfoPtr_influenceDeltaPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormFactionSelectionImageRenderer.InfluenceDeltaPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.NativeFieldInfoPtr_influenceDeltaPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00040A9C File Offset: 0x0003EC9C
		// (set) Token: 0x06000D67 RID: 3431 RVA: 0x0000917D File Offset: 0x0000737D
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00040ACC File Offset: 0x0003ECCC
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x0000919C File Offset: 0x0000739C
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeFieldInfoPtr_atlasName;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameFormat;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeFieldInfoPtr_influenceDeltaPairs;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000383 RID: 899
		[Serializable]
		public sealed class InfluenceDeltaPair : ValueType
		{
			// Token: 0x06002434 RID: 9268 RVA: 0x00085B28 File Offset: 0x00083D28
			// Note: this type is marked as 'beforefieldinit'.
			static InfluenceDeltaPair()
			{
				Il2CppClassPointerStore<WormFactionSelectionImageRenderer.InfluenceDeltaPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormFactionSelectionImageRenderer>.NativeClassPtr, "InfluenceDeltaPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionSelectionImageRenderer.InfluenceDeltaPair>.NativeClassPtr);
				WormFactionSelectionImageRenderer.InfluenceDeltaPair.NativeFieldInfoPtr_delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionSelectionImageRenderer.InfluenceDeltaPair>.NativeClassPtr, "delta");
				WormFactionSelectionImageRenderer.InfluenceDeltaPair.NativeFieldInfoPtr_nameSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionSelectionImageRenderer.InfluenceDeltaPair>.NativeClassPtr, "nameSuffix");
			}

			// Token: 0x06002435 RID: 9269 RVA: 0x00014331 File Offset: 0x00012531
			public InfluenceDeltaPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002436 RID: 9270 RVA: 0x0001433A File Offset: 0x0001253A
			public InfluenceDeltaPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionSelectionImageRenderer.InfluenceDeltaPair>.NativeClassPtr))
			{
			}

			// Token: 0x17000A06 RID: 2566
			// (get) Token: 0x06002437 RID: 9271 RVA: 0x00085B7C File Offset: 0x00083D7C
			// (set) Token: 0x06002438 RID: 9272 RVA: 0x0001434C File Offset: 0x0001254C
			public unsafe int delta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.InfluenceDeltaPair.NativeFieldInfoPtr_delta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.InfluenceDeltaPair.NativeFieldInfoPtr_delta)) = value;
				}
			}

			// Token: 0x17000A07 RID: 2567
			// (get) Token: 0x06002439 RID: 9273 RVA: 0x00085BA4 File Offset: 0x00083DA4
			// (set) Token: 0x0600243A RID: 9274 RVA: 0x00014367 File Offset: 0x00012567
			public unsafe string nameSuffix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.InfluenceDeltaPair.NativeFieldInfoPtr_nameSuffix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.InfluenceDeltaPair.NativeFieldInfoPtr_nameSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040014C2 RID: 5314
			private static readonly IntPtr NativeFieldInfoPtr_delta;

			// Token: 0x040014C3 RID: 5315
			private static readonly IntPtr NativeFieldInfoPtr_nameSuffix;
		}

		// Token: 0x02000384 RID: 900
		[ObfuscatedName("worm.match.dataRenderers.WormFactionSelectionImageRenderer+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600243B RID: 9275 RVA: 0x00085BCC File Offset: 0x00083DCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<WormFactionSelectionImageRenderer.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormFactionSelectionImageRenderer>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionSelectionImageRenderer.__c__DisplayClass7_0>.NativeClassPtr);
				WormFactionSelectionImageRenderer.__c__DisplayClass7_0.NativeFieldInfoPtr_influenceDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionSelectionImageRenderer.__c__DisplayClass7_0>.NativeClassPtr, "influenceDelta");
				WormFactionSelectionImageRenderer.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionSelectionImageRenderer.__c__DisplayClass7_0>.NativeClassPtr, 100665126);
				WormFactionSelectionImageRenderer.__c__DisplayClass7_0.NativeMethodInfoPtr__DirtyUpdate_b__0_Internal_Boolean_InfluenceDeltaPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionSelectionImageRenderer.__c__DisplayClass7_0>.NativeClassPtr, 100665127);
			}

			// Token: 0x0600243C RID: 9276 RVA: 0x00085C34 File Offset: 0x00083E34
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionSelectionImageRenderer.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionSelectionImageRenderer.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600243D RID: 9277 RVA: 0x00085C70 File Offset: 0x00083E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705540, XrefRangeEnd = 705542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DirtyUpdate_b__0(WormFactionSelectionImageRenderer.InfluenceDeltaPair p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionSelectionImageRenderer.__c__DisplayClass7_0.NativeMethodInfoPtr__DirtyUpdate_b__0_Internal_Boolean_InfluenceDeltaPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600243E RID: 9278 RVA: 0x00014386 File Offset: 0x00012586
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A08 RID: 2568
			// (get) Token: 0x0600243F RID: 9279 RVA: 0x00085CC4 File Offset: 0x00083EC4
			// (set) Token: 0x06002440 RID: 9280 RVA: 0x0001438F File Offset: 0x0001258F
			public Nullable<int> influenceDelta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.__c__DisplayClass7_0.NativeFieldInfoPtr_influenceDelta);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionSelectionImageRenderer.__c__DisplayClass7_0.NativeFieldInfoPtr_influenceDelta), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014C4 RID: 5316
			private static readonly IntPtr NativeFieldInfoPtr_influenceDelta;

			// Token: 0x040014C5 RID: 5317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014C6 RID: 5318
			private static readonly IntPtr NativeMethodInfoPtr__DirtyUpdate_b__0_Internal_Boolean_InfluenceDeltaPair_0;
		}
	}
}
