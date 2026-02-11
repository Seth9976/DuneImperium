using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000C3 RID: 195
	public sealed class LabelScopeInfo : Object
	{
		// Token: 0x06000B8B RID: 2955 RVA: 0x000407E8 File Offset: 0x0003E9E8
		// Note: this type is marked as 'beforefieldinit'.
		static LabelScopeInfo()
		{
			Il2CppClassPointerStore<LabelScopeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "LabelScopeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabelScopeInfo>.NativeClassPtr);
			LabelScopeInfo.NativeFieldInfoPtr__labels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelScopeInfo>.NativeClassPtr, "_labels");
			LabelScopeInfo.NativeFieldInfoPtr_Kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelScopeInfo>.NativeClassPtr, "Kind");
			LabelScopeInfo.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelScopeInfo>.NativeClassPtr, "Parent");
			LabelScopeInfo.NativeMethodInfoPtr__ctor_Internal_Void_LabelScopeInfo_LabelScopeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelScopeInfo>.NativeClassPtr, 100665437);
			LabelScopeInfo.NativeMethodInfoPtr_get_CanJumpInto_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelScopeInfo>.NativeClassPtr, 100665438);
			LabelScopeInfo.NativeMethodInfoPtr_ContainsTarget_Internal_Boolean_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelScopeInfo>.NativeClassPtr, 100665439);
			LabelScopeInfo.NativeMethodInfoPtr_TryGetLabelInfo_Internal_Boolean_LabelTarget_byref_LabelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelScopeInfo>.NativeClassPtr, 100665440);
			LabelScopeInfo.NativeMethodInfoPtr_AddLabelInfo_Internal_Void_LabelTarget_LabelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelScopeInfo>.NativeClassPtr, 100665441);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000408B8 File Offset: 0x0003EAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019585, XrefRangeEnd = 1019587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabelScopeInfo(LabelScopeInfo parent, LabelScopeKind kind)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabelScopeInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelScopeInfo.NativeMethodInfoPtr__ctor_Internal_Void_LabelScopeInfo_LabelScopeKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00040914 File Offset: 0x0003EB14
		public unsafe bool CanJumpInto
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelScopeInfo.NativeMethodInfoPtr_get_CanJumpInto_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00040950 File Offset: 0x0003EB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019587, XrefRangeEnd = 1019590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsTarget(LabelTarget target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelScopeInfo.NativeMethodInfoPtr_ContainsTarget_Internal_Boolean_LabelTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000409A0 File Offset: 0x0003EBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019590, XrefRangeEnd = 1019594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetLabelInfo(LabelTarget target, out LabelInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LabelScopeInfo.NativeMethodInfoPtr_TryGetLabelInfo_Internal_Boolean_LabelTarget_byref_LabelInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			info = ((intPtr4 == 0) ? null : new LabelInfo(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00040A10 File Offset: 0x0003EC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019594, XrefRangeEnd = 1019605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLabelInfo(LabelTarget target, LabelInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelScopeInfo.NativeMethodInfoPtr_AddLabelInfo_Internal_Void_LabelTarget_LabelInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0000559D File Offset: 0x0000379D
		public LabelScopeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x00040A64 File Offset: 0x0003EC64
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x000055A6 File Offset: 0x000037A6
		public unsafe HybridReferenceDictionary<LabelTarget, LabelInfo> _labels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelScopeInfo.NativeFieldInfoPtr__labels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HybridReferenceDictionary<LabelTarget, LabelInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelScopeInfo.NativeFieldInfoPtr__labels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x00040A94 File Offset: 0x0003EC94
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x000055C5 File Offset: 0x000037C5
		public unsafe LabelScopeKind Kind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelScopeInfo.NativeFieldInfoPtr_Kind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelScopeInfo.NativeFieldInfoPtr_Kind)) = value;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x00040ABC File Offset: 0x0003ECBC
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x000055E0 File Offset: 0x000037E0
		public unsafe LabelScopeInfo Parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelScopeInfo.NativeFieldInfoPtr_Parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabelScopeInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelScopeInfo.NativeFieldInfoPtr_Parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeFieldInfoPtr__labels;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeFieldInfoPtr_Kind;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeFieldInfoPtr_Parent;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LabelScopeInfo_LabelScopeKind_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_get_CanJumpInto_Internal_get_Boolean_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_ContainsTarget_Internal_Boolean_LabelTarget_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_TryGetLabelInfo_Internal_Boolean_LabelTarget_byref_LabelInfo_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_AddLabelInfo_Internal_Void_LabelTarget_LabelInfo_0;
	}
}
