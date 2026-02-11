using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	// Token: 0x0200023D RID: 573
	public sealed class RendererListParams : ValueType
	{
		// Token: 0x06002630 RID: 9776 RVA: 0x000A2100 File Offset: 0x000A0300
		// Note: this type is marked as 'beforefieldinit'.
		static RendererListParams()
		{
			Il2CppClassPointerStore<RendererListParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RendererListParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr);
			RendererListParams.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "Invalid");
			RendererListParams.NativeFieldInfoPtr_cullingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "cullingResults");
			RendererListParams.NativeFieldInfoPtr_drawSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "drawSettings");
			RendererListParams.NativeFieldInfoPtr_filteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "filteringSettings");
			RendererListParams.NativeFieldInfoPtr_tagName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "tagName");
			RendererListParams.NativeFieldInfoPtr_isPassTagName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "isPassTagName");
			RendererListParams.NativeFieldInfoPtr_tagValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "tagValues");
			RendererListParams.NativeFieldInfoPtr_stateBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "stateBlocks");
			RendererListParams.NativeMethodInfoPtr_get_numStateBlocks_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100668194);
			RendererListParams.NativeMethodInfoPtr_get_stateBlocksPtr_Internal_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100668195);
			RendererListParams.NativeMethodInfoPtr_get_tagsValuePtr_Internal_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100668196);
			RendererListParams.NativeMethodInfoPtr_Dispose_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100668197);
			RendererListParams.NativeMethodInfoPtr_Validate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100668198);
			RendererListParams.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RendererListParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100668199);
			RendererListParams.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100668200);
			RendererListParams.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100668201);
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06002631 RID: 9777 RVA: 0x000A2270 File Offset: 0x000A0470
		public unsafe int numStateBlocks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683795, XrefRangeEnd = 683797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_get_numStateBlocks_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x000A22B4 File Offset: 0x000A04B4
		public unsafe IntPtr stateBlocksPtr
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683805, RefRangeEnd = 683806, XrefRangeStart = 683797, XrefRangeEnd = 683805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_get_stateBlocksPtr_Internal_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06002633 RID: 9779 RVA: 0x000A22F8 File Offset: 0x000A04F8
		public unsafe IntPtr tagsValuePtr
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683814, RefRangeEnd = 683815, XrefRangeStart = 683806, XrefRangeEnd = 683814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_get_tagsValuePtr_Internal_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x000A233C File Offset: 0x000A053C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683829, RefRangeEnd = 683830, XrefRangeStart = 683815, XrefRangeEnd = 683829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_Dispose_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x000A2374 File Offset: 0x000A0574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683839, RefRangeEnd = 683840, XrefRangeStart = 683830, XrefRangeEnd = 683839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_Validate_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000A23AC File Offset: 0x000A05AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683866, RefRangeEnd = 683867, XrefRangeStart = 683840, XrefRangeEnd = 683866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RendererListParams other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RendererListParams_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x000A2404 File Offset: 0x000A0604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683867, XrefRangeEnd = 683873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x000A2458 File Offset: 0x000A0658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683873, XrefRangeEnd = 683888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x0000EF45 File Offset: 0x0000D145
		public RendererListParams(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x0000EF4E File Offset: 0x0000D14E
		public RendererListParams()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr))
		{
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600263B RID: 9787 RVA: 0x000A249C File Offset: 0x000A069C
		// (set) Token: 0x0600263C RID: 9788 RVA: 0x0000EF60 File Offset: 0x0000D160
		public unsafe static RendererListParams Invalid
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(RendererListParams.NativeFieldInfoPtr_Invalid, intPtr);
				return new RendererListParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererListParams.NativeFieldInfoPtr_Invalid, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x0600263D RID: 9789 RVA: 0x000A24D8 File Offset: 0x000A06D8
		// (set) Token: 0x0600263E RID: 9790 RVA: 0x0000EF77 File Offset: 0x0000D177
		public unsafe CullingResults cullingResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_cullingResults);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_cullingResults)) = value;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x0600263F RID: 9791 RVA: 0x000A2500 File Offset: 0x000A0700
		// (set) Token: 0x06002640 RID: 9792 RVA: 0x0000EF92 File Offset: 0x0000D192
		public unsafe DrawingSettings drawSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_drawSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_drawSettings)) = value;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06002641 RID: 9793 RVA: 0x000A2528 File Offset: 0x000A0728
		// (set) Token: 0x06002642 RID: 9794 RVA: 0x0000EFAD File Offset: 0x0000D1AD
		public unsafe FilteringSettings filteringSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_filteringSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_filteringSettings)) = value;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x000A2550 File Offset: 0x000A0750
		// (set) Token: 0x06002644 RID: 9796 RVA: 0x0000EFC8 File Offset: 0x0000D1C8
		public unsafe ShaderTagId tagName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_tagName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_tagName)) = value;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06002645 RID: 9797 RVA: 0x000A2578 File Offset: 0x000A0778
		// (set) Token: 0x06002646 RID: 9798 RVA: 0x0000EFE3 File Offset: 0x0000D1E3
		public unsafe bool isPassTagName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_isPassTagName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_isPassTagName)) = value;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06002647 RID: 9799 RVA: 0x000A25A0 File Offset: 0x000A07A0
		// (set) Token: 0x06002648 RID: 9800 RVA: 0x0000EFFE File Offset: 0x0000D1FE
		public Nullable<Unity.Collections.NativeArray<ShaderTagId>> tagValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_tagValues);
				return new Nullable<Unity.Collections.NativeArray<ShaderTagId>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Unity.Collections.NativeArray<ShaderTagId>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_tagValues), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Unity.Collections.NativeArray<ShaderTagId>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06002649 RID: 9801 RVA: 0x000A25D0 File Offset: 0x000A07D0
		// (set) Token: 0x0600264A RID: 9802 RVA: 0x0000F02C File Offset: 0x0000D22C
		public Nullable<Unity.Collections.NativeArray<RenderStateBlock>> stateBlocks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_stateBlocks);
				return new Nullable<Unity.Collections.NativeArray<RenderStateBlock>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Unity.Collections.NativeArray<RenderStateBlock>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_stateBlocks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Unity.Collections.NativeArray<RenderStateBlock>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x000A2600 File Offset: 0x000A0800
		public static bool operator ==(RendererListParams left, RendererListParams right)
		{
			return left.Equals(right);
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x000A261C File Offset: 0x000A081C
		public static bool operator !=(RendererListParams left, RendererListParams right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0400223E RID: 8766
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x0400223F RID: 8767
		private static readonly IntPtr NativeFieldInfoPtr_cullingResults;

		// Token: 0x04002240 RID: 8768
		private static readonly IntPtr NativeFieldInfoPtr_drawSettings;

		// Token: 0x04002241 RID: 8769
		private static readonly IntPtr NativeFieldInfoPtr_filteringSettings;

		// Token: 0x04002242 RID: 8770
		private static readonly IntPtr NativeFieldInfoPtr_tagName;

		// Token: 0x04002243 RID: 8771
		private static readonly IntPtr NativeFieldInfoPtr_isPassTagName;

		// Token: 0x04002244 RID: 8772
		private static readonly IntPtr NativeFieldInfoPtr_tagValues;

		// Token: 0x04002245 RID: 8773
		private static readonly IntPtr NativeFieldInfoPtr_stateBlocks;

		// Token: 0x04002246 RID: 8774
		private static readonly IntPtr NativeMethodInfoPtr_get_numStateBlocks_Internal_get_Int32_0;

		// Token: 0x04002247 RID: 8775
		private static readonly IntPtr NativeMethodInfoPtr_get_stateBlocksPtr_Internal_get_IntPtr_0;

		// Token: 0x04002248 RID: 8776
		private static readonly IntPtr NativeMethodInfoPtr_get_tagsValuePtr_Internal_get_IntPtr_0;

		// Token: 0x04002249 RID: 8777
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Void_0;

		// Token: 0x0400224A RID: 8778
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Void_0;

		// Token: 0x0400224B RID: 8779
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RendererListParams_0;

		// Token: 0x0400224C RID: 8780
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400224D RID: 8781
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
